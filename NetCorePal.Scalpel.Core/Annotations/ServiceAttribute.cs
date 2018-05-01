using System;

namespace NetCorePal.Scalpel.Annotations
{
    /// <summary>
    /// 表示一个服务
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface)]
    public class ServiceAttribute : Attribute
    {
    }
}
