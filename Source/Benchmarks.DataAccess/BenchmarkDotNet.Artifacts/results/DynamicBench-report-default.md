
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.431 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
  [Host]     : .NET Framework 4.6.1 (CLR 4.0.30319.42000), 32bit LegacyJIT-v4.7.2650.0
  DefaultJob : .NET Framework 4.6.1 (CLR 4.0.30319.42000), 32bit LegacyJIT-v4.7.2650.0


                        Method |     Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------------------ |---------:|----------:|----------:|-------:|----------:|
  ReadAsDictionary_DynamicDict | 375.1 ns | 1.1981 ns | 1.1207 ns |      - |       0 B |
 WriteAsDictionary_DynamicDict | 418.5 ns | 8.3547 ns | 8.9395 ns | 0.0281 |     120 B |
     ReadAsDynamic_DynamicDict | 419.1 ns | 0.7789 ns | 0.6905 ns | 0.0281 |     120 B |
    WriteAsDynamic_DynamicDict | 554.1 ns | 2.3868 ns | 2.1159 ns | 0.0563 |     240 B |
