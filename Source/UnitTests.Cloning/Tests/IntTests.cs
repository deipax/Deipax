using System;
using System.Collections.Generic;
using UnitTests.Cloning.BaseTests;
using Xunit;

namespace UnitTests.Cloning
{
    public class IntTests : IntBase
    {
        public IntTests() : base(DeipaxCloneHelper.Instance)
        {
        }

        protected override void AfterArrayOfDiffInstance(
            CloneArguments<int[]> args)
        {
            base.AfterArrayOfDiffInstance(args);
            Assert.Equal(1, args.CacheCount);
        }

        protected override void AfterArrayOfObjectsSameInstance(
            CloneArguments<object[]> args)
        {
            base.AfterArrayOfObjectsSameInstance(args);
            Assert.Equal(1, args.CacheCount);
        }

        protected override void AfterArrayOfObjectsDiffInstance(
            CloneArguments<object[]> args)
        {
            base.AfterArrayOfObjectsDiffInstance(args);
            Assert.Equal(1, args.CacheCount);
        }

        protected override void AfterArrayOfSameInstance(
            CloneArguments<int[]> args)
        {
            base.AfterArrayOfSameInstance(args);
            Assert.Equal(1, args.CacheCount);
        }

        protected override void AfterDefaultInstance(
            CloneArguments<int> args)
        {
            base.AfterDefaultInstance(args);
            Assert.Equal(0, args.CacheCount);
        }

        protected override void AfterSingleInstance(
            CloneArguments<int> args)
        {
            base.AfterSingleInstance(args);
            Assert.Equal(0, args.CacheCount);
        }

        protected override void AfterArray2dOfDiffInstance(
            CloneArguments<int[][]> args)
        {
            base.AfterArray2dOfDiffInstance(args);
            Assert.Equal(args.Target.Length + 1, args.CacheCount);
        }

        protected override void AfterArray2dOfSameInstance(
            CloneArguments<int[][]> args)
        {
            base.AfterArray2dOfSameInstance(args);
            Assert.Equal(2, args.CacheCount);
        }

        protected override void AfterArrayOfDefaultInstance(
            CloneArguments<int[]> args)
        {
            base.AfterArrayOfDefaultInstance(args);
            Assert.Equal(1, args.CacheCount);
        }

        protected override void AfterArrayRank2OfDiffInstance(
            CloneArguments<int[,]> args)
        {
            base.AfterArrayRank2OfDiffInstance(args);
            Assert.Equal(1, args.CacheCount);
        }

        protected override void AfterArrayRank2OfSameInstance(
            CloneArguments<int[,]> args)
        {
            base.AfterArrayRank2OfSameInstance(args);
            Assert.Equal(1, args.CacheCount);
        }

        protected override void AfterArrayRank3OfDiffInstance(
            CloneArguments<int[,,]> args)
        {
            base.AfterArrayRank3OfDiffInstance(args);
            Assert.Equal(1, args.CacheCount);
        }

        protected override void AfterArrayRank3OfSameInstance(
            CloneArguments<int[,,]> args)
        {
            base.AfterArrayRank3OfSameInstance(args);
            Assert.Equal(1, args.CacheCount);
        }

        protected override void AfterListOfDiffInstance(
            CloneArguments<List<int>> args)
        {
            base.AfterListOfDiffInstance(args);
            Assert.Equal(1, args.CacheCount);
        }

        protected override void AfterListOfObjectDiffInstance(
            CloneArguments<List<object>> args)
        {
            base.AfterListOfObjectDiffInstance(args);
            Assert.Equal(1, args.CacheCount);
        }

        protected override void AfterListOfObjectSameInstance(
            CloneArguments<List<object>> args)
        {
            base.AfterListOfObjectSameInstance(args);
            Assert.Equal(1, args.CacheCount);
        }

        protected override void AfterListOfSameInstance(
            CloneArguments<List<int>> args)
        {
            base.AfterListOfSameInstance(args);
            Assert.Equal(1, args.CacheCount);
        }

        protected override void AfterKeyValuePairDiff(
            CloneArguments<KeyValuePair<int, int>> args)
        {
            base.AfterKeyValuePairDiff(args);
            Assert.Equal(0, args.CacheCount);
        }

        protected override void AfterKeyValuePairSame(
            CloneArguments<KeyValuePair<int, int>> args)
        {
            base.AfterKeyValuePairSame(args);
            Assert.Equal(0, args.CacheCount);
        }

        protected override void AfterTupleDiffInstance(
            CloneArguments<Tuple<int, int>> args)
        {
            base.AfterTupleDiffInstance(args);
            Assert.Equal(1, args.CacheCount);
        }

        protected override void AfterTupleSameInstance(
            CloneArguments<Tuple<int, int>> args)
        {
            base.AfterTupleSameInstance(args);
            Assert.Equal(1, args.CacheCount);
        }

        protected override void AfterDictionaryDiffInstance(
            CloneArguments<Dictionary<int, int>> args)
        {
            base.AfterDictionaryDiffInstance(args);
            Assert.Equal(1, args.CacheCount);
        }

        protected override void AfterDictionarySameInstance(
            CloneArguments<Dictionary<int, int>> args)
        {
            base.AfterDictionarySameInstance(args);
            Assert.Equal(1, args.CacheCount);
        }
    }
}