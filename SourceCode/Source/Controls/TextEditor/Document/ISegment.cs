﻿/*********************************************        
作者：曹旭升              
QQ：279060597
访问博客了解详细介绍及更多内容：   
http://blog.shengxunwei.com
**********************************************/
namespace Sheng.SailingEase.Controls.TextEditor.Document
{
	public interface ISegment
	{
		int Offset {
			get;
			set;
		}
		int Length {
			get;
			set;
		}
	}
}
