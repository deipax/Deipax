
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


                      Method |     Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
---------------------------- |---------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
        IRealOnlyList_String | 942.4 ns | 7.2293 ns | 6.7623 ns |      1.3123 |      0.0343 |           - |              8262 B |
 GrandChildClass_AsInterface | 119.5 ns | 0.9738 ns | 0.9109 ns |      0.0520 |           - |           - |               328 B |
     IRealOnlyList_Interface | 359.0 ns | 2.1974 ns | 2.0554 ns |      0.0277 |           - |           - |               176 B |
