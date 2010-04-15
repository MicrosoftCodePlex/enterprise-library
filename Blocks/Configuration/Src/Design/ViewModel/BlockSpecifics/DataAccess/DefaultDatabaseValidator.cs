﻿//===============================================================================
// Microsoft patterns & practices Enterprise Library
// Core
//===============================================================================
// Copyright © Microsoft Corporation.  All rights reserved.
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY
// OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT
// LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND
// FITNESS FOR A PARTICULAR PURPOSE.
//===============================================================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Configuration.Design.Validation;
using Microsoft.Practices.EnterpriseLibrary.Configuration.Design.Properties;

namespace Microsoft.Practices.EnterpriseLibrary.Configuration.Design.ViewModel.BlockSpecifics
{
#pragma warning disable 1591
    /// <summary>
    /// This class supports block-specific configuration design-time and is not
    /// intended to be used directly from your code.
    /// </summary>
    public class DefaultDatabaseValidator : PropertyValidator
    {
        protected override void ValidateCore(Property property, string value, IList<ValidationResult> results)
        {
            var internalValue = (string)property.ConvertFromBindableValue(value);
            if (string.IsNullOrEmpty(internalValue))
            {
                results.Add(new PropertyValidationResult(property, Resources.DatabaseSettingsDoesntHaveDefaultDatabase, true));
            }
        }
    }
#pragma warning restore 1591
}
