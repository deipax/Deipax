
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


                                              Method |          Mean |         Error |        StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
---------------------------------------------------- |--------------:|--------------:|--------------:|------------:|------------:|------------:|--------------------:|
                                          Primitives |     162.19 ns |     1.1961 ns |     1.1189 ns |      0.0126 |           - |           - |                80 B |
                                             Classes |     606.48 ns |     5.5383 ns |     5.1805 ns |      0.0868 |           - |           - |               552 B |
                                             Structs |     188.72 ns |     0.6368 ns |     0.5645 ns |      0.0570 |           - |           - |               360 B |
                                                Null |      21.80 ns |     0.0992 ns |     0.0928 ns |           - |           - |           - |                   - |
 TupleCloneLogicTests_List_TupleOfClasses_Duplicates | 318,207.99 ns | 1,336.7524 ns | 1,250.3991 ns |     12.6953 |      2.4414 |           - |             80680 B |
