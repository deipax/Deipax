using Deipax.Core.Conversion;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UnitTests.Core.BaseClasses.Conversion;

namespace UnitTests.Core.Deipax.Conversion
{
    [TestClass]
    public class ConvertTo2_Base<TTo> : BaseConvertTo<TTo>
    {
        protected override TTo ConvertFrom<TFrom>(TFrom from)
        {
            return ConvertTo2<TTo, TFrom>.From(from);
        }
    }
}