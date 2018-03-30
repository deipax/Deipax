using Deipax.Core.Conversion.Factories;
using Deipax.Core.Interfaces;
using System;
using System.Collections.Generic;

namespace Deipax.Core.Conversion
{
    public static class ConvertConfig
    {
        static ConvertConfig()
        {
            _defaults = new List<IConvertFactory>()
            {
                new NoConvertFactory(),
                new FromStringFactory(),
                new FromNonNullablePrimitive(),
                new FromNullablePrimitive(),
                new FromConvertibleRefType(),
                new FromConvertibleValueType(),
                new DefaultFactory()
            };
        }

        #region Field Members
        private static IReadOnlyList<IConvertFactory> _defaults;
        #endregion

        #region Public Members
        public static IResult<TFrom, TTo> Get<TFrom, TTo>()
        {
            foreach (var factory in _defaults)
            {
                var func = factory.Get<TFrom, TTo>();

                if (func != null)
                {
                    return new Result<TFrom, TTo>()
                    {
                        Factory = factory,
                        Converter = func
                    };
                }
            }

            return null;
        }
        #endregion

        #region Helpers
        class Result<TFrom, TTo> : IResult<TFrom, TTo>
        {
            public IConvertFactory Factory { get; set; }
            public Func<TFrom, TTo> Converter { get; set; }
        }
        #endregion
    }
}