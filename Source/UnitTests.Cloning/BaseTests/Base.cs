using System;
using System.Collections.Generic;
using System.Linq;
using UnitTests.Common;
using Xunit;

namespace UnitTests.Cloning.BaseTests
{
    public abstract class Base<T>
    {
        public Base(ICloneHelper cloneHelper)
        {
            _generator = GetItemGenerator();

            _default = default;

            _cloneHelper = cloneHelper;

            _single = _generator.GetItem();

            _object = _single;

            _arrayDiff = _generator.GetItems(10).ToArray();

            _arrayDiffObjects = _arrayDiff.Cast<object>().ToArray();
            _arraySame = Enumerable.Repeat(_single, 10).ToArray();
            _arraySameObjects = _arraySame.Cast<object>().ToArray();

            _arrayDefault = Enumerable.Repeat(default(T), 10).ToArray();

            _jaggedArray2dDiff = new T[10][];
            _jaggedArray2dSame = new T[10][];
            _multiDimArrayRank2Diff = new T[10, 10];
            _multiDimArrayRank2Same = new T[10, 10];
            _multiDimArrayRank3Diff = new T[10, 10, 10];
            _multiDimArrayRank3Same = new T[10, 10, 10];

            for (int i = 0; i < 10; i++)
            {
                _jaggedArray2dSame[i] = new T[10];
                _jaggedArray2dDiff[i] = new T[10];

                for (int j = 0; j < 10; j++)
                {
                    _jaggedArray2dSame[i][j] = _single;
                    _jaggedArray2dDiff[i][j] = _generator.GetItem();

                    _multiDimArrayRank2Same[i, j] = _single;
                    _multiDimArrayRank2Diff[i, j] = _generator.GetItem();

                    for (int k = 0; k < 10; k++)
                    {
                        _multiDimArrayRank3Same[i, j, k] = _single;
                        _multiDimArrayRank3Diff[i, j, k] = _generator.GetItem();
                    }
                }
            }

            _listDiff = _arrayDiff.ToList();
            _listSame = _arraySame.ToList();
            _listDiffObject = _arrayDiffObjects.ToList();
            _listSameObject = _arraySameObjects.ToList();
            _keyValueSame = new KeyValuePair<T, T>(_single, _single);
            _keyValueDiff = new KeyValuePair<T, T>(_generator.GetItem(), _generator.GetItem());
            _tupleSame = new Tuple<T, T>(_single, _single);
            _tupleDiff = new Tuple<T, T>(_generator.GetItem(), _generator.GetItem());
            _dictSame = _listDiff.ToDictionary(x => x, x => x);
            _dictDiff = _listDiff.ToDictionary(x => x, x => _generator.GetItem());
        }

        private Base()
        {
        }

        #region Field Members
        private readonly ItemGenerator<T> _generator;
        private readonly T _default;
        private readonly T _single;
        private readonly object _object;
        private readonly T[] _arraySame;
        private readonly T[] _arrayDiff;
        private readonly object[] _arraySameObjects;
        private readonly object[] _arrayDiffObjects;
        private readonly T[][] _jaggedArray2dDiff;
        private readonly T[][] _jaggedArray2dSame;
        private readonly T[] _arrayDefault;
        private readonly ICloneHelper _cloneHelper;
        private readonly T[,] _multiDimArrayRank2Diff;
        private readonly T[,] _multiDimArrayRank2Same;
        private readonly T[,,] _multiDimArrayRank3Diff;
        private readonly T[,,] _multiDimArrayRank3Same;
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

        [Fact]
        public void ArrayOfDiffInstance()
        {
            var args = CreateArgs(_arrayDiff);
            _cloneHelper.Clone(args);
            AfterArrayOfDiffInstance(args);
        }

        [Fact]
        public void ArrayOfSameInstance()
        {
            var args = CreateArgs(_arraySame);
            _cloneHelper.Clone(args);
            AfterArrayOfSameInstance(args);
        }

        [Fact]
        public void ArrayOfObjectsDiffInstance()
        {
            var args = CreateArgs(_arrayDiffObjects);
            _cloneHelper.Clone(args);
            AfterArrayOfObjectsDiffInstance(args);
        }

        [Fact]
        public void ArrayOfObjectsSameInstance()
        {
            var args = CreateArgs(_arraySameObjects);
            _cloneHelper.Clone(args);
            AfterArrayOfObjectsSameInstance(args);
        }

