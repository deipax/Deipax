
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


     Method |      Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
----------- |----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
 Primitives |  52.29 ns | 0.2633 ns | 0.2463 ns |      0.0050 |           - |           - |                32 B |
    Classes | 164.72 ns | 0.9617 ns | 0.8996 ns |      0.0226 |           - |           - |               144 B |
    Structs |  60.64 ns | 0.2850 ns | 0.2666 ns |      0.0151 |           - |           - |                96 B |
      Nulls | 139.32 ns | 1.2505 ns | 1.1698 ns |      0.0050 |           - |           - |                32 B |
