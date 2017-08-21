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
using System.Xml;
using Sheng.SailingEase.Kernal;
namespace Sheng.SailingEase.Core.Development
{
    [Serializable]
    class DataListRefreshDev : DataListRefreshEvent, IEventEditorSupport, ICallEntityMethod, IWarningable
    {
        [NonSerialized]
        private EventEditorAdapterAbstract _editorAdapater;
        [ObjectCompare(Ignore = true)]
        public EventEditorAdapterAbstract EditorAdapter
        {
            get
            {
                if (_editorAdapater == null)
                    _editorAdapater = new DataListRefreshDevEditorAdapter(this);
                return _editorAdapater;
            }
        }
        public static EnumEventDataSource AllowWhereSetDataSourceType
        {
            get
            {
                return (EnumEventDataSource)(EnumEventDataSource.FormElement | EnumEventDataSource.System);
            }
        }
        public static UIElementEntityTypeCollection AllowWhereSetFormElementControlType
        {
            get
            {
                UIElementEntityTypeCollection collection = new UIElementEntityTypeCollection();
                collection.Add(typeof(UIElementTextBoxEntity));
                collection.Add(typeof(UIElementComboBoxEntity));
                return collection;
            }
        }
        public CallUIElementMethodEvent.EnumCallUIElementMethodTargetForm CallEntityMethodObjectForm
        {
            set
            {
                DataListRefreshDevEditorAdapter adapter = _editorAdapater as DataListRefreshDevEditorAdapter;
                switch (value)
                {
                    case CallUIElementMethodEvent.EnumCallUIElementMethodTargetForm.Current:
                        adapter.ParameterPanels.General.ObjectForm = EnumTargetWindow.Current;
                        break;
                    case CallUIElementMethodEvent.EnumCallUIElementMethodTargetForm.Caller:
                        adapter.ParameterPanels.General.ObjectForm = EnumTargetWindow.Caller;
                        break;
                }
            }
        }
        public object CallEntityMethodFormElement
        {
            set
            {
                DataListRefreshDevEditorAdapter adapter = _editorAdapater as DataListRefreshDevEditorAdapter;
                UIElementDataListEntity dataListEntity = value as UIElementDataListEntity;
                if (dataListEntity == null)
                {
                    return;
                }
                adapter.ParameterPanels.General.DataListId = dataListEntity.Id;
                adapter.ParameterPanels.General.DataEntityId = dataListEntity.DataEntityId;
            }
        }
        public string WarningSignName
        {
            get { return this.Name; }
        }
        [NonSerialized]
        private WarningSign _warning;
        [ObjectCompare(Ignore = true)]
        public WarningSign Warning
        {
            get
            {
                if (_warning == null)
                    _warning = new WarningSign(this);
                return _warning;
            }
            set { _warning = value; }
        }
        public void CheckWarning()
        {
            DataListRefreshDevChecker.CheckWarning(this);
        }
    }
}
