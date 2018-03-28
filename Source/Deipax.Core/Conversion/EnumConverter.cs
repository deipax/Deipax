using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using Deipax.Core.Extensions;

namespace Deipax.Core.Conversion
{
    internal static class EnumConverter<T>
    {
        static EnumConverter()
        {
            if (_targetType.IsEnum())
            {
                foreach (var name in Enum.GetNames(_targetType))
                {
                    _enumValues.Add(name, Enum.Parse(_targetType, name));
                }

                foreach (var value in Enum.GetValues(_targetType).Cast<int>())
                {
                    _enumValues.Add(value, Enum.Parse(_targetType, value.ToString()));
                    _enumValues.Add(value.ToString(), Enum.Parse(_targetType, value.ToString()));
                }

                _intconverter = ConvertMap<int>.DefaultFn;

                From = GetToEnumFunc();
            }
        }

        #region Field Members
        private static Type _intType = typeof(int);
        private static Type _stringType = typeof(string);
        private static Type _targetType = typeof(T);
        private static Func<object, int> _intconverter;
        private static Dictionary<object, object> _enumValues = new Dictionary<object, object>();
        #endregion

        #region Public Members
        public static readonly Func<object, T> From;
        #endregion

        #region Private Members
        private static Func<object, T> GetToEnumFunc()
        {
            var delegateType = typeof(Func<object, T>);
            var methodInfo = typeof(EnumConverter<T>)
                .GetRuntimeMethods()
                .Where(x =>
                    x.Name == "GetToEnumFuncHelper" &&
                    x.IsStatic &&
                    x.IsPrivate)
                .FirstOrDefault();

            var genericMethod = methodInfo.MakeGenericMethod(typeof(T));
            return (Func<object, T>)genericMethod.CreateDelegate(delegateType);
        }

        private static TEnum GetToEnumFuncHelper<TEnum>(object source) where TEnum : struct
        {
            object retVal = null;
            var sourceType = source.GetType();

            if (sourceType == _stringType || sourceType == _intType)
            {
                _enumValues.TryGetValue(source, out retVal);
            }
            else
            {
                _enumValues.TryGetValue(_intconverter(source), out retVal);
            }

            return retVal != null ? (TEnum)retVal : default(TEnum);
        }
        #endregion
    }
}