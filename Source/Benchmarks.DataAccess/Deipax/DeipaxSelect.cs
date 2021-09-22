using BenchmarkDotNet.Attributes;
using Benchmarks.DataAccess.Base;
using Deipax.DataAccess.Extensions;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using UnitTests.Common;

namespace Benchmarks.DataAccess.Deipax
{
    public class DeipaxSelect : SelectBase
    {
        [Benchmark]
        public override IList<MultipleFieldClass> AllFieldsAsClass() => _dbConnection.AsEnumerable<MultipleFieldClass>(SqliteSql.Sql).ToList();

        [Benchmark]
        public override IList<MultipleFieldClass> AllFieldsAsClass_Async() => _dbConnection.AsEnumerableAsync<MultipleFieldClass>(SqliteSql.Sql).Result.ToList();

        [Benchmark]
        public override IList<MultipleFieldStruct> AllFieldsAsStruct() => _dbConnection.AsEnumerable<MultipleFieldStruct>(SqliteSql.Sql).ToList();

        [Benchmark]
        public override IList<MultipleFieldStruct> AllFieldsAsStruct_Async() => _dbConnection.AsEnumerableAsync<MultipleFieldStruct>(SqliteSql.Sql).Result.ToList();

        [Benchmark]
        public override IList<dynamic> DynamicList() => _dbConnection.AsEnumerable(SqliteSql.Sql).ToList();

        [Benchmark]
        public override IList<dynamic> DynamicList_Async() => _dbConnection.AsEnumerableAsync(SqliteSql.Sql).Result.ToList();

        [Benchmark]
        public override dynamic QueryFirst() => _dbConnection.First(SqliteSql.Sql);

        [Benchmark]
        public override dynamic QueryFirstOrDefault() => _dbConnection.FirstOrDefault(SqliteSql.Sql);

        [Benchmark]
        public override dynamic QuerySingle() => _dbConnection.Single(SqliteSql.SqlLimitOne);

        [Benchmark]
        public override dynamic QuerySingleOrDefault() => _dbConnection.SingleOrDefault(SqliteSql.SqlLimitOne);
    }
}