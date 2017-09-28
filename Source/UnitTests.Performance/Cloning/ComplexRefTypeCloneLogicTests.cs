using Deipax.Cloning.Common;
using Deipax.Cloning.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using UnitTests.Common;

namespace Performance.Cloning
{
	[TestClass]
	public class ComplexRefTypeCloneLogicTests : BaseTest
	{
		[TestMethod]
		public void ComplexRefTypeCloneLogicTests_SimpleClass()
		{
			Helper1 source = new Helper1()
			{
				PropOne = RandGen.GenerateInt(),
				PropTwo = RandGen.GenerateInt(),
				PropThree = RandGen.GenerateInt(),
			};

			var result = TestingHelper.ComparePerformance(source, 3000000, 3000000);

			WriteLine(result.GetReport());
		}

		[TestMethod]
		public void ComplexRefTypeCloneLogicTests_ComplexClass()
		{
			Helper2 source = new Helper2()
			{
				Helper = new Helper1()
				{
					PropOne = RandGen.GenerateInt(),
					PropTwo = RandGen.GenerateInt(),
					PropThree = RandGen.GenerateInt(),
					PropFour = RandGen.GenerateInt(),
					PropFive = RandGen.GenerateInt(),
					PropSix = RandGen.GenerateInt(),
					PropSeven = RandGen.GenerateInt(),
					PropEight = RandGen.GenerateInt(),
					PropNine = RandGen.GenerateInt(),
					PropTen = RandGen.GenerateInt()
				}
			};

			var result = TestingHelper.ComparePerformance(source, 3000000, 3000000);

			WriteLine(result.GetReport());
		}

		[TestMethod]
		public void ComplexRefTypeCloneLogicTests_InheritList_Class()
		{
			var source = new Helper3<Helper1>()
			{
				PropOne = RandGen.GenerateInt()
			};

			for (int i = 0; i < 1000000; i++)
			{
				source.Add(new Helper1()
				{
					PropOne = RandGen.GenerateInt()
				});
			};

			var result = TestingHelper.ComparePerformance(source, 1, 1);

			WriteLine(result.GetReport());
		}

		[TestMethod]
		public void ComplexRefTypeCloneLogicTests_InheritList_Int()
		{
			var source = new Helper3<int>();

			for (int i = 0; i < 30000000; i++)
			{
				source.Add(RandGen.GenerateInt());
			};

			var result = TestingHelper.ComparePerformance(source, 1, 1);

			WriteLine(result.GetReport());
		}

		[TestMethod]
		public void ComplexRefTypeCloneLogicTests_Null()
		{
			Helper1 source = null;

			var result = TestingHelper.ComparePerformance(source, 30000000, 30000000);

			WriteLine(result.GetReport());
		}

		[TestMethod]
		public void ComplexRefTypeCloneLogicTests_GrandChildClass()
		{
			GrandChildClass source = TestingHelper.GetRandomGrandChild();

			var result = TestingHelper.ComparePerformance(source, 1500000, 1500000);

			WriteLine(result.GetReport());
		}

		[TestMethod]
		public void ComplexRefTypeCloneLogicTests_List_SimpleClasses()
		{
			List<Helper1> source = new List<Helper1>();

			for (int i = 0; i < 1000000; i++)
			{
				source.Add(new Helper1()
				{
					PropOne = RandGen.GenerateInt(),
					PropTwo = RandGen.GenerateInt(),
					PropThree = RandGen.GenerateInt(),
				});
			}

			var result = TestingHelper.ComparePerformance(source, 1, 1);

			WriteLine(result.GetReport());
		}

		[TestMethod]
		public void ComplexRefTypeCloneLogicTests_List_ComplexClasses()
		{
			List<Helper2> source = new List<Helper2>();

			for (int i = 0; i < 2000000; i++)
			{
				source.Add(new Helper2()
				{
					Helper = new Helper1()
					{
						PropOne = RandGen.GenerateInt(),
						PropTwo = RandGen.GenerateInt(),
						PropThree = RandGen.GenerateInt(),
					}
				});
			}

			var result = TestingHelper.ComparePerformance(source, 1, 1);

			WriteLine(result.GetReport());
		}

		[TestMethod]
		public void ComplexRefTypeCloneLogicTests_List_Interfaces()
		{
			List<MyTmpInterface> source = new List<MyTmpInterface>();

			for (int i = 0; i < 1000000; i++)
			{
				source.Add(new Helper1());
				source.Add(new Helper1_1());
			}

			var result = TimingHelper.GetPerformance(1, () => source.GetClone());

			WriteLine(result.GetReport());
		}

