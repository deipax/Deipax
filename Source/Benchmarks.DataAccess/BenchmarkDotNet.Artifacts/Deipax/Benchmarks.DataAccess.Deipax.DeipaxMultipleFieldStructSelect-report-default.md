
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.401
  [Host]   : .NET Core 5.0.10 (CoreCLR 5.0.1021.41214, CoreFX 5.0.1021.41214), X64 RyuJIT
  ShortRun : .NET Core 3.1.19 (CoreCLR 4.700.21.41101, CoreFX 4.700.21.41603), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

          Method |     Toolchain |        Mean |       Error |    StdDev |         Min |         Max |      Median | Ratio | RatioSD |     Gen 0 |     Gen 1 |    Gen 2 |   Allocated |
---------------- |-------------- |------------:|------------:|----------:|------------:|------------:|------------:|------:|--------:|----------:|----------:|---------:|------------:|
           First | .NET Core 3.1 |    231.8 μs |   109.41 μs |   6.00 μs |    227.8 μs |    238.6 μs |    228.8 μs |  1.00 |    0.00 |    4.8828 |         - |        - |     30.3 KB |
           First | .NET Core 5.0 |    226.2 μs |    54.54 μs |   2.99 μs |    222.8 μs |    228.3 μs |    227.6 μs |  0.98 |    0.02 |    4.8828 |         - |        - |    30.31 KB |
                 |               |             |             |           |             |             |             |       |         |           |           |          |             |
  FirstOrDefault | .NET Core 3.1 |    224.0 μs |    14.53 μs |   0.80 μs |    223.2 μs |    224.8 μs |    224.0 μs |  1.00 |    0.00 |    4.8828 |         - |        - |     30.3 KB |
  FirstOrDefault | .NET Core 5.0 |    222.6 μs |    15.01 μs |   0.82 μs |    221.8 μs |    223.4 μs |    222.7 μs |  0.99 |    0.01 |    4.8828 |         - |        - |    30.31 KB |
                 |               |             |             |           |             |             |             |       |         |           |           |          |             |
            List | .NET Core 3.1 | 39,056.5 μs | 6,030.10 μs | 330.53 μs | 38,731.6 μs | 39,392.4 μs | 39,045.7 μs |  1.00 |    0.00 | 1846.1538 | 1076.9231 | 846.1538 |  12501.2 KB |
            List | .NET Core 5.0 | 35,389.3 μs | 1,687.17 μs |  92.48 μs | 35,282.8 μs | 35,449.6 μs | 35,435.5 μs |  0.91 |    0.01 | 1785.7143 | 1000.0000 | 785.7143 | 12500.21 KB |
                 |               |             |             |           |             |             |             |       |         |           |           |          |             |
      List_Async | .NET Core 3.1 | 37,553.6 μs | 2,925.04 μs | 160.33 μs | 37,380.7 μs | 37,697.4 μs | 37,582.8 μs |  1.00 |    0.00 | 1928.5714 | 1071.4286 | 928.5714 | 12501.09 KB |
      List_Async | .NET Core 5.0 | 35,166.1 μs |   799.89 μs |  43.84 μs | 35,133.9 μs | 35,216.0 μs | 35,148.3 μs |  0.94 |    0.00 | 1785.7143 | 1000.0000 | 785.7143 | 12501.49 KB |
                 |               |             |             |           |             |             |             |       |         |           |           |          |             |
          Single | .NET Core 3.1 |    224.8 μs |    10.66 μs |   0.58 μs |    224.3 μs |    225.4 μs |    224.7 μs |  1.00 |    0.00 |    4.8828 |         - |        - |     30.3 KB |
          Single | .NET Core 5.0 |    224.2 μs |    15.72 μs |   0.86 μs |    223.3 μs |    224.9 μs |    224.6 μs |  1.00 |    0.01 |    4.8828 |         - |        - |    30.31 KB |
                 |               |             |             |           |             |             |             |       |         |           |           |          |             |
 SingleOrDefault | .NET Core 3.1 |    225.1 μs |    68.34 μs |   3.75 μs |    221.4 μs |    228.9 μs |    225.2 μs |  1.00 |    0.00 |    4.8828 |    0.2441 |        - |     30.3 KB |
 SingleOrDefault | .NET Core 5.0 |    251.0 μs |   435.59 μs |  23.88 μs |    231.5 μs |    277.6 μs |    243.9 μs |  1.12 |    0.12 |    4.8828 |         - |        - |    30.31 KB |
