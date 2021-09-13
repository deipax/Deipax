
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

                        Method |     Toolchain |      Mean |      Error |    StdDev |    Median | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------------------ |-------------- |----------:|-----------:|----------:|----------:|------:|--------:|-------:|------:|------:|----------:|
       CanShallowClone_Decimal | .NET Core 3.1 |  15.36 ns |  12.257 ns |  0.672 ns |  15.02 ns |  1.00 |    0.00 |      - |     - |     - |         - |
       CanShallowClone_Decimal | .NET Core 5.0 |  14.15 ns |   0.689 ns |  0.038 ns |  14.16 ns |  0.92 |    0.04 |      - |     - |     - |         - |
                               |               |           |            |           |           |       |         |        |       |       |           |
 CanShallowClone_ComplexStruct | .NET Core 3.1 | 772.42 ns |  28.689 ns |  1.573 ns | 771.54 ns |  1.00 |    0.00 | 0.0734 |     - |     - |     464 B |
 CanShallowClone_ComplexStruct | .NET Core 5.0 | 740.47 ns | 200.998 ns | 11.017 ns | 744.48 ns |  0.96 |    0.02 | 0.0734 |     - |     - |     464 B |
