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
using System.Drawing;
namespace Sheng.SailingEase.Controls
{
    public class SEListViewItem
    {
        private SEListViewItemCollection _ownerCollection;
        internal SEListViewItemCollection OwnerCollection
        {
            get { return _ownerCollection; }
            set { _ownerCollection = value; }
        }
        public int Index
        {
            get
            {
                return _ownerCollection.IndexOf(this);
            }
        }
        private ListViewItemState _state = ListViewItemState.None;
        public ListViewItemState State
        {
            get { return _state; }
        }
        public bool Selected
        {
            get
            {
                return (_state & ListViewItemState.Selected) == ListViewItemState.Selected;
            }
            set
            {
                bool selected = Selected;
                if (value)
                    _state = _state | ListViewItemState.Selected;
                else
                    _state = _state ^ ListViewItemState.Selected;
                if (selected != Selected)
                    Render();
            }
        }
        public bool Hovered
        {
            get
            {
                return (_state & ListViewItemState.Hovered) == ListViewItemState.Hovered;
            }
            set
            {
                bool hovered = Hovered;
                if (value)
                    _state = _state | ListViewItemState.Hovered;
                else
                    _state = _state ^ ListViewItemState.Hovered;
                if (hovered != Hovered)
                    Render();
            }
        }
        public bool Focused
        {
            get
            {
                return (_state & ListViewItemState.Focused) == ListViewItemState.Focused;
            }
            set
            {
                bool focused = Focused;
                if (value)
                    _state = _state | ListViewItemState.Focused;
                else
                    _state = _state ^ ListViewItemState.Focused;
                if (focused != Focused)
                    Render();
            }
        }
        private object _value;
        public object Value
        {
            get { return _value; }
        }
        public SEListViewItem(object value)
        {
            _value = value;
        }
        private void Render()
        {
            _ownerCollection.Owner.RenderItem(this);
        }
    }
}
