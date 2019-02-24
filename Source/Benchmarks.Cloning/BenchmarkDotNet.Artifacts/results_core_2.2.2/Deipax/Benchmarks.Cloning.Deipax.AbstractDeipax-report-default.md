
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


                      Method |     Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
---------------------------- |---------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
        IRealOnlyList_String | 786.0 ns | 1.1888 ns | 1.1120 ns |      1.2798 |      0.0334 |           - |              8064 B |
 GrandChildClass_AsInterface | 134.7 ns | 0.2177 ns | 0.1818 ns |      0.0520 |           - |           - |               328 B |
     IRealOnlyList_Interface | 313.6 ns | 0.3715 ns | 0.3475 ns |      0.0253 |           - |           - |               160 B |
