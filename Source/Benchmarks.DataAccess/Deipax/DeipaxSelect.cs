using BenchmarkDotNet.Attributes;
using Benchmarks.DataAccess.Base;
using Deipax.DataAccess.Extensions;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using UnitTests.Common;

namespace Benchmarks.DataAccess.Deipax
{
    public class DeipaxDynamicSelect : DynamicSelect
    {
        [Benchmark]
        public override dynamic First() => _dbConnection.First(_selectOne);

        [Benchmark]
        public override dynamic FirstOrDefault() => _dbConnection.FirstOrDefault(_selectOne);

        [Benchmark]
        public override IList<dynamic> List() => _dbConnection.AsEnumerable(_selectAll).ToList();

        [Benchmark]
        public override IList<dynamic> List_Async() => _dbConnection.AsEnumerableAsync(_selectAll).Result.ToList();

        [Benchmark]
        public override dynamic Single() => _dbConnection.Single(_selectOne);

        [Benchmark]
        public override dynamic SingleOrDefault() => _dbConnection.SingleOrDefault(_selectOne);
    }

    public class DeipaxMultipleFieldClassSelect : MultipleFieldClassSelect
    {
        [Benchmark]
        public override MultipleFieldClass First() => _dbConnection.First<MultipleFieldClass>(_selectOne);

        [Benchmark]
        public override MultipleFieldClass FirstOrDefault() => _dbConnection.FirstOrDefault<MultipleFieldClass>(_selectOne);

        [Benchmark]
        public override IList<MultipleFieldClass> List() => _dbConnection.AsEnumerable<MultipleFieldClass>(_selectAll).ToList();

        [Benchmark]
        public override IList<MultipleFieldClass> List_Async() => _dbConnection.AsEnumerableAsync<MultipleFieldClass>(_selectAll).Result.ToList();

        [Benchmark]
        public override MultipleFieldClass Single() => _dbConnection.Single<MultipleFieldClass>(_selectOne);

        [Benchmark]
        public override MultipleFieldClass SingleOrDefault() => _dbConnection.SingleOrDefault<MultipleFieldClass>(_selectOne);
    }

    public class DeipaxMultipleFieldClassConvertSelect : MultipleFieldClassConvertSelect
    {
        [Benchmark]
        public override MultipleFieldClassConvert First() => _dbConnection.First<MultipleFieldClassConvert>(_selectOne);

        [Benchmark]
        public override MultipleFieldClassConvert FirstOrDefault() => _dbConnection.FirstOrDefault<MultipleFieldClassConvert>(_selectOne);

        [Benchmark]
        public override IList<MultipleFieldClassConvert> List() => _dbConnection.AsEnumerable<MultipleFieldClassConvert>(_selectAll).ToList();

        [Benchmark]
        public override IList<MultipleFieldClassConvert> List_Async() => _dbConnection.AsEnumerableAsync<MultipleFieldClassConvert>(_selectAll).Result.ToList();

        [Benchmark]
        public override MultipleFieldClassConvert Single() => _dbConnection.Single<MultipleFieldClassConvert>(_selectOne);

        [Benchmark]
        public override MultipleFieldClassConvert SingleOrDefault() => _dbConnection.SingleOrDefault<MultipleFieldClassConvert>(_selectOne);
    }

    public class DeipaxMultipleFieldStructSelect : MultipleFieldStructSelect
    {
        [Benchmark]
        public override MultipleFieldStruct First() => _dbConnection.First<MultipleFieldStruct>(_selectOne);

        [Benchmark]
        public override MultipleFieldStruct FirstOrDefault() => _dbConnection.FirstOrDefault<MultipleFieldStruct>(_selectOne);

        [Benchmark]
        public override IList<MultipleFieldStruct> List() => _dbConnection.AsEnumerable<MultipleFieldStruct>(_selectAll).ToList();

        [Benchmark]
        public override IList<MultipleFieldStruct> List_Async() => _dbConnection.AsEnumerableAsync<MultipleFieldStruct>(_selectAll).Result.ToList();

        [Benchmark]
        public override MultipleFieldStruct Single() => _dbConnection.Single<MultipleFieldStruct>(_selectOne);

        [Benchmark]
        public override MultipleFieldStruct SingleOrDefault() => _dbConnection.SingleOrDefault<MultipleFieldStruct>(_selectOne);
    }

    public class DeipaxMultipleFieldStructConvertSelect : MultipleFieldStructConvertSelect
    {
        [Benchmark]
        public override MultipleFieldStructConvert First() => _dbConnection.First<MultipleFieldStructConvert>(_selectOne);

        [Benchmark]
        public override MultipleFieldStructConvert FirstOrDefault() => _dbConnection.FirstOrDefault<MultipleFieldStructConvert>(_selectOne);

        [Benchmark]
        public override IList<MultipleFieldStructConvert> List() => _dbConnection.AsEnumerable<MultipleFieldStructConvert>(_selectAll).ToList();

        [Benchmark]
        public override IList<MultipleFieldStructConvert> List_Async() => _dbConnection.AsEnumerableAsync<MultipleFieldStructConvert>(_selectAll).Result.ToList();

        [Benchmark]
        public override MultipleFieldStructConvert Single() => _dbConnection.Single<MultipleFieldStructConvert>(_selectOne);

        [Benchmark]
        public override MultipleFieldStructConvert SingleOrDefault() => _dbConnection.SingleOrDefault<MultipleFieldStructConvert>(_selectOne);
    }
}