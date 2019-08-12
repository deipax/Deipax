
BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.615 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-FWPOAF : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), 64bit RyuJIT
  Job-ZZPTUV : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-EOJUSV : .NET Core 3.0.0-preview6-27804-01 (CoreCLR 4.700.19.30373, CoreFX 4.700.19.30308), 64bit RyuJIT
  Job-KESODJ : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0
  Job-PJAXXB : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0


                                                Method |     Toolchain |       Mean |     Error |    StdDev |     Median | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------------------------------------------ |-------------- |-----------:|----------:|----------:|-----------:|------:|--------:|-------:|------:|------:|----------:|
                                             From_Bool | .NET Core 2.0 |  15.304 ns | 0.0312 ns | 0.0292 ns |  15.309 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 2.2 |  12.162 ns | 0.0521 ns | 0.0462 ns |  12.172 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 3.0 |   7.337 ns | 0.0308 ns | 0.0257 ns |   7.331 ns |  0.48 |    0.00 |      - |     - |     - |         - |
                                             From_Bool |        net461 |  14.178 ns | 0.0223 ns | 0.0209 ns |  14.180 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                             From_Bool |        net472 |  12.958 ns | 0.0652 ns | 0.0578 ns |  12.940 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                    From_Bool_AsObject | .NET Core 2.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 2.2 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 3.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net461 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net472 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                          From_Bool_Nullable_WithValue | .NET Core 2.0 |  13.391 ns | 0.0326 ns | 0.0305 ns |  13.387 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 2.2 |  11.026 ns | 0.0106 ns | 0.0083 ns |  11.024 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 3.0 |   7.405 ns | 0.0173 ns | 0.0162 ns |   7.402 ns |  0.55 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net461 |  14.566 ns | 0.1016 ns | 0.0950 ns |  14.541 ns |  1.09 |    0.01 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net472 |  12.958 ns | 0.0461 ns | 0.0385 ns |  12.944 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.2 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 3.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net461 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net472 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                            From_Bool_Nullable_NoValue | .NET Core 2.0 |  13.370 ns | 0.0205 ns | 0.0182 ns |  13.366 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 2.2 |  11.542 ns | 0.0161 ns | 0.0143 ns |  11.543 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 3.0 |   7.398 ns | 0.0105 ns | 0.0098 ns |   7.401 ns |  0.55 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net461 |  13.913 ns | 0.0251 ns | 0.0222 ns |  13.918 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net472 |  13.154 ns | 0.1335 ns | 0.1249 ns |  13.217 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.0 |  15.532 ns | 0.0322 ns | 0.0285 ns |  15.522 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.2 |  14.008 ns | 0.0165 ns | 0.0155 ns |  14.005 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 3.0 |  13.600 ns | 0.2940 ns | 0.4217 ns |  13.263 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net461 |  24.115 ns | 0.0368 ns | 0.0326 ns |  24.115 ns |  1.55 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net472 |  27.236 ns | 0.0421 ns | 0.0351 ns |  27.232 ns |  1.75 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                             From_Byte | .NET Core 2.0 |  14.650 ns | 0.0933 ns | 0.0873 ns |  14.608 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 2.2 |  11.005 ns | 0.0619 ns | 0.0549 ns |  11.018 ns |  0.75 |    0.01 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 3.0 |   8.478 ns | 0.1056 ns | 0.0987 ns |   8.436 ns |  0.58 |    0.01 |      - |     - |     - |         - |
                                             From_Byte |        net461 |  13.704 ns | 0.1526 ns | 0.1428 ns |  13.637 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                                             From_Byte |        net472 |  12.968 ns | 0.0274 ns | 0.0243 ns |  12.972 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                    From_Byte_AsObject | .NET Core 2.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 2.2 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 3.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net461 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net472 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                          From_Byte_Nullable_WithValue | .NET Core 2.0 |  16.601 ns | 0.0610 ns | 0.0571 ns |  16.574 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 2.2 |  10.586 ns | 0.0236 ns | 0.0209 ns |  10.591 ns |  0.64 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 3.0 |   7.905 ns | 0.0263 ns | 0.0233 ns |   7.903 ns |  0.48 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net461 |  14.042 ns | 0.1708 ns | 0.1598 ns |  13.967 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net472 |  15.198 ns | 0.0568 ns | 0.0504 ns |  15.178 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.2 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 3.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net461 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net472 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                            From_Byte_Nullable_NoValue | .NET Core 2.0 |  14.277 ns | 0.0245 ns | 0.0229 ns |  14.276 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 2.2 |  11.075 ns | 0.0213 ns | 0.0189 ns |  11.075 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 3.0 |   7.912 ns | 0.1800 ns | 0.1503 ns |   7.969 ns |  0.55 |    0.01 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net461 |  13.979 ns | 0.0421 ns | 0.0373 ns |  13.985 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net472 |  12.937 ns | 0.0157 ns | 0.0131 ns |  12.938 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.0 |  15.504 ns | 0.0337 ns | 0.0315 ns |  15.502 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.2 |  15.794 ns | 0.0153 ns | 0.0128 ns |  15.798 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 3.0 |  12.450 ns | 0.1793 ns | 0.1678 ns |  12.317 ns |  0.80 |    0.01 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net461 |  26.233 ns | 0.2199 ns | 0.2057 ns |  26.311 ns |  1.69 |    0.01 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net472 |  23.984 ns | 0.0461 ns | 0.0432 ns |  23.988 ns |  1.55 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                             From_Char | .NET Core 2.0 |  13.311 ns | 0.0199 ns | 0.0186 ns |  13.309 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Char | .NET Core 2.2 |  11.028 ns | 0.0102 ns | 0.0090 ns |  11.027 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                             From_Char | .NET Core 3.0 |   8.201 ns | 0.1879 ns | 0.2870 ns |   8.336 ns |  0.61 |    0.03 |      - |     - |     - |         - |
                                             From_Char |        net461 |  14.826 ns | 0.0278 ns | 0.0246 ns |  14.833 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                             From_Char |        net472 |  12.966 ns | 0.0145 ns | 0.0129 ns |  12.969 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                    From_Char_AsObject | .NET Core 2.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 2.2 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 3.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Char_AsObject |        net461 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Char_AsObject |        net472 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                          From_Char_Nullable_WithValue | .NET Core 2.0 |  13.468 ns | 0.0269 ns | 0.0252 ns |  13.461 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 2.2 |  10.725 ns | 0.0168 ns | 0.0157 ns |  10.728 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 3.0 |   7.563 ns | 0.0179 ns | 0.0159 ns |   7.562 ns |  0.56 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net461 |  13.930 ns | 0.1330 ns | 0.1244 ns |  13.997 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net472 |  13.388 ns | 0.0140 ns | 0.0131 ns |  13.390 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.2 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 3.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net461 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net472 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                            From_Char_Nullable_NoValue | .NET Core 2.0 |  13.338 ns | 0.0524 ns | 0.0490 ns |  13.318 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 2.2 |  11.079 ns | 0.0135 ns | 0.0119 ns |  11.077 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 3.0 |   7.562 ns | 0.0119 ns | 0.0105 ns |   7.560 ns |  0.57 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net461 |  13.762 ns | 0.0220 ns | 0.0205 ns |  13.768 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net472 |  13.379 ns | 0.0170 ns | 0.0159 ns |  13.382 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.0 |  15.664 ns | 0.0276 ns | 0.0258 ns |  15.662 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.2 |  14.002 ns | 0.0227 ns | 0.0212 ns |  13.996 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 3.0 |  14.266 ns | 0.3076 ns | 0.4605 ns |  14.004 ns |  0.93 |    0.03 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net461 |  24.614 ns | 0.1757 ns | 0.1644 ns |  24.672 ns |  1.57 |    0.01 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net472 |  26.822 ns | 0.0422 ns | 0.0395 ns |  26.822 ns |  1.71 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                         From_DateTime | .NET Core 2.0 |  14.447 ns | 0.0249 ns | 0.0233 ns |  14.451 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 2.2 |  12.070 ns | 0.0626 ns | 0.0586 ns |  12.081 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 3.0 |  11.536 ns | 0.1375 ns | 0.1286 ns |  11.476 ns |  0.80 |    0.01 |      - |     - |     - |         - |
                                         From_DateTime |        net461 |  15.627 ns | 0.0228 ns | 0.0190 ns |  15.629 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime |        net472 |  14.442 ns | 0.0385 ns | 0.0360 ns |  14.434 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                From_DateTime_AsObject | .NET Core 2.0 |  25.750 ns | 0.0508 ns | 0.0450 ns |  25.763 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 2.2 |  26.728 ns | 0.0292 ns | 0.0243 ns |  26.724 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 3.0 |  28.007 ns | 0.0548 ns | 0.0486 ns |  28.015 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net461 |  36.040 ns | 0.1214 ns | 0.1013 ns |  36.028 ns |  1.40 |    0.00 |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net472 |  36.641 ns | 0.0714 ns | 0.0668 ns |  36.634 ns |  1.42 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                      From_DateTime_Nullable_WithValue | .NET Core 2.0 |  12.924 ns | 0.0277 ns | 0.0246 ns |  12.924 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 2.2 |  11.651 ns | 0.0133 ns | 0.0111 ns |  11.647 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 3.0 |   9.891 ns | 0.2215 ns | 0.5045 ns |  10.061 ns |  0.72 |    0.06 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net461 |  13.440 ns | 0.0275 ns | 0.0230 ns |  13.446 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net472 |  13.948 ns | 0.0267 ns | 0.0250 ns |  13.948 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.0 |  25.743 ns | 0.0666 ns | 0.0623 ns |  25.732 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.2 |  27.687 ns | 0.0433 ns | 0.0405 ns |  27.696 ns |  1.08 |    0.00 |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 3.0 |  27.410 ns | 0.5618 ns | 0.5769 ns |  27.013 ns |  1.07 |    0.02 |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net461 |  36.584 ns | 0.3064 ns | 0.2866 ns |  36.712 ns |  1.42 |    0.01 |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net472 |  38.981 ns | 0.0532 ns | 0.0472 ns |  38.988 ns |  1.51 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                        From_DateTime_Nullable_NoValue | .NET Core 2.0 |  13.593 ns | 0.0814 ns | 0.0762 ns |  13.551 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 2.2 |  11.657 ns | 0.0134 ns | 0.0119 ns |  11.657 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 3.0 |   8.757 ns | 0.0210 ns | 0.0196 ns |   8.752 ns |  0.64 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net461 |  13.911 ns | 0.0171 ns | 0.0151 ns |  13.913 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net472 |  13.301 ns | 0.0290 ns | 0.0242 ns |  13.297 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.0 |  15.487 ns | 0.0481 ns | 0.0450 ns |  15.494 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.2 |  14.016 ns | 0.0276 ns | 0.0258 ns |  14.009 ns |  0.91 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 3.0 |  15.725 ns | 0.0181 ns | 0.0141 ns |  15.721 ns |  1.02 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net461 |  23.845 ns | 0.0416 ns | 0.0389 ns |  23.837 ns |  1.54 |    0.01 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net472 |  24.095 ns | 0.0508 ns | 0.0450 ns |  24.091 ns |  1.56 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                          From_Decimal | .NET Core 2.0 |  13.371 ns | 0.0350 ns | 0.0310 ns |  13.365 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 2.2 |  11.893 ns | 0.0454 ns | 0.0425 ns |  11.897 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 3.0 |   9.943 ns | 0.2233 ns | 0.5520 ns |  10.162 ns |  0.68 |    0.05 |      - |     - |     - |         - |
                                          From_Decimal |        net461 |  14.326 ns | 0.1056 ns | 0.0936 ns |  14.348 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                                          From_Decimal |        net472 |  12.953 ns | 0.0259 ns | 0.0230 ns |  12.951 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                 From_Decimal_AsObject | .NET Core 2.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 2.2 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 3.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net461 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net472 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                       From_Decimal_Nullable_WithValue | .NET Core 2.0 |  13.754 ns | 0.1557 ns | 0.1456 ns |  13.802 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 2.2 |  11.732 ns | 0.0173 ns | 0.0144 ns |  11.725 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 3.0 |   9.639 ns | 0.0844 ns | 0.0789 ns |   9.615 ns |  0.70 |    0.01 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net461 |  14.403 ns | 0.0172 ns | 0.0152 ns |  14.408 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net472 |  13.041 ns | 0.0205 ns | 0.0182 ns |  13.041 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.2 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 3.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net461 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net472 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                         From_Decimal_Nullable_NoValue | .NET Core 2.0 |  15.062 ns | 0.1117 ns | 0.1045 ns |  15.014 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 2.2 |  12.187 ns | 0.0209 ns | 0.0195 ns |  12.192 ns |  0.81 |    0.01 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 3.0 |  10.037 ns | 0.2188 ns | 0.2047 ns |  10.104 ns |  0.67 |    0.02 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net461 |  14.178 ns | 0.0332 ns | 0.0295 ns |  14.181 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net472 |  13.802 ns | 0.1626 ns | 0.1521 ns |  13.833 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.0 |  16.932 ns | 0.0404 ns | 0.0378 ns |  16.923 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.2 |  14.790 ns | 0.0219 ns | 0.0194 ns |  14.793 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 3.0 |  13.787 ns | 0.1053 ns | 0.0985 ns |  13.777 ns |  0.81 |    0.01 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net461 |  25.972 ns | 0.0479 ns | 0.0448 ns |  25.980 ns |  1.53 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net472 |  25.540 ns | 0.0439 ns | 0.0367 ns |  25.541 ns |  1.51 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                           From_Double | .NET Core 2.0 |  13.369 ns | 0.0256 ns | 0.0214 ns |  13.371 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 2.2 |  11.057 ns | 0.0106 ns | 0.0088 ns |  11.056 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 3.0 |   8.758 ns | 0.1945 ns | 0.2460 ns |   8.855 ns |  0.65 |    0.02 |      - |     - |     - |         - |
                                           From_Double |        net461 |  14.635 ns | 0.1559 ns | 0.1458 ns |  14.720 ns |  1.10 |    0.01 |      - |     - |     - |         - |
                                           From_Double |        net472 |  13.172 ns | 0.0359 ns | 0.0336 ns |  13.167 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                  From_Double_AsObject | .NET Core 2.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 2.2 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 3.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                  From_Double_AsObject |        net461 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                  From_Double_AsObject |        net472 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                        From_Double_Nullable_WithValue | .NET Core 2.0 |  13.945 ns | 0.1507 ns | 0.1410 ns |  13.959 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 2.2 |  11.641 ns | 0.0406 ns | 0.0360 ns |  11.634 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 3.0 |   9.114 ns | 0.0773 ns | 0.0603 ns |   9.141 ns |  0.65 |    0.01 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net461 |  14.108 ns | 0.0212 ns | 0.0198 ns |  14.104 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net472 |  12.947 ns | 0.0178 ns | 0.0148 ns |  12.948 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.2 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 3.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net461 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net472 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                          From_Double_Nullable_NoValue | .NET Core 2.0 |  13.338 ns | 0.0223 ns | 0.0209 ns |  13.337 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 2.2 |  12.140 ns | 0.0163 ns | 0.0153 ns |  12.137 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 3.0 |  11.510 ns | 0.2558 ns | 0.6227 ns |  11.711 ns |  0.81 |    0.08 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net461 |  14.176 ns | 0.1001 ns | 0.0936 ns |  14.150 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net472 |  12.991 ns | 0.0370 ns | 0.0328 ns |  12.987 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.0 |  15.693 ns | 0.0357 ns | 0.0279 ns |  15.691 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.2 |  14.949 ns | 0.0179 ns | 0.0158 ns |  14.950 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 3.0 |  13.722 ns | 0.1467 ns | 0.1372 ns |  13.778 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net461 |  25.357 ns | 0.0458 ns | 0.0429 ns |  25.373 ns |  1.62 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net472 |  23.809 ns | 0.0614 ns | 0.0513 ns |  23.811 ns |  1.52 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                            From_Short | .NET Core 2.0 |  13.496 ns | 0.1350 ns | 0.1054 ns |  13.537 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 2.2 |  11.014 ns | 0.0617 ns | 0.0547 ns |  11.026 ns |  0.82 |    0.01 |      - |     - |     - |         - |
                                            From_Short | .NET Core 3.0 |   7.316 ns | 0.0222 ns | 0.0207 ns |   7.311 ns |  0.54 |    0.00 |      - |     - |     - |         - |
                                            From_Short |        net461 |  13.781 ns | 0.1415 ns | 0.1323 ns |  13.866 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                                            From_Short |        net472 |  13.773 ns | 0.1505 ns | 0.1408 ns |  13.675 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                   From_Short_AsObject | .NET Core 2.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 2.2 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 3.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                   From_Short_AsObject |        net461 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                   From_Short_AsObject |        net472 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                         From_Short_Nullable_WithValue | .NET Core 2.0 |  13.119 ns | 0.0312 ns | 0.0291 ns |  13.113 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 2.2 |  11.144 ns | 0.0163 ns | 0.0152 ns |  11.146 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 3.0 |   7.677 ns | 0.0604 ns | 0.0504 ns |   7.687 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net461 |  14.316 ns | 0.0199 ns | 0.0176 ns |  14.315 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net472 |  13.398 ns | 0.0268 ns | 0.0251 ns |  13.398 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.2 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 3.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net461 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net472 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                           From_Short_Nullable_NoValue | .NET Core 2.0 |  13.073 ns | 0.0232 ns | 0.0217 ns |  13.072 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 2.2 |  10.726 ns | 0.0138 ns | 0.0129 ns |  10.730 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 3.0 |   8.393 ns | 0.0242 ns | 0.0226 ns |   8.390 ns |  0.64 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net461 |  13.755 ns | 0.0246 ns | 0.0231 ns |  13.765 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net472 |  13.367 ns | 0.0238 ns | 0.0222 ns |  13.363 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.0 |  15.719 ns | 0.0363 ns | 0.0322 ns |  15.714 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.2 |  14.155 ns | 0.0173 ns | 0.0153 ns |  14.156 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 3.0 |  14.962 ns | 0.0954 ns | 0.0796 ns |  14.981 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net461 |  25.699 ns | 0.2175 ns | 0.2034 ns |  25.773 ns |  1.64 |    0.01 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net472 |  25.487 ns | 0.0316 ns | 0.0280 ns |  25.484 ns |  1.62 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                              From_Int | .NET Core 2.0 |  14.801 ns | 0.0234 ns | 0.0183 ns |  14.800 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 2.2 |  10.958 ns | 0.0555 ns | 0.0519 ns |  10.970 ns |  0.74 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 3.0 |   7.555 ns | 0.0191 ns | 0.0179 ns |   7.551 ns |  0.51 |    0.00 |      - |     - |     - |         - |
                                              From_Int |        net461 |  13.769 ns | 0.0295 ns | 0.0262 ns |  13.773 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                              From_Int |        net472 |  14.634 ns | 0.0169 ns | 0.0149 ns |  14.633 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                     From_Int_AsObject | .NET Core 2.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 2.2 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 3.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                     From_Int_AsObject |        net461 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                     From_Int_AsObject |        net472 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                           From_Int_Nullable_WithValue | .NET Core 2.0 |  13.143 ns | 0.0251 ns | 0.0223 ns |  13.145 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 2.2 |  10.736 ns | 0.0276 ns | 0.0231 ns |  10.744 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 3.0 |   7.810 ns | 0.1060 ns | 0.0992 ns |   7.862 ns |  0.59 |    0.01 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net461 |  15.485 ns | 0.0293 ns | 0.0260 ns |  15.488 ns |  1.18 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net472 |  15.688 ns | 0.0188 ns | 0.0176 ns |  15.686 ns |  1.19 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.2 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 3.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net461 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net472 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                             From_Int_Nullable_NoValue | .NET Core 2.0 |  13.121 ns | 0.0291 ns | 0.0272 ns |  13.129 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 2.2 |  11.150 ns | 0.0355 ns | 0.0315 ns |  11.155 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 3.0 |   7.874 ns | 0.0197 ns | 0.0175 ns |   7.880 ns |  0.60 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net461 |  13.783 ns | 0.0318 ns | 0.0281 ns |  13.780 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net472 |  13.404 ns | 0.0318 ns | 0.0298 ns |  13.399 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.0 |  18.103 ns | 0.0527 ns | 0.0493 ns |  18.096 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.2 |  14.132 ns | 0.0305 ns | 0.0255 ns |  14.135 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 3.0 |  13.783 ns | 0.0142 ns | 0.0119 ns |  13.780 ns |  0.76 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net461 |  24.090 ns | 0.0390 ns | 0.0346 ns |  24.100 ns |  1.33 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net472 |  26.897 ns | 0.0298 ns | 0.0264 ns |  26.898 ns |  1.49 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                             From_Long | .NET Core 2.0 |  15.410 ns | 0.1003 ns | 0.0938 ns |  15.427 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Long | .NET Core 2.2 |  10.762 ns | 0.0168 ns | 0.0131 ns |  10.764 ns |  0.70 |    0.00 |      - |     - |     - |         - |
                                             From_Long | .NET Core 3.0 |   8.508 ns | 0.0418 ns | 0.0371 ns |   8.511 ns |  0.55 |    0.00 |      - |     - |     - |         - |
                                             From_Long |        net461 |  13.886 ns | 0.0219 ns | 0.0205 ns |  13.887 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                                             From_Long |        net472 |  13.371 ns | 0.0183 ns | 0.0162 ns |  13.373 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                    From_Long_AsObject | .NET Core 2.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 2.2 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 3.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Long_AsObject |        net461 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Long_AsObject |        net472 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                          From_Long_Nullable_WithValue | .NET Core 2.0 |  13.708 ns | 0.0378 ns | 0.0335 ns |  13.703 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 2.2 |  12.003 ns | 0.0256 ns | 0.0214 ns |  12.005 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 3.0 |   8.759 ns | 0.1962 ns | 0.2015 ns |   8.907 ns |  0.64 |    0.01 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net461 |  14.115 ns | 0.0286 ns | 0.0254 ns |  14.120 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net472 |  13.630 ns | 0.1303 ns | 0.1219 ns |  13.627 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.2 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 3.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net461 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net472 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                            From_Long_Nullable_NoValue | .NET Core 2.0 |  13.569 ns | 0.0259 ns | 0.0230 ns |  13.561 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 2.2 |  13.022 ns | 0.0157 ns | 0.0147 ns |  13.022 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 3.0 |   9.144 ns | 0.0809 ns | 0.0756 ns |   9.168 ns |  0.67 |    0.01 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net461 |  14.106 ns | 0.0274 ns | 0.0256 ns |  14.103 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net472 |  13.680 ns | 0.0351 ns | 0.0311 ns |  13.688 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.0 |  15.983 ns | 0.0937 ns | 0.0876 ns |  16.014 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.2 |  14.081 ns | 0.0219 ns | 0.0205 ns |  14.085 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 3.0 |  12.252 ns | 0.0291 ns | 0.0273 ns |  12.261 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net461 |  24.008 ns | 0.0296 ns | 0.0262 ns |  24.009 ns |  1.50 |    0.01 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net472 |  26.855 ns | 0.0195 ns | 0.0163 ns |  26.852 ns |  1.68 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                            From_SByte | .NET Core 2.0 |  13.357 ns | 0.0302 ns | 0.0268 ns |  13.360 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 2.2 |  10.806 ns | 0.0146 ns | 0.0114 ns |  10.804 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 3.0 |   8.308 ns | 0.0220 ns | 0.0184 ns |   8.304 ns |  0.62 |    0.00 |      - |     - |     - |         - |
                                            From_SByte |        net461 |  15.426 ns | 0.0425 ns | 0.0355 ns |  15.436 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                                            From_SByte |        net472 |  14.071 ns | 0.0792 ns | 0.0702 ns |  14.061 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                   From_SByte_AsObject | .NET Core 2.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 2.2 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 3.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net461 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net472 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                         From_SByte_Nullable_WithValue | .NET Core 2.0 |  15.290 ns | 0.1038 ns | 0.0810 ns |  15.313 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 2.2 |  11.327 ns | 0.0256 ns | 0.0213 ns |  11.322 ns |  0.74 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 3.0 |   7.467 ns | 0.1106 ns | 0.1035 ns |   7.407 ns |  0.49 |    0.01 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net461 |  13.960 ns | 0.0486 ns | 0.0431 ns |  13.956 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net472 |  13.862 ns | 0.0155 ns | 0.0138 ns |  13.861 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.2 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 3.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net461 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net472 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                           From_SByte_Nullable_NoValue | .NET Core 2.0 |  13.389 ns | 0.0285 ns | 0.0267 ns |  13.384 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 2.2 |  11.038 ns | 0.0140 ns | 0.0131 ns |  11.038 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 3.0 |   8.175 ns | 0.3123 ns | 0.3207 ns |   8.021 ns |  0.61 |    0.02 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net461 |  13.938 ns | 0.0162 ns | 0.0151 ns |  13.941 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net472 |  14.317 ns | 0.0170 ns | 0.0150 ns |  14.318 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.0 |  15.967 ns | 0.0676 ns | 0.0565 ns |  15.980 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.2 |  14.042 ns | 0.0302 ns | 0.0282 ns |  14.044 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 3.0 |  14.117 ns | 0.8078 ns | 1.5369 ns |  13.272 ns |  1.02 |    0.08 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net461 |  23.758 ns | 0.0444 ns | 0.0393 ns |  23.766 ns |  1.49 |    0.01 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net472 |  23.993 ns | 0.0338 ns | 0.0299 ns |  23.990 ns |  1.50 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                            From_Float | .NET Core 2.0 |  13.914 ns | 0.0416 ns | 0.0389 ns |  13.915 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 2.2 |  10.900 ns | 0.0713 ns | 0.0667 ns |  10.866 ns |  0.78 |    0.01 |      - |     - |     - |         - |
                                            From_Float | .NET Core 3.0 |   9.018 ns | 0.1170 ns | 0.1095 ns |   9.075 ns |  0.65 |    0.01 |      - |     - |     - |         - |
                                            From_Float |        net461 |  14.781 ns | 0.0527 ns | 0.0493 ns |  14.786 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                                            From_Float |        net472 |  13.142 ns | 0.0231 ns | 0.0193 ns |  13.140 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                   From_Float_AsObject | .NET Core 2.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 2.2 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 3.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                   From_Float_AsObject |        net461 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                   From_Float_AsObject |        net472 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                         From_Float_Nullable_WithValue | .NET Core 2.0 |  13.401 ns | 0.0691 ns | 0.0646 ns |  13.386 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 2.2 |  12.539 ns | 0.0124 ns | 0.0110 ns |  12.536 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 3.0 |   7.830 ns | 0.0227 ns | 0.0202 ns |   7.831 ns |  0.58 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net461 |  13.759 ns | 0.0124 ns | 0.0116 ns |  13.757 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net472 |  14.032 ns | 0.0227 ns | 0.0212 ns |  14.030 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.2 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 3.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net461 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net472 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                           From_Float_Nullable_NoValue | .NET Core 2.0 |  14.522 ns | 0.0336 ns | 0.0314 ns |  14.521 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 2.2 |  10.724 ns | 0.0111 ns | 0.0104 ns |  10.727 ns |  0.74 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 3.0 |   7.719 ns | 0.0604 ns | 0.0505 ns |   7.727 ns |  0.53 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net461 |  13.838 ns | 0.0232 ns | 0.0217 ns |  13.839 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net472 |  13.365 ns | 0.0178 ns | 0.0167 ns |  13.362 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.0 |  15.499 ns | 0.0216 ns | 0.0202 ns |  15.501 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.2 |  14.964 ns | 0.0448 ns | 0.0420 ns |  14.962 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 3.0 |  13.625 ns | 0.2950 ns | 0.4847 ns |  13.287 ns |  0.91 |    0.02 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net461 |  24.207 ns | 0.0345 ns | 0.0323 ns |  24.209 ns |  1.56 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net472 |  24.025 ns | 0.0553 ns | 0.0517 ns |  24.039 ns |  1.55 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                           From_String | .NET Core 2.0 | 505.657 ns | 1.1585 ns | 1.0837 ns | 505.569 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 2.2 | 439.997 ns | 0.9961 ns | 0.8318 ns | 439.801 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 3.0 | 402.757 ns | 1.0075 ns | 0.8931 ns | 402.851 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                           From_String |        net461 | 789.265 ns | 1.0758 ns | 0.8984 ns | 789.066 ns |  1.56 |    0.00 |      - |     - |     - |         - |
                                           From_String |        net472 | 786.662 ns | 1.4034 ns | 1.1719 ns | 786.484 ns |  1.56 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                  From_String_AsObject | .NET Core 2.0 | 511.759 ns | 1.3562 ns | 1.2022 ns | 511.765 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 2.2 | 449.444 ns | 0.4946 ns | 0.4385 ns | 449.416 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 3.0 | 418.033 ns | 2.5189 ns | 2.3562 ns | 417.747 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject |        net461 | 797.607 ns | 1.2045 ns | 1.1266 ns | 797.783 ns |  1.56 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject |        net472 | 794.670 ns | 1.0403 ns | 0.8687 ns | 794.495 ns |  1.55 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                      From_String_Null | .NET Core 2.0 |  14.158 ns | 0.0201 ns | 0.0168 ns |  14.160 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 2.2 |  12.900 ns | 0.0143 ns | 0.0119 ns |  12.901 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 3.0 |  12.638 ns | 0.4197 ns | 0.5603 ns |  12.398 ns |  0.91 |    0.05 |      - |     - |     - |         - |
                                      From_String_Null |        net461 |  22.084 ns | 0.0348 ns | 0.0326 ns |  22.081 ns |  1.56 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null |        net472 |  21.943 ns | 0.0480 ns | 0.0449 ns |  21.941 ns |  1.55 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                             From_String_Null_AsObject | .NET Core 2.0 |  15.542 ns | 0.0413 ns | 0.0366 ns |  15.535 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 2.2 |  14.003 ns | 0.0140 ns | 0.0109 ns |  14.003 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 3.0 |  13.757 ns | 0.5835 ns | 0.8554 ns |  13.295 ns |  0.92 |    0.06 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net461 |  24.334 ns | 0.0955 ns | 0.0893 ns |  24.304 ns |  1.57 |    0.01 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net472 |  25.528 ns | 0.0200 ns | 0.0187 ns |  25.523 ns |  1.64 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                     From_String_Empty | .NET Core 2.0 |  13.719 ns | 0.1347 ns | 0.1260 ns |  13.652 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 2.2 |  12.449 ns | 0.0391 ns | 0.0347 ns |  12.436 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 3.0 |  12.254 ns | 0.1169 ns | 0.1094 ns |  12.193 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                                     From_String_Empty |        net461 |  22.845 ns | 0.0258 ns | 0.0215 ns |  22.842 ns |  1.67 |    0.01 |      - |     - |     - |         - |
                                     From_String_Empty |        net472 |  24.335 ns | 0.0618 ns | 0.0548 ns |  24.316 ns |  1.77 |    0.02 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                            From_String_Empty_AsObject | .NET Core 2.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 2.2 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 3.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net461 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net472 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                           From_UShort | .NET Core 2.0 |  13.331 ns | 0.0221 ns | 0.0207 ns |  13.334 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 2.2 |  10.829 ns | 0.0132 ns | 0.0117 ns |  10.828 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 3.0 |   8.073 ns | 0.1450 ns | 0.1357 ns |   8.153 ns |  0.61 |    0.01 |      - |     - |     - |         - |
                                           From_UShort |        net461 |  14.150 ns | 0.0322 ns | 0.0285 ns |  14.157 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                           From_UShort |        net472 |  14.232 ns | 0.0250 ns | 0.0222 ns |  14.226 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                  From_UShort_AsObject | .NET Core 2.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 2.2 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 3.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net461 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net472 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                        From_UShort_Nullable_WithValue | .NET Core 2.0 |  13.086 ns | 0.0110 ns | 0.0103 ns |  13.088 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 2.2 |  12.235 ns | 0.0998 ns | 0.0934 ns |  12.185 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 3.0 |   7.664 ns | 0.1036 ns | 0.0969 ns |   7.697 ns |  0.59 |    0.01 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net461 |  13.906 ns | 0.1487 ns | 0.1391 ns |  13.979 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net472 |  13.372 ns | 0.0171 ns | 0.0152 ns |  13.371 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.2 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 3.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net461 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net472 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                          From_UShort_Nullable_NoValue | .NET Core 2.0 |  13.124 ns | 0.0176 ns | 0.0156 ns |  13.124 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 2.2 |  11.586 ns | 0.0218 ns | 0.0193 ns |  11.590 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 3.0 |   7.867 ns | 0.0232 ns | 0.0217 ns |   7.864 ns |  0.60 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net461 |  13.770 ns | 0.0226 ns | 0.0200 ns |  13.765 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net472 |  13.411 ns | 0.0128 ns | 0.0113 ns |  13.409 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.0 |  15.498 ns | 0.0256 ns | 0.0239 ns |  15.497 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.2 |  14.051 ns | 0.0643 ns | 0.0601 ns |  14.025 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 3.0 |  13.440 ns | 0.1331 ns | 0.1245 ns |  13.415 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net461 |  24.455 ns | 0.2078 ns | 0.1944 ns |  24.544 ns |  1.58 |    0.01 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net472 |  23.797 ns | 0.0359 ns | 0.0336 ns |  23.802 ns |  1.54 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                             From_UInt | .NET Core 2.0 |  14.088 ns | 0.0250 ns | 0.0234 ns |  14.088 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 2.2 |  10.784 ns | 0.0170 ns | 0.0159 ns |  10.783 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 3.0 |   7.855 ns | 0.0199 ns | 0.0177 ns |   7.858 ns |  0.56 |    0.00 |      - |     - |     - |         - |
                                             From_UInt |        net461 |  13.782 ns | 0.0305 ns | 0.0254 ns |  13.787 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                             From_UInt |        net472 |  13.950 ns | 0.0264 ns | 0.0234 ns |  13.954 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                    From_UInt_AsObject | .NET Core 2.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 2.2 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 3.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net461 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net472 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                          From_UInt_Nullable_WithValue | .NET Core 2.0 |  14.508 ns | 0.0169 ns | 0.0158 ns |  14.509 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 2.2 |  11.765 ns | 0.0844 ns | 0.0748 ns |  11.791 ns |  0.81 |    0.01 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 3.0 |   7.936 ns | 0.1086 ns | 0.1016 ns |   7.874 ns |  0.55 |    0.01 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net461 |  13.873 ns | 0.1609 ns | 0.1505 ns |  13.798 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net472 |  13.646 ns | 0.0985 ns | 0.0922 ns |  13.676 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.2 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 3.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net461 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net472 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                            From_UInt_Nullable_NoValue | .NET Core 2.0 |  15.370 ns | 0.0218 ns | 0.0182 ns |  15.367 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 2.2 |  10.726 ns | 0.0138 ns | 0.0115 ns |  10.724 ns |  0.70 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 3.0 |   8.378 ns | 0.0304 ns | 0.0269 ns |   8.373 ns |  0.55 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net461 |  13.871 ns | 0.1710 ns | 0.1599 ns |  13.993 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net472 |  13.414 ns | 0.0241 ns | 0.0226 ns |  13.413 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.0 |  17.146 ns | 0.0163 ns | 0.0152 ns |  17.148 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.2 |  14.679 ns | 0.0581 ns | 0.0544 ns |  14.695 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 3.0 |  13.360 ns | 0.1216 ns | 0.1137 ns |  13.296 ns |  0.78 |    0.01 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net461 |  24.103 ns | 0.0803 ns | 0.0712 ns |  24.079 ns |  1.41 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net472 |  24.349 ns | 0.2262 ns | 0.2116 ns |  24.433 ns |  1.42 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                            From_ULong | .NET Core 2.0 |  13.713 ns | 0.0317 ns | 0.0281 ns |  13.713 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 2.2 |  10.805 ns | 0.0235 ns | 0.0220 ns |  10.802 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 3.0 |   7.852 ns | 0.0149 ns | 0.0139 ns |   7.847 ns |  0.57 |    0.00 |      - |     - |     - |         - |
                                            From_ULong |        net461 |  13.819 ns | 0.0245 ns | 0.0204 ns |  13.822 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                            From_ULong |        net472 |  14.842 ns | 0.0488 ns | 0.0408 ns |  14.838 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                   From_ULong_AsObject | .NET Core 2.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 2.2 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 3.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net461 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net472 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                         From_ULong_Nullable_WithValue | .NET Core 2.0 |  13.355 ns | 0.0112 ns | 0.0100 ns |  13.359 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 2.2 |  11.810 ns | 0.0125 ns | 0.0105 ns |  11.809 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 3.0 |   9.745 ns | 0.1499 ns | 0.1251 ns |   9.750 ns |  0.73 |    0.01 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net461 |  14.660 ns | 0.0894 ns | 0.0836 ns |  14.612 ns |  1.10 |    0.01 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net472 |  12.941 ns | 0.0286 ns | 0.0239 ns |  12.935 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.2 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 3.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net461 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net472 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                           From_ULong_Nullable_NoValue | .NET Core 2.0 |  14.003 ns | 0.0311 ns | 0.0260 ns |  14.001 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 2.2 |  11.593 ns | 0.0208 ns | 0.0184 ns |  11.598 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 3.0 |  10.092 ns | 0.2192 ns | 0.2251 ns |  10.175 ns |  0.72 |    0.02 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net461 |  14.177 ns | 0.1603 ns | 0.1499 ns |  14.081 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net472 |  12.999 ns | 0.0482 ns | 0.0450 ns |  12.984 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.0 |  15.492 ns | 0.0312 ns | 0.0260 ns |  15.487 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.2 |  14.116 ns | 0.0144 ns | 0.0134 ns |  14.118 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 3.0 |  13.633 ns | 0.1656 ns | 0.1549 ns |  13.674 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net461 |  24.136 ns | 0.0380 ns | 0.0355 ns |  24.138 ns |  1.56 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net472 |  27.432 ns | 0.0210 ns | 0.0186 ns |  27.427 ns |  1.77 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                       From_NullObject | .NET Core 2.0 |  15.665 ns | 0.0276 ns | 0.0259 ns |  15.669 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 2.2 |  14.950 ns | 0.0398 ns | 0.0353 ns |  14.957 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 3.0 |  12.485 ns | 0.1889 ns | 0.1767 ns |  12.616 ns |  0.80 |    0.01 |      - |     - |     - |         - |
                                       From_NullObject |        net461 |  25.390 ns | 0.0418 ns | 0.0349 ns |  25.403 ns |  1.62 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject |        net472 |  24.100 ns | 0.0326 ns | 0.0305 ns |  24.103 ns |  1.54 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                           From_DBNull | .NET Core 2.0 |  14.348 ns | 0.0283 ns | 0.0265 ns |  14.352 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 2.2 |  10.388 ns | 0.0192 ns | 0.0150 ns |  10.386 ns |  0.72 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 3.0 |  12.069 ns | 0.0691 ns | 0.0646 ns |  12.085 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                                           From_DBNull |        net461 |  14.572 ns | 0.1559 ns | 0.1458 ns |  14.661 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                                           From_DBNull |        net472 |  13.901 ns | 0.0282 ns | 0.0263 ns |  13.907 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                  From_DBNull_AsObject | .NET Core 2.0 |  15.758 ns | 0.0977 ns | 0.0866 ns |  15.788 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 2.2 |  15.394 ns | 0.0180 ns | 0.0168 ns |  15.391 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 3.0 |  13.508 ns | 0.1997 ns | 0.1868 ns |  13.640 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net461 |  24.048 ns | 0.1269 ns | 0.1187 ns |  23.987 ns |  1.53 |    0.01 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net472 |  24.078 ns | 0.0487 ns | 0.0406 ns |  24.085 ns |  1.53 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                 From_ConvertibleClass | .NET Core 2.0 |  20.928 ns | 0.0493 ns | 0.0461 ns |  20.953 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 2.2 |  16.696 ns | 0.0398 ns | 0.0353 ns |  16.691 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 3.0 |  16.646 ns | 0.0899 ns | 0.0841 ns |  16.612 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net461 |  28.324 ns | 0.0336 ns | 0.0298 ns |  28.329 ns |  1.35 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net472 |  29.180 ns | 0.0423 ns | 0.0353 ns |  29.185 ns |  1.39 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                        From_ConvertibleClass_AsObject | .NET Core 2.0 |  21.442 ns | 0.0431 ns | 0.0403 ns |  21.436 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 2.2 |  19.491 ns | 0.0172 ns | 0.0161 ns |  19.495 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 3.0 |  20.437 ns | 0.1117 ns | 0.0990 ns |  20.472 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net461 |  28.838 ns | 0.0391 ns | 0.0347 ns |  28.840 ns |  1.34 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net472 |  29.963 ns | 0.0368 ns | 0.0327 ns |  29.965 ns |  1.40 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                         From_ConvertibleClass_NoValue | .NET Core 2.0 |  16.315 ns | 0.0188 ns | 0.0176 ns |  16.314 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 2.2 |  13.718 ns | 0.0236 ns | 0.0197 ns |  13.713 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 3.0 |  11.972 ns | 0.0434 ns | 0.0339 ns |  11.975 ns |  0.73 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net461 |  25.345 ns | 0.0575 ns | 0.0538 ns |  25.338 ns |  1.55 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net472 |  26.827 ns | 0.0538 ns | 0.0503 ns |  26.811 ns |  1.64 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.0 |  15.500 ns | 0.0257 ns | 0.0240 ns |  15.501 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.2 |  13.843 ns | 0.0289 ns | 0.0256 ns |  13.838 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 3.0 |  14.420 ns | 0.0255 ns | 0.0239 ns |  14.423 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net461 |  23.985 ns | 0.0255 ns | 0.0238 ns |  23.989 ns |  1.55 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net472 |  24.085 ns | 0.0603 ns | 0.0534 ns |  24.091 ns |  1.55 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                              From_NonConvertibleClass | .NET Core 2.0 |  14.083 ns | 0.0163 ns | 0.0145 ns |  14.084 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 2.2 |  12.248 ns | 0.0173 ns | 0.0162 ns |  12.255 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 3.0 |  13.851 ns | 0.4361 ns | 0.4079 ns |  13.661 ns |  0.98 |    0.03 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net461 |  17.094 ns | 0.1510 ns | 0.1412 ns |  17.177 ns |  1.22 |    0.01 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net472 |  15.879 ns | 0.0241 ns | 0.0214 ns |  15.878 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                     From_NonConvertibleClass_AsObject | .NET Core 2.0 |  17.392 ns | 0.0283 ns | 0.0236 ns |  17.379 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 2.2 |  17.780 ns | 0.0606 ns | 0.0506 ns |  17.762 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 3.0 |  16.505 ns | 0.3566 ns | 0.8815 ns |  16.830 ns |  0.86 |    0.07 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net461 |  26.565 ns | 0.0258 ns | 0.0202 ns |  26.566 ns |  1.53 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net472 |  29.721 ns | 0.0447 ns | 0.0418 ns |  29.717 ns |  1.71 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                      From_NonConvertibleClass_NoValue | .NET Core 2.0 |  14.325 ns | 0.0124 ns | 0.0110 ns |  14.327 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 2.2 |  12.270 ns | 0.0398 ns | 0.0353 ns |  12.269 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 3.0 |  11.010 ns | 0.0229 ns | 0.0203 ns |  11.012 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net461 |  15.990 ns | 0.0206 ns | 0.0193 ns |  15.995 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net472 |  15.894 ns | 0.0348 ns | 0.0326 ns |  15.899 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.0 |  15.544 ns | 0.0391 ns | 0.0327 ns |  15.552 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.2 |  14.264 ns | 0.0840 ns | 0.0786 ns |  14.246 ns |  0.92 |    0.01 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 3.0 |  14.834 ns | 0.0543 ns | 0.0482 ns |  14.836 ns |  0.95 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net461 |  24.644 ns | 0.0666 ns | 0.0623 ns |  24.653 ns |  1.59 |    0.01 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net472 |  24.001 ns | 0.0290 ns | 0.0272 ns |  23.997 ns |  1.54 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                From_ConvertibleStruct | .NET Core 2.0 |  24.591 ns | 0.0328 ns | 0.0307 ns |  24.594 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 2.2 |  18.251 ns | 0.0290 ns | 0.0242 ns |  18.259 ns |  0.74 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 3.0 |  16.200 ns | 0.2812 ns | 0.2630 ns |  16.396 ns |  0.66 |    0.01 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net461 |  29.430 ns | 0.0747 ns | 0.0662 ns |  29.418 ns |  1.20 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net472 |  27.425 ns | 0.0513 ns | 0.0455 ns |  27.397 ns |  1.12 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                       From_ConvertibleStruct_AsObject | .NET Core 2.0 |  21.927 ns | 0.0451 ns | 0.0422 ns |  21.902 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 2.2 |  19.730 ns | 0.0287 ns | 0.0268 ns |  19.731 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 3.0 |  20.635 ns | 0.0255 ns | 0.0213 ns |  20.639 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net461 |  30.176 ns | 0.0513 ns | 0.0480 ns |  30.174 ns |  1.38 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net472 |  31.612 ns | 0.0451 ns | 0.0400 ns |  31.612 ns |  1.44 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.0 |  24.016 ns | 0.1227 ns | 0.1148 ns |  23.973 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.2 |  18.823 ns | 0.0443 ns | 0.0393 ns |  18.814 ns |  0.78 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 3.0 |  17.030 ns | 0.5478 ns | 0.8689 ns |  16.580 ns |  0.73 |    0.04 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net461 |  30.022 ns | 0.1939 ns | 0.1719 ns |  30.063 ns |  1.25 |    0.01 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net472 |  28.865 ns | 0.0838 ns | 0.0784 ns |  28.877 ns |  1.20 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 |  21.952 ns | 0.0302 ns | 0.0282 ns |  21.941 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 |  20.280 ns | 0.1119 ns | 0.0934 ns |  20.299 ns |  0.92 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 |  19.403 ns | 0.0966 ns | 0.0904 ns |  19.411 ns |  0.88 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net461 |  31.960 ns | 0.0969 ns | 0.0907 ns |  31.930 ns |  1.46 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net472 |  30.345 ns | 0.0685 ns | 0.0640 ns |  30.363 ns |  1.38 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.0 |  15.165 ns | 0.0588 ns | 0.0550 ns |  15.180 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.2 |  12.843 ns | 0.0393 ns | 0.0349 ns |  12.832 ns |  0.85 |    0.01 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 3.0 |   9.095 ns | 0.0175 ns | 0.0164 ns |   9.091 ns |  0.60 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net461 |  26.471 ns | 0.0420 ns | 0.0393 ns |  26.474 ns |  1.75 |    0.01 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net472 |  20.232 ns | 0.0357 ns | 0.0334 ns |  20.239 ns |  1.33 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 |  17.322 ns | 0.0289 ns | 0.0242 ns |  17.318 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 |  13.908 ns | 0.0267 ns | 0.0249 ns |  13.911 ns |  0.80 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 |  13.550 ns | 0.2244 ns | 0.2099 ns |  13.477 ns |  0.78 |    0.01 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net461 |  25.839 ns | 0.1775 ns | 0.1661 ns |  25.904 ns |  1.49 |    0.01 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net472 |  24.057 ns | 0.1003 ns | 0.0889 ns |  24.028 ns |  1.39 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                             From_NonConvertibleStruct | .NET Core 2.0 |  15.178 ns | 0.0227 ns | 0.0213 ns |  15.183 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 2.2 |  12.047 ns | 0.0159 ns | 0.0124 ns |  12.052 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 3.0 |   7.406 ns | 0.0238 ns | 0.0198 ns |   7.409 ns |  0.49 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net461 |  16.005 ns | 0.0257 ns | 0.0228 ns |  16.012 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net472 |  13.625 ns | 0.0235 ns | 0.0208 ns |  13.622 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.0 |  18.244 ns | 0.0360 ns | 0.0319 ns |  18.242 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.2 |  15.317 ns | 0.0455 ns | 0.0426 ns |  15.318 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 3.0 |  18.517 ns | 0.3938 ns | 1.0647 ns |  18.891 ns |  0.91 |    0.08 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net461 |  25.081 ns | 0.0354 ns | 0.0314 ns |  25.078 ns |  1.37 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net472 |  25.519 ns | 0.0345 ns | 0.0323 ns |  25.514 ns |  1.40 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.0 |  15.629 ns | 0.0361 ns | 0.0320 ns |  15.622 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.2 |  11.879 ns | 0.0240 ns | 0.0200 ns |  11.877 ns |  0.76 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 3.0 |   7.432 ns | 0.0640 ns | 0.0598 ns |   7.402 ns |  0.48 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net461 |  14.236 ns | 0.0167 ns | 0.0156 ns |  14.236 ns |  0.91 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net472 |  13.607 ns | 0.0287 ns | 0.0268 ns |  13.612 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 |  17.600 ns | 0.1683 ns | 0.1492 ns |  17.543 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 |  15.564 ns | 0.1240 ns | 0.0968 ns |  15.604 ns |  0.89 |    0.01 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 |  14.752 ns | 0.0250 ns | 0.0221 ns |  14.753 ns |  0.84 |    0.01 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net461 |  27.147 ns | 0.0333 ns | 0.0278 ns |  27.144 ns |  1.54 |    0.01 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net472 |  25.467 ns | 0.0345 ns | 0.0323 ns |  25.466 ns |  1.45 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.0 |  17.334 ns | 0.0157 ns | 0.0139 ns |  17.334 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.2 |  11.785 ns | 0.0278 ns | 0.0260 ns |  11.778 ns |  0.68 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 3.0 |   9.117 ns | 0.2076 ns | 0.4379 ns |   9.265 ns |  0.50 |    0.04 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net461 |  14.236 ns | 0.0568 ns | 0.0531 ns |  14.231 ns |  0.82 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net472 |  13.628 ns | 0.0343 ns | 0.0304 ns |  13.626 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 |  15.679 ns | 0.0251 ns | 0.0234 ns |  15.684 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 |  14.030 ns | 0.0346 ns | 0.0289 ns |  14.030 ns |  0.89 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 |  12.572 ns | 0.3948 ns | 0.4699 ns |  12.312 ns |  0.81 |    0.03 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net461 |  23.355 ns | 0.0278 ns | 0.0261 ns |  23.348 ns |  1.49 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net472 |  24.100 ns | 0.0229 ns | 0.0191 ns |  24.101 ns |  1.54 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                             From_Enum | .NET Core 2.0 |  13.172 ns | 0.0202 ns | 0.0158 ns |  13.172 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 2.2 |  11.982 ns | 0.0904 ns | 0.0846 ns |  11.959 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 3.0 |   8.939 ns | 0.0999 ns | 0.0935 ns |   8.926 ns |  0.68 |    0.01 |      - |     - |     - |         - |
                                             From_Enum |        net461 |  13.689 ns | 0.0365 ns | 0.0341 ns |  13.683 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                             From_Enum |        net472 |  13.391 ns | 0.0283 ns | 0.0265 ns |  13.389 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                    From_Enum_AsObject | .NET Core 2.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Enum_AsObject | .NET Core 2.2 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Enum_AsObject | .NET Core 3.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Enum_AsObject |        net461 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Enum_AsObject |        net472 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                          From_Enum_Nullable_WithValue | .NET Core 2.0 |  15.674 ns | 0.0240 ns | 0.0213 ns |  15.678 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 2.2 |  10.784 ns | 0.0288 ns | 0.0256 ns |  10.787 ns |  0.69 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 3.0 |   7.412 ns | 0.0199 ns | 0.0167 ns |   7.412 ns |  0.47 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net461 |  13.568 ns | 0.0294 ns | 0.0261 ns |  13.570 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net472 |  13.788 ns | 0.0202 ns | 0.0189 ns |  13.781 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.2 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 3.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                 From_Enum_Nullable_WithValue_AsObject |        net461 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                 From_Enum_Nullable_WithValue_AsObject |        net472 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                            From_Enum_Nullable_NoValue | .NET Core 2.0 |  14.587 ns | 0.0103 ns | 0.0096 ns |  14.589 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 2.2 |  11.219 ns | 0.2069 ns | 0.1936 ns |  11.260 ns |  0.77 |    0.01 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 3.0 |   7.416 ns | 0.0223 ns | 0.0209 ns |   7.415 ns |  0.51 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net461 |  14.223 ns | 0.0428 ns | 0.0400 ns |  14.214 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net472 |  13.408 ns | 0.0336 ns | 0.0281 ns |  13.412 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.0 |  16.089 ns | 0.0304 ns | 0.0285 ns |  16.089 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.2 |  16.226 ns | 0.1655 ns | 0.1548 ns |  16.258 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 3.0 |  14.106 ns | 0.1451 ns | 0.1358 ns |  14.194 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net461 |  23.890 ns | 0.0410 ns | 0.0384 ns |  23.891 ns |  1.48 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net472 |  24.120 ns | 0.0633 ns | 0.0561 ns |  24.117 ns |  1.50 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                      From_ParentClass | .NET Core 2.0 |  14.943 ns | 0.0264 ns | 0.0234 ns |  14.932 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 2.2 |  12.252 ns | 0.0115 ns | 0.0102 ns |  12.251 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 3.0 |  11.776 ns | 0.0239 ns | 0.0212 ns |  11.774 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass |        net461 |  15.546 ns | 0.1571 ns | 0.1470 ns |  15.642 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                      From_ParentClass |        net472 |  16.017 ns | 0.1196 ns | 0.1118 ns |  16.048 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                             From_ParentClass_AsObject | .NET Core 2.0 |  19.015 ns | 0.0146 ns | 0.0122 ns |  19.016 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 2.2 |  16.682 ns | 0.0340 ns | 0.0318 ns |  16.688 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 3.0 |  15.966 ns | 0.0544 ns | 0.0482 ns |  15.967 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net461 |  25.074 ns | 0.0391 ns | 0.0326 ns |  25.073 ns |  1.32 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net472 |  27.344 ns | 0.0826 ns | 0.0772 ns |  27.312 ns |  1.44 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                              From_ParentClass_NoValue | .NET Core 2.0 |  14.118 ns | 0.1068 ns | 0.0999 ns |  14.054 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 2.2 |  12.241 ns | 0.0183 ns | 0.0171 ns |  12.241 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 3.0 |  11.762 ns | 0.0207 ns | 0.0183 ns |  11.763 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net461 |  15.432 ns | 0.0192 ns | 0.0170 ns |  15.431 ns |  1.09 |    0.01 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net472 |  15.905 ns | 0.0320 ns | 0.0300 ns |  15.911 ns |  1.13 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.0 |  16.047 ns | 0.0370 ns | 0.0328 ns |  16.047 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.2 |  14.912 ns | 0.0253 ns | 0.0236 ns |  14.907 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 3.0 |  12.437 ns | 0.2345 ns | 0.2193 ns |  12.282 ns |  0.78 |    0.01 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net461 |  25.918 ns | 0.1507 ns | 0.1410 ns |  25.966 ns |  1.62 |    0.01 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net472 |  27.212 ns | 0.0421 ns | 0.0373 ns |  27.227 ns |  1.70 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                     From_ParentStruct | .NET Core 2.0 |  42.882 ns | 0.0620 ns | 0.0580 ns |  42.875 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 2.2 |  39.621 ns | 0.0389 ns | 0.0364 ns |  39.636 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 3.0 |  37.811 ns | 0.9727 ns | 1.8507 ns |  36.817 ns |  0.93 |    0.04 |      - |     - |     - |         - |
                                     From_ParentStruct |        net461 |  41.925 ns | 0.0612 ns | 0.0478 ns |  41.927 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct |        net472 |  39.503 ns | 0.0843 ns | 0.0789 ns |  39.481 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                            From_ParentStruct_AsObject | .NET Core 2.0 |  18.330 ns | 0.0239 ns | 0.0212 ns |  18.329 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 2.2 |  16.765 ns | 0.0385 ns | 0.0322 ns |  16.757 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 3.0 |  19.693 ns | 0.4651 ns | 1.3492 ns |  20.033 ns |  0.96 |    0.16 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net461 |  25.495 ns | 0.0226 ns | 0.0201 ns |  25.494 ns |  1.39 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net472 |  25.431 ns | 0.0192 ns | 0.0170 ns |  25.428 ns |  1.39 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.0 |  41.221 ns | 0.0408 ns | 0.0362 ns |  41.214 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.2 |  39.487 ns | 0.0727 ns | 0.0607 ns |  39.460 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 3.0 |  37.875 ns | 0.3371 ns | 0.3153 ns |  37.733 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue |        net461 |  48.935 ns | 0.4729 ns | 0.4424 ns |  49.157 ns |  1.19 |    0.01 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue |        net472 |  40.758 ns | 0.0775 ns | 0.0687 ns |  40.766 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.0 |  18.087 ns | 0.0995 ns | 0.0882 ns |  18.120 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.2 |  15.964 ns | 0.2321 ns | 0.2057 ns |  15.861 ns |  0.88 |    0.01 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 3.0 |  15.408 ns | 0.3313 ns | 0.5626 ns |  15.046 ns |  0.89 |    0.02 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net461 |  25.499 ns | 0.0587 ns | 0.0490 ns |  25.512 ns |  1.41 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net472 |  27.680 ns | 0.0269 ns | 0.0238 ns |  27.680 ns |  1.53 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.0 |  42.176 ns | 0.0402 ns | 0.0376 ns |  42.168 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.2 |  39.814 ns | 0.0684 ns | 0.0640 ns |  39.816 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 3.0 |  36.616 ns | 0.1207 ns | 0.1129 ns |  36.590 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net461 |  40.622 ns | 0.0663 ns | 0.0587 ns |  40.610 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net472 |  39.527 ns | 0.0929 ns | 0.0823 ns |  39.503 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.0 |  15.559 ns | 0.0308 ns | 0.0288 ns |  15.562 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.2 |  14.954 ns | 0.1733 ns | 0.1621 ns |  14.863 ns |  0.96 |    0.01 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 3.0 |  12.359 ns | 0.1701 ns | 0.1328 ns |  12.344 ns |  0.79 |    0.01 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net461 |  24.431 ns | 0.2154 ns | 0.2015 ns |  24.550 ns |  1.57 |    0.01 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net472 |  23.769 ns | 0.0445 ns | 0.0416 ns |  23.782 ns |  1.53 |    0.00 |      - |     - |     - |         - |

