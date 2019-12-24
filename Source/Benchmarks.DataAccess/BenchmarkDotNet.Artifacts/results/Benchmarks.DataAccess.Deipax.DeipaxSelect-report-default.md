
BenchmarkDotNet=v0.12.0, OS=Windows 10.0.17763.914 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.0.100
  [Host]     : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT
  Job-CRLCKA : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), X64 RyuJIT
  Job-HIUJXT : .NET Core 2.2.7 (CoreCLR 4.6.28008.02, CoreFX 4.6.28008.03), X64 RyuJIT
  Job-GEBPZK : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT


                  Method |     Toolchain |     Mean |    Error |   StdDev |   Median | Ratio | RatioSD |     Gen 0 |     Gen 1 |     Gen 2 |  Allocated |
------------------------ |-------------- |---------:|---------:|---------:|---------:|------:|--------:|----------:|----------:|----------:|-----------:|
        AllFieldsAsClass | .NET Core 2.0 | 39.40 ms | 0.770 ms | 0.720 ms | 39.06 ms |  1.00 |    0.00 | 2153.8462 | 1000.0000 |  153.8462 | 13573462 B |
        AllFieldsAsClass | .NET Core 2.2 | 37.17 ms | 0.249 ms | 0.232 ms | 37.13 ms |  0.94 |    0.02 | 2142.8571 |  928.5714 |  142.8571 | 13573457 B |
        AllFieldsAsClass | .NET Core 3.0 | 35.89 ms | 0.436 ms | 0.408 ms | 35.88 ms |  0.91 |    0.02 | 2066.6667 |  933.3333 |  200.0000 | 13165651 B |
        AllFieldsAsClass |        net462 |       NA |       NA |       NA |       NA |     ? |       ? |         - |         - |         - |          - |
        AllFieldsAsClass |        net472 |       NA |       NA |       NA |       NA |     ? |       ? |         - |         - |         - |          - |
        AllFieldsAsClass |         net48 |       NA |       NA |       NA |       NA |     ? |       ? |         - |         - |         - |          - |
                         |               |          |          |          |          |       |         |           |           |           |            |
  AllFieldsAsClass_Async | .NET Core 2.0 | 38.78 ms | 0.133 ms | 0.118 ms | 38.75 ms |  1.00 |    0.00 | 2153.8462 | 1000.0000 |  153.8462 | 13573822 B |
  AllFieldsAsClass_Async | .NET Core 2.2 | 38.24 ms | 0.731 ms | 0.813 ms | 38.08 ms |  0.98 |    0.02 | 2142.8571 |  928.5714 |  142.8571 | 13573817 B |
  AllFieldsAsClass_Async | .NET Core 3.0 | 35.88 ms | 0.695 ms | 0.650 ms | 35.72 ms |  0.92 |    0.02 | 2066.6667 |  933.3333 |  200.0000 | 13166009 B |
  AllFieldsAsClass_Async |        net462 |       NA |       NA |       NA |       NA |     ? |       ? |         - |         - |         - |          - |
  AllFieldsAsClass_Async |        net472 |       NA |       NA |       NA |       NA |     ? |       ? |         - |         - |         - |          - |
  AllFieldsAsClass_Async |         net48 |       NA |       NA |       NA |       NA |     ? |       ? |         - |         - |         - |          - |
                         |               |          |          |          |          |       |         |           |           |           |            |
       AllFieldsAsStruct | .NET Core 2.0 | 52.19 ms | 0.805 ms | 0.714 ms | 52.21 ms |  1.00 |    0.00 | 2800.0000 | 1900.0000 |  900.0000 | 16662578 B |
       AllFieldsAsStruct | .NET Core 2.2 | 43.90 ms | 0.458 ms | 0.429 ms | 43.87 ms |  0.84 |    0.01 | 2750.0000 | 1833.3333 |  916.6667 | 16662353 B |
       AllFieldsAsStruct | .NET Core 3.0 | 39.22 ms | 0.261 ms | 0.244 ms | 39.27 ms |  0.75 |    0.01 | 2846.1538 | 1923.0769 | 1000.0000 | 16253837 B |
       AllFieldsAsStruct |        net462 |       NA |       NA |       NA |       NA |     ? |       ? |         - |         - |         - |          - |
       AllFieldsAsStruct |        net472 |       NA |       NA |       NA |       NA |     ? |       ? |         - |         - |         - |          - |
       AllFieldsAsStruct |         net48 |       NA |       NA |       NA |       NA |     ? |       ? |         - |         - |         - |          - |
                         |               |          |          |          |          |       |         |           |           |           |            |
 AllFieldsAsStruct_Async | .NET Core 2.0 | 49.56 ms | 0.398 ms | 0.373 ms | 49.59 ms |  1.00 |    0.00 | 2800.0000 | 1900.0000 |  900.0000 | 16662514 B |
 AllFieldsAsStruct_Async | .NET Core 2.2 | 44.32 ms | 0.563 ms | 0.527 ms | 44.39 ms |  0.89 |    0.01 | 2750.0000 | 1833.3333 |  916.6667 | 16662274 B |
 AllFieldsAsStruct_Async | .NET Core 3.0 | 38.72 ms | 0.135 ms | 0.126 ms | 38.73 ms |  0.78 |    0.01 | 2846.1538 | 1923.0769 | 1000.0000 | 16254276 B |
 AllFieldsAsStruct_Async |        net462 |       NA |       NA |       NA |       NA |     ? |       ? |         - |         - |         - |          - |
 AllFieldsAsStruct_Async |        net472 |       NA |       NA |       NA |       NA |     ? |       ? |         - |         - |         - |          - |
 AllFieldsAsStruct_Async |         net48 |       NA |       NA |       NA |       NA |     ? |       ? |         - |         - |         - |          - |
                         |               |          |          |          |          |       |         |           |           |           |            |
             DynamicList | .NET Core 2.0 | 38.78 ms | 0.408 ms | 0.382 ms | 38.69 ms |  1.00 |    0.00 | 2307.6923 | 1000.0000 |  307.6923 | 13764479 B |
             DynamicList | .NET Core 2.2 | 37.44 ms | 0.341 ms | 0.319 ms | 37.49 ms |  0.97 |    0.01 | 2285.7143 | 1000.0000 |  285.7143 | 13764107 B |
             DynamicList | .NET Core 3.0 | 32.52 ms | 0.385 ms | 0.360 ms | 32.48 ms |  0.84 |    0.01 | 2125.0000 | 1000.0000 |  125.0000 | 13355970 B |
             DynamicList |        net462 |       NA |       NA |       NA |       NA |     ? |       ? |         - |         - |         - |          - |
             DynamicList |        net472 |       NA |       NA |       NA |       NA |     ? |       ? |         - |         - |         - |          - |
             DynamicList |         net48 |       NA |       NA |       NA |       NA |     ? |       ? |         - |         - |         - |          - |
                         |               |          |          |          |          |       |         |           |           |           |            |
       DynamicList_Async | .NET Core 2.0 | 39.99 ms | 0.764 ms | 0.714 ms | 39.79 ms |  1.00 |    0.00 | 2307.6923 | 1000.0000 |  307.6923 | 13764930 B |
       DynamicList_Async | .NET Core 2.2 | 37.07 ms | 0.216 ms | 0.191 ms | 37.11 ms |  0.93 |    0.02 | 2307.6923 | 1000.0000 |  307.6923 | 13764729 B |
       DynamicList_Async | .NET Core 3.0 | 33.42 ms | 0.665 ms | 1.181 ms | 34.12 ms |  0.82 |    0.03 | 2066.6667 |  933.3333 |  266.6667 | 13356297 B |
       DynamicList_Async |        net462 |       NA |       NA |       NA |       NA |     ? |       ? |         - |         - |         - |          - |
       DynamicList_Async |        net472 |       NA |       NA |       NA |       NA |     ? |       ? |         - |         - |         - |          - |
       DynamicList_Async |         net48 |       NA |       NA |       NA |       NA |     ? |       ? |         - |         - |         - |          - |

