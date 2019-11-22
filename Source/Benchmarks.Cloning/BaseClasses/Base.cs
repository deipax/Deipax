using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Benchmarks.Cloning.BaseClasses
{
    public abstract class Base<T>
    {
        public Base()
        {
            _default = default;
            _single = GenerateItem();
            _object = _single;

            _arrayDiff = Enumerable
                .Range(0, 10000)
                .Select(x => GenerateItem())
                .ToArray();

            _arrayDiffObjects = _arrayDiff.Cast<object>().ToArray();
            _arraySame = Enumerable.Repeat(_single, 10000).ToArray();
            _arraySameObjects = _arraySame.Cast<object>().ToArray();

            _array2dDiff = Enumerable
                .Range(0, 100)
                .Select(x => Enumerable.Range(0, 100).Select(y => GenerateItem()).ToArray())
                .ToArray();

            _array2dSame = Enumerable.Repeat(_array2dDiff[0], 100).ToArray();

            _arrayDefault = Enumerable.Repeat(default(T), 10000).ToArray();

            _arrayRank2Diff = new T[10, 10];
            _arrayRank2Same = new T[10, 10];
            _arrayRank3Diff = new T[10, 10, 10];
            _arrayRank3Same = new T[10, 10, 10];

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    _arrayRank2Same[i, j] = _single;
                    _arrayRank2Diff[i, j] = GenerateItem();

                    for (int k = 0; k < 10; k++)
                    {
                        _arrayRank3Same[i, j, k] = _single;
                        _arrayRank3Diff[i, j, k] = GenerateItem();
                    }
                }
            }

            _listDiff = _arrayDiff.ToList();
            _listSame = _arraySame.ToList();
            _listDiffObject = _arrayDiffObjects.ToList();
            _listSameObject = _arraySameObjects.ToList();
            _keyValueSame = new KeyValuePair<T, T>(_single, _single);
            _keyValueDiff = new KeyValuePair<T, T>(GenerateItem(), GenerateItem());
            _tupleSame = new Tuple<T, T>(_single, _single);
            _tupleDiff = new Tuple<T, T>(GenerateItem(), GenerateItem());

            _dictSame = new Dictionary<T, T>();
            _dictDiff = new Dictionary<T, T>();

            while (_dictSame.Count < 10000)
            {
                T item = GenerateItem();
                _dictSame[item] = item;
            }

            while (_dictDiff.Count < 10000)
            {
                _dictDiff[GenerateItem()] = GenerateItem();
            }
        }

        #region Field Members
        private readonly T _default;
        private readonly T _single;
        private readonly object _object;
        private readonly T[] _arraySame;
        private readonly T[] _arrayDiff;
        private readonly object[] _arraySameObjects;
        private readonly object[] _arrayDiffObjects;
        private readonly T[][] _array2dDiff;
        private readonly T[][] _array2dSame;
        private readonly T[] _arrayDefault;
        private readonly T[,] _arrayRank2Diff;
        private readonly T[,] _arrayRank2Same;
        private readonly T[,,] _arrayRank3Diff;
        private readonly T[,,] _arrayRank3Same;
        private readonly List<T> _listSame;
        private readonly List<T> _listDiff;
        private readonly List<object> _listSameObject;
        private readonly List<object> _listDiffObject;
        private readonly KeyValuePair<T, T> _keyValueSame;
        private readonly KeyValuePair<T, T> _keyValueDiff;
        private readonly Tuple<T, T> _tupleSame;
        private readonly Tuple<T, T> _tupleDiff;
        private readonly Dictionary<T, T> _dictSame;
        private readonly Dictionary<T, T> _dictDiff;
        #endregion

        #region Public Members
        [Benchmark]
        public int SingleInstance()
        {
            var result = Clone(_single);
            return 1;
        }

        [Benchmark]
        public int ObjectInstance()
        {
            var result = Clone(_object);
            return 1;
        }

        [Benchmark]
        public int DefaultInstance()
        {
            var result = Clone(_default);
            return 1;
        }

        [Benchmark]
        public int ArrayOfDefaultInstance()
        {
            return Clone(_arrayDefault).Length;
        }

        [Benchmark]
        public int ArrayOfDiffInstance()
        {
            return Clone(_arrayDiff).Length;
        }

        [Benchmark]
        public int ArrayOfSameInstance()
        {
            return Clone(_arraySame).Length;
        }

        [Benchmark]
        public int ArrayOfObjectsDiffInstance()
        {
            return Clone(_arrayDiffObjects).Length;
        }

        [Benchmark]
        public int ArrayOfObjectsSameInstance()
        {
            return Clone(_arraySameObjects).Length;
        }

        [Benchmark]
        public int Array2dOfDiffInstance()
        {
            return Clone(_array2dDiff).Length;
        }

        [Benchmark]
        public int Array2dOfSameInstance()
        {
            return Clone(_array2dSame).Length;
        }

        [Benchmark]
        public int ArrayRank2OfDiffInstance()
        {
            return Clone(_arrayRank2Diff).Length;
        }

        [Benchmark]
        public int ArrayRank2OfSameInstance()
        {
            return Clone(_arrayRank2Same).Length;
        }

        [Benchmark]
        public int ArrayRank3OfDiffInstance()
        {
            return Clone(_arrayRank3Diff).Length;
        }

        [Benchmark]
        public int ArrayRank3OfSameInstance()
        {
            return Clone(_arrayRank3Same).Length;
        }

        [Benchmark]
        public int ListOfDiffInstance()
        {
            return Clone(_listDiff).Count;
        }

        [Benchmark]
        public int ListOfSameInstance()
        {
            return Clone(_listSame).Count;
        }

        [Benchmark]
        public int ListOfObjectsDiffInstance()
        {
            return Clone(_listDiffObject).Count;
        }

        [Benchmark]
        public int ListOfObjectsSameInstance()
        {
            return Clone(_listSameObject).Count;
        }

        [Benchmark]
        public int KeyValuePairSame()
        {
            Clone(_keyValueSame);
            return 1;
        }

        [Benchmark]
        public int KeyValuePairDiff()
        {
            Clone(_keyValueDiff);
            return 1;
        }

        [Benchmark]
        public int TupleSameInstance()
        {
            Clone(_tupleSame);
            return 1;
        }

        [Benchmark]
        public int TupleDiffInstance()
        {
            Clone(_tupleDiff);
            return 1;
        }

        [Benchmark]
        public int DictionarySameInstance()
        {
            return Clone(_dictSame).Keys.Count;
        }

        [Benchmark]
        public int DictionaryDiffInstance()
        {
            return Clone(_dictDiff).Keys.Count;
        }
        #endregion

        #region Protected Members
        protected abstract T GenerateItem();
        protected abstract X Clone<X>(X source);
        #endregion
    }
}