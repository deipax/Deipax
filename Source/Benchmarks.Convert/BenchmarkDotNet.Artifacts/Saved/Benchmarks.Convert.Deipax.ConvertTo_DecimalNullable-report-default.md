
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

                                                Method |     Toolchain |      Mean |       Error |    StdDev |    Median | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------------------------------------------ |-------------- |----------:|------------:|----------:|----------:|------:|--------:|-------:|------:|------:|----------:|
                     From_ParentClass_NoValue_AsObject | .NET Core 3.1 | 17.250 ns |   5.5941 ns | 0.3066 ns | 17.264 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 5.0 | 12.436 ns |   0.6221 ns | 0.0341 ns | 12.420 ns |  0.72 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
                                     From_ParentStruct | .NET Core 3.1 | 36.664 ns |   1.5570 ns | 0.0853 ns | 36.641 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 5.0 | 28.414 ns |   4.3163 ns | 0.2366 ns | 28.437 ns |  0.78 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
                            From_ParentStruct_AsObject | .NET Core 3.1 | 15.479 ns |   3.1192 ns | 0.1710 ns | 15.477 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 5.0 | 14.915 ns |   2.3947 ns | 0.1313 ns | 14.843 ns |  0.96 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
                  From_ParentStruct_Nullable_WithValue | .NET Core 3.1 | 35.146 ns |   9.0481 ns | 0.4960 ns | 34.874 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 5.0 | 28.636 ns |   2.3612 ns | 0.1294 ns | 28.602 ns |  0.81 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 3.1 | 15.211 ns |   3.2541 ns | 0.1784 ns | 15.156 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 5.0 | 14.542 ns |   3.4505 ns | 0.1891 ns | 14.518 ns |  0.96 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
                    From_ParentStruct_Nullable_NoValue | .NET Core 3.1 | 35.882 ns |   4.3298 ns | 0.2373 ns | 35.751 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 5.0 | 29.047 ns |   1.2818 ns | 0.0703 ns | 29.039 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 3.1 | 12.462 ns |   4.6459 ns | 0.2547 ns | 12.330 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 5.0 | 12.829 ns |   4.2819 ns | 0.2347 ns | 12.846 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
                                             From_Bool | .NET Core 3.1 | 14.592 ns |   0.7231 ns | 0.0396 ns | 14.610 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 5.0 |  9.846 ns |   1.8051 ns | 0.0989 ns |  9.830 ns |  0.67 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
                                    From_Bool_AsObject | .NET Core 3.1 | 24.313 ns |   1.1842 ns | 0.0649 ns | 24.334 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 5.0 | 20.419 ns |   3.4932 ns | 0.1915 ns | 20.358 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
                          From_Bool_Nullable_WithValue | .NET Core 3.1 | 15.793 ns |   6.5834 ns | 0.3609 ns | 15.679 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 5.0 | 10.480 ns |   0.3232 ns | 0.0177 ns | 10.487 ns |  0.66 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 3.1 | 24.375 ns |   2.6222 ns | 0.1437 ns | 24.312 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 5.0 | 20.744 ns |   8.6386 ns | 0.4735 ns | 20.635 ns |  0.85 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
                            From_Bool_Nullable_NoValue | .NET Core 3.1 |  5.984 ns |   2.1307 ns | 0.1168 ns |  5.999 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 5.0 |  6.612 ns |   2.5798 ns | 0.1414 ns |  6.559 ns |  1.11 |    0.03 |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 3.1 | 13.816 ns |   2.4884 ns | 0.1364 ns | 13.874 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 5.0 | 12.472 ns |   0.1393 ns | 0.0076 ns | 12.470 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
                                             From_Byte | .NET Core 3.1 | 14.582 ns |   1.4497 ns | 0.0795 ns | 14.581 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 5.0 |  9.559 ns |   1.1108 ns | 0.0609 ns |  9.532 ns |  0.66 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
                                    From_Byte_AsObject | .NET Core 3.1 | 24.077 ns |   8.7957 ns | 0.4821 ns | 23.808 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 5.0 | 20.459 ns |   6.4484 ns | 0.3535 ns | 20.447 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
                          From_Byte_Nullable_WithValue | .NET Core 3.1 | 15.082 ns |   2.6087 ns | 0.1430 ns | 15.004 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 5.0 | 10.030 ns |   0.1601 ns | 0.0088 ns | 10.028 ns |  0.67 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 3.1 | 23.751 ns |   0.6780 ns | 0.0372 ns | 23.762 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 5.0 | 19.909 ns |   0.4232 ns | 0.0232 ns | 19.898 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
                            From_Byte_Nullable_NoValue | .NET Core 3.1 |  7.172 ns |   5.5045 ns | 0.3017 ns |  7.030 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 5.0 |  6.778 ns |  11.8921 ns | 0.6518 ns |  6.429 ns |  0.94 |    0.05 |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 3.1 | 14.681 ns |   3.3281 ns | 0.1824 ns | 14.586 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 5.0 | 12.671 ns |   3.4723 ns | 0.1903 ns | 12.746 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
                                             From_Char | .NET Core 3.1 |  6.754 ns |   1.4101 ns | 0.0773 ns |  6.717 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Char | .NET Core 5.0 |  5.880 ns |   0.2458 ns | 0.0135 ns |  5.879 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
                                    From_Char_AsObject | .NET Core 3.1 |        NA |          NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 5.0 |        NA |          NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
                          From_Char_Nullable_WithValue | .NET Core 3.1 |  5.670 ns |   1.7971 ns | 0.0985 ns |  5.614 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 5.0 |  6.098 ns |   0.2509 ns | 0.0138 ns |  6.091 ns |  1.08 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 3.1 |        NA |          NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 5.0 |        NA |          NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
                            From_Char_Nullable_NoValue | .NET Core 3.1 |  6.744 ns |   1.1226 ns | 0.0615 ns |  6.766 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 5.0 |  6.098 ns |   0.9546 ns | 0.0523 ns |  6.090 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 3.1 | 13.958 ns |   2.2065 ns | 0.1209 ns | 14.004 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 5.0 | 12.587 ns |   3.0740 ns | 0.1685 ns | 12.530 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
                                         From_DateTime | .NET Core 3.1 |  7.542 ns |   4.5986 ns | 0.2521 ns |  7.606 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 5.0 |  7.605 ns |   7.2896 ns | 0.3996 ns |  7.750 ns |  1.01 |    0.08 |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
                                From_DateTime_AsObject | .NET Core 3.1 |        NA |          NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 5.0 |        NA |          NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
                      From_DateTime_Nullable_WithValue | .NET Core 3.1 |  7.799 ns |   3.5865 ns | 0.1966 ns |  7.688 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 5.0 |  6.339 ns |   1.1975 ns | 0.0656 ns |  6.304 ns |  0.81 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 3.1 |        NA |          NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 5.0 |        NA |          NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
                        From_DateTime_Nullable_NoValue | .NET Core 3.1 |  7.536 ns |   0.2380 ns | 0.0130 ns |  7.535 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 5.0 |  6.444 ns |   1.1041 ns | 0.0605 ns |  6.409 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 3.1 | 13.794 ns |   1.1398 ns | 0.0625 ns | 13.764 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 5.0 | 12.643 ns |   1.3087 ns | 0.0717 ns | 12.625 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
                                          From_Decimal | .NET Core 3.1 | 10.444 ns |   0.0220 ns | 0.0012 ns | 10.444 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 5.0 |  9.823 ns |   0.3740 ns | 0.0205 ns |  9.813 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
                                 From_Decimal_AsObject | .NET Core 3.1 | 24.937 ns |   4.4925 ns | 0.2462 ns | 24.862 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 5.0 | 23.811 ns |   1.3842 ns | 0.0759 ns | 23.788 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
                       From_Decimal_Nullable_WithValue | .NET Core 3.1 |  7.818 ns |   2.0819 ns | 0.1141 ns |  7.789 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 5.0 |  6.040 ns |   2.1868 ns | 0.1199 ns |  6.057 ns |  0.77 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 3.1 | 27.399 ns |  13.2552 ns | 0.7266 ns | 27.759 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 5.0 | 24.026 ns |   8.3951 ns | 0.4602 ns | 23.807 ns |  0.88 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
                         From_Decimal_Nullable_NoValue | .NET Core 3.1 |  6.914 ns |   0.9113 ns | 0.0500 ns |  6.921 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 5.0 |  6.003 ns |   1.0814 ns | 0.0593 ns |  5.987 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 3.1 | 13.740 ns |   0.5252 ns | 0.0288 ns | 13.738 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 5.0 | 12.542 ns |   2.9096 ns | 0.1595 ns | 12.470 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
                                           From_Double | .NET Core 3.1 | 20.094 ns |   1.3413 ns | 0.0735 ns | 20.079 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 5.0 | 17.030 ns |   3.1521 ns | 0.1728 ns | 17.008 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
                                  From_Double_AsObject | .NET Core 3.1 | 31.957 ns |   6.0616 ns | 0.3323 ns | 31.861 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 5.0 | 31.273 ns |   3.8869 ns | 0.2131 ns | 31.293 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
                        From_Double_Nullable_WithValue | .NET Core 3.1 | 21.115 ns |   0.3499 ns | 0.0192 ns | 21.126 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 5.0 | 17.420 ns |   5.0004 ns | 0.2741 ns | 17.328 ns |  0.82 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
               From_Double_Nullable_WithValue_AsObject | .NET Core 3.1 | 31.437 ns |   1.6021 ns | 0.0878 ns | 31.394 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 5.0 | 32.722 ns |   2.8592 ns | 0.1567 ns | 32.738 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
                          From_Double_Nullable_NoValue | .NET Core 3.1 |  7.170 ns |   0.2354 ns | 0.0129 ns |  7.173 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 5.0 |  6.777 ns |   0.1608 ns | 0.0088 ns |  6.782 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 3.1 | 13.250 ns |   4.4081 ns | 0.2416 ns | 13.292 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 5.0 | 12.714 ns |   5.0875 ns | 0.2789 ns | 12.734 ns |  0.96 |    0.03 |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
                                            From_Short | .NET Core 3.1 | 14.845 ns |   0.2486 ns | 0.0136 ns | 14.839 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 5.0 |  9.823 ns |   1.9566 ns | 0.1072 ns |  9.765 ns |  0.66 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
                                   From_Short_AsObject | .NET Core 3.1 | 22.555 ns |   1.0519 ns | 0.0577 ns | 22.541 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 5.0 | 20.078 ns |   0.3308 ns | 0.0181 ns | 20.081 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
                         From_Short_Nullable_WithValue | .NET Core 3.1 | 15.136 ns |   0.8960 ns | 0.0491 ns | 15.112 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 5.0 | 10.288 ns |   1.4499 ns | 0.0795 ns | 10.263 ns |  0.68 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
                From_Short_Nullable_WithValue_AsObject | .NET Core 3.1 | 24.107 ns |   0.8071 ns | 0.0442 ns | 24.087 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 5.0 | 33.212 ns | 156.1721 ns | 8.5603 ns | 36.592 ns |  1.38 |    0.36 |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
                           From_Short_Nullable_NoValue | .NET Core 3.1 |  6.450 ns |   1.7341 ns | 0.0951 ns |  6.483 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 5.0 |  6.831 ns |   1.9459 ns | 0.1067 ns |  6.885 ns |  1.06 |    0.03 |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 3.1 | 13.618 ns |   1.2683 ns | 0.0695 ns | 13.595 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 5.0 | 13.872 ns |   6.2844 ns | 0.3445 ns | 13.771 ns |  1.02 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
                                              From_Int | .NET Core 3.1 | 14.362 ns |   0.7846 ns | 0.0430 ns | 14.354 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 5.0 |  9.853 ns |   1.9368 ns | 0.1062 ns |  9.805 ns |  0.69 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
                                     From_Int_AsObject | .NET Core 3.1 | 22.247 ns |   0.8280 ns | 0.0454 ns | 22.222 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 5.0 | 20.423 ns |   4.2960 ns | 0.2355 ns | 20.337 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
                           From_Int_Nullable_WithValue | .NET Core 3.1 | 15.282 ns |   1.8656 ns | 0.1023 ns | 15.245 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 5.0 | 10.254 ns |   1.0434 ns | 0.0572 ns | 10.229 ns |  0.67 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 3.1 | 24.253 ns |   7.0061 ns | 0.3840 ns | 24.139 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 5.0 | 20.333 ns |   0.3491 ns | 0.0191 ns | 20.325 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
                             From_Int_Nullable_NoValue | .NET Core 3.1 |  5.970 ns |   0.4118 ns | 0.0226 ns |  5.965 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 5.0 |  6.318 ns |   0.4129 ns | 0.0226 ns |  6.307 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 3.1 | 14.040 ns |   2.3055 ns | 0.1264 ns | 13.982 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 5.0 | 12.511 ns |   0.3506 ns | 0.0192 ns | 12.517 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
                                             From_Long | .NET Core 3.1 | 14.876 ns |   1.1053 ns | 0.0606 ns | 14.871 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Long | .NET Core 5.0 | 10.080 ns |   7.1087 ns | 0.3897 ns | 10.004 ns |  0.68 |    0.03 |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
                                    From_Long_AsObject | .NET Core 3.1 | 24.231 ns |   3.6176 ns | 0.1983 ns | 24.156 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 5.0 | 20.257 ns |   0.7616 ns | 0.0417 ns | 20.260 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
                          From_Long_Nullable_WithValue | .NET Core 3.1 | 15.971 ns |   2.4472 ns | 0.1341 ns | 16.018 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 5.0 | 10.836 ns |  16.1295 ns | 0.8841 ns | 10.576 ns |  0.68 |    0.05 |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 3.1 | 24.204 ns |   2.6168 ns | 0.1434 ns | 24.219 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 5.0 | 20.287 ns |   0.7195 ns | 0.0394 ns | 20.293 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
                            From_Long_Nullable_NoValue | .NET Core 3.1 |  7.605 ns |   2.0406 ns | 0.1119 ns |  7.547 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 5.0 |  6.628 ns |   3.8010 ns | 0.2083 ns |  6.556 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 3.1 | 13.988 ns |   3.1294 ns | 0.1715 ns | 14.035 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 5.0 | 12.394 ns |   0.4062 ns | 0.0223 ns | 12.389 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
                                            From_SByte | .NET Core 3.1 | 14.320 ns |   0.8330 ns | 0.0457 ns | 14.332 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 5.0 |  9.776 ns |   0.3091 ns | 0.0169 ns |  9.776 ns |  0.68 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
                                   From_SByte_AsObject | .NET Core 3.1 | 24.474 ns |   0.4238 ns | 0.0232 ns | 24.474 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 5.0 | 20.076 ns |   3.4775 ns | 0.1906 ns | 20.066 ns |  0.82 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
                         From_SByte_Nullable_WithValue | .NET Core 3.1 | 14.882 ns |   1.0621 ns | 0.0582 ns | 14.882 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 5.0 | 10.237 ns |   0.1796 ns | 0.0098 ns | 10.233 ns |  0.69 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 3.1 | 24.366 ns |   6.6468 ns | 0.3643 ns | 24.255 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 5.0 | 20.223 ns |   1.1257 ns | 0.0617 ns | 20.227 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
                           From_SByte_Nullable_NoValue | .NET Core 3.1 |  5.942 ns |   0.3666 ns | 0.0201 ns |  5.951 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 5.0 |  7.326 ns |   0.4798 ns | 0.0263 ns |  7.331 ns |  1.23 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 3.1 | 14.544 ns |   7.4278 ns | 0.4071 ns | 14.520 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 5.0 | 12.751 ns |   2.8445 ns | 0.1559 ns | 12.671 ns |  0.88 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
                                            From_Float | .NET Core 3.1 | 19.934 ns |   1.7921 ns | 0.0982 ns | 19.902 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 5.0 | 17.959 ns |   2.7534 ns | 0.1509 ns | 17.882 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
                                   From_Float_AsObject | .NET Core 3.1 | 28.843 ns |   4.7024 ns | 0.2578 ns | 28.982 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 5.0 | 29.601 ns |   1.7702 ns | 0.0970 ns | 29.631 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
                         From_Float_Nullable_WithValue | .NET Core 3.1 | 19.661 ns |   0.6896 ns | 0.0378 ns | 19.673 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 5.0 | 17.912 ns |   0.2663 ns | 0.0146 ns | 17.910 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
                From_Float_Nullable_WithValue_AsObject | .NET Core 3.1 | 30.122 ns |   4.5046 ns | 0.2469 ns | 30.020 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 5.0 | 29.542 ns |   1.7242 ns | 0.0945 ns | 29.556 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
                           From_Float_Nullable_NoValue | .NET Core 3.1 |  6.739 ns |   2.1920 ns | 0.1201 ns |  6.794 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 5.0 |  6.518 ns |   1.7222 ns | 0.0944 ns |  6.464 ns |  0.97 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 3.1 | 13.174 ns |   3.3029 ns | 0.1810 ns | 13.210 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 5.0 | 14.152 ns |   2.3526 ns | 0.1290 ns | 14.093 ns |  1.07 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
                                           From_String | .NET Core 3.1 | 60.811 ns |  23.2652 ns | 1.2752 ns | 60.347 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 5.0 | 59.582 ns |  42.5900 ns | 2.3345 ns | 58.547 ns |  0.98 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
                                  From_String_AsObject | .NET Core 3.1 | 63.967 ns |  21.9452 ns | 1.2029 ns | 63.415 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 5.0 | 66.149 ns |   2.5121 ns | 0.1377 ns | 66.164 ns |  1.03 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
                                      From_String_Null | .NET Core 3.1 | 11.383 ns |   2.6381 ns | 0.1446 ns | 11.459 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 5.0 | 11.082 ns |   1.4229 ns | 0.0780 ns | 11.049 ns |  0.97 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
                             From_String_Null_AsObject | .NET Core 3.1 | 13.079 ns |   0.9554 ns | 0.0524 ns | 13.108 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 5.0 | 12.317 ns |   1.7687 ns | 0.0969 ns | 12.264 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
                                     From_String_Empty | .NET Core 3.1 |  9.857 ns |   0.7725 ns | 0.0423 ns |  9.840 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 5.0 | 11.473 ns |   0.4839 ns | 0.0265 ns | 11.471 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
                            From_String_Empty_AsObject | .NET Core 3.1 |        NA |          NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 5.0 |        NA |          NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
                                           From_UShort | .NET Core 3.1 | 14.365 ns |   0.3748 ns | 0.0205 ns | 14.354 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 5.0 | 10.546 ns |   1.1729 ns | 0.0643 ns | 10.529 ns |  0.73 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
                                  From_UShort_AsObject | .NET Core 3.1 | 23.967 ns |   2.8917 ns | 0.1585 ns | 24.039 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 5.0 | 19.750 ns |   0.4732 ns | 0.0259 ns | 19.737 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
                        From_UShort_Nullable_WithValue | .NET Core 3.1 | 15.267 ns |   2.1407 ns | 0.1173 ns | 15.217 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 5.0 |  9.985 ns |   0.4396 ns | 0.0241 ns |  9.989 ns |  0.65 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 3.1 | 23.988 ns |   0.6326 ns | 0.0347 ns | 23.969 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 5.0 | 19.944 ns |   2.0109 ns | 0.1102 ns | 19.884 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
                          From_UShort_Nullable_NoValue | .NET Core 3.1 |  6.507 ns |   3.4996 ns | 0.1918 ns |  6.408 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 5.0 |  6.314 ns |   0.1715 ns | 0.0094 ns |  6.310 ns |  0.97 |    0.03 |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 3.1 | 13.112 ns |   0.2346 ns | 0.0129 ns | 13.113 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 5.0 | 13.501 ns |   1.6905 ns | 0.0927 ns | 13.482 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
                                             From_UInt | .NET Core 3.1 | 14.134 ns |   2.0271 ns | 0.1111 ns | 14.150 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 5.0 |  9.481 ns |   0.4764 ns | 0.0261 ns |  9.479 ns |  0.67 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
                                    From_UInt_AsObject | .NET Core 3.1 | 23.375 ns |   0.7193 ns | 0.0394 ns | 23.357 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 5.0 | 19.799 ns |   2.1392 ns | 0.1173 ns | 19.802 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
                          From_UInt_Nullable_WithValue | .NET Core 3.1 | 14.832 ns |   0.8531 ns | 0.0468 ns | 14.841 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 5.0 |  9.961 ns |   0.9385 ns | 0.0514 ns |  9.978 ns |  0.67 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 3.1 | 23.769 ns |   0.3160 ns | 0.0173 ns | 23.772 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 5.0 | 19.974 ns |   6.7331 ns | 0.3691 ns | 19.850 ns |  0.84 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
                            From_UInt_Nullable_NoValue | .NET Core 3.1 |  6.498 ns |   2.9233 ns | 0.1602 ns |  6.559 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 5.0 |  6.316 ns |   1.0851 ns | 0.0595 ns |  6.300 ns |  0.97 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 3.1 | 13.564 ns |   0.7652 ns | 0.0419 ns | 13.585 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 5.0 | 12.339 ns |   2.4400 ns | 0.1337 ns | 12.285 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
                                            From_ULong | .NET Core 3.1 | 14.552 ns |   2.6869 ns | 0.1473 ns | 14.578 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 5.0 |  9.532 ns |   1.0277 ns | 0.0563 ns |  9.519 ns |  0.66 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
                                   From_ULong_AsObject | .NET Core 3.1 | 24.025 ns |   0.3836 ns | 0.0210 ns | 24.035 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 5.0 | 19.778 ns |   2.2198 ns | 0.1217 ns | 19.806 ns |  0.82 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
                         From_ULong_Nullable_WithValue | .NET Core 3.1 | 15.880 ns |   0.5999 ns | 0.0329 ns | 15.864 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 5.0 |  9.973 ns |   0.7598 ns | 0.0416 ns |  9.985 ns |  0.63 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 3.1 | 23.847 ns |   1.3014 ns | 0.0713 ns | 23.852 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 5.0 | 19.930 ns |   0.8737 ns | 0.0479 ns | 19.950 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
                           From_ULong_Nullable_NoValue | .NET Core 3.1 |  7.489 ns |   2.7566 ns | 0.1511 ns |  7.412 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 5.0 |  6.535 ns |   1.1467 ns | 0.0629 ns |  6.560 ns |  0.87 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 3.1 | 13.788 ns |   0.2053 ns | 0.0113 ns | 13.785 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 5.0 | 12.378 ns |   2.4250 ns | 0.1329 ns | 12.304 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
                                       From_NullObject | .NET Core 3.1 | 13.780 ns |   2.3801 ns | 0.1305 ns | 13.723 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 5.0 | 12.333 ns |   0.9874 ns | 0.0541 ns | 12.349 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
                                           From_DBNull | .NET Core 3.1 | 10.137 ns |   1.6515 ns | 0.0905 ns | 10.115 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 5.0 |  9.840 ns |   1.8944 ns | 0.1038 ns |  9.810 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
                                  From_DBNull_AsObject | .NET Core 3.1 | 13.973 ns |   6.8158 ns | 0.3736 ns | 13.759 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 5.0 | 12.852 ns |   1.6064 ns | 0.0881 ns | 12.805 ns |  0.92 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
                                 From_ConvertibleClass | .NET Core 3.1 | 15.274 ns |   1.1065 ns | 0.0607 ns | 15.246 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 5.0 | 17.361 ns |   0.9936 ns | 0.0545 ns | 17.383 ns |  1.14 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
                        From_ConvertibleClass_AsObject | .NET Core 3.1 | 19.568 ns |   2.1345 ns | 0.1170 ns | 19.501 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 5.0 | 19.840 ns |   0.4742 ns | 0.0260 ns | 19.837 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
                         From_ConvertibleClass_NoValue | .NET Core 3.1 | 12.646 ns |   2.6250 ns | 0.1439 ns | 12.711 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 5.0 | 11.754 ns |   0.3868 ns | 0.0212 ns | 11.749 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 3.1 | 12.867 ns |   2.0987 ns | 0.1150 ns | 12.888 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 5.0 | 12.394 ns |   2.3788 ns | 0.1304 ns | 12.328 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
                              From_NonConvertibleClass | .NET Core 3.1 |  9.527 ns |   1.9874 ns | 0.1089 ns |  9.583 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 5.0 |  9.424 ns |   0.2811 ns | 0.0154 ns |  9.418 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
                     From_NonConvertibleClass_AsObject | .NET Core 3.1 | 14.226 ns |   0.2893 ns | 0.0159 ns | 14.232 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 5.0 | 14.048 ns |   0.4261 ns | 0.0234 ns | 14.039 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
                      From_NonConvertibleClass_NoValue | .NET Core 3.1 |  9.158 ns |   0.4987 ns | 0.0273 ns |  9.166 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 5.0 |  9.290 ns |   0.7173 ns | 0.0393 ns |  9.304 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 3.1 | 12.356 ns |   2.0659 ns | 0.1132 ns | 12.341 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 5.0 | 13.841 ns |   2.2716 ns | 0.1245 ns | 13.865 ns |  1.12 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
                                From_ConvertibleStruct | .NET Core 3.1 | 14.817 ns |   1.0548 ns | 0.0578 ns | 14.844 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 5.0 | 15.588 ns |   0.4648 ns | 0.0255 ns | 15.603 ns |  1.05 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
                       From_ConvertibleStruct_AsObject | .NET Core 3.1 | 19.511 ns |   0.8633 ns | 0.0473 ns | 19.488 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 5.0 | 20.565 ns |   0.9202 ns | 0.0504 ns | 20.547 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 3.1 | 15.538 ns |   0.9425 ns | 0.0517 ns | 15.511 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 5.0 | 15.213 ns |   3.1200 ns | 0.1710 ns | 15.268 ns |  0.98 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.1 | 20.364 ns |   2.1766 ns | 0.1193 ns | 20.405 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 5.0 | 20.768 ns |   2.9261 ns | 0.1604 ns | 20.785 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 3.1 |  6.829 ns |   1.4019 ns | 0.0768 ns |  6.801 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 5.0 |  7.241 ns |   1.2503 ns | 0.0685 ns |  7.222 ns |  1.06 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.1 | 13.046 ns |   3.1796 ns | 0.1743 ns | 13.005 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 5.0 | 12.934 ns |   6.0830 ns | 0.3334 ns | 12.853 ns |  0.99 |    0.03 |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
                             From_NonConvertibleStruct | .NET Core 3.1 |  6.554 ns |   0.1395 ns | 0.0076 ns |  6.556 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 5.0 |  7.014 ns |   5.4331 ns | 0.2978 ns |  6.845 ns |  1.07 |    0.05 |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
                    From_NonConvertibleStruct_AsObject | .NET Core 3.1 | 14.325 ns |   2.7177 ns | 0.1490 ns | 14.265 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 5.0 | 14.291 ns |   2.5842 ns | 0.1416 ns | 14.247 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 3.1 |  6.503 ns |   0.5881 ns | 0.0322 ns |  6.494 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 5.0 |  6.637 ns |   0.7650 ns | 0.0419 ns |  6.616 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.1 | 13.988 ns |   2.6392 ns | 0.1447 ns | 13.926 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 5.0 | 14.363 ns |   1.4347 ns | 0.0786 ns | 14.319 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 3.1 |  5.602 ns |   1.4935 ns | 0.0819 ns |  5.560 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 5.0 |  6.660 ns |   1.2105 ns | 0.0664 ns |  6.654 ns |  1.19 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.1 | 12.293 ns |   1.9670 ns | 0.1078 ns | 12.262 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 5.0 | 12.701 ns |   4.5121 ns | 0.2473 ns | 12.657 ns |  1.03 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
                                             From_Enum | .NET Core 3.1 | 14.608 ns |   0.6374 ns | 0.0349 ns | 14.600 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 5.0 |  9.770 ns |   0.7496 ns | 0.0411 ns |  9.766 ns |  0.67 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
                                    From_Enum_AsObject | .NET Core 3.1 | 40.409 ns |   5.5134 ns | 0.3022 ns | 40.372 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject | .NET Core 5.0 | 29.593 ns |  19.3798 ns | 1.0623 ns | 29.040 ns |  0.73 |    0.02 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
                          From_Enum_Nullable_WithValue | .NET Core 3.1 | 16.605 ns |   4.9929 ns | 0.2737 ns | 16.474 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 5.0 | 10.507 ns |   1.9423 ns | 0.1065 ns | 10.461 ns |  0.63 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 3.1 | 41.569 ns |  16.0083 ns | 0.8775 ns | 41.195 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 5.0 | 30.365 ns |   7.4709 ns | 0.4095 ns | 30.364 ns |  0.73 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
                            From_Enum_Nullable_NoValue | .NET Core 3.1 |  5.956 ns |   1.6003 ns | 0.0877 ns |  5.922 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 5.0 |  6.462 ns |   1.1346 ns | 0.0622 ns |  6.478 ns |  1.09 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 3.1 | 12.439 ns |   0.8750 ns | 0.0480 ns | 12.454 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 5.0 | 12.466 ns |   0.1986 ns | 0.0109 ns | 12.465 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
                                      From_ParentClass | .NET Core 3.1 |  9.232 ns |   1.5421 ns | 0.0845 ns |  9.192 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 5.0 |  9.541 ns |   0.5688 ns | 0.0312 ns |  9.540 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
                             From_ParentClass_AsObject | .NET Core 3.1 | 14.553 ns |   2.7048 ns | 0.1483 ns | 14.539 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 5.0 | 14.551 ns |   3.2450 ns | 0.1779 ns | 14.490 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |             |           |           |       |         |        |       |       |           |
                              From_ParentClass_NoValue | .NET Core 3.1 |  9.896 ns |   1.6817 ns | 0.0922 ns |  9.940 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 5.0 |  9.388 ns |   1.6337 ns | 0.0895 ns |  9.337 ns |  0.95 |    0.01 |      - |     - |     - |         - |

Benchmarks with issues:
  ConvertTo_DecimalNullable.From_Char_AsObject: ShortRun(Toolchain=.NET Core 3.1, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DecimalNullable.From_Char_AsObject: ShortRun(Toolchain=.NET Core 5.0, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DecimalNullable.From_Char_Nullable_WithValue_AsObject: ShortRun(Toolchain=.NET Core 3.1, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DecimalNullable.From_Char_Nullable_WithValue_AsObject: ShortRun(Toolchain=.NET Core 5.0, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DecimalNullable.From_DateTime_AsObject: ShortRun(Toolchain=.NET Core 3.1, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DecimalNullable.From_DateTime_AsObject: ShortRun(Toolchain=.NET Core 5.0, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DecimalNullable.From_DateTime_Nullable_WithValue_AsObject: ShortRun(Toolchain=.NET Core 3.1, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DecimalNullable.From_DateTime_Nullable_WithValue_AsObject: ShortRun(Toolchain=.NET Core 5.0, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DecimalNullable.From_String_Empty_AsObject: ShortRun(Toolchain=.NET Core 3.1, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DecimalNullable.From_String_Empty_AsObject: ShortRun(Toolchain=.NET Core 5.0, IterationCount=3, LaunchCount=1, WarmupCount=3)
