﻿/*********************************************        
作者：曹旭升              
QQ：279060597
访问博客了解详细介绍及更多内容：   
http://blog.shengxunwei.com
**********************************************/
using System.Management.Instrumentation;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration.Manageability;
using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling.Configuration.Manageability;
using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling.Logging.Configuration;
using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling.Logging.Configuration.Manageability;
[assembly : Instrumented(@"root\EnterpriseLibrary")]
[assembly : WmiConfiguration(@"root\EnterpriseLibrary", HostingModel = ManagementHostingModel.Decoupled, IdentifyLevel = false)]
[assembly : ConfigurationElementManageabilityProvider(typeof(LoggingExceptionHandlerDataManageabilityProvider), typeof(LoggingExceptionHandlerData), typeof(ExceptionHandlingSettingsManageabilityProvider))]
