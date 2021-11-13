
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.403
  [Host]   : .NET Core 5.0.12 (CoreCLR 5.0.1221.52207, CoreFX 5.0.1221.52207), X64 RyuJIT
  ShortRun : .NET Core 3.1.21 (CoreCLR 4.700.21.51404, CoreFX 4.700.21.51508), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

            Method |     Toolchain |     Mean |     Error |   StdDev |      Min |      Max |   Median | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------ |-------------- |---------:|----------:|---------:|---------:|---------:|---------:|------:|--------:|------:|------:|------:|----------:|
      GetNewSymbol | .NET Core 3.1 | 17.32 ns |  4.440 ns | 0.243 ns | 17.05 ns | 17.53 ns | 17.38 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      GetNewSymbol | .NET Core 5.0 | 14.87 ns |  1.009 ns | 0.055 ns | 14.83 ns | 14.93 ns | 14.86 ns |  0.86 |    0.02 |     - |     - |     - |         - |
                   |               |          |           |          |          |          |          |       |         |       |       |       |           |
 GetExistingSymbol | .NET Core 3.1 | 21.87 ns | 69.627 ns | 3.817 ns | 19.49 ns | 26.27 ns | 19.85 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 GetExistingSymbol | .NET Core 5.0 | 16.33 ns |  2.300 ns | 0.126 ns | 16.21 ns | 16.46 ns | 16.32 ns |  0.76 |    0.12 |     - |     - |     - |         - |
