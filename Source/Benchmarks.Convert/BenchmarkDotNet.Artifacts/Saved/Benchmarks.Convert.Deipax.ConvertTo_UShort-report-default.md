
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

                                                Method |     Toolchain |      Mean |      Error |    StdDev |    Median | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------------------------------------------ |-------------- |----------:|-----------:|----------:|----------:|------:|--------:|-------:|------:|------:|----------:|
                     From_ParentClass_NoValue_AsObject | .NET Core 3.1 | 11.596 ns |  4.4775 ns | 0.2454 ns | 11.463 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 5.0 | 10.502 ns |  9.3253 ns | 0.5112 ns | 10.691 ns |  0.91 |    0.06 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                     From_ParentStruct | .NET Core 3.1 | 34.197 ns |  3.1366 ns | 0.1719 ns | 34.214 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 5.0 | 33.399 ns | 17.9953 ns | 0.9864 ns | 33.808 ns |  0.98 |    0.03 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                            From_ParentStruct_AsObject | .NET Core 3.1 | 14.656 ns |  6.4431 ns | 0.3532 ns | 14.550 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 5.0 | 13.422 ns |  0.6362 ns | 0.0349 ns | 13.414 ns |  0.92 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                  From_ParentStruct_Nullable_WithValue | .NET Core 3.1 | 34.158 ns |  1.5892 ns | 0.0871 ns | 34.139 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 5.0 | 27.737 ns |  1.0733 ns | 0.0588 ns | 27.737 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 3.1 | 13.440 ns |  0.4862 ns | 0.0267 ns | 13.443 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 5.0 | 13.142 ns |  0.4105 ns | 0.0225 ns | 13.137 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                    From_ParentStruct_Nullable_NoValue | .NET Core 3.1 | 36.069 ns |  2.1319 ns | 0.1169 ns | 36.125 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 5.0 | 28.541 ns | 14.8154 ns | 0.8121 ns | 28.227 ns |  0.79 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 3.1 | 11.103 ns |  2.2544 ns | 0.1236 ns | 11.036 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 5.0 | 11.224 ns |  4.1883 ns | 0.2296 ns | 11.217 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                             From_Bool | .NET Core 3.1 |  6.875 ns |  0.6421 ns | 0.0352 ns |  6.893 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 5.0 |  5.506 ns |  0.1939 ns | 0.0106 ns |  5.503 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                    From_Bool_AsObject | .NET Core 3.1 | 15.236 ns |  2.2565 ns | 0.1237 ns | 15.180 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 5.0 | 14.927 ns |  0.4202 ns | 0.0230 ns | 14.917 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                          From_Bool_Nullable_WithValue | .NET Core 3.1 |  5.928 ns |  0.1818 ns | 0.0100 ns |  5.930 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 5.0 |  5.982 ns |  0.1941 ns | 0.0106 ns |  5.987 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 3.1 | 14.834 ns |  3.1870 ns | 0.1747 ns | 14.750 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 5.0 | 15.315 ns |  1.4123 ns | 0.0774 ns | 15.286 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                            From_Bool_Nullable_NoValue | .NET Core 3.1 |  5.168 ns |  0.9591 ns | 0.0526 ns |  5.149 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 5.0 |  6.402 ns |  8.8232 ns | 0.4836 ns |  6.654 ns |  1.24 |    0.09 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 3.1 | 12.516 ns |  1.2634 ns | 0.0693 ns | 12.500 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 5.0 | 11.099 ns |  1.4527 ns | 0.0796 ns | 11.081 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                             From_Byte | .NET Core 3.1 |  5.164 ns |  0.1633 ns | 0.0090 ns |  5.166 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 5.0 |  5.329 ns |  0.9466 ns | 0.0519 ns |  5.303 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                    From_Byte_AsObject | .NET Core 3.1 | 26.400 ns |  0.8436 ns | 0.0462 ns | 26.418 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 5.0 | 14.810 ns |  1.2498 ns | 0.0685 ns | 14.796 ns |  0.56 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                          From_Byte_Nullable_WithValue | .NET Core 3.1 |  5.231 ns |  1.5342 ns | 0.0841 ns |  5.197 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 5.0 |  6.006 ns |  3.2016 ns | 0.1755 ns |  5.945 ns |  1.15 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 3.1 | 15.280 ns |  5.8990 ns | 0.3233 ns | 15.133 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 5.0 | 15.339 ns |  3.2140 ns | 0.1762 ns | 15.344 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                            From_Byte_Nullable_NoValue | .NET Core 3.1 |  5.324 ns |  5.9368 ns | 0.3254 ns |  5.178 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 5.0 |  5.790 ns |  0.1883 ns | 0.0103 ns |  5.790 ns |  1.09 |    0.06 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 3.1 | 12.598 ns |  2.0440 ns | 0.1120 ns | 12.596 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 5.0 | 11.085 ns |  2.6924 ns | 0.1476 ns | 11.024 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                             From_Char | .NET Core 3.1 |  5.810 ns |  0.8000 ns | 0.0438 ns |  5.789 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Char | .NET Core 5.0 |  5.944 ns | 10.0807 ns | 0.5526 ns |  6.196 ns |  1.02 |    0.10 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                    From_Char_AsObject | .NET Core 3.1 | 14.761 ns |  3.2541 ns | 0.1784 ns | 14.706 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 5.0 | 13.572 ns |  5.8613 ns | 0.3213 ns | 13.401 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                          From_Char_Nullable_WithValue | .NET Core 3.1 |  7.371 ns |  2.5130 ns | 0.1377 ns |  7.355 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 5.0 |  5.924 ns |  1.2965 ns | 0.0711 ns |  5.884 ns |  0.80 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 3.1 | 14.667 ns |  0.1402 ns | 0.0077 ns | 14.669 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 5.0 | 15.166 ns |  3.4803 ns | 0.1908 ns | 15.059 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                            From_Char_Nullable_NoValue | .NET Core 3.1 |  7.210 ns |  0.4358 ns | 0.0239 ns |  7.202 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 5.0 |  5.810 ns |  1.2678 ns | 0.0695 ns |  5.778 ns |  0.81 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 3.1 | 10.940 ns |  1.5076 ns | 0.0826 ns | 10.896 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 5.0 | 10.079 ns |  3.9903 ns | 0.2187 ns | 10.050 ns |  0.92 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                         From_DateTime | .NET Core 3.1 |  5.954 ns |  0.1568 ns | 0.0086 ns |  5.957 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 5.0 |  6.554 ns |  0.5407 ns | 0.0296 ns |  6.540 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                From_DateTime_AsObject | .NET Core 3.1 |        NA |         NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 5.0 |        NA |         NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                      From_DateTime_Nullable_WithValue | .NET Core 3.1 |  6.166 ns |  0.7203 ns | 0.0395 ns |  6.148 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 5.0 |  5.597 ns |  1.7400 ns | 0.0954 ns |  5.638 ns |  0.91 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 3.1 |        NA |         NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 5.0 |        NA |         NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                        From_DateTime_Nullable_NoValue | .NET Core 3.1 |  6.571 ns |  1.6132 ns | 0.0884 ns |  6.529 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 5.0 |  6.038 ns |  9.6349 ns | 0.5281 ns |  6.343 ns |  0.92 |    0.07 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 3.1 | 12.478 ns |  0.9164 ns | 0.0502 ns | 12.466 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 5.0 | 11.139 ns |  4.9116 ns | 0.2692 ns | 10.998 ns |  0.89 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                          From_Decimal | .NET Core 3.1 | 13.031 ns |  1.9118 ns | 0.1048 ns | 12.980 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 5.0 | 12.528 ns |  0.1718 ns | 0.0094 ns | 12.527 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                 From_Decimal_AsObject | .NET Core 3.1 | 20.903 ns |  4.7457 ns | 0.2601 ns | 20.766 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 5.0 | 21.511 ns |  4.9431 ns | 0.2710 ns | 21.386 ns |  1.03 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                       From_Decimal_Nullable_WithValue | .NET Core 3.1 | 15.346 ns |  0.3658 ns | 0.0201 ns | 15.338 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 5.0 | 14.235 ns |  0.9367 ns | 0.0513 ns | 14.209 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 3.1 | 22.100 ns |  7.8395 ns | 0.4297 ns | 22.037 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 5.0 | 21.041 ns |  0.8470 ns | 0.0464 ns | 21.040 ns |  0.95 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                         From_Decimal_Nullable_NoValue | .NET Core 3.1 |  6.346 ns |  0.1857 ns | 0.0102 ns |  6.347 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 5.0 |  6.187 ns |  0.3251 ns | 0.0178 ns |  6.184 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 3.1 | 13.308 ns |  1.3303 ns | 0.0729 ns | 13.278 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 5.0 | 11.585 ns |  4.4360 ns | 0.2432 ns | 11.633 ns |  0.87 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                           From_Double | .NET Core 3.1 |  9.142 ns |  2.6113 ns | 0.1431 ns |  9.076 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 5.0 |  8.184 ns |  4.2896 ns | 0.2351 ns |  8.067 ns |  0.90 |    0.03 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                  From_Double_AsObject | .NET Core 3.1 | 17.362 ns |  3.0140 ns | 0.1652 ns | 17.444 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 5.0 | 16.460 ns |  3.3609 ns | 0.1842 ns | 16.484 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                        From_Double_Nullable_WithValue | .NET Core 3.1 | 11.350 ns |  3.3564 ns | 0.1840 ns | 11.392 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 5.0 |  8.295 ns |  1.3829 ns | 0.0758 ns |  8.261 ns |  0.73 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
               From_Double_Nullable_WithValue_AsObject | .NET Core 3.1 | 17.211 ns |  4.4953 ns | 0.2464 ns | 17.081 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 5.0 | 16.443 ns |  4.4828 ns | 0.2457 ns | 16.346 ns |  0.96 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                          From_Double_Nullable_NoValue | .NET Core 3.1 |  6.712 ns |  0.3465 ns | 0.0190 ns |  6.714 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 5.0 |  5.985 ns |  4.1364 ns | 0.2267 ns |  5.873 ns |  0.89 |    0.03 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 3.1 | 12.466 ns |  0.0912 ns | 0.0050 ns | 12.466 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 5.0 | 11.022 ns |  2.6340 ns | 0.1444 ns | 10.946 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                            From_Short | .NET Core 3.1 |  5.975 ns |  1.6031 ns | 0.0879 ns |  5.995 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 5.0 |  5.503 ns |  0.0862 ns | 0.0047 ns |  5.501 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                   From_Short_AsObject | .NET Core 3.1 | 12.813 ns |  2.3417 ns | 0.1284 ns | 12.801 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 5.0 | 14.914 ns |  2.5456 ns | 0.1395 ns | 14.864 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                         From_Short_Nullable_WithValue | .NET Core 3.1 |  5.360 ns |  2.6668 ns | 0.1462 ns |  5.290 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 5.0 |  6.793 ns | 12.8969 ns | 0.7069 ns |  7.143 ns |  1.27 |    0.16 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                From_Short_Nullable_WithValue_AsObject | .NET Core 3.1 | 16.246 ns |  2.6789 ns | 0.1468 ns | 16.180 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 5.0 | 15.023 ns |  8.3776 ns | 0.4592 ns | 14.882 ns |  0.92 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                           From_Short_Nullable_NoValue | .NET Core 3.1 |  5.724 ns |  0.1993 ns | 0.0109 ns |  5.721 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 5.0 |  7.076 ns |  0.0175 ns | 0.0010 ns |  7.076 ns |  1.24 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 3.1 | 12.124 ns |  1.4106 ns | 0.0773 ns | 12.160 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 5.0 |  9.940 ns |  1.4146 ns | 0.0775 ns |  9.905 ns |  0.82 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                              From_Int | .NET Core 3.1 |  6.570 ns |  3.2829 ns | 0.1799 ns |  6.582 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 5.0 |  5.530 ns |  0.1907 ns | 0.0105 ns |  5.528 ns |  0.84 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                     From_Int_AsObject | .NET Core 3.1 | 15.929 ns |  0.7104 ns | 0.0389 ns | 15.911 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 5.0 | 14.540 ns |  0.2760 ns | 0.0151 ns | 14.539 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                           From_Int_Nullable_WithValue | .NET Core 3.1 |  7.715 ns |  0.2819 ns | 0.0155 ns |  7.716 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 5.0 |  6.449 ns | 14.0231 ns | 0.7687 ns |  6.016 ns |  0.84 |    0.10 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 3.1 | 13.082 ns |  3.4036 ns | 0.1866 ns | 13.015 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 5.0 | 14.766 ns |  0.0373 ns | 0.0020 ns | 14.766 ns |  1.13 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                             From_Int_Nullable_NoValue | .NET Core 3.1 |  5.217 ns |  1.5738 ns | 0.0863 ns |  5.244 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 5.0 |  5.853 ns |  0.1986 ns | 0.0109 ns |  5.856 ns |  1.12 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 3.1 | 11.043 ns |  1.8435 ns | 0.1010 ns | 11.015 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 5.0 | 11.755 ns |  3.1352 ns | 0.1718 ns | 11.656 ns |  1.06 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                             From_Long | .NET Core 3.1 |  5.392 ns |  1.8754 ns | 0.1028 ns |  5.396 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Long | .NET Core 5.0 |  5.570 ns |  0.6121 ns | 0.0335 ns |  5.555 ns |  1.03 |    0.03 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                    From_Long_AsObject | .NET Core 3.1 | 14.807 ns | 12.7976 ns | 0.7015 ns | 14.515 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 5.0 | 14.704 ns |  1.4535 ns | 0.0797 ns | 14.663 ns |  0.99 |    0.05 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                          From_Long_Nullable_WithValue | .NET Core 3.1 |  7.705 ns |  0.4309 ns | 0.0236 ns |  7.718 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 5.0 |  6.108 ns |  0.7954 ns | 0.0436 ns |  6.090 ns |  0.79 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 3.1 | 14.940 ns |  6.4673 ns | 0.3545 ns | 14.766 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 5.0 | 14.989 ns |  3.6964 ns | 0.2026 ns | 14.890 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                            From_Long_Nullable_NoValue | .NET Core 3.1 |  7.374 ns |  0.4598 ns | 0.0252 ns |  7.382 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 5.0 |  5.870 ns |  0.1895 ns | 0.0104 ns |  5.869 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 3.1 | 11.052 ns |  1.8902 ns | 0.1036 ns | 10.997 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 5.0 | 11.476 ns |  9.2469 ns | 0.5069 ns | 11.299 ns |  1.04 |    0.05 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                            From_SByte | .NET Core 3.1 |  6.031 ns |  0.4180 ns | 0.0229 ns |  6.025 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 5.0 |  5.496 ns |  0.2332 ns | 0.0128 ns |  5.499 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                   From_SByte_AsObject | .NET Core 3.1 | 15.417 ns |  0.0732 ns | 0.0040 ns | 15.417 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 5.0 | 14.786 ns |  5.5994 ns | 0.3069 ns | 14.669 ns |  0.96 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                         From_SByte_Nullable_WithValue | .NET Core 3.1 |  5.267 ns |  0.4750 ns | 0.0260 ns |  5.254 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 5.0 |  7.484 ns |  1.5781 ns | 0.0865 ns |  7.435 ns |  1.42 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 3.1 | 15.374 ns |  1.0403 ns | 0.0570 ns | 15.404 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 5.0 | 14.757 ns |  5.2610 ns | 0.2884 ns | 14.616 ns |  0.96 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                           From_SByte_Nullable_NoValue | .NET Core 3.1 |  6.070 ns |  0.5617 ns | 0.0308 ns |  6.072 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 5.0 |  5.961 ns |  5.1021 ns | 0.2797 ns |  5.807 ns |  0.98 |    0.05 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 3.1 |  9.760 ns |  1.6874 ns | 0.0925 ns |  9.737 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 5.0 | 11.199 ns |  4.6142 ns | 0.2529 ns | 11.200 ns |  1.15 |    0.04 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                            From_Float | .NET Core 3.1 |  8.051 ns |  1.0927 ns | 0.0599 ns |  8.054 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 5.0 |  8.122 ns |  2.8913 ns | 0.1585 ns |  8.056 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                   From_Float_AsObject | .NET Core 3.1 | 19.363 ns |  2.5989 ns | 0.1425 ns | 19.297 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 5.0 | 16.316 ns |  4.2935 ns | 0.2353 ns | 16.198 ns |  0.84 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                         From_Float_Nullable_WithValue | .NET Core 3.1 |  9.044 ns |  2.9755 ns | 0.1631 ns |  9.130 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 5.0 |  8.409 ns |  1.5611 ns | 0.0856 ns |  8.439 ns |  0.93 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                From_Float_Nullable_WithValue_AsObject | .NET Core 3.1 | 19.038 ns |  7.6196 ns | 0.4177 ns | 18.804 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 5.0 | 16.679 ns |  3.2828 ns | 0.1799 ns | 16.653 ns |  0.88 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                           From_Float_Nullable_NoValue | .NET Core 3.1 |  7.358 ns |  0.0387 ns | 0.0021 ns |  7.358 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 5.0 |  7.233 ns |  0.5067 ns | 0.0278 ns |  7.235 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 3.1 |  9.866 ns |  3.8588 ns | 0.2115 ns |  9.755 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 5.0 | 11.068 ns |  1.7902 ns | 0.0981 ns | 11.015 ns |  1.12 |    0.03 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                           From_String | .NET Core 3.1 | 17.800 ns |  0.6478 ns | 0.0355 ns | 17.788 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 5.0 | 19.548 ns | 14.9381 ns | 0.8188 ns | 19.130 ns |  1.10 |    0.04 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                  From_String_AsObject | .NET Core 3.1 | 24.214 ns |  4.7279 ns | 0.2592 ns | 24.340 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 5.0 | 20.510 ns |  3.6730 ns | 0.2013 ns | 20.499 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                      From_String_Null | .NET Core 3.1 | 10.937 ns |  3.1987 ns | 0.1753 ns | 10.849 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 5.0 | 10.380 ns |  4.5171 ns | 0.2476 ns | 10.246 ns |  0.95 |    0.03 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                             From_String_Null_AsObject | .NET Core 3.1 |  9.899 ns |  2.5911 ns | 0.1420 ns |  9.907 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 5.0 | 11.161 ns |  4.5149 ns | 0.2475 ns | 11.157 ns |  1.13 |    0.04 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                     From_String_Empty | .NET Core 3.1 | 11.838 ns |  1.1616 ns | 0.0637 ns | 11.808 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 5.0 | 10.966 ns |  0.6726 ns | 0.0369 ns | 10.950 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                            From_String_Empty_AsObject | .NET Core 3.1 |        NA |         NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 5.0 |        NA |         NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                           From_UShort | .NET Core 3.1 |  4.974 ns |  1.7881 ns | 0.0980 ns |  4.971 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 5.0 |  4.839 ns |  1.1863 ns | 0.0650 ns |  4.805 ns |  0.97 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                  From_UShort_AsObject | .NET Core 3.1 | 16.394 ns | 12.3940 ns | 0.6794 ns | 16.030 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 5.0 | 11.687 ns |  0.6223 ns | 0.0341 ns | 11.681 ns |  0.71 |    0.03 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                        From_UShort_Nullable_WithValue | .NET Core 3.1 |  5.361 ns |  2.3810 ns | 0.1305 ns |  5.393 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 5.0 |  5.617 ns |  4.7467 ns | 0.2602 ns |  5.553 ns |  1.05 |    0.03 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 3.1 | 13.625 ns |  1.7467 ns | 0.0957 ns | 13.574 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 5.0 | 11.785 ns |  1.9750 ns | 0.1083 ns | 11.820 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                          From_UShort_Nullable_NoValue | .NET Core 3.1 |  5.141 ns |  1.3964 ns | 0.0765 ns |  5.107 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 5.0 |  5.901 ns | 10.0990 ns | 0.5536 ns |  5.740 ns |  1.15 |    0.12 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 3.1 | 11.069 ns |  2.5652 ns | 0.1406 ns | 10.994 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 5.0 | 11.085 ns |  1.6990 ns | 0.0931 ns | 11.072 ns |  1.00 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                             From_UInt | .NET Core 3.1 |  4.794 ns |  0.0414 ns | 0.0023 ns |  4.794 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 5.0 |  5.504 ns |  0.1352 ns | 0.0074 ns |  5.500 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                    From_UInt_AsObject | .NET Core 3.1 | 15.607 ns |  2.7593 ns | 0.1512 ns | 15.647 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 5.0 | 14.722 ns |  0.6596 ns | 0.0362 ns | 14.733 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                          From_UInt_Nullable_WithValue | .NET Core 3.1 |  5.288 ns |  0.3134 ns | 0.0172 ns |  5.295 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 5.0 |  6.918 ns | 14.6091 ns | 0.8008 ns |  7.359 ns |  1.31 |    0.15 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 3.1 | 14.088 ns |  5.9848 ns | 0.3280 ns | 13.916 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 5.0 | 14.502 ns |  0.1207 ns | 0.0066 ns | 14.499 ns |  1.03 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                            From_UInt_Nullable_NoValue | .NET Core 3.1 |  5.226 ns |  1.1133 ns | 0.0610 ns |  5.246 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 5.0 |  5.697 ns |  0.3289 ns | 0.0180 ns |  5.703 ns |  1.09 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 3.1 | 12.676 ns |  1.6217 ns | 0.0889 ns | 12.696 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 5.0 | 10.987 ns |  0.2119 ns | 0.0116 ns | 10.988 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                            From_ULong | .NET Core 3.1 |  5.344 ns |  1.2089 ns | 0.0663 ns |  5.316 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 5.0 |  5.922 ns |  1.3195 ns | 0.0723 ns |  5.899 ns |  1.11 |    0.03 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                   From_ULong_AsObject | .NET Core 3.1 | 13.498 ns |  1.2762 ns | 0.0700 ns | 13.462 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 5.0 | 14.339 ns |  0.1158 ns | 0.0063 ns | 14.341 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                         From_ULong_Nullable_WithValue | .NET Core 3.1 |  8.629 ns |  0.3630 ns | 0.0199 ns |  8.639 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 5.0 |  6.334 ns |  5.1306 ns | 0.2812 ns |  6.488 ns |  0.73 |    0.03 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 3.1 | 15.408 ns |  0.1422 ns | 0.0078 ns | 15.404 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 5.0 | 14.650 ns |  2.4599 ns | 0.1348 ns | 14.630 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                           From_ULong_Nullable_NoValue | .NET Core 3.1 |  6.506 ns |  2.2144 ns | 0.1214 ns |  6.476 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 5.0 |  5.920 ns |  0.5842 ns | 0.0320 ns |  5.904 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 3.1 | 11.308 ns |  1.8042 ns | 0.0989 ns | 11.290 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 5.0 | 11.121 ns |  2.5019 ns | 0.1371 ns | 11.170 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                       From_NullObject | .NET Core 3.1 | 13.296 ns |  2.2343 ns | 0.1225 ns | 13.352 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 5.0 |  9.794 ns |  0.2025 ns | 0.0111 ns |  9.792 ns |  0.74 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                           From_DBNull | .NET Core 3.1 |  9.003 ns |  0.7380 ns | 0.0405 ns |  8.982 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 5.0 |  8.373 ns |  3.1793 ns | 0.1743 ns |  8.305 ns |  0.93 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                  From_DBNull_AsObject | .NET Core 3.1 | 12.877 ns |  0.0739 ns | 0.0041 ns | 12.875 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 5.0 | 11.062 ns |  2.2523 ns | 0.1235 ns | 11.018 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                 From_ConvertibleClass | .NET Core 3.1 | 12.611 ns |  3.6466 ns | 0.1999 ns | 12.502 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 5.0 | 13.256 ns |  9.2313 ns | 0.5060 ns | 13.125 ns |  1.05 |    0.05 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                        From_ConvertibleClass_AsObject | .NET Core 3.1 | 15.042 ns |  2.3928 ns | 0.1312 ns | 14.970 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 5.0 | 13.536 ns |  3.1519 ns | 0.1728 ns | 13.440 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                         From_ConvertibleClass_NoValue | .NET Core 3.1 | 13.713 ns |  4.2010 ns | 0.2303 ns | 13.596 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 5.0 | 10.721 ns |  0.2947 ns | 0.0162 ns | 10.718 ns |  0.78 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 3.1 | 12.848 ns |  2.3921 ns | 0.1311 ns | 12.778 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 5.0 | 10.972 ns |  1.0927 ns | 0.0599 ns | 10.945 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                              From_NonConvertibleClass | .NET Core 3.1 |  8.214 ns |  0.1433 ns | 0.0079 ns |  8.212 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 5.0 |  8.785 ns | 14.7559 ns | 0.8088 ns |  8.322 ns |  1.07 |    0.10 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                     From_NonConvertibleClass_AsObject | .NET Core 3.1 | 13.942 ns |  2.8048 ns | 0.1537 ns | 13.860 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 5.0 | 12.611 ns |  2.1242 ns | 0.1164 ns | 12.588 ns |  0.90 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                      From_NonConvertibleClass_NoValue | .NET Core 3.1 |  8.591 ns |  1.4468 ns | 0.0793 ns |  8.605 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 5.0 |  8.341 ns |  1.3578 ns | 0.0744 ns |  8.340 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 3.1 | 12.576 ns |  0.8847 ns | 0.0485 ns | 12.549 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 5.0 | 11.178 ns |  3.2389 ns | 0.1775 ns | 11.113 ns |  0.89 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                From_ConvertibleStruct | .NET Core 3.1 |  9.747 ns |  3.9816 ns | 0.2182 ns |  9.806 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 5.0 | 10.230 ns |  2.2571 ns | 0.1237 ns | 10.175 ns |  1.05 |    0.03 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                       From_ConvertibleStruct_AsObject | .NET Core 3.1 | 15.913 ns |  2.6868 ns | 0.1473 ns | 15.856 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 5.0 | 14.542 ns |  3.0097 ns | 0.1650 ns | 14.528 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 3.1 | 10.387 ns |  3.6525 ns | 0.2002 ns | 10.357 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 5.0 | 10.862 ns |  2.2653 ns | 0.1242 ns | 10.929 ns |  1.05 |    0.03 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.1 | 12.514 ns |  0.9209 ns | 0.0505 ns | 12.505 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 5.0 | 14.547 ns |  3.4024 ns | 0.1865 ns | 14.450 ns |  1.16 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 3.1 |  5.736 ns |  0.3636 ns | 0.0199 ns |  5.725 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 5.0 |  6.422 ns |  5.3681 ns | 0.2942 ns |  6.272 ns |  1.12 |    0.05 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.1 | 12.782 ns |  3.7495 ns | 0.2055 ns | 12.865 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 5.0 | 11.023 ns |  1.7710 ns | 0.0971 ns | 10.971 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                             From_NonConvertibleStruct | .NET Core 3.1 |  5.562 ns |  3.1156 ns | 0.1708 ns |  5.486 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 5.0 |  6.177 ns |  1.1593 ns | 0.0635 ns |  6.149 ns |  1.11 |    0.04 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                    From_NonConvertibleStruct_AsObject | .NET Core 3.1 | 13.942 ns |  2.8150 ns | 0.1543 ns | 13.891 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 5.0 | 12.590 ns |  1.6852 ns | 0.0924 ns | 12.540 ns |  0.90 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 3.1 |  5.438 ns |  0.6662 ns | 0.0365 ns |  5.428 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 5.0 |  6.246 ns |  1.0178 ns | 0.0558 ns |  6.261 ns |  1.15 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.1 | 13.244 ns |  4.0982 ns | 0.2246 ns | 13.256 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 5.0 | 13.858 ns |  3.4710 ns | 0.1903 ns | 13.756 ns |  1.05 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 3.1 |  5.554 ns |  2.4092 ns | 0.1321 ns |  5.518 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 5.0 |  6.618 ns | 13.8853 ns | 0.7611 ns |  6.181 ns |  1.19 |    0.15 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.1 | 11.327 ns |  0.7126 ns | 0.0391 ns | 11.349 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 5.0 | 11.044 ns |  2.1191 ns | 0.1162 ns | 11.000 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                             From_Enum | .NET Core 3.1 |  5.943 ns |  0.6708 ns | 0.0368 ns |  5.930 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 5.0 |  5.514 ns |  1.0788 ns | 0.0591 ns |  5.503 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                    From_Enum_AsObject | .NET Core 3.1 | 33.919 ns |  6.6933 ns | 0.3669 ns | 33.966 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject | .NET Core 5.0 | 23.439 ns |  1.9046 ns | 0.1044 ns | 23.434 ns |  0.69 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                          From_Enum_Nullable_WithValue | .NET Core 3.1 |  6.787 ns |  0.6831 ns | 0.0374 ns |  6.774 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 5.0 |  6.257 ns |  4.7722 ns | 0.2616 ns |  6.134 ns |  0.92 |    0.03 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 3.1 | 32.675 ns |  0.4784 ns | 0.0262 ns | 32.665 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 5.0 | 24.371 ns |  6.6840 ns | 0.3664 ns | 24.445 ns |  0.75 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                            From_Enum_Nullable_NoValue | .NET Core 3.1 |  5.832 ns |  0.7022 ns | 0.0385 ns |  5.819 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 5.0 |  5.779 ns |  0.1833 ns | 0.0100 ns |  5.782 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 3.1 | 10.217 ns |  3.3770 ns | 0.1851 ns | 10.223 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 5.0 | 11.427 ns |  1.7702 ns | 0.0970 ns | 11.421 ns |  1.12 |    0.03 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                      From_ParentClass | .NET Core 3.1 |  8.508 ns |  3.5134 ns | 0.1926 ns |  8.504 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 5.0 |  8.301 ns |  0.5576 ns | 0.0306 ns |  8.311 ns |  0.98 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                             From_ParentClass_AsObject | .NET Core 3.1 | 13.273 ns |  8.0565 ns | 0.4416 ns | 13.024 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 5.0 | 12.991 ns |  1.8183 ns | 0.0997 ns | 12.996 ns |  0.98 |    0.04 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                              From_ParentClass_NoValue | .NET Core 3.1 |  8.324 ns |  1.4309 ns | 0.0784 ns |  8.321 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 5.0 |  8.775 ns |  7.8672 ns | 0.4312 ns |  8.940 ns |  1.05 |    0.05 |      - |     - |     - |         - |

Benchmarks with issues:
  ConvertTo_UShort.From_DateTime_AsObject: ShortRun(Toolchain=.NET Core 3.1, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_UShort.From_DateTime_AsObject: ShortRun(Toolchain=.NET Core 5.0, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_UShort.From_DateTime_Nullable_WithValue_AsObject: ShortRun(Toolchain=.NET Core 3.1, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_UShort.From_DateTime_Nullable_WithValue_AsObject: ShortRun(Toolchain=.NET Core 5.0, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_UShort.From_String_Empty_AsObject: ShortRun(Toolchain=.NET Core 3.1, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_UShort.From_String_Empty_AsObject: ShortRun(Toolchain=.NET Core 5.0, IterationCount=3, LaunchCount=1, WarmupCount=3)
