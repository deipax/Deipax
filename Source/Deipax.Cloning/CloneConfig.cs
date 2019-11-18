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
        #region Field Members
        private static readonly IReadOnlyList<ICloneDelFactory> _defaults = new List<ICloneDelFactory>
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
        #endregion

        #region Public Members
        public static IReadOnlyList<ICloneDelFactory> Factories { get; set; }

        public static ICloneDelResult<T> Get<T>()
        {
            Result<T> result = new Result<T>()
            {
                Func = CloneConfig<T>.CloneDel
            };

            if (result.Func != null) return result;

            result = GetResult<T>(Factories);
            if (result != null) return result;

            return GetResult<T>(_defaults);
        }
        #endregion

        #region Private Members
        private static Result<T> GetResult<T>(
            IReadOnlyList<ICloneDelFactory> factories)
        {
            return factories?
                .Select(x => GetResult<T>(x))
                .FirstOrDefault(x => x != null);
        }

        private static Result<T> GetResult<T>(
            ICloneDelFactory factory)
        {
            var result = factory?.Create<T>();

            if (result != null)
            {
                return new Result<T>()
                {
                    Factory = factory,
                    Func = result,
                };
            }

            return null;
        }
        #endregion

        #region Helpers
        class Result<T> : ICloneDelResult<T>
        {
            public ICloneDelFactory Factory { get; set; }
            public CloneDel<T> Func { get; set; }
        }
        #endregion
    }
}