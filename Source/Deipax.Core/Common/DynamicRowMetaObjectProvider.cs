using System;
using System.Dynamic;
using System.Linq.Expressions;
using System.Reflection;

namespace Deipax.Core.Common
{
    internal class DynamicRowMetaObjectProvider : DynamicMetaObject
    {
        public DynamicRowMetaObjectProvider(
            Expression expression,
            BindingRestrictions restrictions)
            : base(expression, restrictions)
        {
        }

        public DynamicRowMetaObjectProvider(
            Expression expression,
            BindingRestrictions restrictions,
            DynamicRow row)
            : base(expression, restrictions, row)
        {
        }

        #region Field Members
        private static readonly MethodInfo _getValue = typeof(DynamicRow)
            .GetMethod("GetValue", new Type[] { typeof(string) });

        private static readonly MethodInfo _setValue = typeof(DynamicRow)
            .GetMethod("SetValue", new Type[] { typeof(string), typeof(object) });
        #endregion

        #region Public Members
        public override DynamicMetaObject BindGetMember(
            GetMemberBinder binder)
        {
            return CallMethod(
                _getValue,
                Expression,
                LimitType,
                new[] { Expression.Constant(binder.Name) });
        }

        public override DynamicMetaObject BindSetMember(
            SetMemberBinder binder,
            DynamicMetaObject value)
        {
            Expression convert = Expression.Convert(
                value.Expression,
                typeof(object));

            return CallMethod(
                _setValue,
                Expression,
                LimitType,
                new[] { Expression.Constant(binder.Name), convert });
        }

        public override DynamicMetaObject BindInvokeMember(
            InvokeMemberBinder binder,
            DynamicMetaObject[] args)
        {
            return CallMethod(
                _getValue,
                Expression,
                LimitType,
                new[] { Expression.Constant(binder.Name) });
        }
        #endregion

        #region Private Members
        private static DynamicMetaObject CallMethod(
            MethodInfo method,
            Expression expression,
            Type limitType,
            Expression[] parameters)
        {
            var callExpression = Expression.Call(
                Expression.Convert(expression, limitType),
                method,
                parameters);

            return new DynamicMetaObject(
                callExpression,
                BindingRestrictions.GetTypeRestriction(expression, limitType));
        }
        #endregion
    }
}