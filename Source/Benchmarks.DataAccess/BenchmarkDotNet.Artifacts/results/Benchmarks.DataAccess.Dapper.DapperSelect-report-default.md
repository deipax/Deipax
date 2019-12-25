
BenchmarkDotNet=v0.12.0, OS=Windows 10.0.17763.914 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.0.100
  [Host]     : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT
  Job-AXMPOB : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), X64 RyuJIT
  Job-GYILMG : .NET Core 2.2.7 (CoreCLR 4.6.28008.02, CoreFX 4.6.28008.03), X64 RyuJIT
  Job-RBZVIF : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT


                  Method |     Toolchain |     Mean |    Error |   StdDev | Ratio | RatioSD |     Gen 0 |     Gen 1 |    Gen 2 | Allocated |
------------------------ |-------------- |---------:|---------:|---------:|------:|--------:|----------:|----------:|---------:|----------:|
        AllFieldsAsClass | .NET Core 2.0 | 43.85 ms | 0.896 ms | 2.005 ms |  1.00 |    0.00 | 2181.8182 | 1000.0000 | 181.8182 |  13.19 MB |
        AllFieldsAsClass | .NET Core 2.2 | 42.08 ms | 0.804 ms | 0.790 ms |  0.96 |    0.05 | 2166.6667 |  916.6667 | 166.6667 |  13.19 MB |
        AllFieldsAsClass | .NET Core 3.0 | 40.82 ms | 0.815 ms | 1.362 ms |  0.92 |    0.05 | 2153.8462 |  923.0769 | 230.7692 |   12.8 MB |
                         |               |          |          |          |       |         |           |           |          |           |
  AllFieldsAsClass_Async | .NET Core 2.0 | 42.73 ms | 0.851 ms | 1.512 ms |  1.00 |    0.00 | 2166.6667 |  916.6667 | 166.6667 |  13.19 MB |
  AllFieldsAsClass_Async | .NET Core 2.2 | 42.09 ms | 0.834 ms | 1.114 ms |  0.99 |    0.03 | 2166.6667 |  916.6667 | 166.6667 |  13.19 MB |
  AllFieldsAsClass_Async | .NET Core 3.0 | 40.97 ms | 0.994 ms | 1.426 ms |  0.96 |    0.05 | 2153.8462 |  923.0769 | 230.7692 |   12.8 MB |
                         |               |          |          |          |       |         |           |           |          |           |
       AllFieldsAsStruct | .NET Core 2.0 | 54.13 ms | 1.072 ms | 1.905 ms |  1.00 |    0.00 | 2900.0000 | 1600.0000 | 900.0000 |  17.25 MB |
       AllFieldsAsStruct | .NET Core 2.2 | 50.64 ms | 1.103 ms | 1.617 ms |  0.94 |    0.05 | 2900.0000 | 1600.0000 | 900.0000 |  17.25 MB |
       AllFieldsAsStruct | .NET Core 3.0 | 48.57 ms | 0.949 ms | 1.477 ms |  0.90 |    0.04 | 2818.1818 | 1818.1818 | 909.0909 |  16.86 MB |
                         |               |          |          |          |       |         |           |           |          |           |
 AllFieldsAsStruct_Async | .NET Core 2.0 | 53.75 ms | 1.055 ms | 1.514 ms |  1.00 |    0.00 | 2900.0000 | 1600.0000 | 900.0000 |  17.25 MB |
 AllFieldsAsStruct_Async | .NET Core 2.2 | 49.34 ms | 0.986 ms | 1.727 ms |  0.92 |    0.04 | 2909.0909 | 1636.3636 | 909.0909 |  17.25 MB |
 AllFieldsAsStruct_Async | .NET Core 3.0 | 46.62 ms | 0.900 ms | 1.201 ms |  0.87 |    0.03 | 2818.1818 | 1818.1818 | 909.0909 |  16.86 MB |
                         |               |          |          |          |       |         |           |           |          |           |
             DynamicList | .NET Core 2.0 | 44.76 ms | 0.880 ms | 0.978 ms |  1.00 |    0.00 | 2363.6364 | 1000.0000 | 363.6364 |  13.16 MB |
             DynamicList | .NET Core 2.2 | 43.10 ms | 0.829 ms | 1.049 ms |  0.97 |    0.03 | 2416.6667 | 1000.0000 | 416.6667 |  13.16 MB |
             DynamicList | .NET Core 3.0 | 40.73 ms | 0.790 ms | 1.321 ms |  0.91 |    0.04 | 2230.7692 |  923.0769 | 307.6923 |  12.77 MB |
                         |               |          |          |          |       |         |           |           |          |           |
       DynamicList_Async | .NET Core 2.0 | 44.55 ms | 0.891 ms | 1.651 ms |  1.00 |    0.00 | 2363.6364 | 1000.0000 | 363.6364 |  13.16 MB |
       DynamicList_Async | .NET Core 2.2 | 43.50 ms | 0.856 ms | 1.358 ms |  0.98 |    0.05 | 2416.6667 | 1000.0000 | 416.6667 |  13.16 MB |
       DynamicList_Async | .NET Core 3.0 | 41.29 ms | 0.823 ms | 1.505 ms |  0.93 |    0.05 | 2250.0000 |  916.6667 | 250.0000 |  12.77 MB |
