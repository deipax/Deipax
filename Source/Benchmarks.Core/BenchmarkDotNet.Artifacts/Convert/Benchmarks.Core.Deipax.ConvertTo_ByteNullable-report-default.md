
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
                                             From_Bool | .NET Core 2.0 | 11.945 ns | 0.0270 ns | 0.0252 ns | 11.938 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 2.2 | 11.700 ns | 0.0985 ns | 0.0921 ns | 11.662 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 3.0 |  9.490 ns | 0.0355 ns | 0.0333 ns |  9.488 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                                             From_Bool |        net461 | 13.734 ns | 0.0423 ns | 0.0395 ns | 13.729 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                                             From_Bool |        net472 | 12.621 ns | 0.0733 ns | 0.0685 ns | 12.590 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Bool_AsObject | .NET Core 2.0 | 27.616 ns | 0.2005 ns | 0.1875 ns | 27.605 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 2.2 | 17.424 ns | 0.0475 ns | 0.0444 ns | 17.421 ns |  0.63 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 3.0 | 18.175 ns | 0.0311 ns | 0.0259 ns | 18.178 ns |  0.66 |    0.01 |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net461 | 27.119 ns | 0.0330 ns | 0.0276 ns | 27.120 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net472 | 30.779 ns | 0.3283 ns | 0.3071 ns | 30.928 ns |  1.11 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Bool_Nullable_WithValue | .NET Core 2.0 | 12.135 ns | 0.0177 ns | 0.0165 ns | 12.135 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 2.2 | 11.792 ns | 0.0324 ns | 0.0253 ns | 11.789 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 3.0 | 10.182 ns | 0.0135 ns | 0.0105 ns | 10.185 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net461 | 13.498 ns | 0.0535 ns | 0.0447 ns | 13.487 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net472 | 12.819 ns | 0.0172 ns | 0.0161 ns | 12.822 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.444 ns | 0.0596 ns | 0.0558 ns | 19.428 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.414 ns | 0.0432 ns | 0.0383 ns | 17.427 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.048 ns | 0.0550 ns | 0.0515 ns | 18.035 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net461 | 27.084 ns | 0.0560 ns | 0.0496 ns | 27.084 ns |  1.39 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net472 | 29.623 ns | 0.0749 ns | 0.0700 ns | 29.619 ns |  1.52 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Bool_Nullable_NoValue | .NET Core 2.0 | 12.069 ns | 0.0852 ns | 0.0797 ns | 12.092 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 2.2 | 10.841 ns | 0.0159 ns | 0.0133 ns | 10.840 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 3.0 | 10.812 ns | 0.2390 ns | 0.3860 ns | 11.029 ns |  0.87 |    0.04 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net461 | 14.123 ns | 0.0259 ns | 0.0230 ns | 14.129 ns |  1.17 |    0.01 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net472 | 13.741 ns | 0.0680 ns | 0.0568 ns | 13.753 ns |  1.14 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.0 | 16.371 ns | 0.0450 ns | 0.0399 ns | 16.372 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.002 ns | 0.0146 ns | 0.0129 ns | 13.000 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.485 ns | 0.0623 ns | 0.0553 ns | 13.461 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net461 | 22.811 ns | 0.0630 ns | 0.0589 ns | 22.815 ns |  1.39 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net472 | 27.532 ns | 0.0449 ns | 0.0420 ns | 27.541 ns |  1.68 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Byte | .NET Core 2.0 | 13.000 ns | 0.0213 ns | 0.0189 ns | 13.001 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 2.2 | 10.446 ns | 0.0162 ns | 0.0151 ns | 10.443 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 3.0 |  9.723 ns | 0.0244 ns | 0.0228 ns |  9.723 ns |  0.75 |    0.00 |      - |     - |     - |         - |
                                             From_Byte |        net461 | 12.303 ns | 0.0138 ns | 0.0129 ns | 12.298 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                             From_Byte |        net472 | 12.524 ns | 0.0993 ns | 0.0929 ns | 12.557 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Byte_AsObject | .NET Core 2.0 | 23.766 ns | 0.0276 ns | 0.0244 ns | 23.773 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 2.2 | 25.572 ns | 0.2156 ns | 0.2016 ns | 25.574 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 3.0 | 28.427 ns | 0.5860 ns | 0.8215 ns | 27.834 ns |  1.22 |    0.04 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net461 | 37.528 ns | 0.2794 ns | 0.2613 ns | 37.657 ns |  1.58 |    0.01 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net472 | 38.378 ns | 0.1073 ns | 0.1003 ns | 38.388 ns |  1.62 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Byte_Nullable_WithValue | .NET Core 2.0 | 11.469 ns | 0.0708 ns | 0.0663 ns | 11.511 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 2.2 | 10.282 ns | 0.0286 ns | 0.0239 ns | 10.278 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 3.0 |  6.702 ns | 0.1233 ns | 0.1154 ns |  6.776 ns |  0.58 |    0.01 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net461 | 11.829 ns | 0.0239 ns | 0.0223 ns | 11.834 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net472 | 11.864 ns | 0.0145 ns | 0.0129 ns | 11.862 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.0 | 25.655 ns | 0.0444 ns | 0.0416 ns | 25.651 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.2 | 25.550 ns | 0.0528 ns | 0.0494 ns | 25.565 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 3.0 | 28.514 ns | 0.0601 ns | 0.0562 ns | 28.491 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net461 | 35.384 ns | 0.0598 ns | 0.0559 ns | 35.374 ns |  1.38 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net472 | 37.207 ns | 0.0670 ns | 0.0627 ns | 37.213 ns |  1.45 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Byte_Nullable_NoValue | .NET Core 2.0 | 11.375 ns | 0.0256 ns | 0.0227 ns | 11.377 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 2.2 | 10.293 ns | 0.0521 ns | 0.0487 ns | 10.271 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 3.0 |  6.597 ns | 0.0127 ns | 0.0099 ns |  6.594 ns |  0.58 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net461 | 12.061 ns | 0.0727 ns | 0.0607 ns | 12.072 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net472 | 12.000 ns | 0.1195 ns | 0.1118 ns | 12.067 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.0 | 16.345 ns | 0.0352 ns | 0.0330 ns | 16.349 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.162 ns | 0.1253 ns | 0.1172 ns | 13.228 ns |  0.81 |    0.01 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.640 ns | 0.1961 ns | 0.1834 ns | 13.558 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net461 | 22.811 ns | 0.0472 ns | 0.0442 ns | 22.811 ns |  1.40 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net472 | 25.502 ns | 0.0418 ns | 0.0391 ns | 25.508 ns |  1.56 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Char | .NET Core 2.0 | 11.948 ns | 0.0440 ns | 0.0412 ns | 11.936 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Char | .NET Core 2.2 | 11.282 ns | 0.0337 ns | 0.0315 ns | 11.267 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                             From_Char | .NET Core 3.0 |  9.770 ns | 0.1007 ns | 0.0942 ns |  9.723 ns |  0.82 |    0.01 |      - |     - |     - |         - |
                                             From_Char |        net461 | 14.123 ns | 0.0343 ns | 0.0304 ns | 14.116 ns |  1.18 |    0.00 |      - |     - |     - |         - |
                                             From_Char |        net472 | 14.085 ns | 0.0329 ns | 0.0308 ns | 14.088 ns |  1.18 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Char_AsObject | .NET Core 2.0 | 20.080 ns | 0.0267 ns | 0.0250 ns | 20.080 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 2.2 | 18.481 ns | 0.0318 ns | 0.0282 ns | 18.477 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 3.0 | 18.461 ns | 0.2564 ns | 0.2399 ns | 18.295 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                                    From_Char_AsObject |        net461 | 27.532 ns | 0.0489 ns | 0.0408 ns | 27.536 ns |  1.37 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject |        net472 | 31.044 ns | 0.1858 ns | 0.1647 ns | 31.031 ns |  1.55 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Char_Nullable_WithValue | .NET Core 2.0 | 12.174 ns | 0.0140 ns | 0.0110 ns | 12.171 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 2.2 | 11.226 ns | 0.0207 ns | 0.0193 ns | 11.224 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 3.0 | 10.042 ns | 0.0279 ns | 0.0248 ns | 10.041 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net461 | 14.508 ns | 0.0262 ns | 0.0232 ns | 14.513 ns |  1.19 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net472 | 13.527 ns | 0.0139 ns | 0.0116 ns | 13.527 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.265 ns | 0.0428 ns | 0.0400 ns | 20.259 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.2 | 18.114 ns | 0.0125 ns | 0.0111 ns | 18.117 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 3.0 | 19.367 ns | 0.0824 ns | 0.0771 ns | 19.388 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net461 | 27.851 ns | 0.2787 ns | 0.2607 ns | 27.978 ns |  1.37 |    0.01 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net472 | 29.079 ns | 0.1136 ns | 0.1063 ns | 29.051 ns |  1.43 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Char_Nullable_NoValue | .NET Core 2.0 | 12.485 ns | 0.0140 ns | 0.0124 ns | 12.483 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 2.2 | 11.057 ns | 0.0932 ns | 0.0826 ns | 11.055 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 3.0 |  9.875 ns | 0.0287 ns | 0.0269 ns |  9.871 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net461 | 14.379 ns | 0.0330 ns | 0.0308 ns | 14.363 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net472 | 13.690 ns | 0.1461 ns | 0.1367 ns | 13.774 ns |  1.10 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.143 ns | 0.0905 ns | 0.0846 ns | 15.190 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.011 ns | 0.0219 ns | 0.0183 ns | 13.007 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.073 ns | 0.2922 ns | 0.2440 ns | 14.199 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net461 | 23.084 ns | 0.2095 ns | 0.1960 ns | 23.209 ns |  1.52 |    0.01 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net472 | 25.620 ns | 0.0585 ns | 0.0548 ns | 25.600 ns |  1.69 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                         From_DateTime | .NET Core 2.0 | 12.314 ns | 0.0121 ns | 0.0101 ns | 12.317 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 2.2 | 12.092 ns | 0.1218 ns | 0.1140 ns | 12.007 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 3.0 |  9.779 ns | 0.0143 ns | 0.0127 ns |  9.777 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime |        net461 | 13.845 ns | 0.0332 ns | 0.0310 ns | 13.852 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime |        net472 | 12.992 ns | 0.0289 ns | 0.0242 ns | 12.995 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                From_DateTime_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                      From_DateTime_Nullable_WithValue | .NET Core 2.0 | 13.188 ns | 0.0172 ns | 0.0152 ns | 13.187 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 2.2 | 12.871 ns | 0.1268 ns | 0.1186 ns | 12.950 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 3.0 | 10.558 ns | 0.0827 ns | 0.0774 ns | 10.610 ns |  0.80 |    0.01 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net461 | 16.331 ns | 0.1224 ns | 0.1145 ns | 16.381 ns |  1.24 |    0.01 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net472 | 13.375 ns | 0.0188 ns | 0.0166 ns | 13.376 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_DateTime_Nullable_NoValue | .NET Core 2.0 | 12.801 ns | 0.0850 ns | 0.0795 ns | 12.759 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 2.2 | 11.933 ns | 0.0367 ns | 0.0343 ns | 11.928 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 3.0 | 10.251 ns | 0.0129 ns | 0.0115 ns | 10.249 ns |  0.80 |    0.01 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net461 | 14.701 ns | 0.0209 ns | 0.0196 ns | 14.702 ns |  1.15 |    0.01 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net472 | 13.408 ns | 0.0190 ns | 0.0178 ns | 13.407 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.943 ns | 0.0341 ns | 0.0266 ns | 14.944 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.359 ns | 0.1266 ns | 0.1184 ns | 14.308 ns |  0.96 |    0.01 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.294 ns | 0.0197 ns | 0.0165 ns | 13.297 ns |  0.89 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net461 | 23.051 ns | 0.2707 ns | 0.2532 ns | 23.180 ns |  1.54 |    0.02 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net472 | 26.494 ns | 0.0337 ns | 0.0298 ns | 26.493 ns |  1.77 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                          From_Decimal | .NET Core 2.0 | 27.656 ns | 0.0229 ns | 0.0191 ns | 27.663 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 2.2 | 24.958 ns | 0.0409 ns | 0.0341 ns | 24.965 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 3.0 | 14.572 ns | 0.1964 ns | 0.1837 ns | 14.452 ns |  0.53 |    0.01 |      - |     - |     - |         - |
                                          From_Decimal |        net461 | 27.638 ns | 0.0466 ns | 0.0413 ns | 27.629 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal |        net472 | 26.942 ns | 0.2618 ns | 0.2449 ns | 27.096 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                 From_Decimal_AsObject | .NET Core 2.0 | 31.207 ns | 0.0469 ns | 0.0415 ns | 31.209 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 2.2 | 29.640 ns | 0.0686 ns | 0.0573 ns | 29.633 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 3.0 | 23.064 ns | 0.0431 ns | 0.0403 ns | 23.059 ns |  0.74 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net461 | 36.847 ns | 0.3230 ns | 0.3022 ns | 37.014 ns |  1.18 |    0.01 |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net472 | 37.368 ns | 0.1317 ns | 0.1232 ns | 37.350 ns |  1.20 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                       From_Decimal_Nullable_WithValue | .NET Core 2.0 | 29.189 ns | 0.0530 ns | 0.0496 ns | 29.203 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 2.2 | 25.101 ns | 0.0408 ns | 0.0341 ns | 25.102 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 3.0 | 19.560 ns | 0.0353 ns | 0.0331 ns | 19.564 ns |  0.67 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net461 | 26.893 ns | 0.0701 ns | 0.0622 ns | 26.893 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net472 | 27.652 ns | 0.0768 ns | 0.0680 ns | 27.642 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.0 | 31.391 ns | 0.0512 ns | 0.0454 ns | 31.379 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.2 | 29.260 ns | 0.2440 ns | 0.2282 ns | 29.147 ns |  0.93 |    0.01 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 3.0 | 24.633 ns | 0.1748 ns | 0.1549 ns | 24.688 ns |  0.78 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net461 | 41.925 ns | 0.0740 ns | 0.0693 ns | 41.914 ns |  1.34 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net472 | 39.006 ns | 0.1034 ns | 0.0917 ns | 39.035 ns |  1.24 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Decimal_Nullable_NoValue | .NET Core 2.0 | 13.501 ns | 0.0210 ns | 0.0164 ns | 13.502 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 2.2 | 12.130 ns | 0.0206 ns | 0.0193 ns | 12.131 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 3.0 | 10.714 ns | 0.2407 ns | 0.3375 ns | 10.530 ns |  0.81 |    0.02 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net461 | 15.538 ns | 0.0623 ns | 0.0583 ns | 15.551 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net472 | 13.453 ns | 0.0175 ns | 0.0155 ns | 13.450 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.046 ns | 0.0368 ns | 0.0345 ns | 15.041 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.976 ns | 0.0317 ns | 0.0297 ns | 12.973 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.506 ns | 0.0220 ns | 0.0183 ns | 13.502 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net461 | 22.800 ns | 0.0513 ns | 0.0479 ns | 22.792 ns |  1.52 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net472 | 25.545 ns | 0.0885 ns | 0.0828 ns | 25.523 ns |  1.70 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_Double | .NET Core 2.0 | 15.249 ns | 0.0291 ns | 0.0258 ns | 15.248 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 2.2 | 14.097 ns | 0.0216 ns | 0.0191 ns | 14.099 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 3.0 | 12.904 ns | 0.0843 ns | 0.0789 ns | 12.955 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                                           From_Double |        net461 | 16.869 ns | 0.0324 ns | 0.0303 ns | 16.870 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                           From_Double |        net472 | 15.417 ns | 0.0242 ns | 0.0202 ns | 15.411 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_Double_AsObject | .NET Core 2.0 | 22.166 ns | 0.1711 ns | 0.1601 ns | 22.260 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 2.2 | 20.833 ns | 0.1260 ns | 0.1179 ns | 20.813 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 3.0 | 20.583 ns | 0.0441 ns | 0.0391 ns | 20.573 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                                  From_Double_AsObject |        net461 | 29.312 ns | 0.1643 ns | 0.1372 ns | 29.341 ns |  1.32 |    0.01 |      - |     - |     - |         - |
                                  From_Double_AsObject |        net472 | 31.707 ns | 0.0725 ns | 0.0566 ns | 31.707 ns |  1.43 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_Double_Nullable_WithValue | .NET Core 2.0 | 17.094 ns | 0.0313 ns | 0.0277 ns | 17.094 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 2.2 | 15.275 ns | 0.0375 ns | 0.0332 ns | 15.280 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 3.0 | 13.935 ns | 0.0845 ns | 0.0791 ns | 13.969 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net461 | 17.573 ns | 0.0279 ns | 0.0247 ns | 17.580 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net472 | 16.888 ns | 0.0453 ns | 0.0378 ns | 16.894 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.0 | 23.443 ns | 0.0366 ns | 0.0306 ns | 23.443 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.2 | 19.982 ns | 0.1688 ns | 0.1579 ns | 20.047 ns |  0.85 |    0.01 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 3.0 | 20.553 ns | 0.0423 ns | 0.0375 ns | 20.550 ns |  0.88 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net461 | 29.260 ns | 0.3087 ns | 0.2888 ns | 29.084 ns |  1.25 |    0.01 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net472 | 32.664 ns | 0.0918 ns | 0.0766 ns | 32.686 ns |  1.39 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Double_Nullable_NoValue | .NET Core 2.0 | 12.423 ns | 0.0307 ns | 0.0287 ns | 12.424 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 2.2 | 11.995 ns | 0.0249 ns | 0.0208 ns | 11.992 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 3.0 | 10.691 ns | 0.0250 ns | 0.0209 ns | 10.690 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net461 | 14.351 ns | 0.0284 ns | 0.0266 ns | 14.343 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net472 | 16.294 ns | 0.0333 ns | 0.0295 ns | 16.292 ns |  1.31 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.865 ns | 0.0355 ns | 0.0315 ns | 14.870 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.994 ns | 0.0235 ns | 0.0197 ns | 12.992 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.986 ns | 0.0805 ns | 0.0753 ns | 15.022 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net461 | 22.672 ns | 0.0328 ns | 0.0307 ns | 22.668 ns |  1.53 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net472 | 25.482 ns | 0.0706 ns | 0.0661 ns | 25.463 ns |  1.71 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_Short | .NET Core 2.0 | 13.300 ns | 0.0351 ns | 0.0312 ns | 13.294 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 2.2 | 12.111 ns | 0.0250 ns | 0.0234 ns | 12.114 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 3.0 |  9.998 ns | 0.0217 ns | 0.0193 ns |  9.995 ns |  0.75 |    0.00 |      - |     - |     - |         - |
                                            From_Short |        net461 | 14.612 ns | 0.0162 ns | 0.0136 ns | 14.616 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                            From_Short |        net472 | 13.196 ns | 0.1167 ns | 0.1092 ns | 13.257 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_Short_AsObject | .NET Core 2.0 | 21.567 ns | 0.0511 ns | 0.0478 ns | 21.557 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 2.2 | 17.915 ns | 0.0426 ns | 0.0356 ns | 17.913 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 3.0 | 19.696 ns | 0.0551 ns | 0.0460 ns | 19.686 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net461 | 27.963 ns | 0.0539 ns | 0.0421 ns | 27.974 ns |  1.30 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net472 | 31.288 ns | 0.0636 ns | 0.0595 ns | 31.284 ns |  1.45 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Short_Nullable_WithValue | .NET Core 2.0 | 13.028 ns | 0.0554 ns | 0.0518 ns | 13.006 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 2.2 | 14.566 ns | 0.0283 ns | 0.0265 ns | 14.562 ns |  1.12 |    0.01 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 3.0 | 10.956 ns | 0.0153 ns | 0.0135 ns | 10.957 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net461 | 15.077 ns | 0.0393 ns | 0.0348 ns | 15.082 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net472 | 13.523 ns | 0.0429 ns | 0.0402 ns | 13.513 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.209 ns | 0.0410 ns | 0.0343 ns | 20.229 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.884 ns | 0.0258 ns | 0.0241 ns | 17.890 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.460 ns | 0.1227 ns | 0.1148 ns | 18.395 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net461 | 28.196 ns | 0.2562 ns | 0.2397 ns | 28.341 ns |  1.39 |    0.01 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net472 | 31.748 ns | 0.1081 ns | 0.1011 ns | 31.768 ns |  1.57 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Short_Nullable_NoValue | .NET Core 2.0 | 12.274 ns | 0.0263 ns | 0.0233 ns | 12.270 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 2.2 | 11.514 ns | 0.0215 ns | 0.0168 ns | 11.512 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 3.0 |  9.602 ns | 0.0332 ns | 0.0311 ns |  9.598 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net461 | 14.152 ns | 0.0266 ns | 0.0248 ns | 14.144 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net472 | 13.623 ns | 0.0340 ns | 0.0318 ns | 13.629 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.872 ns | 0.0288 ns | 0.0241 ns | 14.869 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.997 ns | 0.0305 ns | 0.0285 ns | 12.999 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.809 ns | 0.0211 ns | 0.0176 ns | 14.814 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net461 | 23.021 ns | 0.1130 ns | 0.1057 ns | 23.057 ns |  1.55 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net472 | 25.472 ns | 0.0699 ns | 0.0619 ns | 25.471 ns |  1.71 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                              From_Int | .NET Core 2.0 | 13.279 ns | 0.0228 ns | 0.0213 ns | 13.277 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 2.2 | 12.195 ns | 0.0286 ns | 0.0268 ns | 12.198 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 3.0 |  9.898 ns | 0.0809 ns | 0.0756 ns |  9.935 ns |  0.75 |    0.01 |      - |     - |     - |         - |
                                              From_Int |        net461 | 15.712 ns | 0.0307 ns | 0.0287 ns | 15.724 ns |  1.18 |    0.00 |      - |     - |     - |         - |
                                              From_Int |        net472 | 13.030 ns | 0.0172 ns | 0.0144 ns | 13.025 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_Int_AsObject | .NET Core 2.0 | 20.180 ns | 0.0340 ns | 0.0284 ns | 20.176 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 2.2 | 17.926 ns | 0.0465 ns | 0.0388 ns | 17.918 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 3.0 | 19.831 ns | 0.1058 ns | 0.0989 ns | 19.886 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net461 | 27.485 ns | 0.0343 ns | 0.0321 ns | 27.488 ns |  1.36 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net472 | 30.812 ns | 0.0638 ns | 0.0597 ns | 30.802 ns |  1.53 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Int_Nullable_WithValue | .NET Core 2.0 | 13.289 ns | 0.1208 ns | 0.1130 ns | 13.343 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 2.2 | 12.879 ns | 0.0792 ns | 0.0741 ns | 12.909 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 3.0 | 10.921 ns | 0.0182 ns | 0.0170 ns | 10.914 ns |  0.82 |    0.01 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net461 | 14.741 ns | 0.1151 ns | 0.1077 ns | 14.711 ns |  1.11 |    0.01 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net472 | 13.493 ns | 0.0184 ns | 0.0172 ns | 13.489 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.510 ns | 0.0447 ns | 0.0396 ns | 20.508 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.872 ns | 0.0278 ns | 0.0247 ns | 17.867 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.448 ns | 0.1711 ns | 0.1601 ns | 18.488 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net461 | 27.742 ns | 0.0800 ns | 0.0749 ns | 27.718 ns |  1.35 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net472 | 30.996 ns | 0.1759 ns | 0.1645 ns | 30.931 ns |  1.51 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_Int_Nullable_NoValue | .NET Core 2.0 | 12.491 ns | 0.0189 ns | 0.0157 ns | 12.489 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 2.2 | 10.810 ns | 0.0212 ns | 0.0165 ns | 10.812 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 3.0 |  9.544 ns | 0.0137 ns | 0.0128 ns |  9.538 ns |  0.76 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net461 | 13.687 ns | 0.0153 ns | 0.0143 ns | 13.687 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net472 | 12.830 ns | 0.0215 ns | 0.0179 ns | 12.832 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.198 ns | 0.0249 ns | 0.0233 ns | 15.203 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.030 ns | 0.0180 ns | 0.0150 ns | 13.033 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.557 ns | 0.0675 ns | 0.0632 ns | 13.536 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net461 | 24.925 ns | 0.2203 ns | 0.2060 ns | 25.037 ns |  1.64 |    0.01 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net472 | 24.502 ns | 0.0405 ns | 0.0338 ns | 24.500 ns |  1.61 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Long | .NET Core 2.0 | 13.271 ns | 0.0184 ns | 0.0172 ns | 13.276 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Long | .NET Core 2.2 | 11.993 ns | 0.0340 ns | 0.0318 ns | 11.988 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                             From_Long | .NET Core 3.0 | 10.080 ns | 0.1006 ns | 0.0941 ns | 10.035 ns |  0.76 |    0.01 |      - |     - |     - |         - |
                                             From_Long |        net461 | 14.794 ns | 0.0385 ns | 0.0360 ns | 14.797 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                             From_Long |        net472 | 13.408 ns | 0.0207 ns | 0.0162 ns | 13.408 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Long_AsObject | .NET Core 2.0 | 20.485 ns | 0.2196 ns | 0.1946 ns | 20.558 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 2.2 | 18.308 ns | 0.1102 ns | 0.1030 ns | 18.354 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 3.0 | 17.976 ns | 0.0268 ns | 0.0224 ns | 17.979 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net461 | 30.171 ns | 0.0401 ns | 0.0355 ns | 30.172 ns |  1.47 |    0.01 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net472 | 31.327 ns | 0.2509 ns | 0.2347 ns | 31.416 ns |  1.53 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Long_Nullable_WithValue | .NET Core 2.0 | 14.071 ns | 0.0432 ns | 0.0383 ns | 14.080 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 2.2 | 13.440 ns | 0.0440 ns | 0.0412 ns | 13.435 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 3.0 | 10.834 ns | 0.0629 ns | 0.0588 ns | 10.845 ns |  0.77 |    0.01 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net461 | 15.385 ns | 0.0333 ns | 0.0312 ns | 15.373 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net472 | 16.306 ns | 0.0208 ns | 0.0173 ns | 16.307 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.956 ns | 0.0209 ns | 0.0174 ns | 19.958 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.2 | 18.114 ns | 0.1529 ns | 0.1430 ns | 18.182 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.254 ns | 0.0369 ns | 0.0345 ns | 18.256 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net461 | 27.625 ns | 0.0177 ns | 0.0157 ns | 27.625 ns |  1.38 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net472 | 31.723 ns | 0.2435 ns | 0.2278 ns | 31.624 ns |  1.59 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Long_Nullable_NoValue | .NET Core 2.0 | 12.533 ns | 0.0700 ns | 0.0621 ns | 12.554 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 2.2 | 12.127 ns | 0.0219 ns | 0.0194 ns | 12.124 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 3.0 | 10.033 ns | 0.2800 ns | 0.3737 ns |  9.856 ns |  0.81 |    0.03 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net461 | 15.264 ns | 0.2023 ns | 0.1893 ns | 15.344 ns |  1.22 |    0.02 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net472 | 13.531 ns | 0.1250 ns | 0.1169 ns | 13.580 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.231 ns | 0.0508 ns | 0.0450 ns | 15.236 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.988 ns | 0.0185 ns | 0.0144 ns | 12.988 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.544 ns | 0.3155 ns | 0.3376 ns | 14.648 ns |  0.95 |    0.03 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net461 | 22.788 ns | 0.0268 ns | 0.0251 ns | 22.782 ns |  1.50 |    0.01 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net472 | 24.495 ns | 0.0416 ns | 0.0389 ns | 24.480 ns |  1.61 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_SByte | .NET Core 2.0 | 12.416 ns | 0.0238 ns | 0.0211 ns | 12.416 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 2.2 | 11.549 ns | 0.1207 ns | 0.1129 ns | 11.581 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 3.0 |  9.539 ns | 0.0451 ns | 0.0422 ns |  9.522 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                                            From_SByte |        net461 | 13.815 ns | 0.0223 ns | 0.0209 ns | 13.812 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                            From_SByte |        net472 | 13.010 ns | 0.0514 ns | 0.0429 ns | 12.993 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_SByte_AsObject | .NET Core 2.0 | 19.597 ns | 0.0239 ns | 0.0199 ns | 19.595 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 2.2 | 18.032 ns | 0.0315 ns | 0.0295 ns | 18.037 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 3.0 | 19.132 ns | 0.1610 ns | 0.1506 ns | 19.115 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net461 | 27.670 ns | 0.0601 ns | 0.0562 ns | 27.678 ns |  1.41 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net472 | 30.886 ns | 0.1442 ns | 0.1349 ns | 30.925 ns |  1.58 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_SByte_Nullable_WithValue | .NET Core 2.0 | 12.241 ns | 0.1318 ns | 0.1233 ns | 12.309 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 2.2 | 11.797 ns | 0.1421 ns | 0.1329 ns | 11.775 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 3.0 | 10.022 ns | 0.0260 ns | 0.0244 ns | 10.019 ns |  0.82 |    0.01 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net461 | 15.362 ns | 0.0411 ns | 0.0344 ns | 15.353 ns |  1.26 |    0.01 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net472 | 14.265 ns | 0.0217 ns | 0.0181 ns | 14.271 ns |  1.17 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.622 ns | 0.0410 ns | 0.0384 ns | 19.622 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.669 ns | 0.0238 ns | 0.0211 ns | 17.671 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.743 ns | 0.0249 ns | 0.0208 ns | 17.747 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net461 | 28.027 ns | 0.2514 ns | 0.2351 ns | 28.135 ns |  1.43 |    0.01 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net472 | 30.989 ns | 0.0673 ns | 0.0630 ns | 30.986 ns |  1.58 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_SByte_Nullable_NoValue | .NET Core 2.0 | 12.093 ns | 0.0294 ns | 0.0245 ns | 12.090 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 2.2 | 11.911 ns | 0.0168 ns | 0.0149 ns | 11.907 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 3.0 |  9.633 ns | 0.0699 ns | 0.0654 ns |  9.662 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net461 | 13.495 ns | 0.0101 ns | 0.0089 ns | 13.494 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net472 | 12.823 ns | 0.0225 ns | 0.0176 ns | 12.824 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.305 ns | 0.0894 ns | 0.0836 ns | 15.330 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.012 ns | 0.0313 ns | 0.0261 ns | 13.007 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.726 ns | 0.2304 ns | 0.2156 ns | 13.888 ns |  0.90 |    0.02 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net461 | 22.803 ns | 0.0906 ns | 0.0848 ns | 22.781 ns |  1.49 |    0.01 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net472 | 26.384 ns | 0.0610 ns | 0.0571 ns | 26.380 ns |  1.72 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_Float | .NET Core 2.0 | 15.651 ns | 0.0442 ns | 0.0392 ns | 15.640 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 2.2 | 13.499 ns | 0.0158 ns | 0.0148 ns | 13.498 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 3.0 | 12.578 ns | 0.0169 ns | 0.0158 ns | 12.578 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                            From_Float |        net461 | 17.092 ns | 0.0329 ns | 0.0307 ns | 17.088 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                            From_Float |        net472 | 15.828 ns | 0.0748 ns | 0.0700 ns | 15.840 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_Float_AsObject | .NET Core 2.0 | 22.085 ns | 0.0590 ns | 0.0493 ns | 22.071 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 2.2 | 19.945 ns | 0.1839 ns | 0.1720 ns | 20.060 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 3.0 | 20.529 ns | 0.0666 ns | 0.0623 ns | 20.529 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject |        net461 | 30.476 ns | 0.0450 ns | 0.0421 ns | 30.482 ns |  1.38 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject |        net472 | 32.438 ns | 0.1029 ns | 0.0912 ns | 32.418 ns |  1.47 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Float_Nullable_WithValue | .NET Core 2.0 | 14.833 ns | 0.0236 ns | 0.0197 ns | 14.835 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 2.2 | 13.557 ns | 0.0392 ns | 0.0327 ns | 13.552 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 3.0 | 12.917 ns | 0.1039 ns | 0.0972 ns | 12.968 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net461 | 16.244 ns | 0.1970 ns | 0.1842 ns | 16.131 ns |  1.09 |    0.01 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net472 | 15.538 ns | 0.0620 ns | 0.0484 ns | 15.526 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.0 | 22.277 ns | 0.0354 ns | 0.0296 ns | 22.279 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.2 | 19.880 ns | 0.1794 ns | 0.1679 ns | 20.005 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 3.0 | 20.309 ns | 0.0429 ns | 0.0380 ns | 20.307 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net461 | 30.533 ns | 0.0849 ns | 0.0794 ns | 30.512 ns |  1.37 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net472 | 34.124 ns | 0.0933 ns | 0.0780 ns | 34.142 ns |  1.53 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Float_Nullable_NoValue | .NET Core 2.0 | 12.129 ns | 0.0342 ns | 0.0320 ns | 12.116 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 2.2 | 10.934 ns | 0.0207 ns | 0.0194 ns | 10.942 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 3.0 |  9.797 ns | 0.0496 ns | 0.0464 ns |  9.774 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net461 | 13.721 ns | 0.0200 ns | 0.0177 ns | 13.717 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net472 | 13.757 ns | 0.0391 ns | 0.0346 ns | 13.761 ns |  1.13 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.848 ns | 0.0345 ns | 0.0322 ns | 14.848 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.089 ns | 0.0257 ns | 0.0201 ns | 13.087 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.326 ns | 0.0602 ns | 0.0563 ns | 13.303 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net461 | 22.749 ns | 0.1960 ns | 0.1833 ns | 22.846 ns |  1.53 |    0.01 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net472 | 26.403 ns | 0.0579 ns | 0.0513 ns | 26.397 ns |  1.78 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_String | .NET Core 2.0 | 59.269 ns | 0.1671 ns | 0.1563 ns | 59.271 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 2.2 | 58.850 ns | 0.0942 ns | 0.0835 ns | 58.840 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 3.0 | 20.516 ns | 0.0308 ns | 0.0273 ns | 20.521 ns |  0.35 |    0.00 |      - |     - |     - |         - |
                                           From_String |        net461 | 58.949 ns | 0.1109 ns | 0.1037 ns | 58.930 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                           From_String |        net472 | 60.313 ns | 0.1055 ns | 0.0935 ns | 60.296 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_String_AsObject | .NET Core 2.0 | 66.535 ns | 0.3147 ns | 0.2790 ns | 66.599 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 2.2 | 63.036 ns | 0.1132 ns | 0.0945 ns | 63.015 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 3.0 | 26.008 ns | 0.5305 ns | 0.5210 ns | 25.957 ns |  0.39 |    0.01 |      - |     - |     - |         - |
                                  From_String_AsObject |        net461 | 73.521 ns | 0.2737 ns | 0.2426 ns | 73.438 ns |  1.11 |    0.01 |      - |     - |     - |         - |
                                  From_String_AsObject |        net472 | 76.682 ns | 0.6163 ns | 0.5765 ns | 76.382 ns |  1.15 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                      From_String_Null | .NET Core 2.0 | 14.276 ns | 0.0217 ns | 0.0192 ns | 14.275 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 2.2 | 18.673 ns | 0.0448 ns | 0.0397 ns | 18.678 ns |  1.31 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 3.0 | 13.907 ns | 0.0414 ns | 0.0388 ns | 13.909 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null |        net461 | 14.849 ns | 0.0500 ns | 0.0468 ns | 14.849 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null |        net472 | 15.894 ns | 0.1434 ns | 0.1342 ns | 15.898 ns |  1.11 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_String_Null_AsObject | .NET Core 2.0 | 15.758 ns | 0.0240 ns | 0.0213 ns | 15.759 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 2.2 | 13.440 ns | 0.0402 ns | 0.0376 ns | 13.427 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 3.0 | 13.531 ns | 0.0567 ns | 0.0503 ns | 13.516 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net461 | 22.797 ns | 0.0455 ns | 0.0426 ns | 22.800 ns |  1.45 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net472 | 24.874 ns | 0.1935 ns | 0.1810 ns | 24.933 ns |  1.58 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_String_Empty | .NET Core 2.0 | 14.131 ns | 0.0263 ns | 0.0246 ns | 14.134 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 2.2 | 18.938 ns | 0.1792 ns | 0.1676 ns | 18.880 ns |  1.34 |    0.01 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 3.0 | 14.166 ns | 0.0260 ns | 0.0244 ns | 14.157 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty |        net461 | 16.198 ns | 0.0418 ns | 0.0349 ns | 16.198 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty |        net472 | 16.341 ns | 0.0185 ns | 0.0154 ns | 16.345 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_String_Empty_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_UShort | .NET Core 2.0 | 12.380 ns | 0.0524 ns | 0.0490 ns | 12.366 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 2.2 | 12.043 ns | 0.0335 ns | 0.0313 ns | 12.036 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 3.0 |  9.609 ns | 0.0623 ns | 0.0582 ns |  9.648 ns |  0.78 |    0.01 |      - |     - |     - |         - |
                                           From_UShort |        net461 | 14.678 ns | 0.0401 ns | 0.0376 ns | 14.672 ns |  1.19 |    0.00 |      - |     - |     - |         - |
                                           From_UShort |        net472 | 14.156 ns | 0.0254 ns | 0.0238 ns | 14.152 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_UShort_AsObject | .NET Core 2.0 | 19.610 ns | 0.0477 ns | 0.0423 ns | 19.605 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 2.2 | 17.833 ns | 0.1465 ns | 0.1370 ns | 17.905 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 3.0 | 17.862 ns | 0.1381 ns | 0.1292 ns | 17.935 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net461 | 27.626 ns | 0.0377 ns | 0.0353 ns | 27.639 ns |  1.41 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net472 | 29.421 ns | 0.0594 ns | 0.0527 ns | 29.447 ns |  1.50 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_UShort_Nullable_WithValue | .NET Core 2.0 | 12.630 ns | 0.0855 ns | 0.0799 ns | 12.627 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 2.2 | 11.207 ns | 0.0202 ns | 0.0189 ns | 11.209 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 3.0 | 10.038 ns | 0.0148 ns | 0.0131 ns | 10.037 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net461 | 14.677 ns | 0.0704 ns | 0.0659 ns | 14.695 ns |  1.16 |    0.01 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net472 | 13.576 ns | 0.0159 ns | 0.0141 ns | 13.578 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.895 ns | 0.1062 ns | 0.0994 ns | 19.864 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.630 ns | 0.0265 ns | 0.0248 ns | 17.636 ns |  0.89 |    0.01 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.526 ns | 0.0400 ns | 0.0354 ns | 17.532 ns |  0.88 |    0.01 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net461 | 27.650 ns | 0.0287 ns | 0.0254 ns | 27.643 ns |  1.39 |    0.01 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net472 | 30.615 ns | 0.0447 ns | 0.0396 ns | 30.614 ns |  1.54 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_UShort_Nullable_NoValue | .NET Core 2.0 | 12.162 ns | 0.0221 ns | 0.0207 ns | 12.163 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 2.2 | 10.918 ns | 0.1152 ns | 0.1078 ns | 10.979 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 3.0 |  9.560 ns | 0.0136 ns | 0.0120 ns |  9.559 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net461 | 14.777 ns | 0.0358 ns | 0.0299 ns | 14.771 ns |  1.21 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net472 | 12.852 ns | 0.0097 ns | 0.0086 ns | 12.852 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.915 ns | 0.0285 ns | 0.0267 ns | 14.920 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.976 ns | 0.0282 ns | 0.0250 ns | 13.980 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.851 ns | 0.0261 ns | 0.0218 ns | 14.848 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net461 | 24.531 ns | 0.0335 ns | 0.0297 ns | 24.526 ns |  1.65 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net472 | 26.511 ns | 0.0464 ns | 0.0434 ns | 26.509 ns |  1.78 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_UInt | .NET Core 2.0 | 11.940 ns | 0.0139 ns | 0.0130 ns | 11.943 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 2.2 | 12.099 ns | 0.0316 ns | 0.0280 ns | 12.092 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 3.0 |  9.355 ns | 0.0326 ns | 0.0305 ns |  9.354 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                                             From_UInt |        net461 | 14.414 ns | 0.0421 ns | 0.0373 ns | 14.410 ns |  1.21 |    0.00 |      - |     - |     - |         - |
                                             From_UInt |        net472 | 14.147 ns | 0.0414 ns | 0.0367 ns | 14.143 ns |  1.18 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_UInt_AsObject | .NET Core 2.0 | 20.660 ns | 0.1071 ns | 0.1002 ns | 20.635 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 2.2 | 17.636 ns | 0.0339 ns | 0.0283 ns | 17.645 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 3.0 | 17.686 ns | 0.1550 ns | 0.1450 ns | 17.743 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net461 | 30.119 ns | 0.0763 ns | 0.0713 ns | 30.112 ns |  1.46 |    0.01 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net472 | 29.873 ns | 0.0397 ns | 0.0352 ns | 29.864 ns |  1.45 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_UInt_Nullable_WithValue | .NET Core 2.0 | 12.283 ns | 0.0591 ns | 0.0552 ns | 12.303 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 2.2 | 11.350 ns | 0.1014 ns | 0.0847 ns | 11.387 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 3.0 | 10.693 ns | 0.0176 ns | 0.0164 ns | 10.692 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net461 | 15.247 ns | 0.0214 ns | 0.0178 ns | 15.251 ns |  1.24 |    0.01 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net472 | 15.370 ns | 0.0424 ns | 0.0354 ns | 15.370 ns |  1.25 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.808 ns | 0.0739 ns | 0.0656 ns | 19.800 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.693 ns | 0.0432 ns | 0.0404 ns | 17.688 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.133 ns | 0.3853 ns | 0.4123 ns | 18.152 ns |  0.91 |    0.02 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net461 | 27.508 ns | 0.1125 ns | 0.1053 ns | 27.466 ns |  1.39 |    0.01 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net472 | 30.018 ns | 0.1704 ns | 0.1511 ns | 30.081 ns |  1.52 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_UInt_Nullable_NoValue | .NET Core 2.0 | 12.168 ns | 0.0327 ns | 0.0290 ns | 12.163 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 2.2 | 10.804 ns | 0.0748 ns | 0.0663 ns | 10.780 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 3.0 |  9.561 ns | 0.0216 ns | 0.0191 ns |  9.559 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net461 | 13.504 ns | 0.0337 ns | 0.0315 ns | 13.505 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net472 | 12.860 ns | 0.0175 ns | 0.0155 ns | 12.861 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.763 ns | 0.0903 ns | 0.0801 ns | 15.793 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.978 ns | 0.0256 ns | 0.0239 ns | 12.975 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.568 ns | 0.0632 ns | 0.0591 ns | 13.593 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net461 | 22.688 ns | 0.0252 ns | 0.0224 ns | 22.696 ns |  1.44 |    0.01 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net472 | 24.793 ns | 0.0472 ns | 0.0419 ns | 24.785 ns |  1.57 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_ULong | .NET Core 2.0 | 13.399 ns | 0.0294 ns | 0.0275 ns | 13.392 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 2.2 | 12.172 ns | 0.0368 ns | 0.0326 ns | 12.167 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 3.0 | 10.069 ns | 0.0901 ns | 0.0843 ns | 10.032 ns |  0.75 |    0.01 |      - |     - |     - |         - |
                                            From_ULong |        net461 | 14.238 ns | 0.1214 ns | 0.1136 ns | 14.289 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                                            From_ULong |        net472 | 13.569 ns | 0.0184 ns | 0.0172 ns | 13.568 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_ULong_AsObject | .NET Core 2.0 | 20.113 ns | 0.0808 ns | 0.0755 ns | 20.077 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 2.2 | 17.961 ns | 0.1110 ns | 0.0984 ns | 17.930 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 3.0 | 19.706 ns | 0.0443 ns | 0.0392 ns | 19.717 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net461 | 27.659 ns | 0.0599 ns | 0.0560 ns | 27.667 ns |  1.38 |    0.01 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net472 | 29.233 ns | 0.0286 ns | 0.0268 ns | 29.225 ns |  1.45 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_ULong_Nullable_WithValue | .NET Core 2.0 | 14.094 ns | 0.0753 ns | 0.0668 ns | 14.115 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 2.2 | 13.307 ns | 0.0355 ns | 0.0332 ns | 13.305 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 3.0 | 11.093 ns | 0.1460 ns | 0.1366 ns | 11.196 ns |  0.79 |    0.01 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net461 | 15.974 ns | 0.0255 ns | 0.0238 ns | 15.969 ns |  1.13 |    0.01 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net472 | 14.956 ns | 0.1393 ns | 0.1303 ns | 14.921 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.814 ns | 0.0383 ns | 0.0339 ns | 20.818 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.2 | 18.023 ns | 0.1356 ns | 0.1269 ns | 17.966 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 3.0 | 19.534 ns | 0.1378 ns | 0.1289 ns | 19.636 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net461 | 28.092 ns | 0.1178 ns | 0.1044 ns | 28.116 ns |  1.35 |    0.01 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net472 | 31.122 ns | 0.0432 ns | 0.0404 ns | 31.126 ns |  1.50 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_ULong_Nullable_NoValue | .NET Core 2.0 | 12.390 ns | 0.0214 ns | 0.0200 ns | 12.394 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 2.2 | 12.100 ns | 0.0138 ns | 0.0129 ns | 12.100 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 3.0 |  9.974 ns | 0.0169 ns | 0.0150 ns |  9.974 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net461 | 14.940 ns | 0.0442 ns | 0.0413 ns | 14.926 ns |  1.21 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net472 | 13.329 ns | 0.0143 ns | 0.0134 ns | 13.327 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.613 ns | 0.0395 ns | 0.0330 ns | 15.618 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.987 ns | 0.0180 ns | 0.0150 ns | 12.991 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.460 ns | 0.0423 ns | 0.0396 ns | 13.440 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net461 | 22.739 ns | 0.0821 ns | 0.0768 ns | 22.710 ns |  1.46 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net472 | 24.959 ns | 0.0385 ns | 0.0321 ns | 24.954 ns |  1.60 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                       From_NullObject | .NET Core 2.0 | 14.916 ns | 0.0361 ns | 0.0302 ns | 14.916 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 2.2 | 12.987 ns | 0.0224 ns | 0.0209 ns | 12.993 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 3.0 | 13.242 ns | 0.0261 ns | 0.0231 ns | 13.240 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject |        net461 | 24.563 ns | 0.0528 ns | 0.0494 ns | 24.551 ns |  1.65 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject |        net472 | 24.291 ns | 0.0680 ns | 0.0603 ns | 24.275 ns |  1.63 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_DBNull | .NET Core 2.0 | 12.708 ns | 0.0822 ns | 0.0769 ns | 12.748 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 2.2 | 11.160 ns | 0.0250 ns | 0.0222 ns | 11.158 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 3.0 | 12.448 ns | 0.0194 ns | 0.0172 ns | 12.448 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                                           From_DBNull |        net461 | 13.339 ns | 0.1174 ns | 0.1098 ns | 13.344 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                                           From_DBNull |        net472 | 15.251 ns | 0.0254 ns | 0.0237 ns | 15.245 ns |  1.20 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_DBNull_AsObject | .NET Core 2.0 | 14.909 ns | 0.0348 ns | 0.0308 ns | 14.909 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 2.2 | 13.044 ns | 0.0958 ns | 0.0897 ns | 12.994 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 3.0 | 13.446 ns | 0.0300 ns | 0.0280 ns | 13.451 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net461 | 22.948 ns | 0.1896 ns | 0.1774 ns | 23.052 ns |  1.54 |    0.01 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net472 | 26.682 ns | 0.0363 ns | 0.0322 ns | 26.669 ns |  1.79 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                 From_ConvertibleClass | .NET Core 2.0 | 17.726 ns | 0.1278 ns | 0.1196 ns | 17.782 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 2.2 | 15.076 ns | 0.0381 ns | 0.0357 ns | 15.085 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 3.0 | 15.464 ns | 0.3316 ns | 0.3257 ns | 15.693 ns |  0.87 |    0.02 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net461 | 26.073 ns | 0.0557 ns | 0.0521 ns | 26.072 ns |  1.47 |    0.01 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net472 | 25.505 ns | 0.0453 ns | 0.0423 ns | 25.505 ns |  1.44 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_ConvertibleClass_AsObject | .NET Core 2.0 | 19.232 ns | 0.0340 ns | 0.0302 ns | 19.223 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 2.2 | 16.912 ns | 0.0227 ns | 0.0201 ns | 16.909 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 3.0 | 16.839 ns | 0.0296 ns | 0.0231 ns | 16.849 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net461 | 26.231 ns | 0.0609 ns | 0.0540 ns | 26.208 ns |  1.36 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net472 | 30.096 ns | 0.1751 ns | 0.1638 ns | 30.051 ns |  1.57 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_ConvertibleClass_NoValue | .NET Core 2.0 | 15.860 ns | 0.0301 ns | 0.0267 ns | 15.863 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 2.2 | 13.463 ns | 0.0174 ns | 0.0145 ns | 13.466 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 3.0 | 12.977 ns | 0.0338 ns | 0.0300 ns | 12.977 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net461 | 24.501 ns | 0.0475 ns | 0.0444 ns | 24.486 ns |  1.54 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net472 | 26.879 ns | 0.1334 ns | 0.1248 ns | 26.880 ns |  1.69 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.0 | 15.545 ns | 0.0337 ns | 0.0315 ns | 15.546 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.2 | 12.996 ns | 0.0256 ns | 0.0227 ns | 12.994 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 3.0 | 15.010 ns | 0.1513 ns | 0.1264 ns | 15.067 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net461 | 22.760 ns | 0.0261 ns | 0.0244 ns | 22.756 ns |  1.46 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net472 | 25.790 ns | 0.0384 ns | 0.0321 ns | 25.788 ns |  1.66 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                              From_NonConvertibleClass | .NET Core 2.0 | 13.934 ns | 0.0420 ns | 0.0393 ns | 13.925 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 2.2 | 12.934 ns | 0.0839 ns | 0.0785 ns | 12.964 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 3.0 | 12.699 ns | 0.0403 ns | 0.0377 ns | 12.692 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net461 | 14.615 ns | 0.0998 ns | 0.0933 ns | 14.647 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net472 | 14.425 ns | 0.0713 ns | 0.0667 ns | 14.412 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                     From_NonConvertibleClass_AsObject | .NET Core 2.0 | 17.300 ns | 0.1455 ns | 0.1361 ns | 17.358 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 2.2 | 14.854 ns | 0.0328 ns | 0.0307 ns | 14.854 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 3.0 | 15.328 ns | 0.1548 ns | 0.1448 ns | 15.344 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net461 | 24.618 ns | 0.0345 ns | 0.0322 ns | 24.613 ns |  1.42 |    0.01 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net472 | 27.280 ns | 0.0309 ns | 0.0258 ns | 27.282 ns |  1.58 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                      From_NonConvertibleClass_NoValue | .NET Core 2.0 | 13.930 ns | 0.0539 ns | 0.0504 ns | 13.911 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 2.2 | 12.745 ns | 0.0119 ns | 0.0093 ns | 12.746 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 3.0 | 12.733 ns | 0.0189 ns | 0.0167 ns | 12.739 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net461 | 15.066 ns | 0.0314 ns | 0.0279 ns | 15.067 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net472 | 14.390 ns | 0.0305 ns | 0.0285 ns | 14.394 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.0 | 14.968 ns | 0.0782 ns | 0.0732 ns | 14.934 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.2 | 13.226 ns | 0.0238 ns | 0.0223 ns | 13.230 ns |  0.88 |    0.01 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 3.0 | 14.773 ns | 0.0159 ns | 0.0133 ns | 14.771 ns |  0.99 |    0.01 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net461 | 23.063 ns | 0.1205 ns | 0.1127 ns | 23.087 ns |  1.54 |    0.01 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net472 | 24.578 ns | 0.0571 ns | 0.0506 ns | 24.566 ns |  1.64 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                From_ConvertibleStruct | .NET Core 2.0 | 21.969 ns | 0.0475 ns | 0.0444 ns | 21.963 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 2.2 | 16.336 ns | 0.0456 ns | 0.0404 ns | 16.332 ns |  0.74 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 3.0 | 15.200 ns | 0.3256 ns | 0.5871 ns | 15.431 ns |  0.67 |    0.04 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net461 | 19.682 ns | 0.0251 ns | 0.0222 ns | 19.688 ns |  0.90 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net472 | 18.742 ns | 0.0551 ns | 0.0516 ns | 18.747 ns |  0.85 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                       From_ConvertibleStruct_AsObject | .NET Core 2.0 | 19.926 ns | 0.0414 ns | 0.0388 ns | 19.930 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 2.2 | 17.942 ns | 0.0331 ns | 0.0277 ns | 17.934 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 3.0 | 17.451 ns | 0.0543 ns | 0.0481 ns | 17.446 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net461 | 27.482 ns | 0.2626 ns | 0.2456 ns | 27.567 ns |  1.38 |    0.01 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net472 | 29.847 ns | 0.0684 ns | 0.0606 ns | 29.834 ns |  1.50 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.0 | 21.790 ns | 0.0686 ns | 0.0608 ns | 21.806 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.2 | 17.993 ns | 0.0304 ns | 0.0254 ns | 17.984 ns |  0.83 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 3.0 | 14.935 ns | 0.1993 ns | 0.1864 ns | 14.943 ns |  0.69 |    0.01 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net461 | 29.860 ns | 0.0767 ns | 0.0717 ns | 29.873 ns |  1.37 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net472 | 27.174 ns | 0.0620 ns | 0.0580 ns | 27.183 ns |  1.25 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.374 ns | 0.0170 ns | 0.0151 ns | 19.371 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.150 ns | 0.0226 ns | 0.0201 ns | 17.146 ns |  0.89 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.522 ns | 0.0707 ns | 0.0661 ns | 17.520 ns |  0.90 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net461 | 27.009 ns | 0.0757 ns | 0.0708 ns | 27.001 ns |  1.39 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net472 | 29.820 ns | 0.0387 ns | 0.0343 ns | 29.827 ns |  1.54 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.0 | 15.181 ns | 0.1149 ns | 0.1019 ns | 15.139 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.2 | 13.672 ns | 0.0727 ns | 0.0680 ns | 13.693 ns |  0.90 |    0.01 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 3.0 | 10.474 ns | 0.0523 ns | 0.0464 ns | 10.456 ns |  0.69 |    0.01 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net461 | 21.832 ns | 0.0371 ns | 0.0347 ns | 21.831 ns |  1.44 |    0.01 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net472 | 18.644 ns | 0.1507 ns | 0.1410 ns | 18.693 ns |  1.23 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.906 ns | 0.0483 ns | 0.0428 ns | 14.913 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.017 ns | 0.0282 ns | 0.0263 ns | 13.009 ns |  0.87 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.565 ns | 0.0911 ns | 0.0853 ns | 13.547 ns |  0.91 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net461 | 22.982 ns | 0.1879 ns | 0.1757 ns | 23.095 ns |  1.54 |    0.01 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net472 | 25.547 ns | 0.0479 ns | 0.0448 ns | 25.534 ns |  1.71 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_NonConvertibleStruct | .NET Core 2.0 | 14.358 ns | 0.1268 ns | 0.1186 ns | 14.435 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 2.2 | 12.492 ns | 0.0724 ns | 0.0678 ns | 12.515 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 3.0 |  9.483 ns | 0.0154 ns | 0.0137 ns |  9.480 ns |  0.66 |    0.01 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net461 | 14.022 ns | 0.0332 ns | 0.0294 ns | 14.018 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net472 | 12.314 ns | 0.0162 ns | 0.0143 ns | 12.315 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.0 | 17.293 ns | 0.0359 ns | 0.0318 ns | 17.287 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.2 | 14.942 ns | 0.0277 ns | 0.0231 ns | 14.939 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 3.0 | 15.906 ns | 0.1477 ns | 0.1382 ns | 15.903 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net461 | 25.033 ns | 0.0265 ns | 0.0248 ns | 25.032 ns |  1.45 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net472 | 28.174 ns | 0.0516 ns | 0.0482 ns | 28.161 ns |  1.63 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.0 | 14.922 ns | 0.0461 ns | 0.0431 ns | 14.912 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.2 | 11.604 ns | 0.1090 ns | 0.1019 ns | 11.668 ns |  0.78 |    0.01 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 3.0 |  9.751 ns | 0.0253 ns | 0.0224 ns |  9.752 ns |  0.65 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net461 | 13.023 ns | 0.0289 ns | 0.0270 ns | 13.023 ns |  0.87 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net472 | 12.291 ns | 0.0229 ns | 0.0203 ns | 12.285 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 16.942 ns | 0.1044 ns | 0.0977 ns | 16.974 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 14.870 ns | 0.0424 ns | 0.0397 ns | 14.877 ns |  0.88 |    0.01 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.537 ns | 0.3341 ns | 0.5852 ns | 15.165 ns |  0.95 |    0.03 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net461 | 25.996 ns | 0.0366 ns | 0.0306 ns | 25.998 ns |  1.53 |    0.01 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net472 | 27.765 ns | 0.1631 ns | 0.1446 ns | 27.797 ns |  1.64 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.0 | 14.287 ns | 0.0278 ns | 0.0260 ns | 14.285 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.2 | 11.477 ns | 0.0158 ns | 0.0140 ns | 11.479 ns |  0.80 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 3.0 |  9.511 ns | 0.0283 ns | 0.0265 ns |  9.523 ns |  0.67 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net461 | 13.983 ns | 0.0348 ns | 0.0326 ns | 13.977 ns |  0.98 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net472 | 12.311 ns | 0.0171 ns | 0.0151 ns | 12.308 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.975 ns | 0.1094 ns | 0.1023 ns | 14.908 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.175 ns | 0.1075 ns | 0.0953 ns | 13.206 ns |  0.88 |    0.01 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.230 ns | 0.0131 ns | 0.0123 ns | 13.228 ns |  0.88 |    0.01 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net461 | 22.680 ns | 0.0195 ns | 0.0173 ns | 22.675 ns |  1.52 |    0.01 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net472 | 25.430 ns | 0.0202 ns | 0.0179 ns | 25.430 ns |  1.70 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Enum | .NET Core 2.0 | 14.676 ns | 0.0319 ns | 0.0299 ns | 14.682 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 2.2 | 12.847 ns | 0.0220 ns | 0.0206 ns | 12.846 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 3.0 |  9.761 ns | 0.0293 ns | 0.0275 ns |  9.755 ns |  0.67 |    0.00 |      - |     - |     - |         - |
                                             From_Enum |        net461 | 13.975 ns | 0.0306 ns | 0.0286 ns | 13.976 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                             From_Enum |        net472 | 14.204 ns | 0.1373 ns | 0.1284 ns | 14.281 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Enum_AsObject | .NET Core 2.0 | 47.055 ns | 0.0944 ns | 0.0883 ns | 47.062 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject | .NET Core 2.2 | 50.604 ns | 0.5402 ns | 0.5053 ns | 50.785 ns |  1.08 |    0.01 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject | .NET Core 3.0 | 41.030 ns | 0.1590 ns | 0.1487 ns | 40.989 ns |  0.87 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject |        net461 | 53.336 ns | 0.1468 ns | 0.1301 ns | 53.337 ns |  1.13 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject |        net472 | 53.768 ns | 0.0826 ns | 0.0733 ns | 53.756 ns |  1.14 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Enum_Nullable_WithValue | .NET Core 2.0 | 15.050 ns | 0.0879 ns | 0.0822 ns | 15.019 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 2.2 | 13.132 ns | 0.0210 ns | 0.0196 ns | 13.136 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 3.0 | 10.869 ns | 0.0157 ns | 0.0123 ns | 10.870 ns |  0.72 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net461 | 14.752 ns | 0.1017 ns | 0.0951 ns | 14.703 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net472 | 14.000 ns | 0.0224 ns | 0.0198 ns | 13.993 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.0 | 46.908 ns | 0.3049 ns | 0.2852 ns | 46.828 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.2 | 45.370 ns | 0.1273 ns | 0.1128 ns | 45.378 ns |  0.97 |    0.01 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 3.0 | 40.890 ns | 0.2794 ns | 0.2613 ns | 40.968 ns |  0.87 |    0.01 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject |        net461 | 51.695 ns | 0.1494 ns | 0.1397 ns | 51.688 ns |  1.10 |    0.01 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject |        net472 | 55.792 ns | 0.1054 ns | 0.0986 ns | 55.803 ns |  1.19 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Enum_Nullable_NoValue | .NET Core 2.0 | 13.775 ns | 0.0205 ns | 0.0192 ns | 13.770 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 2.2 | 12.583 ns | 0.1119 ns | 0.1047 ns | 12.647 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 3.0 | 10.181 ns | 0.0181 ns | 0.0169 ns | 10.180 ns |  0.74 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net461 | 13.529 ns | 0.0432 ns | 0.0404 ns | 13.517 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net472 | 12.853 ns | 0.0229 ns | 0.0191 ns | 12.851 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.506 ns | 0.0353 ns | 0.0295 ns | 15.504 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.016 ns | 0.0250 ns | 0.0209 ns | 13.018 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.778 ns | 0.0343 ns | 0.0268 ns | 14.783 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net461 | 22.761 ns | 0.0368 ns | 0.0307 ns | 22.759 ns |  1.47 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net472 | 26.756 ns | 0.2640 ns | 0.2470 ns | 26.826 ns |  1.73 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                      From_ParentClass | .NET Core 2.0 | 14.222 ns | 0.0928 ns | 0.0868 ns | 14.192 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 2.2 | 12.763 ns | 0.0321 ns | 0.0284 ns | 12.755 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 3.0 | 12.524 ns | 0.0304 ns | 0.0269 ns | 12.526 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                                      From_ParentClass |        net461 | 15.364 ns | 0.0131 ns | 0.0116 ns | 15.363 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                                      From_ParentClass |        net472 | 14.351 ns | 0.0252 ns | 0.0236 ns | 14.354 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_ParentClass_AsObject | .NET Core 2.0 | 17.509 ns | 0.0875 ns | 0.0818 ns | 17.539 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 2.2 | 15.352 ns | 0.0547 ns | 0.0457 ns | 15.343 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 3.0 | 15.313 ns | 0.0402 ns | 0.0356 ns | 15.308 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net461 | 25.141 ns | 0.0436 ns | 0.0386 ns | 25.140 ns |  1.44 |    0.01 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net472 | 26.269 ns | 0.0491 ns | 0.0460 ns | 26.272 ns |  1.50 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                              From_ParentClass_NoValue | .NET Core 2.0 | 13.919 ns | 0.0369 ns | 0.0327 ns | 13.918 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 2.2 | 12.765 ns | 0.0143 ns | 0.0127 ns | 12.762 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 3.0 | 12.546 ns | 0.0592 ns | 0.0553 ns | 12.523 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net461 | 14.379 ns | 0.0097 ns | 0.0086 ns | 14.379 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net472 | 14.356 ns | 0.0224 ns | 0.0187 ns | 14.355 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.0 | 15.723 ns | 0.1488 ns | 0.1391 ns | 15.799 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.2 | 13.070 ns | 0.0505 ns | 0.0473 ns | 13.050 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 3.0 | 13.844 ns | 0.2878 ns | 0.2955 ns | 14.029 ns |  0.88 |    0.02 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net461 | 21.742 ns | 0.1295 ns | 0.1148 ns | 21.799 ns |  1.38 |    0.01 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net472 | 24.402 ns | 0.0290 ns | 0.0257 ns | 24.402 ns |  1.55 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_ParentStruct | .NET Core 2.0 | 44.320 ns | 0.0801 ns | 0.0750 ns | 44.299 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 2.2 | 40.691 ns | 0.1055 ns | 0.0987 ns | 40.682 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 3.0 | 40.286 ns | 0.0984 ns | 0.0872 ns | 40.296 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct |        net461 | 41.643 ns | 0.1109 ns | 0.0983 ns | 41.641 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct |        net472 | 41.170 ns | 0.4550 ns | 0.4256 ns | 40.926 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_ParentStruct_AsObject | .NET Core 2.0 | 17.495 ns | 0.1393 ns | 0.1303 ns | 17.580 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 2.2 | 15.313 ns | 0.0389 ns | 0.0345 ns | 15.315 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 3.0 | 15.618 ns | 0.1542 ns | 0.1442 ns | 15.543 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net461 | 25.014 ns | 0.0495 ns | 0.0386 ns | 25.021 ns |  1.43 |    0.01 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net472 | 26.249 ns | 0.0389 ns | 0.0364 ns | 26.248 ns |  1.50 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.0 | 44.334 ns | 0.0634 ns | 0.0593 ns | 44.322 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.2 | 40.841 ns | 0.0271 ns | 0.0212 ns | 40.844 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 3.0 | 39.769 ns | 0.3800 ns | 0.2967 ns | 39.753 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue |        net461 | 54.898 ns | 0.4391 ns | 0.4107 ns | 54.637 ns |  1.24 |    0.01 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue |        net472 | 41.647 ns | 0.0603 ns | 0.0503 ns | 41.666 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 17.235 ns | 0.0439 ns | 0.0366 ns | 17.234 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.383 ns | 0.0358 ns | 0.0335 ns | 15.388 ns |  0.89 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.565 ns | 0.0441 ns | 0.0391 ns | 15.565 ns |  0.90 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net461 | 24.309 ns | 0.0525 ns | 0.0491 ns | 24.315 ns |  1.41 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net472 | 28.311 ns | 0.0841 ns | 0.0745 ns | 28.318 ns |  1.64 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.0 | 44.396 ns | 0.1120 ns | 0.1048 ns | 44.384 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.2 | 40.253 ns | 0.0900 ns | 0.0842 ns | 40.268 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 3.0 | 39.444 ns | 0.2246 ns | 0.2101 ns | 39.395 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net461 | 45.027 ns | 0.1013 ns | 0.0898 ns | 45.001 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net472 | 42.461 ns | 0.3624 ns | 0.3390 ns | 42.606 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.856 ns | 0.0124 ns | 0.0116 ns | 14.859 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.994 ns | 0.0470 ns | 0.0440 ns | 12.981 ns |  0.87 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.074 ns | 0.0257 ns | 0.0241 ns | 14.068 ns |  0.95 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net461 | 22.744 ns | 0.0593 ns | 0.0525 ns | 22.729 ns |  1.53 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net472 | 25.464 ns | 0.0564 ns | 0.0527 ns | 25.471 ns |  1.71 |    0.00 |      - |     - |     - |         - |

