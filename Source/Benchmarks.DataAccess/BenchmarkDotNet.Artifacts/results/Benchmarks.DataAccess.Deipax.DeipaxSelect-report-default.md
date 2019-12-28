
BenchmarkDotNet=v0.12.0, OS=Windows 10.0.17763.914 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.0.100
  [Host]     : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT
  Job-UKPVHT : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), X64 RyuJIT
  Job-FFDKSR : .NET Core 2.2.7 (CoreCLR 4.6.28008.02, CoreFX 4.6.28008.03), X64 RyuJIT
  Job-ZDULOV : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT


                  Method |     Toolchain |        Mean |       Error |      StdDev |      Median | Ratio | RatioSD |     Gen 0 |     Gen 1 |     Gen 2 |   Allocated |
------------------------ |-------------- |------------:|------------:|------------:|------------:|------:|--------:|----------:|----------:|----------:|------------:|
        AllFieldsAsClass | .NET Core 2.0 | 39,315.2 us |   745.19 us |   797.35 us | 38,924.6 us |  1.00 |    0.00 | 2153.8462 | 1000.0000 |  153.8462 | 13256.21 KB |
        AllFieldsAsClass | .NET Core 2.2 | 38,033.2 us |   298.61 us |   264.71 us | 37,981.6 us |  0.97 |    0.02 | 2153.8462 | 1000.0000 |  153.8462 | 13256.21 KB |
        AllFieldsAsClass | .NET Core 3.0 | 35,368.2 us |   127.05 us |   106.09 us | 35,369.8 us |  0.90 |    0.02 | 2066.6667 |  933.3333 |  133.3333 | 12857.95 KB |
                         |               |             |             |             |             |       |         |           |           |           |             |
  AllFieldsAsClass_Async | .NET Core 2.0 | 39,054.2 us |   293.13 us |   274.19 us | 39,072.7 us |  1.00 |    0.00 | 2153.8462 | 1000.0000 |  153.8462 | 13256.63 KB |
  AllFieldsAsClass_Async | .NET Core 2.2 | 37,326.4 us |   158.98 us |   148.71 us | 37,263.1 us |  0.96 |    0.01 | 2142.8571 |  928.5714 |  142.8571 | 13256.63 KB |
  AllFieldsAsClass_Async | .NET Core 3.0 | 34,737.4 us |   271.04 us |   240.27 us | 34,702.5 us |  0.89 |    0.01 | 2066.6667 |  933.3333 |  133.3333 | 12858.38 KB |
                         |               |             |             |             |             |       |         |           |           |           |             |
       AllFieldsAsStruct | .NET Core 2.0 | 49,992.9 us |   386.18 us |   361.23 us | 49,959.0 us |  1.00 |    0.00 | 2800.0000 | 1900.0000 |  900.0000 | 16274.61 KB |
       AllFieldsAsStruct | .NET Core 2.2 | 45,816.5 us |   632.11 us |   560.35 us | 45,673.5 us |  0.92 |    0.01 | 2727.2727 | 1818.1818 |  909.0909 | 16272.25 KB |
       AllFieldsAsStruct | .NET Core 3.0 | 40,550.9 us |   749.07 us |   700.68 us | 40,251.8 us |  0.81 |    0.02 | 2846.1538 | 1923.0769 | 1000.0000 | 15874.22 KB |
                         |               |             |             |             |             |       |         |           |           |           |             |
 AllFieldsAsStruct_Async | .NET Core 2.0 | 51,178.1 us | 1,022.68 us | 1,466.70 us | 51,044.8 us |  1.00 |    0.00 | 2800.0000 | 1900.0000 |  900.0000 | 16273.44 KB |
 AllFieldsAsStruct_Async | .NET Core 2.2 | 45,556.9 us |   341.72 us |   319.65 us | 45,473.3 us |  0.89 |    0.03 | 2818.1818 | 1909.0909 |  909.0909 | 16271.98 KB |
 AllFieldsAsStruct_Async | .NET Core 3.0 | 39,012.3 us |   409.79 us |   363.27 us | 39,010.4 us |  0.76 |    0.03 | 2846.1538 | 1923.0769 | 1000.0000 | 15874.93 KB |
                         |               |             |             |             |             |       |         |           |           |           |             |
             DynamicList | .NET Core 2.0 | 38,731.7 us |   319.99 us |   283.66 us | 38,790.8 us |  1.00 |    0.00 | 2307.6923 | 1000.0000 |  307.6923 | 13442.67 KB |
             DynamicList | .NET Core 2.2 | 37,613.5 us |   468.75 us |   415.53 us | 37,516.0 us |  0.97 |    0.02 | 2307.6923 | 1000.0000 |  307.6923 | 13442.78 KB |
             DynamicList | .NET Core 3.0 | 32,978.0 us | 1,046.51 us |   978.90 us | 32,459.1 us |  0.85 |    0.03 | 2125.0000 | 1000.0000 |  125.0000 | 13043.81 KB |
                         |               |             |             |             |             |       |         |           |           |           |             |
       DynamicList_Async | .NET Core 2.0 | 39,219.5 us |   710.50 us |   629.84 us | 38,964.6 us |  1.00 |    0.00 | 2307.6923 | 1000.0000 |  307.6923 | 13443.51 KB |
       DynamicList_Async | .NET Core 2.2 | 37,618.4 us |   218.24 us |   204.14 us | 37,577.5 us |  0.96 |    0.01 | 2285.7143 | 1000.0000 |  285.7143 | 13443.22 KB |
       DynamicList_Async | .NET Core 3.0 | 34,365.3 us |   681.80 us | 1,246.70 us | 34,550.3 us |  0.88 |    0.05 | 2125.0000 | 1000.0000 |  312.5000 | 13044.24 KB |
                         |               |             |             |             |             |       |         |           |           |           |             |
              QueryFirst | .NET Core 2.0 |    282.8 us |     2.40 us |     2.13 us |    281.9 us |  1.00 |    0.00 |    6.3477 |         - |         - |    39.39 KB |
              QueryFirst | .NET Core 2.2 |    258.5 us |     1.75 us |     1.55 us |    258.2 us |  0.91 |    0.01 |    6.3477 |         - |         - |    39.39 KB |
              QueryFirst | .NET Core 3.0 |    244.3 us |     1.89 us |     1.58 us |    243.6 us |  0.86 |    0.01 |    5.8594 |         - |         - |    38.51 KB |
                         |               |             |             |             |             |       |         |           |           |           |             |
     QueryFirstOrDefault | .NET Core 2.0 |    286.8 us |     5.65 us |     6.94 us |    282.5 us |  1.00 |    0.00 |    6.3477 |         - |         - |    39.39 KB |
     QueryFirstOrDefault | .NET Core 2.2 |    264.5 us |     4.16 us |     3.69 us |    265.5 us |  0.92 |    0.03 |    6.3477 |         - |         - |    39.39 KB |
     QueryFirstOrDefault | .NET Core 3.0 |    247.6 us |     4.02 us |     3.56 us |    246.3 us |  0.86 |    0.02 |    5.8594 |         - |         - |     38.5 KB |
                         |               |             |             |             |             |       |         |           |           |           |             |
             QuerySingle | .NET Core 2.0 |    283.0 us |     0.60 us |     0.56 us |    283.0 us |  1.00 |    0.00 |    6.3477 |         - |         - |    39.41 KB |
             QuerySingle | .NET Core 2.2 |    259.2 us |     0.66 us |     0.58 us |    259.3 us |  0.92 |    0.00 |    6.3477 |         - |         - |    39.41 KB |
             QuerySingle | .NET Core 3.0 |    246.8 us |     0.61 us |     0.54 us |    246.6 us |  0.87 |    0.00 |    5.8594 |         - |         - |    38.53 KB |
                         |               |             |             |             |             |       |         |           |           |           |             |
    QuerySingleOrDefault | .NET Core 2.0 |    285.8 us |     1.17 us |     1.04 us |    286.1 us |  1.00 |    0.00 |    6.3477 |         - |         - |    39.41 KB |
    QuerySingleOrDefault | .NET Core 2.2 |    262.2 us |     2.92 us |     2.59 us |    261.4 us |  0.92 |    0.01 |    6.3477 |         - |         - |    39.41 KB |
    QuerySingleOrDefault | .NET Core 3.0 |    251.3 us |     4.92 us |     4.60 us |    248.5 us |  0.88 |    0.02 |    5.8594 |         - |         - |    38.53 KB |
