using Benchmarks.DataAccess.Base;
using Dapper;
using System.Collections.Generic;
using UnitTests.Common;

namespace Benchmarks.DataAccess.Dapper
{
    public class DapperSelect : SelectBase
    {
        public override IEnumerable<MultipleFieldClass> AllFieldsAsClass()
        {
            return _dbConnection.Query<MultipleFieldClass>(SqliteSql.Sql);
        }

        public override IEnumerable<MultipleFieldClass> AllFieldsAsClass_Async()
        {
            return _dbConnection.QueryAsync<MultipleFieldClass>(SqliteSql.Sql).Result;
        }

        public override IEnumerable<MultipleFieldStruct> AllFieldsAsStruct()
        {
            return _dbConnection.Query<MultipleFieldStruct>(SqliteSql.Sql);
        }

        public override IEnumerable<MultipleFieldStruct> AllFieldsAsStruct_Async()
        {
            return _dbConnection.QueryAsync<MultipleFieldStruct>(SqliteSql.Sql).Result;
        }

        public override IEnumerable<dynamic> DynamicList()
        {
            return _dbConnection.Query(SqliteSql.Sql);
        }

        public override IEnumerable<dynamic> DynamicList_Async()
        {
            return _dbConnection.QueryAsync(SqliteSql.Sql).Result;
        }

        public override dynamic QueryFirst()
        {
            return _dbConnection.QueryFirst(SqliteSql.Sql);
        }

        public override dynamic QueryFirstOrDefault()
        {
            return _dbConnection.QueryFirstOrDefault(SqliteSql.Sql);
        }

        public override dynamic QuerySingle()
        {
            return _dbConnection.QuerySingle(SqliteSql.SqlLimitOne);
        }

        public override dynamic QuerySingleOrDefault()
        {
            return _dbConnection.QuerySingleOrDefault(SqliteSql.SqlLimitOne);
        }
    }
}
