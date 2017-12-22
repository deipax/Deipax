using Deipax.Cloning.Extensions;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.Serialization;

namespace Deipax.Cloning.Common
{
    internal static class MethodInfos
    {
        static MethodInfos()
        {
            TryGetCopy = typeof(CopyContext).GetMethod("TryGetCopy");
            RecordCopy = GetActionCall((CopyContext ctx) => ctx.RecordCopy(default(object), default(object)));
            ArrayCopy = typeof(Array).GetRuntimeMethod(
                "CopyTo",
                new Type[2] { typeof(Array), typeof(int) });
            GetTypeFromHandle = GetFuncCall(() => Type.GetTypeFromHandle(typeof(Type).TypeHandle));
            GetFuncCall(() => FormatterServices.GetUninitializedObject(typeof(int)));
        }

        #region Public Members
        public static readonly MethodInfo TryGetCopy;
        public static readonly MethodInfo RecordCopy;
        public static readonly MethodInfo ArrayCopy;
        public static readonly MethodInfo GetTypeFromHandle;
        public static readonly MethodInfo GetUninitializedObject;
        #endregion

        #region Private Members
        private static MethodInfo GetActionCall<T>(Expression<Action<T>> expression)
        {
            return (expression.Body as MethodCallExpression)?.Method
                   ?? throw new ArgumentException("Expression type unsupported.");
        }

        private static MethodInfo GetFuncCall<T>(Expression<Func<T>> expression)
        {
            return (expression.Body as MethodCallExpression)?.Method
                   ?? throw new ArgumentException("Expression type unsupported.");
        }
        #endregion
    }
}