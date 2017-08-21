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
using System.Windows.Forms;
using Sheng.SailingEase.Controls.Extensions;
using System.Drawing;
namespace Sheng.SailingEase.Infrastructure
{
    public interface IWorkbenchService
    {
        Form Form { get; }
        Point ToolStripPanelLocation { get; }
        Point PointToScreen(Point point);
        void Show<T>() where T : IView;
        void Show<T>(object singleKey) where T : IView;
        void Show(IView view);
        void Show(Func<IView> func, object singleKey);
        void CloseView(IView view);
        T GetView<T>() where T : IView;
        void SetStatusMessage(string msg);
        void ActivateToolStrip(ToolStripCodon toolStripCodon);
        void DeactiveToolStrip(ToolStripCodon toolStripCodon);
        void DestroyToolStrip(List<ToolStripCodon> toolStripCodonList);
        void CloseAllViewButThis();
        void CloseAllView();
        void CloseView();
    }
}
