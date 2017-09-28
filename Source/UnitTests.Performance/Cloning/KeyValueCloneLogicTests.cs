using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTests.Common;

namespace Performance.Cloning
{
	[TestClass]
	public class KeyValueCloneLogicTests : BaseTest
	{
		[TestMethod]
		public void KeyValueCloneLogicTests_Primitives()
		{
			var source = new KeyValuePair<int, string>(10, "test");

			var result = TestingHelper.ComparePerformance(source, 10000000, 10000000);

			WriteLine(result.GetReport());
		}

		[TestMethod]
		public void KeyValueCloneLogicTests_Class()
		{
			var source = new KeyValuePair<Helper1, Helper1>(
				new Helper1() { PropOne = 1 },
				new Helper1() { PropOne = 2 });

			var result = TestingHelper.ComparePerformance(source, 1500000, 1500000);

			WriteLine(result.GetReport());
		}

		[TestMethod]
		public void KeyValueCloneLogicTests_Struct()
		{
			var source = new KeyValuePair<HelperStruct1, HelperStruct1>(
				new HelperStruct1() { PropOne = 1 },
				new HelperStruct1() { PropOne = 2 });

			var result = TestingHelper.ComparePerformance(source, 5000000, 5000000);

			WriteLine(result.GetReport());
		}

		[TestMethod]
		public void KeyValueCloneLogicTests_Null()
		{
			var source = new KeyValuePair<Helper1, Helper1>(null, null);

			var result = TestingHelper.ComparePerformance(source, 10000000, 10000000);

			WriteLine(result.GetReport());
		}
	}
}