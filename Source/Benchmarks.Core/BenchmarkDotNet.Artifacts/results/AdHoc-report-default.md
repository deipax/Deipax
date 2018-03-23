
BenchmarkDotNet=v0.10.13, OS=Windows 7 SP1 (6.1.7601.0)
Intel Xeon CPU E5-1650 v3 3.50GHz, 1 CPU, 12 logical cores and 6 physical cores
Frequency=3410087 Hz, Resolution=293.2477 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                  Method |       Mean |     Error |    StdDev |     Median |  Gen 0 | Allocated |
------------------------ |-----------:|----------:|----------:|-----------:|-------:|----------:|
 ConvertTo_FromIntToLong | 26.1464 ns | 1.1634 ns | 3.4304 ns | 25.6902 ns | 0.0038 |      24 B |
   Convert_FromIntToLong |  0.0431 ns | 0.0309 ns | 0.0797 ns |  0.0000 ns |      - |       0 B |
