
BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.615 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-LRKCAO : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), 64bit RyuJIT
  Job-VAJWLV : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-TJIRAH : .NET Core 3.0.0-preview6-27804-01 (CoreCLR 4.700.19.30373, CoreFX 4.700.19.30308), 64bit RyuJIT
  Job-HBFVIR : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0
  Job-YRWWQX : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0


                                                Method |     Toolchain |      Mean |     Error |    StdDev |    Median | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------------------------------------------ |-------------- |----------:|----------:|----------:|----------:|------:|--------:|-------:|------:|------:|----------:|
                                             From_Bool | .NET Core 2.0 | 11.901 ns | 0.0281 ns | 0.0263 ns | 11.896 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 2.2 | 10.428 ns | 0.0210 ns | 0.0186 ns | 10.432 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 3.0 |  9.496 ns | 0.0191 ns | 0.0179 ns |  9.488 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                             From_Bool |        net461 | 14.149 ns | 0.1397 ns | 0.1306 ns | 14.081 ns |  1.19 |    0.01 |      - |     - |     - |         - |
                                             From_Bool |        net472 | 12.419 ns | 0.1220 ns | 0.1141 ns | 12.348 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Bool_AsObject | .NET Core 2.0 | 25.056 ns | 0.0691 ns | 0.0646 ns | 25.033 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 2.2 | 25.851 ns | 0.2535 ns | 0.2371 ns | 25.956 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 3.0 | 28.651 ns | 0.0466 ns | 0.0436 ns | 28.654 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net461 | 34.865 ns | 0.0525 ns | 0.0466 ns | 34.869 ns |  1.39 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net472 | 37.617 ns | 0.0583 ns | 0.0546 ns | 37.610 ns |  1.50 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Bool_Nullable_WithValue | .NET Core 2.0 | 11.644 ns | 0.0841 ns | 0.0745 ns | 11.673 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 2.2 |  9.997 ns | 0.0080 ns | 0.0071 ns |  9.999 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 3.0 |  7.081 ns | 0.0691 ns | 0.0647 ns |  7.122 ns |  0.61 |    0.01 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net461 | 12.542 ns | 0.1024 ns | 0.0957 ns | 12.494 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net472 | 12.765 ns | 0.1231 ns | 0.1151 ns | 12.684 ns |  1.10 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.0 | 24.574 ns | 0.0373 ns | 0.0349 ns | 24.569 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.2 | 25.066 ns | 0.0711 ns | 0.0594 ns | 25.061 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 3.0 | 28.059 ns | 0.1783 ns | 0.1668 ns | 28.118 ns |  1.14 |    0.01 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net461 | 35.932 ns | 0.2245 ns | 0.1874 ns | 35.985 ns |  1.46 |    0.01 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net472 | 39.462 ns | 0.0893 ns | 0.0792 ns | 39.441 ns |  1.61 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Bool_Nullable_NoValue | .NET Core 2.0 | 11.554 ns | 0.0185 ns | 0.0155 ns | 11.551 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 2.2 | 10.023 ns | 0.0256 ns | 0.0239 ns | 10.013 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 3.0 |  7.036 ns | 0.0158 ns | 0.0140 ns |  7.033 ns |  0.61 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net461 | 12.510 ns | 0.0410 ns | 0.0364 ns | 12.494 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net472 | 12.778 ns | 0.0931 ns | 0.0871 ns | 12.733 ns |  1.10 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.926 ns | 0.0139 ns | 0.0130 ns | 14.924 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.672 ns | 0.0536 ns | 0.0501 ns | 13.652 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.994 ns | 0.1424 ns | 0.1332 ns | 15.055 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net461 | 22.350 ns | 0.0235 ns | 0.0208 ns | 22.350 ns |  1.50 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net472 | 27.720 ns | 0.0309 ns | 0.0289 ns | 27.719 ns |  1.86 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Byte | .NET Core 2.0 | 11.952 ns | 0.0209 ns | 0.0185 ns | 11.952 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 2.2 | 10.966 ns | 0.1044 ns | 0.0976 ns | 10.911 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 3.0 | 10.224 ns | 0.2269 ns | 0.3599 ns | 10.401 ns |  0.83 |    0.04 |      - |     - |     - |         - |
                                             From_Byte |        net461 | 13.951 ns | 0.1408 ns | 0.1317 ns | 13.870 ns |  1.17 |    0.01 |      - |     - |     - |         - |
                                             From_Byte |        net472 | 12.382 ns | 0.1051 ns | 0.0983 ns | 12.322 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Byte_AsObject | .NET Core 2.0 | 20.237 ns | 0.0365 ns | 0.0305 ns | 20.233 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 2.2 | 17.523 ns | 0.0378 ns | 0.0336 ns | 17.518 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 3.0 | 17.766 ns | 0.1905 ns | 0.1782 ns | 17.859 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net461 | 27.216 ns | 0.0405 ns | 0.0359 ns | 27.214 ns |  1.34 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net472 | 30.417 ns | 0.0482 ns | 0.0451 ns | 30.415 ns |  1.50 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Byte_Nullable_WithValue | .NET Core 2.0 | 12.186 ns | 0.0153 ns | 0.0144 ns | 12.180 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 2.2 | 11.142 ns | 0.0192 ns | 0.0180 ns | 11.143 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 3.0 |  9.968 ns | 0.0282 ns | 0.0250 ns |  9.968 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net461 | 13.541 ns | 0.0286 ns | 0.0253 ns | 13.534 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net472 | 13.510 ns | 0.0144 ns | 0.0135 ns | 13.508 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.086 ns | 0.0326 ns | 0.0289 ns | 20.086 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.719 ns | 0.0897 ns | 0.0749 ns | 17.736 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.592 ns | 0.0186 ns | 0.0165 ns | 17.586 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net461 | 27.257 ns | 0.1826 ns | 0.1708 ns | 27.179 ns |  1.36 |    0.01 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net472 | 28.859 ns | 0.0509 ns | 0.0476 ns | 28.851 ns |  1.44 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Byte_Nullable_NoValue | .NET Core 2.0 | 12.011 ns | 0.0250 ns | 0.0234 ns | 12.009 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 2.2 | 10.770 ns | 0.0216 ns | 0.0168 ns | 10.769 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 3.0 |  9.576 ns | 0.1087 ns | 0.1017 ns |  9.503 ns |  0.80 |    0.01 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net461 | 14.422 ns | 0.1290 ns | 0.1207 ns | 14.470 ns |  1.20 |    0.01 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net472 | 12.807 ns | 0.0209 ns | 0.0195 ns | 12.808 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.923 ns | 0.0233 ns | 0.0207 ns | 14.926 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.227 ns | 0.0217 ns | 0.0181 ns | 14.223 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.486 ns | 0.0527 ns | 0.0493 ns | 13.475 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net461 | 24.036 ns | 0.0990 ns | 0.0926 ns | 24.013 ns |  1.61 |    0.01 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net472 | 24.048 ns | 0.0748 ns | 0.0663 ns | 24.043 ns |  1.61 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Char | .NET Core 2.0 | 11.973 ns | 0.0132 ns | 0.0117 ns | 11.976 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Char | .NET Core 2.2 | 11.465 ns | 0.0232 ns | 0.0217 ns | 11.465 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                             From_Char | .NET Core 3.0 |  9.264 ns | 0.0249 ns | 0.0208 ns |  9.257 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                                             From_Char |        net461 | 13.926 ns | 0.0784 ns | 0.0695 ns | 13.938 ns |  1.16 |    0.01 |      - |     - |     - |         - |
                                             From_Char |        net472 | 12.422 ns | 0.1240 ns | 0.1160 ns | 12.495 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Char_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Char_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Char_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Char_Nullable_WithValue | .NET Core 2.0 | 11.914 ns | 0.0212 ns | 0.0188 ns | 11.910 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 2.2 | 10.740 ns | 0.0173 ns | 0.0153 ns | 10.741 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 3.0 |  9.471 ns | 0.0143 ns | 0.0127 ns |  9.468 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net461 | 13.787 ns | 0.1166 ns | 0.1091 ns | 13.719 ns |  1.16 |    0.01 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net472 | 13.244 ns | 0.1158 ns | 0.1083 ns | 13.184 ns |  1.11 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Char_Nullable_NoValue | .NET Core 2.0 | 11.959 ns | 0.0510 ns | 0.0426 ns | 11.943 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 2.2 | 10.618 ns | 0.0213 ns | 0.0199 ns | 10.611 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 3.0 |  9.468 ns | 0.0280 ns | 0.0262 ns |  9.466 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net461 | 13.722 ns | 0.0294 ns | 0.0246 ns | 13.716 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net472 | 12.342 ns | 0.0663 ns | 0.0620 ns | 12.308 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.974 ns | 0.0138 ns | 0.0123 ns | 14.975 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.025 ns | 0.0245 ns | 0.0217 ns | 13.031 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.405 ns | 0.0192 ns | 0.0170 ns | 13.403 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net461 | 22.232 ns | 0.0601 ns | 0.0533 ns | 22.243 ns |  1.48 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net472 | 25.310 ns | 0.0276 ns | 0.0244 ns | 25.313 ns |  1.69 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                         From_DateTime | .NET Core 2.0 | 12.262 ns | 0.0941 ns | 0.0880 ns | 12.211 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 2.2 | 11.659 ns | 0.0168 ns | 0.0157 ns | 11.656 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 3.0 |  9.985 ns | 0.0150 ns | 0.0117 ns |  9.985 ns |  0.81 |    0.01 |      - |     - |     - |         - |
                                         From_DateTime |        net461 | 14.379 ns | 0.0310 ns | 0.0259 ns | 14.381 ns |  1.17 |    0.01 |      - |     - |     - |         - |
                                         From_DateTime |        net472 | 13.132 ns | 0.0180 ns | 0.0160 ns | 13.131 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                From_DateTime_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                      From_DateTime_Nullable_WithValue | .NET Core 2.0 | 12.718 ns | 0.0242 ns | 0.0226 ns | 12.713 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 2.2 | 11.842 ns | 0.0361 ns | 0.0301 ns | 11.843 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 3.0 |  9.967 ns | 0.0296 ns | 0.0247 ns |  9.958 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net461 | 18.322 ns | 0.0876 ns | 0.0776 ns | 18.340 ns |  1.44 |    0.01 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net472 | 13.368 ns | 0.0328 ns | 0.0307 ns | 13.358 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_DateTime_Nullable_NoValue | .NET Core 2.0 | 12.603 ns | 0.0127 ns | 0.0113 ns | 12.602 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 2.2 | 11.845 ns | 0.0853 ns | 0.0756 ns | 11.816 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 3.0 |  9.952 ns | 0.0160 ns | 0.0142 ns |  9.956 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net461 | 14.446 ns | 0.1327 ns | 0.1241 ns | 14.534 ns |  1.15 |    0.01 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net472 | 13.895 ns | 0.0166 ns | 0.0139 ns | 13.894 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.581 ns | 0.0390 ns | 0.0364 ns | 15.582 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.008 ns | 0.0310 ns | 0.0290 ns | 13.004 ns |  0.83 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.422 ns | 0.0113 ns | 0.0106 ns | 13.424 ns |  0.86 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net461 | 22.817 ns | 0.0855 ns | 0.0800 ns | 22.824 ns |  1.46 |    0.01 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net472 | 23.944 ns | 0.0619 ns | 0.0517 ns | 23.941 ns |  1.54 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                          From_Decimal | .NET Core 2.0 | 24.383 ns | 0.0753 ns | 0.0704 ns | 24.369 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 2.2 | 21.273 ns | 0.0353 ns | 0.0313 ns | 21.270 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 3.0 | 13.968 ns | 0.0417 ns | 0.0348 ns | 13.973 ns |  0.57 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal |        net461 | 25.452 ns | 0.0260 ns | 0.0231 ns | 25.449 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal |        net472 | 23.399 ns | 0.0273 ns | 0.0242 ns | 23.393 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                 From_Decimal_AsObject | .NET Core 2.0 | 25.884 ns | 0.0332 ns | 0.0294 ns | 25.883 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 2.2 | 24.737 ns | 0.0800 ns | 0.0748 ns | 24.751 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 3.0 | 20.792 ns | 0.1181 ns | 0.1105 ns | 20.848 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net461 | 32.581 ns | 0.0474 ns | 0.0420 ns | 32.590 ns |  1.26 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net472 | 36.687 ns | 0.0527 ns | 0.0440 ns | 36.669 ns |  1.42 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                       From_Decimal_Nullable_WithValue | .NET Core 2.0 | 23.174 ns | 0.0346 ns | 0.0270 ns | 23.173 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 2.2 | 20.561 ns | 0.0312 ns | 0.0276 ns | 20.568 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 3.0 | 17.455 ns | 0.1759 ns | 0.1645 ns | 17.447 ns |  0.75 |    0.01 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net461 | 24.914 ns | 0.0469 ns | 0.0439 ns | 24.921 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net472 | 25.557 ns | 0.0281 ns | 0.0263 ns | 25.559 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.0 | 26.721 ns | 0.0520 ns | 0.0461 ns | 26.722 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.2 | 23.239 ns | 0.0254 ns | 0.0212 ns | 23.236 ns |  0.87 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 3.0 | 20.931 ns | 0.1037 ns | 0.0970 ns | 20.945 ns |  0.78 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net461 | 32.438 ns | 0.0643 ns | 0.0502 ns | 32.435 ns |  1.21 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net472 | 35.766 ns | 0.0417 ns | 0.0370 ns | 35.766 ns |  1.34 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Decimal_Nullable_NoValue | .NET Core 2.0 | 12.762 ns | 0.0134 ns | 0.0119 ns | 12.765 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 2.2 | 12.066 ns | 0.0422 ns | 0.0395 ns | 12.055 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 3.0 | 10.001 ns | 0.0101 ns | 0.0095 ns |  9.999 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net461 | 14.436 ns | 0.0249 ns | 0.0220 ns | 14.439 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net472 | 13.484 ns | 0.0134 ns | 0.0112 ns | 13.485 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.177 ns | 0.0947 ns | 0.0886 ns | 15.224 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.983 ns | 0.0151 ns | 0.0134 ns | 12.986 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.614 ns | 0.1123 ns | 0.0995 ns | 13.653 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net461 | 22.583 ns | 0.2362 ns | 0.2094 ns | 22.476 ns |  1.49 |    0.02 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net472 | 24.306 ns | 0.0300 ns | 0.0266 ns | 24.312 ns |  1.60 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_Double | .NET Core 2.0 | 12.771 ns | 0.0157 ns | 0.0147 ns | 12.769 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 2.2 | 11.373 ns | 0.0181 ns | 0.0169 ns | 11.370 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 3.0 | 10.773 ns | 0.1493 ns | 0.1397 ns | 10.698 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                                           From_Double |        net461 | 14.213 ns | 0.0299 ns | 0.0265 ns | 14.219 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                           From_Double |        net472 | 13.470 ns | 0.0361 ns | 0.0338 ns | 13.460 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_Double_AsObject | .NET Core 2.0 | 20.028 ns | 0.2415 ns | 0.2259 ns | 19.951 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 2.2 | 17.474 ns | 0.0653 ns | 0.0545 ns | 17.456 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 3.0 | 19.591 ns | 0.0473 ns | 0.0419 ns | 19.583 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                                  From_Double_AsObject |        net461 | 26.898 ns | 0.0421 ns | 0.0373 ns | 26.897 ns |  1.34 |    0.01 |      - |     - |     - |         - |
                                  From_Double_AsObject |        net472 | 31.321 ns | 0.0410 ns | 0.0384 ns | 31.326 ns |  1.56 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_Double_Nullable_WithValue | .NET Core 2.0 | 13.098 ns | 0.0450 ns | 0.0421 ns | 13.080 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 2.2 | 12.451 ns | 0.0237 ns | 0.0222 ns | 12.448 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 3.0 | 11.252 ns | 0.0937 ns | 0.0876 ns | 11.291 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net461 | 14.675 ns | 0.0402 ns | 0.0376 ns | 14.666 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net472 | 14.191 ns | 0.0185 ns | 0.0145 ns | 14.197 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.986 ns | 0.0967 ns | 0.0904 ns | 21.039 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.547 ns | 0.1390 ns | 0.1300 ns | 17.468 ns |  0.84 |    0.01 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.133 ns | 0.0524 ns | 0.0438 ns | 18.141 ns |  0.86 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net461 | 27.060 ns | 0.0295 ns | 0.0261 ns | 27.053 ns |  1.29 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net472 | 30.429 ns | 0.1171 ns | 0.1095 ns | 30.389 ns |  1.45 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Double_Nullable_NoValue | .NET Core 2.0 | 13.205 ns | 0.0444 ns | 0.0394 ns | 13.207 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 2.2 | 12.051 ns | 0.0242 ns | 0.0226 ns | 12.050 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 3.0 |  9.959 ns | 0.0126 ns | 0.0112 ns |  9.964 ns |  0.75 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net461 | 14.434 ns | 0.0413 ns | 0.0345 ns | 14.426 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net472 | 13.885 ns | 0.0716 ns | 0.0598 ns | 13.893 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.0 | 16.674 ns | 0.0264 ns | 0.0247 ns | 16.678 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.206 ns | 0.0692 ns | 0.0648 ns | 13.232 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 3.0 | 15.062 ns | 0.0845 ns | 0.0790 ns | 15.087 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net461 | 22.561 ns | 0.0251 ns | 0.0196 ns | 22.562 ns |  1.35 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net472 | 23.734 ns | 0.0860 ns | 0.0805 ns | 23.697 ns |  1.42 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_Short | .NET Core 2.0 | 13.525 ns | 0.0445 ns | 0.0416 ns | 13.523 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 2.2 | 11.328 ns | 0.0197 ns | 0.0184 ns | 11.324 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 3.0 | 10.281 ns | 0.0632 ns | 0.0591 ns | 10.282 ns |  0.76 |    0.00 |      - |     - |     - |         - |
                                            From_Short |        net461 | 13.953 ns | 0.0315 ns | 0.0263 ns | 13.955 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                            From_Short |        net472 | 12.536 ns | 0.0127 ns | 0.0112 ns | 12.537 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_Short_AsObject | .NET Core 2.0 | 20.162 ns | 0.1567 ns | 0.1466 ns | 20.259 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 2.2 | 17.479 ns | 0.0268 ns | 0.0250 ns | 17.474 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 3.0 | 17.561 ns | 0.0277 ns | 0.0259 ns | 17.551 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net461 | 27.570 ns | 0.1659 ns | 0.1471 ns | 27.631 ns |  1.37 |    0.01 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net472 | 28.827 ns | 0.0424 ns | 0.0376 ns | 28.829 ns |  1.43 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Short_Nullable_WithValue | .NET Core 2.0 | 12.183 ns | 0.0196 ns | 0.0164 ns | 12.184 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 2.2 | 11.345 ns | 0.0137 ns | 0.0121 ns | 11.342 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 3.0 | 10.127 ns | 0.0857 ns | 0.0802 ns | 10.161 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net461 | 14.225 ns | 0.0246 ns | 0.0230 ns | 14.224 ns |  1.17 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net472 | 12.808 ns | 0.0234 ns | 0.0218 ns | 12.805 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.815 ns | 0.0250 ns | 0.0222 ns | 19.814 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.495 ns | 0.0352 ns | 0.0330 ns | 17.491 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.920 ns | 0.3336 ns | 0.3121 ns | 17.840 ns |  0.90 |    0.02 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net461 | 26.994 ns | 0.0367 ns | 0.0343 ns | 26.992 ns |  1.36 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net472 | 29.934 ns | 0.0471 ns | 0.0393 ns | 29.920 ns |  1.51 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Short_Nullable_NoValue | .NET Core 2.0 | 12.077 ns | 0.0679 ns | 0.0635 ns | 12.106 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 2.2 | 10.941 ns | 0.0119 ns | 0.0112 ns | 10.943 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 3.0 |  9.744 ns | 0.0303 ns | 0.0283 ns |  9.735 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net461 | 14.192 ns | 0.0229 ns | 0.0191 ns | 14.192 ns |  1.18 |    0.01 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net472 | 12.867 ns | 0.0187 ns | 0.0165 ns | 12.875 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.916 ns | 0.0293 ns | 0.0274 ns | 14.916 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.123 ns | 0.0742 ns | 0.0694 ns | 14.147 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.019 ns | 0.2959 ns | 0.3522 ns | 14.248 ns |  0.93 |    0.03 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net461 | 24.616 ns | 0.0874 ns | 0.0817 ns | 24.570 ns |  1.65 |    0.01 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net472 | 24.296 ns | 0.0217 ns | 0.0203 ns | 24.304 ns |  1.63 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                              From_Int | .NET Core 2.0 | 12.572 ns | 0.0221 ns | 0.0184 ns | 12.570 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 2.2 | 11.118 ns | 0.0167 ns | 0.0156 ns | 11.116 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 3.0 |  9.486 ns | 0.0269 ns | 0.0251 ns |  9.490 ns |  0.75 |    0.00 |      - |     - |     - |         - |
                                              From_Int |        net461 | 13.019 ns | 0.0341 ns | 0.0302 ns | 13.011 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                              From_Int |        net472 | 12.301 ns | 0.0337 ns | 0.0315 ns | 12.286 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_Int_AsObject | .NET Core 2.0 | 20.214 ns | 0.1437 ns | 0.1344 ns | 20.195 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 2.2 | 17.444 ns | 0.0273 ns | 0.0255 ns | 17.440 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 3.0 | 17.458 ns | 0.0339 ns | 0.0283 ns | 17.461 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net461 | 27.155 ns | 0.0181 ns | 0.0160 ns | 27.159 ns |  1.34 |    0.01 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net472 | 30.769 ns | 0.0701 ns | 0.0586 ns | 30.759 ns |  1.52 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Int_Nullable_WithValue | .NET Core 2.0 | 12.192 ns | 0.0220 ns | 0.0195 ns | 12.189 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 2.2 | 11.431 ns | 0.0646 ns | 0.0540 ns | 11.451 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 3.0 |  9.963 ns | 0.0252 ns | 0.0236 ns |  9.963 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net461 | 14.294 ns | 0.0347 ns | 0.0308 ns | 14.298 ns |  1.17 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net472 | 13.185 ns | 0.0315 ns | 0.0263 ns | 13.178 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.104 ns | 0.1183 ns | 0.1107 ns | 20.055 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.504 ns | 0.0338 ns | 0.0316 ns | 17.515 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.683 ns | 0.2723 ns | 0.2547 ns | 17.561 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net461 | 27.460 ns | 0.1286 ns | 0.1140 ns | 27.492 ns |  1.37 |    0.01 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net472 | 30.586 ns | 0.0376 ns | 0.0352 ns | 30.594 ns |  1.52 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_Int_Nullable_NoValue | .NET Core 2.0 | 12.100 ns | 0.1010 ns | 0.0945 ns | 12.125 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 2.2 | 10.822 ns | 0.0095 ns | 0.0089 ns | 10.823 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 3.0 |  9.575 ns | 0.0583 ns | 0.0486 ns |  9.583 ns |  0.79 |    0.01 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net461 | 13.505 ns | 0.0340 ns | 0.0302 ns | 13.498 ns |  1.12 |    0.01 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net472 | 12.901 ns | 0.0180 ns | 0.0160 ns | 12.898 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.536 ns | 0.0312 ns | 0.0260 ns | 15.540 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.132 ns | 0.0252 ns | 0.0236 ns | 13.130 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.414 ns | 0.0226 ns | 0.0211 ns | 13.416 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net461 | 21.978 ns | 0.0531 ns | 0.0444 ns | 21.991 ns |  1.41 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net472 | 26.563 ns | 0.1222 ns | 0.1143 ns | 26.561 ns |  1.71 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Long | .NET Core 2.0 | 11.982 ns | 0.1031 ns | 0.0965 ns | 11.930 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Long | .NET Core 2.2 | 10.975 ns | 0.0400 ns | 0.0374 ns | 10.962 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                                             From_Long | .NET Core 3.0 |  9.967 ns | 0.0122 ns | 0.0109 ns |  9.969 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                                             From_Long |        net461 | 13.218 ns | 0.0282 ns | 0.0264 ns | 13.211 ns |  1.10 |    0.01 |      - |     - |     - |         - |
                                             From_Long |        net472 | 13.559 ns | 0.0307 ns | 0.0272 ns | 13.548 ns |  1.13 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Long_AsObject | .NET Core 2.0 | 19.811 ns | 0.0261 ns | 0.0218 ns | 19.815 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 2.2 | 17.661 ns | 0.0977 ns | 0.0866 ns | 17.690 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 3.0 | 17.633 ns | 0.0680 ns | 0.0603 ns | 17.627 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net461 | 26.848 ns | 0.0494 ns | 0.0413 ns | 26.838 ns |  1.36 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net472 | 30.323 ns | 0.0680 ns | 0.0636 ns | 30.310 ns |  1.53 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Long_Nullable_WithValue | .NET Core 2.0 | 13.234 ns | 0.0245 ns | 0.0217 ns | 13.229 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 2.2 | 12.330 ns | 0.0243 ns | 0.0227 ns | 12.333 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 3.0 | 10.197 ns | 0.0347 ns | 0.0307 ns | 10.196 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net461 | 15.212 ns | 0.0196 ns | 0.0174 ns | 15.211 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net472 | 14.418 ns | 0.0169 ns | 0.0158 ns | 14.417 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.081 ns | 0.0533 ns | 0.0499 ns | 20.101 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.473 ns | 0.0183 ns | 0.0153 ns | 17.472 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.602 ns | 0.0239 ns | 0.0212 ns | 17.604 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net461 | 26.984 ns | 0.0371 ns | 0.0347 ns | 26.988 ns |  1.34 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net472 | 29.764 ns | 0.0234 ns | 0.0196 ns | 29.759 ns |  1.48 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Long_Nullable_NoValue | .NET Core 2.0 | 12.432 ns | 0.0148 ns | 0.0138 ns | 12.429 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 2.2 | 11.955 ns | 0.0173 ns | 0.0161 ns | 11.956 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 3.0 | 10.218 ns | 0.0581 ns | 0.0515 ns | 10.196 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net461 | 14.960 ns | 0.0276 ns | 0.0258 ns | 14.968 ns |  1.20 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net472 | 13.636 ns | 0.0659 ns | 0.0616 ns | 13.642 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.903 ns | 0.0393 ns | 0.0367 ns | 14.894 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.040 ns | 0.0148 ns | 0.0124 ns | 13.038 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.788 ns | 0.0140 ns | 0.0124 ns | 14.789 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net461 | 25.298 ns | 0.0473 ns | 0.0419 ns | 25.291 ns |  1.70 |    0.01 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net472 | 25.274 ns | 0.0872 ns | 0.0815 ns | 25.254 ns |  1.70 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_SByte | .NET Core 2.0 | 12.531 ns | 0.0203 ns | 0.0190 ns | 12.522 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 2.2 | 11.052 ns | 0.0634 ns | 0.0530 ns | 11.075 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 3.0 |  9.977 ns | 0.0146 ns | 0.0130 ns |  9.975 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                            From_SByte |        net461 | 13.263 ns | 0.0118 ns | 0.0110 ns | 13.260 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                            From_SByte |        net472 | 12.516 ns | 0.0184 ns | 0.0163 ns | 12.512 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_SByte_AsObject | .NET Core 2.0 | 20.662 ns | 0.2601 ns | 0.2433 ns | 20.802 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 2.2 | 20.856 ns | 0.0460 ns | 0.0430 ns | 20.853 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 3.0 | 17.512 ns | 0.0622 ns | 0.0519 ns | 17.500 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net461 | 26.934 ns | 0.0455 ns | 0.0355 ns | 26.932 ns |  1.30 |    0.02 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net472 | 31.438 ns | 0.0447 ns | 0.0396 ns | 31.442 ns |  1.52 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_SByte_Nullable_WithValue | .NET Core 2.0 | 12.139 ns | 0.0185 ns | 0.0173 ns | 12.143 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 2.2 | 11.194 ns | 0.0307 ns | 0.0287 ns | 11.198 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 3.0 | 11.088 ns | 0.1123 ns | 0.1051 ns | 11.097 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net461 | 14.225 ns | 0.0190 ns | 0.0178 ns | 14.223 ns |  1.17 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net472 | 12.817 ns | 0.0262 ns | 0.0245 ns | 12.814 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.788 ns | 0.0539 ns | 0.0421 ns | 19.781 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.485 ns | 0.0237 ns | 0.0222 ns | 17.487 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.576 ns | 0.0756 ns | 0.0708 ns | 17.566 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net461 | 29.762 ns | 0.0556 ns | 0.0493 ns | 29.753 ns |  1.50 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net472 | 31.012 ns | 0.1015 ns | 0.0949 ns | 31.033 ns |  1.57 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_SByte_Nullable_NoValue | .NET Core 2.0 | 11.949 ns | 0.0223 ns | 0.0209 ns | 11.954 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 2.2 | 10.825 ns | 0.0152 ns | 0.0135 ns | 10.824 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 3.0 |  9.488 ns | 0.0210 ns | 0.0196 ns |  9.486 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net461 | 13.512 ns | 0.0111 ns | 0.0104 ns | 13.509 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net472 | 13.821 ns | 0.0359 ns | 0.0300 ns | 13.812 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.877 ns | 0.0453 ns | 0.0423 ns | 14.869 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.575 ns | 0.0908 ns | 0.0849 ns | 13.601 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.434 ns | 0.0417 ns | 0.0390 ns | 13.426 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net461 | 22.259 ns | 0.0166 ns | 0.0138 ns | 22.258 ns |  1.50 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net472 | 24.130 ns | 0.0262 ns | 0.0232 ns | 24.124 ns |  1.62 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_Float | .NET Core 2.0 | 12.916 ns | 0.0487 ns | 0.0456 ns | 12.924 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 2.2 | 11.777 ns | 0.0231 ns | 0.0204 ns | 11.778 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 3.0 | 10.442 ns | 0.0383 ns | 0.0358 ns | 10.440 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                                            From_Float |        net461 | 14.813 ns | 0.0213 ns | 0.0178 ns | 14.806 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                                            From_Float |        net472 | 13.656 ns | 0.0734 ns | 0.0651 ns | 13.676 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_Float_AsObject | .NET Core 2.0 | 20.018 ns | 0.1105 ns | 0.1033 ns | 19.985 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 2.2 | 17.506 ns | 0.0303 ns | 0.0284 ns | 17.506 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 3.0 | 21.797 ns | 0.4557 ns | 1.0470 ns | 22.159 ns |  1.03 |    0.09 |      - |     - |     - |         - |
                                   From_Float_AsObject |        net461 | 26.805 ns | 0.0458 ns | 0.0428 ns | 26.793 ns |  1.34 |    0.01 |      - |     - |     - |         - |
                                   From_Float_AsObject |        net472 | 30.702 ns | 0.0936 ns | 0.0876 ns | 30.674 ns |  1.53 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Float_Nullable_WithValue | .NET Core 2.0 | 12.765 ns | 0.1114 ns | 0.1042 ns | 12.802 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 2.2 | 11.395 ns | 0.0176 ns | 0.0156 ns | 11.396 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 3.0 | 10.362 ns | 0.0541 ns | 0.0479 ns | 10.370 ns |  0.81 |    0.01 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net461 | 15.890 ns | 0.1058 ns | 0.0938 ns | 15.926 ns |  1.24 |    0.01 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net472 | 13.501 ns | 0.0424 ns | 0.0331 ns | 13.485 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.832 ns | 0.1209 ns | 0.1072 ns | 19.783 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.517 ns | 0.0197 ns | 0.0164 ns | 17.519 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 3.0 | 21.218 ns | 0.4497 ns | 1.1447 ns | 21.607 ns |  0.98 |    0.10 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net461 | 30.658 ns | 0.0713 ns | 0.0632 ns | 30.634 ns |  1.55 |    0.01 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net472 | 30.907 ns | 0.1910 ns | 0.1693 ns | 30.950 ns |  1.56 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Float_Nullable_NoValue | .NET Core 2.0 | 12.137 ns | 0.0172 ns | 0.0153 ns | 12.132 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 2.2 | 10.971 ns | 0.0362 ns | 0.0321 ns | 10.962 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 3.0 |  9.731 ns | 0.0136 ns | 0.0127 ns |  9.731 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net461 | 13.954 ns | 0.1028 ns | 0.0911 ns | 13.986 ns |  1.15 |    0.01 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net472 | 13.038 ns | 0.0147 ns | 0.0130 ns | 13.041 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.155 ns | 0.1436 ns | 0.1343 ns | 15.230 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.045 ns | 0.0198 ns | 0.0186 ns | 13.044 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.773 ns | 0.2896 ns | 0.2709 ns | 13.795 ns |  0.91 |    0.02 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net461 | 22.270 ns | 0.0246 ns | 0.0206 ns | 22.266 ns |  1.47 |    0.01 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net472 | 26.614 ns | 0.1186 ns | 0.1109 ns | 26.621 ns |  1.76 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_String | .NET Core 2.0 | 28.312 ns | 0.0613 ns | 0.0573 ns | 28.299 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 2.2 | 32.925 ns | 0.0397 ns | 0.0352 ns | 32.922 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 3.0 | 26.175 ns | 0.1375 ns | 0.1287 ns | 26.224 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                                           From_String |        net461 | 28.525 ns | 0.0747 ns | 0.0662 ns | 28.495 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                           From_String |        net472 | 29.648 ns | 0.1085 ns | 0.1015 ns | 29.608 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_String_AsObject | .NET Core 2.0 | 32.673 ns | 0.0702 ns | 0.0586 ns | 32.668 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 2.2 | 40.811 ns | 0.0554 ns | 0.0519 ns | 40.832 ns |  1.25 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 3.0 | 29.664 ns | 0.0690 ns | 0.0645 ns | 29.674 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject |        net461 | 38.623 ns | 0.1743 ns | 0.1630 ns | 38.660 ns |  1.18 |    0.01 |      - |     - |     - |         - |
                                  From_String_AsObject |        net472 | 42.048 ns | 0.0292 ns | 0.0259 ns | 42.056 ns |  1.29 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                      From_String_Null | .NET Core 2.0 | 14.336 ns | 0.0608 ns | 0.0569 ns | 14.346 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 2.2 | 12.807 ns | 0.0292 ns | 0.0259 ns | 12.810 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 3.0 | 12.526 ns | 0.0419 ns | 0.0371 ns | 12.529 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                                      From_String_Null |        net461 | 15.105 ns | 0.0124 ns | 0.0104 ns | 15.101 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null |        net472 | 15.323 ns | 0.0242 ns | 0.0214 ns | 15.317 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_String_Null_AsObject | .NET Core 2.0 | 14.857 ns | 0.0246 ns | 0.0230 ns | 14.855 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 2.2 | 13.039 ns | 0.0145 ns | 0.0128 ns | 13.039 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 3.0 | 13.621 ns | 0.0674 ns | 0.0630 ns | 13.626 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net461 | 24.231 ns | 0.1674 ns | 0.1565 ns | 24.152 ns |  1.63 |    0.01 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net472 | 24.308 ns | 0.0293 ns | 0.0274 ns | 24.311 ns |  1.64 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_String_Empty | .NET Core 2.0 | 14.413 ns | 0.0435 ns | 0.0407 ns | 14.392 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 2.2 | 12.960 ns | 0.0152 ns | 0.0142 ns | 12.957 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 3.0 | 12.535 ns | 0.0247 ns | 0.0219 ns | 12.530 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty |        net461 | 14.869 ns | 0.0692 ns | 0.0647 ns | 14.877 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                     From_String_Empty |        net472 | 16.181 ns | 0.1456 ns | 0.1362 ns | 16.272 ns |  1.12 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_String_Empty_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_UShort | .NET Core 2.0 | 11.889 ns | 0.0234 ns | 0.0207 ns | 11.887 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 2.2 | 10.952 ns | 0.0142 ns | 0.0133 ns | 10.955 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 3.0 | 10.217 ns | 0.0188 ns | 0.0157 ns | 10.217 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                           From_UShort |        net461 | 13.933 ns | 0.0287 ns | 0.0240 ns | 13.934 ns |  1.17 |    0.00 |      - |     - |     - |         - |
                                           From_UShort |        net472 | 12.529 ns | 0.0229 ns | 0.0178 ns | 12.535 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_UShort_AsObject | .NET Core 2.0 | 20.514 ns | 0.1708 ns | 0.1598 ns | 20.431 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 2.2 | 17.476 ns | 0.0318 ns | 0.0298 ns | 17.478 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 3.0 | 17.652 ns | 0.0524 ns | 0.0465 ns | 17.645 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net461 | 26.833 ns | 0.0233 ns | 0.0207 ns | 26.832 ns |  1.31 |    0.01 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net472 | 30.048 ns | 0.0263 ns | 0.0234 ns | 30.049 ns |  1.47 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_UShort_Nullable_WithValue | .NET Core 2.0 | 12.134 ns | 0.0412 ns | 0.0385 ns | 12.121 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 2.2 | 13.949 ns | 0.0142 ns | 0.0126 ns | 13.950 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 3.0 | 10.015 ns | 0.0372 ns | 0.0311 ns | 10.016 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net461 | 13.509 ns | 0.0170 ns | 0.0159 ns | 13.508 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net472 | 12.795 ns | 0.0224 ns | 0.0199 ns | 12.791 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.541 ns | 0.0743 ns | 0.0620 ns | 20.548 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.457 ns | 0.0333 ns | 0.0295 ns | 17.457 ns |  0.85 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.629 ns | 0.0343 ns | 0.0321 ns | 17.639 ns |  0.86 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net461 | 27.206 ns | 0.0278 ns | 0.0232 ns | 27.213 ns |  1.32 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net472 | 30.550 ns | 0.0369 ns | 0.0327 ns | 30.550 ns |  1.49 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_UShort_Nullable_NoValue | .NET Core 2.0 | 12.048 ns | 0.1136 ns | 0.1063 ns | 12.105 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 2.2 | 10.949 ns | 0.0311 ns | 0.0260 ns | 10.942 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 3.0 |  9.534 ns | 0.0223 ns | 0.0209 ns |  9.531 ns |  0.79 |    0.01 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net461 | 13.498 ns | 0.0279 ns | 0.0261 ns | 13.492 ns |  1.12 |    0.01 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net472 | 13.514 ns | 0.0138 ns | 0.0115 ns | 13.513 ns |  1.12 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.755 ns | 0.0350 ns | 0.0327 ns | 15.754 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.331 ns | 0.0205 ns | 0.0182 ns | 13.333 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.528 ns | 0.1020 ns | 0.0954 ns | 13.555 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net461 | 22.324 ns | 0.0603 ns | 0.0535 ns | 22.313 ns |  1.42 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net472 | 25.793 ns | 0.1308 ns | 0.1160 ns | 25.828 ns |  1.64 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_UInt | .NET Core 2.0 | 12.434 ns | 0.0307 ns | 0.0256 ns | 12.430 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 2.2 | 10.968 ns | 0.0178 ns | 0.0158 ns | 10.968 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 3.0 |  9.485 ns | 0.0154 ns | 0.0144 ns |  9.480 ns |  0.76 |    0.00 |      - |     - |     - |         - |
                                             From_UInt |        net461 | 13.753 ns | 0.0355 ns | 0.0277 ns | 13.748 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                             From_UInt |        net472 | 12.647 ns | 0.0655 ns | 0.0613 ns | 12.643 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_UInt_AsObject | .NET Core 2.0 | 20.032 ns | 0.1577 ns | 0.1475 ns | 20.096 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 2.2 | 17.571 ns | 0.0247 ns | 0.0219 ns | 17.567 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 3.0 | 21.303 ns | 0.0703 ns | 0.0623 ns | 21.287 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net461 | 27.288 ns | 0.0340 ns | 0.0284 ns | 27.294 ns |  1.36 |    0.01 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net472 | 29.891 ns | 0.0596 ns | 0.0528 ns | 29.892 ns |  1.49 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_UInt_Nullable_WithValue | .NET Core 2.0 | 12.125 ns | 0.0222 ns | 0.0207 ns | 12.128 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 2.2 | 11.589 ns | 0.0763 ns | 0.0714 ns | 11.597 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 3.0 | 10.406 ns | 0.0210 ns | 0.0197 ns | 10.404 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net461 | 13.505 ns | 0.0208 ns | 0.0185 ns | 13.502 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net472 | 12.999 ns | 0.0540 ns | 0.0479 ns | 13.010 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.751 ns | 0.0242 ns | 0.0226 ns | 19.752 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.464 ns | 0.0219 ns | 0.0204 ns | 17.459 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.653 ns | 0.0478 ns | 0.0373 ns | 17.650 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net461 | 27.634 ns | 0.1687 ns | 0.1578 ns | 27.676 ns |  1.40 |    0.01 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net472 | 28.846 ns | 0.0791 ns | 0.0702 ns | 28.847 ns |  1.46 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_UInt_Nullable_NoValue | .NET Core 2.0 | 12.074 ns | 0.0844 ns | 0.0789 ns | 12.113 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 2.2 | 10.821 ns | 0.0169 ns | 0.0141 ns | 10.820 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 3.0 |  9.494 ns | 0.0300 ns | 0.0281 ns |  9.497 ns |  0.79 |    0.01 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net461 | 14.159 ns | 0.0321 ns | 0.0268 ns | 14.157 ns |  1.17 |    0.01 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net472 | 13.782 ns | 0.0266 ns | 0.0236 ns | 13.784 ns |  1.14 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.511 ns | 0.0478 ns | 0.0447 ns | 15.490 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.038 ns | 0.0282 ns | 0.0264 ns | 13.044 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.400 ns | 0.0173 ns | 0.0154 ns | 13.402 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net461 | 22.240 ns | 0.0251 ns | 0.0235 ns | 22.236 ns |  1.43 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net472 | 26.015 ns | 0.0346 ns | 0.0289 ns | 26.011 ns |  1.68 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_ULong | .NET Core 2.0 | 11.888 ns | 0.0213 ns | 0.0199 ns | 11.889 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 2.2 | 11.790 ns | 0.0208 ns | 0.0184 ns | 11.785 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 3.0 |  9.715 ns | 0.1135 ns | 0.1062 ns |  9.776 ns |  0.82 |    0.01 |      - |     - |     - |         - |
                                            From_ULong |        net461 | 13.920 ns | 0.0694 ns | 0.0649 ns | 13.931 ns |  1.17 |    0.01 |      - |     - |     - |         - |
                                            From_ULong |        net472 | 12.992 ns | 0.0264 ns | 0.0220 ns | 12.989 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_ULong_AsObject | .NET Core 2.0 | 20.008 ns | 0.0323 ns | 0.0302 ns | 20.006 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 2.2 | 17.464 ns | 0.0514 ns | 0.0430 ns | 17.450 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 3.0 | 17.903 ns | 0.0355 ns | 0.0296 ns | 17.886 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net461 | 26.598 ns | 0.0345 ns | 0.0306 ns | 26.597 ns |  1.33 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net472 | 31.424 ns | 0.0464 ns | 0.0411 ns | 31.428 ns |  1.57 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_ULong_Nullable_WithValue | .NET Core 2.0 | 13.026 ns | 0.0453 ns | 0.0424 ns | 13.019 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 2.2 | 13.078 ns | 0.0210 ns | 0.0186 ns | 13.073 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 3.0 | 10.663 ns | 0.0290 ns | 0.0272 ns | 10.660 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net461 | 14.410 ns | 0.0283 ns | 0.0251 ns | 14.414 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net472 | 13.721 ns | 0.0377 ns | 0.0315 ns | 13.710 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.791 ns | 0.0336 ns | 0.0315 ns | 19.786 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.834 ns | 0.1084 ns | 0.1014 ns | 17.787 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.948 ns | 0.2884 ns | 0.2697 ns | 18.110 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net461 | 26.600 ns | 0.0606 ns | 0.0538 ns | 26.596 ns |  1.34 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net472 | 31.932 ns | 0.2624 ns | 0.2326 ns | 31.833 ns |  1.61 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_ULong_Nullable_NoValue | .NET Core 2.0 | 12.459 ns | 0.0212 ns | 0.0198 ns | 12.453 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 2.2 | 12.286 ns | 0.0252 ns | 0.0235 ns | 12.285 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 3.0 | 10.179 ns | 0.0296 ns | 0.0262 ns | 10.181 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net461 | 14.284 ns | 0.1008 ns | 0.0943 ns | 14.321 ns |  1.15 |    0.01 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net472 | 13.557 ns | 0.0689 ns | 0.0611 ns | 13.572 ns |  1.09 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.917 ns | 0.0768 ns | 0.0719 ns | 14.883 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.038 ns | 0.0184 ns | 0.0172 ns | 13.036 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.413 ns | 0.0293 ns | 0.0229 ns | 13.423 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net461 | 22.092 ns | 0.0293 ns | 0.0259 ns | 22.091 ns |  1.48 |    0.01 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net472 | 26.081 ns | 0.0396 ns | 0.0309 ns | 26.086 ns |  1.75 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                       From_NullObject | .NET Core 2.0 | 17.284 ns | 0.0434 ns | 0.0406 ns | 17.288 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 2.2 | 12.981 ns | 0.0114 ns | 0.0095 ns | 12.982 ns |  0.75 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 3.0 | 13.752 ns | 0.3011 ns | 0.5114 ns | 13.435 ns |  0.82 |    0.03 |      - |     - |     - |         - |
                                       From_NullObject |        net461 | 23.990 ns | 0.0318 ns | 0.0282 ns | 23.985 ns |  1.39 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject |        net472 | 26.721 ns | 0.0307 ns | 0.0288 ns | 26.723 ns |  1.55 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_DBNull | .NET Core 2.0 | 13.306 ns | 0.0181 ns | 0.0151 ns | 13.306 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 2.2 | 11.126 ns | 0.0230 ns | 0.0215 ns | 11.124 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 3.0 | 12.544 ns | 0.0122 ns | 0.0102 ns | 12.547 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull |        net461 | 13.247 ns | 0.0108 ns | 0.0096 ns | 13.246 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull |        net472 | 16.209 ns | 0.0301 ns | 0.0267 ns | 16.205 ns |  1.22 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_DBNull_AsObject | .NET Core 2.0 | 15.517 ns | 0.0365 ns | 0.0341 ns | 15.508 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 2.2 | 12.986 ns | 0.0199 ns | 0.0177 ns | 12.985 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 3.0 | 13.484 ns | 0.0852 ns | 0.0755 ns | 13.447 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net461 | 22.102 ns | 0.0379 ns | 0.0354 ns | 22.105 ns |  1.42 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net472 | 24.216 ns | 0.0622 ns | 0.0520 ns | 24.221 ns |  1.56 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                 From_ConvertibleClass | .NET Core 2.0 | 17.380 ns | 0.0212 ns | 0.0198 ns | 17.391 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 2.2 | 15.082 ns | 0.0193 ns | 0.0161 ns | 15.086 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 3.0 | 15.068 ns | 0.0425 ns | 0.0398 ns | 15.066 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net461 | 25.000 ns | 0.0859 ns | 0.0761 ns | 25.010 ns |  1.44 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net472 | 28.677 ns | 0.0511 ns | 0.0427 ns | 28.667 ns |  1.65 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_ConvertibleClass_AsObject | .NET Core 2.0 | 19.163 ns | 0.1453 ns | 0.1359 ns | 19.082 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 2.2 | 16.906 ns | 0.0383 ns | 0.0339 ns | 16.914 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 3.0 | 16.996 ns | 0.1071 ns | 0.1002 ns | 16.954 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net461 | 27.790 ns | 0.0791 ns | 0.0740 ns | 27.763 ns |  1.45 |    0.01 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net472 | 28.000 ns | 0.0511 ns | 0.0426 ns | 28.006 ns |  1.46 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_ConvertibleClass_NoValue | .NET Core 2.0 | 16.066 ns | 0.0321 ns | 0.0285 ns | 16.068 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 2.2 | 13.419 ns | 0.0200 ns | 0.0187 ns | 13.416 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 3.0 | 13.189 ns | 0.1519 ns | 0.1421 ns | 13.242 ns |  0.82 |    0.01 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net461 | 23.875 ns | 0.0493 ns | 0.0385 ns | 23.871 ns |  1.49 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net472 | 22.236 ns | 0.0278 ns | 0.0260 ns | 22.231 ns |  1.38 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.0 | 14.845 ns | 0.0328 ns | 0.0256 ns | 14.847 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.2 | 13.182 ns | 0.1118 ns | 0.0991 ns | 13.229 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 3.0 | 13.664 ns | 0.0717 ns | 0.0670 ns | 13.678 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net461 | 24.152 ns | 0.1373 ns | 0.1284 ns | 24.211 ns |  1.63 |    0.01 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net472 | 26.125 ns | 0.0765 ns | 0.0715 ns | 26.134 ns |  1.76 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                              From_NonConvertibleClass | .NET Core 2.0 | 14.327 ns | 0.1204 ns | 0.1127 ns | 14.381 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 2.2 | 12.768 ns | 0.0237 ns | 0.0221 ns | 12.768 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 3.0 | 12.554 ns | 0.0187 ns | 0.0166 ns | 12.553 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net461 | 14.383 ns | 0.0303 ns | 0.0253 ns | 14.386 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net472 | 15.918 ns | 0.1349 ns | 0.1262 ns | 15.859 ns |  1.11 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                     From_NonConvertibleClass_AsObject | .NET Core 2.0 | 16.632 ns | 0.0290 ns | 0.0257 ns | 16.633 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 2.2 | 15.479 ns | 0.0135 ns | 0.0119 ns | 15.476 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 3.0 | 15.326 ns | 0.0459 ns | 0.0383 ns | 15.311 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net461 | 25.347 ns | 0.0554 ns | 0.0433 ns | 25.349 ns |  1.52 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net472 | 25.662 ns | 0.0275 ns | 0.0257 ns | 25.669 ns |  1.54 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                      From_NonConvertibleClass_NoValue | .NET Core 2.0 | 13.922 ns | 0.0178 ns | 0.0148 ns | 13.927 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 2.2 | 12.929 ns | 0.1158 ns | 0.1026 ns | 12.966 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 3.0 | 12.707 ns | 0.0926 ns | 0.0866 ns | 12.734 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net461 | 14.382 ns | 0.0196 ns | 0.0173 ns | 14.373 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net472 | 16.737 ns | 0.1816 ns | 0.1698 ns | 16.655 ns |  1.20 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.0 | 14.886 ns | 0.0237 ns | 0.0221 ns | 14.882 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.2 | 12.997 ns | 0.0220 ns | 0.0195 ns | 12.994 ns |  0.87 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 3.0 | 13.658 ns | 0.2533 ns | 0.2369 ns | 13.504 ns |  0.92 |    0.02 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net461 | 22.145 ns | 0.0284 ns | 0.0266 ns | 22.155 ns |  1.49 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net472 | 24.221 ns | 0.0289 ns | 0.0270 ns | 24.213 ns |  1.63 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                From_ConvertibleStruct | .NET Core 2.0 | 20.394 ns | 0.0279 ns | 0.0247 ns | 20.394 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 2.2 | 16.446 ns | 0.1021 ns | 0.0955 ns | 16.403 ns |  0.81 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 3.0 | 13.993 ns | 0.1093 ns | 0.1022 ns | 13.980 ns |  0.69 |    0.01 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net461 | 20.046 ns | 0.0388 ns | 0.0344 ns | 20.035 ns |  0.98 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net472 | 18.736 ns | 0.0303 ns | 0.0283 ns | 18.739 ns |  0.92 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                       From_ConvertibleStruct_AsObject | .NET Core 2.0 | 21.559 ns | 0.1361 ns | 0.1273 ns | 21.502 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 2.2 | 17.554 ns | 0.0181 ns | 0.0169 ns | 17.551 ns |  0.81 |    0.01 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 3.0 | 19.452 ns | 0.1564 ns | 0.1463 ns | 19.500 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net461 | 28.293 ns | 0.0345 ns | 0.0305 ns | 28.290 ns |  1.31 |    0.01 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net472 | 28.810 ns | 0.0509 ns | 0.0452 ns | 28.811 ns |  1.34 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.0 | 20.412 ns | 0.0628 ns | 0.0587 ns | 20.408 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.2 | 16.557 ns | 0.0479 ns | 0.0400 ns | 16.567 ns |  0.81 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 3.0 | 14.561 ns | 0.1004 ns | 0.0890 ns | 14.542 ns |  0.71 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net461 | 27.608 ns | 0.0457 ns | 0.0382 ns | 27.613 ns |  1.35 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net472 | 27.131 ns | 0.2777 ns | 0.2598 ns | 26.947 ns |  1.33 |    0.02 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.566 ns | 0.0432 ns | 0.0360 ns | 19.562 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.213 ns | 0.0170 ns | 0.0159 ns | 17.212 ns |  0.88 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.446 ns | 0.0467 ns | 0.0365 ns | 17.441 ns |  0.89 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net461 | 26.989 ns | 0.1556 ns | 0.1455 ns | 26.983 ns |  1.38 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net472 | 28.650 ns | 0.0448 ns | 0.0397 ns | 28.652 ns |  1.46 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.0 | 13.925 ns | 0.0143 ns | 0.0127 ns | 13.924 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.2 | 12.241 ns | 0.0884 ns | 0.0738 ns | 12.268 ns |  0.88 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 3.0 | 10.338 ns | 0.0636 ns | 0.0595 ns | 10.359 ns |  0.74 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net461 | 23.490 ns | 0.0324 ns | 0.0270 ns | 23.493 ns |  1.69 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net472 | 19.195 ns | 0.0277 ns | 0.0216 ns | 19.199 ns |  1.38 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 16.139 ns | 0.0394 ns | 0.0350 ns | 16.135 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.990 ns | 0.0186 ns | 0.0174 ns | 12.990 ns |  0.80 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.462 ns | 0.0508 ns | 0.0475 ns | 13.445 ns |  0.83 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net461 | 21.950 ns | 0.0948 ns | 0.0886 ns | 21.909 ns |  1.36 |    0.01 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net472 | 26.096 ns | 0.0350 ns | 0.0273 ns | 26.094 ns |  1.62 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_NonConvertibleStruct | .NET Core 2.0 | 13.202 ns | 0.0214 ns | 0.0178 ns | 13.205 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 2.2 | 11.465 ns | 0.0169 ns | 0.0150 ns | 11.462 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 3.0 | 10.760 ns | 0.2418 ns | 0.5100 ns | 10.955 ns |  0.76 |    0.05 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net461 | 13.764 ns | 0.0964 ns | 0.0854 ns | 13.733 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net472 | 13.478 ns | 0.0144 ns | 0.0135 ns | 13.476 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.0 | 22.597 ns | 0.4518 ns | 1.0998 ns | 22.576 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.2 | 14.837 ns | 0.0405 ns | 0.0379 ns | 14.838 ns |  0.67 |    0.03 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 3.0 | 15.980 ns | 0.2449 ns | 0.2291 ns | 15.977 ns |  0.72 |    0.04 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net461 | 24.311 ns | 0.1257 ns | 0.1176 ns | 24.344 ns |  1.09 |    0.05 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net472 | 26.941 ns | 0.0512 ns | 0.0454 ns | 26.927 ns |  1.21 |    0.06 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.0 | 13.542 ns | 0.0254 ns | 0.0212 ns | 13.542 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.2 | 11.529 ns | 0.0305 ns | 0.0285 ns | 11.526 ns |  0.85 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 3.0 |  9.761 ns | 0.0156 ns | 0.0139 ns |  9.759 ns |  0.72 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net461 | 13.735 ns | 0.0798 ns | 0.0708 ns | 13.710 ns |  1.01 |    0.01 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net472 | 12.287 ns | 0.0191 ns | 0.0179 ns | 12.291 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 16.628 ns | 0.0230 ns | 0.0204 ns | 16.620 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.234 ns | 0.0993 ns | 0.0929 ns | 15.230 ns |  0.92 |    0.01 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.310 ns | 0.0214 ns | 0.0167 ns | 15.310 ns |  0.92 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net461 | 23.730 ns | 0.0440 ns | 0.0344 ns | 23.733 ns |  1.43 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net472 | 25.692 ns | 0.0688 ns | 0.0610 ns | 25.684 ns |  1.55 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.0 | 13.279 ns | 0.0993 ns | 0.0929 ns | 13.232 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.2 | 11.407 ns | 0.0255 ns | 0.0213 ns | 11.408 ns |  0.86 |    0.01 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 3.0 |  9.609 ns | 0.0847 ns | 0.0792 ns |  9.651 ns |  0.72 |    0.01 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net461 | 13.214 ns | 0.1047 ns | 0.0928 ns | 13.230 ns |  1.00 |    0.01 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net472 | 12.284 ns | 0.0155 ns | 0.0145 ns | 12.285 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.875 ns | 0.0309 ns | 0.0289 ns | 14.882 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.463 ns | 0.0139 ns | 0.0130 ns | 14.462 ns |  0.97 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.432 ns | 0.0171 ns | 0.0152 ns | 13.430 ns |  0.90 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net461 | 23.986 ns | 0.0298 ns | 0.0264 ns | 23.985 ns |  1.61 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net472 | 26.214 ns | 0.0591 ns | 0.0524 ns | 26.206 ns |  1.76 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Enum | .NET Core 2.0 | 13.193 ns | 0.0141 ns | 0.0125 ns | 13.191 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 2.2 | 11.963 ns | 0.1189 ns | 0.1112 ns | 12.017 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 3.0 |  9.516 ns | 0.0204 ns | 0.0170 ns |  9.512 ns |  0.72 |    0.00 |      - |     - |     - |         - |
                                             From_Enum |        net461 | 13.008 ns | 0.0168 ns | 0.0140 ns | 13.008 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                             From_Enum |        net472 | 13.063 ns | 0.0245 ns | 0.0230 ns | 13.062 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Enum_AsObject | .NET Core 2.0 | 45.751 ns | 0.3544 ns | 0.3315 ns | 45.593 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject | .NET Core 2.2 | 47.621 ns | 0.1149 ns | 0.1075 ns | 47.609 ns |  1.04 |    0.01 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject | .NET Core 3.0 | 38.940 ns | 0.7072 ns | 0.6269 ns | 39.173 ns |  0.85 |    0.01 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject |        net461 | 50.693 ns | 0.1041 ns | 0.0923 ns | 50.691 ns |  1.11 |    0.01 | 0.0037 |     - |     - |      24 B |
                                    From_Enum_AsObject |        net472 | 56.024 ns | 0.0705 ns | 0.0625 ns | 56.028 ns |  1.22 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Enum_Nullable_WithValue | .NET Core 2.0 | 13.447 ns | 0.0181 ns | 0.0161 ns | 13.442 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 2.2 | 10.670 ns | 0.0142 ns | 0.0126 ns | 10.669 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 3.0 |  9.993 ns | 0.0156 ns | 0.0138 ns |  9.994 ns |  0.74 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net461 | 14.169 ns | 0.0294 ns | 0.0260 ns | 14.172 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net472 | 13.589 ns | 0.1278 ns | 0.1196 ns | 13.541 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.0 | 46.921 ns | 0.3917 ns | 0.3664 ns | 46.790 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.2 | 48.229 ns | 0.4269 ns | 0.3993 ns | 48.314 ns |  1.03 |    0.01 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 3.0 | 38.517 ns | 0.7857 ns | 0.9649 ns | 39.211 ns |  0.83 |    0.01 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject |        net461 | 50.794 ns | 0.1226 ns | 0.1147 ns | 50.786 ns |  1.08 |    0.01 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject |        net472 | 53.461 ns | 0.0649 ns | 0.0575 ns | 53.484 ns |  1.14 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Enum_Nullable_NoValue | .NET Core 2.0 | 13.222 ns | 0.0129 ns | 0.0115 ns | 13.227 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 2.2 | 11.695 ns | 0.0221 ns | 0.0207 ns | 11.689 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 3.0 |  9.531 ns | 0.0156 ns | 0.0146 ns |  9.531 ns |  0.72 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net461 | 13.467 ns | 0.0096 ns | 0.0080 ns | 13.467 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net472 | 13.512 ns | 0.0136 ns | 0.0121 ns | 13.510 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.507 ns | 0.0256 ns | 0.0240 ns | 15.517 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.978 ns | 0.0208 ns | 0.0173 ns | 12.976 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.903 ns | 0.2380 ns | 0.2226 ns | 13.737 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net461 | 22.093 ns | 0.0339 ns | 0.0283 ns | 22.084 ns |  1.42 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net472 | 25.313 ns | 0.0369 ns | 0.0288 ns | 25.312 ns |  1.63 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                      From_ParentClass | .NET Core 2.0 | 14.077 ns | 0.0998 ns | 0.0933 ns | 14.127 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 2.2 | 12.724 ns | 0.0274 ns | 0.0256 ns | 12.722 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 3.0 | 12.538 ns | 0.0224 ns | 0.0210 ns | 12.530 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                                      From_ParentClass |        net461 | 14.533 ns | 0.1332 ns | 0.1181 ns | 14.601 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                      From_ParentClass |        net472 | 14.375 ns | 0.0064 ns | 0.0054 ns | 14.376 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_ParentClass_AsObject | .NET Core 2.0 | 17.841 ns | 0.0320 ns | 0.0300 ns | 17.837 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 2.2 | 15.371 ns | 0.1012 ns | 0.0947 ns | 15.352 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 3.0 | 15.827 ns | 0.3403 ns | 0.5094 ns | 15.507 ns |  0.91 |    0.03 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net461 | 23.972 ns | 0.0260 ns | 0.0244 ns | 23.970 ns |  1.34 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net472 | 27.797 ns | 0.0417 ns | 0.0369 ns | 27.796 ns |  1.56 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                              From_ParentClass_NoValue | .NET Core 2.0 | 14.082 ns | 0.1214 ns | 0.1136 ns | 14.156 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 2.2 | 12.744 ns | 0.0214 ns | 0.0189 ns | 12.738 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 3.0 | 12.573 ns | 0.0269 ns | 0.0225 ns | 12.579 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net461 | 14.488 ns | 0.1314 ns | 0.1229 ns | 14.414 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net472 | 16.012 ns | 0.0512 ns | 0.0428 ns | 16.016 ns |  1.14 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.0 | 14.872 ns | 0.0219 ns | 0.0205 ns | 14.873 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.2 | 14.213 ns | 0.0191 ns | 0.0170 ns | 14.216 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 3.0 | 13.434 ns | 0.0342 ns | 0.0286 ns | 13.430 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net461 | 23.981 ns | 0.0230 ns | 0.0203 ns | 23.978 ns |  1.61 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net472 | 26.567 ns | 0.0355 ns | 0.0315 ns | 26.568 ns |  1.79 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_ParentStruct | .NET Core 2.0 | 43.025 ns | 0.0925 ns | 0.0820 ns | 43.021 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 2.2 | 41.352 ns | 0.3503 ns | 0.3277 ns | 41.496 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 3.0 | 42.767 ns | 0.6807 ns | 0.6034 ns | 43.048 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                                     From_ParentStruct |        net461 | 47.359 ns | 0.3726 ns | 0.3485 ns | 47.198 ns |  1.10 |    0.01 |      - |     - |     - |         - |
                                     From_ParentStruct |        net472 | 41.814 ns | 0.3906 ns | 0.3654 ns | 42.033 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_ParentStruct_AsObject | .NET Core 2.0 | 17.401 ns | 0.1505 ns | 0.1407 ns | 17.332 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 2.2 | 15.343 ns | 0.0379 ns | 0.0354 ns | 15.348 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 3.0 | 17.286 ns | 0.1172 ns | 0.1039 ns | 17.324 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net461 | 24.187 ns | 0.2488 ns | 0.2327 ns | 24.312 ns |  1.39 |    0.02 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net472 | 28.154 ns | 0.1751 ns | 0.1462 ns | 28.213 ns |  1.62 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.0 | 42.782 ns | 0.0877 ns | 0.0820 ns | 42.747 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.2 | 40.454 ns | 0.0276 ns | 0.0245 ns | 40.447 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 3.0 | 37.689 ns | 0.0637 ns | 0.0565 ns | 37.706 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue |        net461 | 41.820 ns | 0.3137 ns | 0.2934 ns | 41.625 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue |        net472 | 42.147 ns | 0.1277 ns | 0.1195 ns | 42.122 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 17.248 ns | 0.0394 ns | 0.0329 ns | 17.253 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.679 ns | 0.0811 ns | 0.0677 ns | 15.699 ns |  0.91 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.516 ns | 0.0351 ns | 0.0274 ns | 15.511 ns |  0.90 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net461 | 24.331 ns | 0.0348 ns | 0.0326 ns | 24.321 ns |  1.41 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net472 | 27.122 ns | 0.0533 ns | 0.0445 ns | 27.108 ns |  1.57 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.0 | 48.968 ns | 0.4160 ns | 0.3891 ns | 49.249 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.2 | 40.128 ns | 0.0520 ns | 0.0486 ns | 40.114 ns |  0.82 |    0.01 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 3.0 | 38.870 ns | 0.2554 ns | 0.2389 ns | 38.953 ns |  0.79 |    0.01 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net461 | 44.181 ns | 0.0749 ns | 0.0585 ns | 44.177 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net472 | 43.261 ns | 0.0480 ns | 0.0426 ns | 43.257 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.140 ns | 0.0300 ns | 0.0281 ns | 15.146 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.986 ns | 0.0278 ns | 0.0246 ns | 12.978 ns |  0.86 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.710 ns | 0.0319 ns | 0.0283 ns | 13.707 ns |  0.91 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net461 | 22.446 ns | 0.0461 ns | 0.0432 ns | 22.449 ns |  1.48 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net472 | 26.159 ns | 0.0429 ns | 0.0380 ns | 26.167 ns |  1.73 |    0.00 |      - |     - |     - |         - |

