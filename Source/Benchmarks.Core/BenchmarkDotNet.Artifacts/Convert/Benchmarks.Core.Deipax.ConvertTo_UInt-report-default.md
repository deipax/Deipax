
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
                                             From_Bool | .NET Core 2.0 | 12.954 ns | 0.0095 ns | 0.0084 ns | 12.954 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 2.2 | 10.166 ns | 0.0127 ns | 0.0106 ns | 10.166 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 3.0 |  7.074 ns | 0.0076 ns | 0.0067 ns |  7.073 ns |  0.55 |    0.00 |      - |     - |     - |         - |
                                             From_Bool |        net461 | 11.967 ns | 0.0558 ns | 0.0495 ns | 11.946 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                             From_Bool |        net472 | 12.068 ns | 0.0188 ns | 0.0147 ns | 12.069 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Bool_AsObject | .NET Core 2.0 | 18.300 ns | 0.0346 ns | 0.0323 ns | 18.303 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 2.2 | 15.030 ns | 0.0337 ns | 0.0316 ns | 15.038 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 3.0 | 15.558 ns | 0.0407 ns | 0.0380 ns | 15.562 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net461 | 18.644 ns | 0.0227 ns | 0.0189 ns | 18.649 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net472 | 20.634 ns | 0.0304 ns | 0.0284 ns | 20.634 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Bool_Nullable_WithValue | .NET Core 2.0 | 11.896 ns | 0.0116 ns | 0.0108 ns | 11.896 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 2.2 | 10.375 ns | 0.0696 ns | 0.0651 ns | 10.338 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 3.0 |  7.264 ns | 0.0098 ns | 0.0087 ns |  7.266 ns |  0.61 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net461 | 13.416 ns | 0.0238 ns | 0.0211 ns | 13.416 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net472 | 10.634 ns | 0.0180 ns | 0.0160 ns | 10.632 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.0 | 17.989 ns | 0.0265 ns | 0.0235 ns | 17.995 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.026 ns | 0.0184 ns | 0.0172 ns | 15.022 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.775 ns | 0.1356 ns | 0.1269 ns | 15.818 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net461 | 18.844 ns | 0.0292 ns | 0.0273 ns | 18.850 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net472 | 20.522 ns | 0.0650 ns | 0.0576 ns | 20.521 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Bool_Nullable_NoValue | .NET Core 2.0 | 11.673 ns | 0.0096 ns | 0.0075 ns | 11.673 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 2.2 |  9.966 ns | 0.0130 ns | 0.0121 ns |  9.965 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 3.0 |  6.616 ns | 0.0093 ns | 0.0087 ns |  6.614 ns |  0.57 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net461 | 12.531 ns | 0.0049 ns | 0.0038 ns | 12.532 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net472 | 10.248 ns | 0.0125 ns | 0.0104 ns | 10.247 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.063 ns | 0.0177 ns | 0.0157 ns | 14.062 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.860 ns | 0.0187 ns | 0.0165 ns | 11.858 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.206 ns | 0.0359 ns | 0.0336 ns | 14.198 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net461 | 13.297 ns | 0.0483 ns | 0.0452 ns | 13.296 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net472 | 14.957 ns | 0.0147 ns | 0.0130 ns | 14.959 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Byte | .NET Core 2.0 | 11.601 ns | 0.0130 ns | 0.0108 ns | 11.603 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 2.2 |  9.942 ns | 0.0120 ns | 0.0112 ns |  9.940 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 3.0 |  8.126 ns | 0.1875 ns | 0.4457 ns |  8.261 ns |  0.65 |    0.07 |      - |     - |     - |         - |
                                             From_Byte |        net461 | 11.696 ns | 0.0139 ns | 0.0116 ns | 11.695 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                             From_Byte |        net472 | 10.352 ns | 0.0164 ns | 0.0153 ns | 10.354 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Byte_AsObject | .NET Core 2.0 | 18.409 ns | 0.0320 ns | 0.0284 ns | 18.400 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 2.2 | 14.548 ns | 0.0113 ns | 0.0100 ns | 14.550 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 3.0 | 15.075 ns | 0.0405 ns | 0.0359 ns | 15.066 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net461 | 18.933 ns | 0.0410 ns | 0.0363 ns | 18.933 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net472 | 20.046 ns | 0.0252 ns | 0.0210 ns | 20.051 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Byte_Nullable_WithValue | .NET Core 2.0 | 11.773 ns | 0.0101 ns | 0.0094 ns | 11.769 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 2.2 | 10.198 ns | 0.0098 ns | 0.0081 ns | 10.200 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 3.0 |  7.269 ns | 0.0061 ns | 0.0057 ns |  7.267 ns |  0.62 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net461 | 13.048 ns | 0.0859 ns | 0.0803 ns | 13.034 ns |  1.11 |    0.01 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net472 | 10.563 ns | 0.0442 ns | 0.0369 ns | 10.573 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.443 ns | 0.0424 ns | 0.0376 ns | 18.459 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.2 | 14.764 ns | 0.0205 ns | 0.0160 ns | 14.760 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.017 ns | 0.0311 ns | 0.0291 ns | 15.014 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net461 | 21.080 ns | 0.0394 ns | 0.0329 ns | 21.077 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net472 | 20.090 ns | 0.0282 ns | 0.0263 ns | 20.081 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Byte_Nullable_NoValue | .NET Core 2.0 | 11.673 ns | 0.0114 ns | 0.0101 ns | 11.674 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 2.2 |  9.999 ns | 0.0613 ns | 0.0574 ns |  9.966 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 3.0 |  7.086 ns | 0.2393 ns | 0.2457 ns |  6.952 ns |  0.61 |    0.02 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net461 | 12.528 ns | 0.0202 ns | 0.0189 ns | 12.528 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net472 | 11.673 ns | 0.0160 ns | 0.0133 ns | 11.672 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.070 ns | 0.0432 ns | 0.0404 ns | 15.078 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.651 ns | 0.0098 ns | 0.0092 ns | 12.651 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.929 ns | 0.0123 ns | 0.0109 ns | 11.931 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net461 | 13.238 ns | 0.0543 ns | 0.0508 ns | 13.218 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net472 | 15.813 ns | 0.0277 ns | 0.0259 ns | 15.811 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Char | .NET Core 2.0 | 11.504 ns | 0.0191 ns | 0.0169 ns | 11.501 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Char | .NET Core 2.2 |  9.958 ns | 0.0128 ns | 0.0113 ns |  9.956 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                             From_Char | .NET Core 3.0 |  6.698 ns | 0.0111 ns | 0.0087 ns |  6.696 ns |  0.58 |    0.00 |      - |     - |     - |         - |
                                             From_Char |        net461 | 11.738 ns | 0.0731 ns | 0.0684 ns | 11.700 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                                             From_Char |        net472 | 11.764 ns | 0.0144 ns | 0.0135 ns | 11.763 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Char_AsObject | .NET Core 2.0 | 18.470 ns | 0.2531 ns | 0.2367 ns | 18.350 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 2.2 | 15.452 ns | 0.0188 ns | 0.0167 ns | 15.455 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 3.0 | 15.977 ns | 0.0501 ns | 0.0469 ns | 15.971 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                                    From_Char_AsObject |        net461 | 20.821 ns | 0.1122 ns | 0.0994 ns | 20.851 ns |  1.13 |    0.02 |      - |     - |     - |         - |
                                    From_Char_AsObject |        net472 | 19.984 ns | 0.0222 ns | 0.0197 ns | 19.976 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Char_Nullable_WithValue | .NET Core 2.0 | 11.794 ns | 0.0261 ns | 0.0231 ns | 11.796 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 2.2 | 10.199 ns | 0.0178 ns | 0.0167 ns | 10.201 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 3.0 |  7.293 ns | 0.0321 ns | 0.0300 ns |  7.299 ns |  0.62 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net461 | 12.306 ns | 0.0289 ns | 0.0271 ns | 12.309 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net472 | 12.130 ns | 0.0171 ns | 0.0160 ns | 12.127 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.673 ns | 0.0174 ns | 0.0154 ns | 18.674 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.454 ns | 0.0128 ns | 0.0107 ns | 15.457 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.736 ns | 0.0493 ns | 0.0461 ns | 17.745 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net461 | 18.291 ns | 0.0326 ns | 0.0305 ns | 18.290 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net472 | 20.501 ns | 0.0814 ns | 0.0761 ns | 20.518 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Char_Nullable_NoValue | .NET Core 2.0 | 11.776 ns | 0.0108 ns | 0.0090 ns | 11.777 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 2.2 | 11.487 ns | 0.0135 ns | 0.0112 ns | 11.488 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 3.0 |  6.664 ns | 0.0276 ns | 0.0230 ns |  6.656 ns |  0.57 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net461 | 12.593 ns | 0.0830 ns | 0.0777 ns | 12.594 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net472 | 11.685 ns | 0.0143 ns | 0.0134 ns | 11.686 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.063 ns | 0.0192 ns | 0.0179 ns | 14.060 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.866 ns | 0.0173 ns | 0.0162 ns | 11.865 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.360 ns | 0.2692 ns | 0.4854 ns | 12.205 ns |  0.86 |    0.03 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net461 | 15.797 ns | 0.0187 ns | 0.0175 ns | 15.797 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net472 | 14.902 ns | 0.0191 ns | 0.0179 ns | 14.896 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                         From_DateTime | .NET Core 2.0 | 11.814 ns | 0.0129 ns | 0.0120 ns | 11.813 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 2.2 | 11.351 ns | 0.0137 ns | 0.0128 ns | 11.351 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 3.0 |  8.200 ns | 0.0643 ns | 0.0602 ns |  8.170 ns |  0.69 |    0.01 |      - |     - |     - |         - |
                                         From_DateTime |        net461 | 13.373 ns | 0.0552 ns | 0.0516 ns | 13.349 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime |        net472 | 11.898 ns | 0.0171 ns | 0.0151 ns | 11.897 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                From_DateTime_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                      From_DateTime_Nullable_WithValue | .NET Core 2.0 | 12.464 ns | 0.0131 ns | 0.0122 ns | 12.462 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 2.2 | 11.125 ns | 0.0469 ns | 0.0416 ns | 11.139 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 3.0 |  8.556 ns | 0.0786 ns | 0.0735 ns |  8.582 ns |  0.69 |    0.01 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net461 | 13.294 ns | 0.0400 ns | 0.0375 ns | 13.274 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net472 | 13.437 ns | 0.0467 ns | 0.0437 ns | 13.431 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_DateTime_Nullable_NoValue | .NET Core 2.0 | 12.488 ns | 0.0211 ns | 0.0198 ns | 12.487 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 2.2 | 11.028 ns | 0.0164 ns | 0.0153 ns | 11.029 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 3.0 |  8.497 ns | 0.0747 ns | 0.0698 ns |  8.449 ns |  0.68 |    0.01 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net461 | 13.268 ns | 0.0147 ns | 0.0131 ns | 13.265 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net472 | 13.296 ns | 0.0122 ns | 0.0114 ns | 13.294 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.214 ns | 0.0514 ns | 0.0456 ns | 14.224 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.508 ns | 0.0180 ns | 0.0160 ns | 13.514 ns |  0.95 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.952 ns | 0.0199 ns | 0.0186 ns | 11.953 ns |  0.84 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net461 | 13.283 ns | 0.0211 ns | 0.0198 ns | 13.287 ns |  0.93 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net472 | 15.847 ns | 0.0275 ns | 0.0257 ns | 15.848 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                          From_Decimal | .NET Core 2.0 | 22.026 ns | 0.0424 ns | 0.0397 ns | 22.021 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 2.2 | 19.764 ns | 0.0221 ns | 0.0207 ns | 19.763 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 3.0 | 13.035 ns | 0.0983 ns | 0.0920 ns | 13.068 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal |        net461 | 23.094 ns | 0.0426 ns | 0.0355 ns | 23.095 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal |        net472 | 21.470 ns | 0.0151 ns | 0.0126 ns | 21.470 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                 From_Decimal_AsObject | .NET Core 2.0 | 26.350 ns | 0.0269 ns | 0.0238 ns | 26.343 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 2.2 | 26.273 ns | 0.0214 ns | 0.0190 ns | 26.269 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 3.0 | 19.268 ns | 0.2563 ns | 0.2272 ns | 19.137 ns |  0.73 |    0.01 |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net461 | 28.177 ns | 0.1715 ns | 0.1604 ns | 28.302 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net472 | 27.357 ns | 0.0302 ns | 0.0267 ns | 27.358 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                       From_Decimal_Nullable_WithValue | .NET Core 2.0 | 22.838 ns | 0.0237 ns | 0.0221 ns | 22.838 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 2.2 | 20.901 ns | 0.0255 ns | 0.0238 ns | 20.897 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 3.0 | 15.950 ns | 0.2541 ns | 0.2377 ns | 16.060 ns |  0.70 |    0.01 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net461 | 24.199 ns | 0.0339 ns | 0.0301 ns | 24.195 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net472 | 24.356 ns | 0.0550 ns | 0.0515 ns | 24.343 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.0 | 26.929 ns | 0.0315 ns | 0.0294 ns | 26.919 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.2 | 24.592 ns | 0.0222 ns | 0.0207 ns | 24.598 ns |  0.91 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 3.0 | 20.524 ns | 0.4337 ns | 0.4994 ns | 20.165 ns |  0.76 |    0.02 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net461 | 26.294 ns | 0.0362 ns | 0.0321 ns | 26.293 ns |  0.98 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net472 | 27.821 ns | 0.0584 ns | 0.0518 ns | 27.827 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Decimal_Nullable_NoValue | .NET Core 2.0 | 12.619 ns | 0.0496 ns | 0.0464 ns | 12.624 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 2.2 | 11.396 ns | 0.0105 ns | 0.0088 ns | 11.392 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 3.0 |  7.998 ns | 0.0516 ns | 0.0483 ns |  8.011 ns |  0.63 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net461 | 14.187 ns | 0.0142 ns | 0.0126 ns | 14.190 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net472 | 14.336 ns | 0.0178 ns | 0.0166 ns | 14.338 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.380 ns | 0.0193 ns | 0.0180 ns | 14.380 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.884 ns | 0.0229 ns | 0.0203 ns | 11.876 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.351 ns | 0.0283 ns | 0.0265 ns | 14.347 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net461 | 13.213 ns | 0.0492 ns | 0.0436 ns | 13.199 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net472 | 15.041 ns | 0.0165 ns | 0.0146 ns | 15.039 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_Double | .NET Core 2.0 | 12.164 ns | 0.0135 ns | 0.0120 ns | 12.163 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 2.2 | 10.885 ns | 0.0284 ns | 0.0266 ns | 10.883 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 3.0 |  9.360 ns | 0.5694 ns | 0.9032 ns |  8.833 ns |  0.82 |    0.09 |      - |     - |     - |         - |
                                           From_Double |        net461 | 13.693 ns | 0.0315 ns | 0.0279 ns | 13.695 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                           From_Double |        net472 | 11.470 ns | 0.0154 ns | 0.0144 ns | 11.468 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_Double_AsObject | .NET Core 2.0 | 18.783 ns | 0.0338 ns | 0.0317 ns | 18.777 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 2.2 | 18.632 ns | 0.0141 ns | 0.0125 ns | 18.632 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 3.0 | 18.823 ns | 0.0694 ns | 0.0615 ns | 18.800 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject |        net461 | 20.172 ns | 0.0256 ns | 0.0240 ns | 20.168 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject |        net472 | 21.185 ns | 0.0405 ns | 0.0379 ns | 21.179 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_Double_Nullable_WithValue | .NET Core 2.0 | 13.761 ns | 0.0101 ns | 0.0084 ns | 13.761 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 2.2 | 12.972 ns | 0.0645 ns | 0.0603 ns | 12.991 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 3.0 | 12.415 ns | 0.2682 ns | 0.4768 ns | 12.569 ns |  0.88 |    0.05 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net461 | 16.454 ns | 0.0596 ns | 0.0557 ns | 16.466 ns |  1.20 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net472 | 14.428 ns | 0.0861 ns | 0.0805 ns | 14.475 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.421 ns | 0.0347 ns | 0.0308 ns | 19.418 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.405 ns | 0.0203 ns | 0.0180 ns | 17.405 ns |  0.90 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 3.0 | 16.862 ns | 0.1370 ns | 0.1282 ns | 16.923 ns |  0.87 |    0.01 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net461 | 22.065 ns | 0.0303 ns | 0.0283 ns | 22.058 ns |  1.14 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net472 | 21.776 ns | 0.0468 ns | 0.0437 ns | 21.775 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Double_Nullable_NoValue | .NET Core 2.0 | 12.615 ns | 0.0104 ns | 0.0097 ns | 12.613 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 2.2 | 11.376 ns | 0.0140 ns | 0.0131 ns | 11.374 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 3.0 |  8.151 ns | 0.0339 ns | 0.0317 ns |  8.143 ns |  0.65 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net461 | 15.383 ns | 0.0346 ns | 0.0307 ns | 15.385 ns |  1.22 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net472 | 12.677 ns | 0.0183 ns | 0.0171 ns | 12.679 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.040 ns | 0.0195 ns | 0.0173 ns | 14.041 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.497 ns | 0.0170 ns | 0.0159 ns | 13.493 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.458 ns | 0.2751 ns | 0.3378 ns | 12.640 ns |  0.88 |    0.03 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net461 | 15.856 ns | 0.0193 ns | 0.0171 ns | 15.855 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net472 | 14.916 ns | 0.0146 ns | 0.0137 ns | 14.918 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_Short | .NET Core 2.0 | 11.626 ns | 0.0279 ns | 0.0261 ns | 11.615 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 2.2 | 10.225 ns | 0.0442 ns | 0.0369 ns | 10.236 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 3.0 |  6.707 ns | 0.1574 ns | 0.1933 ns |  6.847 ns |  0.57 |    0.02 |      - |     - |     - |         - |
                                            From_Short |        net461 | 13.149 ns | 0.0320 ns | 0.0284 ns | 13.148 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                            From_Short |        net472 | 10.865 ns | 0.0223 ns | 0.0198 ns | 10.862 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_Short_AsObject | .NET Core 2.0 | 20.356 ns | 0.0167 ns | 0.0156 ns | 20.356 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 2.2 | 15.329 ns | 0.0151 ns | 0.0134 ns | 15.325 ns |  0.75 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 3.0 | 17.461 ns | 0.0580 ns | 0.0484 ns | 17.452 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net461 | 19.466 ns | 0.0175 ns | 0.0155 ns | 19.468 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net472 | 20.802 ns | 0.0220 ns | 0.0195 ns | 20.799 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Short_Nullable_WithValue | .NET Core 2.0 | 11.912 ns | 0.0318 ns | 0.0282 ns | 11.910 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 2.2 | 10.289 ns | 0.0085 ns | 0.0080 ns | 10.292 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 3.0 |  7.101 ns | 0.0520 ns | 0.0486 ns |  7.090 ns |  0.60 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net461 | 14.208 ns | 0.0439 ns | 0.0367 ns | 14.208 ns |  1.19 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net472 | 13.288 ns | 0.0110 ns | 0.0102 ns | 13.285 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.080 ns | 0.0456 ns | 0.0405 ns | 18.070 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.2 | 14.769 ns | 0.0174 ns | 0.0145 ns | 14.774 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.633 ns | 0.1622 ns | 0.1517 ns | 17.674 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net461 | 19.505 ns | 0.0214 ns | 0.0200 ns | 19.499 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net472 | 21.415 ns | 0.0236 ns | 0.0221 ns | 21.420 ns |  1.18 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Short_Nullable_NoValue | .NET Core 2.0 | 11.643 ns | 0.0088 ns | 0.0074 ns | 11.641 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 2.2 | 10.044 ns | 0.0149 ns | 0.0139 ns | 10.045 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 3.0 |  7.119 ns | 0.0696 ns | 0.0582 ns |  7.100 ns |  0.61 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net461 | 11.837 ns | 0.0098 ns | 0.0087 ns | 11.837 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net472 | 10.344 ns | 0.0110 ns | 0.0092 ns | 10.342 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.072 ns | 0.0123 ns | 0.0109 ns | 14.072 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.952 ns | 0.0123 ns | 0.0109 ns | 11.951 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.861 ns | 0.1490 ns | 0.1321 ns | 14.856 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net461 | 13.214 ns | 0.0205 ns | 0.0192 ns | 13.212 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net472 | 14.932 ns | 0.0190 ns | 0.0168 ns | 14.936 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                              From_Int | .NET Core 2.0 | 11.568 ns | 0.0145 ns | 0.0113 ns | 11.571 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 2.2 | 10.171 ns | 0.0160 ns | 0.0125 ns | 10.171 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 3.0 |  6.947 ns | 0.1457 ns | 0.1363 ns |  7.018 ns |  0.60 |    0.01 |      - |     - |     - |         - |
                                              From_Int |        net461 | 12.373 ns | 0.0996 ns | 0.0931 ns | 12.407 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                                              From_Int |        net472 | 10.892 ns | 0.0335 ns | 0.0297 ns | 10.904 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_Int_AsObject | .NET Core 2.0 | 18.380 ns | 0.0301 ns | 0.0282 ns | 18.368 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 2.2 | 14.992 ns | 0.0200 ns | 0.0167 ns | 14.991 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 3.0 | 15.587 ns | 0.2991 ns | 0.2798 ns | 15.642 ns |  0.85 |    0.02 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net461 | 19.473 ns | 0.0726 ns | 0.0644 ns | 19.455 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net472 | 20.794 ns | 0.0163 ns | 0.0144 ns | 20.791 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Int_Nullable_WithValue | .NET Core 2.0 | 12.927 ns | 0.0374 ns | 0.0350 ns | 12.931 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 2.2 | 10.385 ns | 0.0135 ns | 0.0113 ns | 10.383 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 3.0 |  6.929 ns | 0.0831 ns | 0.0736 ns |  6.892 ns |  0.54 |    0.01 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net461 | 13.148 ns | 0.0448 ns | 0.0419 ns | 13.136 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net472 | 11.962 ns | 0.0105 ns | 0.0098 ns | 11.965 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.372 ns | 0.0335 ns | 0.0314 ns | 18.372 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.535 ns | 0.0110 ns | 0.0103 ns | 15.535 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.578 ns | 0.1972 ns | 0.1748 ns | 17.505 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net461 | 21.801 ns | 0.0194 ns | 0.0182 ns | 21.806 ns |  1.19 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net472 | 20.538 ns | 0.0144 ns | 0.0120 ns | 20.539 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_Int_Nullable_NoValue | .NET Core 2.0 | 11.629 ns | 0.0114 ns | 0.0095 ns | 11.630 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 2.2 | 10.063 ns | 0.0139 ns | 0.0108 ns | 10.060 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 3.0 |  7.268 ns | 0.0504 ns | 0.0421 ns |  7.275 ns |  0.63 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net461 | 11.872 ns | 0.0177 ns | 0.0147 ns | 11.873 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net472 | 10.280 ns | 0.0218 ns | 0.0204 ns | 10.277 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.963 ns | 0.0222 ns | 0.0208 ns | 14.965 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.932 ns | 0.0363 ns | 0.0339 ns | 11.949 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.243 ns | 0.1132 ns | 0.1059 ns | 12.273 ns |  0.82 |    0.01 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net461 | 13.301 ns | 0.0223 ns | 0.0209 ns | 13.299 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net472 | 15.228 ns | 0.0955 ns | 0.0847 ns | 15.196 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Long | .NET Core 2.0 | 11.970 ns | 0.0136 ns | 0.0127 ns | 11.970 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Long | .NET Core 2.2 | 10.439 ns | 0.0122 ns | 0.0114 ns | 10.438 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                             From_Long | .NET Core 3.0 |  7.378 ns | 0.0281 ns | 0.0263 ns |  7.381 ns |  0.62 |    0.00 |      - |     - |     - |         - |
                                             From_Long |        net461 | 13.066 ns | 0.0229 ns | 0.0203 ns | 13.064 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                             From_Long |        net472 | 10.943 ns | 0.0128 ns | 0.0113 ns | 10.941 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Long_AsObject | .NET Core 2.0 | 18.978 ns | 0.0503 ns | 0.0471 ns | 18.987 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 2.2 | 15.704 ns | 0.0228 ns | 0.0178 ns | 15.699 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 3.0 | 18.288 ns | 0.0713 ns | 0.0667 ns | 18.287 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net461 | 19.225 ns | 0.0256 ns | 0.0227 ns | 19.222 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net472 | 20.523 ns | 0.0238 ns | 0.0211 ns | 20.529 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Long_Nullable_WithValue | .NET Core 2.0 | 13.430 ns | 0.0183 ns | 0.0162 ns | 13.426 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 2.2 | 12.615 ns | 0.0130 ns | 0.0121 ns | 12.615 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 3.0 | 10.501 ns | 0.2326 ns | 0.2176 ns | 10.437 ns |  0.78 |    0.02 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net461 | 14.568 ns | 0.0324 ns | 0.0303 ns | 14.568 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net472 | 14.499 ns | 0.0261 ns | 0.0218 ns | 14.493 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.760 ns | 0.2450 ns | 0.2292 ns | 18.795 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.707 ns | 0.0125 ns | 0.0117 ns | 15.705 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.751 ns | 0.0606 ns | 0.0473 ns | 15.757 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net461 | 19.434 ns | 0.0348 ns | 0.0308 ns | 19.428 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net472 | 20.801 ns | 0.0267 ns | 0.0250 ns | 20.801 ns |  1.11 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Long_Nullable_NoValue | .NET Core 2.0 | 12.527 ns | 0.0471 ns | 0.0417 ns | 12.544 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 2.2 | 11.424 ns | 0.0542 ns | 0.0507 ns | 11.436 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 3.0 |  8.361 ns | 0.1863 ns | 0.1993 ns |  8.269 ns |  0.67 |    0.02 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net461 | 13.495 ns | 0.0177 ns | 0.0157 ns | 13.496 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net472 | 12.603 ns | 0.0139 ns | 0.0116 ns | 12.600 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.324 ns | 0.0239 ns | 0.0200 ns | 15.328 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.531 ns | 0.0103 ns | 0.0096 ns | 13.534 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.427 ns | 0.0271 ns | 0.0254 ns | 13.427 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net461 | 15.909 ns | 0.0866 ns | 0.0810 ns | 15.925 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net472 | 15.924 ns | 0.1026 ns | 0.0960 ns | 15.983 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_SByte | .NET Core 2.0 | 11.621 ns | 0.0117 ns | 0.0104 ns | 11.622 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 2.2 | 10.273 ns | 0.0323 ns | 0.0286 ns | 10.282 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 3.0 |  6.768 ns | 0.0140 ns | 0.0124 ns |  6.765 ns |  0.58 |    0.00 |      - |     - |     - |         - |
                                            From_SByte |        net461 | 13.019 ns | 0.0666 ns | 0.0623 ns | 13.006 ns |  1.12 |    0.01 |      - |     - |     - |         - |
                                            From_SByte |        net472 | 10.975 ns | 0.0208 ns | 0.0195 ns | 10.971 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_SByte_AsObject | .NET Core 2.0 | 18.107 ns | 0.0343 ns | 0.0321 ns | 18.095 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 2.2 | 14.861 ns | 0.0196 ns | 0.0173 ns | 14.861 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 3.0 | 17.571 ns | 0.0333 ns | 0.0311 ns | 17.570 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net461 | 21.747 ns | 0.0157 ns | 0.0139 ns | 21.749 ns |  1.20 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net472 | 20.745 ns | 0.0302 ns | 0.0283 ns | 20.738 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_SByte_Nullable_WithValue | .NET Core 2.0 | 11.913 ns | 0.0184 ns | 0.0172 ns | 11.915 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 2.2 | 10.876 ns | 0.2397 ns | 0.2664 ns | 10.823 ns |  0.92 |    0.02 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 3.0 |  7.332 ns | 0.0593 ns | 0.0554 ns |  7.303 ns |  0.62 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net461 | 14.064 ns | 0.0412 ns | 0.0344 ns | 14.063 ns |  1.18 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net472 | 13.180 ns | 0.0405 ns | 0.0378 ns | 13.187 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.803 ns | 0.0344 ns | 0.0287 ns | 18.804 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.064 ns | 0.0162 ns | 0.0151 ns | 15.066 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 3.0 | 16.248 ns | 0.3497 ns | 0.4669 ns | 16.304 ns |  0.85 |    0.02 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net461 | 21.688 ns | 0.0316 ns | 0.0280 ns | 21.697 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net472 | 21.382 ns | 0.0370 ns | 0.0328 ns | 21.377 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_SByte_Nullable_NoValue | .NET Core 2.0 | 11.648 ns | 0.0159 ns | 0.0148 ns | 11.648 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 2.2 | 10.057 ns | 0.0118 ns | 0.0104 ns | 10.055 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 3.0 |  6.817 ns | 0.1163 ns | 0.0971 ns |  6.824 ns |  0.59 |    0.01 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net461 | 12.561 ns | 0.0601 ns | 0.0562 ns | 12.563 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net472 | 11.682 ns | 0.0145 ns | 0.0114 ns | 11.680 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.040 ns | 0.0096 ns | 0.0085 ns | 14.041 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.964 ns | 0.0520 ns | 0.0486 ns | 11.984 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.171 ns | 0.1903 ns | 0.1780 ns | 12.100 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net461 | 13.270 ns | 0.0604 ns | 0.0565 ns | 13.238 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net472 | 15.225 ns | 0.0187 ns | 0.0175 ns | 15.232 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_Float | .NET Core 2.0 | 12.174 ns | 0.0075 ns | 0.0063 ns | 12.175 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 2.2 | 10.943 ns | 0.0401 ns | 0.0375 ns | 10.957 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 3.0 |  8.735 ns | 0.0188 ns | 0.0167 ns |  8.735 ns |  0.72 |    0.00 |      - |     - |     - |         - |
                                            From_Float |        net461 | 13.410 ns | 0.0595 ns | 0.0557 ns | 13.387 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                            From_Float |        net472 | 12.927 ns | 0.0200 ns | 0.0188 ns | 12.929 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_Float_AsObject | .NET Core 2.0 | 19.379 ns | 0.0467 ns | 0.0437 ns | 19.386 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 2.2 | 15.905 ns | 0.0393 ns | 0.0348 ns | 15.888 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 3.0 | 17.012 ns | 0.1253 ns | 0.1046 ns | 17.015 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                                   From_Float_AsObject |        net461 | 20.694 ns | 0.0409 ns | 0.0382 ns | 20.690 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject |        net472 | 22.099 ns | 0.0987 ns | 0.0924 ns | 22.120 ns |  1.14 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Float_Nullable_WithValue | .NET Core 2.0 | 12.676 ns | 0.0327 ns | 0.0306 ns | 12.675 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 2.2 | 11.831 ns | 0.0190 ns | 0.0169 ns | 11.833 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 3.0 |  9.326 ns | 0.1958 ns | 0.1736 ns |  9.283 ns |  0.74 |    0.01 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net461 | 14.912 ns | 0.0294 ns | 0.0275 ns | 14.909 ns |  1.18 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net472 | 12.451 ns | 0.0198 ns | 0.0175 ns | 12.451 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.783 ns | 0.0525 ns | 0.0438 ns | 18.781 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.2 | 16.094 ns | 0.0254 ns | 0.0238 ns | 16.095 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.902 ns | 0.1236 ns | 0.1156 ns | 18.855 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net461 | 20.601 ns | 0.0277 ns | 0.0259 ns | 20.593 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net472 | 21.894 ns | 0.0188 ns | 0.0175 ns | 21.892 ns |  1.17 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Float_Nullable_NoValue | .NET Core 2.0 | 11.702 ns | 0.0407 ns | 0.0381 ns | 11.686 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 2.2 | 10.006 ns | 0.0093 ns | 0.0082 ns | 10.005 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 3.0 |  6.683 ns | 0.0521 ns | 0.0487 ns |  6.658 ns |  0.57 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net461 | 12.108 ns | 0.0487 ns | 0.0432 ns | 12.125 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net472 | 11.763 ns | 0.0140 ns | 0.0124 ns | 11.761 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.088 ns | 0.0234 ns | 0.0207 ns | 14.086 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.664 ns | 0.0531 ns | 0.0496 ns | 12.641 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.983 ns | 0.0638 ns | 0.0566 ns | 11.960 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net461 | 13.219 ns | 0.0194 ns | 0.0172 ns | 13.212 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net472 | 15.830 ns | 0.0250 ns | 0.0234 ns | 15.823 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_String | .NET Core 2.0 | 57.220 ns | 0.0871 ns | 0.0727 ns | 57.199 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 2.2 | 49.816 ns | 0.0846 ns | 0.0706 ns | 49.794 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 3.0 | 20.042 ns | 0.0982 ns | 0.0919 ns | 20.068 ns |  0.35 |    0.00 |      - |     - |     - |         - |
                                           From_String |        net461 | 58.515 ns | 0.0949 ns | 0.0887 ns | 58.497 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                           From_String |        net472 | 60.199 ns | 0.3414 ns | 0.3194 ns | 60.047 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_String_AsObject | .NET Core 2.0 | 63.119 ns | 0.1596 ns | 0.1333 ns | 63.128 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 2.2 | 56.767 ns | 0.3319 ns | 0.3105 ns | 56.948 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 3.0 | 26.936 ns | 0.2618 ns | 0.2449 ns | 26.929 ns |  0.43 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject |        net461 | 62.730 ns | 0.1266 ns | 0.1122 ns | 62.750 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject |        net472 | 64.412 ns | 0.1125 ns | 0.0997 ns | 64.409 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                      From_String_Null | .NET Core 2.0 | 13.567 ns | 0.0195 ns | 0.0163 ns | 13.566 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 2.2 | 11.386 ns | 0.0136 ns | 0.0114 ns | 11.386 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 3.0 | 11.880 ns | 0.1116 ns | 0.1044 ns | 11.939 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                                      From_String_Null |        net461 | 13.584 ns | 0.0547 ns | 0.0512 ns | 13.577 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null |        net472 | 14.425 ns | 0.0170 ns | 0.0159 ns | 14.424 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_String_Null_AsObject | .NET Core 2.0 | 14.953 ns | 0.0192 ns | 0.0170 ns | 14.952 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 2.2 | 13.522 ns | 0.0176 ns | 0.0164 ns | 13.517 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 3.0 | 12.127 ns | 0.2724 ns | 0.3243 ns | 11.925 ns |  0.82 |    0.02 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net461 | 15.798 ns | 0.0113 ns | 0.0094 ns | 15.795 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net472 | 16.029 ns | 0.0146 ns | 0.0129 ns | 16.027 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_String_Empty | .NET Core 2.0 | 12.833 ns | 0.0145 ns | 0.0135 ns | 12.831 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 2.2 | 11.387 ns | 0.0118 ns | 0.0111 ns | 11.386 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 3.0 | 11.584 ns | 0.0182 ns | 0.0142 ns | 11.582 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty |        net461 | 12.730 ns | 0.0383 ns | 0.0339 ns | 12.733 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty |        net472 | 15.171 ns | 0.0194 ns | 0.0162 ns | 15.174 ns |  1.18 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_String_Empty_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_UShort | .NET Core 2.0 | 11.502 ns | 0.0102 ns | 0.0085 ns | 11.502 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 2.2 | 10.018 ns | 0.0258 ns | 0.0229 ns | 10.022 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 3.0 |  6.855 ns | 0.0206 ns | 0.0161 ns |  6.853 ns |  0.60 |    0.00 |      - |     - |     - |         - |
                                           From_UShort |        net461 | 11.819 ns | 0.0361 ns | 0.0338 ns | 11.825 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                           From_UShort |        net472 | 10.335 ns | 0.0147 ns | 0.0130 ns | 10.337 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_UShort_AsObject | .NET Core 2.0 | 18.019 ns | 0.0848 ns | 0.0793 ns | 18.043 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 2.2 | 15.962 ns | 0.0236 ns | 0.0209 ns | 15.964 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 3.0 | 15.614 ns | 0.2079 ns | 0.1945 ns | 15.588 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net461 | 18.878 ns | 0.0790 ns | 0.0700 ns | 18.905 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net472 | 20.069 ns | 0.0301 ns | 0.0267 ns | 20.068 ns |  1.11 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_UShort_Nullable_WithValue | .NET Core 2.0 | 11.800 ns | 0.0195 ns | 0.0172 ns | 11.796 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 2.2 | 10.209 ns | 0.0161 ns | 0.0151 ns | 10.208 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 3.0 |  6.906 ns | 0.0214 ns | 0.0179 ns |  6.899 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net461 | 12.151 ns | 0.0378 ns | 0.0353 ns | 12.136 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net472 | 12.948 ns | 0.2120 ns | 0.1983 ns | 13.035 ns |  1.10 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.083 ns | 0.0329 ns | 0.0308 ns | 18.070 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.2 | 14.762 ns | 0.0088 ns | 0.0074 ns | 14.762 ns |  0.82 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.065 ns | 0.0548 ns | 0.0513 ns | 15.050 ns |  0.83 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net461 | 19.178 ns | 0.0615 ns | 0.0575 ns | 19.186 ns |  1.06 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net472 | 21.298 ns | 0.1073 ns | 0.1004 ns | 21.322 ns |  1.18 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_UShort_Nullable_NoValue | .NET Core 2.0 | 11.661 ns | 0.0114 ns | 0.0089 ns | 11.661 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 2.2 | 10.003 ns | 0.0174 ns | 0.0162 ns | 10.000 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 3.0 |  7.027 ns | 0.3734 ns | 0.5474 ns |  6.750 ns |  0.64 |    0.06 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net461 | 12.549 ns | 0.0282 ns | 0.0250 ns | 12.544 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net472 | 10.244 ns | 0.0155 ns | 0.0137 ns | 10.243 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.069 ns | 0.0174 ns | 0.0163 ns | 14.069 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.846 ns | 0.0103 ns | 0.0097 ns | 11.847 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.369 ns | 0.4143 ns | 0.5531 ns | 12.123 ns |  0.89 |    0.05 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net461 | 13.301 ns | 0.0223 ns | 0.0198 ns | 13.303 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net472 | 14.897 ns | 0.0215 ns | 0.0179 ns | 14.903 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_UInt | .NET Core 2.0 | 11.602 ns | 0.0152 ns | 0.0127 ns | 11.600 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 2.2 |  9.983 ns | 0.0278 ns | 0.0246 ns |  9.974 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 3.0 |  6.457 ns | 0.0775 ns | 0.0725 ns |  6.417 ns |  0.56 |    0.01 |      - |     - |     - |         - |
                                             From_UInt |        net461 | 11.700 ns | 0.0187 ns | 0.0166 ns | 11.701 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                             From_UInt |        net472 | 11.817 ns | 0.0185 ns | 0.0164 ns | 11.818 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_UInt_AsObject | .NET Core 2.0 | 14.798 ns | 0.0249 ns | 0.0208 ns | 14.791 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 2.2 | 12.479 ns | 0.0139 ns | 0.0123 ns | 12.477 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 3.0 | 15.135 ns | 0.0191 ns | 0.0179 ns | 15.133 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net461 | 14.345 ns | 0.0183 ns | 0.0171 ns | 14.349 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net472 | 15.717 ns | 0.0387 ns | 0.0362 ns | 15.713 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_UInt_Nullable_WithValue | .NET Core 2.0 | 11.772 ns | 0.0137 ns | 0.0121 ns | 11.772 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 2.2 | 10.206 ns | 0.0120 ns | 0.0093 ns | 10.205 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 3.0 |  6.917 ns | 0.0629 ns | 0.0588 ns |  6.942 ns |  0.59 |    0.01 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net461 | 12.352 ns | 0.0098 ns | 0.0092 ns | 12.356 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net472 | 12.179 ns | 0.0870 ns | 0.0814 ns | 12.230 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.0 | 17.528 ns | 0.0130 ns | 0.0102 ns | 17.525 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.2 | 12.515 ns | 0.0153 ns | 0.0143 ns | 12.516 ns |  0.71 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 3.0 | 14.134 ns | 0.3101 ns | 0.4245 ns | 14.021 ns |  0.82 |    0.03 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net461 | 14.289 ns | 0.0342 ns | 0.0320 ns | 14.284 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net472 | 15.695 ns | 0.0214 ns | 0.0189 ns | 15.692 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_UInt_Nullable_NoValue | .NET Core 2.0 | 11.638 ns | 0.0110 ns | 0.0092 ns | 11.637 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 2.2 | 11.479 ns | 0.0083 ns | 0.0073 ns | 11.479 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 3.0 |  6.712 ns | 0.0497 ns | 0.0415 ns |  6.726 ns |  0.58 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net461 | 10.366 ns | 0.0121 ns | 0.0113 ns | 10.363 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net472 | 10.265 ns | 0.0121 ns | 0.0095 ns | 10.266 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.298 ns | 0.0134 ns | 0.0119 ns | 15.299 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.868 ns | 0.0118 ns | 0.0098 ns | 12.866 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 3.0 | 15.240 ns | 0.0361 ns | 0.0320 ns | 15.227 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net461 | 15.795 ns | 0.0184 ns | 0.0163 ns | 15.795 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net472 | 15.296 ns | 0.0193 ns | 0.0181 ns | 15.298 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_ULong | .NET Core 2.0 | 11.735 ns | 0.0120 ns | 0.0100 ns | 11.738 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 2.2 | 10.241 ns | 0.0628 ns | 0.0588 ns | 10.274 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 3.0 |  6.892 ns | 0.0432 ns | 0.0404 ns |  6.872 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                                            From_ULong |        net461 | 12.306 ns | 0.0672 ns | 0.0629 ns | 12.276 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                                            From_ULong |        net472 | 12.450 ns | 0.0087 ns | 0.0081 ns | 12.451 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_ULong_AsObject | .NET Core 2.0 | 18.992 ns | 0.0315 ns | 0.0263 ns | 18.993 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 2.2 | 15.005 ns | 0.0956 ns | 0.0895 ns | 15.039 ns |  0.79 |    0.01 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 3.0 | 17.581 ns | 0.0766 ns | 0.0679 ns | 17.563 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net461 | 19.409 ns | 0.0183 ns | 0.0162 ns | 19.410 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net472 | 20.513 ns | 0.0370 ns | 0.0309 ns | 20.513 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_ULong_Nullable_WithValue | .NET Core 2.0 | 14.911 ns | 0.0228 ns | 0.0202 ns | 14.914 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 2.2 | 11.607 ns | 0.0128 ns | 0.0114 ns | 11.609 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 3.0 |  8.313 ns | 0.0101 ns | 0.0090 ns |  8.313 ns |  0.56 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net461 | 15.197 ns | 0.0232 ns | 0.0194 ns | 15.195 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net472 | 13.904 ns | 0.0432 ns | 0.0404 ns | 13.905 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.387 ns | 0.0477 ns | 0.0423 ns | 18.378 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.920 ns | 0.0153 ns | 0.0143 ns | 15.919 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 3.0 | 14.834 ns | 0.0728 ns | 0.0681 ns | 14.806 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net461 | 19.314 ns | 0.0320 ns | 0.0284 ns | 19.310 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net472 | 20.502 ns | 0.0186 ns | 0.0156 ns | 20.497 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_ULong_Nullable_NoValue | .NET Core 2.0 | 12.417 ns | 0.0235 ns | 0.0219 ns | 12.407 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 2.2 | 12.346 ns | 0.0098 ns | 0.0087 ns | 12.346 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 3.0 |  8.051 ns | 0.0431 ns | 0.0403 ns |  8.029 ns |  0.65 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net461 | 13.856 ns | 0.0450 ns | 0.0399 ns | 13.847 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net472 | 12.666 ns | 0.0075 ns | 0.0067 ns | 12.664 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.945 ns | 0.0248 ns | 0.0207 ns | 14.942 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.860 ns | 0.0146 ns | 0.0137 ns | 11.856 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.620 ns | 0.2000 ns | 0.1670 ns | 12.576 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net461 | 13.955 ns | 0.0130 ns | 0.0115 ns | 13.954 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net472 | 14.894 ns | 0.0177 ns | 0.0166 ns | 14.898 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                       From_NullObject | .NET Core 2.0 | 14.936 ns | 0.0209 ns | 0.0195 ns | 14.936 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 2.2 | 11.950 ns | 0.0670 ns | 0.0627 ns | 11.976 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 3.0 | 13.514 ns | 0.0747 ns | 0.0624 ns | 13.509 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject |        net461 | 13.258 ns | 0.0178 ns | 0.0167 ns | 13.263 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject |        net472 | 15.314 ns | 0.1116 ns | 0.1044 ns | 15.320 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_DBNull | .NET Core 2.0 | 11.414 ns | 0.0232 ns | 0.0217 ns | 11.406 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 2.2 |  9.015 ns | 0.0107 ns | 0.0095 ns |  9.014 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 3.0 | 11.694 ns | 0.2283 ns | 0.2135 ns | 11.668 ns |  1.02 |    0.02 |      - |     - |     - |         - |
                                           From_DBNull |        net461 | 11.045 ns | 0.0192 ns | 0.0179 ns | 11.046 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull |        net472 | 11.221 ns | 0.0161 ns | 0.0135 ns | 11.223 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_DBNull_AsObject | .NET Core 2.0 | 14.049 ns | 0.0160 ns | 0.0150 ns | 14.047 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 2.2 | 11.873 ns | 0.0176 ns | 0.0165 ns | 11.874 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 3.0 | 11.903 ns | 0.2560 ns | 0.3329 ns | 11.997 ns |  0.84 |    0.03 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net461 | 13.255 ns | 0.0449 ns | 0.0420 ns | 13.240 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net472 | 14.889 ns | 0.0281 ns | 0.0263 ns | 14.886 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                 From_ConvertibleClass | .NET Core 2.0 | 14.931 ns | 0.0255 ns | 0.0226 ns | 14.926 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 2.2 | 13.397 ns | 0.0143 ns | 0.0127 ns | 13.399 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 3.0 | 13.026 ns | 0.1156 ns | 0.0902 ns | 13.014 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net461 | 16.676 ns | 0.0405 ns | 0.0359 ns | 16.678 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net472 | 16.837 ns | 0.0870 ns | 0.0814 ns | 16.830 ns |  1.13 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_ConvertibleClass_AsObject | .NET Core 2.0 | 17.507 ns | 0.0547 ns | 0.0457 ns | 17.511 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 2.2 | 14.131 ns | 0.0104 ns | 0.0097 ns | 14.130 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 3.0 | 18.297 ns | 0.5600 ns | 1.5886 ns | 17.819 ns |  1.05 |    0.09 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net461 | 16.580 ns | 0.0326 ns | 0.0305 ns | 16.570 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net472 | 18.589 ns | 0.0351 ns | 0.0311 ns | 18.595 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_ConvertibleClass_NoValue | .NET Core 2.0 | 15.000 ns | 0.0152 ns | 0.0135 ns | 14.997 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 2.2 | 12.520 ns | 0.0263 ns | 0.0246 ns | 12.516 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 3.0 | 13.256 ns | 0.1188 ns | 0.0928 ns | 13.253 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net461 | 14.044 ns | 0.0113 ns | 0.0106 ns | 14.041 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net472 | 13.078 ns | 0.0240 ns | 0.0213 ns | 13.079 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.0 | 14.186 ns | 0.0211 ns | 0.0187 ns | 14.181 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.2 | 12.530 ns | 0.0161 ns | 0.0134 ns | 12.526 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 3.0 | 14.412 ns | 0.1179 ns | 0.1103 ns | 14.467 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net461 | 13.302 ns | 0.0338 ns | 0.0282 ns | 13.293 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net472 | 15.735 ns | 0.0197 ns | 0.0184 ns | 15.735 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                              From_NonConvertibleClass | .NET Core 2.0 | 11.910 ns | 0.0134 ns | 0.0119 ns | 11.910 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 2.2 | 11.113 ns | 0.0103 ns | 0.0096 ns | 11.112 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 3.0 | 10.763 ns | 0.1211 ns | 0.1133 ns | 10.690 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net461 | 12.292 ns | 0.0201 ns | 0.0188 ns | 12.282 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net472 | 12.525 ns | 0.0113 ns | 0.0094 ns | 12.524 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                     From_NonConvertibleClass_AsObject | .NET Core 2.0 | 15.922 ns | 0.0142 ns | 0.0132 ns | 15.923 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 2.2 | 13.267 ns | 0.0133 ns | 0.0111 ns | 13.264 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 3.0 | 15.142 ns | 0.1334 ns | 0.1182 ns | 15.098 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net461 | 15.068 ns | 0.0354 ns | 0.0313 ns | 15.065 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net472 | 16.726 ns | 0.0135 ns | 0.0127 ns | 16.726 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                      From_NonConvertibleClass_NoValue | .NET Core 2.0 | 11.782 ns | 0.0102 ns | 0.0085 ns | 11.783 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 2.2 | 11.420 ns | 0.0094 ns | 0.0083 ns | 11.419 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 3.0 | 11.781 ns | 0.2572 ns | 0.4637 ns | 11.958 ns |  0.97 |    0.06 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net461 | 12.614 ns | 0.0345 ns | 0.0306 ns | 12.618 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net472 | 12.707 ns | 0.0109 ns | 0.0102 ns | 12.704 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.0 | 14.064 ns | 0.0143 ns | 0.0126 ns | 14.062 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.2 | 11.864 ns | 0.0161 ns | 0.0151 ns | 11.867 ns |  0.84 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 3.0 | 11.978 ns | 0.1016 ns | 0.0950 ns | 11.915 ns |  0.85 |    0.01 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net461 | 13.183 ns | 0.0367 ns | 0.0343 ns | 13.174 ns |  0.94 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net472 | 15.057 ns | 0.0158 ns | 0.0132 ns | 15.052 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                From_ConvertibleStruct | .NET Core 2.0 | 19.408 ns | 0.0493 ns | 0.0437 ns | 19.397 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 2.2 | 15.835 ns | 0.0398 ns | 0.0332 ns | 15.842 ns |  0.82 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 3.0 | 11.428 ns | 0.0403 ns | 0.0377 ns | 11.437 ns |  0.59 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net461 | 18.510 ns | 0.0751 ns | 0.0702 ns | 18.484 ns |  0.95 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net472 | 17.134 ns | 0.0427 ns | 0.0400 ns | 17.120 ns |  0.88 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                       From_ConvertibleStruct_AsObject | .NET Core 2.0 | 17.125 ns | 0.0762 ns | 0.0713 ns | 17.131 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 2.2 | 14.425 ns | 0.0185 ns | 0.0164 ns | 14.423 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 3.0 | 17.334 ns | 0.0300 ns | 0.0266 ns | 17.330 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net461 | 17.461 ns | 0.0230 ns | 0.0204 ns | 17.462 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net472 | 19.321 ns | 0.0309 ns | 0.0289 ns | 19.324 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.0 | 19.214 ns | 0.0557 ns | 0.0494 ns | 19.205 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.2 | 15.989 ns | 0.0505 ns | 0.0473 ns | 15.987 ns |  0.83 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 3.0 | 12.344 ns | 0.0444 ns | 0.0394 ns | 12.336 ns |  0.64 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net461 | 19.917 ns | 0.0416 ns | 0.0348 ns | 19.922 ns |  1.04 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net472 | 19.552 ns | 0.0823 ns | 0.0770 ns | 19.580 ns |  1.02 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 16.916 ns | 0.0261 ns | 0.0244 ns | 16.908 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 16.066 ns | 0.0216 ns | 0.0181 ns | 16.068 ns |  0.95 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.255 ns | 0.0795 ns | 0.0744 ns | 15.272 ns |  0.90 |    0.01 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net461 | 17.439 ns | 0.0270 ns | 0.0239 ns | 17.437 ns |  1.03 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net472 | 19.977 ns | 0.0236 ns | 0.0221 ns | 19.981 ns |  1.18 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.0 | 13.130 ns | 0.0109 ns | 0.0091 ns | 13.131 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.2 | 11.587 ns | 0.0088 ns | 0.0078 ns | 11.586 ns |  0.88 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 3.0 |  7.446 ns | 0.0187 ns | 0.0175 ns |  7.452 ns |  0.57 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net461 | 11.963 ns | 0.0152 ns | 0.0127 ns | 11.965 ns |  0.91 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net472 | 10.486 ns | 0.0203 ns | 0.0190 ns | 10.485 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.722 ns | 0.0171 ns | 0.0160 ns | 14.722 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.867 ns | 0.0126 ns | 0.0112 ns | 11.869 ns |  0.81 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.222 ns | 0.1058 ns | 0.0938 ns | 12.231 ns |  0.83 |    0.01 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net461 | 13.849 ns | 0.0391 ns | 0.0366 ns | 13.850 ns |  0.94 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net472 | 15.869 ns | 0.0210 ns | 0.0196 ns | 15.869 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_NonConvertibleStruct | .NET Core 2.0 | 12.933 ns | 0.0122 ns | 0.0114 ns | 12.934 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 2.2 | 11.452 ns | 0.0139 ns | 0.0130 ns | 11.455 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 3.0 |  6.579 ns | 0.0072 ns | 0.0064 ns |  6.580 ns |  0.51 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net461 | 11.785 ns | 0.0136 ns | 0.0114 ns | 11.783 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net472 | 10.317 ns | 0.0092 ns | 0.0077 ns | 10.317 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.0 | 15.767 ns | 0.0233 ns | 0.0218 ns | 15.761 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.2 | 13.358 ns | 0.0490 ns | 0.0458 ns | 13.375 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 3.0 | 13.973 ns | 0.2106 ns | 0.1970 ns | 13.927 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net461 | 14.958 ns | 0.0388 ns | 0.0344 ns | 14.949 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net472 | 17.429 ns | 0.0524 ns | 0.0490 ns | 17.424 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.0 | 13.048 ns | 0.0332 ns | 0.0311 ns | 13.059 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.2 | 10.028 ns | 0.0204 ns | 0.0190 ns | 10.022 ns |  0.77 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 3.0 |  6.775 ns | 0.0098 ns | 0.0087 ns |  6.774 ns |  0.52 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net461 | 12.499 ns | 0.0227 ns | 0.0213 ns | 12.491 ns |  0.96 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net472 | 10.293 ns | 0.0136 ns | 0.0121 ns | 10.293 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 15.803 ns | 0.0270 ns | 0.0253 ns | 15.802 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 14.041 ns | 0.0157 ns | 0.0139 ns | 14.038 ns |  0.89 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.720 ns | 0.0806 ns | 0.0715 ns | 15.695 ns |  0.99 |    0.01 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net461 | 15.051 ns | 0.0992 ns | 0.0928 ns | 15.000 ns |  0.95 |    0.01 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net472 | 17.288 ns | 0.0205 ns | 0.0191 ns | 17.287 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.0 | 12.835 ns | 0.0104 ns | 0.0081 ns | 12.837 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.2 | 11.342 ns | 0.0099 ns | 0.0077 ns | 11.343 ns |  0.88 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 3.0 |  6.486 ns | 0.0529 ns | 0.0495 ns |  6.481 ns |  0.51 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net461 | 11.819 ns | 0.0110 ns | 0.0103 ns | 11.820 ns |  0.92 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net472 | 10.373 ns | 0.0093 ns | 0.0082 ns | 10.372 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.042 ns | 0.0138 ns | 0.0115 ns | 14.043 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.112 ns | 0.0121 ns | 0.0107 ns | 12.111 ns |  0.86 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 15.089 ns | 0.0814 ns | 0.0762 ns | 15.112 ns |  1.07 |    0.01 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net461 | 13.265 ns | 0.1302 ns | 0.1217 ns | 13.190 ns |  0.94 |    0.01 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net472 | 15.052 ns | 0.0774 ns | 0.0724 ns | 15.026 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Enum | .NET Core 2.0 | 13.060 ns | 0.0181 ns | 0.0169 ns | 13.062 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 2.2 | 10.253 ns | 0.0165 ns | 0.0138 ns | 10.251 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 3.0 |  6.601 ns | 0.0132 ns | 0.0123 ns |  6.601 ns |  0.51 |    0.00 |      - |     - |     - |         - |
                                             From_Enum |        net461 | 12.255 ns | 0.0467 ns | 0.0437 ns | 12.230 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                             From_Enum |        net472 | 10.713 ns | 0.0132 ns | 0.0117 ns | 10.715 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Enum_AsObject | .NET Core 2.0 | 50.968 ns | 0.1323 ns | 0.1238 ns | 50.967 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject | .NET Core 2.2 | 44.154 ns | 0.0512 ns | 0.0454 ns | 44.162 ns |  0.87 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject | .NET Core 3.0 | 34.482 ns | 0.1021 ns | 0.0955 ns | 34.474 ns |  0.68 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject |        net461 | 46.932 ns | 0.1754 ns | 0.1555 ns | 46.940 ns |  0.92 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject |        net472 | 47.339 ns | 0.1015 ns | 0.0949 ns | 47.336 ns |  0.93 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Enum_Nullable_WithValue | .NET Core 2.0 | 16.542 ns | 0.0112 ns | 0.0100 ns | 16.544 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 2.2 | 12.397 ns | 0.0602 ns | 0.0563 ns | 12.419 ns |  0.75 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 3.0 |  6.984 ns | 0.0112 ns | 0.0104 ns |  6.980 ns |  0.42 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net461 | 13.770 ns | 0.0240 ns | 0.0200 ns | 13.770 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net472 | 12.065 ns | 0.0174 ns | 0.0154 ns | 12.068 ns |  0.73 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.0 | 44.793 ns | 0.1933 ns | 0.1808 ns | 44.716 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.2 | 38.810 ns | 0.0827 ns | 0.0691 ns | 38.796 ns |  0.87 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 3.0 | 33.552 ns | 0.6947 ns | 1.3713 ns | 32.852 ns |  0.78 |    0.03 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject |        net461 | 43.556 ns | 0.1414 ns | 0.1180 ns | 43.563 ns |  0.97 |    0.01 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject |        net472 | 46.806 ns | 0.0775 ns | 0.0725 ns | 46.780 ns |  1.04 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Enum_Nullable_NoValue | .NET Core 2.0 | 13.672 ns | 0.0178 ns | 0.0166 ns | 13.674 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 2.2 | 10.545 ns | 0.0123 ns | 0.0115 ns | 10.544 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 3.0 |  6.568 ns | 0.0162 ns | 0.0143 ns |  6.568 ns |  0.48 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net461 | 12.507 ns | 0.0130 ns | 0.0121 ns | 12.503 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net472 | 10.396 ns | 0.0091 ns | 0.0085 ns | 10.394 ns |  0.76 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.979 ns | 0.0170 ns | 0.0151 ns | 14.977 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.847 ns | 0.0110 ns | 0.0103 ns | 11.850 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.236 ns | 0.4837 ns | 0.4967 ns | 11.995 ns |  0.82 |    0.04 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net461 | 13.303 ns | 0.0565 ns | 0.0528 ns | 13.279 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net472 | 15.524 ns | 0.0151 ns | 0.0134 ns | 15.526 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                      From_ParentClass | .NET Core 2.0 | 12.219 ns | 0.0483 ns | 0.0452 ns | 12.242 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 2.2 | 11.987 ns | 0.0066 ns | 0.0051 ns | 11.986 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 3.0 | 11.417 ns | 0.2697 ns | 0.3210 ns | 11.248 ns |  0.94 |    0.03 |      - |     - |     - |         - |
                                      From_ParentClass |        net461 | 12.478 ns | 0.0252 ns | 0.0223 ns | 12.483 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass |        net472 | 12.584 ns | 0.0263 ns | 0.0246 ns | 12.586 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_ParentClass_AsObject | .NET Core 2.0 | 15.428 ns | 0.0139 ns | 0.0130 ns | 15.428 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 2.2 | 15.394 ns | 0.0466 ns | 0.0436 ns | 15.394 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 3.0 | 13.162 ns | 0.0684 ns | 0.0606 ns | 13.187 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net461 | 15.268 ns | 0.0237 ns | 0.0210 ns | 15.273 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net472 | 16.946 ns | 0.0331 ns | 0.0294 ns | 16.944 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                              From_ParentClass_NoValue | .NET Core 2.0 | 11.911 ns | 0.0144 ns | 0.0127 ns | 11.907 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 2.2 | 11.119 ns | 0.0107 ns | 0.0100 ns | 11.115 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 3.0 | 11.427 ns | 0.0624 ns | 0.0584 ns | 11.430 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net461 | 12.309 ns | 0.0218 ns | 0.0193 ns | 12.304 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net472 | 12.522 ns | 0.0170 ns | 0.0159 ns | 12.516 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.0 | 14.077 ns | 0.0206 ns | 0.0182 ns | 14.076 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.2 | 11.868 ns | 0.0125 ns | 0.0105 ns | 11.864 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 3.0 | 13.368 ns | 0.1133 ns | 0.1004 ns | 13.385 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net461 | 13.456 ns | 0.0321 ns | 0.0301 ns | 13.447 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net472 | 17.374 ns | 0.0344 ns | 0.0305 ns | 17.360 ns |  1.23 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_ParentStruct | .NET Core 2.0 | 38.757 ns | 0.0421 ns | 0.0374 ns | 38.767 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 2.2 | 36.128 ns | 0.0387 ns | 0.0343 ns | 36.121 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 3.0 | 38.787 ns | 0.0559 ns | 0.0523 ns | 38.775 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct |        net461 | 38.699 ns | 0.1224 ns | 0.1085 ns | 38.673 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct |        net472 | 38.397 ns | 0.0765 ns | 0.0678 ns | 38.381 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_ParentStruct_AsObject | .NET Core 2.0 | 15.432 ns | 0.0189 ns | 0.0158 ns | 15.435 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 2.2 | 13.505 ns | 0.0103 ns | 0.0086 ns | 13.503 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 3.0 | 13.130 ns | 0.0658 ns | 0.0514 ns | 13.117 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net461 | 17.579 ns | 0.1303 ns | 0.1219 ns | 17.517 ns |  1.14 |    0.01 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net472 | 16.968 ns | 0.0199 ns | 0.0167 ns | 16.966 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.0 | 39.196 ns | 0.1172 ns | 0.1096 ns | 39.242 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.2 | 38.078 ns | 0.1323 ns | 0.1237 ns | 38.135 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 3.0 | 35.920 ns | 0.4107 ns | 0.3841 ns | 35.664 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue |        net461 | 46.803 ns | 0.0284 ns | 0.0252 ns | 46.813 ns |  1.19 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue |        net472 | 38.601 ns | 0.0510 ns | 0.0452 ns | 38.609 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 16.501 ns | 0.0395 ns | 0.0350 ns | 16.496 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 13.496 ns | 0.0097 ns | 0.0081 ns | 13.496 ns |  0.82 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 14.425 ns | 0.0178 ns | 0.0158 ns | 14.424 ns |  0.87 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net461 | 15.277 ns | 0.0345 ns | 0.0322 ns | 15.279 ns |  0.93 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net472 | 18.151 ns | 0.0220 ns | 0.0184 ns | 18.146 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.0 | 46.819 ns | 0.0754 ns | 0.0668 ns | 46.795 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.2 | 42.889 ns | 0.3622 ns | 0.3388 ns | 42.708 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 3.0 | 35.941 ns | 0.2409 ns | 0.1881 ns | 36.029 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net461 | 39.713 ns | 0.1111 ns | 0.1039 ns | 39.731 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net472 | 37.976 ns | 0.0551 ns | 0.0460 ns | 37.953 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.109 ns | 0.0103 ns | 0.0096 ns | 14.111 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.683 ns | 0.0605 ns | 0.0566 ns | 12.644 ns |  0.90 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.169 ns | 0.2641 ns | 0.4339 ns | 12.357 ns |  0.84 |    0.04 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net461 | 13.291 ns | 0.0251 ns | 0.0235 ns | 13.298 ns |  0.94 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net472 | 15.056 ns | 0.0868 ns | 0.0812 ns | 15.103 ns |  1.07 |    0.01 |      - |     - |     - |         - |

Benchmarks with issues:
  ConvertTo_UInt.From_DateTime_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_UInt.From_DateTime_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_UInt.From_DateTime_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_UInt.From_DateTime_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_UInt.From_DateTime_AsObject: Job-ZVTGBZ(Toolchain=net472)
  ConvertTo_UInt.From_DateTime_Nullable_WithValue_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_UInt.From_DateTime_Nullable_WithValue_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_UInt.From_DateTime_Nullable_WithValue_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_UInt.From_DateTime_Nullable_WithValue_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_UInt.From_DateTime_Nullable_WithValue_AsObject: Job-ZVTGBZ(Toolchain=net472)
  ConvertTo_UInt.From_String_Empty_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_UInt.From_String_Empty_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_UInt.From_String_Empty_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_UInt.From_String_Empty_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_UInt.From_String_Empty_AsObject: Job-ZVTGBZ(Toolchain=net472)
