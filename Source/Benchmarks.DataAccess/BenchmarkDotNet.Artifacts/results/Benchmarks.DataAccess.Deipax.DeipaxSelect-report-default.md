
BenchmarkDotNet=v0.12.0, OS=Windows 10.0.17763.914 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.0.100
  [Host]     : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT
  Job-VMENWI : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), X64 RyuJIT
  Job-ZQVVLK : .NET Core 2.2.7 (CoreCLR 4.6.28008.02, CoreFX 4.6.28008.03), X64 RyuJIT
  Job-ZKHXTO : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT


                  Method |     Toolchain |        Mean |     Error |      StdDev |      Median | Ratio | RatioSD |     Gen 0 |     Gen 1 |     Gen 2 |   Allocated |
------------------------ |-------------- |------------:|----------:|------------:|------------:|------:|--------:|----------:|----------:|----------:|------------:|
        AllFieldsAsClass | .NET Core 2.0 | 38,722.6 us | 210.45 us |   196.86 us | 38,701.4 us |  1.00 |    0.00 | 2153.8462 | 1000.0000 |  153.8462 | 13256.21 KB |
        AllFieldsAsClass | .NET Core 2.2 | 38,338.7 us | 439.19 us |   366.75 us | 38,289.0 us |  0.99 |    0.01 | 2142.8571 |  928.5714 |  142.8571 |  13256.2 KB |
        AllFieldsAsClass | .NET Core 3.0 | 35,786.0 us | 562.75 us |   498.87 us | 35,755.7 us |  0.92 |    0.02 | 2066.6667 |  933.3333 |  200.0000 | 12857.95 KB |
                         |               |             |           |             |             |       |         |           |           |           |             |
  AllFieldsAsClass_Async | .NET Core 2.0 | 38,785.0 us | 208.49 us |   195.03 us | 38,770.0 us |  1.00 |    0.00 | 2153.8462 | 1000.0000 |  153.8462 | 13256.63 KB |
  AllFieldsAsClass_Async | .NET Core 2.2 | 38,316.8 us | 754.75 us |   741.26 us | 38,117.5 us |  0.99 |    0.02 | 2153.8462 | 1000.0000 |  153.8462 | 13256.63 KB |
  AllFieldsAsClass_Async | .NET Core 3.0 | 35,428.4 us | 609.27 us |   540.11 us | 35,338.3 us |  0.91 |    0.02 | 2083.3333 |  916.6667 |   83.3333 | 12858.39 KB |
                         |               |             |           |             |             |       |         |           |           |           |             |
       AllFieldsAsStruct | .NET Core 2.0 | 50,293.3 us | 475.78 us |   445.05 us | 50,267.1 us |  1.00 |    0.00 | 2818.1818 | 1909.0909 |  909.0909 | 16273.06 KB |
       AllFieldsAsStruct | .NET Core 2.2 | 44,795.5 us | 536.47 us |   447.98 us | 44,893.2 us |  0.89 |    0.01 | 2750.0000 | 1833.3333 |  916.6667 | 16271.92 KB |
       AllFieldsAsStruct | .NET Core 3.0 | 39,696.4 us | 788.24 us |   658.22 us | 39,608.8 us |  0.79 |    0.01 | 2846.1538 | 1923.0769 | 1000.0000 | 15874.47 KB |
                         |               |             |           |             |             |       |         |           |           |           |             |
 AllFieldsAsStruct_Async | .NET Core 2.0 | 49,375.8 us | 384.73 us |   359.88 us | 49,407.8 us |  1.00 |    0.00 | 2818.1818 | 1909.0909 |  909.0909 | 16272.45 KB |
 AllFieldsAsStruct_Async | .NET Core 2.2 | 47,089.0 us | 997.88 us | 1,462.68 us | 46,914.5 us |  0.97 |    0.04 | 2818.1818 | 1909.0909 |  909.0909 | 16272.88 KB |
 AllFieldsAsStruct_Async | .NET Core 3.0 | 39,565.0 us | 279.78 us |   261.70 us | 39,519.2 us |  0.80 |    0.01 | 2846.1538 | 1923.0769 | 1000.0000 | 15874.61 KB |
                         |               |             |           |             |             |       |         |           |           |           |             |
             DynamicList | .NET Core 2.0 | 38,803.7 us | 497.90 us |   465.73 us | 38,811.9 us |  1.00 |    0.00 | 2307.6923 | 1000.0000 |  307.6923 | 13442.72 KB |
             DynamicList | .NET Core 2.2 | 37,925.1 us | 403.26 us |   377.21 us | 37,732.9 us |  0.98 |    0.02 | 2285.7143 | 1000.0000 |  285.7143 | 13442.68 KB |
             DynamicList | .NET Core 3.0 | 33,783.8 us | 672.35 us | 1,212.39 us | 34,523.5 us |  0.86 |    0.04 | 2066.6667 |  933.3333 |  266.6667 | 13043.78 KB |
                         |               |             |           |             |             |       |         |           |           |           |             |
       DynamicList_Async | .NET Core 2.0 | 40,156.8 us | 873.64 us | 1,483.51 us | 39,607.8 us |  1.00 |    0.00 | 2307.6923 | 1000.0000 |  307.6923 | 13442.65 KB |
       DynamicList_Async | .NET Core 2.2 | 37,884.4 us | 441.80 us |   413.26 us | 37,850.2 us |  0.92 |    0.05 | 2307.6923 | 1000.0000 |  307.6923 | 13442.73 KB |
       DynamicList_Async | .NET Core 3.0 | 34,230.8 us | 682.30 us | 1,230.33 us | 34,848.0 us |  0.85 |    0.05 | 2125.0000 | 1000.0000 |  312.5000 | 13044.24 KB |
                         |               |             |           |             |             |       |         |           |           |           |             |
              QueryFirst | .NET Core 2.0 |    282.1 us |   2.98 us |     2.49 us |    281.0 us |  1.00 |    0.00 |    6.3477 |         - |         - |    39.39 KB |
              QueryFirst | .NET Core 2.2 |    260.3 us |   1.62 us |     1.52 us |    259.7 us |  0.92 |    0.01 |    6.3477 |         - |         - |    39.39 KB |
              QueryFirst | .NET Core 3.0 |    250.3 us |   3.99 us |     3.54 us |    248.9 us |  0.89 |    0.02 |    5.8594 |         - |         - |     38.5 KB |
                         |               |             |           |             |             |       |         |           |           |           |             |
     QueryFirstOrDefault | .NET Core 2.0 |    284.1 us |   2.20 us |     1.84 us |    283.6 us |  1.00 |    0.00 |    6.3477 |         - |         - |    39.39 KB |
     QueryFirstOrDefault | .NET Core 2.2 |    259.0 us |   1.14 us |     1.06 us |    258.6 us |  0.91 |    0.01 |    6.3477 |         - |         - |    39.39 KB |
     QueryFirstOrDefault | .NET Core 3.0 |    251.0 us |   2.81 us |     2.63 us |    251.6 us |  0.88 |    0.01 |    5.8594 |         - |         - |     38.5 KB |
                         |               |             |           |             |             |       |         |           |           |           |             |
             QuerySingle | .NET Core 2.0 |    285.5 us |   0.58 us |     0.54 us |    285.5 us |  1.00 |    0.00 |    6.3477 |         - |         - |    39.41 KB |
             QuerySingle | .NET Core 2.2 |    270.8 us |   4.19 us |     3.71 us |    271.7 us |  0.95 |    0.01 |    6.3477 |         - |         - |    39.41 KB |
             QuerySingle | .NET Core 3.0 |    253.4 us |   3.24 us |     3.03 us |    252.6 us |  0.89 |    0.01 |    5.8594 |         - |         - |    38.53 KB |
                         |               |             |           |             |             |       |         |           |           |           |             |
    QuerySingleOrDefault | .NET Core 2.0 |    292.3 us |   3.95 us |     3.50 us |    291.2 us |  1.00 |    0.00 |    6.3477 |         - |         - |    39.41 KB |
    QuerySingleOrDefault | .NET Core 2.2 |    265.0 us |   1.59 us |     1.48 us |    264.9 us |  0.91 |    0.01 |    6.3477 |         - |         - |    39.41 KB |
    QuerySingleOrDefault | .NET Core 3.0 |    256.7 us |   5.07 us |     5.83 us |    254.8 us |  0.88 |    0.02 |    5.8594 |         - |         - |    38.53 KB |
