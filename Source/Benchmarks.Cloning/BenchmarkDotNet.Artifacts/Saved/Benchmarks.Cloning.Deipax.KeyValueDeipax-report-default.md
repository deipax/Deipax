
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

     Method |     Toolchain |      Mean |     Error |   StdDev |    Median | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
----------- |-------------- |----------:|----------:|---------:|----------:|------:|--------:|-------:|------:|------:|----------:|
 Primitives | .NET Core 3.1 |  28.94 ns | 25.498 ns | 1.398 ns |  28.26 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 Primitives | .NET Core 5.0 |  28.30 ns | 40.084 ns | 2.197 ns |  27.25 ns |  0.98 |    0.11 |      - |     - |     - |         - |
            |               |           |           |          |           |       |         |        |       |       |           |
    Classes | .NET Core 3.1 | 134.19 ns | 12.452 ns | 0.683 ns | 133.99 ns |  1.00 |    0.00 | 0.0176 |     - |     - |     112 B |
    Classes | .NET Core 5.0 | 113.37 ns | 10.178 ns | 0.558 ns | 113.38 ns |  0.84 |    0.01 | 0.0178 |     - |     - |     112 B |
            |               |           |           |          |           |       |         |        |       |       |           |
    Structs | .NET Core 3.1 |  40.86 ns |  6.652 ns | 0.365 ns |  40.88 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    Structs | .NET Core 5.0 |  34.31 ns |  6.030 ns | 0.331 ns |  34.44 ns |  0.84 |    0.01 |      - |     - |     - |         - |
            |               |           |           |          |           |       |         |        |       |       |           |
      Nulls | .NET Core 3.1 |  47.67 ns |  4.876 ns | 0.267 ns |  47.59 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      Nulls | .NET Core 5.0 |  33.97 ns |  4.174 ns | 0.229 ns |  34.05 ns |  0.71 |    0.00 |      - |     - |     - |         - |
