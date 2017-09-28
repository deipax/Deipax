﻿using System.Collections.Generic;
using CloneExtensions;
using Deipax.Cloning.Common;

namespace UnitTests.Common
{
	public abstract class ParentAbstractClass : MyInterface
	{
		public string PublicFieldCommonName;
		private string PrivateFieldCommonName;

		private string PrivatePropCommonName { get; set; }
		public string PublicPropCommonName { get; set; }

		public string Parent_PublicField;
		private string Parent_PrivateField;
		public readonly string Parent_ReadOnlyField;
		public static string Parent_StaticField;
		public const string Parent_ConstField = "";

		public static string Parent_Public_Static_GetSet_AutoProp { get; set; }
		private static string Parent_Private_Static_GetSet_AutoProp { get; set; }

		public string Parent_Public_GetSet_AutoProp { get; set; }
		public string Parent_Public_GetPSet_AutoProp { get; private set; }
		public string Parent_Public_PGetSet_AutoProp { private get; set; }
		public string Parent_Public_Get_AutoProp { get; }

		private string Parent_Private_GetSet_AutoProp { get; set; }
		private string Parent_Private_Get_AutoProp { get; }
	}

	public abstract class ChildAbstractClass : ParentAbstractClass
	{
		public new string PublicFieldCommonName;
		private string PrivateFieldCommonName;

		private string PrivatePropCommonName { get; set; }
		public new string PublicPropCommonName { get; set; }

		public string Child_PublicField;
		private string Child_PrivateField;
		public readonly string Child_ReadOnlyField;
		public static string Child_StaticField;
		public const string Child_ConstField = "";

		public static string Child_Public_Static_GetSet_AutoProp { get; set; }
		private static string Child_Private_Static_GetSet_AutoProp { get; set; }

		public string Child_Public_GetSet_AutoProp { get; set; }
		public string Child_Public_GetPSet_AutoProp { get; private set; }
		public string Child_Public_PGetSet_AutoProp { private get; set; }
		public string Child_Public_Get_AutoProp { get; }

		private string Child_Private_GetSet_AutoProp { get; set; }
		private string Child_Private_Get_AutoProp { get; }
	}

	public class GrandChildClass : ChildAbstractClass
	{
		public new string PublicFieldCommonName;
		private string PrivateFieldCommonName;

		private string PrivatePropCommonName { get; set; }
		public new string PublicPropCommonName { get; set; }

		public string GrandChild_PublicField;
		private string GrandChild_PrivateField;
		public readonly string GrandChild_ReadOnlyField;
		public static string GrandChild_StaticField;
		public const string GrandChild_ConstField = "";

		public static string GrandChild_Public_Static_GetSet_AutoProp { get; set; }
		private static string GrandChild_Private_Static_GetSet_AutoProp { get; set; }

		public string GrandChild_Public_GetSet_AutoProp { get; set; }
		public string GrandChild_Public_GetPSet_AutoProp { get; private set; }
		public string GrandChild_Public_PGetSet_AutoProp { private get; set; }
		public string GrandChild_Public_Get_AutoProp { get; }

		private string GrandChild_Private_GetSet_AutoProp { get; set; }
		private string GrandChild_Private_Get_AutoProp { get; }
	}

	public interface MyInterface
	{
		string Parent_Public_GetSet_AutoProp { get; set; }
		string Parent_Public_Get_AutoProp { get; }
	}

	public struct MyStruct
	{
		public int PropTwo { get; set; }
	}

	public class MyStaticClass
	{
		public static string MyStaticProperty { get; set; }
		public static string MyStaticField;
	}

	public interface MyTmpInterface
	{
		int PropOne { get; set; }
	}

	public class Helper1 : MyTmpInterface
	{
		public int PropOne { get; set; }
		public int PropTwo { get; set; }
		public int PropThree { get; set; }
		public int PropFour { get; set; }
		public int PropFive { get; set; }
		public int PropSix { get; set; }
		public int PropSeven { get; set; }
		public int PropEight { get; set; }
		public int PropNine { get; set; }
		public int PropTen { get; set; }
	}

	public class Helper1_1 : MyTmpInterface
	{
		public int PropOne { get; set; }
	}

	public class Helper2
	{
		public Helper1 Helper { get; set; }
	}

	public struct HelperStruct1
	{
		public int PropOne { get; set; }
		public int PropTwo { get; set; }
		public int PropThree { get; set; }
		public int PropFour { get; set; }
		public int PropFive { get; set; }
		public int PropSix { get; set; }
		public int PropSeven { get; set; }
		public int PropEight { get; set; }
		public int PropNine { get; set; }
		public int PropTen { get; set; }
	}

	public struct HelperStruct2
	{
		public HelperStruct1 Helper { get; set; }
	}

	public struct HelperStruct3 : MyTmpInterface
	{
		public int PropOne { get; set; }
	}

	public class Helper3<T> : List<T>
	{
		public int PropOne { get; set; }
	}

	public class Helper4
	{
		public Helper4 Prop { get; set; }
	}

	public class Helper5
	{
		public Helper5(int prop)
		{
			this.Prop = prop;
		}

		public int Prop { get; private set; }
	}

	public struct HelperStruct5
	{
		public HelperStruct5(int prop)
		{
			this.Prop = prop;
		}

		public int Prop { get; private set; }
	}

	public class Base
	{
		public int iBase;
	}

	public class Derived : Base
	{
		public int iDerived;
	}

	public class Message
	{
		public Base aRef;  // polymorphic reference to a Derived
	}
}