
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

                                                Method |     Toolchain |       Mean |       Error |     StdDev |     Median | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------------------------------------------ |-------------- |-----------:|------------:|-----------:|-----------:|------:|--------:|-------:|------:|------:|----------:|
                     From_ParentClass_NoValue_AsObject | .NET Core 3.1 |  12.983 ns |   3.0427 ns |  0.1668 ns |  12.895 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 5.0 |  12.553 ns |   0.6334 ns |  0.0347 ns |  12.565 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                                     From_ParentStruct | .NET Core 3.1 |  34.960 ns |   1.5539 ns |  0.0852 ns |  34.922 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 5.0 |  33.524 ns |   1.0281 ns |  0.0564 ns |  33.537 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                            From_ParentStruct_AsObject | .NET Core 3.1 |  14.649 ns |   0.3682 ns |  0.0202 ns |  14.654 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 5.0 |  15.163 ns |   0.4019 ns |  0.0220 ns |  15.159 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                  From_ParentStruct_Nullable_WithValue | .NET Core 3.1 |  36.748 ns |   3.1831 ns |  0.1745 ns |  36.780 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 5.0 |  28.253 ns |   0.5483 ns |  0.0301 ns |  28.263 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 3.1 |  16.275 ns |   1.0487 ns |  0.0575 ns |  16.287 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 5.0 |  15.631 ns |   9.5231 ns |  0.5220 ns |  15.749 ns |  0.96 |    0.03 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                    From_ParentStruct_Nullable_NoValue | .NET Core 3.1 |  35.438 ns |  12.0752 ns |  0.6619 ns |  35.761 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 5.0 |  28.049 ns |   0.4175 ns |  0.0229 ns |  28.046 ns |  0.79 |    0.02 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 3.1 |  14.371 ns |   0.0907 ns |  0.0050 ns |  14.373 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 5.0 |  13.133 ns |   0.2244 ns |  0.0123 ns |  13.138 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                                             From_Bool | .NET Core 3.1 |   6.083 ns |   1.7629 ns |  0.0966 ns |   6.123 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 5.0 |   6.217 ns |   0.1407 ns |  0.0077 ns |   6.222 ns |  1.02 |    0.02 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                                    From_Bool_AsObject | .NET Core 3.1 |         NA |          NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 5.0 |         NA |          NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                          From_Bool_Nullable_WithValue | .NET Core 3.1 |   6.479 ns |   0.4576 ns |  0.0251 ns |   6.480 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 5.0 |   5.861 ns |   0.2620 ns |  0.0144 ns |   5.853 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 3.1 |         NA |          NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 5.0 |         NA |          NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                            From_Bool_Nullable_NoValue | .NET Core 3.1 |   6.453 ns |   1.9829 ns |  0.1087 ns |   6.408 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 5.0 |   6.272 ns |   0.2406 ns |  0.0132 ns |   6.276 ns |  0.97 |    0.02 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 3.1 |  12.570 ns |   0.1833 ns |  0.0100 ns |  12.569 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 5.0 |  12.779 ns |   3.3559 ns |  0.1839 ns |  12.705 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                                             From_Byte | .NET Core 3.1 |   6.519 ns |   5.6703 ns |  0.3108 ns |   6.386 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 5.0 |   6.421 ns |   1.2779 ns |  0.0700 ns |   6.415 ns |  0.99 |    0.04 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                                    From_Byte_AsObject | .NET Core 3.1 |         NA |          NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 5.0 |         NA |          NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                          From_Byte_Nullable_WithValue | .NET Core 3.1 |   6.002 ns |   0.1190 ns |  0.0065 ns |   6.006 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 5.0 |   6.493 ns |   0.2543 ns |  0.0139 ns |   6.488 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 3.1 |         NA |          NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 5.0 |         NA |          NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                            From_Byte_Nullable_NoValue | .NET Core 3.1 |   5.968 ns |   0.7133 ns |  0.0391 ns |   5.952 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 5.0 |   6.613 ns |   1.5758 ns |  0.0864 ns |   6.653 ns |  1.11 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 3.1 |  12.559 ns |   2.5005 ns |  0.1371 ns |  12.502 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 5.0 |  14.807 ns |   2.6328 ns |  0.1443 ns |  14.725 ns |  1.18 |    0.02 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                                             From_Char | .NET Core 3.1 |   6.584 ns |   7.9539 ns |  0.4360 ns |   6.829 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Char | .NET Core 5.0 |   6.357 ns |   1.1030 ns |  0.0605 ns |   6.335 ns |  0.97 |    0.06 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                                    From_Char_AsObject | .NET Core 3.1 |         NA |          NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 5.0 |         NA |          NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                          From_Char_Nullable_WithValue | .NET Core 3.1 |   5.930 ns |   0.2823 ns |  0.0155 ns |   5.934 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 5.0 |   6.795 ns |   4.9733 ns |  0.2726 ns |   6.736 ns |  1.15 |    0.05 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 3.1 |         NA |          NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 5.0 |         NA |          NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                            From_Char_Nullable_NoValue | .NET Core 3.1 |   6.379 ns |   0.3090 ns |  0.0169 ns |   6.375 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 5.0 |   5.965 ns |   1.3788 ns |  0.0756 ns |   5.928 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 3.1 |  12.537 ns |   3.8609 ns |  0.2116 ns |  12.428 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 5.0 |  12.971 ns |   7.4825 ns |  0.4101 ns |  12.849 ns |  1.03 |    0.02 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                                         From_DateTime | .NET Core 3.1 |   9.095 ns |   0.1060 ns |  0.0058 ns |   9.098 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 5.0 |   9.328 ns |   0.4253 ns |  0.0233 ns |   9.322 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                                From_DateTime_AsObject | .NET Core 3.1 |  23.049 ns |   6.7973 ns |  0.3726 ns |  22.839 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 5.0 |  22.733 ns |   4.9818 ns |  0.2731 ns |  22.764 ns |  0.99 |    0.02 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                      From_DateTime_Nullable_WithValue | .NET Core 3.1 |   7.555 ns |   0.5059 ns |  0.0277 ns |   7.559 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 5.0 |   5.833 ns |   1.2330 ns |  0.0676 ns |   5.854 ns |  0.77 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 3.1 |  25.089 ns |   2.0148 ns |  0.1104 ns |  25.141 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 5.0 |  22.624 ns |   1.3623 ns |  0.0747 ns |  22.592 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                        From_DateTime_Nullable_NoValue | .NET Core 3.1 |   7.302 ns |   2.0957 ns |  0.1149 ns |   7.294 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 5.0 |   5.921 ns |   1.9460 ns |  0.1067 ns |   5.890 ns |  0.81 |    0.03 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 3.1 |  12.688 ns |   6.1250 ns |  0.3357 ns |  12.622 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 5.0 |  12.755 ns |   3.1500 ns |  0.1727 ns |  12.670 ns |  1.01 |    0.03 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                                          From_Decimal | .NET Core 3.1 |   7.619 ns |   2.4649 ns |  0.1351 ns |   7.550 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 5.0 |   6.001 ns |   0.3630 ns |  0.0199 ns |   6.005 ns |  0.79 |    0.02 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                                 From_Decimal_AsObject | .NET Core 3.1 |         NA |          NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 5.0 |         NA |          NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                       From_Decimal_Nullable_WithValue | .NET Core 3.1 |   7.140 ns |   0.8384 ns |  0.0460 ns |   7.136 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 5.0 |   6.388 ns |   5.4423 ns |  0.2983 ns |   6.330 ns |  0.89 |    0.04 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 3.1 |         NA |          NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 5.0 |         NA |          NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                         From_Decimal_Nullable_NoValue | .NET Core 3.1 |   7.798 ns |   2.7434 ns |  0.1504 ns |   7.852 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 5.0 |   6.356 ns |   2.0692 ns |  0.1134 ns |   6.317 ns |  0.82 |    0.02 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 3.1 |  13.683 ns |   3.2533 ns |  0.1783 ns |  13.658 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 5.0 |  12.835 ns |   2.8960 ns |  0.1587 ns |  12.774 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                                           From_Double | .NET Core 3.1 |   6.187 ns |   0.3915 ns |  0.0215 ns |   6.196 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 5.0 |   6.168 ns |   1.2796 ns |  0.0701 ns |   6.131 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                                  From_Double_AsObject | .NET Core 3.1 |         NA |          NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 5.0 |         NA |          NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                        From_Double_Nullable_WithValue | .NET Core 3.1 |   9.271 ns |   0.2995 ns |  0.0164 ns |   9.279 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 5.0 |   8.011 ns |   0.4096 ns |  0.0225 ns |   8.008 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
               From_Double_Nullable_WithValue_AsObject | .NET Core 3.1 |         NA |          NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 5.0 |         NA |          NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                          From_Double_Nullable_NoValue | .NET Core 3.1 |   7.723 ns |   1.3622 ns |  0.0747 ns |   7.704 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 5.0 |   6.629 ns |   1.1109 ns |  0.0609 ns |   6.597 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 3.1 |  13.517 ns |   4.5449 ns |  0.2491 ns |  13.396 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 5.0 |  12.823 ns |   3.9255 ns |  0.2152 ns |  12.703 ns |  0.95 |    0.03 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                                            From_Short | .NET Core 3.1 |   6.325 ns |   0.3578 ns |  0.0196 ns |   6.326 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 5.0 |   6.456 ns |   3.1021 ns |  0.1700 ns |   6.370 ns |  1.02 |    0.03 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                                   From_Short_AsObject | .NET Core 3.1 |         NA |          NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 5.0 |         NA |          NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                         From_Short_Nullable_WithValue | .NET Core 3.1 |   7.294 ns |   1.5996 ns |  0.0877 ns |   7.244 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 5.0 |   6.533 ns |   0.3032 ns |  0.0166 ns |   6.540 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                From_Short_Nullable_WithValue_AsObject | .NET Core 3.1 |         NA |          NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 5.0 |         NA |          NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                           From_Short_Nullable_NoValue | .NET Core 3.1 |   5.947 ns |   0.7413 ns |  0.0406 ns |   5.947 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 5.0 |   5.953 ns |   1.2281 ns |  0.0673 ns |   5.972 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 3.1 |  12.682 ns |   3.8424 ns |  0.2106 ns |  12.571 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 5.0 |  12.900 ns |   0.2655 ns |  0.0146 ns |  12.904 ns |  1.02 |    0.02 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                                              From_Int | .NET Core 3.1 |   7.922 ns |   1.8681 ns |  0.1024 ns |   7.875 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 5.0 |   6.540 ns |   1.1345 ns |  0.0622 ns |   6.534 ns |  0.83 |    0.02 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                                     From_Int_AsObject | .NET Core 3.1 |         NA |          NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 5.0 |         NA |          NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                           From_Int_Nullable_WithValue | .NET Core 3.1 |   6.152 ns |   0.2577 ns |  0.0141 ns |   6.145 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 5.0 |   6.600 ns |   2.1317 ns |  0.1168 ns |   6.573 ns |  1.07 |    0.02 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 3.1 |         NA |          NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 5.0 |         NA |          NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                             From_Int_Nullable_NoValue | .NET Core 3.1 |   6.660 ns |   4.5485 ns |  0.2493 ns |   6.525 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 5.0 |   6.644 ns |   2.1495 ns |  0.1178 ns |   6.667 ns |  1.00 |    0.05 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 3.1 |  13.597 ns |   4.1708 ns |  0.2286 ns |  13.603 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 5.0 |  12.688 ns |   2.2579 ns |  0.1238 ns |  12.650 ns |  0.93 |    0.02 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                                             From_Long | .NET Core 3.1 |   6.681 ns |   2.4483 ns |  0.1342 ns |   6.637 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Long | .NET Core 5.0 |   6.125 ns |   2.7961 ns |  0.1533 ns |   6.052 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                                    From_Long_AsObject | .NET Core 3.1 |         NA |          NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 5.0 |         NA |          NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                          From_Long_Nullable_WithValue | .NET Core 3.1 |   7.599 ns |   1.9841 ns |  0.1088 ns |   7.567 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 5.0 |   6.589 ns |   0.2553 ns |  0.0140 ns |   6.588 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 3.1 |         NA |          NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 5.0 |         NA |          NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                            From_Long_Nullable_NoValue | .NET Core 3.1 |   7.509 ns |   0.0676 ns |  0.0037 ns |   7.508 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 5.0 |   6.676 ns |   2.4776 ns |  0.1358 ns |   6.602 ns |  0.89 |    0.02 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 3.1 |  12.646 ns |   2.7268 ns |  0.1495 ns |  12.571 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 5.0 |  12.695 ns |   2.2402 ns |  0.1228 ns |  12.670 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                                            From_SByte | .NET Core 3.1 |   6.389 ns |   1.4064 ns |  0.0771 ns |   6.395 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 5.0 |   6.425 ns |   2.9866 ns |  0.1637 ns |   6.462 ns |  1.01 |    0.03 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                                   From_SByte_AsObject | .NET Core 3.1 |         NA |          NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 5.0 |         NA |          NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                         From_SByte_Nullable_WithValue | .NET Core 3.1 |   6.049 ns |   1.5499 ns |  0.0850 ns |   6.018 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 5.0 |   6.311 ns |   1.4968 ns |  0.0820 ns |   6.282 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 3.1 |         NA |          NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 5.0 |         NA |          NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                           From_SByte_Nullable_NoValue | .NET Core 3.1 |   5.970 ns |   1.3377 ns |  0.0733 ns |   6.012 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 5.0 |   6.971 ns |   0.8080 ns |  0.0443 ns |   6.990 ns |  1.17 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 3.1 |  12.739 ns |   2.7486 ns |  0.1507 ns |  12.751 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 5.0 |  12.599 ns |   0.3660 ns |  0.0201 ns |  12.593 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                                            From_Float | .NET Core 3.1 |   6.661 ns |   0.5907 ns |  0.0324 ns |   6.678 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 5.0 |   6.151 ns |   1.3033 ns |  0.0714 ns |   6.116 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                                   From_Float_AsObject | .NET Core 3.1 |         NA |          NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 5.0 |         NA |          NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                         From_Float_Nullable_WithValue | .NET Core 3.1 |   6.198 ns |   2.0134 ns |  0.1104 ns |   6.244 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 5.0 |   5.949 ns |   1.6992 ns |  0.0931 ns |   5.952 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                From_Float_Nullable_WithValue_AsObject | .NET Core 3.1 |         NA |          NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 5.0 |         NA |          NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                           From_Float_Nullable_NoValue | .NET Core 3.1 |   6.405 ns |   1.7777 ns |  0.0974 ns |   6.374 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 5.0 |   5.986 ns |   1.6389 ns |  0.0898 ns |   5.935 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 3.1 |  14.738 ns |   0.2453 ns |  0.0134 ns |  14.735 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 5.0 |  13.120 ns |   4.3560 ns |  0.2388 ns |  13.251 ns |  0.89 |    0.02 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                                           From_String | .NET Core 3.1 | 421.671 ns |  51.7970 ns |  2.8392 ns | 420.318 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 5.0 | 371.018 ns |  76.6214 ns |  4.1999 ns | 370.401 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                                  From_String_AsObject | .NET Core 3.1 | 427.391 ns | 261.3142 ns | 14.3235 ns | 419.582 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 5.0 | 376.812 ns |  11.8109 ns |  0.6474 ns | 377.034 ns |  0.88 |    0.03 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                                      From_String_Null | .NET Core 3.1 |  10.875 ns |   4.2987 ns |  0.2356 ns |  10.939 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 5.0 |  11.142 ns |   2.9844 ns |  0.1636 ns |  11.052 ns |  1.03 |    0.04 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                             From_String_Null_AsObject | .NET Core 3.1 |  12.552 ns |   0.1599 ns |  0.0088 ns |  12.553 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 5.0 |  12.626 ns |   1.7374 ns |  0.0952 ns |  12.580 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                                     From_String_Empty | .NET Core 3.1 |  10.076 ns |   1.5482 ns |  0.0849 ns |  10.029 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 5.0 |   9.830 ns |   1.8053 ns |  0.0990 ns |   9.777 ns |  0.98 |    0.02 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                            From_String_Empty_AsObject | .NET Core 3.1 |         NA |          NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 5.0 |         NA |          NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                                           From_UShort | .NET Core 3.1 |   6.275 ns |   0.3610 ns |  0.0198 ns |   6.264 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 5.0 |   6.263 ns |   7.7963 ns |  0.4273 ns |   6.091 ns |  1.00 |    0.06 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                                  From_UShort_AsObject | .NET Core 3.1 |         NA |          NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 5.0 |         NA |          NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                        From_UShort_Nullable_WithValue | .NET Core 3.1 |   6.554 ns |   0.2160 ns |  0.0118 ns |   6.558 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 5.0 |   5.914 ns |   0.6842 ns |  0.0375 ns |   5.932 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 3.1 |         NA |          NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 5.0 |         NA |          NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                          From_UShort_Nullable_NoValue | .NET Core 3.1 |   6.161 ns |   1.8079 ns |  0.0991 ns |   6.104 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 5.0 |   5.994 ns |   1.7675 ns |  0.0969 ns |   6.002 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 3.1 |  13.533 ns |   6.6904 ns |  0.3667 ns |  13.325 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 5.0 |  12.626 ns |   2.9465 ns |  0.1615 ns |  12.559 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                                             From_UInt | .NET Core 3.1 |   6.577 ns |   1.8742 ns |  0.1027 ns |   6.625 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 5.0 |   6.267 ns |   0.0620 ns |  0.0034 ns |   6.268 ns |  0.95 |    0.02 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                                    From_UInt_AsObject | .NET Core 3.1 |         NA |          NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 5.0 |         NA |          NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                          From_UInt_Nullable_WithValue | .NET Core 3.1 |   6.570 ns |   0.6809 ns |  0.0373 ns |   6.586 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 5.0 |   6.607 ns |   1.3932 ns |  0.0764 ns |   6.592 ns |  1.01 |    0.02 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 3.1 |         NA |          NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 5.0 |         NA |          NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                            From_UInt_Nullable_NoValue | .NET Core 3.1 |   8.235 ns |   1.6842 ns |  0.0923 ns |   8.184 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 5.0 |   7.247 ns |  10.5367 ns |  0.5776 ns |   7.562 ns |  0.88 |    0.07 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 3.1 |  14.472 ns |   3.7602 ns |  0.2061 ns |  14.543 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 5.0 |  13.074 ns |   8.5961 ns |  0.4712 ns |  13.113 ns |  0.90 |    0.04 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                                            From_ULong | .NET Core 3.1 |   7.236 ns |   0.5615 ns |  0.0308 ns |   7.232 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 5.0 |   6.331 ns |   0.1055 ns |  0.0058 ns |   6.331 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                                   From_ULong_AsObject | .NET Core 3.1 |         NA |          NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 5.0 |         NA |          NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                         From_ULong_Nullable_WithValue | .NET Core 3.1 |   7.625 ns |   2.1732 ns |  0.1191 ns |   7.649 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 5.0 |   6.428 ns |  12.9165 ns |  0.7080 ns |   6.097 ns |  0.84 |    0.09 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 3.1 |         NA |          NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 5.0 |         NA |          NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                           From_ULong_Nullable_NoValue | .NET Core 3.1 |   6.984 ns |   0.4560 ns |  0.0250 ns |   6.977 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 5.0 |   5.936 ns |   0.6862 ns |  0.0376 ns |   5.921 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 3.1 |  11.285 ns |   0.2759 ns |  0.0151 ns |  11.289 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 5.0 |  12.643 ns |   4.3570 ns |  0.2388 ns |  12.530 ns |  1.12 |    0.02 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                                       From_NullObject | .NET Core 3.1 |  12.840 ns |   0.3763 ns |  0.0206 ns |  12.837 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 5.0 |  12.562 ns |   0.7487 ns |  0.0410 ns |  12.538 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                                           From_DBNull | .NET Core 3.1 |   9.779 ns |   2.6259 ns |  0.1439 ns |   9.700 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 5.0 |   9.257 ns |   1.1294 ns |  0.0619 ns |   9.223 ns |  0.95 |    0.02 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                                  From_DBNull_AsObject | .NET Core 3.1 |  13.699 ns |   2.1193 ns |  0.1162 ns |  13.660 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 5.0 |  13.764 ns |  24.1417 ns |  1.3233 ns |  13.364 ns |  1.00 |    0.09 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                                 From_ConvertibleClass | .NET Core 3.1 |  14.362 ns |   1.1736 ns |  0.0643 ns |  14.329 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 5.0 |  16.409 ns |   3.4548 ns |  0.1894 ns |  16.421 ns |  1.14 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                        From_ConvertibleClass_AsObject | .NET Core 3.1 |  18.259 ns |   3.9857 ns |  0.2185 ns |  18.225 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 5.0 |  18.685 ns |   0.7995 ns |  0.0438 ns |  18.705 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                         From_ConvertibleClass_NoValue | .NET Core 3.1 |  13.186 ns |   1.0381 ns |  0.0569 ns |  13.165 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 5.0 |  12.426 ns |   2.1954 ns |  0.1203 ns |  12.375 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 3.1 |  11.921 ns |   7.4887 ns |  0.4105 ns |  11.782 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 5.0 |  12.554 ns |   0.4778 ns |  0.0262 ns |  12.541 ns |  1.05 |    0.04 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                              From_NonConvertibleClass | .NET Core 3.1 |   9.663 ns |   0.3093 ns |  0.0170 ns |   9.659 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 5.0 |   9.057 ns |   0.0637 ns |  0.0035 ns |   9.055 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                     From_NonConvertibleClass_AsObject | .NET Core 3.1 |  15.056 ns |   4.2473 ns |  0.2328 ns |  14.923 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 5.0 |  14.744 ns |   2.2277 ns |  0.1221 ns |  14.682 ns |  0.98 |    0.02 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                      From_NonConvertibleClass_NoValue | .NET Core 3.1 |   9.672 ns |   0.7973 ns |  0.0437 ns |   9.652 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 5.0 |   9.330 ns |   1.5480 ns |  0.0849 ns |   9.331 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 3.1 |  12.560 ns |   0.2175 ns |  0.0119 ns |  12.554 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 5.0 |  15.074 ns |   5.5839 ns |  0.3061 ns |  15.045 ns |  1.20 |    0.03 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                                From_ConvertibleStruct | .NET Core 3.1 |  14.697 ns |   0.0592 ns |  0.0032 ns |  14.696 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 5.0 |  14.087 ns |   2.0652 ns |  0.1132 ns |  14.024 ns |  0.96 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                       From_ConvertibleStruct_AsObject | .NET Core 3.1 |  18.779 ns |   0.4444 ns |  0.0244 ns |  18.776 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 5.0 |  19.429 ns |   1.0740 ns |  0.0589 ns |  19.415 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 3.1 |  14.485 ns |   1.5695 ns |  0.0860 ns |  14.532 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 5.0 |  15.403 ns |   0.7496 ns |  0.0411 ns |  15.410 ns |  1.06 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.1 |  19.586 ns |  11.3623 ns |  0.6228 ns |  19.828 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 5.0 |  19.449 ns |   3.5047 ns |  0.1921 ns |  19.392 ns |  0.99 |    0.03 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 3.1 |   7.495 ns |   0.7340 ns |  0.0402 ns |   7.486 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 5.0 |   8.381 ns |   0.5114 ns |  0.0280 ns |   8.387 ns |  1.12 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.1 |  12.855 ns |   0.4033 ns |  0.0221 ns |  12.844 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 5.0 |  12.637 ns |   2.9610 ns |  0.1623 ns |  12.557 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                             From_NonConvertibleStruct | .NET Core 3.1 |   5.900 ns |   0.3904 ns |  0.0214 ns |   5.895 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 5.0 |   6.278 ns |   1.3975 ns |  0.0766 ns |   6.257 ns |  1.06 |    0.02 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                    From_NonConvertibleStruct_AsObject | .NET Core 3.1 |  13.627 ns |   0.8758 ns |  0.0480 ns |  13.647 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 5.0 |  14.738 ns |   0.4627 ns |  0.0254 ns |  14.748 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 3.1 |   5.983 ns |   1.1052 ns |  0.0606 ns |   5.985 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 5.0 |   5.875 ns |   0.1002 ns |  0.0055 ns |   5.877 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.1 |  14.407 ns |   3.3684 ns |  0.1846 ns |  14.432 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 5.0 |  14.553 ns |   4.3125 ns |  0.2364 ns |  14.622 ns |  1.01 |    0.03 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 3.1 |   6.084 ns |   2.9571 ns |  0.1621 ns |   6.096 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 5.0 |   6.679 ns |  12.8715 ns |  0.7055 ns |   7.014 ns |  1.10 |    0.09 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.1 |  12.647 ns |   3.0529 ns |  0.1673 ns |  12.578 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 5.0 |  12.577 ns |   3.3534 ns |  0.1838 ns |  12.476 ns |  0.99 |    0.02 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                                             From_Enum | .NET Core 3.1 |   6.152 ns |   2.3248 ns |  0.1274 ns |   6.204 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 5.0 |   6.016 ns |   0.5167 ns |  0.0283 ns |   6.005 ns |  0.98 |    0.03 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                                    From_Enum_AsObject | .NET Core 3.1 |         NA |          NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Enum_AsObject | .NET Core 5.0 |         NA |          NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                          From_Enum_Nullable_WithValue | .NET Core 3.1 |   5.974 ns |   2.4160 ns |  0.1324 ns |   5.914 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 5.0 |   5.866 ns |   0.3625 ns |  0.0199 ns |   5.854 ns |  0.98 |    0.02 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 3.1 |         NA |          NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 5.0 |         NA |          NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                            From_Enum_Nullable_NoValue | .NET Core 3.1 |   5.915 ns |   0.5311 ns |  0.0291 ns |   5.899 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 5.0 |   5.956 ns |   1.7234 ns |  0.0945 ns |   6.005 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 3.1 |  13.764 ns |   6.9143 ns |  0.3790 ns |  13.836 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 5.0 |  12.613 ns |   2.3874 ns |  0.1309 ns |  12.555 ns |  0.92 |    0.03 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                                      From_ParentClass | .NET Core 3.1 |   9.824 ns |   2.6044 ns |  0.1428 ns |   9.750 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 5.0 |   9.298 ns |   3.1322 ns |  0.1717 ns |   9.223 ns |  0.95 |    0.03 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                             From_ParentClass_AsObject | .NET Core 3.1 |  15.348 ns |   5.8140 ns |  0.3187 ns |  15.265 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 5.0 |  14.952 ns |   2.4260 ns |  0.1330 ns |  15.010 ns |  0.97 |    0.02 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                              From_ParentClass_NoValue | .NET Core 3.1 |   9.723 ns |   2.4082 ns |  0.1320 ns |   9.655 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 5.0 |   9.192 ns |   2.9144 ns |  0.1597 ns |   9.178 ns |  0.95 |    0.03 |      - |     - |     - |         - |

