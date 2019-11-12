using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace UnitTests.Cloning.BaseTests
{
    public abstract class Base<T>
    {
        public Base(ICloneHelper cloneHelper)
        {
            _default = default;

            _cloneHelper = cloneHelper;

            _single = GenerateItem();

            _object = _single;

            _arrayDiff = GenerateItems(10);

            _arrayDiffObjects = _arrayDiff.Cast<object>().ToArray();
            _arraySame = Enumerable.Repeat(_single, 10).ToArray();
            _arraySameObjects = _arraySame.Cast<object>().ToArray();

            _array2dDiff = Enumerable
                .Range(0, 10)
                .Select(x => Enumerable.Range(0, 10).Select(y => GenerateItem()).ToArray())
                .ToArray();

            _array2dSame = Enumerable.Repeat(_array2dDiff[0], 10).ToArray();

            _arrayDefault = Enumerable.Repeat(default(T), 10).ToArray();

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
            _dictSame = _listDiff.ToDictionary(x => x, x => x);
            _dictDiff = _listDiff.ToDictionary(x => x, x => GenerateItem());
        }

        private Base()
        {
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
        private readonly ICloneHelper _cloneHelper;
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
        public void Array2dOfDiffInstance()
        {
            var args = CreateArgs(_array2dDiff);
            _cloneHelper.Clone(args);
            AfterArray2dOfDiffInstance(args);
        }

        [Fact]
        public void Array2dOfSameInstance()
        {
            var args = CreateArgs(_array2dSame);
            _cloneHelper.Clone(args);
            AfterArray2dOfSameInstance(args);
        }

        [Fact]
        public void ArrayOfDefaultInstance()
        {
            var args = CreateArgs(_arrayDefault);
            _cloneHelper.Clone(args);
            AfterArrayOfDefaultInstance(args);
        }

        [Fact]
        public void ArrayRank2OfSameInstance()
        {
            var args = CreateArgs(_arrayRank2Same);
            _cloneHelper.Clone(args);
            AfterArrayRank2OfSameInstance(args);
        }

        [Fact]
        public void ArrayRank2OfDiffInstance()
        {
            var args = CreateArgs(_arrayRank2Diff);
            _cloneHelper.Clone(args);
            AfterArrayRank2OfDiffInstance(args);
        }

        [Fact]
        public void ArrayRank3OfSameInstance()
        {
            var args = CreateArgs(_arrayRank3Same);
            _cloneHelper.Clone(args);
            AfterArrayRank3OfSameInstance(args);
        }

        [Fact]
        public void ArrayRank3OfDiffInstance()
        {
            var args = CreateArgs(_arrayRank3Diff);
            _cloneHelper.Clone(args);
            AfterArrayRank3OfDiffInstance(args);
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
        protected abstract T GenerateItem();
        protected abstract void AssertAreSame(T source, T target);
        protected abstract void AssertAreEqual(T source, T target);

        protected virtual void AfterArrayOfDiffInstance(
            CloneArguments<T[]> args)
        {
            Assert.NotSame(args.Source, args.Target);
            Assert.Equal(args.Source.Length, args.Target.Length);

            for (int i = 0; i < args.Source.Length; i++)
            {
                AssertAreEqual(args.Source[i], args.Target[i]);
            }
        }

        protected virtual void AfterArrayOfSameInstance(
            CloneArguments<T[]> args)
        {
            Assert.NotSame(args.Source, args.Target);
            Assert.Equal(args.Source.Length, args.Target.Length);

            for (int i = 0; i < args.Source.Length; i++)
            {
                AssertAreEqual(args.Source[i], args.Target[i]);
            }

            for (int i = 0; i < args.Target.Length; i++)
            {
                AssertAreSame(args.Target[0], args.Target[i]);
            }
        }

        protected virtual void AfterArrayOfObjectsDiffInstance(
            CloneArguments<object[]> args)
        {
            Assert.NotSame(args.Source, args.Target);
            Assert.Equal(args.Source.Length, args.Target.Length);

            for (int i = 0; i < args.Source.Length; i++)
            {
                AssertAreEqual((T)args.Source[i], (T)args.Target[i]);
            }
        }

        protected virtual void AfterArrayOfObjectsSameInstance(
            CloneArguments<object[]> args)
        {
            Assert.NotSame(args.Source, args.Target);
            Assert.Equal(args.Source.Length, args.Target.Length);

            for (int i = 0; i < args.Source.Length; i++)
            {
                AssertAreEqual((T)args.Source[i], (T)args.Target[i]);
            }

            for (int i = 0; i < args.Target.Length; i++)
            {
                AssertAreSame((T)args.Target[0], (T)args.Target[i]);
            }
        }

        protected virtual void AfterSingleInstance(
            CloneArguments<T> args)
        {
            AssertAreEqual(args.Source, args.Target);
        }

        protected virtual void AfterObjectInstance(
            CloneArguments<object> args)
        {
            AssertAreEqual((T)args.Source, (T)args.Target);
        }

        protected virtual void AfterDefaultInstance(
            CloneArguments<T> args)
        {
            Assert.Equal(default, args.Target);
            Assert.Equal(default, args.Source);
        }

        protected virtual void AfterArray2dOfDiffInstance(
            CloneArguments<T[][]> args)
        {
            Assert.NotSame(args.Source, args.Target);
            Assert.Equal(args.Source.Length, args.Target.Length);

            for (int i = 0; i < args.Source.Length; i++)
            {
                var sourceArray = args.Source[i];
                var targetArray = args.Target[i];

                Assert.NotNull(sourceArray);
                Assert.NotNull(targetArray);

                for (int j = 0; j < sourceArray.Length; j++)
                {
                    AssertAreEqual(sourceArray[j], targetArray[j]);
                }
            }
        }

        protected virtual void AfterArray2dOfSameInstance(
            CloneArguments<T[][]> args)
        {
            Assert.NotSame(args.Source, args.Target);
            Assert.Equal(args.Source.Length, args.Target.Length);

            for (int i = 0; i < args.Source.Length; i++)
            {
                var sourceArray = args.Source[i];
                var targetArray = args.Target[i];

                Assert.NotNull(sourceArray);
                Assert.NotNull(targetArray);

                for (int j = 0; j < sourceArray.Length; j++)
                {
                    AssertAreEqual(sourceArray[j], targetArray[j]);
                }
            }

            for (int i = 0; i < args.Target.Length; i++)
            {
                Assert.Same(args.Target[0], args.Target[i]);
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

        protected virtual void AfterArrayRank2OfSameInstance(
            CloneArguments<T[,]> args)
        {
            Assert.NotSame(args.Source, args.Target);
            Assert.Equal(args.Source.GetLength(0), args.Target.GetLength(0));
            Assert.Equal(args.Source.GetLength(1), args.Target.GetLength(1));

            for (int i = 0; i < args.Source.GetLength(0); i++)
            {
                for (int j = 0; j < args.Source.GetLength(1); j++)
                {
                    AssertAreEqual(args.Source[i, j], args.Target[i, j]);
                    AssertAreSame(args.Target[0, 0], args.Target[i, j]);
                }
            }
        }

        protected virtual void AfterArrayRank2OfDiffInstance(
            CloneArguments<T[,]> args)
        {
            Assert.NotSame(args.Source, args.Target);
            Assert.Equal(args.Source.GetLength(0), args.Target.GetLength(0));
            Assert.Equal(args.Source.GetLength(1), args.Target.GetLength(1));

            for (int i = 0; i < args.Source.GetLength(0); i++)
            {
                for (int j = 0; j < args.Source.GetLength(1); j++)
                {
                    AssertAreEqual(args.Source[i, j], args.Target[i, j]);
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
                        AssertAreEqual(args.Source[i, j, k], args.Target[i, j, k]);
                        AssertAreSame(args.Target[0, 0, 0], args.Target[i, j, k]);
                    }
                }
            }
        }

        protected virtual void AfterArrayRank3OfDiffInstance(
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
                        AssertAreEqual(args.Source[i, j, k], args.Target[i, j, k]);
                    }
                }
            }
        }

        protected virtual void AfterListOfDiffInstance(
            CloneArguments<List<T>> args)
        {
            Assert.NotSame(args.Source, args.Target);
            Assert.Equal(args.Source.Count, args.Target.Count);

            for (int i = 0; i < args.Source.Count; i++)
            {
                AssertAreEqual(args.Source[i], args.Target[i]);
            }
        }

        protected virtual void AfterListOfSameInstance(
            CloneArguments<List<T>> args)
        {
            Assert.NotSame(args.Source, args.Target);
            Assert.Equal(args.Source.Count, args.Target.Count);

            for (int i = 0; i < args.Source.Count; i++)
            {
                AssertAreEqual(args.Source[i], args.Target[i]);
            }

            for (int i = 0; i < args.Target.Count; i++)
            {
                AssertAreSame(args.Target[0], args.Target[i]);
            }
        }

        protected virtual void AfterListOfObjectDiffInstance(
            CloneArguments<List<object>> args)
        {
            Assert.NotSame(args.Source, args.Target);
            Assert.Equal(args.Source.Count, args.Target.Count);

            for (int i = 0; i < args.Source.Count; i++)
            {
                AssertAreEqual((T)args.Source[i], (T)args.Target[i]);
            }
        }

        protected virtual void AfterListOfObjectSameInstance(
            CloneArguments<List<object>> args)
        {
            Assert.NotSame(args.Source, args.Target);
            Assert.Equal(args.Source.Count, args.Target.Count);

            for (int i = 0; i < args.Source.Count; i++)
            {
                AssertAreEqual((T)args.Source[i], (T)args.Target[i]);
            }

            for (int i = 0; i < args.Target.Count; i++)
            {
                AssertAreSame((T)args.Target[0], (T)args.Target[i]);
            }
        }

        protected virtual void AfterKeyValuePairSame(
            CloneArguments<KeyValuePair<T, T>> args)
        {
            AssertAreSame(args.Source.Key, args.Source.Value);
            AssertAreSame(args.Target.Key, args.Target.Value);
            AssertAreEqual(args.Source.Key, args.Target.Key);
            AssertAreEqual(args.Source.Value, args.Target.Value);
        }

        protected virtual void AfterKeyValuePairDiff(
            CloneArguments<KeyValuePair<T, T>> args)
        {
            AssertAreEqual(args.Source.Key, args.Target.Key);
            AssertAreEqual(args.Source.Value, args.Target.Value);
        }

        protected virtual void AfterTupleSameInstance(
            CloneArguments<Tuple<T, T>> args)
        {
            AssertAreSame(args.Source.Item1, args.Source.Item2);
            AssertAreSame(args.Target.Item1, args.Target.Item2);
            AssertAreEqual(args.Source.Item1, args.Target.Item1);
            AssertAreEqual(args.Source.Item2, args.Target.Item2);
        }

        protected virtual void AfterTupleDiffInstance(
            CloneArguments<Tuple<T, T>> args)
        {
            AssertAreEqual(args.Source.Item1, args.Target.Item1);
            AssertAreEqual(args.Source.Item2, args.Target.Item2);
        }

        protected virtual void AfterDictionarySameInstance(
            CloneArguments<Dictionary<T, T>> args)
        {
            Assert.Equal(args.Target.Count, args.Source.Count);

            var targetKeys = args.Target.Keys.ToList();
            var sourceKeys = args.Source.Keys.ToList();

            for (int i = 0; i < targetKeys.Count; i++)
            {
                var targetKey = targetKeys[i];
                var sourceKey = sourceKeys[i];

                AssertAreEqual(targetKey, sourceKey);

                var targetValue = args.Target[targetKey];
                var sourceValue = args.Source[sourceKey];

                AssertAreEqual(targetValue, sourceValue);
            }

            var tmpKey = targetKeys[0];
            var tmpValue = args.Target[tmpKey];

            foreach (var item in args.Target)
            {
                AssertAreSame(item.Key, item.Value);
            }
        }

        protected virtual void AfterDictionaryDiffInstance(
            CloneArguments<Dictionary<T, T>> args)
        {
            Assert.Equal(args.Target.Count, args.Source.Count);

            var targetKeys = args.Target.Keys.ToList();
            var sourceKeys = args.Source.Keys.ToList();

            for (int i = 0; i < targetKeys.Count; i++)
            {
                var targetKey = targetKeys[i];
                var sourceKey = sourceKeys[i];

                AssertAreEqual(targetKey, sourceKey);

                var targetValue = args.Target[targetKey];
                var sourceValue = args.Source[sourceKey];

                AssertAreEqual(targetValue, sourceValue);
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

        private T[] GenerateItems(int count)
        {
            List<T> items = new List<T>();

            while (items.Count != count)
            {
                T item = GenerateItem();

                if (!items.Contains(item))
                {
                    items.Add(item);
                }
            };

            return items.ToArray();
        }
        #endregion
    }

    public class CloneArguments<T>
    {
        public T Source { get; set; }
        public T Target { get; set; }
        public int CacheCount { get; set; }
    }

    public interface ICloneHelper
    {
        void Clone<T>(CloneArguments<T> args);
    }
}