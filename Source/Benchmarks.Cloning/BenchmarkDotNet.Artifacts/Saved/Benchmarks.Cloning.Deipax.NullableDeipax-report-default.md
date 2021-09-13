
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

  Method |     Toolchain |     Mean |     Error |   StdDev |   Median | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
-------- |-------------- |---------:|----------:|---------:|---------:|------:|--------:|-------:|------:|------:|----------:|
     Int | .NET Core 3.1 | 68.87 ns | 16.942 ns | 0.929 ns | 68.52 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
     Int | .NET Core 5.0 | 66.13 ns |  8.529 ns | 0.467 ns | 65.97 ns |  0.96 |    0.02 | 0.0038 |     - |     - |      24 B |
         |               |          |           |          |          |       |         |        |       |       |           |
 NullInt | .NET Core 3.1 | 16.45 ns |  1.585 ns | 0.087 ns | 16.45 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 NullInt | .NET Core 5.0 | 18.07 ns | 34.724 ns | 1.903 ns | 17.97 ns |  1.10 |    0.11 |      - |     - |     - |         - |
         |               |          |           |          |          |       |         |        |       |       |           |
  Struct | .NET Core 3.1 | 95.78 ns | 15.956 ns | 0.875 ns | 95.80 ns |  1.00 |    0.00 | 0.0088 |     - |     - |      56 B |
  Struct | .NET Core 5.0 | 83.56 ns |  2.025 ns | 0.111 ns | 83.54 ns |  0.87 |    0.01 | 0.0088 |     - |     - |      56 B |
