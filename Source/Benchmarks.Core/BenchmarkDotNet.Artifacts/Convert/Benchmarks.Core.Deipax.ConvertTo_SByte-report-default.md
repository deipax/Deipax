
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
                                             From_Bool | .NET Core 2.0 | 11.757 ns | 0.1196 ns | 0.1119 ns | 11.687 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 2.2 | 11.127 ns | 0.0253 ns | 0.0224 ns | 11.122 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 3.0 |  6.890 ns | 0.0893 ns | 0.0836 ns |  6.843 ns |  0.59 |    0.01 |      - |     - |     - |         - |
                                             From_Bool |        net461 | 12.923 ns | 0.0841 ns | 0.0786 ns | 12.966 ns |  1.10 |    0.01 |      - |     - |     - |         - |
                                             From_Bool |        net472 | 10.641 ns | 0.0163 ns | 0.0144 ns | 10.636 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Bool_AsObject | .NET Core 2.0 | 17.897 ns | 0.0364 ns | 0.0304 ns | 17.891 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 2.2 | 15.605 ns | 0.1161 ns | 0.0970 ns | 15.644 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 3.0 | 15.612 ns | 0.0446 ns | 0.0418 ns | 15.628 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net461 | 18.532 ns | 0.0346 ns | 0.0323 ns | 18.533 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net472 | 21.009 ns | 0.0629 ns | 0.0525 ns | 21.014 ns |  1.17 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Bool_Nullable_WithValue | .NET Core 2.0 | 13.708 ns | 0.1140 ns | 0.1066 ns | 13.649 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 2.2 | 10.989 ns | 0.0141 ns | 0.0132 ns | 10.989 ns |  0.80 |    0.01 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 3.0 |  7.486 ns | 0.0227 ns | 0.0202 ns |  7.478 ns |  0.55 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net461 | 13.280 ns | 0.0372 ns | 0.0330 ns | 13.271 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net472 | 10.777 ns | 0.0172 ns | 0.0134 ns | 10.781 ns |  0.79 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.062 ns | 0.0503 ns | 0.0446 ns | 18.078 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.335 ns | 0.0238 ns | 0.0223 ns | 15.331 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 3.0 | 16.148 ns | 0.1838 ns | 0.1719 ns | 16.242 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net461 | 18.958 ns | 0.1000 ns | 0.0935 ns | 18.972 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net472 | 21.174 ns | 0.1408 ns | 0.1317 ns | 21.265 ns |  1.17 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Bool_Nullable_NoValue | .NET Core 2.0 | 11.832 ns | 0.0988 ns | 0.0924 ns | 11.864 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 2.2 | 10.916 ns | 0.0514 ns | 0.0481 ns | 10.925 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 3.0 |  6.864 ns | 0.0234 ns | 0.0219 ns |  6.861 ns |  0.58 |    0.01 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net461 | 12.622 ns | 0.0218 ns | 0.0204 ns | 12.620 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net472 | 11.829 ns | 0.0428 ns | 0.0400 ns | 11.809 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.500 ns | 0.0303 ns | 0.0283 ns | 15.497 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.918 ns | 0.0121 ns | 0.0113 ns | 11.916 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.900 ns | 0.3051 ns | 0.4567 ns | 14.014 ns |  0.89 |    0.04 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net461 | 13.386 ns | 0.0346 ns | 0.0324 ns | 13.383 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net472 | 18.837 ns | 0.0201 ns | 0.0168 ns | 18.842 ns |  1.22 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Byte | .NET Core 2.0 | 11.924 ns | 0.0218 ns | 0.0204 ns | 11.921 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 2.2 | 11.251 ns | 0.0098 ns | 0.0092 ns | 11.249 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 3.0 |  6.717 ns | 0.0838 ns | 0.0784 ns |  6.760 ns |  0.56 |    0.01 |      - |     - |     - |         - |
                                             From_Byte |        net461 | 13.213 ns | 0.1004 ns | 0.0939 ns | 13.258 ns |  1.11 |    0.01 |      - |     - |     - |         - |
                                             From_Byte |        net472 | 12.701 ns | 0.0639 ns | 0.0598 ns | 12.732 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Byte_AsObject | .NET Core 2.0 | 18.989 ns | 0.1476 ns | 0.1381 ns | 19.038 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 2.2 | 15.829 ns | 0.0809 ns | 0.0675 ns | 15.847 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 3.0 | 15.128 ns | 0.0509 ns | 0.0451 ns | 15.132 ns |  0.80 |    0.01 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net461 | 19.584 ns | 0.0355 ns | 0.0315 ns | 19.575 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net472 | 22.000 ns | 0.0270 ns | 0.0225 ns | 21.997 ns |  1.16 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Byte_Nullable_WithValue | .NET Core 2.0 | 11.915 ns | 0.0121 ns | 0.0107 ns | 11.914 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 2.2 | 11.010 ns | 0.0134 ns | 0.0125 ns | 11.010 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 3.0 |  7.077 ns | 0.0086 ns | 0.0072 ns |  7.079 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net461 | 13.237 ns | 0.0153 ns | 0.0143 ns | 13.238 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net472 | 12.071 ns | 0.0855 ns | 0.0800 ns | 12.032 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.218 ns | 0.0247 ns | 0.0219 ns | 18.214 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.306 ns | 0.0156 ns | 0.0138 ns | 15.305 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.304 ns | 0.1721 ns | 0.1610 ns | 15.235 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net461 | 19.828 ns | 0.0429 ns | 0.0401 ns | 19.835 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net472 | 22.325 ns | 0.0655 ns | 0.0613 ns | 22.339 ns |  1.23 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Byte_Nullable_NoValue | .NET Core 2.0 | 11.858 ns | 0.0666 ns | 0.0623 ns | 11.878 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 2.2 | 11.028 ns | 0.1028 ns | 0.0962 ns | 11.028 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 3.0 |  6.852 ns | 0.0137 ns | 0.0128 ns |  6.850 ns |  0.58 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net461 | 12.621 ns | 0.0223 ns | 0.0209 ns | 12.627 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net472 | 11.814 ns | 0.0197 ns | 0.0184 ns | 11.808 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.319 ns | 0.0206 ns | 0.0193 ns | 14.312 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.925 ns | 0.0121 ns | 0.0101 ns | 11.926 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.304 ns | 0.0363 ns | 0.0303 ns | 11.313 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net461 | 13.368 ns | 0.0812 ns | 0.0760 ns | 13.337 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net472 | 16.152 ns | 0.1161 ns | 0.1086 ns | 16.106 ns |  1.13 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Char | .NET Core 2.0 | 11.642 ns | 0.0196 ns | 0.0184 ns | 11.642 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Char | .NET Core 2.2 | 11.679 ns | 0.0510 ns | 0.0477 ns | 11.690 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Char | .NET Core 3.0 |  7.170 ns | 0.1059 ns | 0.0827 ns |  7.172 ns |  0.62 |    0.01 |      - |     - |     - |         - |
                                             From_Char |        net461 | 13.277 ns | 0.0212 ns | 0.0199 ns | 13.272 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                             From_Char |        net472 | 11.764 ns | 0.0486 ns | 0.0431 ns | 11.781 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Char_AsObject | .NET Core 2.0 | 19.470 ns | 0.1297 ns | 0.1150 ns | 19.510 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 2.2 | 16.568 ns | 0.0877 ns | 0.0733 ns | 16.579 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 3.0 | 16.657 ns | 0.0327 ns | 0.0306 ns | 16.663 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                                    From_Char_AsObject |        net461 | 19.183 ns | 0.0311 ns | 0.0260 ns | 19.190 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                                    From_Char_AsObject |        net472 | 21.612 ns | 0.0568 ns | 0.0504 ns | 21.597 ns |  1.11 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Char_Nullable_WithValue | .NET Core 2.0 | 11.905 ns | 0.0140 ns | 0.0131 ns | 11.901 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 2.2 | 11.015 ns | 0.0181 ns | 0.0169 ns | 11.010 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 3.0 |  7.034 ns | 0.0165 ns | 0.0146 ns |  7.036 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net461 | 13.551 ns | 0.1045 ns | 0.0978 ns | 13.483 ns |  1.14 |    0.01 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net472 | 13.411 ns | 0.0226 ns | 0.0176 ns | 13.407 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.990 ns | 0.0319 ns | 0.0298 ns | 18.993 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.2 | 16.301 ns | 0.0173 ns | 0.0153 ns | 16.303 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 3.0 | 16.034 ns | 0.1719 ns | 0.1608 ns | 16.116 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net461 | 19.343 ns | 0.1104 ns | 0.1033 ns | 19.407 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net472 | 20.912 ns | 0.0667 ns | 0.0591 ns | 20.928 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Char_Nullable_NoValue | .NET Core 2.0 | 12.544 ns | 0.0138 ns | 0.0122 ns | 12.540 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 2.2 | 10.981 ns | 0.0905 ns | 0.0802 ns | 10.998 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 3.0 |  7.552 ns | 0.2657 ns | 0.3547 ns |  7.369 ns |  0.61 |    0.03 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net461 | 12.622 ns | 0.0178 ns | 0.0158 ns | 12.622 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net472 | 10.360 ns | 0.0147 ns | 0.0130 ns | 10.356 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.465 ns | 0.0258 ns | 0.0215 ns | 14.466 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.923 ns | 0.0169 ns | 0.0158 ns | 11.917 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.176 ns | 0.0957 ns | 0.0848 ns | 12.200 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net461 | 13.445 ns | 0.0969 ns | 0.0906 ns | 13.408 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net472 | 16.095 ns | 0.1364 ns | 0.1276 ns | 16.040 ns |  1.11 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                         From_DateTime | .NET Core 2.0 | 12.199 ns | 0.0327 ns | 0.0255 ns | 12.203 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 2.2 | 11.459 ns | 0.0061 ns | 0.0051 ns | 11.459 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 3.0 |  7.736 ns | 0.0212 ns | 0.0188 ns |  7.732 ns |  0.63 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime |        net461 | 13.104 ns | 0.0303 ns | 0.0283 ns | 13.108 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime |        net472 | 13.626 ns | 0.0120 ns | 0.0093 ns | 13.623 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                From_DateTime_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                      From_DateTime_Nullable_WithValue | .NET Core 2.0 | 12.570 ns | 0.0484 ns | 0.0453 ns | 12.558 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 2.2 | 11.828 ns | 0.0238 ns | 0.0223 ns | 11.824 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 3.0 |  8.005 ns | 0.0131 ns | 0.0109 ns |  8.006 ns |  0.64 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net461 | 14.063 ns | 0.0280 ns | 0.0219 ns | 14.058 ns |  1.12 |    0.01 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net472 | 13.939 ns | 0.0310 ns | 0.0275 ns | 13.940 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_DateTime_Nullable_NoValue | .NET Core 2.0 | 12.533 ns | 0.0193 ns | 0.0181 ns | 12.530 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 2.2 | 11.797 ns | 0.0142 ns | 0.0133 ns | 11.797 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 3.0 |  8.027 ns | 0.0279 ns | 0.0261 ns |  8.019 ns |  0.64 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net461 | 14.678 ns | 0.0176 ns | 0.0165 ns | 14.675 ns |  1.17 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net472 | 12.879 ns | 0.0705 ns | 0.0659 ns | 12.897 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.466 ns | 0.0559 ns | 0.0523 ns | 14.449 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.356 ns | 0.3062 ns | 0.4488 ns | 12.279 ns |  0.85 |    0.04 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.899 ns | 0.0300 ns | 0.0266 ns | 12.901 ns |  0.89 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net461 | 13.316 ns | 0.0255 ns | 0.0213 ns | 13.306 ns |  0.92 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net472 | 16.639 ns | 0.0299 ns | 0.0265 ns | 16.632 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                          From_Decimal | .NET Core 2.0 | 25.242 ns | 0.0392 ns | 0.0348 ns | 25.253 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 2.2 | 28.387 ns | 0.2829 ns | 0.2647 ns | 28.255 ns |  1.13 |    0.01 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 3.0 | 14.625 ns | 0.0755 ns | 0.0706 ns | 14.594 ns |  0.58 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal |        net461 | 26.896 ns | 0.0452 ns | 0.0422 ns | 26.901 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal |        net472 | 24.872 ns | 0.0170 ns | 0.0151 ns | 24.873 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                 From_Decimal_AsObject | .NET Core 2.0 | 27.940 ns | 0.0209 ns | 0.0185 ns | 27.944 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 2.2 | 26.164 ns | 0.0545 ns | 0.0483 ns | 26.160 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 3.0 | 20.102 ns | 0.0697 ns | 0.0652 ns | 20.090 ns |  0.72 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net461 | 28.137 ns | 0.0273 ns | 0.0255 ns | 28.141 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net472 | 30.600 ns | 0.1934 ns | 0.1715 ns | 30.664 ns |  1.10 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                       From_Decimal_Nullable_WithValue | .NET Core 2.0 | 25.619 ns | 0.0853 ns | 0.0798 ns | 25.590 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 2.2 | 25.465 ns | 0.0176 ns | 0.0165 ns | 25.470 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 3.0 | 17.750 ns | 0.3807 ns | 0.7514 ns | 18.143 ns |  0.66 |    0.03 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net461 | 27.040 ns | 0.1619 ns | 0.1515 ns | 26.958 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net472 | 27.064 ns | 0.0550 ns | 0.0514 ns | 27.059 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.0 | 27.526 ns | 0.0622 ns | 0.0551 ns | 27.536 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.2 | 25.372 ns | 0.0205 ns | 0.0182 ns | 25.370 ns |  0.92 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 3.0 | 20.032 ns | 0.0281 ns | 0.0249 ns | 20.023 ns |  0.73 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net461 | 28.761 ns | 0.0428 ns | 0.0379 ns | 28.768 ns |  1.04 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net472 | 30.440 ns | 0.1437 ns | 0.1344 ns | 30.363 ns |  1.11 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Decimal_Nullable_NoValue | .NET Core 2.0 | 12.606 ns | 0.0051 ns | 0.0043 ns | 12.607 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 2.2 | 11.926 ns | 0.0211 ns | 0.0165 ns | 11.924 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 3.0 |  8.077 ns | 0.0701 ns | 0.0656 ns |  8.063 ns |  0.64 |    0.01 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net461 | 15.391 ns | 0.0150 ns | 0.0140 ns | 15.387 ns |  1.22 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net472 | 13.508 ns | 0.0308 ns | 0.0288 ns | 13.510 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.145 ns | 0.0438 ns | 0.0388 ns | 14.143 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.138 ns | 0.0172 ns | 0.0134 ns | 12.140 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.928 ns | 0.0227 ns | 0.0212 ns | 12.921 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net461 | 13.311 ns | 0.0250 ns | 0.0195 ns | 13.312 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net472 | 15.909 ns | 0.0304 ns | 0.0285 ns | 15.912 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_Double | .NET Core 2.0 | 13.181 ns | 0.0455 ns | 0.0403 ns | 13.184 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 2.2 | 13.166 ns | 0.0141 ns | 0.0125 ns | 13.163 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 3.0 | 10.074 ns | 0.0615 ns | 0.0576 ns | 10.052 ns |  0.76 |    0.00 |      - |     - |     - |         - |
                                           From_Double |        net461 | 15.506 ns | 0.0363 ns | 0.0303 ns | 15.492 ns |  1.18 |    0.00 |      - |     - |     - |         - |
                                           From_Double |        net472 | 14.058 ns | 0.0340 ns | 0.0284 ns | 14.053 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_Double_AsObject | .NET Core 2.0 | 20.342 ns | 0.0424 ns | 0.0354 ns | 20.338 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 2.2 | 17.305 ns | 0.0258 ns | 0.0242 ns | 17.313 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 3.0 | 17.772 ns | 0.0337 ns | 0.0315 ns | 17.761 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject |        net461 | 20.897 ns | 0.0295 ns | 0.0276 ns | 20.895 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject |        net472 | 22.515 ns | 0.0663 ns | 0.0620 ns | 22.502 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_Double_Nullable_WithValue | .NET Core 2.0 | 15.370 ns | 0.1390 ns | 0.1232 ns | 15.409 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 2.2 | 14.685 ns | 0.0298 ns | 0.0249 ns | 14.678 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 3.0 | 12.706 ns | 0.0271 ns | 0.0253 ns | 12.698 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net461 | 18.232 ns | 0.1613 ns | 0.1509 ns | 18.143 ns |  1.19 |    0.02 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net472 | 16.938 ns | 0.0454 ns | 0.0402 ns | 16.943 ns |  1.10 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.0 | 21.060 ns | 0.0854 ns | 0.0757 ns | 21.035 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.121 ns | 0.0238 ns | 0.0223 ns | 17.126 ns |  0.81 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.484 ns | 0.0566 ns | 0.0502 ns | 17.492 ns |  0.83 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net461 | 20.914 ns | 0.0270 ns | 0.0240 ns | 20.914 ns |  0.99 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net472 | 23.075 ns | 0.0337 ns | 0.0315 ns | 23.070 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Double_Nullable_NoValue | .NET Core 2.0 | 12.484 ns | 0.0234 ns | 0.0219 ns | 12.486 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 2.2 | 11.691 ns | 0.0178 ns | 0.0148 ns | 11.688 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 3.0 |  8.607 ns | 0.1975 ns | 0.2637 ns |  8.738 ns |  0.68 |    0.02 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net461 | 14.075 ns | 0.0129 ns | 0.0114 ns | 14.077 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net472 | 12.789 ns | 0.0379 ns | 0.0355 ns | 12.793 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.975 ns | 0.0218 ns | 0.0182 ns | 14.973 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.177 ns | 0.0559 ns | 0.0523 ns | 12.150 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.999 ns | 0.0147 ns | 0.0138 ns | 12.004 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net461 | 15.090 ns | 0.0254 ns | 0.0199 ns | 15.090 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net472 | 17.429 ns | 0.0335 ns | 0.0297 ns | 17.426 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_Short | .NET Core 2.0 | 11.956 ns | 0.0228 ns | 0.0213 ns | 11.962 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 2.2 | 11.504 ns | 0.0449 ns | 0.0420 ns | 11.498 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 3.0 |  8.115 ns | 0.1485 ns | 0.1390 ns |  8.124 ns |  0.68 |    0.01 |      - |     - |     - |         - |
                                            From_Short |        net461 | 13.327 ns | 0.0254 ns | 0.0238 ns | 13.321 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                            From_Short |        net472 | 11.116 ns | 0.0319 ns | 0.0266 ns | 11.106 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_Short_AsObject | .NET Core 2.0 | 19.584 ns | 0.1489 ns | 0.1393 ns | 19.661 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 2.2 | 16.329 ns | 0.0220 ns | 0.0206 ns | 16.328 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 3.0 | 15.960 ns | 0.1076 ns | 0.1007 ns | 15.951 ns |  0.82 |    0.01 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net461 | 19.618 ns | 0.0360 ns | 0.0319 ns | 19.627 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net472 | 21.905 ns | 0.0321 ns | 0.0284 ns | 21.909 ns |  1.12 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Short_Nullable_WithValue | .NET Core 2.0 | 12.493 ns | 0.0460 ns | 0.0430 ns | 12.478 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 2.2 | 12.397 ns | 0.0354 ns | 0.0314 ns | 12.396 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 3.0 |  8.798 ns | 0.1896 ns | 0.2029 ns |  8.727 ns |  0.71 |    0.02 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net461 | 13.589 ns | 0.0898 ns | 0.0840 ns | 13.627 ns |  1.09 |    0.01 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net472 | 12.133 ns | 0.0375 ns | 0.0350 ns | 12.122 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.189 ns | 0.0523 ns | 0.0437 ns | 19.188 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.2 | 16.294 ns | 0.0114 ns | 0.0089 ns | 16.295 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 3.0 | 16.566 ns | 0.1171 ns | 0.1095 ns | 16.548 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net461 | 19.628 ns | 0.0332 ns | 0.0310 ns | 19.619 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net472 | 20.866 ns | 0.0256 ns | 0.0239 ns | 20.863 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Short_Nullable_NoValue | .NET Core 2.0 | 11.670 ns | 0.0142 ns | 0.0126 ns | 11.673 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 2.2 | 10.743 ns | 0.0089 ns | 0.0083 ns | 10.742 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 3.0 |  6.834 ns | 0.0336 ns | 0.0315 ns |  6.835 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net461 | 11.962 ns | 0.0139 ns | 0.0116 ns | 11.961 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net472 | 10.341 ns | 0.0304 ns | 0.0284 ns | 10.337 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.0 | 18.024 ns | 0.0982 ns | 0.0919 ns | 18.005 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.950 ns | 0.0164 ns | 0.0146 ns | 11.951 ns |  0.66 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.417 ns | 0.1654 ns | 0.1547 ns | 11.290 ns |  0.63 |    0.01 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net461 | 15.083 ns | 0.0319 ns | 0.0266 ns | 15.084 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net472 | 16.647 ns | 0.0234 ns | 0.0208 ns | 16.644 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                              From_Int | .NET Core 2.0 | 11.921 ns | 0.0205 ns | 0.0171 ns | 11.922 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 2.2 | 11.371 ns | 0.0163 ns | 0.0153 ns | 11.372 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 3.0 |  8.009 ns | 0.0423 ns | 0.0396 ns |  7.996 ns |  0.67 |    0.00 |      - |     - |     - |         - |
                                              From_Int |        net461 | 13.254 ns | 0.0156 ns | 0.0146 ns | 13.253 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                              From_Int |        net472 | 11.362 ns | 0.0713 ns | 0.0595 ns | 11.369 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_Int_AsObject | .NET Core 2.0 | 19.495 ns | 0.0237 ns | 0.0222 ns | 19.491 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 2.2 | 15.812 ns | 0.0286 ns | 0.0268 ns | 15.818 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 3.0 | 16.068 ns | 0.0285 ns | 0.0238 ns | 16.066 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net461 | 19.701 ns | 0.1262 ns | 0.1180 ns | 19.654 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net472 | 20.858 ns | 0.0535 ns | 0.0500 ns | 20.863 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Int_Nullable_WithValue | .NET Core 2.0 | 15.400 ns | 0.0381 ns | 0.0356 ns | 15.398 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 2.2 | 12.139 ns | 0.0140 ns | 0.0124 ns | 12.139 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 3.0 |  8.166 ns | 0.0152 ns | 0.0135 ns |  8.167 ns |  0.53 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net461 | 13.265 ns | 0.0532 ns | 0.0498 ns | 13.244 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net472 | 13.108 ns | 0.0207 ns | 0.0184 ns | 13.109 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.472 ns | 0.0870 ns | 0.0814 ns | 19.469 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.2 | 16.001 ns | 0.0241 ns | 0.0202 ns | 15.999 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 3.0 | 16.001 ns | 0.0384 ns | 0.0321 ns | 16.000 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net461 | 22.622 ns | 0.1656 ns | 0.1549 ns | 22.728 ns |  1.16 |    0.01 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net472 | 21.732 ns | 0.0859 ns | 0.0803 ns | 21.700 ns |  1.12 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_Int_Nullable_NoValue | .NET Core 2.0 | 11.757 ns | 0.0088 ns | 0.0068 ns | 11.760 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 2.2 | 10.750 ns | 0.0158 ns | 0.0132 ns | 10.749 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 3.0 |  7.091 ns | 0.0616 ns | 0.0577 ns |  7.109 ns |  0.60 |    0.01 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net461 | 12.644 ns | 0.0305 ns | 0.0285 ns | 12.635 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net472 | 10.321 ns | 0.0291 ns | 0.0272 ns | 10.320 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.927 ns | 0.0364 ns | 0.0322 ns | 14.920 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.925 ns | 0.0227 ns | 0.0201 ns | 11.924 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.795 ns | 0.2510 ns | 0.2577 ns | 11.909 ns |  0.79 |    0.02 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net461 | 13.395 ns | 0.0458 ns | 0.0429 ns | 13.373 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net472 | 16.901 ns | 0.0325 ns | 0.0288 ns | 16.894 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Long | .NET Core 2.0 | 12.124 ns | 0.1222 ns | 0.1143 ns | 12.194 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Long | .NET Core 2.2 | 11.535 ns | 0.0152 ns | 0.0127 ns | 11.530 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                                             From_Long | .NET Core 3.0 |  8.172 ns | 0.0103 ns | 0.0096 ns |  8.172 ns |  0.67 |    0.01 |      - |     - |     - |         - |
                                             From_Long |        net461 | 12.727 ns | 0.0099 ns | 0.0088 ns | 12.727 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                                             From_Long |        net472 | 11.110 ns | 0.0662 ns | 0.0619 ns | 11.098 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Long_AsObject | .NET Core 2.0 | 18.887 ns | 0.0305 ns | 0.0271 ns | 18.882 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 2.2 | 16.024 ns | 0.0232 ns | 0.0205 ns | 16.020 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 3.0 | 16.776 ns | 0.4644 ns | 0.9694 ns | 16.240 ns |  0.97 |    0.03 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net461 | 19.387 ns | 0.0279 ns | 0.0233 ns | 19.389 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net472 | 21.627 ns | 0.0394 ns | 0.0329 ns | 21.639 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Long_Nullable_WithValue | .NET Core 2.0 | 13.516 ns | 0.0161 ns | 0.0135 ns | 13.520 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 2.2 | 13.511 ns | 0.0181 ns | 0.0161 ns | 13.513 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 3.0 | 10.521 ns | 0.0174 ns | 0.0162 ns | 10.517 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net461 | 14.663 ns | 0.0186 ns | 0.0165 ns | 14.664 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net472 | 13.855 ns | 0.0256 ns | 0.0227 ns | 13.858 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.679 ns | 0.2412 ns | 0.2256 ns | 19.674 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.2 | 16.013 ns | 0.0212 ns | 0.0166 ns | 16.015 ns |  0.81 |    0.01 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.577 ns | 0.2194 ns | 0.2053 ns | 17.721 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net461 | 19.802 ns | 0.1251 ns | 0.1170 ns | 19.874 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net472 | 20.947 ns | 0.1087 ns | 0.1017 ns | 20.903 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Long_Nullable_NoValue | .NET Core 2.0 | 12.524 ns | 0.0208 ns | 0.0185 ns | 12.524 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 2.2 | 11.811 ns | 0.0129 ns | 0.0121 ns | 11.809 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 3.0 |  8.236 ns | 0.0122 ns | 0.0108 ns |  8.237 ns |  0.66 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net461 | 13.564 ns | 0.0439 ns | 0.0410 ns | 13.561 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net472 | 12.778 ns | 0.0309 ns | 0.0289 ns | 12.775 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.015 ns | 0.0182 ns | 0.0152 ns | 15.017 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.940 ns | 0.0200 ns | 0.0167 ns | 11.942 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.796 ns | 0.1400 ns | 0.1309 ns | 11.873 ns |  0.78 |    0.01 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net461 | 13.424 ns | 0.0502 ns | 0.0470 ns | 13.410 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net472 | 16.077 ns | 0.0302 ns | 0.0267 ns | 16.076 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_SByte | .NET Core 2.0 | 11.754 ns | 0.0095 ns | 0.0080 ns | 11.755 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 2.2 | 10.238 ns | 0.0152 ns | 0.0142 ns | 10.241 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 3.0 |  6.441 ns | 0.0133 ns | 0.0111 ns |  6.442 ns |  0.55 |    0.00 |      - |     - |     - |         - |
                                            From_SByte |        net461 | 11.899 ns | 0.0767 ns | 0.0718 ns | 11.928 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                            From_SByte |        net472 | 10.421 ns | 0.0229 ns | 0.0203 ns | 10.420 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_SByte_AsObject | .NET Core 2.0 | 15.671 ns | 0.0193 ns | 0.0181 ns | 15.668 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 2.2 | 13.336 ns | 0.0162 ns | 0.0143 ns | 13.335 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 3.0 | 13.126 ns | 0.2394 ns | 0.2239 ns | 13.155 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net461 | 15.963 ns | 0.0314 ns | 0.0278 ns | 15.964 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net472 | 17.418 ns | 0.1765 ns | 0.1651 ns | 17.317 ns |  1.11 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_SByte_Nullable_WithValue | .NET Core 2.0 | 11.835 ns | 0.0189 ns | 0.0158 ns | 11.838 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 2.2 | 10.418 ns | 0.0202 ns | 0.0189 ns | 10.418 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 3.0 |  7.396 ns | 0.1544 ns | 0.1444 ns |  7.281 ns |  0.63 |    0.01 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net461 | 10.710 ns | 0.0174 ns | 0.0154 ns | 10.710 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net472 | 12.174 ns | 0.0229 ns | 0.0203 ns | 12.177 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.0 | 15.792 ns | 0.1581 ns | 0.1479 ns | 15.853 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.2 | 12.529 ns | 0.0113 ns | 0.0100 ns | 12.528 ns |  0.79 |    0.01 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 3.0 | 12.010 ns | 0.0730 ns | 0.0683 ns | 12.004 ns |  0.76 |    0.01 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net461 | 14.496 ns | 0.0398 ns | 0.0372 ns | 14.501 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net472 | 17.355 ns | 0.0981 ns | 0.0918 ns | 17.323 ns |  1.10 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_SByte_Nullable_NoValue | .NET Core 2.0 | 11.673 ns | 0.0138 ns | 0.0129 ns | 11.673 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 2.2 | 10.297 ns | 0.0178 ns | 0.0166 ns | 10.294 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 3.0 |  7.659 ns | 0.0105 ns | 0.0098 ns |  7.656 ns |  0.66 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net461 | 12.006 ns | 0.0556 ns | 0.0520 ns | 11.986 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net472 | 10.341 ns | 0.0193 ns | 0.0181 ns | 10.346 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.130 ns | 0.0297 ns | 0.0263 ns | 14.124 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.143 ns | 0.0199 ns | 0.0186 ns | 12.141 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.396 ns | 0.1705 ns | 0.1595 ns | 11.296 ns |  0.81 |    0.01 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net461 | 13.492 ns | 0.0243 ns | 0.0215 ns | 13.492 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net472 | 17.371 ns | 0.0211 ns | 0.0197 ns | 17.372 ns |  1.23 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_Float | .NET Core 2.0 | 13.393 ns | 0.0677 ns | 0.0633 ns | 13.411 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 2.2 | 13.075 ns | 0.0108 ns | 0.0101 ns | 13.076 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 3.0 |  9.635 ns | 0.0198 ns | 0.0176 ns |  9.631 ns |  0.72 |    0.00 |      - |     - |     - |         - |
                                            From_Float |        net461 | 15.776 ns | 0.0208 ns | 0.0195 ns | 15.782 ns |  1.18 |    0.01 |      - |     - |     - |         - |
                                            From_Float |        net472 | 15.861 ns | 0.1220 ns | 0.1141 ns | 15.810 ns |  1.18 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_Float_AsObject | .NET Core 2.0 | 21.273 ns | 0.0841 ns | 0.0787 ns | 21.296 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 2.2 | 17.536 ns | 0.1514 ns | 0.1416 ns | 17.462 ns |  0.82 |    0.01 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 3.0 | 20.714 ns | 1.2447 ns | 1.8245 ns | 19.711 ns |  1.02 |    0.10 |      - |     - |     - |         - |
                                   From_Float_AsObject |        net461 | 20.868 ns | 0.0311 ns | 0.0276 ns | 20.874 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject |        net472 | 22.104 ns | 0.0483 ns | 0.0403 ns | 22.117 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Float_Nullable_WithValue | .NET Core 2.0 | 14.665 ns | 0.0244 ns | 0.0228 ns | 14.668 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 2.2 | 13.454 ns | 0.0258 ns | 0.0229 ns | 13.449 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 3.0 | 12.713 ns | 0.2785 ns | 0.5874 ns | 12.873 ns |  0.84 |    0.07 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net461 | 14.714 ns | 0.0341 ns | 0.0319 ns | 14.720 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net472 | 13.252 ns | 0.0161 ns | 0.0126 ns | 13.248 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.716 ns | 0.0468 ns | 0.0415 ns | 20.711 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.778 ns | 0.0287 ns | 0.0224 ns | 17.771 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.696 ns | 0.0454 ns | 0.0425 ns | 18.709 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net461 | 20.551 ns | 0.0246 ns | 0.0230 ns | 20.547 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net472 | 22.925 ns | 0.2128 ns | 0.1990 ns | 22.832 ns |  1.11 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Float_Nullable_NoValue | .NET Core 2.0 | 11.906 ns | 0.0088 ns | 0.0082 ns | 11.907 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 2.2 | 10.802 ns | 0.0282 ns | 0.0264 ns | 10.800 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 3.0 |  7.153 ns | 0.0262 ns | 0.0245 ns |  7.148 ns |  0.60 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net461 | 12.224 ns | 0.1469 ns | 0.1374 ns | 12.289 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net472 | 10.421 ns | 0.0281 ns | 0.0262 ns | 10.429 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.381 ns | 0.0260 ns | 0.0243 ns | 15.380 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.939 ns | 0.0174 ns | 0.0154 ns | 11.937 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.871 ns | 0.4849 ns | 0.7691 ns | 11.452 ns |  0.80 |    0.06 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net461 | 15.774 ns | 0.0263 ns | 0.0246 ns | 15.762 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net472 | 14.979 ns | 0.0188 ns | 0.0167 ns | 14.981 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_String | .NET Core 2.0 | 59.224 ns | 0.0821 ns | 0.0728 ns | 59.224 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 2.2 | 54.425 ns | 0.0709 ns | 0.0663 ns | 54.399 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 3.0 | 19.261 ns | 0.0336 ns | 0.0314 ns | 19.261 ns |  0.33 |    0.00 |      - |     - |     - |         - |
                                           From_String |        net461 | 59.999 ns | 0.0889 ns | 0.0788 ns | 59.994 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                           From_String |        net472 | 61.450 ns | 0.6026 ns | 0.5637 ns | 61.652 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_String_AsObject | .NET Core 2.0 | 64.946 ns | 0.8293 ns | 0.7757 ns | 65.086 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 2.2 | 59.950 ns | 0.0948 ns | 0.0887 ns | 59.961 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 3.0 | 23.806 ns | 0.0542 ns | 0.0507 ns | 23.818 ns |  0.37 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject |        net461 | 66.485 ns | 0.4048 ns | 0.3786 ns | 66.591 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                                  From_String_AsObject |        net472 | 67.759 ns | 0.2370 ns | 0.2217 ns | 67.782 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                      From_String_Null | .NET Core 2.0 | 14.153 ns | 0.0155 ns | 0.0145 ns | 14.157 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 2.2 | 12.194 ns | 0.0122 ns | 0.0102 ns | 12.191 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 3.0 | 12.078 ns | 0.2549 ns | 0.2384 ns | 12.199 ns |  0.85 |    0.02 |      - |     - |     - |         - |
                                      From_String_Null |        net461 | 12.807 ns | 0.0151 ns | 0.0141 ns | 12.811 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null |        net472 | 14.499 ns | 0.0134 ns | 0.0125 ns | 14.498 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_String_Null_AsObject | .NET Core 2.0 | 15.758 ns | 0.0281 ns | 0.0263 ns | 15.749 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 2.2 | 11.917 ns | 0.0165 ns | 0.0146 ns | 11.918 ns |  0.76 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 3.0 | 12.921 ns | 0.0349 ns | 0.0326 ns | 12.928 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net461 | 14.998 ns | 0.0175 ns | 0.0146 ns | 14.990 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net472 | 17.005 ns | 0.1548 ns | 0.1448 ns | 17.055 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_String_Empty | .NET Core 2.0 | 12.789 ns | 0.0687 ns | 0.0573 ns | 12.810 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 2.2 | 12.955 ns | 0.0325 ns | 0.0271 ns | 12.947 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 3.0 | 13.774 ns | 0.1274 ns | 0.1191 ns | 13.819 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                                     From_String_Empty |        net461 | 14.388 ns | 0.1390 ns | 0.1300 ns | 14.466 ns |  1.12 |    0.01 |      - |     - |     - |         - |
                                     From_String_Empty |        net472 | 14.837 ns | 0.0288 ns | 0.0255 ns | 14.836 ns |  1.16 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_String_Empty_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_UShort | .NET Core 2.0 | 11.829 ns | 0.0634 ns | 0.0593 ns | 11.841 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 2.2 | 11.293 ns | 0.0225 ns | 0.0211 ns | 11.294 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 3.0 |  7.161 ns | 0.2928 ns | 0.4292 ns |  6.929 ns |  0.62 |    0.04 |      - |     - |     - |         - |
                                           From_UShort |        net461 | 12.878 ns | 0.0753 ns | 0.0668 ns | 12.875 ns |  1.09 |    0.01 |      - |     - |     - |         - |
                                           From_UShort |        net472 | 11.667 ns | 0.0868 ns | 0.0812 ns | 11.686 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_UShort_AsObject | .NET Core 2.0 | 18.221 ns | 0.0333 ns | 0.0295 ns | 18.223 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 2.2 | 15.330 ns | 0.0148 ns | 0.0124 ns | 15.329 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 3.0 | 15.206 ns | 0.1298 ns | 0.1214 ns | 15.133 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net461 | 19.794 ns | 0.1673 ns | 0.1565 ns | 19.882 ns |  1.09 |    0.01 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net472 | 21.920 ns | 0.0245 ns | 0.0217 ns | 21.917 ns |  1.20 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_UShort_Nullable_WithValue | .NET Core 2.0 | 12.745 ns | 0.0184 ns | 0.0163 ns | 12.740 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 2.2 | 11.024 ns | 0.0250 ns | 0.0222 ns | 11.020 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 3.0 |  7.409 ns | 0.0424 ns | 0.0397 ns |  7.400 ns |  0.58 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net461 | 13.174 ns | 0.0414 ns | 0.0387 ns | 13.165 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net472 | 13.111 ns | 0.0141 ns | 0.0132 ns | 13.108 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.901 ns | 0.0304 ns | 0.0254 ns | 18.901 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.352 ns | 0.0203 ns | 0.0169 ns | 15.353 ns |  0.81 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.345 ns | 0.0677 ns | 0.0565 ns | 15.367 ns |  0.81 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net461 | 19.815 ns | 0.0787 ns | 0.0698 ns | 19.785 ns |  1.05 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net472 | 22.085 ns | 0.2151 ns | 0.1907 ns | 22.172 ns |  1.17 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_UShort_Nullable_NoValue | .NET Core 2.0 | 12.435 ns | 0.0543 ns | 0.0508 ns | 12.434 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 2.2 | 10.800 ns | 0.0137 ns | 0.0122 ns | 10.801 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 3.0 |  7.710 ns | 0.1796 ns | 0.3546 ns |  7.867 ns |  0.59 |    0.04 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net461 | 11.886 ns | 0.0195 ns | 0.0173 ns | 11.888 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net472 | 10.335 ns | 0.0167 ns | 0.0139 ns | 10.339 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.142 ns | 0.0254 ns | 0.0225 ns | 14.138 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.928 ns | 0.0151 ns | 0.0141 ns | 11.927 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.944 ns | 0.3232 ns | 0.5661 ns | 15.289 ns |  1.02 |    0.05 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net461 | 13.327 ns | 0.0259 ns | 0.0229 ns | 13.320 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net472 | 15.915 ns | 0.0143 ns | 0.0134 ns | 15.918 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_UInt | .NET Core 2.0 | 12.776 ns | 0.0146 ns | 0.0129 ns | 12.777 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 2.2 | 11.294 ns | 0.0211 ns | 0.0187 ns | 11.291 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 3.0 |  7.218 ns | 0.0664 ns | 0.0589 ns |  7.238 ns |  0.56 |    0.00 |      - |     - |     - |         - |
                                             From_UInt |        net461 | 12.457 ns | 0.0504 ns | 0.0446 ns | 12.443 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                             From_UInt |        net472 | 11.075 ns | 0.1064 ns | 0.0995 ns | 11.115 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_UInt_AsObject | .NET Core 2.0 | 18.728 ns | 0.0346 ns | 0.0323 ns | 18.738 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 2.2 | 15.582 ns | 0.0309 ns | 0.0258 ns | 15.577 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 3.0 | 15.506 ns | 0.1132 ns | 0.1059 ns | 15.483 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net461 | 19.545 ns | 0.0473 ns | 0.0419 ns | 19.545 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net472 | 20.970 ns | 0.1308 ns | 0.1159 ns | 20.957 ns |  1.12 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_UInt_Nullable_WithValue | .NET Core 2.0 | 12.786 ns | 0.0978 ns | 0.0817 ns | 12.815 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 2.2 | 11.025 ns | 0.0145 ns | 0.0129 ns | 11.025 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 3.0 |  7.515 ns | 0.5314 ns | 0.7094 ns |  7.127 ns |  0.62 |    0.06 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net461 | 13.381 ns | 0.0195 ns | 0.0173 ns | 13.374 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net472 | 13.522 ns | 0.1509 ns | 0.1412 ns | 13.611 ns |  1.06 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.199 ns | 0.0468 ns | 0.0391 ns | 18.213 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.561 ns | 0.0167 ns | 0.0156 ns | 15.563 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.140 ns | 0.0321 ns | 0.0284 ns | 15.138 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net461 | 19.537 ns | 0.0287 ns | 0.0224 ns | 19.535 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net472 | 20.900 ns | 0.0312 ns | 0.0276 ns | 20.902 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_UInt_Nullable_NoValue | .NET Core 2.0 | 11.698 ns | 0.0230 ns | 0.0204 ns | 11.701 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 2.2 | 12.512 ns | 0.0206 ns | 0.0193 ns | 12.512 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 3.0 |  6.938 ns | 0.0764 ns | 0.0715 ns |  6.959 ns |  0.59 |    0.01 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net461 | 12.564 ns | 0.0243 ns | 0.0227 ns | 12.567 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net472 | 10.313 ns | 0.0218 ns | 0.0193 ns | 10.313 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.202 ns | 0.1351 ns | 0.1263 ns | 15.253 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.947 ns | 0.0220 ns | 0.0195 ns | 11.943 ns |  0.79 |    0.01 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.240 ns | 0.0283 ns | 0.0265 ns | 11.242 ns |  0.74 |    0.01 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net461 | 13.252 ns | 0.0166 ns | 0.0138 ns | 13.255 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net472 | 16.659 ns | 0.0272 ns | 0.0254 ns | 16.659 ns |  1.10 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_ULong | .NET Core 2.0 | 12.311 ns | 0.0073 ns | 0.0065 ns | 12.311 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 2.2 | 11.224 ns | 0.0175 ns | 0.0156 ns | 11.228 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 3.0 |  7.805 ns | 0.1816 ns | 0.1943 ns |  7.796 ns |  0.64 |    0.02 |      - |     - |     - |         - |
                                            From_ULong |        net461 | 13.039 ns | 0.0451 ns | 0.0400 ns | 13.027 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                            From_ULong |        net472 | 10.905 ns | 0.0240 ns | 0.0225 ns | 10.912 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_ULong_AsObject | .NET Core 2.0 | 18.405 ns | 0.0306 ns | 0.0271 ns | 18.414 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 2.2 | 15.593 ns | 0.0210 ns | 0.0197 ns | 15.595 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 3.0 | 15.605 ns | 0.1753 ns | 0.1639 ns | 15.687 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net461 | 19.582 ns | 0.0477 ns | 0.0446 ns | 19.582 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net472 | 20.856 ns | 0.0224 ns | 0.0187 ns | 20.853 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_ULong_Nullable_WithValue | .NET Core 2.0 | 12.947 ns | 0.0730 ns | 0.0683 ns | 12.968 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 2.2 | 12.000 ns | 0.0191 ns | 0.0169 ns | 11.997 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 3.0 |  8.559 ns | 0.0664 ns | 0.0621 ns |  8.573 ns |  0.66 |    0.01 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net461 | 15.507 ns | 0.0189 ns | 0.0167 ns | 15.507 ns |  1.20 |    0.01 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net472 | 13.936 ns | 0.1382 ns | 0.1292 ns | 13.869 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.694 ns | 0.0424 ns | 0.0354 ns | 18.700 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.569 ns | 0.0210 ns | 0.0176 ns | 15.567 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 3.0 | 16.358 ns | 0.2047 ns | 0.1915 ns | 16.463 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net461 | 19.872 ns | 0.0679 ns | 0.0635 ns | 19.888 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net472 | 21.695 ns | 0.0460 ns | 0.0430 ns | 21.701 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_ULong_Nullable_NoValue | .NET Core 2.0 | 12.488 ns | 0.0166 ns | 0.0156 ns | 12.491 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 2.2 | 11.845 ns | 0.0128 ns | 0.0119 ns | 11.848 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 3.0 |  8.008 ns | 0.0151 ns | 0.0134 ns |  8.010 ns |  0.64 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net461 | 14.909 ns | 0.0336 ns | 0.0314 ns | 14.918 ns |  1.19 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net472 | 12.824 ns | 0.0169 ns | 0.0158 ns | 12.824 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.312 ns | 0.0844 ns | 0.0790 ns | 14.337 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.937 ns | 0.0153 ns | 0.0143 ns | 11.940 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.056 ns | 0.0375 ns | 0.0351 ns | 12.064 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net461 | 13.405 ns | 0.1077 ns | 0.0899 ns | 13.449 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net472 | 15.247 ns | 0.0802 ns | 0.0711 ns | 15.274 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                       From_NullObject | .NET Core 2.0 | 15.992 ns | 0.0175 ns | 0.0155 ns | 15.995 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 2.2 | 11.920 ns | 0.0208 ns | 0.0194 ns | 11.914 ns |  0.75 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 3.0 | 12.007 ns | 0.0177 ns | 0.0157 ns | 11.997 ns |  0.75 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject |        net461 | 13.279 ns | 0.0153 ns | 0.0143 ns | 13.280 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject |        net472 | 15.988 ns | 0.0275 ns | 0.0257 ns | 15.989 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_DBNull | .NET Core 2.0 | 12.439 ns | 0.0141 ns | 0.0125 ns | 12.439 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 2.2 |  9.416 ns | 0.0632 ns | 0.0591 ns |  9.414 ns |  0.76 |    0.01 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 3.0 | 11.492 ns | 0.0668 ns | 0.0625 ns | 11.467 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                                           From_DBNull |        net461 | 11.056 ns | 0.0146 ns | 0.0122 ns | 11.058 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull |        net472 | 14.768 ns | 0.2483 ns | 0.2322 ns | 14.753 ns |  1.19 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_DBNull_AsObject | .NET Core 2.0 | 14.349 ns | 0.0766 ns | 0.0716 ns | 14.368 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 2.2 | 13.006 ns | 0.0179 ns | 0.0167 ns | 13.005 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 3.0 | 11.995 ns | 0.0255 ns | 0.0238 ns | 12.001 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net461 | 13.418 ns | 0.0631 ns | 0.0559 ns | 13.442 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net472 | 16.872 ns | 0.0381 ns | 0.0356 ns | 16.871 ns |  1.18 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                 From_ConvertibleClass | .NET Core 2.0 | 15.674 ns | 0.0593 ns | 0.0555 ns | 15.646 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 2.2 | 13.342 ns | 0.0229 ns | 0.0191 ns | 13.339 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 3.0 | 13.030 ns | 0.0806 ns | 0.0754 ns | 13.018 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net461 | 16.832 ns | 0.0214 ns | 0.0200 ns | 16.834 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net472 | 17.044 ns | 0.0844 ns | 0.0789 ns | 17.040 ns |  1.09 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_ConvertibleClass_AsObject | .NET Core 2.0 | 16.582 ns | 0.0372 ns | 0.0310 ns | 16.582 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 2.2 | 14.322 ns | 0.0151 ns | 0.0133 ns | 14.322 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 3.0 | 14.419 ns | 0.0261 ns | 0.0218 ns | 14.419 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net461 | 16.642 ns | 0.0394 ns | 0.0368 ns | 16.629 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net472 | 18.680 ns | 0.0397 ns | 0.0371 ns | 18.677 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_ConvertibleClass_NoValue | .NET Core 2.0 | 13.008 ns | 0.0124 ns | 0.0104 ns | 13.009 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 2.2 | 12.647 ns | 0.0445 ns | 0.0372 ns | 12.648 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 3.0 | 12.173 ns | 0.6165 ns | 0.8231 ns | 11.728 ns |  0.97 |    0.07 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net461 | 13.271 ns | 0.0802 ns | 0.0750 ns | 13.314 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net472 | 17.462 ns | 0.0902 ns | 0.0800 ns | 17.454 ns |  1.34 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.0 | 14.153 ns | 0.0237 ns | 0.0221 ns | 14.150 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.2 | 11.921 ns | 0.0108 ns | 0.0096 ns | 11.921 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 3.0 | 12.776 ns | 0.1761 ns | 0.1647 ns | 12.898 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net461 | 13.338 ns | 0.0209 ns | 0.0195 ns | 13.334 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net472 | 14.983 ns | 0.0295 ns | 0.0276 ns | 14.976 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                              From_NonConvertibleClass | .NET Core 2.0 | 12.424 ns | 0.0127 ns | 0.0119 ns | 12.427 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 2.2 | 11.164 ns | 0.0195 ns | 0.0152 ns | 11.164 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 3.0 | 11.389 ns | 0.0606 ns | 0.0567 ns | 11.365 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net461 | 12.360 ns | 0.0194 ns | 0.0181 ns | 12.363 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net472 | 12.595 ns | 0.0194 ns | 0.0172 ns | 12.601 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                     From_NonConvertibleClass_AsObject | .NET Core 2.0 | 15.074 ns | 0.0244 ns | 0.0217 ns | 15.073 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 2.2 | 13.532 ns | 0.0888 ns | 0.0787 ns | 13.553 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 3.0 | 14.042 ns | 0.1669 ns | 0.1561 ns | 14.026 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net461 | 15.220 ns | 0.0550 ns | 0.0488 ns | 15.235 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net472 | 18.619 ns | 0.0329 ns | 0.0307 ns | 18.613 ns |  1.24 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                      From_NonConvertibleClass_NoValue | .NET Core 2.0 | 13.189 ns | 0.0275 ns | 0.0244 ns | 13.191 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 2.2 | 11.175 ns | 0.0117 ns | 0.0109 ns | 11.178 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 3.0 | 10.793 ns | 0.0312 ns | 0.0260 ns | 10.784 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net461 | 12.598 ns | 0.0259 ns | 0.0242 ns | 12.595 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net472 | 14.304 ns | 0.0252 ns | 0.0235 ns | 14.304 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.0 | 14.344 ns | 0.0727 ns | 0.0645 ns | 14.336 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.2 | 11.911 ns | 0.0113 ns | 0.0100 ns | 11.912 ns |  0.83 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 3.0 | 12.004 ns | 0.0330 ns | 0.0309 ns | 11.998 ns |  0.84 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net461 | 14.185 ns | 0.0149 ns | 0.0132 ns | 14.181 ns |  0.99 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net472 | 16.858 ns | 0.0214 ns | 0.0178 ns | 16.853 ns |  1.18 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                From_ConvertibleStruct | .NET Core 2.0 | 19.571 ns | 0.0453 ns | 0.0424 ns | 19.563 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 2.2 | 16.386 ns | 0.1439 ns | 0.1346 ns | 16.357 ns |  0.84 |    0.01 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 3.0 | 11.927 ns | 0.1639 ns | 0.1534 ns | 12.013 ns |  0.61 |    0.01 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net461 | 19.519 ns | 0.1306 ns | 0.1221 ns | 19.562 ns |  1.00 |    0.01 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net472 | 17.968 ns | 0.1128 ns | 0.1055 ns | 18.001 ns |  0.92 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                       From_ConvertibleStruct_AsObject | .NET Core 2.0 | 18.065 ns | 0.0278 ns | 0.0260 ns | 18.067 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 2.2 | 14.830 ns | 0.0208 ns | 0.0194 ns | 14.830 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 3.0 | 15.333 ns | 0.0719 ns | 0.0673 ns | 15.307 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net461 | 18.082 ns | 0.0355 ns | 0.0315 ns | 18.085 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net472 | 20.573 ns | 0.0176 ns | 0.0147 ns | 20.569 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.0 | 19.458 ns | 0.0400 ns | 0.0374 ns | 19.460 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.2 | 15.938 ns | 0.0458 ns | 0.0429 ns | 15.926 ns |  0.82 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 3.0 | 12.729 ns | 0.0440 ns | 0.0390 ns | 12.738 ns |  0.65 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net461 | 19.398 ns | 0.0364 ns | 0.0323 ns | 19.391 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net472 | 18.700 ns | 0.1110 ns | 0.1038 ns | 18.655 ns |  0.96 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 21.799 ns | 0.0375 ns | 0.0333 ns | 21.796 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.352 ns | 0.1246 ns | 0.1165 ns | 15.304 ns |  0.70 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.654 ns | 0.0429 ns | 0.0380 ns | 15.654 ns |  0.72 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net461 | 17.540 ns | 0.1924 ns | 0.1800 ns | 17.648 ns |  0.80 |    0.01 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net472 | 20.983 ns | 0.1498 ns | 0.1401 ns | 21.053 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.0 | 13.203 ns | 0.0227 ns | 0.0212 ns | 13.206 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.2 | 11.783 ns | 0.0207 ns | 0.0173 ns | 11.782 ns |  0.89 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 3.0 |  7.467 ns | 0.0099 ns | 0.0092 ns |  7.464 ns |  0.57 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net461 | 12.985 ns | 0.0266 ns | 0.0248 ns | 12.988 ns |  0.98 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net472 | 10.575 ns | 0.0124 ns | 0.0103 ns | 10.576 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.217 ns | 0.1093 ns | 0.1023 ns | 15.258 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.913 ns | 0.0148 ns | 0.0123 ns | 11.913 ns |  0.78 |    0.01 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.499 ns | 0.1839 ns | 0.1720 ns | 11.472 ns |  0.76 |    0.01 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net461 | 13.286 ns | 0.0126 ns | 0.0112 ns | 13.290 ns |  0.87 |    0.01 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net472 | 16.776 ns | 0.0250 ns | 0.0234 ns | 16.768 ns |  1.10 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_NonConvertibleStruct | .NET Core 2.0 | 13.041 ns | 0.0518 ns | 0.0484 ns | 13.017 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 2.2 | 11.643 ns | 0.0888 ns | 0.0831 ns | 11.602 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 3.0 |  6.915 ns | 0.0122 ns | 0.0114 ns |  6.916 ns |  0.53 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net461 | 12.027 ns | 0.0640 ns | 0.0568 ns | 12.043 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net472 | 10.455 ns | 0.0881 ns | 0.0825 ns | 10.424 ns |  0.80 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.0 | 15.047 ns | 0.0294 ns | 0.0261 ns | 15.052 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.2 | 13.328 ns | 0.0201 ns | 0.0188 ns | 13.330 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 3.0 | 13.310 ns | 0.2875 ns | 0.3195 ns | 13.099 ns |  0.89 |    0.02 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net461 | 16.884 ns | 0.0255 ns | 0.0226 ns | 16.874 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net472 | 18.088 ns | 0.0155 ns | 0.0145 ns | 18.086 ns |  1.20 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.0 | 15.246 ns | 0.0867 ns | 0.0724 ns | 15.270 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.2 | 11.631 ns | 0.0195 ns | 0.0163 ns | 11.633 ns |  0.76 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 3.0 |  6.659 ns | 0.0141 ns | 0.0131 ns |  6.660 ns |  0.44 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net461 | 11.925 ns | 0.0273 ns | 0.0228 ns | 11.924 ns |  0.78 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net472 | 11.788 ns | 0.0190 ns | 0.0178 ns | 11.784 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 15.981 ns | 0.0499 ns | 0.0467 ns | 15.992 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 13.359 ns | 0.0589 ns | 0.0523 ns | 13.346 ns |  0.84 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.375 ns | 0.3722 ns | 0.8248 ns | 17.693 ns |  1.03 |    0.08 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net461 | 15.152 ns | 0.0222 ns | 0.0185 ns | 15.155 ns |  0.95 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net472 | 17.402 ns | 0.1336 ns | 0.1116 ns | 17.440 ns |  1.09 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.0 | 13.421 ns | 0.0168 ns | 0.0158 ns | 13.423 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.2 | 11.648 ns | 0.0229 ns | 0.0203 ns | 11.649 ns |  0.87 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 3.0 |  6.821 ns | 0.0611 ns | 0.0572 ns |  6.799 ns |  0.51 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net461 | 12.180 ns | 0.0630 ns | 0.0558 ns | 12.198 ns |  0.91 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net472 | 10.406 ns | 0.0277 ns | 0.0259 ns | 10.414 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.220 ns | 0.0222 ns | 0.0185 ns | 15.221 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.902 ns | 0.0208 ns | 0.0174 ns | 11.906 ns |  0.78 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.994 ns | 0.0171 ns | 0.0160 ns | 12.995 ns |  0.85 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net461 | 13.260 ns | 0.0162 ns | 0.0127 ns | 13.259 ns |  0.87 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net472 | 16.363 ns | 0.0367 ns | 0.0326 ns | 16.352 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Enum | .NET Core 2.0 | 13.529 ns | 0.0732 ns | 0.0649 ns | 13.555 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 2.2 | 10.562 ns | 0.0167 ns | 0.0139 ns | 10.563 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 3.0 |  8.072 ns | 0.3052 ns | 0.4474 ns |  7.827 ns |  0.62 |    0.04 |      - |     - |     - |         - |
                                             From_Enum |        net461 | 13.290 ns | 0.0682 ns | 0.0638 ns | 13.271 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                                             From_Enum |        net472 | 12.784 ns | 0.0593 ns | 0.0495 ns | 12.794 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Enum_AsObject | .NET Core 2.0 | 50.955 ns | 0.0559 ns | 0.0496 ns | 50.960 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject | .NET Core 2.2 | 43.255 ns | 0.0931 ns | 0.0727 ns | 43.274 ns |  0.85 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject | .NET Core 3.0 | 36.606 ns | 0.0515 ns | 0.0430 ns | 36.598 ns |  0.72 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject |        net461 | 46.744 ns | 0.1768 ns | 0.1654 ns | 46.699 ns |  0.92 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject |        net472 | 50.088 ns | 0.3647 ns | 0.3412 ns | 49.990 ns |  0.98 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Enum_Nullable_WithValue | .NET Core 2.0 | 13.978 ns | 0.0440 ns | 0.0390 ns | 13.967 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 2.2 | 11.521 ns | 0.0191 ns | 0.0149 ns | 11.524 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 3.0 |  8.433 ns | 0.0182 ns | 0.0162 ns |  8.433 ns |  0.60 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net461 | 14.951 ns | 0.0109 ns | 0.0097 ns | 14.951 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net472 | 12.270 ns | 0.1024 ns | 0.0958 ns | 12.321 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.0 | 45.473 ns | 0.2024 ns | 0.1794 ns | 45.511 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.2 | 43.430 ns | 0.0497 ns | 0.0440 ns | 43.431 ns |  0.96 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 3.0 | 34.042 ns | 0.0557 ns | 0.0493 ns | 34.029 ns |  0.75 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject |        net461 | 44.945 ns | 0.0650 ns | 0.0576 ns | 44.954 ns |  0.99 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject |        net472 | 45.411 ns | 0.1898 ns | 0.1682 ns | 45.395 ns |  1.00 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Enum_Nullable_NoValue | .NET Core 2.0 | 13.709 ns | 0.0159 ns | 0.0148 ns | 13.706 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 2.2 | 13.818 ns | 0.0250 ns | 0.0234 ns | 13.815 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 3.0 |  7.149 ns | 0.1640 ns | 0.1754 ns |  7.093 ns |  0.52 |    0.01 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net461 | 12.647 ns | 0.0137 ns | 0.0121 ns | 12.647 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net472 | 10.432 ns | 0.0158 ns | 0.0140 ns | 10.433 ns |  0.76 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.870 ns | 0.0374 ns | 0.0331 ns | 15.873 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.915 ns | 0.0171 ns | 0.0143 ns | 11.915 ns |  0.75 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.059 ns | 0.0815 ns | 0.0762 ns | 13.024 ns |  0.82 |    0.01 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net461 | 14.172 ns | 0.0940 ns | 0.0879 ns | 14.130 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net472 | 15.942 ns | 0.0762 ns | 0.0676 ns | 15.919 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                      From_ParentClass | .NET Core 2.0 | 12.179 ns | 0.0190 ns | 0.0158 ns | 12.176 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 2.2 | 11.159 ns | 0.0143 ns | 0.0120 ns | 11.159 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 3.0 | 12.521 ns | 0.2705 ns | 0.3421 ns | 12.689 ns |  1.02 |    0.03 |      - |     - |     - |         - |
                                      From_ParentClass |        net461 | 12.975 ns | 0.0630 ns | 0.0590 ns | 12.943 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass |        net472 | 12.822 ns | 0.0869 ns | 0.0813 ns | 12.786 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_ParentClass_AsObject | .NET Core 2.0 | 16.305 ns | 0.0147 ns | 0.0138 ns | 16.302 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 2.2 | 14.715 ns | 0.0229 ns | 0.0203 ns | 14.716 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 3.0 | 15.083 ns | 0.3250 ns | 0.5860 ns | 14.815 ns |  0.96 |    0.03 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net461 | 15.387 ns | 0.0229 ns | 0.0203 ns | 15.390 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net472 | 18.374 ns | 0.0279 ns | 0.0261 ns | 18.370 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                              From_ParentClass_NoValue | .NET Core 2.0 | 11.982 ns | 0.0138 ns | 0.0123 ns | 11.980 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 2.2 | 11.165 ns | 0.0316 ns | 0.0280 ns | 11.163 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 3.0 | 11.440 ns | 0.0224 ns | 0.0187 ns | 11.438 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net461 | 12.457 ns | 0.0269 ns | 0.0210 ns | 12.455 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net472 | 12.586 ns | 0.0361 ns | 0.0301 ns | 12.581 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.0 | 14.342 ns | 0.1078 ns | 0.1008 ns | 14.345 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.2 | 12.133 ns | 0.0657 ns | 0.0614 ns | 12.147 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 3.0 | 12.415 ns | 0.2143 ns | 0.2004 ns | 12.316 ns |  0.87 |    0.02 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net461 | 13.346 ns | 0.0674 ns | 0.0630 ns | 13.310 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net472 | 15.189 ns | 0.1469 ns | 0.1374 ns | 15.265 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_ParentStruct | .NET Core 2.0 | 38.689 ns | 0.0569 ns | 0.0532 ns | 38.689 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 2.2 | 37.557 ns | 0.0845 ns | 0.0790 ns | 37.543 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 3.0 | 37.093 ns | 0.5080 ns | 0.4504 ns | 37.310 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                                     From_ParentStruct |        net461 | 40.606 ns | 0.1277 ns | 0.1195 ns | 40.627 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct |        net472 | 41.473 ns | 0.0832 ns | 0.0778 ns | 41.492 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_ParentStruct_AsObject | .NET Core 2.0 | 16.598 ns | 0.1157 ns | 0.1026 ns | 16.602 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 2.2 | 13.573 ns | 0.0245 ns | 0.0229 ns | 13.569 ns |  0.82 |    0.01 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 3.0 | 15.399 ns | 0.1197 ns | 0.1120 ns | 15.457 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net461 | 15.411 ns | 0.0288 ns | 0.0241 ns | 15.422 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net472 | 18.380 ns | 0.0206 ns | 0.0182 ns | 18.376 ns |  1.11 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.0 | 39.206 ns | 0.0386 ns | 0.0342 ns | 39.201 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.2 | 37.741 ns | 0.0501 ns | 0.0469 ns | 37.739 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 3.0 | 35.468 ns | 0.1519 ns | 0.1269 ns | 35.430 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue |        net461 | 44.679 ns | 0.2632 ns | 0.2462 ns | 44.561 ns |  1.14 |    0.01 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue |        net472 | 53.113 ns | 0.4808 ns | 0.4498 ns | 53.365 ns |  1.35 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 15.518 ns | 0.0144 ns | 0.0120 ns | 15.521 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 14.746 ns | 0.0217 ns | 0.0192 ns | 14.753 ns |  0.95 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 13.926 ns | 0.0254 ns | 0.0225 ns | 13.925 ns |  0.90 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net461 | 15.640 ns | 0.0284 ns | 0.0265 ns | 15.633 ns |  1.01 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net472 | 17.064 ns | 0.0962 ns | 0.0900 ns | 17.025 ns |  1.10 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.0 | 45.816 ns | 0.5054 ns | 0.4728 ns | 45.749 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.2 | 39.591 ns | 0.0552 ns | 0.0431 ns | 39.605 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 3.0 | 34.619 ns | 0.2331 ns | 0.2067 ns | 34.703 ns |  0.76 |    0.01 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net461 | 47.586 ns | 0.2096 ns | 0.1961 ns | 47.505 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net472 | 38.154 ns | 0.0556 ns | 0.0464 ns | 38.156 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.018 ns | 0.0266 ns | 0.0248 ns | 15.011 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.912 ns | 0.0207 ns | 0.0184 ns | 11.918 ns |  0.79 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.129 ns | 0.0251 ns | 0.0235 ns | 13.129 ns |  0.87 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net461 | 14.109 ns | 0.0108 ns | 0.0101 ns | 14.110 ns |  0.94 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net472 | 17.406 ns | 0.0945 ns | 0.0884 ns | 17.436 ns |  1.16 |    0.01 |      - |     - |     - |         - |

