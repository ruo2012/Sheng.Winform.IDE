﻿/*********************************************        
作者：曹旭升              
QQ：279060597
访问博客了解详细介绍及更多内容：   
http://blog.shengxunwei.com
**********************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Sheng.SailingEase.ComponentModel.Design;
using Sheng.SailingEase.Components.NavigationComponent.Localisation;
using Sheng.SailingEase.Core;
using Sheng.SailingEase.Infrastructure;
using Sheng.SailingEase.Kernal;
using Sheng.SailingEase.Core.Development;
using Sheng.SailingEase.Localisation;
namespace Sheng.SailingEase.Components.NavigationComponent.View
{
    public partial class ExplorerPropertyView : PadViewBase
    {
        ToolStripArchive _toolStripArchive = ToolStripArchive.Instance;
        MenuStripArchive _menuStripArchive = MenuStripArchive.Instance;
        public ExplorerPropertyView()
        {
            InitializeComponent();
            this.TabText = Language.Current.Explorer_PropertyView_TabText;
            PropertyGridTypeWrapper toolStripPageEntityWrapper = new PropertyGridTypeWrapper(typeof(ToolStripPageEntity))
            {
                ActOnSubClass = true,
                VisibleAll = true,
            };
            toolStripPageEntityWrapper.VisibleException.Add(EntityBase.Property_Remark);
            propertyGrid.AddTypeWrapper(toolStripPageEntityWrapper);
            PropertyGridTypeWrapper toolStripGroupEntityWrapper = new PropertyGridTypeWrapper(typeof(ToolStripGroupEntity))
            {
                ActOnSubClass = true,
                VisibleAll = true
            };
            toolStripGroupEntityWrapper.VisibleException.Add(EntityBase.Property_Remark);
            propertyGrid.AddTypeWrapper(toolStripGroupEntityWrapper);
            PropertyGridValidator toolStripItemValidator = new PropertyGridValidator(typeof(EntityBase))
            {
                ActOnSub = true,
            };
            toolStripItemValidator.Validator = (e) =>
            {
                bool success = true;
                string message = null;
                if (e.Property == EntityBase.Property_Code)
                {
                    if (Keywords.Container(e.Value.ToString()))
                    {
                        success = false;
                        message = CommonLanguage.Current.ValueInefficacyUseKeywords;
                    }
                    else
                    {
                        Debug.Assert(e.Objects.Length == 1, "验证 Code 时对象数目只能是一个");
                        object obj = e.Objects[0];
#if DEBUG
                        Type objType = obj.GetType();
                        if (ReflectionHelper.IsSubOf(objType, typeof(ToolStripItemAbstract)) == false &&
                            ReflectionHelper.IsSubOf(objType, typeof(ToolStripPageEntity)) == false &&
                            ReflectionHelper.IsSubOf(objType, typeof(ToolStripGroupEntity)) == false && 
                             ReflectionHelper.IsSubOf(objType, typeof(MenuEntity)) == false)
                        {
                            Debug.Assert(false, "obj 不是有效的用于菜单或工具栏的对象类型");
                        }
#endif
                        string value = e.Value.ToString();
                        if (_toolStripArchive.CheckExistByCode(value) ||
                            _toolStripArchive.PageExistByCode(value) ||
                            _toolStripArchive.GroupExistByCode(value) ||
                            _menuStripArchive.CheckExistByCode(value))
                        {
                            success = false;
                            message = Language.Current.Explorer_PropertyView_MessageCodeExist;
                        }
                    }
                }
                return new PropertyGridValidateResult(success, message);
            };
            propertyGrid.AddValidator(toolStripItemValidator);
            propertyGrid.PropertyChanged += new PropertyGridPad.OnPropertyChangeHandler(propertyGrid_PropertyChanged);
        }
        void propertyGrid_PropertyChanged(object sender, PropertyChangeEventArgs e)
        {
            object obj = e.SelectedObjects[0];
            IPersistence persistence = obj as IPersistence;
            Debug.Assert(persistence != null, "没有实现 IPersistence");
            if (persistence != null)
                persistence.Save();
        }
        public void SetSelectedObject(object obj)
        {
            propertyGrid.SelectedObjects = new object[] { obj };
        }
    }
}
