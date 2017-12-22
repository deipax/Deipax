using Deipax.Cloning.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Reflection;

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
        #region Field Members
        private static List<FieldInfo> _fields = typeof(GrandChildClass)
            .GetCopyableFields();

        private static Type _stringType = typeof(string);
        #endregion

        public static GrandChildClass Generate()
        {
            var grandChild = new GrandChildClass();

            _fields.ForEach(x =>
            {
                if (x.FieldType == _stringType)
                {
                    x.SetValue(grandChild, RandGen.GenerateString(10));
                }
            });

            return grandChild;
        }

        public static void AreEqual(
            GrandChildClass one,
            GrandChildClass two)
        {
            _fields.ForEach(x =>
            {
                var valueOne = x.GetValue(one);
                var valueTwo = x.GetValue(two);
                Assert.AreEqual(one, two);
            });
        }

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

    public struct HelperStruct6
    {
        public HelperStruct6(int prop)
        {
            this.Prop = prop;
            this.Helper1 = new Helper1();
        }

        public int Prop { get; private set; }
        public Helper1 Helper1 { get; set; }
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

    public abstract class BaseClassOne
    {
        public int MyField;

        public int Property { get; set; }
        virtual public int VirtualProperty { get; set; }
        abstract public int AbstractProperty { get; set; }
        virtual public int VirtualProperty2 { get; set; }

        virtual public string VirtualProperty3
        {
            get { return _virtualProperty; }
            set { _virtualProperty = string.Empty; }
        }
        private string _virtualProperty;
    }

    public class DerivedClassOne : BaseClassOne
    {
        public new int MyField;

        public new int Property { get; set; }
        public override int AbstractProperty { get; set; }
        public override int VirtualProperty { get; set; }
        // use the default implementation for VirtualProperty2
        public override string VirtualProperty3 { get; set; }
    }

    public class A
    {
        public virtual string Foo { get; set; }
    }

    public class B : A
    {
        public override string Foo { get; set; }
    }

    public class C : B
    {
        public virtual new string Foo { get; set; }
    }

    public class D : C
    {
        public override string Foo { get; set; }
    }
}