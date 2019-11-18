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
            Assert.Equal(count, args.Context.Count);
        }

        protected override void AfterArrayOfObjectsSameInstance(
            CloneArguments<object[]> args)
        {
            base.AfterArrayOfObjectsSameInstance(args);
            Assert.Equal(3, args.Context.Count);
        }

        protected override void AfterArrayOfObjectsDiffInstance(
            CloneArguments<object[]> args)
        {
            base.AfterArrayOfObjectsDiffInstance(args);
            var count = (args.Target.Length * 2) + 1;
            Assert.Equal(count, args.Context.Count);
        }

        protected override void AfterArrayOfSameInstance(
            CloneArguments<DoubleSimpleClass[]> args)
        {
            base.AfterArrayOfSameInstance(args);
            Assert.Equal(3, args.Context.Count);
        }

        protected override void AfterDefaultInstance(
            CloneArguments<DoubleSimpleClass> args)
        {
            base.AfterDefaultInstance(args);
            Assert.Equal(0, args.Context.Count);
        }

        protected override void AfterSingleInstance(
            CloneArguments<DoubleSimpleClass> args)
        {
            base.AfterSingleInstance(args);
            Assert.Equal(2, args.Context.Count);
        }

        protected override void AfterJaggedArray2dOfDiffInstance(
            CloneArguments<DoubleSimpleClass[][]> args)
        {
            base.AfterJaggedArray2dOfDiffInstance(args);

            var itemCount = args.Target.Select(x => x.Length).Sum();

            var count = 1 + args.Target.Length + (itemCount * 2);
            Assert.Equal(count, args.Context.Count);
        }

        protected override void AfterJaggedArray2dOfSameInstance(
            CloneArguments<DoubleSimpleClass[][]> args)
        {
            base.AfterJaggedArray2dOfSameInstance(args);

            Assert.Single(args.Context.Keys.OfType<DoubleSimpleClass>());
            Assert.Single(args.Context.Keys.OfType<SimpleClass>());
            Assert.Single(args.Context.Keys.OfType<DoubleSimpleClass[][]>());
            Assert.Equal(args.Context.Keys.OfType<DoubleSimpleClass[]>().Count(), GetItemCount(args.Target[0]));
        }

        protected override void AfterArrayOfDefaultInstance(
            CloneArguments<DoubleSimpleClass[]> args)
        {
            base.AfterArrayOfDefaultInstance(args);
            Assert.Equal(1, args.Context.Count);
        }

        protected override void AfterMultiDimArrayRank2OfDiffInstance(
            CloneArguments<DoubleSimpleClass[,]> args)
        {
            base.AfterMultiDimArrayRank2OfDiffInstance(args);
            var count = ((args.Target.GetLength(0) * args.Target.GetLength(1)) * 2) + 1;
            Assert.Equal(count, args.Context.Count);
        }

        protected override void AfterMultiDimArrayRank2OfSameInstance(
            CloneArguments<DoubleSimpleClass[,]> args)
        {
            base.AfterMultiDimArrayRank2OfSameInstance(args);
            Assert.Equal(3, args.Context.Count);
        }

        protected override void AfterMultiDimArrayRank3OfDiffInstance(
            CloneArguments<DoubleSimpleClass[,,]> args)
        {
            base.AfterMultiDimArrayRank3OfDiffInstance(args);
            var count = ((args.Target.GetLength(0) * args.Target.GetLength(1) * args.Target.GetLength(2)) * 2) + 1;
            Assert.Equal(count, args.Context.Count);
        }

        protected override void AfterArrayRank3OfSameInstance(
            CloneArguments<DoubleSimpleClass[,,]> args)
        {
            base.AfterArrayRank3OfSameInstance(args);
            Assert.Equal(3, args.Context.Count);
        }

        protected override void AfterListOfDiffInstance(
            CloneArguments<List<DoubleSimpleClass>> args)
        {
            base.AfterListOfDiffInstance(args);
            var count = (args.Target.Count * 2) + 1;
            Assert.Equal(count, args.Context.Count);
        }

        protected override void AfterListOfObjectDiffInstance(
            CloneArguments<List<object>> args)
        {
            base.AfterListOfObjectDiffInstance(args);
            var count = (args.Target.Count * 2) + 1;
            Assert.Equal(count, args.Context.Count);
        }

        protected override void AfterListOfObjectSameInstance(
            CloneArguments<List<object>> args)
        {
            base.AfterListOfObjectSameInstance(args);
            Assert.Equal(3, args.Context.Count);
        }

        protected override void AfterListOfSameInstance(
            CloneArguments<List<DoubleSimpleClass>> args)
        {
            base.AfterListOfSameInstance(args);
            Assert.Equal(3, args.Context.Count);
        }

        protected override void AfterKeyValuePairDiff(
            CloneArguments<KeyValuePair<DoubleSimpleClass, DoubleSimpleClass>> args)
        {
            base.AfterKeyValuePairDiff(args);
            Assert.Equal(4, args.Context.Count);
        }

        protected override void AfterKeyValuePairSame(
            CloneArguments<KeyValuePair<DoubleSimpleClass, DoubleSimpleClass>> args)
        {
            base.AfterKeyValuePairSame(args);
            Assert.Equal(2, args.Context.Count);
        }

        protected override void AfterTupleDiffInstance(
            CloneArguments<Tuple<DoubleSimpleClass, DoubleSimpleClass>> args)
        {
            base.AfterTupleDiffInstance(args);
            Assert.Equal(5, args.Context.Count);
        }

        protected override void AfterTupleSameInstance(
            CloneArguments<Tuple<DoubleSimpleClass, DoubleSimpleClass>> args)
        {
            base.AfterTupleSameInstance(args);
            Assert.Equal(3, args.Context.Count);
        }

        protected override void AfterDictionaryDiffInstance(
            CloneArguments<Dictionary<DoubleSimpleClass, DoubleSimpleClass>> args)
        {
            base.AfterDictionaryDiffInstance(args);
            Assert.Equal((args.Target.Keys.Count * 4) + 1, args.Context.Count);
        }

        protected override void AfterDictionarySameInstance(
            CloneArguments<Dictionary<DoubleSimpleClass, DoubleSimpleClass>> args)
        {
            base.AfterDictionarySameInstance(args);
            Assert.Equal((args.Target.Keys.Count * 2) + 1, args.Context.Count);
        }
    }
}