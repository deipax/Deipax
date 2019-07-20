
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
                                             From_Bool | .NET Core 2.0 | 12.182 ns | 0.0842 ns | 0.0747 ns | 12.208 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 2.2 | 10.654 ns | 0.0271 ns | 0.0240 ns | 10.652 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 3.0 |  6.758 ns | 0.0091 ns | 0.0081 ns |  6.758 ns |  0.55 |    0.00 |      - |     - |     - |         - |
                                             From_Bool |        net461 | 12.082 ns | 0.0275 ns | 0.0258 ns | 12.072 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                                             From_Bool |        net472 | 10.556 ns | 0.0886 ns | 0.0785 ns | 10.553 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Bool_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Bool_Nullable_WithValue | .NET Core 2.0 | 11.619 ns | 0.1187 ns | 0.1111 ns | 11.555 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 2.2 | 10.645 ns | 0.0320 ns | 0.0284 ns | 10.638 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 3.0 |  7.063 ns | 0.2658 ns | 0.4792 ns |  6.791 ns |  0.65 |    0.05 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net461 | 12.531 ns | 0.0078 ns | 0.0065 ns | 12.530 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net472 | 10.708 ns | 0.1706 ns | 0.1595 ns | 10.747 ns |  0.92 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Bool_Nullable_NoValue | .NET Core 2.0 | 11.569 ns | 0.0392 ns | 0.0367 ns | 11.557 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 2.2 | 11.288 ns | 0.0304 ns | 0.0285 ns | 11.286 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 3.0 |  6.898 ns | 0.0211 ns | 0.0176 ns |  6.904 ns |  0.60 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net461 | 12.743 ns | 0.1916 ns | 0.1698 ns | 12.677 ns |  1.10 |    0.02 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net472 | 10.420 ns | 0.1021 ns | 0.0955 ns | 10.371 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.392 ns | 0.0246 ns | 0.0218 ns | 14.387 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.925 ns | 0.0138 ns | 0.0122 ns | 11.927 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.768 ns | 0.0262 ns | 0.0245 ns | 13.759 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net461 | 13.382 ns | 0.0542 ns | 0.0507 ns | 13.360 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net472 | 16.849 ns | 0.1771 ns | 0.1656 ns | 16.786 ns |  1.17 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Byte | .NET Core 2.0 | 12.256 ns | 0.0153 ns | 0.0136 ns | 12.253 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 2.2 | 10.784 ns | 0.0715 ns | 0.0669 ns | 10.810 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 3.0 |  6.586 ns | 0.0149 ns | 0.0132 ns |  6.588 ns |  0.54 |    0.00 |      - |     - |     - |         - |
                                             From_Byte |        net461 | 11.773 ns | 0.0613 ns | 0.0543 ns | 11.751 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                             From_Byte |        net472 | 10.638 ns | 0.1897 ns | 0.1775 ns | 10.569 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Byte_AsObject | .NET Core 2.0 | 18.022 ns | 0.0189 ns | 0.0158 ns | 18.021 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 2.2 | 15.312 ns | 0.0167 ns | 0.0140 ns | 15.314 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 3.0 | 15.550 ns | 0.0825 ns | 0.0772 ns | 15.571 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net461 | 18.994 ns | 0.1324 ns | 0.1238 ns | 18.960 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net472 | 20.718 ns | 0.2608 ns | 0.2312 ns | 20.781 ns |  1.15 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Byte_Nullable_WithValue | .NET Core 2.0 | 11.886 ns | 0.0427 ns | 0.0379 ns | 11.879 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 2.2 | 10.868 ns | 0.0121 ns | 0.0101 ns | 10.868 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 3.0 |  7.063 ns | 0.0267 ns | 0.0237 ns |  7.056 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net461 | 13.215 ns | 0.0442 ns | 0.0392 ns | 13.203 ns |  1.11 |    0.01 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net472 | 10.599 ns | 0.0613 ns | 0.0512 ns | 10.585 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.773 ns | 0.1176 ns | 0.1043 ns | 18.808 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.068 ns | 0.0425 ns | 0.0376 ns | 15.088 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.145 ns | 0.1318 ns | 0.1233 ns | 15.215 ns |  0.81 |    0.01 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net461 | 18.847 ns | 0.0181 ns | 0.0151 ns | 18.842 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net472 | 21.479 ns | 0.1824 ns | 0.1707 ns | 21.475 ns |  1.14 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Byte_Nullable_NoValue | .NET Core 2.0 | 12.040 ns | 0.0301 ns | 0.0267 ns | 12.039 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 2.2 | 10.742 ns | 0.0200 ns | 0.0177 ns | 10.740 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 3.0 |  8.154 ns | 0.0596 ns | 0.0557 ns |  8.158 ns |  0.68 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net461 | 11.915 ns | 0.0284 ns | 0.0252 ns | 11.918 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net472 | 10.453 ns | 0.1334 ns | 0.1248 ns | 10.407 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.033 ns | 0.0233 ns | 0.0207 ns | 14.034 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.116 ns | 0.0272 ns | 0.0241 ns | 12.122 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.004 ns | 0.0178 ns | 0.0158 ns | 12.004 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net461 | 13.267 ns | 0.0167 ns | 0.0148 ns | 13.266 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net472 | 17.178 ns | 0.0234 ns | 0.0196 ns | 17.178 ns |  1.22 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Char | .NET Core 2.0 | 12.398 ns | 0.0399 ns | 0.0333 ns | 12.394 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Char | .NET Core 2.2 | 10.266 ns | 0.0199 ns | 0.0186 ns | 10.267 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                             From_Char | .NET Core 3.0 |  7.147 ns | 0.1689 ns | 0.2679 ns |  7.243 ns |  0.56 |    0.03 |      - |     - |     - |         - |
                                             From_Char |        net461 | 10.394 ns | 0.0916 ns | 0.0812 ns | 10.358 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                                             From_Char |        net472 | 10.548 ns | 0.1147 ns | 0.1073 ns | 10.629 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Char_AsObject | .NET Core 2.0 | 15.742 ns | 0.0234 ns | 0.0207 ns | 15.739 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 2.2 | 12.516 ns | 0.0133 ns | 0.0124 ns | 12.514 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 3.0 | 12.675 ns | 0.1411 ns | 0.1320 ns | 12.747 ns |  0.81 |    0.01 |      - |     - |     - |         - |
                                    From_Char_AsObject |        net461 | 14.446 ns | 0.0226 ns | 0.0200 ns | 14.451 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject |        net472 | 16.483 ns | 0.0411 ns | 0.0343 ns | 16.478 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Char_Nullable_WithValue | .NET Core 2.0 | 13.018 ns | 0.0132 ns | 0.0117 ns | 13.022 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 2.2 | 10.563 ns | 0.1015 ns | 0.0949 ns | 10.604 ns |  0.81 |    0.01 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 3.0 |  7.691 ns | 0.1746 ns | 0.1941 ns |  7.825 ns |  0.59 |    0.02 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net461 | 10.640 ns | 0.0186 ns | 0.0174 ns | 10.642 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net472 | 10.549 ns | 0.0232 ns | 0.0193 ns | 10.553 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.0 | 14.949 ns | 0.0763 ns | 0.0713 ns | 14.964 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.2 | 12.530 ns | 0.0127 ns | 0.0113 ns | 12.531 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 3.0 | 13.319 ns | 0.2759 ns | 0.2952 ns | 13.424 ns |  0.89 |    0.02 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net461 | 14.523 ns | 0.0235 ns | 0.0208 ns | 14.526 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net472 | 16.813 ns | 0.1115 ns | 0.1043 ns | 16.830 ns |  1.12 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Char_Nullable_NoValue | .NET Core 2.0 | 12.182 ns | 0.1102 ns | 0.1031 ns | 12.182 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 2.2 | 11.629 ns | 0.1203 ns | 0.1125 ns | 11.682 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 3.0 |  7.663 ns | 0.0930 ns | 0.0870 ns |  7.702 ns |  0.63 |    0.01 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net461 | 11.952 ns | 0.0247 ns | 0.0219 ns | 11.944 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net472 | 12.235 ns | 0.0266 ns | 0.0249 ns | 12.226 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.0 | 16.973 ns | 0.0699 ns | 0.0654 ns | 17.003 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.942 ns | 0.0422 ns | 0.0394 ns | 11.925 ns |  0.70 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.180 ns | 0.1495 ns | 0.1398 ns | 12.225 ns |  0.72 |    0.01 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net461 | 13.337 ns | 0.1197 ns | 0.1120 ns | 13.284 ns |  0.79 |    0.01 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net472 | 17.284 ns | 0.0208 ns | 0.0174 ns | 17.286 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                         From_DateTime | .NET Core 2.0 | 11.900 ns | 0.0149 ns | 0.0124 ns | 11.902 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 2.2 | 12.123 ns | 0.0439 ns | 0.0410 ns | 12.104 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 3.0 |  7.687 ns | 0.0158 ns | 0.0140 ns |  7.690 ns |  0.65 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime |        net461 | 13.469 ns | 0.0681 ns | 0.0637 ns | 13.447 ns |  1.13 |    0.01 |      - |     - |     - |         - |
                                         From_DateTime |        net472 | 12.988 ns | 0.0277 ns | 0.0259 ns | 12.990 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                From_DateTime_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                      From_DateTime_Nullable_WithValue | .NET Core 2.0 | 12.596 ns | 0.0294 ns | 0.0275 ns | 12.590 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 2.2 | 11.827 ns | 0.0316 ns | 0.0280 ns | 11.820 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 3.0 |  7.876 ns | 0.0169 ns | 0.0158 ns |  7.881 ns |  0.63 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net461 | 13.397 ns | 0.0332 ns | 0.0310 ns | 13.398 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net472 | 12.684 ns | 0.0149 ns | 0.0116 ns | 12.682 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_DateTime_Nullable_NoValue | .NET Core 2.0 | 12.591 ns | 0.0327 ns | 0.0306 ns | 12.579 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 2.2 | 11.817 ns | 0.0330 ns | 0.0308 ns | 11.807 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 3.0 |  8.037 ns | 0.1849 ns | 0.1816 ns |  7.926 ns |  0.64 |    0.02 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net461 | 13.365 ns | 0.0246 ns | 0.0205 ns | 13.361 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net472 | 12.664 ns | 0.0275 ns | 0.0215 ns | 12.655 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.0 | 16.671 ns | 0.0237 ns | 0.0198 ns | 16.663 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.917 ns | 0.0291 ns | 0.0243 ns | 11.909 ns |  0.71 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.016 ns | 0.0376 ns | 0.0314 ns | 12.015 ns |  0.72 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net461 | 13.280 ns | 0.0230 ns | 0.0179 ns | 13.276 ns |  0.80 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net472 | 15.992 ns | 0.1425 ns | 0.1263 ns | 16.016 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                          From_Decimal | .NET Core 2.0 | 12.580 ns | 0.0261 ns | 0.0204 ns | 12.576 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 2.2 | 11.784 ns | 0.0181 ns | 0.0160 ns | 11.786 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 3.0 |  8.093 ns | 0.0982 ns | 0.0919 ns |  8.138 ns |  0.64 |    0.01 |      - |     - |     - |         - |
                                          From_Decimal |        net461 | 13.950 ns | 0.0145 ns | 0.0135 ns | 13.951 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal |        net472 | 12.756 ns | 0.0602 ns | 0.0563 ns | 12.760 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                 From_Decimal_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                       From_Decimal_Nullable_WithValue | .NET Core 2.0 | 12.537 ns | 0.0193 ns | 0.0180 ns | 12.537 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 2.2 | 11.712 ns | 0.0218 ns | 0.0204 ns | 11.707 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 3.0 |  9.269 ns | 0.2112 ns | 0.4168 ns |  9.406 ns |  0.72 |    0.05 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net461 | 14.089 ns | 0.1082 ns | 0.1012 ns | 14.065 ns |  1.12 |    0.01 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net472 | 13.591 ns | 0.0820 ns | 0.0727 ns | 13.599 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Decimal_Nullable_NoValue | .NET Core 2.0 | 12.529 ns | 0.0189 ns | 0.0168 ns | 12.526 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 2.2 | 12.630 ns | 0.0434 ns | 0.0385 ns | 12.623 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 3.0 |  8.175 ns | 0.1615 ns | 0.1511 ns |  8.274 ns |  0.65 |    0.01 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net461 | 14.835 ns | 0.1512 ns | 0.1262 ns | 14.888 ns |  1.18 |    0.01 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net472 | 13.292 ns | 0.0307 ns | 0.0272 ns | 13.291 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.006 ns | 0.0311 ns | 0.0259 ns | 15.010 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.914 ns | 0.0313 ns | 0.0277 ns | 11.906 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.618 ns | 0.3095 ns | 0.4131 ns | 14.838 ns |  0.96 |    0.03 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net461 | 13.286 ns | 0.0761 ns | 0.0675 ns | 13.259 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net472 | 16.863 ns | 0.1256 ns | 0.1049 ns | 16.906 ns |  1.12 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_Double | .NET Core 2.0 | 11.711 ns | 0.0264 ns | 0.0221 ns | 11.703 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 2.2 | 11.646 ns | 0.0450 ns | 0.0421 ns | 11.631 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 3.0 |  7.327 ns | 0.1649 ns | 0.1620 ns |  7.253 ns |  0.63 |    0.01 |      - |     - |     - |         - |
                                           From_Double |        net461 | 12.923 ns | 0.0202 ns | 0.0179 ns | 12.925 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                           From_Double |        net472 | 10.505 ns | 0.0266 ns | 0.0236 ns | 10.508 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_Double_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                  From_Double_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                  From_Double_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_Double_Nullable_WithValue | .NET Core 2.0 | 12.773 ns | 0.0175 ns | 0.0164 ns | 12.778 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 2.2 | 11.813 ns | 0.0262 ns | 0.0245 ns | 11.814 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 3.0 |  9.175 ns | 0.2096 ns | 0.3937 ns |  9.298 ns |  0.70 |    0.05 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net461 | 14.336 ns | 0.2727 ns | 0.2417 ns | 14.317 ns |  1.12 |    0.02 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net472 | 12.941 ns | 0.0819 ns | 0.0766 ns | 12.952 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Double_Nullable_NoValue | .NET Core 2.0 | 12.595 ns | 0.0125 ns | 0.0117 ns | 12.597 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 2.2 | 11.819 ns | 0.0325 ns | 0.0288 ns | 11.818 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 3.0 |  7.998 ns | 0.0097 ns | 0.0091 ns |  7.999 ns |  0.63 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net461 | 14.365 ns | 0.1839 ns | 0.1721 ns | 14.385 ns |  1.14 |    0.01 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net472 | 12.663 ns | 0.0098 ns | 0.0076 ns | 12.667 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.316 ns | 0.1227 ns | 0.1024 ns | 14.369 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.935 ns | 0.0286 ns | 0.0253 ns | 11.937 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.517 ns | 0.0989 ns | 0.0825 ns | 13.543 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net461 | 13.460 ns | 0.0606 ns | 0.0567 ns | 13.444 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net472 | 15.933 ns | 0.0777 ns | 0.0649 ns | 15.928 ns |  1.11 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_Short | .NET Core 2.0 | 11.690 ns | 0.0206 ns | 0.0183 ns | 11.696 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 2.2 | 10.837 ns | 0.0289 ns | 0.0257 ns | 10.837 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 3.0 |  7.136 ns | 0.1672 ns | 0.2972 ns |  7.290 ns |  0.59 |    0.03 |      - |     - |     - |         - |
                                            From_Short |        net461 | 12.369 ns | 0.0563 ns | 0.0526 ns | 12.367 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                                            From_Short |        net472 | 10.995 ns | 0.0188 ns | 0.0167 ns | 10.998 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_Short_AsObject | .NET Core 2.0 | 18.376 ns | 0.0438 ns | 0.0366 ns | 18.378 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 2.2 | 15.555 ns | 0.0136 ns | 0.0121 ns | 15.554 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 3.0 | 15.604 ns | 0.1783 ns | 0.1581 ns | 15.669 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net461 | 19.802 ns | 0.1696 ns | 0.1503 ns | 19.754 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net472 | 20.669 ns | 0.0312 ns | 0.0276 ns | 20.668 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Short_Nullable_WithValue | .NET Core 2.0 | 11.957 ns | 0.0202 ns | 0.0179 ns | 11.954 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 2.2 | 11.073 ns | 0.0947 ns | 0.0886 ns | 11.032 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 3.0 |  7.335 ns | 0.0985 ns | 0.0922 ns |  7.305 ns |  0.61 |    0.01 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net461 | 14.144 ns | 0.1268 ns | 0.1186 ns | 14.099 ns |  1.18 |    0.01 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net472 | 12.277 ns | 0.0549 ns | 0.0513 ns | 12.250 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.771 ns | 0.0541 ns | 0.0480 ns | 18.765 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.554 ns | 0.0407 ns | 0.0381 ns | 15.555 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.478 ns | 0.0520 ns | 0.0486 ns | 15.464 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net461 | 19.636 ns | 0.1880 ns | 0.1758 ns | 19.544 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net472 | 21.681 ns | 0.0298 ns | 0.0279 ns | 21.686 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Short_Nullable_NoValue | .NET Core 2.0 | 11.970 ns | 0.1093 ns | 0.1023 ns | 12.000 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 2.2 | 10.807 ns | 0.0353 ns | 0.0330 ns | 10.795 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 3.0 |  6.916 ns | 0.0187 ns | 0.0175 ns |  6.913 ns |  0.58 |    0.01 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net461 | 12.045 ns | 0.0965 ns | 0.0855 ns | 12.030 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net472 | 10.350 ns | 0.0096 ns | 0.0080 ns | 10.351 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.141 ns | 0.0194 ns | 0.0182 ns | 14.136 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.047 ns | 0.1346 ns | 0.1259 ns | 12.064 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.017 ns | 0.0135 ns | 0.0127 ns | 12.016 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net461 | 13.399 ns | 0.1254 ns | 0.1173 ns | 13.426 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net472 | 16.897 ns | 0.0977 ns | 0.0763 ns | 16.915 ns |  1.20 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                              From_Int | .NET Core 2.0 | 11.950 ns | 0.0158 ns | 0.0148 ns | 11.948 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 2.2 | 11.406 ns | 0.0148 ns | 0.0139 ns | 11.409 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 3.0 |  7.285 ns | 0.0216 ns | 0.0191 ns |  7.284 ns |  0.61 |    0.00 |      - |     - |     - |         - |
                                              From_Int |        net461 | 13.307 ns | 0.0777 ns | 0.0726 ns | 13.279 ns |  1.11 |    0.01 |      - |     - |     - |         - |
                                              From_Int |        net472 | 11.137 ns | 0.0222 ns | 0.0197 ns | 11.139 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_Int_AsObject | .NET Core 2.0 | 18.907 ns | 0.0383 ns | 0.0358 ns | 18.913 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 2.2 | 16.097 ns | 0.0220 ns | 0.0195 ns | 16.095 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 3.0 | 16.816 ns | 0.2494 ns | 0.2333 ns | 16.826 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net461 | 19.731 ns | 0.1116 ns | 0.0989 ns | 19.708 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net472 | 21.882 ns | 0.0290 ns | 0.0226 ns | 21.891 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Int_Nullable_WithValue | .NET Core 2.0 | 12.707 ns | 0.1133 ns | 0.0946 ns | 12.749 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 2.2 | 12.174 ns | 0.0445 ns | 0.0416 ns | 12.161 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 3.0 |  8.198 ns | 0.0142 ns | 0.0126 ns |  8.198 ns |  0.65 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net461 | 14.732 ns | 0.1661 ns | 0.1554 ns | 14.689 ns |  1.16 |    0.02 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net472 | 12.175 ns | 0.0906 ns | 0.0804 ns | 12.208 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.337 ns | 0.0220 ns | 0.0195 ns | 19.343 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.2 | 16.363 ns | 0.0755 ns | 0.0669 ns | 16.380 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 3.0 | 16.999 ns | 0.1800 ns | 0.1503 ns | 17.020 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net461 | 19.395 ns | 0.0541 ns | 0.0480 ns | 19.384 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net472 | 21.279 ns | 0.0341 ns | 0.0303 ns | 21.273 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_Int_Nullable_NoValue | .NET Core 2.0 | 11.793 ns | 0.0567 ns | 0.0530 ns | 11.777 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 2.2 | 10.756 ns | 0.0160 ns | 0.0150 ns | 10.756 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 3.0 |  6.663 ns | 0.0159 ns | 0.0133 ns |  6.664 ns |  0.57 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net461 | 12.694 ns | 0.1308 ns | 0.1223 ns | 12.633 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net472 | 10.988 ns | 0.0404 ns | 0.0358 ns | 10.975 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.0 | 18.022 ns | 0.0652 ns | 0.0610 ns | 18.001 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.924 ns | 0.0175 ns | 0.0155 ns | 11.922 ns |  0.66 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.317 ns | 0.3034 ns | 0.3726 ns | 14.549 ns |  0.79 |    0.02 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net461 | 15.856 ns | 0.0557 ns | 0.0494 ns | 15.846 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net472 | 17.056 ns | 0.1647 ns | 0.1540 ns | 17.028 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Long | .NET Core 2.0 | 12.133 ns | 0.1073 ns | 0.0952 ns | 12.141 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Long | .NET Core 2.2 | 10.991 ns | 0.0219 ns | 0.0205 ns | 10.991 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                                             From_Long | .NET Core 3.0 |  7.275 ns | 0.0192 ns | 0.0161 ns |  7.276 ns |  0.60 |    0.01 |      - |     - |     - |         - |
                                             From_Long |        net461 | 12.635 ns | 0.0612 ns | 0.0572 ns | 12.624 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                             From_Long |        net472 | 11.131 ns | 0.0718 ns | 0.0672 ns | 11.117 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Long_AsObject | .NET Core 2.0 | 18.660 ns | 0.0367 ns | 0.0326 ns | 18.657 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 2.2 | 15.788 ns | 0.0263 ns | 0.0246 ns | 15.801 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 3.0 | 16.022 ns | 0.1105 ns | 0.0979 ns | 15.982 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net461 | 19.411 ns | 0.0448 ns | 0.0419 ns | 19.394 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net472 | 21.684 ns | 0.0374 ns | 0.0332 ns | 21.668 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Long_Nullable_WithValue | .NET Core 2.0 | 13.553 ns | 0.0399 ns | 0.0354 ns | 13.555 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 2.2 | 13.140 ns | 0.0348 ns | 0.0326 ns | 13.142 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 3.0 | 10.356 ns | 0.0140 ns | 0.0117 ns | 10.350 ns |  0.76 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net461 | 14.772 ns | 0.0641 ns | 0.0568 ns | 14.768 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net472 | 14.100 ns | 0.0587 ns | 0.0549 ns | 14.109 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.809 ns | 0.1179 ns | 0.1045 ns | 18.786 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.796 ns | 0.0175 ns | 0.0155 ns | 15.791 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 3.0 | 16.217 ns | 0.0304 ns | 0.0237 ns | 16.217 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net461 | 22.563 ns | 0.1666 ns | 0.1559 ns | 22.512 ns |  1.20 |    0.01 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net472 | 21.872 ns | 0.0111 ns | 0.0086 ns | 21.874 ns |  1.16 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Long_Nullable_NoValue | .NET Core 2.0 | 12.505 ns | 0.0212 ns | 0.0188 ns | 12.509 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 2.2 | 11.947 ns | 0.1071 ns | 0.1001 ns | 12.005 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 3.0 |  8.271 ns | 0.1776 ns | 0.1662 ns |  8.381 ns |  0.66 |    0.01 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net461 | 14.234 ns | 0.0626 ns | 0.0555 ns | 14.230 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net472 | 13.477 ns | 0.0237 ns | 0.0210 ns | 13.475 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.485 ns | 0.0212 ns | 0.0198 ns | 15.479 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.221 ns | 0.0204 ns | 0.0180 ns | 13.224 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.021 ns | 0.0164 ns | 0.0137 ns | 12.020 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net461 | 13.378 ns | 0.0581 ns | 0.0515 ns | 13.374 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net472 | 14.988 ns | 0.0395 ns | 0.0350 ns | 14.984 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_SByte | .NET Core 2.0 | 11.686 ns | 0.0272 ns | 0.0254 ns | 11.689 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 2.2 | 10.875 ns | 0.0169 ns | 0.0158 ns | 10.870 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 3.0 |  7.258 ns | 0.0657 ns | 0.0614 ns |  7.230 ns |  0.62 |    0.00 |      - |     - |     - |         - |
                                            From_SByte |        net461 | 13.078 ns | 0.0475 ns | 0.0445 ns | 13.079 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                            From_SByte |        net472 | 11.134 ns | 0.0492 ns | 0.0460 ns | 11.123 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_SByte_AsObject | .NET Core 2.0 | 18.662 ns | 0.0546 ns | 0.0511 ns | 18.642 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 2.2 | 15.582 ns | 0.1062 ns | 0.0886 ns | 15.560 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 3.0 | 15.727 ns | 0.0865 ns | 0.0767 ns | 15.753 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net461 | 19.351 ns | 0.0339 ns | 0.0301 ns | 19.348 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net472 | 21.822 ns | 0.0582 ns | 0.0544 ns | 21.824 ns |  1.17 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_SByte_Nullable_WithValue | .NET Core 2.0 | 13.509 ns | 0.0240 ns | 0.0200 ns | 13.505 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 2.2 | 12.305 ns | 0.0386 ns | 0.0361 ns | 12.293 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 3.0 |  7.140 ns | 0.0377 ns | 0.0334 ns |  7.127 ns |  0.53 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net461 | 13.430 ns | 0.0230 ns | 0.0215 ns | 13.431 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net472 | 11.999 ns | 0.0164 ns | 0.0137 ns | 11.995 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.165 ns | 0.0326 ns | 0.0272 ns | 18.169 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.337 ns | 0.0331 ns | 0.0276 ns | 15.339 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.077 ns | 0.0389 ns | 0.0325 ns | 15.095 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net461 | 20.798 ns | 0.0611 ns | 0.0571 ns | 20.779 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net472 | 20.644 ns | 0.0281 ns | 0.0249 ns | 20.644 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_SByte_Nullable_NoValue | .NET Core 2.0 | 11.727 ns | 0.0428 ns | 0.0379 ns | 11.726 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 2.2 | 11.198 ns | 0.0196 ns | 0.0164 ns | 11.205 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 3.0 |  7.001 ns | 0.1689 ns | 0.2311 ns |  6.949 ns |  0.60 |    0.02 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net461 | 12.150 ns | 0.0212 ns | 0.0198 ns | 12.149 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net472 | 10.366 ns | 0.0156 ns | 0.0146 ns | 10.362 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.016 ns | 0.0358 ns | 0.0335 ns | 15.013 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.920 ns | 0.0126 ns | 0.0105 ns | 11.923 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.723 ns | 0.2986 ns | 0.4989 ns | 13.930 ns |  0.89 |    0.04 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net461 | 13.319 ns | 0.0275 ns | 0.0257 ns | 13.315 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net472 | 15.878 ns | 0.0360 ns | 0.0320 ns | 15.872 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_Float | .NET Core 2.0 | 11.685 ns | 0.0190 ns | 0.0169 ns | 11.685 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 2.2 | 11.099 ns | 0.1279 ns | 0.1197 ns | 11.180 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                                            From_Float | .NET Core 3.0 |  7.218 ns | 0.0401 ns | 0.0375 ns |  7.222 ns |  0.62 |    0.00 |      - |     - |     - |         - |
                                            From_Float |        net461 | 12.972 ns | 0.0481 ns | 0.0450 ns | 12.981 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                            From_Float |        net472 | 12.936 ns | 0.0331 ns | 0.0293 ns | 12.930 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_Float_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                   From_Float_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                   From_Float_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Float_Nullable_WithValue | .NET Core 2.0 | 11.526 ns | 0.0261 ns | 0.0244 ns | 11.528 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 2.2 | 10.630 ns | 0.0148 ns | 0.0138 ns | 10.625 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 3.0 |  6.483 ns | 0.0742 ns | 0.0694 ns |  6.455 ns |  0.56 |    0.01 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net461 | 12.543 ns | 0.0568 ns | 0.0531 ns | 12.527 ns |  1.09 |    0.01 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net472 | 10.383 ns | 0.0164 ns | 0.0145 ns | 10.380 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Float_Nullable_NoValue | .NET Core 2.0 | 11.524 ns | 0.0242 ns | 0.0226 ns | 11.528 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 2.2 | 10.955 ns | 0.0220 ns | 0.0206 ns | 10.956 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 3.0 |  6.745 ns | 0.0227 ns | 0.0213 ns |  6.742 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net461 | 12.518 ns | 0.0208 ns | 0.0184 ns | 12.516 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net472 | 10.410 ns | 0.0260 ns | 0.0231 ns | 10.406 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.024 ns | 0.0262 ns | 0.0245 ns | 15.028 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.973 ns | 0.0137 ns | 0.0128 ns | 11.974 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.117 ns | 0.1367 ns | 0.1279 ns | 12.138 ns |  0.81 |    0.01 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net461 | 13.950 ns | 0.0478 ns | 0.0423 ns | 13.957 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net472 | 14.996 ns | 0.0178 ns | 0.0158 ns | 14.994 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_String | .NET Core 2.0 | 14.573 ns | 0.0168 ns | 0.0157 ns | 14.571 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 2.2 | 12.722 ns | 0.0782 ns | 0.0732 ns | 12.743 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 3.0 | 12.086 ns | 0.2614 ns | 0.3211 ns | 12.263 ns |  0.82 |    0.02 |      - |     - |     - |         - |
                                           From_String |        net461 | 13.899 ns | 0.0194 ns | 0.0172 ns | 13.904 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                           From_String |        net472 | 15.894 ns | 0.0533 ns | 0.0498 ns | 15.898 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_String_AsObject | .NET Core 2.0 | 17.952 ns | 0.0390 ns | 0.0365 ns | 17.951 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 2.2 | 17.788 ns | 0.0346 ns | 0.0307 ns | 17.796 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 3.0 | 15.654 ns | 0.1616 ns | 0.1432 ns | 15.711 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                                  From_String_AsObject |        net461 | 18.598 ns | 0.0264 ns | 0.0234 ns | 18.594 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject |        net472 | 20.784 ns | 0.0578 ns | 0.0541 ns | 20.796 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                      From_String_Null | .NET Core 2.0 | 12.919 ns | 0.0257 ns | 0.0228 ns | 12.922 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 2.2 | 12.615 ns | 0.0152 ns | 0.0142 ns | 12.611 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 3.0 | 11.859 ns | 0.2524 ns | 0.2805 ns | 11.885 ns |  0.91 |    0.02 |      - |     - |     - |         - |
                                      From_String_Null |        net461 | 12.911 ns | 0.1219 ns | 0.1140 ns | 12.986 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                                      From_String_Null |        net472 | 15.115 ns | 0.0261 ns | 0.0244 ns | 15.109 ns |  1.17 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_String_Null_AsObject | .NET Core 2.0 | 14.114 ns | 0.0196 ns | 0.0174 ns | 14.114 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 2.2 | 11.949 ns | 0.0096 ns | 0.0085 ns | 11.949 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 3.0 | 11.998 ns | 0.0344 ns | 0.0305 ns | 12.002 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net461 | 13.929 ns | 0.0315 ns | 0.0279 ns | 13.940 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net472 | 16.611 ns | 0.0235 ns | 0.0208 ns | 16.604 ns |  1.18 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_String_Empty | .NET Core 2.0 | 12.175 ns | 0.0203 ns | 0.0190 ns | 12.168 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 2.2 | 12.707 ns | 0.0544 ns | 0.0482 ns | 12.725 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 3.0 | 11.130 ns | 0.2202 ns | 0.2060 ns | 11.235 ns |  0.91 |    0.02 |      - |     - |     - |         - |
                                     From_String_Empty |        net461 | 12.514 ns | 0.0215 ns | 0.0190 ns | 12.515 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty |        net472 | 14.472 ns | 0.0062 ns | 0.0048 ns | 14.472 ns |  1.19 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_String_Empty_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_UShort | .NET Core 2.0 | 11.551 ns | 0.0180 ns | 0.0169 ns | 11.548 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 2.2 | 10.620 ns | 0.0123 ns | 0.0116 ns | 10.618 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 3.0 |  6.626 ns | 0.0724 ns | 0.0677 ns |  6.598 ns |  0.57 |    0.01 |      - |     - |     - |         - |
                                           From_UShort |        net461 | 12.683 ns | 0.1160 ns | 0.1085 ns | 12.747 ns |  1.10 |    0.01 |      - |     - |     - |         - |
                                           From_UShort |        net472 | 10.541 ns | 0.0240 ns | 0.0200 ns | 10.540 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_UShort_AsObject | .NET Core 2.0 | 19.680 ns | 0.0919 ns | 0.0814 ns | 19.698 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 2.2 | 15.341 ns | 0.0616 ns | 0.0546 ns | 15.353 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 3.0 | 16.120 ns | 0.1413 ns | 0.1321 ns | 16.106 ns |  0.82 |    0.01 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net461 | 20.087 ns | 0.0614 ns | 0.0574 ns | 20.089 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net472 | 21.231 ns | 0.2202 ns | 0.1952 ns | 21.182 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_UShort_Nullable_WithValue | .NET Core 2.0 | 11.860 ns | 0.0245 ns | 0.0218 ns | 11.861 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 2.2 | 11.359 ns | 0.0213 ns | 0.0199 ns | 11.366 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 3.0 |  6.949 ns | 0.1227 ns | 0.1148 ns |  6.908 ns |  0.59 |    0.01 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net461 | 12.863 ns | 0.0207 ns | 0.0194 ns | 12.867 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net472 | 10.528 ns | 0.0175 ns | 0.0163 ns | 10.525 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.442 ns | 0.1187 ns | 0.1110 ns | 18.473 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.139 ns | 0.0215 ns | 0.0190 ns | 15.143 ns |  0.82 |    0.01 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.548 ns | 0.1480 ns | 0.1385 ns | 15.471 ns |  0.84 |    0.01 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net461 | 19.119 ns | 0.0592 ns | 0.0494 ns | 19.103 ns |  1.04 |    0.01 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net472 | 28.858 ns | 0.7351 ns | 2.1675 ns | 29.426 ns |  1.56 |    0.16 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_UShort_Nullable_NoValue | .NET Core 2.0 | 11.710 ns | 0.0271 ns | 0.0240 ns | 11.711 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 2.2 | 10.792 ns | 0.0136 ns | 0.0127 ns | 10.795 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 3.0 |  6.660 ns | 0.0135 ns | 0.0127 ns |  6.656 ns |  0.57 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net461 | 11.867 ns | 0.0289 ns | 0.0256 ns | 11.859 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net472 | 10.323 ns | 0.0167 ns | 0.0156 ns | 10.326 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.005 ns | 0.0226 ns | 0.0189 ns | 15.013 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.974 ns | 0.0283 ns | 0.0265 ns | 11.977 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.417 ns | 0.2689 ns | 0.2761 ns | 12.390 ns |  0.83 |    0.02 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net461 | 15.804 ns | 0.0267 ns | 0.0250 ns | 15.804 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net472 | 15.937 ns | 0.0316 ns | 0.0295 ns | 15.935 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_UInt | .NET Core 2.0 | 11.591 ns | 0.0171 ns | 0.0143 ns | 11.589 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 2.2 | 10.865 ns | 0.0142 ns | 0.0133 ns | 10.863 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 3.0 |  7.064 ns | 0.0117 ns | 0.0098 ns |  7.065 ns |  0.61 |    0.00 |      - |     - |     - |         - |
                                             From_UInt |        net461 | 12.466 ns | 0.0219 ns | 0.0195 ns | 12.471 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                             From_UInt |        net472 | 10.990 ns | 0.1199 ns | 0.1122 ns | 10.957 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_UInt_AsObject | .NET Core 2.0 | 18.240 ns | 0.0291 ns | 0.0272 ns | 18.234 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 2.2 | 15.636 ns | 0.0663 ns | 0.0553 ns | 15.620 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 3.0 | 15.532 ns | 0.0442 ns | 0.0413 ns | 15.520 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net461 | 19.557 ns | 0.0365 ns | 0.0305 ns | 19.548 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net472 | 20.887 ns | 0.0347 ns | 0.0325 ns | 20.880 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_UInt_Nullable_WithValue | .NET Core 2.0 | 11.942 ns | 0.0399 ns | 0.0373 ns | 11.932 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 2.2 | 11.089 ns | 0.0243 ns | 0.0215 ns | 11.088 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 3.0 |  6.856 ns | 0.0219 ns | 0.0194 ns |  6.854 ns |  0.57 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net461 | 13.577 ns | 0.2406 ns | 0.2251 ns | 13.432 ns |  1.14 |    0.02 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net472 | 12.062 ns | 0.0142 ns | 0.0133 ns | 12.063 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.223 ns | 0.0358 ns | 0.0334 ns | 18.234 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.421 ns | 0.0246 ns | 0.0218 ns | 15.421 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.697 ns | 0.0265 ns | 0.0248 ns | 15.698 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net461 | 19.566 ns | 0.0354 ns | 0.0314 ns | 19.568 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net472 | 21.247 ns | 0.1384 ns | 0.1155 ns | 21.271 ns |  1.17 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_UInt_Nullable_NoValue | .NET Core 2.0 | 11.731 ns | 0.0320 ns | 0.0299 ns | 11.725 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 2.2 | 10.868 ns | 0.0209 ns | 0.0185 ns | 10.871 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 3.0 |  8.102 ns | 0.0462 ns | 0.0410 ns |  8.094 ns |  0.69 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net461 | 11.914 ns | 0.0411 ns | 0.0384 ns | 11.911 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net472 | 11.760 ns | 0.0148 ns | 0.0131 ns | 11.758 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.192 ns | 0.1368 ns | 0.1279 ns | 14.135 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.978 ns | 0.0119 ns | 0.0111 ns | 11.976 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.966 ns | 0.2764 ns | 0.3290 ns | 13.092 ns |  0.91 |    0.02 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net461 | 13.366 ns | 0.0205 ns | 0.0182 ns | 13.365 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net472 | 14.981 ns | 0.0237 ns | 0.0185 ns | 14.987 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_ULong | .NET Core 2.0 | 11.935 ns | 0.0280 ns | 0.0262 ns | 11.929 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 2.2 | 11.227 ns | 0.0631 ns | 0.0590 ns | 11.249 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 3.0 |  7.320 ns | 0.0292 ns | 0.0228 ns |  7.319 ns |  0.61 |    0.00 |      - |     - |     - |         - |
                                            From_ULong |        net461 | 13.021 ns | 0.0127 ns | 0.0119 ns | 13.018 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                            From_ULong |        net472 | 11.094 ns | 0.0288 ns | 0.0240 ns | 11.093 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_ULong_AsObject | .NET Core 2.0 | 19.576 ns | 0.0252 ns | 0.0236 ns | 19.574 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 2.2 | 16.119 ns | 0.0313 ns | 0.0278 ns | 16.114 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 3.0 | 17.033 ns | 0.3580 ns | 0.4261 ns | 17.294 ns |  0.86 |    0.02 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net461 | 19.317 ns | 0.0246 ns | 0.0218 ns | 19.312 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net472 | 21.314 ns | 0.0351 ns | 0.0293 ns | 21.301 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_ULong_Nullable_WithValue | .NET Core 2.0 | 14.241 ns | 0.0331 ns | 0.0293 ns | 14.247 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 2.2 | 13.251 ns | 0.0525 ns | 0.0465 ns | 13.264 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 3.0 | 11.731 ns | 0.1516 ns | 0.1418 ns | 11.823 ns |  0.82 |    0.01 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net461 | 14.730 ns | 0.1585 ns | 0.1482 ns | 14.711 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net472 | 13.861 ns | 0.0186 ns | 0.0156 ns | 13.860 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.849 ns | 0.0416 ns | 0.0389 ns | 18.835 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.2 | 16.081 ns | 0.0191 ns | 0.0179 ns | 16.079 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 3.0 | 16.692 ns | 0.0567 ns | 0.0530 ns | 16.685 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net461 | 19.663 ns | 0.2203 ns | 0.1953 ns | 19.625 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net472 | 20.621 ns | 0.0374 ns | 0.0312 ns | 20.618 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_ULong_Nullable_NoValue | .NET Core 2.0 | 12.787 ns | 0.1234 ns | 0.1154 ns | 12.837 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 2.2 | 11.977 ns | 0.0489 ns | 0.0457 ns | 11.990 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 3.0 |  8.109 ns | 0.0481 ns | 0.0450 ns |  8.124 ns |  0.63 |    0.01 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net461 | 15.708 ns | 0.2402 ns | 0.2247 ns | 15.616 ns |  1.23 |    0.02 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net472 | 12.780 ns | 0.0214 ns | 0.0201 ns | 12.780 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.777 ns | 0.0335 ns | 0.0313 ns | 14.774 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.009 ns | 0.0309 ns | 0.0289 ns | 12.015 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.026 ns | 0.0244 ns | 0.0217 ns | 12.032 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net461 | 13.604 ns | 0.0768 ns | 0.0681 ns | 13.578 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net472 | 17.732 ns | 0.0316 ns | 0.0280 ns | 17.728 ns |  1.20 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                       From_NullObject | .NET Core 2.0 | 14.129 ns | 0.0263 ns | 0.0233 ns | 14.119 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 2.2 | 11.964 ns | 0.0187 ns | 0.0156 ns | 11.962 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 3.0 | 14.143 ns | 0.3030 ns | 0.3940 ns | 13.983 ns |  1.02 |    0.02 |      - |     - |     - |         - |
                                       From_NullObject |        net461 | 13.472 ns | 0.1042 ns | 0.0924 ns | 13.431 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                                       From_NullObject |        net472 | 17.163 ns | 0.1426 ns | 0.1333 ns | 17.102 ns |  1.21 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_DBNull | .NET Core 2.0 | 11.563 ns | 0.1272 ns | 0.1190 ns | 11.642 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 2.2 |  9.126 ns | 0.0192 ns | 0.0160 ns |  9.130 ns |  0.79 |    0.01 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 3.0 | 11.236 ns | 0.2480 ns | 0.3225 ns | 11.454 ns |  0.96 |    0.03 |      - |     - |     - |         - |
                                           From_DBNull |        net461 | 11.238 ns | 0.0304 ns | 0.0238 ns | 11.248 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                                           From_DBNull |        net472 | 11.273 ns | 0.0276 ns | 0.0216 ns | 11.272 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_DBNull_AsObject | .NET Core 2.0 | 14.125 ns | 0.0215 ns | 0.0191 ns | 14.125 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 2.2 | 11.970 ns | 0.0287 ns | 0.0240 ns | 11.963 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 3.0 | 12.005 ns | 0.0207 ns | 0.0173 ns | 12.002 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net461 | 13.547 ns | 0.1550 ns | 0.1450 ns | 13.535 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net472 | 17.870 ns | 0.0297 ns | 0.0278 ns | 17.878 ns |  1.27 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                 From_ConvertibleClass | .NET Core 2.0 | 15.047 ns | 0.0914 ns | 0.0855 ns | 15.006 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 2.2 | 13.392 ns | 0.0213 ns | 0.0188 ns | 13.393 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 3.0 | 12.597 ns | 0.0275 ns | 0.0258 ns | 12.598 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net461 | 16.906 ns | 0.0298 ns | 0.0249 ns | 16.905 ns |  1.12 |    0.01 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net472 | 18.350 ns | 0.0417 ns | 0.0390 ns | 18.358 ns |  1.22 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_ConvertibleClass_AsObject | .NET Core 2.0 | 17.582 ns | 0.0389 ns | 0.0364 ns | 17.574 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 2.2 | 15.417 ns | 0.0220 ns | 0.0195 ns | 15.423 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 3.0 | 14.724 ns | 0.0397 ns | 0.0352 ns | 14.731 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net461 | 16.975 ns | 0.1824 ns | 0.1706 ns | 16.948 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net472 | 19.036 ns | 0.0348 ns | 0.0326 ns | 19.041 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_ConvertibleClass_NoValue | .NET Core 2.0 | 12.992 ns | 0.0122 ns | 0.0095 ns | 12.994 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 2.2 | 12.462 ns | 0.0188 ns | 0.0175 ns | 12.463 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 3.0 | 11.461 ns | 0.0544 ns | 0.0482 ns | 11.449 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net461 | 13.306 ns | 0.0627 ns | 0.0556 ns | 13.316 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net472 | 13.231 ns | 0.0131 ns | 0.0116 ns | 13.232 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.0 | 14.175 ns | 0.0159 ns | 0.0149 ns | 14.177 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.2 | 11.997 ns | 0.0876 ns | 0.0777 ns | 11.959 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 3.0 | 13.765 ns | 0.0253 ns | 0.0237 ns | 13.765 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net461 | 13.431 ns | 0.1539 ns | 0.1365 ns | 13.365 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net472 | 16.622 ns | 0.0227 ns | 0.0177 ns | 16.618 ns |  1.17 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                              From_NonConvertibleClass | .NET Core 2.0 | 11.985 ns | 0.0220 ns | 0.0195 ns | 11.986 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 2.2 | 11.202 ns | 0.0176 ns | 0.0165 ns | 11.201 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 3.0 | 10.775 ns | 0.0168 ns | 0.0149 ns | 10.774 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net461 | 12.691 ns | 0.0959 ns | 0.0897 ns | 12.708 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net472 | 12.634 ns | 0.0580 ns | 0.0542 ns | 12.617 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                     From_NonConvertibleClass_AsObject | .NET Core 2.0 | 15.542 ns | 0.0349 ns | 0.0326 ns | 15.531 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 2.2 | 13.379 ns | 0.0154 ns | 0.0144 ns | 13.378 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 3.0 | 14.962 ns | 0.0227 ns | 0.0213 ns | 14.966 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net461 | 17.180 ns | 0.2906 ns | 0.2576 ns | 17.134 ns |  1.11 |    0.02 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net472 | 18.204 ns | 0.1671 ns | 0.1563 ns | 18.125 ns |  1.17 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                      From_NonConvertibleClass_NoValue | .NET Core 2.0 | 12.789 ns | 0.0303 ns | 0.0268 ns | 12.792 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 2.2 | 11.640 ns | 0.0674 ns | 0.0630 ns | 11.611 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 3.0 | 10.757 ns | 0.0162 ns | 0.0135 ns | 10.759 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net461 | 12.752 ns | 0.1915 ns | 0.1791 ns | 12.669 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net472 | 12.804 ns | 0.0195 ns | 0.0152 ns | 12.810 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.0 | 15.758 ns | 0.0169 ns | 0.0150 ns | 15.756 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.2 | 11.971 ns | 0.0127 ns | 0.0119 ns | 11.970 ns |  0.76 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 3.0 | 12.005 ns | 0.0210 ns | 0.0175 ns | 12.004 ns |  0.76 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net461 | 13.524 ns | 0.1779 ns | 0.1664 ns | 13.431 ns |  0.86 |    0.01 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net472 | 15.880 ns | 0.0186 ns | 0.0155 ns | 15.880 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                From_ConvertibleStruct | .NET Core 2.0 | 19.556 ns | 0.0600 ns | 0.0561 ns | 19.551 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 2.2 | 16.705 ns | 0.0591 ns | 0.0524 ns | 16.691 ns |  0.85 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 3.0 | 12.249 ns | 0.2673 ns | 0.3078 ns | 12.409 ns |  0.62 |    0.02 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net461 | 19.417 ns | 0.1763 ns | 0.1563 ns | 19.332 ns |  0.99 |    0.01 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net472 | 18.818 ns | 0.0757 ns | 0.0632 ns | 18.813 ns |  0.96 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                       From_ConvertibleStruct_AsObject | .NET Core 2.0 | 17.207 ns | 0.2113 ns | 0.1976 ns | 17.175 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 2.2 | 14.904 ns | 0.0614 ns | 0.0574 ns | 14.888 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 3.0 | 15.608 ns | 0.1118 ns | 0.0933 ns | 15.638 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net461 | 17.638 ns | 0.1282 ns | 0.1199 ns | 17.616 ns |  1.03 |    0.02 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net472 | 20.178 ns | 0.1636 ns | 0.1530 ns | 20.113 ns |  1.17 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.0 | 19.247 ns | 0.0551 ns | 0.0489 ns | 19.238 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.2 | 15.984 ns | 0.0491 ns | 0.0435 ns | 15.987 ns |  0.83 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 3.0 | 13.033 ns | 0.0322 ns | 0.0285 ns | 13.026 ns |  0.68 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net461 | 20.101 ns | 0.0792 ns | 0.0661 ns | 20.086 ns |  1.04 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net472 | 17.989 ns | 0.1556 ns | 0.1455 ns | 17.905 ns |  0.93 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 16.980 ns | 0.0253 ns | 0.0225 ns | 16.982 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.094 ns | 0.0768 ns | 0.0718 ns | 15.121 ns |  0.89 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.898 ns | 0.1732 ns | 0.1620 ns | 15.967 ns |  0.94 |    0.01 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net461 | 17.619 ns | 0.0694 ns | 0.0615 ns | 17.597 ns |  1.04 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net472 | 19.444 ns | 0.0403 ns | 0.0358 ns | 19.440 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.0 | 13.374 ns | 0.1044 ns | 0.0977 ns | 13.423 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.2 | 11.847 ns | 0.0275 ns | 0.0244 ns | 11.848 ns |  0.89 |    0.01 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 3.0 |  8.077 ns | 0.1310 ns | 0.1225 ns |  8.132 ns |  0.60 |    0.01 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net461 | 12.721 ns | 0.0401 ns | 0.0335 ns | 12.709 ns |  0.95 |    0.01 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net472 | 10.566 ns | 0.0554 ns | 0.0518 ns | 10.540 ns |  0.79 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.018 ns | 0.0255 ns | 0.0213 ns | 15.013 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.965 ns | 0.0172 ns | 0.0144 ns | 11.963 ns |  0.80 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.032 ns | 0.0243 ns | 0.0227 ns | 12.036 ns |  0.80 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net461 | 15.117 ns | 0.0927 ns | 0.0822 ns | 15.100 ns |  1.01 |    0.01 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net472 | 15.910 ns | 0.0199 ns | 0.0186 ns | 15.913 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_NonConvertibleStruct | .NET Core 2.0 | 14.953 ns | 0.1531 ns | 0.1432 ns | 15.051 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 2.2 | 13.138 ns | 0.0287 ns | 0.0254 ns | 13.139 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 3.0 |  6.610 ns | 0.0061 ns | 0.0051 ns |  6.609 ns |  0.44 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net461 | 12.854 ns | 0.1384 ns | 0.1156 ns | 12.887 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net472 | 11.765 ns | 0.0287 ns | 0.0268 ns | 11.774 ns |  0.79 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.0 | 15.072 ns | 0.0434 ns | 0.0406 ns | 15.067 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.2 | 13.405 ns | 0.0368 ns | 0.0308 ns | 13.397 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 3.0 | 13.758 ns | 0.0972 ns | 0.0909 ns | 13.733 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net461 | 15.362 ns | 0.2375 ns | 0.2106 ns | 15.259 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net472 | 17.407 ns | 0.0316 ns | 0.0280 ns | 17.403 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.0 | 13.578 ns | 0.0122 ns | 0.0101 ns | 13.581 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.2 | 11.697 ns | 0.0243 ns | 0.0227 ns | 11.693 ns |  0.86 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 3.0 |  6.885 ns | 0.0159 ns | 0.0141 ns |  6.884 ns |  0.51 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net461 | 11.974 ns | 0.0993 ns | 0.0829 ns | 11.970 ns |  0.88 |    0.01 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net472 | 11.108 ns | 0.0263 ns | 0.0246 ns | 11.110 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 15.289 ns | 0.1645 ns | 0.1539 ns | 15.347 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 13.382 ns | 0.0175 ns | 0.0164 ns | 13.383 ns |  0.88 |    0.01 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 13.964 ns | 0.1409 ns | 0.1318 ns | 13.962 ns |  0.91 |    0.01 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net461 | 15.329 ns | 0.1958 ns | 0.1831 ns | 15.263 ns |  1.00 |    0.02 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net472 | 16.817 ns | 0.0304 ns | 0.0254 ns | 16.823 ns |  1.10 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.0 | 13.506 ns | 0.0153 ns | 0.0143 ns | 13.505 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.2 | 11.701 ns | 0.0253 ns | 0.0212 ns | 11.701 ns |  0.87 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 3.0 |  6.873 ns | 0.1585 ns | 0.1761 ns |  6.758 ns |  0.51 |    0.01 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net461 | 12.131 ns | 0.1667 ns | 0.1559 ns | 12.059 ns |  0.90 |    0.01 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net472 | 10.463 ns | 0.0307 ns | 0.0272 ns | 10.467 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.136 ns | 0.0152 ns | 0.0142 ns | 14.132 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.957 ns | 0.0134 ns | 0.0112 ns | 11.957 ns |  0.85 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.213 ns | 0.2152 ns | 0.2013 ns | 12.354 ns |  0.86 |    0.01 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net461 | 15.634 ns | 0.2509 ns | 0.2224 ns | 15.596 ns |  1.11 |    0.02 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net472 | 15.481 ns | 0.0336 ns | 0.0262 ns | 15.477 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Enum | .NET Core 2.0 | 13.311 ns | 0.0290 ns | 0.0257 ns | 13.317 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 2.2 | 10.612 ns | 0.0191 ns | 0.0169 ns | 10.612 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 3.0 |  7.484 ns | 0.0457 ns | 0.0428 ns |  7.466 ns |  0.56 |    0.00 |      - |     - |     - |         - |
                                             From_Enum |        net461 | 12.677 ns | 0.1478 ns | 0.1382 ns | 12.614 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                                             From_Enum |        net472 | 10.969 ns | 0.0268 ns | 0.0238 ns | 10.967 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Enum_AsObject | .NET Core 2.0 | 44.563 ns | 0.0565 ns | 0.0501 ns | 44.559 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject | .NET Core 2.2 | 47.545 ns | 0.1027 ns | 0.0857 ns | 47.554 ns |  1.07 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject | .NET Core 3.0 | 37.697 ns | 0.1500 ns | 0.1330 ns | 37.664 ns |  0.85 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject |        net461 | 47.924 ns | 0.4495 ns | 0.4205 ns | 47.932 ns |  1.08 |    0.01 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject |        net472 | 47.028 ns | 0.0634 ns | 0.0562 ns | 47.034 ns |  1.06 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Enum_Nullable_WithValue | .NET Core 2.0 | 13.931 ns | 0.0236 ns | 0.0221 ns | 13.931 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 2.2 | 11.590 ns | 0.0164 ns | 0.0137 ns | 11.590 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 3.0 |  8.226 ns | 0.0241 ns | 0.0225 ns |  8.219 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net461 | 14.929 ns | 0.1839 ns | 0.1720 ns | 14.912 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net472 | 12.347 ns | 0.0335 ns | 0.0280 ns | 12.356 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.0 | 49.191 ns | 0.4026 ns | 0.3766 ns | 49.029 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.2 | 44.434 ns | 0.3546 ns | 0.3317 ns | 44.326 ns |  0.90 |    0.01 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 3.0 | 37.253 ns | 0.0889 ns | 0.0788 ns | 37.251 ns |  0.76 |    0.01 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject |        net461 | 43.981 ns | 0.3207 ns | 0.2843 ns | 43.944 ns |  0.89 |    0.01 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject |        net472 | 46.566 ns | 0.1458 ns | 0.1364 ns | 46.541 ns |  0.95 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Enum_Nullable_NoValue | .NET Core 2.0 | 13.048 ns | 0.0163 ns | 0.0145 ns | 13.049 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 2.2 | 10.328 ns | 0.0100 ns | 0.0078 ns | 10.325 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 3.0 |  6.686 ns | 0.1004 ns | 0.0939 ns |  6.626 ns |  0.51 |    0.01 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net461 | 12.699 ns | 0.0382 ns | 0.0338 ns | 12.701 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net472 | 11.943 ns | 0.0336 ns | 0.0280 ns | 11.936 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.124 ns | 0.0269 ns | 0.0238 ns | 14.129 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.965 ns | 0.0210 ns | 0.0186 ns | 11.970 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.020 ns | 0.0595 ns | 0.0528 ns | 12.007 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net461 | 13.702 ns | 0.3314 ns | 0.3100 ns | 13.576 ns |  0.97 |    0.02 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net472 | 16.602 ns | 0.0335 ns | 0.0314 ns | 16.607 ns |  1.18 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                      From_ParentClass | .NET Core 2.0 | 12.788 ns | 0.0176 ns | 0.0156 ns | 12.788 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 2.2 | 11.208 ns | 0.0170 ns | 0.0142 ns | 11.205 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 3.0 | 10.750 ns | 0.0178 ns | 0.0149 ns | 10.751 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass |        net461 | 12.620 ns | 0.2163 ns | 0.1917 ns | 12.565 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                                      From_ParentClass |        net472 | 12.619 ns | 0.0236 ns | 0.0209 ns | 12.620 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_ParentClass_AsObject | .NET Core 2.0 | 15.516 ns | 0.0362 ns | 0.0321 ns | 15.509 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 2.2 | 13.719 ns | 0.0163 ns | 0.0144 ns | 13.721 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 3.0 | 13.881 ns | 0.0591 ns | 0.0553 ns | 13.882 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net461 | 15.448 ns | 0.0686 ns | 0.0573 ns | 15.428 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net472 | 17.540 ns | 0.0250 ns | 0.0221 ns | 17.535 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                              From_ParentClass_NoValue | .NET Core 2.0 | 12.784 ns | 0.0488 ns | 0.0456 ns | 12.777 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 2.2 | 11.211 ns | 0.0227 ns | 0.0202 ns | 11.213 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 3.0 | 11.208 ns | 0.2462 ns | 0.2736 ns | 11.343 ns |  0.87 |    0.02 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net461 | 12.468 ns | 0.0596 ns | 0.0557 ns | 12.455 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net472 | 14.001 ns | 0.0256 ns | 0.0240 ns | 13.999 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.0 | 15.018 ns | 0.0340 ns | 0.0284 ns | 15.016 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.2 | 12.006 ns | 0.0717 ns | 0.0670 ns | 11.982 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 3.0 | 12.018 ns | 0.0402 ns | 0.0376 ns | 12.023 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net461 | 13.554 ns | 0.1156 ns | 0.1082 ns | 13.579 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net472 | 15.172 ns | 0.0376 ns | 0.0314 ns | 15.173 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_ParentStruct | .NET Core 2.0 | 39.070 ns | 0.0833 ns | 0.0738 ns | 39.062 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 2.2 | 37.418 ns | 0.0654 ns | 0.0579 ns | 37.421 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 3.0 | 34.877 ns | 0.2222 ns | 0.2078 ns | 34.944 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                                     From_ParentStruct |        net461 | 39.213 ns | 0.1615 ns | 0.1510 ns | 39.180 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct |        net472 | 38.688 ns | 0.0927 ns | 0.0774 ns | 38.672 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_ParentStruct_AsObject | .NET Core 2.0 | 16.074 ns | 0.0253 ns | 0.0237 ns | 16.077 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 2.2 | 13.666 ns | 0.0813 ns | 0.0720 ns | 13.638 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 3.0 | 14.213 ns | 0.1787 ns | 0.1672 ns | 14.307 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net461 | 15.576 ns | 0.0616 ns | 0.0515 ns | 15.564 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net472 | 19.009 ns | 0.0224 ns | 0.0210 ns | 19.002 ns |  1.18 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.0 | 43.799 ns | 0.1746 ns | 0.1633 ns | 43.851 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.2 | 38.260 ns | 0.0810 ns | 0.0757 ns | 38.268 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 3.0 | 35.900 ns | 0.2726 ns | 0.2550 ns | 35.945 ns |  0.82 |    0.01 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue |        net461 | 47.349 ns | 0.1839 ns | 0.1720 ns | 47.308 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue |        net472 | 38.183 ns | 0.0391 ns | 0.0327 ns | 38.183 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 15.520 ns | 0.0390 ns | 0.0364 ns | 15.520 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 13.611 ns | 0.0183 ns | 0.0171 ns | 13.613 ns |  0.88 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 14.544 ns | 0.3082 ns | 0.3549 ns | 14.752 ns |  0.95 |    0.02 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net461 | 15.648 ns | 0.1307 ns | 0.1222 ns | 15.686 ns |  1.01 |    0.01 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net472 | 18.082 ns | 0.0713 ns | 0.0595 ns | 18.092 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.0 | 39.128 ns | 0.0394 ns | 0.0349 ns | 39.126 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.2 | 38.429 ns | 0.0467 ns | 0.0414 ns | 38.424 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 3.0 | 35.488 ns | 0.7209 ns | 0.8302 ns | 36.129 ns |  0.90 |    0.02 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net461 | 39.236 ns | 0.3710 ns | 0.3470 ns | 39.191 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net472 | 39.609 ns | 0.0874 ns | 0.0775 ns | 39.594 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.283 ns | 0.1596 ns | 0.1493 ns | 14.393 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.993 ns | 0.0229 ns | 0.0214 ns | 11.991 ns |  0.84 |    0.01 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.093 ns | 0.1542 ns | 0.1443 ns | 12.022 ns |  0.85 |    0.01 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net461 | 13.507 ns | 0.0408 ns | 0.0341 ns | 13.512 ns |  0.95 |    0.01 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net472 | 16.894 ns | 0.0877 ns | 0.0821 ns | 16.918 ns |  1.18 |    0.01 |      - |     - |     - |         - |

