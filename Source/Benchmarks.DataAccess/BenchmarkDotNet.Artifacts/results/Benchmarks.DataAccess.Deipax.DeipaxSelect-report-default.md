
BenchmarkDotNet=v0.12.0, OS=Windows 10.0.17763.914 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.0.100
  [Host]     : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT
  Job-SYJLYP : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), X64 RyuJIT
  Job-WNDIQQ : .NET Core 2.2.7 (CoreCLR 4.6.28008.02, CoreFX 4.6.28008.03), X64 RyuJIT
  Job-JGXFBV : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT


                  Method |     Toolchain |        Mean |     Error |      StdDev |      Median | Ratio | RatioSD |     Gen 0 |     Gen 1 |     Gen 2 |   Allocated |
------------------------ |-------------- |------------:|----------:|------------:|------------:|------:|--------:|----------:|----------:|----------:|------------:|
        AllFieldsAsClass | .NET Core 2.0 | 39,318.3 us | 470.57 us |   417.15 us | 39,256.7 us |  1.00 |    0.00 | 2153.8462 | 1000.0000 |  153.8462 | 13256.21 KB |
        AllFieldsAsClass | .NET Core 2.2 | 37,896.7 us | 117.68 us |    98.27 us | 37,896.9 us |  0.96 |    0.01 | 2153.8462 | 1000.0000 |  153.8462 | 13256.21 KB |
        AllFieldsAsClass | .NET Core 3.0 | 34,599.8 us | 178.50 us |   158.23 us | 34,649.4 us |  0.88 |    0.01 | 2066.6667 |  933.3333 |  133.3333 | 12857.95 KB |
                         |               |             |           |             |             |       |         |           |           |           |             |
  AllFieldsAsClass_Async | .NET Core 2.0 | 38,771.4 us | 195.61 us |   182.98 us | 38,684.8 us |  1.00 |    0.00 | 2153.8462 | 1000.0000 |  153.8462 | 13256.56 KB |
  AllFieldsAsClass_Async | .NET Core 2.2 | 38,547.7 us | 394.61 us |   369.12 us | 38,593.7 us |  0.99 |    0.01 | 2142.8571 |  928.5714 |  142.8571 | 13256.56 KB |
  AllFieldsAsClass_Async | .NET Core 3.0 | 35,707.4 us | 313.73 us |   293.47 us | 35,792.9 us |  0.92 |    0.01 | 2071.4286 |  928.5714 |  142.8571 | 12858.31 KB |
                         |               |             |           |             |             |       |         |           |           |           |             |
       AllFieldsAsStruct | .NET Core 2.0 | 49,995.3 us | 562.74 us |   526.39 us | 49,859.6 us |  1.00 |    0.00 | 2800.0000 | 1900.0000 |  900.0000 |  16272.1 KB |
       AllFieldsAsStruct | .NET Core 2.2 | 44,654.3 us | 586.24 us |   548.37 us | 44,752.5 us |  0.89 |    0.01 | 2750.0000 | 1833.3333 |  916.6667 | 16272.05 KB |
       AllFieldsAsStruct | .NET Core 3.0 | 40,938.6 us | 816.71 us | 1,090.29 us | 41,567.1 us |  0.81 |    0.03 | 2846.1538 | 1923.0769 | 1000.0000 | 15875.12 KB |
                         |               |             |           |             |             |       |         |           |           |           |             |
 AllFieldsAsStruct_Async | .NET Core 2.0 | 48,860.0 us | 360.18 us |   319.29 us | 48,903.3 us |  1.00 |    0.00 | 2818.1818 | 1909.0909 |  909.0909 |  16272.5 KB |
 AllFieldsAsStruct_Async | .NET Core 2.2 | 45,295.7 us | 442.88 us |   414.27 us | 45,368.9 us |  0.93 |    0.01 | 2750.0000 | 1833.3333 |  916.6667 | 16272.61 KB |
 AllFieldsAsStruct_Async | .NET Core 3.0 | 38,724.3 us | 152.28 us |   127.16 us | 38,704.9 us |  0.79 |    0.01 | 2846.1538 | 1923.0769 | 1000.0000 | 15874.98 KB |
                         |               |             |           |             |             |       |         |           |           |           |             |
             DynamicList | .NET Core 2.0 | 39,244.6 us | 491.24 us |   459.50 us | 39,175.7 us |  1.00 |    0.00 | 2285.7143 | 1000.0000 |  285.7143 | 13442.35 KB |
             DynamicList | .NET Core 2.2 | 37,263.8 us | 232.79 us |   206.36 us | 37,269.2 us |  0.95 |    0.01 | 2285.7143 | 1000.0000 |  285.7143 | 13442.52 KB |
             DynamicList | .NET Core 3.0 | 34,525.2 us | 689.56 us | 1,361.13 us | 35,226.9 us |  0.86 |    0.04 | 2125.0000 | 1000.0000 |  312.5000 | 13043.81 KB |
                         |               |             |           |             |             |       |         |           |           |           |             |
       DynamicList_Async | .NET Core 2.0 | 38,951.7 us | 453.82 us |   424.50 us | 38,928.6 us |  1.00 |    0.00 | 2307.6923 | 1000.0000 |  307.6923 | 13442.69 KB |
       DynamicList_Async | .NET Core 2.2 | 37,741.4 us | 385.51 us |   360.60 us | 37,743.0 us |  0.97 |    0.02 | 2285.7143 | 1000.0000 |  285.7143 | 13442.78 KB |
       DynamicList_Async | .NET Core 3.0 | 33,724.4 us | 658.29 us | 1,203.72 us | 34,223.3 us |  0.86 |    0.04 | 2066.6667 |  933.3333 |  266.6667 | 13044.13 KB |
                         |               |             |           |             |             |       |         |           |           |           |             |
              QueryFirst | .NET Core 2.0 |    280.5 us |   0.46 us |     0.41 us |    280.4 us |  1.00 |    0.00 |    6.3477 |         - |         - |    39.39 KB |
              QueryFirst | .NET Core 2.2 |    260.8 us |   0.84 us |     0.75 us |    260.7 us |  0.93 |    0.00 |    6.3477 |         - |         - |    39.39 KB |
              QueryFirst | .NET Core 3.0 |    249.7 us |   1.73 us |     1.54 us |    250.2 us |  0.89 |    0.00 |    5.8594 |         - |         - |     38.5 KB |
                         |               |             |           |             |             |       |         |           |           |           |             |
     QueryFirstOrDefault | .NET Core 2.0 |    284.7 us |   3.16 us |     2.96 us |    285.9 us |  1.00 |    0.00 |    6.3477 |         - |         - |    39.39 KB |
     QueryFirstOrDefault | .NET Core 2.2 |    255.9 us |   0.63 us |     0.56 us |    256.1 us |  0.90 |    0.01 |    6.3477 |         - |         - |    39.39 KB |
     QueryFirstOrDefault | .NET Core 3.0 |    242.8 us |   0.55 us |     0.49 us |    242.7 us |  0.85 |    0.01 |    5.8594 |         - |         - |     38.5 KB |
                         |               |             |           |             |             |       |         |           |           |           |             |
             QuerySingle | .NET Core 2.0 |    291.9 us |   4.01 us |     3.75 us |    293.6 us |  1.00 |    0.00 |    6.3477 |         - |         - |    39.41 KB |
             QuerySingle | .NET Core 2.2 |    262.6 us |   3.97 us |     3.72 us |    261.2 us |  0.90 |    0.02 |    6.3477 |         - |         - |    39.41 KB |
             QuerySingle | .NET Core 3.0 |    249.8 us |   1.89 us |     1.58 us |    249.8 us |  0.86 |    0.01 |    5.8594 |         - |         - |    38.53 KB |
                         |               |             |           |             |             |       |         |           |           |           |             |
    QuerySingleOrDefault | .NET Core 2.0 |    283.6 us |   0.72 us |     0.68 us |    283.6 us |  1.00 |    0.00 |    6.3477 |         - |         - |    39.41 KB |
    QuerySingleOrDefault | .NET Core 2.2 |    262.4 us |   2.67 us |     2.50 us |    263.4 us |  0.93 |    0.01 |    6.3477 |         - |         - |    39.41 KB |
    QuerySingleOrDefault | .NET Core 3.0 |    249.1 us |   2.77 us |     2.59 us |    249.7 us |  0.88 |    0.01 |    5.8594 |         - |         - |    38.53 KB |
