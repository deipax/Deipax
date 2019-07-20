
BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.615 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-XBZJXS : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), 64bit RyuJIT
  Job-RPHYXP : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-WPBXUQ : .NET Core 3.0.0-preview6-27804-01 (CoreCLR 4.700.19.30373, CoreFX 4.700.19.30308), 64bit RyuJIT
  Job-EJFWSE : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0
  Job-ZVTGBZ : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0


                                                Method |     Toolchain |      Mean |     Error |    StdDev |    Median | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------------------------------------------ |-------------- |----------:|----------:|----------:|----------:|------:|--------:|-------:|------:|------:|----------:|
                                             From_Bool | .NET Core 2.0 | 13.608 ns | 0.0163 ns | 0.0144 ns | 13.605 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 2.2 | 12.453 ns | 0.0125 ns | 0.0116 ns | 12.453 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 3.0 |  9.878 ns | 0.0168 ns | 0.0157 ns |  9.876 ns |  0.73 |    0.00 |      - |     - |     - |         - |
                                             From_Bool |        net461 | 14.490 ns | 0.1193 ns | 0.1116 ns | 14.510 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                                             From_Bool |        net472 | 12.956 ns | 0.0190 ns | 0.0178 ns | 12.950 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Bool_AsObject | .NET Core 2.0 | 19.358 ns | 0.0248 ns | 0.0207 ns | 19.359 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 2.2 | 17.523 ns | 0.0181 ns | 0.0169 ns | 17.522 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 3.0 | 18.032 ns | 0.0191 ns | 0.0159 ns | 18.036 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net461 | 27.790 ns | 0.2218 ns | 0.1852 ns | 27.811 ns |  1.44 |    0.01 |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net472 | 30.027 ns | 0.1142 ns | 0.1068 ns | 30.060 ns |  1.55 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Bool_Nullable_WithValue | .NET Core 2.0 | 12.769 ns | 0.1416 ns | 0.1324 ns | 12.764 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 2.2 | 10.955 ns | 0.0404 ns | 0.0358 ns | 10.966 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 3.0 | 10.118 ns | 0.0124 ns | 0.0116 ns | 10.115 ns |  0.79 |    0.01 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net461 | 14.730 ns | 0.1474 ns | 0.1307 ns | 14.717 ns |  1.15 |    0.02 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net472 | 13.153 ns | 0.0188 ns | 0.0176 ns | 13.152 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.753 ns | 0.0307 ns | 0.0272 ns | 19.745 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.544 ns | 0.0330 ns | 0.0308 ns | 17.543 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 3.0 | 19.383 ns | 0.0840 ns | 0.0785 ns | 19.340 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net461 | 30.095 ns | 0.0739 ns | 0.0655 ns | 30.081 ns |  1.52 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net472 | 28.837 ns | 0.0444 ns | 0.0415 ns | 28.829 ns |  1.46 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Bool_Nullable_NoValue | .NET Core 2.0 | 12.112 ns | 0.0410 ns | 0.0363 ns | 12.127 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 2.2 | 10.379 ns | 0.0118 ns | 0.0110 ns | 10.380 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 3.0 |  9.924 ns | 0.0657 ns | 0.0615 ns |  9.879 ns |  0.82 |    0.01 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net461 | 14.504 ns | 0.0489 ns | 0.0434 ns | 14.506 ns |  1.20 |    0.01 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net472 | 13.033 ns | 0.0424 ns | 0.0396 ns | 13.041 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.599 ns | 0.0302 ns | 0.0283 ns | 15.589 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.674 ns | 0.0175 ns | 0.0146 ns | 13.671 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.405 ns | 0.0180 ns | 0.0169 ns | 13.400 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net461 | 23.402 ns | 0.0922 ns | 0.0863 ns | 23.372 ns |  1.50 |    0.01 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net472 | 24.662 ns | 0.0326 ns | 0.0289 ns | 24.657 ns |  1.58 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Byte | .NET Core 2.0 | 12.067 ns | 0.0086 ns | 0.0076 ns | 12.066 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 2.2 | 10.419 ns | 0.0186 ns | 0.0174 ns | 10.418 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 3.0 |  9.432 ns | 0.0113 ns | 0.0094 ns |  9.433 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                                             From_Byte |        net461 | 14.134 ns | 0.0574 ns | 0.0480 ns | 14.137 ns |  1.17 |    0.00 |      - |     - |     - |         - |
                                             From_Byte |        net472 | 12.678 ns | 0.0156 ns | 0.0130 ns | 12.679 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Byte_AsObject | .NET Core 2.0 | 19.409 ns | 0.0276 ns | 0.0258 ns | 19.412 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 2.2 | 18.438 ns | 0.0253 ns | 0.0225 ns | 18.446 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 3.0 | 17.803 ns | 0.0295 ns | 0.0246 ns | 17.799 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net461 | 31.115 ns | 0.2870 ns | 0.2685 ns | 31.016 ns |  1.60 |    0.01 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net472 | 29.049 ns | 0.0272 ns | 0.0254 ns | 29.042 ns |  1.50 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Byte_Nullable_WithValue | .NET Core 2.0 | 12.314 ns | 0.0141 ns | 0.0132 ns | 12.313 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 2.2 | 10.907 ns | 0.0301 ns | 0.0282 ns | 10.913 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 3.0 | 10.330 ns | 0.0112 ns | 0.0099 ns | 10.330 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net461 | 13.739 ns | 0.1631 ns | 0.1525 ns | 13.656 ns |  1.12 |    0.01 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net472 | 12.928 ns | 0.0323 ns | 0.0270 ns | 12.921 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.998 ns | 0.0624 ns | 0.0554 ns | 20.022 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.539 ns | 0.0483 ns | 0.0452 ns | 17.531 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 3.0 | 19.228 ns | 0.1465 ns | 0.1370 ns | 19.205 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net461 | 27.493 ns | 0.2519 ns | 0.2356 ns | 27.417 ns |  1.37 |    0.01 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net472 | 28.736 ns | 0.0299 ns | 0.0279 ns | 28.736 ns |  1.44 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Byte_Nullable_NoValue | .NET Core 2.0 | 12.053 ns | 0.0114 ns | 0.0106 ns | 12.052 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 2.2 | 11.350 ns | 0.0148 ns | 0.0139 ns | 11.353 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 3.0 |  9.658 ns | 0.0120 ns | 0.0106 ns |  9.658 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net461 | 14.753 ns | 0.4290 ns | 0.4405 ns | 14.562 ns |  1.23 |    0.04 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net472 | 12.923 ns | 0.0133 ns | 0.0111 ns | 12.923 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.998 ns | 0.0117 ns | 0.0104 ns | 14.996 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.151 ns | 0.0336 ns | 0.0314 ns | 13.135 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.985 ns | 0.0678 ns | 0.0635 ns | 15.033 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net461 | 23.646 ns | 0.3598 ns | 0.3366 ns | 23.433 ns |  1.58 |    0.02 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net472 | 25.581 ns | 0.0304 ns | 0.0270 ns | 25.586 ns |  1.71 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Char | .NET Core 2.0 | 12.587 ns | 0.0184 ns | 0.0163 ns | 12.584 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Char | .NET Core 2.2 | 10.161 ns | 0.0132 ns | 0.0124 ns | 10.158 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                                             From_Char | .NET Core 3.0 |  9.483 ns | 0.0133 ns | 0.0118 ns |  9.479 ns |  0.75 |    0.00 |      - |     - |     - |         - |
                                             From_Char |        net461 | 13.524 ns | 0.0801 ns | 0.0710 ns | 13.518 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                                             From_Char |        net472 | 13.155 ns | 0.0338 ns | 0.0299 ns | 13.143 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Char_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Char_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Char_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Char_Nullable_WithValue | .NET Core 2.0 | 11.895 ns | 0.0587 ns | 0.0549 ns | 11.915 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 2.2 | 10.213 ns | 0.0278 ns | 0.0260 ns | 10.203 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 3.0 |  9.684 ns | 0.0100 ns | 0.0094 ns |  9.684 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net461 | 13.613 ns | 0.1212 ns | 0.1134 ns | 13.600 ns |  1.14 |    0.01 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net472 | 12.453 ns | 0.0144 ns | 0.0134 ns | 12.456 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Char_Nullable_NoValue | .NET Core 2.0 | 12.450 ns | 0.0671 ns | 0.0628 ns | 12.498 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 2.2 | 10.313 ns | 0.0097 ns | 0.0086 ns | 10.315 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 3.0 |  9.677 ns | 0.0143 ns | 0.0120 ns |  9.675 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net461 | 13.773 ns | 0.2850 ns | 0.2666 ns | 13.658 ns |  1.11 |    0.02 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net472 | 12.476 ns | 0.0227 ns | 0.0212 ns | 12.469 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.584 ns | 0.0158 ns | 0.0132 ns | 15.585 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.145 ns | 0.0087 ns | 0.0077 ns | 13.144 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 3.0 | 15.003 ns | 0.0740 ns | 0.0692 ns | 15.024 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net461 | 28.124 ns | 0.1051 ns | 0.0931 ns | 28.091 ns |  1.81 |    0.01 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net472 | 24.815 ns | 0.0223 ns | 0.0209 ns | 24.809 ns |  1.59 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                         From_DateTime | .NET Core 2.0 | 14.642 ns | 0.1775 ns | 0.1660 ns | 14.628 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 2.2 | 11.248 ns | 0.0124 ns | 0.0116 ns | 11.245 ns |  0.77 |    0.01 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 3.0 |  9.942 ns | 0.0126 ns | 0.0098 ns |  9.943 ns |  0.68 |    0.01 |      - |     - |     - |         - |
                                         From_DateTime |        net461 | 14.243 ns | 0.0742 ns | 0.0620 ns | 14.245 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                                         From_DateTime |        net472 | 13.205 ns | 0.0157 ns | 0.0147 ns | 13.198 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                From_DateTime_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                      From_DateTime_Nullable_WithValue | .NET Core 2.0 | 12.431 ns | 0.0255 ns | 0.0226 ns | 12.423 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 2.2 | 11.350 ns | 0.0125 ns | 0.0117 ns | 11.353 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 3.0 | 10.140 ns | 0.0112 ns | 0.0099 ns | 10.142 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net461 | 14.221 ns | 0.0712 ns | 0.0594 ns | 14.196 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net472 | 13.218 ns | 0.0241 ns | 0.0213 ns | 13.217 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_DateTime_Nullable_NoValue | .NET Core 2.0 | 12.340 ns | 0.0102 ns | 0.0095 ns | 12.338 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 2.2 | 11.362 ns | 0.0109 ns | 0.0096 ns | 11.360 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 3.0 |  9.917 ns | 0.0114 ns | 0.0101 ns |  9.916 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net461 | 14.025 ns | 0.0265 ns | 0.0235 ns | 14.020 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net472 | 14.004 ns | 0.0152 ns | 0.0135 ns | 14.008 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.021 ns | 0.0274 ns | 0.0256 ns | 15.018 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.151 ns | 0.0167 ns | 0.0156 ns | 13.150 ns |  0.88 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 3.0 | 16.622 ns | 0.0735 ns | 0.0687 ns | 16.640 ns |  1.11 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net461 | 25.418 ns | 0.0327 ns | 0.0306 ns | 25.412 ns |  1.69 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net472 | 25.794 ns | 0.0649 ns | 0.0607 ns | 25.797 ns |  1.72 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                          From_Decimal | .NET Core 2.0 | 24.040 ns | 0.0329 ns | 0.0292 ns | 24.048 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 2.2 | 20.427 ns | 0.0161 ns | 0.0151 ns | 20.426 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 3.0 | 12.739 ns | 0.0117 ns | 0.0104 ns | 12.739 ns |  0.53 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal |        net461 | 24.253 ns | 0.0251 ns | 0.0223 ns | 24.261 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal |        net472 | 23.142 ns | 0.0249 ns | 0.0208 ns | 23.146 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                 From_Decimal_AsObject | .NET Core 2.0 | 26.560 ns | 0.0235 ns | 0.0196 ns | 26.557 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 2.2 | 24.330 ns | 0.0118 ns | 0.0098 ns | 24.329 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 3.0 | 22.051 ns | 0.0263 ns | 0.0220 ns | 22.044 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net461 | 32.129 ns | 0.1418 ns | 0.1326 ns | 32.063 ns |  1.21 |    0.01 |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net472 | 35.876 ns | 0.0632 ns | 0.0560 ns | 35.857 ns |  1.35 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                       From_Decimal_Nullable_WithValue | .NET Core 2.0 | 26.261 ns | 0.0286 ns | 0.0267 ns | 26.263 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 2.2 | 25.232 ns | 0.0247 ns | 0.0231 ns | 25.227 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 3.0 | 24.519 ns | 0.0230 ns | 0.0192 ns | 24.516 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net461 | 28.035 ns | 0.1531 ns | 0.1432 ns | 27.988 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net472 | 27.811 ns | 0.0300 ns | 0.0266 ns | 27.801 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.0 | 27.083 ns | 0.0276 ns | 0.0244 ns | 27.079 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.2 | 25.403 ns | 0.0134 ns | 0.0119 ns | 25.404 ns |  0.94 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 3.0 | 21.530 ns | 0.0162 ns | 0.0144 ns | 21.526 ns |  0.79 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net461 | 35.838 ns | 0.0844 ns | 0.0659 ns | 35.856 ns |  1.32 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net472 | 34.094 ns | 0.0489 ns | 0.0458 ns | 34.098 ns |  1.26 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Decimal_Nullable_NoValue | .NET Core 2.0 | 14.079 ns | 0.0131 ns | 0.0117 ns | 14.077 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 2.2 | 11.479 ns | 0.0134 ns | 0.0119 ns | 11.479 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 3.0 | 10.091 ns | 0.0327 ns | 0.0290 ns | 10.104 ns |  0.72 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net461 | 14.360 ns | 0.0289 ns | 0.0256 ns | 14.357 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net472 | 13.637 ns | 0.0199 ns | 0.0186 ns | 13.640 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.002 ns | 0.0354 ns | 0.0314 ns | 15.000 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.624 ns | 0.0140 ns | 0.0131 ns | 13.626 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.909 ns | 0.3123 ns | 0.5632 ns | 13.598 ns |  0.97 |    0.04 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net461 | 23.090 ns | 0.0559 ns | 0.0523 ns | 23.079 ns |  1.54 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net472 | 26.246 ns | 0.1428 ns | 0.1335 ns | 26.317 ns |  1.75 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_Double | .NET Core 2.0 | 12.246 ns | 0.0149 ns | 0.0132 ns | 12.244 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 2.2 | 10.825 ns | 0.0147 ns | 0.0130 ns | 10.827 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 3.0 | 10.111 ns | 0.0149 ns | 0.0133 ns | 10.109 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                           From_Double |        net461 | 14.271 ns | 0.0181 ns | 0.0169 ns | 14.268 ns |  1.17 |    0.00 |      - |     - |     - |         - |
                                           From_Double |        net472 | 13.596 ns | 0.0228 ns | 0.0213 ns | 13.591 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_Double_AsObject | .NET Core 2.0 | 19.942 ns | 0.0277 ns | 0.0259 ns | 19.938 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 2.2 | 17.307 ns | 0.0265 ns | 0.0248 ns | 17.302 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 3.0 | 17.799 ns | 0.1277 ns | 0.1195 ns | 17.754 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                                  From_Double_AsObject |        net461 | 31.127 ns | 0.1084 ns | 0.0961 ns | 31.158 ns |  1.56 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject |        net472 | 29.087 ns | 0.0269 ns | 0.0239 ns | 29.089 ns |  1.46 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_Double_Nullable_WithValue | .NET Core 2.0 | 12.737 ns | 0.0154 ns | 0.0137 ns | 12.734 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 2.2 | 12.275 ns | 0.2505 ns | 0.2344 ns | 12.281 ns |  0.96 |    0.02 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 3.0 | 10.597 ns | 0.0180 ns | 0.0168 ns | 10.598 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net461 | 21.394 ns | 0.0438 ns | 0.0410 ns | 21.396 ns |  1.68 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net472 | 14.564 ns | 0.0665 ns | 0.0622 ns | 14.600 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.943 ns | 0.0870 ns | 0.0726 ns | 19.967 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.2 | 18.356 ns | 0.0504 ns | 0.0446 ns | 18.363 ns |  0.92 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.497 ns | 0.0400 ns | 0.0354 ns | 17.491 ns |  0.88 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net461 | 27.994 ns | 0.0757 ns | 0.0708 ns | 28.014 ns |  1.40 |    0.01 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net472 | 29.012 ns | 0.0249 ns | 0.0233 ns | 29.011 ns |  1.45 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Double_Nullable_NoValue | .NET Core 2.0 | 12.357 ns | 0.0102 ns | 0.0085 ns | 12.355 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 2.2 | 11.383 ns | 0.0084 ns | 0.0079 ns | 11.383 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 3.0 |  9.879 ns | 0.0058 ns | 0.0049 ns |  9.879 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net461 | 14.460 ns | 0.0175 ns | 0.0146 ns | 14.459 ns |  1.17 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net472 | 13.386 ns | 0.0211 ns | 0.0165 ns | 13.388 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.0 | 16.091 ns | 0.0142 ns | 0.0126 ns | 16.090 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.125 ns | 0.0059 ns | 0.0049 ns | 13.126 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 3.0 | 15.063 ns | 0.0784 ns | 0.0695 ns | 15.089 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net461 | 23.104 ns | 0.1930 ns | 0.1612 ns | 23.017 ns |  1.44 |    0.01 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net472 | 26.554 ns | 0.0327 ns | 0.0306 ns | 26.563 ns |  1.65 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_Short | .NET Core 2.0 | 12.717 ns | 0.0107 ns | 0.0095 ns | 12.717 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 2.2 | 11.118 ns | 0.0112 ns | 0.0094 ns | 11.117 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 3.0 |  9.748 ns | 0.3938 ns | 0.5772 ns |  9.421 ns |  0.79 |    0.05 |      - |     - |     - |         - |
                                            From_Short |        net461 | 14.225 ns | 0.1071 ns | 0.1002 ns | 14.267 ns |  1.12 |    0.01 |      - |     - |     - |         - |
                                            From_Short |        net472 | 12.694 ns | 0.0169 ns | 0.0158 ns | 12.697 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_Short_AsObject | .NET Core 2.0 | 20.387 ns | 0.0914 ns | 0.0855 ns | 20.420 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 2.2 | 17.522 ns | 0.0182 ns | 0.0161 ns | 17.516 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 3.0 | 19.379 ns | 0.0611 ns | 0.0572 ns | 19.367 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net461 | 27.752 ns | 0.0298 ns | 0.0249 ns | 27.750 ns |  1.36 |    0.01 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net472 | 29.930 ns | 0.0316 ns | 0.0296 ns | 29.941 ns |  1.47 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Short_Nullable_WithValue | .NET Core 2.0 | 12.275 ns | 0.0156 ns | 0.0138 ns | 12.279 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 2.2 | 11.528 ns | 0.0140 ns | 0.0131 ns | 11.529 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 3.0 | 10.371 ns | 0.0828 ns | 0.0775 ns | 10.330 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net461 | 13.726 ns | 0.0471 ns | 0.0440 ns | 13.731 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net472 | 13.047 ns | 0.0751 ns | 0.0703 ns | 13.070 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.460 ns | 0.0225 ns | 0.0199 ns | 19.463 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.634 ns | 0.0674 ns | 0.0630 ns | 17.658 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.984 ns | 0.0351 ns | 0.0311 ns | 17.985 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net461 | 27.411 ns | 0.0950 ns | 0.0889 ns | 27.367 ns |  1.41 |    0.01 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net472 | 29.795 ns | 0.0456 ns | 0.0427 ns | 29.777 ns |  1.53 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Short_Nullable_NoValue | .NET Core 2.0 | 12.052 ns | 0.0109 ns | 0.0102 ns | 12.054 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 2.2 | 10.371 ns | 0.0133 ns | 0.0125 ns | 10.368 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 3.0 |  9.727 ns | 0.0613 ns | 0.0573 ns |  9.757 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net461 | 13.724 ns | 0.0673 ns | 0.0629 ns | 13.744 ns |  1.14 |    0.01 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net472 | 12.923 ns | 0.0204 ns | 0.0181 ns | 12.917 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.972 ns | 0.0140 ns | 0.0124 ns | 14.969 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.198 ns | 0.0156 ns | 0.0138 ns | 14.198 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.540 ns | 0.0354 ns | 0.0296 ns | 13.528 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net461 | 26.709 ns | 0.1740 ns | 0.1627 ns | 26.781 ns |  1.78 |    0.01 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net472 | 24.546 ns | 0.0396 ns | 0.0371 ns | 24.540 ns |  1.64 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                              From_Int | .NET Core 2.0 | 12.038 ns | 0.0140 ns | 0.0117 ns | 12.039 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 2.2 | 10.476 ns | 0.0164 ns | 0.0137 ns | 10.482 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 3.0 |  9.661 ns | 0.0113 ns | 0.0100 ns |  9.658 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                              From_Int |        net461 | 13.872 ns | 0.0312 ns | 0.0292 ns | 13.862 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                                              From_Int |        net472 | 17.484 ns | 0.0590 ns | 0.0552 ns | 17.485 ns |  1.45 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_Int_AsObject | .NET Core 2.0 | 19.396 ns | 0.0268 ns | 0.0237 ns | 19.402 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 2.2 | 18.433 ns | 0.0234 ns | 0.0208 ns | 18.432 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 3.0 | 17.970 ns | 0.0201 ns | 0.0168 ns | 17.973 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net461 | 27.499 ns | 0.0345 ns | 0.0269 ns | 27.488 ns |  1.42 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net472 | 30.271 ns | 0.0660 ns | 0.0551 ns | 30.269 ns |  1.56 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Int_Nullable_WithValue | .NET Core 2.0 | 12.272 ns | 0.0117 ns | 0.0109 ns | 12.270 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 2.2 | 11.360 ns | 0.0453 ns | 0.0424 ns | 11.378 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 3.0 | 10.122 ns | 0.0156 ns | 0.0139 ns | 10.124 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net461 | 13.610 ns | 0.0268 ns | 0.0224 ns | 13.604 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net472 | 13.310 ns | 0.0782 ns | 0.0731 ns | 13.299 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.734 ns | 0.0918 ns | 0.0859 ns | 20.763 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.531 ns | 0.0231 ns | 0.0216 ns | 17.528 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.881 ns | 0.0162 ns | 0.0144 ns | 18.880 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net461 | 26.903 ns | 0.0355 ns | 0.0296 ns | 26.904 ns |  1.30 |    0.01 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net472 | 29.173 ns | 0.0541 ns | 0.0452 ns | 29.161 ns |  1.41 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_Int_Nullable_NoValue | .NET Core 2.0 | 12.031 ns | 0.0126 ns | 0.0117 ns | 12.030 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 2.2 | 10.839 ns | 0.0124 ns | 0.0110 ns | 10.839 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 3.0 |  9.667 ns | 0.0241 ns | 0.0214 ns |  9.660 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net461 | 13.674 ns | 0.0192 ns | 0.0179 ns | 13.673 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net472 | 12.937 ns | 0.0193 ns | 0.0180 ns | 12.935 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.987 ns | 0.0134 ns | 0.0125 ns | 14.990 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.161 ns | 0.0150 ns | 0.0133 ns | 13.161 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 3.0 | 15.987 ns | 0.0592 ns | 0.0525 ns | 15.970 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net461 | 22.930 ns | 0.0299 ns | 0.0280 ns | 22.927 ns |  1.53 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net472 | 25.479 ns | 0.0287 ns | 0.0269 ns | 25.482 ns |  1.70 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Long | .NET Core 2.0 | 12.358 ns | 0.0200 ns | 0.0167 ns | 12.359 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Long | .NET Core 2.2 | 10.406 ns | 0.0096 ns | 0.0085 ns | 10.405 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                             From_Long | .NET Core 3.0 |  9.645 ns | 0.0094 ns | 0.0088 ns |  9.647 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                                             From_Long |        net461 | 14.164 ns | 0.0630 ns | 0.0589 ns | 14.180 ns |  1.15 |    0.01 |      - |     - |     - |         - |
                                             From_Long |        net472 | 12.704 ns | 0.0240 ns | 0.0224 ns | 12.706 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Long_AsObject | .NET Core 2.0 | 19.742 ns | 0.0132 ns | 0.0117 ns | 19.745 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 2.2 | 18.575 ns | 0.0661 ns | 0.0618 ns | 18.601 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 3.0 | 18.173 ns | 0.0850 ns | 0.0795 ns | 18.139 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net461 | 29.918 ns | 0.1228 ns | 0.1149 ns | 29.972 ns |  1.52 |    0.01 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net472 | 29.305 ns | 0.0170 ns | 0.0150 ns | 29.302 ns |  1.48 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Long_Nullable_WithValue | .NET Core 2.0 | 13.322 ns | 0.0693 ns | 0.0648 ns | 13.308 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 2.2 | 11.701 ns | 0.0163 ns | 0.0145 ns | 11.698 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 3.0 | 10.351 ns | 0.0134 ns | 0.0119 ns | 10.350 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net461 | 15.336 ns | 0.0267 ns | 0.0250 ns | 15.332 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net472 | 14.471 ns | 0.0185 ns | 0.0155 ns | 14.470 ns |  1.09 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.572 ns | 0.0276 ns | 0.0258 ns | 19.576 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.2 | 18.583 ns | 0.1732 ns | 0.1621 ns | 18.501 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.005 ns | 0.1270 ns | 0.1188 ns | 17.961 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net461 | 27.533 ns | 0.0434 ns | 0.0406 ns | 27.538 ns |  1.41 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net472 | 29.451 ns | 0.0394 ns | 0.0349 ns | 29.451 ns |  1.50 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Long_Nullable_NoValue | .NET Core 2.0 | 12.719 ns | 0.0138 ns | 0.0129 ns | 12.714 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 2.2 | 11.524 ns | 0.0534 ns | 0.0500 ns | 11.529 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 3.0 | 10.098 ns | 0.0121 ns | 0.0101 ns | 10.101 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net461 | 14.364 ns | 0.0151 ns | 0.0141 ns | 14.371 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net472 | 15.731 ns | 0.0449 ns | 0.0420 ns | 15.721 ns |  1.24 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.015 ns | 0.0248 ns | 0.0232 ns | 15.017 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.257 ns | 0.0196 ns | 0.0183 ns | 13.254 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.748 ns | 0.1827 ns | 0.1709 ns | 14.723 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net461 | 22.618 ns | 0.0472 ns | 0.0442 ns | 22.606 ns |  1.51 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net472 | 24.589 ns | 0.0430 ns | 0.0381 ns | 24.582 ns |  1.64 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_SByte | .NET Core 2.0 | 12.636 ns | 0.0154 ns | 0.0129 ns | 12.638 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 2.2 | 10.416 ns | 0.0135 ns | 0.0113 ns | 10.416 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 3.0 |  9.416 ns | 0.0117 ns | 0.0098 ns |  9.419 ns |  0.75 |    0.00 |      - |     - |     - |         - |
                                            From_SByte |        net461 | 14.092 ns | 0.0269 ns | 0.0252 ns | 14.094 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                            From_SByte |        net472 | 12.693 ns | 0.0126 ns | 0.0106 ns | 12.695 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_SByte_AsObject | .NET Core 2.0 | 20.693 ns | 0.0826 ns | 0.0773 ns | 20.723 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 2.2 | 17.698 ns | 0.0482 ns | 0.0451 ns | 17.705 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 3.0 | 17.884 ns | 0.4283 ns | 0.6279 ns | 17.550 ns |  0.88 |    0.03 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net461 | 27.894 ns | 0.0349 ns | 0.0326 ns | 27.891 ns |  1.35 |    0.01 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net472 | 30.324 ns | 0.0787 ns | 0.0698 ns | 30.330 ns |  1.47 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_SByte_Nullable_WithValue | .NET Core 2.0 | 12.537 ns | 0.0184 ns | 0.0172 ns | 12.537 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 2.2 | 10.829 ns | 0.0131 ns | 0.0109 ns | 10.825 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 3.0 | 10.375 ns | 0.0692 ns | 0.0648 ns | 10.399 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net461 | 14.321 ns | 0.0221 ns | 0.0207 ns | 14.317 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net472 | 12.931 ns | 0.0162 ns | 0.0143 ns | 12.927 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.382 ns | 0.0219 ns | 0.0205 ns | 19.387 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.515 ns | 0.0197 ns | 0.0164 ns | 17.515 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.812 ns | 0.1941 ns | 0.1816 ns | 17.725 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net461 | 28.100 ns | 0.1265 ns | 0.1183 ns | 28.129 ns |  1.45 |    0.01 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net472 | 29.018 ns | 0.0179 ns | 0.0150 ns | 29.016 ns |  1.50 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_SByte_Nullable_NoValue | .NET Core 2.0 | 12.052 ns | 0.0152 ns | 0.0134 ns | 12.052 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 2.2 | 10.388 ns | 0.0317 ns | 0.0265 ns | 10.380 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 3.0 |  9.880 ns | 0.0072 ns | 0.0064 ns |  9.881 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net461 | 13.617 ns | 0.0222 ns | 0.0196 ns | 13.617 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net472 | 12.946 ns | 0.0163 ns | 0.0145 ns | 12.945 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.995 ns | 0.0233 ns | 0.0194 ns | 14.991 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.614 ns | 0.0346 ns | 0.0307 ns | 13.602 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.929 ns | 0.0186 ns | 0.0174 ns | 14.926 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net461 | 26.536 ns | 0.0979 ns | 0.0916 ns | 26.495 ns |  1.77 |    0.01 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net472 | 24.525 ns | 0.0288 ns | 0.0269 ns | 24.526 ns |  1.64 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_Float | .NET Core 2.0 | 12.264 ns | 0.0144 ns | 0.0134 ns | 12.261 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 2.2 | 10.831 ns | 0.0177 ns | 0.0166 ns | 10.826 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 3.0 |  9.939 ns | 0.0185 ns | 0.0154 ns |  9.941 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                                            From_Float |        net461 | 12.931 ns | 0.0168 ns | 0.0157 ns | 12.929 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                            From_Float |        net472 | 12.985 ns | 0.0717 ns | 0.0671 ns | 12.955 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_Float_AsObject | .NET Core 2.0 | 23.695 ns | 0.0231 ns | 0.0204 ns | 23.699 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 2.2 | 26.623 ns | 0.0298 ns | 0.0279 ns | 26.625 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 3.0 | 31.628 ns | 0.1542 ns | 0.1443 ns | 31.666 ns |  1.33 |    0.01 |      - |     - |     - |         - |
                                   From_Float_AsObject |        net461 | 35.095 ns | 0.0428 ns | 0.0357 ns | 35.103 ns |  1.48 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject |        net472 | 38.819 ns | 0.0416 ns | 0.0368 ns | 38.821 ns |  1.64 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Float_Nullable_WithValue | .NET Core 2.0 | 12.216 ns | 0.0652 ns | 0.0610 ns | 12.240 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 2.2 | 10.079 ns | 0.0071 ns | 0.0059 ns | 10.081 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 3.0 |  6.933 ns | 0.0120 ns | 0.0113 ns |  6.936 ns |  0.57 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net461 | 11.852 ns | 0.0449 ns | 0.0420 ns | 11.866 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net472 | 12.890 ns | 0.0145 ns | 0.0136 ns | 12.891 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.0 | 23.674 ns | 0.0326 ns | 0.0289 ns | 23.676 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.2 | 25.266 ns | 0.0563 ns | 0.0527 ns | 25.257 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 3.0 | 31.030 ns | 0.0347 ns | 0.0307 ns | 31.035 ns |  1.31 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net461 | 35.079 ns | 0.0410 ns | 0.0384 ns | 35.071 ns |  1.48 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net472 | 37.415 ns | 0.0454 ns | 0.0424 ns | 37.398 ns |  1.58 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Float_Nullable_NoValue | .NET Core 2.0 | 11.332 ns | 0.0507 ns | 0.0475 ns | 11.359 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 2.2 | 10.130 ns | 0.0406 ns | 0.0360 ns | 10.120 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 3.0 |  6.636 ns | 0.1554 ns | 0.1454 ns |  6.536 ns |  0.59 |    0.01 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net461 | 11.760 ns | 0.0108 ns | 0.0101 ns | 11.763 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net472 | 11.838 ns | 0.0107 ns | 0.0090 ns | 11.838 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.009 ns | 0.0276 ns | 0.0258 ns | 15.007 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.582 ns | 0.0084 ns | 0.0070 ns | 13.583 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 3.0 | 16.563 ns | 0.3533 ns | 0.4716 ns | 16.817 ns |  1.09 |    0.04 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net461 | 22.813 ns | 0.0359 ns | 0.0318 ns | 22.808 ns |  1.52 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net472 | 24.703 ns | 0.0979 ns | 0.0915 ns | 24.740 ns |  1.65 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_String | .NET Core 2.0 | 72.111 ns | 0.0791 ns | 0.0701 ns | 72.117 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 2.2 | 77.672 ns | 0.1002 ns | 0.0938 ns | 77.686 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 3.0 | 60.318 ns | 0.1271 ns | 0.1189 ns | 60.342 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                           From_String |        net461 | 74.596 ns | 0.3874 ns | 0.3624 ns | 74.771 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                           From_String |        net472 | 74.313 ns | 0.0987 ns | 0.0924 ns | 74.311 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_String_AsObject | .NET Core 2.0 | 77.312 ns | 0.0654 ns | 0.0580 ns | 77.315 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 2.2 | 80.452 ns | 0.1335 ns | 0.1184 ns | 80.460 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 3.0 | 62.634 ns | 0.1098 ns | 0.1027 ns | 62.588 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject |        net461 | 85.601 ns | 0.1355 ns | 0.1267 ns | 85.593 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject |        net472 | 87.785 ns | 0.0972 ns | 0.0910 ns | 87.768 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                      From_String_Null | .NET Core 2.0 | 14.292 ns | 0.0093 ns | 0.0078 ns | 14.287 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 2.2 | 18.321 ns | 0.1077 ns | 0.1008 ns | 18.358 ns |  1.28 |    0.01 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 3.0 | 13.872 ns | 0.0178 ns | 0.0166 ns | 13.872 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null |        net461 | 14.995 ns | 0.0210 ns | 0.0197 ns | 14.992 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null |        net472 | 16.410 ns | 0.0449 ns | 0.0420 ns | 16.399 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_String_Null_AsObject | .NET Core 2.0 | 15.032 ns | 0.0164 ns | 0.0146 ns | 15.035 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 2.2 | 13.158 ns | 0.0138 ns | 0.0116 ns | 13.158 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 3.0 | 15.122 ns | 0.0990 ns | 0.0926 ns | 15.160 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net461 | 26.688 ns | 0.1944 ns | 0.1819 ns | 26.770 ns |  1.78 |    0.01 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net472 | 24.522 ns | 0.0603 ns | 0.0534 ns | 24.510 ns |  1.63 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_String_Empty | .NET Core 2.0 | 14.310 ns | 0.0145 ns | 0.0136 ns | 14.308 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 2.2 | 18.425 ns | 0.0288 ns | 0.0255 ns | 18.420 ns |  1.29 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 3.0 | 13.678 ns | 0.0287 ns | 0.0268 ns | 13.668 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty |        net461 | 14.975 ns | 0.0107 ns | 0.0095 ns | 14.976 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty |        net472 | 16.376 ns | 0.0247 ns | 0.0231 ns | 16.377 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_String_Empty_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_UShort | .NET Core 2.0 | 12.069 ns | 0.0165 ns | 0.0154 ns | 12.071 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 2.2 | 10.433 ns | 0.0139 ns | 0.0123 ns | 10.436 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 3.0 |  9.700 ns | 0.0506 ns | 0.0473 ns |  9.724 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                           From_UShort |        net461 | 13.388 ns | 0.0126 ns | 0.0118 ns | 13.388 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                           From_UShort |        net472 | 12.717 ns | 0.0369 ns | 0.0346 ns | 12.709 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_UShort_AsObject | .NET Core 2.0 | 19.512 ns | 0.0663 ns | 0.0588 ns | 19.538 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 2.2 | 17.562 ns | 0.0187 ns | 0.0166 ns | 17.561 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 3.0 | 19.939 ns | 0.0191 ns | 0.0160 ns | 19.941 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net461 | 27.533 ns | 0.0303 ns | 0.0284 ns | 27.527 ns |  1.41 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net472 | 29.201 ns | 0.0314 ns | 0.0294 ns | 29.208 ns |  1.50 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_UShort_Nullable_WithValue | .NET Core 2.0 | 12.284 ns | 0.0145 ns | 0.0128 ns | 12.284 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 2.2 | 10.852 ns | 0.0088 ns | 0.0078 ns | 10.852 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 3.0 | 10.335 ns | 0.0129 ns | 0.0120 ns | 10.332 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net461 | 14.427 ns | 0.1210 ns | 0.1132 ns | 14.483 ns |  1.17 |    0.01 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net472 | 12.911 ns | 0.0117 ns | 0.0098 ns | 12.910 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.980 ns | 0.0159 ns | 0.0141 ns | 19.986 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.2 | 18.027 ns | 0.0196 ns | 0.0183 ns | 18.022 ns |  0.90 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.985 ns | 0.0208 ns | 0.0195 ns | 17.983 ns |  0.90 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net461 | 27.540 ns | 0.0294 ns | 0.0260 ns | 27.537 ns |  1.38 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net472 | 30.454 ns | 0.1177 ns | 0.1101 ns | 30.487 ns |  1.52 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_UShort_Nullable_NoValue | .NET Core 2.0 | 12.297 ns | 0.0094 ns | 0.0088 ns | 12.298 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 2.2 | 10.383 ns | 0.0158 ns | 0.0123 ns | 10.382 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 3.0 |  9.652 ns | 0.0130 ns | 0.0115 ns |  9.653 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net461 | 14.438 ns | 0.0224 ns | 0.0187 ns | 14.440 ns |  1.17 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net472 | 13.591 ns | 0.0225 ns | 0.0199 ns | 13.587 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.003 ns | 0.0178 ns | 0.0158 ns | 15.005 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.590 ns | 0.0261 ns | 0.0218 ns | 14.586 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 3.0 | 15.019 ns | 0.0644 ns | 0.0603 ns | 15.047 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net461 | 22.945 ns | 0.0299 ns | 0.0279 ns | 22.942 ns |  1.53 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net472 | 26.718 ns | 0.0202 ns | 0.0179 ns | 26.719 ns |  1.78 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_UInt | .NET Core 2.0 | 12.835 ns | 0.0301 ns | 0.0267 ns | 12.839 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 2.2 | 10.873 ns | 0.0154 ns | 0.0144 ns | 10.876 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 3.0 |  9.419 ns | 0.0159 ns | 0.0141 ns |  9.421 ns |  0.73 |    0.00 |      - |     - |     - |         - |
                                             From_UInt |        net461 | 13.395 ns | 0.0105 ns | 0.0093 ns | 13.397 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                             From_UInt |        net472 | 12.718 ns | 0.0211 ns | 0.0197 ns | 12.721 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_UInt_AsObject | .NET Core 2.0 | 19.614 ns | 0.0262 ns | 0.0232 ns | 19.612 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 2.2 | 17.527 ns | 0.0209 ns | 0.0175 ns | 17.528 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 3.0 | 19.532 ns | 0.0175 ns | 0.0155 ns | 19.535 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net461 | 31.027 ns | 0.1142 ns | 0.1068 ns | 31.071 ns |  1.58 |    0.01 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net472 | 30.250 ns | 0.0967 ns | 0.0904 ns | 30.259 ns |  1.54 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_UInt_Nullable_WithValue | .NET Core 2.0 | 13.222 ns | 0.0864 ns | 0.0808 ns | 13.230 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 2.2 | 12.454 ns | 0.0115 ns | 0.0096 ns | 12.451 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 3.0 | 10.331 ns | 0.0580 ns | 0.0543 ns | 10.368 ns |  0.78 |    0.01 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net461 | 14.075 ns | 0.0131 ns | 0.0109 ns | 14.079 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net472 | 13.371 ns | 0.0175 ns | 0.0155 ns | 13.372 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.622 ns | 0.0250 ns | 0.0234 ns | 19.618 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.559 ns | 0.0215 ns | 0.0180 ns | 17.557 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.928 ns | 0.0309 ns | 0.0258 ns | 17.923 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net461 | 27.731 ns | 0.1078 ns | 0.1008 ns | 27.725 ns |  1.41 |    0.01 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net472 | 29.406 ns | 0.0438 ns | 0.0388 ns | 29.404 ns |  1.50 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_UInt_Nullable_NoValue | .NET Core 2.0 | 12.301 ns | 0.0118 ns | 0.0105 ns | 12.298 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 2.2 | 10.798 ns | 0.0077 ns | 0.0068 ns | 10.796 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 3.0 | 10.596 ns | 0.2358 ns | 0.3808 ns | 10.751 ns |  0.84 |    0.03 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net461 | 14.201 ns | 0.0134 ns | 0.0104 ns | 14.202 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net472 | 13.636 ns | 0.0260 ns | 0.0243 ns | 13.636 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.120 ns | 0.0265 ns | 0.0247 ns | 15.115 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.271 ns | 0.0337 ns | 0.0282 ns | 13.278 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 3.0 | 15.144 ns | 0.0853 ns | 0.0756 ns | 15.156 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net461 | 22.820 ns | 0.0381 ns | 0.0338 ns | 22.817 ns |  1.51 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net472 | 25.591 ns | 0.0232 ns | 0.0205 ns | 25.592 ns |  1.69 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_ULong | .NET Core 2.0 | 12.505 ns | 0.0142 ns | 0.0133 ns | 12.502 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 2.2 | 10.584 ns | 0.0099 ns | 0.0082 ns | 10.584 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 3.0 |  9.507 ns | 0.0440 ns | 0.0368 ns |  9.498 ns |  0.76 |    0.00 |      - |     - |     - |         - |
                                            From_ULong |        net461 | 13.388 ns | 0.0101 ns | 0.0094 ns | 13.387 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                            From_ULong |        net472 | 12.704 ns | 0.0310 ns | 0.0275 ns | 12.691 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_ULong_AsObject | .NET Core 2.0 | 20.359 ns | 0.0186 ns | 0.0165 ns | 20.361 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 2.2 | 17.533 ns | 0.0178 ns | 0.0167 ns | 17.532 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 3.0 | 18.021 ns | 0.0291 ns | 0.0272 ns | 18.017 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net461 | 28.021 ns | 0.0155 ns | 0.0121 ns | 28.019 ns |  1.38 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net472 | 30.058 ns | 0.0523 ns | 0.0489 ns | 30.042 ns |  1.48 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_ULong_Nullable_WithValue | .NET Core 2.0 | 13.189 ns | 0.0186 ns | 0.0165 ns | 13.189 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 2.2 | 11.751 ns | 0.0155 ns | 0.0138 ns | 11.746 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 3.0 | 10.679 ns | 0.0732 ns | 0.0685 ns | 10.693 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net461 | 15.386 ns | 0.0275 ns | 0.0257 ns | 15.380 ns |  1.17 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net472 | 14.549 ns | 0.0161 ns | 0.0143 ns | 14.550 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.648 ns | 0.0236 ns | 0.0220 ns | 19.646 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.550 ns | 0.0207 ns | 0.0194 ns | 17.555 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 3.0 | 19.616 ns | 0.0150 ns | 0.0140 ns | 19.620 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net461 | 28.143 ns | 0.0524 ns | 0.0490 ns | 28.136 ns |  1.43 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net472 | 30.294 ns | 0.1368 ns | 0.1280 ns | 30.330 ns |  1.54 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_ULong_Nullable_NoValue | .NET Core 2.0 | 12.403 ns | 0.0098 ns | 0.0091 ns | 12.403 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 2.2 | 12.554 ns | 0.1657 ns | 0.1550 ns | 12.542 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 3.0 |  9.903 ns | 0.0312 ns | 0.0277 ns |  9.899 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net461 | 15.052 ns | 0.1177 ns | 0.1101 ns | 15.008 ns |  1.21 |    0.01 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net472 | 13.406 ns | 0.0151 ns | 0.0141 ns | 13.409 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.996 ns | 0.0193 ns | 0.0181 ns | 14.993 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.194 ns | 0.0198 ns | 0.0185 ns | 13.193 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 3.0 | 15.074 ns | 0.0664 ns | 0.0622 ns | 15.080 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net461 | 26.481 ns | 0.0608 ns | 0.0568 ns | 26.456 ns |  1.77 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net472 | 25.523 ns | 0.0886 ns | 0.0829 ns | 25.485 ns |  1.70 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                       From_NullObject | .NET Core 2.0 | 15.160 ns | 0.0114 ns | 0.0107 ns | 15.162 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 2.2 | 13.262 ns | 0.0165 ns | 0.0138 ns | 13.261 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 3.0 | 15.200 ns | 0.3255 ns | 0.6937 ns | 15.460 ns |  0.95 |    0.07 |      - |     - |     - |         - |
                                       From_NullObject |        net461 | 22.882 ns | 0.0532 ns | 0.0498 ns | 22.860 ns |  1.51 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject |        net472 | 25.477 ns | 0.0293 ns | 0.0274 ns | 25.477 ns |  1.68 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_DBNull | .NET Core 2.0 | 13.287 ns | 0.0142 ns | 0.0126 ns | 13.287 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 2.2 | 11.350 ns | 0.0134 ns | 0.0119 ns | 11.352 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 3.0 | 13.002 ns | 0.0560 ns | 0.0524 ns | 12.989 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull |        net461 | 13.124 ns | 0.0128 ns | 0.0113 ns | 13.123 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull |        net472 | 13.836 ns | 0.0160 ns | 0.0149 ns | 13.838 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_DBNull_AsObject | .NET Core 2.0 | 15.044 ns | 0.0679 ns | 0.0635 ns | 15.053 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 2.2 | 13.429 ns | 0.0125 ns | 0.0117 ns | 13.426 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 3.0 | 13.740 ns | 0.2589 ns | 0.2162 ns | 13.713 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net461 | 26.427 ns | 0.0145 ns | 0.0121 ns | 26.424 ns |  1.76 |    0.01 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net472 | 25.761 ns | 0.1168 ns | 0.1092 ns | 25.811 ns |  1.71 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                 From_ConvertibleClass | .NET Core 2.0 | 17.755 ns | 0.0243 ns | 0.0215 ns | 17.761 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 2.2 | 15.229 ns | 0.0123 ns | 0.0109 ns | 15.231 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 3.0 | 15.756 ns | 0.1223 ns | 0.1144 ns | 15.705 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net461 | 25.499 ns | 0.1142 ns | 0.1069 ns | 25.526 ns |  1.44 |    0.01 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net472 | 26.788 ns | 0.0405 ns | 0.0379 ns | 26.800 ns |  1.51 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_ConvertibleClass_AsObject | .NET Core 2.0 | 18.914 ns | 0.0192 ns | 0.0179 ns | 18.906 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 2.2 | 17.307 ns | 0.0245 ns | 0.0229 ns | 17.299 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 3.0 | 17.656 ns | 0.1657 ns | 0.1550 ns | 17.596 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net461 | 26.662 ns | 0.0361 ns | 0.0320 ns | 26.663 ns |  1.41 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net472 | 29.008 ns | 0.0496 ns | 0.0440 ns | 29.014 ns |  1.53 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_ConvertibleClass_NoValue | .NET Core 2.0 | 14.905 ns | 0.0204 ns | 0.0181 ns | 14.904 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 2.2 | 15.103 ns | 0.0391 ns | 0.0366 ns | 15.095 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 3.0 | 14.767 ns | 0.0664 ns | 0.0589 ns | 14.754 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net461 | 22.984 ns | 0.0529 ns | 0.0495 ns | 22.988 ns |  1.54 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net472 | 24.571 ns | 0.0250 ns | 0.0234 ns | 24.572 ns |  1.65 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.0 | 14.983 ns | 0.0202 ns | 0.0169 ns | 14.980 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.2 | 13.187 ns | 0.0150 ns | 0.0140 ns | 13.185 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 3.0 | 13.883 ns | 0.0707 ns | 0.0661 ns | 13.888 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net461 | 22.948 ns | 0.0403 ns | 0.0377 ns | 22.935 ns |  1.53 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net472 | 25.680 ns | 0.0217 ns | 0.0203 ns | 25.684 ns |  1.71 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                              From_NonConvertibleClass | .NET Core 2.0 | 14.080 ns | 0.0157 ns | 0.0139 ns | 14.079 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 2.2 | 12.907 ns | 0.0166 ns | 0.0147 ns | 12.907 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 3.0 | 12.909 ns | 0.0537 ns | 0.0503 ns | 12.904 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net461 | 15.340 ns | 0.0239 ns | 0.0212 ns | 15.341 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net472 | 14.522 ns | 0.0090 ns | 0.0084 ns | 14.524 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                     From_NonConvertibleClass_AsObject | .NET Core 2.0 | 16.829 ns | 0.0218 ns | 0.0204 ns | 16.828 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 2.2 | 15.086 ns | 0.0535 ns | 0.0500 ns | 15.109 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 3.0 | 16.865 ns | 0.0610 ns | 0.0509 ns | 16.858 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net461 | 23.668 ns | 0.0278 ns | 0.0260 ns | 23.669 ns |  1.41 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net472 | 26.483 ns | 0.0245 ns | 0.0205 ns | 26.490 ns |  1.57 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                      From_NonConvertibleClass_NoValue | .NET Core 2.0 | 14.079 ns | 0.0355 ns | 0.0332 ns | 14.068 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 2.2 | 12.906 ns | 0.0146 ns | 0.0122 ns | 12.905 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 3.0 | 13.114 ns | 0.0459 ns | 0.0384 ns | 13.103 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net461 | 14.512 ns | 0.0165 ns | 0.0138 ns | 14.510 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net472 | 14.513 ns | 0.0133 ns | 0.0118 ns | 14.514 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.0 | 15.125 ns | 0.0762 ns | 0.0676 ns | 15.153 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.2 | 13.605 ns | 0.0134 ns | 0.0125 ns | 13.604 ns |  0.90 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 3.0 | 14.001 ns | 0.1850 ns | 0.1730 ns | 13.995 ns |  0.93 |    0.01 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net461 | 22.683 ns | 0.0332 ns | 0.0295 ns | 22.694 ns |  1.50 |    0.01 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net472 | 25.445 ns | 0.0362 ns | 0.0321 ns | 25.450 ns |  1.68 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                From_ConvertibleStruct | .NET Core 2.0 | 20.084 ns | 0.0509 ns | 0.0452 ns | 20.071 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 2.2 | 16.048 ns | 0.0397 ns | 0.0352 ns | 16.049 ns |  0.80 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 3.0 | 14.474 ns | 0.1736 ns | 0.1355 ns | 14.450 ns |  0.72 |    0.01 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net461 | 20.950 ns | 0.0412 ns | 0.0344 ns | 20.946 ns |  1.04 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net472 | 18.784 ns | 0.0363 ns | 0.0339 ns | 18.773 ns |  0.94 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                       From_ConvertibleStruct_AsObject | .NET Core 2.0 | 19.148 ns | 0.0292 ns | 0.0259 ns | 19.145 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 2.2 | 19.218 ns | 0.0210 ns | 0.0164 ns | 19.220 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 3.0 | 19.582 ns | 0.2702 ns | 0.2395 ns | 19.500 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net461 | 27.272 ns | 0.0417 ns | 0.0390 ns | 27.278 ns |  1.42 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net472 | 28.714 ns | 0.1686 ns | 0.1577 ns | 28.657 ns |  1.50 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.0 | 20.299 ns | 0.0244 ns | 0.0217 ns | 20.303 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.2 | 16.441 ns | 0.0350 ns | 0.0327 ns | 16.434 ns |  0.81 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 3.0 | 14.767 ns | 0.1061 ns | 0.0940 ns | 14.724 ns |  0.73 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net461 | 29.100 ns | 0.0309 ns | 0.0289 ns | 29.102 ns |  1.43 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net472 | 27.119 ns | 0.0293 ns | 0.0245 ns | 27.120 ns |  1.34 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.138 ns | 0.0188 ns | 0.0176 ns | 19.135 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 18.116 ns | 0.1395 ns | 0.1305 ns | 18.054 ns |  0.95 |    0.01 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.099 ns | 0.3842 ns | 0.5982 ns | 17.882 ns |  0.96 |    0.04 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net461 | 30.835 ns | 0.2349 ns | 0.1962 ns | 30.929 ns |  1.61 |    0.01 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net472 | 30.166 ns | 0.0331 ns | 0.0294 ns | 30.160 ns |  1.58 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.0 | 13.839 ns | 0.0192 ns | 0.0160 ns | 13.840 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.2 | 11.993 ns | 0.0092 ns | 0.0082 ns | 11.995 ns |  0.87 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 3.0 |  9.974 ns | 0.0492 ns | 0.0460 ns |  9.951 ns |  0.72 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net461 | 22.699 ns | 0.0224 ns | 0.0209 ns | 22.698 ns |  1.64 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net472 | 22.831 ns | 0.0293 ns | 0.0274 ns | 22.827 ns |  1.65 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.978 ns | 0.0096 ns | 0.0075 ns | 14.980 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.133 ns | 0.0120 ns | 0.0100 ns | 13.130 ns |  0.88 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.403 ns | 0.0647 ns | 0.0606 ns | 13.390 ns |  0.89 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net461 | 26.560 ns | 0.0368 ns | 0.0344 ns | 26.563 ns |  1.77 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net472 | 24.690 ns | 0.0417 ns | 0.0390 ns | 24.688 ns |  1.65 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_NonConvertibleStruct | .NET Core 2.0 | 13.475 ns | 0.0211 ns | 0.0187 ns | 13.469 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 2.2 | 11.537 ns | 0.0188 ns | 0.0167 ns | 11.533 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 3.0 |  9.886 ns | 0.0109 ns | 0.0102 ns |  9.883 ns |  0.73 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net461 | 14.497 ns | 0.0244 ns | 0.0216 ns | 14.496 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net472 | 13.222 ns | 0.0976 ns | 0.0913 ns | 13.174 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.0 | 17.007 ns | 0.0406 ns | 0.0380 ns | 17.012 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.2 | 14.971 ns | 0.0152 ns | 0.0143 ns | 14.972 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 3.0 | 16.801 ns | 0.0275 ns | 0.0230 ns | 16.799 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net461 | 27.465 ns | 0.0359 ns | 0.0318 ns | 27.460 ns |  1.61 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net472 | 25.651 ns | 0.0301 ns | 0.0267 ns | 25.642 ns |  1.51 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.0 | 13.369 ns | 0.0164 ns | 0.0137 ns | 13.367 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.2 | 11.676 ns | 0.0139 ns | 0.0124 ns | 11.677 ns |  0.87 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 3.0 |  9.667 ns | 0.0439 ns | 0.0410 ns |  9.644 ns |  0.72 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net461 | 13.152 ns | 0.0085 ns | 0.0071 ns | 13.149 ns |  0.98 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net472 | 12.463 ns | 0.0081 ns | 0.0076 ns | 12.463 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.069 ns | 0.1149 ns | 0.1075 ns | 18.087 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.007 ns | 0.0164 ns | 0.0154 ns | 15.008 ns |  0.83 |    0.01 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 16.793 ns | 0.0635 ns | 0.0594 ns | 16.763 ns |  0.93 |    0.01 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net461 | 27.468 ns | 0.0254 ns | 0.0225 ns | 27.472 ns |  1.52 |    0.01 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net472 | 25.852 ns | 0.0561 ns | 0.0525 ns | 25.865 ns |  1.43 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.0 | 13.148 ns | 0.0162 ns | 0.0152 ns | 13.148 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.2 | 11.535 ns | 0.0117 ns | 0.0109 ns | 11.534 ns |  0.88 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 3.0 | 10.110 ns | 0.0110 ns | 0.0097 ns | 10.107 ns |  0.77 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net461 | 13.271 ns | 0.0213 ns | 0.0189 ns | 13.270 ns |  1.01 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net472 | 12.457 ns | 0.0152 ns | 0.0127 ns | 12.452 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.999 ns | 0.0238 ns | 0.0223 ns | 14.999 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.471 ns | 0.0110 ns | 0.0092 ns | 13.470 ns |  0.90 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 15.284 ns | 0.0216 ns | 0.0180 ns | 15.288 ns |  1.02 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net461 | 22.861 ns | 0.0227 ns | 0.0202 ns | 22.859 ns |  1.52 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net472 | 24.529 ns | 0.0752 ns | 0.0628 ns | 24.516 ns |  1.64 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Enum | .NET Core 2.0 | 13.466 ns | 0.0377 ns | 0.0334 ns | 13.476 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 2.2 | 11.865 ns | 0.0418 ns | 0.0391 ns | 11.879 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 3.0 |  9.445 ns | 0.0103 ns | 0.0091 ns |  9.445 ns |  0.70 |    0.00 |      - |     - |     - |         - |
                                             From_Enum |        net461 | 13.133 ns | 0.0265 ns | 0.0222 ns | 13.130 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                             From_Enum |        net472 | 12.463 ns | 0.0164 ns | 0.0146 ns | 12.461 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Enum_AsObject | .NET Core 2.0 | 49.203 ns | 0.0636 ns | 0.0595 ns | 49.200 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject | .NET Core 2.2 | 44.366 ns | 0.0962 ns | 0.0853 ns | 44.383 ns |  0.90 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject | .NET Core 3.0 | 41.784 ns | 0.1610 ns | 0.1506 ns | 41.707 ns |  0.85 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject |        net461 | 51.505 ns | 0.1780 ns | 0.1578 ns | 51.534 ns |  1.05 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject |        net472 | 53.589 ns | 0.2747 ns | 0.2435 ns | 53.631 ns |  1.09 |    0.01 | 0.0037 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Enum_Nullable_WithValue | .NET Core 2.0 | 13.589 ns | 0.0093 ns | 0.0083 ns | 13.588 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 2.2 | 11.625 ns | 0.0112 ns | 0.0105 ns | 11.625 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 3.0 | 10.480 ns | 0.2217 ns | 0.2074 ns | 10.419 ns |  0.77 |    0.02 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net461 | 14.045 ns | 0.0191 ns | 0.0169 ns | 14.044 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net472 | 13.355 ns | 0.1753 ns | 0.1639 ns | 13.332 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.0 | 48.683 ns | 0.0711 ns | 0.0631 ns | 48.673 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.2 | 42.252 ns | 0.0944 ns | 0.0737 ns | 42.249 ns |  0.87 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 3.0 | 43.517 ns | 0.2498 ns | 0.2336 ns | 43.491 ns |  0.89 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject |        net461 | 51.282 ns | 0.0565 ns | 0.0501 ns | 51.267 ns |  1.05 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject |        net472 | 52.097 ns | 0.2395 ns | 0.2241 ns | 52.059 ns |  1.07 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Enum_Nullable_NoValue | .NET Core 2.0 | 13.381 ns | 0.0207 ns | 0.0184 ns | 13.381 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 2.2 | 10.369 ns | 0.0177 ns | 0.0157 ns | 10.365 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 3.0 |  9.933 ns | 0.0286 ns | 0.0254 ns |  9.941 ns |  0.74 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net461 | 13.660 ns | 0.0238 ns | 0.0223 ns | 13.661 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net472 | 13.393 ns | 0.0436 ns | 0.0408 ns | 13.401 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.156 ns | 0.0172 ns | 0.0161 ns | 15.156 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.934 ns | 0.0167 ns | 0.0156 ns | 13.928 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.459 ns | 0.1028 ns | 0.0802 ns | 13.438 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net461 | 26.444 ns | 0.0421 ns | 0.0394 ns | 26.434 ns |  1.74 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net472 | 24.652 ns | 0.1067 ns | 0.0998 ns | 24.619 ns |  1.63 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                      From_ParentClass | .NET Core 2.0 | 14.072 ns | 0.0207 ns | 0.0184 ns | 14.071 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 2.2 | 12.922 ns | 0.0232 ns | 0.0217 ns | 12.915 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 3.0 | 12.725 ns | 0.0942 ns | 0.0881 ns | 12.718 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                                      From_ParentClass |        net461 | 15.332 ns | 0.0189 ns | 0.0158 ns | 15.336 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass |        net472 | 14.668 ns | 0.1573 ns | 0.1472 ns | 14.581 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_ParentClass_AsObject | .NET Core 2.0 | 17.264 ns | 0.0292 ns | 0.0273 ns | 17.248 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 2.2 | 16.608 ns | 0.0234 ns | 0.0219 ns | 16.606 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 3.0 | 18.082 ns | 0.2628 ns | 0.2330 ns | 17.967 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net461 | 24.875 ns | 0.0287 ns | 0.0268 ns | 24.875 ns |  1.44 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net472 | 27.221 ns | 0.2651 ns | 0.2480 ns | 27.131 ns |  1.58 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                              From_ParentClass_NoValue | .NET Core 2.0 | 14.067 ns | 0.0149 ns | 0.0139 ns | 14.067 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 2.2 | 12.902 ns | 0.0205 ns | 0.0171 ns | 12.901 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 3.0 | 13.209 ns | 0.1033 ns | 0.0967 ns | 13.167 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net461 | 14.513 ns | 0.0192 ns | 0.0180 ns | 14.510 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net472 | 14.780 ns | 0.1869 ns | 0.1749 ns | 14.721 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.0 | 15.002 ns | 0.0264 ns | 0.0247 ns | 15.008 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.2 | 13.364 ns | 0.0102 ns | 0.0080 ns | 13.365 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 3.0 | 14.617 ns | 0.3129 ns | 0.4586 ns | 14.369 ns |  0.99 |    0.04 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net461 | 22.791 ns | 0.0282 ns | 0.0264 ns | 22.792 ns |  1.52 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net472 | 25.337 ns | 0.0803 ns | 0.0751 ns | 25.312 ns |  1.69 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_ParentStruct | .NET Core 2.0 | 42.649 ns | 0.0454 ns | 0.0425 ns | 42.653 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 2.2 | 41.228 ns | 0.1200 ns | 0.1122 ns | 41.244 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 3.0 | 39.648 ns | 0.0862 ns | 0.0720 ns | 39.650 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct |        net461 | 42.417 ns | 0.0661 ns | 0.0618 ns | 42.401 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct |        net472 | 41.126 ns | 0.4627 ns | 0.4328 ns | 40.891 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_ParentStruct_AsObject | .NET Core 2.0 | 17.305 ns | 0.0210 ns | 0.0196 ns | 17.300 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 2.2 | 15.500 ns | 0.0771 ns | 0.0721 ns | 15.470 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 3.0 | 17.058 ns | 0.0982 ns | 0.0919 ns | 17.020 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net461 | 24.231 ns | 0.0337 ns | 0.0315 ns | 24.231 ns |  1.40 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net472 | 27.785 ns | 0.0673 ns | 0.0597 ns | 27.775 ns |  1.61 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.0 | 43.181 ns | 0.0285 ns | 0.0267 ns | 43.188 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.2 | 40.304 ns | 0.0419 ns | 0.0392 ns | 40.310 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 3.0 | 40.732 ns | 0.8248 ns | 1.5081 ns | 41.241 ns |  0.92 |    0.05 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue |        net461 | 42.787 ns | 0.0450 ns | 0.0399 ns | 42.795 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue |        net472 | 41.013 ns | 0.2124 ns | 0.1883 ns | 40.965 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 17.298 ns | 0.0222 ns | 0.0208 ns | 17.298 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.487 ns | 0.0135 ns | 0.0126 ns | 15.489 ns |  0.90 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 16.119 ns | 0.3451 ns | 0.3836 ns | 16.125 ns |  0.93 |    0.02 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net461 | 24.621 ns | 0.0298 ns | 0.0279 ns | 24.614 ns |  1.42 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net472 | 25.762 ns | 0.0835 ns | 0.0781 ns | 25.739 ns |  1.49 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.0 | 42.443 ns | 0.0314 ns | 0.0279 ns | 42.442 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.2 | 40.634 ns | 0.0292 ns | 0.0244 ns | 40.637 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 3.0 | 39.883 ns | 0.2331 ns | 0.1947 ns | 39.865 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net461 | 41.439 ns | 0.1089 ns | 0.1019 ns | 41.400 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net472 | 46.810 ns | 0.3382 ns | 0.3164 ns | 46.726 ns |  1.10 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.977 ns | 0.0194 ns | 0.0172 ns | 14.981 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.133 ns | 0.0112 ns | 0.0099 ns | 13.132 ns |  0.88 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 15.183 ns | 0.2097 ns | 0.1859 ns | 15.166 ns |  1.01 |    0.01 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net461 | 22.955 ns | 0.0413 ns | 0.0387 ns | 22.951 ns |  1.53 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net472 | 24.522 ns | 0.0374 ns | 0.0292 ns | 24.511 ns |  1.64 |    0.00 |      - |     - |     - |         - |

