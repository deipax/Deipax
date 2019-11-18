using System;
using System.Collections.Generic;
using UnitTests.Cloning.BaseTests;
using UnitTests.Common;
using Xunit;

namespace UnitTests.Cloning
{
    public class ComplexClassTests : ComplexClassBase
    {
        public ComplexClassTests() : base(DeipaxCloneHelper.Instance)
        {
        }

        protected override void AfterArrayOfDiffInstance(
            CloneArguments<ComplexClass[]> args)
        {
            base.AfterArrayOfDiffInstance(args);
            Assert.Equal(args.Target.Length + 1, args.Context.Count);
        }

        protected override void AfterArrayOfObjectsSameInstance(
            CloneArguments<object[]> args)
        {
            base.AfterArrayOfObjectsSameInstance(args);
            Assert.Equal(2, args.Context.Count);
        }

        protected override void AfterArrayOfObjectsDiffInstance(
            CloneArguments<object[]> args)
        {
            base.AfterArrayOfObjectsDiffInstance(args);
            Assert.Equal(args.Target.Length + 1, args.Context.Count);
        }

        protected override void AfterArrayOfSameInstance(
            CloneArguments<ComplexClass[]> args)
        {
            base.AfterArrayOfSameInstance(args);
            Assert.Equal(2, args.Context.Count);
        }

        protected override void AfterDefaultInstance(
            CloneArguments<ComplexClass> args)
        {
            base.AfterDefaultInstance(args);
            Assert.Equal(0, args.Context.Count);
        }

        protected override void AfterSingleInstance(
            CloneArguments<ComplexClass> args)
        {
            base.AfterSingleInstance(args);
            Assert.Equal(1, args.Context.Count);
        }

        protected override void AfterJaggedArray2dOfDiffInstance(
            CloneArguments<ComplexClass[][]> args)
        {
            base.AfterJaggedArray2dOfDiffInstance(args);
            Assert.Equal(GetItemCount(args.Target) + 1, args.Context.Count);
        }

        protected override void AfterJaggedArray2dOfSameInstance(
            CloneArguments<ComplexClass[][]> args)
        {
            base.AfterJaggedArray2dOfSameInstance(args);
            Assert.Equal(GetItemCount(args.Target[0]) + 2, args.Context.Count);
        }

        protected override void AfterArrayOfDefaultInstance(
            CloneArguments<ComplexClass[]> args)
        {
            base.AfterArrayOfDefaultInstance(args);
            Assert.Equal(1, args.Context.Count);
        }

        protected override void AfterMultiDimArrayRank2OfDiffInstance(
            CloneArguments<ComplexClass[,]> args)
        {
            base.AfterMultiDimArrayRank2OfDiffInstance(args);
            var count = (args.Target.GetLength(0) * args.Target.GetLength(1)) + 1;
            Assert.Equal(count, args.Context.Count);
        }

        protected override void AfterMultiDimArrayRank2OfSameInstance(
            CloneArguments<ComplexClass[,]> args)
        {
            base.AfterMultiDimArrayRank2OfSameInstance(args);
            Assert.Equal(2, args.Context.Count);
        }

        protected override void AfterMultiDimArrayRank3OfDiffInstance(
            CloneArguments<ComplexClass[,,]> args)
        {
            base.AfterMultiDimArrayRank3OfDiffInstance(args);
            var count = (args.Target.GetLength(0) * args.Target.GetLength(1) * args.Target.GetLength(2)) + 1;
            Assert.Equal(count, args.Context.Count);
        }

        protected override void AfterArrayRank3OfSameInstance(
            CloneArguments<ComplexClass[,,]> args)
        {
            base.AfterArrayRank3OfSameInstance(args);
            Assert.Equal(2, args.Context.Count);
        }

        protected override void AfterListOfDiffInstance(
            CloneArguments<List<ComplexClass>> args)
        {
            base.AfterListOfDiffInstance(args);
            Assert.Equal(args.Target.Count + 1, args.Context.Count);
        }

        protected override void AfterListOfObjectDiffInstance(
            CloneArguments<List<object>> args)
        {
            base.AfterListOfObjectDiffInstance(args);
            Assert.Equal(args.Target.Count + 1, args.Context.Count);
        }

        protected override void AfterListOfObjectSameInstance(
            CloneArguments<List<object>> args)
        {
            base.AfterListOfObjectSameInstance(args);
            Assert.Equal(2, args.Context.Count);
        }

        protected override void AfterListOfSameInstance(
            CloneArguments<List<ComplexClass>> args)
        {
            base.AfterListOfSameInstance(args);
            Assert.Equal(2, args.Context.Count);
        }

        protected override void AfterKeyValuePairDiff(
            CloneArguments<KeyValuePair<ComplexClass, ComplexClass>> args)
        {
            base.AfterKeyValuePairDiff(args);
            Assert.Equal(2, args.Context.Count);
        }

        protected override void AfterKeyValuePairSame(
            CloneArguments<KeyValuePair<ComplexClass, ComplexClass>> args)
        {
            base.AfterKeyValuePairSame(args);
            Assert.Equal(1, args.Context.Count);
        }

        protected override void AfterTupleDiffInstance(
            CloneArguments<Tuple<ComplexClass, ComplexClass>> args)
        {
            base.AfterTupleDiffInstance(args);
            Assert.Equal(3, args.Context.Count);
        }

        protected override void AfterTupleSameInstance(
            CloneArguments<Tuple<ComplexClass, ComplexClass>> args)
        {
            base.AfterTupleSameInstance(args);
            Assert.Equal(2, args.Context.Count);
        }

        protected override void AfterDictionaryDiffInstance(
            CloneArguments<Dictionary<ComplexClass, ComplexClass>> args)
        {
            base.AfterDictionaryDiffInstance(args);
            Assert.Equal((args.Target.Keys.Count * 2) + 1, args.Context.Count);
        }

        protected override void AfterDictionarySameInstance(
            CloneArguments<Dictionary<ComplexClass, ComplexClass>> args)
        {
            base.AfterDictionarySameInstance(args);
            Assert.Equal(args.Target.Keys.Count + 1, args.Context.Count);
        }
    }
}