        [Fact]
        public void SingleInstance()
        {
            var args = CreateArgs(_single);
            _cloneHelper.Clone(args);
            AfterSingleInstance(args);
        }

        [Fact]
        public void ObjectInstance()
        {
            var args = CreateArgs(_object);
            _cloneHelper.Clone(args);
            AfterObjectInstance(args);
        }

        [Fact]
        public void DefaultInstance()
        {
            var args = CreateArgs(_default);
            _cloneHelper.Clone(args);
            AfterDefaultInstance(args);
        }

        [Fact]
        public void JaggedArray2dOfDiffInstance()
        {
            var args = CreateArgs(_jaggedArray2dDiff);
            _cloneHelper.Clone(args);
            AfterJaggedArray2dOfDiffInstance(args);
        }

        [Fact]
        public void JaggedArray2dOfSameInstance()
        {
            var args = CreateArgs(_jaggedArray2dSame);
            _cloneHelper.Clone(args);
            AfterJaggedArray2dOfSameInstance(args);
        }

        [Fact]
        public void ArrayOfDefaultInstance()
        {
            var args = CreateArgs(_arrayDefault);
            _cloneHelper.Clone(args);
            AfterArrayOfDefaultInstance(args);
        }

        [Fact]
        public void MultiDimArrayRank2OfSameInstance()
        {
            var args = CreateArgs(_multiDimArrayRank2Same);
            _cloneHelper.Clone(args);
            AfterMultiDimArrayRank2OfSameInstance(args);
        }

        [Fact]
        public void MultiDimArrayRank2OfDiffInstance()
        {
            var args = CreateArgs(_multiDimArrayRank2Diff);
            _cloneHelper.Clone(args);
            AfterMultiDimArrayRank2OfDiffInstance(args);
        }

        [Fact]
        public void MultiDimArrayRank3OfSameInstance()
        {
            var args = CreateArgs(_multiDimArrayRank3Same);
            _cloneHelper.Clone(args);
            AfterArrayRank3OfSameInstance(args);
        }

        [Fact]
        public void MultiDimArrayRank3OfDiffInstance()
        {
            var args = CreateArgs(_multiDimArrayRank3Diff);
            _cloneHelper.Clone(args);
            AfterMultiDimArrayRank3OfDiffInstance(args);
        }

        [Fact]
        public void ListOfDiffInstance()
        {
            var args = CreateArgs(_listDiff);
            _cloneHelper.Clone(args);
            AfterListOfDiffInstance(args);
        }

        [Fact]
        public void ListOfSameInstance()
        {
            var args = CreateArgs(_listSame);
            _cloneHelper.Clone(args);
            AfterListOfSameInstance(args);
        }

        [Fact]
        public void ListOfObjectDiffInstance()
        {
            var args = CreateArgs(_listDiffObject);
            _cloneHelper.Clone(args);
            AfterListOfObjectDiffInstance(args);
        }

        [Fact]
        public void ListOfObjectSameInstance()
        {
            var args = CreateArgs(_listSameObject);
            _cloneHelper.Clone(args);
            AfterListOfObjectSameInstance(args);
        }

        [Fact]
        public void KeyValuePairSame()
        {
            var args = CreateArgs(_keyValueSame);
            _cloneHelper.Clone(args);
            AfterKeyValuePairSame(args);
        }

        [Fact]
        public void KeyValuePairDiff()
        {
            var args = CreateArgs(_keyValueDiff);
            _cloneHelper.Clone(args);
            AfterKeyValuePairDiff(args);
        }

        [Fact]
        public void TupleSameInstance()
        {
            var args = CreateArgs(_tupleSame);
            _cloneHelper.Clone(args);
            AfterTupleSameInstance(args);
        }

        [Fact]
        public void TupleDiffInstance()
        {
            var args = CreateArgs(_tupleDiff);
            _cloneHelper.Clone(args);
            AfterTupleDiffInstance(args);
        }

        [Fact]
        public void DictionarySameInstance()
        {
            var args = CreateArgs(_dictSame);
            _cloneHelper.Clone(args);
            AfterDictionarySameInstance(args);
        }

        [Fact]
        public void DictionaryDiffInstance()
        {
            var args = CreateArgs(_dictDiff);
            _cloneHelper.Clone(args);
            AfterDictionaryDiffInstance(args);
        }

        #region Protected Members
        protected abstract ItemGenerator<T> GetItemGenerator();

