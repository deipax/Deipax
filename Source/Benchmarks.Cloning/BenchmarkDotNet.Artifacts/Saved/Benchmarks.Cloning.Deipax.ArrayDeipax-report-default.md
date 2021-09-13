
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

              Method |     Toolchain |        Mean |      Error |    StdDev |      Median | Ratio | RatioSD |  Gen 0 |  Gen 1 | Gen 2 | Allocated |
-------------------- |-------------- |------------:|-----------:|----------:|------------:|------:|--------:|-------:|-------:|------:|----------:|
            IntArray | .NET Core 3.1 |    98.19 ns |  93.893 ns |  5.147 ns |    95.58 ns |  1.00 |    0.00 | 0.0101 |      - |     - |      64 B |
            IntArray | .NET Core 5.0 |    72.41 ns |  11.774 ns |  0.645 ns |    72.14 ns |  0.74 |    0.04 | 0.0101 |      - |     - |      64 B |
                     |               |             |            |           |             |       |         |        |        |       |           |
           ByteArray | .NET Core 3.1 |   139.15 ns |  33.567 ns |  1.840 ns |   138.56 ns |  1.00 |    0.00 | 0.1631 |      - |     - |    1024 B |
           ByteArray | .NET Core 5.0 |   114.64 ns |  31.326 ns |  1.717 ns |   115.32 ns |  0.82 |    0.01 | 0.1632 |      - |     - |    1024 B |
                     |               |             |            |           |             |       |         |        |        |       |           |
         StringArray | .NET Core 3.1 |   101.09 ns |  10.829 ns |  0.594 ns |   101.39 ns |  1.00 |    0.00 | 0.0166 |      - |     - |     104 B |
         StringArray | .NET Core 5.0 |    87.01 ns |  96.034 ns |  5.264 ns |    84.35 ns |  0.86 |    0.05 | 0.0166 |      - |     - |     104 B |
                     |               |             |            |           |             |       |         |        |        |       |           |
       TimeSpanArray | .NET Core 3.1 |    96.47 ns |   9.420 ns |  0.516 ns |    96.18 ns |  1.00 |    0.00 | 0.0166 |      - |     - |     104 B |
       TimeSpanArray | .NET Core 5.0 |    77.70 ns |  24.285 ns |  1.331 ns |    77.15 ns |  0.81 |    0.02 | 0.0166 |      - |     - |     104 B |
                     |               |             |            |           |             |       |         |        |        |       |           |
       DateTimeArray | .NET Core 3.1 |    97.36 ns |  17.306 ns |  0.949 ns |    97.29 ns |  1.00 |    0.00 | 0.0166 |      - |     - |     104 B |
       DateTimeArray | .NET Core 5.0 |    78.87 ns |  13.371 ns |  0.733 ns |    78.92 ns |  0.81 |    0.00 | 0.0166 |      - |     - |     104 B |
                     |               |             |            |           |             |       |         |        |        |       |           |
       DelegateArray | .NET Core 3.1 |   102.97 ns |   5.331 ns |  0.292 ns |   103.03 ns |  1.00 |    0.00 | 0.0166 |      - |     - |     104 B |
       DelegateArray | .NET Core 5.0 |    79.72 ns |  11.710 ns |  0.642 ns |    80.05 ns |  0.77 |    0.01 | 0.0166 |      - |     - |     104 B |
                     |               |             |            |           |             |       |         |        |        |       |           |
 ArrayOfStringArrays | .NET Core 3.1 |   214.77 ns |  14.056 ns |  0.770 ns |   214.64 ns |  1.00 |    0.00 | 0.0191 |      - |     - |     120 B |
 ArrayOfStringArrays | .NET Core 5.0 |   165.14 ns |  55.168 ns |  3.024 ns |   163.63 ns |  0.77 |    0.01 | 0.0191 |      - |     - |     120 B |
                     |               |             |            |           |             |       |         |        |        |       |           |
      ArrayOfClasses | .NET Core 3.1 | 4,230.25 ns | 876.917 ns | 48.067 ns | 4,214.09 ns |  1.00 |    0.00 | 1.0223 | 0.0229 |     - |    6424 B |
      ArrayOfClasses | .NET Core 5.0 | 3,904.21 ns | 594.572 ns | 32.590 ns | 3,905.83 ns |  0.92 |    0.00 | 1.0223 | 0.0229 |     - |    6424 B |
                     |               |             |            |           |             |       |         |        |        |       |           |
       ArrayOfStruct | .NET Core 3.1 |   271.07 ns | 119.879 ns |  6.571 ns |   274.33 ns |  1.00 |    0.00 | 0.6413 |      - |     - |    4024 B |
       ArrayOfStruct | .NET Core 5.0 |   276.39 ns |  90.090 ns |  4.938 ns |   276.42 ns |  1.02 |    0.03 | 0.6413 |      - |     - |    4024 B |
