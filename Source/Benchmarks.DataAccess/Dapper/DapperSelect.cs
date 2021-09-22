using BenchmarkDotNet.Attributes;
using Benchmarks.DataAccess.Base;
using Dapper;
using System.Collections.Generic;
using System.Linq;
using UnitTests.Common;

namespace Benchmarks.DataAccess.Dapper
{
    public class DapperDynamicSelect : DynamicSelect
    {
        [Benchmark]
        public override dynamic First() => _dbConnection.QueryFirst(_selectOne);

        [Benchmark]
        public override dynamic FirstOrDefault() => _dbConnection.QueryFirstOrDefault(_selectOne);

        [Benchmark]
        public override IList<dynamic> List() => _dbConnection.Query(_selectAll).ToList();

        [Benchmark]
        public override IList<dynamic> List_Async() => _dbConnection.QueryAsync(_selectAll).Result.ToList();

        [Benchmark]
        public override dynamic Single() => _dbConnection.QuerySingle(_selectOne);

        [Benchmark]
        public override dynamic SingleOrDefault() => _dbConnection.QuerySingleOrDefault(_selectOne);
    }

    public class DapperMultipleFieldClassSelect : MultipleFieldClassSelect
    {
        [Benchmark]
        public override MultipleFieldClass First() => _dbConnection.QueryFirst<MultipleFieldClass>(_selectOne);

        [Benchmark]
        public override MultipleFieldClass FirstOrDefault() => _dbConnection.QueryFirstOrDefault<MultipleFieldClass>(_selectOne);

        [Benchmark]
        public override IList<MultipleFieldClass> List() => _dbConnection.Query<MultipleFieldClass>(_selectAll).ToList();

        [Benchmark]
        public override IList<MultipleFieldClass> List_Async() => _dbConnection.QueryAsync<MultipleFieldClass>(_selectAll).Result.ToList();

        [Benchmark]
        public override MultipleFieldClass Single() => _dbConnection.QuerySingle<MultipleFieldClass>(_selectOne);

        [Benchmark]
        public override MultipleFieldClass SingleOrDefault() => _dbConnection.QuerySingleOrDefault<MultipleFieldClass>(_selectOne);
    }

    public class DapperMultipleFieldClassConvertSelect : MultipleFieldClassConvertSelect
    {
        [Benchmark]
        public override MultipleFieldClassConvert First() => _dbConnection.QueryFirst<MultipleFieldClassConvert>(_selectOne);

        [Benchmark]
        public override MultipleFieldClassConvert FirstOrDefault() => _dbConnection.QueryFirstOrDefault<MultipleFieldClassConvert>(_selectOne);

        [Benchmark]
        public override IList<MultipleFieldClassConvert> List() => _dbConnection.Query<MultipleFieldClassConvert>(_selectAll).ToList();

        [Benchmark]
        public override IList<MultipleFieldClassConvert> List_Async() => _dbConnection.QueryAsync<MultipleFieldClassConvert>(_selectAll).Result.ToList();

        [Benchmark]
        public override MultipleFieldClassConvert Single() => _dbConnection.QuerySingle<MultipleFieldClassConvert>(_selectOne);

        [Benchmark]
        public override MultipleFieldClassConvert SingleOrDefault() => _dbConnection.QuerySingleOrDefault<MultipleFieldClassConvert>(_selectOne);
    }

    public class DapperMultipleFieldStructSelect : MultipleFieldStructSelect
    {
        [Benchmark]
        public override MultipleFieldStruct First() => _dbConnection.QueryFirst<MultipleFieldStruct>(_selectOne);

        [Benchmark]
        public override MultipleFieldStruct FirstOrDefault() => _dbConnection.QueryFirstOrDefault<MultipleFieldStruct>(_selectOne);

        [Benchmark]
        public override IList<MultipleFieldStruct> List() => _dbConnection.Query<MultipleFieldStruct>(_selectAll).ToList();

        [Benchmark]
        public override IList<MultipleFieldStruct> List_Async() => _dbConnection.QueryAsync<MultipleFieldStruct>(_selectAll).Result.ToList();

        [Benchmark]
        public override MultipleFieldStruct Single() => _dbConnection.QuerySingle<MultipleFieldStruct>(_selectOne);

        [Benchmark]
        public override MultipleFieldStruct SingleOrDefault() => _dbConnection.QuerySingleOrDefault<MultipleFieldStruct>(_selectOne);
    }

    public class DapperMultipleFieldStructConvertSelect : MultipleFieldStructConvertSelect
    {
        [Benchmark]
        public override MultipleFieldStructConvert First() => _dbConnection.QueryFirst<MultipleFieldStructConvert>(_selectOne);

        [Benchmark]
        public override MultipleFieldStructConvert FirstOrDefault() => _dbConnection.QueryFirstOrDefault<MultipleFieldStructConvert>(_selectOne);

        [Benchmark]
        public override IList<MultipleFieldStructConvert> List() => _dbConnection.Query<MultipleFieldStructConvert>(_selectAll).ToList();

        [Benchmark]
        public override IList<MultipleFieldStructConvert> List_Async() => _dbConnection.QueryAsync<MultipleFieldStructConvert>(_selectAll).Result.ToList();

        [Benchmark]
        public override MultipleFieldStructConvert Single() => _dbConnection.QuerySingle<MultipleFieldStructConvert>(_selectOne);

        [Benchmark]
        public override MultipleFieldStructConvert SingleOrDefault() => _dbConnection.QuerySingleOrDefault<MultipleFieldStructConvert>(_selectOne);
    }
}
