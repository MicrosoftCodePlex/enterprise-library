﻿//===============================================================================
// Microsoft patterns & practices Enterprise Library
// Policy Injection Application Block
//===============================================================================
// Copyright © Microsoft Corporation.  All rights reserved.
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY
// OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT
// LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND
// FITNESS FOR A PARTICULAR PURPOSE.
//===============================================================================

using Microsoft.Practices.Unity.InterceptionExtension;

namespace Microsoft.Practices.EnterpriseLibrary.PolicyInjection.Configuration
{
    /// <summary>
    /// Configuration element for the <see cref="AssemblyMatchingRule"/>.
    /// </summary>
    public partial class AssemblyMatchingRuleData
    {
        /// <summary>
        /// Constructs an <see cref="AssemblyMatchingRuleData"/> with default settings.
        /// </summary>
        public AssemblyMatchingRuleData()
            : base()
        {
        }

        /// <summary>
        /// Constructs an <see cref="AssemblyMatchingRuleData"/> instance with the given
        /// rule name and assembly name pattern to match.
        /// </summary>
        /// <param name="matchingRuleName">Name of rule from the configuration file.</param>
        /// <param name="assemblyName">Assembly name to match.</param>
        public AssemblyMatchingRuleData(string matchingRuleName, string assemblyName)
        {
            Name = matchingRuleName;
            Match = assemblyName;
        }

        /// <summary>
        /// The assembly name to match.
        /// </summary>
        /// <value>Assembly name to match.</value>
        public string Match
        {
            get;
            set;
        }
    }
}
