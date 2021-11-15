
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19043
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.403
  [Host]   : .NET Core 5.0.12 (CoreCLR 5.0.1221.52207, CoreFX 5.0.1221.52207), X64 RyuJIT
  ShortRun : .NET Core 3.1.21 (CoreCLR 4.700.21.51404, CoreFX 4.700.21.51508), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

      Method |     Toolchain |     Mean |    Error |   StdDev |      Min |      Max |   Median | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
------------ |-------------- |---------:|---------:|---------:|---------:|---------:|---------:|------:|--------:|------:|------:|------:|----------:|
      GetNew | .NET Core 3.1 | 20.83 ns | 0.123 ns | 0.007 ns | 20.83 ns | 20.84 ns | 20.83 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      GetNew | .NET Core 5.0 | 21.75 ns | 6.510 ns | 0.357 ns | 21.51 ns | 22.16 ns | 21.58 ns |  1.04 |    0.02 |     - |     - |     - |         - |
             |               |          |          |          |          |          |          |       |         |       |       |       |           |
 GetExisting | .NET Core 3.1 | 21.99 ns | 1.798 ns | 0.099 ns | 21.91 ns | 22.10 ns | 21.96 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 GetExisting | .NET Core 5.0 | 22.68 ns | 0.478 ns | 0.026 ns | 22.65 ns | 22.69 ns | 22.69 ns |  1.03 |    0.00 |     - |     - |     - |         - |
