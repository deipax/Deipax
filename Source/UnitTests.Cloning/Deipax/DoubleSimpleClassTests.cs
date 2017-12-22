using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using UnitTests.Common;
using UnitTests.Cloning.BaseTests;

namespace UnitTests.Cloning.Deipax
{
    [TestClass]
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
            Assert.AreEqual(count, args.CacheCount, "Cache count incorrect.");
        }

        protected override void AfterArrayOfObjectsSameInstance(
            CloneArguments<object[]> args)
        {
            base.AfterArrayOfObjectsSameInstance(args);
            Assert.AreEqual(3, args.CacheCount, "Cache count incorrect.");
        }

        protected override void AfterArrayOfObjectsDiffInstance(
            CloneArguments<object[]> args)
        {
            base.AfterArrayOfObjectsDiffInstance(args);
            var count = (args.Target.Length * 2) + 1;
            Assert.AreEqual(count, args.CacheCount, "Cache count incorrect.");
        }

        protected override void AfterArrayOfSameInstance(
            CloneArguments<DoubleSimpleClass[]> args)
        {
            base.AfterArrayOfSameInstance(args);
            Assert.AreEqual(3, args.CacheCount, "Cache count incorrect.");
        }

        protected override void AfterDefaultInstance(
            CloneArguments<DoubleSimpleClass> args)
        {
            base.AfterDefaultInstance(args);
            Assert.AreEqual(0, args.CacheCount, "Cache count incorrect.");
        }

        protected override void AfterSingleInstance(
            CloneArguments<DoubleSimpleClass> args)
        {
            base.AfterSingleInstance(args);
            Assert.AreEqual(2, args.CacheCount, "Cache count incorrect.");
        }

        protected override void AfterArray2dOfDiffInstance(
            CloneArguments<DoubleSimpleClass[][]> args)
        {
            base.AfterArray2dOfDiffInstance(args);

            var itemCount = args.Target.Select(x => x.Length).Sum();

            var count = 1 + args.Target.Length + (itemCount * 2);
            Assert.AreEqual(count, args.CacheCount, "Cache count incorrect.");
        }

        protected override void AfterArray2dOfSameInstance(
            CloneArguments<DoubleSimpleClass[][]> args)
        {
            base.AfterArray2dOfSameInstance(args);
            var count = 2 + (GetItemCount(args.Target[0]) * 2);
            Assert.AreEqual(count, args.CacheCount, "Cache count incorrect.");
        }

        protected override void ArrayOfDefaultInstance(
            CloneArguments<DoubleSimpleClass[]> args)
        {
            base.ArrayOfDefaultInstance(args);
            Assert.AreEqual(1, args.CacheCount, "Cache count incorrect.");
        }

        protected override void AfterArrayRank2OfDiffInstance(
            CloneArguments<DoubleSimpleClass[,]> args)
        {
            base.AfterArrayRank2OfDiffInstance(args);
            var count = ((args.Target.GetLength(0) * args.Target.GetLength(1)) * 2) + 1;
            Assert.AreEqual(count, args.CacheCount, "Cache count incorrect.");
        }

        protected override void AfterArrayRank2OfSameInstance(
            CloneArguments<DoubleSimpleClass[,]> args)
        {
            base.AfterArrayRank2OfSameInstance(args);
            Assert.AreEqual(3, args.CacheCount, "Cache count incorrect.");
        }

        protected override void AfterArrayRank3OfDiffInstance(
            CloneArguments<DoubleSimpleClass[,,]> args)
        {
            base.AfterArrayRank3OfDiffInstance(args);
            var count = ((args.Target.GetLength(0) * args.Target.GetLength(1) * args.Target.GetLength(2)) * 2) + 1;
            Assert.AreEqual(count, args.CacheCount, "Cache count incorrect.");
        }

        protected override void AfterArrayRank3OfSameInstance(
            CloneArguments<DoubleSimpleClass[,,]> args)
        {
            base.AfterArrayRank3OfSameInstance(args);
            Assert.AreEqual(3, args.CacheCount, "Cache count incorrect.");
        }

        protected override void AfterListOfDiffInstance(
            CloneArguments<List<DoubleSimpleClass>> args)
        {
            base.AfterListOfDiffInstance(args);
            var count = (args.Target.Count * 2) + 1;
            Assert.AreEqual(count, args.CacheCount, "Cache count incorrect.");
        }

        protected override void AfterListOfObjectDiffInstance(
            CloneArguments<List<object>> args)
        {
            base.AfterListOfObjectDiffInstance(args);
            var count = (args.Target.Count * 2) + 1;
            Assert.AreEqual(count, args.CacheCount, "Cache count incorrect.");
        }

        protected override void AfterListOfObjectSameInstance(
            CloneArguments<List<object>> args)
        {
            base.AfterListOfObjectSameInstance(args);
            Assert.AreEqual(3, args.CacheCount, "Cache count incorrect.");
        }

        protected override void AfterListOfSameInstance(
            CloneArguments<List<DoubleSimpleClass>> args)
        {
            base.AfterListOfSameInstance(args);
            Assert.AreEqual(3, args.CacheCount, "Cache count incorrect.");
        }

        protected override void AfterKeyValuePairDiff(
            CloneArguments<KeyValuePair<DoubleSimpleClass, DoubleSimpleClass>> args)
        {
            base.AfterKeyValuePairDiff(args);
            Assert.AreEqual(4, args.CacheCount, "Cache count incorrect.");
        }

        protected override void AfterKeyValuePairSame(
            CloneArguments<KeyValuePair<DoubleSimpleClass, DoubleSimpleClass>> args)
        {
            base.AfterKeyValuePairSame(args);
            Assert.AreEqual(2, args.CacheCount, "Cache count incorrect.");
        }

        protected override void AfterTupleDiffInstance(
            CloneArguments<Tuple<DoubleSimpleClass, DoubleSimpleClass>> args)
        {
            base.AfterTupleDiffInstance(args);
            Assert.AreEqual(5, args.CacheCount, "Cache count incorrect.");
        }

        protected override void AfterTupleSameInstance(
            CloneArguments<Tuple<DoubleSimpleClass, DoubleSimpleClass>> args)
        {
            base.AfterTupleSameInstance(args);
            Assert.AreEqual(3, args.CacheCount, "Cache count incorrect.");
        }

        protected override void AfterDictionaryDiffInstance(
            CloneArguments<Dictionary<DoubleSimpleClass, DoubleSimpleClass>> args)
        {
            base.AfterDictionaryDiffInstance(args);
            Assert.AreEqual((args.Target.Keys.Count * 4) + 1, args.CacheCount, "Cache count incorrect.");
        }

        protected override void AfterDictionarySameInstance(
            CloneArguments<Dictionary<DoubleSimpleClass, DoubleSimpleClass>> args)
        {
            base.AfterDictionarySameInstance(args);
            Assert.AreEqual((args.Target.Keys.Count * 2) + 1, args.CacheCount, "Cache count incorrect.");
        }
    }
}