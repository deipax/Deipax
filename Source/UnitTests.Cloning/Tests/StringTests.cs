using System;
using System.Collections.Generic;
using UnitTests.Cloning.BaseTests;
using Xunit;

namespace UnitTests.Cloning
{
    public class StringTests : StringBase
    {
        public StringTests() : base(DeipaxCloneHelper.Instance)
        {
        }

        protected override void AfterArrayOfDiffInstance(
            CloneArguments<string[]> args)
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
            CloneArguments<string[]> args)
        {
            base.AfterArrayOfSameInstance(args);
            Assert.Equal(1, args.CacheCount);
        }

        protected override void AfterDefaultInstance(
            CloneArguments<string> args)
        {
            base.AfterDefaultInstance(args);
            Assert.Equal(0, args.CacheCount);
        }

        protected override void AfterSingleInstance(
            CloneArguments<string> args)
        {
            base.AfterSingleInstance(args);
            Assert.Equal(0, args.CacheCount);
        }

        protected override void AfterArray2dOfDiffInstance(
            CloneArguments<string[][]> args)
        {
            base.AfterArray2dOfDiffInstance(args);
            Assert.Equal(args.Target.Length + 1, args.CacheCount);
        }

        protected override void AfterArray2dOfSameInstance(
            CloneArguments<string[][]> args)
        {
            base.AfterArray2dOfSameInstance(args);
            Assert.Equal(2, args.CacheCount);
        }

        protected override void AfterArrayOfDefaultInstance(
            CloneArguments<string[]> args)
        {
            base.AfterArrayOfDefaultInstance(args);
            Assert.Equal(1, args.CacheCount);
        }

        protected override void AfterArrayRank2OfDiffInstance(
            CloneArguments<string[,]> args)
        {
            base.AfterArrayRank2OfDiffInstance(args);
            Assert.Equal(1, args.CacheCount);
        }

        protected override void AfterArrayRank2OfSameInstance(
            CloneArguments<string[,]> args)
        {
            base.AfterArrayRank2OfSameInstance(args);
            Assert.Equal(1, args.CacheCount);
        }

        protected override void AfterArrayRank3OfDiffInstance(
            CloneArguments<string[,,]> args)
        {
            base.AfterArrayRank3OfDiffInstance(args);
            Assert.Equal(1, args.CacheCount);
        }

        protected override void AfterArrayRank3OfSameInstance(
            CloneArguments<string[,,]> args)
        {
            base.AfterArrayRank3OfSameInstance(args);
            Assert.Equal(1, args.CacheCount);
        }

        protected override void AfterListOfDiffInstance(
            CloneArguments<List<string>> args)
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
            CloneArguments<List<string>> args)
        {
            base.AfterListOfSameInstance(args);
            Assert.Equal(1, args.CacheCount);
        }

        protected override void AfterKeyValuePairDiff(
            CloneArguments<KeyValuePair<string, string>> args)
        {
            base.AfterKeyValuePairDiff(args);
            Assert.Equal(0, args.CacheCount);
        }

        protected override void AfterKeyValuePairSame(
            CloneArguments<KeyValuePair<string, string>> args)
        {
            base.AfterKeyValuePairSame(args);
            Assert.Equal(0, args.CacheCount);
        }

        protected override void AfterTupleDiffInstance(
            CloneArguments<Tuple<string, string>> args)
        {
            base.AfterTupleDiffInstance(args);
            Assert.Equal(1, args.CacheCount);
        }

        protected override void AfterTupleSameInstance(
            CloneArguments<Tuple<string, string>> args)
        {
            base.AfterTupleSameInstance(args);
            Assert.Equal(1, args.CacheCount);
        }

        protected override void AfterDictionaryDiffInstance(
            CloneArguments<Dictionary<string, string>> args)
        {
            base.AfterDictionaryDiffInstance(args);
            Assert.Equal(1, args.CacheCount);
        }

        protected override void AfterDictionarySameInstance(
            CloneArguments<Dictionary<string, string>> args)
        {
            base.AfterDictionarySameInstance(args);
            Assert.Equal(1, args.CacheCount);
        }
    }
}