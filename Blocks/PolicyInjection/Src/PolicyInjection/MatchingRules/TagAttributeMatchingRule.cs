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

#if !SILVERLIGHT
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;
using Microsoft.Practices.EnterpriseLibrary.PolicyInjection.Configuration;
#endif

using Microsoft.Practices.EnterpriseLibrary.PolicyInjection.Properties;
using Microsoft.Practices.Unity.InterceptionExtension;

namespace Microsoft.Practices.EnterpriseLibrary.PolicyInjection.MatchingRules
{
    /// <summary>
    /// Placeholder for <see cref="Microsoft.Practices.Unity.InterceptionExtension.TagAttributeMatchingRule"/>.
    /// </summary>
#if !SILVERLIGHT
    [ConfigurationElementType(typeof(TagAttributeMatchingRuleData))]
#endif
    public class TagAttributeMatchingRule : IMatchingRule
    {
        /// <summary>
        /// Tests to see if this rule applies to the given member.
        /// </summary>
        /// <remarks>
        /// This type is available to support the configuration subsystem. Use 
        /// <see cref="Microsoft.Practices.Unity.InterceptionExtension.TagAttributeMatchingRule"/> instead.
        /// </remarks>
        public bool Matches(System.Reflection.MethodBase member)
        {
            throw new System.InvalidOperationException(Resources.PlaceholderRule);
        }
    }
}
