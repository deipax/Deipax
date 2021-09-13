
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

                     Method |     Toolchain |            Mean |            Error |        StdDev |          Median | Ratio | RatioSD |    Gen 0 |    Gen 1 |   Gen 2 | Allocated |
--------------------------- |-------------- |----------------:|-----------------:|--------------:|----------------:|------:|--------:|---------:|---------:|--------:|----------:|
             SingleInstance | .NET Core 3.1 |       111.80 ns |        17.915 ns |      0.982 ns |       111.50 ns |  1.00 |    0.00 |   0.0050 |        - |       - |      32 B |
             SingleInstance | .NET Core 5.0 |        97.95 ns |        17.801 ns |      0.976 ns |        98.24 ns |  0.88 |    0.01 |   0.0050 |        - |       - |      32 B |
                            |               |                 |                  |               |                 |       |         |          |          |         |           |
             ObjectInstance | .NET Core 3.1 |       140.28 ns |        11.756 ns |      0.644 ns |       140.44 ns |  1.00 |    0.00 |   0.0100 |        - |       - |      64 B |
             ObjectInstance | .NET Core 5.0 |       120.96 ns |        61.244 ns |      3.357 ns |       119.59 ns |  0.86 |    0.03 |   0.0100 |        - |       - |      64 B |
                            |               |                 |                  |               |                 |       |         |          |          |         |           |
            DefaultInstance | .NET Core 3.1 |        29.48 ns |         1.386 ns |      0.076 ns |        29.44 ns |  1.00 |    0.00 |        - |        - |       - |         - |
            DefaultInstance | .NET Core 5.0 |        24.24 ns |         3.713 ns |      0.204 ns |        24.26 ns |  0.82 |    0.01 |        - |        - |       - |         - |
                            |               |                 |                  |               |                 |       |         |          |          |         |           |
     ArrayOfDefaultInstance | .NET Core 3.1 |   109,077.86 ns |     5,630.387 ns |    308.620 ns |   109,018.51 ns |  1.00 |    0.00 |  26.8555 |  26.8555 | 26.8555 |  160016 B |
     ArrayOfDefaultInstance | .NET Core 5.0 |   109,376.81 ns |    15,614.138 ns |    855.864 ns |   108,962.15 ns |  1.00 |    0.01 |  27.0996 |  27.0996 | 27.0996 |  160016 B |
                            |               |                 |                  |               |                 |       |         |          |          |         |           |
        ArrayOfDiffInstance | .NET Core 3.1 | 1,111,172.20 ns |   111,770.075 ns |  6,126.495 ns | 1,113,155.27 ns |  1.00 |    0.00 |  85.9375 |  64.4531 | 41.0156 |  480056 B |
        ArrayOfDiffInstance | .NET Core 5.0 |   978,778.45 ns |   128,951.695 ns |  7,068.278 ns |   978,349.22 ns |  0.88 |    0.01 |  85.9375 |  64.4531 | 41.0156 |  480063 B |
                            |               |                 |                  |               |                 |       |         |          |          |         |           |
        ArrayOfSameInstance | .NET Core 3.1 |   341,312.35 ns |    24,485.970 ns |  1,342.159 ns |   341,396.88 ns |  1.00 |    0.00 |  38.5742 |  38.5742 | 38.5742 |  160270 B |
        ArrayOfSameInstance | .NET Core 5.0 |   289,222.72 ns |    26,367.212 ns |  1,445.276 ns |   289,273.58 ns |  0.85 |    0.01 |  37.5977 |  37.5977 | 37.5977 |  160350 B |
                            |               |                 |                  |               |                 |       |         |          |          |         |           |
 ArrayOfObjectsDiffInstance | .NET Core 3.1 | 1,159,987.37 ns |   130,064.677 ns |  7,129.284 ns | 1,162,856.64 ns |  1.00 |    0.00 | 113.2813 |  48.8281 |       - |  720024 B |
 ArrayOfObjectsDiffInstance | .NET Core 5.0 | 1,067,695.96 ns |   188,632.003 ns | 10,339.557 ns | 1,064,752.54 ns |  0.92 |    0.01 | 113.2813 |  48.8281 |       - |  720024 B |
                            |               |                 |                  |               |                 |       |         |          |          |         |           |
 ArrayOfObjectsSameInstance | .NET Core 3.1 |   603,438.02 ns |   214,661.454 ns | 11,766.319 ns |   601,682.42 ns |  1.00 |    0.00 |  63.4766 |  22.4609 |       - |  400056 B |
 ArrayOfObjectsSameInstance | .NET Core 5.0 |   598,685.64 ns |    72,065.684 ns |  3,950.163 ns |   600,837.79 ns |  0.99 |    0.02 |  63.4766 |  22.4609 |       - |  400056 B |
                            |               |                 |                  |               |                 |       |         |          |          |         |           |
      Array2dOfDiffInstance | .NET Core 3.1 |   914,342.74 ns |   554,407.880 ns | 30,388.967 ns |   907,790.23 ns |  1.00 |    0.00 |  76.1719 |  33.2031 |       - |  483224 B |
      Array2dOfDiffInstance | .NET Core 5.0 |   772,489.97 ns |   555,211.355 ns | 30,433.008 ns |   759,593.95 ns |  0.84 |    0.02 |  76.1719 |  33.2031 |       - |  483224 B |
                            |               |                 |                  |               |                 |       |         |          |          |         |           |
      Array2dOfSameInstance | .NET Core 3.1 |    11,608.81 ns |       327.937 ns |     17.975 ns |    11,616.92 ns |  1.00 |    0.00 |   0.9003 |   0.0153 |       - |    5648 B |
      Array2dOfSameInstance | .NET Core 5.0 |     9,635.53 ns |       887.799 ns |     48.663 ns |     9,624.73 ns |  0.83 |    0.00 |   0.9003 |   0.0153 |       - |    5648 B |
                            |               |                 |                  |               |                 |       |         |          |          |         |           |
   ArrayRank2OfDiffInstance | .NET Core 3.1 |     8,223.86 ns |     1,039.078 ns |     56.955 ns |     8,232.17 ns |  1.00 |    0.00 |   0.7629 |        - |       - |    4840 B |
   ArrayRank2OfDiffInstance | .NET Core 5.0 |     7,429.91 ns |       677.783 ns |     37.152 ns |     7,446.24 ns |  0.90 |    0.01 |   0.7706 |   0.0076 |       - |    4840 B |
                            |               |                 |                  |               |                 |       |         |          |          |         |           |
   ArrayRank2OfSameInstance | .NET Core 3.1 |     4,181.05 ns |       466.833 ns |     25.589 ns |     4,168.44 ns |  1.00 |    0.00 |   0.2594 |        - |       - |    1672 B |
   ArrayRank2OfSameInstance | .NET Core 5.0 |     3,318.91 ns |       413.150 ns |     22.646 ns |     3,326.04 ns |  0.79 |    0.00 |   0.2632 |        - |       - |    1672 B |
                            |               |                 |                  |               |                 |       |         |          |          |         |           |
   ArrayRank3OfDiffInstance | .NET Core 3.1 |   213,958.46 ns |    16,202.933 ns |    888.137 ns |   214,279.17 ns |  1.00 |    0.00 |  17.8223 |   2.1973 |       - |  112168 B |
   ArrayRank3OfDiffInstance | .NET Core 5.0 |   197,758.58 ns |    19,644.246 ns |  1,076.767 ns |   197,323.88 ns |  0.92 |    0.01 |  17.8223 |   2.1973 |       - |  112168 B |
                            |               |                 |                  |               |                 |       |         |          |          |         |           |
   ArrayRank3OfSameInstance | .NET Core 3.1 |   162,824.72 ns |    21,776.342 ns |  1,193.635 ns |   162,266.70 ns |  1.00 |    0.00 |  12.6953 |   0.4883 |       - |   80200 B |
   ArrayRank3OfSameInstance | .NET Core 5.0 |   156,322.23 ns |    13,262.886 ns |    726.984 ns |   156,174.98 ns |  0.96 |    0.01 |  12.6953 |   0.4883 |       - |   80200 B |
                            |               |                 |                  |               |                 |       |         |          |          |         |           |
         ListOfDiffInstance | .NET Core 3.1 | 1,243,366.34 ns |   149,542.174 ns |  8,196.911 ns | 1,246,693.95 ns |  1.00 |    0.00 |  85.9375 |  64.4531 | 41.0156 |  480099 B |
         ListOfDiffInstance | .NET Core 5.0 | 1,090,580.08 ns |   246,565.610 ns | 13,515.093 ns | 1,093,745.90 ns |  0.88 |    0.01 |  85.9375 |  64.4531 | 41.0156 |  480086 B |
                            |               |                 |                  |               |                 |       |         |          |          |         |           |
         ListOfSameInstance | .NET Core 3.1 |   360,149.56 ns |    43,157.400 ns |  2,365.603 ns |   360,010.25 ns |  1.00 |    0.00 |  39.0625 |  39.0625 | 39.0625 |  160394 B |
         ListOfSameInstance | .NET Core 5.0 |   303,671.94 ns |    30,021.197 ns |  1,645.563 ns |   303,283.25 ns |  0.84 |    0.01 |  37.5977 |  37.5977 | 37.5977 |  160378 B |
                            |               |                 |                  |               |                 |       |         |          |          |         |           |
  ListOfObjectsDiffInstance | .NET Core 3.1 | 1,223,398.63 ns | 1,387,879.396 ns | 76,074.353 ns | 1,188,648.24 ns |  1.00 |    0.00 | 113.2813 |  48.8281 |       - |  720056 B |
  ListOfObjectsDiffInstance | .NET Core 5.0 | 1,074,302.99 ns |   256,004.863 ns | 14,032.490 ns | 1,067,967.38 ns |  0.88 |    0.06 | 113.2813 |  48.8281 |       - |  720056 B |
                            |               |                 |                  |               |                 |       |         |          |          |         |           |
  ListOfObjectsSameInstance | .NET Core 3.1 |   630,977.08 ns |    90,184.928 ns |  4,943.340 ns |   631,696.19 ns |  1.00 |    0.00 |  63.4766 |  22.4609 |       - |  400088 B |
  ListOfObjectsSameInstance | .NET Core 5.0 |   652,059.77 ns | 1,149,243.168 ns | 62,993.896 ns |   617,834.18 ns |  1.03 |    0.09 |  63.4766 |  22.4609 |       - |  400088 B |
                            |               |                 |                  |               |                 |       |         |          |          |         |           |
           KeyValuePairSame | .NET Core 3.1 |       179.61 ns |         7.186 ns |      0.394 ns |       179.73 ns |  1.00 |    0.00 |   0.0050 |        - |       - |      32 B |
           KeyValuePairSame | .NET Core 5.0 |       134.32 ns |        42.051 ns |      2.305 ns |       134.47 ns |  0.75 |    0.01 |   0.0050 |        - |       - |      32 B |
                            |               |                 |                  |               |                 |       |         |          |          |         |           |
           KeyValuePairDiff | .NET Core 3.1 |       223.63 ns |       241.533 ns |     13.239 ns |       220.44 ns |  1.00 |    0.00 |   0.0100 |        - |       - |      64 B |
           KeyValuePairDiff | .NET Core 5.0 |       181.15 ns |        25.284 ns |      1.386 ns |       180.98 ns |  0.81 |    0.04 |   0.0100 |        - |       - |      64 B |
                            |               |                 |                  |               |                 |       |         |          |          |         |           |
          TupleSameInstance | .NET Core 3.1 |       189.36 ns |         1.867 ns |      0.102 ns |       189.38 ns |  1.00 |    0.00 |   0.0126 |        - |       - |      80 B |
          TupleSameInstance | .NET Core 5.0 |       165.22 ns |         8.445 ns |      0.463 ns |       165.34 ns |  0.87 |    0.00 |   0.0126 |        - |       - |      80 B |
                            |               |                 |                  |               |                 |       |         |          |          |         |           |
          TupleDiffInstance | .NET Core 3.1 |       233.53 ns |        16.932 ns |      0.928 ns |       234.05 ns |  1.00 |    0.00 |   0.0176 |        - |       - |     112 B |
          TupleDiffInstance | .NET Core 5.0 |       197.06 ns |        19.078 ns |      1.046 ns |       196.85 ns |  0.84 |    0.01 |   0.0176 |        - |       - |     112 B |
                            |               |                 |                  |               |                 |       |         |          |          |         |           |
     DictionarySameInstance | .NET Core 3.1 | 3,345,487.24 ns |   996,903.786 ns | 54,643.660 ns | 3,369,954.30 ns |  1.00 |    0.00 | 203.1250 | 160.1563 | 97.6563 | 1084901 B |
     DictionarySameInstance | .NET Core 5.0 | 3,090,878.26 ns | 1,203,024.696 ns | 65,941.843 ns | 3,119,969.14 ns |  0.92 |    0.03 | 203.1250 | 160.1563 | 97.6563 | 1084815 B |
                            |               |                 |                  |               |                 |       |         |          |          |         |           |
     DictionaryDiffInstance | .NET Core 3.1 | 4,012,058.33 ns | 1,562,398.158 ns | 85,640.315 ns | 3,968,410.94 ns |  1.00 |    0.00 | 242.1875 | 171.8750 | 85.9375 | 1404848 B |
     DictionaryDiffInstance | .NET Core 5.0 | 3,551,868.23 ns |   217,322.276 ns | 11,912.167 ns | 3,545,831.64 ns |  0.89 |    0.02 | 246.0938 | 183.5938 | 93.7500 | 1404844 B |
