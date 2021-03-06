﻿using System;
using System.Collections.Generic;
using UnitTests.Cloning.BaseTests;
using UnitTests.Common;
using Xunit;

namespace UnitTests.Cloning
{
    public class NullableComplexStructTests : NullableComplexStructBase
    {
        public NullableComplexStructTests() : base(DeipaxCloneHelper.Instance)
        {
        }

        protected override void AfterArrayOfDiffInstance(
            CloneArguments<ComplexStruct?[]> args)
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
            CloneArguments<ComplexStruct?[]> args)
        {
            base.AfterArrayOfSameInstance(args);
            Assert.Equal(2, args.Context.Count);
        }

        protected override void AfterDefaultInstance(
            CloneArguments<ComplexStruct?> args)
        {
            base.AfterDefaultInstance(args);
            Assert.Equal(0, args.Context.Count);
        }

        protected override void AfterSingleInstance(
            CloneArguments<ComplexStruct?> args)
        {
            base.AfterSingleInstance(args);
            Assert.Equal(1, args.Context.Count);
        }

        protected override void AfterJaggedArray2dOfDiffInstance(
            CloneArguments<ComplexStruct?[][]> args)
        {
            base.AfterJaggedArray2dOfDiffInstance(args);
            Assert.Equal(GetItemCount(args.Target) + 1, args.Context.Count);
        }

        protected override void AfterJaggedArray2dOfSameInstance(
            CloneArguments<ComplexStruct?[][]> args)
        {
            base.AfterJaggedArray2dOfSameInstance(args);
            Assert.Equal(GetItemCount(args.Target[0]) + 2, args.Context.Count);
        }

        protected override void AfterArrayOfDefaultInstance(
            CloneArguments<ComplexStruct?[]> args)
        {
            base.AfterArrayOfDefaultInstance(args);
            Assert.Equal(1, args.Context.Count);
        }

        protected override void AfterMultiDimArrayRank2OfDiffInstance(
            CloneArguments<ComplexStruct?[,]> args)
        {
            base.AfterMultiDimArrayRank2OfDiffInstance(args);
            var count = (args.Target.GetLength(0) * args.Target.GetLength(1)) + 1;
            Assert.Equal(count, args.Context.Count);
        }

        protected override void AfterMultiDimArrayRank2OfSameInstance(
            CloneArguments<ComplexStruct?[,]> args)
        {
            base.AfterMultiDimArrayRank2OfSameInstance(args);
            Assert.Equal(2, args.Context.Count);
        }

        protected override void AfterMultiDimArrayRank3OfDiffInstance(
            CloneArguments<ComplexStruct?[,,]> args)
        {
            base.AfterMultiDimArrayRank3OfDiffInstance(args);
            var count = (args.Target.GetLength(0) * args.Target.GetLength(1) * args.Target.GetLength(2)) + 1;
            Assert.Equal(count, args.Context.Count);
        }

        protected override void AfterArrayRank3OfSameInstance(
            CloneArguments<ComplexStruct?[,,]> args)
        {
            base.AfterArrayRank3OfSameInstance(args);
            Assert.Equal(2, args.Context.Count);
        }

        protected override void AfterListOfDiffInstance(
            CloneArguments<List<ComplexStruct?>> args)
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
            CloneArguments<List<ComplexStruct?>> args)
        {
            base.AfterListOfSameInstance(args);
            Assert.Equal(2, args.Context.Count);
        }

        protected override void AfterKeyValuePairDiff(
            CloneArguments<KeyValuePair<ComplexStruct?, ComplexStruct?>> args)
        {
            base.AfterKeyValuePairDiff(args);
            Assert.Equal(2, args.Context.Count);
        }

        protected override void AfterKeyValuePairSame(
            CloneArguments<KeyValuePair<ComplexStruct?, ComplexStruct?>> args)
        {
            base.AfterKeyValuePairSame(args);
            Assert.Equal(1, args.Context.Count);
        }

        protected override void AfterTupleDiffInstance(
            CloneArguments<Tuple<ComplexStruct?, ComplexStruct?>> args)
        {
            base.AfterTupleDiffInstance(args);
            Assert.Equal(3, args.Context.Count);
        }

        protected override void AfterTupleSameInstance(
            CloneArguments<Tuple<ComplexStruct?, ComplexStruct?>> args)
        {
            base.AfterTupleSameInstance(args);
            Assert.Equal(2, args.Context.Count);
        }

        protected override void AfterDictionaryDiffInstance(
            CloneArguments<Dictionary<ComplexStruct?, ComplexStruct?>> args)
        {
            base.AfterDictionaryDiffInstance(args);
            Assert.Equal((args.Target.Keys.Count * 2) + 1, args.Context.Count);
        }

        protected override void AfterDictionarySameInstance(
            CloneArguments<Dictionary<ComplexStruct?, ComplexStruct?>> args)
        {
            base.AfterDictionarySameInstance(args);
            Assert.Equal(args.Target.Keys.Count + 1, args.Context.Count);
        }
    }
}