using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Core.Deipax.Conversion.ConvertTo
{
    [TestClass]
    public class ConvertTo_Long : ConvertTo_Base<long>
    {
    }

    [TestClass]
    public class ConvertTo_LongNullable : ConvertTo_Base<long?>
    {
    }
}