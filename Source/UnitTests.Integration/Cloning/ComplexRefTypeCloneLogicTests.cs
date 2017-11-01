using Deipax.Cloning.Common;
using Deipax.Cloning.Extensions;
using Deipax.Cloning.Factories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using UnitTests.Common;

namespace Integration.Cloning
{
	[TestClass]
	public class ComplexRefTypeCloneLogicTests
	{
		[TestMethod]
		public void ComplexRefTypeCloneLogicTests_ObjectsAreReused()
		{
			Helper1 helper1 = new Helper1();
			Helper2 helper2 = new Helper2()
			{
				Helper = helper1
			};

			List<Helper2> source = new List<Helper2>()
			{
				helper2,
				helper2,
			};

			//var target = CloneExtensions.CloneFactory.GetClone(source);
			var target = GetClone(source, 3);

			Assert.IsNotNull(target);
			Assert.AreEqual(target.Count, source.Count);

			Assert.AreNotSame(target, source);

			Assert.AreNotSame(target[0], source[0]);
			Assert.AreNotSame(target[0], helper1);
			Assert.AreNotSame(target[0].Helper, source[0].Helper);
			Assert.AreNotSame(target[0].Helper, helper2);

			Assert.AreNotSame(target[1], source[1]);
			Assert.AreNotSame(target[1], helper1);
			Assert.AreNotSame(target[1].Helper, source[1].Helper);
			Assert.AreNotSame(target[1].Helper, helper2);

			Assert.AreSame(target[0], target[1]);
			Assert.AreSame(target[0].Helper, target[1].Helper);
		}

		[TestMethod]
		public void ComplexRefTypeCloneLogicTests_SimpleClass()
		{
			Helper2 source = new Helper2()
			{
				Helper = new Helper1()
				{
					PropOne = RandGen.GenerateInt()
				}
			};

			Helper2 dest = GetClone(source, 2);

			Assert.IsNotNull(dest);
			Assert.IsNotNull(dest.Helper);
			Assert.AreNotSame(dest.Helper, source.Helper);
			Assert.AreEqual(dest.Helper.PropOne, source.Helper.PropOne);
			Assert.AreNotSame(dest.Helper.PropOne, source.Helper.PropOne);
		}

		[TestMethod]
		public void ComplexRefTypeCloneLogicTests_Null()
		{
			Helper1 source = null;
			var dest = GetClone(source, 0);
			Assert.IsNull(dest);
		}

		[TestMethod]
		public void ComplexRefTypeCloneLogicTests_InheritList_Class()
		{
			var source = new Helper3<Helper1>()
			{
				PropOne = RandGen.GenerateInt()
			};

			for (int i = 0; i < 1000; i++)
			{
				source.Add(new Helper1()
				{
					PropOne = RandGen.GenerateInt()
				});
			};

			var target = GetClone(source, 1001);

			Assert.AreNotSame(source, target);
			Assert.AreEqual(target.Count, source.Count);
			Assert.AreNotSame(target.PropOne, source.PropOne);
			Assert.AreEqual(target.PropOne, source.PropOne);

			for (int i = 0; i < target.Count; i++)
			{
				Assert.AreNotSame(target[i], source[i]);
				Assert.AreEqual(target[i].PropOne, source[i].PropOne);
			}
		}

		[TestMethod]
		public void ComplexRefTypeCloneLogicTests_InheritList_Int()
		{
			var source = new Helper3<int>();

			for (int i = 0; i < 1000; i++)
			{
				source.Add(RandGen.GenerateInt());
			};

			var target = GetClone(source, 1);

			Assert.AreNotSame(source, target);
			Assert.AreEqual(target.Count, source.Count);

			for (int i = 0; i < target.Count; i++)
			{
				Assert.AreNotSame(target[i], source[i]);
			}
		}

		[TestMethod]
		public void ComplexRefTypeCloneLogicTests_InheritList_Stuct()
		{
			var source = new Helper3<HelperStruct1>()
			{
				PropOne = RandGen.GenerateInt()
			};

			for (int i = 0; i < 1000; i++)
			{
				source.Add(new HelperStruct1()
				{
					PropOne = RandGen.GenerateInt()
				});
			};

			var target = GetClone(source, 1);

			Assert.AreNotSame(source, target);
			Assert.AreEqual(source.Count, target.Count);
			Assert.AreNotSame(source.PropOne, target.PropOne);
			Assert.AreEqual(source.PropOne, target.PropOne);

			for (int i = 0; i < target.Count; i++)
			{
				Assert.AreNotSame(source[i], target[i]);
				Assert.AreEqual(source[i].PropOne, target[i].PropOne);
			}
		}

