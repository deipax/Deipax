
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

                                                Method |     Toolchain |      Mean |      Error |    StdDev |    Median | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------------------------------------------ |-------------- |----------:|-----------:|----------:|----------:|------:|--------:|-------:|------:|------:|----------:|
                     From_ParentClass_NoValue_AsObject | .NET Core 3.1 | 13.196 ns |  2.2804 ns | 0.1250 ns | 13.135 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 5.0 | 11.630 ns |  1.6050 ns | 0.0880 ns | 11.653 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                     From_ParentStruct | .NET Core 3.1 | 37.260 ns |  1.6336 ns | 0.0895 ns | 37.289 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 5.0 | 28.106 ns |  2.1467 ns | 0.1177 ns | 28.076 ns |  0.75 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                            From_ParentStruct_AsObject | .NET Core 3.1 | 15.611 ns |  0.8499 ns | 0.0466 ns | 15.607 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 5.0 | 13.637 ns |  0.3954 ns | 0.0217 ns | 13.625 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                  From_ParentStruct_Nullable_WithValue | .NET Core 3.1 | 38.953 ns |  2.2853 ns | 0.1253 ns | 38.933 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 5.0 | 27.994 ns |  1.2255 ns | 0.0672 ns | 28.005 ns |  0.72 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 3.1 | 15.384 ns |  3.3863 ns | 0.1856 ns | 15.307 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 5.0 | 13.505 ns |  3.3099 ns | 0.1814 ns | 13.546 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                    From_ParentStruct_Nullable_NoValue | .NET Core 3.1 | 38.307 ns |  4.3099 ns | 0.2362 ns | 38.385 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 5.0 | 34.541 ns |  4.4612 ns | 0.2445 ns | 34.568 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 3.1 | 13.557 ns |  2.0901 ns | 0.1146 ns | 13.509 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 5.0 | 11.410 ns |  2.1131 ns | 0.1158 ns | 11.407 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                             From_Bool | .NET Core 3.1 |  7.989 ns |  0.3843 ns | 0.0211 ns |  7.984 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 5.0 |  7.894 ns | 13.6801 ns | 0.7499 ns |  7.479 ns |  0.99 |    0.09 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                    From_Bool_AsObject | .NET Core 3.1 | 19.128 ns | 66.2776 ns | 3.6329 ns | 17.065 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 5.0 | 16.911 ns |  2.9347 ns | 0.1609 ns | 16.859 ns |  0.90 |    0.16 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                          From_Bool_Nullable_WithValue | .NET Core 3.1 |  8.582 ns |  4.8089 ns | 0.2636 ns |  8.446 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 5.0 |  7.836 ns |  2.0012 ns | 0.1097 ns |  7.780 ns |  0.91 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 3.1 | 17.185 ns |  2.2897 ns | 0.1255 ns | 17.123 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 5.0 | 17.020 ns |  4.2164 ns | 0.2311 ns | 17.101 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                            From_Bool_Nullable_NoValue | .NET Core 3.1 |  7.913 ns |  0.5632 ns | 0.0309 ns |  7.917 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 5.0 |  6.220 ns |  2.9161 ns | 0.1598 ns |  6.188 ns |  0.79 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 3.1 | 12.999 ns |  0.2959 ns | 0.0162 ns | 12.990 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 5.0 | 11.413 ns |  4.1079 ns | 0.2252 ns | 11.343 ns |  0.88 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                             From_Byte | .NET Core 3.1 |  7.913 ns |  0.5292 ns | 0.0290 ns |  7.913 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 5.0 |  7.846 ns | 11.1085 ns | 0.6089 ns |  7.508 ns |  0.99 |    0.08 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                    From_Byte_AsObject | .NET Core 3.1 | 16.641 ns |  0.4179 ns | 0.0229 ns | 16.645 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 5.0 | 16.788 ns |  4.1833 ns | 0.2293 ns | 16.880 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                          From_Byte_Nullable_WithValue | .NET Core 3.1 |  8.626 ns |  1.0148 ns | 0.0556 ns |  8.608 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 5.0 | 10.096 ns | 41.7960 ns | 2.2910 ns |  9.319 ns |  1.17 |    0.27 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 3.1 | 15.335 ns |  1.4880 ns | 0.0816 ns | 15.295 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 5.0 | 18.523 ns |  6.7784 ns | 0.3715 ns | 18.428 ns |  1.21 |    0.03 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                            From_Byte_Nullable_NoValue | .NET Core 3.1 |  8.130 ns |  0.0548 ns | 0.0030 ns |  8.128 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 5.0 |  8.676 ns | 17.9537 ns | 0.9841 ns |  8.114 ns |  1.07 |    0.12 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 3.1 | 12.979 ns |  0.3436 ns | 0.0188 ns | 12.972 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 5.0 | 11.899 ns |  4.0140 ns | 0.2200 ns | 11.801 ns |  0.92 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                             From_Char | .NET Core 3.1 |  7.910 ns |  0.2564 ns | 0.0141 ns |  7.911 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Char | .NET Core 5.0 |  7.770 ns |  1.0136 ns | 0.0556 ns |  7.757 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                    From_Char_AsObject | .NET Core 3.1 | 17.142 ns |  3.9519 ns | 0.2166 ns | 17.109 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 5.0 | 17.595 ns |  4.5098 ns | 0.2472 ns | 17.465 ns |  1.03 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                          From_Char_Nullable_WithValue | .NET Core 3.1 |  8.390 ns |  0.6790 ns | 0.0372 ns |  8.375 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 5.0 |  7.461 ns |  1.6610 ns | 0.0910 ns |  7.446 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 3.1 | 16.874 ns |  0.1125 ns | 0.0062 ns | 16.872 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 5.0 | 17.585 ns |  9.1488 ns | 0.5015 ns | 17.440 ns |  1.04 |    0.03 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                            From_Char_Nullable_NoValue | .NET Core 3.1 |  7.982 ns |  1.0487 ns | 0.0575 ns |  7.971 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 5.0 |  6.676 ns |  3.3725 ns | 0.1849 ns |  6.670 ns |  0.84 |    0.03 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 3.1 | 11.768 ns |  2.4637 ns | 0.1350 ns | 11.812 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 5.0 | 12.191 ns | 24.7053 ns | 1.3542 ns | 11.570 ns |  1.04 |    0.11 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                         From_DateTime | .NET Core 3.1 |  8.186 ns |  1.5988 ns | 0.0876 ns |  8.151 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 5.0 |  6.714 ns |  1.2239 ns | 0.0671 ns |  6.678 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                From_DateTime_AsObject | .NET Core 3.1 |        NA |         NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 5.0 |        NA |         NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                      From_DateTime_Nullable_WithValue | .NET Core 3.1 |  8.435 ns |  0.9314 ns | 0.0511 ns |  8.437 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 5.0 |  5.790 ns |  2.9449 ns | 0.1614 ns |  5.732 ns |  0.69 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 3.1 |        NA |         NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 5.0 |        NA |         NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                        From_DateTime_Nullable_NoValue | .NET Core 3.1 |  8.491 ns |  2.0271 ns | 0.1111 ns |  8.539 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 5.0 |  5.803 ns |  2.3597 ns | 0.1293 ns |  5.855 ns |  0.68 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 3.1 | 12.985 ns |  0.4475 ns | 0.0245 ns | 12.974 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 5.0 | 12.633 ns | 20.6846 ns | 1.1338 ns | 12.800 ns |  0.97 |    0.09 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                          From_Decimal | .NET Core 3.1 | 12.307 ns |  0.2583 ns | 0.0142 ns | 12.305 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 5.0 | 17.918 ns | 41.8366 ns | 2.2932 ns | 17.162 ns |  1.46 |    0.19 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                 From_Decimal_AsObject | .NET Core 3.1 | 20.306 ns |  2.9861 ns | 0.1637 ns | 20.340 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 5.0 | 25.966 ns | 34.2037 ns | 1.8748 ns | 25.369 ns |  1.28 |    0.10 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                       From_Decimal_Nullable_WithValue | .NET Core 3.1 | 17.190 ns |  0.4659 ns | 0.0255 ns | 17.183 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 5.0 | 15.972 ns |  4.1010 ns | 0.2248 ns | 16.064 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 3.1 | 21.247 ns |  0.7770 ns | 0.0426 ns | 21.255 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 5.0 | 24.517 ns |  2.7790 ns | 0.1523 ns | 24.539 ns |  1.15 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                         From_Decimal_Nullable_NoValue | .NET Core 3.1 |  8.900 ns |  1.9058 ns | 0.1045 ns |  8.851 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 5.0 |  6.059 ns |  4.4733 ns | 0.2452 ns |  5.920 ns |  0.68 |    0.03 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 3.1 | 13.045 ns |  2.2036 ns | 0.1208 ns | 13.020 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 5.0 | 11.308 ns |  1.9170 ns | 0.1051 ns | 11.274 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                           From_Double | .NET Core 3.1 | 10.286 ns |  0.9155 ns | 0.0502 ns | 10.294 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 5.0 | 10.923 ns |  6.5055 ns | 0.3566 ns | 10.909 ns |  1.06 |    0.03 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                  From_Double_AsObject | .NET Core 3.1 | 18.891 ns |  0.5892 ns | 0.0323 ns | 18.895 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 5.0 | 20.000 ns |  6.5937 ns | 0.3614 ns | 19.900 ns |  1.06 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                        From_Double_Nullable_WithValue | .NET Core 3.1 | 10.944 ns |  2.6347 ns | 0.1444 ns | 10.969 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 5.0 | 10.535 ns |  1.5318 ns | 0.0840 ns | 10.568 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
               From_Double_Nullable_WithValue_AsObject | .NET Core 3.1 | 18.788 ns |  0.7665 ns | 0.0420 ns | 18.773 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 5.0 | 19.784 ns | 10.6857 ns | 0.5857 ns | 19.683 ns |  1.05 |    0.03 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                          From_Double_Nullable_NoValue | .NET Core 3.1 |  8.706 ns |  1.5753 ns | 0.0863 ns |  8.683 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 5.0 |  6.169 ns |  1.9274 ns | 0.1056 ns |  6.162 ns |  0.71 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 3.1 | 11.815 ns |  4.3686 ns | 0.2395 ns | 11.779 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 5.0 | 11.423 ns |  1.5698 ns | 0.0860 ns | 11.437 ns |  0.97 |    0.03 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                            From_Short | .NET Core 3.1 |  7.891 ns |  1.2412 ns | 0.0680 ns |  7.915 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 5.0 |  7.616 ns |  0.4264 ns | 0.0234 ns |  7.604 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                   From_Short_AsObject | .NET Core 3.1 | 18.326 ns |  4.7955 ns | 0.2629 ns | 18.188 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 5.0 | 17.022 ns |  3.8131 ns | 0.2090 ns | 17.079 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                         From_Short_Nullable_WithValue | .NET Core 3.1 |  9.471 ns |  2.2675 ns | 0.1243 ns |  9.452 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 5.0 |  7.364 ns |  2.3987 ns | 0.1315 ns |  7.340 ns |  0.78 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                From_Short_Nullable_WithValue_AsObject | .NET Core 3.1 | 17.295 ns |  5.6449 ns | 0.3094 ns | 17.154 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 5.0 | 17.841 ns | 17.9722 ns | 0.9851 ns | 17.399 ns |  1.03 |    0.04 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                           From_Short_Nullable_NoValue | .NET Core 3.1 |  8.195 ns |  1.4479 ns | 0.0794 ns |  8.162 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 5.0 |  6.665 ns | 13.4866 ns | 0.7392 ns |  6.723 ns |  0.81 |    0.08 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 3.1 | 12.936 ns |  0.4070 ns | 0.0223 ns | 12.944 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 5.0 | 11.172 ns |  0.9865 ns | 0.0541 ns | 11.175 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                              From_Int | .NET Core 3.1 |  7.699 ns |  0.8108 ns | 0.0444 ns |  7.692 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 5.0 |  7.152 ns |  1.6513 ns | 0.0905 ns |  7.197 ns |  0.93 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                     From_Int_AsObject | .NET Core 3.1 | 17.750 ns | 15.1933 ns | 0.8328 ns | 17.589 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 5.0 | 17.825 ns | 17.1920 ns | 0.9424 ns | 18.002 ns |  1.01 |    0.08 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                           From_Int_Nullable_WithValue | .NET Core 3.1 |  8.359 ns |  0.3815 ns | 0.0209 ns |  8.353 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 5.0 |  7.418 ns |  1.9415 ns | 0.1064 ns |  7.369 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 3.1 | 17.396 ns |  3.1139 ns | 0.1707 ns | 17.416 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 5.0 | 16.873 ns |  3.4521 ns | 0.1892 ns | 16.838 ns |  0.97 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                             From_Int_Nullable_NoValue | .NET Core 3.1 |  8.001 ns |  1.0577 ns | 0.0580 ns |  8.022 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 5.0 |  5.768 ns |  0.4808 ns | 0.0264 ns |  5.766 ns |  0.72 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 3.1 | 13.083 ns |  2.4700 ns | 0.1354 ns | 13.050 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 5.0 | 11.179 ns |  0.4540 ns | 0.0249 ns | 11.193 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                             From_Long | .NET Core 3.1 |  8.165 ns |  0.3063 ns | 0.0168 ns |  8.156 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Long | .NET Core 5.0 |  7.445 ns |  0.8852 ns | 0.0485 ns |  7.437 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                    From_Long_AsObject | .NET Core 3.1 | 17.609 ns |  2.4072 ns | 0.1319 ns | 17.565 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 5.0 | 16.777 ns |  2.7521 ns | 0.1509 ns | 16.719 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                          From_Long_Nullable_WithValue | .NET Core 3.1 |  9.472 ns |  3.4462 ns | 0.1889 ns |  9.397 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 5.0 |  8.171 ns |  1.7277 ns | 0.0947 ns |  8.138 ns |  0.86 |    0.03 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 3.1 | 17.523 ns |  3.5854 ns | 0.1965 ns | 17.607 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 5.0 | 16.831 ns |  1.6609 ns | 0.0910 ns | 16.779 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                            From_Long_Nullable_NoValue | .NET Core 3.1 |  8.289 ns |  0.2207 ns | 0.0121 ns |  8.284 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 5.0 |  5.792 ns |  0.2957 ns | 0.0162 ns |  5.793 ns |  0.70 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 3.1 | 13.061 ns |  3.6561 ns | 0.2004 ns | 12.950 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 5.0 | 11.185 ns |  1.7479 ns | 0.0958 ns | 11.240 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                            From_SByte | .NET Core 3.1 |  7.896 ns |  0.3855 ns | 0.0211 ns |  7.893 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 5.0 |  7.668 ns |  0.4064 ns | 0.0223 ns |  7.665 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                   From_SByte_AsObject | .NET Core 3.1 | 17.299 ns |  2.4442 ns | 0.1340 ns | 17.235 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 5.0 | 16.678 ns |  0.3555 ns | 0.0195 ns | 16.681 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                         From_SByte_Nullable_WithValue | .NET Core 3.1 |  8.402 ns |  0.5884 ns | 0.0323 ns |  8.408 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 5.0 |  7.445 ns |  0.4842 ns | 0.0265 ns |  7.458 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 3.1 | 17.347 ns |  0.3598 ns | 0.0197 ns | 17.354 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 5.0 | 16.902 ns |  2.4918 ns | 0.1366 ns | 16.935 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                           From_SByte_Nullable_NoValue | .NET Core 3.1 |  8.200 ns |  0.5972 ns | 0.0327 ns |  8.207 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 5.0 |  5.746 ns |  1.4145 ns | 0.0775 ns |  5.756 ns |  0.70 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 3.1 | 12.942 ns |  0.1621 ns | 0.0089 ns | 12.942 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 5.0 | 11.160 ns |  2.7981 ns | 0.1534 ns | 11.083 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                            From_Float | .NET Core 3.1 | 10.481 ns |  0.3014 ns | 0.0165 ns | 10.483 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 5.0 | 10.232 ns |  3.8578 ns | 0.2115 ns | 10.137 ns |  0.98 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                   From_Float_AsObject | .NET Core 3.1 | 19.270 ns |  3.8120 ns | 0.2090 ns | 19.316 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 5.0 | 18.805 ns |  2.0969 ns | 0.1149 ns | 18.756 ns |  0.98 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                         From_Float_Nullable_WithValue | .NET Core 3.1 | 10.481 ns |  0.5323 ns | 0.0292 ns | 10.465 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 5.0 | 10.014 ns |  1.8234 ns | 0.0999 ns | 10.071 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                From_Float_Nullable_WithValue_AsObject | .NET Core 3.1 | 19.125 ns |  3.9126 ns | 0.2145 ns | 19.040 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 5.0 | 18.826 ns |  0.6584 ns | 0.0361 ns | 18.844 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                           From_Float_Nullable_NoValue | .NET Core 3.1 |  8.146 ns |  0.4132 ns | 0.0226 ns |  8.151 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 5.0 |  7.133 ns |  0.7625 ns | 0.0418 ns |  7.119 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 3.1 | 12.934 ns |  0.4225 ns | 0.0232 ns | 12.922 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 5.0 | 11.175 ns |  0.9517 ns | 0.0522 ns | 11.166 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                           From_String | .NET Core 3.1 | 24.294 ns |  2.5450 ns | 0.1395 ns | 24.274 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 5.0 | 20.161 ns |  1.8348 ns | 0.1006 ns | 20.210 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                  From_String_AsObject | .NET Core 3.1 | 28.507 ns | 24.0691 ns | 1.3193 ns | 28.127 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 5.0 | 24.906 ns |  1.0113 ns | 0.0554 ns | 24.928 ns |  0.87 |    0.04 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                      From_String_Null | .NET Core 3.1 | 11.860 ns |  0.6042 ns | 0.0331 ns | 11.858 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 5.0 | 10.620 ns |  0.3537 ns | 0.0194 ns | 10.615 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                             From_String_Null_AsObject | .NET Core 3.1 | 13.018 ns |  2.0316 ns | 0.1114 ns | 13.020 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 5.0 | 11.278 ns |  1.8891 ns | 0.1035 ns | 11.274 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                     From_String_Empty | .NET Core 3.1 | 12.734 ns |  1.9877 ns | 0.1090 ns | 12.742 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 5.0 | 11.726 ns |  1.6581 ns | 0.0909 ns | 11.717 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                            From_String_Empty_AsObject | .NET Core 3.1 |        NA |         NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 5.0 |        NA |         NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                           From_UShort | .NET Core 3.1 |  7.889 ns |  0.3246 ns | 0.0178 ns |  7.897 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 5.0 |  7.506 ns |  1.3142 ns | 0.0720 ns |  7.517 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                  From_UShort_AsObject | .NET Core 3.1 | 16.636 ns |  1.2061 ns | 0.0661 ns | 16.647 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 5.0 | 16.651 ns |  2.4257 ns | 0.1330 ns | 16.663 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                        From_UShort_Nullable_WithValue | .NET Core 3.1 |  8.367 ns |  0.1545 ns | 0.0085 ns |  8.368 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 5.0 |  7.501 ns |  0.1600 ns | 0.0088 ns |  7.498 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 3.1 | 16.910 ns |  4.8905 ns | 0.2681 ns | 17.017 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 5.0 | 16.602 ns |  2.0666 ns | 0.1133 ns | 16.641 ns |  0.98 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                          From_UShort_Nullable_NoValue | .NET Core 3.1 |  7.904 ns |  0.6633 ns | 0.0364 ns |  7.908 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 5.0 |  6.152 ns | 11.3161 ns | 0.6203 ns |  5.872 ns |  0.78 |    0.08 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 3.1 | 12.982 ns |  0.9099 ns | 0.0499 ns | 12.997 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 5.0 | 12.179 ns | 13.1722 ns | 0.7220 ns | 11.773 ns |  0.94 |    0.06 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                             From_UInt | .NET Core 3.1 |  7.995 ns |  0.3284 ns | 0.0180 ns |  8.005 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 5.0 |  7.267 ns |  1.8192 ns | 0.0997 ns |  7.277 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                    From_UInt_AsObject | .NET Core 3.1 | 23.819 ns |  0.5776 ns | 0.0317 ns | 23.820 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 5.0 | 22.406 ns |  3.5000 ns | 0.1918 ns | 22.459 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                          From_UInt_Nullable_WithValue | .NET Core 3.1 |  6.546 ns |  0.4488 ns | 0.0246 ns |  6.534 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 5.0 |  5.125 ns |  0.5842 ns | 0.0320 ns |  5.140 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 3.1 | 23.965 ns |  3.9431 ns | 0.2161 ns | 24.021 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 5.0 | 22.471 ns |  5.5782 ns | 0.3058 ns | 22.297 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                            From_UInt_Nullable_NoValue | .NET Core 3.1 |  6.454 ns |  0.3976 ns | 0.0218 ns |  6.464 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 5.0 |  5.102 ns |  1.4526 ns | 0.0796 ns |  5.065 ns |  0.79 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 3.1 | 13.596 ns |  2.9711 ns | 0.1629 ns | 13.536 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 5.0 | 11.299 ns |  2.2961 ns | 0.1259 ns | 11.235 ns |  0.83 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                            From_ULong | .NET Core 3.1 |  7.918 ns |  0.3017 ns | 0.0165 ns |  7.921 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 5.0 |  7.544 ns |  1.5880 ns | 0.0870 ns |  7.583 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                   From_ULong_AsObject | .NET Core 3.1 | 17.612 ns |  0.7430 ns | 0.0407 ns | 17.592 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 5.0 | 17.039 ns |  1.3275 ns | 0.0728 ns | 16.997 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                         From_ULong_Nullable_WithValue | .NET Core 3.1 |  8.967 ns |  1.6021 ns | 0.0878 ns |  8.927 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 5.0 |  8.161 ns |  0.4213 ns | 0.0231 ns |  8.173 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 3.1 | 21.817 ns |  1.9512 ns | 0.1070 ns | 21.765 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 5.0 | 16.815 ns |  0.6433 ns | 0.0353 ns | 16.813 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                           From_ULong_Nullable_NoValue | .NET Core 3.1 |  8.186 ns |  0.2345 ns | 0.0129 ns |  8.182 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 5.0 |  6.120 ns |  0.7155 ns | 0.0392 ns |  6.122 ns |  0.75 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 3.1 | 12.942 ns |  0.9855 ns | 0.0540 ns | 12.938 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 5.0 | 11.227 ns |  0.8273 ns | 0.0453 ns | 11.212 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                       From_NullObject | .NET Core 3.1 | 13.092 ns |  1.2890 ns | 0.0707 ns | 13.054 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 5.0 | 11.294 ns |  0.8562 ns | 0.0469 ns | 11.271 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                           From_DBNull | .NET Core 3.1 | 10.731 ns |  1.6251 ns | 0.0891 ns | 10.699 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 5.0 |  8.384 ns |  1.2837 ns | 0.0704 ns |  8.387 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                  From_DBNull_AsObject | .NET Core 3.1 | 14.403 ns |  0.8973 ns | 0.0492 ns | 14.389 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 5.0 | 11.285 ns |  1.4004 ns | 0.0768 ns | 11.309 ns |  0.78 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                 From_ConvertibleClass | .NET Core 3.1 | 14.454 ns | 10.5220 ns | 0.5767 ns | 14.240 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 5.0 | 14.033 ns |  1.0840 ns | 0.0594 ns | 14.009 ns |  0.97 |    0.04 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                        From_ConvertibleClass_AsObject | .NET Core 3.1 | 16.721 ns |  2.3344 ns | 0.1280 ns | 16.670 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 5.0 | 16.326 ns |  2.0073 ns | 0.1100 ns | 16.317 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                         From_ConvertibleClass_NoValue | .NET Core 3.1 | 11.392 ns |  0.3043 ns | 0.0167 ns | 11.385 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 5.0 | 10.800 ns |  1.0086 ns | 0.0553 ns | 10.777 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 3.1 | 12.401 ns |  3.8655 ns | 0.2119 ns | 12.429 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 5.0 | 11.382 ns |  0.1219 ns | 0.0067 ns | 11.386 ns |  0.92 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                              From_NonConvertibleClass | .NET Core 3.1 | 11.170 ns |  9.1983 ns | 0.5042 ns | 10.999 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 5.0 |  8.371 ns |  1.6826 ns | 0.0922 ns |  8.328 ns |  0.75 |    0.04 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                     From_NonConvertibleClass_AsObject | .NET Core 3.1 | 14.655 ns |  3.5228 ns | 0.1931 ns | 14.571 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 5.0 | 13.679 ns |  2.3451 ns | 0.1285 ns | 13.646 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                      From_NonConvertibleClass_NoValue | .NET Core 3.1 | 10.791 ns |  1.1247 ns | 0.0616 ns | 10.781 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 5.0 |  8.490 ns |  2.7151 ns | 0.1488 ns |  8.503 ns |  0.79 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 3.1 | 12.939 ns |  0.0711 ns | 0.0039 ns | 12.938 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 5.0 | 11.315 ns |  2.6434 ns | 0.1449 ns | 11.346 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                From_ConvertibleStruct | .NET Core 3.1 | 12.274 ns |  3.5403 ns | 0.1941 ns | 12.295 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 5.0 | 11.697 ns |  3.5485 ns | 0.1945 ns | 11.614 ns |  0.95 |    0.03 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                       From_ConvertibleStruct_AsObject | .NET Core 3.1 | 16.667 ns |  0.8633 ns | 0.0473 ns | 16.666 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 5.0 | 16.819 ns |  0.8286 ns | 0.0454 ns | 16.841 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 3.1 | 12.588 ns |  0.6139 ns | 0.0337 ns | 12.607 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 5.0 | 12.845 ns |  0.2067 ns | 0.0113 ns | 12.838 ns |  1.02 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.1 | 17.191 ns |  4.4389 ns | 0.2433 ns | 17.062 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 5.0 | 17.558 ns |  1.4349 ns | 0.0787 ns | 17.531 ns |  1.02 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 3.1 |  8.347 ns |  0.4883 ns | 0.0268 ns |  8.334 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 5.0 |  6.327 ns |  1.3081 ns | 0.0717 ns |  6.346 ns |  0.76 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.1 | 12.967 ns |  0.6859 ns | 0.0376 ns | 12.965 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 5.0 | 11.466 ns |  5.2203 ns | 0.2861 ns | 11.328 ns |  0.88 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                             From_NonConvertibleStruct | .NET Core 3.1 |  7.682 ns |  0.5511 ns | 0.0302 ns |  7.698 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 5.0 |  6.465 ns |  6.6447 ns | 0.3642 ns |  6.287 ns |  0.84 |    0.05 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                    From_NonConvertibleStruct_AsObject | .NET Core 3.1 | 15.792 ns |  3.1227 ns | 0.1712 ns | 15.715 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 5.0 | 13.191 ns |  2.3733 ns | 0.1301 ns | 13.201 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 3.1 |  7.755 ns |  0.9064 ns | 0.0497 ns |  7.736 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 5.0 |  6.233 ns |  0.8170 ns | 0.0448 ns |  6.229 ns |  0.80 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.1 | 14.774 ns |  0.7247 ns | 0.0397 ns | 14.782 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 5.0 | 13.110 ns |  1.2359 ns | 0.0677 ns | 13.148 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 3.1 |  7.922 ns |  0.2403 ns | 0.0132 ns |  7.919 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 5.0 |  6.272 ns |  0.2814 ns | 0.0154 ns |  6.280 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.1 | 13.143 ns |  6.3105 ns | 0.3459 ns | 13.014 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 5.0 | 11.627 ns |  1.1571 ns | 0.0634 ns | 11.601 ns |  0.89 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                             From_Enum | .NET Core 3.1 |  7.644 ns |  0.3855 ns | 0.0211 ns |  7.637 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 5.0 |  7.036 ns |  0.8513 ns | 0.0467 ns |  7.024 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                    From_Enum_AsObject | .NET Core 3.1 | 35.855 ns |  0.6178 ns | 0.0339 ns | 35.864 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject | .NET Core 5.0 | 24.911 ns |  5.8127 ns | 0.3186 ns | 24.729 ns |  0.69 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                          From_Enum_Nullable_WithValue | .NET Core 3.1 |  8.371 ns |  0.1860 ns | 0.0102 ns |  8.370 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 5.0 |  8.338 ns | 13.4861 ns | 0.7392 ns |  8.338 ns |  1.00 |    0.09 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 3.1 | 33.869 ns |  8.2081 ns | 0.4499 ns | 33.663 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 5.0 | 25.125 ns |  6.5800 ns | 0.3607 ns | 24.958 ns |  0.74 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                            From_Enum_Nullable_NoValue | .NET Core 3.1 |  7.899 ns |  0.7822 ns | 0.0429 ns |  7.896 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 5.0 |  6.044 ns |  0.5921 ns | 0.0325 ns |  6.036 ns |  0.77 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 3.1 | 14.179 ns |  1.7096 ns | 0.0937 ns | 14.228 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 5.0 | 11.477 ns |  0.6035 ns | 0.0331 ns | 11.471 ns |  0.81 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                      From_ParentClass | .NET Core 3.1 | 10.705 ns |  0.0702 ns | 0.0038 ns | 10.704 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 5.0 |  8.435 ns |  0.1216 ns | 0.0067 ns |  8.433 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                             From_ParentClass_AsObject | .NET Core 3.1 | 14.886 ns |  0.4096 ns | 0.0224 ns | 14.880 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 5.0 | 13.500 ns |  1.4809 ns | 0.0812 ns | 13.544 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                              From_ParentClass_NoValue | .NET Core 3.1 | 10.754 ns |  0.7932 ns | 0.0435 ns | 10.740 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 5.0 |  8.410 ns |  1.7640 ns | 0.0967 ns |  8.371 ns |  0.78 |    0.01 |      - |     - |     - |         - |

Benchmarks with issues:
  ConvertTo_UIntNullable.From_DateTime_AsObject: ShortRun(Toolchain=.NET Core 3.1, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_UIntNullable.From_DateTime_AsObject: ShortRun(Toolchain=.NET Core 5.0, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_UIntNullable.From_DateTime_Nullable_WithValue_AsObject: ShortRun(Toolchain=.NET Core 3.1, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_UIntNullable.From_DateTime_Nullable_WithValue_AsObject: ShortRun(Toolchain=.NET Core 5.0, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_UIntNullable.From_String_Empty_AsObject: ShortRun(Toolchain=.NET Core 3.1, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_UIntNullable.From_String_Empty_AsObject: ShortRun(Toolchain=.NET Core 5.0, IterationCount=3, LaunchCount=1, WarmupCount=3)
