
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


                                              Method |          Mean |       Error |      StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
---------------------------------------------------- |--------------:|------------:|------------:|------------:|------------:|------------:|--------------------:|
                                          Primitives |     147.79 ns |   0.1898 ns |   0.1776 ns |      0.0126 |           - |           - |                80 B |
                                             Classes |     343.69 ns |   0.2491 ns |   0.2209 ns |      0.0873 |           - |           - |               552 B |
                                             Structs |     193.34 ns |   0.3025 ns |   0.2830 ns |      0.0570 |           - |           - |               360 B |
                                                Null |      24.32 ns |   0.0176 ns |   0.0156 ns |           - |           - |           - |                   - |
 TupleCloneLogicTests_List_TupleOfClasses_Duplicates | 190,300.59 ns | 185.5688 ns | 173.5812 ns |     41.5039 |     41.5039 |     41.5039 |            131688 B |
