
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


        Method |     Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
-------------- |---------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
 ComplexStruct | 36.66 ns | 0.2283 ns | 0.2136 ns |      0.0089 |           - |           - |                56 B |
  SimpleStruct | 39.25 ns | 0.2971 ns | 0.2481 ns |      0.0089 |           - |           - |                56 B |
    NullStruct | 35.86 ns | 0.1834 ns | 0.1716 ns |      0.0089 |           - |           - |                56 B |
