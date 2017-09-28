using Deipax.Cloning.Common;
using Deipax.Cloning.Factories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using UnitTests.Common;

namespace Integration.Cloning
{
	[TestClass]
	public class ArrayCloneLogicTests
	{
		[TestMethod]
		public void ArrayCloneLogicTests_ArrayOfStringArrays()
		{
			string[][] source = new string[][]
			{
				new string [] { "one", "two" },
				new string [] { "three", "four" }
			};

			var dest = GetClone(source, 3);

			Assert.IsNotNull(dest);
			Assert.AreNotEqual(dest, source);
			Assert.AreNotSame(dest, source);
			Assert.AreEqual(dest.Length, source.Length);
			Assert.AreNotEqual(dest[0], source[0]);
			Assert.AreNotEqual(dest[1], source[1]);
			Assert.AreEqual(dest[0][0], source[0][0]);
			Assert.AreEqual(dest[0][1], source[0][1]);
			Assert.AreEqual(dest[1][0], source[1][0]);
			Assert.AreEqual(dest[1][1], source[1][1]);
		}

		[TestMethod]
		public void ArrayCloneLogicTests_ArrayOfStringArrays_DuplicateReuse()
		{
			string[] helper = new string[] {"one", "two"};

			string[][] source = new string[][]
			{
				helper,
				helper,
				helper,
				helper
			};

			var dest = GetClone(source, 2);

			Assert.IsNotNull(dest);
			Assert.AreNotEqual(dest, source);
			Assert.AreNotSame(dest, source);
			Assert.AreEqual(dest.Length, source.Length);

			var firstItem = dest[0];

			for (int i = 0; i < dest.Length; i++)
			{
				Assert.AreNotSame(source[i], dest[i]);
				Assert.AreSame(firstItem, dest[i]);
				Assert.AreEqual(source[i].Length, dest[i].Length);

				for (int j = 0; j < dest[i].Length; j++)
				{
					Assert.AreEqual(source[i][j], dest[i][j]);
				}
			}
		}

		[TestMethod]
		public void ArrayCloneLogicTests_ArrayOfStringArrays_Null()
		{
			string[][] source = null;
			var dest = GetClone(source, 0);
			Assert.IsNull(dest);
		}

		[TestMethod]
		public void ArrayCloneLogicTests_ArrayOfNullableInts()
		{
			Nullable<int>[] source = new Nullable<int>[]
			{
				new Nullable<int>(10),
				new Nullable<int>(5),
				null
			};

			var dest = GetClone(source, 1);

			Assert.IsNotNull(dest);
			Assert.AreNotEqual(dest, source);
			Assert.AreNotSame(dest, source);
			Assert.AreEqual(dest.Length, source.Length);
			Assert.AreEqual(dest[0], source[0]);
			Assert.AreEqual(dest[1], source[1]);
			Assert.AreEqual(dest[2], source[2]);
			Assert.IsTrue(!dest[2].HasValue);
		}

		[TestMethod]
		public void ArrayCloneLogicTests_ArrayOfClasses()
		{
			Helper1[] source = new Helper1[1000];

			for (int i = 0; i < source.Length; i++)
			{
				source[i] = new Helper1()
				{
					PropOne = RandGen.GenerateInt()
				};
			}

			var dest = GetClone(source, 1001);

			Assert.IsTrue(dest != null);
			Assert.IsTrue(dest.Length == source.Length);

			for (int i = 0; i < dest.Length; i++)
			{
				Assert.AreNotSame(dest[i], source[i]);
				Assert.AreNotSame(dest[i].PropOne, source[i].PropOne);
				Assert.AreEqual(dest[i].PropOne, source[i].PropOne);
			}
		}

		#region Private Members
		private T GetClone<T>(T source, int dictCount)
		{
			var dictionary = new Dictionary<object, object>();
			var expression = CloneExpressionFactory<T>.Get();
			Assert.IsTrue(expression.CloneLogic is ArrayCloneLogic);
			T clonedItem = expression.Clone(source, dictionary);
			Assert.AreEqual(dictionary.Count, dictCount);
			return clonedItem;
		}
		#endregion
	}
}