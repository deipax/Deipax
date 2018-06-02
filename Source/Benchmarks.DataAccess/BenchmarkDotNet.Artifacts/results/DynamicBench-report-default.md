
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.17134
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435888 Hz, Resolution=291.0456 ns, Timer=TSC
  [Host]     : .NET Framework 4.6.1 (CLR 4.0.30319.42000), 32bit LegacyJIT-v4.7.3101.0
  DefaultJob : .NET Framework 4.6.1 (CLR 4.0.30319.42000), 32bit LegacyJIT-v4.7.3101.0


                        Method |     Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------------------ |---------:|----------:|----------:|-------:|----------:|
  ReadAsDictionary_DynamicDict | 315.9 ns |  2.497 ns |  2.085 ns |      - |       0 B |
 WriteAsDictionary_DynamicDict | 366.0 ns |  2.556 ns |  2.391 ns | 0.0281 |     120 B |
     ReadAsDynamic_DynamicDict | 516.5 ns |  6.464 ns |  5.397 ns |      - |       0 B |
    WriteAsDynamic_DynamicDict | 805.9 ns | 16.128 ns | 24.630 ns | 0.0277 |     120 B |
   ReadAsDictionary_DynamicRow | 409.1 ns |  5.453 ns |  4.834 ns |      - |       0 B |
  WriteAsDictionary_DynamicRow | 424.0 ns |  1.425 ns |  1.112 ns | 0.0281 |     120 B |
      ReadAsDynamic_DynamicRow | 571.6 ns |  2.150 ns |  1.906 ns |      - |       0 B |
     WriteAsDynamic_DynamicRow | 586.5 ns |  2.289 ns |  2.141 ns | 0.0277 |     120 B |