        protected virtual void AfterArrayOfDiffInstance(
            CloneArguments<T[]> args)
        {
            Assert.NotSame(args.Source, args.Target);
            Assert.Equal(args.Source.Length, args.Target.Length);

            for (int i = 0; i < args.Target.Length; i++)
            {
                Assert.Equal(args.Source[i], args.Target[i], _generator.Comparer);

                if (i == 0) continue;
                Assert.True(AreNotSame(args.Target[0], args.Target[i]));
            }
        }

        protected virtual void AfterArrayOfSameInstance(
            CloneArguments<T[]> args)
        {
            Assert.NotSame(args.Source, args.Target);
            Assert.Equal(args.Source.Length, args.Target.Length);

            for (int i = 0; i < args.Target.Length; i++)
            {
                Assert.Equal(args.Source[i], args.Target[i], _generator.Comparer);
                Assert.True(AreSame(args.Target[0], args.Target[i]));
            }
        }

        protected virtual void AfterArrayOfObjectsDiffInstance(
            CloneArguments<object[]> args)
        {
            Assert.NotSame(args.Source, args.Target);
            Assert.Equal(args.Source.Length, args.Target.Length);

            for (int i = 0; i < args.Target.Length; i++)
            {
                Assert.Equal((T)args.Source[i], (T)args.Target[i], _generator.Comparer);

                if (i == 0) continue;
                Assert.True(AreNotSame((T)args.Target[0], (T)args.Target[i]));
            }
        }

        protected virtual void AfterArrayOfObjectsSameInstance(
            CloneArguments<object[]> args)
        {
            Assert.NotSame(args.Source, args.Target);
            Assert.Equal(args.Source.Length, args.Target.Length);

            for (int i = 0; i < args.Target.Length; i++)
            {
                Assert.Equal((T)args.Source[i], (T)args.Target[i], _generator.Comparer);
                Assert.True(AreSame((T)args.Target[0], (T)args.Target[i]));
            }
        }

        protected virtual void AfterSingleInstance(
            CloneArguments<T> args)
        {
            Assert.Equal(args.Source, args.Target, _generator.Comparer);
        }

        protected virtual void AfterObjectInstance(
            CloneArguments<object> args)
        {
            Assert.Equal((T)args.Source, (T)args.Target, _generator.Comparer);
        }

        protected virtual void AfterDefaultInstance(
            CloneArguments<T> args)
        {
            Assert.Equal(default, args.Target);
            Assert.Equal(default, args.Source);
        }

        protected virtual void AfterJaggedArray2dOfDiffInstance(
            CloneArguments<T[][]> args)
        {
            Assert.NotSame(args.Source, args.Target);
            Assert.Equal(args.Source.Length, args.Target.Length);

            for (int i = 0; i < args.Target.Length; i++)
            {
                for (int j = 0; j < args.Target[i].Length; j++)
                {
                    Assert.Equal(args.Source[i][j], args.Target[i][j], _generator.Comparer);

                    if (j == 0 && i == 0) continue;
                    Assert.True(AreNotSame(args.Target[0][0], args.Target[i][j]));
                }
            }
        }

        protected virtual void AfterJaggedArray2dOfSameInstance(
            CloneArguments<T[][]> args)
        {
            Assert.NotSame(args.Source, args.Target);
            Assert.Equal(args.Source.Length, args.Target.Length);

            for (int i = 0; i < args.Target.Length; i++)
            {
                for (int j = 0; j < args.Target[i].Length; j++)
                {
                    Assert.Equal(args.Source[i][j], args.Target[i][j], _generator.Comparer);
                    Assert.True(AreSame(args.Target[0][0], args.Target[i][j]));
                }
            }
        }

        protected virtual void AfterArrayOfDefaultInstance(
            CloneArguments<T[]> args)
        {
            Assert.NotSame(args.Source, args.Target);
            Assert.Equal(args.Source.Length, args.Target.Length);

            for (int i = 0; i < args.Source.Length; i++)
            {
                Assert.Equal(default, args.Source[i]);
                Assert.Equal(default, args.Target[i]);
            }
        }

        protected virtual void AfterMultiDimArrayRank2OfSameInstance(
            CloneArguments<T[,]> args)
        {
            Assert.NotSame(args.Source, args.Target);
            Assert.Equal(args.Source.GetLength(0), args.Target.GetLength(0));
            Assert.Equal(args.Source.GetLength(1), args.Target.GetLength(1));

            for (int i = 0; i < args.Source.GetLength(0); i++)
            {
                for (int j = 0; j < args.Source.GetLength(1); j++)
                {
                    Assert.Equal(args.Source[i, j], args.Target[i, j], _generator.Comparer);
                    Assert.True(AreSame(args.Target[0, 0], args.Target[i, j]));
                }
            }
        }

