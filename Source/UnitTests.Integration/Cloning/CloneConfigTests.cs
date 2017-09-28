using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Deipax.Cloning.Common;
using Deipax.Cloning.Extensions;
using Deipax.Cloning.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTests.Common;

namespace Integration.Cloning
{
	[TestClass]
	public class CloneConfigTests
	{
		[TestCleanup]
		public void CleanUp()
		{
			CloneLogicFactory.UserFactories.Clear();
			CloneConfig<Helper1>.UserCloneLogic = null;
			CloneConfig<Helper5>.Initializer = null;
			CloneConfig<HelperStruct5>.Initializer = null;
		}

		[TestMethod]
		public void CloneConfigTests_Overrides()
		{
			MyCustomCloneLogic clone1 = new MyCustomCloneLogic()
			{
				AddNullCheck = true,
				CloneLogicExpression = GetCloneFunc<Helper1>(),
				RunCompliedExpression = true
			};

			MyCustomCloneLogic clone2 = new MyCustomCloneLogic()
			{
				AddNullCheck = true,
				CloneLogicExpression = GetCloneFunc<Helper1>(),
				RunCompliedExpression = true
			};

			MyCustomCloneLogicFactory factory = new MyCustomCloneLogicFactory()
			{
				ReturnValue = clone2
			};

			CloneConfig<Helper1>.UserCloneLogic = clone1;
			CloneLogicFactory.UserFactories.Add(factory);

			var cloneExpression1 = CloneExpressionFactory<Helper1>.Get();

			Assert.AreSame(cloneExpression1.CloneLogic, clone1);

			CloneConfig<Helper1>.UserCloneLogic = null;

			var cloneExpression2 = CloneExpressionFactory<Helper1>.Get();

			Assert.AreSame(cloneExpression2.CloneLogic, clone2);
		}

		[TestMethod]
		public void CloneConfigTests_Initializer_Override_Class()
		{
			int methodCalled = 0;

			CloneConfig<Helper5>.Initializer = (x) =>
			{
				methodCalled++;
				return new Helper5(x.Prop);
			};

			var source = new Helper5(6);
			var dest = source.GetClone();

			Assert.IsNotNull(dest);
			Assert.AreNotSame(source, dest);
			Assert.AreEqual(source.Prop, dest.Prop);
			Assert.AreEqual(dest.Prop, 6);
			Assert.AreEqual(methodCalled, 1);

			var source2 = new Helper5(7);
			var dest2 = source2.GetClone();

			Assert.IsNotNull(dest2);
			Assert.AreNotSame(source2, dest2);
			Assert.AreEqual(source2.Prop, dest2.Prop);
			Assert.AreEqual(dest2.Prop, 7);
			Assert.AreEqual(methodCalled, 2);
		}

		[TestMethod]
		public void CloneConfigTests_Initializer_Override_Struct()
		{
			int methodCalled = 0;

			CloneConfig<HelperStruct5>.Initializer = (x) =>
			{
				methodCalled++;
				return new HelperStruct5(x.Prop);
			};

			var source = new HelperStruct5(6);

			var dest = source.GetClone();

			Assert.IsNotNull(dest);
			Assert.AreNotSame(source, dest);
			Assert.AreEqual(source.Prop, dest.Prop);
			Assert.AreEqual(dest.Prop, 6);
			Assert.AreEqual(methodCalled, 1);

			var source2 = new HelperStruct5(7);
			var dest2 = source2.GetClone();

			Assert.IsNotNull(dest2);
			Assert.AreNotSame(source2, dest2);
			Assert.AreEqual(source2.Prop, dest2.Prop);
			Assert.AreEqual(dest2.Prop, 7);
			Assert.AreEqual(methodCalled, 2);
		}

		#region Private Members
		private BlockExpression GetCloneFunc<T>()
		{
			return Expression.Block(Expression.Empty());
		}
		#endregion

		#region Helpers
		class MyCustomCloneLogicFactory : ICloneLogicFactory
		{
			public ICloneLogic ReturnValue { get; set; }

			public ICloneLogic Get<T>(ICloneLogicArgs args)
			{
				return ReturnValue;
			}
		}

		class MyCustomCloneLogic : ICloneLogic
		{
			public bool AddNullCheck { get; set; }
			public bool CheckClonedObjects { get; set; }
			public Expression CloneLogicExpression { get; set; }
			public bool RunCompliedExpression { get; set; }
		}
		#endregion
	}
}
