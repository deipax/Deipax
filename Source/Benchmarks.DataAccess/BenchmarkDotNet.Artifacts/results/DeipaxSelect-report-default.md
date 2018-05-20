
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.431 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
  [Host]     : .NET Framework 4.6.1 (CLR 4.0.30319.42000), 32bit LegacyJIT-v4.7.2650.0
  DefaultJob : .NET Framework 4.6.1 (CLR 4.0.30319.42000), 32bit LegacyJIT-v4.7.2650.0


                   Method |     Mean |     Error |    StdDev |     Gen 0 |     Gen 1 |     Gen 2 | Allocated |
------------------------- |---------:|----------:|----------:|----------:|----------:|----------:|----------:|
  AllFieldsAsClass_Deipax | 64.08 ms | 0.6473 ms | 0.6055 ms | 2062.5000 | 1375.0000 |  500.0000 |   9.45 MB |
 AllFieldsAsStruct_Deipax | 80.03 ms | 0.7569 ms | 0.6710 ms | 2250.0000 | 1500.0000 |  687.5000 |  11.38 MB |
       DynamicList_Deipax | 93.45 ms | 1.8306 ms | 3.0077 ms | 4250.0000 | 3125.0000 | 1312.5000 |  15.43 MB |
  AllFieldsAsClass_Dapper | 69.47 ms | 1.3528 ms | 1.5579 ms | 2062.5000 | 1437.5000 |  562.5000 |   9.61 MB |
 AllFieldsAsStruct_Dapper | 88.18 ms | 0.9832 ms | 0.9196 ms | 2312.5000 | 1375.0000 |  750.0000 |  12.27 MB |
       DynamicList_Dapper | 65.74 ms | 1.2252 ms | 1.1460 ms | 2062.5000 | 1437.5000 |  562.5000 |    9.4 MB |
