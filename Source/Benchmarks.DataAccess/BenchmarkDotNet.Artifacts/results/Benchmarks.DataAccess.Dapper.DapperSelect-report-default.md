
BenchmarkDotNet=v0.12.0, OS=Windows 10.0.17763.914 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.0.100
  [Host]     : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT
  Job-XYVOCI : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), X64 RyuJIT
  Job-DLSBQL : .NET Core 2.2.7 (CoreCLR 4.6.28008.02, CoreFX 4.6.28008.03), X64 RyuJIT
  Job-ZPORLS : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT


                  Method |     Toolchain |        Mean |     Error |      StdDev | Ratio | RatioSD |     Gen 0 |     Gen 1 |     Gen 2 |   Allocated |
------------------------ |-------------- |------------:|----------:|------------:|------:|--------:|----------:|----------:|----------:|------------:|
        AllFieldsAsClass | .NET Core 2.0 | 40,338.1 us | 319.68 us |   283.39 us |  1.00 |    0.00 | 2166.6667 |  916.6667 |  166.6667 | 13505.33 KB |
        AllFieldsAsClass | .NET Core 2.2 | 38,714.0 us | 131.09 us |   122.63 us |  0.96 |    0.01 | 2153.8462 |  923.0769 |  230.7692 | 13505.33 KB |
        AllFieldsAsClass | .NET Core 3.0 | 38,270.9 us | 604.46 us |   565.41 us |  0.95 |    0.02 | 2153.8462 |  923.0769 |  230.7692 | 13107.12 KB |
                         |               |             |           |             |       |         |           |           |           |             |
  AllFieldsAsClass_Async | .NET Core 2.0 | 40,189.2 us | 474.13 us |   443.50 us |  1.00 |    0.00 | 2153.8462 |  923.0769 |  230.7692 | 13505.26 KB |
  AllFieldsAsClass_Async | .NET Core 2.2 | 39,613.5 us | 353.57 us |   330.73 us |  0.99 |    0.01 | 2153.8462 |  923.0769 |  230.7692 | 13505.26 KB |
  AllFieldsAsClass_Async | .NET Core 3.0 | 38,253.9 us | 511.19 us |   478.16 us |  0.95 |    0.02 | 2153.8462 |  923.0769 |  230.7692 | 13107.36 KB |
                         |               |             |           |             |       |         |           |           |           |             |
       AllFieldsAsStruct | .NET Core 2.0 | 49,602.7 us | 200.86 us |   178.06 us |  1.00 |    0.00 | 2909.0909 | 1636.3636 |  909.0909 |  17665.9 KB |
       AllFieldsAsStruct | .NET Core 2.2 | 46,579.2 us | 459.59 us |   429.90 us |  0.94 |    0.01 | 2909.0909 | 1636.3636 |  909.0909 | 17665.46 KB |
       AllFieldsAsStruct | .NET Core 3.0 | 45,087.0 us | 221.57 us |   185.02 us |  0.91 |    0.00 | 2916.6667 | 1916.6667 |  916.6667 | 17266.77 KB |
                         |               |             |           |             |       |         |           |           |           |             |
 AllFieldsAsStruct_Async | .NET Core 2.0 | 48,501.6 us | 182.12 us |   170.35 us |  1.00 |    0.00 | 2909.0909 | 1636.3636 |  909.0909 | 17665.75 KB |
 AllFieldsAsStruct_Async | .NET Core 2.2 | 45,585.8 us | 181.72 us |   169.98 us |  0.94 |    0.00 | 3000.0000 | 1750.0000 | 1000.0000 | 17664.81 KB |
 AllFieldsAsStruct_Async | .NET Core 3.0 | 44,847.8 us | 666.10 us |   623.07 us |  0.92 |    0.01 | 2916.6667 | 1916.6667 |  916.6667 | 17266.31 KB |
                         |               |             |           |             |       |         |           |           |           |             |
             DynamicList | .NET Core 2.0 | 42,359.9 us | 273.05 us |   255.41 us |  1.00 |    0.00 | 2416.6667 | 1000.0000 |  416.6667 | 13474.19 KB |
             DynamicList | .NET Core 2.2 | 40,763.5 us | 241.98 us |   226.35 us |  0.96 |    0.01 | 2384.6154 | 1000.0000 |  384.6154 | 13474.18 KB |
             DynamicList | .NET Core 3.0 | 37,520.8 us | 596.88 us |   529.11 us |  0.89 |    0.02 | 2230.7692 |  923.0769 |  307.6923 |    13076 KB |
                         |               |             |           |             |       |         |           |           |           |             |
       DynamicList_Async | .NET Core 2.0 | 42,325.3 us | 538.90 us |   504.08 us |  1.00 |    0.00 | 2416.6667 | 1000.0000 |  416.6667 | 13473.41 KB |
       DynamicList_Async | .NET Core 2.2 | 39,870.7 us | 218.74 us |   204.61 us |  0.94 |    0.01 | 2384.6154 | 1000.0000 |  384.6154 | 13473.75 KB |
       DynamicList_Async | .NET Core 3.0 | 39,920.1 us | 798.00 us | 1,784.83 us |  0.98 |    0.04 | 2300.0000 | 1000.0000 |  300.0000 | 13076.11 KB |
                         |               |             |           |             |       |         |           |           |           |             |
              QueryFirst | .NET Core 2.0 |    277.3 us |   0.56 us |     0.50 us |  1.00 |    0.00 |    5.8594 |         - |         - |    38.14 KB |
              QueryFirst | .NET Core 2.2 |    260.4 us |   3.75 us |     3.51 us |  0.94 |    0.01 |    5.8594 |         - |         - |    38.14 KB |
              QueryFirst | .NET Core 3.0 |    245.2 us |   1.55 us |     1.45 us |  0.88 |    0.01 |    5.8594 |         - |         - |    37.27 KB |
                         |               |             |           |             |       |         |           |           |           |             |
     QueryFirstOrDefault | .NET Core 2.0 |    282.4 us |   4.08 us |     3.62 us |  1.00 |    0.00 |    5.8594 |         - |         - |    38.14 KB |
     QueryFirstOrDefault | .NET Core 2.2 |    259.5 us |   2.72 us |     2.54 us |  0.92 |    0.02 |    5.8594 |         - |         - |    38.14 KB |
     QueryFirstOrDefault | .NET Core 3.0 |    243.7 us |   1.46 us |     1.37 us |  0.86 |    0.01 |    5.8594 |         - |         - |    37.27 KB |
                         |               |             |           |             |       |         |           |           |           |             |
             QuerySingle | .NET Core 2.0 |    281.4 us |   0.61 us |     0.54 us |  1.00 |    0.00 |    5.8594 |         - |         - |    38.16 KB |
             QuerySingle | .NET Core 2.2 |    260.7 us |   2.83 us |     2.65 us |  0.93 |    0.01 |    5.8594 |         - |         - |    38.16 KB |
             QuerySingle | .NET Core 3.0 |    243.6 us |   0.52 us |     0.46 us |  0.87 |    0.00 |    5.8594 |         - |         - |     37.3 KB |
                         |               |             |           |             |       |         |           |           |           |             |
    QuerySingleOrDefault | .NET Core 2.0 |    283.2 us |   1.57 us |     1.22 us |  1.00 |    0.00 |    5.8594 |         - |         - |    38.16 KB |
    QuerySingleOrDefault | .NET Core 2.2 |    257.9 us |   1.18 us |     1.10 us |  0.91 |    0.01 |    5.8594 |         - |         - |    38.16 KB |
    QuerySingleOrDefault | .NET Core 3.0 |    247.3 us |   1.20 us |     1.12 us |  0.87 |    0.01 |    5.8594 |         - |         - |     37.3 KB |
