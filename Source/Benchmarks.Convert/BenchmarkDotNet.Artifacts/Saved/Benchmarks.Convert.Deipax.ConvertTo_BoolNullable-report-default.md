
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

                                                Method |     Toolchain |      Mean |       Error |     StdDev |    Median | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------------------------------------------ |-------------- |----------:|------------:|-----------:|----------:|------:|--------:|-------:|------:|------:|----------:|
                     From_ParentClass_NoValue_AsObject | .NET Core 3.1 | 13.967 ns |   6.0670 ns |  0.3326 ns | 14.104 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 5.0 | 11.769 ns |   4.4897 ns |  0.2461 ns | 11.663 ns |  0.84 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
                                     From_ParentStruct | .NET Core 3.1 | 45.963 ns | 182.6078 ns | 10.0094 ns | 40.408 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 5.0 | 32.477 ns |   5.5560 ns |  0.3045 ns | 32.451 ns |  0.73 |    0.14 |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
                            From_ParentStruct_AsObject | .NET Core 3.1 | 15.290 ns |   0.9557 ns |  0.0524 ns | 15.313 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 5.0 | 18.392 ns |  36.6483 ns |  2.0088 ns | 17.967 ns |  1.20 |    0.13 |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
                  From_ParentStruct_Nullable_WithValue | .NET Core 3.1 | 37.222 ns |   3.2509 ns |  0.1782 ns | 37.321 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 5.0 | 28.300 ns |   6.9671 ns |  0.3819 ns | 28.515 ns |  0.76 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 3.1 | 15.877 ns |   4.0438 ns |  0.2217 ns | 15.983 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 5.0 | 13.499 ns |   1.9730 ns |  0.1081 ns | 13.440 ns |  0.85 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
                    From_ParentStruct_Nullable_NoValue | .NET Core 3.1 | 38.738 ns |   4.5043 ns |  0.2469 ns | 38.737 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 5.0 | 33.309 ns |  60.1360 ns |  3.2963 ns | 34.831 ns |  0.86 |    0.09 |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 3.1 | 13.084 ns |   1.7617 ns |  0.0966 ns | 13.056 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 5.0 | 13.073 ns |   1.0529 ns |  0.0577 ns | 13.060 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
                                             From_Bool | .NET Core 3.1 |  8.217 ns |   1.1788 ns |  0.0646 ns |  8.184 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 5.0 |  7.562 ns |   5.6479 ns |  0.3096 ns |  7.574 ns |  0.92 |    0.04 |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
                                    From_Bool_AsObject | .NET Core 3.1 | 23.517 ns |   2.5554 ns |  0.1401 ns | 23.487 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 5.0 | 21.951 ns |   0.9673 ns |  0.0530 ns | 21.978 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
                          From_Bool_Nullable_WithValue | .NET Core 3.1 |  5.420 ns |   3.4818 ns |  0.1909 ns |  5.415 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 5.0 |  5.491 ns |   3.6263 ns |  0.1988 ns |  5.411 ns |  1.01 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 3.1 | 23.682 ns |   5.7478 ns |  0.3151 ns | 23.506 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 5.0 | 22.032 ns |   0.5281 ns |  0.0289 ns | 22.026 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
                            From_Bool_Nullable_NoValue | .NET Core 3.1 |  5.924 ns |   1.0904 ns |  0.0598 ns |  5.910 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 5.0 |  5.240 ns |   2.6055 ns |  0.1428 ns |  5.302 ns |  0.88 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 3.1 | 12.989 ns |   0.1575 ns |  0.0086 ns | 12.993 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 5.0 | 11.594 ns |   3.6457 ns |  0.1998 ns | 11.492 ns |  0.89 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
                                             From_Byte | .NET Core 3.1 |  8.077 ns |   1.9912 ns |  0.1091 ns |  8.018 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 5.0 |  7.219 ns |   0.4698 ns |  0.0258 ns |  7.233 ns |  0.89 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
                                    From_Byte_AsObject | .NET Core 3.1 | 17.479 ns |   1.3541 ns |  0.0742 ns | 17.516 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 5.0 | 16.908 ns |   8.1156 ns |  0.4448 ns | 16.677 ns |  0.97 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
                          From_Byte_Nullable_WithValue | .NET Core 3.1 | 10.781 ns |  50.9771 ns |  2.7942 ns |  9.381 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 5.0 |  7.606 ns |   0.6985 ns |  0.0383 ns |  7.587 ns |  0.73 |    0.16 |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 3.1 | 16.855 ns |   2.4279 ns |  0.1331 ns | 16.882 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 5.0 | 16.832 ns |   1.2382 ns |  0.0679 ns | 16.819 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
                            From_Byte_Nullable_NoValue | .NET Core 3.1 |  8.403 ns |   1.0797 ns |  0.0592 ns |  8.428 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 5.0 |  5.290 ns |   0.6928 ns |  0.0380 ns |  5.271 ns |  0.63 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 3.1 | 12.706 ns |   1.3715 ns |  0.0752 ns | 12.683 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 5.0 | 11.587 ns |   1.5571 ns |  0.0854 ns | 11.540 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
                                             From_Char | .NET Core 3.1 |  7.664 ns |   0.5827 ns |  0.0319 ns |  7.653 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Char | .NET Core 5.0 |  4.908 ns |   3.4447 ns |  0.1888 ns |  4.892 ns |  0.64 |    0.03 |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
                                    From_Char_AsObject | .NET Core 3.1 |        NA |          NA |         NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 5.0 |        NA |          NA |         NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
                          From_Char_Nullable_WithValue | .NET Core 3.1 |  7.758 ns |   5.1623 ns |  0.2830 ns |  7.596 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 5.0 |  4.854 ns |   1.1524 ns |  0.0632 ns |  4.880 ns |  0.63 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 3.1 |        NA |          NA |         NA |        NA |     ? |       ? |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 5.0 |        NA |          NA |         NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
                            From_Char_Nullable_NoValue | .NET Core 3.1 |  7.644 ns |   1.1434 ns |  0.0627 ns |  7.641 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 5.0 |  4.863 ns |   1.0608 ns |  0.0581 ns |  4.836 ns |  0.64 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 3.1 | 12.756 ns |   1.2971 ns |  0.0711 ns | 12.739 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 5.0 | 11.262 ns |   2.0819 ns |  0.1141 ns | 11.231 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
                                         From_DateTime | .NET Core 3.1 |  9.000 ns |  25.9062 ns |  1.4200 ns |  8.255 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 5.0 |  7.457 ns |   1.4195 ns |  0.0778 ns |  7.469 ns |  0.84 |    0.12 |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
                                From_DateTime_AsObject | .NET Core 3.1 |        NA |          NA |         NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 5.0 |        NA |          NA |         NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
                      From_DateTime_Nullable_WithValue | .NET Core 3.1 |  8.388 ns |   0.1500 ns |  0.0082 ns |  8.391 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 5.0 |  5.308 ns |   2.2571 ns |  0.1237 ns |  5.249 ns |  0.63 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 3.1 |        NA |          NA |         NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 5.0 |        NA |          NA |         NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
                        From_DateTime_Nullable_NoValue | .NET Core 3.1 |  8.378 ns |   0.1776 ns |  0.0097 ns |  8.382 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 5.0 |  5.749 ns |   0.6105 ns |  0.0335 ns |  5.768 ns |  0.69 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 3.1 | 12.791 ns |   1.2570 ns |  0.0689 ns | 12.752 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 5.0 | 14.629 ns |   1.3338 ns |  0.0731 ns | 14.605 ns |  1.14 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
                                          From_Decimal | .NET Core 3.1 | 11.316 ns |   4.8624 ns |  0.2665 ns | 11.319 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 5.0 | 11.454 ns |  10.8735 ns |  0.5960 ns | 11.363 ns |  1.01 |    0.03 |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
                                 From_Decimal_AsObject | .NET Core 3.1 | 21.513 ns |   7.8217 ns |  0.4287 ns | 21.322 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 5.0 | 21.390 ns |   2.2426 ns |  0.1229 ns | 21.402 ns |  0.99 |    0.03 |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
                       From_Decimal_Nullable_WithValue | .NET Core 3.1 | 16.857 ns |  24.0951 ns |  1.3207 ns | 16.214 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 5.0 | 14.567 ns |   3.4947 ns |  0.1916 ns | 14.622 ns |  0.87 |    0.06 |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 3.1 | 21.144 ns |   1.5107 ns |  0.0828 ns | 21.189 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 5.0 | 20.766 ns |   6.4261 ns |  0.3522 ns | 20.723 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
                         From_Decimal_Nullable_NoValue | .NET Core 3.1 |  9.174 ns |  12.6647 ns |  0.6942 ns |  9.083 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 5.0 |  5.553 ns |   2.6623 ns |  0.1459 ns |  5.590 ns |  0.61 |    0.06 |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 3.1 | 12.925 ns |   0.8347 ns |  0.0458 ns | 12.945 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 5.0 | 11.301 ns |   0.6223 ns |  0.0341 ns | 11.305 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
                                           From_Double | .NET Core 3.1 |  8.416 ns |   1.5185 ns |  0.0832 ns |  8.386 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 5.0 |  8.172 ns |   0.9597 ns |  0.0526 ns |  8.149 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
                                  From_Double_AsObject | .NET Core 3.1 | 17.417 ns |   1.0389 ns |  0.0569 ns | 17.390 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 5.0 | 17.322 ns |   2.4804 ns |  0.1360 ns | 17.288 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
                        From_Double_Nullable_WithValue | .NET Core 3.1 |  9.583 ns |   0.4222 ns |  0.0231 ns |  9.576 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 5.0 |  8.330 ns |   0.7927 ns |  0.0435 ns |  8.318 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
               From_Double_Nullable_WithValue_AsObject | .NET Core 3.1 | 16.965 ns |   1.3593 ns |  0.0745 ns | 17.005 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 5.0 | 17.164 ns |   1.0829 ns |  0.0594 ns | 17.152 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
                          From_Double_Nullable_NoValue | .NET Core 3.1 |  8.294 ns |   0.4034 ns |  0.0221 ns |  8.298 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 5.0 |  5.559 ns |   0.3556 ns |  0.0195 ns |  5.568 ns |  0.67 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 3.1 | 12.840 ns |   1.6190 ns |  0.0887 ns | 12.791 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 5.0 | 11.344 ns |   1.2090 ns |  0.0663 ns | 11.369 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
                                            From_Short | .NET Core 3.1 |  7.813 ns |   1.3471 ns |  0.0738 ns |  7.828 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 5.0 |  7.277 ns |   2.0915 ns |  0.1146 ns |  7.279 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
                                   From_Short_AsObject | .NET Core 3.1 | 17.223 ns |  14.5125 ns |  0.7955 ns | 16.908 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 5.0 | 17.005 ns |   4.3908 ns |  0.2407 ns | 16.902 ns |  0.99 |    0.05 |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
                         From_Short_Nullable_WithValue | .NET Core 3.1 |  8.808 ns |   1.5451 ns |  0.0847 ns |  8.761 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 5.0 |  7.705 ns |   1.1558 ns |  0.0634 ns |  7.706 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
                From_Short_Nullable_WithValue_AsObject | .NET Core 3.1 | 17.322 ns |   2.4463 ns |  0.1341 ns | 17.396 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 5.0 | 16.589 ns |   2.3509 ns |  0.1289 ns | 16.528 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
                           From_Short_Nullable_NoValue | .NET Core 3.1 |  8.105 ns |   6.4447 ns |  0.3533 ns |  7.923 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 5.0 |  5.718 ns |   1.3744 ns |  0.0753 ns |  5.731 ns |  0.71 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 3.1 | 12.742 ns |   0.3701 ns |  0.0203 ns | 12.740 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 5.0 | 11.377 ns |   3.3957 ns |  0.1861 ns | 11.275 ns |  0.89 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
                                              From_Int | .NET Core 3.1 |  7.834 ns |   0.4397 ns |  0.0241 ns |  7.829 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 5.0 |  7.265 ns |   0.9635 ns |  0.0528 ns |  7.293 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
                                     From_Int_AsObject | .NET Core 3.1 | 16.816 ns |   0.5949 ns |  0.0326 ns | 16.818 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 5.0 | 16.718 ns |   2.5639 ns |  0.1405 ns | 16.726 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
                           From_Int_Nullable_WithValue | .NET Core 3.1 |  8.711 ns |   9.3353 ns |  0.5117 ns |  8.543 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 5.0 |  8.090 ns |   7.0969 ns |  0.3890 ns |  8.079 ns |  0.93 |    0.08 |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 3.1 | 16.887 ns |   0.3523 ns |  0.0193 ns | 16.897 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 5.0 | 17.099 ns |   1.8479 ns |  0.1013 ns | 17.156 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
                             From_Int_Nullable_NoValue | .NET Core 3.1 |  8.348 ns |   1.4944 ns |  0.0819 ns |  8.318 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 5.0 |  5.467 ns |   5.0818 ns |  0.2785 ns |  5.445 ns |  0.66 |    0.04 |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 3.1 | 13.311 ns |   1.6262 ns |  0.0891 ns | 13.274 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 5.0 | 11.187 ns |   0.1649 ns |  0.0090 ns | 11.185 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
                                             From_Long | .NET Core 3.1 |  8.010 ns |   2.5358 ns |  0.1390 ns |  7.942 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Long | .NET Core 5.0 |  7.201 ns |   0.3346 ns |  0.0183 ns |  7.200 ns |  0.90 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
                                    From_Long_AsObject | .NET Core 3.1 | 16.676 ns |   1.5634 ns |  0.0857 ns | 16.681 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 5.0 | 16.626 ns |   1.9304 ns |  0.1058 ns | 16.593 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
                          From_Long_Nullable_WithValue | .NET Core 3.1 | 10.123 ns |   8.2097 ns |  0.4500 ns | 10.187 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 5.0 |  7.660 ns |   0.8337 ns |  0.0457 ns |  7.660 ns |  0.76 |    0.03 |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 3.1 | 16.771 ns |   1.4288 ns |  0.0783 ns | 16.792 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 5.0 | 17.305 ns |   0.9370 ns |  0.0514 ns | 17.297 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
                            From_Long_Nullable_NoValue | .NET Core 3.1 |  9.521 ns |   7.6846 ns |  0.4212 ns |  9.763 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 5.0 |  5.939 ns |   0.6646 ns |  0.0364 ns |  5.927 ns |  0.62 |    0.03 |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 3.1 | 13.949 ns |  35.4189 ns |  1.9414 ns | 12.869 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 5.0 | 11.421 ns |   4.6878 ns |  0.2570 ns | 11.380 ns |  0.83 |    0.11 |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
                                            From_SByte | .NET Core 3.1 |  7.863 ns |   0.5196 ns |  0.0285 ns |  7.872 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 5.0 |  7.232 ns |   1.1573 ns |  0.0634 ns |  7.217 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
                                   From_SByte_AsObject | .NET Core 3.1 | 17.417 ns |   0.3331 ns |  0.0183 ns | 17.426 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 5.0 | 16.711 ns |   1.9257 ns |  0.1056 ns | 16.652 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
                         From_SByte_Nullable_WithValue | .NET Core 3.1 |  8.356 ns |   0.5807 ns |  0.0318 ns |  8.361 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 5.0 |  7.722 ns |   0.8960 ns |  0.0491 ns |  7.698 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 3.1 | 17.089 ns |   1.6412 ns |  0.0900 ns | 17.104 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 5.0 | 16.674 ns |   1.1000 ns |  0.0603 ns | 16.670 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
                           From_SByte_Nullable_NoValue | .NET Core 3.1 |  7.989 ns |   1.1821 ns |  0.0648 ns |  8.026 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 5.0 |  5.806 ns |   0.8175 ns |  0.0448 ns |  5.824 ns |  0.73 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 3.1 | 12.813 ns |   1.7109 ns |  0.0938 ns | 12.805 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 5.0 | 11.299 ns |   2.8328 ns |  0.1553 ns | 11.245 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
                                            From_Float | .NET Core 3.1 |  8.704 ns |   4.5237 ns |  0.2480 ns |  8.779 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 5.0 |  8.104 ns |   1.4338 ns |  0.0786 ns |  8.059 ns |  0.93 |    0.04 |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
                                   From_Float_AsObject | .NET Core 3.1 | 19.098 ns |  39.2489 ns |  2.1514 ns | 17.894 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 5.0 | 18.236 ns |   2.6707 ns |  0.1464 ns | 18.215 ns |  0.96 |    0.11 |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
                         From_Float_Nullable_WithValue | .NET Core 3.1 |  9.653 ns |   1.6883 ns |  0.0925 ns |  9.602 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 5.0 |  8.285 ns |   1.1673 ns |  0.0640 ns |  8.295 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
                From_Float_Nullable_WithValue_AsObject | .NET Core 3.1 | 17.076 ns |   0.7492 ns |  0.0411 ns | 17.055 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 5.0 | 17.143 ns |   0.9166 ns |  0.0502 ns | 17.149 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
                           From_Float_Nullable_NoValue | .NET Core 3.1 |  8.069 ns |   1.6378 ns |  0.0898 ns |  8.076 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 5.0 |  5.720 ns |   0.1712 ns |  0.0094 ns |  5.725 ns |  0.71 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 3.1 | 12.684 ns |   0.5657 ns |  0.0310 ns | 12.688 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 5.0 | 11.189 ns |   0.2185 ns |  0.0120 ns | 11.193 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
                                           From_String | .NET Core 3.1 | 23.892 ns |   6.4863 ns |  0.3555 ns | 23.833 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 5.0 | 24.694 ns |   0.8001 ns |  0.0439 ns | 24.673 ns |  1.03 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
                                  From_String_AsObject | .NET Core 3.1 | 28.521 ns |   2.1455 ns |  0.1176 ns | 28.572 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 5.0 | 29.094 ns |  11.8170 ns |  0.6477 ns | 28.988 ns |  1.02 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
                                      From_String_Null | .NET Core 3.1 | 10.778 ns |   0.4745 ns |  0.0260 ns | 10.773 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 5.0 |  8.675 ns |   1.0718 ns |  0.0587 ns |  8.676 ns |  0.80 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
                             From_String_Null_AsObject | .NET Core 3.1 | 12.892 ns |   0.9483 ns |  0.0520 ns | 12.912 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 5.0 | 11.296 ns |   2.3380 ns |  0.1282 ns | 11.223 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
                                     From_String_Empty | .NET Core 3.1 | 12.034 ns |   0.7066 ns |  0.0387 ns | 12.055 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 5.0 |  9.444 ns |   1.7771 ns |  0.0974 ns |  9.479 ns |  0.78 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
                            From_String_Empty_AsObject | .NET Core 3.1 |        NA |          NA |         NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 5.0 |        NA |          NA |         NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
                                           From_UShort | .NET Core 3.1 |  8.099 ns |   0.8351 ns |  0.0458 ns |  8.094 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 5.0 |  7.879 ns |   9.4329 ns |  0.5170 ns |  8.015 ns |  0.97 |    0.06 |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
                                  From_UShort_AsObject | .NET Core 3.1 | 16.653 ns |   0.4459 ns |  0.0244 ns | 16.649 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 5.0 | 16.662 ns |   1.2876 ns |  0.0706 ns | 16.691 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
                        From_UShort_Nullable_WithValue | .NET Core 3.1 |  8.299 ns |   1.1623 ns |  0.0637 ns |  8.326 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 5.0 |  8.114 ns |   7.0497 ns |  0.3864 ns |  8.315 ns |  0.98 |    0.04 |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 3.1 | 16.899 ns |   2.2472 ns |  0.1232 ns | 16.884 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 5.0 | 16.669 ns |   2.4429 ns |  0.1339 ns | 16.707 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
                          From_UShort_Nullable_NoValue | .NET Core 3.1 |  7.869 ns |   0.6363 ns |  0.0349 ns |  7.889 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 5.0 |  5.147 ns |   0.1724 ns |  0.0095 ns |  5.148 ns |  0.65 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 3.1 | 13.316 ns |   0.7229 ns |  0.0396 ns | 13.329 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 5.0 | 13.149 ns |   7.3753 ns |  0.4043 ns | 12.932 ns |  0.99 |    0.03 |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
                                             From_UInt | .NET Core 3.1 |  7.915 ns |   0.7762 ns |  0.0425 ns |  7.900 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 5.0 |  7.207 ns |   0.4550 ns |  0.0249 ns |  7.208 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
                                    From_UInt_AsObject | .NET Core 3.1 | 16.907 ns |   2.6011 ns |  0.1426 ns | 16.943 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 5.0 | 16.756 ns |   1.1634 ns |  0.0638 ns | 16.741 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
                          From_UInt_Nullable_WithValue | .NET Core 3.1 |  8.316 ns |   0.3245 ns |  0.0178 ns |  8.316 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 5.0 |  7.648 ns |   0.3878 ns |  0.0213 ns |  7.640 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 3.1 | 16.948 ns |   1.7676 ns |  0.0969 ns | 16.929 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 5.0 | 16.695 ns |   1.5993 ns |  0.0877 ns | 16.678 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
                            From_UInt_Nullable_NoValue | .NET Core 3.1 |  7.822 ns |   0.8053 ns |  0.0441 ns |  7.796 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 5.0 |  5.790 ns |   0.2798 ns |  0.0153 ns |  5.784 ns |  0.74 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 3.1 | 12.729 ns |   0.9522 ns |  0.0522 ns | 12.738 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 5.0 | 11.334 ns |   2.1792 ns |  0.1195 ns | 11.353 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
                                            From_ULong | .NET Core 3.1 |  7.803 ns |   0.8846 ns |  0.0485 ns |  7.831 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 5.0 |  7.216 ns |   0.8970 ns |  0.0492 ns |  7.193 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
                                   From_ULong_AsObject | .NET Core 3.1 | 17.986 ns |  17.9132 ns |  0.9819 ns | 17.801 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 5.0 | 16.893 ns |   4.4971 ns |  0.2465 ns | 16.784 ns |  0.94 |    0.05 |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
                         From_ULong_Nullable_WithValue | .NET Core 3.1 |  8.595 ns |   0.4536 ns |  0.0249 ns |  8.604 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 5.0 |  7.750 ns |   0.7087 ns |  0.0388 ns |  7.738 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 3.1 | 17.837 ns |   1.8419 ns |  0.1010 ns | 17.848 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 5.0 | 16.879 ns |   0.8732 ns |  0.0479 ns | 16.867 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
                           From_ULong_Nullable_NoValue | .NET Core 3.1 |  8.122 ns |   0.2715 ns |  0.0149 ns |  8.118 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 5.0 |  5.211 ns |   0.4986 ns |  0.0273 ns |  5.220 ns |  0.64 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 3.1 | 11.339 ns |   2.0332 ns |  0.1114 ns | 11.284 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 5.0 | 11.276 ns |   1.4446 ns |  0.0792 ns | 11.317 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
                                       From_NullObject | .NET Core 3.1 | 12.803 ns |   0.8419 ns |  0.0461 ns | 12.812 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 5.0 | 11.234 ns |   0.7406 ns |  0.0406 ns | 11.211 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
                                           From_DBNull | .NET Core 3.1 | 10.622 ns |   1.2581 ns |  0.0690 ns | 10.651 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 5.0 |  8.555 ns |   7.5538 ns |  0.4140 ns |  8.414 ns |  0.81 |    0.04 |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
                                  From_DBNull_AsObject | .NET Core 3.1 | 13.104 ns |  11.1276 ns |  0.6099 ns | 12.761 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 5.0 | 11.282 ns |   1.4040 ns |  0.0770 ns | 11.324 ns |  0.86 |    0.04 |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
                                 From_ConvertibleClass | .NET Core 3.1 | 14.169 ns |   1.3509 ns |  0.0740 ns | 14.165 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 5.0 | 14.276 ns |   4.6477 ns |  0.2548 ns | 14.327 ns |  1.01 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
                        From_ConvertibleClass_AsObject | .NET Core 3.1 | 16.154 ns |   0.4599 ns |  0.0252 ns | 16.151 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 5.0 | 17.137 ns |   0.6294 ns |  0.0345 ns | 17.151 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
                         From_ConvertibleClass_NoValue | .NET Core 3.1 | 12.514 ns |   0.9562 ns |  0.0524 ns | 12.531 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 5.0 | 11.709 ns |   1.9475 ns |  0.1068 ns | 11.689 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 3.1 | 14.091 ns |   0.3606 ns |  0.0198 ns | 14.080 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 5.0 | 11.191 ns |   1.5242 ns |  0.0835 ns | 11.180 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
                              From_NonConvertibleClass | .NET Core 3.1 | 11.070 ns |   3.7588 ns |  0.2060 ns | 11.062 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 5.0 |  9.533 ns |   1.8147 ns |  0.0995 ns |  9.586 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
                     From_NonConvertibleClass_AsObject | .NET Core 3.1 | 14.481 ns |   0.5475 ns |  0.0300 ns | 14.484 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 5.0 | 13.208 ns |   1.1702 ns |  0.0641 ns | 13.234 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
                      From_NonConvertibleClass_NoValue | .NET Core 3.1 | 12.661 ns |   6.7027 ns |  0.3674 ns | 12.459 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 5.0 |  8.325 ns |   0.3185 ns |  0.0175 ns |  8.323 ns |  0.66 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 3.1 | 13.102 ns |   1.5283 ns |  0.0838 ns | 13.141 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 5.0 | 11.272 ns |   0.2985 ns |  0.0164 ns | 11.272 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
                                From_ConvertibleStruct | .NET Core 3.1 | 11.963 ns |   2.0445 ns |  0.1121 ns | 11.906 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 5.0 | 11.670 ns |   4.0919 ns |  0.2243 ns | 11.642 ns |  0.98 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
                       From_ConvertibleStruct_AsObject | .NET Core 3.1 | 16.627 ns |   0.7132 ns |  0.0391 ns | 16.623 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 5.0 | 17.298 ns |   7.2181 ns |  0.3957 ns | 17.152 ns |  1.04 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 3.1 | 12.555 ns |   2.6746 ns |  0.1466 ns | 12.498 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 5.0 | 12.603 ns |   1.1118 ns |  0.0609 ns | 12.621 ns |  1.00 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.1 | 16.472 ns |   1.1602 ns |  0.0636 ns | 16.491 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 5.0 | 16.737 ns |   0.7584 ns |  0.0416 ns | 16.716 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 3.1 |  8.304 ns |   1.0090 ns |  0.0553 ns |  8.279 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 5.0 |  6.256 ns |   0.9072 ns |  0.0497 ns |  6.238 ns |  0.75 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.1 | 13.329 ns |   1.1608 ns |  0.0636 ns | 13.346 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 5.0 | 11.404 ns |   0.7513 ns |  0.0412 ns | 11.420 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
                             From_NonConvertibleStruct | .NET Core 3.1 |  7.536 ns |   0.4555 ns |  0.0250 ns |  7.536 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 5.0 |  6.236 ns |   0.7338 ns |  0.0402 ns |  6.219 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
                    From_NonConvertibleStruct_AsObject | .NET Core 3.1 | 14.564 ns |   1.0848 ns |  0.0595 ns | 14.561 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 5.0 | 13.223 ns |   0.1076 ns |  0.0059 ns | 13.225 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 3.1 |  7.601 ns |   0.0996 ns |  0.0055 ns |  7.599 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 5.0 |  6.291 ns |   2.3648 ns |  0.1296 ns |  6.235 ns |  0.83 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.1 | 14.780 ns |   0.9404 ns |  0.0515 ns | 14.753 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 5.0 | 13.106 ns |   1.2080 ns |  0.0662 ns | 13.123 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 3.1 |  7.897 ns |   1.2797 ns |  0.0701 ns |  7.914 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 5.0 |  6.261 ns |   2.3445 ns |  0.1285 ns |  6.191 ns |  0.79 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.1 | 14.673 ns |   2.2095 ns |  0.1211 ns | 14.647 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 5.0 | 11.380 ns |   3.7541 ns |  0.2058 ns | 11.489 ns |  0.78 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
                                             From_Enum | .NET Core 3.1 |  7.927 ns |   0.1889 ns |  0.0104 ns |  7.931 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 5.0 |  7.163 ns |   0.3260 ns |  0.0179 ns |  7.171 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
                                    From_Enum_AsObject | .NET Core 3.1 | 37.020 ns |   2.6970 ns |  0.1478 ns | 37.044 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject | .NET Core 5.0 | 24.614 ns |   7.0182 ns |  0.3847 ns | 24.694 ns |  0.66 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
                          From_Enum_Nullable_WithValue | .NET Core 3.1 |  8.350 ns |   0.1055 ns |  0.0058 ns |  8.351 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 5.0 |  7.924 ns |   0.4026 ns |  0.0221 ns |  7.914 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 3.1 | 42.250 ns |   1.5303 ns |  0.0839 ns | 42.290 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 5.0 | 25.095 ns |   1.5761 ns |  0.0864 ns | 25.131 ns |  0.59 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
                            From_Enum_Nullable_NoValue | .NET Core 3.1 |  7.934 ns |   0.4924 ns |  0.0270 ns |  7.929 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 5.0 |  5.885 ns |   0.6342 ns |  0.0348 ns |  5.868 ns |  0.74 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 3.1 | 12.984 ns |   0.4653 ns |  0.0255 ns | 12.971 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 5.0 | 11.449 ns |   2.8424 ns |  0.1558 ns | 11.448 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
                                      From_ParentClass | .NET Core 3.1 | 11.822 ns |   2.0653 ns |  0.1132 ns | 11.799 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 5.0 |  8.409 ns |   1.3057 ns |  0.0716 ns |  8.404 ns |  0.71 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
                             From_ParentClass_AsObject | .NET Core 3.1 | 16.964 ns |   3.9082 ns |  0.2142 ns | 16.910 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 5.0 | 13.229 ns |   0.8287 ns |  0.0454 ns | 13.205 ns |  0.78 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |             |            |           |       |         |        |       |       |           |
                              From_ParentClass_NoValue | .NET Core 3.1 | 11.916 ns |   1.7664 ns |  0.0968 ns | 11.876 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 5.0 |  8.412 ns |   2.8718 ns |  0.1574 ns |  8.340 ns |  0.71 |    0.01 |      - |     - |     - |         - |

