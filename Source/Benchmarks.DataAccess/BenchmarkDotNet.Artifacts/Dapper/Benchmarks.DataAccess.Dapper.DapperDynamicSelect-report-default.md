
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.401
  [Host]   : .NET Core 5.0.10 (CoreCLR 5.0.1021.41214, CoreFX 5.0.1021.41214), X64 RyuJIT
  ShortRun : .NET Core 3.1.19 (CoreCLR 4.700.21.41101, CoreFX 4.700.21.41603), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

          Method |     Toolchain |        Mean |       Error |    StdDev |         Min |         Max |      Median | Ratio | RatioSD |     Gen 0 |    Gen 1 |    Gen 2 |  Allocated |
---------------- |-------------- |------------:|------------:|----------:|------------:|------------:|------------:|------:|--------:|----------:|---------:|---------:|-----------:|
           First | .NET Core 3.1 |    235.7 μs |   213.20 μs |  11.69 μs |    222.9 μs |    245.7 μs |    238.7 μs |  1.00 |    0.00 |    4.6387 |   0.2441 |        - |   29.18 KB |
           First | .NET Core 5.0 |    217.1 μs |    14.28 μs |   0.78 μs |    216.3 μs |    217.9 μs |    217.1 μs |  0.92 |    0.05 |    4.6387 |        - |        - |   29.19 KB |
                 |               |             |             |           |             |             |             |       |         |           |          |          |            |
  FirstOrDefault | .NET Core 3.1 |    219.9 μs |    15.68 μs |   0.86 μs |    218.9 μs |    220.5 μs |    220.2 μs |  1.00 |    0.00 |    4.3945 |        - |        - |   29.18 KB |
  FirstOrDefault | .NET Core 5.0 |    218.7 μs |    22.17 μs |   1.22 μs |    217.7 μs |    220.1 μs |    218.4 μs |  0.99 |    0.00 |    4.6387 |        - |        - |   29.19 KB |
                 |               |             |             |           |             |             |             |       |         |           |          |          |            |
            List | .NET Core 3.1 | 31,469.6 μs | 4,807.33 μs | 263.51 μs | 31,192.8 μs | 31,717.4 μs | 31,498.7 μs |  1.00 |    0.00 | 1562.5000 | 625.0000 | 187.5000 | 8655.67 KB |
            List | .NET Core 5.0 | 27,916.5 μs | 5,942.42 μs | 325.72 μs | 27,557.0 μs | 28,192.0 μs | 28,000.5 μs |  0.89 |    0.02 | 1562.5000 | 625.0000 | 187.5000 |    8656 KB |
                 |               |             |             |           |             |             |             |       |         |           |          |          |            |
      List_Async | .NET Core 3.1 | 31,615.3 μs | 1,549.26 μs |  84.92 μs | 31,517.6 μs | 31,671.9 μs | 31,656.3 μs |  1.00 |    0.00 | 1562.5000 | 625.0000 | 187.5000 | 8608.12 KB |
      List_Async | .NET Core 5.0 | 29,057.7 μs | 1,914.83 μs | 104.96 μs | 28,943.2 μs | 29,149.3 μs | 29,080.7 μs |  0.92 |    0.00 | 1531.2500 | 625.0000 | 218.7500 | 8608.34 KB |
                 |               |             |             |           |             |             |             |       |         |           |          |          |            |
          Single | .NET Core 3.1 |    221.6 μs |    37.18 μs |   2.04 μs |    219.3 μs |    222.9 μs |    222.7 μs |  1.00 |    0.00 |    4.6387 |   0.2441 |        - |   29.18 KB |
          Single | .NET Core 5.0 |    225.9 μs |    22.74 μs |   1.25 μs |    224.4 μs |    226.7 μs |    226.4 μs |  1.02 |    0.01 |    4.6387 |        - |        - |   29.19 KB |
                 |               |             |             |           |             |             |             |       |         |           |          |          |            |
 SingleOrDefault | .NET Core 3.1 |    220.0 μs |    15.21 μs |   0.83 μs |    219.2 μs |    220.9 μs |    219.9 μs |  1.00 |    0.00 |    4.6387 |   0.2441 |        - |   29.18 KB |
 SingleOrDefault | .NET Core 5.0 |    228.0 μs |   114.87 μs |   6.30 μs |    224.2 μs |    235.2 μs |    224.5 μs |  1.04 |    0.03 |    4.6387 |        - |        - |   29.19 KB |
