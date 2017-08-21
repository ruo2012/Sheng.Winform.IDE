﻿/*********************************************        
作者：曹旭升              
QQ：279060597
访问博客了解详细介绍及更多内容：   
http://blog.shengxunwei.com
**********************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sheng.SailingEase.Kernal;
using System.Windows.Forms;
using Sheng.SailingEase.ComponentModel.Design.Localisation;
namespace Sheng.SailingEase.ComponentModel.Design
{
    public class Unity
    {
        static LocalisationHelper _localisationHelper;
        static Unity()
        {
            _localisationHelper = new LocalisationHelper(Language.Current.ResourceManager);
        }
        public static void ApplyResource(Control control)
        {
            _localisationHelper.ApplyResource(control);
        }
    }
}
