using BenchmarkDotNet.Attributes;
using DeepCopy;
using Deipax.Cloning.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using UnitTests.Common;

namespace Benchmarks.Cloning
{
    public class AdHoc
    {
        public AdHoc()
        {
            SimpleClass c = SimpleClass.Generate();
            var tmp = new Tuple<SimpleClass, SimpleClass, SimpleClass, SimpleClass, SimpleClass>(c, c, c, c, c);

            _source = Enumerable
                .Repeat(tmp, 10000)
                .Select(x => x)
                .ToList();
        }

        #region Field Members
        private List<Tuple<SimpleClass, SimpleClass, SimpleClass, SimpleClass, SimpleClass>> _source;
        #endregion

        [Benchmark]
        public int ListOfClasses_DeepCopy()
        {
            DeepCopier.Copy(_source);
            return 1;
        }

        [Benchmark]
        public int ListOfClasses_Deipax()
        {
            _source.GetClone();
            return 1;
        }
    }
}