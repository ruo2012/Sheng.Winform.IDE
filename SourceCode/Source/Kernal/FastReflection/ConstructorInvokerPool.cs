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
using System.Reflection;
using System.Diagnostics;
namespace Sheng.SailingEase.Kernal
{
    public class ConstructorInvokerPool : FastReflectionPool<Type[], IConstructorInvoker>
    {
        public ConstructorInvokerPool()
        {
            CustomCompare = true;
        }
        protected override bool Compare(Type[] key1, Type[] key2)
        {
            return key1.SequenceEqual(key2);
        }
        protected override IConstructorInvoker Create(Type type, Type[] key)
        {
            if (type == null || key == null)
            {
                Debug.Assert(false, "type 或 key 为空");
                throw new ArgumentNullException();
            }
            ConstructorInfo constructorInfo = type.GetConstructor(key);
            if (constructorInfo == null)
            {
                Debug.Assert(false, "没有指定的ConstructorInfo");
                throw new InvalidOperationException();
            }
            return new ConstructorInvoker(constructorInfo);
        }
    }
}
