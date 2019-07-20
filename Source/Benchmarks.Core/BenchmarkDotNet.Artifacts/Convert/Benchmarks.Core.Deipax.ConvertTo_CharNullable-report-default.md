
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
                                             From_Bool | .NET Core 2.0 | 15.301 ns | 0.0328 ns | 0.0307 ns | 15.292 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 2.2 | 10.701 ns | 0.0172 ns | 0.0161 ns | 10.700 ns |  0.70 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 3.0 |  9.488 ns | 0.0149 ns | 0.0132 ns |  9.484 ns |  0.62 |    0.00 |      - |     - |     - |         - |
                                             From_Bool |        net461 | 13.803 ns | 0.0646 ns | 0.0572 ns | 13.775 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                             From_Bool |        net472 | 12.667 ns | 0.0134 ns | 0.0125 ns | 12.663 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Bool_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Bool_Nullable_WithValue | .NET Core 2.0 | 12.284 ns | 0.0162 ns | 0.0136 ns | 12.287 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 2.2 | 10.565 ns | 0.0169 ns | 0.0150 ns | 10.572 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 3.0 |  9.479 ns | 0.0115 ns | 0.0102 ns |  9.478 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net461 | 13.014 ns | 0.0177 ns | 0.0148 ns | 13.014 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net472 | 12.315 ns | 0.0203 ns | 0.0190 ns | 12.311 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Bool_Nullable_NoValue | .NET Core 2.0 | 14.077 ns | 0.0479 ns | 0.0448 ns | 14.064 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 2.2 | 10.720 ns | 0.1034 ns | 0.0917 ns | 10.758 ns |  0.76 |    0.01 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 3.0 |  9.270 ns | 0.0458 ns | 0.0382 ns |  9.261 ns |  0.66 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net461 | 13.672 ns | 0.0203 ns | 0.0169 ns | 13.671 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net472 | 12.490 ns | 0.0966 ns | 0.0856 ns | 12.518 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.626 ns | 0.0206 ns | 0.0192 ns | 15.623 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.991 ns | 0.0239 ns | 0.0223 ns | 12.989 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.573 ns | 0.0266 ns | 0.0249 ns | 14.570 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net461 | 22.818 ns | 0.0966 ns | 0.0903 ns | 22.810 ns |  1.46 |    0.01 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net472 | 24.447 ns | 0.0321 ns | 0.0300 ns | 24.442 ns |  1.56 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Byte | .NET Core 2.0 | 11.926 ns | 0.0142 ns | 0.0126 ns | 11.926 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 2.2 | 10.885 ns | 0.0128 ns | 0.0114 ns | 10.888 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 3.0 |  9.492 ns | 0.0099 ns | 0.0088 ns |  9.490 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                             From_Byte |        net461 | 12.984 ns | 0.0212 ns | 0.0199 ns | 12.982 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                             From_Byte |        net472 | 12.331 ns | 0.0152 ns | 0.0142 ns | 12.333 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Byte_AsObject | .NET Core 2.0 | 19.698 ns | 0.0528 ns | 0.0494 ns | 19.699 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 2.2 | 17.384 ns | 0.1860 ns | 0.1740 ns | 17.432 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 3.0 | 19.486 ns | 0.2803 ns | 0.2622 ns | 19.551 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net461 | 27.511 ns | 0.0807 ns | 0.0755 ns | 27.484 ns |  1.40 |    0.01 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net472 | 29.170 ns | 0.1774 ns | 0.1659 ns | 29.096 ns |  1.48 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Byte_Nullable_WithValue | .NET Core 2.0 | 12.392 ns | 0.0239 ns | 0.0200 ns | 12.397 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 2.2 | 11.164 ns | 0.0228 ns | 0.0213 ns | 11.164 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 3.0 |  9.973 ns | 0.0171 ns | 0.0152 ns |  9.973 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net461 | 15.522 ns | 0.0682 ns | 0.0605 ns | 15.536 ns |  1.25 |    0.01 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net472 | 12.769 ns | 0.0109 ns | 0.0102 ns | 12.769 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.392 ns | 0.0292 ns | 0.0259 ns | 20.385 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.155 ns | 0.0158 ns | 0.0123 ns | 17.154 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.360 ns | 0.1175 ns | 0.1099 ns | 17.446 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net461 | 27.411 ns | 0.0560 ns | 0.0524 ns | 27.405 ns |  1.34 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net472 | 28.937 ns | 0.0385 ns | 0.0341 ns | 28.943 ns |  1.42 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Byte_Nullable_NoValue | .NET Core 2.0 | 11.965 ns | 0.0254 ns | 0.0238 ns | 11.957 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 2.2 | 10.938 ns | 0.1164 ns | 0.1089 ns | 11.017 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 3.0 |  9.862 ns | 0.0803 ns | 0.0751 ns |  9.895 ns |  0.82 |    0.01 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net461 | 14.417 ns | 0.0134 ns | 0.0125 ns | 14.420 ns |  1.20 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net472 | 12.798 ns | 0.0156 ns | 0.0122 ns | 12.800 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.330 ns | 0.0153 ns | 0.0128 ns | 15.332 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.984 ns | 0.0186 ns | 0.0165 ns | 12.989 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.251 ns | 0.0192 ns | 0.0180 ns | 13.247 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net461 | 23.799 ns | 0.0512 ns | 0.0428 ns | 23.809 ns |  1.55 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net472 | 24.188 ns | 0.0275 ns | 0.0244 ns | 24.191 ns |  1.58 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Char | .NET Core 2.0 | 12.105 ns | 0.0191 ns | 0.0169 ns | 12.104 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Char | .NET Core 2.2 | 10.440 ns | 0.0130 ns | 0.0115 ns | 10.440 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                             From_Char | .NET Core 3.0 |  9.745 ns | 0.0111 ns | 0.0104 ns |  9.744 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                                             From_Char |        net461 | 13.034 ns | 0.0252 ns | 0.0235 ns | 13.034 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                             From_Char |        net472 | 12.763 ns | 0.1561 ns | 0.1384 ns | 12.802 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Char_AsObject | .NET Core 2.0 | 24.151 ns | 0.0279 ns | 0.0248 ns | 24.152 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 2.2 | 25.656 ns | 0.2792 ns | 0.2612 ns | 25.823 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 3.0 | 29.322 ns | 0.2866 ns | 0.2681 ns | 29.507 ns |  1.22 |    0.01 |      - |     - |     - |         - |
                                    From_Char_AsObject |        net461 | 36.378 ns | 0.1674 ns | 0.1484 ns | 36.406 ns |  1.51 |    0.01 |      - |     - |     - |         - |
                                    From_Char_AsObject |        net472 | 37.465 ns | 0.0824 ns | 0.0771 ns | 37.483 ns |  1.55 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Char_Nullable_WithValue | .NET Core 2.0 | 11.366 ns | 0.0147 ns | 0.0130 ns | 11.364 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 2.2 | 10.282 ns | 0.0310 ns | 0.0290 ns | 10.279 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 3.0 |  6.452 ns | 0.0191 ns | 0.0169 ns |  6.451 ns |  0.57 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net461 | 12.341 ns | 0.1216 ns | 0.1138 ns | 12.337 ns |  1.09 |    0.01 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net472 | 11.837 ns | 0.0367 ns | 0.0325 ns | 11.834 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.0 | 25.276 ns | 0.0195 ns | 0.0182 ns | 25.276 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.2 | 25.502 ns | 0.0403 ns | 0.0377 ns | 25.516 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 3.0 | 27.383 ns | 0.2250 ns | 0.1995 ns | 27.504 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net461 | 35.807 ns | 0.0464 ns | 0.0434 ns | 35.801 ns |  1.42 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net472 | 38.815 ns | 0.0793 ns | 0.0662 ns | 38.833 ns |  1.54 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Char_Nullable_NoValue | .NET Core 2.0 | 12.943 ns | 0.1172 ns | 0.1097 ns | 12.962 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 2.2 | 10.339 ns | 0.1077 ns | 0.1008 ns | 10.269 ns |  0.80 |    0.01 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 3.0 |  6.583 ns | 0.1349 ns | 0.1262 ns |  6.568 ns |  0.51 |    0.01 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net461 | 12.810 ns | 0.0147 ns | 0.0138 ns | 12.810 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net472 | 12.870 ns | 0.0095 ns | 0.0080 ns | 12.870 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.617 ns | 0.0197 ns | 0.0175 ns | 15.615 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.585 ns | 0.0177 ns | 0.0157 ns | 13.588 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.734 ns | 0.0336 ns | 0.0315 ns | 13.734 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net461 | 22.180 ns | 0.0237 ns | 0.0222 ns | 22.177 ns |  1.42 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net472 | 24.364 ns | 0.0942 ns | 0.0835 ns | 24.327 ns |  1.56 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                         From_DateTime | .NET Core 2.0 | 13.129 ns | 0.0120 ns | 0.0106 ns | 13.132 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 2.2 | 11.719 ns | 0.0182 ns | 0.0170 ns | 11.724 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 3.0 | 10.096 ns | 0.2320 ns | 0.3098 ns |  9.930 ns |  0.78 |    0.03 |      - |     - |     - |         - |
                                         From_DateTime |        net461 | 13.910 ns | 0.0286 ns | 0.0223 ns | 13.907 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime |        net472 | 15.420 ns | 0.0258 ns | 0.0241 ns | 15.417 ns |  1.17 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                From_DateTime_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                      From_DateTime_Nullable_WithValue | .NET Core 2.0 | 13.346 ns | 0.2186 ns | 0.2045 ns | 13.327 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 2.2 | 12.688 ns | 0.0150 ns | 0.0133 ns | 12.688 ns |  0.95 |    0.02 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 3.0 | 10.016 ns | 0.0334 ns | 0.0296 ns | 10.020 ns |  0.75 |    0.01 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net461 | 14.328 ns | 0.0160 ns | 0.0150 ns | 14.333 ns |  1.07 |    0.02 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net472 | 13.966 ns | 0.0382 ns | 0.0298 ns | 13.967 ns |  1.04 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_DateTime_Nullable_NoValue | .NET Core 2.0 | 12.686 ns | 0.0176 ns | 0.0147 ns | 12.688 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 2.2 | 12.882 ns | 0.1170 ns | 0.1094 ns | 12.937 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 3.0 |  9.952 ns | 0.0148 ns | 0.0139 ns |  9.953 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net461 | 14.104 ns | 0.0190 ns | 0.0178 ns | 14.105 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net472 | 13.350 ns | 0.0291 ns | 0.0258 ns | 13.347 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.859 ns | 0.0231 ns | 0.0205 ns | 14.863 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.008 ns | 0.0312 ns | 0.0292 ns | 13.008 ns |  0.88 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.231 ns | 0.0142 ns | 0.0133 ns | 13.231 ns |  0.89 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net461 | 24.344 ns | 0.0352 ns | 0.0329 ns | 24.341 ns |  1.64 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net472 | 26.183 ns | 0.0317 ns | 0.0248 ns | 26.184 ns |  1.76 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                          From_Decimal | .NET Core 2.0 | 12.642 ns | 0.0169 ns | 0.0142 ns | 12.638 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 2.2 | 11.919 ns | 0.0127 ns | 0.0119 ns | 11.916 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 3.0 | 10.355 ns | 0.0927 ns | 0.0821 ns | 10.381 ns |  0.82 |    0.01 |      - |     - |     - |         - |
                                          From_Decimal |        net461 | 13.830 ns | 0.0257 ns | 0.0228 ns | 13.836 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal |        net472 | 13.916 ns | 0.0622 ns | 0.0520 ns | 13.912 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                 From_Decimal_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                       From_Decimal_Nullable_WithValue | .NET Core 2.0 | 12.888 ns | 0.0208 ns | 0.0184 ns | 12.885 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 2.2 | 11.970 ns | 0.0225 ns | 0.0211 ns | 11.980 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 3.0 | 10.232 ns | 0.0150 ns | 0.0133 ns | 10.233 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net461 | 14.122 ns | 0.0241 ns | 0.0214 ns | 14.127 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net472 | 13.220 ns | 0.0350 ns | 0.0273 ns | 13.222 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Decimal_Nullable_NoValue | .NET Core 2.0 | 13.310 ns | 0.0298 ns | 0.0279 ns | 13.302 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 2.2 | 12.202 ns | 0.0131 ns | 0.0123 ns | 12.202 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 3.0 | 10.004 ns | 0.0191 ns | 0.0170 ns | 10.008 ns |  0.75 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net461 | 14.199 ns | 0.1510 ns | 0.1413 ns | 14.117 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net472 | 13.230 ns | 0.0511 ns | 0.0478 ns | 13.214 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.919 ns | 0.0184 ns | 0.0163 ns | 14.922 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.986 ns | 0.0202 ns | 0.0189 ns | 12.989 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.238 ns | 0.0164 ns | 0.0128 ns | 13.240 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net461 | 22.695 ns | 0.0307 ns | 0.0288 ns | 22.703 ns |  1.52 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net472 | 25.924 ns | 0.1366 ns | 0.1278 ns | 25.962 ns |  1.74 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_Double | .NET Core 2.0 | 13.282 ns | 0.0171 ns | 0.0142 ns | 13.284 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 2.2 | 10.896 ns | 0.0119 ns | 0.0111 ns | 10.893 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 3.0 |  9.933 ns | 0.0188 ns | 0.0166 ns |  9.933 ns |  0.75 |    0.00 |      - |     - |     - |         - |
                                           From_Double |        net461 | 13.773 ns | 0.0236 ns | 0.0210 ns | 13.773 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                           From_Double |        net472 | 12.764 ns | 0.0104 ns | 0.0087 ns | 12.762 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_Double_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                  From_Double_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                  From_Double_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_Double_Nullable_WithValue | .NET Core 2.0 | 12.704 ns | 0.0197 ns | 0.0184 ns | 12.706 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 2.2 | 13.793 ns | 0.0292 ns | 0.0259 ns | 13.788 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 3.0 |  9.976 ns | 0.0443 ns | 0.0393 ns |  9.963 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net461 | 14.536 ns | 0.0344 ns | 0.0322 ns | 14.530 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net472 | 13.557 ns | 0.0747 ns | 0.0699 ns | 13.569 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Double_Nullable_NoValue | .NET Core 2.0 | 12.678 ns | 0.0281 ns | 0.0263 ns | 12.672 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 2.2 | 11.979 ns | 0.0165 ns | 0.0138 ns | 11.986 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 3.0 | 10.162 ns | 0.0240 ns | 0.0224 ns | 10.157 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net461 | 15.598 ns | 0.0711 ns | 0.0665 ns | 15.607 ns |  1.23 |    0.01 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net472 | 13.850 ns | 0.1258 ns | 0.1176 ns | 13.897 ns |  1.09 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.830 ns | 0.0246 ns | 0.0230 ns | 14.822 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.579 ns | 0.0473 ns | 0.0442 ns | 13.560 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.946 ns | 0.2411 ns | 0.2255 ns | 14.884 ns |  1.01 |    0.02 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net461 | 22.453 ns | 0.0457 ns | 0.0428 ns | 22.443 ns |  1.51 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net472 | 24.942 ns | 0.0727 ns | 0.0567 ns | 24.954 ns |  1.68 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_Short | .NET Core 2.0 | 12.293 ns | 0.0193 ns | 0.0151 ns | 12.291 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 2.2 | 11.084 ns | 0.0494 ns | 0.0462 ns | 11.094 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 3.0 |  9.719 ns | 0.0189 ns | 0.0167 ns |  9.722 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                                            From_Short |        net461 | 14.216 ns | 0.0322 ns | 0.0251 ns | 14.215 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                                            From_Short |        net472 | 13.209 ns | 0.0264 ns | 0.0206 ns | 13.208 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_Short_AsObject | .NET Core 2.0 | 19.697 ns | 0.2091 ns | 0.1956 ns | 19.586 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 2.2 | 17.611 ns | 0.0314 ns | 0.0294 ns | 17.618 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 3.0 | 19.306 ns | 0.1757 ns | 0.1644 ns | 19.372 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net461 | 28.085 ns | 0.0249 ns | 0.0221 ns | 28.083 ns |  1.43 |    0.01 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net472 | 29.540 ns | 0.0598 ns | 0.0559 ns | 29.521 ns |  1.50 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Short_Nullable_WithValue | .NET Core 2.0 | 12.142 ns | 0.0444 ns | 0.0415 ns | 12.133 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 2.2 | 11.130 ns | 0.0108 ns | 0.0084 ns | 11.133 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 3.0 | 10.258 ns | 0.0467 ns | 0.0414 ns | 10.259 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net461 | 15.217 ns | 0.0232 ns | 0.0205 ns | 15.212 ns |  1.25 |    0.01 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net472 | 13.472 ns | 0.0228 ns | 0.0191 ns | 13.467 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.572 ns | 0.0283 ns | 0.0265 ns | 19.573 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.589 ns | 0.0323 ns | 0.0302 ns | 17.589 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 3.0 | 19.198 ns | 0.0492 ns | 0.0436 ns | 19.198 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net461 | 27.699 ns | 0.0709 ns | 0.0628 ns | 27.681 ns |  1.42 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net472 | 29.337 ns | 0.0440 ns | 0.0390 ns | 29.344 ns |  1.50 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Short_Nullable_NoValue | .NET Core 2.0 | 12.113 ns | 0.0322 ns | 0.0302 ns | 12.117 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 2.2 | 10.709 ns | 0.0236 ns | 0.0184 ns | 10.716 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 3.0 | 10.131 ns | 0.0897 ns | 0.0839 ns | 10.177 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net461 | 14.223 ns | 0.0315 ns | 0.0280 ns | 14.219 ns |  1.17 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net472 | 12.765 ns | 0.0348 ns | 0.0308 ns | 12.757 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.916 ns | 0.0215 ns | 0.0201 ns | 14.914 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.764 ns | 0.0500 ns | 0.0443 ns | 13.751 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.587 ns | 0.1738 ns | 0.1452 ns | 13.549 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net461 | 22.757 ns | 0.0485 ns | 0.0430 ns | 22.752 ns |  1.53 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net472 | 25.583 ns | 0.2195 ns | 0.2053 ns | 25.487 ns |  1.72 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                              From_Int | .NET Core 2.0 | 12.657 ns | 0.0472 ns | 0.0442 ns | 12.636 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 2.2 | 12.500 ns | 0.0459 ns | 0.0429 ns | 12.487 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 3.0 |  9.980 ns | 0.1848 ns | 0.1728 ns |  9.878 ns |  0.79 |    0.01 |      - |     - |     - |         - |
                                              From_Int |        net461 | 14.781 ns | 0.1538 ns | 0.1438 ns | 14.834 ns |  1.17 |    0.01 |      - |     - |     - |         - |
                                              From_Int |        net472 | 13.438 ns | 0.0158 ns | 0.0140 ns | 13.438 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_Int_AsObject | .NET Core 2.0 | 19.849 ns | 0.0524 ns | 0.0465 ns | 19.847 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 2.2 | 17.856 ns | 0.0202 ns | 0.0189 ns | 17.853 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 3.0 | 22.102 ns | 0.3073 ns | 0.2874 ns | 22.064 ns |  1.11 |    0.01 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net461 | 27.979 ns | 0.0387 ns | 0.0343 ns | 27.973 ns |  1.41 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net472 | 31.487 ns | 0.3091 ns | 0.2891 ns | 31.381 ns |  1.59 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Int_Nullable_WithValue | .NET Core 2.0 | 13.096 ns | 0.0578 ns | 0.0541 ns | 13.097 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 2.2 | 12.378 ns | 0.1497 ns | 0.1400 ns | 12.448 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 3.0 | 11.158 ns | 0.2462 ns | 0.3024 ns | 11.203 ns |  0.85 |    0.02 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net461 | 14.900 ns | 0.0185 ns | 0.0154 ns | 14.905 ns |  1.14 |    0.01 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net472 | 13.468 ns | 0.0482 ns | 0.0427 ns | 13.474 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.378 ns | 0.0222 ns | 0.0197 ns | 20.378 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.870 ns | 0.0301 ns | 0.0281 ns | 17.861 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.592 ns | 0.3903 ns | 0.5342 ns | 18.391 ns |  0.92 |    0.03 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net461 | 27.705 ns | 0.0318 ns | 0.0282 ns | 27.706 ns |  1.36 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net472 | 31.771 ns | 0.0686 ns | 0.0573 ns | 31.753 ns |  1.56 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_Int_Nullable_NoValue | .NET Core 2.0 | 11.927 ns | 0.0357 ns | 0.0334 ns | 11.922 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 2.2 | 10.765 ns | 0.0129 ns | 0.0120 ns | 10.765 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 3.0 |  9.750 ns | 0.2197 ns | 0.2055 ns |  9.686 ns |  0.82 |    0.02 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net461 | 13.524 ns | 0.0117 ns | 0.0104 ns | 13.524 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net472 | 13.479 ns | 0.0198 ns | 0.0176 ns | 13.480 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.0 | 16.172 ns | 0.0269 ns | 0.0239 ns | 16.171 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.209 ns | 0.1073 ns | 0.0952 ns | 13.253 ns |  0.82 |    0.01 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.680 ns | 0.1546 ns | 0.1446 ns | 13.697 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net461 | 23.050 ns | 0.0227 ns | 0.0201 ns | 23.052 ns |  1.43 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net472 | 24.689 ns | 0.0306 ns | 0.0271 ns | 24.692 ns |  1.53 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Long | .NET Core 2.0 | 13.501 ns | 0.0431 ns | 0.0403 ns | 13.485 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Long | .NET Core 2.2 | 12.041 ns | 0.0168 ns | 0.0157 ns | 12.040 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                             From_Long | .NET Core 3.0 |  9.776 ns | 0.0413 ns | 0.0386 ns |  9.769 ns |  0.72 |    0.00 |      - |     - |     - |         - |
                                             From_Long |        net461 | 14.052 ns | 0.0355 ns | 0.0296 ns | 14.044 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                             From_Long |        net472 | 13.308 ns | 0.1400 ns | 0.1309 ns | 13.369 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Long_AsObject | .NET Core 2.0 | 20.080 ns | 0.0352 ns | 0.0329 ns | 20.076 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 2.2 | 17.855 ns | 0.0326 ns | 0.0289 ns | 17.859 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 3.0 | 18.916 ns | 0.1323 ns | 0.1173 ns | 18.908 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net461 | 27.959 ns | 0.0385 ns | 0.0360 ns | 27.962 ns |  1.39 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net472 | 30.591 ns | 0.0392 ns | 0.0367 ns | 30.586 ns |  1.52 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Long_Nullable_WithValue | .NET Core 2.0 | 16.048 ns | 0.0224 ns | 0.0210 ns | 16.048 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 2.2 | 13.828 ns | 0.1205 ns | 0.1127 ns | 13.875 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 3.0 | 10.967 ns | 0.0834 ns | 0.0739 ns | 10.935 ns |  0.68 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net461 | 16.293 ns | 0.0182 ns | 0.0161 ns | 16.293 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net472 | 14.671 ns | 0.0296 ns | 0.0247 ns | 14.678 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.984 ns | 0.0385 ns | 0.0341 ns | 19.977 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.847 ns | 0.0257 ns | 0.0228 ns | 17.850 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 3.0 | 20.109 ns | 0.1704 ns | 0.1594 ns | 20.155 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net461 | 27.842 ns | 0.0693 ns | 0.0579 ns | 27.832 ns |  1.39 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net472 | 32.238 ns | 0.2060 ns | 0.1927 ns | 32.304 ns |  1.61 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Long_Nullable_NoValue | .NET Core 2.0 | 13.318 ns | 0.0297 ns | 0.0278 ns | 13.316 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 2.2 | 12.102 ns | 0.0219 ns | 0.0205 ns | 12.095 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 3.0 |  9.722 ns | 0.0271 ns | 0.0253 ns |  9.719 ns |  0.73 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net461 | 14.921 ns | 0.0796 ns | 0.0706 ns | 14.937 ns |  1.12 |    0.01 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net472 | 13.432 ns | 0.0476 ns | 0.0422 ns | 13.418 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.110 ns | 0.0962 ns | 0.0900 ns | 15.148 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.208 ns | 0.0731 ns | 0.0683 ns | 13.226 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 3.0 | 15.469 ns | 0.1507 ns | 0.1410 ns | 15.567 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net461 | 25.656 ns | 0.1684 ns | 0.1576 ns | 25.704 ns |  1.70 |    0.01 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net472 | 26.343 ns | 0.0422 ns | 0.0395 ns | 26.354 ns |  1.74 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_SByte | .NET Core 2.0 | 11.936 ns | 0.0201 ns | 0.0188 ns | 11.939 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 2.2 | 11.050 ns | 0.0237 ns | 0.0222 ns | 11.057 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 3.0 |  9.619 ns | 0.0740 ns | 0.0618 ns |  9.611 ns |  0.81 |    0.01 |      - |     - |     - |         - |
                                            From_SByte |        net461 | 14.548 ns | 0.0505 ns | 0.0422 ns | 14.532 ns |  1.22 |    0.00 |      - |     - |     - |         - |
                                            From_SByte |        net472 | 13.628 ns | 0.0673 ns | 0.0562 ns | 13.610 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_SByte_AsObject | .NET Core 2.0 | 19.872 ns | 0.0288 ns | 0.0240 ns | 19.865 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 2.2 | 17.588 ns | 0.0332 ns | 0.0294 ns | 17.587 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 3.0 | 18.033 ns | 0.1442 ns | 0.1278 ns | 17.977 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net461 | 27.414 ns | 0.1341 ns | 0.1189 ns | 27.367 ns |  1.38 |    0.01 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net472 | 30.264 ns | 0.0840 ns | 0.0744 ns | 30.250 ns |  1.52 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_SByte_Nullable_WithValue | .NET Core 2.0 | 12.362 ns | 0.0383 ns | 0.0358 ns | 12.371 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 2.2 | 11.291 ns | 0.0848 ns | 0.0794 ns | 11.321 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 3.0 | 10.707 ns | 0.2396 ns | 0.2353 ns | 10.637 ns |  0.87 |    0.02 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net461 | 16.171 ns | 0.0372 ns | 0.0348 ns | 16.163 ns |  1.31 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net472 | 13.402 ns | 0.0293 ns | 0.0260 ns | 13.401 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.034 ns | 0.1040 ns | 0.0973 ns | 20.073 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.661 ns | 0.0254 ns | 0.0238 ns | 17.660 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 3.0 | 19.169 ns | 0.1253 ns | 0.1172 ns | 19.104 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net461 | 27.214 ns | 0.0410 ns | 0.0342 ns | 27.211 ns |  1.36 |    0.01 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net472 | 29.527 ns | 0.0383 ns | 0.0340 ns | 29.518 ns |  1.47 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_SByte_Nullable_NoValue | .NET Core 2.0 | 12.636 ns | 0.0666 ns | 0.0623 ns | 12.620 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 2.2 | 10.735 ns | 0.0122 ns | 0.0108 ns | 10.735 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 3.0 |  9.835 ns | 0.1527 ns | 0.1428 ns |  9.793 ns |  0.78 |    0.01 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net461 | 14.138 ns | 0.0278 ns | 0.0247 ns | 14.139 ns |  1.12 |    0.01 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net472 | 12.770 ns | 0.0139 ns | 0.0108 ns | 12.767 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.0 | 16.009 ns | 0.0404 ns | 0.0358 ns | 16.007 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.991 ns | 0.0405 ns | 0.0379 ns | 12.980 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.646 ns | 0.0984 ns | 0.0872 ns | 13.607 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net461 | 24.505 ns | 0.0752 ns | 0.0704 ns | 24.491 ns |  1.53 |    0.01 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net472 | 24.504 ns | 0.0769 ns | 0.0642 ns | 24.514 ns |  1.53 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_Float | .NET Core 2.0 | 12.520 ns | 0.0504 ns | 0.0472 ns | 12.532 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 2.2 | 10.903 ns | 0.0168 ns | 0.0149 ns | 10.902 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 3.0 |  9.885 ns | 0.0424 ns | 0.0354 ns |  9.875 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                                            From_Float |        net461 | 14.213 ns | 0.0229 ns | 0.0203 ns | 14.208 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                            From_Float |        net472 | 12.771 ns | 0.0098 ns | 0.0086 ns | 12.770 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_Float_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                   From_Float_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                   From_Float_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Float_Nullable_WithValue | .NET Core 2.0 | 12.383 ns | 0.0571 ns | 0.0534 ns | 12.372 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 2.2 | 11.378 ns | 0.0207 ns | 0.0183 ns | 11.378 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 3.0 | 10.001 ns | 0.2520 ns | 0.2801 ns |  9.917 ns |  0.81 |    0.03 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net461 | 13.717 ns | 0.0505 ns | 0.0472 ns | 13.704 ns |  1.11 |    0.01 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net472 | 12.288 ns | 0.0260 ns | 0.0231 ns | 12.287 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Float_Nullable_NoValue | .NET Core 2.0 | 12.435 ns | 0.0112 ns | 0.0105 ns | 12.434 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 2.2 | 10.557 ns | 0.0175 ns | 0.0146 ns | 10.553 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 3.0 |  9.919 ns | 0.2126 ns | 0.2088 ns |  9.886 ns |  0.80 |    0.02 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net461 | 13.716 ns | 0.0334 ns | 0.0279 ns | 13.714 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net472 | 12.289 ns | 0.0248 ns | 0.0232 ns | 12.286 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.071 ns | 0.0216 ns | 0.0191 ns | 15.065 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.702 ns | 0.1376 ns | 0.1287 ns | 14.645 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 3.0 | 15.635 ns | 0.1781 ns | 0.1666 ns | 15.640 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net461 | 22.692 ns | 0.0396 ns | 0.0370 ns | 22.683 ns |  1.51 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net472 | 26.335 ns | 0.0413 ns | 0.0345 ns | 26.332 ns |  1.75 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_String | .NET Core 2.0 | 15.372 ns | 0.0246 ns | 0.0230 ns | 15.372 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 2.2 | 14.396 ns | 0.0289 ns | 0.0256 ns | 14.394 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 3.0 | 13.925 ns | 0.0663 ns | 0.0620 ns | 13.919 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                           From_String |        net461 | 15.764 ns | 0.0142 ns | 0.0133 ns | 15.764 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                           From_String |        net472 | 17.333 ns | 0.0829 ns | 0.0775 ns | 17.342 ns |  1.13 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_String_AsObject | .NET Core 2.0 | 21.976 ns | 0.0272 ns | 0.0241 ns | 21.975 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 2.2 | 19.158 ns | 0.0355 ns | 0.0277 ns | 19.161 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 3.0 | 18.262 ns | 0.4911 ns | 0.6032 ns | 18.017 ns |  0.83 |    0.03 |      - |     - |     - |         - |
                                  From_String_AsObject |        net461 | 27.533 ns | 0.0979 ns | 0.0915 ns | 27.505 ns |  1.25 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject |        net472 | 30.777 ns | 0.0374 ns | 0.0350 ns | 30.788 ns |  1.40 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                      From_String_Null | .NET Core 2.0 | 13.987 ns | 0.0146 ns | 0.0136 ns | 13.985 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 2.2 | 12.965 ns | 0.0255 ns | 0.0239 ns | 12.967 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 3.0 | 12.661 ns | 0.1112 ns | 0.0986 ns | 12.667 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                                      From_String_Null |        net461 | 14.619 ns | 0.0298 ns | 0.0264 ns | 14.616 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null |        net472 | 15.292 ns | 0.0286 ns | 0.0267 ns | 15.284 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_String_Null_AsObject | .NET Core 2.0 | 14.944 ns | 0.0272 ns | 0.0241 ns | 14.946 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 2.2 | 13.232 ns | 0.0199 ns | 0.0176 ns | 13.229 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 3.0 | 14.028 ns | 0.2972 ns | 0.3422 ns | 14.136 ns |  0.94 |    0.03 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net461 | 22.379 ns | 0.0738 ns | 0.0690 ns | 22.377 ns |  1.50 |    0.01 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net472 | 26.012 ns | 0.1245 ns | 0.1104 ns | 26.031 ns |  1.74 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_String_Empty | .NET Core 2.0 | 14.367 ns | 0.0521 ns | 0.0488 ns | 14.377 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 2.2 | 13.267 ns | 0.0366 ns | 0.0306 ns | 13.263 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 3.0 | 12.649 ns | 0.0746 ns | 0.0698 ns | 12.626 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty |        net461 | 14.654 ns | 0.0592 ns | 0.0554 ns | 14.627 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                                     From_String_Empty |        net472 | 15.745 ns | 0.0233 ns | 0.0207 ns | 15.743 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_String_Empty_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_UShort | .NET Core 2.0 | 12.622 ns | 0.0917 ns | 0.0858 ns | 12.661 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 2.2 | 10.892 ns | 0.0236 ns | 0.0221 ns | 10.889 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 3.0 |  9.618 ns | 0.1625 ns | 0.1520 ns |  9.557 ns |  0.76 |    0.01 |      - |     - |     - |         - |
                                           From_UShort |        net461 | 14.225 ns | 0.0310 ns | 0.0290 ns | 14.224 ns |  1.13 |    0.01 |      - |     - |     - |         - |
                                           From_UShort |        net472 | 13.246 ns | 0.0751 ns | 0.0702 ns | 13.259 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_UShort_AsObject | .NET Core 2.0 | 19.411 ns | 0.0242 ns | 0.0202 ns | 19.398 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 2.2 | 17.152 ns | 0.0285 ns | 0.0252 ns | 17.155 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 3.0 | 19.033 ns | 0.2354 ns | 0.2202 ns | 18.921 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net461 | 27.381 ns | 0.0372 ns | 0.0348 ns | 27.380 ns |  1.41 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net472 | 31.800 ns | 0.0499 ns | 0.0443 ns | 31.812 ns |  1.64 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_UShort_Nullable_WithValue | .NET Core 2.0 | 11.973 ns | 0.0392 ns | 0.0367 ns | 11.968 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 2.2 | 11.156 ns | 0.0243 ns | 0.0203 ns | 11.155 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 3.0 | 10.090 ns | 0.0555 ns | 0.0463 ns | 10.094 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net461 | 13.648 ns | 0.0340 ns | 0.0318 ns | 13.658 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net472 | 12.792 ns | 0.0420 ns | 0.0372 ns | 12.777 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.623 ns | 0.1588 ns | 0.1486 ns | 19.692 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.133 ns | 0.0297 ns | 0.0248 ns | 17.139 ns |  0.87 |    0.01 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.849 ns | 0.1326 ns | 0.1240 ns | 17.795 ns |  0.91 |    0.01 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net461 | 27.305 ns | 0.0589 ns | 0.0551 ns | 27.300 ns |  1.39 |    0.01 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net472 | 30.679 ns | 0.0710 ns | 0.0664 ns | 30.679 ns |  1.56 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_UShort_Nullable_NoValue | .NET Core 2.0 | 12.515 ns | 0.0658 ns | 0.0615 ns | 12.518 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 2.2 | 10.903 ns | 0.0143 ns | 0.0111 ns | 10.906 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 3.0 |  9.736 ns | 0.0961 ns | 0.0899 ns |  9.700 ns |  0.78 |    0.01 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net461 | 13.515 ns | 0.0577 ns | 0.0540 ns | 13.494 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net472 | 12.812 ns | 0.0164 ns | 0.0145 ns | 12.808 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.932 ns | 0.0188 ns | 0.0157 ns | 14.930 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.985 ns | 0.0198 ns | 0.0185 ns | 12.988 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.237 ns | 0.0338 ns | 0.0282 ns | 13.231 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net461 | 22.711 ns | 0.0271 ns | 0.0253 ns | 22.707 ns |  1.52 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net472 | 24.573 ns | 0.0757 ns | 0.0708 ns | 24.549 ns |  1.65 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_UInt | .NET Core 2.0 | 12.109 ns | 0.0662 ns | 0.0620 ns | 12.100 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 2.2 | 10.894 ns | 0.0185 ns | 0.0164 ns | 10.892 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 3.0 |  9.480 ns | 0.0372 ns | 0.0330 ns |  9.480 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                                             From_UInt |        net461 | 14.625 ns | 0.0467 ns | 0.0414 ns | 14.620 ns |  1.21 |    0.01 |      - |     - |     - |         - |
                                             From_UInt |        net472 | 13.134 ns | 0.0177 ns | 0.0148 ns | 13.133 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_UInt_AsObject | .NET Core 2.0 | 19.643 ns | 0.0308 ns | 0.0288 ns | 19.640 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 2.2 | 17.616 ns | 0.0180 ns | 0.0151 ns | 17.617 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 3.0 | 18.135 ns | 0.0486 ns | 0.0455 ns | 18.130 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net461 | 27.432 ns | 0.0428 ns | 0.0334 ns | 27.441 ns |  1.40 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net472 | 29.380 ns | 0.0663 ns | 0.0554 ns | 29.376 ns |  1.50 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_UInt_Nullable_WithValue | .NET Core 2.0 | 12.134 ns | 0.0240 ns | 0.0213 ns | 12.131 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 2.2 | 12.280 ns | 0.0871 ns | 0.0814 ns | 12.315 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 3.0 | 10.273 ns | 0.2243 ns | 0.2203 ns | 10.155 ns |  0.85 |    0.02 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net461 | 15.098 ns | 0.0379 ns | 0.0354 ns | 15.097 ns |  1.24 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net472 | 13.443 ns | 0.0283 ns | 0.0236 ns | 13.444 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.009 ns | 0.0526 ns | 0.0466 ns | 20.004 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.2 | 18.504 ns | 0.0213 ns | 0.0199 ns | 18.507 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.192 ns | 0.0697 ns | 0.0618 ns | 18.172 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net461 | 29.284 ns | 0.0401 ns | 0.0355 ns | 29.279 ns |  1.46 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net472 | 31.222 ns | 0.0569 ns | 0.0444 ns | 31.220 ns |  1.56 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_UInt_Nullable_NoValue | .NET Core 2.0 | 12.129 ns | 0.0443 ns | 0.0370 ns | 12.115 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 2.2 | 10.737 ns | 0.0438 ns | 0.0388 ns | 10.724 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 3.0 |  9.945 ns | 0.0135 ns | 0.0126 ns |  9.945 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net461 | 14.208 ns | 0.0297 ns | 0.0264 ns | 14.210 ns |  1.17 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net472 | 13.478 ns | 0.0211 ns | 0.0198 ns | 13.482 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.864 ns | 0.0437 ns | 0.0365 ns | 14.859 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.135 ns | 0.1207 ns | 0.1129 ns | 13.088 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.463 ns | 0.0352 ns | 0.0329 ns | 13.453 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net461 | 24.988 ns | 0.0688 ns | 0.0610 ns | 24.995 ns |  1.68 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net472 | 24.757 ns | 0.0826 ns | 0.0773 ns | 24.761 ns |  1.66 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_ULong | .NET Core 2.0 | 12.869 ns | 0.0529 ns | 0.0495 ns | 12.852 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 2.2 | 12.451 ns | 0.0201 ns | 0.0188 ns | 12.456 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 3.0 |  9.911 ns | 0.1606 ns | 0.1502 ns |  9.988 ns |  0.77 |    0.01 |      - |     - |     - |         - |
                                            From_ULong |        net461 | 14.042 ns | 0.0204 ns | 0.0160 ns | 14.041 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                            From_ULong |        net472 | 17.348 ns | 0.0153 ns | 0.0135 ns | 17.345 ns |  1.35 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_ULong_AsObject | .NET Core 2.0 | 19.915 ns | 0.0292 ns | 0.0273 ns | 19.922 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 2.2 | 18.165 ns | 0.1003 ns | 0.0938 ns | 18.188 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 3.0 | 17.984 ns | 0.0487 ns | 0.0432 ns | 17.980 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net461 | 30.183 ns | 0.0799 ns | 0.0708 ns | 30.153 ns |  1.52 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net472 | 31.411 ns | 0.0984 ns | 0.0872 ns | 31.395 ns |  1.58 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_ULong_Nullable_WithValue | .NET Core 2.0 | 14.552 ns | 0.0392 ns | 0.0327 ns | 14.542 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 2.2 | 13.155 ns | 0.0246 ns | 0.0231 ns | 13.161 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 3.0 | 10.643 ns | 0.0170 ns | 0.0151 ns | 10.641 ns |  0.73 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net461 | 15.899 ns | 0.0393 ns | 0.0368 ns | 15.902 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net472 | 14.620 ns | 0.0244 ns | 0.0204 ns | 14.618 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.358 ns | 0.0849 ns | 0.0752 ns | 20.370 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.2 | 18.044 ns | 0.1906 ns | 0.1783 ns | 18.134 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 3.0 | 20.900 ns | 0.1851 ns | 0.1731 ns | 20.885 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net461 | 27.434 ns | 0.0885 ns | 0.0828 ns | 27.409 ns |  1.35 |    0.01 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net472 | 30.651 ns | 0.0404 ns | 0.0358 ns | 30.657 ns |  1.51 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_ULong_Nullable_NoValue | .NET Core 2.0 | 12.376 ns | 0.0151 ns | 0.0141 ns | 12.374 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 2.2 | 12.102 ns | 0.0205 ns | 0.0192 ns | 12.105 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 3.0 |  9.788 ns | 0.0453 ns | 0.0424 ns |  9.803 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net461 | 14.214 ns | 0.0222 ns | 0.0196 ns | 14.211 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net472 | 13.418 ns | 0.0152 ns | 0.0127 ns | 13.420 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.699 ns | 0.0235 ns | 0.0209 ns | 15.696 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.985 ns | 0.0103 ns | 0.0091 ns | 12.986 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.219 ns | 0.0133 ns | 0.0111 ns | 13.216 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net461 | 22.095 ns | 0.0688 ns | 0.0644 ns | 22.098 ns |  1.41 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net472 | 24.683 ns | 0.0441 ns | 0.0412 ns | 24.681 ns |  1.57 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                       From_NullObject | .NET Core 2.0 | 15.156 ns | 0.0195 ns | 0.0173 ns | 15.155 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 2.2 | 13.924 ns | 0.0157 ns | 0.0147 ns | 13.927 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 3.0 | 13.958 ns | 0.2001 ns | 0.1872 ns | 13.943 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                                       From_NullObject |        net461 | 22.688 ns | 0.0266 ns | 0.0249 ns | 22.689 ns |  1.50 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject |        net472 | 26.001 ns | 0.0450 ns | 0.0421 ns | 25.991 ns |  1.72 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_DBNull | .NET Core 2.0 | 13.093 ns | 0.0194 ns | 0.0172 ns | 13.092 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 2.2 | 11.171 ns | 0.0329 ns | 0.0308 ns | 11.177 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 3.0 | 12.828 ns | 0.0239 ns | 0.0224 ns | 12.831 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull |        net461 | 13.313 ns | 0.0707 ns | 0.0590 ns | 13.305 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull |        net472 | 15.521 ns | 0.0378 ns | 0.0353 ns | 15.516 ns |  1.19 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_DBNull_AsObject | .NET Core 2.0 | 14.907 ns | 0.0157 ns | 0.0147 ns | 14.909 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 2.2 | 12.982 ns | 0.0179 ns | 0.0159 ns | 12.981 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 3.0 | 13.241 ns | 0.0505 ns | 0.0472 ns | 13.229 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net461 | 22.729 ns | 0.0395 ns | 0.0369 ns | 22.728 ns |  1.52 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net472 | 25.854 ns | 0.1648 ns | 0.1541 ns | 25.902 ns |  1.73 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                 From_ConvertibleClass | .NET Core 2.0 | 18.814 ns | 0.0270 ns | 0.0239 ns | 18.809 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 2.2 | 15.389 ns | 0.0784 ns | 0.0695 ns | 15.410 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 3.0 | 14.771 ns | 0.2161 ns | 0.1804 ns | 14.709 ns |  0.79 |    0.01 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net461 | 27.663 ns | 0.0966 ns | 0.0904 ns | 27.621 ns |  1.47 |    0.01 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net472 | 26.015 ns | 0.0593 ns | 0.0526 ns | 26.009 ns |  1.38 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_ConvertibleClass_AsObject | .NET Core 2.0 | 19.167 ns | 0.0544 ns | 0.0509 ns | 19.153 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 2.2 | 16.931 ns | 0.0162 ns | 0.0144 ns | 16.930 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 3.0 | 18.289 ns | 0.0521 ns | 0.0462 ns | 18.285 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net461 | 26.251 ns | 0.0432 ns | 0.0404 ns | 26.258 ns |  1.37 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net472 | 28.036 ns | 0.0610 ns | 0.0571 ns | 28.024 ns |  1.46 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_ConvertibleClass_NoValue | .NET Core 2.0 | 14.897 ns | 0.0273 ns | 0.0256 ns | 14.898 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 2.2 | 13.549 ns | 0.0203 ns | 0.0190 ns | 13.550 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 3.0 | 13.529 ns | 0.0493 ns | 0.0437 ns | 13.523 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net461 | 22.985 ns | 0.1666 ns | 0.1558 ns | 23.078 ns |  1.54 |    0.01 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net472 | 23.033 ns | 0.1785 ns | 0.1670 ns | 23.119 ns |  1.55 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.0 | 15.017 ns | 0.0273 ns | 0.0213 ns | 15.007 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.2 | 13.124 ns | 0.1508 ns | 0.1411 ns | 13.225 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 3.0 | 13.268 ns | 0.0869 ns | 0.0770 ns | 13.235 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net461 | 22.787 ns | 0.0235 ns | 0.0220 ns | 22.785 ns |  1.52 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net472 | 26.365 ns | 0.0372 ns | 0.0330 ns | 26.349 ns |  1.76 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                              From_NonConvertibleClass | .NET Core 2.0 | 13.923 ns | 0.0222 ns | 0.0207 ns | 13.922 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 2.2 | 12.758 ns | 0.0218 ns | 0.0204 ns | 12.760 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 3.0 | 12.507 ns | 0.0254 ns | 0.0238 ns | 12.502 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net461 | 14.535 ns | 0.0227 ns | 0.0201 ns | 14.537 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net472 | 14.386 ns | 0.0182 ns | 0.0161 ns | 14.389 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                     From_NonConvertibleClass_AsObject | .NET Core 2.0 | 16.644 ns | 0.0198 ns | 0.0165 ns | 16.643 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 2.2 | 14.810 ns | 0.0177 ns | 0.0148 ns | 14.814 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 3.0 | 15.130 ns | 0.0293 ns | 0.0274 ns | 15.129 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net461 | 24.496 ns | 0.1540 ns | 0.1365 ns | 24.542 ns |  1.47 |    0.01 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net472 | 28.437 ns | 0.2344 ns | 0.2193 ns | 28.531 ns |  1.71 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                      From_NonConvertibleClass_NoValue | .NET Core 2.0 | 13.922 ns | 0.0411 ns | 0.0343 ns | 13.912 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 2.2 | 12.921 ns | 0.1077 ns | 0.0899 ns | 12.964 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 3.0 | 12.530 ns | 0.0297 ns | 0.0278 ns | 12.520 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net461 | 14.465 ns | 0.0267 ns | 0.0250 ns | 14.462 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net472 | 14.380 ns | 0.0150 ns | 0.0133 ns | 14.378 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.0 | 15.033 ns | 0.0369 ns | 0.0328 ns | 15.031 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.2 | 12.975 ns | 0.0256 ns | 0.0240 ns | 12.972 ns |  0.86 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 3.0 | 13.224 ns | 0.0158 ns | 0.0132 ns | 13.227 ns |  0.88 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net461 | 22.772 ns | 0.0346 ns | 0.0307 ns | 22.775 ns |  1.51 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net472 | 25.535 ns | 0.0965 ns | 0.0902 ns | 25.514 ns |  1.70 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                From_ConvertibleStruct | .NET Core 2.0 | 20.972 ns | 0.0426 ns | 0.0377 ns | 20.973 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 2.2 | 16.218 ns | 0.0340 ns | 0.0318 ns | 16.220 ns |  0.77 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 3.0 | 13.804 ns | 0.0614 ns | 0.0544 ns | 13.816 ns |  0.66 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net461 | 20.950 ns | 0.1318 ns | 0.1233 ns | 20.998 ns |  1.00 |    0.01 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net472 | 19.253 ns | 0.0191 ns | 0.0159 ns | 19.257 ns |  0.92 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                       From_ConvertibleStruct_AsObject | .NET Core 2.0 | 19.222 ns | 0.1994 ns | 0.1865 ns | 19.343 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 2.2 | 17.402 ns | 0.1483 ns | 0.1387 ns | 17.467 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 3.0 | 18.158 ns | 0.1185 ns | 0.1108 ns | 18.157 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net461 | 28.640 ns | 0.0649 ns | 0.0607 ns | 28.641 ns |  1.49 |    0.01 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net472 | 29.766 ns | 0.1785 ns | 0.1670 ns | 29.810 ns |  1.55 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.0 | 20.542 ns | 0.0476 ns | 0.0446 ns | 20.530 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.2 | 16.423 ns | 0.0408 ns | 0.0381 ns | 16.422 ns |  0.80 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 3.0 | 14.347 ns | 0.0762 ns | 0.0713 ns | 14.325 ns |  0.70 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net461 | 27.398 ns | 0.1069 ns | 0.0948 ns | 27.407 ns |  1.33 |    0.01 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net472 | 27.391 ns | 0.0413 ns | 0.0387 ns | 27.384 ns |  1.33 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.063 ns | 0.1125 ns | 0.1052 ns | 19.014 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.146 ns | 0.0138 ns | 0.0129 ns | 17.146 ns |  0.90 |    0.01 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.705 ns | 0.1547 ns | 0.1292 ns | 17.650 ns |  0.93 |    0.01 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net461 | 27.119 ns | 0.0654 ns | 0.0579 ns | 27.116 ns |  1.42 |    0.01 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net472 | 30.312 ns | 0.0561 ns | 0.0525 ns | 30.304 ns |  1.59 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.0 | 14.048 ns | 0.1189 ns | 0.1112 ns | 13.971 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.2 | 12.260 ns | 0.0098 ns | 0.0082 ns | 12.261 ns |  0.87 |    0.01 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 3.0 | 10.077 ns | 0.0840 ns | 0.0786 ns | 10.120 ns |  0.72 |    0.01 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net461 | 23.076 ns | 0.2144 ns | 0.2006 ns | 23.166 ns |  1.64 |    0.02 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net472 | 18.990 ns | 0.0141 ns | 0.0132 ns | 18.988 ns |  1.35 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.928 ns | 0.0312 ns | 0.0292 ns | 14.932 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.967 ns | 0.0191 ns | 0.0178 ns | 12.968 ns |  0.87 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.238 ns | 0.0454 ns | 0.0425 ns | 13.227 ns |  0.89 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net461 | 22.744 ns | 0.0322 ns | 0.0268 ns | 22.748 ns |  1.52 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net472 | 24.390 ns | 0.0702 ns | 0.0586 ns | 24.416 ns |  1.63 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_NonConvertibleStruct | .NET Core 2.0 | 13.226 ns | 0.0393 ns | 0.0368 ns | 13.209 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 2.2 | 11.748 ns | 0.0220 ns | 0.0195 ns | 11.745 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 3.0 |  9.731 ns | 0.0226 ns | 0.0200 ns |  9.729 ns |  0.74 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net461 | 13.010 ns | 0.0106 ns | 0.0099 ns | 13.011 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net472 | 12.296 ns | 0.0150 ns | 0.0125 ns | 12.296 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.0 | 16.840 ns | 0.1449 ns | 0.1356 ns | 16.921 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.2 | 14.984 ns | 0.0334 ns | 0.0313 ns | 14.981 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 3.0 | 16.637 ns | 0.1337 ns | 0.1250 ns | 16.712 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net461 | 24.844 ns | 0.1391 ns | 0.1302 ns | 24.900 ns |  1.48 |    0.01 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net472 | 27.209 ns | 0.0850 ns | 0.0710 ns | 27.186 ns |  1.62 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.0 | 13.207 ns | 0.0211 ns | 0.0187 ns | 13.207 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.2 | 11.469 ns | 0.0170 ns | 0.0151 ns | 11.472 ns |  0.87 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 3.0 |  9.525 ns | 0.0170 ns | 0.0133 ns |  9.522 ns |  0.72 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net461 | 13.760 ns | 0.0264 ns | 0.0234 ns | 13.758 ns |  1.04 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net472 | 12.292 ns | 0.0267 ns | 0.0237 ns | 12.288 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 16.634 ns | 0.0311 ns | 0.0260 ns | 16.633 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 14.827 ns | 0.0216 ns | 0.0202 ns | 14.821 ns |  0.89 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.304 ns | 0.0644 ns | 0.0603 ns | 15.319 ns |  0.92 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net461 | 26.040 ns | 0.0419 ns | 0.0371 ns | 26.042 ns |  1.57 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net472 | 27.975 ns | 0.0625 ns | 0.0554 ns | 27.964 ns |  1.68 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.0 | 13.390 ns | 0.1050 ns | 0.0982 ns | 13.432 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.2 | 11.588 ns | 0.0276 ns | 0.0231 ns | 11.595 ns |  0.87 |    0.01 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 3.0 |  9.526 ns | 0.0166 ns | 0.0156 ns |  9.521 ns |  0.71 |    0.01 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net461 | 13.196 ns | 0.0937 ns | 0.0877 ns | 13.228 ns |  0.99 |    0.01 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net472 | 12.288 ns | 0.0517 ns | 0.0458 ns | 12.277 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 16.728 ns | 0.0157 ns | 0.0139 ns | 16.731 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.174 ns | 0.0148 ns | 0.0131 ns | 13.173 ns |  0.79 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.713 ns | 0.0172 ns | 0.0152 ns | 14.714 ns |  0.88 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net461 | 25.359 ns | 0.0393 ns | 0.0367 ns | 25.356 ns |  1.52 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net472 | 25.861 ns | 0.1596 ns | 0.1415 ns | 25.890 ns |  1.55 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Enum | .NET Core 2.0 | 14.034 ns | 0.0426 ns | 0.0399 ns | 14.020 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 2.2 | 12.078 ns | 0.0442 ns | 0.0392 ns | 12.071 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 3.0 | 10.029 ns | 0.0096 ns | 0.0085 ns | 10.026 ns |  0.71 |    0.00 |      - |     - |     - |         - |
                                             From_Enum |        net461 | 14.702 ns | 0.1701 ns | 0.1591 ns | 14.616 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                                             From_Enum |        net472 | 14.009 ns | 0.0200 ns | 0.0177 ns | 14.014 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Enum_AsObject | .NET Core 2.0 | 46.664 ns | 0.1054 ns | 0.0934 ns | 46.644 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject | .NET Core 2.2 | 47.701 ns | 0.1219 ns | 0.1140 ns | 47.711 ns |  1.02 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject | .NET Core 3.0 | 41.775 ns | 0.1641 ns | 0.1535 ns | 41.739 ns |  0.90 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject |        net461 | 62.665 ns | 0.1591 ns | 0.1488 ns | 62.643 ns |  1.34 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject |        net472 | 61.334 ns | 0.0931 ns | 0.0778 ns | 61.315 ns |  1.31 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Enum_Nullable_WithValue | .NET Core 2.0 | 14.178 ns | 0.0370 ns | 0.0346 ns | 14.168 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 2.2 | 12.968 ns | 0.0220 ns | 0.0195 ns | 12.970 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 3.0 | 10.348 ns | 0.0123 ns | 0.0115 ns | 10.352 ns |  0.73 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net461 | 15.604 ns | 0.0246 ns | 0.0230 ns | 15.598 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net472 | 14.843 ns | 0.0885 ns | 0.0739 ns | 14.856 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.0 | 46.193 ns | 0.2474 ns | 0.2314 ns | 46.107 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.2 | 52.054 ns | 0.2983 ns | 0.2790 ns | 51.990 ns |  1.13 |    0.01 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 3.0 | 43.120 ns | 0.8297 ns | 0.8520 ns | 43.525 ns |  0.93 |    0.02 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject |        net461 | 52.381 ns | 0.3324 ns | 0.2776 ns | 52.476 ns |  1.13 |    0.01 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject |        net472 | 53.680 ns | 0.0893 ns | 0.0791 ns | 53.670 ns |  1.16 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Enum_Nullable_NoValue | .NET Core 2.0 | 13.206 ns | 0.0238 ns | 0.0223 ns | 13.210 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 2.2 | 12.389 ns | 0.0261 ns | 0.0244 ns | 12.389 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 3.0 |  9.836 ns | 0.0405 ns | 0.0379 ns |  9.840 ns |  0.74 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net461 | 13.941 ns | 0.0845 ns | 0.0790 ns | 13.909 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net472 | 13.519 ns | 0.0193 ns | 0.0161 ns | 13.520 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.502 ns | 0.0252 ns | 0.0223 ns | 15.503 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.970 ns | 0.0118 ns | 0.0099 ns | 12.973 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.673 ns | 0.1606 ns | 0.1503 ns | 14.754 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net461 | 22.734 ns | 0.0361 ns | 0.0338 ns | 22.735 ns |  1.47 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net472 | 27.853 ns | 0.2564 ns | 0.2398 ns | 27.976 ns |  1.80 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                      From_ParentClass | .NET Core 2.0 | 13.920 ns | 0.0454 ns | 0.0403 ns | 13.907 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 2.2 | 12.971 ns | 0.0688 ns | 0.0610 ns | 12.987 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 3.0 | 12.578 ns | 0.0374 ns | 0.0332 ns | 12.570 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass |        net461 | 15.062 ns | 0.0291 ns | 0.0272 ns | 15.067 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass |        net472 | 14.367 ns | 0.0166 ns | 0.0147 ns | 14.368 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_ParentClass_AsObject | .NET Core 2.0 | 17.228 ns | 0.0362 ns | 0.0321 ns | 17.222 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 2.2 | 15.554 ns | 0.0307 ns | 0.0287 ns | 15.552 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 3.0 | 15.434 ns | 0.0418 ns | 0.0391 ns | 15.437 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net461 | 24.766 ns | 0.0352 ns | 0.0312 ns | 24.759 ns |  1.44 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net472 | 26.315 ns | 0.0641 ns | 0.0568 ns | 26.318 ns |  1.53 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                              From_ParentClass_NoValue | .NET Core 2.0 | 13.890 ns | 0.0210 ns | 0.0186 ns | 13.887 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 2.2 | 12.740 ns | 0.0106 ns | 0.0089 ns | 12.737 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 3.0 | 12.697 ns | 0.0101 ns | 0.0095 ns | 12.697 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net461 | 15.065 ns | 0.0285 ns | 0.0253 ns | 15.069 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net472 | 14.600 ns | 0.0667 ns | 0.0592 ns | 14.613 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.0 | 14.856 ns | 0.0137 ns | 0.0114 ns | 14.859 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.2 | 13.160 ns | 0.0869 ns | 0.0813 ns | 13.198 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 3.0 | 15.099 ns | 0.0102 ns | 0.0086 ns | 15.101 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net461 | 22.698 ns | 0.0250 ns | 0.0221 ns | 22.696 ns |  1.53 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net472 | 26.404 ns | 0.0516 ns | 0.0483 ns | 26.396 ns |  1.78 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_ParentStruct | .NET Core 2.0 | 42.476 ns | 0.0871 ns | 0.0772 ns | 42.456 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 2.2 | 42.249 ns | 0.0780 ns | 0.0730 ns | 42.260 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 3.0 | 40.329 ns | 0.0904 ns | 0.0845 ns | 40.355 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct |        net461 | 42.132 ns | 0.1221 ns | 0.1142 ns | 42.118 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct |        net472 | 41.053 ns | 0.0658 ns | 0.0583 ns | 41.038 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_ParentStruct_AsObject | .NET Core 2.0 | 17.343 ns | 0.0595 ns | 0.0465 ns | 17.322 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 2.2 | 16.156 ns | 0.0200 ns | 0.0187 ns | 16.157 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 3.0 | 15.832 ns | 0.0907 ns | 0.0849 ns | 15.807 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net461 | 27.595 ns | 0.0440 ns | 0.0367 ns | 27.592 ns |  1.59 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net472 | 28.194 ns | 0.0476 ns | 0.0422 ns | 28.187 ns |  1.63 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.0 | 42.616 ns | 0.0788 ns | 0.0737 ns | 42.625 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.2 | 41.107 ns | 0.1773 ns | 0.1572 ns | 41.141 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 3.0 | 38.200 ns | 0.4967 ns | 0.4646 ns | 38.378 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue |        net461 | 43.087 ns | 0.1801 ns | 0.1685 ns | 43.121 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue |        net472 | 44.246 ns | 0.4309 ns | 0.4031 ns | 44.463 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 17.557 ns | 0.0197 ns | 0.0175 ns | 17.557 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.326 ns | 0.0298 ns | 0.0264 ns | 15.324 ns |  0.87 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 16.763 ns | 0.0405 ns | 0.0359 ns | 16.763 ns |  0.95 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net461 | 28.299 ns | 0.0373 ns | 0.0311 ns | 28.294 ns |  1.61 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net472 | 27.363 ns | 0.0379 ns | 0.0336 ns | 27.360 ns |  1.56 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.0 | 43.249 ns | 0.2896 ns | 0.2709 ns | 43.349 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.2 | 40.982 ns | 0.0544 ns | 0.0509 ns | 40.987 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 3.0 | 38.498 ns | 0.7001 ns | 0.6549 ns | 38.759 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net461 | 45.099 ns | 0.4389 ns | 0.4105 ns | 45.401 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net472 | 43.768 ns | 0.1365 ns | 0.1277 ns | 43.740 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.878 ns | 0.0384 ns | 0.0341 ns | 14.888 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.203 ns | 0.0449 ns | 0.0420 ns | 13.214 ns |  0.89 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.827 ns | 0.0955 ns | 0.0893 ns | 13.816 ns |  0.93 |    0.01 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net461 | 22.128 ns | 0.0338 ns | 0.0300 ns | 22.130 ns |  1.49 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net472 | 24.941 ns | 0.1961 ns | 0.1834 ns | 25.013 ns |  1.68 |    0.01 |      - |     - |     - |         - |

