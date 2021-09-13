
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

                                                Method |     Toolchain |      Mean |      Error |    StdDev |    Median | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------------------------------------------ |-------------- |----------:|-----------:|----------:|----------:|------:|--------:|-------:|------:|------:|----------:|
                     From_ParentClass_NoValue_AsObject | .NET Core 3.1 | 14.154 ns |  3.7412 ns | 0.2051 ns | 14.052 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 5.0 | 11.304 ns |  1.3804 ns | 0.0757 ns | 11.275 ns |  0.80 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                     From_ParentStruct | .NET Core 3.1 | 40.132 ns |  0.9289 ns | 0.0509 ns | 40.120 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 5.0 | 28.021 ns |  1.1425 ns | 0.0626 ns | 28.030 ns |  0.70 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                            From_ParentStruct_AsObject | .NET Core 3.1 | 16.284 ns |  3.8864 ns | 0.2130 ns | 16.221 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 5.0 | 13.876 ns |  3.2142 ns | 0.1762 ns | 13.813 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                  From_ParentStruct_Nullable_WithValue | .NET Core 3.1 | 38.958 ns |  4.3318 ns | 0.2374 ns | 38.854 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 5.0 | 28.534 ns |  1.1343 ns | 0.0622 ns | 28.529 ns |  0.73 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 3.1 | 15.582 ns |  4.4118 ns | 0.2418 ns | 15.493 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 5.0 | 13.445 ns |  2.9358 ns | 0.1609 ns | 13.484 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                    From_ParentStruct_Nullable_NoValue | .NET Core 3.1 | 38.298 ns |  4.5600 ns | 0.2499 ns | 38.269 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 5.0 | 28.611 ns | 11.8644 ns | 0.6503 ns | 28.820 ns |  0.75 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 3.1 | 13.398 ns |  3.2721 ns | 0.1794 ns | 13.497 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 5.0 | 11.246 ns |  0.1578 ns | 0.0087 ns | 11.244 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                             From_Bool | .NET Core 3.1 |  7.897 ns |  0.5782 ns | 0.0317 ns |  7.899 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 5.0 |  7.283 ns |  1.4058 ns | 0.0771 ns |  7.290 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                    From_Bool_AsObject | .NET Core 3.1 | 18.206 ns |  0.5691 ns | 0.0312 ns | 18.212 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 5.0 | 16.895 ns |  2.8394 ns | 0.1556 ns | 16.808 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                          From_Bool_Nullable_WithValue | .NET Core 3.1 |  8.370 ns |  0.1797 ns | 0.0098 ns |  8.365 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 5.0 |  7.491 ns |  0.2996 ns | 0.0164 ns |  7.498 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 3.1 | 18.061 ns |  6.3463 ns | 0.3479 ns | 18.175 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 5.0 | 16.871 ns |  1.1146 ns | 0.0611 ns | 16.866 ns |  0.93 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                            From_Bool_Nullable_NoValue | .NET Core 3.1 |  7.930 ns |  0.3154 ns | 0.0173 ns |  7.921 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 5.0 |  5.835 ns |  1.5826 ns | 0.0867 ns |  5.802 ns |  0.74 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 3.1 | 14.713 ns |  1.3823 ns | 0.0758 ns | 14.684 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 5.0 | 11.296 ns |  0.7035 ns | 0.0386 ns | 11.279 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                             From_Byte | .NET Core 3.1 |  7.964 ns |  1.1334 ns | 0.0621 ns |  7.953 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 5.0 |  7.214 ns |  0.4300 ns | 0.0236 ns |  7.204 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                    From_Byte_AsObject | .NET Core 3.1 | 16.794 ns |  0.2541 ns | 0.0139 ns | 16.802 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 5.0 | 16.811 ns |  1.8507 ns | 0.1014 ns | 16.770 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                          From_Byte_Nullable_WithValue | .NET Core 3.1 | 11.124 ns |  0.7200 ns | 0.0395 ns | 11.110 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 5.0 |  7.446 ns |  0.2589 ns | 0.0142 ns |  7.444 ns |  0.67 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 3.1 | 16.448 ns |  0.4669 ns | 0.0256 ns | 16.444 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 5.0 | 16.751 ns |  1.7187 ns | 0.0942 ns | 16.741 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                            From_Byte_Nullable_NoValue | .NET Core 3.1 |  7.909 ns |  0.1638 ns | 0.0090 ns |  7.907 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 5.0 |  5.821 ns |  0.6979 ns | 0.0383 ns |  5.804 ns |  0.74 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 3.1 | 13.629 ns |  0.1174 ns | 0.0064 ns | 13.628 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 5.0 | 11.318 ns |  0.5968 ns | 0.0327 ns | 11.312 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                             From_Char | .NET Core 3.1 |  7.927 ns |  0.3456 ns | 0.0189 ns |  7.930 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Char | .NET Core 5.0 |  7.236 ns |  0.8103 ns | 0.0444 ns |  7.240 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                    From_Char_AsObject | .NET Core 3.1 | 17.647 ns |  5.9002 ns | 0.3234 ns | 17.513 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 5.0 | 17.286 ns |  5.2883 ns | 0.2899 ns | 17.120 ns |  0.98 |    0.03 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                          From_Char_Nullable_WithValue | .NET Core 3.1 |  8.385 ns |  0.5629 ns | 0.0309 ns |  8.368 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 5.0 |  7.475 ns |  0.7119 ns | 0.0390 ns |  7.456 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 3.1 | 17.589 ns |  4.6870 ns | 0.2569 ns | 17.477 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 5.0 | 17.155 ns |  2.4160 ns | 0.1324 ns | 17.090 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                            From_Char_Nullable_NoValue | .NET Core 3.1 |  7.937 ns |  0.2229 ns | 0.0122 ns |  7.939 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 5.0 |  5.773 ns |  0.0879 ns | 0.0048 ns |  5.775 ns |  0.73 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 3.1 | 12.876 ns |  1.5349 ns | 0.0841 ns | 12.908 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 5.0 | 11.231 ns |  0.3024 ns | 0.0166 ns | 11.228 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                         From_DateTime | .NET Core 3.1 |  8.167 ns |  0.5387 ns | 0.0295 ns |  8.152 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 5.0 |  6.547 ns |  0.9811 ns | 0.0538 ns |  6.540 ns |  0.80 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                From_DateTime_AsObject | .NET Core 3.1 |        NA |         NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 5.0 |        NA |         NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                      From_DateTime_Nullable_WithValue | .NET Core 3.1 |  8.619 ns |  0.2058 ns | 0.0113 ns |  8.617 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 5.0 |  5.433 ns |  0.1320 ns | 0.0072 ns |  5.432 ns |  0.63 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 3.1 |        NA |         NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 5.0 |        NA |         NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                        From_DateTime_Nullable_NoValue | .NET Core 3.1 |  8.379 ns |  0.7201 ns | 0.0395 ns |  8.372 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 5.0 |  5.659 ns |  1.2576 ns | 0.0689 ns |  5.642 ns |  0.68 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 3.1 | 14.659 ns |  1.9342 ns | 0.1060 ns | 14.693 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 5.0 | 11.269 ns |  2.2538 ns | 0.1235 ns | 11.198 ns |  0.77 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                          From_Decimal | .NET Core 3.1 | 13.891 ns |  3.3985 ns | 0.1863 ns | 13.796 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 5.0 | 15.358 ns |  0.7163 ns | 0.0393 ns | 15.357 ns |  1.11 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                 From_Decimal_AsObject | .NET Core 3.1 | 23.135 ns |  7.2684 ns | 0.3984 ns | 22.910 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 5.0 | 24.703 ns |  1.0239 ns | 0.0561 ns | 24.723 ns |  1.07 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                       From_Decimal_Nullable_WithValue | .NET Core 3.1 | 17.615 ns |  0.3727 ns | 0.0204 ns | 17.619 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 5.0 | 15.881 ns |  0.4328 ns | 0.0237 ns | 15.869 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 3.1 | 23.373 ns |  1.5645 ns | 0.0858 ns | 23.355 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 5.0 | 24.991 ns |  3.5879 ns | 0.1967 ns | 24.886 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                         From_Decimal_Nullable_NoValue | .NET Core 3.1 |  8.387 ns |  0.5327 ns | 0.0292 ns |  8.374 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 5.0 |  6.229 ns |  4.5706 ns | 0.2505 ns |  6.302 ns |  0.74 |    0.03 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 3.1 | 12.793 ns |  0.4263 ns | 0.0234 ns | 12.785 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 5.0 | 11.341 ns |  1.1018 ns | 0.0604 ns | 11.312 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                           From_Double | .NET Core 3.1 | 10.951 ns |  0.5791 ns | 0.0317 ns | 10.933 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 5.0 | 10.323 ns |  1.8937 ns | 0.1038 ns | 10.263 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                  From_Double_AsObject | .NET Core 3.1 | 19.905 ns |  4.8802 ns | 0.2675 ns | 19.790 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 5.0 | 19.365 ns |  3.1610 ns | 0.1733 ns | 19.277 ns |  0.97 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                        From_Double_Nullable_WithValue | .NET Core 3.1 | 11.410 ns |  0.2293 ns | 0.0126 ns | 11.406 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 5.0 | 10.267 ns |  0.7568 ns | 0.0415 ns | 10.265 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
               From_Double_Nullable_WithValue_AsObject | .NET Core 3.1 | 19.708 ns |  3.2940 ns | 0.1806 ns | 19.637 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 5.0 | 19.268 ns |  1.2933 ns | 0.0709 ns | 19.299 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                          From_Double_Nullable_NoValue | .NET Core 3.1 |  8.380 ns |  0.5415 ns | 0.0297 ns |  8.396 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 5.0 |  5.903 ns |  0.3047 ns | 0.0167 ns |  5.902 ns |  0.70 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 3.1 | 13.271 ns |  5.5207 ns | 0.3026 ns | 13.217 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 5.0 | 11.327 ns |  2.3943 ns | 0.1312 ns | 11.277 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                            From_Short | .NET Core 3.1 |  7.961 ns |  0.6336 ns | 0.0347 ns |  7.968 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 5.0 |  7.251 ns |  0.9608 ns | 0.0527 ns |  7.232 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                   From_Short_AsObject | .NET Core 3.1 | 17.531 ns |  0.1415 ns | 0.0078 ns | 17.527 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 5.0 | 16.981 ns |  3.3012 ns | 0.1809 ns | 16.905 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                         From_Short_Nullable_WithValue | .NET Core 3.1 |  8.667 ns |  0.8457 ns | 0.0464 ns |  8.672 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 5.0 |  7.479 ns |  0.2793 ns | 0.0153 ns |  7.481 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                From_Short_Nullable_WithValue_AsObject | .NET Core 3.1 | 18.034 ns |  1.7153 ns | 0.0940 ns | 18.020 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 5.0 | 16.891 ns |  0.1660 ns | 0.0091 ns | 16.888 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                           From_Short_Nullable_NoValue | .NET Core 3.1 |  8.018 ns |  2.0799 ns | 0.1140 ns |  7.993 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 5.0 |  5.780 ns |  0.1054 ns | 0.0058 ns |  5.778 ns |  0.72 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 3.1 | 14.426 ns |  1.4929 ns | 0.0818 ns | 14.386 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 5.0 | 11.337 ns |  1.6895 ns | 0.0926 ns | 11.291 ns |  0.79 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                              From_Int | .NET Core 3.1 |  8.149 ns |  0.6774 ns | 0.0371 ns |  8.137 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 5.0 |  7.307 ns |  0.6938 ns | 0.0380 ns |  7.309 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                     From_Int_AsObject | .NET Core 3.1 | 18.830 ns |  0.7176 ns | 0.0393 ns | 18.808 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 5.0 | 16.848 ns |  0.7614 ns | 0.0417 ns | 16.869 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                           From_Int_Nullable_WithValue | .NET Core 3.1 |  8.581 ns |  0.2415 ns | 0.0132 ns |  8.584 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 5.0 |  7.549 ns |  1.4383 ns | 0.0788 ns |  7.527 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 3.1 | 18.829 ns |  3.2468 ns | 0.1780 ns | 18.746 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 5.0 | 17.504 ns | 12.5875 ns | 0.6900 ns | 17.252 ns |  0.93 |    0.04 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                             From_Int_Nullable_NoValue | .NET Core 3.1 |  7.862 ns |  1.1106 ns | 0.0609 ns |  7.893 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 5.0 |  5.859 ns |  1.1963 ns | 0.0656 ns |  5.835 ns |  0.75 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 3.1 | 12.744 ns |  0.2099 ns | 0.0115 ns | 12.749 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 5.0 | 11.325 ns |  1.5947 ns | 0.0874 ns | 11.280 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                             From_Long | .NET Core 3.1 |  8.166 ns |  0.0442 ns | 0.0024 ns |  8.167 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Long | .NET Core 5.0 |  8.001 ns |  0.5601 ns | 0.0307 ns |  8.005 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                    From_Long_AsObject | .NET Core 3.1 | 17.367 ns |  3.3185 ns | 0.1819 ns | 17.289 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 5.0 | 17.500 ns |  2.7370 ns | 0.1500 ns | 17.563 ns |  1.01 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                          From_Long_Nullable_WithValue | .NET Core 3.1 |  9.319 ns |  4.0928 ns | 0.2243 ns |  9.195 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 5.0 |  8.637 ns |  0.4050 ns | 0.0222 ns |  8.635 ns |  0.93 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 3.1 | 17.966 ns |  1.2258 ns | 0.0672 ns | 17.977 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 5.0 | 17.371 ns |  3.1915 ns | 0.1749 ns | 17.320 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                            From_Long_Nullable_NoValue | .NET Core 3.1 |  8.191 ns |  1.8803 ns | 0.1031 ns |  8.147 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 5.0 |  5.989 ns |  5.2172 ns | 0.2860 ns |  5.830 ns |  0.73 |    0.04 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 3.1 | 12.892 ns |  1.9889 ns | 0.1090 ns | 12.934 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 5.0 | 11.448 ns |  4.6388 ns | 0.2543 ns | 11.470 ns |  0.89 |    0.03 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                            From_SByte | .NET Core 3.1 |  7.872 ns |  0.2672 ns | 0.0146 ns |  7.868 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 5.0 |  7.981 ns |  1.6051 ns | 0.0880 ns |  8.000 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                   From_SByte_AsObject | .NET Core 3.1 | 17.321 ns |  4.5477 ns | 0.2493 ns | 17.192 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 5.0 | 16.943 ns |  2.6488 ns | 0.1452 ns | 16.952 ns |  0.98 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                         From_SByte_Nullable_WithValue | .NET Core 3.1 |  8.711 ns |  4.8890 ns | 0.2680 ns |  8.848 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 5.0 |  7.699 ns |  7.5912 ns | 0.4161 ns |  7.462 ns |  0.88 |    0.04 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 3.1 | 17.283 ns |  0.3258 ns | 0.0179 ns | 17.289 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 5.0 | 16.882 ns |  0.3552 ns | 0.0195 ns | 16.876 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                           From_SByte_Nullable_NoValue | .NET Core 3.1 |  7.954 ns |  1.3190 ns | 0.0723 ns |  7.942 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 5.0 |  5.801 ns |  0.1612 ns | 0.0088 ns |  5.806 ns |  0.73 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 3.1 | 12.746 ns |  0.2831 ns | 0.0155 ns | 12.742 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 5.0 | 11.266 ns |  0.6015 ns | 0.0330 ns | 11.257 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                            From_Float | .NET Core 3.1 | 11.022 ns |  1.1793 ns | 0.0646 ns | 11.048 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 5.0 | 10.040 ns |  1.3737 ns | 0.0753 ns | 10.006 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                   From_Float_AsObject | .NET Core 3.1 | 20.238 ns |  3.3510 ns | 0.1837 ns | 20.182 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 5.0 | 19.370 ns |  2.9768 ns | 0.1632 ns | 19.371 ns |  0.96 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                         From_Float_Nullable_WithValue | .NET Core 3.1 | 11.289 ns |  0.8068 ns | 0.0442 ns | 11.290 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 5.0 | 10.179 ns |  3.7551 ns | 0.2058 ns | 10.071 ns |  0.90 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                From_Float_Nullable_WithValue_AsObject | .NET Core 3.1 | 19.994 ns |  1.2201 ns | 0.0669 ns | 20.014 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 5.0 | 19.222 ns |  1.1261 ns | 0.0617 ns | 19.245 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                           From_Float_Nullable_NoValue | .NET Core 3.1 |  8.132 ns |  0.3811 ns | 0.0209 ns |  8.125 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 5.0 |  6.032 ns |  2.4039 ns | 0.1318 ns |  6.079 ns |  0.74 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 3.1 | 15.548 ns |  1.5743 ns | 0.0863 ns | 15.583 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 5.0 | 11.410 ns |  2.5856 ns | 0.1417 ns | 11.335 ns |  0.73 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                           From_String | .NET Core 3.1 | 20.223 ns |  0.7562 ns | 0.0414 ns | 20.204 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 5.0 | 19.003 ns |  5.8060 ns | 0.3182 ns | 18.877 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                  From_String_AsObject | .NET Core 3.1 | 25.394 ns |  7.0598 ns | 0.3870 ns | 25.356 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 5.0 | 24.248 ns | 23.4642 ns | 1.2862 ns | 23.547 ns |  0.96 |    0.06 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                      From_String_Null | .NET Core 3.1 | 13.224 ns |  1.0361 ns | 0.0568 ns | 13.193 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 5.0 | 10.407 ns |  0.8317 ns | 0.0456 ns | 10.429 ns |  0.79 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                             From_String_Null_AsObject | .NET Core 3.1 | 12.778 ns |  0.1051 ns | 0.0058 ns | 12.781 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 5.0 | 11.402 ns |  3.7199 ns | 0.2039 ns | 11.288 ns |  0.89 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                     From_String_Empty | .NET Core 3.1 | 13.933 ns |  0.2220 ns | 0.0122 ns | 13.938 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 5.0 | 10.494 ns |  1.9142 ns | 0.1049 ns | 10.453 ns |  0.75 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                            From_String_Empty_AsObject | .NET Core 3.1 |        NA |         NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 5.0 |        NA |         NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                           From_UShort | .NET Core 3.1 |  7.907 ns |  0.5012 ns | 0.0275 ns |  7.918 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 5.0 |  7.214 ns |  0.2275 ns | 0.0125 ns |  7.213 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                  From_UShort_AsObject | .NET Core 3.1 | 24.027 ns |  7.2672 ns | 0.3983 ns | 24.174 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 5.0 | 22.355 ns |  5.6765 ns | 0.3111 ns | 22.180 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                        From_UShort_Nullable_WithValue | .NET Core 3.1 |  5.136 ns |  1.0527 ns | 0.0577 ns |  5.137 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 5.0 |  5.210 ns |  4.9936 ns | 0.2737 ns |  5.078 ns |  1.01 |    0.06 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 3.1 | 23.815 ns |  5.0194 ns | 0.2751 ns | 23.674 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 5.0 | 22.195 ns |  3.3913 ns | 0.1859 ns | 22.108 ns |  0.93 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                          From_UShort_Nullable_NoValue | .NET Core 3.1 |  5.149 ns |  1.4490 ns | 0.0794 ns |  5.126 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 5.0 |  5.356 ns |  1.3203 ns | 0.0724 ns |  5.328 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 3.1 | 13.420 ns |  1.6703 ns | 0.0916 ns | 13.464 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 5.0 | 11.300 ns |  0.3400 ns | 0.0186 ns | 11.304 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                             From_UInt | .NET Core 3.1 |  7.678 ns |  0.7136 ns | 0.0391 ns |  7.670 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 5.0 |  7.276 ns |  0.8573 ns | 0.0470 ns |  7.251 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                    From_UInt_AsObject | .NET Core 3.1 | 17.074 ns |  1.3174 ns | 0.0722 ns | 17.075 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 5.0 | 16.833 ns |  0.1248 ns | 0.0068 ns | 16.833 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                          From_UInt_Nullable_WithValue | .NET Core 3.1 |  8.853 ns |  0.2303 ns | 0.0126 ns |  8.854 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 5.0 |  7.526 ns |  0.2602 ns | 0.0143 ns |  7.520 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 3.1 | 17.298 ns |  5.0844 ns | 0.2787 ns | 17.179 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 5.0 | 16.891 ns |  0.7655 ns | 0.0420 ns | 16.874 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                            From_UInt_Nullable_NoValue | .NET Core 3.1 |  7.927 ns |  0.7925 ns | 0.0434 ns |  7.945 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 5.0 |  5.883 ns |  0.1269 ns | 0.0070 ns |  5.887 ns |  0.74 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 3.1 | 12.772 ns |  0.3303 ns | 0.0181 ns | 12.779 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 5.0 | 11.400 ns |  2.1721 ns | 0.1191 ns | 11.332 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                            From_ULong | .NET Core 3.1 |  8.339 ns |  2.7632 ns | 0.1515 ns |  8.263 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 5.0 |  8.073 ns |  2.8716 ns | 0.1574 ns |  8.124 ns |  0.97 |    0.04 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                   From_ULong_AsObject | .NET Core 3.1 | 17.340 ns |  1.4791 ns | 0.0811 ns | 17.370 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 5.0 | 17.534 ns |  3.1409 ns | 0.1722 ns | 17.611 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                         From_ULong_Nullable_WithValue | .NET Core 3.1 |  9.295 ns |  1.9214 ns | 0.1053 ns |  9.239 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 5.0 |  8.851 ns |  3.1222 ns | 0.1711 ns |  8.924 ns |  0.95 |    0.03 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 3.1 | 17.817 ns |  3.3245 ns | 0.1822 ns | 17.773 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 5.0 | 17.366 ns |  0.1356 ns | 0.0074 ns | 17.369 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                           From_ULong_Nullable_NoValue | .NET Core 3.1 |  8.209 ns |  0.2185 ns | 0.0120 ns |  8.205 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 5.0 |  5.845 ns |  0.2336 ns | 0.0128 ns |  5.838 ns |  0.71 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 3.1 | 12.764 ns |  0.1998 ns | 0.0110 ns | 12.768 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 5.0 | 11.391 ns |  1.6479 ns | 0.0903 ns | 11.355 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                       From_NullObject | .NET Core 3.1 | 13.569 ns |  1.5941 ns | 0.0874 ns | 13.529 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 5.0 | 12.336 ns |  8.4636 ns | 0.4639 ns | 12.240 ns |  0.91 |    0.03 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                           From_DBNull | .NET Core 3.1 | 10.958 ns |  1.4767 ns | 0.0809 ns | 10.941 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 5.0 |  8.499 ns |  0.5521 ns | 0.0303 ns |  8.493 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                  From_DBNull_AsObject | .NET Core 3.1 | 14.203 ns |  0.4470 ns | 0.0245 ns | 14.193 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 5.0 | 11.713 ns |  1.2376 ns | 0.0678 ns | 11.679 ns |  0.82 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                 From_ConvertibleClass | .NET Core 3.1 | 14.470 ns |  2.8930 ns | 0.1586 ns | 14.406 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 5.0 | 13.941 ns |  0.0538 ns | 0.0030 ns | 13.939 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                        From_ConvertibleClass_AsObject | .NET Core 3.1 | 16.173 ns |  0.2543 ns | 0.0139 ns | 16.175 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 5.0 | 16.432 ns |  0.4254 ns | 0.0233 ns | 16.436 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                         From_ConvertibleClass_NoValue | .NET Core 3.1 | 12.927 ns | 11.7022 ns | 0.6414 ns | 12.560 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 5.0 | 10.814 ns |  0.3837 ns | 0.0210 ns | 10.816 ns |  0.84 |    0.04 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 3.1 | 12.852 ns |  1.0494 ns | 0.0575 ns | 12.875 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 5.0 | 11.245 ns |  0.0287 ns | 0.0016 ns | 11.245 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                              From_NonConvertibleClass | .NET Core 3.1 | 10.689 ns |  0.7288 ns | 0.0399 ns | 10.687 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 5.0 |  8.524 ns |  0.2882 ns | 0.0158 ns |  8.516 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                     From_NonConvertibleClass_AsObject | .NET Core 3.1 | 14.566 ns |  0.2078 ns | 0.0114 ns | 14.562 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 5.0 | 15.566 ns |  2.5327 ns | 0.1388 ns | 15.557 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                      From_NonConvertibleClass_NoValue | .NET Core 3.1 | 10.751 ns |  1.1370 ns | 0.0623 ns | 10.749 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 5.0 |  8.407 ns |  1.2153 ns | 0.0666 ns |  8.386 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 3.1 | 12.932 ns |  3.9929 ns | 0.2189 ns | 12.817 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 5.0 | 11.259 ns |  0.3610 ns | 0.0198 ns | 11.252 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                From_ConvertibleStruct | .NET Core 3.1 | 13.279 ns |  0.1972 ns | 0.0108 ns | 13.278 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 5.0 | 11.789 ns |  1.6809 ns | 0.0921 ns | 11.840 ns |  0.89 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                       From_ConvertibleStruct_AsObject | .NET Core 3.1 | 16.713 ns |  1.8210 ns | 0.0998 ns | 16.659 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 5.0 | 17.006 ns |  3.7264 ns | 0.2043 ns | 17.100 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 3.1 | 13.790 ns |  0.5714 ns | 0.0313 ns | 13.795 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 5.0 | 12.835 ns |  2.4839 ns | 0.1362 ns | 12.904 ns |  0.93 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.1 | 17.177 ns |  3.5068 ns | 0.1922 ns | 17.124 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 5.0 | 16.863 ns |  0.2448 ns | 0.0134 ns | 16.857 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 3.1 |  8.384 ns |  0.3539 ns | 0.0194 ns |  8.394 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 5.0 |  6.315 ns |  2.0286 ns | 0.1112 ns |  6.275 ns |  0.75 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.1 | 13.986 ns |  1.4748 ns | 0.0808 ns | 13.969 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 5.0 | 11.593 ns |  1.8556 ns | 0.1017 ns | 11.539 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                             From_NonConvertibleStruct | .NET Core 3.1 |  7.725 ns |  0.7518 ns | 0.0412 ns |  7.722 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 5.0 |  6.633 ns | 11.2338 ns | 0.6158 ns |  6.331 ns |  0.86 |    0.08 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                    From_NonConvertibleStruct_AsObject | .NET Core 3.1 | 14.614 ns |  2.2039 ns | 0.1208 ns | 14.594 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 5.0 | 13.154 ns |  1.2976 ns | 0.0711 ns | 13.124 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 3.1 |  7.681 ns |  0.4148 ns | 0.0227 ns |  7.685 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 5.0 |  6.197 ns |  0.0369 ns | 0.0020 ns |  6.197 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.1 | 15.192 ns |  2.5069 ns | 0.1374 ns | 15.156 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 5.0 | 13.577 ns |  0.5945 ns | 0.0326 ns | 13.561 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 3.1 |  7.667 ns |  0.2727 ns | 0.0149 ns |  7.668 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 5.0 |  6.246 ns |  1.2225 ns | 0.0670 ns |  6.266 ns |  0.81 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.1 | 12.840 ns |  2.0614 ns | 0.1130 ns | 12.817 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 5.0 | 11.231 ns |  0.3219 ns | 0.0176 ns | 11.226 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                             From_Enum | .NET Core 3.1 |  8.182 ns |  0.5619 ns | 0.0308 ns |  8.187 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 5.0 |  7.236 ns |  0.2154 ns | 0.0118 ns |  7.235 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                    From_Enum_AsObject | .NET Core 3.1 | 43.786 ns |  0.7769 ns | 0.0426 ns | 43.809 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject | .NET Core 5.0 | 25.000 ns |  6.0328 ns | 0.3307 ns | 25.171 ns |  0.57 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                          From_Enum_Nullable_WithValue | .NET Core 3.1 |  8.720 ns |  1.7755 ns | 0.0973 ns |  8.667 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 5.0 |  7.516 ns |  1.0196 ns | 0.0559 ns |  7.488 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 3.1 | 34.309 ns |  2.0023 ns | 0.1098 ns | 34.299 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 5.0 | 27.637 ns |  3.4520 ns | 0.1892 ns | 27.683 ns |  0.81 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                            From_Enum_Nullable_NoValue | .NET Core 3.1 |  7.905 ns |  0.3721 ns | 0.0204 ns |  7.917 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 5.0 |  5.790 ns |  0.2995 ns | 0.0164 ns |  5.784 ns |  0.73 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 3.1 | 12.929 ns |  3.7114 ns | 0.2034 ns | 12.841 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 5.0 | 11.246 ns |  0.1396 ns | 0.0077 ns | 11.246 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                      From_ParentClass | .NET Core 3.1 | 11.128 ns |  6.9543 ns | 0.3812 ns | 11.297 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 5.0 |  8.593 ns |  2.3727 ns | 0.1301 ns |  8.667 ns |  0.77 |    0.04 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                             From_ParentClass_AsObject | .NET Core 3.1 | 15.488 ns |  6.0604 ns | 0.3322 ns | 15.362 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 5.0 | 13.311 ns |  0.6298 ns | 0.0345 ns | 13.298 ns |  0.86 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                              From_ParentClass_NoValue | .NET Core 3.1 | 10.779 ns |  1.3039 ns | 0.0715 ns | 10.819 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 5.0 |  8.453 ns |  2.1159 ns | 0.1160 ns |  8.413 ns |  0.78 |    0.01 |      - |     - |     - |         - |

Benchmarks with issues:
  ConvertTo_UShortNullable.From_DateTime_AsObject: ShortRun(Toolchain=.NET Core 3.1, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_UShortNullable.From_DateTime_AsObject: ShortRun(Toolchain=.NET Core 5.0, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_UShortNullable.From_DateTime_Nullable_WithValue_AsObject: ShortRun(Toolchain=.NET Core 3.1, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_UShortNullable.From_DateTime_Nullable_WithValue_AsObject: ShortRun(Toolchain=.NET Core 5.0, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_UShortNullable.From_String_Empty_AsObject: ShortRun(Toolchain=.NET Core 3.1, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_UShortNullable.From_String_Empty_AsObject: ShortRun(Toolchain=.NET Core 5.0, IterationCount=3, LaunchCount=1, WarmupCount=3)
