
BenchmarkDotNet=v0.12.0, OS=Windows 10.0.17763.914 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.0.100
  [Host]     : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT
  Job-UBQXFW : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), X64 RyuJIT
  Job-BZDDAE : .NET Core 2.2.7 (CoreCLR 4.6.28008.02, CoreFX 4.6.28008.03), X64 RyuJIT
  Job-OHXMKF : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT


                  Method |     Toolchain |        Mean |     Error |    StdDev | Ratio | RatioSD |     Gen 0 |     Gen 1 |    Gen 2 |   Allocated |
------------------------ |-------------- |------------:|----------:|----------:|------:|--------:|----------:|----------:|---------:|------------:|
        AllFieldsAsClass | .NET Core 2.0 | 40,339.0 us | 146.99 us | 122.75 us |  1.00 |    0.00 | 2153.8462 |  923.0769 | 230.7692 | 13505.33 KB |
        AllFieldsAsClass | .NET Core 2.2 | 39,656.6 us | 198.36 us | 165.64 us |  0.98 |    0.00 | 2153.8462 |  923.0769 | 230.7692 | 13505.33 KB |
        AllFieldsAsClass | .NET Core 3.0 | 38,716.5 us | 552.63 us | 516.93 us |  0.96 |    0.01 | 2142.8571 |  928.5714 | 214.2857 | 13107.57 KB |
                         |               |             |           |           |       |         |           |           |          |             |
  AllFieldsAsClass_Async | .NET Core 2.0 | 40,829.7 us | 193.80 us | 181.28 us |  1.00 |    0.00 | 2153.8462 |  923.0769 | 230.7692 | 13505.26 KB |
  AllFieldsAsClass_Async | .NET Core 2.2 | 39,530.4 us | 232.32 us | 194.00 us |  0.97 |    0.01 | 2153.8462 |  923.0769 | 230.7692 | 13505.26 KB |
  AllFieldsAsClass_Async | .NET Core 3.0 | 39,057.7 us | 776.35 us | 953.43 us |  0.96 |    0.03 | 2142.8571 |  928.5714 | 214.2857 | 13107.21 KB |
                         |               |             |           |           |       |         |           |           |          |             |
       AllFieldsAsStruct | .NET Core 2.0 | 49,935.0 us | 367.52 us | 306.90 us |  1.00 |    0.00 | 2909.0909 | 1636.3636 | 909.0909 | 17665.25 KB |
       AllFieldsAsStruct | .NET Core 2.2 | 47,061.9 us | 382.47 us | 357.76 us |  0.94 |    0.01 | 2909.0909 | 1636.3636 | 909.0909 | 17665.83 KB |
       AllFieldsAsStruct | .NET Core 3.0 | 46,024.1 us | 628.82 us | 588.20 us |  0.92 |    0.01 | 2818.1818 | 1818.1818 | 909.0909 | 17267.33 KB |
                         |               |             |           |           |       |         |           |           |          |             |
 AllFieldsAsStruct_Async | .NET Core 2.0 | 49,120.4 us | 165.16 us | 146.41 us |  1.00 |    0.00 | 2909.0909 | 1636.3636 | 909.0909 | 17664.99 KB |
 AllFieldsAsStruct_Async | .NET Core 2.2 | 45,539.5 us | 161.31 us | 150.89 us |  0.93 |    0.00 | 2909.0909 | 1636.3636 | 909.0909 | 17664.34 KB |
 AllFieldsAsStruct_Async | .NET Core 3.0 | 45,001.1 us | 689.60 us | 611.32 us |  0.92 |    0.01 | 2916.6667 | 1916.6667 | 916.6667 |  17267.4 KB |
                         |               |             |           |           |       |         |           |           |          |             |
             DynamicList | .NET Core 2.0 | 42,067.7 us | 395.22 us | 369.69 us |  1.00 |    0.00 | 2416.6667 | 1000.0000 | 416.6667 | 13474.54 KB |
             DynamicList | .NET Core 2.2 | 40,309.0 us | 257.75 us | 241.10 us |  0.96 |    0.01 | 2384.6154 | 1000.0000 | 384.6154 | 13474.61 KB |
             DynamicList | .NET Core 3.0 | 38,528.3 us | 443.58 us | 414.92 us |  0.92 |    0.01 | 2230.7692 |  923.0769 | 307.6923 | 13075.16 KB |
                         |               |             |           |           |       |         |           |           |          |             |
       DynamicList_Async | .NET Core 2.0 | 42,590.5 us | 416.45 us | 389.54 us |  1.00 |    0.00 | 2416.6667 | 1000.0000 | 416.6667 | 13474.11 KB |
       DynamicList_Async | .NET Core 2.2 | 40,182.3 us | 207.15 us | 183.63 us |  0.94 |    0.01 | 2384.6154 | 1000.0000 | 384.6154 | 13474.12 KB |
       DynamicList_Async | .NET Core 3.0 | 38,550.2 us | 652.29 us | 610.15 us |  0.91 |    0.02 | 2230.7692 |  923.0769 | 307.6923 |  13075.6 KB |
                         |               |             |           |           |       |         |           |           |          |             |
              QueryFirst | .NET Core 2.0 |    279.5 us |   1.31 us |   1.16 us |  1.00 |    0.00 |    5.8594 |         - |        - |    38.14 KB |
              QueryFirst | .NET Core 2.2 |    257.6 us |   1.18 us |   0.92 us |  0.92 |    0.00 |    5.8594 |         - |        - |    38.14 KB |
              QueryFirst | .NET Core 3.0 |    242.9 us |   1.13 us |   1.06 us |  0.87 |    0.01 |    5.8594 |         - |        - |    37.27 KB |
                         |               |             |           |           |       |         |           |           |          |             |
     QueryFirstOrDefault | .NET Core 2.0 |    280.9 us |   1.62 us |   1.51 us |  1.00 |    0.00 |    5.8594 |         - |        - |    38.14 KB |
     QueryFirstOrDefault | .NET Core 2.2 |    258.2 us |   0.80 us |   0.71 us |  0.92 |    0.01 |    5.8594 |         - |        - |    38.14 KB |
     QueryFirstOrDefault | .NET Core 3.0 |    248.1 us |   2.89 us |   2.56 us |  0.88 |    0.01 |    5.8594 |         - |        - |    37.27 KB |
                         |               |             |           |           |       |         |           |           |          |             |
             QuerySingle | .NET Core 2.0 |    285.5 us |   4.67 us |   4.37 us |  1.00 |    0.00 |    5.8594 |         - |        - |    38.16 KB |
             QuerySingle | .NET Core 2.2 |    260.7 us |   1.34 us |   1.25 us |  0.91 |    0.01 |    5.8594 |         - |        - |    38.16 KB |
             QuerySingle | .NET Core 3.0 |    248.5 us |   1.26 us |   1.18 us |  0.87 |    0.01 |    5.8594 |         - |        - |     37.3 KB |
                         |               |             |           |           |       |         |           |           |          |             |
    QuerySingleOrDefault | .NET Core 2.0 |    288.1 us |   3.09 us |   2.89 us |  1.00 |    0.00 |    5.8594 |         - |        - |    38.16 KB |
    QuerySingleOrDefault | .NET Core 2.2 |    262.6 us |   4.23 us |   3.95 us |  0.91 |    0.02 |    5.8594 |         - |        - |    38.16 KB |
    QuerySingleOrDefault | .NET Core 3.0 |    247.9 us |   1.62 us |   1.43 us |  0.86 |    0.01 |    5.8594 |         - |        - |     37.3 KB |
