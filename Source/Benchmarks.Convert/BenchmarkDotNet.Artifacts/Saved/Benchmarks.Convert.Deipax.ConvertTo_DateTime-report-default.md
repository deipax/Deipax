
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

                                                Method |     Toolchain |       Mean |       Error |     StdDev |     Median | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------------------------------------------ |-------------- |-----------:|------------:|-----------:|-----------:|------:|--------:|-------:|------:|------:|----------:|
                     From_ParentClass_NoValue_AsObject | .NET Core 3.1 |  10.578 ns |   2.4100 ns |  0.1321 ns |  10.522 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 5.0 |  11.599 ns |   2.7912 ns |  0.1530 ns |  11.568 ns |  1.10 |    0.03 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                                     From_ParentStruct | .NET Core 3.1 |  33.696 ns |   0.6497 ns |  0.0356 ns |  33.684 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 5.0 |  32.452 ns |   7.3144 ns |  0.4009 ns |  32.337 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                            From_ParentStruct_AsObject | .NET Core 3.1 |  15.152 ns |   1.7247 ns |  0.0945 ns |  15.192 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 5.0 |  13.331 ns |   2.5327 ns |  0.1388 ns |  13.295 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                  From_ParentStruct_Nullable_WithValue | .NET Core 3.1 |  34.384 ns |   2.0312 ns |  0.1113 ns |  34.391 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 5.0 |  35.674 ns |   2.7464 ns |  0.1505 ns |  35.744 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 3.1 |  13.727 ns |   5.9865 ns |  0.3281 ns |  13.584 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 5.0 |  13.601 ns |   2.9335 ns |  0.1608 ns |  13.548 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                    From_ParentStruct_Nullable_NoValue | .NET Core 3.1 |  34.526 ns |   2.6695 ns |  0.1463 ns |  34.577 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 5.0 |  27.047 ns |   1.5880 ns |  0.0870 ns |  27.066 ns |  0.78 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 3.1 |  11.360 ns |   0.5229 ns |  0.0287 ns |  11.354 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 5.0 |  11.523 ns |   0.5847 ns |  0.0321 ns |  11.511 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                                             From_Bool | .NET Core 3.1 |   5.100 ns |   0.0795 ns |  0.0044 ns |   5.101 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 5.0 |   5.503 ns |   0.0681 ns |  0.0037 ns |   5.504 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                                    From_Bool_AsObject | .NET Core 3.1 |         NA |          NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 5.0 |         NA |          NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                          From_Bool_Nullable_WithValue | .NET Core 3.1 |   5.708 ns |   1.0556 ns |  0.0579 ns |   5.740 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 5.0 |   5.796 ns |   0.7949 ns |  0.0436 ns |   5.788 ns |  1.02 |    0.02 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 3.1 |         NA |          NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 5.0 |         NA |          NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                            From_Bool_Nullable_NoValue | .NET Core 3.1 |   5.260 ns |   1.1409 ns |  0.0625 ns |   5.288 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 5.0 |   5.788 ns |   0.5946 ns |  0.0326 ns |   5.794 ns |  1.10 |    0.02 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 3.1 |  10.589 ns |   3.2354 ns |  0.1773 ns |  10.497 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 5.0 |  12.513 ns |   0.1726 ns |  0.0095 ns |  12.515 ns |  1.18 |    0.02 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                                             From_Byte | .NET Core 3.1 |   5.596 ns |   0.2127 ns |  0.0117 ns |   5.589 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 5.0 |   5.576 ns |   1.7543 ns |  0.0962 ns |   5.528 ns |  1.00 |    0.02 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                                    From_Byte_AsObject | .NET Core 3.1 |         NA |          NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 5.0 |         NA |          NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                          From_Byte_Nullable_WithValue | .NET Core 3.1 |   5.919 ns |   1.0576 ns |  0.0580 ns |   5.887 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 5.0 |   5.769 ns |   0.3666 ns |  0.0201 ns |   5.764 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 3.1 |         NA |          NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 5.0 |         NA |          NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                            From_Byte_Nullable_NoValue | .NET Core 3.1 |   5.905 ns |   0.1728 ns |  0.0095 ns |   5.905 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 5.0 |   5.847 ns |   0.9709 ns |  0.0532 ns |   5.835 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 3.1 |  11.653 ns |   0.6123 ns |  0.0336 ns |  11.648 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 5.0 |  11.614 ns |   2.6512 ns |  0.1453 ns |  11.534 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                                             From_Char | .NET Core 3.1 |   5.587 ns |   0.0863 ns |  0.0047 ns |   5.588 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Char | .NET Core 5.0 |   5.503 ns |   0.2380 ns |  0.0130 ns |   5.509 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                                    From_Char_AsObject | .NET Core 3.1 |         NA |          NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 5.0 |         NA |          NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                          From_Char_Nullable_WithValue | .NET Core 3.1 |   5.207 ns |   0.6652 ns |  0.0365 ns |   5.192 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 5.0 |   6.081 ns |   2.3268 ns |  0.1275 ns |   6.030 ns |  1.17 |    0.03 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 3.1 |         NA |          NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 5.0 |         NA |          NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                            From_Char_Nullable_NoValue | .NET Core 3.1 |   5.155 ns |   0.3030 ns |  0.0166 ns |   5.157 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 5.0 |   5.825 ns |   1.2992 ns |  0.0712 ns |   5.848 ns |  1.13 |    0.02 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 3.1 |  11.607 ns |   2.3020 ns |  0.1262 ns |  11.585 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 5.0 |  11.669 ns |   4.0718 ns |  0.2232 ns |  11.711 ns |  1.01 |    0.02 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                                         From_DateTime | .NET Core 3.1 |   6.643 ns |   7.1791 ns |  0.3935 ns |   6.850 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 5.0 |   6.230 ns |   0.9319 ns |  0.0511 ns |   6.223 ns |  0.94 |    0.06 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                                From_DateTime_AsObject | .NET Core 3.1 |  12.739 ns |   0.1221 ns |  0.0067 ns |  12.741 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 5.0 |  11.879 ns |   0.3427 ns |  0.0188 ns |  11.883 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                      From_DateTime_Nullable_WithValue | .NET Core 3.1 |   7.530 ns |   3.1919 ns |  0.1750 ns |   7.568 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 5.0 |   5.822 ns |   0.1284 ns |  0.0070 ns |   5.820 ns |  0.77 |    0.02 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 3.1 |  11.980 ns |   0.2315 ns |  0.0127 ns |  11.974 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 5.0 |  11.906 ns |   2.9272 ns |  0.1604 ns |  11.860 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                        From_DateTime_Nullable_NoValue | .NET Core 3.1 |   6.721 ns |   3.0088 ns |  0.1649 ns |   6.637 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 5.0 |   5.413 ns |   1.2908 ns |  0.0708 ns |   5.384 ns |  0.81 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 3.1 |  11.681 ns |   0.6227 ns |  0.0341 ns |  11.700 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 5.0 |  11.621 ns |   1.5321 ns |  0.0840 ns |  11.573 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                                          From_Decimal | .NET Core 3.1 |   6.372 ns |   0.1239 ns |  0.0068 ns |   6.373 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 5.0 |   5.793 ns |   1.1063 ns |  0.0606 ns |   5.818 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                                 From_Decimal_AsObject | .NET Core 3.1 |         NA |          NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 5.0 |         NA |          NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                       From_Decimal_Nullable_WithValue | .NET Core 3.1 |   6.518 ns |   1.3675 ns |  0.0750 ns |   6.478 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 5.0 |   6.229 ns |   0.3326 ns |  0.0182 ns |   6.238 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 3.1 |         NA |          NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 5.0 |         NA |          NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                         From_Decimal_Nullable_NoValue | .NET Core 3.1 |   6.977 ns |   2.3584 ns |  0.1293 ns |   6.907 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 5.0 |   6.114 ns |   1.0903 ns |  0.0598 ns |   6.140 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 3.1 |  13.389 ns |   0.4815 ns |  0.0264 ns |  13.401 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 5.0 |  11.599 ns |   2.2653 ns |  0.1242 ns |  11.533 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                                           From_Double | .NET Core 3.1 |   5.162 ns |   1.0799 ns |  0.0592 ns |   5.129 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 5.0 |   5.646 ns |   0.9914 ns |  0.0543 ns |   5.660 ns |  1.09 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                                  From_Double_AsObject | .NET Core 3.1 |         NA |          NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 5.0 |         NA |          NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                        From_Double_Nullable_WithValue | .NET Core 3.1 |   8.027 ns |   1.7281 ns |  0.0947 ns |   8.028 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 5.0 |   5.854 ns |   0.2160 ns |  0.0118 ns |   5.860 ns |  0.73 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
               From_Double_Nullable_WithValue_AsObject | .NET Core 3.1 |         NA |          NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 5.0 |         NA |          NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                          From_Double_Nullable_NoValue | .NET Core 3.1 |   6.916 ns |   0.5340 ns |  0.0293 ns |   6.910 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 5.0 |   5.843 ns |   1.5575 ns |  0.0854 ns |   5.848 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 3.1 |  10.483 ns |   2.1003 ns |  0.1151 ns |  10.430 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 5.0 |  11.644 ns |   0.6036 ns |  0.0331 ns |  11.654 ns |  1.11 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                                            From_Short | .NET Core 3.1 |   5.540 ns |   0.4456 ns |  0.0244 ns |   5.551 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 5.0 |   5.545 ns |   1.2184 ns |  0.0668 ns |   5.509 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                                   From_Short_AsObject | .NET Core 3.1 |         NA |          NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 5.0 |         NA |          NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                         From_Short_Nullable_WithValue | .NET Core 3.1 |   5.896 ns |   0.3962 ns |  0.0217 ns |   5.896 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 5.0 |   5.854 ns |   2.1147 ns |  0.1159 ns |   5.810 ns |  0.99 |    0.02 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                From_Short_Nullable_WithValue_AsObject | .NET Core 3.1 |         NA |          NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 5.0 |         NA |          NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                           From_Short_Nullable_NoValue | .NET Core 3.1 |   5.340 ns |   2.3763 ns |  0.1303 ns |   5.410 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 5.0 |   5.738 ns |   0.1537 ns |  0.0084 ns |   5.738 ns |  1.08 |    0.03 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 3.1 |  11.458 ns |   2.5323 ns |  0.1388 ns |  11.513 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 5.0 |  11.969 ns |   7.4247 ns |  0.4070 ns |  12.019 ns |  1.04 |    0.05 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                                              From_Int | .NET Core 3.1 |   5.602 ns |   1.3057 ns |  0.0716 ns |   5.631 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 5.0 |   5.602 ns |   1.1633 ns |  0.0638 ns |   5.615 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                                     From_Int_AsObject | .NET Core 3.1 |         NA |          NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 5.0 |         NA |          NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                           From_Int_Nullable_WithValue | .NET Core 3.1 |   5.688 ns |   1.5422 ns |  0.0845 ns |   5.642 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 5.0 |   5.793 ns |   0.8138 ns |  0.0446 ns |   5.786 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 3.1 |         NA |          NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 5.0 |         NA |          NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                             From_Int_Nullable_NoValue | .NET Core 3.1 |   5.888 ns |   0.0311 ns |  0.0017 ns |   5.888 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 5.0 |   5.886 ns |   1.7003 ns |  0.0932 ns |   5.838 ns |  1.00 |    0.02 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 3.1 |  11.654 ns |   2.2220 ns |  0.1218 ns |  11.588 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 5.0 |  11.638 ns |   3.0109 ns |  0.1650 ns |  11.596 ns |  1.00 |    0.02 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                                             From_Long | .NET Core 3.1 |   4.971 ns |   0.5942 ns |  0.0326 ns |   4.971 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Long | .NET Core 5.0 |   5.817 ns |   4.1242 ns |  0.2261 ns |   5.733 ns |  1.17 |    0.04 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                                    From_Long_AsObject | .NET Core 3.1 |         NA |          NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 5.0 |         NA |          NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                          From_Long_Nullable_WithValue | .NET Core 3.1 |   6.875 ns |   0.5313 ns |  0.0291 ns |   6.890 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 5.0 |   5.808 ns |   2.0513 ns |  0.1124 ns |   5.862 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 3.1 |         NA |          NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 5.0 |         NA |          NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                            From_Long_Nullable_NoValue | .NET Core 3.1 |   6.893 ns |   0.2398 ns |  0.0131 ns |   6.890 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 5.0 |   5.858 ns |   0.6578 ns |  0.0361 ns |   5.878 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 3.1 |  10.437 ns |   1.9279 ns |  0.1057 ns |  10.382 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 5.0 |  11.615 ns |   2.6113 ns |  0.1431 ns |  11.591 ns |  1.11 |    0.02 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                                            From_SByte | .NET Core 3.1 |   5.081 ns |   1.1371 ns |  0.0623 ns |   5.098 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 5.0 |   5.569 ns |   1.7811 ns |  0.0976 ns |   5.526 ns |  1.10 |    0.03 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                                   From_SByte_AsObject | .NET Core 3.1 |         NA |          NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 5.0 |         NA |          NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                         From_SByte_Nullable_WithValue | .NET Core 3.1 |   5.867 ns |   0.2173 ns |  0.0119 ns |   5.868 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 5.0 |   5.810 ns |   1.1828 ns |  0.0648 ns |   5.823 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 3.1 |         NA |          NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 5.0 |         NA |          NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                           From_SByte_Nullable_NoValue | .NET Core 3.1 |   5.168 ns |   0.9692 ns |  0.0531 ns |   5.144 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 5.0 |   5.772 ns |   0.7514 ns |  0.0412 ns |   5.749 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 3.1 |  10.438 ns |   0.1278 ns |  0.0070 ns |  10.435 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 5.0 |  11.547 ns |   0.9538 ns |  0.0523 ns |  11.528 ns |  1.11 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                                            From_Float | .NET Core 3.1 |   5.066 ns |   0.7999 ns |  0.0438 ns |   5.064 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 5.0 |   5.645 ns |   1.3806 ns |  0.0757 ns |   5.669 ns |  1.11 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                                   From_Float_AsObject | .NET Core 3.1 |         NA |          NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 5.0 |         NA |          NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                         From_Float_Nullable_WithValue | .NET Core 3.1 |   5.156 ns |   0.4286 ns |  0.0235 ns |   5.167 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 5.0 |   5.814 ns |   1.2114 ns |  0.0664 ns |   5.817 ns |  1.13 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                From_Float_Nullable_WithValue_AsObject | .NET Core 3.1 |         NA |          NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 5.0 |         NA |          NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                           From_Float_Nullable_NoValue | .NET Core 3.1 |   5.129 ns |   0.2300 ns |  0.0126 ns |   5.122 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 5.0 |   6.268 ns |  15.3602 ns |  0.8419 ns |   5.784 ns |  1.22 |    0.17 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 3.1 |  11.390 ns |   1.9046 ns |  0.1044 ns |  11.347 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 5.0 |  11.551 ns |   0.2676 ns |  0.0147 ns |  11.546 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                                           From_String | .NET Core 3.1 | 414.102 ns |  19.4019 ns |  1.0635 ns | 414.657 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 5.0 | 368.905 ns |  22.5958 ns |  1.2386 ns | 368.861 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                                  From_String_AsObject | .NET Core 3.1 | 415.500 ns | 212.4476 ns | 11.6450 ns | 410.231 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 5.0 | 380.720 ns |  34.8574 ns |  1.9106 ns | 381.106 ns |  0.92 |    0.03 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                                      From_String_Null | .NET Core 3.1 |   9.005 ns |   0.1692 ns |  0.0093 ns |   9.001 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 5.0 |   9.132 ns |   0.2051 ns |  0.0112 ns |   9.133 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                             From_String_Null_AsObject | .NET Core 3.1 |  10.410 ns |   0.5753 ns |  0.0315 ns |  10.395 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 5.0 |  11.737 ns |   2.0947 ns |  0.1148 ns |  11.727 ns |  1.13 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                                     From_String_Empty | .NET Core 3.1 |   9.258 ns |   3.3034 ns |  0.1811 ns |   9.179 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 5.0 |  10.367 ns |   2.0282 ns |  0.1112 ns |  10.331 ns |  1.12 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                            From_String_Empty_AsObject | .NET Core 3.1 |         NA |          NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 5.0 |         NA |          NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                                           From_UShort | .NET Core 3.1 |   5.694 ns |   2.4699 ns |  0.1354 ns |   5.659 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 5.0 |   5.680 ns |   6.3567 ns |  0.3484 ns |   5.485 ns |  1.00 |    0.08 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                                  From_UShort_AsObject | .NET Core 3.1 |         NA |          NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 5.0 |         NA |          NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                        From_UShort_Nullable_WithValue | .NET Core 3.1 |   5.936 ns |   1.3361 ns |  0.0732 ns |   5.922 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 5.0 |   5.855 ns |   2.5849 ns |  0.1417 ns |   5.874 ns |  0.99 |    0.03 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 3.1 |         NA |          NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 5.0 |         NA |          NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                          From_UShort_Nullable_NoValue | .NET Core 3.1 |   5.874 ns |   0.6007 ns |  0.0329 ns |   5.882 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 5.0 |   5.779 ns |   0.1464 ns |  0.0080 ns |   5.780 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 3.1 |  12.184 ns |   0.0583 ns |  0.0032 ns |  12.186 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 5.0 |  11.618 ns |   1.0268 ns |  0.0563 ns |  11.586 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                                             From_UInt | .NET Core 3.1 |   5.111 ns |   2.1942 ns |  0.1203 ns |   5.100 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 5.0 |   5.541 ns |   1.0606 ns |  0.0581 ns |   5.523 ns |  1.08 |    0.02 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                                    From_UInt_AsObject | .NET Core 3.1 |         NA |          NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 5.0 |         NA |          NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                          From_UInt_Nullable_WithValue | .NET Core 3.1 |   5.893 ns |   1.1382 ns |  0.0624 ns |   5.876 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 5.0 |   5.785 ns |   0.3040 ns |  0.0167 ns |   5.795 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 3.1 |         NA |          NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 5.0 |         NA |          NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                            From_UInt_Nullable_NoValue | .NET Core 3.1 |   5.914 ns |   0.4070 ns |  0.0223 ns |   5.903 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 5.0 |   5.868 ns |   1.4436 ns |  0.0791 ns |   5.913 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 3.1 |  11.258 ns |   0.3379 ns |  0.0185 ns |  11.268 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 5.0 |  11.585 ns |   1.3501 ns |  0.0740 ns |  11.563 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                                            From_ULong | .NET Core 3.1 |   4.928 ns |   0.1401 ns |  0.0077 ns |   4.927 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 5.0 |   5.487 ns |   1.2602 ns |  0.0691 ns |   5.454 ns |  1.11 |    0.02 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                                   From_ULong_AsObject | .NET Core 3.1 |         NA |          NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 5.0 |         NA |          NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                         From_ULong_Nullable_WithValue | .NET Core 3.1 |   6.684 ns |   3.1538 ns |  0.1729 ns |   6.772 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 5.0 |   5.797 ns |   0.2775 ns |  0.0152 ns |   5.789 ns |  0.87 |    0.02 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 3.1 |         NA |          NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 5.0 |         NA |          NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                           From_ULong_Nullable_NoValue | .NET Core 3.1 |   6.438 ns |   1.5389 ns |  0.0844 ns |   6.469 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 5.0 |   5.772 ns |   0.9846 ns |  0.0540 ns |   5.783 ns |  0.90 |    0.02 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 3.1 |  11.359 ns |   2.0599 ns |  0.1129 ns |  11.314 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 5.0 |  11.533 ns |   0.7622 ns |  0.0418 ns |  11.524 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                                       From_NullObject | .NET Core 3.1 |  11.579 ns |   0.4663 ns |  0.0256 ns |  11.568 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 5.0 |  11.543 ns |   0.3139 ns |  0.0172 ns |  11.548 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                                           From_DBNull | .NET Core 3.1 |   9.528 ns |   0.2052 ns |  0.0112 ns |   9.522 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 5.0 |   8.790 ns |   1.9819 ns |  0.1086 ns |   8.808 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                                  From_DBNull_AsObject | .NET Core 3.1 |  10.452 ns |   1.4147 ns |  0.0775 ns |  10.433 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 5.0 |  11.531 ns |   1.2036 ns |  0.0660 ns |  11.542 ns |  1.10 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                                 From_ConvertibleClass | .NET Core 3.1 |  12.087 ns |   1.5054 ns |  0.0825 ns |  12.114 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 5.0 |  12.364 ns |   2.5134 ns |  0.1378 ns |  12.335 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                        From_ConvertibleClass_AsObject | .NET Core 3.1 |  12.698 ns |   1.0815 ns |  0.0593 ns |  12.677 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 5.0 |  13.864 ns |   0.2785 ns |  0.0153 ns |  13.865 ns |  1.09 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                         From_ConvertibleClass_NoValue | .NET Core 3.1 |  12.535 ns |   1.1018 ns |  0.0604 ns |  12.501 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 5.0 |  11.415 ns |   2.4736 ns |  0.1356 ns |  11.385 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 3.1 |  11.597 ns |   0.4110 ns |  0.0225 ns |  11.595 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 5.0 |  11.498 ns |   0.1701 ns |  0.0093 ns |  11.499 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                              From_NonConvertibleClass | .NET Core 3.1 |   9.607 ns |   1.5684 ns |  0.0860 ns |   9.635 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 5.0 |   8.947 ns |   2.0089 ns |  0.1101 ns |   8.887 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                     From_NonConvertibleClass_AsObject | .NET Core 3.1 |  12.574 ns |   0.4690 ns |  0.0257 ns |  12.563 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 5.0 |  13.289 ns |   2.8569 ns |  0.1566 ns |  13.304 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                      From_NonConvertibleClass_NoValue | .NET Core 3.1 |   9.533 ns |   1.2262 ns |  0.0672 ns |   9.506 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 5.0 |   8.766 ns |   1.6684 ns |  0.0914 ns |   8.749 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 3.1 |  10.473 ns |   1.3654 ns |  0.0748 ns |  10.508 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 5.0 |  11.559 ns |   2.6974 ns |  0.1479 ns |  11.506 ns |  1.10 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                                From_ConvertibleStruct | .NET Core 3.1 |  12.395 ns |   1.1498 ns |  0.0630 ns |  12.392 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 5.0 |  10.384 ns |   4.5891 ns |  0.2515 ns |  10.482 ns |  0.84 |    0.02 | 0.0038 |     - |     - |      24 B |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                       From_ConvertibleStruct_AsObject | .NET Core 3.1 |  14.627 ns |   2.2721 ns |  0.1245 ns |  14.587 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 5.0 |  15.205 ns |   5.9075 ns |  0.3238 ns |  15.301 ns |  1.04 |    0.02 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 3.1 |  12.866 ns |   3.4463 ns |  0.1889 ns |  12.902 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 5.0 |  11.765 ns |   1.7234 ns |  0.0945 ns |  11.769 ns |  0.91 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.1 |  13.640 ns |   4.0791 ns |  0.2236 ns |  13.548 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 5.0 |  15.225 ns |   0.3409 ns |  0.0187 ns |  15.222 ns |  1.12 |    0.02 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 3.1 |   7.887 ns |   0.2346 ns |  0.0129 ns |   7.891 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 5.0 |   7.206 ns |   0.3739 ns |  0.0205 ns |   7.203 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.1 |  11.337 ns |   2.2865 ns |  0.1253 ns |  11.301 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 5.0 |  11.518 ns |   1.1097 ns |  0.0608 ns |  11.543 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                             From_NonConvertibleStruct | .NET Core 3.1 |   5.606 ns |   1.7427 ns |  0.0955 ns |   5.588 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 5.0 |   5.856 ns |   2.1019 ns |  0.1152 ns |   5.808 ns |  1.04 |    0.03 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                    From_NonConvertibleStruct_AsObject | .NET Core 3.1 |  12.729 ns |   4.7572 ns |  0.2608 ns |  12.589 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 5.0 |  13.245 ns |   2.2423 ns |  0.1229 ns |  13.303 ns |  1.04 |    0.02 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 3.1 |   5.158 ns |   1.4147 ns |  0.0775 ns |   5.116 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 5.0 |   6.921 ns |   1.0668 ns |  0.0585 ns |   6.904 ns |  1.34 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.1 |  13.120 ns |   2.6000 ns |  0.1425 ns |  13.061 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 5.0 |  13.165 ns |   0.3700 ns |  0.0203 ns |  13.158 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 3.1 |   5.098 ns |   0.0433 ns |  0.0024 ns |   5.099 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 5.0 |   5.833 ns |   1.0305 ns |  0.0565 ns |   5.802 ns |  1.14 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.1 |  11.350 ns |   1.7447 ns |  0.0956 ns |  11.299 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 5.0 |  11.838 ns |   1.4058 ns |  0.0771 ns |  11.804 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                                             From_Enum | .NET Core 3.1 |   5.094 ns |   0.5444 ns |  0.0298 ns |   5.099 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 5.0 |   5.507 ns |   1.2726 ns |  0.0698 ns |   5.472 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                                    From_Enum_AsObject | .NET Core 3.1 |         NA |          NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Enum_AsObject | .NET Core 5.0 |         NA |          NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                          From_Enum_Nullable_WithValue | .NET Core 3.1 |   5.869 ns |   1.1636 ns |  0.0638 ns |   5.841 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 5.0 |   5.757 ns |   0.3602 ns |  0.0197 ns |   5.764 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 3.1 |         NA |          NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 5.0 |         NA |          NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                            From_Enum_Nullable_NoValue | .NET Core 3.1 |   5.138 ns |   0.1130 ns |  0.0062 ns |   5.139 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 5.0 |   5.897 ns |   1.6096 ns |  0.0882 ns |   5.918 ns |  1.15 |    0.02 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 3.1 |  10.376 ns |   0.6121 ns |  0.0336 ns |  10.370 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 5.0 |  11.547 ns |   0.3160 ns |  0.0173 ns |  11.539 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                                      From_ParentClass | .NET Core 3.1 |   8.813 ns |   1.2153 ns |  0.0666 ns |   8.810 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 5.0 |   8.745 ns |   1.3469 ns |  0.0738 ns |   8.722 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                             From_ParentClass_AsObject | .NET Core 3.1 |  12.935 ns |   2.0459 ns |  0.1121 ns |  12.934 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 5.0 |  13.310 ns |   0.4519 ns |  0.0248 ns |  13.299 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |             |            |            |       |         |        |       |       |           |
                              From_ParentClass_NoValue | .NET Core 3.1 |   9.548 ns |   2.4422 ns |  0.1339 ns |   9.504 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 5.0 |   8.758 ns |   1.1254 ns |  0.0617 ns |   8.762 ns |  0.92 |    0.02 |      - |     - |     - |         - |

