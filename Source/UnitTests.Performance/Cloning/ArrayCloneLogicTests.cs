using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTests.Common;

namespace Performance.Cloning
{
	[TestClass]
	public class ArrayCloneLogicTests : BaseTest
	{
		[TestMethod]
		public void ArrayCloneLogicTests_ArrayOfStringArrays()
		{
			string[][] source = new string[][]
			{
				new string [] { "one", "two" },
				new string [] { "three", "four" }
			};

			var result = TestingHelper.ComparePerformance(source, 5000000, 5000000);

			WriteLine(result.GetReport());
		}

		[TestMethod]
		public void ArrayCloneLogicTests_ArrayOfClasses()
		{
			Helper1[] source = new Helper1[100];

			for (int i = 0; i < source.Length; i++)
			{
				source[i] = new Helper1()
				{
					PropOne = RandGen.GenerateInt()
				};
			}

			var result = TestingHelper.ComparePerformance(source, 20000, 20000);

			WriteLine(result.GetReport());
		}

		[TestMethod]
		public void ArrayCloneLogicTests_ArrayOfStruct()
		{
			HelperStruct1[] source = new HelperStruct1[100];

			for (int i = 0; i < source.Length; i++)
			{
				source[i] = new HelperStruct1()
				{
					PropOne = RandGen.GenerateInt()
				};
			}

			var result = TestingHelper.ComparePerformance(source, 200000, 200000);

			WriteLine(result.GetReport());
		}
	}
}