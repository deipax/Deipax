using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;

namespace Deipax.DataAccess.Common
{
    public static class DynamicType
    {
        #region Field Members
        private static readonly object _lock = new object();

        private static readonly Dictionary<int, Type> _cache =
            new Dictionary<int, Type>();

        private static readonly AssemblyName _aName = new AssemblyName("Deipax.DataAccess.Dynamic");
        private static readonly AssemblyBuilder _ab = AssemblyBuilder.DefineDynamicAssembly(
               _aName,
               AssemblyBuilderAccess.Run);
        private static readonly ModuleBuilder _mb = _ab.DefineDynamicModule(_aName.Name + ".dll");
        #endregion

        public static Type Get(DataReaderCache cache)
        {
            if (!_cache.TryGetValue(cache.GetColumnHash(), out Type value))
            {
                lock (_lock)
                {
                    if (!_cache.TryGetValue(cache.GetColumnHash(), out value))
                    {
                        value = Create(cache);
                        _cache.Add(cache.GetColumnHash(), value);
                    }
                }
            }

            return value;
        }

        #region Private Members
        private static Type Create(DataReaderCache cache)
        {
            TypeBuilder tb = _mb.DefineType(
                $"DynamicType_#{cache.GetColumnHash()}",
                TypeAttributes.Public);

            for (int fieldIndex = 0; fieldIndex < cache.Reader.FieldCount; fieldIndex++)
            {
                tb.DefineField(
                    cache.Reader.GetName(fieldIndex),
                    cache.Reader.GetFieldType(fieldIndex),
                    FieldAttributes.Public);
            }

            return tb.CreateTypeInfo();
        }
        #endregion
    }
}