Benchmarks with issues:
  ConvertTo_BoolNullable.From_Char_AsObject: ShortRun(Toolchain=.NET Core 3.1, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_BoolNullable.From_Char_AsObject: ShortRun(Toolchain=.NET Core 5.0, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_BoolNullable.From_Char_Nullable_WithValue_AsObject: ShortRun(Toolchain=.NET Core 3.1, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_BoolNullable.From_Char_Nullable_WithValue_AsObject: ShortRun(Toolchain=.NET Core 5.0, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_BoolNullable.From_DateTime_AsObject: ShortRun(Toolchain=.NET Core 3.1, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_BoolNullable.From_DateTime_AsObject: ShortRun(Toolchain=.NET Core 5.0, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_BoolNullable.From_DateTime_Nullable_WithValue_AsObject: ShortRun(Toolchain=.NET Core 3.1, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_BoolNullable.From_DateTime_Nullable_WithValue_AsObject: ShortRun(Toolchain=.NET Core 5.0, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_BoolNullable.From_String_Empty_AsObject: ShortRun(Toolchain=.NET Core 3.1, IterationCount=3, LaunchCount=1, WarmupCount=3)
  ConvertTo_BoolNullable.From_String_Empty_AsObject: ShortRun(Toolchain=.NET Core 5.0, IterationCount=3, LaunchCount=1, WarmupCount=3)
