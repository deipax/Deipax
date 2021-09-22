using Benchmarks.DataAccess.Base;
using Dapper;
using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;
using UnitTests.Common;

namespace Benchmarks.DataAccess.Dapper
{
    public class DapperSelect : SelectBase
    {
        [Benchmark]
        public override IList<MultipleFieldClass> AllFieldsAsClass() => _dbConnection.Query<MultipleFieldClass>(SqliteSql.Sql).ToList();

        [Benchmark]
        public override IList<MultipleFieldClass> AllFieldsAsClass_Async() => _dbConnection.QueryAsync<MultipleFieldClass>(SqliteSql.Sql).Result.ToList();

        [Benchmark]
        public override IList<MultipleFieldStruct> AllFieldsAsStruct() => _dbConnection.Query<MultipleFieldStruct>(SqliteSql.Sql).ToList();

        [Benchmark]
        public override IList<MultipleFieldStruct> AllFieldsAsStruct_Async() => _dbConnection.QueryAsync<MultipleFieldStruct>(SqliteSql.Sql).Result.ToList();

        [Benchmark]
        public override IList<dynamic> DynamicList() => _dbConnection.Query(SqliteSql.Sql).ToList();

        [Benchmark]
        public override IList<dynamic> DynamicList_Async() => _dbConnection.QueryAsync(SqliteSql.Sql).Result.ToList();

        [Benchmark]
        public override dynamic QueryFirst() => _dbConnection.QueryFirst(SqliteSql.Sql);

        [Benchmark]
        public override dynamic QueryFirstOrDefault() => _dbConnection.QueryFirstOrDefault(SqliteSql.Sql);

        [Benchmark]
        public override dynamic QuerySingle() => _dbConnection.QuerySingle(SqliteSql.SqlLimitOne);

        [Benchmark]
        public override dynamic QuerySingleOrDefault() => _dbConnection.QuerySingleOrDefault(SqliteSql.SqlLimitOne);
    }
}
