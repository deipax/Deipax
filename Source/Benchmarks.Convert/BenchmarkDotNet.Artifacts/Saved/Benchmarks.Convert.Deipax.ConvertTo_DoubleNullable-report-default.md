
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

                                                Method |     Toolchain |      Mean |      Error |    StdDev |    Median | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------------------------------------------ |-------------- |----------:|-----------:|----------:|----------:|------:|--------:|-------:|------:|------:|----------:|
                     From_ParentClass_NoValue_AsObject | .NET Core 3.1 | 13.285 ns |  2.7055 ns | 0.1483 ns | 13.259 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 5.0 | 12.549 ns |  1.5159 ns | 0.0831 ns | 12.509 ns |  0.94 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                     From_ParentStruct | .NET Core 3.1 | 35.493 ns |  9.4982 ns | 0.5206 ns | 35.259 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 5.0 | 29.579 ns |  8.2105 ns | 0.4500 ns | 29.354 ns |  0.83 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                            From_ParentStruct_AsObject | .NET Core 3.1 | 15.912 ns |  2.2587 ns | 0.1238 ns | 15.855 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 5.0 | 14.504 ns |  0.7903 ns | 0.0433 ns | 14.521 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                  From_ParentStruct_Nullable_WithValue | .NET Core 3.1 | 36.855 ns |  4.1357 ns | 0.2267 ns | 36.773 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 5.0 | 33.468 ns |  1.6113 ns | 0.0883 ns | 33.487 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 3.1 | 16.197 ns |  8.9200 ns | 0.4889 ns | 16.024 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 5.0 | 14.827 ns |  5.0687 ns | 0.2778 ns | 14.736 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                    From_ParentStruct_Nullable_NoValue | .NET Core 3.1 | 35.009 ns |  1.0175 ns | 0.0558 ns | 34.992 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 5.0 | 30.567 ns |  4.2907 ns | 0.2352 ns | 30.595 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 3.1 | 12.491 ns |  2.1113 ns | 0.1157 ns | 12.441 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 5.0 | 12.465 ns |  1.2886 ns | 0.0706 ns | 12.486 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                             From_Bool | .NET Core 3.1 |  6.179 ns |  0.2286 ns | 0.0125 ns |  6.173 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 5.0 |  6.087 ns |  0.4003 ns | 0.0219 ns |  6.096 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                    From_Bool_AsObject | .NET Core 3.1 | 15.860 ns |  0.6229 ns | 0.0341 ns | 15.854 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 5.0 | 17.576 ns |  3.3430 ns | 0.1832 ns | 17.490 ns |  1.11 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                          From_Bool_Nullable_WithValue | .NET Core 3.1 |  7.078 ns |  0.6439 ns | 0.0353 ns |  7.061 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 5.0 |  7.348 ns |  1.7169 ns | 0.0941 ns |  7.349 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 3.1 | 18.367 ns |  3.6105 ns | 0.1979 ns | 18.299 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 5.0 | 17.919 ns |  0.8954 ns | 0.0491 ns | 17.912 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                            From_Bool_Nullable_NoValue | .NET Core 3.1 |  6.131 ns |  0.1370 ns | 0.0075 ns |  6.130 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 5.0 |  7.574 ns |  9.9878 ns | 0.5475 ns |  7.378 ns |  1.24 |    0.09 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 3.1 | 13.908 ns |  2.5383 ns | 0.1391 ns | 13.853 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 5.0 | 13.200 ns |  4.5728 ns | 0.2506 ns | 13.107 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                             From_Byte | .NET Core 3.1 |  6.124 ns |  1.8620 ns | 0.1021 ns |  6.067 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 5.0 |  6.173 ns |  0.6023 ns | 0.0330 ns |  6.158 ns |  1.01 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                    From_Byte_AsObject | .NET Core 3.1 | 17.721 ns |  3.8687 ns | 0.2121 ns | 17.619 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 5.0 | 17.217 ns |  0.8469 ns | 0.0464 ns | 17.191 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                          From_Byte_Nullable_WithValue | .NET Core 3.1 |  7.262 ns |  2.0484 ns | 0.1123 ns |  7.214 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 5.0 |  6.727 ns |  1.7915 ns | 0.0982 ns |  6.737 ns |  0.93 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 3.1 | 16.695 ns |  8.4057 ns | 0.4607 ns | 16.953 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 5.0 | 17.127 ns |  1.1880 ns | 0.0651 ns | 17.107 ns |  1.03 |    0.03 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                            From_Byte_Nullable_NoValue | .NET Core 3.1 |  6.036 ns |  1.6380 ns | 0.0898 ns |  5.994 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 5.0 |  7.177 ns | 13.4948 ns | 0.7397 ns |  7.491 ns |  1.19 |    0.14 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 3.1 | 13.252 ns |  2.7540 ns | 0.1510 ns | 13.202 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 5.0 | 12.801 ns |  9.0461 ns | 0.4958 ns | 12.574 ns |  0.97 |    0.03 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                             From_Char | .NET Core 3.1 |  5.965 ns |  3.4611 ns | 0.1897 ns |  5.858 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Char | .NET Core 5.0 |  5.895 ns |  0.8852 ns | 0.0485 ns |  5.878 ns |  0.99 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                    From_Char_AsObject | .NET Core 3.1 |        NA |         NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 5.0 |        NA |         NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                          From_Char_Nullable_WithValue | .NET Core 3.1 |  5.757 ns |  2.9627 ns | 0.1624 ns |  5.847 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 5.0 |  6.070 ns |  0.9180 ns | 0.0503 ns |  6.063 ns |  1.06 |    0.04 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 3.1 |        NA |         NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 5.0 |        NA |         NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                            From_Char_Nullable_NoValue | .NET Core 3.1 |  5.607 ns |  0.7332 ns | 0.0402 ns |  5.611 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 5.0 |  6.015 ns |  0.6679 ns | 0.0366 ns |  5.998 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 3.1 | 13.975 ns |  4.1749 ns | 0.2288 ns | 13.887 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 5.0 | 12.403 ns |  1.7263 ns | 0.0946 ns | 12.362 ns |  0.89 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                         From_DateTime | .NET Core 3.1 |  7.262 ns |  2.3930 ns | 0.1312 ns |  7.320 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 5.0 |  7.124 ns |  1.4867 ns | 0.0815 ns |  7.114 ns |  0.98 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                From_DateTime_AsObject | .NET Core 3.1 |        NA |         NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 5.0 |        NA |         NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                      From_DateTime_Nullable_WithValue | .NET Core 3.1 |  6.932 ns |  0.6999 ns | 0.0384 ns |  6.911 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 5.0 |  6.223 ns |  1.2911 ns | 0.0708 ns |  6.252 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 3.1 |        NA |         NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 5.0 |        NA |         NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                        From_DateTime_Nullable_NoValue | .NET Core 3.1 |  6.798 ns |  0.2931 ns | 0.0161 ns |  6.793 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 5.0 |  6.094 ns |  1.4469 ns | 0.0793 ns |  6.109 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 3.1 | 13.184 ns |  1.9104 ns | 0.1047 ns | 13.220 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 5.0 | 12.521 ns |  2.8736 ns | 0.1575 ns | 12.608 ns |  0.95 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                          From_Decimal | .NET Core 3.1 | 11.148 ns |  0.3129 ns | 0.0172 ns | 11.147 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 5.0 | 10.096 ns |  4.8245 ns | 0.2644 ns |  9.973 ns |  0.91 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                 From_Decimal_AsObject | .NET Core 3.1 | 20.308 ns |  0.4179 ns | 0.0229 ns | 20.296 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 5.0 | 18.365 ns |  1.7194 ns | 0.0942 ns | 18.333 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                       From_Decimal_Nullable_WithValue | .NET Core 3.1 | 18.602 ns |  1.4204 ns | 0.0779 ns | 18.561 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 5.0 | 10.091 ns |  1.0113 ns | 0.0554 ns | 10.074 ns |  0.54 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 3.1 | 21.067 ns |  2.5907 ns | 0.1420 ns | 21.117 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 5.0 | 20.195 ns |  0.5357 ns | 0.0294 ns | 20.188 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                         From_Decimal_Nullable_NoValue | .NET Core 3.1 |  7.715 ns |  0.7988 ns | 0.0438 ns |  7.730 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 5.0 |  6.683 ns |  0.2042 ns | 0.0112 ns |  6.678 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 3.1 | 13.908 ns |  1.4291 ns | 0.0783 ns | 13.907 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 5.0 | 12.521 ns |  5.2686 ns | 0.2888 ns | 12.454 ns |  0.90 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                           From_Double | .NET Core 3.1 |  5.690 ns |  0.3714 ns | 0.0204 ns |  5.697 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 5.0 |  6.130 ns |  0.6514 ns | 0.0357 ns |  6.132 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                  From_Double_AsObject | .NET Core 3.1 | 23.882 ns |  0.3426 ns | 0.0188 ns | 23.888 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 5.0 | 22.288 ns |  2.3732 ns | 0.1301 ns | 22.320 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                        From_Double_Nullable_WithValue | .NET Core 3.1 |  7.485 ns |  1.6505 ns | 0.0905 ns |  7.444 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 5.0 |  5.962 ns |  3.4756 ns | 0.1905 ns |  5.988 ns |  0.80 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
               From_Double_Nullable_WithValue_AsObject | .NET Core 3.1 | 25.908 ns |  3.8180 ns | 0.2093 ns | 25.972 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 5.0 | 22.969 ns | 15.2763 ns | 0.8373 ns | 22.650 ns |  0.89 |    0.04 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                          From_Double_Nullable_NoValue | .NET Core 3.1 |  6.804 ns |  2.9095 ns | 0.1595 ns |  6.761 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 5.0 |  5.757 ns |  3.2582 ns | 0.1786 ns |  5.717 ns |  0.85 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 3.1 | 14.182 ns |  0.9576 ns | 0.0525 ns | 14.189 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 5.0 | 12.313 ns |  0.0268 ns | 0.0015 ns | 12.314 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                            From_Short | .NET Core 3.1 |  6.067 ns |  0.1261 ns | 0.0069 ns |  6.065 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 5.0 |  5.929 ns |  0.3333 ns | 0.0183 ns |  5.937 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                   From_Short_AsObject | .NET Core 3.1 | 17.155 ns |  2.0774 ns | 0.1139 ns | 17.199 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 5.0 | 16.780 ns |  0.5213 ns | 0.0286 ns | 16.771 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                         From_Short_Nullable_WithValue | .NET Core 3.1 |  7.467 ns |  4.7549 ns | 0.2606 ns |  7.374 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 5.0 |  6.559 ns |  0.4566 ns | 0.0250 ns |  6.566 ns |  0.88 |    0.03 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                From_Short_Nullable_WithValue_AsObject | .NET Core 3.1 | 16.891 ns |  1.6932 ns | 0.0928 ns | 16.925 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 5.0 | 17.070 ns |  2.4820 ns | 0.1360 ns | 17.123 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                           From_Short_Nullable_NoValue | .NET Core 3.1 |  8.218 ns |  2.7889 ns | 0.1529 ns |  8.130 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 5.0 |  6.277 ns |  0.8923 ns | 0.0489 ns |  6.254 ns |  0.76 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 3.1 | 12.515 ns |  1.9447 ns | 0.1066 ns | 12.464 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 5.0 | 12.339 ns |  0.4960 ns | 0.0272 ns | 12.339 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                              From_Int | .NET Core 3.1 |  6.177 ns |  9.8220 ns | 0.5384 ns |  6.469 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 5.0 |  6.269 ns |  1.2416 ns | 0.0681 ns |  6.259 ns |  1.02 |    0.09 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                     From_Int_AsObject | .NET Core 3.1 | 16.263 ns |  0.5932 ns | 0.0325 ns | 16.273 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 5.0 | 17.043 ns |  0.6021 ns | 0.0330 ns | 17.054 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                           From_Int_Nullable_WithValue | .NET Core 3.1 |  7.051 ns |  4.6160 ns | 0.2530 ns |  6.913 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 5.0 |  6.656 ns |  0.5998 ns | 0.0329 ns |  6.648 ns |  0.94 |    0.03 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 3.1 | 16.275 ns |  1.0995 ns | 0.0603 ns | 16.303 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 5.0 | 17.299 ns |  4.4312 ns | 0.2429 ns | 17.291 ns |  1.06 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                             From_Int_Nullable_NoValue | .NET Core 3.1 |  6.613 ns |  1.4184 ns | 0.0777 ns |  6.642 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 5.0 |  6.429 ns |  1.3114 ns | 0.0719 ns |  6.392 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 3.1 | 13.662 ns |  0.1753 ns | 0.0096 ns | 13.664 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 5.0 | 15.042 ns |  2.0558 ns | 0.1127 ns | 14.981 ns |  1.10 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                             From_Long | .NET Core 3.1 |  6.231 ns |  1.2727 ns | 0.0698 ns |  6.225 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Long | .NET Core 5.0 |  6.040 ns |  0.9588 ns | 0.0526 ns |  6.050 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                    From_Long_AsObject | .NET Core 3.1 | 17.909 ns |  3.0616 ns | 0.1678 ns | 17.920 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 5.0 | 16.771 ns |  0.8720 ns | 0.0478 ns | 16.784 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                          From_Long_Nullable_WithValue | .NET Core 3.1 |  8.451 ns |  2.8898 ns | 0.1584 ns |  8.403 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 5.0 |  8.097 ns |  7.1267 ns | 0.3906 ns |  7.899 ns |  0.96 |    0.05 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 3.1 | 19.255 ns |  4.9500 ns | 0.2713 ns | 19.316 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 5.0 | 16.731 ns |  0.7823 ns | 0.0429 ns | 16.732 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                            From_Long_Nullable_NoValue | .NET Core 3.1 |  7.526 ns |  0.1708 ns | 0.0094 ns |  7.522 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 5.0 |  6.453 ns |  0.6636 ns | 0.0364 ns |  6.435 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 3.1 | 13.941 ns |  0.3352 ns | 0.0184 ns | 13.950 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 5.0 | 12.287 ns |  0.2308 ns | 0.0127 ns | 12.293 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                            From_SByte | .NET Core 3.1 |  5.669 ns |  1.2224 ns | 0.0670 ns |  5.651 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 5.0 |  6.058 ns |  3.4438 ns | 0.1888 ns |  5.951 ns |  1.07 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                   From_SByte_AsObject | .NET Core 3.1 | 17.175 ns |  0.8239 ns | 0.0452 ns | 17.173 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 5.0 | 18.351 ns | 29.3232 ns | 1.6073 ns | 17.730 ns |  1.07 |    0.09 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                         From_SByte_Nullable_WithValue | .NET Core 3.1 |  6.467 ns |  0.9599 ns | 0.0526 ns |  6.488 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 5.0 |  6.624 ns |  0.4909 ns | 0.0269 ns |  6.609 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 3.1 | 16.433 ns |  0.3192 ns | 0.0175 ns | 16.426 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 5.0 | 17.155 ns |  0.4024 ns | 0.0221 ns | 17.149 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                           From_SByte_Nullable_NoValue | .NET Core 3.1 |  6.524 ns |  2.3137 ns | 0.1268 ns |  6.558 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 5.0 |  6.695 ns |  5.6949 ns | 0.3122 ns |  6.751 ns |  1.03 |    0.06 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 3.1 | 13.106 ns |  3.5242 ns | 0.1932 ns | 13.006 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 5.0 | 12.353 ns |  0.4652 ns | 0.0255 ns | 12.350 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                            From_Float | .NET Core 3.1 |  6.337 ns |  0.1995 ns | 0.0109 ns |  6.340 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 5.0 |  6.253 ns |  0.7321 ns | 0.0401 ns |  6.233 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                   From_Float_AsObject | .NET Core 3.1 | 17.608 ns |  2.1905 ns | 0.1201 ns | 17.650 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 5.0 | 17.086 ns |  1.7358 ns | 0.0951 ns | 17.055 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                         From_Float_Nullable_WithValue | .NET Core 3.1 |  6.773 ns |  2.1539 ns | 0.1181 ns |  6.761 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 5.0 |  6.513 ns |  0.6534 ns | 0.0358 ns |  6.508 ns |  0.96 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                From_Float_Nullable_WithValue_AsObject | .NET Core 3.1 | 17.954 ns |  0.9182 ns | 0.0503 ns | 17.960 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 5.0 | 17.055 ns |  1.0260 ns | 0.0562 ns | 17.031 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                           From_Float_Nullable_NoValue | .NET Core 3.1 |  6.482 ns |  0.4901 ns | 0.0269 ns |  6.491 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 5.0 |  6.950 ns | 13.6396 ns | 0.7476 ns |  6.661 ns |  1.07 |    0.11 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 3.1 | 14.953 ns |  2.4606 ns | 0.1349 ns | 14.881 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 5.0 | 13.009 ns |  1.7969 ns | 0.0985 ns | 13.058 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                           From_String | .NET Core 3.1 | 59.044 ns | 25.8566 ns | 1.4173 ns | 59.517 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 5.0 | 53.712 ns | 13.1257 ns | 0.7195 ns | 53.471 ns |  0.91 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                  From_String_AsObject | .NET Core 3.1 | 69.577 ns | 28.2185 ns | 1.5467 ns | 68.723 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 5.0 | 61.871 ns | 18.9225 ns | 1.0372 ns | 62.384 ns |  0.89 |    0.03 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                      From_String_Null | .NET Core 3.1 | 12.309 ns |  2.6742 ns | 0.1466 ns | 12.224 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 5.0 | 11.149 ns |  3.1838 ns | 0.1745 ns | 11.051 ns |  0.91 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                             From_String_Null_AsObject | .NET Core 3.1 | 12.387 ns |  4.3906 ns | 0.2407 ns | 12.315 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 5.0 | 12.367 ns |  1.5466 ns | 0.0848 ns | 12.322 ns |  1.00 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                     From_String_Empty | .NET Core 3.1 | 12.450 ns |  1.8989 ns | 0.1041 ns | 12.396 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 5.0 | 11.617 ns |  2.9433 ns | 0.1613 ns | 11.558 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                            From_String_Empty_AsObject | .NET Core 3.1 |        NA |         NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 5.0 |        NA |         NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                           From_UShort | .NET Core 3.1 |  6.149 ns |  2.0912 ns | 0.1146 ns |  6.098 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 5.0 |  6.939 ns | 15.8141 ns | 0.8668 ns |  7.389 ns |  1.13 |    0.16 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                  From_UShort_AsObject | .NET Core 3.1 | 17.695 ns |  1.1981 ns | 0.0657 ns | 17.668 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 5.0 | 16.905 ns |  3.8565 ns | 0.2114 ns | 16.786 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                        From_UShort_Nullable_WithValue | .NET Core 3.1 |  8.352 ns |  2.1532 ns | 0.1180 ns |  8.412 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 5.0 |  6.581 ns |  0.5314 ns | 0.0291 ns |  6.588 ns |  0.79 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 3.1 | 18.391 ns |  2.5255 ns | 0.1384 ns | 18.344 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 5.0 | 18.663 ns | 15.2108 ns | 0.8338 ns | 18.934 ns |  1.02 |    0.05 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                          From_UShort_Nullable_NoValue | .NET Core 3.1 |  6.375 ns |  2.6146 ns | 0.1433 ns |  6.421 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 5.0 |  6.344 ns |  0.3027 ns | 0.0166 ns |  6.336 ns |  1.00 |    0.03 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 3.1 | 12.488 ns |  2.5509 ns | 0.1398 ns | 12.471 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 5.0 | 12.383 ns |  1.6578 ns | 0.0909 ns | 12.376 ns |  0.99 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                             From_UInt | .NET Core 3.1 |  6.033 ns |  0.3012 ns | 0.0165 ns |  6.024 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 5.0 |  6.050 ns |  1.2860 ns | 0.0705 ns |  6.041 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                    From_UInt_AsObject | .NET Core 3.1 | 16.733 ns |  2.4242 ns | 0.1329 ns | 16.702 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 5.0 | 17.218 ns |  3.6995 ns | 0.2028 ns | 17.141 ns |  1.03 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                          From_UInt_Nullable_WithValue | .NET Core 3.1 |  7.035 ns |  2.2736 ns | 0.1246 ns |  7.016 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 5.0 |  6.584 ns |  0.4067 ns | 0.0223 ns |  6.597 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 3.1 | 17.422 ns |  4.0754 ns | 0.2234 ns | 17.294 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 5.0 | 17.535 ns |  8.8914 ns | 0.4874 ns | 17.719 ns |  1.01 |    0.03 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                            From_UInt_Nullable_NoValue | .NET Core 3.1 |  6.375 ns |  0.9836 ns | 0.0539 ns |  6.360 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 5.0 |  6.638 ns |  9.9309 ns | 0.5443 ns |  6.352 ns |  1.04 |    0.09 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 3.1 | 12.473 ns |  3.2317 ns | 0.1771 ns | 12.398 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 5.0 | 12.359 ns |  0.0675 ns | 0.0037 ns | 12.358 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                            From_ULong | .NET Core 3.1 |  5.975 ns |  1.6800 ns | 0.0921 ns |  5.941 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 5.0 |  6.112 ns |  1.4593 ns | 0.0800 ns |  6.072 ns |  1.02 |    0.03 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                   From_ULong_AsObject | .NET Core 3.1 | 18.007 ns |  0.6020 ns | 0.0330 ns | 18.008 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 5.0 | 17.907 ns |  3.1522 ns | 0.1728 ns | 17.894 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                         From_ULong_Nullable_WithValue | .NET Core 3.1 |  7.955 ns |  3.1488 ns | 0.1726 ns |  7.889 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 5.0 |  7.230 ns |  0.5162 ns | 0.0283 ns |  7.242 ns |  0.91 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 3.1 | 17.838 ns |  1.8678 ns | 0.1024 ns | 17.800 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 5.0 | 17.746 ns |  1.2017 ns | 0.0659 ns | 17.744 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                           From_ULong_Nullable_NoValue | .NET Core 3.1 |  6.926 ns |  0.3176 ns | 0.0174 ns |  6.929 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 5.0 |  6.620 ns |  1.4487 ns | 0.0794 ns |  6.618 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 3.1 | 12.410 ns |  2.7802 ns | 0.1524 ns | 12.323 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 5.0 | 12.399 ns |  0.4510 ns | 0.0247 ns | 12.408 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                       From_NullObject | .NET Core 3.1 | 13.833 ns |  0.3564 ns | 0.0195 ns | 13.829 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 5.0 | 12.485 ns |  2.2169 ns | 0.1215 ns | 12.421 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                           From_DBNull | .NET Core 3.1 | 10.102 ns |  0.7365 ns | 0.0404 ns | 10.102 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 5.0 | 10.256 ns |  4.6792 ns | 0.2565 ns | 10.371 ns |  1.02 |    0.03 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                  From_DBNull_AsObject | .NET Core 3.1 | 14.915 ns |  3.4266 ns | 0.1878 ns | 14.850 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 5.0 | 12.512 ns |  2.3855 ns | 0.1308 ns | 12.442 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                 From_ConvertibleClass | .NET Core 3.1 | 15.235 ns |  0.2524 ns | 0.0138 ns | 15.231 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 5.0 | 14.063 ns |  1.4299 ns | 0.0784 ns | 14.072 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                        From_ConvertibleClass_AsObject | .NET Core 3.1 | 17.320 ns |  2.8083 ns | 0.1539 ns | 17.287 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 5.0 | 16.132 ns |  0.9631 ns | 0.0528 ns | 16.103 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                         From_ConvertibleClass_NoValue | .NET Core 3.1 | 14.092 ns |  2.2079 ns | 0.1210 ns | 14.058 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 5.0 | 11.807 ns |  1.0005 ns | 0.0548 ns | 11.792 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 3.1 | 15.498 ns |  1.3872 ns | 0.0760 ns | 15.486 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 5.0 | 12.441 ns |  1.4936 ns | 0.0819 ns | 12.412 ns |  0.80 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                              From_NonConvertibleClass | .NET Core 3.1 |  9.241 ns |  3.2852 ns | 0.1801 ns |  9.160 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 5.0 |  9.276 ns |  1.9844 ns | 0.1088 ns |  9.223 ns |  1.00 |    0.03 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                     From_NonConvertibleClass_AsObject | .NET Core 3.1 | 15.432 ns |  0.2943 ns | 0.0161 ns | 15.430 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 5.0 | 14.587 ns |  0.5974 ns | 0.0327 ns | 14.571 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                      From_NonConvertibleClass_NoValue | .NET Core 3.1 |  9.170 ns |  0.7874 ns | 0.0432 ns |  9.153 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 5.0 |  9.346 ns |  2.7284 ns | 0.1496 ns |  9.288 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 3.1 | 13.954 ns |  2.6834 ns | 0.1471 ns | 13.895 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 5.0 | 12.586 ns |  1.6995 ns | 0.0932 ns | 12.639 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                From_ConvertibleStruct | .NET Core 3.1 | 12.169 ns | 12.0785 ns | 0.6621 ns | 11.817 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 5.0 | 12.200 ns |  0.2717 ns | 0.0149 ns | 12.197 ns |  1.00 |    0.05 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                       From_ConvertibleStruct_AsObject | .NET Core 3.1 | 16.550 ns |  3.2669 ns | 0.1791 ns | 16.579 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 5.0 | 17.135 ns |  3.0628 ns | 0.1679 ns | 17.067 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 3.1 | 13.888 ns |  7.5555 ns | 0.4141 ns | 13.921 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 5.0 | 13.223 ns |  3.3707 ns | 0.1848 ns | 13.193 ns |  0.95 |    0.02 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.1 | 17.235 ns |  1.1155 ns | 0.0611 ns | 17.243 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 5.0 | 18.406 ns |  1.9534 ns | 0.1071 ns | 18.378 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 3.1 |  6.655 ns |  1.9376 ns | 0.1062 ns |  6.601 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 5.0 |  7.266 ns |  2.5853 ns | 0.1417 ns |  7.297 ns |  1.09 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.1 | 12.393 ns |  1.9933 ns | 0.1093 ns | 12.342 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 5.0 | 12.396 ns |  0.8780 ns | 0.0481 ns | 12.379 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                             From_NonConvertibleStruct | .NET Core 3.1 |  6.336 ns |  5.9975 ns | 0.3287 ns |  6.184 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 5.0 |  6.679 ns |  1.1031 ns | 0.0605 ns |  6.653 ns |  1.06 |    0.06 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                    From_NonConvertibleStruct_AsObject | .NET Core 3.1 | 13.917 ns |  0.7132 ns | 0.0391 ns | 13.918 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 5.0 | 14.494 ns |  1.9615 ns | 0.1075 ns | 14.493 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 3.1 |  6.947 ns |  4.5632 ns | 0.2501 ns |  7.021 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 5.0 |  6.731 ns |  1.3405 ns | 0.0735 ns |  6.693 ns |  0.97 |    0.05 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.1 | 14.718 ns |  5.2153 ns | 0.2859 ns | 14.577 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 5.0 | 14.139 ns |  2.6956 ns | 0.1478 ns | 14.084 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 3.1 |  5.645 ns |  0.8406 ns | 0.0461 ns |  5.641 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 5.0 |  7.177 ns | 11.1493 ns | 0.6111 ns |  6.915 ns |  1.27 |    0.11 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.1 | 13.056 ns |  1.4255 ns | 0.0781 ns | 13.054 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 5.0 | 12.416 ns |  0.5127 ns | 0.0281 ns | 12.420 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                             From_Enum | .NET Core 3.1 |  5.542 ns |  1.5903 ns | 0.0872 ns |  5.504 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 5.0 |  6.224 ns |  3.8296 ns | 0.2099 ns |  6.297 ns |  1.12 |    0.03 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                    From_Enum_AsObject | .NET Core 3.1 | 35.428 ns |  4.8539 ns | 0.2661 ns | 35.328 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject | .NET Core 5.0 | 26.459 ns |  3.2407 ns | 0.1776 ns | 26.534 ns |  0.75 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                          From_Enum_Nullable_WithValue | .NET Core 3.1 |  6.365 ns |  1.3600 ns | 0.0745 ns |  6.396 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 5.0 |  6.704 ns |  1.8067 ns | 0.0990 ns |  6.728 ns |  1.05 |    0.03 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 3.1 | 37.743 ns | 20.9105 ns | 1.1462 ns | 38.090 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 5.0 | 27.075 ns |  3.8727 ns | 0.2123 ns | 27.142 ns |  0.72 |    0.03 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                            From_Enum_Nullable_NoValue | .NET Core 3.1 |  5.918 ns |  0.7102 ns | 0.0389 ns |  5.932 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 5.0 |  6.372 ns |  1.1049 ns | 0.0606 ns |  6.392 ns |  1.08 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 3.1 | 13.709 ns |  2.4837 ns | 0.1361 ns | 13.638 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 5.0 | 12.568 ns |  1.9734 ns | 0.1082 ns | 12.568 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                                      From_ParentClass | .NET Core 3.1 |  9.314 ns |  3.5028 ns | 0.1920 ns |  9.228 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 5.0 |  9.453 ns |  3.2037 ns | 0.1756 ns |  9.434 ns |  1.02 |    0.04 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                             From_ParentClass_AsObject | .NET Core 3.1 | 14.268 ns |  2.5507 ns | 0.1398 ns | 14.242 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 5.0 | 14.532 ns |  5.9281 ns | 0.3249 ns | 14.382 ns |  1.02 |    0.03 |      - |     - |     - |         - |
                                                       |               |           |            |           |           |       |         |        |       |       |           |
                              From_ParentClass_NoValue | .NET Core 3.1 |  9.191 ns |  1.0901 ns | 0.0598 ns |  9.188 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 5.0 |  9.299 ns |  0.0658 ns | 0.0036 ns |  9.298 ns |  1.01 |    0.01 |      - |     - |     - |         - |

Benchmarks with issues:
  ConvertTo_DoubleNullable.From_Char_AsObject: ShortRun(Toolchain=.NET Core 3.1, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DoubleNullable.From_Char_AsObject: ShortRun(Toolchain=.NET Core 5.0, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DoubleNullable.From_Char_Nullable_WithValue_AsObject: ShortRun(Toolchain=.NET Core 3.1, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DoubleNullable.From_Char_Nullable_WithValue_AsObject: ShortRun(Toolchain=.NET Core 5.0, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DoubleNullable.From_DateTime_AsObject: ShortRun(Toolchain=.NET Core 3.1, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DoubleNullable.From_DateTime_AsObject: ShortRun(Toolchain=.NET Core 5.0, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DoubleNullable.From_DateTime_Nullable_WithValue_AsObject: ShortRun(Toolchain=.NET Core 3.1, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DoubleNullable.From_DateTime_Nullable_WithValue_AsObject: ShortRun(Toolchain=.NET Core 5.0, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DoubleNullable.From_String_Empty_AsObject: ShortRun(Toolchain=.NET Core 3.1, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_DoubleNullable.From_String_Empty_AsObject: ShortRun(Toolchain=.NET Core 5.0, IterationCount=3, LaunchCount=1, WarmupCount=3)