Benchmarks with issues:
  ConvertTo_ByteNullable.From_DateTime_AsObject: Job-LRKCAO(Toolchain=.NET Core 2.0)
  ConvertTo_ByteNullable.From_DateTime_AsObject: Job-VAJWLV(Toolchain=.NET Core 2.2)
  ConvertTo_ByteNullable.From_DateTime_AsObject: Job-TJIRAH(Toolchain=.NET Core 3.0)
  ConvertTo_ByteNullable.From_DateTime_AsObject: Job-HBFVIR(Toolchain=net461)
  ConvertTo_ByteNullable.From_DateTime_AsObject: Job-YRWWQX(Toolchain=net472)
  ConvertTo_ByteNullable.From_DateTime_Nullable_WithValue_AsObject: Job-LRKCAO(Toolchain=.NET Core 2.0)
  ConvertTo_ByteNullable.From_DateTime_Nullable_WithValue_AsObject: Job-VAJWLV(Toolchain=.NET Core 2.2)
  ConvertTo_ByteNullable.From_DateTime_Nullable_WithValue_AsObject: Job-TJIRAH(Toolchain=.NET Core 3.0)
  ConvertTo_ByteNullable.From_DateTime_Nullable_WithValue_AsObject: Job-HBFVIR(Toolchain=net461)
  ConvertTo_ByteNullable.From_DateTime_Nullable_WithValue_AsObject: Job-YRWWQX(Toolchain=net472)
  ConvertTo_ByteNullable.From_String_Empty_AsObject: Job-LRKCAO(Toolchain=.NET Core 2.0)
  ConvertTo_ByteNullable.From_String_Empty_AsObject: Job-VAJWLV(Toolchain=.NET Core 2.2)
  ConvertTo_ByteNullable.From_String_Empty_AsObject: Job-TJIRAH(Toolchain=.NET Core 3.0)
  ConvertTo_ByteNullable.From_String_Empty_AsObject: Job-HBFVIR(Toolchain=net461)
  ConvertTo_ByteNullable.From_String_Empty_AsObject: Job-YRWWQX(Toolchain=net472)
