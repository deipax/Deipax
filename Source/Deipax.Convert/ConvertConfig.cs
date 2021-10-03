using Deipax.Convert.Factories;
using Deipax.Convert.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Deipax.Convert
{
    public static class ConvertConfig
    {
        static ConvertConfig()
        {
            DefaultFactories = new List<IConvertFactory>()
            {
                new NoConvert(),
                new ToEnum(),
                new ToOrFromDBNull(),
                new ToString(),
                new ToBool(),
                new ToChar(),
                new ToByte(),
                new ToSByte(),
                new ToShort(),
                new ToUShort(),
                new ToInt(),
                new ToUInt(),
                new ToLong(),
                new ToULong(),
                new ToFloat(),
                new ToDouble(),
                new ToDecimal(),
                new ToDateTime(),
                new FromEnum(),
                new FromString(),
                new FromIConvertible(),
                new FromObject(),
            };
        }

        #region Field Members
        private static readonly IConvertFactory _defaultFactory = new DefaultFactory();
        #endregion

        #region Public Members
        public static IConvertFactory DefaultFactory { get; set; }
        public static IReadOnlyList<IConvertFactory> Factories { get; set; }
        public static IReadOnlyList<IConvertFactory> DefaultFactories { get; private set; }

        public static IConvertResult<TFrom, TTo> Get<TFrom, TTo>()
        {
            var result = GetResult<TFrom, TTo>(Factories);
            if (result != null) return result;

            result = GetResult<TFrom, TTo>(DefaultFactories);
            if (result != null) return result;

            result = DefaultFactory?.Create<TFrom, TTo>();
            if (result != null) return result;

            return _defaultFactory?.Create<TFrom, TTo>();
        }
        #endregion

        #region Private Members
        private static IConvertResult<TFrom, TTo> GetResult<TFrom, TTo>(
            IReadOnlyList<IConvertFactory> factories)
        {
            return factories?
                .Select(x => x.Create<TFrom, TTo>())
                .FirstOrDefault(x => x != null);
        }
        #endregion
    }
}