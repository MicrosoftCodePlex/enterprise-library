﻿using System.IO;
using System.IO.IsolatedStorage;
using Microsoft.Practices.EnterpriseLibrary.Logging.TraceListeners;
using Microsoft.Silverlight.Testing;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Microsoft.Practices.EnterpriseLibrary.Logging.Tests.TraceListeners.IsolatedStorage.given_repository_file_does_not_exist
{
    [TestClass]
    [Tag("IsolatedStorage")]
    public class when_creating_repository_for_available_size : Context
    {
        private IsolatedStorageLogEntryRepository repository;
        private int maxSizeInKilobytes;

        protected override void Act()
        {
            base.Act();

            this.maxSizeInKilobytes = (int)IsolatedStorageFile.GetUserStoreForApplication().AvailableFreeSpace * 9 / 10 / 1024;
            this.repository = new IsolatedStorageLogEntryRepository(this.repositoryName, maxSizeInKilobytes);
        }

        protected override void Teardown()
        {
            this.repository.Dispose();

            base.Teardown();
        }

        [TestMethod]
        public void then_creates_repository_file()
        {
            Assert.IsTrue(
                IsolatedStorageFile.GetUserStoreForApplication().FileExists(Path.Combine("__logging", this.repositoryName)));
        }

        [TestMethod]
        public void then_repository_has_specified_max_sizes()
        {
            Assert.AreEqual(this.maxSizeInKilobytes, this.repository.MaxSizeInKilobytes);
            Assert.AreEqual(this.maxSizeInKilobytes, this.repository.ActualMaxSizeInKilobytes);
        }
    }
}