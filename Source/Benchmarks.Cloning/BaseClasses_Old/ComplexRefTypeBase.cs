using BenchmarkDotNet.Attributes;
using System.Collections.Generic;
using System.Linq;
using UnitTests.Common;

namespace Benchmarks.Cloning.BaseClasses_Old
{
    public abstract class ComplexRefTypeBase
    {
        public ComplexRefTypeBase()
        {
            _null = null;

            _simpleClass = new Helper1()
            {
                PropOne = RandGen.GenerateInt(),
                PropTwo = RandGen.GenerateInt(),
                PropThree = RandGen.GenerateInt(),
            };

            _complexClass = new Helper2()
            {
                Helper = new Helper1()
                {
                    PropOne = RandGen.GenerateInt(),
                    PropTwo = RandGen.GenerateInt(),
                    PropThree = RandGen.GenerateInt(),
                    PropFour = RandGen.GenerateInt(),
                    PropFive = RandGen.GenerateInt(),
                    PropSix = RandGen.GenerateInt(),
                    PropSeven = RandGen.GenerateInt(),
                    PropEight = RandGen.GenerateInt(),
                    PropNine = RandGen.GenerateInt(),
                    PropTen = RandGen.GenerateInt()
                }
            };

            _inheritListClass = new Helper3<Helper1>()
            {
                PropOne = RandGen.GenerateInt()
            };

            for (int i = 0; i < 10000; i++)
            {
                _inheritListClass.Add(new Helper1()
                {
                    PropOne = RandGen.GenerateInt()
                });
            };

            _inheritListInt = new Helper3<int>();

            for (int i = 0; i < 10000; i++)
            {
                _inheritListInt.Add(RandGen.GenerateInt());
            };

            _grandChildClass = GrandChildClassHelper.Generate();

            _listSimpleClasses = new List<Helper1>();

            for (int i = 0; i < 10000; i++)
            {
                _listSimpleClasses.Add(new Helper1()
                {
                    PropOne = RandGen.GenerateInt(),
                    PropTwo = RandGen.GenerateInt(),
                    PropThree = RandGen.GenerateInt(),
                });
            }

            _listComplexClasses = new List<Helper2>();

            for (int i = 0; i < 10000; i++)
            {
                _listComplexClasses.Add(new Helper2()
                {
                    Helper = new Helper1()
                    {
                        PropOne = RandGen.GenerateInt(),
                        PropTwo = RandGen.GenerateInt(),
                        PropThree = RandGen.GenerateInt(),
                    }
                });
            }

            _listInterfaces = new List<MyTmpInterface>();

            for (int i = 0; i < 10000; i++)
            {
                _listInterfaces.Add(new Helper1());
                _listInterfaces.Add(new Helper1_1());
            }

            _listSimpleStructs = new List<HelperStruct1>();

            for (int i = 0; i < 10000; i++)
            {
                _listSimpleStructs.Add(new HelperStruct1()
                {
                    PropOne = RandGen.GenerateInt(),
                    PropTwo = RandGen.GenerateInt(),
                    PropThree = RandGen.GenerateInt(),
                });
            }

            _listComplexStructs = new List<HelperStruct2>();

            for (int i = 0; i < 10000; i++)
            {
                _listComplexStructs.Add(new HelperStruct2()
                {
                    Helper = new HelperStruct1()
                    {
                        PropOne = RandGen.GenerateInt(),
                        PropTwo = RandGen.GenerateInt(),
                        PropThree = RandGen.GenerateInt(),
                    }
                });
            }

            _dictOfStructs = new Dictionary<HelperStruct1, HelperStruct1>();

            for (int i = 0; i < 10000; i++)
            {
                _dictOfStructs.Add(
                    new HelperStruct1()
                    {
                        PropOne = RandGen.GenerateInt(),
                        PropTwo = RandGen.GenerateInt(),
                        PropThree = RandGen.GenerateInt()
                    },
                    new HelperStruct1()
                    {
                        PropOne = RandGen.GenerateInt(),
                        PropTwo = RandGen.GenerateInt(),
                        PropThree = RandGen.GenerateInt()
                    });
            }

            _dictOfClasses = new Dictionary<Helper1, Helper1>();

            for (int i = 0; i < 10000; i++)
            {
                _dictOfClasses.Add(
                    new Helper1()
                    {
                        PropOne = RandGen.GenerateInt(),
                        PropTwo = RandGen.GenerateInt(),
                        PropThree = RandGen.GenerateInt()
                    },
                    new Helper1()
                    {
                        PropOne = RandGen.GenerateInt(),
                        PropTwo = RandGen.GenerateInt(),
                        PropThree = RandGen.GenerateInt()
                    });
            }

            _dictOfInt = new Dictionary<int, int>();

            for (int i = 0; i < 10000; i++)
            {
                _dictOfInt.Add(i, RandGen.GenerateInt());
            }

            _listSimpleClassesAsInterfaces = _listSimpleClasses
                .OfType<MyTmpInterface>()
                .ToList();

            _listSimpleClassesAsObjects = _listSimpleClasses
                .Cast<object>()
                .ToList();
        }

