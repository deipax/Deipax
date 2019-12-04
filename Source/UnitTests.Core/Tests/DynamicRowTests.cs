using Deipax.Core.Common;
using System.Collections.Generic;
using UnitTests.Common;
using Xunit;
using System.Linq;

namespace UnitTests.Core
{
    public class DynamicRowTests
    {
        public DynamicRowTests()
        {
            DynamicTable table = new DynamicTable(_source.Keys.ToArray());
            _asDynamic = new DynamicRow(table, _source.Values.ToArray());
            _asDict = _asDynamic;
        }

        #region Fields
        private static readonly Dictionary<string, object> _source = new Dictionary<string, object>()
        {
            { "Field0", RandGen.GenerateString(10) },
            { "Field1", RandGen.GenerateString(10) },
            { "Field2", RandGen.GenerateInt() },
            { "Field3", RandGen.GenerateInt() },
            { "Field4", RandGen.GenerateDate(0) },
            { "Field5", RandGen.GenerateStringList(10, 10) },
            { "Field6", RandGen.GenerateStringList(10, 10) },
            { "Field7", RandGen.GenerateDate(0) },
            { "Field8", RandGen.GenerateIntList(10) },
            { "Field9", RandGen.GenerateIntList(10) },
        };

        private dynamic _asDynamic;
        private IDictionary<string, object> _asDict;
        #endregion

        [Fact]
        public void AsDictionary_CreateFromEmpty()
        {
            DynamicTable table = new DynamicTable();
            IDictionary<string, object> rowOne = new DynamicRow(table);
            IDictionary<string, object> rowTwo = new DynamicRow(table);

            rowOne["PropOne"] = "PropOne";
            rowOne["PropTwo"] = 2;

            Assert.Equal("PropOne", rowOne["PropOne"]);
            Assert.Equal(2, rowOne["PropTwo"]);

            Assert.Equal(default(object), rowTwo["PropOne"]);
            Assert.Equal(default(object), rowTwo["PropTwo"]);
        }

        [Fact]
        public void AsDictionary_Read()
        {
            foreach (var field in _source.Keys)
            {
                var value = _asDict[field];
                Assert.Equal(_source[field], value);
                Assert.IsType(_source[field].GetType(), value);
            }
        }

        [Fact]
        public void AsDictinary_Write()
        {
            foreach (var field in _source.Keys)
            {
                _asDict[field] = 10;
                var value = _asDict[field];
                Assert.Equal(10, value);
            }
        }

        [Fact]
        public void AsDictionary_Read_NonExisting()
        {
            var tmp = _asDict["DoesNotExist1"];
            Assert.Equal(default, tmp);
        }

        [Fact]
        public void AsDictionary_Write_NonExisting()
        {
            var value = RandGen.GenerateInt(10);
            _asDict["DoesNotExist2"] = value;
            var tmp = _asDict["DoesNotExist2"];
            Assert.Equal(value, tmp);
            Assert.IsType(value.GetType(), tmp);
        }

        [Fact]
        public void AsDynamic_CreateFromEmpty()
        {
            DynamicTable table = new DynamicTable();
            dynamic rowOne = new DynamicRow(table);
            dynamic rowTwo = new DynamicRow(table);

            rowOne.PropOne = "PropOne";
            rowOne.PropTwo = 2;

            Assert.Equal("PropOne", rowOne.PropOne);
            Assert.Equal(2, rowOne.PropTwo);

            Assert.Equal(default(object), rowTwo.PropOne);
            Assert.Equal(default(object), rowTwo.PropTwo);
        }

