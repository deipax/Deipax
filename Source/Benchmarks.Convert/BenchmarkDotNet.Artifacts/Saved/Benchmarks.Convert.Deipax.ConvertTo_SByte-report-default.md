
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

                                                Method |     Toolchain |      Mean |      Error |    StdDev |    Median | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------------------------------------------ |-------------- |----------:|-----------:|----------:|----------:|------:|--------:|-------:|------:|------:|----------:|
                     From_ParentClass_NoValue_AsObject | .NET Core 3.1 | 13.645 ns |  1.7974 ns | 0.0985 ns | 13.702 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 5.0 | 16.199 ns |  1.3959 ns | 0.0765 ns | 16.169 ns |  1.19 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                     From_ParentStruct | .NET Core 3.1 | 34.169 ns |  1.9814 ns | 0.1086 ns | 34.133 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 5.0 | 28.215 ns |  4.2245 ns | 0.2316 ns | 28.269 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                            From_ParentStruct_AsObject | .NET Core 3.1 | 13.063 ns |  3.0715 ns | 0.1684 ns | 12.999 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 5.0 | 13.001 ns |  0.6461 ns | 0.0354 ns | 12.985 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                  From_ParentStruct_Nullable_WithValue | .NET Core 3.1 | 34.538 ns | 11.6720 ns | 0.6398 ns | 34.254 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 5.0 | 27.983 ns |  2.5166 ns | 0.1379 ns | 27.909 ns |  0.81 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 3.1 | 13.681 ns |  0.1563 ns | 0.0086 ns | 13.684 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 5.0 | 13.024 ns |  2.6614 ns | 0.1459 ns | 12.942 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                    From_ParentStruct_Nullable_NoValue | .NET Core 3.1 | 34.320 ns |  2.6529 ns | 0.1454 ns | 34.255 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 5.0 | 28.036 ns |  5.5574 ns | 0.3046 ns | 27.987 ns |  0.82 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 3.1 | 10.579 ns |  0.5614 ns | 0.0308 ns | 10.578 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 5.0 | 11.127 ns |  2.6208 ns | 0.1437 ns | 11.090 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                             From_Bool | .NET Core 3.1 |  5.167 ns |  0.9044 ns | 0.0496 ns |  5.144 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 5.0 |  5.154 ns |  2.8908 ns | 0.1585 ns |  5.166 ns |  1.00 |    0.03 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                    From_Bool_AsObject | .NET Core 3.1 | 14.207 ns |  2.1264 ns | 0.1166 ns | 14.212 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 5.0 | 14.973 ns |  0.9495 ns | 0.0520 ns | 14.951 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                          From_Bool_Nullable_WithValue | .NET Core 3.1 |  5.384 ns |  1.6917 ns | 0.0927 ns |  5.353 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 5.0 |  5.413 ns |  1.4391 ns | 0.0789 ns |  5.369 ns |  1.01 |    0.03 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 3.1 | 15.297 ns |  2.5799 ns | 0.1414 ns | 15.249 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 5.0 | 15.021 ns |  2.6515 ns | 0.1453 ns | 14.961 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                            From_Bool_Nullable_NoValue | .NET Core 3.1 |  7.253 ns |  0.1671 ns | 0.0092 ns |  7.247 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 5.0 |  5.182 ns |  0.2621 ns | 0.0144 ns |  5.190 ns |  0.71 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 3.1 | 12.700 ns |  0.7194 ns | 0.0394 ns | 12.703 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 5.0 | 11.609 ns |  1.4779 ns | 0.0810 ns | 11.595 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                             From_Byte | .NET Core 3.1 |  4.945 ns |  0.8104 ns | 0.0444 ns |  4.920 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 5.0 |  4.988 ns |  1.6254 ns | 0.0891 ns |  4.966 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                    From_Byte_AsObject | .NET Core 3.1 | 15.790 ns |  2.4662 ns | 0.1352 ns | 15.820 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 5.0 | 14.645 ns |  2.4050 ns | 0.1318 ns | 14.574 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                          From_Byte_Nullable_WithValue | .NET Core 3.1 |  6.763 ns |  1.3556 ns | 0.0743 ns |  6.732 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 5.0 |  5.379 ns |  1.6773 ns | 0.0919 ns |  5.330 ns |  0.80 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 3.1 | 15.868 ns |  0.3246 ns | 0.0178 ns | 15.868 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 5.0 | 14.607 ns |  2.9546 ns | 0.1620 ns | 14.580 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                            From_Byte_Nullable_NoValue | .NET Core 3.1 |  5.228 ns |  0.5169 ns | 0.0283 ns |  5.217 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 5.0 |  5.466 ns |  0.2926 ns | 0.0160 ns |  5.459 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 3.1 | 12.678 ns |  1.5907 ns | 0.0872 ns | 12.642 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 5.0 | 11.022 ns |  0.6318 ns | 0.0346 ns | 11.040 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                             From_Char | .NET Core 3.1 |  4.939 ns |  0.6089 ns | 0.0334 ns |  4.945 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Char | .NET Core 5.0 |  4.969 ns |  1.5776 ns | 0.0865 ns |  4.925 ns |  1.01 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                    From_Char_AsObject | .NET Core 3.1 | 15.839 ns |  3.6957 ns | 0.2026 ns | 15.723 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 5.0 | 15.546 ns |  5.7701 ns | 0.3163 ns | 15.367 ns |  0.98 |    0.03 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                          From_Char_Nullable_WithValue | .NET Core 3.1 |  6.026 ns |  1.2368 ns | 0.0678 ns |  5.995 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 5.0 |  5.354 ns |  1.6388 ns | 0.0898 ns |  5.313 ns |  0.89 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 3.1 | 16.035 ns |  3.5539 ns | 0.1948 ns | 15.962 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 5.0 | 15.104 ns |  2.2987 ns | 0.1260 ns | 15.105 ns |  0.94 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                            From_Char_Nullable_NoValue | .NET Core 3.1 |  6.513 ns |  0.9264 ns | 0.0508 ns |  6.492 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 5.0 |  6.167 ns |  0.1511 ns | 0.0083 ns |  6.169 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 3.1 | 12.804 ns |  1.9093 ns | 0.1047 ns | 12.840 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 5.0 | 11.159 ns |  1.6558 ns | 0.0908 ns | 11.193 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                         From_DateTime | .NET Core 3.1 |  6.236 ns |  1.5942 ns | 0.0874 ns |  6.262 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 5.0 |  6.263 ns |  0.6816 ns | 0.0374 ns |  6.248 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                From_DateTime_AsObject | .NET Core 3.1 |        NA |         NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 5.0 |        NA |         NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                      From_DateTime_Nullable_WithValue | .NET Core 3.1 |  6.420 ns |  1.6458 ns | 0.0902 ns |  6.447 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 5.0 |  4.880 ns |  0.0797 ns | 0.0044 ns |  4.882 ns |  0.76 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 3.1 |        NA |         NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 5.0 |        NA |         NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                        From_DateTime_Nullable_NoValue | .NET Core 3.1 |  6.755 ns |  1.6546 ns | 0.0907 ns |  6.775 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 5.0 |  4.987 ns |  1.4303 ns | 0.0784 ns |  5.028 ns |  0.74 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 3.1 | 11.369 ns |  1.8359 ns | 0.1006 ns | 11.328 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 5.0 | 11.242 ns |  2.6069 ns | 0.1429 ns | 11.162 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                          From_Decimal | .NET Core 3.1 | 13.619 ns |  0.6803 ns | 0.0373 ns | 13.620 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 5.0 | 12.648 ns |  4.9887 ns | 0.2735 ns | 12.779 ns |  0.93 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                 From_Decimal_AsObject | .NET Core 3.1 | 18.838 ns |  1.6492 ns | 0.0904 ns | 18.795 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 5.0 | 21.300 ns |  1.3121 ns | 0.0719 ns | 21.295 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                       From_Decimal_Nullable_WithValue | .NET Core 3.1 | 14.648 ns |  0.3427 ns | 0.0188 ns | 14.652 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 5.0 | 12.971 ns |  1.8234 ns | 0.0999 ns | 13.008 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 3.1 | 21.713 ns |  1.0942 ns | 0.0600 ns | 21.719 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 5.0 | 21.529 ns |  3.4668 ns | 0.1900 ns | 21.610 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                         From_Decimal_Nullable_NoValue | .NET Core 3.1 |  6.497 ns |  1.8021 ns | 0.0988 ns |  6.458 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 5.0 |  5.346 ns |  1.3579 ns | 0.0744 ns |  5.323 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 3.1 | 11.413 ns |  8.9248 ns | 0.4892 ns | 11.138 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 5.0 | 11.406 ns |  4.0354 ns | 0.2212 ns | 11.338 ns |  1.00 |    0.06 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                           From_Double | .NET Core 3.1 |  8.510 ns |  5.7157 ns | 0.3133 ns |  8.406 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 5.0 |  7.969 ns |  1.5116 ns | 0.0829 ns |  8.002 ns |  0.94 |    0.03 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                  From_Double_AsObject | .NET Core 3.1 | 19.487 ns |  0.9306 ns | 0.0510 ns | 19.500 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 5.0 | 18.103 ns |  1.4566 ns | 0.0798 ns | 18.144 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                        From_Double_Nullable_WithValue | .NET Core 3.1 | 12.045 ns |  2.7248 ns | 0.1494 ns | 11.963 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 5.0 |  8.273 ns |  2.9980 ns | 0.1643 ns |  8.219 ns |  0.69 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
               From_Double_Nullable_WithValue_AsObject | .NET Core 3.1 | 17.348 ns |  1.0488 ns | 0.0575 ns | 17.331 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 5.0 | 17.800 ns |  0.7426 ns | 0.0407 ns | 17.821 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                          From_Double_Nullable_NoValue | .NET Core 3.1 |  6.992 ns |  0.4203 ns | 0.0230 ns |  6.980 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 5.0 |  5.789 ns |  0.6056 ns | 0.0332 ns |  5.770 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 3.1 |  9.887 ns |  2.3037 ns | 0.1263 ns |  9.913 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 5.0 | 11.130 ns |  4.4815 ns | 0.2456 ns | 10.993 ns |  1.13 |    0.03 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                            From_Short | .NET Core 3.1 |  6.127 ns |  0.3056 ns | 0.0168 ns |  6.135 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 5.0 |  5.540 ns |  2.1255 ns | 0.1165 ns |  5.476 ns |  0.90 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                   From_Short_AsObject | .NET Core 3.1 | 15.312 ns |  2.9308 ns | 0.1606 ns | 15.230 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 5.0 | 15.213 ns |  4.4926 ns | 0.2463 ns | 15.115 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                         From_Short_Nullable_WithValue | .NET Core 3.1 |  7.563 ns |  2.4741 ns | 0.1356 ns |  7.487 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 5.0 |  6.683 ns |  3.6508 ns | 0.2001 ns |  6.748 ns |  0.88 |    0.03 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                From_Short_Nullable_WithValue_AsObject | .NET Core 3.1 | 15.885 ns |  1.3650 ns | 0.0748 ns | 15.859 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 5.0 | 15.181 ns |  4.0955 ns | 0.2245 ns | 15.082 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                           From_Short_Nullable_NoValue | .NET Core 3.1 |  6.552 ns |  3.1008 ns | 0.1700 ns |  6.481 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 5.0 |  5.215 ns |  2.2998 ns | 0.1261 ns |  5.162 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 3.1 | 11.323 ns |  0.2988 ns | 0.0164 ns | 11.322 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 5.0 | 11.215 ns |  2.6698 ns | 0.1463 ns | 11.194 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                              From_Int | .NET Core 3.1 |  6.100 ns |  0.7438 ns | 0.0408 ns |  6.106 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 5.0 |  5.478 ns |  0.6033 ns | 0.0331 ns |  5.462 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                     From_Int_AsObject | .NET Core 3.1 | 16.175 ns |  4.1193 ns | 0.2258 ns | 16.106 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 5.0 | 15.840 ns | 13.9534 ns | 0.7648 ns | 15.415 ns |  0.98 |    0.05 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                           From_Int_Nullable_WithValue | .NET Core 3.1 |  6.843 ns |  0.7855 ns | 0.0431 ns |  6.823 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 5.0 |  6.661 ns |  1.1090 ns | 0.0608 ns |  6.686 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 3.1 | 13.575 ns |  3.4360 ns | 0.1883 ns | 13.553 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 5.0 | 15.563 ns |  4.5866 ns | 0.2514 ns | 15.440 ns |  1.15 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                             From_Int_Nullable_NoValue | .NET Core 3.1 |  5.815 ns |  0.5447 ns | 0.0299 ns |  5.800 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 5.0 |  5.211 ns |  1.7071 ns | 0.0936 ns |  5.178 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 3.1 |  9.785 ns |  0.2267 ns | 0.0124 ns |  9.789 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 5.0 | 11.048 ns |  0.6701 ns | 0.0367 ns | 11.028 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                             From_Long | .NET Core 3.1 |  5.577 ns |  1.8637 ns | 0.1022 ns |  5.528 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Long | .NET Core 5.0 |  5.103 ns |  0.2059 ns | 0.0113 ns |  5.105 ns |  0.92 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                    From_Long_AsObject | .NET Core 3.1 | 15.196 ns |  0.1280 ns | 0.0070 ns | 15.195 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 5.0 | 15.611 ns |  4.1654 ns | 0.2283 ns | 15.739 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                          From_Long_Nullable_WithValue | .NET Core 3.1 |  8.931 ns |  1.3791 ns | 0.0756 ns |  8.905 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 5.0 |  5.689 ns |  0.3111 ns | 0.0171 ns |  5.693 ns |  0.64 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 3.1 | 17.284 ns |  5.6095 ns | 0.3075 ns | 17.162 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 5.0 | 15.576 ns |  4.7300 ns | 0.2593 ns | 15.483 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                            From_Long_Nullable_NoValue | .NET Core 3.1 |  7.249 ns |  1.7769 ns | 0.0974 ns |  7.228 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 5.0 |  5.492 ns |  7.0604 ns | 0.3870 ns |  5.287 ns |  0.76 |    0.06 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 3.1 | 11.328 ns |  0.4722 ns | 0.0259 ns | 11.322 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 5.0 | 11.845 ns |  0.1438 ns | 0.0079 ns | 11.842 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                            From_SByte | .NET Core 3.1 |  4.800 ns |  1.4975 ns | 0.0821 ns |  4.754 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 5.0 |  5.043 ns |  1.3072 ns | 0.0717 ns |  5.040 ns |  1.05 |    0.03 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                   From_SByte_AsObject | .NET Core 3.1 | 13.216 ns |  1.1589 ns | 0.0635 ns | 13.193 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 5.0 | 11.947 ns |  3.8456 ns | 0.2108 ns | 11.923 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                         From_SByte_Nullable_WithValue | .NET Core 3.1 |  5.955 ns |  1.5716 ns | 0.0861 ns |  5.932 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 5.0 |  5.292 ns |  0.6422 ns | 0.0352 ns |  5.287 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 3.1 | 10.543 ns |  0.8315 ns | 0.0456 ns | 10.542 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 5.0 | 11.797 ns |  1.6502 ns | 0.0905 ns | 11.754 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                           From_SByte_Nullable_NoValue | .NET Core 3.1 |  5.978 ns |  2.7340 ns | 0.1499 ns |  5.960 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 5.0 |  5.445 ns |  1.4065 ns | 0.0771 ns |  5.478 ns |  0.91 |    0.03 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 3.1 |  9.853 ns |  1.9853 ns | 0.1088 ns |  9.795 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 5.0 | 11.038 ns |  0.4397 ns | 0.0241 ns | 11.037 ns |  1.12 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                            From_Float | .NET Core 3.1 |  8.771 ns |  1.6030 ns | 0.0879 ns |  8.770 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 5.0 |  8.052 ns |  2.4163 ns | 0.1324 ns |  8.091 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                   From_Float_AsObject | .NET Core 3.1 | 17.683 ns |  3.5359 ns | 0.1938 ns | 17.599 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 5.0 | 18.087 ns |  6.1721 ns | 0.3383 ns | 18.254 ns |  1.02 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                         From_Float_Nullable_WithValue | .NET Core 3.1 |  9.203 ns |  0.5393 ns | 0.0296 ns |  9.186 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 5.0 |  8.700 ns |  0.4340 ns | 0.0238 ns |  8.691 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                From_Float_Nullable_WithValue_AsObject | .NET Core 3.1 | 15.430 ns |  3.7085 ns | 0.2033 ns | 15.360 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 5.0 | 17.781 ns |  0.9590 ns | 0.0526 ns | 17.798 ns |  1.15 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                           From_Float_Nullable_NoValue | .NET Core 3.1 |  5.422 ns |  6.6565 ns | 0.3649 ns |  5.218 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 5.0 |  5.205 ns |  1.7913 ns | 0.0982 ns |  5.149 ns |  0.96 |    0.04 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 3.1 | 11.247 ns |  3.3884 ns | 0.1857 ns | 11.271 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 5.0 | 11.088 ns |  0.2075 ns | 0.0114 ns | 11.084 ns |  0.99 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                           From_String | .NET Core 3.1 | 19.595 ns |  7.4141 ns | 0.4064 ns | 19.377 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 5.0 | 15.309 ns |  0.7804 ns | 0.0428 ns | 15.332 ns |  0.78 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                  From_String_AsObject | .NET Core 3.1 | 22.961 ns |  1.7589 ns | 0.0964 ns | 22.913 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 5.0 | 20.466 ns |  7.4154 ns | 0.4065 ns | 20.236 ns |  0.89 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                      From_String_Null | .NET Core 3.1 | 11.037 ns |  1.4484 ns | 0.0794 ns | 11.001 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 5.0 |  9.701 ns |  0.1952 ns | 0.0107 ns |  9.701 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                             From_String_Null_AsObject | .NET Core 3.1 | 11.108 ns |  2.6314 ns | 0.1442 ns | 11.038 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 5.0 | 11.175 ns |  2.4165 ns | 0.1325 ns | 11.124 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                     From_String_Empty | .NET Core 3.1 |  9.352 ns |  0.5808 ns | 0.0318 ns |  9.336 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 5.0 | 11.412 ns |  2.8337 ns | 0.1553 ns | 11.349 ns |  1.22 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                            From_String_Empty_AsObject | .NET Core 3.1 |        NA |         NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 5.0 |        NA |         NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                           From_UShort | .NET Core 3.1 |  4.940 ns |  0.2733 ns | 0.0150 ns |  4.935 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 5.0 |  4.989 ns |  1.9068 ns | 0.1045 ns |  4.952 ns |  1.01 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                  From_UShort_AsObject | .NET Core 3.1 | 15.536 ns |  3.4444 ns | 0.1888 ns | 15.467 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 5.0 | 15.101 ns |  9.1854 ns | 0.5035 ns | 15.086 ns |  0.97 |    0.04 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                        From_UShort_Nullable_WithValue | .NET Core 3.1 |  7.665 ns |  1.2610 ns | 0.0691 ns |  7.643 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 5.0 |  6.033 ns |  1.2294 ns | 0.0674 ns |  6.008 ns |  0.79 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 3.1 | 15.585 ns |  3.7906 ns | 0.2078 ns | 15.473 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 5.0 | 14.695 ns |  1.4522 ns | 0.0796 ns | 14.735 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                          From_UShort_Nullable_NoValue | .NET Core 3.1 |  5.791 ns |  0.7009 ns | 0.0384 ns |  5.777 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 5.0 |  5.213 ns |  1.6819 ns | 0.0922 ns |  5.184 ns |  0.90 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 3.1 | 12.575 ns |  0.5922 ns | 0.0325 ns | 12.558 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 5.0 | 11.073 ns |  0.6274 ns | 0.0344 ns | 11.058 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                             From_UInt | .NET Core 3.1 |  5.447 ns |  1.5952 ns | 0.0874 ns |  5.405 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 5.0 |  4.876 ns |  0.1862 ns | 0.0102 ns |  4.877 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                    From_UInt_AsObject | .NET Core 3.1 | 14.010 ns |  1.4334 ns | 0.0786 ns | 14.045 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 5.0 | 15.294 ns |  7.4974 ns | 0.4110 ns | 15.224 ns |  1.09 |    0.04 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                          From_UInt_Nullable_WithValue | .NET Core 3.1 |  5.406 ns |  1.0060 ns | 0.0551 ns |  5.402 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 5.0 |  6.878 ns |  0.4133 ns | 0.0227 ns |  6.867 ns |  1.27 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 3.1 | 15.667 ns |  0.8166 ns | 0.0448 ns | 15.693 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 5.0 | 14.715 ns |  2.0669 ns | 0.1133 ns | 14.745 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                            From_UInt_Nullable_NoValue | .NET Core 3.1 |  6.508 ns |  0.7840 ns | 0.0430 ns |  6.522 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 5.0 |  5.529 ns | 11.4449 ns | 0.6273 ns |  5.168 ns |  0.85 |    0.09 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 3.1 | 12.586 ns |  0.1306 ns | 0.0072 ns | 12.584 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 5.0 | 11.242 ns |  2.5565 ns | 0.1401 ns | 11.311 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                            From_ULong | .NET Core 3.1 |  5.597 ns |  0.1537 ns | 0.0084 ns |  5.593 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 5.0 |  4.972 ns |  1.3976 ns | 0.0766 ns |  5.006 ns |  0.89 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                   From_ULong_AsObject | .NET Core 3.1 | 16.310 ns |  1.3094 ns | 0.0718 ns | 16.309 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 5.0 | 14.733 ns |  2.7846 ns | 0.1526 ns | 14.679 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                         From_ULong_Nullable_WithValue | .NET Core 3.1 |  6.502 ns |  0.4842 ns | 0.0265 ns |  6.516 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 5.0 |  5.344 ns |  0.4350 ns | 0.0238 ns |  5.332 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 3.1 | 15.786 ns |  3.3777 ns | 0.1851 ns | 15.729 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 5.0 | 15.195 ns |  3.5294 ns | 0.1935 ns | 15.174 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                           From_ULong_Nullable_NoValue | .NET Core 3.1 |  6.409 ns |  0.4631 ns | 0.0254 ns |  6.401 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 5.0 |  5.313 ns |  1.7337 ns | 0.0950 ns |  5.297 ns |  0.83 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 3.1 | 11.393 ns |  1.4364 ns | 0.0787 ns | 11.364 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 5.0 | 11.303 ns |  1.9235 ns | 0.1054 ns | 11.352 ns |  0.99 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                       From_NullObject | .NET Core 3.1 | 11.113 ns |  2.4759 ns | 0.1357 ns | 11.040 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 5.0 | 11.483 ns |  2.5743 ns | 0.1411 ns | 11.413 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                           From_DBNull | .NET Core 3.1 |  9.218 ns |  0.1967 ns | 0.0108 ns |  9.218 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 5.0 |  9.069 ns |  2.4704 ns | 0.1354 ns |  8.992 ns |  0.98 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                  From_DBNull_AsObject | .NET Core 3.1 | 12.585 ns |  0.5927 ns | 0.0325 ns | 12.573 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 5.0 | 11.223 ns |  3.2899 ns | 0.1803 ns | 11.149 ns |  0.89 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                 From_ConvertibleClass | .NET Core 3.1 | 11.251 ns |  2.8655 ns | 0.1571 ns | 11.184 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 5.0 | 11.956 ns |  3.3410 ns | 0.1831 ns | 11.852 ns |  1.06 |    0.03 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                        From_ConvertibleClass_AsObject | .NET Core 3.1 | 15.024 ns |  0.3527 ns | 0.0193 ns | 15.030 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 5.0 | 13.588 ns |  4.0841 ns | 0.2239 ns | 13.461 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                         From_ConvertibleClass_NoValue | .NET Core 3.1 | 12.386 ns |  3.1190 ns | 0.1710 ns | 12.309 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 5.0 | 10.772 ns |  0.5962 ns | 0.0327 ns | 10.772 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 3.1 | 12.801 ns |  2.3272 ns | 0.1276 ns | 12.793 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 5.0 | 11.035 ns |  0.5876 ns | 0.0322 ns | 11.018 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                              From_NonConvertibleClass | .NET Core 3.1 |  8.404 ns |  2.1962 ns | 0.1204 ns |  8.465 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 5.0 |  8.619 ns |  9.6616 ns | 0.5296 ns |  8.315 ns |  1.03 |    0.08 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                     From_NonConvertibleClass_AsObject | .NET Core 3.1 | 12.819 ns |  1.4440 ns | 0.0792 ns | 12.794 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 5.0 | 12.724 ns |  2.8140 ns | 0.1542 ns | 12.644 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                      From_NonConvertibleClass_NoValue | .NET Core 3.1 |  9.079 ns |  0.3845 ns | 0.0211 ns |  9.075 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 5.0 |  8.822 ns |  5.7529 ns | 0.3153 ns |  8.855 ns |  0.97 |    0.04 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 3.1 | 11.693 ns |  1.1553 ns | 0.0633 ns | 11.667 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 5.0 | 11.177 ns |  2.6511 ns | 0.1453 ns | 11.124 ns |  0.96 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                From_ConvertibleStruct | .NET Core 3.1 |  9.810 ns |  2.8558 ns | 0.1565 ns |  9.849 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 5.0 | 10.302 ns |  1.5601 ns | 0.0855 ns | 10.314 ns |  1.05 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                       From_ConvertibleStruct_AsObject | .NET Core 3.1 | 15.809 ns |  0.4616 ns | 0.0253 ns | 15.803 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 5.0 | 14.708 ns |  0.6700 ns | 0.0367 ns | 14.696 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 3.1 | 12.220 ns |  8.5786 ns | 0.4702 ns | 12.123 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 5.0 | 11.035 ns |  4.3124 ns | 0.2364 ns | 11.048 ns |  0.90 |    0.05 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.1 | 17.218 ns |  6.7080 ns | 0.3677 ns | 17.017 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 5.0 | 15.656 ns |  4.5579 ns | 0.2498 ns | 15.673 ns |  0.91 |    0.03 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 3.1 |  5.966 ns |  0.6391 ns | 0.0350 ns |  5.947 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 5.0 |  6.321 ns |  2.9174 ns | 0.1599 ns |  6.232 ns |  1.06 |    0.03 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.1 | 11.763 ns |  1.9853 ns | 0.1088 ns | 11.702 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 5.0 | 11.247 ns |  2.8598 ns | 0.1568 ns | 11.314 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                             From_NonConvertibleStruct | .NET Core 3.1 |  4.927 ns |  0.9827 ns | 0.0539 ns |  4.904 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 5.0 |  6.236 ns |  1.6985 ns | 0.0931 ns |  6.203 ns |  1.27 |    0.03 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                    From_NonConvertibleStruct_AsObject | .NET Core 3.1 | 12.832 ns |  0.9931 ns | 0.0544 ns | 12.851 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 5.0 | 12.675 ns |  3.8357 ns | 0.2102 ns | 12.567 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 3.1 |  6.045 ns |  2.6870 ns | 0.1473 ns |  6.111 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 5.0 |  6.282 ns |  1.7172 ns | 0.0941 ns |  6.332 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.1 | 14.173 ns |  2.5658 ns | 0.1406 ns | 14.215 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 5.0 | 12.681 ns |  3.0808 ns | 0.1689 ns | 12.602 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 3.1 |  6.132 ns |  0.1995 ns | 0.0109 ns |  6.130 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 5.0 |  6.367 ns |  2.9755 ns | 0.1631 ns |  6.403 ns |  1.04 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.1 | 11.256 ns |  2.1813 ns | 0.1196 ns | 11.324 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 5.0 | 11.249 ns |  3.8417 ns | 0.2106 ns | 11.347 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                             From_Enum | .NET Core 3.1 |  5.993 ns |  0.2652 ns | 0.0145 ns |  5.988 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 5.0 |  5.914 ns |  2.2565 ns | 0.1237 ns |  5.982 ns |  0.99 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                    From_Enum_AsObject | .NET Core 3.1 | 32.280 ns |  5.7487 ns | 0.3151 ns | 32.400 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject | .NET Core 5.0 | 25.924 ns | 19.6504 ns | 1.0771 ns | 26.283 ns |  0.80 |    0.04 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                          From_Enum_Nullable_WithValue | .NET Core 3.1 |  7.789 ns |  2.1999 ns | 0.1206 ns |  7.730 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 5.0 |  6.845 ns |  0.5787 ns | 0.0317 ns |  6.833 ns |  0.88 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 3.1 | 33.939 ns |  9.9111 ns | 0.5433 ns | 33.946 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 5.0 | 27.288 ns |  5.1358 ns | 0.2815 ns | 27.140 ns |  0.80 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                            From_Enum_Nullable_NoValue | .NET Core 3.1 |  5.216 ns |  1.1772 ns | 0.0645 ns |  5.235 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 5.0 |  5.799 ns |  0.3662 ns | 0.0201 ns |  5.796 ns |  1.11 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 3.1 |  9.757 ns |  0.4805 ns | 0.0263 ns |  9.752 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 5.0 | 11.681 ns |  2.7526 ns | 0.1509 ns | 11.728 ns |  1.20 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                      From_ParentClass | .NET Core 3.1 | 10.379 ns |  0.8992 ns | 0.0493 ns | 10.366 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 5.0 |  8.423 ns |  2.3076 ns | 0.1265 ns |  8.453 ns |  0.81 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                             From_ParentClass_AsObject | .NET Core 3.1 | 14.370 ns |  0.4111 ns | 0.0225 ns | 14.377 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 5.0 | 13.012 ns |  1.3656 ns | 0.0749 ns | 12.989 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                              From_ParentClass_NoValue | .NET Core 3.1 |  9.119 ns |  1.9692 ns | 0.1079 ns |  9.154 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 5.0 |  8.368 ns |  0.6290 ns | 0.0345 ns |  8.377 ns |  0.92 |    0.01 |      - |     - |     - |         - |

Benchmarks with issues:
  ConvertTo_SByte.From_DateTime_AsObject: ShortRun(Toolchain=.NET Core 3.1, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_SByte.From_DateTime_AsObject: ShortRun(Toolchain=.NET Core 5.0, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_SByte.From_DateTime_Nullable_WithValue_AsObject: ShortRun(Toolchain=.NET Core 3.1, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_SByte.From_DateTime_Nullable_WithValue_AsObject: ShortRun(Toolchain=.NET Core 5.0, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_SByte.From_String_Empty_AsObject: ShortRun(Toolchain=.NET Core 3.1, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_SByte.From_String_Empty_AsObject: ShortRun(Toolchain=.NET Core 5.0, IterationCount=3, LaunchCount=1, WarmupCount=3)
