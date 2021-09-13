
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

                     Method |     Toolchain |            Mean |             Error |         StdDev |          Median | Ratio | RatioSD |    Gen 0 |    Gen 1 |    Gen 2 | Allocated |
--------------------------- |-------------- |----------------:|------------------:|---------------:|----------------:|------:|--------:|---------:|---------:|---------:|----------:|
             SingleInstance | .NET Core 3.1 |       192.22 ns |         70.257 ns |       3.851 ns |       193.58 ns |  1.00 |    0.00 |   0.0100 |        - |        - |      64 B |
             SingleInstance | .NET Core 5.0 |       161.49 ns |          2.600 ns |       0.143 ns |       161.51 ns |  0.84 |    0.02 |   0.0100 |        - |        - |      64 B |
                            |               |                 |                   |                |                 |       |         |          |          |          |           |
             ObjectInstance | .NET Core 3.1 |       133.01 ns |         20.812 ns |       1.141 ns |       132.78 ns |  1.00 |    0.00 |   0.0100 |        - |        - |      64 B |
             ObjectInstance | .NET Core 5.0 |       127.01 ns |         18.170 ns |       0.996 ns |       126.52 ns |  0.95 |    0.01 |   0.0100 |        - |        - |      64 B |
                            |               |                 |                   |                |                 |       |         |          |          |          |           |
            DefaultInstance | .NET Core 3.1 |        30.43 ns |         10.070 ns |       0.552 ns |        30.74 ns |  1.00 |    0.00 |        - |        - |        - |         - |
            DefaultInstance | .NET Core 5.0 |        22.76 ns |          2.445 ns |       0.134 ns |        22.72 ns |  0.75 |    0.01 |        - |        - |        - |         - |
                            |               |                 |                   |                |                 |       |         |          |          |          |           |
     ArrayOfDefaultInstance | .NET Core 3.1 |    20,181.22 ns |     20,285.450 ns |   1,111.914 ns |    20,734.90 ns |  1.00 |    0.00 |   3.9673 |   3.9673 |   3.9673 |  240020 B |
     ArrayOfDefaultInstance | .NET Core 5.0 |    17,333.92 ns |      1,872.860 ns |     102.658 ns |    17,274.96 ns |  0.86 |    0.05 |   3.8452 |   3.8452 |   3.8452 |  240020 B |
                            |               |                 |                   |                |                 |       |         |          |          |          |           |
        ArrayOfDiffInstance | .NET Core 3.1 | 2,367,614.71 ns |    742,658.234 ns |  40,707.604 ns | 2,365,388.28 ns |  1.00 |    0.00 | 152.3438 | 105.4688 |  50.7813 |  880228 B |
        ArrayOfDiffInstance | .NET Core 5.0 | 2,089,647.14 ns |    386,345.897 ns |  21,176.922 ns | 2,096,445.70 ns |  0.88 |    0.02 | 148.4375 |  97.6563 |  50.7813 |  880086 B |
                            |               |                 |                   |                |                 |       |         |          |          |          |           |
        ArrayOfSameInstance | .NET Core 3.1 | 1,114,291.34 ns |    112,083.340 ns |   6,143.666 ns | 1,111,911.33 ns |  1.00 |    0.00 | 107.4219 |  56.6406 |  56.6406 |  560191 B |
        ArrayOfSameInstance | .NET Core 5.0 | 1,035,864.39 ns |     26,605.345 ns |   1,458.329 ns | 1,035,303.32 ns |  0.93 |    0.00 | 105.4688 |  54.6875 |  54.6875 |  560221 B |
                            |               |                 |                   |                |                 |       |         |          |          |          |           |
 ArrayOfObjectsDiffInstance | .NET Core 3.1 | 1,113,256.25 ns |     73,496.444 ns |   4,028.588 ns | 1,114,314.06 ns |  1.00 |    0.00 | 113.2813 |  48.8281 |        - |  720024 B |
 ArrayOfObjectsDiffInstance | .NET Core 5.0 | 1,048,554.43 ns |    219,392.192 ns |  12,025.626 ns | 1,049,396.09 ns |  0.94 |    0.01 | 113.2813 |  48.8281 |        - |  720024 B |
                            |               |                 |                   |                |                 |       |         |          |          |          |           |
 ArrayOfObjectsSameInstance | .NET Core 3.1 |   606,595.44 ns |     65,947.146 ns |   3,614.786 ns |   608,364.84 ns |  1.00 |    0.00 |  63.4766 |  22.4609 |        - |  400056 B |
 ArrayOfObjectsSameInstance | .NET Core 5.0 |   607,347.69 ns |     52,341.779 ns |   2,869.030 ns |   607,121.00 ns |  1.00 |    0.01 |  63.4766 |  22.4609 |        - |  400056 B |
                            |               |                 |                   |                |                 |       |         |          |          |          |           |
      Array2dOfDiffInstance | .NET Core 3.1 | 1,634,543.42 ns |    252,171.427 ns |  13,822.367 ns | 1,626,662.11 ns |  1.00 |    0.00 | 140.6250 |  48.8281 |        - |  883224 B |
      Array2dOfDiffInstance | .NET Core 5.0 | 1,455,828.39 ns |     89,877.027 ns |   4,926.463 ns | 1,457,202.54 ns |  0.89 |    0.01 | 140.6250 |  48.8281 |        - |  883224 B |
                            |               |                 |                   |                |                 |       |         |          |          |          |           |
      Array2dOfSameInstance | .NET Core 3.1 |    20,012.34 ns |      2,022.865 ns |     110.880 ns |    20,054.10 ns |  1.00 |    0.00 |   1.5259 |   0.0305 |        - |    9648 B |
      Array2dOfSameInstance | .NET Core 5.0 |    16,123.35 ns |      3,709.357 ns |     203.322 ns |    16,187.86 ns |  0.81 |    0.01 |   1.5259 |   0.0305 |        - |    9648 B |
                            |               |                 |                   |                |                 |       |         |          |          |          |           |
   ArrayRank2OfDiffInstance | .NET Core 3.1 |    15,415.30 ns |      2,118.643 ns |     116.130 ns |    15,390.23 ns |  1.00 |    0.00 |   1.4038 |        - |        - |    8840 B |
   ArrayRank2OfDiffInstance | .NET Core 5.0 |    13,633.72 ns |      3,131.483 ns |     171.647 ns |    13,565.67 ns |  0.88 |    0.02 |   1.4038 |   0.0153 |        - |    8840 B |
                            |               |                 |                   |                |                 |       |         |          |          |          |           |
   ArrayRank2OfSameInstance | .NET Core 3.1 |    10,865.92 ns |      1,432.654 ns |      78.529 ns |    10,846.75 ns |  1.00 |    0.00 |   0.9003 |        - |        - |    5672 B |
   ArrayRank2OfSameInstance | .NET Core 5.0 |     9,849.58 ns |      1,938.829 ns |     106.274 ns |     9,887.32 ns |  0.91 |    0.01 |   0.9003 |        - |        - |    5672 B |
                            |               |                 |                   |                |                 |       |         |          |          |          |           |
   ArrayRank3OfDiffInstance | .NET Core 3.1 |   216,376.65 ns |     29,929.553 ns |   1,640.540 ns |   216,817.21 ns |  1.00 |    0.00 |  19.0430 |   2.6855 |        - |  120168 B |
   ArrayRank3OfDiffInstance | .NET Core 5.0 |   202,834.98 ns |     29,341.157 ns |   1,608.288 ns |   203,728.54 ns |  0.94 |    0.01 |  19.0430 |   2.6855 |        - |  120168 B |
                            |               |                 |                   |                |                 |       |         |          |          |          |           |
   ArrayRank3OfSameInstance | .NET Core 3.1 |   168,666.09 ns |     26,396.369 ns |   1,446.874 ns |   167,923.27 ns |  1.00 |    0.00 |  13.9160 |   0.9766 |        - |   88200 B |
   ArrayRank3OfSameInstance | .NET Core 5.0 |   158,402.28 ns |     14,917.490 ns |     817.678 ns |   158,506.23 ns |  0.94 |    0.01 |  13.9160 |   0.9766 |        - |   88200 B |
                            |               |                 |                   |                |                 |       |         |          |          |          |           |
         ListOfDiffInstance | .NET Core 3.1 | 2,299,475.52 ns |    279,695.511 ns |  15,331.055 ns | 2,293,839.06 ns |  1.00 |    0.00 | 148.4375 | 101.5625 |  50.7813 |  880151 B |
         ListOfDiffInstance | .NET Core 5.0 | 2,106,814.84 ns |    919,461.564 ns |  50,398.791 ns | 2,089,031.64 ns |  0.92 |    0.03 | 148.4375 |  97.6563 |  50.7813 |  880178 B |
                            |               |                 |                   |                |                 |       |         |          |          |          |           |
         ListOfSameInstance | .NET Core 3.1 | 1,154,809.51 ns |     21,715.068 ns |   1,190.276 ns | 1,154,580.47 ns |  1.00 |    0.00 | 107.4219 |  56.6406 |  56.6406 |  560248 B |
         ListOfSameInstance | .NET Core 5.0 | 1,088,184.24 ns |    507,984.028 ns |  27,844.319 ns | 1,088,261.52 ns |  0.94 |    0.02 | 107.4219 |  56.6406 |  56.6406 |  560255 B |
                            |               |                 |                   |                |                 |       |         |          |          |          |           |
  ListOfObjectsDiffInstance | .NET Core 3.1 | 1,202,846.16 ns |    120,597.430 ns |   6,610.352 ns | 1,202,267.19 ns |  1.00 |    0.00 | 113.2813 |  48.8281 |        - |  720056 B |
  ListOfObjectsDiffInstance | .NET Core 5.0 | 1,055,345.44 ns |    405,672.169 ns |  22,236.260 ns | 1,046,677.15 ns |  0.88 |    0.01 | 113.2813 |  48.8281 |        - |  720056 B |
                            |               |                 |                   |                |                 |       |         |          |          |          |           |
  ListOfObjectsSameInstance | .NET Core 3.1 |   648,371.22 ns |     58,601.990 ns |   3,212.173 ns |   647,214.94 ns |  1.00 |    0.00 |  63.4766 |  22.4609 |        - |  400088 B |
  ListOfObjectsSameInstance | .NET Core 5.0 |   562,422.20 ns |     81,347.669 ns |   4,458.940 ns |   561,256.05 ns |  0.87 |    0.01 |  63.4766 |  22.4609 |        - |  400088 B |
                            |               |                 |                   |                |                 |       |         |          |          |          |           |
           KeyValuePairSame | .NET Core 3.1 |       367.49 ns |        112.240 ns |       6.152 ns |       366.89 ns |  1.00 |    0.00 |   0.0153 |        - |        - |      96 B |
           KeyValuePairSame | .NET Core 5.0 |       275.03 ns |        152.613 ns |       8.365 ns |       278.47 ns |  0.75 |    0.03 |   0.0153 |        - |        - |      96 B |
                            |               |                 |                   |                |                 |       |         |          |          |          |           |
           KeyValuePairDiff | .NET Core 3.1 |       399.66 ns |         85.247 ns |       4.673 ns |       399.98 ns |  1.00 |    0.00 |   0.0200 |        - |        - |     128 B |
           KeyValuePairDiff | .NET Core 5.0 |       305.01 ns |         64.824 ns |       3.553 ns |       303.08 ns |  0.76 |    0.01 |   0.0200 |        - |        - |     128 B |
                            |               |                 |                   |                |                 |       |         |          |          |          |           |
          TupleSameInstance | .NET Core 3.1 |       385.29 ns |         97.310 ns |       5.334 ns |       383.72 ns |  1.00 |    0.00 |   0.0253 |        - |        - |     160 B |
          TupleSameInstance | .NET Core 5.0 |       294.72 ns |         72.050 ns |       3.949 ns |       296.26 ns |  0.77 |    0.01 |   0.0253 |        - |        - |     160 B |
                            |               |                 |                   |                |                 |       |         |          |          |          |           |
          TupleDiffInstance | .NET Core 3.1 |       434.33 ns |         77.873 ns |       4.268 ns |       433.30 ns |  1.00 |    0.00 |   0.0305 |        - |        - |     192 B |
          TupleDiffInstance | .NET Core 5.0 |       338.36 ns |         72.460 ns |       3.972 ns |       337.23 ns |  0.78 |    0.01 |   0.0305 |        - |        - |     192 B |
                            |               |                 |                   |                |                 |       |         |          |          |          |           |
     DictionarySameInstance | .NET Core 3.1 | 4,911,550.00 ns |  1,126,055.196 ns |  61,722.885 ns | 4,876,367.97 ns |  1.00 |    0.00 | 335.9375 | 257.8125 | 125.0000 | 1886761 B |
     DictionarySameInstance | .NET Core 5.0 | 4,292,434.38 ns |     87,499.531 ns |   4,796.145 ns | 4,293,046.09 ns |  0.87 |    0.01 | 335.9375 | 257.8125 | 125.0000 | 1886701 B |
                            |               |                 |                   |                |                 |       |         |          |          |          |           |
     DictionaryDiffInstance | .NET Core 3.1 | 6,607,908.07 ns | 10,692,868.580 ns | 586,112.208 ns | 6,584,927.34 ns |  1.00 |    0.00 | 351.5625 | 226.5625 | 109.3750 | 2206614 B |
     DictionaryDiffInstance | .NET Core 5.0 | 5,712,215.36 ns |    500,190.534 ns |  27,417.131 ns | 5,703,426.56 ns |  0.87 |    0.08 | 343.7500 | 226.5625 | 109.3750 | 2206490 B |
