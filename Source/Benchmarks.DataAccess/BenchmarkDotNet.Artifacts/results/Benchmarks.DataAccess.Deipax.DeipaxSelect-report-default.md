
BenchmarkDotNet=v0.12.0, OS=Windows 10.0.17763.914 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.0.100
  [Host]     : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT
  Job-CYIOGA : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), X64 RyuJIT
  Job-TXVMHJ : .NET Core 2.2.7 (CoreCLR 4.6.28008.02, CoreFX 4.6.28008.03), X64 RyuJIT
  Job-CIEYVM : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT


                   Method |     Toolchain |     Mean |    Error |   StdDev | Ratio | RatioSD |     Gen 0 |     Gen 1 |    Gen 2 |  Allocated |
------------------------- |-------------- |---------:|---------:|---------:|------:|--------:|----------:|----------:|---------:|-----------:|
  AllFieldsAsClass_Deipax | .NET Core 2.0 | 37.87 ms | 0.230 ms | 0.215 ms |  1.00 |    0.00 | 2153.8462 | 1000.0000 | 153.8462 | 13573438 B |
  AllFieldsAsClass_Deipax | .NET Core 2.2 | 36.56 ms | 0.187 ms | 0.175 ms |  0.97 |    0.01 | 2142.8571 |  928.5714 | 142.8571 | 13573433 B |
  AllFieldsAsClass_Deipax | .NET Core 3.0 | 34.71 ms | 0.550 ms | 0.514 ms |  0.92 |    0.01 | 2066.6667 |  933.3333 | 200.0000 | 13165625 B |
  AllFieldsAsClass_Deipax |        net462 |       NA |       NA |       NA |     ? |       ? |         - |         - |        - |          - |
  AllFieldsAsClass_Deipax |        net472 |       NA |       NA |       NA |     ? |       ? |         - |         - |        - |          - |
  AllFieldsAsClass_Deipax |         net48 |       NA |       NA |       NA |     ? |       ? |         - |         - |        - |          - |
                          |               |          |          |          |       |         |           |           |          |            |
 AllFieldsAsStruct_Deipax | .NET Core 2.0 | 47.40 ms | 0.406 ms | 0.380 ms |  1.00 |    0.00 | 2818.1818 | 1909.0909 | 909.0909 | 16661726 B |
 AllFieldsAsStruct_Deipax | .NET Core 2.2 | 43.25 ms | 0.361 ms | 0.320 ms |  0.91 |    0.01 | 2750.0000 | 1833.3333 | 916.6667 | 16661573 B |
 AllFieldsAsStruct_Deipax | .NET Core 3.0 | 38.17 ms | 0.558 ms | 0.494 ms |  0.80 |    0.01 | 2714.2857 | 1857.1429 | 928.5714 | 16252604 B |
 AllFieldsAsStruct_Deipax |        net462 |       NA |       NA |       NA |     ? |       ? |         - |         - |        - |          - |
 AllFieldsAsStruct_Deipax |        net472 |       NA |       NA |       NA |     ? |       ? |         - |         - |        - |          - |
 AllFieldsAsStruct_Deipax |         net48 |       NA |       NA |       NA |     ? |       ? |         - |         - |        - |          - |
                          |               |          |          |          |       |         |           |           |          |            |
       DynamicList_Deipax | .NET Core 2.0 | 37.67 ms | 0.347 ms | 0.324 ms |  1.00 |    0.00 | 2285.7143 | 1000.0000 | 285.7143 | 13764042 B |
       DynamicList_Deipax | .NET Core 2.2 | 36.52 ms | 0.263 ms | 0.246 ms |  0.97 |    0.01 | 2285.7143 | 1000.0000 | 285.7143 | 13764384 B |
       DynamicList_Deipax | .NET Core 3.0 | 31.61 ms | 0.370 ms | 0.346 ms |  0.84 |    0.01 | 2125.0000 | 1000.0000 | 125.0000 | 13355946 B |
       DynamicList_Deipax |        net462 |       NA |       NA |       NA |     ? |       ? |         - |         - |        - |          - |
       DynamicList_Deipax |        net472 |       NA |       NA |       NA |     ? |       ? |         - |         - |        - |          - |
       DynamicList_Deipax |         net48 |       NA |       NA |       NA |     ? |       ? |         - |         - |        - |          - |

Benchmarks with issues:
  DeipaxSelect.AllFieldsAsClass_Deipax: Job-KKWYXK(Toolchain=net462)
  DeipaxSelect.AllFieldsAsClass_Deipax: Job-XFLSCM(Toolchain=net472)
  DeipaxSelect.AllFieldsAsClass_Deipax: Job-BDZJJC(Toolchain=net48)
  DeipaxSelect.AllFieldsAsStruct_Deipax: Job-KKWYXK(Toolchain=net462)
  DeipaxSelect.AllFieldsAsStruct_Deipax: Job-XFLSCM(Toolchain=net472)
  DeipaxSelect.AllFieldsAsStruct_Deipax: Job-BDZJJC(Toolchain=net48)
  DeipaxSelect.DynamicList_Deipax: Job-KKWYXK(Toolchain=net462)
  DeipaxSelect.DynamicList_Deipax: Job-XFLSCM(Toolchain=net472)
  DeipaxSelect.DynamicList_Deipax: Job-BDZJJC(Toolchain=net48)
