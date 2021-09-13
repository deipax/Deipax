
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

                                                Method |     Toolchain |      Mean |      Error |   StdDev |    Median | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------------------------------------------ |-------------- |----------:|-----------:|---------:|----------:|------:|--------:|-------:|------:|------:|----------:|
                     From_ParentClass_NoValue_AsObject | .NET Core 3.1 |  12.41 ns |   4.007 ns | 0.220 ns |  12.51 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 5.0 |  12.05 ns |   0.614 ns | 0.034 ns |  12.04 ns |  0.97 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
                                     From_ParentStruct | .NET Core 3.1 |  85.59 ns |   0.807 ns | 0.044 ns |  85.57 ns |  1.00 |    0.00 | 0.0854 |     - |     - |     536 B |
                                     From_ParentStruct | .NET Core 5.0 |  77.42 ns |  30.842 ns | 1.691 ns |  77.88 ns |  0.90 |    0.02 | 0.0854 |     - |     - |     536 B |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
                            From_ParentStruct_AsObject | .NET Core 3.1 |  22.26 ns |   8.281 ns | 0.454 ns |  22.06 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 5.0 |  22.03 ns |   4.122 ns | 0.226 ns |  21.91 ns |  0.99 |    0.03 |      - |     - |     - |         - |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
                  From_ParentStruct_Nullable_WithValue | .NET Core 3.1 | 120.69 ns |   2.526 ns | 0.138 ns | 120.64 ns |  1.00 |    0.00 | 0.0854 |     - |     - |     536 B |
                  From_ParentStruct_Nullable_WithValue | .NET Core 5.0 | 106.10 ns |  75.348 ns | 4.130 ns | 105.13 ns |  0.88 |    0.03 | 0.0854 |     - |     - |     536 B |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 3.1 |  22.25 ns |   8.978 ns | 0.492 ns |  21.99 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 5.0 |  21.86 ns |   0.796 ns | 0.044 ns |  21.84 ns |  0.98 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
                    From_ParentStruct_Nullable_NoValue | .NET Core 3.1 |  56.10 ns |   1.849 ns | 0.101 ns |  56.11 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 5.0 |  41.02 ns |   4.398 ns | 0.241 ns |  40.93 ns |  0.73 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 3.1 |  11.52 ns |   1.570 ns | 0.086 ns |  11.55 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 5.0 |  12.06 ns |   1.157 ns | 0.063 ns |  12.03 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
                                             From_Bool | .NET Core 3.1 |  12.39 ns |   2.969 ns | 0.163 ns |  12.38 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 5.0 |  11.85 ns |   0.562 ns | 0.031 ns |  11.84 ns |  0.96 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
                                    From_Bool_AsObject | .NET Core 3.1 |  15.68 ns |   1.649 ns | 0.090 ns |  15.64 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 5.0 |  16.10 ns |   1.701 ns | 0.093 ns |  16.05 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
                          From_Bool_Nullable_WithValue | .NET Core 3.1 |  14.59 ns |   2.820 ns | 0.155 ns |  14.55 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 5.0 |  12.71 ns |   4.357 ns | 0.239 ns |  12.76 ns |  0.87 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 3.1 |  15.97 ns |   0.499 ns | 0.027 ns |  15.96 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 5.0 |  16.87 ns |   3.194 ns | 0.175 ns |  16.93 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
                            From_Bool_Nullable_NoValue | .NET Core 3.1 |  11.11 ns |   0.964 ns | 0.053 ns |  11.12 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 5.0 |  11.59 ns |   9.569 ns | 0.525 ns |  11.39 ns |  1.04 |    0.05 |      - |     - |     - |         - |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 3.1 |  12.25 ns |   3.460 ns | 0.190 ns |  12.18 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 5.0 |  12.54 ns |   1.163 ns | 0.064 ns |  12.57 ns |  1.02 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
                                             From_Byte | .NET Core 3.1 |  25.64 ns |   1.503 ns | 0.082 ns |  25.60 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 5.0 |  12.82 ns |   1.255 ns | 0.069 ns |  12.79 ns |  0.50 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
                                    From_Byte_AsObject | .NET Core 3.1 |  28.84 ns |   4.634 ns | 0.254 ns |  28.90 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 5.0 |  18.11 ns |  15.767 ns | 0.864 ns |  17.64 ns |  0.63 |    0.03 |      - |     - |     - |         - |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
                          From_Byte_Nullable_WithValue | .NET Core 3.1 |  24.65 ns |  19.260 ns | 1.056 ns |  24.04 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 5.0 |  13.38 ns |   0.710 ns | 0.039 ns |  13.40 ns |  0.54 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 3.1 |  28.24 ns |  12.296 ns | 0.674 ns |  27.93 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 5.0 |  17.35 ns |   2.814 ns | 0.154 ns |  17.26 ns |  0.61 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
                            From_Byte_Nullable_NoValue | .NET Core 3.1 |  10.97 ns |   1.541 ns | 0.084 ns |  10.95 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 5.0 |  11.22 ns |   1.843 ns | 0.101 ns |  11.22 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 3.1 |  12.29 ns |   3.719 ns | 0.204 ns |  12.35 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 5.0 |  12.54 ns |   1.549 ns | 0.085 ns |  12.58 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
                                             From_Char | .NET Core 3.1 |  13.80 ns |   1.120 ns | 0.061 ns |  13.77 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                             From_Char | .NET Core 5.0 |  14.26 ns |   2.558 ns | 0.140 ns |  14.33 ns |  1.03 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
                                    From_Char_AsObject | .NET Core 3.1 |  18.05 ns |   1.930 ns | 0.106 ns |  18.07 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Char_AsObject | .NET Core 5.0 |  19.35 ns |   2.976 ns | 0.163 ns |  19.37 ns |  1.07 |    0.02 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
                          From_Char_Nullable_WithValue | .NET Core 3.1 |  14.17 ns |   2.993 ns | 0.164 ns |  14.12 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                          From_Char_Nullable_WithValue | .NET Core 5.0 |  15.36 ns |   2.422 ns | 0.133 ns |  15.30 ns |  1.08 |    0.02 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 3.1 |  18.18 ns |  10.268 ns | 0.563 ns |  18.06 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 5.0 |  22.37 ns |   6.207 ns | 0.340 ns |  22.49 ns |  1.23 |    0.02 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
                            From_Char_Nullable_NoValue | .NET Core 3.1 |  12.73 ns |   7.477 ns | 0.410 ns |  12.83 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 5.0 |  11.31 ns |   3.630 ns | 0.199 ns |  11.33 ns |  0.89 |    0.04 |      - |     - |     - |         - |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 3.1 |  12.03 ns |   0.399 ns | 0.022 ns |  12.04 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 5.0 |  12.96 ns |  12.430 ns | 0.681 ns |  13.29 ns |  1.08 |    0.06 |      - |     - |     - |         - |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
                                         From_DateTime | .NET Core 3.1 | 234.10 ns |  12.017 ns | 0.659 ns | 234.05 ns |  1.00 |    0.00 | 0.0100 |     - |     - |      64 B |
                                         From_DateTime | .NET Core 5.0 | 229.90 ns |  40.560 ns | 2.223 ns | 230.14 ns |  0.98 |    0.01 | 0.0100 |     - |     - |      64 B |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
                                From_DateTime_AsObject | .NET Core 3.1 | 245.45 ns |  19.160 ns | 1.050 ns | 245.76 ns |  1.00 |    0.00 | 0.0100 |     - |     - |      64 B |
                                From_DateTime_AsObject | .NET Core 5.0 | 239.03 ns |   8.725 ns | 0.478 ns | 238.79 ns |  0.97 |    0.00 | 0.0100 |     - |     - |      64 B |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
                      From_DateTime_Nullable_WithValue | .NET Core 3.1 | 241.24 ns |  41.744 ns | 2.288 ns | 240.53 ns |  1.00 |    0.00 | 0.0100 |     - |     - |      64 B |
                      From_DateTime_Nullable_WithValue | .NET Core 5.0 | 239.58 ns |  42.315 ns | 2.319 ns | 240.47 ns |  0.99 |    0.01 | 0.0100 |     - |     - |      64 B |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 3.1 | 248.02 ns |   6.680 ns | 0.366 ns | 248.12 ns |  1.00 |    0.00 | 0.0100 |     - |     - |      64 B |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 5.0 | 242.61 ns |  30.247 ns | 1.658 ns | 242.73 ns |  0.98 |    0.01 | 0.0100 |     - |     - |      64 B |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
                        From_DateTime_Nullable_NoValue | .NET Core 3.1 |  13.26 ns |   0.447 ns | 0.025 ns |  13.26 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 5.0 |  11.78 ns |   2.019 ns | 0.111 ns |  11.72 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 3.1 |  11.35 ns |   1.431 ns | 0.078 ns |  11.32 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 5.0 |  12.65 ns |   1.298 ns | 0.071 ns |  12.66 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
                                          From_Decimal | .NET Core 3.1 |  58.77 ns |   6.347 ns | 0.348 ns |  58.66 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                          From_Decimal | .NET Core 5.0 |  48.85 ns |  10.396 ns | 0.570 ns |  49.05 ns |  0.83 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
                                 From_Decimal_AsObject | .NET Core 3.1 |  61.94 ns |   1.691 ns | 0.093 ns |  61.90 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                 From_Decimal_AsObject | .NET Core 5.0 |  56.24 ns |   6.162 ns | 0.338 ns |  56.20 ns |  0.91 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
                       From_Decimal_Nullable_WithValue | .NET Core 3.1 |  57.67 ns |   9.233 ns | 0.506 ns |  57.70 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                       From_Decimal_Nullable_WithValue | .NET Core 5.0 |  49.20 ns |  10.894 ns | 0.597 ns |  49.49 ns |  0.85 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 3.1 |  61.99 ns |   8.744 ns | 0.479 ns |  61.73 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 5.0 |  56.49 ns |   6.597 ns | 0.362 ns |  56.36 ns |  0.91 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
                         From_Decimal_Nullable_NoValue | .NET Core 3.1 |  13.80 ns |   3.247 ns | 0.178 ns |  13.73 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 5.0 |  12.62 ns |   1.132 ns | 0.062 ns |  12.61 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 3.1 |  11.43 ns |   2.164 ns | 0.119 ns |  11.38 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 5.0 |  13.11 ns |  11.312 ns | 0.620 ns |  13.40 ns |  1.15 |    0.07 |      - |     - |     - |         - |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
                                           From_Double | .NET Core 3.1 | 128.68 ns |  47.545 ns | 2.606 ns | 129.47 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                           From_Double | .NET Core 5.0 | 107.62 ns |   6.920 ns | 0.379 ns | 107.79 ns |  0.84 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
                                  From_Double_AsObject | .NET Core 3.1 | 131.57 ns |   4.787 ns | 0.262 ns | 131.47 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                  From_Double_AsObject | .NET Core 5.0 | 117.78 ns | 134.731 ns | 7.385 ns | 113.65 ns |  0.90 |    0.05 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
                        From_Double_Nullable_WithValue | .NET Core 3.1 | 126.95 ns |  46.068 ns | 2.525 ns | 125.50 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                        From_Double_Nullable_WithValue | .NET Core 5.0 | 108.02 ns |  38.150 ns | 2.091 ns | 107.16 ns |  0.85 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
               From_Double_Nullable_WithValue_AsObject | .NET Core 3.1 | 136.07 ns |  75.697 ns | 4.149 ns | 138.41 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
               From_Double_Nullable_WithValue_AsObject | .NET Core 5.0 | 112.96 ns |  40.516 ns | 2.221 ns | 113.43 ns |  0.83 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
                          From_Double_Nullable_NoValue | .NET Core 3.1 |  11.26 ns |   0.209 ns | 0.011 ns |  11.26 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 5.0 |  12.57 ns |   3.930 ns | 0.215 ns |  12.67 ns |  1.12 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 3.1 |  11.54 ns |   3.530 ns | 0.193 ns |  11.62 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 5.0 |  12.48 ns |   1.584 ns | 0.087 ns |  12.45 ns |  1.08 |    0.03 |      - |     - |     - |         - |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
                                            From_Short | .NET Core 3.1 |  23.46 ns |   9.966 ns | 0.546 ns |  23.77 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 5.0 |  13.10 ns |   2.518 ns | 0.138 ns |  13.03 ns |  0.56 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
                                   From_Short_AsObject | .NET Core 3.1 |  28.87 ns |   0.740 ns | 0.041 ns |  28.86 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 5.0 |  18.36 ns |   1.847 ns | 0.101 ns |  18.38 ns |  0.64 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
                         From_Short_Nullable_WithValue | .NET Core 3.1 |  23.10 ns |   4.013 ns | 0.220 ns |  23.09 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 5.0 |  13.34 ns |   6.663 ns | 0.365 ns |  13.14 ns |  0.58 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
                From_Short_Nullable_WithValue_AsObject | .NET Core 3.1 |  28.44 ns |   5.908 ns | 0.324 ns |  28.26 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 5.0 |  18.16 ns |   0.546 ns | 0.030 ns |  18.15 ns |  0.64 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
                           From_Short_Nullable_NoValue | .NET Core 3.1 |  11.09 ns |   2.397 ns | 0.131 ns |  11.02 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 5.0 |  11.36 ns |   6.839 ns | 0.375 ns |  11.18 ns |  1.02 |    0.04 |      - |     - |     - |         - |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 3.1 |  11.42 ns |   3.036 ns | 0.166 ns |  11.33 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 5.0 |  12.51 ns |   2.209 ns | 0.121 ns |  12.49 ns |  1.10 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
                                              From_Int | .NET Core 3.1 |  26.83 ns |   2.622 ns | 0.144 ns |  26.78 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 5.0 |  12.72 ns |   0.412 ns | 0.023 ns |  12.72 ns |  0.47 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
                                     From_Int_AsObject | .NET Core 3.1 |  28.59 ns |   9.013 ns | 0.494 ns |  28.63 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 5.0 |  17.69 ns |  11.513 ns | 0.631 ns |  17.35 ns |  0.62 |    0.03 |      - |     - |     - |         - |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
                           From_Int_Nullable_WithValue | .NET Core 3.1 |  23.49 ns |   4.580 ns | 0.251 ns |  23.46 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 5.0 |  13.49 ns |   8.013 ns | 0.439 ns |  13.25 ns |  0.57 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 3.1 |  27.56 ns |   6.787 ns | 0.372 ns |  27.48 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 5.0 |  17.32 ns |   0.606 ns | 0.033 ns |  17.30 ns |  0.63 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
                             From_Int_Nullable_NoValue | .NET Core 3.1 |  11.10 ns |   2.626 ns | 0.144 ns |  11.02 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 5.0 |  11.21 ns |   3.336 ns | 0.183 ns |  11.15 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 3.1 |  11.58 ns |   3.758 ns | 0.206 ns |  11.67 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 5.0 |  11.99 ns |   0.553 ns | 0.030 ns |  11.98 ns |  1.04 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
                                             From_Long | .NET Core 3.1 |  22.27 ns |   3.342 ns | 0.183 ns |  22.22 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Long | .NET Core 5.0 |  13.61 ns |   3.090 ns | 0.169 ns |  13.53 ns |  0.61 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
                                    From_Long_AsObject | .NET Core 3.1 |  30.63 ns |   1.526 ns | 0.084 ns |  30.61 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 5.0 |  18.24 ns |   1.343 ns | 0.074 ns |  18.25 ns |  0.60 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
                          From_Long_Nullable_WithValue | .NET Core 3.1 |  23.06 ns |   4.899 ns | 0.269 ns |  23.12 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 5.0 |  14.38 ns |   2.206 ns | 0.121 ns |  14.33 ns |  0.62 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 3.1 |  29.07 ns |   1.034 ns | 0.057 ns |  29.08 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 5.0 |  18.16 ns |   0.362 ns | 0.020 ns |  18.15 ns |  0.62 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
                            From_Long_Nullable_NoValue | .NET Core 3.1 |  11.58 ns |   0.416 ns | 0.023 ns |  11.58 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 5.0 |  11.87 ns |   2.078 ns | 0.114 ns |  11.83 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 3.1 |  11.83 ns |   2.341 ns | 0.128 ns |  11.77 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 5.0 |  12.42 ns |   1.534 ns | 0.084 ns |  12.41 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
                                            From_SByte | .NET Core 3.1 |  22.59 ns |  16.229 ns | 0.890 ns |  22.26 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 5.0 |  13.14 ns |   3.327 ns | 0.182 ns |  13.20 ns |  0.58 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
                                   From_SByte_AsObject | .NET Core 3.1 |  28.96 ns |   9.640 ns | 0.528 ns |  28.80 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 5.0 |  17.41 ns |   1.254 ns | 0.069 ns |  17.44 ns |  0.60 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
                         From_SByte_Nullable_WithValue | .NET Core 3.1 |  23.33 ns |   3.338 ns | 0.183 ns |  23.39 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 5.0 |  13.13 ns |   0.542 ns | 0.030 ns |  13.14 ns |  0.56 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 3.1 |  28.36 ns |   7.169 ns | 0.393 ns |  28.18 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 5.0 |  18.16 ns |   3.361 ns | 0.184 ns |  18.08 ns |  0.64 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
                           From_SByte_Nullable_NoValue | .NET Core 3.1 |  13.24 ns |   0.989 ns | 0.054 ns |  13.24 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 5.0 |  11.45 ns |   4.562 ns | 0.250 ns |  11.32 ns |  0.86 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 3.1 |  12.05 ns |   1.760 ns | 0.096 ns |  12.00 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 5.0 |  12.37 ns |   1.137 ns | 0.062 ns |  12.39 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
                                            From_Float | .NET Core 3.1 | 128.70 ns |  50.684 ns | 2.778 ns | 129.45 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                            From_Float | .NET Core 5.0 | 107.29 ns |   5.863 ns | 0.321 ns | 107.35 ns |  0.83 |    0.02 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
                                   From_Float_AsObject | .NET Core 3.1 | 133.80 ns |   4.608 ns | 0.253 ns | 133.83 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                   From_Float_AsObject | .NET Core 5.0 | 114.63 ns |  34.123 ns | 1.870 ns | 115.22 ns |  0.86 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
                         From_Float_Nullable_WithValue | .NET Core 3.1 | 125.21 ns |  11.304 ns | 0.620 ns | 125.08 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                         From_Float_Nullable_WithValue | .NET Core 5.0 | 107.75 ns |   8.427 ns | 0.462 ns | 107.64 ns |  0.86 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
                From_Float_Nullable_WithValue_AsObject | .NET Core 3.1 | 132.57 ns |  40.690 ns | 2.230 ns | 133.17 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                From_Float_Nullable_WithValue_AsObject | .NET Core 5.0 | 113.17 ns |  25.907 ns | 1.420 ns | 113.22 ns |  0.85 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
                           From_Float_Nullable_NoValue | .NET Core 3.1 |  15.86 ns |   4.501 ns | 0.247 ns |  15.79 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 5.0 |  11.51 ns |  10.526 ns | 0.577 ns |  11.83 ns |  0.73 |    0.05 |      - |     - |     - |         - |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 3.1 |  12.03 ns |   0.671 ns | 0.037 ns |  12.05 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 5.0 |  13.83 ns |   1.443 ns | 0.079 ns |  13.87 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
                                           From_String | .NET Core 3.1 |  10.67 ns |   3.052 ns | 0.167 ns |  10.59 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 5.0 |  11.60 ns |   2.355 ns | 0.129 ns |  11.56 ns |  1.09 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
                                  From_String_AsObject | .NET Core 3.1 |  12.62 ns |   1.005 ns | 0.055 ns |  12.62 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 5.0 |  13.20 ns |   5.822 ns | 0.319 ns |  13.11 ns |  1.05 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
                                      From_String_Null | .NET Core 3.1 |  11.77 ns |   0.211 ns | 0.012 ns |  11.78 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 5.0 |  11.40 ns |   2.967 ns | 0.163 ns |  11.34 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
                             From_String_Null_AsObject | .NET Core 3.1 |  12.09 ns |   1.862 ns | 0.102 ns |  12.09 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 5.0 |  12.21 ns |   2.297 ns | 0.126 ns |  12.21 ns |  1.01 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
                                     From_String_Empty | .NET Core 3.1 |  11.86 ns |   3.110 ns | 0.170 ns |  11.76 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 5.0 |  11.01 ns |   5.561 ns | 0.305 ns |  10.94 ns |  0.93 |    0.04 |      - |     - |     - |         - |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
                            From_String_Empty_AsObject | .NET Core 3.1 |  12.03 ns |   2.180 ns | 0.120 ns |  11.96 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 5.0 |  12.55 ns |   2.225 ns | 0.122 ns |  12.49 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
                                           From_UShort | .NET Core 3.1 |  24.78 ns |   5.249 ns | 0.288 ns |  24.90 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 5.0 |  12.84 ns |   0.973 ns | 0.053 ns |  12.81 ns |  0.52 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
                                  From_UShort_AsObject | .NET Core 3.1 |  29.81 ns |   1.447 ns | 0.079 ns |  29.81 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 5.0 |  17.27 ns |   6.061 ns | 0.332 ns |  17.26 ns |  0.58 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
                        From_UShort_Nullable_WithValue | .NET Core 3.1 |  23.65 ns |   2.606 ns | 0.143 ns |  23.69 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 5.0 |  13.06 ns |   0.868 ns | 0.048 ns |  13.05 ns |  0.55 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 3.1 |  29.87 ns |  11.406 ns | 0.625 ns |  29.57 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 5.0 |  17.30 ns |   0.415 ns | 0.023 ns |  17.31 ns |  0.58 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
                          From_UShort_Nullable_NoValue | .NET Core 3.1 |  13.21 ns |   0.419 ns | 0.023 ns |  13.22 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 5.0 |  11.11 ns |   0.513 ns | 0.028 ns |  11.10 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 3.1 |  11.64 ns |   2.919 ns | 0.160 ns |  11.64 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 5.0 |  12.49 ns |   0.623 ns | 0.034 ns |  12.47 ns |  1.07 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
                                             From_UInt | .NET Core 3.1 |  24.27 ns |   5.859 ns | 0.321 ns |  24.42 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 5.0 |  12.72 ns |   2.755 ns | 0.151 ns |  12.79 ns |  0.52 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
                                    From_UInt_AsObject | .NET Core 3.1 |  28.02 ns |   6.659 ns | 0.365 ns |  27.99 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 5.0 |  17.28 ns |   1.556 ns | 0.085 ns |  17.26 ns |  0.62 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
                          From_UInt_Nullable_WithValue | .NET Core 3.1 |  22.87 ns |   2.489 ns | 0.136 ns |  22.94 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 5.0 |  13.12 ns |   3.940 ns | 0.216 ns |  13.04 ns |  0.57 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 3.1 |  28.07 ns |   1.451 ns | 0.080 ns |  28.09 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 5.0 |  18.56 ns |   0.152 ns | 0.008 ns |  18.55 ns |  0.66 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
                            From_UInt_Nullable_NoValue | .NET Core 3.1 |  11.95 ns |   0.710 ns | 0.039 ns |  11.94 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 5.0 |  11.80 ns |  18.433 ns | 1.010 ns |  11.31 ns |  0.99 |    0.09 |      - |     - |     - |         - |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 3.1 |  11.35 ns |   1.578 ns | 0.086 ns |  11.32 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 5.0 |  12.99 ns |  11.955 ns | 0.655 ns |  12.68 ns |  1.14 |    0.06 |      - |     - |     - |         - |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
                                            From_ULong | .NET Core 3.1 |  23.24 ns |   2.563 ns | 0.140 ns |  23.29 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 5.0 |  13.81 ns |   3.239 ns | 0.178 ns |  13.76 ns |  0.59 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
                                   From_ULong_AsObject | .NET Core 3.1 |  29.82 ns |   7.216 ns | 0.396 ns |  29.99 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 5.0 |  18.07 ns |   3.638 ns | 0.199 ns |  18.09 ns |  0.61 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
                         From_ULong_Nullable_WithValue | .NET Core 3.1 |  23.18 ns |   3.633 ns | 0.199 ns |  23.23 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 5.0 |  14.52 ns |   3.230 ns | 0.177 ns |  14.55 ns |  0.63 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 3.1 |  30.20 ns |   3.363 ns | 0.184 ns |  30.10 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 5.0 |  18.26 ns |   8.847 ns | 0.485 ns |  18.53 ns |  0.60 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
                           From_ULong_Nullable_NoValue | .NET Core 3.1 |  13.00 ns |   4.866 ns | 0.267 ns |  13.08 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 5.0 |  11.99 ns |   5.946 ns | 0.326 ns |  12.17 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 3.1 |  12.51 ns |   0.965 ns | 0.053 ns |  12.48 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 5.0 |  12.21 ns |   6.918 ns | 0.379 ns |  12.00 ns |  0.98 |    0.03 |      - |     - |     - |         - |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
                                       From_NullObject | .NET Core 3.1 |  12.11 ns |   2.965 ns | 0.163 ns |  12.04 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 5.0 |  12.03 ns |   2.570 ns | 0.141 ns |  11.96 ns |  0.99 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
                                           From_DBNull | .NET Core 3.1 |  11.14 ns |   2.642 ns | 0.145 ns |  11.08 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 5.0 |  10.74 ns |   4.114 ns | 0.226 ns |  10.74 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
                                  From_DBNull_AsObject | .NET Core 3.1 |  11.45 ns |   2.643 ns | 0.145 ns |  11.39 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 5.0 |  12.93 ns |  13.624 ns | 0.747 ns |  13.34 ns |  1.13 |    0.06 |      - |     - |     - |         - |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
                                 From_ConvertibleClass | .NET Core 3.1 |  13.78 ns |   2.686 ns | 0.147 ns |  13.75 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 5.0 |  12.88 ns |   0.310 ns | 0.017 ns |  12.88 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
                        From_ConvertibleClass_AsObject | .NET Core 3.1 |  15.65 ns |   1.662 ns | 0.091 ns |  15.63 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 5.0 |  15.57 ns |   0.855 ns | 0.047 ns |  15.54 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
                         From_ConvertibleClass_NoValue | .NET Core 3.1 |  12.00 ns |   0.243 ns | 0.013 ns |  12.01 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 5.0 |  12.25 ns |   4.785 ns | 0.262 ns |  12.14 ns |  1.02 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 3.1 |  11.35 ns |   1.674 ns | 0.092 ns |  11.30 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 5.0 |  12.10 ns |   0.341 ns | 0.019 ns |  12.10 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
                              From_NonConvertibleClass | .NET Core 3.1 |  20.54 ns |   0.219 ns | 0.012 ns |  20.54 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 5.0 |  18.66 ns |  17.738 ns | 0.972 ns |  18.22 ns |  0.91 |    0.05 |      - |     - |     - |         - |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
                     From_NonConvertibleClass_AsObject | .NET Core 3.1 |  21.56 ns |   7.485 ns | 0.410 ns |  21.33 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 5.0 |  25.03 ns |  17.375 ns | 0.952 ns |  24.62 ns |  1.16 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
                      From_NonConvertibleClass_NoValue | .NET Core 3.1 |  11.90 ns |   0.391 ns | 0.021 ns |  11.91 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 5.0 |  11.46 ns |   2.297 ns | 0.126 ns |  11.41 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 3.1 |  12.25 ns |   0.850 ns | 0.047 ns |  12.23 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 5.0 |  12.07 ns |   1.585 ns | 0.087 ns |  12.03 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
                                From_ConvertibleStruct | .NET Core 3.1 |  18.56 ns |   0.400 ns | 0.022 ns |  18.56 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 5.0 |  16.43 ns |   1.775 ns | 0.097 ns |  16.42 ns |  0.89 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
                       From_ConvertibleStruct_AsObject | .NET Core 3.1 |  17.93 ns |   6.207 ns | 0.340 ns |  17.94 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 5.0 |  16.09 ns |   3.105 ns | 0.170 ns |  16.17 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 3.1 |  16.40 ns |   3.948 ns | 0.216 ns |  16.28 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 5.0 |  18.06 ns |   3.087 ns | 0.169 ns |  18.10 ns |  1.10 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.1 |  15.36 ns |   5.353 ns | 0.293 ns |  15.46 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 5.0 |  16.08 ns |   3.184 ns | 0.175 ns |  16.03 ns |  1.05 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 3.1 |  11.97 ns |   3.152 ns | 0.173 ns |  11.96 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 5.0 |  11.64 ns |   1.706 ns | 0.094 ns |  11.63 ns |  0.97 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.1 |  11.43 ns |   1.559 ns | 0.085 ns |  11.48 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 5.0 |  12.07 ns |   1.595 ns | 0.087 ns |  12.12 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
                             From_NonConvertibleStruct | .NET Core 3.1 |  19.25 ns |   2.847 ns | 0.156 ns |  19.28 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                             From_NonConvertibleStruct | .NET Core 5.0 |  18.42 ns |   2.024 ns | 0.111 ns |  18.48 ns |  0.96 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
                    From_NonConvertibleStruct_AsObject | .NET Core 3.1 |  20.43 ns |   0.142 ns | 0.008 ns |  20.42 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 5.0 |  22.77 ns |   8.405 ns | 0.461 ns |  22.52 ns |  1.11 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 3.1 |  22.65 ns |   2.356 ns | 0.129 ns |  22.70 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 5.0 |  20.67 ns |   0.931 ns | 0.051 ns |  20.69 ns |  0.91 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.1 |  21.67 ns |   5.139 ns | 0.282 ns |  21.52 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 5.0 |  22.72 ns |   4.196 ns | 0.230 ns |  22.72 ns |  1.05 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 3.1 |  11.56 ns |   0.676 ns | 0.037 ns |  11.56 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 5.0 |  11.17 ns |   3.897 ns | 0.214 ns |  11.17 ns |  0.97 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.1 |  14.65 ns |   1.106 ns | 0.061 ns |  14.68 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 5.0 |  12.24 ns |   4.453 ns | 0.244 ns |  12.37 ns |  0.84 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
                                             From_Enum | .NET Core 3.1 |  32.89 ns |   1.437 ns | 0.079 ns |  32.93 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 5.0 |  27.99 ns |   2.815 ns | 0.154 ns |  27.92 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
                                    From_Enum_AsObject | .NET Core 3.1 |  44.98 ns |   7.433 ns | 0.407 ns |  44.95 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Enum_AsObject | .NET Core 5.0 |  39.82 ns |   0.181 ns | 0.010 ns |  39.82 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
                          From_Enum_Nullable_WithValue | .NET Core 3.1 |  32.16 ns |   3.130 ns | 0.172 ns |  32.25 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 5.0 |  28.41 ns |   5.988 ns | 0.328 ns |  28.41 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 3.1 |  44.03 ns |   5.277 ns | 0.289 ns |  44.03 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 5.0 |  38.53 ns |   6.480 ns | 0.355 ns |  38.61 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
                            From_Enum_Nullable_NoValue | .NET Core 3.1 |  11.05 ns |   0.909 ns | 0.050 ns |  11.05 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 5.0 |  11.15 ns |   0.869 ns | 0.048 ns |  11.13 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 3.1 |  12.11 ns |   1.370 ns | 0.075 ns |  12.07 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 5.0 |  11.99 ns |   0.464 ns | 0.025 ns |  11.98 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
                                      From_ParentClass | .NET Core 3.1 |  15.96 ns |   2.112 ns | 0.116 ns |  15.93 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 5.0 |  16.94 ns |   2.626 ns | 0.144 ns |  16.94 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
                             From_ParentClass_AsObject | .NET Core 3.1 |  21.75 ns |   9.979 ns | 0.547 ns |  22.06 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 5.0 |  22.00 ns |   6.520 ns | 0.357 ns |  21.83 ns |  1.01 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |          |           |       |         |        |       |       |           |
                              From_ParentClass_NoValue | .NET Core 3.1 |  12.73 ns |   0.452 ns | 0.025 ns |  12.75 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 5.0 |  12.07 ns |   5.514 ns | 0.302 ns |  12.11 ns |  0.95 |    0.03 |      - |     - |     - |         - |
