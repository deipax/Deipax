
BenchmarkDotNet=v0.12.0, OS=Windows 10.0.17763.914 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.0.100
  [Host]     : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT
  Job-FAKALP : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), X64 RyuJIT
  Job-DEJPFA : .NET Core 2.2.7 (CoreCLR 4.6.28008.02, CoreFX 4.6.28008.03), X64 RyuJIT
  Job-WRHJWW : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT


                  Method |     Toolchain |     Mean |    Error |   StdDev |   Median | Ratio | RatioSD |     Gen 0 |     Gen 1 |     Gen 2 |  Allocated |
------------------------ |-------------- |---------:|---------:|---------:|---------:|------:|--------:|----------:|----------:|----------:|-----------:|
        AllFieldsAsClass | .NET Core 2.0 | 38.48 ms | 0.430 ms | 0.381 ms | 38.31 ms |  1.00 |    0.00 | 2153.8462 | 1000.0000 |  153.8462 | 13573438 B |
        AllFieldsAsClass | .NET Core 2.2 | 37.88 ms | 0.267 ms | 0.223 ms | 37.95 ms |  0.98 |    0.01 | 2153.8462 | 1000.0000 |  153.8462 | 13573438 B |
        AllFieldsAsClass | .NET Core 3.0 | 35.95 ms | 0.601 ms | 0.533 ms | 35.98 ms |  0.93 |    0.02 | 2071.4286 |  928.5714 |  142.8571 | 13165627 B |
        AllFieldsAsClass |        net462 |       NA |       NA |       NA |       NA |     ? |       ? |         - |         - |         - |          - |
        AllFieldsAsClass |        net472 |       NA |       NA |       NA |       NA |     ? |       ? |         - |         - |         - |          - |
        AllFieldsAsClass |         net48 |       NA |       NA |       NA |       NA |     ? |       ? |         - |         - |         - |          - |
                         |               |          |          |          |          |       |         |           |           |           |            |
  AllFieldsAsClass_Async | .NET Core 2.0 | 38.04 ms | 0.547 ms | 0.512 ms | 37.79 ms |  1.00 |    0.00 | 2142.8571 |  928.5714 |  142.8571 | 13573793 B |
  AllFieldsAsClass_Async | .NET Core 2.2 | 37.35 ms | 0.723 ms | 0.604 ms | 37.21 ms |  0.98 |    0.01 | 2083.3333 |  916.6667 |  166.6667 | 13573779 B |
  AllFieldsAsClass_Async | .NET Core 3.0 | 34.87 ms | 0.520 ms | 0.461 ms | 34.99 ms |  0.92 |    0.02 | 2071.4286 |  928.5714 |  142.8571 | 13165987 B |
  AllFieldsAsClass_Async |        net462 |       NA |       NA |       NA |       NA |     ? |       ? |         - |         - |         - |          - |
  AllFieldsAsClass_Async |        net472 |       NA |       NA |       NA |       NA |     ? |       ? |         - |         - |         - |          - |
  AllFieldsAsClass_Async |         net48 |       NA |       NA |       NA |       NA |     ? |       ? |         - |         - |         - |          - |
                         |               |          |          |          |          |       |         |           |           |           |            |
       AllFieldsAsStruct | .NET Core 2.0 | 49.69 ms | 0.959 ms | 1.066 ms | 49.17 ms |  1.00 |    0.00 | 2800.0000 | 1900.0000 |  900.0000 | 16662350 B |
       AllFieldsAsStruct | .NET Core 2.2 | 46.52 ms | 0.873 ms | 0.729 ms | 46.43 ms |  0.93 |    0.03 | 2727.2727 | 1818.1818 |  909.0909 | 16661085 B |
       AllFieldsAsStruct | .NET Core 3.0 | 38.62 ms | 0.713 ms | 0.700 ms | 38.62 ms |  0.78 |    0.02 | 2714.2857 | 1857.1429 |  928.5714 | 16254728 B |
       AllFieldsAsStruct |        net462 |       NA |       NA |       NA |       NA |     ? |       ? |         - |         - |         - |          - |
       AllFieldsAsStruct |        net472 |       NA |       NA |       NA |       NA |     ? |       ? |         - |         - |         - |          - |
       AllFieldsAsStruct |         net48 |       NA |       NA |       NA |       NA |     ? |       ? |         - |         - |         - |          - |
                         |               |          |          |          |          |       |         |           |           |           |            |
 AllFieldsAsStruct_Async | .NET Core 2.0 | 48.43 ms | 0.853 ms | 0.798 ms | 47.99 ms |  1.00 |    0.00 | 2818.1818 | 1909.0909 |  909.0909 | 16662596 B |
 AllFieldsAsStruct_Async | .NET Core 2.2 | 46.41 ms | 0.496 ms | 0.440 ms | 46.55 ms |  0.96 |    0.01 | 2818.1818 | 1909.0909 |  909.0909 | 16662796 B |
 AllFieldsAsStruct_Async | .NET Core 3.0 | 40.12 ms | 0.193 ms | 0.171 ms | 40.11 ms |  0.83 |    0.01 | 2846.1538 | 1923.0769 | 1000.0000 | 16255476 B |
 AllFieldsAsStruct_Async |        net462 |       NA |       NA |       NA |       NA |     ? |       ? |         - |         - |         - |          - |
 AllFieldsAsStruct_Async |        net472 |       NA |       NA |       NA |       NA |     ? |       ? |         - |         - |         - |          - |
 AllFieldsAsStruct_Async |         net48 |       NA |       NA |       NA |       NA |     ? |       ? |         - |         - |         - |          - |
                         |               |          |          |          |          |       |         |           |           |           |            |
             DynamicList | .NET Core 2.0 | 40.28 ms | 1.810 ms | 1.693 ms | 39.77 ms |  1.00 |    0.00 | 2285.7143 | 1000.0000 |  285.7143 | 13764687 B |
             DynamicList | .NET Core 2.2 | 38.55 ms | 0.531 ms | 0.496 ms | 38.64 ms |  0.96 |    0.04 | 2307.6923 | 1000.0000 |  307.6923 | 13764190 B |
             DynamicList | .NET Core 3.0 | 33.15 ms | 0.653 ms | 1.290 ms | 33.71 ms |  0.81 |    0.05 | 2066.6667 |  933.3333 |  266.6667 | 13355913 B |
             DynamicList |        net462 |       NA |       NA |       NA |       NA |     ? |       ? |         - |         - |         - |          - |
             DynamicList |        net472 |       NA |       NA |       NA |       NA |     ? |       ? |         - |         - |         - |          - |
             DynamicList |         net48 |       NA |       NA |       NA |       NA |     ? |       ? |         - |         - |         - |          - |
                         |               |          |          |          |          |       |         |           |           |           |            |
       DynamicList_Async | .NET Core 2.0 | 39.75 ms | 0.844 ms | 0.789 ms | 39.68 ms |  1.00 |    0.00 | 2307.6923 | 1000.0000 |  307.6923 | 13764807 B |
       DynamicList_Async | .NET Core 2.2 | 37.96 ms | 0.484 ms | 0.429 ms | 37.80 ms |  0.95 |    0.02 | 2307.6923 | 1000.0000 |  307.6923 | 13764250 B |
       DynamicList_Async | .NET Core 3.0 | 33.39 ms | 0.653 ms | 1.259 ms | 33.41 ms |  0.82 |    0.03 | 2071.4286 |  928.5714 |  285.7143 | 13356279 B |
       DynamicList_Async |        net462 |       NA |       NA |       NA |       NA |     ? |       ? |         - |         - |         - |          - |
       DynamicList_Async |        net472 |       NA |       NA |       NA |       NA |     ? |       ? |         - |         - |         - |          - |
       DynamicList_Async |         net48 |       NA |       NA |       NA |       NA |     ? |       ? |         - |         - |         - |          - |

