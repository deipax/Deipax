
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


        Method |     Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
-------------- |---------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
 ComplexStruct | 36.93 ns | 0.0350 ns | 0.0328 ns |           - |           - |           - |                   - |
  SimpleStruct | 36.56 ns | 0.0203 ns | 0.0190 ns |           - |           - |           - |                   - |
    NullStruct | 31.98 ns | 0.0151 ns | 0.0134 ns |           - |           - |           - |                   - |
