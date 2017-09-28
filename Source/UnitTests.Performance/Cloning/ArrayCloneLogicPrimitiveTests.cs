using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UnitTests.Common;

namespace Performance.Cloning
{
    [TestClass]
	public class ArrayCloneLogicPrimitiveTests : BaseTest
	{
		[TestMethod]
		public void ArrayCloneLogicPrimitiveTests_IntArray()
		{
			var source = new[] { 0, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

			var result = TestingHelper.ComparePerformance(source, 2000000, 2000000);

			WriteLine(result.GetReport());
		}

		[TestMethod]
		public void ArrayCloneLogicPrimitiveTests_ByteArray()
		{
			var source = RandGen.GenerateByteArray(1000);

			var result = TestingHelper.ComparePerformance(source, 300000, 300000);

			WriteLine(result.GetReport());
		}

		[TestMethod]
		public void ArrayCloneLogicPrimitiveTests_StringArray()
		{
			var source = new[]
			{
				RandGen.GenerateString(10),
				RandGen.GenerateString(10),
				RandGen.GenerateString(10),
				RandGen.GenerateString(10),
				RandGen.GenerateString(10),
				RandGen.GenerateString(10),
				RandGen.GenerateString(10),
				RandGen.GenerateString(10),
				RandGen.GenerateString(10),
				RandGen.GenerateString(10),
			};

			var result = TestingHelper.ComparePerformance(source, 2000000, 2000000);

			WriteLine(result.GetReport());
		}

		[TestMethod]
		public void ArrayCloneLogicPrimitiveTests_TimeSpanArray()
		{
			var source = new[]
			{
				new TimeSpan(0),
				new TimeSpan(1),
				new TimeSpan(2),
				new TimeSpan(3),
				new TimeSpan(4),
				new TimeSpan(5),
				new TimeSpan(6),
				new TimeSpan(7),
				new TimeSpan(8),
				new TimeSpan(9),
			};

			var result = TestingHelper.ComparePerformance(source, 2000000, 2000000);

			WriteLine(result.GetReport());
		}

		[TestMethod]
		public void ArrayCloneLogicPrimitiveTests_DateTimeArray()
		{
			var source = new[]
			{
				DateTime.Now,
				DateTime.Now,
				DateTime.Now,
				DateTime.Now,
				DateTime.Now,
				DateTime.Now,
				DateTime.Now,
				DateTime.Now,
				DateTime.Now,
				DateTime.Now,
			};

			var result = TestingHelper.ComparePerformance(source, 2000000, 2000000);

			WriteLine(result.GetReport());
		}

		[TestMethod]
		public void ArrayCloneLogicPrimitiveTests_DelegateArray()
		{
			Func<string> func = () =>
			{
				return string.Empty;
			};

			var source = new[]
			{
				func,
				func,
				func,
				func,
				func,
				func,
				func,
				func,
				func,
				func,
			};

			var result = TestingHelper.ComparePerformance(source, 2000000, 2000000);

			WriteLine(result.GetReport());
		}
	}
}