using BenchmarkDotNet.Attributes;
using Deipax.DataAccess.Extensions;
using System.Collections.Generic;
using System.Data;
using UnitTests.Common;

namespace Benchmarks.DataAccess.Base
{
    public abstract class SelectBase
    {
        #region Field Members
        protected IDbConnection _dbConnection;
        #endregion

        [GlobalSetup]
        public void GlobalSetup()
        {
            _dbConnection = DbHelper.GetNorthwind().Open();
        }

        [GlobalCleanup]
        public void GlobalCleanup()
        {
            _dbConnection.Dispose();
        }

        [Benchmark]
        public abstract IEnumerable<MultipleFieldClass> AllFieldsAsClass();

        [Benchmark]
        public abstract IEnumerable<MultipleFieldClass> AllFieldsAsClass_Async();

        [Benchmark]
        public abstract IEnumerable<MultipleFieldStruct> AllFieldsAsStruct();

        [Benchmark]
        public abstract IEnumerable<MultipleFieldStruct> AllFieldsAsStruct_Async();

        [Benchmark]
        public abstract IEnumerable<dynamic> DynamicList();

        [Benchmark]
        public abstract IEnumerable<dynamic> DynamicList_Async();

        [Benchmark]
        public abstract dynamic QueryFirst();

        [Benchmark]
        public abstract dynamic QueryFirstOrDefault();

        [Benchmark]
        public abstract dynamic QuerySingle();

        [Benchmark]
        public abstract dynamic QuerySingleOrDefault();
    }
}