Benchmarks with issues:
  ConvertTo_Char.From_Bool_AsObject: Job-LRKCAO(Toolchain=.NET Core 2.0)
  ConvertTo_Char.From_Bool_AsObject: Job-VAJWLV(Toolchain=.NET Core 2.2)
  ConvertTo_Char.From_Bool_AsObject: Job-TJIRAH(Toolchain=.NET Core 3.0)
  ConvertTo_Char.From_Bool_AsObject: Job-HBFVIR(Toolchain=net461)
  ConvertTo_Char.From_Bool_AsObject: Job-YRWWQX(Toolchain=net472)
  ConvertTo_Char.From_Bool_Nullable_WithValue_AsObject: Job-LRKCAO(Toolchain=.NET Core 2.0)
  ConvertTo_Char.From_Bool_Nullable_WithValue_AsObject: Job-VAJWLV(Toolchain=.NET Core 2.2)
  ConvertTo_Char.From_Bool_Nullable_WithValue_AsObject: Job-TJIRAH(Toolchain=.NET Core 3.0)
  ConvertTo_Char.From_Bool_Nullable_WithValue_AsObject: Job-HBFVIR(Toolchain=net461)
  ConvertTo_Char.From_Bool_Nullable_WithValue_AsObject: Job-YRWWQX(Toolchain=net472)
  ConvertTo_Char.From_DateTime_AsObject: Job-LRKCAO(Toolchain=.NET Core 2.0)
  ConvertTo_Char.From_DateTime_AsObject: Job-VAJWLV(Toolchain=.NET Core 2.2)
  ConvertTo_Char.From_DateTime_AsObject: Job-TJIRAH(Toolchain=.NET Core 3.0)
  ConvertTo_Char.From_DateTime_AsObject: Job-HBFVIR(Toolchain=net461)
  ConvertTo_Char.From_DateTime_AsObject: Job-YRWWQX(Toolchain=net472)
  ConvertTo_Char.From_DateTime_Nullable_WithValue_AsObject: Job-LRKCAO(Toolchain=.NET Core 2.0)
  ConvertTo_Char.From_DateTime_Nullable_WithValue_AsObject: Job-VAJWLV(Toolchain=.NET Core 2.2)
  ConvertTo_Char.From_DateTime_Nullable_WithValue_AsObject: Job-TJIRAH(Toolchain=.NET Core 3.0)
  ConvertTo_Char.From_DateTime_Nullable_WithValue_AsObject: Job-HBFVIR(Toolchain=net461)
  ConvertTo_Char.From_DateTime_Nullable_WithValue_AsObject: Job-YRWWQX(Toolchain=net472)
  ConvertTo_Char.From_Decimal_AsObject: Job-LRKCAO(Toolchain=.NET Core 2.0)
  ConvertTo_Char.From_Decimal_AsObject: Job-VAJWLV(Toolchain=.NET Core 2.2)
  ConvertTo_Char.From_Decimal_AsObject: Job-TJIRAH(Toolchain=.NET Core 3.0)
  ConvertTo_Char.From_Decimal_AsObject: Job-HBFVIR(Toolchain=net461)
  ConvertTo_Char.From_Decimal_AsObject: Job-YRWWQX(Toolchain=net472)
  ConvertTo_Char.From_Decimal_Nullable_WithValue_AsObject: Job-LRKCAO(Toolchain=.NET Core 2.0)
  ConvertTo_Char.From_Decimal_Nullable_WithValue_AsObject: Job-VAJWLV(Toolchain=.NET Core 2.2)
  ConvertTo_Char.From_Decimal_Nullable_WithValue_AsObject: Job-TJIRAH(Toolchain=.NET Core 3.0)
  ConvertTo_Char.From_Decimal_Nullable_WithValue_AsObject: Job-HBFVIR(Toolchain=net461)
  ConvertTo_Char.From_Decimal_Nullable_WithValue_AsObject: Job-YRWWQX(Toolchain=net472)
  ConvertTo_Char.From_Double_AsObject: Job-LRKCAO(Toolchain=.NET Core 2.0)
  ConvertTo_Char.From_Double_AsObject: Job-VAJWLV(Toolchain=.NET Core 2.2)
  ConvertTo_Char.From_Double_AsObject: Job-TJIRAH(Toolchain=.NET Core 3.0)
  ConvertTo_Char.From_Double_AsObject: Job-HBFVIR(Toolchain=net461)
  ConvertTo_Char.From_Double_AsObject: Job-YRWWQX(Toolchain=net472)
  ConvertTo_Char.From_Double_Nullable_WithValue_AsObject: Job-LRKCAO(Toolchain=.NET Core 2.0)
  ConvertTo_Char.From_Double_Nullable_WithValue_AsObject: Job-VAJWLV(Toolchain=.NET Core 2.2)
  ConvertTo_Char.From_Double_Nullable_WithValue_AsObject: Job-TJIRAH(Toolchain=.NET Core 3.0)
  ConvertTo_Char.From_Double_Nullable_WithValue_AsObject: Job-HBFVIR(Toolchain=net461)
  ConvertTo_Char.From_Double_Nullable_WithValue_AsObject: Job-YRWWQX(Toolchain=net472)
  ConvertTo_Char.From_Float_AsObject: Job-LRKCAO(Toolchain=.NET Core 2.0)
  ConvertTo_Char.From_Float_AsObject: Job-VAJWLV(Toolchain=.NET Core 2.2)
  ConvertTo_Char.From_Float_AsObject: Job-TJIRAH(Toolchain=.NET Core 3.0)
  ConvertTo_Char.From_Float_AsObject: Job-HBFVIR(Toolchain=net461)
  ConvertTo_Char.From_Float_AsObject: Job-YRWWQX(Toolchain=net472)
  ConvertTo_Char.From_Float_Nullable_WithValue_AsObject: Job-LRKCAO(Toolchain=.NET Core 2.0)
  ConvertTo_Char.From_Float_Nullable_WithValue_AsObject: Job-VAJWLV(Toolchain=.NET Core 2.2)
  ConvertTo_Char.From_Float_Nullable_WithValue_AsObject: Job-TJIRAH(Toolchain=.NET Core 3.0)
  ConvertTo_Char.From_Float_Nullable_WithValue_AsObject: Job-HBFVIR(Toolchain=net461)
  ConvertTo_Char.From_Float_Nullable_WithValue_AsObject: Job-YRWWQX(Toolchain=net472)
  ConvertTo_Char.From_String_Empty_AsObject: Job-LRKCAO(Toolchain=.NET Core 2.0)
  ConvertTo_Char.From_String_Empty_AsObject: Job-VAJWLV(Toolchain=.NET Core 2.2)
  ConvertTo_Char.From_String_Empty_AsObject: Job-TJIRAH(Toolchain=.NET Core 3.0)
  ConvertTo_Char.From_String_Empty_AsObject: Job-HBFVIR(Toolchain=net461)
  ConvertTo_Char.From_String_Empty_AsObject: Job-YRWWQX(Toolchain=net472)
