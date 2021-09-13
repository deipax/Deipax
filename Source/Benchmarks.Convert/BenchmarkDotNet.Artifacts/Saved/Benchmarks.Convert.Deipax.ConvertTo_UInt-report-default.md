
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

                                                Method |     Toolchain |      Mean |      Error |    StdDev |    Median | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------------------------------------------ |-------------- |----------:|-----------:|----------:|----------:|------:|--------:|-------:|------:|------:|----------:|
                     From_ParentClass_NoValue_AsObject | .NET Core 3.1 | 12.159 ns |  3.2940 ns | 0.1806 ns | 12.111 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 5.0 | 11.282 ns |  2.4255 ns | 0.1330 ns | 11.279 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                     From_ParentStruct | .NET Core 3.1 | 38.391 ns |  2.7438 ns | 0.1504 ns | 38.476 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 5.0 | 29.686 ns |  2.1335 ns | 0.1169 ns | 29.631 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                            From_ParentStruct_AsObject | .NET Core 3.1 | 14.489 ns |  4.2471 ns | 0.2328 ns | 14.485 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 5.0 | 13.035 ns |  1.9510 ns | 0.1069 ns | 13.066 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                  From_ParentStruct_Nullable_WithValue | .NET Core 3.1 | 33.849 ns |  4.8663 ns | 0.2667 ns | 33.786 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 5.0 | 35.118 ns |  6.0450 ns | 0.3313 ns | 35.251 ns |  1.04 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 3.1 | 13.500 ns |  1.1504 ns | 0.0631 ns | 13.515 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 5.0 | 13.322 ns |  3.4693 ns | 0.1902 ns | 13.304 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                    From_ParentStruct_Nullable_NoValue | .NET Core 3.1 | 37.968 ns | 44.6241 ns | 2.4460 ns | 38.940 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 5.0 | 27.818 ns |  2.5108 ns | 0.1376 ns | 27.849 ns |  0.73 |    0.05 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 3.1 | 13.276 ns |  1.2026 ns | 0.0659 ns | 13.284 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 5.0 | 11.070 ns |  1.6022 ns | 0.0878 ns | 11.025 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                             From_Bool | .NET Core 3.1 |  5.079 ns |  1.4058 ns | 0.0771 ns |  5.123 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 5.0 |  5.495 ns |  3.3733 ns | 0.1849 ns |  5.410 ns |  1.08 |    0.03 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                    From_Bool_AsObject | .NET Core 3.1 | 14.498 ns |  2.9923 ns | 0.1640 ns | 14.477 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 5.0 | 15.076 ns |  1.2566 ns | 0.0689 ns | 15.080 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                          From_Bool_Nullable_WithValue | .NET Core 3.1 |  5.333 ns |  0.4475 ns | 0.0245 ns |  5.322 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 5.0 |  6.025 ns |  1.0477 ns | 0.0574 ns |  5.994 ns |  1.13 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 3.1 | 13.880 ns |  1.2589 ns | 0.0690 ns | 13.876 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 5.0 | 14.944 ns |  0.5609 ns | 0.0307 ns | 14.944 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                            From_Bool_Nullable_NoValue | .NET Core 3.1 |  6.515 ns |  0.7637 ns | 0.0419 ns |  6.491 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 5.0 |  5.725 ns |  0.5892 ns | 0.0323 ns |  5.716 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 3.1 | 11.109 ns |  2.6283 ns | 0.1441 ns | 11.033 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 5.0 | 11.062 ns |  1.3876 ns | 0.0761 ns | 11.048 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                             From_Byte | .NET Core 3.1 |  4.800 ns |  1.1239 ns | 0.0616 ns |  4.816 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 5.0 |  6.569 ns |  1.3199 ns | 0.0724 ns |  6.550 ns |  1.37 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                    From_Byte_AsObject | .NET Core 3.1 | 12.372 ns |  1.8073 ns | 0.0991 ns | 12.327 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 5.0 | 14.928 ns |  3.7262 ns | 0.2042 ns | 15.034 ns |  1.21 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                          From_Byte_Nullable_WithValue | .NET Core 3.1 |  5.924 ns |  0.3313 ns | 0.0182 ns |  5.916 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 5.0 |  5.883 ns |  0.6187 ns | 0.0339 ns |  5.869 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 3.1 | 13.931 ns |  1.8175 ns | 0.0996 ns | 13.893 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 5.0 | 14.619 ns |  1.6853 ns | 0.0924 ns | 14.571 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                            From_Byte_Nullable_NoValue | .NET Core 3.1 |  5.753 ns |  0.0439 ns | 0.0024 ns |  5.754 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 5.0 |  5.749 ns |  1.3006 ns | 0.0713 ns |  5.732 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 3.1 | 10.501 ns |  0.8939 ns | 0.0490 ns | 10.493 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 5.0 | 12.371 ns |  0.1797 ns | 0.0098 ns | 12.372 ns |  1.18 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                             From_Char | .NET Core 3.1 |  4.912 ns |  4.2604 ns | 0.2335 ns |  4.785 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Char | .NET Core 5.0 |  5.246 ns |  0.5790 ns | 0.0317 ns |  5.231 ns |  1.07 |    0.05 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                    From_Char_AsObject | .NET Core 3.1 | 13.360 ns |  2.0677 ns | 0.1133 ns | 13.383 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 5.0 | 15.166 ns |  1.0443 ns | 0.0572 ns | 15.185 ns |  1.14 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                          From_Char_Nullable_WithValue | .NET Core 3.1 |  6.548 ns |  0.6664 ns | 0.0365 ns |  6.540 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 5.0 |  5.905 ns |  0.1764 ns | 0.0097 ns |  5.902 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 3.1 | 13.998 ns |  0.5589 ns | 0.0306 ns | 14.010 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 5.0 | 15.128 ns |  0.9055 ns | 0.0496 ns | 15.154 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                            From_Char_Nullable_NoValue | .NET Core 3.1 |  5.681 ns |  2.9739 ns | 0.1630 ns |  5.651 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 5.0 |  5.799 ns |  1.1765 ns | 0.0645 ns |  5.804 ns |  1.02 |    0.03 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 3.1 | 10.980 ns |  1.1250 ns | 0.0617 ns | 11.011 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 5.0 | 11.048 ns |  1.1768 ns | 0.0645 ns | 11.022 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                         From_DateTime | .NET Core 3.1 |  6.082 ns |  0.3623 ns | 0.0199 ns |  6.082 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 5.0 |  7.019 ns |  8.0063 ns | 0.4389 ns |  7.024 ns |  1.15 |    0.08 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                From_DateTime_AsObject | .NET Core 3.1 |        NA |         NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 5.0 |        NA |         NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                      From_DateTime_Nullable_WithValue | .NET Core 3.1 |  6.569 ns |  0.7111 ns | 0.0390 ns |  6.549 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 5.0 |  5.629 ns |  3.0155 ns | 0.1653 ns |  5.723 ns |  0.86 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 3.1 |        NA |         NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 5.0 |        NA |         NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                        From_DateTime_Nullable_NoValue | .NET Core 3.1 |  6.974 ns |  1.6960 ns | 0.0930 ns |  6.944 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 5.0 |  5.462 ns |  0.4670 ns | 0.0256 ns |  5.457 ns |  0.78 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 3.1 | 10.320 ns |  0.4425 ns | 0.0243 ns | 10.320 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 5.0 | 11.100 ns |  2.1016 ns | 0.1152 ns | 11.111 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                          From_Decimal | .NET Core 3.1 | 12.168 ns |  1.8258 ns | 0.1001 ns | 12.116 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 5.0 | 11.812 ns |  1.5246 ns | 0.0836 ns | 11.792 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                 From_Decimal_AsObject | .NET Core 3.1 | 16.880 ns |  1.3803 ns | 0.0757 ns | 16.837 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 5.0 | 20.590 ns |  1.1091 ns | 0.0608 ns | 20.590 ns |  1.22 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                       From_Decimal_Nullable_WithValue | .NET Core 3.1 | 14.370 ns |  0.6166 ns | 0.0338 ns | 14.350 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 5.0 | 12.438 ns |  0.4606 ns | 0.0252 ns | 12.452 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 3.1 | 19.410 ns |  1.5789 ns | 0.0865 ns | 19.372 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 5.0 | 20.568 ns |  2.6160 ns | 0.1434 ns | 20.610 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                         From_Decimal_Nullable_NoValue | .NET Core 3.1 |  6.630 ns |  1.5179 ns | 0.0832 ns |  6.593 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 5.0 |  5.990 ns |  0.8167 ns | 0.0448 ns |  5.973 ns |  0.90 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 3.1 | 10.094 ns |  0.4408 ns | 0.0242 ns | 10.086 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 5.0 | 11.134 ns |  1.1455 ns | 0.0628 ns | 11.129 ns |  1.10 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                           From_Double | .NET Core 3.1 |  7.191 ns |  0.9165 ns | 0.0502 ns |  7.182 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 5.0 |  7.562 ns |  0.5711 ns | 0.0313 ns |  7.555 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                  From_Double_AsObject | .NET Core 3.1 | 17.485 ns |  3.0018 ns | 0.1645 ns | 17.503 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 5.0 | 16.124 ns |  2.3944 ns | 0.1312 ns | 16.165 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                        From_Double_Nullable_WithValue | .NET Core 3.1 |  9.008 ns |  1.4152 ns | 0.0776 ns |  9.051 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 5.0 |  8.445 ns |  4.2973 ns | 0.2356 ns |  8.541 ns |  0.94 |    0.03 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
               From_Double_Nullable_WithValue_AsObject | .NET Core 3.1 | 17.327 ns |  0.6075 ns | 0.0333 ns | 17.320 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 5.0 | 15.994 ns |  0.9582 ns | 0.0525 ns | 16.002 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                          From_Double_Nullable_NoValue | .NET Core 3.1 |  6.619 ns |  1.0462 ns | 0.0573 ns |  6.640 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 5.0 |  6.310 ns |  9.9352 ns | 0.5446 ns |  6.031 ns |  0.95 |    0.08 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 3.1 | 11.532 ns |  1.6319 ns | 0.0894 ns | 11.492 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 5.0 | 11.357 ns |  1.4109 ns | 0.0773 ns | 11.322 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                            From_Short | .NET Core 3.1 |  5.164 ns |  1.4721 ns | 0.0807 ns |  5.175 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 5.0 |  6.178 ns |  2.2846 ns | 0.1252 ns |  6.165 ns |  1.20 |    0.04 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                   From_Short_AsObject | .NET Core 3.1 | 15.496 ns |  1.4743 ns | 0.0808 ns | 15.528 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 5.0 | 14.830 ns |  0.7215 ns | 0.0396 ns | 14.829 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                         From_Short_Nullable_WithValue | .NET Core 3.1 |  6.192 ns |  0.6712 ns | 0.0368 ns |  6.179 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 5.0 |  7.997 ns | 34.4979 ns | 1.8909 ns |  7.516 ns |  1.29 |    0.31 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                From_Short_Nullable_WithValue_AsObject | .NET Core 3.1 | 14.378 ns |  0.4104 ns | 0.0225 ns | 14.382 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 5.0 | 15.418 ns |  0.8530 ns | 0.0468 ns | 15.435 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                           From_Short_Nullable_NoValue | .NET Core 3.1 |  5.507 ns |  2.7839 ns | 0.1526 ns |  5.457 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 5.0 |  5.994 ns |  0.5184 ns | 0.0284 ns |  6.001 ns |  1.09 |    0.03 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 3.1 | 13.309 ns |  5.2163 ns | 0.2859 ns | 13.442 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 5.0 | 11.327 ns |  0.1150 ns | 0.0063 ns | 11.328 ns |  0.85 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                              From_Int | .NET Core 3.1 |  5.066 ns |  0.5345 ns | 0.0293 ns |  5.053 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 5.0 |  5.767 ns |  7.7934 ns | 0.4272 ns |  5.544 ns |  1.14 |    0.08 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                     From_Int_AsObject | .NET Core 3.1 | 14.079 ns |  0.4823 ns | 0.0264 ns | 14.093 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 5.0 | 14.778 ns |  6.1263 ns | 0.3358 ns | 14.609 ns |  1.05 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                           From_Int_Nullable_WithValue | .NET Core 3.1 |  7.158 ns |  0.9352 ns | 0.0513 ns |  7.162 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 5.0 |  6.020 ns |  0.7122 ns | 0.0390 ns |  6.021 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 3.1 | 15.258 ns |  1.3064 ns | 0.0716 ns | 15.277 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 5.0 | 14.575 ns |  0.9693 ns | 0.0531 ns | 14.597 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                             From_Int_Nullable_NoValue | .NET Core 3.1 |  7.303 ns |  8.5687 ns | 0.4697 ns |  7.286 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 5.0 |  5.919 ns |  5.8117 ns | 0.3186 ns |  5.750 ns |  0.81 |    0.07 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 3.1 | 11.332 ns |  1.4324 ns | 0.0785 ns | 11.374 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 5.0 | 11.027 ns |  0.2665 ns | 0.0146 ns | 11.034 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                             From_Long | .NET Core 3.1 |  5.932 ns |  0.2019 ns | 0.0111 ns |  5.932 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Long | .NET Core 5.0 |  5.437 ns |  1.1855 ns | 0.0650 ns |  5.411 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                    From_Long_AsObject | .NET Core 3.1 | 16.353 ns |  2.6645 ns | 0.1461 ns | 16.334 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 5.0 | 14.456 ns |  0.2209 ns | 0.0121 ns | 14.452 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                          From_Long_Nullable_WithValue | .NET Core 3.1 |  8.058 ns |  0.6365 ns | 0.0349 ns |  8.054 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 5.0 |  5.901 ns |  1.1381 ns | 0.0624 ns |  5.873 ns |  0.73 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 3.1 | 14.886 ns |  0.7648 ns | 0.0419 ns | 14.887 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 5.0 | 14.560 ns |  2.3408 ns | 0.1283 ns | 14.523 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                            From_Long_Nullable_NoValue | .NET Core 3.1 |  6.856 ns |  0.8310 ns | 0.0456 ns |  6.831 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 5.0 |  5.929 ns |  4.5240 ns | 0.2480 ns |  5.787 ns |  0.86 |    0.03 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 3.1 | 12.009 ns |  0.5697 ns | 0.0312 ns | 12.013 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 5.0 | 11.918 ns |  1.9580 ns | 0.1073 ns | 11.863 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                            From_SByte | .NET Core 3.1 |  6.775 ns |  2.6521 ns | 0.1454 ns |  6.782 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 5.0 |  5.391 ns |  0.5075 ns | 0.0278 ns |  5.382 ns |  0.80 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                   From_SByte_AsObject | .NET Core 3.1 | 19.573 ns | 34.7073 ns | 1.9024 ns | 18.680 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 5.0 | 14.476 ns |  1.9227 ns | 0.1054 ns | 14.453 ns |  0.74 |    0.07 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                         From_SByte_Nullable_WithValue | .NET Core 3.1 | 14.537 ns |  5.8674 ns | 0.3216 ns | 14.699 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 5.0 |  5.873 ns |  0.2627 ns | 0.0144 ns |  5.880 ns |  0.40 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 3.1 | 15.090 ns | 35.4347 ns | 1.9423 ns | 14.172 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 5.0 | 14.452 ns |  1.3038 ns | 0.0715 ns | 14.416 ns |  0.97 |    0.11 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                           From_SByte_Nullable_NoValue | .NET Core 3.1 |  5.191 ns |  0.5642 ns | 0.0309 ns |  5.190 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 5.0 |  5.701 ns |  0.2557 ns | 0.0140 ns |  5.695 ns |  1.10 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 3.1 | 11.181 ns |  1.7828 ns | 0.0977 ns | 11.224 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 5.0 | 10.971 ns |  1.0439 ns | 0.0572 ns | 10.943 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                            From_Float | .NET Core 3.1 |  7.090 ns |  0.9695 ns | 0.0531 ns |  7.069 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 5.0 |  7.685 ns |  0.4934 ns | 0.0270 ns |  7.674 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                   From_Float_AsObject | .NET Core 3.1 | 16.631 ns | 14.0006 ns | 0.7674 ns | 16.199 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 5.0 | 15.951 ns |  2.9752 ns | 0.1631 ns | 16.017 ns |  0.96 |    0.05 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                         From_Float_Nullable_WithValue | .NET Core 3.1 |  8.284 ns |  1.4820 ns | 0.0812 ns |  8.245 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 5.0 |  8.251 ns |  3.0245 ns | 0.1658 ns |  8.164 ns |  1.00 |    0.03 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                From_Float_Nullable_WithValue_AsObject | .NET Core 3.1 | 16.199 ns |  3.7346 ns | 0.2047 ns | 16.230 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 5.0 | 15.797 ns |  0.1765 ns | 0.0097 ns | 15.797 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                           From_Float_Nullable_NoValue | .NET Core 3.1 |  5.129 ns |  0.4013 ns | 0.0220 ns |  5.139 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 5.0 |  5.794 ns |  0.4058 ns | 0.0222 ns |  5.797 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 3.1 | 11.117 ns |  0.8118 ns | 0.0445 ns | 11.121 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 5.0 | 11.749 ns |  0.7929 ns | 0.0435 ns | 11.765 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                           From_String | .NET Core 3.1 | 19.233 ns |  4.4126 ns | 0.2419 ns | 19.289 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 5.0 | 17.723 ns |  2.4754 ns | 0.1357 ns | 17.717 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                  From_String_AsObject | .NET Core 3.1 | 24.008 ns |  1.4744 ns | 0.0808 ns | 24.047 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 5.0 | 22.668 ns | 11.8394 ns | 0.6490 ns | 22.294 ns |  0.94 |    0.03 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                      From_String_Null | .NET Core 3.1 | 10.236 ns |  3.5289 ns | 0.1934 ns | 10.199 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 5.0 | 10.575 ns |  1.8436 ns | 0.1011 ns | 10.627 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                             From_String_Null_AsObject | .NET Core 3.1 | 12.088 ns |  0.8581 ns | 0.0470 ns | 12.098 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 5.0 | 11.058 ns |  0.3796 ns | 0.0208 ns | 11.052 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                     From_String_Empty | .NET Core 3.1 | 10.174 ns |  2.2790 ns | 0.1249 ns | 10.157 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 5.0 | 10.635 ns |  1.3701 ns | 0.0751 ns | 10.662 ns |  1.05 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                            From_String_Empty_AsObject | .NET Core 3.1 |        NA |         NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 5.0 |        NA |         NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                           From_UShort | .NET Core 3.1 |  6.005 ns | 20.7572 ns | 1.1378 ns |  5.397 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 5.0 |  5.261 ns |  0.4473 ns | 0.0245 ns |  5.249 ns |  0.90 |    0.16 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                  From_UShort_AsObject | .NET Core 3.1 | 13.415 ns |  0.5669 ns | 0.0311 ns | 13.399 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 5.0 | 14.688 ns |  2.5340 ns | 0.1389 ns | 14.627 ns |  1.09 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                        From_UShort_Nullable_WithValue | .NET Core 3.1 |  5.383 ns |  1.7728 ns | 0.0972 ns |  5.431 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 5.0 |  5.923 ns |  0.4949 ns | 0.0271 ns |  5.932 ns |  1.10 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 3.1 | 13.753 ns |  0.7625 ns | 0.0418 ns | 13.737 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 5.0 | 14.724 ns |  2.7951 ns | 0.1532 ns | 14.700 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                          From_UShort_Nullable_NoValue | .NET Core 3.1 |  5.225 ns |  0.6684 ns | 0.0366 ns |  5.219 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 5.0 |  5.805 ns |  1.0768 ns | 0.0590 ns |  5.796 ns |  1.11 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 3.1 | 11.023 ns |  2.6686 ns | 0.1463 ns | 10.999 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 5.0 | 11.118 ns |  2.3705 ns | 0.1299 ns | 11.045 ns |  1.01 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                             From_UInt | .NET Core 3.1 |  5.907 ns |  0.6342 ns | 0.0348 ns |  5.920 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 5.0 |  4.769 ns |  0.3091 ns | 0.0169 ns |  4.766 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                    From_UInt_AsObject | .NET Core 3.1 | 11.907 ns |  1.4690 ns | 0.0805 ns | 11.949 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 5.0 | 11.772 ns |  0.7788 ns | 0.0427 ns | 11.749 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                          From_UInt_Nullable_WithValue | .NET Core 3.1 |  5.369 ns |  0.4456 ns | 0.0244 ns |  5.358 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 5.0 |  5.278 ns |  0.6381 ns | 0.0350 ns |  5.266 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 3.1 | 12.044 ns |  4.3175 ns | 0.2367 ns | 12.076 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 5.0 | 11.780 ns |  0.5120 ns | 0.0281 ns | 11.780 ns |  0.98 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                            From_UInt_Nullable_NoValue | .NET Core 3.1 |  5.169 ns |  1.2522 ns | 0.0686 ns |  5.143 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 5.0 |  5.519 ns |  1.8373 ns | 0.1007 ns |  5.566 ns |  1.07 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 3.1 | 11.939 ns |  1.3444 ns | 0.0737 ns | 11.952 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 5.0 | 11.109 ns |  1.1364 ns | 0.0623 ns | 11.105 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                            From_ULong | .NET Core 3.1 |  4.935 ns |  1.1101 ns | 0.0608 ns |  4.948 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 5.0 |  5.553 ns |  2.7319 ns | 0.1497 ns |  5.579 ns |  1.13 |    0.03 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                   From_ULong_AsObject | .NET Core 3.1 | 13.861 ns |  2.6418 ns | 0.1448 ns | 13.916 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 5.0 | 14.563 ns |  1.4326 ns | 0.0785 ns | 14.520 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                         From_ULong_Nullable_WithValue | .NET Core 3.1 |  6.600 ns |  2.2539 ns | 0.1235 ns |  6.613 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 5.0 |  6.586 ns | 10.9961 ns | 0.6027 ns |  6.922 ns |  1.00 |    0.11 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 3.1 | 15.320 ns |  1.8546 ns | 0.1017 ns | 15.298 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 5.0 | 14.848 ns |  0.2299 ns | 0.0126 ns | 14.854 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                           From_ULong_Nullable_NoValue | .NET Core 3.1 |  6.830 ns |  1.4198 ns | 0.0778 ns |  6.820 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 5.0 |  5.912 ns |  0.5746 ns | 0.0315 ns |  5.901 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 3.1 | 11.205 ns |  1.5880 ns | 0.0870 ns | 11.170 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 5.0 | 11.158 ns |  0.9463 ns | 0.0519 ns | 11.180 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                       From_NullObject | .NET Core 3.1 | 12.716 ns | 16.4292 ns | 0.9005 ns | 12.898 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 5.0 | 11.187 ns |  2.0860 ns | 0.1143 ns | 11.182 ns |  0.88 |    0.06 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                           From_DBNull | .NET Core 3.1 |  9.369 ns |  3.0266 ns | 0.1659 ns |  9.379 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 5.0 |  8.398 ns |  0.9815 ns | 0.0538 ns |  8.396 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                  From_DBNull_AsObject | .NET Core 3.1 | 11.796 ns |  3.6467 ns | 0.1999 ns | 11.711 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 5.0 | 11.147 ns |  1.7947 ns | 0.0984 ns | 11.105 ns |  0.95 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                 From_ConvertibleClass | .NET Core 3.1 | 13.853 ns |  0.7038 ns | 0.0386 ns | 13.863 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 5.0 | 12.172 ns |  4.1508 ns | 0.2275 ns | 12.244 ns |  0.88 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                        From_ConvertibleClass_AsObject | .NET Core 3.1 | 13.608 ns |  0.9649 ns | 0.0529 ns | 13.594 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 5.0 | 14.106 ns |  0.4306 ns | 0.0236 ns | 14.096 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                         From_ConvertibleClass_NoValue | .NET Core 3.1 |  9.578 ns |  1.5377 ns | 0.0843 ns |  9.534 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 5.0 | 11.092 ns |  5.1014 ns | 0.2796 ns | 11.030 ns |  1.16 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 3.1 | 11.448 ns |  3.7584 ns | 0.2060 ns | 11.339 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 5.0 | 11.102 ns |  1.6336 ns | 0.0895 ns | 11.060 ns |  0.97 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                              From_NonConvertibleClass | .NET Core 3.1 |  9.315 ns |  1.7573 ns | 0.0963 ns |  9.276 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 5.0 |  8.385 ns |  1.2651 ns | 0.0693 ns |  8.353 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                     From_NonConvertibleClass_AsObject | .NET Core 3.1 | 13.622 ns |  1.7091 ns | 0.0937 ns | 13.652 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 5.0 | 13.011 ns |  1.6130 ns | 0.0884 ns | 12.974 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                      From_NonConvertibleClass_NoValue | .NET Core 3.1 | 11.627 ns |  1.8001 ns | 0.0987 ns | 11.681 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 5.0 |  8.359 ns |  1.4630 ns | 0.0802 ns |  8.329 ns |  0.72 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 3.1 | 11.130 ns |  0.6865 ns | 0.0376 ns | 11.139 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 5.0 | 11.159 ns |  0.7012 ns | 0.0384 ns | 11.152 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                From_ConvertibleStruct | .NET Core 3.1 | 11.896 ns |  2.4166 ns | 0.1325 ns | 11.898 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 5.0 | 10.226 ns |  2.9127 ns | 0.1597 ns | 10.211 ns |  0.86 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                       From_ConvertibleStruct_AsObject | .NET Core 3.1 | 14.284 ns |  1.2409 ns | 0.0680 ns | 14.300 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 5.0 | 14.651 ns |  1.7890 ns | 0.0981 ns | 14.599 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 3.1 | 11.787 ns |  5.7533 ns | 0.3154 ns | 11.676 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 5.0 | 11.787 ns |  6.5328 ns | 0.3581 ns | 11.921 ns |  1.00 |    0.06 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.1 | 14.987 ns |  2.6716 ns | 0.1464 ns | 15.028 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 5.0 | 14.511 ns |  1.7160 ns | 0.0941 ns | 14.465 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 3.1 |  6.986 ns |  2.3545 ns | 0.1291 ns |  6.917 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 5.0 |  6.417 ns |  1.3376 ns | 0.0733 ns |  6.416 ns |  0.92 |    0.03 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.1 | 11.824 ns |  0.7913 ns | 0.0434 ns | 11.832 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 5.0 | 11.324 ns |  4.4983 ns | 0.2466 ns | 11.261 ns |  0.96 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                             From_NonConvertibleStruct | .NET Core 3.1 |  5.366 ns |  1.4546 ns | 0.0797 ns |  5.383 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 5.0 |  6.248 ns |  1.0245 ns | 0.0562 ns |  6.242 ns |  1.16 |    0.03 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                    From_NonConvertibleStruct_AsObject | .NET Core 3.1 | 12.650 ns |  0.7128 ns | 0.0391 ns | 12.646 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 5.0 | 14.573 ns |  1.9932 ns | 0.1093 ns | 14.514 ns |  1.15 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 3.1 |  5.456 ns |  0.5769 ns | 0.0316 ns |  5.463 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 5.0 |  6.246 ns |  0.5231 ns | 0.0287 ns |  6.231 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.1 | 12.983 ns |  2.0921 ns | 0.1147 ns | 12.992 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 5.0 | 12.700 ns |  0.1372 ns | 0.0075 ns | 12.698 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 3.1 |  5.597 ns |  0.6395 ns | 0.0351 ns |  5.584 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 5.0 |  6.269 ns |  1.6403 ns | 0.0899 ns |  6.218 ns |  1.12 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.1 | 11.877 ns |  2.2954 ns | 0.1258 ns | 11.808 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 5.0 | 11.173 ns |  1.9770 ns | 0.1084 ns | 11.167 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                             From_Enum | .NET Core 3.1 |  5.212 ns |  2.1848 ns | 0.1198 ns |  5.197 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 5.0 |  5.542 ns |  0.3666 ns | 0.0201 ns |  5.536 ns |  1.06 |    0.03 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                    From_Enum_AsObject | .NET Core 3.1 | 32.483 ns |  6.6942 ns | 0.3669 ns | 32.516 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject | .NET Core 5.0 | 23.774 ns |  2.1161 ns | 0.1160 ns | 23.731 ns |  0.73 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                          From_Enum_Nullable_WithValue | .NET Core 3.1 |  5.326 ns |  0.6578 ns | 0.0361 ns |  5.322 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 5.0 |  6.336 ns |  6.7515 ns | 0.3701 ns |  6.224 ns |  1.19 |    0.06 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 3.1 | 31.846 ns |  1.3739 ns | 0.0753 ns | 31.803 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 5.0 | 25.390 ns | 21.1228 ns | 1.1578 ns | 24.990 ns |  0.80 |    0.03 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                            From_Enum_Nullable_NoValue | .NET Core 3.1 |  5.230 ns |  0.7850 ns | 0.0430 ns |  5.210 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 5.0 |  5.858 ns |  1.2629 ns | 0.0692 ns |  5.819 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 3.1 | 11.892 ns |  2.4072 ns | 0.1319 ns | 11.850 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 5.0 | 11.090 ns |  0.1853 ns | 0.0102 ns | 11.093 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                      From_ParentClass | .NET Core 3.1 |  8.958 ns |  0.8978 ns | 0.0492 ns |  8.932 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 5.0 |  8.348 ns |  0.7529 ns | 0.0413 ns |  8.330 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                             From_ParentClass_AsObject | .NET Core 3.1 | 13.618 ns |  0.6963 ns | 0.0382 ns | 13.607 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 5.0 | 13.084 ns |  2.1331 ns | 0.1169 ns | 13.079 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                              From_ParentClass_NoValue | .NET Core 3.1 |  8.263 ns |  0.1264 ns | 0.0069 ns |  8.265 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 5.0 |  8.721 ns |  2.7605 ns | 0.1513 ns |  8.661 ns |  1.06 |    0.02 |      - |     - |     - |         - |

Benchmarks with issues:
  ConvertTo_UInt.From_DateTime_AsObject: ShortRun(Toolchain=.NET Core 3.1, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_UInt.From_DateTime_AsObject: ShortRun(Toolchain=.NET Core 5.0, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_UInt.From_DateTime_Nullable_WithValue_AsObject: ShortRun(Toolchain=.NET Core 3.1, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_UInt.From_DateTime_Nullable_WithValue_AsObject: ShortRun(Toolchain=.NET Core 5.0, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_UInt.From_String_Empty_AsObject: ShortRun(Toolchain=.NET Core 3.1, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_UInt.From_String_Empty_AsObject: ShortRun(Toolchain=.NET Core 5.0, IterationCount=3, LaunchCount=1, WarmupCount=3)
