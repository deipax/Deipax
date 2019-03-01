
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


        Method |     Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
-------------- |---------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
 ComplexStruct | 45.96 ns | 0.4036 ns | 0.3775 ns |      0.0089 |           - |           - |                56 B |
  SimpleStruct | 44.17 ns | 0.3151 ns | 0.2948 ns |      0.0089 |           - |           - |                56 B |
    NullStruct | 43.61 ns | 0.2029 ns | 0.1799 ns |      0.0089 |           - |           - |                56 B |