        [Fact]
        public void AsDynamic_Read()
        {
            var tmp0 = _asDynamic.Field0;
            Assert.Equal(_source["Field0"], tmp0);
            Assert.IsType(_source["Field0"].GetType(), tmp0);

            var tmp1 = _asDynamic.Field1;
            Assert.Equal(_source["Field1"], tmp1);
            Assert.IsType(_source["Field1"].GetType(), tmp1);

            var tmp2 = _asDynamic.Field2;
            Assert.Equal(_source["Field2"], tmp2);
            Assert.IsType(_source["Field2"].GetType(), tmp2);

            var tmp3 = _asDynamic.Field3;
            Assert.Equal(_source["Field3"], tmp3);
            Assert.IsType(_source["Field3"].GetType(), tmp3);

            var tmp4 = _asDynamic.Field4;
            Assert.Equal(_source["Field4"], tmp4);
            Assert.IsType(_source["Field4"].GetType(), tmp4);

            var tmp5 = _asDynamic.Field5;
            Assert.Equal(_source["Field5"], tmp5);
            Assert.IsType(_source["Field5"].GetType(), tmp5);

            var tmp6 = _asDynamic.Field6;
            Assert.Equal(_source["Field6"], tmp6);
            Assert.IsType(_source["Field6"].GetType(), tmp6);

            var tmp7 = _asDynamic.Field7;
            Assert.Equal(_source["Field7"], tmp7);
            Assert.IsType(_source["Field7"].GetType(), tmp7);

            var tmp8 = _asDynamic.Field8;
            Assert.Equal(_source["Field8"], tmp8);
            Assert.IsType(_source["Field8"].GetType(), tmp8);

            var tmp9 = _asDynamic.Field9;
            Assert.Equal(_source["Field9"], tmp9);
            Assert.IsType(_source["Field9"].GetType(), tmp9);
        }

        [Fact]
        public void AsDynamic_Write()
        {
            var tmp0 = RandGen.GenerateIntList(10);
            _asDynamic.Field0 = tmp0;
            Assert.Equal(tmp0, _asDynamic.Field0);
            Assert.IsType(tmp0.GetType(), _asDynamic.Field0);

            var tmp1 = RandGen.GenerateStringList(10, 10);
            _asDynamic.Field1 = tmp1;
            Assert.Equal(tmp1, _asDynamic.Field1);
            Assert.IsType(tmp1.GetType(), _asDynamic.Field1);

            var tmp2 = RandGen.GenerateInt();
            _asDynamic.Field2 = tmp2;
            Assert.Equal(tmp2, _asDynamic.Field2);
            Assert.IsType(tmp2.GetType(), _asDynamic.Field2);

            var tmp3 = RandGen.GenerateString(10);
            _asDynamic.Field3 = tmp3;
            Assert.Equal(tmp3, _asDynamic.Field3);
            Assert.IsType(tmp3.GetType(), _asDynamic.Field3);

            var tmp4 = RandGen.GenerateDate(10);
            _asDynamic.Field4 = tmp4;
            Assert.Equal(tmp4, _asDynamic.Field4);
            Assert.IsType(tmp4.GetType(), _asDynamic.Field4);

            var tmp5 = RandGen.GenerateIntList(10);
            _asDynamic.Field5 = tmp5;
            Assert.Equal(tmp5, _asDynamic.Field5);
            Assert.IsType(tmp5.GetType(), _asDynamic.Field5);

            var tmp6 = RandGen.GenerateStringList(10, 10);
            _asDynamic.Field6 = tmp6;
            Assert.Equal(tmp6, _asDynamic.Field6);
            Assert.IsType(tmp6.GetType(), _asDynamic.Field6);

            var tmp7 = RandGen.GenerateInt();
            _asDynamic.Field7 = tmp7;
            Assert.Equal(tmp7, _asDynamic.Field7);
            Assert.IsType(tmp7.GetType(), _asDynamic.Field7);

            var tmp8 = RandGen.GenerateString(10);
            _asDynamic.Field8 = tmp8;
            Assert.Equal(tmp8, _asDynamic.Field8);
            Assert.IsType(tmp8.GetType(), _asDynamic.Field8);

            var tmp9 = RandGen.GenerateDate(10);
            _asDynamic.Field9 = tmp9;
            Assert.Equal(tmp9, _asDynamic.Field9);
            Assert.IsType(tmp9.GetType(), _asDynamic.Field9);
        }

        [Fact]
        public void AsDynamic_Read_NonExisting()
        {
            var tmp = _asDynamic.DoesNotExist1;
            Assert.Equal(default(object), tmp);
        }

        [Fact]
        public void AsDynamic_Write_NonExisting()
        {
            var value = RandGen.GenerateInt(10);
            _asDynamic.DoesNotExist2 = value;
            var tmp = _asDynamic.DoesNotExist2;
            Assert.Equal(value, tmp);
            Assert.IsType(value.GetType(), tmp);
        }
    }
}