
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


  Method |      Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
-------- |----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
     Int |  88.29 ns | 0.9491 ns | 0.8414 ns |      0.0037 |           - |           - |                24 B |
 NullInt |  23.35 ns | 0.1498 ns | 0.1328 ns |           - |           - |           - |                   - |
  Struct | 116.77 ns | 0.6553 ns | 0.5809 ns |      0.0088 |           - |           - |                56 B |