Benchmarks with issues:
  DeipaxSelect.AllFieldsAsClass: Job-BEXCGR(Toolchain=net462)
  DeipaxSelect.AllFieldsAsClass: Job-XGEKOX(Toolchain=net472)
  DeipaxSelect.AllFieldsAsClass: Job-NFJPWK(Toolchain=net48)
  DeipaxSelect.AllFieldsAsClass_Async: Job-BEXCGR(Toolchain=net462)
  DeipaxSelect.AllFieldsAsClass_Async: Job-XGEKOX(Toolchain=net472)
  DeipaxSelect.AllFieldsAsClass_Async: Job-NFJPWK(Toolchain=net48)
  DeipaxSelect.AllFieldsAsStruct: Job-BEXCGR(Toolchain=net462)
  DeipaxSelect.AllFieldsAsStruct: Job-XGEKOX(Toolchain=net472)
  DeipaxSelect.AllFieldsAsStruct: Job-NFJPWK(Toolchain=net48)
  DeipaxSelect.AllFieldsAsStruct_Async: Job-BEXCGR(Toolchain=net462)
  DeipaxSelect.AllFieldsAsStruct_Async: Job-XGEKOX(Toolchain=net472)
  DeipaxSelect.AllFieldsAsStruct_Async: Job-NFJPWK(Toolchain=net48)
  DeipaxSelect.DynamicList: Job-BEXCGR(Toolchain=net462)
  DeipaxSelect.DynamicList: Job-XGEKOX(Toolchain=net472)
  DeipaxSelect.DynamicList: Job-NFJPWK(Toolchain=net48)
  DeipaxSelect.DynamicList_Async: Job-BEXCGR(Toolchain=net462)
  DeipaxSelect.DynamicList_Async: Job-XGEKOX(Toolchain=net472)
  DeipaxSelect.DynamicList_Async: Job-NFJPWK(Toolchain=net48)