Benchmarks with issues:
  ConvertTo_DateTimeNullable.From_Bool_AsObject: ShortRun(Toolchain=.NET Core 3.1, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DateTimeNullable.From_Bool_AsObject: ShortRun(Toolchain=.NET Core 5.0, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DateTimeNullable.From_Bool_Nullable_WithValue_AsObject: ShortRun(Toolchain=.NET Core 3.1, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DateTimeNullable.From_Bool_Nullable_WithValue_AsObject: ShortRun(Toolchain=.NET Core 5.0, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DateTimeNullable.From_Byte_AsObject: ShortRun(Toolchain=.NET Core 3.1, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DateTimeNullable.From_Byte_AsObject: ShortRun(Toolchain=.NET Core 5.0, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DateTimeNullable.From_Byte_Nullable_WithValue_AsObject: ShortRun(Toolchain=.NET Core 3.1, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DateTimeNullable.From_Byte_Nullable_WithValue_AsObject: ShortRun(Toolchain=.NET Core 5.0, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DateTimeNullable.From_Char_AsObject: ShortRun(Toolchain=.NET Core 3.1, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DateTimeNullable.From_Char_AsObject: ShortRun(Toolchain=.NET Core 5.0, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DateTimeNullable.From_Char_Nullable_WithValue_AsObject: ShortRun(Toolchain=.NET Core 3.1, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DateTimeNullable.From_Char_Nullable_WithValue_AsObject: ShortRun(Toolchain=.NET Core 5.0, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DateTimeNullable.From_Decimal_AsObject: ShortRun(Toolchain=.NET Core 3.1, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DateTimeNullable.From_Decimal_AsObject: ShortRun(Toolchain=.NET Core 5.0, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DateTimeNullable.From_Decimal_Nullable_WithValue_AsObject: ShortRun(Toolchain=.NET Core 3.1, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DateTimeNullable.From_Decimal_Nullable_WithValue_AsObject: ShortRun(Toolchain=.NET Core 5.0, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DateTimeNullable.From_Double_AsObject: ShortRun(Toolchain=.NET Core 3.1, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DateTimeNullable.From_Double_AsObject: ShortRun(Toolchain=.NET Core 5.0, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DateTimeNullable.From_Double_Nullable_WithValue_AsObject: ShortRun(Toolchain=.NET Core 3.1, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DateTimeNullable.From_Double_Nullable_WithValue_AsObject: ShortRun(Toolchain=.NET Core 5.0, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DateTimeNullable.From_Short_AsObject: ShortRun(Toolchain=.NET Core 3.1, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DateTimeNullable.From_Short_AsObject: ShortRun(Toolchain=.NET Core 5.0, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DateTimeNullable.From_Short_Nullable_WithValue_AsObject: ShortRun(Toolchain=.NET Core 3.1, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DateTimeNullable.From_Short_Nullable_WithValue_AsObject: ShortRun(Toolchain=.NET Core 5.0, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DateTimeNullable.From_Int_AsObject: ShortRun(Toolchain=.NET Core 3.1, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DateTimeNullable.From_Int_AsObject: ShortRun(Toolchain=.NET Core 5.0, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DateTimeNullable.From_Int_Nullable_WithValue_AsObject: ShortRun(Toolchain=.NET Core 3.1, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DateTimeNullable.From_Int_Nullable_WithValue_AsObject: ShortRun(Toolchain=.NET Core 5.0, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DateTimeNullable.From_Long_AsObject: ShortRun(Toolchain=.NET Core 3.1, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DateTimeNullable.From_Long_AsObject: ShortRun(Toolchain=.NET Core 5.0, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DateTimeNullable.From_Long_Nullable_WithValue_AsObject: ShortRun(Toolchain=.NET Core 3.1, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DateTimeNullable.From_Long_Nullable_WithValue_AsObject: ShortRun(Toolchain=.NET Core 5.0, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DateTimeNullable.From_SByte_AsObject: ShortRun(Toolchain=.NET Core 3.1, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DateTimeNullable.From_SByte_AsObject: ShortRun(Toolchain=.NET Core 5.0, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DateTimeNullable.From_SByte_Nullable_WithValue_AsObject: ShortRun(Toolchain=.NET Core 3.1, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DateTimeNullable.From_SByte_Nullable_WithValue_AsObject: ShortRun(Toolchain=.NET Core 5.0, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DateTimeNullable.From_Float_AsObject: ShortRun(Toolchain=.NET Core 3.1, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DateTimeNullable.From_Float_AsObject: ShortRun(Toolchain=.NET Core 5.0, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DateTimeNullable.From_Float_Nullable_WithValue_AsObject: ShortRun(Toolchain=.NET Core 3.1, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DateTimeNullable.From_Float_Nullable_WithValue_AsObject: ShortRun(Toolchain=.NET Core 5.0, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DateTimeNullable.From_String_Empty_AsObject: ShortRun(Toolchain=.NET Core 3.1, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DateTimeNullable.From_String_Empty_AsObject: ShortRun(Toolchain=.NET Core 5.0, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DateTimeNullable.From_UShort_AsObject: ShortRun(Toolchain=.NET Core 3.1, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DateTimeNullable.From_UShort_AsObject: ShortRun(Toolchain=.NET Core 5.0, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DateTimeNullable.From_UShort_Nullable_WithValue_AsObject: ShortRun(Toolchain=.NET Core 3.1, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DateTimeNullable.From_UShort_Nullable_WithValue_AsObject: ShortRun(Toolchain=.NET Core 5.0, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DateTimeNullable.From_UInt_AsObject: ShortRun(Toolchain=.NET Core 3.1, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DateTimeNullable.From_UInt_AsObject: ShortRun(Toolchain=.NET Core 5.0, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DateTimeNullable.From_UInt_Nullable_WithValue_AsObject: ShortRun(Toolchain=.NET Core 3.1, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DateTimeNullable.From_UInt_Nullable_WithValue_AsObject: ShortRun(Toolchain=.NET Core 5.0, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DateTimeNullable.From_ULong_AsObject: ShortRun(Toolchain=.NET Core 3.1, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DateTimeNullable.From_ULong_AsObject: ShortRun(Toolchain=.NET Core 5.0, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DateTimeNullable.From_ULong_Nullable_WithValue_AsObject: ShortRun(Toolchain=.NET Core 3.1, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DateTimeNullable.From_ULong_Nullable_WithValue_AsObject: ShortRun(Toolchain=.NET Core 5.0, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DateTimeNullable.From_Enum_AsObject: ShortRun(Toolchain=.NET Core 3.1, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DateTimeNullable.From_Enum_AsObject: ShortRun(Toolchain=.NET Core 5.0, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DateTimeNullable.From_Enum_Nullable_WithValue_AsObject: ShortRun(Toolchain=.NET Core 3.1, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DateTimeNullable.From_Enum_Nullable_WithValue_AsObject: ShortRun(Toolchain=.NET Core 5.0, IterationCount=3, LaunchCount=1, WarmupCount=3)
