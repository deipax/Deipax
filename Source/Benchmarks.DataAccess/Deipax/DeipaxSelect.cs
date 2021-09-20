using Benchmarks.DataAccess.Base;
using Deipax.DataAccess.Extensions;
using System.Collections.Generic;
using System.Data;
using UnitTests.Common;

namespace Benchmarks.DataAccess.Deipax
{
    public class DeipaxSelect : SelectBase
    {
        public override IEnumerable<MultipleFieldClass> AllFieldsAsClass()
        {
            return _dbConnection.AsEnumerable<MultipleFieldClass>(SqliteSql.Sql);
        }

        public override IEnumerable<MultipleFieldClass> AllFieldsAsClass_Async()
        {
            return _dbConnection.AsEnumerableAsync<MultipleFieldClass>(SqliteSql.Sql).Result;
        }

        public override IEnumerable<MultipleFieldStruct> AllFieldsAsStruct()
        {
            return _dbConnection.AsEnumerable<MultipleFieldStruct>(SqliteSql.Sql);
        }

        public override IEnumerable<MultipleFieldStruct> AllFieldsAsStruct_Async()
        {
            return _dbConnection.AsEnumerableAsync<MultipleFieldStruct>(SqliteSql.Sql).Result;
        }

        public override IEnumerable<dynamic> DynamicList()
        {
            return _dbConnection.AsEnumerable(SqliteSql.Sql);
        }

        public override IEnumerable<dynamic> DynamicList_Async()
        {
            return _dbConnection.AsEnumerableAsync(SqliteSql.Sql).Result;
        }

        public override dynamic QueryFirst()
        {
            return _dbConnection.First(SqliteSql.Sql);
        }

        public override dynamic QueryFirstOrDefault()
        {
            return _dbConnection.FirstOrDefault(SqliteSql.Sql);
        }

        public override dynamic QuerySingle()
        {
            return _dbConnection.Single(SqliteSql.SqlLimitOne);
        }

        public override dynamic QuerySingleOrDefault()
        {
            return _dbConnection.SingleOrDefault(SqliteSql.SqlLimitOne);
        }
    }
}