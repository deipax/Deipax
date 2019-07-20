
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
                                             From_Bool | .NET Core 2.0 | 13.151 ns | 0.0250 ns | 0.0221 ns | 13.154 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 2.2 | 10.436 ns | 0.0157 ns | 0.0131 ns | 10.442 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 3.0 |  9.731 ns | 0.0226 ns | 0.0211 ns |  9.726 ns |  0.74 |    0.00 |      - |     - |     - |         - |
                                             From_Bool |        net461 | 13.612 ns | 0.0240 ns | 0.0213 ns | 13.608 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                             From_Bool |        net472 | 12.928 ns | 0.0106 ns | 0.0083 ns | 12.927 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Bool_AsObject | .NET Core 2.0 | 21.489 ns | 0.0252 ns | 0.0223 ns | 21.487 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 2.2 | 17.326 ns | 0.0119 ns | 0.0112 ns | 17.325 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 3.0 | 18.780 ns | 0.3714 ns | 0.3474 ns | 18.909 ns |  0.88 |    0.02 |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net461 | 26.356 ns | 0.0306 ns | 0.0286 ns | 26.357 ns |  1.23 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net472 | 29.685 ns | 0.0520 ns | 0.0461 ns | 29.675 ns |  1.38 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Bool_Nullable_WithValue | .NET Core 2.0 | 12.161 ns | 0.0405 ns | 0.0379 ns | 12.164 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 2.2 | 10.854 ns | 0.0237 ns | 0.0221 ns | 10.854 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 3.0 |  9.926 ns | 0.0173 ns | 0.0162 ns |  9.925 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net461 | 14.111 ns | 0.0202 ns | 0.0189 ns | 14.105 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net472 | 12.737 ns | 0.0210 ns | 0.0186 ns | 12.731 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.125 ns | 0.0352 ns | 0.0294 ns | 19.121 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.2 | 18.222 ns | 0.0226 ns | 0.0200 ns | 18.222 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.985 ns | 0.0562 ns | 0.0526 ns | 17.992 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net461 | 30.345 ns | 0.0542 ns | 0.0481 ns | 30.355 ns |  1.59 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net472 | 29.797 ns | 0.0577 ns | 0.0540 ns | 29.778 ns |  1.56 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Bool_Nullable_NoValue | .NET Core 2.0 | 13.151 ns | 0.0191 ns | 0.0160 ns | 13.148 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 2.2 | 11.823 ns | 0.0166 ns | 0.0155 ns | 11.818 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 3.0 |  9.739 ns | 0.0235 ns | 0.0208 ns |  9.743 ns |  0.74 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net461 | 14.121 ns | 0.0154 ns | 0.0137 ns | 14.121 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net472 | 12.751 ns | 0.0222 ns | 0.0197 ns | 12.750 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.881 ns | 0.0778 ns | 0.0728 ns | 14.853 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.2 | 18.672 ns | 0.0666 ns | 0.0623 ns | 18.706 ns |  1.25 |    0.01 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.055 ns | 0.3030 ns | 0.4248 ns | 14.310 ns |  0.93 |    0.03 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net461 | 22.610 ns | 0.0308 ns | 0.0241 ns | 22.603 ns |  1.52 |    0.01 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net472 | 25.110 ns | 0.0893 ns | 0.0835 ns | 25.079 ns |  1.69 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Byte | .NET Core 2.0 | 11.820 ns | 0.0159 ns | 0.0148 ns | 11.820 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 2.2 | 10.409 ns | 0.0100 ns | 0.0094 ns | 10.409 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 3.0 | 10.005 ns | 0.0526 ns | 0.0492 ns | 10.036 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                             From_Byte |        net461 | 13.879 ns | 0.0143 ns | 0.0127 ns | 13.882 ns |  1.17 |    0.00 |      - |     - |     - |         - |
                                             From_Byte |        net472 | 12.389 ns | 0.0263 ns | 0.0233 ns | 12.390 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Byte_AsObject | .NET Core 2.0 | 19.249 ns | 0.0287 ns | 0.0240 ns | 19.249 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 2.2 | 17.092 ns | 0.0259 ns | 0.0242 ns | 17.093 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 3.0 | 18.905 ns | 0.1402 ns | 0.1311 ns | 18.975 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net461 | 27.888 ns | 0.6307 ns | 1.1690 ns | 27.420 ns |  1.52 |    0.07 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net472 | 30.154 ns | 0.0323 ns | 0.0270 ns | 30.150 ns |  1.57 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Byte_Nullable_WithValue | .NET Core 2.0 | 12.582 ns | 0.0133 ns | 0.0111 ns | 12.582 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 2.2 | 10.647 ns | 0.0241 ns | 0.0213 ns | 10.638 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 3.0 | 10.357 ns | 0.0152 ns | 0.0135 ns | 10.358 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net461 | 14.146 ns | 0.0179 ns | 0.0168 ns | 14.151 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net472 | 12.918 ns | 0.0125 ns | 0.0111 ns | 12.916 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.360 ns | 0.1209 ns | 0.1131 ns | 19.325 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.2 | 19.373 ns | 0.0712 ns | 0.0666 ns | 19.399 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.989 ns | 0.1856 ns | 0.1736 ns | 19.088 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net461 | 27.285 ns | 0.2591 ns | 0.2424 ns | 27.168 ns |  1.41 |    0.01 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net472 | 29.093 ns | 0.0635 ns | 0.0594 ns | 29.082 ns |  1.50 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Byte_Nullable_NoValue | .NET Core 2.0 | 11.827 ns | 0.0202 ns | 0.0179 ns | 11.824 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 2.2 | 10.266 ns | 0.0121 ns | 0.0101 ns | 10.265 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 3.0 |  9.550 ns | 0.0117 ns | 0.0103 ns |  9.550 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net461 | 14.077 ns | 0.0149 ns | 0.0132 ns | 14.077 ns |  1.19 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net472 | 12.808 ns | 0.0722 ns | 0.0676 ns | 12.844 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.982 ns | 0.0495 ns | 0.0413 ns | 14.992 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.861 ns | 0.3074 ns | 0.7879 ns | 14.717 ns |  0.99 |    0.06 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.401 ns | 0.0138 ns | 0.0129 ns | 13.400 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net461 | 26.262 ns | 0.0521 ns | 0.0487 ns | 26.258 ns |  1.75 |    0.01 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net472 | 24.326 ns | 0.0324 ns | 0.0303 ns | 24.326 ns |  1.62 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Char | .NET Core 2.0 | 11.839 ns | 0.0147 ns | 0.0131 ns | 11.839 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Char | .NET Core 2.2 | 10.473 ns | 0.0137 ns | 0.0121 ns | 10.471 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                             From_Char | .NET Core 3.0 |  9.732 ns | 0.0185 ns | 0.0173 ns |  9.727 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                             From_Char |        net461 | 14.604 ns | 0.0151 ns | 0.0133 ns | 14.602 ns |  1.23 |    0.00 |      - |     - |     - |         - |
                                             From_Char |        net472 | 13.006 ns | 0.0271 ns | 0.0240 ns | 13.006 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Char_AsObject | .NET Core 2.0 | 20.490 ns | 0.1264 ns | 0.1182 ns | 20.434 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 2.2 | 18.010 ns | 0.0246 ns | 0.0230 ns | 18.004 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 3.0 | 18.245 ns | 0.0299 ns | 0.0250 ns | 18.249 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                                    From_Char_AsObject |        net461 | 27.298 ns | 0.3261 ns | 0.3050 ns | 27.215 ns |  1.33 |    0.02 |      - |     - |     - |         - |
                                    From_Char_AsObject |        net472 | 29.148 ns | 0.1502 ns | 0.1405 ns | 29.084 ns |  1.42 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Char_Nullable_WithValue | .NET Core 2.0 | 12.045 ns | 0.0075 ns | 0.0067 ns | 12.047 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 2.2 | 12.625 ns | 0.0177 ns | 0.0157 ns | 12.627 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 3.0 |  9.887 ns | 0.0166 ns | 0.0155 ns |  9.888 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net461 | 15.053 ns | 0.0403 ns | 0.0357 ns | 15.047 ns |  1.25 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net472 | 13.738 ns | 0.0336 ns | 0.0280 ns | 13.740 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.523 ns | 0.0346 ns | 0.0324 ns | 20.514 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.2 | 18.064 ns | 0.0466 ns | 0.0436 ns | 18.060 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.389 ns | 0.0857 ns | 0.0802 ns | 18.410 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net461 | 31.518 ns | 0.0399 ns | 0.0373 ns | 31.513 ns |  1.54 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net472 | 29.624 ns | 0.0567 ns | 0.0503 ns | 29.632 ns |  1.44 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Char_Nullable_NoValue | .NET Core 2.0 | 12.506 ns | 0.0192 ns | 0.0170 ns | 12.505 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 2.2 | 10.355 ns | 0.0108 ns | 0.0096 ns | 10.357 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 3.0 |  9.893 ns | 0.0369 ns | 0.0345 ns |  9.877 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net461 | 13.821 ns | 0.0141 ns | 0.0110 ns | 13.821 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net472 | 12.963 ns | 0.0248 ns | 0.0220 ns | 12.959 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.557 ns | 0.0146 ns | 0.0130 ns | 15.562 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.940 ns | 0.0175 ns | 0.0155 ns | 12.938 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.195 ns | 0.0308 ns | 0.0288 ns | 13.194 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net461 | 25.140 ns | 0.0588 ns | 0.0550 ns | 25.122 ns |  1.62 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net472 | 24.109 ns | 0.0360 ns | 0.0300 ns | 24.096 ns |  1.55 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                         From_DateTime | .NET Core 2.0 | 12.325 ns | 0.0129 ns | 0.0115 ns | 12.325 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 2.2 | 11.087 ns | 0.0136 ns | 0.0121 ns | 11.085 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 3.0 |  9.919 ns | 0.0094 ns | 0.0083 ns |  9.918 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime |        net461 | 14.520 ns | 0.0381 ns | 0.0356 ns | 14.521 ns |  1.18 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime |        net472 | 13.761 ns | 0.0167 ns | 0.0148 ns | 13.757 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                From_DateTime_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                      From_DateTime_Nullable_WithValue | .NET Core 2.0 | 12.337 ns | 0.0167 ns | 0.0148 ns | 12.338 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 2.2 | 11.276 ns | 0.0234 ns | 0.0219 ns | 11.269 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 3.0 | 10.152 ns | 0.0626 ns | 0.0586 ns | 10.124 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net461 | 15.473 ns | 0.1182 ns | 0.1106 ns | 15.515 ns |  1.25 |    0.01 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net472 | 13.310 ns | 0.0404 ns | 0.0378 ns | 13.319 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_DateTime_Nullable_NoValue | .NET Core 2.0 | 12.346 ns | 0.0155 ns | 0.0138 ns | 12.344 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 2.2 | 11.269 ns | 0.0177 ns | 0.0165 ns | 11.263 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 3.0 | 10.128 ns | 0.0160 ns | 0.0142 ns | 10.126 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net461 | 14.505 ns | 0.0149 ns | 0.0116 ns | 14.506 ns |  1.17 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net472 | 16.496 ns | 0.0253 ns | 0.0211 ns | 16.495 ns |  1.34 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.434 ns | 0.0310 ns | 0.0259 ns | 15.421 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.555 ns | 0.0134 ns | 0.0125 ns | 14.554 ns |  0.94 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.210 ns | 0.3025 ns | 0.4798 ns | 14.468 ns |  0.89 |    0.04 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net461 | 22.836 ns | 0.0186 ns | 0.0165 ns | 22.831 ns |  1.48 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net472 | 25.445 ns | 0.0372 ns | 0.0348 ns | 25.431 ns |  1.65 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                          From_Decimal | .NET Core 2.0 | 24.286 ns | 0.0236 ns | 0.0197 ns | 24.282 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 2.2 | 23.862 ns | 0.0331 ns | 0.0310 ns | 23.857 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 3.0 | 14.296 ns | 0.0143 ns | 0.0126 ns | 14.295 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal |        net461 | 26.306 ns | 0.0262 ns | 0.0219 ns | 26.303 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal |        net472 | 26.473 ns | 0.0435 ns | 0.0407 ns | 26.463 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                 From_Decimal_AsObject | .NET Core 2.0 | 31.019 ns | 0.1551 ns | 0.1450 ns | 30.951 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 2.2 | 29.332 ns | 0.0356 ns | 0.0297 ns | 29.336 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 3.0 | 23.886 ns | 0.1500 ns | 0.1403 ns | 23.838 ns |  0.77 |    0.01 |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net461 | 37.113 ns | 0.1248 ns | 0.1106 ns | 37.152 ns |  1.20 |    0.01 |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net472 | 37.799 ns | 0.0367 ns | 0.0307 ns | 37.808 ns |  1.22 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                       From_Decimal_Nullable_WithValue | .NET Core 2.0 | 25.841 ns | 0.0258 ns | 0.0229 ns | 25.840 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 2.2 | 24.152 ns | 0.0226 ns | 0.0211 ns | 24.156 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 3.0 | 19.421 ns | 0.0262 ns | 0.0232 ns | 19.418 ns |  0.75 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net461 | 27.924 ns | 0.0271 ns | 0.0240 ns | 27.925 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net472 | 28.145 ns | 0.0324 ns | 0.0303 ns | 28.141 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.0 | 31.117 ns | 0.0334 ns | 0.0279 ns | 31.123 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.2 | 29.432 ns | 0.0287 ns | 0.0240 ns | 29.438 ns |  0.95 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 3.0 | 25.881 ns | 0.0510 ns | 0.0477 ns | 25.880 ns |  0.83 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net461 | 38.848 ns | 0.0437 ns | 0.0387 ns | 38.847 ns |  1.25 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net472 | 37.704 ns | 0.0961 ns | 0.0899 ns | 37.711 ns |  1.21 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Decimal_Nullable_NoValue | .NET Core 2.0 | 12.654 ns | 0.0771 ns | 0.0721 ns | 12.685 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 2.2 | 11.549 ns | 0.0234 ns | 0.0208 ns | 11.546 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 3.0 |  9.940 ns | 0.0140 ns | 0.0131 ns |  9.936 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net461 | 15.183 ns | 0.0246 ns | 0.0230 ns | 15.187 ns |  1.20 |    0.01 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net472 | 13.537 ns | 0.0203 ns | 0.0180 ns | 13.535 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.839 ns | 0.0157 ns | 0.0147 ns | 14.838 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.939 ns | 0.0128 ns | 0.0114 ns | 12.934 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.388 ns | 0.0316 ns | 0.0280 ns | 13.379 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net461 | 22.611 ns | 0.0276 ns | 0.0245 ns | 22.613 ns |  1.52 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net472 | 24.176 ns | 0.0599 ns | 0.0560 ns | 24.168 ns |  1.63 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_Double | .NET Core 2.0 | 15.033 ns | 0.0182 ns | 0.0162 ns | 15.029 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 2.2 | 13.626 ns | 0.0720 ns | 0.0674 ns | 13.649 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 3.0 | 12.983 ns | 0.0789 ns | 0.0738 ns | 13.023 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                           From_Double |        net461 | 16.718 ns | 0.0380 ns | 0.0355 ns | 16.715 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                           From_Double |        net472 | 15.346 ns | 0.0227 ns | 0.0201 ns | 15.342 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_Double_AsObject | .NET Core 2.0 | 21.933 ns | 0.1275 ns | 0.1192 ns | 21.973 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 2.2 | 19.630 ns | 0.0200 ns | 0.0187 ns | 19.629 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 3.0 | 20.558 ns | 0.0388 ns | 0.0324 ns | 20.565 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                                  From_Double_AsObject |        net461 | 32.482 ns | 0.0250 ns | 0.0221 ns | 32.477 ns |  1.48 |    0.01 |      - |     - |     - |         - |
                                  From_Double_AsObject |        net472 | 31.381 ns | 0.0437 ns | 0.0409 ns | 31.379 ns |  1.43 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_Double_Nullable_WithValue | .NET Core 2.0 | 16.579 ns | 0.0157 ns | 0.0139 ns | 16.578 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 2.2 | 14.456 ns | 0.0184 ns | 0.0172 ns | 14.462 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 3.0 | 13.375 ns | 0.0226 ns | 0.0200 ns | 13.372 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net461 | 17.412 ns | 0.0185 ns | 0.0144 ns | 17.409 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net472 | 17.969 ns | 0.0810 ns | 0.0718 ns | 17.991 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.0 | 21.879 ns | 0.1323 ns | 0.1237 ns | 21.831 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.2 | 20.228 ns | 0.0441 ns | 0.0412 ns | 20.232 ns |  0.92 |    0.01 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 3.0 | 20.778 ns | 0.0676 ns | 0.0632 ns | 20.756 ns |  0.95 |    0.01 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net461 | 29.289 ns | 0.0553 ns | 0.0517 ns | 29.292 ns |  1.34 |    0.01 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net472 | 32.376 ns | 0.0768 ns | 0.0642 ns | 32.379 ns |  1.48 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Double_Nullable_NoValue | .NET Core 2.0 | 12.374 ns | 0.0177 ns | 0.0157 ns | 12.372 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 2.2 | 11.437 ns | 0.0148 ns | 0.0124 ns | 11.441 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 3.0 |  9.914 ns | 0.0156 ns | 0.0138 ns |  9.907 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net461 | 14.267 ns | 0.0255 ns | 0.0238 ns | 14.260 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net472 | 14.210 ns | 0.0176 ns | 0.0165 ns | 14.207 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.889 ns | 0.0409 ns | 0.0383 ns | 14.872 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.976 ns | 0.0500 ns | 0.0468 ns | 12.957 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 3.0 | 15.031 ns | 0.0721 ns | 0.0675 ns | 15.059 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net461 | 23.052 ns | 0.0559 ns | 0.0496 ns | 23.060 ns |  1.55 |    0.01 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net472 | 25.517 ns | 0.0663 ns | 0.0587 ns | 25.534 ns |  1.71 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_Short | .NET Core 2.0 | 12.241 ns | 0.0161 ns | 0.0143 ns | 12.237 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 2.2 | 10.490 ns | 0.0314 ns | 0.0294 ns | 10.494 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 3.0 |  9.480 ns | 0.0092 ns | 0.0077 ns |  9.481 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                                            From_Short |        net461 | 12.923 ns | 0.0157 ns | 0.0139 ns | 12.919 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                            From_Short |        net472 | 12.261 ns | 0.0333 ns | 0.0295 ns | 12.253 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_Short_AsObject | .NET Core 2.0 | 26.449 ns | 0.0270 ns | 0.0252 ns | 26.447 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 2.2 | 26.365 ns | 0.0311 ns | 0.0276 ns | 26.373 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 3.0 | 28.377 ns | 0.0635 ns | 0.0594 ns | 28.374 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net461 | 35.307 ns | 0.0422 ns | 0.0395 ns | 35.310 ns |  1.33 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net472 | 38.644 ns | 0.2193 ns | 0.2051 ns | 38.719 ns |  1.46 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Short_Nullable_WithValue | .NET Core 2.0 | 11.262 ns | 0.0161 ns | 0.0142 ns | 11.260 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 2.2 | 10.075 ns | 0.0145 ns | 0.0128 ns | 10.075 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 3.0 |  7.752 ns | 0.1800 ns | 0.3717 ns |  7.868 ns |  0.66 |    0.06 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net461 | 13.452 ns | 0.0188 ns | 0.0167 ns | 13.452 ns |  1.19 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net472 | 12.577 ns | 0.0413 ns | 0.0386 ns | 12.557 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.0 | 26.880 ns | 0.0265 ns | 0.0248 ns | 26.875 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.2 | 25.462 ns | 0.0297 ns | 0.0278 ns | 25.456 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 3.0 | 29.556 ns | 0.2956 ns | 0.2765 ns | 29.677 ns |  1.10 |    0.01 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net461 | 35.447 ns | 0.0412 ns | 0.0344 ns | 35.451 ns |  1.32 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net472 | 36.572 ns | 0.0467 ns | 0.0437 ns | 36.561 ns |  1.36 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Short_Nullable_NoValue | .NET Core 2.0 | 11.276 ns | 0.0169 ns | 0.0141 ns | 11.273 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 2.2 | 10.096 ns | 0.0202 ns | 0.0189 ns | 10.092 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 3.0 |  6.929 ns | 0.0118 ns | 0.0105 ns |  6.926 ns |  0.61 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net461 | 11.831 ns | 0.0580 ns | 0.0543 ns | 11.865 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net472 | 11.764 ns | 0.0087 ns | 0.0077 ns | 11.764 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.764 ns | 0.0109 ns | 0.0097 ns | 14.766 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.520 ns | 0.0410 ns | 0.0384 ns | 13.526 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 3.0 | 15.087 ns | 0.3282 ns | 0.6082 ns | 15.368 ns |  0.98 |    0.05 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net461 | 22.796 ns | 0.0241 ns | 0.0214 ns | 22.792 ns |  1.54 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net472 | 25.309 ns | 0.0282 ns | 0.0235 ns | 25.308 ns |  1.71 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                              From_Int | .NET Core 2.0 | 12.608 ns | 0.0100 ns | 0.0089 ns | 12.609 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 2.2 | 11.593 ns | 0.0262 ns | 0.0245 ns | 11.598 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 3.0 |  9.967 ns | 0.0512 ns | 0.0479 ns |  9.938 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                                              From_Int |        net461 | 15.505 ns | 0.0183 ns | 0.0143 ns | 15.503 ns |  1.23 |    0.00 |      - |     - |     - |         - |
                                              From_Int |        net472 | 13.068 ns | 0.0529 ns | 0.0495 ns | 13.081 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_Int_AsObject | .NET Core 2.0 | 19.889 ns | 0.0650 ns | 0.0543 ns | 19.875 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 2.2 | 17.768 ns | 0.0351 ns | 0.0329 ns | 17.758 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 3.0 | 19.978 ns | 0.0434 ns | 0.0362 ns | 19.983 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net461 | 32.108 ns | 0.0451 ns | 0.0422 ns | 32.116 ns |  1.61 |    0.01 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net472 | 30.699 ns | 0.0394 ns | 0.0350 ns | 30.691 ns |  1.54 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Int_Nullable_WithValue | .NET Core 2.0 | 13.081 ns | 0.0249 ns | 0.0233 ns | 13.080 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 2.2 | 11.914 ns | 0.0179 ns | 0.0140 ns | 11.917 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 3.0 | 10.446 ns | 0.0284 ns | 0.0266 ns | 10.450 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net461 | 14.369 ns | 0.0257 ns | 0.0240 ns | 14.365 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net472 | 13.960 ns | 0.0199 ns | 0.0186 ns | 13.955 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.0 | 22.131 ns | 0.0434 ns | 0.0406 ns | 22.119 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.2 | 18.228 ns | 0.0417 ns | 0.0390 ns | 18.221 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 3.0 | 19.481 ns | 0.0417 ns | 0.0370 ns | 19.485 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net461 | 27.406 ns | 0.0485 ns | 0.0453 ns | 27.415 ns |  1.24 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net472 | 29.587 ns | 0.0287 ns | 0.0255 ns | 29.590 ns |  1.34 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_Int_Nullable_NoValue | .NET Core 2.0 | 11.820 ns | 0.0143 ns | 0.0134 ns | 11.816 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 2.2 | 10.283 ns | 0.0129 ns | 0.0101 ns | 10.281 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 3.0 | 10.773 ns | 0.0602 ns | 0.0563 ns | 10.793 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net461 | 15.805 ns | 0.0191 ns | 0.0169 ns | 15.805 ns |  1.34 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net472 | 12.802 ns | 0.0207 ns | 0.0184 ns | 12.799 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.944 ns | 0.1260 ns | 0.1178 ns | 14.930 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.945 ns | 0.0117 ns | 0.0104 ns | 12.944 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.314 ns | 0.0156 ns | 0.0138 ns | 13.314 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net461 | 22.629 ns | 0.0298 ns | 0.0264 ns | 22.625 ns |  1.51 |    0.01 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net472 | 24.568 ns | 0.0634 ns | 0.0562 ns | 24.578 ns |  1.64 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Long | .NET Core 2.0 | 12.733 ns | 0.0452 ns | 0.0422 ns | 12.718 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Long | .NET Core 2.2 | 12.145 ns | 0.0150 ns | 0.0140 ns | 12.139 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                             From_Long | .NET Core 3.0 | 10.319 ns | 0.1191 ns | 0.1114 ns | 10.370 ns |  0.81 |    0.01 |      - |     - |     - |         - |
                                             From_Long |        net461 | 14.077 ns | 0.0225 ns | 0.0211 ns | 14.077 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                             From_Long |        net472 | 13.012 ns | 0.0202 ns | 0.0179 ns | 13.008 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Long_AsObject | .NET Core 2.0 | 19.901 ns | 0.0367 ns | 0.0343 ns | 19.896 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 2.2 | 17.805 ns | 0.0281 ns | 0.0249 ns | 17.799 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 3.0 | 20.048 ns | 0.0445 ns | 0.0417 ns | 20.039 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net461 | 31.066 ns | 0.1746 ns | 0.1633 ns | 31.048 ns |  1.56 |    0.01 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net472 | 30.924 ns | 0.0545 ns | 0.0510 ns | 30.916 ns |  1.55 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Long_Nullable_WithValue | .NET Core 2.0 | 14.108 ns | 0.0164 ns | 0.0145 ns | 14.105 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 2.2 | 12.833 ns | 0.0167 ns | 0.0156 ns | 12.829 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 3.0 | 10.597 ns | 0.0150 ns | 0.0133 ns | 10.597 ns |  0.75 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net461 | 15.290 ns | 0.0251 ns | 0.0222 ns | 15.289 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net472 | 14.565 ns | 0.0243 ns | 0.0215 ns | 14.558 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.289 ns | 0.0414 ns | 0.0387 ns | 20.286 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.2 | 18.966 ns | 0.0180 ns | 0.0159 ns | 18.964 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 3.0 | 19.223 ns | 0.1109 ns | 0.1037 ns | 19.233 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net461 | 27.457 ns | 0.0568 ns | 0.0532 ns | 27.474 ns |  1.35 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net472 | 29.687 ns | 0.0697 ns | 0.0618 ns | 29.694 ns |  1.46 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Long_Nullable_NoValue | .NET Core 2.0 | 12.274 ns | 0.0099 ns | 0.0088 ns | 12.272 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 2.2 | 11.365 ns | 0.0347 ns | 0.0324 ns | 11.358 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 3.0 |  9.681 ns | 0.0147 ns | 0.0123 ns |  9.685 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net461 | 14.234 ns | 0.0164 ns | 0.0146 ns | 14.236 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net472 | 13.320 ns | 0.0686 ns | 0.0641 ns | 13.357 ns |  1.09 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.758 ns | 0.0240 ns | 0.0213 ns | 14.757 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.936 ns | 0.0146 ns | 0.0136 ns | 12.933 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.344 ns | 0.0158 ns | 0.0148 ns | 13.341 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net461 | 22.652 ns | 0.0606 ns | 0.0567 ns | 22.633 ns |  1.54 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net472 | 24.796 ns | 0.0513 ns | 0.0480 ns | 24.798 ns |  1.68 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_SByte | .NET Core 2.0 | 11.822 ns | 0.0142 ns | 0.0126 ns | 11.818 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 2.2 | 10.423 ns | 0.0174 ns | 0.0163 ns | 10.423 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 3.0 |  9.518 ns | 0.0157 ns | 0.0139 ns |  9.518 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                                            From_SByte |        net461 | 13.396 ns | 0.0868 ns | 0.0812 ns | 13.449 ns |  1.13 |    0.01 |      - |     - |     - |         - |
                                            From_SByte |        net472 | 12.214 ns | 0.0210 ns | 0.0186 ns | 12.207 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_SByte_AsObject | .NET Core 2.0 | 19.597 ns | 0.0856 ns | 0.0800 ns | 19.590 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 2.2 | 17.115 ns | 0.0256 ns | 0.0227 ns | 17.116 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 3.0 | 17.357 ns | 0.0178 ns | 0.0158 ns | 17.354 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net461 | 30.452 ns | 0.0465 ns | 0.0435 ns | 30.454 ns |  1.55 |    0.01 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net472 | 29.393 ns | 0.0288 ns | 0.0269 ns | 29.391 ns |  1.50 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_SByte_Nullable_WithValue | .NET Core 2.0 | 11.824 ns | 0.0162 ns | 0.0135 ns | 11.818 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 2.2 | 10.624 ns | 0.0151 ns | 0.0141 ns | 10.618 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 3.0 | 10.193 ns | 0.0371 ns | 0.0347 ns | 10.204 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net461 | 13.599 ns | 0.0209 ns | 0.0186 ns | 13.604 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net472 | 12.747 ns | 0.0197 ns | 0.0184 ns | 12.746 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.831 ns | 0.0605 ns | 0.0536 ns | 19.842 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.082 ns | 0.0208 ns | 0.0184 ns | 17.084 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.645 ns | 0.0213 ns | 0.0166 ns | 17.647 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net461 | 26.946 ns | 0.0530 ns | 0.0470 ns | 26.956 ns |  1.36 |    0.01 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net472 | 30.211 ns | 0.1564 ns | 0.1463 ns | 30.168 ns |  1.52 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_SByte_Nullable_NoValue | .NET Core 2.0 | 11.834 ns | 0.0158 ns | 0.0148 ns | 11.833 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 2.2 | 10.288 ns | 0.0294 ns | 0.0261 ns | 10.276 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 3.0 |  9.475 ns | 0.0172 ns | 0.0152 ns |  9.471 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net461 | 13.446 ns | 0.0223 ns | 0.0174 ns | 13.444 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net472 | 12.746 ns | 0.0218 ns | 0.0193 ns | 12.749 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.426 ns | 0.0268 ns | 0.0251 ns | 15.427 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.933 ns | 0.0117 ns | 0.0109 ns | 12.932 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.750 ns | 0.0241 ns | 0.0225 ns | 14.748 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net461 | 22.605 ns | 0.0418 ns | 0.0391 ns | 22.601 ns |  1.47 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net472 | 24.533 ns | 0.1008 ns | 0.0943 ns | 24.569 ns |  1.59 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_Float | .NET Core 2.0 | 15.267 ns | 0.0131 ns | 0.0116 ns | 15.271 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 2.2 | 13.120 ns | 0.0185 ns | 0.0164 ns | 13.121 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 3.0 | 12.502 ns | 0.0381 ns | 0.0338 ns | 12.497 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                            From_Float |        net461 | 16.341 ns | 0.1098 ns | 0.1027 ns | 16.376 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                                            From_Float |        net472 | 15.439 ns | 0.0347 ns | 0.0290 ns | 15.443 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_Float_AsObject | .NET Core 2.0 | 22.423 ns | 0.0275 ns | 0.0257 ns | 22.426 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 2.2 | 20.945 ns | 0.0241 ns | 0.0226 ns | 20.947 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 3.0 | 22.562 ns | 0.0613 ns | 0.0573 ns | 22.585 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject |        net461 | 29.256 ns | 0.0358 ns | 0.0299 ns | 29.260 ns |  1.30 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject |        net472 | 32.145 ns | 0.0495 ns | 0.0413 ns | 32.157 ns |  1.43 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Float_Nullable_WithValue | .NET Core 2.0 | 14.963 ns | 0.0433 ns | 0.0405 ns | 14.951 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 2.2 | 13.152 ns | 0.0198 ns | 0.0175 ns | 13.152 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 3.0 | 12.916 ns | 0.0175 ns | 0.0164 ns | 12.917 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net461 | 16.068 ns | 0.0466 ns | 0.0436 ns | 16.058 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net472 | 16.041 ns | 0.0391 ns | 0.0366 ns | 16.032 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.0 | 21.974 ns | 0.1995 ns | 0.1866 ns | 21.900 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.2 | 19.635 ns | 0.0350 ns | 0.0327 ns | 19.623 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 3.0 | 20.598 ns | 0.1851 ns | 0.1732 ns | 20.582 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net461 | 29.373 ns | 0.0641 ns | 0.0569 ns | 29.361 ns |  1.34 |    0.01 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net472 | 31.895 ns | 0.0402 ns | 0.0356 ns | 31.896 ns |  1.45 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Float_Nullable_NoValue | .NET Core 2.0 | 12.154 ns | 0.0335 ns | 0.0313 ns | 12.157 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 2.2 | 11.449 ns | 0.0153 ns | 0.0144 ns | 11.450 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 3.0 | 10.154 ns | 0.0140 ns | 0.0131 ns | 10.155 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net461 | 14.363 ns | 0.0283 ns | 0.0265 ns | 14.361 ns |  1.18 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net472 | 12.965 ns | 0.0219 ns | 0.0205 ns | 12.961 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.267 ns | 0.0338 ns | 0.0316 ns | 15.269 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.902 ns | 0.0168 ns | 0.0149 ns | 12.902 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.465 ns | 0.1187 ns | 0.1110 ns | 13.535 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net461 | 22.635 ns | 0.0314 ns | 0.0294 ns | 22.639 ns |  1.48 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net472 | 24.367 ns | 0.0529 ns | 0.0495 ns | 24.364 ns |  1.60 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_String | .NET Core 2.0 | 61.734 ns | 0.2993 ns | 0.2800 ns | 61.804 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 2.2 | 58.846 ns | 0.0889 ns | 0.0832 ns | 58.839 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                                           From_String | .NET Core 3.0 | 20.994 ns | 0.0761 ns | 0.0712 ns | 21.026 ns |  0.34 |    0.00 |      - |     - |     - |         - |
                                           From_String |        net461 | 58.434 ns | 0.0974 ns | 0.0863 ns | 58.421 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                           From_String |        net472 | 61.344 ns | 0.1282 ns | 0.1136 ns | 61.312 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_String_AsObject | .NET Core 2.0 | 65.518 ns | 0.1313 ns | 0.1164 ns | 65.492 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 2.2 | 62.621 ns | 0.1179 ns | 0.1103 ns | 62.622 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 3.0 | 26.571 ns | 0.0327 ns | 0.0306 ns | 26.567 ns |  0.41 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject |        net461 | 70.935 ns | 0.1797 ns | 0.1681 ns | 70.903 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject |        net472 | 72.602 ns | 0.1831 ns | 0.1713 ns | 72.591 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                      From_String_Null | .NET Core 2.0 | 14.771 ns | 0.0186 ns | 0.0165 ns | 14.769 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 2.2 | 18.390 ns | 0.0856 ns | 0.0801 ns | 18.396 ns |  1.25 |    0.01 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 3.0 | 14.147 ns | 0.0345 ns | 0.0306 ns | 14.134 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null |        net461 | 14.790 ns | 0.0110 ns | 0.0098 ns | 14.790 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null |        net472 | 16.142 ns | 0.0568 ns | 0.0531 ns | 16.124 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_String_Null_AsObject | .NET Core 2.0 | 14.847 ns | 0.0218 ns | 0.0193 ns | 14.850 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 2.2 | 12.907 ns | 0.0168 ns | 0.0149 ns | 12.906 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 3.0 | 13.168 ns | 0.0216 ns | 0.0202 ns | 13.167 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net461 | 22.759 ns | 0.0240 ns | 0.0212 ns | 22.760 ns |  1.53 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net472 | 25.276 ns | 0.0216 ns | 0.0202 ns | 25.279 ns |  1.70 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_String_Empty | .NET Core 2.0 | 14.479 ns | 0.0116 ns | 0.0091 ns | 14.479 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 2.2 | 17.563 ns | 0.0171 ns | 0.0143 ns | 17.564 ns |  1.21 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 3.0 | 13.897 ns | 0.0177 ns | 0.0157 ns | 13.899 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty |        net461 | 14.806 ns | 0.0161 ns | 0.0151 ns | 14.804 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty |        net472 | 16.505 ns | 0.0577 ns | 0.0540 ns | 16.520 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_String_Empty_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_UShort | .NET Core 2.0 | 11.874 ns | 0.0160 ns | 0.0141 ns | 11.875 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 2.2 | 10.479 ns | 0.0271 ns | 0.0226 ns | 10.470 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 3.0 |  9.965 ns | 0.0200 ns | 0.0187 ns |  9.960 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                           From_UShort |        net461 | 14.608 ns | 0.0290 ns | 0.0271 ns | 14.606 ns |  1.23 |    0.00 |      - |     - |     - |         - |
                                           From_UShort |        net472 | 13.036 ns | 0.0553 ns | 0.0517 ns | 13.023 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_UShort_AsObject | .NET Core 2.0 | 19.495 ns | 0.0228 ns | 0.0202 ns | 19.495 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 2.2 | 18.628 ns | 0.0385 ns | 0.0341 ns | 18.624 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 3.0 | 17.894 ns | 0.0216 ns | 0.0202 ns | 17.891 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net461 | 31.035 ns | 0.0343 ns | 0.0304 ns | 31.030 ns |  1.59 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net472 | 29.204 ns | 0.0502 ns | 0.0470 ns | 29.207 ns |  1.50 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_UShort_Nullable_WithValue | .NET Core 2.0 | 12.167 ns | 0.0630 ns | 0.0589 ns | 12.144 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 2.2 | 12.575 ns | 0.0260 ns | 0.0243 ns | 12.568 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 3.0 | 10.362 ns | 0.0165 ns | 0.0154 ns | 10.360 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net461 | 14.441 ns | 0.0260 ns | 0.0244 ns | 14.436 ns |  1.19 |    0.01 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net472 | 15.700 ns | 0.0171 ns | 0.0143 ns | 15.699 ns |  1.29 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.082 ns | 0.0222 ns | 0.0208 ns | 20.074 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.542 ns | 0.0213 ns | 0.0189 ns | 17.540 ns |  0.87 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.986 ns | 0.0236 ns | 0.0209 ns | 17.989 ns |  0.90 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net461 | 31.085 ns | 0.0330 ns | 0.0293 ns | 31.076 ns |  1.55 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net472 | 30.263 ns | 0.0582 ns | 0.0545 ns | 30.256 ns |  1.51 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_UShort_Nullable_NoValue | .NET Core 2.0 | 12.065 ns | 0.0281 ns | 0.0262 ns | 12.058 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 2.2 | 12.161 ns | 0.0258 ns | 0.0241 ns | 12.154 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 3.0 |  9.496 ns | 0.0286 ns | 0.0254 ns |  9.505 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net461 | 13.493 ns | 0.0199 ns | 0.0186 ns | 13.490 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net472 | 15.183 ns | 0.0398 ns | 0.0352 ns | 15.185 ns |  1.26 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.817 ns | 0.0151 ns | 0.0134 ns | 14.820 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.905 ns | 0.0157 ns | 0.0131 ns | 12.907 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.409 ns | 0.0220 ns | 0.0172 ns | 13.413 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net461 | 26.474 ns | 0.0213 ns | 0.0189 ns | 26.468 ns |  1.79 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net472 | 24.377 ns | 0.0308 ns | 0.0288 ns | 24.383 ns |  1.65 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_UInt | .NET Core 2.0 | 12.552 ns | 0.0179 ns | 0.0159 ns | 12.552 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 2.2 | 11.845 ns | 0.0135 ns | 0.0120 ns | 11.848 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 3.0 |  9.945 ns | 0.0119 ns | 0.0093 ns |  9.946 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                                             From_UInt |        net461 | 14.108 ns | 0.0387 ns | 0.0362 ns | 14.102 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                             From_UInt |        net472 | 13.957 ns | 0.0840 ns | 0.0785 ns | 13.914 ns |  1.11 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_UInt_AsObject | .NET Core 2.0 | 20.216 ns | 0.0925 ns | 0.0865 ns | 20.244 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 2.2 | 17.959 ns | 0.0301 ns | 0.0267 ns | 17.964 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 3.0 | 18.702 ns | 0.0265 ns | 0.0235 ns | 18.700 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net461 | 27.312 ns | 0.0276 ns | 0.0216 ns | 27.319 ns |  1.35 |    0.01 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net472 | 29.438 ns | 0.0518 ns | 0.0459 ns | 29.439 ns |  1.46 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_UInt_Nullable_WithValue | .NET Core 2.0 | 12.888 ns | 0.0123 ns | 0.0109 ns | 12.888 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 2.2 | 11.968 ns | 0.0260 ns | 0.0230 ns | 11.964 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 3.0 | 10.161 ns | 0.0184 ns | 0.0172 ns | 10.157 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net461 | 14.396 ns | 0.0263 ns | 0.0233 ns | 14.395 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net472 | 13.444 ns | 0.0335 ns | 0.0261 ns | 13.444 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.062 ns | 0.0256 ns | 0.0227 ns | 20.060 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.954 ns | 0.0221 ns | 0.0196 ns | 17.952 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 3.0 | 19.956 ns | 0.0704 ns | 0.0659 ns | 19.952 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net461 | 27.299 ns | 0.0308 ns | 0.0273 ns | 27.304 ns |  1.36 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net472 | 30.025 ns | 0.0373 ns | 0.0330 ns | 30.029 ns |  1.50 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_UInt_Nullable_NoValue | .NET Core 2.0 | 11.846 ns | 0.0182 ns | 0.0162 ns | 11.848 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 2.2 | 10.270 ns | 0.0136 ns | 0.0127 ns | 10.271 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 3.0 |  9.495 ns | 0.0569 ns | 0.0532 ns |  9.523 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net461 | 14.216 ns | 0.0805 ns | 0.0753 ns | 14.223 ns |  1.20 |    0.01 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net472 | 12.746 ns | 0.0149 ns | 0.0139 ns | 12.746 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.813 ns | 0.0157 ns | 0.0139 ns | 14.814 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.912 ns | 0.0141 ns | 0.0125 ns | 12.912 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.341 ns | 0.0251 ns | 0.0234 ns | 13.328 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net461 | 22.642 ns | 0.0280 ns | 0.0248 ns | 22.636 ns |  1.53 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net472 | 24.680 ns | 0.0442 ns | 0.0414 ns | 24.686 ns |  1.67 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_ULong | .NET Core 2.0 | 12.674 ns | 0.0752 ns | 0.0704 ns | 12.684 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 2.2 | 12.713 ns | 0.1471 ns | 0.1376 ns | 12.749 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 3.0 |  9.732 ns | 0.0112 ns | 0.0099 ns |  9.731 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                                            From_ULong |        net461 | 15.000 ns | 0.0256 ns | 0.0227 ns | 15.002 ns |  1.18 |    0.01 |      - |     - |     - |         - |
                                            From_ULong |        net472 | 12.924 ns | 0.0217 ns | 0.0203 ns | 12.922 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_ULong_AsObject | .NET Core 2.0 | 20.357 ns | 0.0213 ns | 0.0189 ns | 20.351 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 2.2 | 18.183 ns | 0.0200 ns | 0.0187 ns | 18.188 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 3.0 | 18.996 ns | 0.1236 ns | 0.1156 ns | 18.941 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net461 | 30.941 ns | 0.0471 ns | 0.0440 ns | 30.947 ns |  1.52 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net472 | 30.581 ns | 0.1572 ns | 0.1471 ns | 30.630 ns |  1.50 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_ULong_Nullable_WithValue | .NET Core 2.0 | 13.806 ns | 0.0195 ns | 0.0163 ns | 13.810 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 2.2 | 13.509 ns | 0.0146 ns | 0.0129 ns | 13.507 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 3.0 | 11.069 ns | 0.1115 ns | 0.1043 ns | 11.115 ns |  0.80 |    0.01 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net461 | 15.236 ns | 0.0187 ns | 0.0166 ns | 15.235 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net472 | 14.552 ns | 0.0162 ns | 0.0144 ns | 14.553 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.715 ns | 0.1419 ns | 0.1327 ns | 20.780 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.751 ns | 0.0195 ns | 0.0173 ns | 17.751 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 3.0 | 19.728 ns | 0.0719 ns | 0.0637 ns | 19.746 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net461 | 30.691 ns | 0.0269 ns | 0.0251 ns | 30.694 ns |  1.48 |    0.01 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net472 | 29.359 ns | 0.0205 ns | 0.0182 ns | 29.357 ns |  1.42 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_ULong_Nullable_NoValue | .NET Core 2.0 | 12.274 ns | 0.0152 ns | 0.0142 ns | 12.278 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 2.2 | 11.234 ns | 0.0187 ns | 0.0156 ns | 11.233 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 3.0 |  9.679 ns | 0.0120 ns | 0.0107 ns |  9.676 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net461 | 14.238 ns | 0.0207 ns | 0.0184 ns | 14.238 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net472 | 14.271 ns | 0.0086 ns | 0.0072 ns | 14.270 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.447 ns | 0.0328 ns | 0.0306 ns | 15.440 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.419 ns | 0.0158 ns | 0.0148 ns | 13.421 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.613 ns | 0.2925 ns | 0.4640 ns | 13.328 ns |  0.90 |    0.03 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net461 | 26.283 ns | 0.0321 ns | 0.0300 ns | 26.292 ns |  1.70 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net472 | 24.407 ns | 0.0325 ns | 0.0304 ns | 24.415 ns |  1.58 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                       From_NullObject | .NET Core 2.0 | 14.858 ns | 0.0149 ns | 0.0139 ns | 14.858 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 2.2 | 15.449 ns | 0.0127 ns | 0.0112 ns | 15.447 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 3.0 | 13.322 ns | 0.0170 ns | 0.0150 ns | 13.318 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject |        net461 | 26.316 ns | 0.0300 ns | 0.0281 ns | 26.319 ns |  1.77 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject |        net472 | 25.394 ns | 0.0542 ns | 0.0481 ns | 25.407 ns |  1.71 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_DBNull | .NET Core 2.0 | 13.819 ns | 0.0155 ns | 0.0130 ns | 13.819 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 2.2 | 11.210 ns | 0.0585 ns | 0.0547 ns | 11.211 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 3.0 | 12.492 ns | 0.0258 ns | 0.0242 ns | 12.482 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull |        net461 | 12.932 ns | 0.0167 ns | 0.0148 ns | 12.932 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull |        net472 | 12.992 ns | 0.0616 ns | 0.0576 ns | 13.024 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_DBNull_AsObject | .NET Core 2.0 | 14.774 ns | 0.0102 ns | 0.0090 ns | 14.775 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 2.2 | 12.923 ns | 0.0168 ns | 0.0140 ns | 12.919 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 3.0 | 14.576 ns | 0.0564 ns | 0.0528 ns | 14.594 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net461 | 22.650 ns | 0.0313 ns | 0.0293 ns | 22.647 ns |  1.53 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net472 | 25.808 ns | 0.0209 ns | 0.0186 ns | 25.811 ns |  1.75 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                 From_ConvertibleClass | .NET Core 2.0 | 18.282 ns | 0.0246 ns | 0.0206 ns | 18.279 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 2.2 | 14.867 ns | 0.0204 ns | 0.0181 ns | 14.862 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 3.0 | 14.948 ns | 0.0203 ns | 0.0158 ns | 14.946 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net461 | 27.774 ns | 0.0614 ns | 0.0574 ns | 27.761 ns |  1.52 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net472 | 26.975 ns | 0.0570 ns | 0.0533 ns | 26.980 ns |  1.48 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_ConvertibleClass_AsObject | .NET Core 2.0 | 19.097 ns | 0.0621 ns | 0.0581 ns | 19.127 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 2.2 | 17.198 ns | 0.0303 ns | 0.0283 ns | 17.199 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 3.0 | 16.601 ns | 0.0273 ns | 0.0228 ns | 16.600 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net461 | 26.103 ns | 0.0579 ns | 0.0541 ns | 26.111 ns |  1.37 |    0.01 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net472 | 27.907 ns | 0.0325 ns | 0.0288 ns | 27.911 ns |  1.46 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_ConvertibleClass_NoValue | .NET Core 2.0 | 14.534 ns | 0.0263 ns | 0.0246 ns | 14.536 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 2.2 | 14.118 ns | 0.0113 ns | 0.0106 ns | 14.115 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 3.0 | 13.494 ns | 0.0841 ns | 0.0787 ns | 13.493 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net461 | 22.736 ns | 0.0259 ns | 0.0243 ns | 22.736 ns |  1.56 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net472 | 24.389 ns | 0.0408 ns | 0.0382 ns | 24.386 ns |  1.68 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.0 | 14.791 ns | 0.0218 ns | 0.0193 ns | 14.792 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.2 | 12.903 ns | 0.0093 ns | 0.0082 ns | 12.901 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 3.0 | 14.717 ns | 0.0088 ns | 0.0069 ns | 14.716 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net461 | 22.697 ns | 0.0314 ns | 0.0294 ns | 22.694 ns |  1.53 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net472 | 24.500 ns | 0.0741 ns | 0.0693 ns | 24.535 ns |  1.66 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                              From_NonConvertibleClass | .NET Core 2.0 | 13.822 ns | 0.0144 ns | 0.0127 ns | 13.822 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 2.2 | 12.779 ns | 0.0261 ns | 0.0218 ns | 12.781 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 3.0 | 12.639 ns | 0.0126 ns | 0.0118 ns | 12.638 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net461 | 15.045 ns | 0.0385 ns | 0.0360 ns | 15.042 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net472 | 14.283 ns | 0.0088 ns | 0.0078 ns | 14.284 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                     From_NonConvertibleClass_AsObject | .NET Core 2.0 | 16.566 ns | 0.0174 ns | 0.0163 ns | 16.560 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 2.2 | 14.775 ns | 0.0156 ns | 0.0146 ns | 14.775 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 3.0 | 16.181 ns | 0.8232 ns | 1.6440 ns | 15.347 ns |  1.10 |    0.09 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net461 | 24.689 ns | 0.0391 ns | 0.0347 ns | 24.693 ns |  1.49 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net472 | 25.853 ns | 0.0331 ns | 0.0310 ns | 25.856 ns |  1.56 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                      From_NonConvertibleClass_NoValue | .NET Core 2.0 | 13.836 ns | 0.0121 ns | 0.0101 ns | 13.839 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 2.2 | 12.676 ns | 0.0247 ns | 0.0219 ns | 12.674 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 3.0 | 13.221 ns | 0.0380 ns | 0.0317 ns | 13.221 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net461 | 14.331 ns | 0.0149 ns | 0.0132 ns | 14.333 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net472 | 14.328 ns | 0.0378 ns | 0.0354 ns | 14.322 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.0 | 14.922 ns | 0.0147 ns | 0.0122 ns | 14.920 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.2 | 12.901 ns | 0.0083 ns | 0.0074 ns | 12.903 ns |  0.86 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 3.0 | 13.335 ns | 0.0248 ns | 0.0220 ns | 13.332 ns |  0.89 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net461 | 22.720 ns | 0.0326 ns | 0.0305 ns | 22.719 ns |  1.52 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net472 | 25.360 ns | 0.0318 ns | 0.0282 ns | 25.357 ns |  1.70 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                From_ConvertibleStruct | .NET Core 2.0 | 20.837 ns | 0.0700 ns | 0.0655 ns | 20.833 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 2.2 | 16.010 ns | 0.0541 ns | 0.0479 ns | 15.998 ns |  0.77 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 3.0 | 14.227 ns | 0.0934 ns | 0.0873 ns | 14.259 ns |  0.68 |    0.01 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net461 | 20.506 ns | 0.0782 ns | 0.0653 ns | 20.514 ns |  0.98 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net472 | 19.935 ns | 0.0357 ns | 0.0299 ns | 19.924 ns |  0.96 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                       From_ConvertibleStruct_AsObject | .NET Core 2.0 | 18.904 ns | 0.0274 ns | 0.0214 ns | 18.905 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 2.2 | 20.109 ns | 0.0271 ns | 0.0211 ns | 20.115 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 3.0 | 17.256 ns | 0.0303 ns | 0.0268 ns | 17.252 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net461 | 26.962 ns | 0.0388 ns | 0.0363 ns | 26.968 ns |  1.43 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net472 | 29.886 ns | 0.1730 ns | 0.1618 ns | 29.932 ns |  1.58 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.0 | 20.443 ns | 0.0412 ns | 0.0386 ns | 20.433 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.2 | 16.125 ns | 0.0432 ns | 0.0404 ns | 16.121 ns |  0.79 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 3.0 | 14.804 ns | 0.2885 ns | 0.2699 ns | 15.021 ns |  0.72 |    0.01 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net461 | 27.504 ns | 0.0571 ns | 0.0534 ns | 27.509 ns |  1.35 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net472 | 25.510 ns | 0.0441 ns | 0.0413 ns | 25.512 ns |  1.25 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.162 ns | 0.1327 ns | 0.1241 ns | 19.207 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.715 ns | 0.0211 ns | 0.0165 ns | 17.710 ns |  0.92 |    0.01 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.024 ns | 0.0202 ns | 0.0188 ns | 17.027 ns |  0.89 |    0.01 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net461 | 26.968 ns | 0.0551 ns | 0.0488 ns | 26.965 ns |  1.41 |    0.01 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net472 | 28.571 ns | 0.0826 ns | 0.0732 ns | 28.543 ns |  1.49 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.0 | 13.863 ns | 0.0104 ns | 0.0092 ns | 13.862 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.2 | 13.335 ns | 0.0272 ns | 0.0255 ns | 13.331 ns |  0.96 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 3.0 | 10.175 ns | 0.0085 ns | 0.0066 ns | 10.175 ns |  0.73 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net461 | 22.718 ns | 0.0239 ns | 0.0212 ns | 22.716 ns |  1.64 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net472 | 18.873 ns | 0.0189 ns | 0.0158 ns | 18.872 ns |  1.36 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.100 ns | 0.0260 ns | 0.0243 ns | 15.095 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.096 ns | 0.0550 ns | 0.0514 ns | 14.080 ns |  0.93 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.566 ns | 0.0149 ns | 0.0139 ns | 13.562 ns |  0.90 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net461 | 22.688 ns | 0.0335 ns | 0.0313 ns | 22.702 ns |  1.50 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net472 | 24.382 ns | 0.0385 ns | 0.0342 ns | 24.390 ns |  1.61 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_NonConvertibleStruct | .NET Core 2.0 | 13.149 ns | 0.0170 ns | 0.0142 ns | 13.146 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 2.2 | 11.420 ns | 0.0110 ns | 0.0097 ns | 11.420 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 3.0 |  9.474 ns | 0.0075 ns | 0.0059 ns |  9.477 ns |  0.72 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net461 | 13.083 ns | 0.0225 ns | 0.0211 ns | 13.080 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net472 | 12.319 ns | 0.0367 ns | 0.0343 ns | 12.322 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.0 | 16.629 ns | 0.0335 ns | 0.0297 ns | 16.633 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.2 | 14.750 ns | 0.0134 ns | 0.0112 ns | 14.751 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 3.0 | 16.807 ns | 0.0319 ns | 0.0299 ns | 16.805 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net461 | 24.448 ns | 0.0523 ns | 0.0489 ns | 24.453 ns |  1.47 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net472 | 25.871 ns | 0.0685 ns | 0.0640 ns | 25.875 ns |  1.56 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.0 | 13.230 ns | 0.0646 ns | 0.0605 ns | 13.264 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.2 | 12.356 ns | 0.0183 ns | 0.0172 ns | 12.352 ns |  0.93 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 3.0 |  9.442 ns | 0.0100 ns | 0.0084 ns |  9.442 ns |  0.71 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net461 | 12.963 ns | 0.0227 ns | 0.0212 ns | 12.963 ns |  0.98 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net472 | 12.252 ns | 0.0262 ns | 0.0232 ns | 12.248 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 17.313 ns | 0.0260 ns | 0.0243 ns | 17.309 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 14.752 ns | 0.0144 ns | 0.0135 ns | 14.753 ns |  0.85 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.830 ns | 0.0822 ns | 0.0769 ns | 15.859 ns |  0.91 |    0.01 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net461 | 24.483 ns | 0.0433 ns | 0.0405 ns | 24.491 ns |  1.41 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net472 | 25.853 ns | 0.0310 ns | 0.0275 ns | 25.859 ns |  1.49 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.0 | 13.135 ns | 0.0152 ns | 0.0127 ns | 13.131 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.2 | 10.368 ns | 0.1166 ns | 0.1091 ns | 10.388 ns |  0.79 |    0.01 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 3.0 |  9.779 ns | 0.0423 ns | 0.0396 ns |  9.794 ns |  0.75 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net461 | 13.784 ns | 0.0224 ns | 0.0210 ns | 13.782 ns |  1.05 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net472 | 12.205 ns | 0.0182 ns | 0.0170 ns | 12.203 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.785 ns | 0.0134 ns | 0.0119 ns | 14.784 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.980 ns | 0.0117 ns | 0.0109 ns | 12.984 ns |  0.88 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.386 ns | 0.0361 ns | 0.0337 ns | 13.402 ns |  0.91 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net461 | 22.601 ns | 0.0353 ns | 0.0295 ns | 22.609 ns |  1.53 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net472 | 24.438 ns | 0.1063 ns | 0.0995 ns | 24.469 ns |  1.65 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Enum | .NET Core 2.0 | 15.315 ns | 0.0226 ns | 0.0189 ns | 15.313 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 2.2 | 16.006 ns | 0.0108 ns | 0.0096 ns | 16.009 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 3.0 |  9.731 ns | 0.0800 ns | 0.0748 ns |  9.689 ns |  0.63 |    0.00 |      - |     - |     - |         - |
                                             From_Enum |        net461 | 13.938 ns | 0.0172 ns | 0.0152 ns | 13.938 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                             From_Enum |        net472 | 12.971 ns | 0.0164 ns | 0.0146 ns | 12.967 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Enum_AsObject | .NET Core 2.0 | 49.546 ns | 0.2509 ns | 0.2346 ns | 49.612 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject | .NET Core 2.2 | 43.182 ns | 0.2080 ns | 0.1946 ns | 43.125 ns |  0.87 |    0.01 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject | .NET Core 3.0 | 40.251 ns | 0.5410 ns | 0.5061 ns | 40.088 ns |  0.81 |    0.01 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject |        net461 | 53.948 ns | 0.0878 ns | 0.0733 ns | 53.953 ns |  1.09 |    0.01 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject |        net472 | 53.748 ns | 0.0577 ns | 0.0482 ns | 53.743 ns |  1.08 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Enum_Nullable_WithValue | .NET Core 2.0 | 15.354 ns | 0.0162 ns | 0.0151 ns | 15.349 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 2.2 | 11.868 ns | 0.0119 ns | 0.0111 ns | 11.866 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 3.0 | 10.111 ns | 0.0140 ns | 0.0124 ns | 10.110 ns |  0.66 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net461 | 14.425 ns | 0.0204 ns | 0.0191 ns | 14.416 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net472 | 13.837 ns | 0.0758 ns | 0.0709 ns | 13.826 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.0 | 48.567 ns | 0.0840 ns | 0.0656 ns | 48.551 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.2 | 45.159 ns | 0.1457 ns | 0.1292 ns | 45.123 ns |  0.93 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 3.0 | 40.594 ns | 0.3973 ns | 0.3716 ns | 40.729 ns |  0.84 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject |        net461 | 56.535 ns | 0.0461 ns | 0.0409 ns | 56.532 ns |  1.16 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject |        net472 | 53.990 ns | 0.1413 ns | 0.1252 ns | 53.952 ns |  1.11 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Enum_Nullable_NoValue | .NET Core 2.0 | 13.152 ns | 0.0147 ns | 0.0122 ns | 13.152 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 2.2 | 11.594 ns | 0.0124 ns | 0.0110 ns | 11.594 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 3.0 |  9.428 ns | 0.0260 ns | 0.0244 ns |  9.422 ns |  0.72 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net461 | 15.271 ns | 0.0422 ns | 0.0374 ns | 15.260 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net472 | 12.731 ns | 0.0082 ns | 0.0077 ns | 12.732 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.767 ns | 0.0117 ns | 0.0104 ns | 14.768 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.926 ns | 0.0096 ns | 0.0085 ns | 12.926 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.411 ns | 0.0761 ns | 0.0712 ns | 13.372 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net461 | 22.670 ns | 0.0243 ns | 0.0203 ns | 22.677 ns |  1.54 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net472 | 24.761 ns | 0.1648 ns | 0.1541 ns | 24.784 ns |  1.68 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                      From_ParentClass | .NET Core 2.0 | 13.837 ns | 0.0236 ns | 0.0209 ns | 13.837 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 2.2 | 12.702 ns | 0.0206 ns | 0.0193 ns | 12.698 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 3.0 | 13.517 ns | 0.2830 ns | 0.2906 ns | 13.736 ns |  0.97 |    0.02 |      - |     - |     - |         - |
                                      From_ParentClass |        net461 | 14.298 ns | 0.0214 ns | 0.0179 ns | 14.300 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass |        net472 | 14.292 ns | 0.0174 ns | 0.0154 ns | 14.290 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_ParentClass_AsObject | .NET Core 2.0 | 17.166 ns | 0.0405 ns | 0.0359 ns | 17.150 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 2.2 | 15.399 ns | 0.0430 ns | 0.0381 ns | 15.401 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 3.0 | 15.411 ns | 0.0431 ns | 0.0382 ns | 15.408 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net461 | 28.463 ns | 0.0400 ns | 0.0334 ns | 28.447 ns |  1.66 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net472 | 27.289 ns | 0.0428 ns | 0.0400 ns | 27.288 ns |  1.59 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                              From_ParentClass_NoValue | .NET Core 2.0 | 13.836 ns | 0.0238 ns | 0.0211 ns | 13.832 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 2.2 | 12.705 ns | 0.0227 ns | 0.0201 ns | 12.702 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 3.0 | 13.200 ns | 0.0418 ns | 0.0391 ns | 13.214 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net461 | 14.342 ns | 0.0143 ns | 0.0127 ns | 14.342 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net472 | 14.318 ns | 0.0244 ns | 0.0204 ns | 14.311 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.0 | 15.535 ns | 0.0705 ns | 0.0659 ns | 15.557 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.2 | 13.011 ns | 0.0205 ns | 0.0181 ns | 13.006 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 3.0 | 13.349 ns | 0.0396 ns | 0.0370 ns | 13.330 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net461 | 26.232 ns | 0.0520 ns | 0.0461 ns | 26.222 ns |  1.69 |    0.01 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net472 | 25.304 ns | 0.0160 ns | 0.0142 ns | 25.305 ns |  1.63 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_ParentStruct | .NET Core 2.0 | 43.719 ns | 0.0546 ns | 0.0484 ns | 43.705 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 2.2 | 40.631 ns | 0.0554 ns | 0.0491 ns | 40.621 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 3.0 | 39.251 ns | 0.1658 ns | 0.1551 ns | 39.207 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct |        net461 | 41.661 ns | 0.0336 ns | 0.0298 ns | 41.667 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct |        net472 | 40.661 ns | 0.0411 ns | 0.0365 ns | 40.647 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_ParentStruct_AsObject | .NET Core 2.0 | 17.767 ns | 0.0145 ns | 0.0129 ns | 17.769 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 2.2 | 16.142 ns | 0.0292 ns | 0.0259 ns | 16.133 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 3.0 | 15.206 ns | 0.0190 ns | 0.0169 ns | 15.205 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net461 | 27.419 ns | 0.0234 ns | 0.0208 ns | 27.424 ns |  1.54 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net472 | 26.105 ns | 0.0393 ns | 0.0368 ns | 26.106 ns |  1.47 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.0 | 44.401 ns | 0.0660 ns | 0.0585 ns | 44.402 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.2 | 40.947 ns | 0.0610 ns | 0.0509 ns | 40.938 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 3.0 | 40.606 ns | 0.5404 ns | 0.5055 ns | 40.871 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue |        net461 | 41.780 ns | 0.0697 ns | 0.0618 ns | 41.776 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue |        net472 | 43.553 ns | 0.0665 ns | 0.0622 ns | 43.553 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 17.914 ns | 0.0256 ns | 0.0239 ns | 17.913 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.257 ns | 0.0289 ns | 0.0270 ns | 15.256 ns |  0.85 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 16.856 ns | 0.0882 ns | 0.0825 ns | 16.901 ns |  0.94 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net461 | 24.507 ns | 0.0397 ns | 0.0371 ns | 24.504 ns |  1.37 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net472 | 27.455 ns | 0.1585 ns | 0.1482 ns | 27.514 ns |  1.53 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.0 | 44.169 ns | 0.1644 ns | 0.1538 ns | 44.224 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.2 | 40.710 ns | 0.0397 ns | 0.0371 ns | 40.710 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 3.0 | 39.811 ns | 0.0400 ns | 0.0355 ns | 39.810 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net461 | 41.692 ns | 0.1864 ns | 0.1744 ns | 41.600 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net472 | 40.766 ns | 0.0392 ns | 0.0327 ns | 40.760 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.785 ns | 0.0179 ns | 0.0159 ns | 14.780 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.005 ns | 0.0261 ns | 0.0204 ns | 13.012 ns |  0.88 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.493 ns | 0.0106 ns | 0.0099 ns | 14.490 ns |  0.98 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net461 | 22.795 ns | 0.0302 ns | 0.0282 ns | 22.789 ns |  1.54 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net472 | 25.281 ns | 0.0166 ns | 0.0155 ns | 25.284 ns |  1.71 |    0.00 |      - |     - |     - |         - |

Benchmarks with issues:
  ConvertTo_ShortNullable.From_DateTime_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_ShortNullable.From_DateTime_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_ShortNullable.From_DateTime_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_ShortNullable.From_DateTime_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_ShortNullable.From_DateTime_AsObject: Job-ZVTGBZ(Toolchain=net472)
  ConvertTo_ShortNullable.From_DateTime_Nullable_WithValue_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_ShortNullable.From_DateTime_Nullable_WithValue_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_ShortNullable.From_DateTime_Nullable_WithValue_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_ShortNullable.From_DateTime_Nullable_WithValue_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_ShortNullable.From_DateTime_Nullable_WithValue_AsObject: Job-ZVTGBZ(Toolchain=net472)
  ConvertTo_ShortNullable.From_String_Empty_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_ShortNullable.From_String_Empty_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_ShortNullable.From_String_Empty_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_ShortNullable.From_String_Empty_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_ShortNullable.From_String_Empty_AsObject: Job-ZVTGBZ(Toolchain=net472)