		[TestMethod]
		public void ComplexRefTypeCloneLogicTests_CyclicalReference()
		{
			Helper4 source = new Helper4();
			source.Prop = source;

			var target = GetClone(source, 1);

			Assert.AreNotSame(source, target);
			Assert.AreSame(target, target.Prop);
		}

		[TestMethod]
		public void ComplexRefTypeCloneLogicTests_ListOfClasses()
		{
			List<Helper2> source = new List<Helper2>();

			for (int i = 0; i < 1000; i++)
			{
				source.Add(new Helper2()
				{
					Helper = new Helper1()
					{
						PropOne = RandGen.GenerateInt()
					}
				});
			}

			List<Helper2> dest = GetClone(source, 2001);

			Assert.IsNotNull(dest);
			Assert.AreEqual(dest.Count, source.Count);

			for (int i = 0; i < dest.Count; i++)
			{
				Assert.AreNotSame(dest[i], source[i]);
				Assert.AreNotSame(dest[i].Helper, source[i].Helper);
				Assert.AreEqual(dest[i].Helper.PropOne, source[i].Helper.PropOne);
				Assert.AreNotSame(dest[i].Helper.PropOne, source[i].Helper.PropOne);
			}
		}

		[TestMethod]
		public void ComplexRefTypeCloneLogicTests_ListOfStructs()
		{
			List<HelperStruct2> source = new List<HelperStruct2>()
			{
				new HelperStruct2()
				{
					Helper = new HelperStruct1()
					{
						PropOne = RandGen.GenerateInt()
					}
				}
			};

			var dest = GetClone(source, 1);

			Assert.IsNotNull(dest);
			Assert.AreEqual(source.Count, dest.Count);
			Assert.AreNotSame(source[0], dest[0]);
			Assert.AreNotSame(source[0].Helper, dest[0].Helper);
			Assert.AreEqual(source[0].Helper.PropOne, dest[0].Helper.PropOne);
			Assert.AreNotSame(source[0].Helper.PropOne, dest[0].Helper.PropOne);
		}

		[TestMethod]
		public void ComplexRefTypeCloneLogicTests_DictionaryOfStructs()
		{
			Dictionary<HelperStruct1, HelperStruct1> source = new Dictionary<HelperStruct1, HelperStruct1>();

			for (int i = 0; i < 1000; i++)
			{
				source.Add(new HelperStruct1()
				{
					PropOne = RandGen.GenerateInt()
				},
				new HelperStruct1()
				{
					PropOne = RandGen.GenerateInt()
				});
			}

			var dest = GetClone(source, 1);

			Assert.IsNotNull(dest);
			Assert.AreEqual(dest.Count, source.Count);

			var destKeys = dest.Keys.ToList();
			var destValues = dest.Values.ToList();
			var sourceKeys = source.Keys.ToList();
			var sourceValues = source.Values.ToList();

			for (int i = 0; i < dest.Keys.Count; i++)
			{
				var tmp1 = source.ContainsKey(destKeys[i]);
				var tmp2 = dest.ContainsKey(sourceKeys[i]);

				Assert.AreNotSame(destKeys[i], sourceKeys[i]);
				Assert.AreNotSame(destKeys[i].PropOne, sourceKeys[i].PropOne);
				Assert.AreEqual(destKeys[i].PropOne, sourceKeys[i].PropOne);

				Assert.AreNotSame(destValues[i], sourceValues[i]);
				Assert.AreNotSame(destValues[i].PropOne, sourceValues[i].PropOne);
				Assert.AreEqual(destValues[i].PropOne, sourceValues[i].PropOne);
			}
		}

