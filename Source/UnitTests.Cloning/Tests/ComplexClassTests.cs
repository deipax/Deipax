using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using UnitTests.Common;
using UnitTests.Cloning.BaseTests;

namespace UnitTests.Cloning
{
    [TestClass]
    public class ComplexClassTests : ComplexClassBase
    {
        public ComplexClassTests() : base(DeipaxCloneHelper.Instance)
        {
        }

        protected override void AfterArrayOfDiffInstance(
            CloneArguments<ComplexClass[]> args)
        {
            base.AfterArrayOfDiffInstance(args);
            Assert.AreEqual(args.Target.Length + 1, args.CacheCount, "Cache count incorrect.");
        }

        protected override void AfterArrayOfObjectsSameInstance(
            CloneArguments<object[]> args)
        {
            base.AfterArrayOfObjectsSameInstance(args);
            Assert.AreEqual(2, args.CacheCount, "Cache count incorrect.");
        }

        protected override void AfterArrayOfObjectsDiffInstance(
            CloneArguments<object[]> args)
        {
            base.AfterArrayOfObjectsDiffInstance(args);
            Assert.AreEqual(args.Target.Length + 1, args.CacheCount, "Cache count incorrect.");
        }

        protected override void AfterArrayOfSameInstance(
            CloneArguments<ComplexClass[]> args)
        {
            base.AfterArrayOfSameInstance(args);
            Assert.AreEqual(2, args.CacheCount, "Cache count incorrect.");
        }

        protected override void AfterDefaultInstance(
            CloneArguments<ComplexClass> args)
        {
            base.AfterDefaultInstance(args);
            Assert.AreEqual(0, args.CacheCount, "Cache count incorrect.");
        }

        protected override void AfterSingleInstance(
            CloneArguments<ComplexClass> args)
        {
            base.AfterSingleInstance(args);
            Assert.AreEqual(1, args.CacheCount, "Cache count incorrect.");
        }

        protected override void AfterArray2dOfDiffInstance(
            CloneArguments<ComplexClass[][]> args)
        {
            base.AfterArray2dOfDiffInstance(args);
            Assert.AreEqual(GetItemCount(args.Target) + 1, args.CacheCount, "Cache count incorrect.");
        }

        protected override void AfterArray2dOfSameInstance(
            CloneArguments<ComplexClass[][]> args)
        {
            base.AfterArray2dOfSameInstance(args);
            Assert.AreEqual(GetItemCount(args.Target[0]) + 2, args.CacheCount, "Cache count incorrect.");
        }

        protected override void ArrayOfDefaultInstance(
            CloneArguments<ComplexClass[]> args)
        {
            base.ArrayOfDefaultInstance(args);
            Assert.AreEqual(1, args.CacheCount, "Cache count incorrect.");
        }

        protected override void AfterArrayRank2OfDiffInstance(
            CloneArguments<ComplexClass[,]> args)
        {
            base.AfterArrayRank2OfDiffInstance(args);
            var count = (args.Target.GetLength(0) * args.Target.GetLength(1)) + 1;
            Assert.AreEqual(count, args.CacheCount, "Cache count incorrect.");
        }

        protected override void AfterArrayRank2OfSameInstance(
            CloneArguments<ComplexClass[,]> args)
        {
            base.AfterArrayRank2OfSameInstance(args);
            Assert.AreEqual(2, args.CacheCount, "Cache count incorrect.");
        }

        protected override void AfterArrayRank3OfDiffInstance(
            CloneArguments<ComplexClass[,,]> args)
        {
            base.AfterArrayRank3OfDiffInstance(args);
            var count = (args.Target.GetLength(0) * args.Target.GetLength(1) * args.Target.GetLength(2)) + 1;
            Assert.AreEqual(count, args.CacheCount, "Cache count incorrect.");
        }

        protected override void AfterArrayRank3OfSameInstance(
            CloneArguments<ComplexClass[,,]> args)
        {
            base.AfterArrayRank3OfSameInstance(args);
            Assert.AreEqual(2, args.CacheCount, "Cache count incorrect.");
        }

        protected override void AfterListOfDiffInstance(
            CloneArguments<List<ComplexClass>> args)
        {
            base.AfterListOfDiffInstance(args);
            Assert.AreEqual(args.Target.Count + 1, args.CacheCount, "Cache count incorrect.");
        }

        protected override void AfterListOfObjectDiffInstance(
            CloneArguments<List<object>> args)
        {
            base.AfterListOfObjectDiffInstance(args);
            Assert.AreEqual(args.Target.Count + 1, args.CacheCount, "Cache count incorrect.");
        }

        protected override void AfterListOfObjectSameInstance(
            CloneArguments<List<object>> args)
        {
            base.AfterListOfObjectSameInstance(args);
            Assert.AreEqual(2, args.CacheCount, "Cache count incorrect.");
        }

        protected override void AfterListOfSameInstance(
            CloneArguments<List<ComplexClass>> args)
        {
            base.AfterListOfSameInstance(args);
            Assert.AreEqual(2, args.CacheCount, "Cache count incorrect.");
        }

        protected override void AfterKeyValuePairDiff(
            CloneArguments<KeyValuePair<ComplexClass, ComplexClass>> args)
        {
            base.AfterKeyValuePairDiff(args);
            Assert.AreEqual(2, args.CacheCount, "Cache count incorrect.");
        }

        protected override void AfterKeyValuePairSame(
            CloneArguments<KeyValuePair<ComplexClass, ComplexClass>> args)
        {
            base.AfterKeyValuePairSame(args);
            Assert.AreEqual(1, args.CacheCount, "Cache count incorrect.");
        }

        protected override void AfterTupleDiffInstance(
            CloneArguments<Tuple<ComplexClass, ComplexClass>> args)
        {
            base.AfterTupleDiffInstance(args);
            Assert.AreEqual(3, args.CacheCount, "Cache count incorrect.");
        }

        protected override void AfterTupleSameInstance(
            CloneArguments<Tuple<ComplexClass, ComplexClass>> args)
        {
            base.AfterTupleSameInstance(args);
            Assert.AreEqual(2, args.CacheCount, "Cache count incorrect.");
        }

        protected override void AfterDictionaryDiffInstance(
            CloneArguments<Dictionary<ComplexClass, ComplexClass>> args)
        {
            base.AfterDictionaryDiffInstance(args);
            Assert.AreEqual((args.Target.Keys.Count * 2) + 1, args.CacheCount, "Cache count incorrect.");
        }

        protected override void AfterDictionarySameInstance(
            CloneArguments<Dictionary<ComplexClass, ComplexClass>> args)
        {
            base.AfterDictionarySameInstance(args);
            Assert.AreEqual(args.Target.Keys.Count + 1, args.CacheCount, "Cache count incorrect.");
        }
    }
}