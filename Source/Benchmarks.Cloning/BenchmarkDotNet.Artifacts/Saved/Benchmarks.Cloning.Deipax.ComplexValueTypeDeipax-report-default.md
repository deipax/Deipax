
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

        Method |     Toolchain |     Mean |     Error |   StdDev |   Median | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
-------------- |-------------- |---------:|----------:|---------:|---------:|------:|--------:|------:|------:|------:|----------:|
 ComplexStruct | .NET Core 3.1 | 40.86 ns | 27.963 ns | 1.533 ns | 40.15 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 ComplexStruct | .NET Core 5.0 | 21.80 ns | 29.608 ns | 1.623 ns | 21.18 ns |  0.53 |    0.02 |     - |     - |     - |         - |
               |               |          |           |          |          |       |         |       |       |       |           |
  SimpleStruct | .NET Core 3.1 | 37.76 ns | 35.762 ns | 1.960 ns | 38.75 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  SimpleStruct | .NET Core 5.0 | 20.97 ns |  4.370 ns | 0.240 ns | 20.96 ns |  0.56 |    0.02 |     - |     - |     - |         - |
               |               |          |           |          |          |       |         |       |       |       |           |
    NullStruct | .NET Core 3.1 | 35.71 ns |  7.997 ns | 0.438 ns | 35.65 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    NullStruct | .NET Core 5.0 | 20.69 ns |  0.773 ns | 0.042 ns | 20.70 ns |  0.58 |    0.01 |     - |     - |     - |         - |
