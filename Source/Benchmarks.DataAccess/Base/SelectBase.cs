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

        public abstract IList<MultipleFieldClass> AllFieldsAsClass();

        public abstract IList<MultipleFieldClass> AllFieldsAsClass_Async();

        public abstract IList<MultipleFieldStruct> AllFieldsAsStruct();

        public abstract IList<MultipleFieldStruct> AllFieldsAsStruct_Async();

        public abstract IList<dynamic> DynamicList();

        public abstract IList<dynamic> DynamicList_Async();

        public abstract dynamic QueryFirst();

        public abstract dynamic QueryFirstOrDefault();

        public abstract dynamic QuerySingle();

        public abstract dynamic QuerySingleOrDefault();
    }
}
