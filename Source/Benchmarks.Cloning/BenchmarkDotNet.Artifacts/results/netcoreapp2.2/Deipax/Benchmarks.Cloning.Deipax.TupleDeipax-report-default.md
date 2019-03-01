
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


                                              Method |          Mean |       Error |      StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
---------------------------------------------------- |--------------:|------------:|------------:|------------:|------------:|------------:|--------------------:|
                                          Primitives |     120.29 ns |   0.1560 ns |   0.1383 ns |      0.0126 |           - |           - |                80 B |
                                             Classes |     442.74 ns |   0.3143 ns |   0.2940 ns |      0.0873 |           - |           - |               552 B |
                                             Structs |     151.19 ns |   0.1820 ns |   0.1703 ns |      0.0570 |           - |           - |               360 B |
                                                Null |      18.02 ns |   0.0198 ns |   0.0175 ns |           - |           - |           - |                   - |
 TupleCloneLogicTests_List_TupleOfClasses_Duplicates | 321,448.86 ns | 901.6442 ns | 843.3986 ns |     12.6953 |      2.4414 |           - |             80616 B |
