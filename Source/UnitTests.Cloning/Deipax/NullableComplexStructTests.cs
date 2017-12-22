using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using UnitTests.Common;
using UnitTests.Cloning.BaseTests;

namespace UnitTests.Cloning.Deipax
{
    [TestClass]
    public class NullableComplexStructTests : NullableComplexStructBase
    {
        public NullableComplexStructTests() : base(DeipaxCloneHelper.Instance)
        {
        }

        protected override void AfterArrayOfDiffInstance(
            CloneArguments<ComplexStruct?[]> args)
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
            CloneArguments<ComplexStruct?[]> args)
        {
            base.AfterArrayOfSameInstance(args);
            Assert.AreEqual(2, args.CacheCount, "Cache count incorrect.");
        }

        protected override void AfterDefaultInstance(
            CloneArguments<ComplexStruct?> args)
        {
            base.AfterDefaultInstance(args);
            Assert.AreEqual(0, args.CacheCount, "Cache count incorrect.");
        }

        protected override void AfterSingleInstance(
            CloneArguments<ComplexStruct?> args)
        {
            base.AfterSingleInstance(args);
            Assert.AreEqual(1, args.CacheCount, "Cache count incorrect.");
        }

        protected override void AfterArray2dOfDiffInstance(
            CloneArguments<ComplexStruct?[][]> args)
        {
            base.AfterArray2dOfDiffInstance(args);
            Assert.AreEqual(GetItemCount(args.Target) + 1, args.CacheCount, "Cache count incorrect.");
        }

        protected override void AfterArray2dOfSameInstance(
            CloneArguments<ComplexStruct?[][]> args)
        {
            base.AfterArray2dOfSameInstance(args);
            Assert.AreEqual(GetItemCount(args.Target[0]) + 2, args.CacheCount, "Cache count incorrect.");
        }

        protected override void ArrayOfDefaultInstance(
            CloneArguments<ComplexStruct?[]> args)
        {
            base.ArrayOfDefaultInstance(args);
            Assert.AreEqual(1, args.CacheCount, "Cache count incorrect.");
        }

        protected override void AfterArrayRank2OfDiffInstance(
            CloneArguments<ComplexStruct?[,]> args)
        {
            base.AfterArrayRank2OfDiffInstance(args);
            var count = (args.Target.GetLength(0) * args.Target.GetLength(1)) + 1;
            Assert.AreEqual(count, args.CacheCount, "Cache count incorrect.");
        }

        protected override void AfterArrayRank2OfSameInstance(
            CloneArguments<ComplexStruct?[,]> args)
        {
            base.AfterArrayRank2OfSameInstance(args);
            Assert.AreEqual(2, args.CacheCount, "Cache count incorrect.");
        }

        protected override void AfterArrayRank3OfDiffInstance(
            CloneArguments<ComplexStruct?[,,]> args)
        {
            base.AfterArrayRank3OfDiffInstance(args);
            var count = (args.Target.GetLength(0) * args.Target.GetLength(1) * args.Target.GetLength(2)) + 1;
            Assert.AreEqual(count, args.CacheCount, "Cache count incorrect.");
        }

        protected override void AfterArrayRank3OfSameInstance(
            CloneArguments<ComplexStruct?[,,]> args)
        {
            base.AfterArrayRank3OfSameInstance(args);
            Assert.AreEqual(2, args.CacheCount, "Cache count incorrect.");
        }

        protected override void AfterListOfDiffInstance(
            CloneArguments<List<ComplexStruct?>> args)
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
            CloneArguments<List<ComplexStruct?>> args)
        {
            base.AfterListOfSameInstance(args);
            Assert.AreEqual(2, args.CacheCount, "Cache count incorrect.");
        }

        protected override void AfterKeyValuePairDiff(
            CloneArguments<KeyValuePair<ComplexStruct?, ComplexStruct?>> args)
        {
            base.AfterKeyValuePairDiff(args);
            Assert.AreEqual(2, args.CacheCount, "Cache count incorrect.");
        }

        protected override void AfterKeyValuePairSame(
            CloneArguments<KeyValuePair<ComplexStruct?, ComplexStruct?>> args)
        {
            base.AfterKeyValuePairSame(args);
            Assert.AreEqual(1, args.CacheCount, "Cache count incorrect.");
        }

        protected override void AfterTupleDiffInstance(
            CloneArguments<Tuple<ComplexStruct?, ComplexStruct?>> args)
        {
            base.AfterTupleDiffInstance(args);
            Assert.AreEqual(3, args.CacheCount, "Cache count incorrect.");
        }

        protected override void AfterTupleSameInstance(
            CloneArguments<Tuple<ComplexStruct?, ComplexStruct?>> args)
        {
            base.AfterTupleSameInstance(args);
            Assert.AreEqual(2, args.CacheCount, "Cache count incorrect.");
        }

        protected override void AfterDictionaryDiffInstance(
            CloneArguments<Dictionary<ComplexStruct?, ComplexStruct?>> args)
        {
            base.AfterDictionaryDiffInstance(args);
            Assert.AreEqual((args.Target.Keys.Count * 2) + 1, args.CacheCount, "Cache count incorrect.");
        }

        protected override void AfterDictionarySameInstance(
            CloneArguments<Dictionary<ComplexStruct?, ComplexStruct?>> args)
        {
            base.AfterDictionarySameInstance(args);
            Assert.AreEqual(args.Target.Keys.Count + 1, args.CacheCount, "Cache count incorrect.");
        }
    }
}