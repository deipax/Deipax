
BenchmarkDotNet=v0.12.0, OS=Windows 10.0.17763.864 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.0.100
  [Host]     : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT
  Job-ONKSQR : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), X64 RyuJIT
  Job-CPIWRK : .NET Core 2.2.7 (CoreCLR 4.6.28008.02, CoreFX 4.6.28008.03), X64 RyuJIT
  Job-FCRTCX : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT


                   Method |     Toolchain |     Mean |    Error |   StdDev |   Median | Ratio | RatioSD |     Gen 0 |     Gen 1 |    Gen 2 |  Allocated |
------------------------- |-------------- |---------:|---------:|---------:|---------:|------:|--------:|----------:|----------:|---------:|-----------:|
  AllFieldsAsClass_Deipax | .NET Core 2.0 | 40.72 ms | 0.788 ms | 0.809 ms | 40.56 ms |  1.00 |    0.00 | 2090.9091 |  909.0909 | 181.8182 | 13573871 B |
  AllFieldsAsClass_Deipax | .NET Core 2.2 | 38.69 ms | 0.194 ms | 0.181 ms | 38.70 ms |  0.95 |    0.02 | 2142.8571 |  928.5714 | 142.8571 | 13573881 B |
  AllFieldsAsClass_Deipax | .NET Core 3.0 | 35.74 ms | 0.388 ms | 0.363 ms | 35.79 ms |  0.88 |    0.02 | 2066.6667 |  933.3333 | 200.0000 | 13166073 B |
  AllFieldsAsClass_Deipax |        net462 |       NA |       NA |       NA |       NA |     ? |       ? |         - |         - |        - |          - |
  AllFieldsAsClass_Deipax |        net472 |       NA |       NA |       NA |       NA |     ? |       ? |         - |         - |        - |          - |
  AllFieldsAsClass_Deipax |         net48 |       NA |       NA |       NA |       NA |     ? |       ? |         - |         - |        - |          - |
                          |               |          |          |          |          |       |         |           |           |          |            |
 AllFieldsAsStruct_Deipax | .NET Core 2.0 | 48.48 ms | 0.510 ms | 0.478 ms | 48.36 ms |  1.00 |    0.00 | 2818.1818 | 1909.0909 | 909.0909 | 16662777 B |
 AllFieldsAsStruct_Deipax | .NET Core 2.2 | 44.88 ms | 0.671 ms | 0.628 ms | 44.75 ms |  0.93 |    0.01 | 2750.0000 | 1833.3333 | 916.6667 | 16663031 B |
 AllFieldsAsStruct_Deipax | .NET Core 3.0 | 38.02 ms | 0.329 ms | 0.308 ms | 37.99 ms |  0.78 |    0.01 | 2714.2857 | 1857.1429 | 928.5714 | 16255261 B |
 AllFieldsAsStruct_Deipax |        net462 |       NA |       NA |       NA |       NA |     ? |       ? |         - |         - |        - |          - |
 AllFieldsAsStruct_Deipax |        net472 |       NA |       NA |       NA |       NA |     ? |       ? |         - |         - |        - |          - |
 AllFieldsAsStruct_Deipax |         net48 |       NA |       NA |       NA |       NA |     ? |       ? |         - |         - |        - |          - |
                          |               |          |          |          |          |       |         |           |           |          |            |
       DynamicList_Deipax | .NET Core 2.0 | 39.00 ms | 0.634 ms | 0.593 ms | 39.14 ms |  1.00 |    0.00 | 2307.6923 | 1000.0000 | 307.6923 | 13764673 B |
       DynamicList_Deipax | .NET Core 2.2 | 36.42 ms | 0.242 ms | 0.226 ms | 36.50 ms |  0.93 |    0.02 | 2285.7143 | 1000.0000 | 285.7143 | 13764960 B |
       DynamicList_Deipax | .NET Core 3.0 | 33.92 ms | 0.670 ms | 1.292 ms | 34.46 ms |  0.85 |    0.03 | 2125.0000 | 1000.0000 | 312.5000 | 13356394 B |
       DynamicList_Deipax |        net462 |       NA |       NA |       NA |       NA |     ? |       ? |         - |         - |        - |          - |
       DynamicList_Deipax |        net472 |       NA |       NA |       NA |       NA |     ? |       ? |         - |         - |        - |          - |
       DynamicList_Deipax |         net48 |       NA |       NA |       NA |       NA |     ? |       ? |         - |         - |        - |          - |

Benchmarks with issues:
  DeipaxSelect.AllFieldsAsClass_Deipax: Job-HXHMTN(Toolchain=net462)
  DeipaxSelect.AllFieldsAsClass_Deipax: Job-MRGEET(Toolchain=net472)
  DeipaxSelect.AllFieldsAsClass_Deipax: Job-TYIBXQ(Toolchain=net48)
  DeipaxSelect.AllFieldsAsStruct_Deipax: Job-HXHMTN(Toolchain=net462)
  DeipaxSelect.AllFieldsAsStruct_Deipax: Job-MRGEET(Toolchain=net472)
  DeipaxSelect.AllFieldsAsStruct_Deipax: Job-TYIBXQ(Toolchain=net48)
  DeipaxSelect.DynamicList_Deipax: Job-HXHMTN(Toolchain=net462)
  DeipaxSelect.DynamicList_Deipax: Job-MRGEET(Toolchain=net472)
  DeipaxSelect.DynamicList_Deipax: Job-TYIBXQ(Toolchain=net48)
