using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTests.Common;
using System.Collections.Generic;

namespace Performance.Cloning
{
	[TestClass]
	public class TupleCloneLogicTests : BaseTest
	{
		[TestMethod]
		public void TupleCloneLogicTests_Primitives()
		{
			var source = new Tuple<int, string, int, int, int, int, int, Tuple<int>>(
				RandGen.GenerateInt(),
				RandGen.GenerateString(10),
				RandGen.GenerateInt(),
				RandGen.GenerateInt(),
				RandGen.GenerateInt(),
				RandGen.GenerateInt(),
				RandGen.GenerateInt(),
				new Tuple<int>(RandGen.GenerateInt()));

			var result = TestingHelper.ComparePerformance(source, 6000000, 6000000);

			WriteLine(result.GetReport());
		}

		[TestMethod]
		public void TupleCloneLogicTests_Class()
		{
			var source = new Tuple<Helper1, Helper1, Helper1, Helper1, Helper1, Helper1, Helper1, Tuple<Helper1>>(
				new Helper1() { PropOne = 1 },
				new Helper1() { PropOne = 2 },
				new Helper1() { PropOne = 3 },
				new Helper1() { PropOne = 4 },
				new Helper1() { PropOne = 5 },
				new Helper1() { PropOne = 6 },
				new Helper1() { PropOne = 7 },
				new Tuple<Helper1>(new Helper1() { PropOne = 8 }));


			var result = TestingHelper.ComparePerformance(source, 300000, 300000);

			WriteLine(result.GetReport());
		}

		[TestMethod]
		public void TupleCloneLogicTests_Struct()
		{
			var source = new Tuple<HelperStruct1, HelperStruct1, HelperStruct1, HelperStruct1, HelperStruct1, HelperStruct1, HelperStruct1, Tuple<HelperStruct1>>(
				new HelperStruct1() { PropOne = 1 },
				new HelperStruct1() { PropOne = 2 },
				new HelperStruct1() { PropOne = 3 },
				new HelperStruct1() { PropOne = 4 },
				new HelperStruct1() { PropOne = 5 },
				new HelperStruct1() { PropOne = 6 },
				new HelperStruct1() { PropOne = 7 },
				new Tuple<HelperStruct1>(new HelperStruct1() { PropOne = 8 }));

			var result = TestingHelper.ComparePerformance(source, 300000, 300000);

			WriteLine(result.GetReport());
		}

		[TestMethod]
		public void TupleCloneLogicTests_Null()
		{
			/*
			var source = (Tuple<int>)null;

			var result = TestingHelper.ComparePerformance(source, 3000000, 3000000);

			WriteLine(result.GetReport());
			*/
		}

		[TestMethod]
		public void TupleCloneLogicTests_List_TupleOfClasses_Duplicates()
		{
			var helper = new Tuple<Helper1, Helper1, Helper1, Helper1, Helper1, Helper1, Helper1, Tuple<Helper1>>(
			   new Helper1(),
			   new Helper1(),
			   new Helper1(),
			   new Helper1(),
			   new Helper1(),
			   new Helper1(),
			   new Helper1(),
			   new Tuple<Helper1>(new Helper1()));

			List<Tuple<Helper1, Helper1, Helper1, Helper1, Helper1, Helper1, Helper1, Tuple<Helper1>>> source = new List<Tuple<Helper1, Helper1, Helper1, Helper1, Helper1, Helper1, Helper1, Tuple<Helper1>>>();

			for (int i = 0; i < 3000000; i++)
			{
				source.Add(helper);
			}

			var result = TestingHelper.ComparePerformance(source, 1, 1);

			WriteLine(result.GetReport());
		}
	}
}