		[TestMethod]
		public void ComplexRefTypeCloneLogicTests_List_SimpleStructs()
		{
			List<HelperStruct1> source = new List<HelperStruct1>();

			for (int i = 0; i < 2000000; i++)
			{
				source.Add(new HelperStruct1()
				{
					PropOne = RandGen.GenerateInt(),
					PropTwo = RandGen.GenerateInt(),
					PropThree = RandGen.GenerateInt(),
				});
			}

			var result = TestingHelper.ComparePerformance(source, 1, 1);

			WriteLine(result.GetReport());
		}

		[TestMethod]
		public void ComplexRefTypeCloneLogicTests_List_ComplexStructs()
		{
			List<HelperStruct2> source = new List<HelperStruct2>();

			for (int i = 0; i < 1000000; i++)
			{
				source.Add(new HelperStruct2()
				{
					Helper = new HelperStruct1()
					{
						PropOne = RandGen.GenerateInt(),
						PropTwo = RandGen.GenerateInt(),
						PropThree = RandGen.GenerateInt(),
					}
				});
			}

			var result = TestingHelper.ComparePerformance(source, 1, 1);

			WriteLine(result.GetReport());
		}

		[TestMethod]
		public void ComplexRefTypeCloneLogicTests_DictionaryOfStructs()
		{
			Dictionary<HelperStruct1, HelperStruct1> source = new Dictionary<HelperStruct1, HelperStruct1>();

			for (int i = 0; i < 300000; i++)
			{
				source.Add(
				new HelperStruct1()
				{
					PropOne = RandGen.GenerateInt(),
					PropTwo = RandGen.GenerateInt(),
					PropThree = RandGen.GenerateInt()
				},
				new HelperStruct1()
				{
					PropOne = RandGen.GenerateInt(),
					PropTwo = RandGen.GenerateInt(),
					PropThree = RandGen.GenerateInt()
				});
			}

			var result = TestingHelper.ComparePerformance(source, 1, 1);

			WriteLine(result.GetReport());
		}

		[TestMethod]
		public void ComplexRefTypeCloneLogicTests_DictionaryOfClasses()
		{
			Dictionary<Helper1, Helper1> source = new Dictionary<Helper1, Helper1>();

			for (int i = 0; i < 300000; i++)
			{
				source.Add(
				new Helper1()
				{
					PropOne = RandGen.GenerateInt(),
					PropTwo = RandGen.GenerateInt(),
					PropThree = RandGen.GenerateInt()
				},
				new Helper1()
				{
					PropOne = RandGen.GenerateInt(),
					PropTwo = RandGen.GenerateInt(),
					PropThree = RandGen.GenerateInt()
				});
			}

			var result = TestingHelper.ComparePerformance(source, 1, 1);

			WriteLine(result.GetReport());
		}

		[TestMethod]
		public void ComplexRefTypeCloneLogicTests_DictionaryOfPrimitives()
		{
			Dictionary<int, int> source = new Dictionary<int, int>();

			for (int i = 0; i < 5000000; i++)
			{
				source.Add(i, RandGen.GenerateInt());
			}

			var result = TestingHelper.ComparePerformance(source, 1, 1);

			WriteLine(result.GetReport());
		}

		[TestMethod]
		public void ComplexRefTypeCloneLogicTests_Concrete_Versus_Abstract()
		{
			List<Helper1> concreteSource = new List<Helper1>();

			for (int i = 0; i < 1000000; i++)
			{
				concreteSource.Add(new Helper1()
				{
					PropOne = RandGen.GenerateInt(),
					PropTwo = RandGen.GenerateInt(),
					PropThree = RandGen.GenerateInt()
				});
			}

			IReadOnlyList<MyTmpInterface> abstractSource = concreteSource
				.OfType<MyTmpInterface>()
				.ToList();

			var result = TimingHelper.ComparePerformance(
				1,
				1,
				() => concreteSource.GetClone(),
				() => abstractSource.GetClone());

			WriteLine(result.GetReport());
		}

		[TestMethod]
		public void ComplexRefTypeCloneLogicTests_List_CastedAsObjects()
		{
			List<object> source = new List<object>();

			for (int i = 0; i < 400000; i++)
			{
				source.Add(RandGen.GenerateInt());
				source.Add(RandGen.GenerateString(10));
				source.Add(RandGen.GenerateByteArray(10));
				source.Add(RandGen.GenerateStringList(10, 10));
			}

			var result = TimingHelper.GetPerformance(
				1,
				() => source.GetClone());

			WriteLine(result.GetReport());
		}
	}
}