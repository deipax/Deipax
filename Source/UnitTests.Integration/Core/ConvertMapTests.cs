using System;
using Deipax.Core.Conversion;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Integration.Core
{
	[TestClass]
	public class ConvertMapTests
	{
		[TestMethod]
		public void ConvertMap_CheckDefaults()
		{
			AssertDefault<bool>(true);
			AssertDefault<byte>(1);
			AssertDefault<char>('a');
			AssertDefault<DateTime>(DateTime.Now);
			AssertDefault<decimal>(1);
			AssertDefault<double>(1);
			AssertDefault<short>(1);
			AssertDefault<int>(1);
			AssertDefault<long>(1);
			AssertDefault<sbyte>(1);
			AssertDefault<float>(1);
			AssertDefault<string>("a");
			AssertDefault<ushort>(1);
			AssertDefault<uint>(1);
			AssertDefault<ulong>(1);
		}

		[TestMethod]
		public void ConvertMap_UserOverride()
		{
			/*
			int convertCallCount = 0;

			Func<object, MyCustomClass> overrideFunc = (source) =>
			{
				convertCallCount++;
				return new MyCustomClass();
			};

			ConvertMap<MyCustomClass>.ConvertFn = overrideFunc;

			var fetchedFunc = ConvertMap<MyCustomClass>.ConvertFn ?? ConvertMap<MyCustomClass>.DefaultFn;
			var dest = fetchedFunc("1");

			Assert.IsTrue(fetchedFunc == overrideFunc);
			Assert.IsTrue(convertCallCount == 1);

			// This will fetch the registered custom delegate,
			// compile it into a guarded delegate and cache it.
			dest = ConvertTo<MyCustomClass>.From("1");
			Assert.IsTrue(convertCallCount == 2);
			*/
		}

		#region Private Members
		private static void AssertDefault<T>(T source)
		{
			Assert.IsTrue(ConvertMap<T>.DefaultFn != null);

			var dest = ConvertMap<T>.DefaultFn(source);

			var sourceType = source.GetType();
			var destType = dest.GetType();

			Assert.IsTrue(sourceType == destType);
			Assert.IsTrue(source.Equals(dest));
		}
		#endregion

		#region Helpers
		class MyCustomClass
		{
			public int PropOne { get; set; }
		}
		#endregion
	}
}