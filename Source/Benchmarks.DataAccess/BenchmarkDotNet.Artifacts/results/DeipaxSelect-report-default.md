
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435896 Hz, Resolution=291.0449 ns, Timer=TSC
  [Host]     : .NET Framework 4.6.1 (CLR 4.0.30319.42000), 32bit LegacyJIT-v4.7.2633.0
  DefaultJob : .NET Framework 4.6.1 (CLR 4.0.30319.42000), 32bit LegacyJIT-v4.7.2633.0


                     Method |      Mean |     Error |    StdDev |     Gen 0 |     Gen 1 |    Gen 2 |  Allocated |
--------------------------- |----------:|----------:|----------:|----------:|----------:|---------:|-----------:|
           AllFieldsAsClass | 38.869 ms | 0.2357 ms | 0.2089 ms | 1500.0000 | 1125.0000 | 187.5000 | 6928.68 KB |
          AllFieldsAsStruct | 48.871 ms | 0.5960 ms | 0.5575 ms | 1500.0000 | 1000.0000 | 437.5000 |  8593.7 KB |
         SingleFieldAsClass |  5.940 ms | 0.0330 ms | 0.0309 ms |   39.0625 |    7.8125 |        - |  174.45 KB |
        SingleFieldAsStruct |  5.372 ms | 0.0191 ms | 0.0170 ms |   39.0625 |         - |        - |  174.41 KB |
    AllFieldsAsClass_Dapper | 40.380 ms | 0.4866 ms | 0.4552 ms | 1437.5000 | 1062.5000 | 187.5000 | 6926.01 KB |
   AllFieldsAsStruct_Dapper | 47.518 ms | 0.3969 ms | 0.3314 ms | 1437.5000 | 1000.0000 | 437.5000 | 8593.03 KB |
  SingleFieldAsClass_Dapper |  5.254 ms | 0.0321 ms | 0.0300 ms |   39.0625 |    7.8125 |        - |  178.63 KB |
 SingleFieldAsStruct_Dapper |  5.142 ms | 0.0185 ms | 0.0173 ms |   39.0625 |         - |        - |  178.63 KB |
