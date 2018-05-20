using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq.Expressions;
using System.Reflection;

namespace Deipax.DataAccess.Common
{
    public class DynamicDictionary<T> : DynamicObject, IDictionary<string, T>
    {
        public DynamicDictionary()
        {
        }

        #region Field Members
        private IDictionary<string, T> _items = new Dictionary<string, T>(StringComparer.Ordinal);
        #endregion

        #region Public Members
        public override bool TryGetIndex(GetIndexBinder b, object[] i, out object r)
        {
            r = _items[(string)i[0]];
            return true;
        }

        public sealed override bool TryGetMember(GetMemberBinder b, out object r)
        {
            r = _items[b.Name];
            return true;
        }

        public sealed override bool TrySetMember(SetMemberBinder b, object value)
        {
            _items[b.Name] = (T)value;
            return true;
        }
        #endregion

        #region IDictionary<string, T> Members
        public ICollection<string> Keys
        {
            get
            {
                return _items.Keys;
            }
        }

        public ICollection<T> Values
        {
            get
            {
                return _items.Values;
            }
        }

        public int Count
        {
            get
            {
                return _items.Count;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return _items.IsReadOnly;
            }
        }

        public T this[string key]
        {
            get
            {
                return _items[key];
            }
            set
            {
                _items[key] = value;
            }
        }

        public bool TryGetValue(string key, out T value)
        {
            return _items.TryGetValue(key, out value);
        }

        public bool ContainsKey(string key)
        {
            return _items.ContainsKey(key);
        }

        public void Add(string key, T value)
        {
            _items.Add(key, value);
        }

        public bool Remove(string key)
        {
            return _items.Remove(key);
        }

        public void Add(KeyValuePair<string, T> item)
        {
            _items.Add(item);
        }

        public void Clear()
        {
            _items.Clear();
        }

        public bool Contains(KeyValuePair<string, T> item)
        {
            return _items.Contains(item);
        }

        public void CopyTo(KeyValuePair<string, T>[] array, int arrayIndex)
        {
            _items.CopyTo(array, arrayIndex);
        }

        public bool Remove(KeyValuePair<string, T> item)
        {
            return _items.Remove(item);
        }

        public IEnumerator<KeyValuePair<string, T>> GetEnumerator()
        {
            return _items.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _items.GetEnumerator();
        }
        #endregion
    }

    internal class DictionaryMetaObjectProvider<T> : DynamicMetaObject
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
        private static readonly MethodInfo _getValue = typeof(IDictionary<string, T>)
            .GetProperty("Item")
            .GetGetMethod();

        private static readonly MethodInfo _setValue = typeof(DynamicDictionary<T>)
            .GetMethod("SetValue", new Type[] { typeof(string), typeof(T) });
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
            return CallMethod(
                _setValue,
                Expression,
                LimitType,
                new[] { Expression.Constant(binder.Name) });
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