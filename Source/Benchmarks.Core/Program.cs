using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Diagnosers;
using BenchmarkDotNet.Exporters;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Toolchains.CsProj;
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
                .With(new Job[]
                {
                    ConfigureJob(Job.Default.With(CsProjCoreToolchain.NetCoreApp20)).AsBaseline(),
                    ConfigureJob(Job.Default.With(CsProjCoreToolchain.NetCoreApp22)),
                    ConfigureJob(Job.Default.With(CsProjCoreToolchain.NetCoreApp30)),
                    ConfigureJob(Job.Default.With(CsProjClassicNetToolchain.Net462)),
                    ConfigureJob(Job.Default.With(CsProjClassicNetToolchain.Net472)),
                    ConfigureJob(Job.Default.With(CsProjClassicNetToolchain.Net48)),
                })
                .With(DefaultConfig.Instance.GetLoggers().ToArray())
                .With(DefaultConfig.Instance.GetValidators().ToArray())
                .With(MarkdownExporter.Default)
                .With(MemoryDiagnoser.Default);
        }

        #region Private Members
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