using Deipax.Cloning.Factories;
using Deipax.Cloning.Interfaces;
using System.Collections.Generic;

namespace Deipax.Cloning.Common
{
    public static class CloneDelConfig
    {
        static CloneDelConfig()
        {
            UserFactories = new List<ICloneDelFactory>();
            DefaultFactories = new List<ICloneDelFactory>
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
        }

        public static List<ICloneDelFactory> UserFactories { get; private set; }
        internal static List<ICloneDelFactory> DefaultFactories { get; private set; }

        public static CloneDel<T> Get<T>()
        {
            CloneDel<T> cloneDel = null;

            foreach (var factory in UserFactories)
            {
                cloneDel = factory.Get<T>();

                if (cloneDel != null)
                {
                    return cloneDel;
                }
            }

            foreach (var factory in DefaultFactories)
            {
                cloneDel = factory.Get<T>();

                if (cloneDel != null)
                {
                    return cloneDel;
                }
            }

            return cloneDel;
        }
    }
}