        protected virtual void AfterMultiDimArrayRank2OfDiffInstance(
            CloneArguments<T[,]> args)
        {
            Assert.NotSame(args.Source, args.Target);
            Assert.Equal(args.Source.GetLength(0), args.Target.GetLength(0));
            Assert.Equal(args.Source.GetLength(1), args.Target.GetLength(1));

            for (int i = 0; i < args.Source.GetLength(0); i++)
            {
                for (int j = 0; j < args.Source.GetLength(1); j++)
                {
                    Assert.Equal(args.Source[i, j], args.Target[i, j], _generator.Comparer);

                    if (j == 0 && i == 0) continue;
                    Assert.True(AreNotSame(args.Target[0, 0], args.Target[i, j]));
                }
            }
        }

        protected virtual void AfterArrayRank3OfSameInstance(
            CloneArguments<T[,,]> args)
        {
            Assert.NotSame(args.Source, args.Target);
            Assert.Equal(args.Source.GetLength(0), args.Target.GetLength(0));
            Assert.Equal(args.Source.GetLength(1), args.Target.GetLength(1));
            Assert.Equal(args.Source.GetLength(2), args.Target.GetLength(2));

            for (int i = 0; i < args.Source.GetLength(0); i++)
            {
                for (int j = 0; j < args.Source.GetLength(1); j++)
                {
                    for (int k = 0; k < args.Source.GetLength(2); k++)
                    {
                        Assert.Equal(args.Source[i, j, k], args.Target[i, j, k], _generator.Comparer);
                        Assert.True(AreSame(args.Target[0, 0, 0], args.Target[i, j, k]));
                    }
                }
            }
        }

        protected virtual void AfterMultiDimArrayRank3OfDiffInstance(
            CloneArguments<T[,,]> args)
        {
            Assert.NotSame(args.Source, args.Target);
            Assert.Equal(args.Source.GetLength(0), args.Target.GetLength(0));
            Assert.Equal(args.Source.GetLength(1), args.Target.GetLength(1));
            Assert.Equal(args.Source.GetLength(2), args.Target.GetLength(2));

            for (int i = 0; i < args.Source.GetLength(0); i++)
            {
                for (int j = 0; j < args.Source.GetLength(1); j++)
                {
                    for (int k = 0; k < args.Source.GetLength(2); k++)
                    {
                        Assert.Equal(args.Source[i, j, k], args.Target[i, j, k], _generator.Comparer);

                        if (i == 0 && j == 0 && k == 0) continue;
                        Assert.True(AreNotSame(args.Target[0, 0, 0], args.Target[i, j, k]));
                    }
                }
            }
        }

        protected virtual void AfterListOfDiffInstance(
            CloneArguments<List<T>> args)
        {
            Assert.NotSame(args.Source, args.Target);
            Assert.Equal(args.Source.Count, args.Target.Count);

            for (int i = 0; i < args.Target.Count; i++)
            {
                Assert.Equal(args.Source[i], args.Target[i], _generator.Comparer);

                if (i == 0) continue;
                Assert.True(AreNotSame(args.Target[0], args.Target[i]));
            }
        }

        protected virtual void AfterListOfSameInstance(
            CloneArguments<List<T>> args)
        {
            Assert.NotSame(args.Source, args.Target);
            Assert.Equal(args.Source.Count, args.Target.Count);

            for (int i = 0; i < args.Target.Count; i++)
            {
                Assert.Equal(args.Source[i], args.Target[i], _generator.Comparer);
                Assert.True(AreSame(args.Target[0], args.Target[i]));
            }
        }

        protected virtual void AfterListOfObjectDiffInstance(
            CloneArguments<List<object>> args)
        {
            Assert.NotSame(args.Source, args.Target);
            Assert.Equal(args.Source.Count, args.Target.Count);

            for (int i = 0; i < args.Target.Count; i++)
            {
                Assert.Equal((T)args.Source[i], (T)args.Target[i], _generator.Comparer);

                if (i == 0) continue;
                Assert.True(AreNotSame((T)args.Target[0], (T)args.Target[i]));
            }
        }