		[TestMethod]
		public void ComplexRefTypeCloneLogicTests_DictionaryOfClasses()
		{
			Dictionary<Helper1, Helper1> source = new Dictionary<Helper1, Helper1>();

			for (int i = 0; i < 1000; i++)
			{
				source.Add(new Helper1()
				{
					PropOne = RandGen.GenerateInt()
				},
				new Helper1()
				{
					PropOne = RandGen.GenerateInt()
				});
			}

			var dest = GetClone(source, 2001);

			Assert.IsNotNull(dest);
			Assert.AreEqual(dest.Count, source.Count);

			var destKeys = dest.Keys.ToList();
			var destValues = dest.Values.ToList();
			var sourceKeys = source.Keys.ToList();
			var sourceValues = source.Values.ToList();

			for (int i = 0; i < dest.Keys.Count; i++)
			{
				Assert.AreNotSame(destKeys[i], sourceKeys[i]);
				Assert.AreNotSame(destKeys[i].PropOne, sourceKeys[i].PropOne);
				Assert.AreEqual(destKeys[i].PropOne, sourceKeys[i].PropOne);

				Assert.AreNotSame(destValues[i], sourceValues[i]);
				Assert.AreNotSame(destValues[i].PropOne, sourceValues[i].PropOne);
				Assert.AreEqual(destValues[i].PropOne, sourceValues[i].PropOne);
			}
		}

		[TestMethod]
		public void ComplexRefTypeCloneLogicTests_DictionaryOfPrimitives()
		{
			Dictionary<int, int> source = new Dictionary<int, int>();

			for (int i = 0; i < 1000; i++)
			{
				source.Add(RandGen.GenerateInt(), RandGen.GenerateInt());
			}

			var dest = GetClone(source, 1);

			Assert.IsNotNull(dest);
			Assert.AreEqual(dest.Count, source.Count);

			foreach (var key in dest.Keys)
			{
				Assert.AreNotSame(dest[key], source[key]);
				Assert.AreNotSame(dest[key], source[key]);
				Assert.AreEqual(dest[key], source[key]);
			}
		}

		[TestMethod]
		public void ComplexRefTypeCloneLogicTests_ListStringArrays_DuplicateReuse()
		{
			var helper = RandGen
				.GenerateStringList(20, 5).
				ToArray();

			List<string[]> source = new List<string[]>()
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
			Assert.AreEqual(dest.Count, source.Count);

			var firstItem = dest[0];

			for (int i = 0; i < dest.Count; i++)
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
		public void ComplexRefTypeCloneLogicTests_PolymorphicSupport()
		{
			Message source = new Message()
			{
				aRef = new Derived()
				{
					iBase = RandGen.GenerateInt(),
					iDerived = RandGen.GenerateInt()
				}
			};

			var dest = GetClone(source, 2);

			Assert.IsNotNull(dest);
			Assert.IsNotNull(dest.aRef);
			Assert.AreNotSame(dest, source);
			Assert.AreNotSame(dest.aRef, source.aRef);
			Assert.AreEqual(dest.aRef.iBase, source.aRef.iBase);
			Assert.AreSame(dest.aRef.GetType(), source.aRef.GetType());
			Assert.AreEqual(dest.aRef.GetType(), typeof(Derived));
		}

		[TestMethod]
		public void ComplexRefTypeCloneLogicTests_ListOfObjects()
		{
			List<object> source = new List<object>()
			{
				(int)1,
				(double)2,
				new Helper1(),
				new Helper2()
				{
					Helper = new Helper1()
				},
				RandGen.GenerateString(10)
			};

			var target = GetClone(source, 4);

			Assert.IsNotNull(target);
			Assert.AreNotSame(source, target);

			Assert.AreNotSame(source[0], target[0]);
			Assert.AreEqual(source[0], target[0]);
			Assert.IsInstanceOfType(target[0], typeof(int));

			Assert.AreNotSame(source[1], target[1]);
			Assert.AreEqual(source[1], target[1]);
			Assert.IsInstanceOfType(target[1], typeof(double));

			Assert.AreNotSame(source[2], target[2]);
			Assert.AreNotEqual(source[2], target[2]);
			Assert.IsInstanceOfType(target[2], typeof(Helper1));

			Assert.AreNotSame(source[3], target[3]);
			Assert.AreNotEqual(source[3], target[3]);
			Assert.IsInstanceOfType(target[3], typeof(Helper2));

			Assert.AreSame(source[4], target[4]);
			Assert.AreEqual(source[4], target[4]);
			Assert.IsInstanceOfType(target[4], typeof(string));
		}

		[TestMethod]
		public void ComplexRefTypeCloneLogicTests_Object()
		{
			object source = new object();
			var target = GetClone(source, 1);
			Assert.IsNotNull(target);
			Assert.AreNotSame(source, target);
		}

		[TestMethod]
		public void ComplexRefTypeCloneLogicTests_IntAsObject()
		{
			int sourceAsInt = 1;
			object source = (object)sourceAsInt;
			var target = GetClone(source, 0);

			Assert.IsNotNull(target);
			Assert.AreNotSame(source, target);

			var targetAsInt = (int)target;

			Assert.AreEqual(sourceAsInt, targetAsInt);
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentException))]
		public void ComplexRefTypeCloneLogicTests_Anon()
		{
			var source = new
			{
				PropAnon = 1
			};

			var tmp = source.GetClone();
		}

