
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

                                              Method |     Toolchain |          Mean |         Error |       StdDev |        Median | Ratio | RatioSD |   Gen 0 |  Gen 1 | Gen 2 | Allocated |
---------------------------------------------------- |-------------- |--------------:|--------------:|-------------:|--------------:|------:|--------:|--------:|-------:|------:|----------:|
                                          Primitives | .NET Core 3.1 |     124.45 ns |     33.441 ns |     1.833 ns |     123.68 ns |  1.00 |    0.00 |  0.0126 |      - |     - |      80 B |
                                          Primitives | .NET Core 5.0 |     103.37 ns |     12.255 ns |     0.672 ns |     103.27 ns |  0.83 |    0.01 |  0.0126 |      - |     - |      80 B |
                                                     |               |               |               |              |               |       |         |         |        |       |           |
                                             Classes | .NET Core 3.1 |     438.98 ns |     21.852 ns |     1.198 ns |     439.61 ns |  1.00 |    0.00 |  0.0877 |      - |     - |     552 B |
                                             Classes | .NET Core 5.0 |     401.87 ns |     17.432 ns |     0.955 ns |     402.19 ns |  0.92 |    0.00 |  0.0877 |      - |     - |     552 B |
                                                     |               |               |               |              |               |       |         |         |        |       |           |
                                             Structs | .NET Core 3.1 |     138.99 ns |     27.422 ns |     1.503 ns |     138.40 ns |  1.00 |    0.00 |  0.0572 |      - |     - |     360 B |
                                             Structs | .NET Core 5.0 |     127.52 ns |     77.472 ns |     4.246 ns |     125.61 ns |  0.92 |    0.02 |  0.0572 |      - |     - |     360 B |
                                                     |               |               |               |              |               |       |         |         |        |       |           |
                                                Null | .NET Core 3.1 |      18.10 ns |      0.749 ns |     0.041 ns |      18.09 ns |  1.00 |    0.00 |       - |      - |     - |         - |
                                                Null | .NET Core 5.0 |      17.07 ns |      2.211 ns |     0.121 ns |      17.09 ns |  0.94 |    0.01 |       - |      - |     - |         - |
                                                     |               |               |               |              |               |       |         |         |        |       |           |
 TupleCloneLogicTests_List_TupleOfClasses_Duplicates | .NET Core 3.1 | 258,386.51 ns | 29,334.752 ns | 1,607.937 ns | 259,247.85 ns |  1.00 |    0.00 | 12.6953 | 2.4414 |     - |   80608 B |
 TupleCloneLogicTests_List_TupleOfClasses_Duplicates | .NET Core 5.0 | 227,057.98 ns | 50,251.838 ns | 2,754.473 ns | 226,113.04 ns |  0.88 |    0.01 | 12.6953 | 2.4414 |     - |   80608 B |