Benchmarks with issues:
  ConvertTo_BoolNullable.From_Char_AsObject: Job-LRKCAO(Toolchain=.NET Core 2.0)
  ConvertTo_BoolNullable.From_Char_AsObject: Job-VAJWLV(Toolchain=.NET Core 2.2)
  ConvertTo_BoolNullable.From_Char_AsObject: Job-TJIRAH(Toolchain=.NET Core 3.0)
  ConvertTo_BoolNullable.From_Char_AsObject: Job-HBFVIR(Toolchain=net461)
  ConvertTo_BoolNullable.From_Char_AsObject: Job-YRWWQX(Toolchain=net472)
  ConvertTo_BoolNullable.From_Char_Nullable_WithValue_AsObject: Job-LRKCAO(Toolchain=.NET Core 2.0)
  ConvertTo_BoolNullable.From_Char_Nullable_WithValue_AsObject: Job-VAJWLV(Toolchain=.NET Core 2.2)
  ConvertTo_BoolNullable.From_Char_Nullable_WithValue_AsObject: Job-TJIRAH(Toolchain=.NET Core 3.0)
  ConvertTo_BoolNullable.From_Char_Nullable_WithValue_AsObject: Job-HBFVIR(Toolchain=net461)
  ConvertTo_BoolNullable.From_Char_Nullable_WithValue_AsObject: Job-YRWWQX(Toolchain=net472)
  ConvertTo_BoolNullable.From_DateTime_AsObject: Job-LRKCAO(Toolchain=.NET Core 2.0)
  ConvertTo_BoolNullable.From_DateTime_AsObject: Job-VAJWLV(Toolchain=.NET Core 2.2)
  ConvertTo_BoolNullable.From_DateTime_AsObject: Job-TJIRAH(Toolchain=.NET Core 3.0)
  ConvertTo_BoolNullable.From_DateTime_AsObject: Job-HBFVIR(Toolchain=net461)
  ConvertTo_BoolNullable.From_DateTime_AsObject: Job-YRWWQX(Toolchain=net472)
  ConvertTo_BoolNullable.From_DateTime_Nullable_WithValue_AsObject: Job-LRKCAO(Toolchain=.NET Core 2.0)
  ConvertTo_BoolNullable.From_DateTime_Nullable_WithValue_AsObject: Job-VAJWLV(Toolchain=.NET Core 2.2)
  ConvertTo_BoolNullable.From_DateTime_Nullable_WithValue_AsObject: Job-TJIRAH(Toolchain=.NET Core 3.0)
  ConvertTo_BoolNullable.From_DateTime_Nullable_WithValue_AsObject: Job-HBFVIR(Toolchain=net461)
  ConvertTo_BoolNullable.From_DateTime_Nullable_WithValue_AsObject: Job-YRWWQX(Toolchain=net472)
  ConvertTo_BoolNullable.From_String_Empty_AsObject: Job-LRKCAO(Toolchain=.NET Core 2.0)
  ConvertTo_BoolNullable.From_String_Empty_AsObject: Job-VAJWLV(Toolchain=.NET Core 2.2)
  ConvertTo_BoolNullable.From_String_Empty_AsObject: Job-TJIRAH(Toolchain=.NET Core 3.0)
  ConvertTo_BoolNullable.From_String_Empty_AsObject: Job-HBFVIR(Toolchain=net461)
  ConvertTo_BoolNullable.From_String_Empty_AsObject: Job-YRWWQX(Toolchain=net472)
