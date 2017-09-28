using Deipax.Cloning.Common;
using Deipax.Cloning.Extensions;
using Deipax.Core.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Integration.Cloning
{
	[TestClass]
	public class NoCloneAttributeTests
	{
		[TestMethod]
		public void NoCloneAttributeTests_TestClass1()
		{
			var source = new TestClass1(3, 4)
			{
				PropOne = 1,
				PropTwo = 2
			};

			var dest = source.GetClone();

			var getterPropThree = ModelAccess<TestClass1>.GetGetter("PropThree");
			var getterPropFour = ModelAccess<TestClass1>.GetGetter("PropFour");

			var destPropThree = getterPropThree.Get(dest);
			var destPropFour = getterPropFour.Get(dest);

			Assert.AreEqual(dest.PropOne, 1);
			Assert.AreEqual(dest.PropTwo, 2);
			Assert.AreEqual(destPropThree, 3);
			Assert.AreEqual(destPropFour, 4);
		}

		[TestMethod]
		public void NoCloneAttributeTests_TestClass2()
		{
			var source = new TestClass2(3, 4)
			{
				PropOne = 1,
				PropTwo = 2
			};

			var dest = source.GetClone();

			var getterPropThree = ModelAccess<TestClass2>.GetGetter("PropThree");
			var getterPropFour = ModelAccess<TestClass2>.GetGetter("PropFour");

			var destPropThree = getterPropThree.Get(dest);
			var destPropFour = getterPropFour.Get(dest);

			Assert.AreEqual(dest.PropOne, 1);
			Assert.AreEqual(dest.PropTwo, default(int));
			Assert.AreEqual(destPropThree, 3);
			Assert.AreEqual(destPropFour, default(int));
		}

		[TestMethod]
		public void NoCloneAttributeTests_TestClass3()
		{
			var source = new TestClass3(3, 4)
			{
				PropOne = 1,
				PropTwo = 2
			};

			var dest = source.GetClone();

			var getterPropThree = ModelAccess<TestClass3>.GetGetter("PropThree");
			var getterPropFour = ModelAccess<TestClass3>.GetGetter("PropFour");

			var destPropThree = getterPropThree.Get(dest);
			var destPropFour = getterPropFour.Get(dest);

			Assert.AreEqual(dest.PropOne, default(int));
			Assert.AreEqual(dest.PropTwo, 2);
			Assert.AreEqual(destPropThree, default(int));
			Assert.AreEqual(destPropFour, 4);
		}

		[TestMethod]
		public void NoCloneAttributeTests_TestStruct1()
		{
			var source = new TestStruct1(3, 4)
			{
				PropOne = 1,
				PropTwo = 2
			};

			var dest = source.GetClone();

			var getterPropThree = ModelAccess<TestStruct1>.GetGetter("PropThree");
			var getterPropFour = ModelAccess<TestStruct1>.GetGetter("PropFour");

			var destPropThree = getterPropThree.Get(dest);
			var destPropFour = getterPropFour.Get(dest);

			Assert.AreEqual(dest.PropOne, 1);
			Assert.AreEqual(dest.PropTwo, 2);
			Assert.AreEqual(destPropThree, 3);
			Assert.AreEqual(destPropFour, 4);
		}

		[TestMethod]
		public void NoCloneAttributeTests_TestStruct2()
		{
			var source = new TestStruct2(3, 4)
			{
				PropOne = 1,
				PropTwo = 2
			};

			var dest = source.GetClone();

			var getterPropThree = ModelAccess<TestStruct2>.GetGetter("PropThree");
			var getterPropFour = ModelAccess<TestStruct2>.GetGetter("PropFour");

			var destPropThree = getterPropThree.Get(dest);
			var destPropFour = getterPropFour.Get(dest);

			Assert.AreEqual(dest.PropOne, 1);
			Assert.AreEqual(dest.PropTwo, default(int));
			Assert.AreEqual(destPropThree, 3);
			Assert.AreEqual(destPropFour, default(int));
		}

		[TestMethod]
		public void NoCloneAttributeTests_TestStruct3()
		{
			var source = new TestStruct3(3, 4)
			{
				PropOne = 1,
				PropTwo = 2
			};

			var dest = source.GetClone();

			var getterPropThree = ModelAccess<TestStruct3>.GetGetter("PropThree");
			var getterPropFour = ModelAccess<TestStruct3>.GetGetter("PropFour");

			var destPropThree = getterPropThree.Get(dest);
			var destPropFour = getterPropFour.Get(dest);

			Assert.AreEqual(dest.PropOne, default(int));
			Assert.AreEqual(dest.PropTwo, 2);
			Assert.AreEqual(destPropThree, default(int));
			Assert.AreEqual(destPropFour, 4);
		}

		#region Helper
		[CloneAll]
		private class TestClass1
		{
			public TestClass1(
				int propThree,
				int propFour)
			{
				PropThree = propThree;
				PropFour = propFour;
			}

			public TestClass1()
			{
			}

			public int PropOne { get; set; }
			public int PropTwo { get; set; }
			private int PropThree { get; set; }
			private int PropFour { get; set;  }
		}

		[CloneAll]
		private class TestClass2
		{
			public TestClass2(
				int propThree,
				int propFour)
			{
				PropThree = propThree;
				PropFour = propFour;
			}

			public TestClass2()
			{
			}

			[Clone]
			public int PropOne { get; set; }

			[NoClone]
			public int PropTwo { get; set; }

			[Clone]
			private int PropThree { get; set; }

			[NoClone]
			private int PropFour { get; set;  }
		}

		private class TestClass3
		{
			public TestClass3(
				int propThree,
				int propFour)
			{
				PropThree = propThree;
				PropFour = propFour;
			}

			public TestClass3()
			{
			}

			[NoClone]
			public int PropOne { get; set; }
		
			public int PropTwo { get; set; }
		
			private int PropThree { get; set; }

			[Clone]
			private int PropFour { get; set;  }
		}

		[CloneAll]
		private class TestStruct1
		{
			public TestStruct1(
				int propThree,
				int propFour)
			{
				PropThree = propThree;
				PropFour = propFour;
			}

			public TestStruct1()
			{
			}

			public int PropOne { get; set; }
			public int PropTwo { get; set; }
			private int PropThree { get; set; }
			private int PropFour { get; set;  }
		}

		[CloneAll]
		private class TestStruct2
		{
			public TestStruct2(
				int propThree,
				int propFour)
			{
				PropThree = propThree;
				PropFour = propFour;
			}

			public TestStruct2()
			{
			}

			[Clone]
			public int PropOne { get; set; }

			[NoClone]
			public int PropTwo { get; set; }

			[Clone]
			private int PropThree { get; set; }

			[NoClone]
			private int PropFour { get; set;  }
		}

		private class TestStruct3
		{
			public TestStruct3(
				int propThree,
				int propFour)
			{
				PropThree = propThree;
				PropFour = propFour;
			}

			public TestStruct3()
			{
			}

			[NoClone]
			public int PropOne { get; set; }
		
			public int PropTwo { get; set; }
		
			private int PropThree { get; set; }

			[Clone]
			private int PropFour { get; set;  }
		}
		#endregion
	}
}