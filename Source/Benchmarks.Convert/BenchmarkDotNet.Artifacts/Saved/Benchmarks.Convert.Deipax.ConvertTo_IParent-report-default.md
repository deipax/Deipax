
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

                                                Method |     Toolchain |     Mean |     Error |   StdDev |   Median | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------------------------------------------ |-------------- |---------:|----------:|---------:|---------:|------:|--------:|-------:|------:|------:|----------:|
                     From_ParentClass_NoValue_AsObject | .NET Core 3.1 | 14.19 ns |  0.586 ns | 0.032 ns | 14.20 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 5.0 | 14.45 ns |  1.455 ns | 0.080 ns | 14.44 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                                     From_ParentStruct | .NET Core 3.1 | 76.94 ns | 17.648 ns | 0.967 ns | 77.37 ns |  1.00 |    0.00 | 0.0854 |     - |     - |     536 B |
                                     From_ParentStruct | .NET Core 5.0 | 72.55 ns | 11.797 ns | 0.647 ns | 72.23 ns |  0.94 |    0.01 | 0.0854 |     - |     - |     536 B |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                            From_ParentStruct_AsObject | .NET Core 3.1 | 16.26 ns |  4.616 ns | 0.253 ns | 16.25 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 5.0 | 17.68 ns |  1.741 ns | 0.095 ns | 17.66 ns |  1.09 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                  From_ParentStruct_Nullable_WithValue | .NET Core 3.1 | 77.68 ns | 17.005 ns | 0.932 ns | 77.16 ns |  1.00 |    0.00 | 0.0854 |     - |     - |     536 B |
                  From_ParentStruct_Nullable_WithValue | .NET Core 5.0 | 74.54 ns |  1.671 ns | 0.092 ns | 74.49 ns |  0.96 |    0.01 | 0.0854 |     - |     - |     536 B |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 3.1 | 17.45 ns |  0.680 ns | 0.037 ns | 17.45 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 5.0 | 17.53 ns |  0.725 ns | 0.040 ns | 17.52 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                    From_ParentStruct_Nullable_NoValue | .NET Core 3.1 | 40.11 ns | 10.555 ns | 0.579 ns | 39.87 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 5.0 | 36.15 ns |  2.844 ns | 0.156 ns | 36.12 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 3.1 | 14.13 ns |  4.587 ns | 0.251 ns | 14.00 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 5.0 | 13.79 ns |  1.757 ns | 0.096 ns | 13.81 ns |  0.98 |    0.02 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                                             From_Bool | .NET Core 3.1 | 10.55 ns |  1.029 ns | 0.056 ns | 10.57 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 5.0 | 10.72 ns |  1.331 ns | 0.073 ns | 10.72 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                                    From_Bool_AsObject | .NET Core 3.1 | 20.22 ns | 16.853 ns | 0.924 ns | 20.09 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 5.0 | 18.39 ns |  1.914 ns | 0.105 ns | 18.36 ns |  0.91 |    0.04 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                          From_Bool_Nullable_WithValue | .NET Core 3.1 | 10.41 ns |  0.457 ns | 0.025 ns | 10.40 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 5.0 | 11.64 ns |  1.603 ns | 0.088 ns | 11.69 ns |  1.12 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 3.1 | 18.90 ns |  6.142 ns | 0.337 ns | 18.75 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 5.0 | 19.06 ns |  1.637 ns | 0.090 ns | 19.11 ns |  1.01 |    0.02 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                            From_Bool_Nullable_NoValue | .NET Core 3.1 | 11.62 ns |  0.820 ns | 0.045 ns | 11.61 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 5.0 | 10.70 ns |  0.819 ns | 0.045 ns | 10.72 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 3.1 | 13.35 ns |  1.615 ns | 0.089 ns | 13.31 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 5.0 | 13.74 ns |  2.136 ns | 0.117 ns | 13.75 ns |  1.03 |    0.02 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                                             From_Byte | .NET Core 3.1 | 12.44 ns |  3.097 ns | 0.170 ns | 12.37 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 5.0 | 10.73 ns |  2.726 ns | 0.149 ns | 10.68 ns |  0.86 |    0.02 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                                    From_Byte_AsObject | .NET Core 3.1 | 18.60 ns |  2.050 ns | 0.112 ns | 18.61 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 5.0 | 18.97 ns |  2.906 ns | 0.159 ns | 18.91 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                          From_Byte_Nullable_WithValue | .NET Core 3.1 | 11.18 ns |  1.340 ns | 0.073 ns | 11.20 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 5.0 | 10.71 ns |  1.905 ns | 0.104 ns | 10.67 ns |  0.96 |    0.02 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 3.1 | 22.31 ns |  1.941 ns | 0.106 ns | 22.27 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 5.0 | 20.00 ns |  2.398 ns | 0.131 ns | 20.05 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                            From_Byte_Nullable_NoValue | .NET Core 3.1 | 11.80 ns |  1.908 ns | 0.105 ns | 11.75 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 5.0 | 10.78 ns |  1.655 ns | 0.091 ns | 10.80 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 3.1 | 13.36 ns |  2.463 ns | 0.135 ns | 13.29 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 5.0 | 13.70 ns |  0.263 ns | 0.014 ns | 13.70 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                                             From_Char | .NET Core 3.1 | 10.50 ns |  2.435 ns | 0.133 ns | 10.43 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Char | .NET Core 5.0 | 10.78 ns |  2.671 ns | 0.146 ns | 10.80 ns |  1.03 |    0.03 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                                    From_Char_AsObject | .NET Core 3.1 | 17.57 ns |  0.305 ns | 0.017 ns | 17.58 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 5.0 | 18.87 ns |  2.842 ns | 0.156 ns | 18.88 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                          From_Char_Nullable_WithValue | .NET Core 3.1 | 10.83 ns |  3.485 ns | 0.191 ns | 10.72 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 5.0 | 10.90 ns |  0.182 ns | 0.010 ns | 10.90 ns |  1.01 |    0.02 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 3.1 | 18.01 ns |  5.351 ns | 0.293 ns | 17.99 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 5.0 | 19.99 ns | 10.348 ns | 0.567 ns | 20.13 ns |  1.11 |    0.03 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                            From_Char_Nullable_NoValue | .NET Core 3.1 | 10.36 ns |  0.949 ns | 0.052 ns | 10.35 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 5.0 | 11.65 ns |  0.638 ns | 0.035 ns | 11.67 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 3.1 | 13.29 ns |  0.278 ns | 0.015 ns | 13.29 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 5.0 | 13.75 ns |  1.577 ns | 0.086 ns | 13.74 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                                         From_DateTime | .NET Core 3.1 | 10.81 ns |  2.267 ns | 0.124 ns | 10.78 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 5.0 | 12.32 ns |  0.433 ns | 0.024 ns | 12.33 ns |  1.14 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                                From_DateTime_AsObject | .NET Core 3.1 | 21.01 ns |  0.547 ns | 0.030 ns | 21.01 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 5.0 | 19.27 ns |  3.333 ns | 0.183 ns | 19.34 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                      From_DateTime_Nullable_WithValue | .NET Core 3.1 | 10.99 ns |  0.827 ns | 0.045 ns | 10.97 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 5.0 | 11.08 ns |  2.728 ns | 0.150 ns | 11.07 ns |  1.01 |    0.02 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 3.1 | 21.70 ns |  2.999 ns | 0.164 ns | 21.63 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 5.0 | 19.09 ns |  0.805 ns | 0.044 ns | 19.09 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                        From_DateTime_Nullable_NoValue | .NET Core 3.1 | 13.40 ns |  9.725 ns | 0.533 ns | 13.33 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 5.0 | 11.28 ns | 11.120 ns | 0.610 ns | 10.99 ns |  0.84 |    0.06 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 3.1 | 13.91 ns |  4.063 ns | 0.223 ns | 13.79 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 5.0 | 13.72 ns |  1.384 ns | 0.076 ns | 13.71 ns |  0.99 |    0.02 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                                          From_Decimal | .NET Core 3.1 | 11.18 ns |  3.260 ns | 0.179 ns | 11.11 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 5.0 | 11.42 ns |  0.099 ns | 0.005 ns | 11.41 ns |  1.02 |    0.02 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                                 From_Decimal_AsObject | .NET Core 3.1 | 17.96 ns |  0.317 ns | 0.017 ns | 17.97 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 5.0 | 19.22 ns |  2.814 ns | 0.154 ns | 19.14 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                       From_Decimal_Nullable_WithValue | .NET Core 3.1 | 12.30 ns |  3.229 ns | 0.177 ns | 12.22 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 5.0 | 11.42 ns |  4.350 ns | 0.238 ns | 11.34 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 3.1 | 18.44 ns |  6.388 ns | 0.350 ns | 18.25 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 5.0 | 19.13 ns |  0.434 ns | 0.024 ns | 19.14 ns |  1.04 |    0.02 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                         From_Decimal_Nullable_NoValue | .NET Core 3.1 | 11.63 ns |  0.565 ns | 0.031 ns | 11.64 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 5.0 | 11.35 ns |  0.437 ns | 0.024 ns | 11.35 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 3.1 | 14.41 ns |  6.775 ns | 0.371 ns | 14.32 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 5.0 | 13.99 ns |  7.505 ns | 0.411 ns | 13.92 ns |  0.97 |    0.05 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                                           From_Double | .NET Core 3.1 | 10.71 ns |  2.360 ns | 0.129 ns | 10.66 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 5.0 | 10.82 ns |  0.848 ns | 0.046 ns | 10.80 ns |  1.01 |    0.02 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                                  From_Double_AsObject | .NET Core 3.1 | 18.18 ns |  4.588 ns | 0.251 ns | 18.20 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 5.0 | 18.55 ns |  0.789 ns | 0.043 ns | 18.53 ns |  1.02 |    0.02 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                        From_Double_Nullable_WithValue | .NET Core 3.1 | 12.20 ns |  0.541 ns | 0.030 ns | 12.21 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 5.0 | 11.48 ns |  1.499 ns | 0.082 ns | 11.46 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
               From_Double_Nullable_WithValue_AsObject | .NET Core 3.1 | 18.81 ns |  0.162 ns | 0.009 ns | 18.81 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 5.0 | 19.71 ns |  2.901 ns | 0.159 ns | 19.66 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                          From_Double_Nullable_NoValue | .NET Core 3.1 | 10.88 ns |  0.124 ns | 0.007 ns | 10.89 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 5.0 | 11.89 ns |  0.517 ns | 0.028 ns | 11.90 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 3.1 | 12.68 ns |  4.352 ns | 0.239 ns | 12.71 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 5.0 | 13.90 ns |  4.238 ns | 0.232 ns | 13.78 ns |  1.10 |    0.04 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                                            From_Short | .NET Core 3.1 | 11.99 ns |  1.946 ns | 0.107 ns | 12.05 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 5.0 | 12.08 ns | 14.830 ns | 0.813 ns | 11.65 ns |  1.01 |    0.08 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                                   From_Short_AsObject | .NET Core 3.1 | 18.89 ns |  0.820 ns | 0.045 ns | 18.88 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 5.0 | 18.82 ns |  4.000 ns | 0.219 ns | 18.83 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                         From_Short_Nullable_WithValue | .NET Core 3.1 | 11.07 ns |  1.626 ns | 0.089 ns | 11.03 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 5.0 | 10.71 ns |  1.000 ns | 0.055 ns | 10.72 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                From_Short_Nullable_WithValue_AsObject | .NET Core 3.1 | 20.26 ns |  3.004 ns | 0.165 ns | 20.20 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 5.0 | 19.61 ns |  1.783 ns | 0.098 ns | 19.57 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                           From_Short_Nullable_NoValue | .NET Core 3.1 | 11.10 ns |  1.713 ns | 0.094 ns | 11.11 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 5.0 | 10.78 ns |  1.008 ns | 0.055 ns | 10.81 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 3.1 | 11.99 ns |  3.999 ns | 0.219 ns | 11.89 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 5.0 | 14.47 ns |  1.078 ns | 0.059 ns | 14.45 ns |  1.21 |    0.02 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                                              From_Int | .NET Core 3.1 | 10.47 ns |  0.891 ns | 0.049 ns | 10.45 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 5.0 | 10.69 ns |  1.505 ns | 0.082 ns | 10.73 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                                     From_Int_AsObject | .NET Core 3.1 | 19.01 ns |  3.054 ns | 0.167 ns | 18.94 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 5.0 | 18.82 ns |  2.091 ns | 0.115 ns | 18.76 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                           From_Int_Nullable_WithValue | .NET Core 3.1 | 11.12 ns |  1.533 ns | 0.084 ns | 11.08 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 5.0 | 12.11 ns |  1.164 ns | 0.064 ns | 12.08 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 3.1 | 20.38 ns |  0.989 ns | 0.054 ns | 20.35 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 5.0 | 18.69 ns |  3.049 ns | 0.167 ns | 18.66 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                             From_Int_Nullable_NoValue | .NET Core 3.1 | 10.40 ns |  0.745 ns | 0.041 ns | 10.37 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 5.0 | 11.09 ns |  8.853 ns | 0.485 ns | 10.87 ns |  1.07 |    0.04 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 3.1 | 12.55 ns |  2.211 ns | 0.121 ns | 12.49 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 5.0 | 13.66 ns |  0.885 ns | 0.048 ns | 13.64 ns |  1.09 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                                             From_Long | .NET Core 3.1 | 10.93 ns |  1.913 ns | 0.105 ns | 10.90 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Long | .NET Core 5.0 | 11.70 ns |  2.768 ns | 0.152 ns | 11.62 ns |  1.07 |    0.02 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                                    From_Long_AsObject | .NET Core 3.1 | 17.41 ns |  6.530 ns | 0.358 ns | 17.31 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 5.0 | 18.92 ns |  2.242 ns | 0.123 ns | 18.91 ns |  1.09 |    0.02 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                          From_Long_Nullable_WithValue | .NET Core 3.1 | 11.63 ns |  2.860 ns | 0.157 ns | 11.54 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 5.0 | 10.83 ns |  0.847 ns | 0.046 ns | 10.81 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 3.1 | 18.00 ns |  3.024 ns | 0.166 ns | 17.90 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 5.0 | 19.14 ns |  1.327 ns | 0.073 ns | 19.13 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                            From_Long_Nullable_NoValue | .NET Core 3.1 | 11.11 ns |  3.984 ns | 0.218 ns | 11.21 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 5.0 | 11.02 ns |  2.338 ns | 0.128 ns | 11.02 ns |  0.99 |    0.02 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 3.1 | 13.30 ns |  1.637 ns | 0.090 ns | 13.28 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 5.0 | 13.73 ns |  1.703 ns | 0.093 ns | 13.70 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                                            From_SByte | .NET Core 3.1 | 10.50 ns |  1.590 ns | 0.087 ns | 10.50 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 5.0 | 10.65 ns |  0.557 ns | 0.031 ns | 10.66 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                                   From_SByte_AsObject | .NET Core 3.1 | 17.45 ns |  2.499 ns | 0.137 ns | 17.42 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 5.0 | 18.79 ns |  3.719 ns | 0.204 ns | 18.78 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                         From_SByte_Nullable_WithValue | .NET Core 3.1 | 11.80 ns |  0.218 ns | 0.012 ns | 11.79 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 5.0 | 10.96 ns |  0.735 ns | 0.040 ns | 10.94 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 3.1 | 18.10 ns |  2.540 ns | 0.139 ns | 18.16 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 5.0 | 18.60 ns |  0.063 ns | 0.003 ns | 18.60 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                           From_SByte_Nullable_NoValue | .NET Core 3.1 | 11.12 ns |  3.023 ns | 0.166 ns | 11.03 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 5.0 | 10.74 ns |  1.627 ns | 0.089 ns | 10.71 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 3.1 | 13.51 ns |  4.146 ns | 0.227 ns | 13.50 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 5.0 | 13.68 ns |  0.515 ns | 0.028 ns | 13.66 ns |  1.01 |    0.02 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                                            From_Float | .NET Core 3.1 | 10.58 ns |  1.511 ns | 0.083 ns | 10.54 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 5.0 | 10.93 ns |  0.393 ns | 0.022 ns | 10.94 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                                   From_Float_AsObject | .NET Core 3.1 | 16.58 ns |  0.340 ns | 0.019 ns | 16.58 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 5.0 | 18.56 ns |  0.053 ns | 0.003 ns | 18.56 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                         From_Float_Nullable_WithValue | .NET Core 3.1 | 11.85 ns |  0.515 ns | 0.028 ns | 11.84 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 5.0 | 11.20 ns |  0.487 ns | 0.027 ns | 11.19 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                From_Float_Nullable_WithValue_AsObject | .NET Core 3.1 | 18.04 ns |  4.869 ns | 0.267 ns | 18.09 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 5.0 | 18.99 ns |  5.845 ns | 0.320 ns | 18.97 ns |  1.05 |    0.02 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                           From_Float_Nullable_NoValue | .NET Core 3.1 | 12.08 ns |  1.881 ns | 0.103 ns | 12.03 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 5.0 | 10.85 ns |  3.285 ns | 0.180 ns | 10.81 ns |  0.90 |    0.02 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 3.1 | 12.55 ns |  2.495 ns | 0.137 ns | 12.51 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 5.0 | 13.66 ns |  0.446 ns | 0.024 ns | 13.66 ns |  1.09 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                                           From_String | .NET Core 3.1 | 10.77 ns |  1.436 ns | 0.079 ns | 10.75 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 5.0 | 10.69 ns |  3.660 ns | 0.201 ns | 10.58 ns |  0.99 |    0.02 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                                  From_String_AsObject | .NET Core 3.1 | 18.19 ns |  3.723 ns | 0.204 ns | 18.25 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 5.0 | 19.24 ns |  0.424 ns | 0.023 ns | 19.23 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                                      From_String_Null | .NET Core 3.1 | 12.77 ns |  0.625 ns | 0.034 ns | 12.76 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 5.0 | 11.25 ns |  9.078 ns | 0.498 ns | 11.51 ns |  0.88 |    0.04 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                             From_String_Null_AsObject | .NET Core 3.1 | 13.49 ns |  3.957 ns | 0.217 ns | 13.49 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 5.0 | 13.76 ns |  0.498 ns | 0.027 ns | 13.77 ns |  1.02 |    0.02 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                                     From_String_Empty | .NET Core 3.1 | 10.49 ns |  1.267 ns | 0.069 ns | 10.45 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 5.0 | 10.78 ns |  0.619 ns | 0.034 ns | 10.76 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                            From_String_Empty_AsObject | .NET Core 3.1 | 16.95 ns |  0.332 ns | 0.018 ns | 16.96 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 5.0 | 19.43 ns |  1.324 ns | 0.073 ns | 19.43 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                                           From_UShort | .NET Core 3.1 | 12.01 ns |  0.725 ns | 0.040 ns | 12.03 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 5.0 | 10.71 ns |  0.360 ns | 0.020 ns | 10.72 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                                  From_UShort_AsObject | .NET Core 3.1 | 17.10 ns |  5.628 ns | 0.308 ns | 17.24 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 5.0 | 18.61 ns |  1.486 ns | 0.081 ns | 18.62 ns |  1.09 |    0.02 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                        From_UShort_Nullable_WithValue | .NET Core 3.1 | 10.35 ns |  0.491 ns | 0.027 ns | 10.37 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 5.0 | 10.65 ns |  0.473 ns | 0.026 ns | 10.64 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 3.1 | 21.38 ns |  0.209 ns | 0.011 ns | 21.38 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 5.0 | 18.62 ns |  0.322 ns | 0.018 ns | 18.63 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                          From_UShort_Nullable_NoValue | .NET Core 3.1 | 12.35 ns |  2.842 ns | 0.156 ns | 12.27 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 5.0 | 11.51 ns |  1.403 ns | 0.077 ns | 11.54 ns |  0.93 |    0.02 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 3.1 | 14.11 ns |  0.426 ns | 0.023 ns | 14.10 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 5.0 | 13.70 ns |  0.295 ns | 0.016 ns | 13.70 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                                             From_UInt | .NET Core 3.1 | 10.51 ns |  0.480 ns | 0.026 ns | 10.51 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 5.0 | 10.77 ns |  0.692 ns | 0.038 ns | 10.78 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                                    From_UInt_AsObject | .NET Core 3.1 | 19.00 ns |  1.395 ns | 0.076 ns | 19.00 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 5.0 | 19.19 ns |  8.557 ns | 0.469 ns | 18.92 ns |  1.01 |    0.02 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                          From_UInt_Nullable_WithValue | .NET Core 3.1 | 10.54 ns |  2.441 ns | 0.134 ns | 10.52 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 5.0 | 10.72 ns |  1.753 ns | 0.096 ns | 10.67 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 3.1 | 16.68 ns |  2.470 ns | 0.135 ns | 16.68 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 5.0 | 18.64 ns |  0.201 ns | 0.011 ns | 18.64 ns |  1.12 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                            From_UInt_Nullable_NoValue | .NET Core 3.1 | 10.45 ns |  0.887 ns | 0.049 ns | 10.43 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 5.0 | 10.98 ns |  1.308 ns | 0.072 ns | 10.94 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 3.1 | 13.45 ns |  0.873 ns | 0.048 ns | 13.46 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 5.0 | 13.75 ns |  1.893 ns | 0.104 ns | 13.74 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                                            From_ULong | .NET Core 3.1 | 10.77 ns |  2.474 ns | 0.136 ns | 10.83 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 5.0 | 10.75 ns |  1.340 ns | 0.073 ns | 10.75 ns |  1.00 |    0.02 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                                   From_ULong_AsObject | .NET Core 3.1 | 19.68 ns |  2.218 ns | 0.122 ns | 19.62 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 5.0 | 18.99 ns |  2.984 ns | 0.164 ns | 18.94 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                         From_ULong_Nullable_WithValue | .NET Core 3.1 | 10.90 ns |  0.378 ns | 0.021 ns | 10.91 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 5.0 | 11.03 ns |  6.190 ns | 0.339 ns | 10.88 ns |  1.01 |    0.03 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 3.1 | 18.79 ns |  2.890 ns | 0.158 ns | 18.70 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 5.0 | 19.76 ns |  0.408 ns | 0.022 ns | 19.76 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                           From_ULong_Nullable_NoValue | .NET Core 3.1 | 10.93 ns |  0.679 ns | 0.037 ns | 10.92 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 5.0 | 10.99 ns |  0.445 ns | 0.024 ns | 10.99 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 3.1 | 13.76 ns |  7.823 ns | 0.429 ns | 13.59 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 5.0 | 14.16 ns |  1.369 ns | 0.075 ns | 14.12 ns |  1.03 |    0.03 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                                       From_NullObject | .NET Core 3.1 | 13.56 ns |  5.188 ns | 0.284 ns | 13.42 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 5.0 | 14.40 ns |  1.600 ns | 0.088 ns | 14.36 ns |  1.06 |    0.02 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                                           From_DBNull | .NET Core 3.1 | 10.55 ns |  1.048 ns | 0.057 ns | 10.53 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 5.0 | 11.53 ns |  1.003 ns | 0.055 ns | 11.50 ns |  1.09 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                                  From_DBNull_AsObject | .NET Core 3.1 | 14.18 ns |  0.498 ns | 0.027 ns | 14.18 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 5.0 | 13.98 ns |  0.681 ns | 0.037 ns | 13.97 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                                 From_ConvertibleClass | .NET Core 3.1 | 11.50 ns |  7.995 ns | 0.438 ns | 11.33 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 5.0 | 11.61 ns |  1.082 ns | 0.059 ns | 11.60 ns |  1.01 |    0.03 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                        From_ConvertibleClass_AsObject | .NET Core 3.1 | 17.98 ns |  0.576 ns | 0.032 ns | 17.99 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 5.0 | 18.12 ns |  0.362 ns | 0.020 ns | 18.12 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                         From_ConvertibleClass_NoValue | .NET Core 3.1 | 11.79 ns | 10.054 ns | 0.551 ns | 12.09 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 5.0 | 10.56 ns |  0.200 ns | 0.011 ns | 10.56 ns |  0.90 |    0.04 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 3.1 | 14.10 ns |  1.902 ns | 0.104 ns | 14.04 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 5.0 | 13.90 ns |  1.214 ns | 0.067 ns | 13.86 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                              From_NonConvertibleClass | .NET Core 3.1 | 11.25 ns |  1.555 ns | 0.085 ns | 11.28 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 5.0 | 10.75 ns |  2.202 ns | 0.121 ns | 10.71 ns |  0.96 |    0.02 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                     From_NonConvertibleClass_AsObject | .NET Core 3.1 | 17.48 ns |  2.851 ns | 0.156 ns | 17.49 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 5.0 | 17.67 ns |  4.010 ns | 0.220 ns | 17.76 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                      From_NonConvertibleClass_NoValue | .NET Core 3.1 | 10.54 ns |  1.454 ns | 0.080 ns | 10.53 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 5.0 | 10.81 ns |  2.545 ns | 0.139 ns | 10.73 ns |  1.03 |    0.02 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 3.1 | 13.68 ns |  0.620 ns | 0.034 ns | 13.66 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 5.0 | 14.31 ns | 16.385 ns | 0.898 ns | 13.81 ns |  1.05 |    0.06 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                                From_ConvertibleStruct | .NET Core 3.1 | 10.52 ns |  2.980 ns | 0.163 ns | 10.46 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                From_ConvertibleStruct | .NET Core 5.0 | 10.66 ns |  0.422 ns | 0.023 ns | 10.66 ns |  1.01 |    0.02 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                       From_ConvertibleStruct_AsObject | .NET Core 3.1 | 16.96 ns |  3.408 ns | 0.187 ns | 16.85 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 5.0 | 17.68 ns |  2.168 ns | 0.119 ns | 17.62 ns |  1.04 |    0.02 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 3.1 | 10.51 ns |  1.135 ns | 0.062 ns | 10.48 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 5.0 | 10.90 ns |  5.164 ns | 0.283 ns | 10.89 ns |  1.04 |    0.03 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.1 | 15.64 ns |  0.584 ns | 0.032 ns | 15.66 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 5.0 | 17.69 ns |  2.483 ns | 0.136 ns | 17.63 ns |  1.13 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 3.1 | 11.58 ns |  0.386 ns | 0.021 ns | 11.58 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 5.0 | 10.77 ns |  1.036 ns | 0.057 ns | 10.77 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.1 | 13.44 ns |  1.326 ns | 0.073 ns | 13.47 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 5.0 | 14.91 ns |  6.860 ns | 0.376 ns | 14.93 ns |  1.11 |    0.03 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                             From_NonConvertibleStruct | .NET Core 3.1 | 11.87 ns |  1.129 ns | 0.062 ns | 11.86 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 5.0 | 12.01 ns |  8.845 ns | 0.485 ns | 11.83 ns |  1.01 |    0.04 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                    From_NonConvertibleStruct_AsObject | .NET Core 3.1 | 17.52 ns |  2.095 ns | 0.115 ns | 17.50 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 5.0 | 17.13 ns |  0.975 ns | 0.053 ns | 17.12 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 3.1 | 10.88 ns |  5.338 ns | 0.293 ns | 10.81 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 5.0 | 11.44 ns |  0.340 ns | 0.019 ns | 11.43 ns |  1.05 |    0.03 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.1 | 16.41 ns |  1.071 ns | 0.059 ns | 16.40 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 5.0 | 19.04 ns |  3.081 ns | 0.169 ns | 19.00 ns |  1.16 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 3.1 | 11.25 ns |  1.349 ns | 0.074 ns | 11.25 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 5.0 | 10.95 ns |  1.768 ns | 0.097 ns | 10.92 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.1 | 13.49 ns |  3.797 ns | 0.208 ns | 13.40 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 5.0 | 13.64 ns |  0.867 ns | 0.048 ns | 13.62 ns |  1.01 |    0.02 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                                             From_Enum | .NET Core 3.1 | 13.29 ns |  0.638 ns | 0.035 ns | 13.28 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 5.0 | 10.64 ns |  0.388 ns | 0.021 ns | 10.63 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                                    From_Enum_AsObject | .NET Core 3.1 | 18.63 ns |  5.432 ns | 0.298 ns | 18.56 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Enum_AsObject | .NET Core 5.0 | 18.55 ns |  0.703 ns | 0.039 ns | 18.54 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                          From_Enum_Nullable_WithValue | .NET Core 3.1 | 12.88 ns |  0.762 ns | 0.042 ns | 12.90 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 5.0 | 10.72 ns |  1.307 ns | 0.072 ns | 10.69 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 3.1 | 18.71 ns |  5.622 ns | 0.308 ns | 18.61 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 5.0 | 19.22 ns |  1.717 ns | 0.094 ns | 19.18 ns |  1.03 |    0.02 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                            From_Enum_Nullable_NoValue | .NET Core 3.1 | 10.48 ns |  2.542 ns | 0.139 ns | 10.42 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 5.0 | 10.77 ns |  0.940 ns | 0.052 ns | 10.79 ns |  1.03 |    0.02 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 3.1 | 14.10 ns |  0.820 ns | 0.045 ns | 14.11 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 5.0 | 13.70 ns |  0.411 ns | 0.023 ns | 13.70 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                                      From_ParentClass | .NET Core 3.1 | 11.83 ns |  0.863 ns | 0.047 ns | 11.84 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 5.0 | 10.85 ns |  1.250 ns | 0.069 ns | 10.82 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                             From_ParentClass_AsObject | .NET Core 3.1 | 16.49 ns |  2.693 ns | 0.148 ns | 16.47 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 5.0 | 17.35 ns |  1.281 ns | 0.070 ns | 17.32 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |          |          |       |         |        |       |       |           |
                              From_ParentClass_NoValue | .NET Core 3.1 | 11.76 ns | 13.053 ns | 0.715 ns | 11.37 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 5.0 | 10.83 ns |  3.257 ns | 0.179 ns | 10.91 ns |  0.92 |    0.05 |      - |     - |     - |         - |
