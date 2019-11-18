using System;
using System.Collections.Generic;
using System.Linq;
using UnitTests.Cloning.BaseTests;
using UnitTests.Common;
using Xunit;

namespace UnitTests.Cloning
{
    public class SimpleStructTests : SimpleStructBase
    {
        public SimpleStructTests() : base(DeipaxCloneHelper.Instance)
        {
        }

        protected override void AfterArrayOfDiffInstance(
            CloneArguments<SimpleStruct[]> args)
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
            CloneArguments<SimpleStruct[]> args)
        {
            base.AfterArrayOfSameInstance(args);
            Assert.Equal(1, args.Context.Count);
        }

        protected override void AfterDefaultInstance(
            CloneArguments<SimpleStruct> args)
        {
            base.AfterDefaultInstance(args);
            Assert.Equal(0, args.Context.Count);
        }

        protected override void AfterSingleInstance(
            CloneArguments<SimpleStruct> args)
        {
            base.AfterSingleInstance(args);
            Assert.Equal(0, args.Context.Count);
        }

        protected override void AfterJaggedArray2dOfDiffInstance(
            CloneArguments<SimpleStruct[][]> args)
        {
            base.AfterJaggedArray2dOfDiffInstance(args);
            Assert.Equal(args.Target.Length + 1, args.Context.Count);
        }

        protected override void AfterJaggedArray2dOfSameInstance(
            CloneArguments<SimpleStruct[][]> args)
        {
            base.AfterJaggedArray2dOfSameInstance(args);
            Assert.Single(args.Context.Keys.OfType<SimpleStruct[][]>());
            Assert.Equal(args.Context.Keys.OfType<SimpleStruct[]>().Count(), GetItemCount(args.Target[0]));
        }

        protected override void AfterArrayOfDefaultInstance(
            CloneArguments<SimpleStruct[]> args)
        {
            base.AfterArrayOfDefaultInstance(args);
            Assert.Equal(1, args.Context.Count);
        }

        protected override void AfterMultiDimArrayRank2OfDiffInstance(
            CloneArguments<SimpleStruct[,]> args)
        {
            base.AfterMultiDimArrayRank2OfDiffInstance(args);
            Assert.Equal(1, args.Context.Count);
        }

        protected override void AfterMultiDimArrayRank2OfSameInstance(
            CloneArguments<SimpleStruct[,]> args)
        {
            base.AfterMultiDimArrayRank2OfSameInstance(args);
            Assert.Equal(1, args.Context.Count);
        }

        protected override void AfterMultiDimArrayRank3OfDiffInstance(
            CloneArguments<SimpleStruct[,,]> args)
        {
            base.AfterMultiDimArrayRank3OfDiffInstance(args);
            Assert.Equal(1, args.Context.Count);
        }

        protected override void AfterArrayRank3OfSameInstance(
            CloneArguments<SimpleStruct[,,]> args)
        {
            base.AfterArrayRank3OfSameInstance(args);
            Assert.Equal(1, args.Context.Count);
        }

        protected override void AfterListOfDiffInstance(
            CloneArguments<List<SimpleStruct>> args)
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
            CloneArguments<List<SimpleStruct>> args)
        {
            base.AfterListOfSameInstance(args);
            Assert.Equal(1, args.Context.Count);
        }

        protected override void AfterKeyValuePairDiff(
            CloneArguments<KeyValuePair<SimpleStruct, SimpleStruct>> args)
        {
            base.AfterKeyValuePairDiff(args);
            Assert.Equal(0, args.Context.Count);
        }

        protected override void AfterKeyValuePairSame(
            CloneArguments<KeyValuePair<SimpleStruct, SimpleStruct>> args)
        {
            base.AfterKeyValuePairSame(args);
            Assert.Equal(0, args.Context.Count);
        }

        protected override void AfterTupleDiffInstance(
            CloneArguments<Tuple<SimpleStruct, SimpleStruct>> args)
        {
            base.AfterTupleDiffInstance(args);
            Assert.Equal(1, args.Context.Count);
        }

        protected override void AfterTupleSameInstance(
            CloneArguments<Tuple<SimpleStruct, SimpleStruct>> args)
        {
            base.AfterTupleSameInstance(args);
            Assert.Equal(1, args.Context.Count);
        }

        protected override void AfterDictionaryDiffInstance(
            CloneArguments<Dictionary<SimpleStruct, SimpleStruct>> args)
        {
            base.AfterDictionaryDiffInstance(args);
            Assert.Equal(1, args.Context.Count);
        }

        protected override void AfterDictionarySameInstance(
            CloneArguments<Dictionary<SimpleStruct, SimpleStruct>> args)
        {
            base.AfterDictionarySameInstance(args);
            Assert.Equal(1, args.Context.Count);
        }
    }
}