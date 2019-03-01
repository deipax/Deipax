
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


                      Method |     Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
---------------------------- |---------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
        IRealOnlyList_String | 924.0 ns | 5.9288 ns | 5.5458 ns |      1.2798 |      0.0324 |           - |              8066 B |
 GrandChildClass_AsInterface | 155.7 ns | 0.7505 ns | 0.6653 ns |      0.0520 |           - |           - |               328 B |
     IRealOnlyList_Interface | 407.4 ns | 2.5690 ns | 2.2773 ns |      0.0253 |           - |           - |               160 B |
