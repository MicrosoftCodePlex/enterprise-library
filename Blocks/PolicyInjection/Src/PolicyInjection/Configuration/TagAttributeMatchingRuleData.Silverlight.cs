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
    /// A class that stores configuration information for
    /// an instance of <see cref="TagAttributeMatchingRule"/>.
    /// </summary>
    public partial class TagAttributeMatchingRuleData
    {
        /// <summary>
        /// Constructs a new <see cref="TagAttributeMatchingRuleData"/> instance.
        /// </summary>
        public TagAttributeMatchingRuleData()
        {
        }

        /// <summary>
        /// Constructs a new <see cref="TagAttributeMatchingRuleData"/> instance.
        /// </summary>
        /// <param name="matchingRuleName">Matching rule instance name in configuration.</param>
        /// <param name="tagToMatch">Tag string to match.</param>
        public TagAttributeMatchingRuleData(string matchingRuleName, string tagToMatch)
            : base(matchingRuleName, tagToMatch)
        {
        }

        /// <summary>
        /// The pattern to match.
        /// </summary>
        public override string Match
        {
            get;
            set;
        }
    }
}
