using Deipax.Cloning.Common;
using Deipax.Cloning.Factories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using UnitTests.Common;

namespace Integration.Cloning
{
	[TestClass]
	public class ComplexValueTypeCloneLogicTests
	{
		[TestMethod]
		public void ComplexValueTypeCloneLogicTests_SimpleStruct()
		{
			HelperStruct2 source = new HelperStruct2()
			{
				Helper = new HelperStruct1()
				{
					PropOne = RandGen.GenerateInt()
				}
			};

			HelperStruct2 target = GetClone(source);

			Assert.AreNotEqual(target, null);
			Assert.AreNotEqual(target.Helper, null);
			Assert.AreNotSame(source.Helper, target.Helper);
			Assert.AreEqual(source.Helper.PropOne, target.Helper.PropOne);
			Assert.AreNotSame(source.Helper.PropOne, target.Helper.PropOne);
		}

		[TestMethod]
		public void ComplexValueTypeCloneLogicTests_InheritList_Stuct()
		{
			var source = new Helper3<HelperStruct1>()
			{
				new HelperStruct1()
				{
					PropOne = RandGen.GenerateInt()
				}
			};

			source.PropOne = RandGen.GenerateInt();

			var target = GetCloneNoAssert(source);

			Assert.AreNotSame(source, target);
			Assert.AreEqual(source.Count, target.Count);
			Assert.AreNotSame(source[0], target[0]);
			Assert.AreEqual(source[0].PropOne, target[0].PropOne);
			Assert.AreNotSame(source.PropOne, target.PropOne);
			Assert.AreEqual(source.PropOne, target.PropOne);
		}

		[TestMethod]
		public void ComplexValueTypeCloneLogicTests_Null()
		{
			HelperStruct1 source = default(HelperStruct1);
			var dest = GetClone(source);
			Assert.IsNotNull(dest);
			Assert.AreEqual(source, dest);
			Assert.AreNotSame(source, dest);
		}

		#region Private Members
		private T GetClone<T>(T source)
		{
			var expression = CloneExpressionFactory<T>.Get();
			Assert.IsTrue(expression.CloneLogic is ComplexValueTypeCloneLogic);
			return expression.Clone(source, new Dictionary<object, object>());
		}

		private T GetCloneNoAssert<T>(T source)
		{
			var expression = CloneExpressionFactory<T>.Get();
			return expression.Clone(source, new Dictionary<object, object>());
		}
		#endregion
	}
}