        #region Field Members
        private readonly Helper1 _simpleClass;
        private readonly Helper2 _complexClass;
        private readonly Helper3<Helper1> _inheritListClass;
        private readonly Helper3<int> _inheritListInt;
        private readonly Helper1 _null;
        private readonly GrandChildClass _grandChildClass;
        private readonly List<Helper1> _listSimpleClasses;
        private readonly List<Helper2> _listComplexClasses;
        private readonly List<MyTmpInterface> _listInterfaces;
        private readonly List<HelperStruct1> _listSimpleStructs;
        private readonly List<HelperStruct2> _listComplexStructs;
        private readonly Dictionary<HelperStruct1, HelperStruct1> _dictOfStructs;
        private readonly Dictionary<Helper1, Helper1> _dictOfClasses;
        private readonly Dictionary<int, int> _dictOfInt;
        private readonly IReadOnlyList<MyTmpInterface> _listSimpleClassesAsInterfaces;
        private readonly List<object> _listSimpleClassesAsObjects;
        #endregion

        protected abstract T GetClone<T>(T source);

        [Benchmark]
        public void SimpleClass()
        {
            var target = GetClone(_simpleClass);
        }

        [Benchmark]
        public void ComplexClass()
        {
            var target = GetClone(_complexClass);
        }

        [Benchmark]
        public void InheritList_Class()
        {
            var target = GetClone(_inheritListClass);
        }

        [Benchmark]
        public void InheritList_Int()
        {
            var target = GetClone(_inheritListInt);
        }

        [Benchmark]
        public void Null()
        {
            var target = GetClone(_null);
        }

        [Benchmark]
        public void GrandChildClass_Test()
        {
            var target = GetClone(_grandChildClass);
        }

        [Benchmark]
        public void List_SimpleClasses()
        {
            var target = GetClone(_listSimpleClasses);
        }

        [Benchmark]
        public void List_SimpleClasses_AsInterface()
        {
            var target = GetClone(_listSimpleClassesAsInterfaces);
        }

        [Benchmark]
        public void List_SimpleClasses_AsObjects()
        {
            var target = GetClone(_listSimpleClassesAsObjects);
        }

        [Benchmark]
        public void List_ComplexClasses()
        {
            var target = GetClone(_listComplexClasses);
        }

        [Benchmark]
        public void List_Interfaces()
        {
            var target = GetClone(_listInterfaces);
        }

        [Benchmark]
        public void List_SimpleStructs()
        {
            var target = GetClone(_listSimpleStructs);
        }

        [Benchmark]
        public void List_ComplexStructs()
        {
            var target = GetClone(_listComplexStructs);
        }

        [Benchmark]
        public void DictionaryOfStructs()
        {
            var target = GetClone(_dictOfStructs);
        }

        [Benchmark]
        public void DictionaryOfClasses()
        {
            var target = GetClone(_dictOfClasses);
        }

        [Benchmark]
        public void DictionaryOfInt()
        {
            var target = GetClone(_dictOfInt);
        }
    }
}