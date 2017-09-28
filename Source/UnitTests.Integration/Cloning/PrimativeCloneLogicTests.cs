using Deipax.Cloning.Common;
using Deipax.Cloning.Factories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Integration.Cloning
{
    [TestClass]
	public class PrimativeCloneLogicTests
	{
		[TestMethod]
		public void PrimativeCloneLogicTests_Int()
		{
			int source = 10;
			var dest = GetClone(source);
			Assert.AreEqual(dest, source);
			Assert.AreNotSame(dest, source);
		}

		[TestMethod]
		public void PrimativeCloneLogicTests_Doublce()
		{
			double source = 10.4;
			var dest = GetClone(source);
			Assert.AreEqual(dest, source);
			Assert.AreNotSame(dest, source);
		}

		[TestMethod]
		public void PrimativeCloneLogicTests_DateTime()
		{
			DateTime source = DateTime.Now;
			var dest = GetClone(source);
			Assert.AreEqual(dest, source);
			Assert.AreNotSame(dest, source);
		}

		[TestMethod]
		public void PrimativeCloneLogicTests_TimeSpan()
		{
			TimeSpan source = TimeSpan.FromMinutes(10.5);
			var dest = GetClone(source);
			Assert.AreEqual(dest, source);
			Assert.AreNotSame(dest, source);
		}

		[TestMethod]
		public void PrimativeCloneLogicTests_String()
		{
			string source = "my input string";
			var dest = GetClone(source);
			Assert.AreSame(dest, source);
		}

		[TestMethod]
		public void PrimativeCloneLogicTests_EmptyString()
		{
			string source = string.Empty;
			var dest = GetClone(source);
			Assert.AreSame(dest, source);
		}

		[TestMethod]
		public void PrimativeCloneLogicTests_NullString()
		{
			string source = null;
			var dest = GetClone(source);
			Assert.IsNull(dest);
		}

		[TestMethod]
		public void PrimativeCloneLogicTests_Delegate()
		{
			Func<int, int> source = (s) => s + 10;
			var dest = GetClone(source);
			Assert.AreSame(source, dest);
		}

		#region Private Members
		private T GetClone<T>(T source)
		{
			var expression = CloneExpressionFactory<T>.Get();
			Assert.IsTrue(expression.CloneLogic is PrimitiveCloneLogic);
			return expression.Clone(source, new Dictionary<object, object>());
		}
		#endregion
	}
}