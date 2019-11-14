using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Diagnosers;
using BenchmarkDotNet.Exporters;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Toolchains.CsProj;
using Benchmarks.Cloning.Deipax;
using System.Linq;

namespace Benchmarks.Cloning
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
                .With(new Job[]
                {
                    ConfigureJob(Job.Default.With(CsProjCoreToolchain.NetCoreApp20)).AsBaseline(),
                    ConfigureJob(Job.Default.With(CsProjCoreToolchain.NetCoreApp22)),
                    ConfigureJob(Job.Default.With(CsProjCoreToolchain.NetCoreApp30)),
                    ConfigureJob(Job.Default.With(CsProjClassicNetToolchain.Net462)),
                    ConfigureJob(Job.Default.With(CsProjClassicNetToolchain.Net472)),
                })
                .With(DefaultConfig.Instance.GetLoggers().ToArray())
                .With(DefaultConfig.Instance.GetValidators().ToArray())
                .With(MarkdownExporter.Default)
                .With(MemoryDiagnoser.Default);

            RunDeipaxBenchmarks(config);
        }

        #region Private Members
        private static void RunDeipaxBenchmarks(IConfig config = null)
        {
            BenchmarkRunner.Run<IntDeipax>(config);
            BenchmarkRunner.Run<StringDeipax>(config);
            BenchmarkRunner.Run<ComplexClassDeipax>(config);
            BenchmarkRunner.Run<ComplexStructDeipax>(config);
            BenchmarkRunner.Run<SimpleClassDeipax>(config);
            BenchmarkRunner.Run<SimpleStructDeipax>(config);
            BenchmarkRunner.Run<DoubleSimpleClassDeipax>(config);
            BenchmarkRunner.Run<NullableIntDeipax>(config);
            BenchmarkRunner.Run<NullableSimpleStructDeipax>(config);
            BenchmarkRunner.Run<NullableComplexStructDeipax>(config);

            BenchmarkRunner.Run<AbstractDeipax>(config);
            BenchmarkRunner.Run<ArrayDeipax>(config);
            BenchmarkRunner.Run<ComplexRefTypeDeipax>(config);
            BenchmarkRunner.Run<ComplexValueTypeDeipax>(config);
            BenchmarkRunner.Run<KeyValueDeipax>(config);
            BenchmarkRunner.Run<NullableDeipax>(config);
            BenchmarkRunner.Run<PrimitiveDeipax>(config);
            BenchmarkRunner.Run<TupleDeipax>(config);
            BenchmarkRunner.Run<CanShallowCloneDeipax>(config);
        }

        private static Job ConfigureJob(Job source)
        {
            return source;
            /*
            return source
                .WithIterationCount(1)
                .WithWarmupCount(1);*/
        }
        #endregion
    }
}