using System;
using System.Collections.Generic;
using System.Text;

namespace NetCorePal.Scalpel.Annotations
{
    /// <summary>
    /// 表示该类为仓储类
    /// </summary>
    [AttributeUsage(AttributeTargets.Interface | AttributeTargets.Class)]
    public class RepositoryAttribute : Attribute
    {
    }
}
