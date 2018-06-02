
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.17134
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435888 Hz, Resolution=291.0456 ns, Timer=TSC
  [Host]     : .NET Framework 4.6.1 (CLR 4.0.30319.42000), 32bit LegacyJIT-v4.7.3101.0
  DefaultJob : .NET Framework 4.6.1 (CLR 4.0.30319.42000), 32bit LegacyJIT-v4.7.3101.0


                   Method |     Mean |     Error |    StdDev |     Gen 0 |     Gen 1 |    Gen 2 | Allocated |
------------------------- |---------:|----------:|----------:|----------:|----------:|---------:|----------:|
  AllFieldsAsClass_Deipax | 65.50 ms | 0.8357 ms | 0.7817 ms | 2062.5000 | 1375.0000 | 500.0000 |   9.45 MB |
 AllFieldsAsStruct_Deipax | 73.50 ms | 1.3983 ms | 1.3080 ms | 2125.0000 | 1500.0000 | 687.5000 |  11.38 MB |
       DynamicList_Deipax | 57.70 ms | 1.1213 ms | 1.7458 ms | 2000.0000 | 1250.0000 | 312.5000 |   9.41 MB |
  AllFieldsAsClass_Dapper | 76.54 ms | 1.5167 ms | 1.3445 ms | 2187.5000 | 1562.5000 | 562.5000 |   9.61 MB |
 AllFieldsAsStruct_Dapper | 81.95 ms | 1.4588 ms | 2.4772 ms | 2500.0000 | 1562.5000 | 750.0000 |  12.27 MB |
       DynamicList_Dapper | 64.36 ms | 1.2761 ms | 1.7035 ms | 2187.5000 | 1437.5000 | 500.0000 |    9.4 MB |
