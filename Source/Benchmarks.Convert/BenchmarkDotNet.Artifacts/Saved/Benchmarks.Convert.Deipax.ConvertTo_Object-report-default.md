
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

                                                Method |     Toolchain |     Mean |     Error |   StdDev |   Median | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------------------------------------------ |-------------- |---------:|----------:|---------:|---------:|------:|--------:|-------:|------:|------:|----------:|
                     From_ParentClass_NoValue_AsObject | .NET Core 3.1 | 11.33 ns |  3.563 ns | 0.195 ns | 11.23 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 5.0 | 10.75 ns |  0.888 ns | 0.049 ns | 10.73 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                                     From_ParentStruct | .NET Core 3.1 | 78.46 ns |  0.699 ns | 0.038 ns | 78.48 ns |  1.00 |    0.00 | 0.0854 |     - |     - |     536 B |
                                     From_ParentStruct | .NET Core 5.0 | 75.95 ns | 57.075 ns | 3.128 ns | 74.19 ns |  0.97 |    0.04 | 0.0854 |     - |     - |     536 B |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                            From_ParentStruct_AsObject | .NET Core 3.1 | 11.27 ns |  2.219 ns | 0.122 ns | 11.32 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 5.0 | 10.65 ns |  2.635 ns | 0.144 ns | 10.57 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                  From_ParentStruct_Nullable_WithValue | .NET Core 3.1 | 79.05 ns | 16.694 ns | 0.915 ns | 78.91 ns |  1.00 |    0.00 | 0.0854 |     - |     - |     536 B |
                  From_ParentStruct_Nullable_WithValue | .NET Core 5.0 | 75.96 ns | 24.770 ns | 1.358 ns | 76.49 ns |  0.96 |    0.01 | 0.0854 |     - |     - |     536 B |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 3.1 | 11.49 ns |  1.293 ns | 0.071 ns | 11.45 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 5.0 | 10.85 ns |  5.831 ns | 0.320 ns | 10.73 ns |  0.94 |    0.02 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                    From_ParentStruct_Nullable_NoValue | .NET Core 3.1 | 41.37 ns |  4.428 ns | 0.243 ns | 41.25 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 5.0 | 34.95 ns |  0.327 ns | 0.018 ns | 34.96 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 3.1 | 11.87 ns |  2.248 ns | 0.123 ns | 11.82 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 5.0 | 10.87 ns |  2.046 ns | 0.112 ns | 10.92 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                                             From_Bool | .NET Core 3.1 | 15.55 ns |  2.482 ns | 0.136 ns | 15.58 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                             From_Bool | .NET Core 5.0 | 14.10 ns |  0.577 ns | 0.032 ns | 14.10 ns |  0.91 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                                    From_Bool_AsObject | .NET Core 3.1 | 10.47 ns |  0.296 ns | 0.016 ns | 10.47 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 5.0 | 11.15 ns | 14.974 ns | 0.821 ns | 10.74 ns |  1.06 |    0.08 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                          From_Bool_Nullable_WithValue | .NET Core 3.1 | 14.32 ns |  0.337 ns | 0.018 ns | 14.32 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                          From_Bool_Nullable_WithValue | .NET Core 5.0 | 15.00 ns |  3.721 ns | 0.204 ns | 15.05 ns |  1.05 |    0.02 | 0.0038 |     - |     - |      24 B |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 3.1 | 11.77 ns |  0.945 ns | 0.052 ns | 11.76 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 5.0 | 10.80 ns |  3.023 ns | 0.166 ns | 10.85 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                            From_Bool_Nullable_NoValue | .NET Core 3.1 | 11.46 ns |  2.420 ns | 0.133 ns | 11.39 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 5.0 | 11.53 ns |  0.540 ns | 0.030 ns | 11.54 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 3.1 | 12.11 ns |  1.003 ns | 0.055 ns | 12.14 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 5.0 | 11.28 ns |  5.885 ns | 0.323 ns | 11.21 ns |  0.93 |    0.03 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                                             From_Byte | .NET Core 3.1 | 14.10 ns |  0.973 ns | 0.053 ns | 14.09 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                             From_Byte | .NET Core 5.0 | 14.18 ns |  0.820 ns | 0.045 ns | 14.17 ns |  1.01 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                                    From_Byte_AsObject | .NET Core 3.1 | 11.69 ns |  1.606 ns | 0.088 ns | 11.67 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 5.0 | 10.71 ns |  1.565 ns | 0.086 ns | 10.73 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                          From_Byte_Nullable_WithValue | .NET Core 3.1 | 16.46 ns |  1.288 ns | 0.071 ns | 16.46 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                          From_Byte_Nullable_WithValue | .NET Core 5.0 | 16.53 ns |  0.692 ns | 0.038 ns | 16.53 ns |  1.00 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 3.1 | 11.13 ns |  1.560 ns | 0.085 ns | 11.09 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 5.0 | 10.63 ns |  0.565 ns | 0.031 ns | 10.62 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                            From_Byte_Nullable_NoValue | .NET Core 3.1 | 11.36 ns |  0.269 ns | 0.015 ns | 11.36 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 5.0 | 12.22 ns | 11.476 ns | 0.629 ns | 12.57 ns |  1.08 |    0.05 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 3.1 | 11.73 ns |  0.540 ns | 0.030 ns | 11.73 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 5.0 | 11.48 ns |  1.388 ns | 0.076 ns | 11.46 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                                             From_Char | .NET Core 3.1 | 16.94 ns |  1.935 ns | 0.106 ns | 16.99 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                             From_Char | .NET Core 5.0 | 14.00 ns |  1.701 ns | 0.093 ns | 13.99 ns |  0.83 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                                    From_Char_AsObject | .NET Core 3.1 | 12.45 ns |  8.553 ns | 0.469 ns | 12.36 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 5.0 | 11.01 ns |  2.311 ns | 0.127 ns | 11.02 ns |  0.88 |    0.03 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                          From_Char_Nullable_WithValue | .NET Core 3.1 | 14.96 ns |  0.562 ns | 0.031 ns | 14.97 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                          From_Char_Nullable_WithValue | .NET Core 5.0 | 15.41 ns |  1.322 ns | 0.072 ns | 15.45 ns |  1.03 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 3.1 | 11.90 ns |  1.079 ns | 0.059 ns | 11.89 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 5.0 | 10.69 ns |  0.950 ns | 0.052 ns | 10.69 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                            From_Char_Nullable_NoValue | .NET Core 3.1 | 11.53 ns |  2.019 ns | 0.111 ns | 11.48 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 5.0 | 11.77 ns |  1.736 ns | 0.095 ns | 11.79 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 3.1 | 10.58 ns |  1.898 ns | 0.104 ns | 10.61 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 5.0 | 10.62 ns |  0.302 ns | 0.017 ns | 10.61 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                                         From_DateTime | .NET Core 3.1 | 14.40 ns |  1.985 ns | 0.109 ns | 14.37 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                         From_DateTime | .NET Core 5.0 | 14.53 ns |  2.959 ns | 0.162 ns | 14.51 ns |  1.01 |    0.02 | 0.0038 |     - |     - |      24 B |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                                From_DateTime_AsObject | .NET Core 3.1 | 11.14 ns |  1.222 ns | 0.067 ns | 11.12 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 5.0 | 11.02 ns |  1.886 ns | 0.103 ns | 10.98 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                      From_DateTime_Nullable_WithValue | .NET Core 3.1 | 16.20 ns | 18.471 ns | 1.012 ns | 15.69 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                      From_DateTime_Nullable_WithValue | .NET Core 5.0 | 15.79 ns |  1.945 ns | 0.107 ns | 15.75 ns |  0.98 |    0.05 | 0.0038 |     - |     - |      24 B |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 3.1 | 11.75 ns |  1.291 ns | 0.071 ns | 11.72 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 5.0 | 10.75 ns |  2.427 ns | 0.133 ns | 10.82 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                        From_DateTime_Nullable_NoValue | .NET Core 3.1 | 12.92 ns |  2.804 ns | 0.154 ns | 12.84 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 5.0 | 12.36 ns |  7.352 ns | 0.403 ns | 12.14 ns |  0.96 |    0.04 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 3.1 | 11.34 ns |  4.000 ns | 0.219 ns | 11.23 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 5.0 | 10.91 ns |  1.936 ns | 0.106 ns | 10.96 ns |  0.96 |    0.02 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                                          From_Decimal | .NET Core 3.1 | 15.30 ns |  4.130 ns | 0.226 ns | 15.25 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
                                          From_Decimal | .NET Core 5.0 | 15.13 ns |  6.257 ns | 0.343 ns | 15.27 ns |  0.99 |    0.03 | 0.0051 |     - |     - |      32 B |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                                 From_Decimal_AsObject | .NET Core 3.1 | 11.94 ns |  1.033 ns | 0.057 ns | 11.97 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 5.0 | 11.04 ns |  6.772 ns | 0.371 ns | 11.25 ns |  0.92 |    0.03 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                       From_Decimal_Nullable_WithValue | .NET Core 3.1 | 16.30 ns |  8.089 ns | 0.443 ns | 16.07 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
                       From_Decimal_Nullable_WithValue | .NET Core 5.0 | 15.87 ns |  2.067 ns | 0.113 ns | 15.88 ns |  0.97 |    0.02 | 0.0051 |     - |     - |      32 B |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 3.1 | 10.71 ns |  2.249 ns | 0.123 ns | 10.75 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 5.0 | 10.94 ns |  2.426 ns | 0.133 ns | 10.93 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                         From_Decimal_Nullable_NoValue | .NET Core 3.1 | 12.30 ns |  2.007 ns | 0.110 ns | 12.29 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 5.0 | 12.17 ns |  1.296 ns | 0.071 ns | 12.19 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 3.1 | 10.45 ns |  0.358 ns | 0.020 ns | 10.46 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 5.0 | 10.91 ns |  5.496 ns | 0.301 ns | 10.81 ns |  1.04 |    0.03 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                                           From_Double | .NET Core 3.1 | 14.55 ns |  1.499 ns | 0.082 ns | 14.58 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                           From_Double | .NET Core 5.0 | 14.32 ns |  1.108 ns | 0.061 ns | 14.30 ns |  0.98 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                                  From_Double_AsObject | .NET Core 3.1 | 11.18 ns |  2.359 ns | 0.129 ns | 11.22 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 5.0 | 10.99 ns |  2.850 ns | 0.156 ns | 10.94 ns |  0.98 |    0.02 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                        From_Double_Nullable_WithValue | .NET Core 3.1 | 15.03 ns |  1.731 ns | 0.095 ns | 15.09 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                        From_Double_Nullable_WithValue | .NET Core 5.0 | 15.94 ns |  2.288 ns | 0.125 ns | 16.00 ns |  1.06 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
               From_Double_Nullable_WithValue_AsObject | .NET Core 3.1 | 11.84 ns |  1.962 ns | 0.108 ns | 11.83 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 5.0 | 10.59 ns |  0.495 ns | 0.027 ns | 10.60 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                          From_Double_Nullable_NoValue | .NET Core 3.1 | 12.27 ns |  2.530 ns | 0.139 ns | 12.23 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 5.0 | 12.28 ns |  1.661 ns | 0.091 ns | 12.29 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 3.1 | 11.09 ns |  0.674 ns | 0.037 ns | 11.11 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 5.0 | 11.25 ns |  6.078 ns | 0.333 ns | 11.19 ns |  1.01 |    0.03 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                                            From_Short | .NET Core 3.1 | 13.45 ns |  5.098 ns | 0.279 ns | 13.39 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                            From_Short | .NET Core 5.0 | 14.11 ns |  0.824 ns | 0.045 ns | 14.08 ns |  1.05 |    0.02 | 0.0038 |     - |     - |      24 B |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                                   From_Short_AsObject | .NET Core 3.1 | 11.85 ns |  2.171 ns | 0.119 ns | 11.91 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 5.0 | 11.32 ns |  4.073 ns | 0.223 ns | 11.27 ns |  0.96 |    0.03 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                         From_Short_Nullable_WithValue | .NET Core 3.1 | 15.41 ns |  2.307 ns | 0.126 ns | 15.40 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                         From_Short_Nullable_WithValue | .NET Core 5.0 | 15.47 ns |  0.669 ns | 0.037 ns | 15.45 ns |  1.00 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                From_Short_Nullable_WithValue_AsObject | .NET Core 3.1 | 10.53 ns |  2.210 ns | 0.121 ns | 10.46 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 5.0 | 10.71 ns |  0.723 ns | 0.040 ns | 10.70 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                           From_Short_Nullable_NoValue | .NET Core 3.1 | 13.01 ns |  1.413 ns | 0.077 ns | 12.99 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 5.0 | 12.15 ns | 10.366 ns | 0.568 ns | 11.93 ns |  0.93 |    0.05 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 3.1 | 10.45 ns |  0.523 ns | 0.029 ns | 10.44 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 5.0 | 10.78 ns |  1.240 ns | 0.068 ns | 10.80 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                                              From_Int | .NET Core 3.1 | 13.34 ns |  0.314 ns | 0.017 ns | 13.33 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                              From_Int | .NET Core 5.0 | 14.24 ns |  1.006 ns | 0.055 ns | 14.25 ns |  1.07 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                                     From_Int_AsObject | .NET Core 3.1 | 11.18 ns |  2.525 ns | 0.138 ns | 11.23 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 5.0 | 11.09 ns |  6.429 ns | 0.352 ns | 11.01 ns |  0.99 |    0.03 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                           From_Int_Nullable_WithValue | .NET Core 3.1 | 15.21 ns |  0.562 ns | 0.031 ns | 15.21 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                           From_Int_Nullable_WithValue | .NET Core 5.0 | 15.36 ns |  3.520 ns | 0.193 ns | 15.46 ns |  1.01 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 3.1 | 10.59 ns |  3.947 ns | 0.216 ns | 10.47 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 5.0 | 10.71 ns |  2.822 ns | 0.155 ns | 10.64 ns |  1.01 |    0.03 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                             From_Int_Nullable_NoValue | .NET Core 3.1 | 10.68 ns |  0.244 ns | 0.013 ns | 10.68 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 5.0 | 11.56 ns |  2.937 ns | 0.161 ns | 11.48 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 3.1 | 10.49 ns |  0.275 ns | 0.015 ns | 10.49 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 5.0 | 10.69 ns |  2.334 ns | 0.128 ns | 10.62 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                                             From_Long | .NET Core 3.1 | 13.68 ns |  2.524 ns | 0.138 ns | 13.62 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                             From_Long | .NET Core 5.0 | 14.06 ns |  2.512 ns | 0.138 ns | 14.02 ns |  1.03 |    0.02 | 0.0038 |     - |     - |      24 B |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                                    From_Long_AsObject | .NET Core 3.1 | 10.56 ns |  2.489 ns | 0.136 ns | 10.54 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 5.0 | 10.71 ns |  1.416 ns | 0.078 ns | 10.68 ns |  1.01 |    0.02 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                          From_Long_Nullable_WithValue | .NET Core 3.1 | 14.59 ns |  2.050 ns | 0.112 ns | 14.62 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                          From_Long_Nullable_WithValue | .NET Core 5.0 | 15.73 ns |  0.930 ns | 0.051 ns | 15.72 ns |  1.08 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 3.1 | 11.08 ns |  0.287 ns | 0.016 ns | 11.08 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 5.0 | 11.21 ns |  2.532 ns | 0.139 ns | 11.28 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                            From_Long_Nullable_NoValue | .NET Core 3.1 | 11.49 ns |  2.350 ns | 0.129 ns | 11.55 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 5.0 | 12.05 ns |  0.309 ns | 0.017 ns | 12.06 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 3.1 | 11.21 ns |  0.085 ns | 0.005 ns | 11.21 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 5.0 | 10.82 ns |  1.559 ns | 0.085 ns | 10.85 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                                            From_SByte | .NET Core 3.1 | 13.68 ns |  1.689 ns | 0.093 ns | 13.64 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                            From_SByte | .NET Core 5.0 | 14.07 ns |  0.852 ns | 0.047 ns | 14.05 ns |  1.03 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                                   From_SByte_AsObject | .NET Core 3.1 | 10.44 ns |  0.102 ns | 0.006 ns | 10.44 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 5.0 | 10.97 ns |  1.734 ns | 0.095 ns | 10.99 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                         From_SByte_Nullable_WithValue | .NET Core 3.1 | 14.51 ns |  1.969 ns | 0.108 ns | 14.49 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                         From_SByte_Nullable_WithValue | .NET Core 5.0 | 15.65 ns |  0.827 ns | 0.045 ns | 15.63 ns |  1.08 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 3.1 | 10.67 ns |  4.236 ns | 0.232 ns | 10.74 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 5.0 | 11.31 ns |  5.580 ns | 0.306 ns | 11.34 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                           From_SByte_Nullable_NoValue | .NET Core 3.1 | 11.43 ns |  1.022 ns | 0.056 ns | 11.42 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 5.0 | 11.49 ns |  0.479 ns | 0.026 ns | 11.48 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 3.1 | 11.23 ns |  5.728 ns | 0.314 ns | 11.06 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 5.0 | 10.92 ns |  1.144 ns | 0.063 ns | 10.95 ns |  0.97 |    0.02 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                                            From_Float | .NET Core 3.1 | 13.56 ns |  0.266 ns | 0.015 ns | 13.57 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                            From_Float | .NET Core 5.0 | 14.28 ns |  1.016 ns | 0.056 ns | 14.29 ns |  1.05 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                                   From_Float_AsObject | .NET Core 3.1 | 10.80 ns |  0.863 ns | 0.047 ns | 10.78 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 5.0 | 10.73 ns |  1.519 ns | 0.083 ns | 10.78 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                         From_Float_Nullable_WithValue | .NET Core 3.1 | 13.68 ns |  1.146 ns | 0.063 ns | 13.68 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                         From_Float_Nullable_WithValue | .NET Core 5.0 | 15.21 ns |  2.052 ns | 0.112 ns | 15.27 ns |  1.11 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                From_Float_Nullable_WithValue_AsObject | .NET Core 3.1 | 11.53 ns |  1.452 ns | 0.080 ns | 11.50 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 5.0 | 10.63 ns |  0.426 ns | 0.023 ns | 10.64 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                           From_Float_Nullable_NoValue | .NET Core 3.1 | 12.93 ns |  1.703 ns | 0.093 ns | 12.93 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 5.0 | 11.74 ns |  1.024 ns | 0.056 ns | 11.71 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 3.1 | 10.52 ns |  0.618 ns | 0.034 ns | 10.52 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 5.0 | 10.76 ns |  3.143 ns | 0.172 ns | 10.74 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                                           From_String | .NET Core 3.1 | 12.16 ns |  8.863 ns | 0.486 ns | 11.89 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 5.0 | 10.74 ns |  1.480 ns | 0.081 ns | 10.73 ns |  0.88 |    0.04 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                                  From_String_AsObject | .NET Core 3.1 | 10.71 ns |  1.563 ns | 0.086 ns | 10.68 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 5.0 | 11.15 ns |  2.154 ns | 0.118 ns | 11.20 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                                      From_String_Null | .NET Core 3.1 | 11.10 ns |  0.797 ns | 0.044 ns | 11.08 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 5.0 | 10.62 ns |  0.269 ns | 0.015 ns | 10.62 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                             From_String_Null_AsObject | .NET Core 3.1 | 10.45 ns |  0.318 ns | 0.017 ns | 10.45 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 5.0 | 10.68 ns |  1.336 ns | 0.073 ns | 10.64 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                                     From_String_Empty | .NET Core 3.1 | 11.08 ns |  0.158 ns | 0.009 ns | 11.08 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 5.0 | 10.63 ns |  1.923 ns | 0.105 ns | 10.62 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                            From_String_Empty_AsObject | .NET Core 3.1 | 10.50 ns |  0.912 ns | 0.050 ns | 10.48 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 5.0 | 10.85 ns |  0.781 ns | 0.043 ns | 10.85 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                                           From_UShort | .NET Core 3.1 | 15.31 ns |  4.346 ns | 0.238 ns | 15.30 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                           From_UShort | .NET Core 5.0 | 13.95 ns |  0.423 ns | 0.023 ns | 13.94 ns |  0.91 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                                  From_UShort_AsObject | .NET Core 3.1 | 11.81 ns |  1.752 ns | 0.096 ns | 11.77 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 5.0 | 10.62 ns |  1.464 ns | 0.080 ns | 10.59 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                        From_UShort_Nullable_WithValue | .NET Core 3.1 | 13.65 ns |  0.230 ns | 0.013 ns | 13.64 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                        From_UShort_Nullable_WithValue | .NET Core 5.0 | 15.34 ns |  3.073 ns | 0.168 ns | 15.33 ns |  1.12 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 3.1 | 10.59 ns |  2.626 ns | 0.144 ns | 10.61 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 5.0 | 10.70 ns |  2.240 ns | 0.123 ns | 10.69 ns |  1.01 |    0.02 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                          From_UShort_Nullable_NoValue | .NET Core 3.1 | 10.90 ns |  0.617 ns | 0.034 ns | 10.89 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 5.0 | 11.94 ns |  2.360 ns | 0.129 ns | 11.88 ns |  1.10 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 3.1 | 11.79 ns |  1.794 ns | 0.098 ns | 11.80 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 5.0 | 10.77 ns |  2.954 ns | 0.162 ns | 10.73 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                                             From_UInt | .NET Core 3.1 | 14.40 ns |  2.400 ns | 0.132 ns | 14.37 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                             From_UInt | .NET Core 5.0 | 14.23 ns |  0.860 ns | 0.047 ns | 14.26 ns |  0.99 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                                    From_UInt_AsObject | .NET Core 3.1 | 10.51 ns |  2.022 ns | 0.111 ns | 10.45 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 5.0 | 10.94 ns |  3.753 ns | 0.206 ns | 10.96 ns |  1.04 |    0.03 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                          From_UInt_Nullable_WithValue | .NET Core 3.1 | 14.49 ns |  3.607 ns | 0.198 ns | 14.43 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                          From_UInt_Nullable_WithValue | .NET Core 5.0 | 15.99 ns |  0.754 ns | 0.041 ns | 15.99 ns |  1.10 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 3.1 | 11.19 ns |  1.031 ns | 0.057 ns | 11.17 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 5.0 | 11.59 ns |  1.712 ns | 0.094 ns | 11.62 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                            From_UInt_Nullable_NoValue | .NET Core 3.1 | 10.75 ns |  2.436 ns | 0.134 ns | 10.68 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 5.0 | 11.52 ns |  1.954 ns | 0.107 ns | 11.49 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 3.1 | 12.56 ns |  0.731 ns | 0.040 ns | 12.56 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 5.0 | 11.35 ns | 11.046 ns | 0.605 ns | 11.12 ns |  0.90 |    0.05 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                                            From_ULong | .NET Core 3.1 | 13.53 ns |  1.753 ns | 0.096 ns | 13.58 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                            From_ULong | .NET Core 5.0 | 14.08 ns |  0.979 ns | 0.054 ns | 14.05 ns |  1.04 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                                   From_ULong_AsObject | .NET Core 3.1 | 12.95 ns |  0.284 ns | 0.016 ns | 12.95 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 5.0 | 10.85 ns |  2.086 ns | 0.114 ns | 10.81 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                         From_ULong_Nullable_WithValue | .NET Core 3.1 | 13.96 ns |  2.739 ns | 0.150 ns | 13.89 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                         From_ULong_Nullable_WithValue | .NET Core 5.0 | 15.91 ns |  0.323 ns | 0.018 ns | 15.91 ns |  1.14 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 3.1 | 10.59 ns |  1.631 ns | 0.089 ns | 10.63 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 5.0 | 10.68 ns |  1.858 ns | 0.102 ns | 10.62 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                           From_ULong_Nullable_NoValue | .NET Core 3.1 | 11.35 ns |  0.383 ns | 0.021 ns | 11.36 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 5.0 | 12.24 ns |  0.464 ns | 0.025 ns | 12.24 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 3.1 | 10.61 ns |  3.254 ns | 0.178 ns | 10.63 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 5.0 | 10.74 ns |  2.593 ns | 0.142 ns | 10.80 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                                       From_NullObject | .NET Core 3.1 | 11.16 ns |  2.142 ns | 0.117 ns | 11.20 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 5.0 | 11.28 ns |  4.995 ns | 0.274 ns | 11.29 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                                           From_DBNull | .NET Core 3.1 | 11.26 ns |  3.813 ns | 0.209 ns | 11.15 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 5.0 | 10.55 ns |  3.055 ns | 0.167 ns | 10.46 ns |  0.94 |    0.03 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                                  From_DBNull_AsObject | .NET Core 3.1 | 11.72 ns |  0.257 ns | 0.014 ns | 11.72 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 5.0 | 10.70 ns |  1.928 ns | 0.106 ns | 10.68 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                                 From_ConvertibleClass | .NET Core 3.1 | 10.52 ns |  1.888 ns | 0.104 ns | 10.49 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 5.0 | 10.65 ns |  2.290 ns | 0.126 ns | 10.60 ns |  1.01 |    0.02 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                        From_ConvertibleClass_AsObject | .NET Core 3.1 | 11.76 ns |  1.965 ns | 0.108 ns | 11.72 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 5.0 | 10.61 ns |  1.133 ns | 0.062 ns | 10.58 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                         From_ConvertibleClass_NoValue | .NET Core 3.1 | 12.51 ns |  0.642 ns | 0.035 ns | 12.49 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 5.0 | 10.62 ns |  2.267 ns | 0.124 ns | 10.56 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 3.1 | 10.45 ns |  0.852 ns | 0.047 ns | 10.42 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 5.0 | 10.69 ns |  4.684 ns | 0.257 ns | 10.60 ns |  1.02 |    0.03 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                              From_NonConvertibleClass | .NET Core 3.1 | 10.41 ns |  0.211 ns | 0.012 ns | 10.41 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 5.0 | 11.65 ns |  2.036 ns | 0.112 ns | 11.59 ns |  1.12 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                     From_NonConvertibleClass_AsObject | .NET Core 3.1 | 11.08 ns |  0.134 ns | 0.007 ns | 11.07 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 5.0 | 10.69 ns |  1.613 ns | 0.088 ns | 10.66 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                      From_NonConvertibleClass_NoValue | .NET Core 3.1 | 11.77 ns |  1.951 ns | 0.107 ns | 11.72 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 5.0 | 10.73 ns |  3.868 ns | 0.212 ns | 10.69 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 3.1 | 10.61 ns |  1.221 ns | 0.067 ns | 10.61 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 5.0 | 10.77 ns |  0.738 ns | 0.040 ns | 10.77 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                                From_ConvertibleStruct | .NET Core 3.1 | 13.38 ns |  3.685 ns | 0.202 ns | 13.27 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 5.0 | 13.96 ns |  1.208 ns | 0.066 ns | 13.97 ns |  1.04 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                       From_ConvertibleStruct_AsObject | .NET Core 3.1 | 11.03 ns |  0.613 ns | 0.034 ns | 11.02 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 5.0 | 10.77 ns |  0.534 ns | 0.029 ns | 10.77 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 3.1 | 15.42 ns |  0.973 ns | 0.053 ns | 15.45 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 5.0 | 16.74 ns | 19.343 ns | 1.060 ns | 17.01 ns |  1.09 |    0.07 | 0.0038 |     - |     - |      24 B |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.1 | 12.41 ns |  1.702 ns | 0.093 ns | 12.41 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 5.0 | 10.59 ns |  0.588 ns | 0.032 ns | 10.59 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 3.1 | 10.76 ns |  0.511 ns | 0.028 ns | 10.75 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 5.0 | 11.98 ns |  5.739 ns | 0.315 ns | 12.12 ns |  1.11 |    0.03 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.1 | 10.59 ns |  3.379 ns | 0.185 ns | 10.49 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 5.0 | 11.05 ns |  4.999 ns | 0.274 ns | 11.05 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                             From_NonConvertibleStruct | .NET Core 3.1 | 14.23 ns |  1.920 ns | 0.105 ns | 14.27 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                             From_NonConvertibleStruct | .NET Core 5.0 | 14.22 ns |  0.042 ns | 0.002 ns | 14.22 ns |  1.00 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                    From_NonConvertibleStruct_AsObject | .NET Core 3.1 | 12.56 ns |  0.763 ns | 0.042 ns | 12.55 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 5.0 | 10.73 ns |  0.928 ns | 0.051 ns | 10.71 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 3.1 | 13.49 ns |  0.583 ns | 0.032 ns | 13.51 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 5.0 | 15.24 ns |  1.181 ns | 0.065 ns | 15.21 ns |  1.13 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.1 | 10.47 ns |  0.169 ns | 0.009 ns | 10.47 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 5.0 | 11.47 ns |  7.991 ns | 0.438 ns | 11.25 ns |  1.10 |    0.04 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 3.1 | 10.71 ns |  0.930 ns | 0.051 ns | 10.69 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 5.0 | 12.28 ns |  0.957 ns | 0.052 ns | 12.29 ns |  1.15 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.1 | 10.48 ns |  1.303 ns | 0.071 ns | 10.45 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 5.0 | 10.62 ns |  1.630 ns | 0.089 ns | 10.56 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                                             From_Enum | .NET Core 3.1 | 13.34 ns |  4.514 ns | 0.247 ns | 13.21 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                             From_Enum | .NET Core 5.0 | 14.09 ns |  0.748 ns | 0.041 ns | 14.07 ns |  1.06 |    0.02 | 0.0038 |     - |     - |      24 B |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                                    From_Enum_AsObject | .NET Core 3.1 | 11.36 ns |  1.806 ns | 0.099 ns | 11.31 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Enum_AsObject | .NET Core 5.0 | 11.05 ns |  1.272 ns | 0.070 ns | 11.03 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                          From_Enum_Nullable_WithValue | .NET Core 3.1 | 13.61 ns |  1.293 ns | 0.071 ns | 13.64 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                          From_Enum_Nullable_WithValue | .NET Core 5.0 | 15.88 ns |  1.194 ns | 0.065 ns | 15.84 ns |  1.17 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 3.1 | 10.43 ns |  1.882 ns | 0.103 ns | 10.38 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 5.0 | 10.76 ns |  0.690 ns | 0.038 ns | 10.77 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                            From_Enum_Nullable_NoValue | .NET Core 3.1 | 11.49 ns |  0.468 ns | 0.026 ns | 11.49 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 5.0 | 11.90 ns |  2.257 ns | 0.124 ns | 11.84 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 3.1 | 10.47 ns |  0.359 ns | 0.020 ns | 10.46 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 5.0 | 11.13 ns |  2.158 ns | 0.118 ns | 11.07 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                                      From_ParentClass | .NET Core 3.1 | 11.15 ns |  3.773 ns | 0.207 ns | 11.03 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 5.0 | 11.25 ns |  2.063 ns | 0.113 ns | 11.19 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                             From_ParentClass_AsObject | .NET Core 3.1 | 10.78 ns |  4.549 ns | 0.249 ns | 10.90 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 5.0 | 10.91 ns |  2.358 ns | 0.129 ns | 10.84 ns |  1.01 |    0.04 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                              From_ParentClass_NoValue | .NET Core 3.1 | 11.78 ns |  0.645 ns | 0.035 ns | 11.76 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 5.0 | 10.55 ns |  1.040 ns | 0.057 ns | 10.57 ns |  0.90 |    0.00 |      - |     - |     - |         - |
