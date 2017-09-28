using Deipax.Cloning.Common;
using Deipax.Cloning.Factories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using UnitTests.Common;

namespace Integration.Cloning
{
	[TestClass]
	public class ArrayCloneLogicPrimitiveTests
	{
		[TestMethod]
		public void ArrayCloneLogicPrimitiveTests_NullIntArray()
		{
			int[] source = null;
			var dest = GetClone(source, 0);
			Assert.IsNull(dest);
		}

		[TestMethod]
		public void ArrayCloneLogicPrimitiveTests_EmptyIntArray()
		{
			int[] source = new int[0];
			var dest = GetClone(source, 1);

			Assert.IsNotNull(dest);
			Assert.AreNotEqual(dest, source);
			Assert.AreNotSame(dest, source);
			Assert.AreEqual(dest.Length, source.Length);
		}

		[TestMethod]
		public void ArrayCloneLogicPrimitiveTests_IntArray()
		{
			int[] source = new[] { 0, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

			var dest = GetClone(source, 1);

			Assert.IsNotNull(dest);
			Assert.AreNotEqual(dest, source);
			Assert.AreNotSame(dest, source);
			Assert.AreEqual(dest.Length, source.Length);
			Assert.AreEqual(dest[0], source[0]);
		}

		[TestMethod]
		public void ArrayCloneLogicPrimitiveTests_StringArray()
		{
			string[] source = new[] { "first string", string.Empty, null };

			var dest = GetClone(source, 1);

			Assert.IsNotNull(dest);
			Assert.AreNotEqual(dest, source);
			Assert.AreNotSame(dest, source);
			Assert.AreEqual(dest.Length, source.Length);
			Assert.AreEqual(dest[0], source[0]);
			Assert.AreEqual(dest[1], source[1]);
			Assert.AreEqual(dest[2], source[2]);
		}

		[TestMethod]
		public void ArrayCloneLogicPrimitiveTests_ByteArray()
		{
			var source = RandGen.GenerateByteArray(1000);

			var dest = GetClone(source, 1);

			Assert.IsNotNull(dest);
			Assert.AreNotEqual(dest, source);
			Assert.AreNotSame(dest, source);
			Assert.AreEqual(dest.Length, source.Length);

			for (int i = 0; i < dest.Length; i++)
			{
				Assert.AreNotSame(dest, source);
				Assert.AreEqual(dest[i], source[i]);
			}
		}

		#region Private Members
		private T GetClone<T>(T source, int dictCount)
		{
			var dictionary = new Dictionary<object, object>();
			var expression = CloneExpressionFactory<T>.Get();
			Assert.IsTrue(expression.CloneLogic is ArrayCloneLogicPrimitive);
			T clonedItem = expression.Clone(source, dictionary);
			Assert.AreEqual(dictionary.Count, dictCount);
			return clonedItem;
		}
		#endregion
	}
}