Benchmarks with issues:
  ConvertTo_CharNullable.From_Bool_AsObject: Job-LRKCAO(Toolchain=.NET Core 2.0)
  ConvertTo_CharNullable.From_Bool_AsObject: Job-VAJWLV(Toolchain=.NET Core 2.2)
  ConvertTo_CharNullable.From_Bool_AsObject: Job-TJIRAH(Toolchain=.NET Core 3.0)
  ConvertTo_CharNullable.From_Bool_AsObject: Job-HBFVIR(Toolchain=net461)
  ConvertTo_CharNullable.From_Bool_AsObject: Job-YRWWQX(Toolchain=net472)
  ConvertTo_CharNullable.From_Bool_Nullable_WithValue_AsObject: Job-LRKCAO(Toolchain=.NET Core 2.0)
  ConvertTo_CharNullable.From_Bool_Nullable_WithValue_AsObject: Job-VAJWLV(Toolchain=.NET Core 2.2)
  ConvertTo_CharNullable.From_Bool_Nullable_WithValue_AsObject: Job-TJIRAH(Toolchain=.NET Core 3.0)
  ConvertTo_CharNullable.From_Bool_Nullable_WithValue_AsObject: Job-HBFVIR(Toolchain=net461)
  ConvertTo_CharNullable.From_Bool_Nullable_WithValue_AsObject: Job-YRWWQX(Toolchain=net472)
  ConvertTo_CharNullable.From_DateTime_AsObject: Job-LRKCAO(Toolchain=.NET Core 2.0)
  ConvertTo_CharNullable.From_DateTime_AsObject: Job-VAJWLV(Toolchain=.NET Core 2.2)
  ConvertTo_CharNullable.From_DateTime_AsObject: Job-TJIRAH(Toolchain=.NET Core 3.0)
  ConvertTo_CharNullable.From_DateTime_AsObject: Job-HBFVIR(Toolchain=net461)
  ConvertTo_CharNullable.From_DateTime_AsObject: Job-YRWWQX(Toolchain=net472)
  ConvertTo_CharNullable.From_DateTime_Nullable_WithValue_AsObject: Job-LRKCAO(Toolchain=.NET Core 2.0)
  ConvertTo_CharNullable.From_DateTime_Nullable_WithValue_AsObject: Job-VAJWLV(Toolchain=.NET Core 2.2)
  ConvertTo_CharNullable.From_DateTime_Nullable_WithValue_AsObject: Job-TJIRAH(Toolchain=.NET Core 3.0)
  ConvertTo_CharNullable.From_DateTime_Nullable_WithValue_AsObject: Job-HBFVIR(Toolchain=net461)
  ConvertTo_CharNullable.From_DateTime_Nullable_WithValue_AsObject: Job-YRWWQX(Toolchain=net472)
  ConvertTo_CharNullable.From_Decimal_AsObject: Job-LRKCAO(Toolchain=.NET Core 2.0)
  ConvertTo_CharNullable.From_Decimal_AsObject: Job-VAJWLV(Toolchain=.NET Core 2.2)
  ConvertTo_CharNullable.From_Decimal_AsObject: Job-TJIRAH(Toolchain=.NET Core 3.0)
  ConvertTo_CharNullable.From_Decimal_AsObject: Job-HBFVIR(Toolchain=net461)
  ConvertTo_CharNullable.From_Decimal_AsObject: Job-YRWWQX(Toolchain=net472)
  ConvertTo_CharNullable.From_Decimal_Nullable_WithValue_AsObject: Job-LRKCAO(Toolchain=.NET Core 2.0)
  ConvertTo_CharNullable.From_Decimal_Nullable_WithValue_AsObject: Job-VAJWLV(Toolchain=.NET Core 2.2)
  ConvertTo_CharNullable.From_Decimal_Nullable_WithValue_AsObject: Job-TJIRAH(Toolchain=.NET Core 3.0)
  ConvertTo_CharNullable.From_Decimal_Nullable_WithValue_AsObject: Job-HBFVIR(Toolchain=net461)
  ConvertTo_CharNullable.From_Decimal_Nullable_WithValue_AsObject: Job-YRWWQX(Toolchain=net472)
  ConvertTo_CharNullable.From_Double_AsObject: Job-LRKCAO(Toolchain=.NET Core 2.0)
  ConvertTo_CharNullable.From_Double_AsObject: Job-VAJWLV(Toolchain=.NET Core 2.2)
  ConvertTo_CharNullable.From_Double_AsObject: Job-TJIRAH(Toolchain=.NET Core 3.0)
  ConvertTo_CharNullable.From_Double_AsObject: Job-HBFVIR(Toolchain=net461)
  ConvertTo_CharNullable.From_Double_AsObject: Job-YRWWQX(Toolchain=net472)
  ConvertTo_CharNullable.From_Double_Nullable_WithValue_AsObject: Job-LRKCAO(Toolchain=.NET Core 2.0)
  ConvertTo_CharNullable.From_Double_Nullable_WithValue_AsObject: Job-VAJWLV(Toolchain=.NET Core 2.2)
  ConvertTo_CharNullable.From_Double_Nullable_WithValue_AsObject: Job-TJIRAH(Toolchain=.NET Core 3.0)
  ConvertTo_CharNullable.From_Double_Nullable_WithValue_AsObject: Job-HBFVIR(Toolchain=net461)
  ConvertTo_CharNullable.From_Double_Nullable_WithValue_AsObject: Job-YRWWQX(Toolchain=net472)
  ConvertTo_CharNullable.From_Float_AsObject: Job-LRKCAO(Toolchain=.NET Core 2.0)
  ConvertTo_CharNullable.From_Float_AsObject: Job-VAJWLV(Toolchain=.NET Core 2.2)
  ConvertTo_CharNullable.From_Float_AsObject: Job-TJIRAH(Toolchain=.NET Core 3.0)
  ConvertTo_CharNullable.From_Float_AsObject: Job-HBFVIR(Toolchain=net461)
  ConvertTo_CharNullable.From_Float_AsObject: Job-YRWWQX(Toolchain=net472)
  ConvertTo_CharNullable.From_Float_Nullable_WithValue_AsObject: Job-LRKCAO(Toolchain=.NET Core 2.0)
  ConvertTo_CharNullable.From_Float_Nullable_WithValue_AsObject: Job-VAJWLV(Toolchain=.NET Core 2.2)
  ConvertTo_CharNullable.From_Float_Nullable_WithValue_AsObject: Job-TJIRAH(Toolchain=.NET Core 3.0)
  ConvertTo_CharNullable.From_Float_Nullable_WithValue_AsObject: Job-HBFVIR(Toolchain=net461)
  ConvertTo_CharNullable.From_Float_Nullable_WithValue_AsObject: Job-YRWWQX(Toolchain=net472)
  ConvertTo_CharNullable.From_String_Empty_AsObject: Job-LRKCAO(Toolchain=.NET Core 2.0)
  ConvertTo_CharNullable.From_String_Empty_AsObject: Job-VAJWLV(Toolchain=.NET Core 2.2)
  ConvertTo_CharNullable.From_String_Empty_AsObject: Job-TJIRAH(Toolchain=.NET Core 3.0)
  ConvertTo_CharNullable.From_String_Empty_AsObject: Job-HBFVIR(Toolchain=net461)
  ConvertTo_CharNullable.From_String_Empty_AsObject: Job-YRWWQX(Toolchain=net472)
