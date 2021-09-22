using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Benchmarks.Cloning.BaseClasses
{
    public abstract class Base<T>
    {
        [GlobalSetup]
        public void Setup()
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
        private T _default;
        private T _single;
        private object _object;
        private T[] _arraySame;
        private T[] _arrayDiff;
        private object[] _arraySameObjects;
        private object[] _arrayDiffObjects;
        private T[][] _array2dDiff;
        private T[][] _array2dSame;
        private T[] _arrayDefault;
        private T[,] _arrayRank2Diff;
        private T[,] _arrayRank2Same;
        private T[,,] _arrayRank3Diff;
        private T[,,] _arrayRank3Same;
        private List<T> _listSame;
        private List<T> _listDiff;
        private List<object> _listSameObject;
        private List<object> _listDiffObject;
        private KeyValuePair<T, T> _keyValueSame;
        private KeyValuePair<T, T> _keyValueDiff;
        private Tuple<T, T> _tupleSame;
        private Tuple<T, T> _tupleDiff;
        private Dictionary<T, T> _dictSame;
        private Dictionary<T, T> _dictDiff;
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