using BenchmarkDotNet.Attributes;
using Benchmarks.Core.TestClasses;
using Deipax.Core.Common;
using Deipax.Core.Conversion;
using System;
using System.Globalization;

namespace Benchmarks.Core
{
    public class AdHoc
    {
        #region Field Members
        private MyEnum _myEnum = MyEnum.Hello;
        private object _myEnumAsObject = MyEnum.Hello;

        enum MyEnum
        {
            Hello = 1
        }
        #endregion

        //[Benchmark]
        public void Enum_Cast()
        {
            string value = _myEnum.ToString();
        }

        //[Benchmark]
        public void IConvertable_Enum()
        {
            IConvertible x = _myEnum as IConvertible;
            string value = x.ToString(CultureInfo.InvariantCulture);
        }

        //[Benchmark]
        public void ConvertTO_Enum()
        {
            string value = ConvertTo<string, MyEnum>.From(_myEnum);
        }

        //[Benchmark]
        public void ConvertTO_Enum_AsObject()
        {
            string value = ConvertTo<string, object>.From(_myEnumAsObject);
        }

        //[Benchmark]
        public void IsObjectEnum()
        {
            var tmp = _myEnumAsObject.GetType().IsEnum;
        }

        //[Benchmark]
        public void NewIt()
        {
            ParentClass x = new ParentClass();
        }
    }
}