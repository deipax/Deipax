
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


     Method |      Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
----------- |----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
 Primitives |  37.94 ns | 0.0331 ns | 0.0310 ns |           - |           - |           - |                   - |
    Classes | 137.81 ns | 0.1892 ns | 0.1770 ns |      0.0176 |           - |           - |               112 B |
    Structs |  42.15 ns | 0.0403 ns | 0.0377 ns |           - |           - |           - |                   - |
      Nulls |  45.44 ns | 0.0371 ns | 0.0347 ns |           - |           - |           - |                   - |