Benchmarks with issues:
  ConvertTo_FloatNullable.From_Char_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_FloatNullable.From_Char_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_FloatNullable.From_Char_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_FloatNullable.From_Char_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_FloatNullable.From_Char_AsObject: Job-ZVTGBZ(Toolchain=net472)
  ConvertTo_FloatNullable.From_Char_Nullable_WithValue_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_FloatNullable.From_Char_Nullable_WithValue_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_FloatNullable.From_Char_Nullable_WithValue_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_FloatNullable.From_Char_Nullable_WithValue_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_FloatNullable.From_Char_Nullable_WithValue_AsObject: Job-ZVTGBZ(Toolchain=net472)
  ConvertTo_FloatNullable.From_DateTime_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_FloatNullable.From_DateTime_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_FloatNullable.From_DateTime_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_FloatNullable.From_DateTime_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_FloatNullable.From_DateTime_AsObject: Job-ZVTGBZ(Toolchain=net472)
  ConvertTo_FloatNullable.From_DateTime_Nullable_WithValue_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_FloatNullable.From_DateTime_Nullable_WithValue_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_FloatNullable.From_DateTime_Nullable_WithValue_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_FloatNullable.From_DateTime_Nullable_WithValue_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_FloatNullable.From_DateTime_Nullable_WithValue_AsObject: Job-ZVTGBZ(Toolchain=net472)
  ConvertTo_FloatNullable.From_String_Empty_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_FloatNullable.From_String_Empty_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_FloatNullable.From_String_Empty_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_FloatNullable.From_String_Empty_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_FloatNullable.From_String_Empty_AsObject: Job-ZVTGBZ(Toolchain=net472)
