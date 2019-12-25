
BenchmarkDotNet=v0.12.0, OS=Windows 10.0.17763.914 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.0.100
  [Host]     : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT
  Job-AXMPOB : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), X64 RyuJIT
  Job-GYILMG : .NET Core 2.2.7 (CoreCLR 4.6.28008.02, CoreFX 4.6.28008.03), X64 RyuJIT
  Job-RBZVIF : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT


                  Method |     Toolchain |     Mean |    Error |   StdDev |   Median | Ratio | RatioSD |     Gen 0 |     Gen 1 |     Gen 2 | Allocated |
------------------------ |-------------- |---------:|---------:|---------:|---------:|------:|--------:|----------:|----------:|----------:|----------:|
        AllFieldsAsClass | .NET Core 2.0 | 38.69 ms | 0.222 ms | 0.197 ms | 38.65 ms |  1.00 |    0.00 | 2153.8462 | 1000.0000 |  153.8462 |  12.95 MB |
        AllFieldsAsClass | .NET Core 2.2 | 37.70 ms | 0.501 ms | 0.469 ms | 37.43 ms |  0.98 |    0.01 | 2142.8571 |  928.5714 |  142.8571 |  12.95 MB |
        AllFieldsAsClass | .NET Core 3.0 | 35.90 ms | 0.682 ms | 0.837 ms | 35.83 ms |  0.93 |    0.02 | 2071.4286 |  928.5714 |  142.8571 |  12.56 MB |
                         |               |          |          |          |          |       |         |           |           |           |           |
  AllFieldsAsClass_Async | .NET Core 2.0 | 38.80 ms | 0.235 ms | 0.208 ms | 38.83 ms |  1.00 |    0.00 | 2153.8462 | 1000.0000 |  153.8462 |  12.95 MB |
  AllFieldsAsClass_Async | .NET Core 2.2 | 37.82 ms | 0.156 ms | 0.131 ms | 37.78 ms |  0.97 |    0.01 | 2142.8571 |  928.5714 |  142.8571 |  12.95 MB |
  AllFieldsAsClass_Async | .NET Core 3.0 | 34.67 ms | 0.410 ms | 0.364 ms | 34.62 ms |  0.89 |    0.01 | 2066.6667 |  933.3333 |  133.3333 |  12.56 MB |
                         |               |          |          |          |          |       |         |           |           |           |           |
       AllFieldsAsStruct | .NET Core 2.0 | 49.07 ms | 0.270 ms | 0.225 ms | 49.16 ms |  1.00 |    0.00 | 2818.1818 | 1909.0909 |  909.0909 |  15.89 MB |
       AllFieldsAsStruct | .NET Core 2.2 | 45.22 ms | 0.898 ms | 1.069 ms | 45.27 ms |  0.92 |    0.03 | 2750.0000 | 1833.3333 |  916.6667 |  15.89 MB |
       AllFieldsAsStruct | .NET Core 3.0 | 39.06 ms | 0.254 ms | 0.237 ms | 39.04 ms |  0.80 |    0.01 | 2846.1538 | 1923.0769 | 1000.0000 |   15.5 MB |
                         |               |          |          |          |          |       |         |           |           |           |           |
 AllFieldsAsStruct_Async | .NET Core 2.0 | 49.29 ms | 0.448 ms | 0.419 ms | 49.19 ms |  1.00 |    0.00 | 2818.1818 | 1909.0909 |  909.0909 |  15.89 MB |
 AllFieldsAsStruct_Async | .NET Core 2.2 | 44.49 ms | 0.605 ms | 0.566 ms | 44.58 ms |  0.90 |    0.02 | 2750.0000 | 1833.3333 |  916.6667 |  15.89 MB |
 AllFieldsAsStruct_Async | .NET Core 3.0 | 38.67 ms | 0.228 ms | 0.213 ms | 38.71 ms |  0.78 |    0.01 | 2846.1538 | 1923.0769 | 1000.0000 |   15.5 MB |
                         |               |          |          |          |          |       |         |           |           |           |           |
             DynamicList | .NET Core 2.0 | 38.48 ms | 0.490 ms | 0.459 ms | 38.34 ms |  1.00 |    0.00 | 2285.7143 | 1000.0000 |  285.7143 |  13.13 MB |
             DynamicList | .NET Core 2.2 | 37.57 ms | 0.400 ms | 0.374 ms | 37.60 ms |  0.98 |    0.02 | 2285.7143 | 1000.0000 |  285.7143 |  13.13 MB |
             DynamicList | .NET Core 3.0 | 32.52 ms | 0.587 ms | 0.549 ms | 32.55 ms |  0.85 |    0.02 | 2125.0000 | 1000.0000 |  125.0000 |  12.74 MB |
                         |               |          |          |          |          |       |         |           |           |           |           |
       DynamicList_Async | .NET Core 2.0 | 38.48 ms | 0.370 ms | 0.346 ms | 38.58 ms |  1.00 |    0.00 | 2307.6923 | 1000.0000 |  307.6923 |  13.13 MB |
       DynamicList_Async | .NET Core 2.2 | 36.99 ms | 0.329 ms | 0.274 ms | 37.06 ms |  0.96 |    0.01 | 2285.7143 | 1000.0000 |  285.7143 |  13.13 MB |
       DynamicList_Async | .NET Core 3.0 | 34.26 ms | 0.650 ms | 1.237 ms | 34.90 ms |  0.87 |    0.03 | 2125.0000 | 1000.0000 |  312.5000 |  12.74 MB |
