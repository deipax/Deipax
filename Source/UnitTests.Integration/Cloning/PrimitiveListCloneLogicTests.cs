using Deipax.Cloning.Common;
using Deipax.Cloning.Factories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using UnitTests.Common;

namespace Integration.Cloning
{
	[TestClass]
	public class PrimitiveListCloneLogicTests
	{
		[TestMethod]
		public void PrimitiveListCloneLogicTests_ListOfStrings()
		{
			List<string> source = RandGen.GenerateStringList(1000, 10);

			var dest = GetClone(source, 1);

			Assert.IsNotNull(dest);
			Assert.AreEqual(dest.Count, source.Count);

			for (int i = 0; i < dest.Count; i++)
			{
				Assert.AreEqual(dest[i], source[i]);
			}

			source.Clear();

			Assert.AreNotEqual(source.Count, dest.Count);
		}

		[TestMethod]
		public void PrimitiveListCloneLogicTests_ListOfBytes()
		{
			List<byte> source = RandGen
				.GenerateByteArray(1000)
				.ToList();

			var dest = GetClone(source, 1);

			Assert.IsNotNull(dest);
			Assert.AreEqual(dest.Count, source.Count);

			for (int i = 0; i < dest.Count; i++)
			{
				Assert.AreEqual(dest[i], source[i]);
			}

			source.Clear();

			Assert.AreNotEqual(source.Count, dest.Count);
		}

		[TestMethod]
		public void PrimitiveListCloneLogicTests_ListOfInts()
		{
			List<int> source = RandGen.GenerateIntList(1000);

			var dest = GetClone(source, 1);

			Assert.IsNotNull(dest);
			Assert.AreEqual(dest.Count, source.Count);

			for (int i = 0; i < dest.Count; i++)
			{
				Assert.AreEqual(dest[i], source[i]);
			}

			source.Clear();

			Assert.AreNotEqual(source.Count, dest.Count);
		}

		[TestMethod]
		public void PrimitiveListCloneLogicTests_ListOfStringList_DuplicateReuse()
		{
			var helper = RandGen.GenerateStringList(20, 5);

			List<List<string>> source = new List<List<string>>()
			{
				helper,
				helper,
				helper,
				helper
			};

			var dest = GetCloneNoAssert(source, 2);

			Assert.IsNotNull(dest);
			Assert.AreNotEqual(dest, source);
			Assert.AreNotSame(dest, source);
			Assert.AreEqual(dest.Count, source.Count);

			var firstItem = dest[0];

			for (int i = 0; i < dest.Count; i++)
			{
				Assert.AreNotSame(source[i], dest[i]);
				Assert.AreSame(firstItem, dest[i]);
				Assert.AreEqual(source[i].Count, dest[i].Count);

				for (int j = 0; j < dest[i].Count; j++)
				{
					Assert.AreEqual(source[i][j], dest[i][j]);
				}
			}

			source.Clear();

			Assert.AreNotEqual(source.Count, dest.Count);
		}

		#region Private Members
		private T GetClone<T>(T source, int dictCount)
		{
			var dictionary = new Dictionary<object, object>();
			var expression = CloneExpressionFactory<T>.Get();
			Assert.IsTrue(expression.CloneLogic is PrimitiveListCloneLogic);
			T clonedItem = expression.Clone(source, dictionary);
			Assert.AreEqual(dictionary.Count, dictCount);
			return clonedItem;
		}

		private T GetCloneNoAssert<T>(T source, int dictCount)
		{
			var dictionary = new Dictionary<object, object>();
			var expression = CloneExpressionFactory<T>.Get();
			T clonedItem = expression.Clone(source, dictionary);
			Assert.AreEqual(dictionary.Count, dictCount);
			return clonedItem;
		}
		#endregion
	}
}