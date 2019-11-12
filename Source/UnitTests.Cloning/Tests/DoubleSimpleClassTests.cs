using System;
using System.Collections.Generic;
using System.Linq;
using UnitTests.Cloning.BaseTests;
using UnitTests.Common;
using Xunit;

namespace UnitTests.Cloning
{
    public class DoubleSimpleClassTests : DoubleSimpleClassBase
    {
        public DoubleSimpleClassTests() : base(DeipaxCloneHelper.Instance)
        {
        }

        protected override void AfterArrayOfDiffInstance(
            CloneArguments<DoubleSimpleClass[]> args)
        {
            base.AfterArrayOfDiffInstance(args);
            var count = (args.Target.Length * 2) + 1;
            Assert.Equal(count, args.CacheCount);
        }

        protected override void AfterArrayOfObjectsSameInstance(
            CloneArguments<object[]> args)
        {
            base.AfterArrayOfObjectsSameInstance(args);
            Assert.Equal(3, args.CacheCount);
        }

        protected override void AfterArrayOfObjectsDiffInstance(
            CloneArguments<object[]> args)
        {
            base.AfterArrayOfObjectsDiffInstance(args);
            var count = (args.Target.Length * 2) + 1;
            Assert.Equal(count, args.CacheCount);
        }

        protected override void AfterArrayOfSameInstance(
            CloneArguments<DoubleSimpleClass[]> args)
        {
            base.AfterArrayOfSameInstance(args);
            Assert.Equal(3, args.CacheCount);
        }

        protected override void AfterDefaultInstance(
            CloneArguments<DoubleSimpleClass> args)
        {
            base.AfterDefaultInstance(args);
            Assert.Equal(0, args.CacheCount);
        }

        protected override void AfterSingleInstance(
            CloneArguments<DoubleSimpleClass> args)
        {
            base.AfterSingleInstance(args);
            Assert.Equal(2, args.CacheCount);
        }

        protected override void AfterArray2dOfDiffInstance(
            CloneArguments<DoubleSimpleClass[][]> args)
        {
            base.AfterArray2dOfDiffInstance(args);

            var itemCount = args.Target.Select(x => x.Length).Sum();

            var count = 1 + args.Target.Length + (itemCount * 2);
            Assert.Equal(count, args.CacheCount);
        }

        protected override void AfterArray2dOfSameInstance(
            CloneArguments<DoubleSimpleClass[][]> args)
        {
            base.AfterArray2dOfSameInstance(args);
            var count = 2 + (GetItemCount(args.Target[0]) * 2);
            Assert.Equal(count, args.CacheCount);
        }

        protected override void AfterArrayOfDefaultInstance(
            CloneArguments<DoubleSimpleClass[]> args)
        {
            base.AfterArrayOfDefaultInstance(args);
            Assert.Equal(1, args.CacheCount);
        }

        protected override void AfterArrayRank2OfDiffInstance(
            CloneArguments<DoubleSimpleClass[,]> args)
        {
            base.AfterArrayRank2OfDiffInstance(args);
            var count = ((args.Target.GetLength(0) * args.Target.GetLength(1)) * 2) + 1;
            Assert.Equal(count, args.CacheCount);
        }

        protected override void AfterArrayRank2OfSameInstance(
            CloneArguments<DoubleSimpleClass[,]> args)
        {
            base.AfterArrayRank2OfSameInstance(args);
            Assert.Equal(3, args.CacheCount);
        }

        protected override void AfterArrayRank3OfDiffInstance(
            CloneArguments<DoubleSimpleClass[,,]> args)
        {
            base.AfterArrayRank3OfDiffInstance(args);
            var count = ((args.Target.GetLength(0) * args.Target.GetLength(1) * args.Target.GetLength(2)) * 2) + 1;
            Assert.Equal(count, args.CacheCount);
        }

        protected override void AfterArrayRank3OfSameInstance(
            CloneArguments<DoubleSimpleClass[,,]> args)
        {
            base.AfterArrayRank3OfSameInstance(args);
            Assert.Equal(3, args.CacheCount);
        }

        protected override void AfterListOfDiffInstance(
            CloneArguments<List<DoubleSimpleClass>> args)
        {
            base.AfterListOfDiffInstance(args);
            var count = (args.Target.Count * 2) + 1;
            Assert.Equal(count, args.CacheCount);
        }

        protected override void AfterListOfObjectDiffInstance(
            CloneArguments<List<object>> args)
        {
            base.AfterListOfObjectDiffInstance(args);
            var count = (args.Target.Count * 2) + 1;
            Assert.Equal(count, args.CacheCount);
        }

        protected override void AfterListOfObjectSameInstance(
            CloneArguments<List<object>> args)
        {
            base.AfterListOfObjectSameInstance(args);
            Assert.Equal(3, args.CacheCount);
        }

        protected override void AfterListOfSameInstance(
            CloneArguments<List<DoubleSimpleClass>> args)
        {
            base.AfterListOfSameInstance(args);
            Assert.Equal(3, args.CacheCount);
        }

        protected override void AfterKeyValuePairDiff(
            CloneArguments<KeyValuePair<DoubleSimpleClass, DoubleSimpleClass>> args)
        {
            base.AfterKeyValuePairDiff(args);
            Assert.Equal(4, args.CacheCount);
        }

        protected override void AfterKeyValuePairSame(
            CloneArguments<KeyValuePair<DoubleSimpleClass, DoubleSimpleClass>> args)
        {
            base.AfterKeyValuePairSame(args);
            Assert.Equal(2, args.CacheCount);
        }

        protected override void AfterTupleDiffInstance(
            CloneArguments<Tuple<DoubleSimpleClass, DoubleSimpleClass>> args)
        {
            base.AfterTupleDiffInstance(args);
            Assert.Equal(5, args.CacheCount);
        }

        protected override void AfterTupleSameInstance(
            CloneArguments<Tuple<DoubleSimpleClass, DoubleSimpleClass>> args)
        {
            base.AfterTupleSameInstance(args);
            Assert.Equal(3, args.CacheCount);
        }

        protected override void AfterDictionaryDiffInstance(
            CloneArguments<Dictionary<DoubleSimpleClass, DoubleSimpleClass>> args)
        {
            base.AfterDictionaryDiffInstance(args);
            Assert.Equal((args.Target.Keys.Count * 4) + 1, args.CacheCount);
        }

        protected override void AfterDictionarySameInstance(
            CloneArguments<Dictionary<DoubleSimpleClass, DoubleSimpleClass>> args)
        {
            base.AfterDictionarySameInstance(args);
            Assert.Equal((args.Target.Keys.Count * 2) + 1, args.CacheCount);
        }
    }
}