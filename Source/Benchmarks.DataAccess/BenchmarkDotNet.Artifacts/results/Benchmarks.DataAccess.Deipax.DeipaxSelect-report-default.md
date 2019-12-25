
BenchmarkDotNet=v0.12.0, OS=Windows 10.0.17763.914 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.0.100
  [Host]     : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT
  Job-XYVOCI : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), X64 RyuJIT
  Job-DLSBQL : .NET Core 2.2.7 (CoreCLR 4.6.28008.02, CoreFX 4.6.28008.03), X64 RyuJIT
  Job-ZPORLS : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT


                  Method |     Toolchain |        Mean |     Error |      StdDev |      Median | Ratio | RatioSD |     Gen 0 |     Gen 1 |     Gen 2 |   Allocated |
------------------------ |-------------- |------------:|----------:|------------:|------------:|------:|--------:|----------:|----------:|----------:|------------:|
        AllFieldsAsClass | .NET Core 2.0 | 39,458.6 us | 388.25 us |   363.17 us | 39,524.9 us |  1.00 |    0.00 | 2153.8462 | 1000.0000 |  153.8462 | 13256.21 KB |
        AllFieldsAsClass | .NET Core 2.2 | 38,015.1 us | 347.26 us |   324.83 us | 38,110.6 us |  0.96 |    0.01 | 2142.8571 |  928.5714 |  142.8571 |  13256.2 KB |
        AllFieldsAsClass | .NET Core 3.0 | 35,573.4 us | 566.62 us |   530.02 us | 35,534.1 us |  0.90 |    0.01 | 2071.4286 |  928.5714 |  142.8571 | 12857.96 KB |
                         |               |             |           |             |             |       |         |           |           |           |             |
  AllFieldsAsClass_Async | .NET Core 2.0 | 39,025.1 us | 368.75 us |   344.93 us | 38,851.5 us |  1.00 |    0.00 | 2153.8462 | 1000.0000 |  153.8462 | 13256.56 KB |
  AllFieldsAsClass_Async | .NET Core 2.2 | 37,297.3 us | 108.68 us |    90.76 us | 37,278.8 us |  0.96 |    0.01 | 2142.8571 |  928.5714 |  142.8571 | 13256.56 KB |
  AllFieldsAsClass_Async | .NET Core 3.0 | 34,869.5 us | 277.04 us |   259.15 us | 34,868.0 us |  0.89 |    0.01 | 2066.6667 |  933.3333 |  133.3333 | 12858.31 KB |
                         |               |             |           |             |             |       |         |           |           |           |             |
       AllFieldsAsStruct | .NET Core 2.0 | 49,931.2 us | 347.10 us |   324.68 us | 49,976.5 us |  1.00 |    0.00 | 2800.0000 | 1900.0000 |  900.0000 | 16272.78 KB |
       AllFieldsAsStruct | .NET Core 2.2 | 44,632.1 us | 343.04 us |   304.10 us | 44,715.4 us |  0.89 |    0.01 | 2750.0000 | 1833.3333 |  916.6667 |  16272.2 KB |
       AllFieldsAsStruct | .NET Core 3.0 | 40,337.0 us | 228.69 us |   202.73 us | 40,295.8 us |  0.81 |    0.01 | 2846.1538 | 1923.0769 | 1000.0000 | 15874.48 KB |
                         |               |             |           |             |             |       |         |           |           |           |             |
 AllFieldsAsStruct_Async | .NET Core 2.0 | 48,652.8 us | 539.13 us |   504.30 us | 48,527.1 us |  1.00 |    0.00 | 2818.1818 | 1909.0909 |  909.0909 | 16273.62 KB |
 AllFieldsAsStruct_Async | .NET Core 2.2 | 47,939.7 us | 940.93 us | 1,720.54 us | 47,582.0 us |  1.00 |    0.03 | 2818.1818 | 1909.0909 |  909.0909 | 16272.74 KB |
 AllFieldsAsStruct_Async | .NET Core 3.0 | 38,586.3 us | 297.28 us |   278.08 us | 38,521.3 us |  0.79 |    0.01 | 2714.2857 | 1857.1429 |  928.5714 | 15874.22 KB |
                         |               |             |           |             |             |       |         |           |           |           |             |
             DynamicList | .NET Core 2.0 | 38,137.0 us | 165.68 us |   138.35 us | 38,126.1 us |  1.00 |    0.00 | 2307.6923 | 1000.0000 |  307.6923 | 13442.86 KB |
             DynamicList | .NET Core 2.2 | 37,629.0 us | 440.91 us |   412.42 us | 37,556.6 us |  0.99 |    0.01 | 2285.7143 | 1000.0000 |  285.7143 | 13442.42 KB |
             DynamicList | .NET Core 3.0 | 34,258.1 us | 675.92 us | 1,318.33 us | 34,730.2 us |  0.88 |    0.04 | 2125.0000 | 1000.0000 |  312.5000 | 13043.81 KB |
                         |               |             |           |             |             |       |         |           |           |           |             |
       DynamicList_Async | .NET Core 2.0 | 38,679.4 us | 323.57 us |   302.66 us | 38,658.8 us |  1.00 |    0.00 | 2307.6923 | 1000.0000 |  307.6923 |  13442.8 KB |
       DynamicList_Async | .NET Core 2.2 | 37,266.1 us | 243.11 us |   227.41 us | 37,285.1 us |  0.96 |    0.01 | 2285.7143 | 1000.0000 |  285.7143 | 13442.75 KB |
       DynamicList_Async | .NET Core 3.0 | 33,729.8 us | 664.30 us | 1,415.67 us | 34,328.7 us |  0.85 |    0.04 | 2066.6667 |  933.3333 |  266.6667 | 13044.13 KB |
                         |               |             |           |             |             |       |         |           |           |           |             |
              QueryFirst | .NET Core 2.0 |    278.6 us |   1.04 us |     0.87 us |    278.4 us |  1.00 |    0.00 |    6.3477 |         - |         - |    39.39 KB |
              QueryFirst | .NET Core 2.2 |    262.0 us |   3.81 us |     3.57 us |    259.5 us |  0.94 |    0.01 |    6.3477 |         - |         - |    39.39 KB |
              QueryFirst | .NET Core 3.0 |    247.7 us |   3.11 us |     2.75 us |    248.8 us |  0.89 |    0.01 |    5.8594 |         - |         - |     38.5 KB |
                         |               |             |           |             |             |       |         |           |           |           |             |
     QueryFirstOrDefault | .NET Core 2.0 |    282.5 us |   1.07 us |     1.00 us |    282.8 us |  1.00 |    0.00 |    6.3477 |         - |         - |    39.39 KB |
     QueryFirstOrDefault | .NET Core 2.2 |    258.2 us |   3.38 us |     3.16 us |    259.2 us |  0.91 |    0.01 |    6.3477 |         - |         - |    39.39 KB |
     QueryFirstOrDefault | .NET Core 3.0 |    242.1 us |   2.09 us |     1.85 us |    241.4 us |  0.86 |    0.01 |    6.1035 |    0.2441 |         - |    38.51 KB |
                         |               |             |           |             |             |       |         |           |           |           |             |
             QuerySingle | .NET Core 2.0 |    288.2 us |   4.17 us |     3.90 us |    288.3 us |  1.00 |    0.00 |    6.3477 |         - |         - |    39.41 KB |
             QuerySingle | .NET Core 2.2 |    258.2 us |   0.67 us |     0.52 us |    258.1 us |  0.90 |    0.01 |    6.3477 |         - |         - |    39.41 KB |
             QuerySingle | .NET Core 3.0 |    251.4 us |   3.14 us |     2.62 us |    250.5 us |  0.87 |    0.01 |    5.8594 |         - |         - |    38.53 KB |
                         |               |             |           |             |             |       |         |           |           |           |             |
    QuerySingleOrDefault | .NET Core 2.0 |    284.7 us |   0.45 us |     0.35 us |    284.8 us |  1.00 |    0.00 |    6.3477 |         - |         - |    39.41 KB |
    QuerySingleOrDefault | .NET Core 2.2 |    264.5 us |   2.70 us |     2.52 us |    263.7 us |  0.93 |    0.01 |    6.3477 |         - |         - |    39.41 KB |
    QuerySingleOrDefault | .NET Core 3.0 |    251.4 us |   3.06 us |     2.87 us |    252.2 us |  0.88 |    0.01 |    5.8594 |         - |         - |    38.53 KB |
