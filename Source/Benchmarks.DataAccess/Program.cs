using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Diagnosers;
using BenchmarkDotNet.Exporters;
using BenchmarkDotNet.Running;
using Benchmarks.DataAccess.Dapper;
using Benchmarks.DataAccess.Deipax;
using System.Linq;

namespace Benchmarks.DataAccess
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = ManualConfig
                .CreateEmpty()
                .With(DefaultConfig.Instance.GetAnalysers().ToArray())
                .With(DefaultConfig.Instance.GetColumnProviders().ToArray())
                .With(DefaultConfig.Instance.GetDiagnosers().ToArray())
                .With(DefaultConfig.Instance.GetFilters().ToArray())
                .With(DefaultConfig.Instance.GetHardwareCounters().ToArray())
                .With(DefaultConfig.Instance.GetJobs().ToArray())
                .With(DefaultConfig.Instance.GetLoggers().ToArray())
                .With(DefaultConfig.Instance.GetOrderProvider())
                .With(DefaultConfig.Instance.GetValidators().ToArray())
                .With(MarkdownExporter.Default)
                .With(MemoryDiagnoser.Default);

            //BenchmarkRunner.Run<DynamicBench>(config);
            //BenchmarkRunner.Run<DeipaxSelect>(config);
            //BenchmarkRunner.Run<DapperSelect>(config);

            BenchmarkRunner.Run<AdHoc>(config);
        }
    }
}