        protected virtual void AfterListOfObjectSameInstance(
            CloneArguments<List<object>> args)
        {
            Assert.NotSame(args.Source, args.Target);
            Assert.Equal(args.Source.Count, args.Target.Count);

            for (int i = 0; i < args.Target.Count; i++)
            {
                Assert.Equal((T)args.Source[i], (T)args.Target[i], _generator.Comparer);
                Assert.True(AreSame((T)args.Target[0], (T)args.Target[i]));
            }
        }

        protected virtual void AfterKeyValuePairSame(
            CloneArguments<KeyValuePair<T, T>> args)
        {
            Assert.True(AreSame(args.Source.Key, args.Source.Value));
            Assert.True(AreSame(args.Target.Key, args.Target.Value));
            Assert.Equal(args.Source.Key, args.Target.Key, _generator.Comparer);
            Assert.Equal(args.Source.Value, args.Target.Value, _generator.Comparer);
        }

        protected virtual void AfterKeyValuePairDiff(
            CloneArguments<KeyValuePair<T, T>> args)
        {
            Assert.Equal(args.Source.Key, args.Target.Key, _generator.Comparer);
            Assert.Equal(args.Source.Value, args.Target.Value, _generator.Comparer);
        }

        protected virtual void AfterTupleSameInstance(
            CloneArguments<Tuple<T, T>> args)
        {
            Assert.True(AreSame(args.Source.Item1, args.Source.Item2));
            Assert.True(AreSame(args.Target.Item1, args.Target.Item2));
            Assert.Equal(args.Source.Item1, args.Target.Item1, _generator.Comparer);
            Assert.Equal(args.Source.Item2, args.Target.Item2, _generator.Comparer);
        }

        protected virtual void AfterTupleDiffInstance(
            CloneArguments<Tuple<T, T>> args)
        {
            Assert.Equal(args.Source.Item1, args.Target.Item1, _generator.Comparer);
            Assert.Equal(args.Source.Item2, args.Target.Item2, _generator.Comparer);
        }

        protected virtual void AfterDictionarySameInstance(
            CloneArguments<Dictionary<T, T>> args)
        {
            Assert.Equal(args.Target.Count, args.Source.Count);

            for (int i = 0; i < args.Target.Keys.Count; i++)
            {
                Assert.Equal(args.Source.Values.ElementAt(i), args.Target.Values.ElementAt(i), _generator.Comparer);
                Assert.Equal(args.Source.Keys.ElementAt(i), args.Target.Keys.ElementAt(i), _generator.Comparer);

                Assert.True(AreSame(args.Target.Keys.ElementAt(i), args.Target.Values.ElementAt(i)));
            }
        }

        protected virtual void AfterDictionaryDiffInstance(
            CloneArguments<Dictionary<T, T>> args)
        {
            Assert.Equal(args.Target.Count, args.Source.Count);

            for (int i = 0; i < args.Target.Keys.Count; i++)
            {
                Assert.Equal(args.Source.Values.ElementAt(i), args.Target.Values.ElementAt(i), _generator.Comparer);
                Assert.Equal(args.Source.Keys.ElementAt(i), args.Target.Keys.ElementAt(i), _generator.Comparer);

                Assert.True(AreNotSame(args.Target.Keys.ElementAt(i), args.Target.Values.ElementAt(i)));
            }
        }

        protected int GetItemCount(T[][] source)
        {
            var count = source.Length;

            for (int i = 0; i < source.Length; i++)
            {
                count += GetItemCount(source[i]);
            }

            return count;
        }

        protected int GetItemCount(T[] source)
        {
            return source != null ? source.Length : 0;
        }
        #endregion

        #region Private Members
        private CloneArguments<X> CreateArgs<X>(
            X source)
        {
            return new CloneArguments<X>()
            {
                Source = source,
            };
        }

        private bool AreSame(T source, T target)
        {
            return typeof(T).IsClass
                ? ReferenceEquals(source, target)
                : _generator.Comparer.Equals(source, target);
        }

        private bool AreNotSame(T source, T target)
        {
            return typeof(T).IsClass
                ? !ReferenceEquals(source, target)
                : !_generator.Comparer.Equals(source, target);
        }
        #endregion
    }

    public class CloneArguments<T>
    {
        public T Source { get; set; }
        public T Target { get; set; }
        public IDictionary<object, object> Context { get; set; }
    }

    public interface ICloneHelper
    {
        void Clone<T>(CloneArguments<T> args);
    }
}