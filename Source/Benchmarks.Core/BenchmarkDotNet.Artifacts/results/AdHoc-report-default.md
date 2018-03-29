
BenchmarkDotNet=v0.10.13, OS=Windows 7 SP1 (6.1.7601.0)
Intel Xeon CPU E5-1650 v3 3.50GHz, 1 CPU, 12 logical cores and 6 physical cores
Frequency=3410087 Hz, Resolution=293.2477 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                  Method |       Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------------ |-----------:|----------:|----------:|-------:|----------:|
               Enum_Cast |  0.2107 ns | 0.0058 ns | 0.0046 ns |      - |       0 B |
       IConvertable_Enum | 44.9828 ns | 2.3611 ns | 6.9246 ns | 0.0076 |      48 B |
          ConvertTO_Enum | 66.0477 ns | 3.1376 ns | 9.0526 ns | 0.0075 |      48 B |
 ConvertTO_Enum_AsObject | 97.2562 ns | 1.6455 ns | 4.2180 ns | 0.0037 |      24 B |
