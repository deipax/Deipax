
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.403
  [Host]   : .NET Core 5.0.12 (CoreCLR 5.0.1221.52207, CoreFX 5.0.1221.52207), X64 RyuJIT
  ShortRun : .NET Core 3.1.21 (CoreCLR 4.700.21.51404, CoreFX 4.700.21.51508), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

            Method |     Toolchain |     Mean |    Error |   StdDev |      Min |      Max |   Median | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------ |-------------- |---------:|---------:|---------:|---------:|---------:|---------:|------:|--------:|-------:|------:|------:|----------:|
      GetNewSymbol | .NET Core 3.1 | 16.76 ns | 2.854 ns | 0.156 ns | 16.58 ns | 16.89 ns | 16.80 ns |  1.00 |    0.00 | 0.0102 |     - |     - |      64 B |
      GetNewSymbol | .NET Core 5.0 | 17.19 ns | 3.970 ns | 0.218 ns | 16.97 ns | 17.40 ns | 17.20 ns |  1.03 |    0.02 | 0.0102 |     - |     - |      64 B |
                   |               |          |          |          |          |          |          |       |         |        |       |       |           |
 GetExistingSymbol | .NET Core 3.1 | 16.61 ns | 1.774 ns | 0.097 ns | 16.52 ns | 16.72 ns | 16.59 ns |  1.00 |    0.00 | 0.0102 |     - |     - |      64 B |
 GetExistingSymbol | .NET Core 5.0 | 16.87 ns | 2.762 ns | 0.151 ns | 16.73 ns | 17.03 ns | 16.85 ns |  1.02 |    0.01 | 0.0102 |     - |     - |      64 B |
