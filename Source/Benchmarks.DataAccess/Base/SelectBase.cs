using BenchmarkDotNet.Attributes;
using Deipax.DataAccess.Extensions;
using System.Collections.Generic;
using System.Data;
using UnitTests.Common;

namespace Benchmarks.DataAccess.Base
{
    public abstract class DynamicSelect : SelectBase<dynamic>
    {
    }

    public abstract class MultipleFieldStructSelect : SelectBase<MultipleFieldStruct>
    {
    }

    public abstract class MultipleFieldStructConvertSelect : SelectBase<MultipleFieldStructConvert>
    {
    }

    public abstract class MultipleFieldClassSelect : SelectBase<MultipleFieldClass>
    {
    }

    public abstract class MultipleFieldClassConvertSelect : SelectBase<MultipleFieldClassConvert>
    {
    }

    public abstract class SelectBase<T>
    {
        #region Field Members
        protected IDbConnection _dbConnection;
        protected string _selectAll = SqliteSql.Sql;
        protected string _selectOne = SqliteSql.SqlLimitOne;
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

        public abstract IList<T> List();

        public abstract IList<T> List_Async();

        public abstract T First();

        public abstract T FirstOrDefault();

        public abstract T Single();

        public abstract T SingleOrDefault();
    }
}
