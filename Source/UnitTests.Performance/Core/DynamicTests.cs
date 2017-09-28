using System;
using System.Collections.Generic;
using System.Dynamic;
using Deipax.DataAccess.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTests.Common;

namespace Performance.Core
{
	[TestClass]
	public class DynamicTests
	{
		#region Fields
		private static readonly List<string> _fieldNames = new List<string>
		{
			"Field0",
			"Field1",
			"Field2",
			"Field3",
			"Field4",
			"Field5",
			"Field6",
			"Field7",
			"Field8",
			"Field9"
		};

		#endregion

		[TestMethod]
		public void ReadAsDictionaryTest()
		{
			var dynamicD = GenRandomDynamicDictionary(_fieldNames);
			var expando = GenRandomExpando(_fieldNames);

			var result = TimingHelper.ComparePerformance(
				2000000,
				2000000,
				() => ReadAsDictionary(expando, _fieldNames),
				() => ReadAsDictionary(dynamicD, _fieldNames));

			Console.WriteLine(result.GetReport());
		}

		[TestMethod]
		public void ReadAsDynamicTest()
		{
			var dynamicD = GenRandomDynamicDictionary(_fieldNames);
			var expando = GenRandomExpando(_fieldNames);

			var result = TimingHelper.ComparePerformance(
				2000000,
				2000000,
				() => ReadAsDynamic(expando),
				() => ReadAsDynamic(dynamicD));

			Console.WriteLine(result.GetReport());
		}

		[TestMethod]
		public void WriteAsDictionaryTest()
		{
			var dynamicD = GenRandomDynamicDictionary(_fieldNames);
			var expando = GenRandomExpando(_fieldNames);

			var result = TimingHelper.ComparePerformance(
				2000000,
				2000000,
				() => WriteAsDictionary(expando, _fieldNames),
				() => WriteAsDictionary(dynamicD, _fieldNames));

			Console.WriteLine(result.GetReport());
		}

		[TestMethod]
		public void WriteAsDynamicTest()
		{
			var dynamicD = GenRandomDynamicDictionary(_fieldNames);
			var expando = GenRandomExpando(_fieldNames);

			var result = TimingHelper.ComparePerformance(
				2000000,
				2000000,
				() => WriteAsDynamic(expando),
				() => WriteAsDynamic(dynamicD));

			Console.WriteLine(result.GetReport());
		}

		[TestMethod]
		public void InitTest()
		{
			var result = TimingHelper.ComparePerformance(
				2000000,
				2000000,
				() => InitExpando(_fieldNames),
				() => InitDD(_fieldNames));

			Console.WriteLine(result.GetReport());
		}

		#region Private Members
		private static IDictionary<string, object> GenRandomDictionary(IEnumerable<string> fieldNames)
		{
			Dictionary<string, object> d = new Dictionary<string, object>();

			foreach (var fieldName in fieldNames)
			{
				d.Add(fieldName, RandGen.GenerateInt());
			}

			return d;
		}

		private static dynamic GenRandomDynamicDictionary(IEnumerable<string> fieldNames)
		{
			var d = new DynamicDictionary<object>();

			foreach (var fieldName in fieldNames)
			{
				d.Add(fieldName, RandGen.GenerateInt());
			}

			return d;
		}

		private static dynamic GenRandomExpando(IEnumerable<string> fieldNames)
		{
			var expando = new ExpandoObject();
			var d = (IDictionary<string, object>)expando;

			foreach (var fieldName in fieldNames)
			{
				d.Add(fieldName, RandGen.GenerateInt());
			}

			return expando;
		}

		private static void ReadAsDictionary(IDictionary<string, object> item, IEnumerable<string> fields)
		{
			foreach (var field in fields)
			{
				var value = item[field];
			}
		}

		private static void WriteAsDictionary(IDictionary<string, object> item, IEnumerable<string> fields)
		{
			foreach (var field in fields)
			{
				item[field] = 10;
			}
		}

		private static void ReadAsDynamic(dynamic item)
		{
			var tmp0 = item.Field0;
			var tmp1 = item.Field1;
			var tmp2 = item.Field2;
			var tmp3 = item.Field3;
			var tmp4 = item.Field4;
			var tmp5 = item.Field5;
			var tmp6 = item.Field6;
			var tmp7 = item.Field7;
			var tmp8 = item.Field8;
			var tmp9 = item.Field9;
		}

		private static void WriteAsDynamic(dynamic item)
		{
			item.Field0 = 10;
			item.Field1 = 10;
			item.Field2 = 10;
			item.Field3 = 10;
			item.Field4 = 10;
			item.Field5 = 10;
			item.Field6 = 10;
			item.Field7 = 10;
			item.Field8 = 10;
			item.Field9 = 10;
		}

		private static void InitDD(IEnumerable<string> fields)
		{
			DynamicDictionary<object> d = new DynamicDictionary<object>();

			foreach (var key in fields)
			{
				d.Add(key, 10);
			}
		}

		private static void InitExpando(IEnumerable<string> fields)
		{
			var d = new ExpandoObject() as IDictionary<string, object>;

			foreach (var key in fields)
			{
				d.Add(key, 10);
			}
		}
		#endregion
	}
}