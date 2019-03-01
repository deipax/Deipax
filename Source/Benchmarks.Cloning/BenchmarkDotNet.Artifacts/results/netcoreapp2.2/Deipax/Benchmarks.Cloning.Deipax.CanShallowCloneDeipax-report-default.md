
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


                        Method |      Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------------------ |----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
       CanShallowClone_Decimal |  16.75 ns | 0.0388 ns | 0.0362 ns |           - |           - |           - |                   - |
 CanShallowClone_ComplexStruct | 898.73 ns | 2.2776 ns | 2.0190 ns |      0.0734 |           - |           - |               464 B |
