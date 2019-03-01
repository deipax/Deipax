
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


                                              Method |          Mean |       Error |      StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
---------------------------------------------------- |--------------:|------------:|------------:|------------:|------------:|------------:|--------------------:|
                                          Primitives |     210.37 ns |   1.2368 ns |   1.1569 ns |      0.0124 |           - |           - |                80 B |
                                             Classes |     432.49 ns |   1.6247 ns |   1.5197 ns |      0.0873 |           - |           - |               552 B |
                                             Structs |     291.35 ns |   1.4154 ns |   1.2547 ns |      0.0567 |           - |           - |               360 B |
                                                Null |      19.56 ns |   0.0972 ns |   0.0909 ns |           - |           - |           - |                   - |
 TupleCloneLogicTests_List_TupleOfClasses_Duplicates | 183,618.31 ns | 504.4789 ns | 421.2627 ns |     41.5039 |     41.5039 |     41.5039 |            131780 B |
