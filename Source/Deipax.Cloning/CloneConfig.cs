using Deipax.Cloning.Common;
using Deipax.Cloning.Factories;
using Deipax.Cloning.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Deipax.Cloning
{
    public delegate T CloneDel<T>(T source, CopyContext context);

    public static class CloneConfig<T>
    {
        public static Func<T, T> Initializer { get; set; }
        public static CloneDel<T> CloneDel { get; set; }
    }

    public static class CloneConfig
    {
        static CloneConfig()
        {
            _defaults = new List<ICloneDelFactory>
            {
                new DictionaryFactory(),
                new KeyValueFactory(),
                new TupleFactory(),
                new ListDeep(),
                new ListShallow(),
                new NullableShallow(),
                new NullableDeep(),
                new ShallowClone(),
                new ArrayRank1Shallow(),
                new ArrayRank1Deep(),
                new ArrayRank2Shallow(),
                new ArrayRank2Deep(),
                new ArrayRankNShallow(),
                new ArrayRankNDeep(),
                new ComplexRefType(),
                new ComplexValueType(),
                new NotSupported()
            };
            UserFactories = new List<ICloneDelFactory>();
        }

        #region Field Members
        private static IReadOnlyList<ICloneDelFactory> _defaults;
        #endregion

        #region Public Members
        public static IReadOnlyList<ICloneDelFactory> UserFactories { get; set; }

        public static CloneDel<T> Get<T>()
        {
            CloneDel<T> cloneDel = CloneConfig<T>.CloneDel;
            if (cloneDel != null) return cloneDel;

            cloneDel = Get<T>(UserFactories);
            if (cloneDel != null) return cloneDel;

            return Get<T>(_defaults);
        }
        #endregion

        #region Private Members
        private static CloneDel<T> Get<T>(
            IReadOnlyList<ICloneDelFactory> factories)
        {
            return factories?
                .Select(x => x?.Get<T>())
                .FirstOrDefault(x => x != null);
        }
        #endregion
    }
}