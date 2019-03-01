
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


     Method |      Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
----------- |----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
 Primitives |  52.52 ns | 0.3846 ns | 0.3597 ns |      0.0050 |           - |           - |                32 B |
    Classes | 195.45 ns | 1.0469 ns | 0.9792 ns |      0.0226 |           - |           - |               144 B |
    Structs |  60.55 ns | 0.3941 ns | 0.3686 ns |      0.0151 |           - |           - |                96 B |
      Nulls |  70.51 ns | 0.4756 ns | 0.4449 ns |      0.0050 |           - |           - |                32 B |
