﻿using Benchmarks.Cloning.BaseClasses;
using Deipax.Cloning.Extensions;

namespace Benchmarks.Cloning.Deipax
{
    public class DoubleSimpleClassDeipax : DoubleSimpleClassBase
    {
        protected override X Clone<X>(X source)
        {
            return source.GetClone();
        }
    }
}