Benchmarks with issues:
  ConvertTo_DateTimeNullable.From_Bool_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_DateTimeNullable.From_Bool_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_DateTimeNullable.From_Bool_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_DateTimeNullable.From_Bool_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_DateTimeNullable.From_Bool_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_DateTimeNullable.From_Bool_Nullable_WithValue_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_DateTimeNullable.From_Bool_Nullable_WithValue_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_DateTimeNullable.From_Bool_Nullable_WithValue_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_DateTimeNullable.From_Bool_Nullable_WithValue_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_DateTimeNullable.From_Bool_Nullable_WithValue_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_DateTimeNullable.From_Byte_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_DateTimeNullable.From_Byte_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_DateTimeNullable.From_Byte_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_DateTimeNullable.From_Byte_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_DateTimeNullable.From_Byte_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_DateTimeNullable.From_Byte_Nullable_WithValue_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_DateTimeNullable.From_Byte_Nullable_WithValue_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_DateTimeNullable.From_Byte_Nullable_WithValue_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_DateTimeNullable.From_Byte_Nullable_WithValue_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_DateTimeNullable.From_Byte_Nullable_WithValue_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_DateTimeNullable.From_Char_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_DateTimeNullable.From_Char_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_DateTimeNullable.From_Char_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_DateTimeNullable.From_Char_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_DateTimeNullable.From_Char_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_DateTimeNullable.From_Char_Nullable_WithValue_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_DateTimeNullable.From_Char_Nullable_WithValue_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_DateTimeNullable.From_Char_Nullable_WithValue_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_DateTimeNullable.From_Char_Nullable_WithValue_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_DateTimeNullable.From_Char_Nullable_WithValue_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_DateTimeNullable.From_Decimal_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_DateTimeNullable.From_Decimal_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_DateTimeNullable.From_Decimal_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_DateTimeNullable.From_Decimal_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_DateTimeNullable.From_Decimal_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_DateTimeNullable.From_Decimal_Nullable_WithValue_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_DateTimeNullable.From_Decimal_Nullable_WithValue_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_DateTimeNullable.From_Decimal_Nullable_WithValue_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_DateTimeNullable.From_Decimal_Nullable_WithValue_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_DateTimeNullable.From_Decimal_Nullable_WithValue_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_DateTimeNullable.From_Double_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_DateTimeNullable.From_Double_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_DateTimeNullable.From_Double_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_DateTimeNullable.From_Double_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_DateTimeNullable.From_Double_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_DateTimeNullable.From_Double_Nullable_WithValue_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_DateTimeNullable.From_Double_Nullable_WithValue_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_DateTimeNullable.From_Double_Nullable_WithValue_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_DateTimeNullable.From_Double_Nullable_WithValue_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_DateTimeNullable.From_Double_Nullable_WithValue_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_DateTimeNullable.From_Short_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_DateTimeNullable.From_Short_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_DateTimeNullable.From_Short_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_DateTimeNullable.From_Short_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_DateTimeNullable.From_Short_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_DateTimeNullable.From_Short_Nullable_WithValue_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_DateTimeNullable.From_Short_Nullable_WithValue_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_DateTimeNullable.From_Short_Nullable_WithValue_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_DateTimeNullable.From_Short_Nullable_WithValue_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_DateTimeNullable.From_Short_Nullable_WithValue_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_DateTimeNullable.From_Int_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_DateTimeNullable.From_Int_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_DateTimeNullable.From_Int_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_DateTimeNullable.From_Int_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_DateTimeNullable.From_Int_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_DateTimeNullable.From_Int_Nullable_WithValue_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_DateTimeNullable.From_Int_Nullable_WithValue_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_DateTimeNullable.From_Int_Nullable_WithValue_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_DateTimeNullable.From_Int_Nullable_WithValue_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_DateTimeNullable.From_Int_Nullable_WithValue_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_DateTimeNullable.From_Long_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_DateTimeNullable.From_Long_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_DateTimeNullable.From_Long_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_DateTimeNullable.From_Long_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_DateTimeNullable.From_Long_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_DateTimeNullable.From_Long_Nullable_WithValue_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_DateTimeNullable.From_Long_Nullable_WithValue_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_DateTimeNullable.From_Long_Nullable_WithValue_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_DateTimeNullable.From_Long_Nullable_WithValue_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_DateTimeNullable.From_Long_Nullable_WithValue_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_DateTimeNullable.From_SByte_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_DateTimeNullable.From_SByte_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_DateTimeNullable.From_SByte_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_DateTimeNullable.From_SByte_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_DateTimeNullable.From_SByte_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_DateTimeNullable.From_SByte_Nullable_WithValue_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_DateTimeNullable.From_SByte_Nullable_WithValue_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_DateTimeNullable.From_SByte_Nullable_WithValue_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_DateTimeNullable.From_SByte_Nullable_WithValue_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_DateTimeNullable.From_SByte_Nullable_WithValue_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_DateTimeNullable.From_Float_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_DateTimeNullable.From_Float_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_DateTimeNullable.From_Float_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_DateTimeNullable.From_Float_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_DateTimeNullable.From_Float_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_DateTimeNullable.From_Float_Nullable_WithValue_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_DateTimeNullable.From_Float_Nullable_WithValue_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_DateTimeNullable.From_Float_Nullable_WithValue_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_DateTimeNullable.From_Float_Nullable_WithValue_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_DateTimeNullable.From_Float_Nullable_WithValue_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_DateTimeNullable.From_String_Empty_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_DateTimeNullable.From_String_Empty_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_DateTimeNullable.From_String_Empty_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_DateTimeNullable.From_String_Empty_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_DateTimeNullable.From_String_Empty_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_DateTimeNullable.From_UShort_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_DateTimeNullable.From_UShort_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_DateTimeNullable.From_UShort_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_DateTimeNullable.From_UShort_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_DateTimeNullable.From_UShort_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_DateTimeNullable.From_UShort_Nullable_WithValue_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_DateTimeNullable.From_UShort_Nullable_WithValue_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_DateTimeNullable.From_UShort_Nullable_WithValue_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_DateTimeNullable.From_UShort_Nullable_WithValue_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_DateTimeNullable.From_UShort_Nullable_WithValue_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_DateTimeNullable.From_UInt_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_DateTimeNullable.From_UInt_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_DateTimeNullable.From_UInt_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_DateTimeNullable.From_UInt_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_DateTimeNullable.From_UInt_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_DateTimeNullable.From_UInt_Nullable_WithValue_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_DateTimeNullable.From_UInt_Nullable_WithValue_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_DateTimeNullable.From_UInt_Nullable_WithValue_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_DateTimeNullable.From_UInt_Nullable_WithValue_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_DateTimeNullable.From_UInt_Nullable_WithValue_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_DateTimeNullable.From_ULong_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_DateTimeNullable.From_ULong_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_DateTimeNullable.From_ULong_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_DateTimeNullable.From_ULong_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_DateTimeNullable.From_ULong_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_DateTimeNullable.From_ULong_Nullable_WithValue_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_DateTimeNullable.From_ULong_Nullable_WithValue_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_DateTimeNullable.From_ULong_Nullable_WithValue_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_DateTimeNullable.From_ULong_Nullable_WithValue_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_DateTimeNullable.From_ULong_Nullable_WithValue_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_DateTimeNullable.From_Enum_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_DateTimeNullable.From_Enum_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_DateTimeNullable.From_Enum_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_DateTimeNullable.From_Enum_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_DateTimeNullable.From_Enum_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_DateTimeNullable.From_Enum_Nullable_WithValue_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_DateTimeNullable.From_Enum_Nullable_WithValue_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_DateTimeNullable.From_Enum_Nullable_WithValue_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_DateTimeNullable.From_Enum_Nullable_WithValue_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_DateTimeNullable.From_Enum_Nullable_WithValue_AsObject: Job-PJAXXB(Toolchain=net472)