Benchmarks with issues:
  ConvertTo_DateTime.From_Bool_AsObject: ShortRun(Toolchain=.NET Core 3.1, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DateTime.From_Bool_AsObject: ShortRun(Toolchain=.NET Core 5.0, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DateTime.From_Bool_Nullable_WithValue_AsObject: ShortRun(Toolchain=.NET Core 3.1, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DateTime.From_Bool_Nullable_WithValue_AsObject: ShortRun(Toolchain=.NET Core 5.0, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DateTime.From_Byte_AsObject: ShortRun(Toolchain=.NET Core 3.1, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DateTime.From_Byte_AsObject: ShortRun(Toolchain=.NET Core 5.0, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DateTime.From_Byte_Nullable_WithValue_AsObject: ShortRun(Toolchain=.NET Core 3.1, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DateTime.From_Byte_Nullable_WithValue_AsObject: ShortRun(Toolchain=.NET Core 5.0, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DateTime.From_Char_AsObject: ShortRun(Toolchain=.NET Core 3.1, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DateTime.From_Char_AsObject: ShortRun(Toolchain=.NET Core 5.0, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DateTime.From_Char_Nullable_WithValue_AsObject: ShortRun(Toolchain=.NET Core 3.1, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DateTime.From_Char_Nullable_WithValue_AsObject: ShortRun(Toolchain=.NET Core 5.0, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DateTime.From_Decimal_AsObject: ShortRun(Toolchain=.NET Core 3.1, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DateTime.From_Decimal_AsObject: ShortRun(Toolchain=.NET Core 5.0, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DateTime.From_Decimal_Nullable_WithValue_AsObject: ShortRun(Toolchain=.NET Core 3.1, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DateTime.From_Decimal_Nullable_WithValue_AsObject: ShortRun(Toolchain=.NET Core 5.0, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DateTime.From_Double_AsObject: ShortRun(Toolchain=.NET Core 3.1, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DateTime.From_Double_AsObject: ShortRun(Toolchain=.NET Core 5.0, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DateTime.From_Double_Nullable_WithValue_AsObject: ShortRun(Toolchain=.NET Core 3.1, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DateTime.From_Double_Nullable_WithValue_AsObject: ShortRun(Toolchain=.NET Core 5.0, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DateTime.From_Short_AsObject: ShortRun(Toolchain=.NET Core 3.1, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DateTime.From_Short_AsObject: ShortRun(Toolchain=.NET Core 5.0, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DateTime.From_Short_Nullable_WithValue_AsObject: ShortRun(Toolchain=.NET Core 3.1, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DateTime.From_Short_Nullable_WithValue_AsObject: ShortRun(Toolchain=.NET Core 5.0, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DateTime.From_Int_AsObject: ShortRun(Toolchain=.NET Core 3.1, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DateTime.From_Int_AsObject: ShortRun(Toolchain=.NET Core 5.0, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DateTime.From_Int_Nullable_WithValue_AsObject: ShortRun(Toolchain=.NET Core 3.1, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DateTime.From_Int_Nullable_WithValue_AsObject: ShortRun(Toolchain=.NET Core 5.0, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DateTime.From_Long_AsObject: ShortRun(Toolchain=.NET Core 3.1, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DateTime.From_Long_AsObject: ShortRun(Toolchain=.NET Core 5.0, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DateTime.From_Long_Nullable_WithValue_AsObject: ShortRun(Toolchain=.NET Core 3.1, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DateTime.From_Long_Nullable_WithValue_AsObject: ShortRun(Toolchain=.NET Core 5.0, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DateTime.From_SByte_AsObject: ShortRun(Toolchain=.NET Core 3.1, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DateTime.From_SByte_AsObject: ShortRun(Toolchain=.NET Core 5.0, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DateTime.From_SByte_Nullable_WithValue_AsObject: ShortRun(Toolchain=.NET Core 3.1, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DateTime.From_SByte_Nullable_WithValue_AsObject: ShortRun(Toolchain=.NET Core 5.0, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DateTime.From_Float_AsObject: ShortRun(Toolchain=.NET Core 3.1, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DateTime.From_Float_AsObject: ShortRun(Toolchain=.NET Core 5.0, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DateTime.From_Float_Nullable_WithValue_AsObject: ShortRun(Toolchain=.NET Core 3.1, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DateTime.From_Float_Nullable_WithValue_AsObject: ShortRun(Toolchain=.NET Core 5.0, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DateTime.From_String_Empty_AsObject: ShortRun(Toolchain=.NET Core 3.1, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DateTime.From_String_Empty_AsObject: ShortRun(Toolchain=.NET Core 5.0, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DateTime.From_UShort_AsObject: ShortRun(Toolchain=.NET Core 3.1, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DateTime.From_UShort_AsObject: ShortRun(Toolchain=.NET Core 5.0, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DateTime.From_UShort_Nullable_WithValue_AsObject: ShortRun(Toolchain=.NET Core 3.1, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DateTime.From_UShort_Nullable_WithValue_AsObject: ShortRun(Toolchain=.NET Core 5.0, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DateTime.From_UInt_AsObject: ShortRun(Toolchain=.NET Core 3.1, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DateTime.From_UInt_AsObject: ShortRun(Toolchain=.NET Core 5.0, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DateTime.From_UInt_Nullable_WithValue_AsObject: ShortRun(Toolchain=.NET Core 3.1, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DateTime.From_UInt_Nullable_WithValue_AsObject: ShortRun(Toolchain=.NET Core 5.0, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DateTime.From_ULong_AsObject: ShortRun(Toolchain=.NET Core 3.1, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DateTime.From_ULong_AsObject: ShortRun(Toolchain=.NET Core 5.0, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DateTime.From_ULong_Nullable_WithValue_AsObject: ShortRun(Toolchain=.NET Core 3.1, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DateTime.From_ULong_Nullable_WithValue_AsObject: ShortRun(Toolchain=.NET Core 5.0, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DateTime.From_Enum_AsObject: ShortRun(Toolchain=.NET Core 3.1, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DateTime.From_Enum_AsObject: ShortRun(Toolchain=.NET Core 5.0, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DateTime.From_Enum_Nullable_WithValue_AsObject: ShortRun(Toolchain=.NET Core 3.1, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DateTime.From_Enum_Nullable_WithValue_AsObject: ShortRun(Toolchain=.NET Core 5.0, IterationCount=3, LaunchCount=1, WarmupCount=3)