		[TestMethod]
		public void ComplexRefTypeCloneLogicTests_ShadowFieldProps1()
		{
			DerivedClassOne source = new DerivedClassOne()
			{
				MyField = 1,
				Property = 1,
				VirtualProperty = 2,
				VirtualProperty2 = 3,
				AbstractProperty = 4,
				VirtualProperty3 = "test1"
			};

			Assert.AreEqual(2, ((BaseClassOne)source).VirtualProperty);
			Assert.AreEqual(3, ((BaseClassOne)source).VirtualProperty2);
			Assert.AreEqual(4, ((BaseClassOne)source).AbstractProperty);
			Assert.AreEqual("test1", ((BaseClassOne)source).VirtualProperty3);

			((BaseClassOne)source).MyField = 2;
			((BaseClassOne)source).Property = 5;
			((BaseClassOne)source).VirtualProperty = 6;
			((BaseClassOne)source).VirtualProperty2 = 7;
			((BaseClassOne)source).AbstractProperty = 8;
			((BaseClassOne)source).VirtualProperty3 = "test2";

			Assert.AreEqual(1, source.MyField);
			Assert.AreEqual(2, ((BaseClassOne)source).MyField);

			Assert.AreEqual(1, source.Property);
			Assert.AreEqual(5, ((BaseClassOne)source).Property);

			Assert.AreEqual(6, source.VirtualProperty);
			Assert.AreEqual(6, ((BaseClassOne)source).VirtualProperty);

			Assert.AreEqual(7, source.VirtualProperty2);
			Assert.AreEqual(7, ((BaseClassOne)source).VirtualProperty2);

			Assert.AreEqual(8, source.AbstractProperty);
			Assert.AreEqual(8, ((BaseClassOne)source).AbstractProperty);

			Assert.AreEqual("test2", source.VirtualProperty3);
			Assert.AreEqual("test2", ((BaseClassOne)source).VirtualProperty3);

			var target = source.GetClone();

			Assert.AreEqual(1, target.MyField);
			Assert.AreEqual(2, ((BaseClassOne)target).MyField);

			Assert.AreEqual(1, target.Property);
			Assert.AreEqual(5, ((BaseClassOne)target).Property);

			Assert.AreEqual(6, target.VirtualProperty);
			Assert.AreEqual(6, ((BaseClassOne)target).VirtualProperty);

			Assert.AreEqual(7, target.VirtualProperty2);
			Assert.AreEqual(7, ((BaseClassOne)target).VirtualProperty2);

			Assert.AreEqual(8, target.AbstractProperty);
			Assert.AreEqual(8, ((BaseClassOne)target).AbstractProperty);

			Assert.AreEqual("test2", target.VirtualProperty3);
			Assert.AreEqual("test2", ((BaseClassOne)target).VirtualProperty3);
		}

		[TestMethod]
		public void ComplexRefTypeCloneLogicTests_ShadowFieldProps2()
		{
			D source = new D()
			{
				Foo = "D"
			};

			((C)source).Foo = "C";
			((B) source).Foo = "B";
			((A)source).Foo = "A";

			Assert.AreEqual("C", source.Foo);
			Assert.AreEqual("C", ((C) source).Foo);
			Assert.AreEqual("A", ((B)source).Foo);
			Assert.AreEqual("A", ((A)source).Foo);

			var target = source.GetClone();

			Assert.AreEqual("C", target.Foo);
			Assert.AreEqual("C", ((C)target).Foo);
			Assert.AreEqual("A", ((B)target).Foo);
			Assert.AreEqual("A", ((A)target).Foo);
		}

		#region Private Members
		private T GetClone<T>(T source, int dictCount)
		{
			var dictionary = new Dictionary<object, object>();
			var expression = CloneExpressionFactory<T>.Get();
			Assert.IsTrue(expression.CloneLogic is ComplexRefTypeCloneLogic);
			T clonedItem = expression.Clone(source, dictionary);
			Assert.AreEqual(dictionary.Count, dictCount);
			return clonedItem;
		}
		#endregion
	}
}