
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

                                                Method |     Toolchain |      Mean |      Error |    StdDev |    Median | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------------------------------------------ |-------------- |----------:|-----------:|----------:|----------:|------:|--------:|-------:|------:|------:|----------:|
                     From_ParentClass_NoValue_AsObject | .NET Core 3.1 | 11.519 ns |  2.2674 ns | 0.1243 ns | 11.453 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 5.0 | 10.244 ns |  2.7985 ns | 0.1534 ns | 10.291 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                     From_ParentStruct | .NET Core 3.1 | 83.517 ns |  4.8736 ns | 0.2671 ns | 83.538 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 5.0 | 62.044 ns |  1.3932 ns | 0.0764 ns | 62.065 ns |  0.74 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                            From_ParentStruct_AsObject | .NET Core 3.1 | 22.524 ns |  4.6316 ns | 0.2539 ns | 22.570 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 5.0 | 21.804 ns | 12.3540 ns | 0.6772 ns | 21.701 ns |  0.97 |    0.03 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                  From_ParentStruct_Nullable_WithValue | .NET Core 3.1 | 81.866 ns |  0.3835 ns | 0.0210 ns | 81.868 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 5.0 | 67.805 ns | 25.8697 ns | 1.4180 ns | 67.089 ns |  0.83 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 3.1 | 22.048 ns |  0.7707 ns | 0.0422 ns | 22.032 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 5.0 | 21.652 ns |  5.8600 ns | 0.3212 ns | 21.765 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                    From_ParentStruct_Nullable_NoValue | .NET Core 3.1 | 55.932 ns |  2.3563 ns | 0.1292 ns | 55.929 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 5.0 | 41.939 ns |  2.1708 ns | 0.1190 ns | 41.923 ns |  0.75 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 3.1 | 11.564 ns |  2.0877 ns | 0.1144 ns | 11.546 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 5.0 | 10.063 ns |  2.8318 ns | 0.1552 ns | 10.010 ns |  0.87 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                             From_Bool | .NET Core 3.1 | 15.848 ns |  1.5072 ns | 0.0826 ns | 15.845 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 5.0 | 14.808 ns |  0.6738 ns | 0.0369 ns | 14.822 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                    From_Bool_AsObject | .NET Core 3.1 | 28.830 ns |  2.1714 ns | 0.1190 ns | 28.874 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 5.0 | 29.242 ns |  0.2516 ns | 0.0138 ns | 29.245 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                          From_Bool_Nullable_WithValue | .NET Core 3.1 | 16.312 ns |  0.9430 ns | 0.0517 ns | 16.314 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 5.0 | 15.431 ns |  1.5330 ns | 0.0840 ns | 15.413 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 3.1 | 29.057 ns |  5.9105 ns | 0.3240 ns | 28.889 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 5.0 | 30.234 ns | 12.8263 ns | 0.7031 ns | 30.483 ns |  1.04 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                            From_Bool_Nullable_NoValue | .NET Core 3.1 |  8.456 ns |  2.1909 ns | 0.1201 ns |  8.450 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 5.0 |  5.464 ns |  2.0388 ns | 0.1118 ns |  5.418 ns |  0.65 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 3.1 | 12.827 ns | 14.4198 ns | 0.7904 ns | 12.741 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 5.0 | 10.094 ns |  1.3414 ns | 0.0735 ns | 10.114 ns |  0.79 |    0.05 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                             From_Byte | .NET Core 3.1 | 17.625 ns |  2.7363 ns | 0.1500 ns | 17.587 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 5.0 | 14.807 ns |  0.4306 ns | 0.0236 ns | 14.804 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                    From_Byte_AsObject | .NET Core 3.1 | 28.887 ns |  4.0988 ns | 0.2247 ns | 28.815 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 5.0 | 29.332 ns |  6.1969 ns | 0.3397 ns | 29.164 ns |  1.02 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                          From_Byte_Nullable_WithValue | .NET Core 3.1 | 18.010 ns |  1.7682 ns | 0.0969 ns | 18.043 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 5.0 | 15.443 ns |  0.3783 ns | 0.0207 ns | 15.438 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 3.1 | 28.525 ns |  1.2817 ns | 0.0703 ns | 28.505 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 5.0 | 29.453 ns |  8.0476 ns | 0.4411 ns | 29.213 ns |  1.03 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                            From_Byte_Nullable_NoValue | .NET Core 3.1 |  7.970 ns |  1.1662 ns | 0.0639 ns |  7.938 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 5.0 |  5.463 ns |  1.5228 ns | 0.0835 ns |  5.418 ns |  0.69 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 3.1 | 11.518 ns |  1.5339 ns | 0.0841 ns | 11.498 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 5.0 | 10.055 ns |  2.4479 ns | 0.1342 ns | 10.016 ns |  0.87 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                             From_Char | .NET Core 3.1 | 15.768 ns |  0.3564 ns | 0.0195 ns | 15.760 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Char | .NET Core 5.0 | 14.702 ns |  0.4836 ns | 0.0265 ns | 14.704 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                    From_Char_AsObject | .NET Core 3.1 | 28.682 ns |  4.6505 ns | 0.2549 ns | 28.806 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 5.0 | 29.537 ns |  0.1506 ns | 0.0083 ns | 29.541 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                          From_Char_Nullable_WithValue | .NET Core 3.1 | 16.171 ns |  0.4398 ns | 0.0241 ns | 16.177 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 5.0 | 15.505 ns |  1.2646 ns | 0.0693 ns | 15.531 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 3.1 | 28.474 ns |  1.3818 ns | 0.0757 ns | 28.494 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 5.0 | 29.846 ns |  8.6098 ns | 0.4719 ns | 30.032 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                            From_Char_Nullable_NoValue | .NET Core 3.1 |  7.919 ns |  0.3986 ns | 0.0218 ns |  7.923 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 5.0 |  5.460 ns |  0.6858 ns | 0.0376 ns |  5.457 ns |  0.69 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 3.1 | 11.409 ns |  0.6876 ns | 0.0377 ns | 11.414 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 5.0 | 10.316 ns |  3.8043 ns | 0.2085 ns | 10.424 ns |  0.90 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                         From_DateTime | .NET Core 3.1 | 11.345 ns |  1.7981 ns | 0.0986 ns | 11.400 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 5.0 | 11.317 ns |  2.1301 ns | 0.1168 ns | 11.380 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                From_DateTime_AsObject | .NET Core 3.1 |        NA |         NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 5.0 |        NA |         NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                      From_DateTime_Nullable_WithValue | .NET Core 3.1 | 12.597 ns |  3.1615 ns | 0.1733 ns | 12.616 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 5.0 |  8.854 ns |  0.5394 ns | 0.0296 ns |  8.871 ns |  0.70 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 3.1 |        NA |         NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 5.0 |        NA |         NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                        From_DateTime_Nullable_NoValue | .NET Core 3.1 |  9.096 ns |  0.5068 ns | 0.0278 ns |  9.101 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 5.0 |  5.752 ns |  1.7912 ns | 0.0982 ns |  5.699 ns |  0.63 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 3.1 | 11.766 ns |  0.3487 ns | 0.0191 ns | 11.759 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 5.0 | 10.008 ns |  3.2337 ns | 0.1773 ns |  9.960 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                          From_Decimal | .NET Core 3.1 | 20.629 ns |  0.7922 ns | 0.0434 ns | 20.629 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 5.0 | 22.834 ns |  0.6547 ns | 0.0359 ns | 22.815 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                 From_Decimal_AsObject | .NET Core 3.1 | 32.726 ns |  4.8620 ns | 0.2665 ns | 32.740 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 5.0 | 37.143 ns |  2.0287 ns | 0.1112 ns | 37.101 ns |  1.13 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                       From_Decimal_Nullable_WithValue | .NET Core 3.1 | 26.088 ns |  1.8463 ns | 0.1012 ns | 26.124 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 5.0 | 23.219 ns |  1.2204 ns | 0.0669 ns | 23.188 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 3.1 | 33.358 ns | 15.9556 ns | 0.8746 ns | 33.402 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 5.0 | 36.825 ns |  1.5621 ns | 0.0856 ns | 36.796 ns |  1.10 |    0.03 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                         From_Decimal_Nullable_NoValue | .NET Core 3.1 |  9.313 ns |  0.5697 ns | 0.0312 ns |  9.309 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 5.0 |  6.008 ns |  4.0794 ns | 0.2236 ns |  5.885 ns |  0.65 |    0.03 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 3.1 | 11.883 ns |  2.4277 ns | 0.1331 ns | 11.898 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 5.0 | 10.806 ns | 11.3644 ns | 0.6229 ns | 10.564 ns |  0.91 |    0.05 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                           From_Double | .NET Core 3.1 | 18.304 ns |  5.3382 ns | 0.2926 ns | 18.257 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 5.0 | 17.208 ns |  2.0444 ns | 0.1121 ns | 17.254 ns |  0.94 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                  From_Double_AsObject | .NET Core 3.1 | 30.355 ns |  2.2867 ns | 0.1253 ns | 30.293 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 5.0 | 30.961 ns |  1.1157 ns | 0.0612 ns | 30.931 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                        From_Double_Nullable_WithValue | .NET Core 3.1 | 20.329 ns |  0.4770 ns | 0.0261 ns | 20.333 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 5.0 | 17.719 ns |  2.4662 ns | 0.1352 ns | 17.663 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
               From_Double_Nullable_WithValue_AsObject | .NET Core 3.1 | 30.282 ns |  5.7383 ns | 0.3145 ns | 30.107 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 5.0 | 34.553 ns | 57.9477 ns | 3.1763 ns | 36.284 ns |  1.14 |    0.10 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                          From_Double_Nullable_NoValue | .NET Core 3.1 |  8.386 ns |  0.4240 ns | 0.0232 ns |  8.379 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 5.0 |  5.797 ns |  3.7335 ns | 0.2046 ns |  5.794 ns |  0.69 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 3.1 | 11.362 ns |  0.2296 ns | 0.0126 ns | 11.367 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 5.0 | 12.646 ns |  3.1041 ns | 0.1701 ns | 12.697 ns |  1.11 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                            From_Short | .NET Core 3.1 | 16.013 ns |  0.9406 ns | 0.0516 ns | 16.039 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 5.0 | 14.748 ns |  0.2647 ns | 0.0145 ns | 14.743 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                   From_Short_AsObject | .NET Core 3.1 | 29.065 ns | 15.2328 ns | 0.8350 ns | 28.743 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 5.0 | 29.205 ns |  3.6491 ns | 0.2000 ns | 29.095 ns |  1.01 |    0.03 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                         From_Short_Nullable_WithValue | .NET Core 3.1 | 16.273 ns |  0.5493 ns | 0.0301 ns | 16.289 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 5.0 | 15.475 ns |  0.4772 ns | 0.0262 ns | 15.483 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                From_Short_Nullable_WithValue_AsObject | .NET Core 3.1 | 28.732 ns |  1.9589 ns | 0.1074 ns | 28.742 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 5.0 | 29.483 ns |  8.8716 ns | 0.4863 ns | 29.700 ns |  1.03 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                           From_Short_Nullable_NoValue | .NET Core 3.1 |  7.942 ns |  0.3052 ns | 0.0167 ns |  7.934 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 5.0 |  5.409 ns |  0.8425 ns | 0.0462 ns |  5.420 ns |  0.68 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 3.1 | 11.463 ns |  0.5048 ns | 0.0277 ns | 11.462 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 5.0 | 10.037 ns |  2.1392 ns | 0.1173 ns |  9.975 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                              From_Int | .NET Core 3.1 | 15.778 ns |  5.5713 ns | 0.3054 ns | 15.618 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 5.0 | 14.775 ns |  0.8602 ns | 0.0471 ns | 14.753 ns |  0.94 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                     From_Int_AsObject | .NET Core 3.1 | 34.416 ns |  4.0303 ns | 0.2209 ns | 34.293 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 5.0 | 34.786 ns |  3.0552 ns | 0.1675 ns | 34.882 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                           From_Int_Nullable_WithValue | .NET Core 3.1 | 16.286 ns |  0.5597 ns | 0.0307 ns | 16.301 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 5.0 | 15.307 ns |  0.9095 ns | 0.0499 ns | 15.278 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 3.1 | 34.416 ns |  0.8847 ns | 0.0485 ns | 34.412 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 5.0 | 34.662 ns |  1.8032 ns | 0.0988 ns | 34.607 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                             From_Int_Nullable_NoValue | .NET Core 3.1 |  7.960 ns |  0.6264 ns | 0.0343 ns |  7.949 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 5.0 |  5.442 ns |  1.8708 ns | 0.1025 ns |  5.418 ns |  0.68 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 3.1 | 11.490 ns |  2.3005 ns | 0.1261 ns | 11.422 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 5.0 | 10.733 ns |  1.2585 ns | 0.0690 ns | 10.696 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                             From_Long | .NET Core 3.1 | 17.918 ns |  0.3388 ns | 0.0186 ns | 17.927 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Long | .NET Core 5.0 | 14.931 ns |  2.5729 ns | 0.1410 ns | 14.985 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                    From_Long_AsObject | .NET Core 3.1 | 29.244 ns |  0.6973 ns | 0.0382 ns | 29.237 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 5.0 | 30.015 ns |  9.6915 ns | 0.5312 ns | 30.283 ns |  1.03 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                          From_Long_Nullable_WithValue | .NET Core 3.1 | 18.791 ns |  1.0987 ns | 0.0602 ns | 18.792 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 5.0 | 15.964 ns |  1.2954 ns | 0.0710 ns | 15.941 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 3.1 | 29.379 ns |  4.2084 ns | 0.2307 ns | 29.286 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 5.0 | 29.575 ns |  0.9809 ns | 0.0538 ns | 29.561 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                            From_Long_Nullable_NoValue | .NET Core 3.1 |  8.687 ns |  4.2063 ns | 0.2306 ns |  8.814 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 5.0 |  6.997 ns | 24.8706 ns | 1.3632 ns |  7.716 ns |  0.80 |    0.14 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 3.1 | 11.477 ns |  1.3611 ns | 0.0746 ns | 11.440 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 5.0 | 10.245 ns |  1.4971 ns | 0.0821 ns | 10.216 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                            From_SByte | .NET Core 3.1 | 16.084 ns |  1.4938 ns | 0.0819 ns | 16.044 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 5.0 | 14.781 ns |  0.1560 ns | 0.0086 ns | 14.783 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                   From_SByte_AsObject | .NET Core 3.1 | 28.469 ns |  0.8979 ns | 0.0492 ns | 28.474 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 5.0 | 30.076 ns | 17.1242 ns | 0.9386 ns | 30.414 ns |  1.06 |    0.03 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                         From_SByte_Nullable_WithValue | .NET Core 3.1 | 16.375 ns |  0.9773 ns | 0.0536 ns | 16.395 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 5.0 | 15.406 ns |  1.8417 ns | 0.1010 ns | 15.437 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 3.1 | 28.720 ns |  7.4655 ns | 0.4092 ns | 28.522 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 5.0 | 29.133 ns |  5.2384 ns | 0.2871 ns | 29.212 ns |  1.01 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                           From_SByte_Nullable_NoValue | .NET Core 3.1 |  7.964 ns |  0.9770 ns | 0.0536 ns |  7.945 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 5.0 |  5.695 ns |  1.9422 ns | 0.1065 ns |  5.668 ns |  0.72 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 3.1 | 13.296 ns |  2.9436 ns | 0.1613 ns | 13.207 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 5.0 | 10.091 ns |  2.5033 ns | 0.1372 ns | 10.023 ns |  0.76 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                            From_Float | .NET Core 3.1 | 18.145 ns |  1.1778 ns | 0.0646 ns | 18.143 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 5.0 | 17.435 ns |  0.6714 ns | 0.0368 ns | 17.451 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                   From_Float_AsObject | .NET Core 3.1 | 30.768 ns |  2.6117 ns | 0.1432 ns | 30.685 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 5.0 | 31.310 ns |  2.4646 ns | 0.1351 ns | 31.233 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                         From_Float_Nullable_WithValue | .NET Core 3.1 | 19.948 ns |  2.5067 ns | 0.1374 ns | 20.019 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 5.0 | 17.762 ns |  4.0357 ns | 0.2212 ns | 17.718 ns |  0.89 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                From_Float_Nullable_WithValue_AsObject | .NET Core 3.1 | 30.681 ns |  3.0133 ns | 0.1652 ns | 30.691 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 5.0 | 31.248 ns |  2.1671 ns | 0.1188 ns | 31.248 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                           From_Float_Nullable_NoValue | .NET Core 3.1 |  8.455 ns |  0.9721 ns | 0.0533 ns |  8.433 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 5.0 |  5.527 ns |  1.0183 ns | 0.0558 ns |  5.546 ns |  0.65 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 3.1 | 12.154 ns |  2.2774 ns | 0.1248 ns | 12.085 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 5.0 | 10.016 ns |  3.3348 ns | 0.1828 ns |  9.929 ns |  0.82 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                           From_String | .NET Core 3.1 | 28.183 ns |  7.2962 ns | 0.3999 ns | 27.976 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 5.0 | 23.899 ns |  3.3762 ns | 0.1851 ns | 23.810 ns |  0.85 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                  From_String_AsObject | .NET Core 3.1 | 31.558 ns | 10.1030 ns | 0.5538 ns | 31.323 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 5.0 | 30.337 ns |  8.6071 ns | 0.4718 ns | 30.563 ns |  0.96 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                      From_String_Null | .NET Core 3.1 | 11.020 ns |  0.8245 ns | 0.0452 ns | 11.019 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 5.0 |  9.380 ns |  0.7283 ns | 0.0399 ns |  9.361 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                             From_String_Null_AsObject | .NET Core 3.1 | 11.849 ns |  1.1475 ns | 0.0629 ns | 11.835 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 5.0 | 10.955 ns |  8.8084 ns | 0.4828 ns | 10.688 ns |  0.92 |    0.04 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                     From_String_Empty | .NET Core 3.1 | 11.121 ns |  1.4564 ns | 0.0798 ns | 11.077 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 5.0 |  9.673 ns |  3.2328 ns | 0.1772 ns |  9.692 ns |  0.87 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                            From_String_Empty_AsObject | .NET Core 3.1 | 20.550 ns |  3.4770 ns | 0.1906 ns | 20.485 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 5.0 | 17.843 ns |  4.4250 ns | 0.2426 ns | 17.724 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                           From_UShort | .NET Core 3.1 | 18.200 ns | 10.1555 ns | 0.5567 ns | 18.171 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 5.0 | 14.826 ns |  0.6401 ns | 0.0351 ns | 14.807 ns |  0.82 |    0.03 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                  From_UShort_AsObject | .NET Core 3.1 | 36.485 ns | 40.4783 ns | 2.2188 ns | 36.258 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 5.0 | 29.182 ns |  1.5778 ns | 0.0865 ns | 29.191 ns |  0.80 |    0.05 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                        From_UShort_Nullable_WithValue | .NET Core 3.1 | 17.886 ns |  1.7749 ns | 0.0973 ns | 17.909 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 5.0 | 16.812 ns |  1.8521 ns | 0.1015 ns | 16.821 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 3.1 | 28.517 ns |  0.7205 ns | 0.0395 ns | 28.528 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 5.0 | 29.318 ns |  2.0865 ns | 0.1144 ns | 29.261 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                          From_UShort_Nullable_NoValue | .NET Core 3.1 |  8.005 ns |  0.4469 ns | 0.0245 ns |  7.992 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 5.0 |  5.577 ns |  1.9079 ns | 0.1046 ns |  5.543 ns |  0.70 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 3.1 | 11.533 ns |  2.6974 ns | 0.1479 ns | 11.612 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 5.0 | 10.045 ns |  3.6393 ns | 0.1995 ns |  9.944 ns |  0.87 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                             From_UInt | .NET Core 3.1 | 15.772 ns |  2.2934 ns | 0.1257 ns | 15.771 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 5.0 | 14.550 ns |  2.5266 ns | 0.1385 ns | 14.549 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                    From_UInt_AsObject | .NET Core 3.1 | 28.910 ns |  4.1997 ns | 0.2302 ns | 29.042 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 5.0 | 29.548 ns |  1.4088 ns | 0.0772 ns | 29.592 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                          From_UInt_Nullable_WithValue | .NET Core 3.1 | 17.881 ns |  0.5140 ns | 0.0282 ns | 17.882 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 5.0 | 14.962 ns |  1.9002 ns | 0.1042 ns | 14.923 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 3.1 | 29.121 ns |  7.6068 ns | 0.4170 ns | 29.082 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 5.0 | 29.660 ns |  2.9288 ns | 0.1605 ns | 29.673 ns |  1.02 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                            From_UInt_Nullable_NoValue | .NET Core 3.1 |  7.914 ns |  0.3683 ns | 0.0202 ns |  7.922 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 5.0 |  5.418 ns |  0.0617 ns | 0.0034 ns |  5.418 ns |  0.68 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 3.1 | 12.801 ns |  0.4296 ns | 0.0235 ns | 12.795 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 5.0 | 10.905 ns |  0.6307 ns | 0.0346 ns | 10.895 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                            From_ULong | .NET Core 3.1 | 16.338 ns |  1.8312 ns | 0.1004 ns | 16.331 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 5.0 | 15.097 ns |  1.1288 ns | 0.0619 ns | 15.108 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                   From_ULong_AsObject | .NET Core 3.1 | 29.411 ns |  3.2783 ns | 0.1797 ns | 29.413 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 5.0 | 30.323 ns |  3.5998 ns | 0.1973 ns | 30.268 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                         From_ULong_Nullable_WithValue | .NET Core 3.1 | 17.162 ns |  0.8661 ns | 0.0475 ns | 17.159 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 5.0 | 15.843 ns |  1.2126 ns | 0.0665 ns | 15.839 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 3.1 | 29.459 ns |  4.8616 ns | 0.2665 ns | 29.411 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 5.0 | 30.208 ns | 18.2342 ns | 0.9995 ns | 29.632 ns |  1.03 |    0.03 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                           From_ULong_Nullable_NoValue | .NET Core 3.1 |  8.504 ns |  1.1805 ns | 0.0647 ns |  8.497 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 5.0 |  5.579 ns |  1.2378 ns | 0.0678 ns |  5.596 ns |  0.66 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 3.1 | 11.480 ns |  3.4279 ns | 0.1879 ns | 11.388 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 5.0 | 10.059 ns |  0.7691 ns | 0.0422 ns | 10.040 ns |  0.88 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                       From_NullObject | .NET Core 3.1 | 13.081 ns |  2.5296 ns | 0.1387 ns | 13.046 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 5.0 | 10.058 ns |  1.9721 ns | 0.1081 ns | 10.060 ns |  0.77 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                           From_DBNull | .NET Core 3.1 | 11.581 ns |  2.6605 ns | 0.1458 ns | 11.533 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 5.0 | 10.067 ns |  5.8664 ns | 0.3216 ns | 10.197 ns |  0.87 |    0.03 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                  From_DBNull_AsObject | .NET Core 3.1 | 14.284 ns |  0.2219 ns | 0.0122 ns | 14.286 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 5.0 | 10.074 ns |  2.7162 ns | 0.1489 ns | 10.067 ns |  0.71 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                 From_ConvertibleClass | .NET Core 3.1 | 25.594 ns |  4.9771 ns | 0.2728 ns | 25.682 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 5.0 | 24.477 ns |  1.1471 ns | 0.0629 ns | 24.442 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                        From_ConvertibleClass_AsObject | .NET Core 3.1 | 28.179 ns |  3.6420 ns | 0.1996 ns | 28.071 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 5.0 | 29.047 ns |  2.8066 ns | 0.1538 ns | 29.020 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                         From_ConvertibleClass_NoValue | .NET Core 3.1 | 11.452 ns |  1.8422 ns | 0.1010 ns | 11.410 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 5.0 |  9.703 ns |  1.4539 ns | 0.0797 ns |  9.718 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 3.1 | 11.506 ns |  1.7046 ns | 0.0934 ns | 11.466 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 5.0 | 10.092 ns |  3.6944 ns | 0.2025 ns |  9.980 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                              From_NonConvertibleClass | .NET Core 3.1 | 18.607 ns |  4.4093 ns | 0.2417 ns | 18.671 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 5.0 | 15.846 ns |  2.4476 ns | 0.1342 ns | 15.905 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                     From_NonConvertibleClass_AsObject | .NET Core 3.1 | 22.018 ns |  3.9482 ns | 0.2164 ns | 21.909 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 5.0 | 21.331 ns |  0.9903 ns | 0.0543 ns | 21.335 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                      From_NonConvertibleClass_NoValue | .NET Core 3.1 | 11.594 ns |  2.2165 ns | 0.1215 ns | 11.550 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 5.0 |  9.623 ns |  1.0632 ns | 0.0583 ns |  9.632 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 3.1 | 12.772 ns |  0.4583 ns | 0.0251 ns | 12.780 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 5.0 | 11.294 ns |  1.0612 ns | 0.0582 ns | 11.262 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                From_ConvertibleStruct | .NET Core 3.1 | 21.266 ns |  0.6274 ns | 0.0344 ns | 21.262 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 5.0 | 20.454 ns |  2.1123 ns | 0.1158 ns | 20.449 ns |  0.96 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                       From_ConvertibleStruct_AsObject | .NET Core 3.1 | 28.743 ns |  1.3021 ns | 0.0714 ns | 28.704 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 5.0 | 29.244 ns |  2.3643 ns | 0.1296 ns | 29.317 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 3.1 | 22.474 ns | 16.4710 ns | 0.9028 ns | 22.102 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 5.0 | 21.081 ns |  2.1640 ns | 0.1186 ns | 21.044 ns |  0.94 |    0.04 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.1 | 28.790 ns | 10.8307 ns | 0.5937 ns | 28.467 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 5.0 | 29.958 ns |  4.5155 ns | 0.2475 ns | 29.824 ns |  1.04 |    0.03 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 3.1 |  8.018 ns |  1.0409 ns | 0.0571 ns |  7.995 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 5.0 |  5.393 ns |  0.8015 ns | 0.0439 ns |  5.383 ns |  0.67 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.1 | 11.523 ns |  4.4997 ns | 0.2466 ns | 11.426 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 5.0 | 10.129 ns |  2.4493 ns | 0.1343 ns | 10.191 ns |  0.88 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                             From_NonConvertibleStruct | .NET Core 3.1 | 12.641 ns |  2.7389 ns | 0.1501 ns | 12.665 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 5.0 | 10.164 ns |  0.8196 ns | 0.0449 ns | 10.169 ns |  0.80 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                    From_NonConvertibleStruct_AsObject | .NET Core 3.1 | 22.008 ns |  0.4175 ns | 0.0229 ns | 22.009 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 5.0 | 23.672 ns |  5.5116 ns | 0.3021 ns | 23.681 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 3.1 | 12.635 ns |  0.1446 ns | 0.0079 ns | 12.631 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 5.0 |  9.793 ns |  0.4070 ns | 0.0223 ns |  9.781 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.1 | 22.165 ns |  5.2056 ns | 0.2853 ns | 22.004 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 5.0 | 22.183 ns |  1.8460 ns | 0.1012 ns | 22.177 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 3.1 |  8.180 ns |  0.3405 ns | 0.0187 ns |  8.176 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 5.0 |  5.255 ns |  0.2944 ns | 0.0161 ns |  5.263 ns |  0.64 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.1 | 11.504 ns |  4.1872 ns | 0.2295 ns | 11.401 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 5.0 |  9.916 ns |  0.3025 ns | 0.0166 ns |  9.907 ns |  0.86 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                             From_Enum | .NET Core 3.1 |  7.951 ns |  0.6699 ns | 0.0367 ns |  7.943 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 5.0 |  7.246 ns |  0.5491 ns | 0.0301 ns |  7.239 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                    From_Enum_AsObject | .NET Core 3.1 | 21.386 ns |  6.6043 ns | 0.3620 ns | 21.210 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Enum_AsObject | .NET Core 5.0 | 20.602 ns |  3.2545 ns | 0.1784 ns | 20.559 ns |  0.96 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                          From_Enum_Nullable_WithValue | .NET Core 3.1 |  5.245 ns |  0.3331 ns | 0.0183 ns |  5.236 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 5.0 |  5.143 ns |  1.3798 ns | 0.0756 ns |  5.103 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 3.1 | 21.526 ns |  4.5086 ns | 0.2471 ns | 21.390 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 5.0 | 20.448 ns |  1.5658 ns | 0.0858 ns | 20.456 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                            From_Enum_Nullable_NoValue | .NET Core 3.1 |  5.959 ns |  1.4702 ns | 0.0806 ns |  5.953 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 5.0 |  5.115 ns |  0.2574 ns | 0.0141 ns |  5.110 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 3.1 | 11.702 ns |  0.7958 ns | 0.0436 ns | 11.688 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 5.0 | 10.014 ns |  1.0116 ns | 0.0555 ns |  9.991 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                      From_ParentClass | .NET Core 3.1 | 18.427 ns |  4.3143 ns | 0.2365 ns | 18.301 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 5.0 | 17.575 ns |  7.7632 ns | 0.4255 ns | 17.733 ns |  0.95 |    0.03 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                             From_ParentClass_AsObject | .NET Core 3.1 | 22.397 ns |  5.7053 ns | 0.3127 ns | 22.471 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 5.0 | 21.348 ns |  2.3591 ns | 0.1293 ns | 21.285 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                              From_ParentClass_NoValue | .NET Core 3.1 | 11.457 ns |  3.0383 ns | 0.1665 ns | 11.364 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 5.0 |  9.705 ns |  2.2518 ns | 0.1234 ns |  9.669 ns |  0.85 |    0.00 |      - |     - |     - |         - |

Benchmarks with issues:
  ConvertTo_EnumNullable.From_DateTime_AsObject: ShortRun(Toolchain=.NET Core 3.1, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_EnumNullable.From_DateTime_AsObject: ShortRun(Toolchain=.NET Core 5.0, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_EnumNullable.From_DateTime_Nullable_WithValue_AsObject: ShortRun(Toolchain=.NET Core 3.1, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_EnumNullable.From_DateTime_Nullable_WithValue_AsObject: ShortRun(Toolchain=.NET Core 5.0, IterationCount=3, LaunchCount=1, WarmupCount=3)
