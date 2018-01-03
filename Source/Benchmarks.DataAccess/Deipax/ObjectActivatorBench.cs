using BenchmarkDotNet.Attributes;
using Deipax.Core.Common;
using System;
using UnitTests.Common;

namespace Benchmarks.DataAccess.Deipax
{
    public class ObjectActivatorBench
    {
        #region Field
        private readonly static Type _type = typeof(GrandChildClass);
        #endregion

        [Benchmark]
        public void IntializeClassByType()
        {
            var tmp = ObjectActivator.GetActivator(_type).Create();
        }

        [Benchmark]
        public void IntializeClassByGeneric()
        {
            var tmp = ObjectActivator<GrandChildClass>.Create();
        }
    }
}