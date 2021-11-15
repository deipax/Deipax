
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19043
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.403
  [Host]   : .NET Core 5.0.12 (CoreCLR 5.0.1221.52207, CoreFX 5.0.1221.52207), X64 RyuJIT
  ShortRun : .NET Core 3.1.21 (CoreCLR 4.700.21.51404, CoreFX 4.700.21.51508), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

      Method |     Toolchain |     Mean |      Error |   StdDev |      Min |      Max |   Median | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
------------ |-------------- |---------:|-----------:|---------:|---------:|---------:|---------:|------:|--------:|------:|------:|------:|----------:|
      GetNew | .NET Core 3.1 | 19.49 ns |   1.187 ns | 0.065 ns | 19.45 ns | 19.57 ns | 19.46 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      GetNew | .NET Core 5.0 | 26.23 ns | 127.872 ns | 7.009 ns | 22.12 ns | 34.33 ns | 22.25 ns |  1.35 |    0.35 |     - |     - |     - |         - |
             |               |          |            |          |          |          |          |       |         |       |       |       |           |
 GetExisting | .NET Core 3.1 | 21.61 ns |   1.474 ns | 0.081 ns | 21.53 ns | 21.69 ns | 21.62 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 GetExisting | .NET Core 5.0 | 21.37 ns |   4.006 ns | 0.220 ns | 21.13 ns | 21.56 ns | 21.42 ns |  0.99 |    0.01 |     - |     - |     - |         - |
