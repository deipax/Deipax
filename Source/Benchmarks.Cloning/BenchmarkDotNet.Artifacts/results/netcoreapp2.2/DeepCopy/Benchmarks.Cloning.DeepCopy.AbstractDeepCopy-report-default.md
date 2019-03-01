
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


                      Method |     Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
---------------------------- |---------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
        IRealOnlyList_String | 799.6 ns | 2.0425 ns | 1.9105 ns |      1.3123 |      0.0353 |           - |              8256 B |
 GrandChildClass_AsInterface | 120.4 ns | 0.2958 ns | 0.2622 ns |      0.0520 |           - |           - |               328 B |
     IRealOnlyList_Interface | 298.4 ns | 0.3931 ns | 0.3677 ns |      0.0277 |           - |           - |               176 B |
