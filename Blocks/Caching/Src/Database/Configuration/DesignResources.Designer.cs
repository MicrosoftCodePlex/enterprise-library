﻿//===============================================================================
// Microsoft patterns & practices Enterprise Library
// Caching Application Block
//===============================================================================
// Copyright © Microsoft Corporation.  All rights reserved.
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY
// OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT
// LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND
// FITNESS FOR A PARTICULAR PURPOSE.
//===============================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.4927
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Practices.EnterpriseLibrary.Caching.Database.Configuration {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class DesignResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal DesignResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Practices.EnterpriseLibrary.Caching.Database.Configuration.DesignResour" +
                            "ces", typeof(DesignResources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Name of the database instance to use for storage of cached data, as configured in the Data Access Application Block..
        /// </summary>
        internal static string DataCacheStorageDataDatabaseInstanceNameDescription {
            get {
                return ResourceManager.GetString("DataCacheStorageDataDatabaseInstanceNameDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Database Instance.
        /// </summary>
        internal static string DataCacheStorageDataDatabaseInstanceNameDisplayName {
            get {
                return ResourceManager.GetString("DataCacheStorageDataDatabaseInstanceNameDisplayName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Stores the cached data in a database configured through the Data Access Application Block..
        /// </summary>
        internal static string DataCacheStorageDataDescription {
            get {
                return ResourceManager.GetString("DataCacheStorageDataDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Data Cache Storage.
        /// </summary>
        internal static string DataCacheStorageDataDisplayName {
            get {
                return ResourceManager.GetString("DataCacheStorageDataDisplayName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The name of the Data Cache Storage provider..
        /// </summary>
        internal static string DataCacheStorageDataNameDescription {
            get {
                return ResourceManager.GetString("DataCacheStorageDataNameDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Name.
        /// </summary>
        internal static string DataCacheStorageDataNameDisplayName {
            get {
                return ResourceManager.GetString("DataCacheStorageDataNameDisplayName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The name of the particular section or partition within the database used to store the cached data. 
        ///This allows different applications to share the same database safely, and prevents different applications accessing the same cached data..
        /// </summary>
        internal static string DataCacheStorageDataPartitionNameDescription {
            get {
                return ResourceManager.GetString("DataCacheStorageDataPartitionNameDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Partition Name.
        /// </summary>
        internal static string DataCacheStorageDataPartitionNameDisplayName {
            get {
                return ResourceManager.GetString("DataCacheStorageDataPartitionNameDisplayName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The name of the Encryption Provider to use for this Database Cache Store..
        /// </summary>
        internal static string DataCacheStorageDataStorageEncryptionDescription {
            get {
                return ResourceManager.GetString("DataCacheStorageDataStorageEncryptionDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Encryption Provider.
        /// </summary>
        internal static string DataCacheStorageDataStorageEncryptionDisplayName {
            get {
                return ResourceManager.GetString("DataCacheStorageDataStorageEncryptionDisplayName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The fully qualified type name of the Database Cache Storage provider..
        /// </summary>
        internal static string DataCacheStorageDataTypeNameDescription {
            get {
                return ResourceManager.GetString("DataCacheStorageDataTypeNameDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Type Name.
        /// </summary>
        internal static string DataCacheStorageDataTypeNameDisplayName {
            get {
                return ResourceManager.GetString("DataCacheStorageDataTypeNameDisplayName", resourceCulture);
            }
        }
    }
}
