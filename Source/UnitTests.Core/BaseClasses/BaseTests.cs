using Deipax.Core.Conversion;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Core.BaseClasses
{
    [TestClass]
    public sealed class BaseTests
    {
        [AssemblyInitialize]
        public static void AssemblyInit(TestContext context)
        {
            ConvertConfig.SafeConvert = true;
        }
    }
}