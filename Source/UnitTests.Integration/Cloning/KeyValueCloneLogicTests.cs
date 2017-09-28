using Deipax.Cloning.Common;
using Deipax.Cloning.Factories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using UnitTests.Common;

namespace Integration.Cloning
{
	[TestClass]
	public class KeyValueCloneLogicTests
	{
		[TestMethod]
		public void KeyValueCloneLogicTests_Primitives()
		{
			var source = new KeyValuePair<int, string>(10, "test");

			var target = GetClone(source);
			Assert.AreEqual(source, target);
			Assert.AreNotSame(source, target);
			Assert.AreEqual(source.Value, target.Value);
			Assert.AreEqual(source.Key, target.Key);
		}

		[TestMethod]
		public void KeyValueCloneLogicTests_Class()
		{
			var source = new KeyValuePair<Helper1, Helper1>(
				new Helper1() { PropOne = 1 },
				new Helper1() { PropOne = 2 });

			var target = GetClone(source);
			Assert.AreNotSame(source, target);
			Assert.AreNotSame(source.Key, target.Key);
			Assert.AreNotSame(source.Value, target.Value);
			Assert.AreEqual(source.Value.PropOne, target.Value.PropOne);
			Assert.AreEqual(source.Key.PropOne, target.Key.PropOne);
		}

		[TestMethod]
		public void KeyValueCloneLogicTests_Struct()
		{
			var source = new KeyValuePair<HelperStruct1, HelperStruct1>(
				new HelperStruct1() { PropOne = 1 },
				new HelperStruct1() { PropOne = 2 });

			var target = GetClone(source);
			Assert.AreNotSame(source, target);
			Assert.AreNotSame(source.Key, target.Key);
			Assert.AreNotSame(source.Value, target.Value);
			Assert.AreEqual(source.Value.PropOne, target.Value.PropOne);
			Assert.AreEqual(source.Key.PropOne, target.Key.PropOne);
		}

		#region Private Members
		private T GetClone<T>(T source)
		{
			var expression = CloneExpressionFactory<T>.Get();
			Assert.IsTrue(expression.CloneLogic is KeyValueCloneLogic);
			return expression.Clone(source, new Dictionary<object, object>());
		}
		#endregion
	}
}