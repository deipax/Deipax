using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTests.Common;

namespace Performance.Cloning
{
	[TestClass]
	public class ComplexValueTypeCloneLogicTests : BaseTest
	{
		[TestMethod]
		public void ComplexValueTypeCloneLogicTests_ComplexStruct()
		{
			HelperStruct2 source = new HelperStruct2()
			{
				Helper = new HelperStruct1()
				{
					PropOne = RandGen.GenerateInt(),
					PropTwo = RandGen.GenerateInt(),
					PropThree = RandGen.GenerateInt()
				}
			};

			var result = TestingHelper.ComparePerformance(source, 3000000, 3000000);

			WriteLine(result.GetReport());
		}

		[TestMethod]
		public void ComplexValueTypeCloneLogicTests_SimpleStruct()
		{
			HelperStruct1 source = new HelperStruct1()
			{
				PropOne = RandGen.GenerateInt(),
				PropTwo = RandGen.GenerateInt(),
				PropThree = RandGen.GenerateInt()
			};

			var result = TestingHelper.ComparePerformance(source, 3000000, 3000000);

			WriteLine(result.GetReport());
		}

		[TestMethod]
		public void ComplexValueTypeCloneLogicTests_Null()
		{
			HelperStruct1 source = default(HelperStruct1);

			var result = TestingHelper.ComparePerformance(source, 4000000, 4000000);

			WriteLine(result.GetReport());
		}
	}
}