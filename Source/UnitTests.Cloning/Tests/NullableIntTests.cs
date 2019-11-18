using System;
using System.Collections.Generic;
using System.Linq;
using UnitTests.Cloning.BaseTests;
using Xunit;

namespace UnitTests.Cloning
{
    public class NullableIntTests : NullableIntBase
    {
        public NullableIntTests() : base(DeipaxCloneHelper.Instance)
        {
        }

        protected override void AfterArrayOfDiffInstance(
            CloneArguments<int?[]> args)
        {
            base.AfterArrayOfDiffInstance(args);
            Assert.Equal(1, args.Context.Count);
        }

        protected override void AfterArrayOfObjectsSameInstance(
            CloneArguments<object[]> args)
        {
            base.AfterArrayOfObjectsSameInstance(args);
            Assert.Equal(1, args.Context.Count);
        }

        protected override void AfterArrayOfObjectsDiffInstance(
            CloneArguments<object[]> args)
        {
            base.AfterArrayOfObjectsDiffInstance(args);
            Assert.Equal(1, args.Context.Count);
        }

        protected override void AfterArrayOfSameInstance(
            CloneArguments<int?[]> args)
        {
            base.AfterArrayOfSameInstance(args);
            Assert.Equal(1, args.Context.Count);
        }

        protected override void AfterDefaultInstance(
            CloneArguments<int?> args)
        {
            base.AfterDefaultInstance(args);
            Assert.Equal(0, args.Context.Count);
        }

        protected override void AfterSingleInstance(
            CloneArguments<int?> args)
        {
            base.AfterSingleInstance(args);
            Assert.Equal(0, args.Context.Count);
        }

        protected override void AfterJaggedArray2dOfDiffInstance(
            CloneArguments<int?[][]> args)
        {
            base.AfterJaggedArray2dOfDiffInstance(args);
            Assert.Equal(args.Target.Length + 1, args.Context.Count);
        }

        protected override void AfterJaggedArray2dOfSameInstance(
            CloneArguments<int?[][]> args)
        {
            base.AfterJaggedArray2dOfSameInstance(args);
            Assert.Single(args.Context.Keys.OfType<int?[][]>());
            Assert.Equal(args.Context.Keys.OfType<int?[]>().Count(), GetItemCount(args.Target[0]));
        }

        protected override void AfterArrayOfDefaultInstance(
            CloneArguments<int?[]> args)
        {
            base.AfterArrayOfDefaultInstance(args);
            Assert.Equal(1, args.Context.Count);
        }

        protected override void AfterMultiDimArrayRank2OfDiffInstance(
            CloneArguments<int?[,]> args)
        {
            base.AfterMultiDimArrayRank2OfDiffInstance(args);
            Assert.Equal(1, args.Context.Count);
        }

        protected override void AfterMultiDimArrayRank2OfSameInstance(
            CloneArguments<int?[,]> args)
        {
            base.AfterMultiDimArrayRank2OfSameInstance(args);
            Assert.Equal(1, args.Context.Count);
        }

        protected override void AfterMultiDimArrayRank3OfDiffInstance(
            CloneArguments<int?[,,]> args)
        {
            base.AfterMultiDimArrayRank3OfDiffInstance(args);
            Assert.Equal(1, args.Context.Count);
        }

        protected override void AfterArrayRank3OfSameInstance(
            CloneArguments<int?[,,]> args)
        {
            base.AfterArrayRank3OfSameInstance(args);
            Assert.Equal(1, args.Context.Count);
        }

        protected override void AfterListOfDiffInstance(
            CloneArguments<List<int?>> args)
        {
            base.AfterListOfDiffInstance(args);
            Assert.Equal(1, args.Context.Count);
        }

        protected override void AfterListOfObjectDiffInstance(
            CloneArguments<List<object>> args)
        {
            base.AfterListOfObjectDiffInstance(args);
            Assert.Equal(1, args.Context.Count);
        }

        protected override void AfterListOfObjectSameInstance(
            CloneArguments<List<object>> args)
        {
            base.AfterListOfObjectSameInstance(args);
            Assert.Equal(1, args.Context.Count);
        }

        protected override void AfterListOfSameInstance(
            CloneArguments<List<int?>> args)
        {
            base.AfterListOfSameInstance(args);
            Assert.Equal(1, args.Context.Count);
        }

        protected override void AfterKeyValuePairDiff(
            CloneArguments<KeyValuePair<int?, int?>> args)
        {
            base.AfterKeyValuePairDiff(args);
            Assert.Equal(0, args.Context.Count);
        }

        protected override void AfterKeyValuePairSame(
            CloneArguments<KeyValuePair<int?, int?>> args)
        {
            base.AfterKeyValuePairSame(args);
            Assert.Equal(0, args.Context.Count);
        }

        protected override void AfterTupleDiffInstance(
            CloneArguments<Tuple<int?, int?>> args)
        {
            base.AfterTupleDiffInstance(args);
            Assert.Equal(1, args.Context.Count);
        }

        protected override void AfterTupleSameInstance(
            CloneArguments<Tuple<int?, int?>> args)
        {
            base.AfterTupleSameInstance(args);
            Assert.Equal(1, args.Context.Count);
        }

        protected override void AfterDictionaryDiffInstance(
            CloneArguments<Dictionary<int?, int?>> args)
        {
            base.AfterDictionaryDiffInstance(args);
            Assert.Equal(1, args.Context.Count);
        }

        protected override void AfterDictionarySameInstance(
            CloneArguments<Dictionary<int?, int?>> args)
        {
            base.AfterDictionarySameInstance(args);
            Assert.Equal(1, args.Context.Count);
        }
    }
}