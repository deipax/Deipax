
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


  Method |     Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
-------- |---------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
     Int | 75.37 ns | 0.0435 ns | 0.0363 ns |      0.0037 |           - |           - |                24 B |
 NullInt | 18.89 ns | 0.0185 ns | 0.0173 ns |           - |           - |           - |                   - |
  Struct | 92.57 ns | 0.0651 ns | 0.0577 ns |      0.0088 |           - |           - |                56 B |
