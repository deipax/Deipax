using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTests.Common;

namespace Performance.Cloning
{
	[TestClass]
	public class NullableCloneLogicTests : BaseTest
	{
		[TestMethod]
		public void NullableCloneLogicTests_Int()
		{
			Nullable<int> source = RandGen.GenerateInt();

			var result = TestingHelper.ComparePerformance(source, 25000000, 25000000);

			WriteLine(result.GetReport());
		}

		[TestMethod]
		public void NullableCloneLogicTests_NullInt()
		{
			Nullable<int> source = null;

			var result = TestingHelper.ComparePerformance(source, 50000000, 50000000);

			WriteLine(result.GetReport());
		}

		[TestMethod]
		public void NullableCloneLogicTests_Struct()
		{
			Nullable<HelperStruct1> source = new HelperStruct1()
			{
				PropOne = RandGen.GenerateInt()
			};

			var result = TestingHelper.ComparePerformance(source, 5000000, 5000000);

			WriteLine(result.GetReport());
		}
	}
}