
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

                         Method |     Toolchain |            Mean |          Error |        StdDev |          Median | Ratio | RatioSD |    Gen 0 |    Gen 1 |    Gen 2 | Allocated |
------------------------------- |-------------- |----------------:|---------------:|--------------:|----------------:|------:|--------:|---------:|---------:|---------:|----------:|
                    SimpleClass | .NET Core 3.1 |        82.07 ns |      16.623 ns |      0.911 ns |        82.31 ns |  1.00 |    0.00 |   0.0088 |        - |        - |      56 B |
                    SimpleClass | .NET Core 5.0 |        63.34 ns |      10.501 ns |      0.576 ns |        63.30 ns |  0.77 |    0.02 |   0.0088 |        - |        - |      56 B |
                                |               |                 |                |               |                 |       |         |          |          |          |           |
                   ComplexClass | .NET Core 3.1 |       111.45 ns |      52.266 ns |      2.865 ns |       112.46 ns |  1.00 |    0.00 |   0.0126 |        - |        - |      80 B |
                   ComplexClass | .NET Core 5.0 |        99.87 ns |      28.932 ns |      1.586 ns |        99.24 ns |  0.90 |    0.03 |   0.0126 |        - |        - |      80 B |
                                |               |                 |                |               |                 |       |         |          |          |          |           |
              InheritList_Class | .NET Core 3.1 | 1,163,959.31 ns | 180,926.021 ns |  9,917.166 ns | 1,166,981.64 ns |  1.00 |    0.00 | 111.3281 |  72.2656 |  23.4375 |  691194 B |
              InheritList_Class | .NET Core 5.0 |   934,361.30 ns | 366,197.523 ns | 20,072.522 ns |   926,071.88 ns |  0.80 |    0.02 | 112.3047 |  74.2188 |  27.3438 |  691197 B |
                                |               |                 |                |               |                 |       |         |          |          |          |           |
                InheritList_Int | .NET Core 3.1 |    74,846.48 ns |  26,428.951 ns |  1,448.660 ns |    74,030.53 ns |  1.00 |    0.00 |  10.3760 |   1.7090 |        - |   65640 B |
                InheritList_Int | .NET Core 5.0 |    75,819.33 ns |  63,066.029 ns |  3,456.862 ns |    73,839.53 ns |  1.01 |    0.06 |  10.3760 |   1.7090 |        - |   65640 B |
                                |               |                 |                |               |                 |       |         |          |          |          |           |
                           Null | .NET Core 3.1 |        17.53 ns |       8.731 ns |      0.479 ns |        17.36 ns |  1.00 |    0.00 |        - |        - |        - |         - |
                           Null | .NET Core 5.0 |        17.00 ns |       0.931 ns |      0.051 ns |        16.99 ns |  0.97 |    0.02 |        - |        - |        - |         - |
                                |               |                 |                |               |                 |       |         |          |          |          |           |
           GrandChildClass_Test | .NET Core 3.1 |       114.04 ns |      26.642 ns |      1.460 ns |       114.03 ns |  1.00 |    0.00 |   0.0522 |        - |        - |     328 B |
           GrandChildClass_Test | .NET Core 5.0 |        96.68 ns |      17.099 ns |      0.937 ns |        96.69 ns |  0.85 |    0.02 |   0.0522 |        - |        - |     328 B |
                                |               |                 |                |               |                 |       |         |          |          |          |           |
             List_SimpleClasses | .NET Core 3.1 |   500,748.50 ns |  36,556.995 ns |  2,003.812 ns |   501,337.11 ns |  1.00 |    0.00 | 101.5625 |  41.0156 |        - |  640056 B |
             List_SimpleClasses | .NET Core 5.0 |   470,824.06 ns |  94,372.851 ns |  5,172.894 ns |   473,245.29 ns |  0.94 |    0.01 | 101.5625 |  41.0156 |        - |  640056 B |
                                |               |                 |                |               |                 |       |         |          |          |          |           |
 List_SimpleClasses_AsInterface | .NET Core 3.1 |   785,255.14 ns |  14,752.344 ns |    808.626 ns |   785,309.08 ns |  1.00 |    0.00 | 101.5625 |  41.0156 |        - |  640056 B |
 List_SimpleClasses_AsInterface | .NET Core 5.0 |   736,423.08 ns |  84,544.491 ns |  4,634.169 ns |   735,647.27 ns |  0.94 |    0.01 | 101.5625 |  41.0156 |        - |  640056 B |
                                |               |                 |                |               |                 |       |         |          |          |          |           |
   List_SimpleClasses_AsObjects | .NET Core 3.1 |   717,685.19 ns | 188,225.971 ns | 10,317.301 ns |   714,716.31 ns |  1.00 |    0.00 | 101.5625 |  41.0156 |        - |  640056 B |
   List_SimpleClasses_AsObjects | .NET Core 5.0 |   698,644.01 ns | 336,754.510 ns | 18,458.651 ns |   688,013.18 ns |  0.97 |    0.04 | 101.5625 |  41.0156 |        - |  640056 B |
                                |               |                 |                |               |                 |       |         |          |          |          |           |
            List_ComplexClasses | .NET Core 3.1 | 1,028,975.52 ns | 171,334.488 ns |  9,391.421 ns | 1,028,810.35 ns |  1.00 |    0.00 | 138.6719 |  52.7344 |        - |  880056 B |
            List_ComplexClasses | .NET Core 5.0 |   959,754.04 ns | 251,101.662 ns | 13,763.729 ns |   962,554.69 ns |  0.93 |    0.01 | 139.6484 |  53.7109 |        - |  880056 B |
                                |               |                 |                |               |                 |       |         |          |          |          |           |
                List_Interfaces | .NET Core 3.1 | 2,678,452.73 ns | 450,918.466 ns | 24,716.363 ns | 2,666,305.86 ns |  1.00 |    0.00 | 144.5313 |  82.0313 |  23.4375 |  960072 B |
                List_Interfaces | .NET Core 5.0 | 2,347,410.03 ns | 599,583.789 ns | 32,865.211 ns | 2,335,895.31 ns |  0.88 |    0.01 | 144.5313 |  82.0313 |  23.4375 |  960111 B |
                                |               |                 |                |               |                 |       |         |          |          |          |           |
             List_SimpleStructs | .NET Core 3.1 |   146,752.37 ns |  21,738.151 ns |  1,191.541 ns |   147,061.04 ns |  1.00 |    0.00 |  21.4844 |  21.4844 |  21.4844 |  400143 B |
             List_SimpleStructs | .NET Core 5.0 |   145,933.38 ns |  26,452.267 ns |  1,449.938 ns |   146,572.53 ns |  0.99 |    0.01 |  21.9727 |  21.9727 |  21.9727 |  400145 B |
                                |               |                 |                |               |                 |       |         |          |          |          |           |
            List_ComplexStructs | .NET Core 3.1 |   145,214.56 ns |  16,546.462 ns |    906.967 ns |   145,150.12 ns |  1.00 |    0.00 |  20.9961 |  20.9961 |  20.9961 |  400141 B |
            List_ComplexStructs | .NET Core 5.0 |   148,391.49 ns |  53,919.677 ns |  2,955.519 ns |   148,862.92 ns |  1.02 |    0.02 |  21.9727 |  21.9727 |  21.9727 |  400090 B |
                                |               |                 |                |               |                 |       |         |          |          |          |           |
            DictionaryOfStructs | .NET Core 3.1 |   878,464.19 ns | 440,599.698 ns | 24,150.756 ns |   870,046.58 ns |  1.00 |    0.00 | 227.5391 | 158.2031 | 131.8359 | 1489708 B |
            DictionaryOfStructs | .NET Core 5.0 |   903,089.55 ns | 113,144.165 ns |  6,201.813 ns |   899,626.66 ns |  1.03 |    0.03 | 228.5156 | 159.1797 | 132.8125 | 1489697 B |
                                |               |                 |                |               |                 |       |         |          |          |          |           |
            DictionaryOfClasses | .NET Core 3.1 | 2,715,679.17 ns | 615,410.183 ns | 33,732.709 ns | 2,722,226.56 ns |  1.00 |    0.00 | 214.8438 | 117.1875 |  42.9688 | 1403078 B |
            DictionaryOfClasses | .NET Core 5.0 | 2,195,745.70 ns | 184,646.567 ns | 10,121.101 ns | 2,192,053.52 ns |  0.81 |    0.01 | 214.8438 | 117.1875 |  42.9688 | 1403073 B |
                                |               |                 |                |               |                 |       |         |          |          |          |           |
                DictionaryOfInt | .NET Core 3.1 |   192,271.31 ns |  18,134.522 ns |    994.014 ns |   192,031.47 ns |  1.00 |    0.00 |  36.8652 |  30.7617 |  30.5176 |  202400 B |
                DictionaryOfInt | .NET Core 5.0 |   119,918.25 ns |  15,350.410 ns |    841.408 ns |   120,228.11 ns |  0.62 |    0.01 |  31.7383 |  25.2686 |  25.2686 |  202385 B |