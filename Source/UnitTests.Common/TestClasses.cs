namespace UnitTests.Common
{
    public struct SimpleStruct
    {
        public static SimpleStruct Generate()
        {
            return new SimpleStruct()
            {
                Int = RandGen.GenerateInt(),
                Long = RandGen.GenerateInt(),
                UInt = (uint)RandGen.GenerateInt(min: 0)
            };
        }

        public int Int { get; set; }
        public uint UInt { get; set; }
        public long Long { get; set; }
    }

    public abstract class SimpleClassParent
    {
        public int BaseInt { get; set; }
    }

    public class SimpleClass : SimpleClassParent
    {
        public static SimpleClass Generate()
        {
            return new SimpleClass()
            {
                BaseInt = RandGen.GenerateInt(),
                Double = RandGen.GenerateInt(),
                Float = RandGen.GenerateInt(),
                Int = RandGen.GenerateInt(),
                Long = RandGen.GenerateInt(),
                String = RandGen.GenerateString(10),
                UInt = (uint)RandGen.GenerateInt(min: 0),
                ULong = (ulong)RandGen.GenerateInt(min: 0)
            };
        }

        public int Int { get; set; }
        public uint UInt { get; set; }
        public long Long { get; set; }
        public ulong ULong { get; set; }
        public double Double { get; set; }
        public float Float { get; set; }
        public string String { get; set; }
    }

    public class ComplexClass
    {
        public static ComplexClass Generate()
        {
            ComplexClass tmp = new ComplexClass()
            {
                Int = RandGen.GenerateInt()
            };

            tmp.One = tmp;

            return tmp;
        }

        public int Int { get; set; }
        public ComplexClass One { get; set; }
    }

    public struct ComplexStruct
    {
        public static ComplexStruct Generate()
        {
            return new ComplexStruct()
            {
                Int = RandGen.GenerateInt(),
                One = ComplexClass.Generate()
            };
        }

        public int Int { get; set; }
        public ComplexClass One { get; set; }
    }

    public class DoubleSimpleClass
    {
        public static DoubleSimpleClass Generate()
        {
            var tmp = SimpleClass.Generate();

            return new DoubleSimpleClass()
            {
                One = tmp,
                Two = tmp
            };
        }

        public SimpleClass One { get; set; }
        public SimpleClass Two { get; set; }
    }
}