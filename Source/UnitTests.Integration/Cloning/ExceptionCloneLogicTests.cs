using Deipax.Cloning.Common;
using Deipax.Cloning.Factories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using UnitTests.Common;

namespace Integration.Cloning
{
	[TestClass]
	public class ExceptionCloneLogicTests
	{
		[TestMethod]
		[ExpectedException(typeof(ArgumentException))]
		public void ExceptionCloneLogicTests_NoDefaultConstructor_Class()
		{
			var source = new Helper5(1);
			var target = GetClone(source);
		}

		#region Private Members
		private T GetClone<T>(T source)
		{
			var expression = CloneExpressionFactory<T>.Get();
			Assert.IsTrue(expression.CloneLogic is ExceptionCloneLogic);
			return expression.Clone(source, new Dictionary<object, object>());
		}
		#endregion
	}
}