﻿using System;
using System.Linq.Expressions;
using System.ServiceModel;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration.ContainerModel;
using Microsoft.Practices.EnterpriseLibrary.Common.Utility;
using Microsoft.Practices.EnterpriseLibrary.Logging.Diagnostics;
using Microsoft.Practices.EnterpriseLibrary.Logging.Service;
using Microsoft.Practices.EnterpriseLibrary.Logging.TraceListeners;

namespace Microsoft.Practices.EnterpriseLibrary.Logging.Configuration
{
    /// <summary>
    /// Configuration for the <see cref="RemoteServiceTraceListener"/>.
    /// </summary>
    public class RemoteServiceTraceListenerData : TraceListenerData
    {
        /// <summary>
        /// Initializes a new instance of <see cref="RemoteServiceTraceListenerData"/>.
        /// </summary>
        public RemoteServiceTraceListenerData()
        {
            this.SubmitInterval = TimeSpan.FromMinutes(1);
            this.MemoryBufferItemsLimit = 100;
        }

        /// <summary>
        /// Gets the creation expression used to produce a <see cref="TypeRegistration"/> during
        /// <see cref="TraceListenerData.GetRegistrations"/>.
        /// </summary>
        /// <returns>A <see cref="Expression"/> that creates a <see cref="RemoteServiceTraceListener"/>.</returns>
        protected override Expression<Func<TraceListener>> GetCreationExpression()
        {
            if (this.SubmitInterval <= TimeSpan.Zero)
                throw new ArgumentException("SubmitInterval");

            if (string.IsNullOrEmpty(EndpointConfigurationName))
                throw new ArgumentException("EndpointConfigurationName");

            // TODO verify if we want to provide default binding config for usability reasons (no need to have a separate ServiceReferences.ClientConfig file)
            var channelFactory = new ChannelFactory<ILoggingService>(this.EndpointConfigurationName);
            return () => new RemoteServiceTraceListener(
                this.SendImmediately,
                () => new LoggingServiceProxy(channelFactory), 
                new RecurringWorkScheduler(this.SubmitInterval),
                new LogEntryMessageStore(this.Name, this.MemoryBufferItemsLimit, this.IsolatedStorageBufferMaxSizeInKilobytes),
                Container.Resolved<IAsyncTracingErrorReporter>(),
                new NetworkStatus());
        }

        /// <summary>
        /// Gets or sets the WCF endpoint configuration name. This configuration must be present in the
        /// ServiceReferences.ClientConfig file of the main application.
        /// </summary>
        public string EndpointConfigurationName { get; set; }

        /// <summary>
        /// Gets or sets the time interval that will be used for submiting the log entries to the server.
        /// </summary>
        public TimeSpan SubmitInterval { get; set; }

        /// <summary>
        /// Gets or sets the maximum amount of items that will be buffered in memory for when there are connectivity issues that prevent the listener from submiting the log entries.
        /// </summary>
        public int MemoryBufferItemsLimit { get; set; }

        /// <summary>
        /// Gets or sets the maximum size in kilobytes to be used when storing entries into the isolated storage as a backup strategy.
        /// </summary>
        public int IsolatedStorageBufferMaxSizeInKilobytes { get; set; }

        /// <summary>
        /// Gets or sets a value indicating if the log entries should be sent shortly after they have been logged, or else 
        /// wait until the <see cref="SubmitInterval"/> interval value has elapsed.
        /// </summary>
        /// <remarks>
        /// Set this value to <see langword="false"/> in order to buffer as many entries as possible during the <see cref="SubmitInterval"/> time,
        /// and have potentially fewer and larger requests to the server.
        /// Set this value to <see langword="true"/> if you prefer to try to submit the entries as soon as possible, potentially sending only one or few log 
        /// entries per server call.
        /// </remarks>
        public bool SendImmediately { get; set; }
    }
}
