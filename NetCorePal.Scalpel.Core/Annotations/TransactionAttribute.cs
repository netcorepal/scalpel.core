using System;

namespace NetCorePal.Scalpel.Annotations
{
    /// <summary>
    /// 表示方法需要事物
    /// </summary>
    [AttributeUsage(AttributeTargets.Method)]
    public class TransactionAttribute : Attribute
    {
    }
}
