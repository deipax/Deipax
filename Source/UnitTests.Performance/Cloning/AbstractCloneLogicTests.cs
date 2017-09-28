using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTests.Common;

namespace Performance.Cloning
{
	[TestClass]
	public class AbstractCloneLogicTests : BaseTest
	{
		[TestMethod]
		public void AbstractCloneLogicTests_IRealOnlyList_String()
		{
			IReadOnlyList<string> source = RandGen.GenerateStringList(1000, 5);
			var result = TestingHelper.ComparePerformance2(source, 1000000, 1000000);
			WriteLine(result.GetReport());
		}

		[TestMethod]
		public void AbstractCloneLogicTests_GrandChildClass_AsInterface()
		{
			MyInterface source = TestingHelper.GetRandomGrandChild();
			var result = TestingHelper.ComparePerformance2(source, 1500000, 1500000);
			WriteLine(result.GetReport());
		}

		[TestMethod]
		public void AbstractCloneLogicTests_IRealOnlyList_Interface()
		{
			IReadOnlyList<MyTmpInterface> source = new List<MyTmpInterface>()
			{
				new Helper1() { PropOne = RandGen.GenerateInt() },
				new Helper1_1() { PropOne = RandGen.GenerateInt() },
			};

			var result = TestingHelper.ComparePerformance2(source, 1000000, 1000000);

			WriteLine(result.GetReport());
		}
	}
}