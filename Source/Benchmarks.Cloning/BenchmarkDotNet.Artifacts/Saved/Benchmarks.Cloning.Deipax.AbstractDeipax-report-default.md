
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

                      Method |     Toolchain |     Mean |       Error |   StdDev |   Median | Ratio | RatioSD |  Gen 0 |  Gen 1 | Gen 2 | Allocated |
---------------------------- |-------------- |---------:|------------:|---------:|---------:|------:|--------:|-------:|-------:|------:|----------:|
        IRealOnlyList_String | .NET Core 3.1 | 758.0 ns | 1,686.07 ns | 92.42 ns | 735.1 ns |  1.00 |    0.00 | 1.2836 | 0.0372 |     - |    8056 B |
        IRealOnlyList_String | .NET Core 5.0 | 624.8 ns |   100.99 ns |  5.54 ns | 623.7 ns |  0.83 |    0.10 | 1.2836 | 0.0372 |     - |    8056 B |
                             |               |          |             |          |          |       |         |        |        |       |           |
 GrandChildClass_AsInterface | .NET Core 3.1 | 134.7 ns |    29.06 ns |  1.59 ns | 133.9 ns |  1.00 |    0.00 | 0.0522 |      - |     - |     328 B |
 GrandChildClass_AsInterface | .NET Core 5.0 | 117.9 ns |    53.41 ns |  2.93 ns | 116.7 ns |  0.88 |    0.03 | 0.0522 |      - |     - |     328 B |
                             |               |          |             |          |          |       |         |        |        |       |           |
     IRealOnlyList_Interface | .NET Core 3.1 | 342.1 ns |   100.47 ns |  5.51 ns | 342.1 ns |  1.00 |    0.00 | 0.0238 |      - |     - |     152 B |
     IRealOnlyList_Interface | .NET Core 5.0 | 276.9 ns |    31.13 ns |  1.71 ns | 277.4 ns |  0.81 |    0.01 | 0.0238 |      - |     - |     152 B |
