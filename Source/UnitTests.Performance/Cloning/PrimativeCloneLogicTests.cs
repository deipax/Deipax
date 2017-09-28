using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTests.Common;

namespace Performance.Cloning
{
	[TestClass]
	public class PrimativeCloneLogicTests : BaseTest
	{
		[TestMethod]
		public void PrimativeCloneLogicTests_Int()
		{
			int source = RandGen.GenerateInt();

			var result = TestingHelper.ComparePerformance(source, 100000000, 100000000);

			WriteLine(result.GetReport());
		}

		[TestMethod]
		public void PrimativeCloneLogicTests_String()
		{
			string source = RandGen.GenerateString(100);

			var result = TestingHelper.ComparePerformance(source, 100000000, 100000000);

			WriteLine(result.GetReport());
		}
	}
}