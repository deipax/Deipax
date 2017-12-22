﻿using Benchmarks.Cloning.BaseClasses_Old;
using DeepCopy;

namespace Benchmarks.Cloning.DeepCopy
{
    public class ComplexRefTypeDeepCopy : ComplexRefTypeBase
    {
        protected override T GetClone<T>(T source)
        {
            return DeepCopier.Copy(source);
        }
    }
}