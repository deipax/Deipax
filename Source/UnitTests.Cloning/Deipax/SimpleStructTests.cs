using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using UnitTests.Common;
using UnitTests.Cloning.BaseTests;

namespace UnitTests.Cloning.Deipax
{
    [TestClass]
    public class SimpleStructTests : SimpleStructBase
    {
        public SimpleStructTests() : base(DeipaxCloneHelper.Instance)
        {       
        }

        protected override void AfterArrayOfDiffInstance(
            CloneArguments<SimpleStruct[]> args)
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
            CloneArguments<SimpleStruct[]> args)
        {
            base.AfterArrayOfSameInstance(args);
            Assert.AreEqual(1, args.CacheCount, "Cache count incorrect.");
        }

        protected override void AfterDefaultInstance(
            CloneArguments<SimpleStruct> args)
        {
            base.AfterDefaultInstance(args);
            Assert.AreEqual(0, args.CacheCount, "Cache count incorrect.");
        }

        protected override void AfterSingleInstance(
            CloneArguments<SimpleStruct> args)
        {
            base.AfterSingleInstance(args);
            Assert.AreEqual(0, args.CacheCount, "Cache count incorrect.");
        }

        protected override void AfterArray2dOfDiffInstance(
            CloneArguments<SimpleStruct[][]> args)
        {
            base.AfterArray2dOfDiffInstance(args);
            Assert.AreEqual(args.Target.Length + 1, args.CacheCount, "Cache count incorrect.");
        }

        protected override void AfterArray2dOfSameInstance(
            CloneArguments<SimpleStruct[][]> args)
        {
            base.AfterArray2dOfSameInstance(args);
            Assert.AreEqual(2, args.CacheCount, "Cache count incorrect.");
        }

        protected override void ArrayOfDefaultInstance(
            CloneArguments<SimpleStruct[]> args)
        {
            base.ArrayOfDefaultInstance(args);
            Assert.AreEqual(1, args.CacheCount, "Cache count incorrect.");
        }

        protected override void AfterArrayRank2OfDiffInstance(
            CloneArguments<SimpleStruct[,]> args)
        {
            base.AfterArrayRank2OfDiffInstance(args);
            Assert.AreEqual(1, args.CacheCount, "Cache count incorrect.");
        }

        protected override void AfterArrayRank2OfSameInstance(
            CloneArguments<SimpleStruct[,]> args)
        {
            base.AfterArrayRank2OfSameInstance(args);
            Assert.AreEqual(1, args.CacheCount, "Cache count incorrect.");
        }

        protected override void AfterArrayRank3OfDiffInstance(
            CloneArguments<SimpleStruct[,,]> args)
        {
            base.AfterArrayRank3OfDiffInstance(args);
            Assert.AreEqual(1, args.CacheCount, "Cache count incorrect.");
        }

        protected override void AfterArrayRank3OfSameInstance(
            CloneArguments<SimpleStruct[,,]> args)
        {
            base.AfterArrayRank3OfSameInstance(args);
            Assert.AreEqual(1, args.CacheCount, "Cache count incorrect.");
        }

        protected override void AfterListOfDiffInstance(
            CloneArguments<List<SimpleStruct>> args)
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
            CloneArguments<List<SimpleStruct>> args)
        {
            base.AfterListOfSameInstance(args);
            Assert.AreEqual(1, args.CacheCount, "Cache count incorrect.");
        }

        protected override void AfterKeyValuePairDiff(
            CloneArguments<KeyValuePair<SimpleStruct, SimpleStruct>> args)
        {
            base.AfterKeyValuePairDiff(args);
            Assert.AreEqual(0, args.CacheCount, "Cache count incorrect.");
        }

        protected override void AfterKeyValuePairSame(
            CloneArguments<KeyValuePair<SimpleStruct, SimpleStruct>> args)
        {
            base.AfterKeyValuePairSame(args);
            Assert.AreEqual(0, args.CacheCount, "Cache count incorrect.");
        }

        protected override void AfterTupleDiffInstance(
            CloneArguments<Tuple<SimpleStruct, SimpleStruct>> args)
        {
            base.AfterTupleDiffInstance(args);
            Assert.AreEqual(1, args.CacheCount, "Cache count incorrect.");
        }

        protected override void AfterTupleSameInstance(
            CloneArguments<Tuple<SimpleStruct, SimpleStruct>> args)
        {
            base.AfterTupleSameInstance(args);
            Assert.AreEqual(1, args.CacheCount, "Cache count incorrect.");
        }

        protected override void AfterDictionaryDiffInstance(
            CloneArguments<Dictionary<SimpleStruct, SimpleStruct>> args)
        {
            base.AfterDictionaryDiffInstance(args);
            Assert.AreEqual(1, args.CacheCount, "Cache count incorrect.");
        }

        protected override void AfterDictionarySameInstance(
            CloneArguments<Dictionary<SimpleStruct, SimpleStruct>> args)
        {
            base.AfterDictionarySameInstance(args);
            Assert.AreEqual(1, args.CacheCount, "Cache count incorrect.");
        }
    }
}