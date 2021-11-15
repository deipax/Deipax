
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.401
  [Host]   : .NET Core 5.0.10 (CoreCLR 5.0.1021.41214, CoreFX 5.0.1021.41214), X64 RyuJIT
  ShortRun : .NET Core 3.1.19 (CoreCLR 4.700.21.41101, CoreFX 4.700.21.41603), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

          Method |     Toolchain |        Mean |        Error |      StdDev |         Min |         Max |      Median | Ratio | RatioSD |     Gen 0 |    Gen 1 |    Gen 2 |  Allocated |
---------------- |-------------- |------------:|-------------:|------------:|------------:|------------:|------------:|------:|--------:|----------:|---------:|---------:|-----------:|
           First | .NET Core 3.1 |    241.5 μs |    318.42 μs |    17.45 μs |    229.3 μs |    261.5 μs |    233.8 μs |  1.00 |    0.00 |    4.8828 |   0.2441 |        - |   30.32 KB |
           First | .NET Core 5.0 |    228.7 μs |     76.28 μs |     4.18 μs |    225.5 μs |    233.5 μs |    227.2 μs |  0.95 |    0.08 |    4.8828 |   0.2441 |        - |   30.33 KB |
                 |               |             |              |             |             |             |             |       |         |           |          |          |            |
  FirstOrDefault | .NET Core 3.1 |    223.2 μs |     18.62 μs |     1.02 μs |    222.2 μs |    224.2 μs |    223.3 μs |  1.00 |    0.00 |    4.8828 |   0.2441 |        - |   30.32 KB |
  FirstOrDefault | .NET Core 5.0 |    226.1 μs |     39.06 μs |     2.14 μs |    224.8 μs |    228.6 μs |    225.0 μs |  1.01 |    0.01 |    4.8828 |   0.2441 |        - |   30.33 KB |
                 |               |             |              |             |             |             |             |       |         |           |          |          |            |
            List | .NET Core 3.1 | 34,468.9 μs |  8,844.30 μs |   484.79 μs | 34,018.0 μs | 34,981.6 μs | 34,407.2 μs |  1.00 |    0.00 | 1466.6667 | 600.0000 | 200.0000 | 8390.72 KB |
            List | .NET Core 5.0 | 31,757.8 μs |  3,994.21 μs |   218.94 μs | 31,539.3 μs | 31,977.2 μs | 31,756.8 μs |  0.92 |    0.01 | 1437.5000 | 562.5000 | 187.5000 | 8390.58 KB |
                 |               |             |              |             |             |             |             |       |         |           |          |          |            |
      List_Async | .NET Core 3.1 | 37,606.1 μs | 34,578.55 μs | 1,895.37 μs | 35,885.7 μs | 39,637.9 μs | 37,294.9 μs |  1.00 |    0.00 | 1466.6667 | 600.0000 | 200.0000 | 8391.45 KB |
      List_Async | .NET Core 5.0 | 32,517.7 μs |  8,578.94 μs |   470.24 μs | 32,083.3 μs | 33,017.0 μs | 32,452.9 μs |  0.87 |    0.06 | 1500.0000 | 571.4286 | 142.8571 | 8390.96 KB |
                 |               |             |              |             |             |             |             |       |         |           |          |          |            |
          Single | .NET Core 3.1 |    224.9 μs |      8.66 μs |     0.47 μs |    224.4 μs |    225.2 μs |    225.2 μs |  1.00 |    0.00 |    4.8828 |   0.2441 |        - |   30.32 KB |
          Single | .NET Core 5.0 |    235.4 μs |     80.84 μs |     4.43 μs |    230.3 μs |    238.6 μs |    237.2 μs |  1.05 |    0.02 |    4.8828 |   0.2441 |        - |   30.33 KB |
                 |               |             |              |             |             |             |             |       |         |           |          |          |            |
 SingleOrDefault | .NET Core 3.1 |    225.7 μs |     10.97 μs |     0.60 μs |    225.0 μs |    226.2 μs |    225.8 μs |  1.00 |    0.00 |    4.8828 |   0.2441 |        - |   30.32 KB |
 SingleOrDefault | .NET Core 5.0 |    231.9 μs |     68.04 μs |     3.73 μs |    229.6 μs |    236.2 μs |    229.9 μs |  1.03 |    0.01 |    4.8828 |   0.2441 |        - |   30.33 KB |