
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


  Method |      Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
-------- |----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
     Int | 110.96 ns | 0.5798 ns | 0.5423 ns |      0.0036 |           - |           - |                24 B |
 NullInt |  18.59 ns | 0.0740 ns | 0.0692 ns |           - |           - |           - |                   - |
  Struct | 128.04 ns | 0.6953 ns | 0.6504 ns |      0.0088 |           - |           - |                56 B |
