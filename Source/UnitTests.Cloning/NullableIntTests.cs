using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using UnitTests.Cloning.BaseTests;

namespace UnitTests.Cloning
{
    [TestClass]
    public class NullableIntTests : NullableIntBase
    {
        public NullableIntTests() : base(DeipaxCloneHelper.Instance)
        {
        }

        protected override void AfterArrayOfDiffInstance(
            CloneArguments<int?[]> args)
        {
            base.AfterArrayOfDiffInstance(args);
            Assert.AreEqual(1, args.CacheCount, "Cache count incorrect.");
        }

        protected override void AfterArrayOfObjectsSameInstance(
            CloneArguments<object[]> args)
        {
            base.AfterArrayOfObjectsSameInstance(args);
            Assert.AreEqual(1, args.CacheCount, "Cache count incorrect.");
        }

        protected override void AfterArrayOfObjectsDiffInstance(
            CloneArguments<object[]> args)
        {
            base.AfterArrayOfObjectsDiffInstance(args);
            Assert.AreEqual(1, args.CacheCount, "Cache count incorrect.");
        }

        protected override void AfterArrayOfSameInstance(
            CloneArguments<int?[]> args)
        {
            base.AfterArrayOfSameInstance(args);
            Assert.AreEqual(1, args.CacheCount, "Cache count incorrect.");
        }

        protected override void AfterDefaultInstance(
            CloneArguments<int?> args)
        {
            base.AfterDefaultInstance(args);
            Assert.AreEqual(0, args.CacheCount, "Cache count incorrect.");
        }

        protected override void AfterSingleInstance(
            CloneArguments<int?> args)
        {
            base.AfterSingleInstance(args);
            Assert.AreEqual(0, args.CacheCount, "Cache count incorrect.");
        }

        protected override void AfterArray2dOfDiffInstance(
            CloneArguments<int?[][]> args)
        {
            base.AfterArray2dOfDiffInstance(args);
            Assert.AreEqual(args.Target.Length + 1, args.CacheCount, "Cache count incorrect.");
        }

        protected override void AfterArray2dOfSameInstance(
            CloneArguments<int?[][]> args)
        {
            base.AfterArray2dOfSameInstance(args);
            Assert.AreEqual(2, args.CacheCount, "Cache count incorrect.");
        }

        protected override void ArrayOfDefaultInstance(
            CloneArguments<int?[]> args)
        {
            base.ArrayOfDefaultInstance(args);
            Assert.AreEqual(1, args.CacheCount, "Cache count incorrect.");
        }

        protected override void AfterArrayRank2OfDiffInstance(
            CloneArguments<int?[,]> args)
        {
            base.AfterArrayRank2OfDiffInstance(args);
            Assert.AreEqual(1, args.CacheCount, "Cache count incorrect.");
        }

        protected override void AfterArrayRank2OfSameInstance(
            CloneArguments<int?[,]> args)
        {
            base.AfterArrayRank2OfSameInstance(args);
            Assert.AreEqual(1, args.CacheCount, "Cache count incorrect.");
        }

        protected override void AfterArrayRank3OfDiffInstance(
            CloneArguments<int?[,,]> args)
        {
            base.AfterArrayRank3OfDiffInstance(args);
            Assert.AreEqual(1, args.CacheCount, "Cache count incorrect.");
        }

        protected override void AfterArrayRank3OfSameInstance(
            CloneArguments<int?[,,]> args)
        {
            base.AfterArrayRank3OfSameInstance(args);
            Assert.AreEqual(1, args.CacheCount, "Cache count incorrect.");
        }

        protected override void AfterListOfDiffInstance(
            CloneArguments<List<int?>> args)
        {
            base.AfterListOfDiffInstance(args);
            Assert.AreEqual(1, args.CacheCount, "Cache count incorrect.");
        }

        protected override void AfterListOfObjectDiffInstance(
            CloneArguments<List<object>> args)
        {
            base.AfterListOfObjectDiffInstance(args);
            Assert.AreEqual(1, args.CacheCount, "Cache count incorrect.");
        }

        protected override void AfterListOfObjectSameInstance(
            CloneArguments<List<object>> args)
        {
            base.AfterListOfObjectSameInstance(args);
            Assert.AreEqual(1, args.CacheCount, "Cache count incorrect.");
        }

        protected override void AfterListOfSameInstance(
            CloneArguments<List<int?>> args)
        {
            base.AfterListOfSameInstance(args);
            Assert.AreEqual(1, args.CacheCount, "Cache count incorrect.");
        }

        protected override void AfterKeyValuePairDiff(
            CloneArguments<KeyValuePair<int?, int?>> args)
        {
            base.AfterKeyValuePairDiff(args);
            Assert.AreEqual(0, args.CacheCount, "Cache count incorrect.");
        }

        protected override void AfterKeyValuePairSame(
            CloneArguments<KeyValuePair<int?, int?>> args)
        {
            base.AfterKeyValuePairSame(args);
            Assert.AreEqual(0, args.CacheCount, "Cache count incorrect.");
        }

        protected override void AfterTupleDiffInstance(
            CloneArguments<Tuple<int?, int?>> args)
        {
            base.AfterTupleDiffInstance(args);
            Assert.AreEqual(1, args.CacheCount, "Cache count incorrect.");
        }

        protected override void AfterTupleSameInstance(
            CloneArguments<Tuple<int?, int?>> args)
        {
            base.AfterTupleSameInstance(args);
            Assert.AreEqual(1, args.CacheCount, "Cache count incorrect.");
        }

        protected override void AfterDictionaryDiffInstance(
            CloneArguments<Dictionary<int?, int?>> args)
        {
            base.AfterDictionaryDiffInstance(args);
            Assert.AreEqual(1, args.CacheCount, "Cache count incorrect.");
        }

        protected override void AfterDictionarySameInstance(
            CloneArguments<Dictionary<int?, int?>> args)
        {
            base.AfterDictionarySameInstance(args);
            Assert.AreEqual(1, args.CacheCount, "Cache count incorrect.");
        }
    }
}