using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq.Expressions;
using System.Reflection;

namespace Deipax.DataAccess.Common
{
    public class DynamicDictionary : Dictionary<string, object>, IDynamicMetaObjectProvider
    {
        public DynamicDictionary()
            : base()
        {
        }

        public DynamicDictionary(int capacity)
            : base(capacity)
        {
        }

        #region Public Members
        public object SetValue(string key, object value)
        {
            if (ContainsKey(key))
            {
                return this[key] = value;
            }
            else
            {
                Add(key, value);
                return value;
            }
        }

        public object GetValue(string key)
        {
            object val = default(object);
            TryGetValue(key, out val);
            return val;
        }
        #endregion

        #region IDynamicMetaObjectProvider Members
        public DynamicMetaObject GetMetaObject(Expression parameter)
        {
            return new DictionaryMetaObjectProvider(
                parameter,
                BindingRestrictions.Empty,
                this);
        }
        #endregion

        #region Helpers
        class DictionaryMetaObjectProvider : DynamicMetaObject
        {
            public DictionaryMetaObjectProvider(
                Expression expression,
                BindingRestrictions restrictions)
                : base(expression, restrictions)
            {
            }

            public DictionaryMetaObjectProvider(
                Expression expression,
                BindingRestrictions restrictions,
                object value)
                : base(expression, restrictions, value)
            {
            }

            #region Field Members
            private static readonly MethodInfo _getValue = typeof(DynamicDictionary)
                .GetMethod("GetValue", new Type[] { typeof(string) });

            private static readonly MethodInfo _setValue = typeof(DynamicDictionary)
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
        #endregion
    }
}