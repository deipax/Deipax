
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


                        Method |        Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------------------ |------------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
       CanShallowClone_Decimal |    13.42 ns | 0.0810 ns | 0.0758 ns |           - |           - |           - |                   - |
 CanShallowClone_ComplexStruct | 1,159.09 ns | 8.3371 ns | 7.7985 ns |      0.0763 |           - |           - |               488 B |