Benchmarks with issues:
  ConvertTo_SByte.From_DateTime_AsObject: Job-LRKCAO(Toolchain=.NET Core 2.0)
  ConvertTo_SByte.From_DateTime_AsObject: Job-VAJWLV(Toolchain=.NET Core 2.2)
  ConvertTo_SByte.From_DateTime_AsObject: Job-TJIRAH(Toolchain=.NET Core 3.0)
  ConvertTo_SByte.From_DateTime_AsObject: Job-HBFVIR(Toolchain=net461)
  ConvertTo_SByte.From_DateTime_AsObject: Job-YRWWQX(Toolchain=net472)
  ConvertTo_SByte.From_DateTime_Nullable_WithValue_AsObject: Job-LRKCAO(Toolchain=.NET Core 2.0)
  ConvertTo_SByte.From_DateTime_Nullable_WithValue_AsObject: Job-VAJWLV(Toolchain=.NET Core 2.2)
  ConvertTo_SByte.From_DateTime_Nullable_WithValue_AsObject: Job-TJIRAH(Toolchain=.NET Core 3.0)
  ConvertTo_SByte.From_DateTime_Nullable_WithValue_AsObject: Job-HBFVIR(Toolchain=net461)
  ConvertTo_SByte.From_DateTime_Nullable_WithValue_AsObject: Job-YRWWQX(Toolchain=net472)
  ConvertTo_SByte.From_String_Empty_AsObject: Job-LRKCAO(Toolchain=.NET Core 2.0)
  ConvertTo_SByte.From_String_Empty_AsObject: Job-VAJWLV(Toolchain=.NET Core 2.2)
  ConvertTo_SByte.From_String_Empty_AsObject: Job-TJIRAH(Toolchain=.NET Core 3.0)
  ConvertTo_SByte.From_String_Empty_AsObject: Job-HBFVIR(Toolchain=net461)
  ConvertTo_SByte.From_String_Empty_AsObject: Job-YRWWQX(Toolchain=net472)
