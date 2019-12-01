
BenchmarkDotNet=v0.12.0, OS=Windows 10.0.17763.864 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.0.100
  [Host]     : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT
  Job-RBYDQA : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), X64 RyuJIT
  Job-UPKNXR : .NET Core 2.2.7 (CoreCLR 4.6.28008.02, CoreFX 4.6.28008.03), X64 RyuJIT
  Job-BHRGGS : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT


                   Method |     Toolchain |     Mean |    Error |   StdDev | Ratio | RatioSD |     Gen 0 |     Gen 1 |     Gen 2 |  Allocated |
------------------------- |-------------- |---------:|---------:|---------:|------:|--------:|----------:|----------:|----------:|-----------:|
  AllFieldsAsClass_Deipax | .NET Core 2.0 | 41.73 ms | 0.827 ms | 1.076 ms |  1.00 |    0.00 | 2090.9091 |  909.0909 |  181.8182 | 13573791 B |
  AllFieldsAsClass_Deipax | .NET Core 2.2 | 38.28 ms | 0.741 ms | 0.793 ms |  0.92 |    0.03 | 2142.8571 |  928.5714 |  142.8571 | 13573801 B |
  AllFieldsAsClass_Deipax | .NET Core 3.0 | 34.77 ms | 0.195 ms | 0.173 ms |  0.83 |    0.03 | 2066.6667 |  933.3333 |  133.3333 | 13165993 B |
  AllFieldsAsClass_Deipax |        net462 |       NA |       NA |       NA |     ? |       ? |         - |         - |         - |          - |
  AllFieldsAsClass_Deipax |        net472 |       NA |       NA |       NA |     ? |       ? |         - |         - |         - |          - |
  AllFieldsAsClass_Deipax |         net48 |       NA |       NA |       NA |     ? |       ? |         - |         - |         - |          - |
                          |               |          |          |          |       |         |           |           |           |            |
 AllFieldsAsStruct_Deipax | .NET Core 2.0 | 49.33 ms | 0.408 ms | 0.362 ms |  1.00 |    0.00 | 2800.0000 | 1900.0000 |  900.0000 | 16662514 B |
 AllFieldsAsStruct_Deipax | .NET Core 2.2 | 44.99 ms | 0.489 ms | 0.458 ms |  0.91 |    0.01 | 2750.0000 | 1833.3333 |  916.6667 | 16662796 B |
 AllFieldsAsStruct_Deipax | .NET Core 3.0 | 39.23 ms | 0.256 ms | 0.227 ms |  0.80 |    0.01 | 2846.1538 | 1923.0769 | 1000.0000 | 16255439 B |
 AllFieldsAsStruct_Deipax |        net462 |       NA |       NA |       NA |     ? |       ? |         - |         - |         - |          - |
 AllFieldsAsStruct_Deipax |        net472 |       NA |       NA |       NA |     ? |       ? |         - |         - |         - |          - |
 AllFieldsAsStruct_Deipax |         net48 |       NA |       NA |       NA |     ? |       ? |         - |         - |         - |          - |
                          |               |          |          |          |       |         |           |           |           |            |
       DynamicList_Deipax | .NET Core 2.0 | 45.87 ms | 0.409 ms | 0.382 ms |  1.00 |    0.00 | 2500.0000 | 1166.6667 |  416.6667 | 13820458 B |
       DynamicList_Deipax | .NET Core 2.2 | 44.84 ms | 0.571 ms | 0.506 ms |  0.98 |    0.01 | 2500.0000 | 1166.6667 |  416.6667 | 13820126 B |
       DynamicList_Deipax | .NET Core 3.0 | 37.21 ms | 0.229 ms | 0.215 ms |  0.81 |    0.01 | 2214.2857 |  928.5714 |  285.7143 | 13412066 B |
       DynamicList_Deipax |        net462 |       NA |       NA |       NA |     ? |       ? |         - |         - |         - |          - |
       DynamicList_Deipax |        net472 |       NA |       NA |       NA |     ? |       ? |         - |         - |         - |          - |
       DynamicList_Deipax |         net48 |       NA |       NA |       NA |     ? |       ? |         - |         - |         - |          - |

Benchmarks with issues:
  DeipaxSelect.AllFieldsAsClass_Deipax: Job-CGASNA(Toolchain=net462)
  DeipaxSelect.AllFieldsAsClass_Deipax: Job-ZMEEBP(Toolchain=net472)
  DeipaxSelect.AllFieldsAsClass_Deipax: Job-AMKRHK(Toolchain=net48)
  DeipaxSelect.AllFieldsAsStruct_Deipax: Job-CGASNA(Toolchain=net462)
  DeipaxSelect.AllFieldsAsStruct_Deipax: Job-ZMEEBP(Toolchain=net472)
  DeipaxSelect.AllFieldsAsStruct_Deipax: Job-AMKRHK(Toolchain=net48)
  DeipaxSelect.DynamicList_Deipax: Job-CGASNA(Toolchain=net462)
  DeipaxSelect.DynamicList_Deipax: Job-ZMEEBP(Toolchain=net472)
  DeipaxSelect.DynamicList_Deipax: Job-AMKRHK(Toolchain=net48)
