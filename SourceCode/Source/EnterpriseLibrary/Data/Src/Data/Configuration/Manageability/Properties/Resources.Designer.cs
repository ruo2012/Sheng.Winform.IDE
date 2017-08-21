﻿/*********************************************        
作者：曹旭升              
QQ：279060597
访问博客了解详细介绍及更多内容：   
http://blog.shengxunwei.com
**********************************************/
namespace Microsoft.Practices.EnterpriseLibrary.Data.Configuration.Manageability.Properties {
    using System;
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        private static global::System.Resources.ResourceManager resourceMan;
        private static global::System.Globalization.CultureInfo resourceCulture;
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Practices.EnterpriseLibrary.Data.Configuration.Manageability.Properties" +
                            ".Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        internal static string ConnectionStringConnectionStringPartName {
            get {
                return ResourceManager.GetString("ConnectionStringConnectionStringPartName", resourceCulture);
            }
        }
        internal static string ConnectionStringPolicyNameTemplate {
            get {
                return ResourceManager.GetString("ConnectionStringPolicyNameTemplate", resourceCulture);
            }
        }
        internal static string ConnectionStringProviderNamePartName {
            get {
                return ResourceManager.GetString("ConnectionStringProviderNamePartName", resourceCulture);
            }
        }
        internal static string ConnectionStringsCategoryName {
            get {
                return ResourceManager.GetString("ConnectionStringsCategoryName", resourceCulture);
            }
        }
        internal static string DatabaseCategoryName {
            get {
                return ResourceManager.GetString("DatabaseCategoryName", resourceCulture);
            }
        }
        internal static string DatabaseSettingsDefaultDatabasePartName {
            get {
                return ResourceManager.GetString("DatabaseSettingsDefaultDatabasePartName", resourceCulture);
            }
        }
        internal static string DatabaseSettingsPolicyName {
            get {
                return ResourceManager.GetString("DatabaseSettingsPolicyName", resourceCulture);
            }
        }
        internal static string OracleConnectionPackagesPartName {
            get {
                return ResourceManager.GetString("OracleConnectionPackagesPartName", resourceCulture);
            }
        }
        internal static string OracleConnectionPolicyNameTemplate {
            get {
                return ResourceManager.GetString("OracleConnectionPolicyNameTemplate", resourceCulture);
            }
        }
        internal static string OracleConnectionsCategoryName {
            get {
                return ResourceManager.GetString("OracleConnectionsCategoryName", resourceCulture);
            }
        }
        internal static string ProviderMappingDatabaseTypePartName {
            get {
                return ResourceManager.GetString("ProviderMappingDatabaseTypePartName", resourceCulture);
            }
        }
        internal static string ProviderMappingPolicyNameTemplate {
            get {
                return ResourceManager.GetString("ProviderMappingPolicyNameTemplate", resourceCulture);
            }
        }
        internal static string ProviderMappingsCategoryName {
            get {
                return ResourceManager.GetString("ProviderMappingsCategoryName", resourceCulture);
            }
        }
    }
}
