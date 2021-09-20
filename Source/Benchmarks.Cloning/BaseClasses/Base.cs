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
        public T SingleInstance() => Clone(_single);

        [Benchmark]
        public object ObjectInstance() => Clone(_object);

        [Benchmark]
        public T DefaultInstance() => Clone(_default);

        [Benchmark]
        public T[] ArrayOfDefaultInstance() => Clone(_arrayDefault);

        [Benchmark]
        public T[] ArrayOfDiffInstance() => Clone(_arrayDiff);

        [Benchmark]
        public T[] ArrayOfSameInstance() => Clone(_arraySame);

        [Benchmark]
        public object[] ArrayOfObjectsDiffInstance() => Clone(_arrayDiffObjects);

        [Benchmark]
        public object[] ArrayOfObjectsSameInstance() => Clone(_arraySameObjects);

        [Benchmark]
        public T[][] Array2dOfDiffInstance() => Clone(_array2dDiff);

        [Benchmark]
        public T[][] Array2dOfSameInstance() => Clone(_array2dSame);

        [Benchmark]
        public T[,] ArrayRank2OfDiffInstance() => Clone(_arrayRank2Diff);

        [Benchmark]
        public T[,] ArrayRank2OfSameInstance() => Clone(_arrayRank2Same);

        [Benchmark]
        public T[,,] ArrayRank3OfDiffInstance() => Clone(_arrayRank3Diff);

        [Benchmark]
        public T[,,] ArrayRank3OfSameInstance() => Clone(_arrayRank3Same);

        [Benchmark]
        public List<T> ListOfDiffInstance() => Clone(_listDiff);

        [Benchmark]
        public List<T> ListOfSameInstance() => Clone(_listSame);

        [Benchmark]
        public List<object> ListOfObjectsDiffInstance() => Clone(_listDiffObject);

        [Benchmark]
        public List<object> ListOfObjectsSameInstance() => Clone(_listSameObject);

        [Benchmark]
        public KeyValuePair<T, T> KeyValuePairSame() => Clone(_keyValueSame);

        [Benchmark]
        public KeyValuePair<T, T> KeyValuePairDiff() => Clone(_keyValueDiff);

        [Benchmark]
        public Tuple<T, T> TupleSameInstance() => Clone(_tupleSame);

        [Benchmark]
        public Tuple<T, T> TupleDiffInstance() => Clone(_tupleDiff);

        [Benchmark]
        public Dictionary<T, T> DictionarySameInstance() => Clone(_dictSame);

        [Benchmark]
        public Dictionary<T, T> DictionaryDiffInstance() => Clone(_dictDiff);
        #endregion

        #region Protected Members
        protected abstract T GenerateItem();
        protected abstract X Clone<X>(X source);
        #endregion
    }
}