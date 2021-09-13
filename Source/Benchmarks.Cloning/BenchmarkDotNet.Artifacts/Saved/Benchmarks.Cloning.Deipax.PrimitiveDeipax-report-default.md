
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

         Method |     Toolchain |             Mean |            Error |         StdDev |           Median | Ratio | RatioSD |    Gen 0 |    Gen 1 |    Gen 2 |   Allocated |
--------------- |-------------- |-----------------:|-----------------:|---------------:|-----------------:|------:|--------:|---------:|---------:|---------:|------------:|
            Int | .NET Core 3.1 |         25.08 ns |         9.299 ns |       0.510 ns |         25.34 ns |  1.00 |    0.00 |        - |        - |        - |           - |
            Int | .NET Core 5.0 |         18.25 ns |         0.360 ns |       0.020 ns |         18.26 ns |  0.73 |    0.02 |        - |        - |        - |           - |
                |               |                  |                  |                |                  |       |         |          |          |          |             |
         String | .NET Core 3.1 |         27.83 ns |         2.133 ns |       0.117 ns |         27.79 ns |  1.00 |    0.00 |        - |        - |        - |           - |
         String | .NET Core 5.0 |         25.55 ns |         3.147 ns |       0.172 ns |         25.51 ns |  0.92 |    0.01 |        - |        - |        - |           - |
                |               |                  |                  |                |                  |       |         |          |          |          |             |
  ListOfStrings | .NET Core 3.1 |        629.74 ns |       184.352 ns |      10.105 ns |        627.13 ns |  1.00 |    0.00 |   1.2836 |   0.0372 |        - |      8056 B |
  ListOfStrings | .NET Core 5.0 |        594.81 ns |        43.424 ns |       2.380 ns |        594.55 ns |  0.94 |    0.02 |   1.2836 |   0.0372 |        - |      8056 B |
                |               |                  |                  |                |                  |       |         |          |          |          |             |
    ListOfBytes | .NET Core 3.1 | 38,958,794.87 ns | 4,970,578.006 ns | 272,454.153 ns | 39,104,200.00 ns |  1.00 |    0.00 | 307.6923 | 307.6923 | 307.6923 | 100000230 B |
    ListOfBytes | .NET Core 5.0 | 35,257,228.21 ns | 3,382,968.524 ns | 185,431.920 ns | 35,219,900.00 ns |  0.91 |    0.01 | 307.6923 | 307.6923 | 307.6923 | 100000300 B |
                |               |                  |                  |                |                  |       |         |          |          |          |             |
     ListOfInts | .NET Core 3.1 |        317.50 ns |       493.946 ns |      27.075 ns |        303.80 ns |  1.00 |    0.00 |   0.6461 |   0.0095 |        - |      4056 B |
     ListOfInts | .NET Core 5.0 |        311.15 ns |        43.145 ns |       2.365 ns |        312.14 ns |  0.98 |    0.09 |   0.6461 |   0.0095 |        - |      4056 B |
                |               |                  |                  |                |                  |       |         |          |          |          |             |
 ListOfTimeSpan | .NET Core 3.1 |        104.27 ns |        46.301 ns |       2.538 ns |        104.15 ns |  1.00 |    0.00 |   0.0216 |        - |        - |       136 B |
 ListOfTimeSpan | .NET Core 5.0 |         87.30 ns |         5.262 ns |       0.288 ns |         87.31 ns |  0.84 |    0.02 |   0.0216 |        - |        - |       136 B |
                |               |                  |                  |                |                  |       |         |          |          |          |             |
 ListOfDateTime | .NET Core 3.1 |        101.59 ns |        13.784 ns |       0.756 ns |        101.26 ns |  1.00 |    0.00 |   0.0216 |        - |        - |       136 B |
 ListOfDateTime | .NET Core 5.0 |         93.33 ns |       174.194 ns |       9.548 ns |         89.93 ns |  0.92 |    0.09 |   0.0216 |        - |        - |       136 B |
                |               |                  |                  |                |                  |       |         |          |          |          |             |
 ListOfDelegate | .NET Core 3.1 |        109.38 ns |        25.067 ns |       1.374 ns |        108.66 ns |  1.00 |    0.00 |   0.0216 |        - |        - |       136 B |
 ListOfDelegate | .NET Core 5.0 |         96.73 ns |         6.026 ns |       0.330 ns |         96.55 ns |  0.88 |    0.01 |   0.0216 |        - |        - |       136 B |