Benchmarks with issues:
  DeipaxSelect.AllFieldsAsClass: Job-YVXFNB(Toolchain=net462)
  DeipaxSelect.AllFieldsAsClass: Job-YSFLDJ(Toolchain=net472)
  DeipaxSelect.AllFieldsAsClass: Job-AYSQSL(Toolchain=net48)
  DeipaxSelect.AllFieldsAsClass_Async: Job-YVXFNB(Toolchain=net462)
  DeipaxSelect.AllFieldsAsClass_Async: Job-YSFLDJ(Toolchain=net472)
  DeipaxSelect.AllFieldsAsClass_Async: Job-AYSQSL(Toolchain=net48)
  DeipaxSelect.AllFieldsAsStruct: Job-YVXFNB(Toolchain=net462)
  DeipaxSelect.AllFieldsAsStruct: Job-YSFLDJ(Toolchain=net472)
  DeipaxSelect.AllFieldsAsStruct: Job-AYSQSL(Toolchain=net48)
  DeipaxSelect.AllFieldsAsStruct_Async: Job-YVXFNB(Toolchain=net462)
  DeipaxSelect.AllFieldsAsStruct_Async: Job-YSFLDJ(Toolchain=net472)
  DeipaxSelect.AllFieldsAsStruct_Async: Job-AYSQSL(Toolchain=net48)
  DeipaxSelect.DynamicList: Job-YVXFNB(Toolchain=net462)
  DeipaxSelect.DynamicList: Job-YSFLDJ(Toolchain=net472)
  DeipaxSelect.DynamicList: Job-AYSQSL(Toolchain=net48)
  DeipaxSelect.DynamicList_Async: Job-YVXFNB(Toolchain=net462)
  DeipaxSelect.DynamicList_Async: Job-YSFLDJ(Toolchain=net472)
  DeipaxSelect.DynamicList_Async: Job-AYSQSL(Toolchain=net48)
