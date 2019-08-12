
BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.615 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-FWPOAF : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), 64bit RyuJIT
  Job-ZZPTUV : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-EOJUSV : .NET Core 3.0.0-preview6-27804-01 (CoreCLR 4.700.19.30373, CoreFX 4.700.19.30308), 64bit RyuJIT
  Job-KESODJ : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0
  Job-PJAXXB : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0


                                                Method |     Toolchain |      Mean |     Error |    StdDev |    Median | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------------------------------------------ |-------------- |----------:|----------:|----------:|----------:|------:|--------:|-------:|------:|------:|----------:|
                                             From_Bool | .NET Core 2.0 |  15.25 ns | 0.0306 ns | 0.0256 ns |  15.25 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 2.2 |  16.22 ns | 0.0166 ns | 0.0155 ns |  16.22 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 3.0 |  13.80 ns | 0.1240 ns | 0.1099 ns |  13.80 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                                             From_Bool |        net461 |  14.91 ns | 0.1885 ns | 0.1763 ns |  14.97 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                                             From_Bool |        net472 |  13.41 ns | 0.0126 ns | 0.0118 ns |  13.41 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Bool_AsObject | .NET Core 2.0 |  18.15 ns | 0.0207 ns | 0.0194 ns |  18.15 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 2.2 |  16.03 ns | 0.0875 ns | 0.0776 ns |  16.00 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 3.0 |  17.63 ns | 0.3614 ns | 0.3380 ns |  17.39 ns |  0.97 |    0.02 |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net461 |  17.95 ns | 0.1655 ns | 0.1467 ns |  18.01 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net472 |  18.30 ns | 0.0236 ns | 0.0209 ns |  18.30 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Bool_Nullable_WithValue | .NET Core 2.0 |  15.54 ns | 0.1399 ns | 0.1168 ns |  15.55 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 2.2 |  16.31 ns | 0.0283 ns | 0.0251 ns |  16.31 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 3.0 |  13.80 ns | 0.0274 ns | 0.0243 ns |  13.80 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net461 |  17.70 ns | 0.0287 ns | 0.0269 ns |  17.70 ns |  1.14 |    0.01 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net472 |  14.41 ns | 0.0341 ns | 0.0319 ns |  14.41 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.0 |  18.85 ns | 0.0538 ns | 0.0477 ns |  18.84 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.2 |  16.42 ns | 0.0291 ns | 0.0272 ns |  16.43 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 3.0 |  17.20 ns | 0.0421 ns | 0.0328 ns |  17.20 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net461 |  17.92 ns | 0.1490 ns | 0.1393 ns |  17.94 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net472 |  17.91 ns | 0.0502 ns | 0.0445 ns |  17.90 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Bool_Nullable_NoValue | .NET Core 2.0 |  13.71 ns | 0.0318 ns | 0.0297 ns |  13.72 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 2.2 |  12.42 ns | 0.1413 ns | 0.1322 ns |  12.46 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 3.0 |  12.35 ns | 0.0587 ns | 0.0550 ns |  12.33 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net461 |  13.53 ns | 0.1231 ns | 0.1151 ns |  13.58 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net472 |  13.62 ns | 0.1150 ns | 0.1076 ns |  13.55 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.0 |  13.79 ns | 0.1293 ns | 0.1146 ns |  13.84 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.2 |  14.32 ns | 0.0210 ns | 0.0186 ns |  14.33 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 3.0 |  13.02 ns | 0.2912 ns | 0.4269 ns |  12.79 ns |  0.96 |    0.04 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net461 |  13.38 ns | 0.0193 ns | 0.0151 ns |  13.39 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net472 |  14.20 ns | 0.0256 ns | 0.0239 ns |  14.20 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Byte | .NET Core 2.0 |  46.71 ns | 0.2469 ns | 0.2310 ns |  46.61 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
                                             From_Byte | .NET Core 2.2 |  28.08 ns | 0.0484 ns | 0.0429 ns |  28.08 ns |  0.60 |    0.00 | 0.0051 |     - |     - |      32 B |
                                             From_Byte | .NET Core 3.0 |  24.90 ns | 0.3489 ns | 0.3264 ns |  24.69 ns |  0.53 |    0.01 |      - |     - |     - |         - |
                                             From_Byte |        net461 |  54.69 ns | 0.0760 ns | 0.0710 ns |  54.67 ns |  1.17 |    0.01 | 0.0051 |     - |     - |      32 B |
                                             From_Byte |        net472 |  52.23 ns | 0.0602 ns | 0.0502 ns |  52.25 ns |  1.12 |    0.01 | 0.0051 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Byte_AsObject | .NET Core 2.0 |  52.86 ns | 0.0671 ns | 0.0627 ns |  52.87 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
                                    From_Byte_AsObject | .NET Core 2.2 |  34.04 ns | 0.1646 ns | 0.1375 ns |  34.09 ns |  0.64 |    0.00 | 0.0051 |     - |     - |      32 B |
                                    From_Byte_AsObject | .NET Core 3.0 |  30.32 ns | 0.1805 ns | 0.1409 ns |  30.35 ns |  0.57 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net461 |  60.76 ns | 0.4989 ns | 0.4667 ns |  60.96 ns |  1.15 |    0.01 | 0.0050 |     - |     - |      32 B |
                                    From_Byte_AsObject |        net472 |  55.95 ns | 0.4250 ns | 0.3976 ns |  55.89 ns |  1.06 |    0.01 | 0.0051 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Byte_Nullable_WithValue | .NET Core 2.0 |  46.98 ns | 0.1486 ns | 0.1160 ns |  46.97 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
                          From_Byte_Nullable_WithValue | .NET Core 2.2 |  29.56 ns | 0.0531 ns | 0.0470 ns |  29.55 ns |  0.63 |    0.00 | 0.0051 |     - |     - |      32 B |
                          From_Byte_Nullable_WithValue | .NET Core 3.0 |  25.21 ns | 0.0501 ns | 0.0444 ns |  25.21 ns |  0.54 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net461 |  48.89 ns | 0.0533 ns | 0.0499 ns |  48.89 ns |  1.04 |    0.00 | 0.0051 |     - |     - |      32 B |
                          From_Byte_Nullable_WithValue |        net472 |  51.53 ns | 0.2480 ns | 0.2319 ns |  51.43 ns |  1.10 |    0.01 | 0.0051 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.0 |  54.04 ns | 0.0835 ns | 0.0781 ns |  54.03 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.2 |  33.13 ns | 0.1239 ns | 0.1098 ns |  33.12 ns |  0.61 |    0.00 | 0.0051 |     - |     - |      32 B |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 3.0 |  29.96 ns | 0.1378 ns | 0.1289 ns |  29.92 ns |  0.55 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net461 |  55.38 ns | 0.1113 ns | 0.0987 ns |  55.36 ns |  1.02 |    0.00 | 0.0051 |     - |     - |      32 B |
                 From_Byte_Nullable_WithValue_AsObject |        net472 |  55.44 ns | 0.5008 ns | 0.4685 ns |  55.16 ns |  1.03 |    0.01 | 0.0051 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Byte_Nullable_NoValue | .NET Core 2.0 |  13.01 ns | 0.0196 ns | 0.0174 ns |  13.01 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 2.2 |  13.21 ns | 0.0208 ns | 0.0184 ns |  13.21 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 3.0 |  13.36 ns | 0.2887 ns | 0.2701 ns |  13.21 ns |  1.03 |    0.02 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net461 |  14.64 ns | 0.0264 ns | 0.0247 ns |  14.65 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net472 |  13.82 ns | 0.0614 ns | 0.0574 ns |  13.81 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.0 |  13.62 ns | 0.0655 ns | 0.0613 ns |  13.62 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.2 |  13.11 ns | 0.1249 ns | 0.1168 ns |  13.16 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 3.0 |  13.37 ns | 0.0314 ns | 0.0262 ns |  13.36 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net461 |  13.46 ns | 0.0126 ns | 0.0112 ns |  13.46 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net472 |  13.43 ns | 0.0246 ns | 0.0230 ns |  13.43 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Char | .NET Core 2.0 |  16.55 ns | 0.0474 ns | 0.0443 ns |  16.54 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
                                             From_Char | .NET Core 2.2 |  15.59 ns | 0.0281 ns | 0.0249 ns |  15.60 ns |  0.94 |    0.00 | 0.0051 |     - |     - |      32 B |
                                             From_Char | .NET Core 3.0 |  16.33 ns | 0.0490 ns | 0.0434 ns |  16.32 ns |  0.99 |    0.00 | 0.0038 |     - |     - |      24 B |
                                             From_Char |        net461 |  17.57 ns | 0.0550 ns | 0.0487 ns |  17.55 ns |  1.06 |    0.00 | 0.0051 |     - |     - |      32 B |
                                             From_Char |        net472 |  19.40 ns | 0.2051 ns | 0.1919 ns |  19.35 ns |  1.17 |    0.01 | 0.0051 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Char_AsObject | .NET Core 2.0 |  23.95 ns | 0.0597 ns | 0.0558 ns |  23.94 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
                                    From_Char_AsObject | .NET Core 2.2 |  21.25 ns | 0.0898 ns | 0.0840 ns |  21.27 ns |  0.89 |    0.00 | 0.0051 |     - |     - |      32 B |
                                    From_Char_AsObject | .NET Core 3.0 |  22.36 ns | 0.0673 ns | 0.0629 ns |  22.36 ns |  0.93 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Char_AsObject |        net461 |  21.95 ns | 0.0368 ns | 0.0307 ns |  21.95 ns |  0.92 |    0.00 | 0.0051 |     - |     - |      32 B |
                                    From_Char_AsObject |        net472 |  22.30 ns | 0.0401 ns | 0.0356 ns |  22.31 ns |  0.93 |    0.00 | 0.0051 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Char_Nullable_WithValue | .NET Core 2.0 |  16.36 ns | 0.0798 ns | 0.0747 ns |  16.35 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
                          From_Char_Nullable_WithValue | .NET Core 2.2 |  17.37 ns | 0.0509 ns | 0.0425 ns |  17.37 ns |  1.06 |    0.01 | 0.0051 |     - |     - |      32 B |
                          From_Char_Nullable_WithValue | .NET Core 3.0 |  16.32 ns | 0.1613 ns | 0.1509 ns |  16.38 ns |  1.00 |    0.01 | 0.0038 |     - |     - |      24 B |
                          From_Char_Nullable_WithValue |        net461 |  18.15 ns | 0.0514 ns | 0.0429 ns |  18.13 ns |  1.11 |    0.01 | 0.0051 |     - |     - |      32 B |
                          From_Char_Nullable_WithValue |        net472 |  18.55 ns | 0.0467 ns | 0.0436 ns |  18.54 ns |  1.13 |    0.01 | 0.0051 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.0 |  23.02 ns | 0.0347 ns | 0.0271 ns |  23.02 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.2 |  24.24 ns | 0.0273 ns | 0.0256 ns |  24.24 ns |  1.05 |    0.00 | 0.0051 |     - |     - |      32 B |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 3.0 |  20.87 ns | 0.0842 ns | 0.0788 ns |  20.89 ns |  0.91 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Char_Nullable_WithValue_AsObject |        net461 |  22.37 ns | 0.0776 ns | 0.0687 ns |  22.35 ns |  0.97 |    0.00 | 0.0051 |     - |     - |      32 B |
                 From_Char_Nullable_WithValue_AsObject |        net472 |  22.79 ns | 0.0294 ns | 0.0229 ns |  22.79 ns |  0.99 |    0.00 | 0.0051 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Char_Nullable_NoValue | .NET Core 2.0 |  13.01 ns | 0.0324 ns | 0.0303 ns |  13.00 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 2.2 |  12.29 ns | 0.0303 ns | 0.0269 ns |  12.29 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 3.0 |  15.68 ns | 0.0501 ns | 0.0468 ns |  15.69 ns |  1.21 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net461 |  14.73 ns | 0.0955 ns | 0.0894 ns |  14.69 ns |  1.13 |    0.01 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net472 |  13.63 ns | 0.0316 ns | 0.0295 ns |  13.63 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.0 |  13.83 ns | 0.1025 ns | 0.0959 ns |  13.78 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.2 |  13.51 ns | 0.1393 ns | 0.1303 ns |  13.43 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 3.0 |  12.86 ns | 0.0283 ns | 0.0251 ns |  12.86 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net461 |  13.40 ns | 0.0326 ns | 0.0305 ns |  13.39 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net472 |  14.02 ns | 0.0295 ns | 0.0276 ns |  14.01 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                         From_DateTime | .NET Core 2.0 | 335.31 ns | 0.7359 ns | 0.6883 ns | 335.26 ns |  1.00 |    0.00 | 0.0262 |     - |     - |     168 B |
                                         From_DateTime | .NET Core 2.2 | 288.99 ns | 0.3818 ns | 0.3572 ns | 289.03 ns |  0.86 |    0.00 | 0.0262 |     - |     - |     168 B |
                                         From_DateTime | .NET Core 3.0 | 239.54 ns | 0.3374 ns | 0.2991 ns | 239.60 ns |  0.71 |    0.00 | 0.0100 |     - |     - |      64 B |
                                         From_DateTime |        net461 | 350.96 ns | 2.0166 ns | 1.8864 ns | 350.10 ns |  1.05 |    0.01 | 0.0300 |     - |     - |     192 B |
                                         From_DateTime |        net472 | 352.16 ns | 0.7902 ns | 0.7005 ns | 352.06 ns |  1.05 |    0.00 | 0.0300 |     - |     - |     192 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                From_DateTime_AsObject | .NET Core 2.0 | 338.17 ns | 2.5026 ns | 2.3409 ns | 337.20 ns |  1.00 |    0.00 | 0.0262 |     - |     - |     168 B |
                                From_DateTime_AsObject | .NET Core 2.2 | 295.32 ns | 0.6493 ns | 0.6074 ns | 295.41 ns |  0.87 |    0.01 | 0.0262 |     - |     - |     168 B |
                                From_DateTime_AsObject | .NET Core 3.0 | 243.11 ns | 0.6912 ns | 0.5772 ns | 243.00 ns |  0.72 |    0.00 | 0.0100 |     - |     - |      64 B |
                                From_DateTime_AsObject |        net461 | 347.85 ns | 1.9079 ns | 1.7846 ns | 346.86 ns |  1.03 |    0.01 | 0.0300 |     - |     - |     192 B |
                                From_DateTime_AsObject |        net472 | 346.63 ns | 0.6050 ns | 0.5659 ns | 346.65 ns |  1.03 |    0.01 | 0.0300 |     - |     - |     192 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                      From_DateTime_Nullable_WithValue | .NET Core 2.0 | 335.54 ns | 2.7151 ns | 2.4069 ns | 336.38 ns |  1.00 |    0.00 | 0.0262 |     - |     - |     168 B |
                      From_DateTime_Nullable_WithValue | .NET Core 2.2 | 293.91 ns | 1.6627 ns | 1.5553 ns | 293.10 ns |  0.88 |    0.01 | 0.0262 |     - |     - |     168 B |
                      From_DateTime_Nullable_WithValue | .NET Core 3.0 | 236.48 ns | 0.4020 ns | 0.3357 ns | 236.50 ns |  0.71 |    0.01 | 0.0100 |     - |     - |      64 B |
                      From_DateTime_Nullable_WithValue |        net461 | 354.11 ns | 0.6200 ns | 0.5800 ns | 354.10 ns |  1.06 |    0.01 | 0.0300 |     - |     - |     192 B |
                      From_DateTime_Nullable_WithValue |        net472 | 359.59 ns | 0.8300 ns | 0.7358 ns | 359.73 ns |  1.07 |    0.01 | 0.0300 |     - |     - |     192 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.0 | 330.63 ns | 0.4918 ns | 0.4600 ns | 330.56 ns |  1.00 |    0.00 | 0.0262 |     - |     - |     168 B |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.2 | 296.79 ns | 0.3899 ns | 0.3457 ns | 296.71 ns |  0.90 |    0.00 | 0.0262 |     - |     - |     168 B |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 3.0 | 241.21 ns | 0.3517 ns | 0.3290 ns | 241.20 ns |  0.73 |    0.00 | 0.0100 |     - |     - |      64 B |
             From_DateTime_Nullable_WithValue_AsObject |        net461 | 352.84 ns | 0.8824 ns | 0.8254 ns | 352.63 ns |  1.07 |    0.00 | 0.0300 |     - |     - |     192 B |
             From_DateTime_Nullable_WithValue_AsObject |        net472 | 350.40 ns | 3.9588 ns | 3.7030 ns | 350.85 ns |  1.06 |    0.01 | 0.0300 |     - |     - |     192 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_DateTime_Nullable_NoValue | .NET Core 2.0 |  14.10 ns | 0.0365 ns | 0.0341 ns |  14.09 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 2.2 |  13.45 ns | 0.0333 ns | 0.0295 ns |  13.45 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 3.0 |  15.10 ns | 0.0249 ns | 0.0221 ns |  15.10 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net461 |  17.03 ns | 0.0672 ns | 0.0596 ns |  17.02 ns |  1.21 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net472 |  14.51 ns | 0.0649 ns | 0.0575 ns |  14.51 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.0 |  14.95 ns | 0.1484 ns | 0.1388 ns |  15.04 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.2 |  13.84 ns | 0.0225 ns | 0.0188 ns |  13.84 ns |  0.92 |    0.01 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 3.0 |  12.99 ns | 0.0829 ns | 0.0776 ns |  13.01 ns |  0.87 |    0.01 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net461 |  13.41 ns | 0.0167 ns | 0.0148 ns |  13.41 ns |  0.90 |    0.01 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net472 |  13.75 ns | 0.0389 ns | 0.0364 ns |  13.76 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                          From_Decimal | .NET Core 2.0 |  63.31 ns | 0.1579 ns | 0.1318 ns |  63.28 ns |  1.00 |    0.00 | 0.0050 |     - |     - |      32 B |
                                          From_Decimal | .NET Core 2.2 |  58.69 ns | 0.0981 ns | 0.0869 ns |  58.68 ns |  0.93 |    0.00 | 0.0050 |     - |     - |      32 B |
                                          From_Decimal | .NET Core 3.0 |  56.97 ns | 0.1383 ns | 0.1294 ns |  56.96 ns |  0.90 |    0.00 | 0.0038 |     - |     - |      24 B |
                                          From_Decimal |        net461 |  64.03 ns | 0.1836 ns | 0.1718 ns |  63.99 ns |  1.01 |    0.00 | 0.0050 |     - |     - |      32 B |
                                          From_Decimal |        net472 |  62.30 ns | 0.1375 ns | 0.1148 ns |  62.28 ns |  0.98 |    0.00 | 0.0050 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                 From_Decimal_AsObject | .NET Core 2.0 |  69.85 ns | 0.1273 ns | 0.1190 ns |  69.85 ns |  1.00 |    0.00 | 0.0050 |     - |     - |      32 B |
                                 From_Decimal_AsObject | .NET Core 2.2 |  59.11 ns | 0.2758 ns | 0.2580 ns |  59.12 ns |  0.85 |    0.00 | 0.0050 |     - |     - |      32 B |
                                 From_Decimal_AsObject | .NET Core 3.0 |  61.80 ns | 0.1662 ns | 0.1554 ns |  61.80 ns |  0.88 |    0.00 | 0.0038 |     - |     - |      24 B |
                                 From_Decimal_AsObject |        net461 |  66.10 ns | 0.1099 ns | 0.0975 ns |  66.07 ns |  0.95 |    0.00 | 0.0050 |     - |     - |      32 B |
                                 From_Decimal_AsObject |        net472 |  67.05 ns | 0.2688 ns | 0.2514 ns |  67.08 ns |  0.96 |    0.00 | 0.0050 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                       From_Decimal_Nullable_WithValue | .NET Core 2.0 |  66.29 ns | 0.6285 ns | 0.5879 ns |  66.49 ns |  1.00 |    0.00 | 0.0050 |     - |     - |      32 B |
                       From_Decimal_Nullable_WithValue | .NET Core 2.2 |  63.39 ns | 0.6917 ns | 0.6470 ns |  63.10 ns |  0.96 |    0.01 | 0.0050 |     - |     - |      32 B |
                       From_Decimal_Nullable_WithValue | .NET Core 3.0 |  55.18 ns | 0.1948 ns | 0.1822 ns |  55.13 ns |  0.83 |    0.01 | 0.0038 |     - |     - |      24 B |
                       From_Decimal_Nullable_WithValue |        net461 |  64.53 ns | 0.1153 ns | 0.0963 ns |  64.55 ns |  0.97 |    0.01 | 0.0050 |     - |     - |      32 B |
                       From_Decimal_Nullable_WithValue |        net472 |  64.91 ns | 0.7049 ns | 0.6594 ns |  65.26 ns |  0.98 |    0.01 | 0.0050 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.0 |  68.48 ns | 0.1198 ns | 0.1062 ns |  68.45 ns |  1.00 |    0.00 | 0.0050 |     - |     - |      32 B |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.2 |  58.04 ns | 0.0728 ns | 0.0681 ns |  58.03 ns |  0.85 |    0.00 | 0.0051 |     - |     - |      32 B |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 3.0 |  62.65 ns | 0.1454 ns | 0.1360 ns |  62.62 ns |  0.91 |    0.00 | 0.0038 |     - |     - |      24 B |
              From_Decimal_Nullable_WithValue_AsObject |        net461 |  68.18 ns | 0.1221 ns | 0.1082 ns |  68.21 ns |  1.00 |    0.00 | 0.0050 |     - |     - |      32 B |
              From_Decimal_Nullable_WithValue_AsObject |        net472 |  66.63 ns | 0.3768 ns | 0.3525 ns |  66.80 ns |  0.97 |    0.01 | 0.0050 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Decimal_Nullable_NoValue | .NET Core 2.0 |  13.54 ns | 0.0185 ns | 0.0173 ns |  13.54 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 2.2 |  18.52 ns | 0.0367 ns | 0.0325 ns |  18.53 ns |  1.37 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 3.0 |  14.72 ns | 0.1231 ns | 0.1151 ns |  14.79 ns |  1.09 |    0.01 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net461 |  16.41 ns | 0.1172 ns | 0.1096 ns |  16.47 ns |  1.21 |    0.01 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net472 |  14.28 ns | 0.0352 ns | 0.0329 ns |  14.28 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.0 |  15.49 ns | 0.0244 ns | 0.0229 ns |  15.49 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.2 |  13.40 ns | 0.1675 ns | 0.1567 ns |  13.44 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 3.0 |  12.95 ns | 0.0663 ns | 0.0620 ns |  12.92 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net461 |  13.44 ns | 0.0721 ns | 0.0674 ns |  13.41 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net472 |  13.43 ns | 0.0212 ns | 0.0188 ns |  13.43 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_Double | .NET Core 2.0 | 209.53 ns | 0.3721 ns | 0.3481 ns | 209.40 ns |  1.00 |    0.00 | 0.0050 |     - |     - |      32 B |
                                           From_Double | .NET Core 2.2 | 121.40 ns | 0.2516 ns | 0.2354 ns | 121.35 ns |  0.58 |    0.00 | 0.0050 |     - |     - |      32 B |
                                           From_Double | .NET Core 3.0 | 124.59 ns | 0.1678 ns | 0.1569 ns | 124.61 ns |  0.59 |    0.00 | 0.0038 |     - |     - |      24 B |
                                           From_Double |        net461 | 311.89 ns | 0.2850 ns | 0.2527 ns | 311.83 ns |  1.49 |    0.00 | 0.0048 |     - |     - |      32 B |
                                           From_Double |        net472 | 328.33 ns | 0.5484 ns | 0.4862 ns | 328.21 ns |  1.57 |    0.00 | 0.0048 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_Double_AsObject | .NET Core 2.0 | 220.60 ns | 0.3703 ns | 0.3092 ns | 220.55 ns |  1.00 |    0.00 | 0.0050 |     - |     - |      32 B |
                                  From_Double_AsObject | .NET Core 2.2 | 127.38 ns | 0.2668 ns | 0.2495 ns | 127.35 ns |  0.58 |    0.00 | 0.0050 |     - |     - |      32 B |
                                  From_Double_AsObject | .NET Core 3.0 | 135.38 ns | 0.6010 ns | 0.5621 ns | 135.45 ns |  0.61 |    0.00 | 0.0038 |     - |     - |      24 B |
                                  From_Double_AsObject |        net461 | 327.02 ns | 2.3987 ns | 2.2437 ns | 325.76 ns |  1.48 |    0.01 | 0.0048 |     - |     - |      32 B |
                                  From_Double_AsObject |        net472 | 325.54 ns | 0.6404 ns | 0.5990 ns | 325.47 ns |  1.48 |    0.00 | 0.0048 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_Double_Nullable_WithValue | .NET Core 2.0 | 210.44 ns | 0.2114 ns | 0.1977 ns | 210.36 ns |  1.00 |    0.00 | 0.0050 |     - |     - |      32 B |
                        From_Double_Nullable_WithValue | .NET Core 2.2 | 123.33 ns | 0.1692 ns | 0.1500 ns | 123.33 ns |  0.59 |    0.00 | 0.0050 |     - |     - |      32 B |
                        From_Double_Nullable_WithValue | .NET Core 3.0 | 128.66 ns | 0.7443 ns | 0.6598 ns | 128.39 ns |  0.61 |    0.00 | 0.0038 |     - |     - |      24 B |
                        From_Double_Nullable_WithValue |        net461 | 318.50 ns | 1.0569 ns | 0.9369 ns | 318.27 ns |  1.51 |    0.00 | 0.0048 |     - |     - |      32 B |
                        From_Double_Nullable_WithValue |        net472 | 319.98 ns | 3.3971 ns | 3.1777 ns | 319.71 ns |  1.52 |    0.01 | 0.0048 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.0 | 218.05 ns | 0.2176 ns | 0.2035 ns | 218.00 ns |  1.00 |    0.00 | 0.0050 |     - |     - |      32 B |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.2 | 128.80 ns | 0.2104 ns | 0.1757 ns | 128.78 ns |  0.59 |    0.00 | 0.0050 |     - |     - |      32 B |
               From_Double_Nullable_WithValue_AsObject | .NET Core 3.0 | 132.92 ns | 0.2223 ns | 0.1736 ns | 132.93 ns |  0.61 |    0.00 | 0.0038 |     - |     - |      24 B |
               From_Double_Nullable_WithValue_AsObject |        net461 | 320.44 ns | 0.4462 ns | 0.3726 ns | 320.56 ns |  1.47 |    0.00 | 0.0048 |     - |     - |      32 B |
               From_Double_Nullable_WithValue_AsObject |        net472 | 320.92 ns | 0.3710 ns | 0.3470 ns | 320.95 ns |  1.47 |    0.00 | 0.0048 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Double_Nullable_NoValue | .NET Core 2.0 |  14.07 ns | 0.1043 ns | 0.0975 ns |  14.11 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 2.2 |  13.27 ns | 0.1480 ns | 0.1384 ns |  13.18 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 3.0 |  14.21 ns | 0.1222 ns | 0.1143 ns |  14.28 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net461 |  15.50 ns | 0.0355 ns | 0.0315 ns |  15.49 ns |  1.10 |    0.01 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net472 |  13.80 ns | 0.0189 ns | 0.0177 ns |  13.80 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.0 |  13.40 ns | 0.0197 ns | 0.0164 ns |  13.40 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.2 |  12.32 ns | 0.0214 ns | 0.0190 ns |  12.33 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 3.0 |  12.87 ns | 0.0136 ns | 0.0128 ns |  12.87 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net461 |  13.42 ns | 0.0261 ns | 0.0204 ns |  13.42 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net472 |  13.44 ns | 0.1124 ns | 0.0996 ns |  13.40 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_Short | .NET Core 2.0 |  46.52 ns | 0.0770 ns | 0.0683 ns |  46.51 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
                                            From_Short | .NET Core 2.2 |  28.75 ns | 0.0939 ns | 0.0833 ns |  28.75 ns |  0.62 |    0.00 | 0.0051 |     - |     - |      32 B |
                                            From_Short | .NET Core 3.0 |  25.07 ns | 0.0616 ns | 0.0546 ns |  25.05 ns |  0.54 |    0.00 |      - |     - |     - |         - |
                                            From_Short |        net461 |  51.54 ns | 0.4648 ns | 0.4348 ns |  51.81 ns |  1.11 |    0.01 | 0.0051 |     - |     - |      32 B |
                                            From_Short |        net472 |  49.17 ns | 0.0593 ns | 0.0526 ns |  49.16 ns |  1.06 |    0.00 | 0.0051 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_Short_AsObject | .NET Core 2.0 |  52.05 ns | 0.3059 ns | 0.2861 ns |  52.11 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
                                   From_Short_AsObject | .NET Core 2.2 |  34.42 ns | 0.3603 ns | 0.3370 ns |  34.26 ns |  0.66 |    0.01 | 0.0051 |     - |     - |      32 B |
                                   From_Short_AsObject | .NET Core 3.0 |  29.87 ns | 0.2017 ns | 0.1788 ns |  29.95 ns |  0.57 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net461 |  54.15 ns | 0.0729 ns | 0.0646 ns |  54.15 ns |  1.04 |    0.00 | 0.0051 |     - |     - |      32 B |
                                   From_Short_AsObject |        net472 |  55.13 ns | 0.0958 ns | 0.0896 ns |  55.14 ns |  1.06 |    0.01 | 0.0051 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Short_Nullable_WithValue | .NET Core 2.0 |  46.80 ns | 0.0874 ns | 0.0775 ns |  46.80 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
                         From_Short_Nullable_WithValue | .NET Core 2.2 |  29.59 ns | 0.0803 ns | 0.0711 ns |  29.60 ns |  0.63 |    0.00 | 0.0051 |     - |     - |      32 B |
                         From_Short_Nullable_WithValue | .NET Core 3.0 |  25.92 ns | 0.1589 ns | 0.1486 ns |  25.97 ns |  0.55 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net461 |  53.62 ns | 0.2566 ns | 0.2275 ns |  53.66 ns |  1.15 |    0.01 | 0.0051 |     - |     - |      32 B |
                         From_Short_Nullable_WithValue |        net472 |  51.69 ns | 0.3469 ns | 0.3075 ns |  51.57 ns |  1.10 |    0.01 | 0.0051 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.0 |  52.23 ns | 0.0831 ns | 0.0737 ns |  52.24 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.2 |  33.30 ns | 0.1608 ns | 0.1342 ns |  33.26 ns |  0.64 |    0.00 | 0.0051 |     - |     - |      32 B |
                From_Short_Nullable_WithValue_AsObject | .NET Core 3.0 |  29.46 ns | 0.0574 ns | 0.0508 ns |  29.45 ns |  0.56 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net461 |  53.98 ns | 0.1658 ns | 0.1470 ns |  53.95 ns |  1.03 |    0.00 | 0.0051 |     - |     - |      32 B |
                From_Short_Nullable_WithValue_AsObject |        net472 |  56.89 ns | 0.1024 ns | 0.0958 ns |  56.87 ns |  1.09 |    0.00 | 0.0051 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Short_Nullable_NoValue | .NET Core 2.0 |  13.56 ns | 0.0702 ns | 0.0657 ns |  13.57 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 2.2 |  13.98 ns | 0.0190 ns | 0.0168 ns |  13.97 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 3.0 |  12.51 ns | 0.0164 ns | 0.0146 ns |  12.50 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net461 |  15.02 ns | 0.0301 ns | 0.0281 ns |  15.01 ns |  1.11 |    0.01 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net472 |  13.70 ns | 0.0954 ns | 0.0893 ns |  13.69 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.0 |  14.04 ns | 0.0156 ns | 0.0130 ns |  14.04 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.2 |  13.19 ns | 0.0194 ns | 0.0172 ns |  13.19 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 3.0 |  13.45 ns | 0.0332 ns | 0.0294 ns |  13.45 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net461 |  13.75 ns | 0.0165 ns | 0.0154 ns |  13.76 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net472 |  13.89 ns | 0.1423 ns | 0.1331 ns |  13.80 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                              From_Int | .NET Core 2.0 |  46.52 ns | 0.3675 ns | 0.3438 ns |  46.31 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
                                              From_Int | .NET Core 2.2 |  29.10 ns | 0.2501 ns | 0.2339 ns |  29.04 ns |  0.63 |    0.01 | 0.0051 |     - |     - |      32 B |
                                              From_Int | .NET Core 3.0 |  25.53 ns | 0.2021 ns | 0.1890 ns |  25.60 ns |  0.55 |    0.01 |      - |     - |     - |         - |
                                              From_Int |        net461 |  51.43 ns | 0.0770 ns | 0.0601 ns |  51.45 ns |  1.11 |    0.01 | 0.0051 |     - |     - |      32 B |
                                              From_Int |        net472 |  48.95 ns | 0.0560 ns | 0.0524 ns |  48.96 ns |  1.05 |    0.01 | 0.0051 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_Int_AsObject | .NET Core 2.0 |  53.33 ns | 0.4498 ns | 0.4207 ns |  53.52 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
                                     From_Int_AsObject | .NET Core 2.2 |  34.22 ns | 0.0731 ns | 0.0683 ns |  34.25 ns |  0.64 |    0.00 | 0.0051 |     - |     - |      32 B |
                                     From_Int_AsObject | .NET Core 3.0 |  29.43 ns | 0.0499 ns | 0.0442 ns |  29.43 ns |  0.55 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net461 |  58.83 ns | 0.5785 ns | 0.5411 ns |  58.59 ns |  1.10 |    0.02 | 0.0050 |     - |     - |      32 B |
                                     From_Int_AsObject |        net472 |  56.56 ns | 0.0853 ns | 0.0712 ns |  56.57 ns |  1.06 |    0.01 | 0.0051 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Int_Nullable_WithValue | .NET Core 2.0 |  48.32 ns | 0.0622 ns | 0.0552 ns |  48.31 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
                           From_Int_Nullable_WithValue | .NET Core 2.2 |  29.48 ns | 0.0504 ns | 0.0472 ns |  29.48 ns |  0.61 |    0.00 | 0.0051 |     - |     - |      32 B |
                           From_Int_Nullable_WithValue | .NET Core 3.0 |  25.78 ns | 0.0401 ns | 0.0375 ns |  25.77 ns |  0.53 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net461 |  51.87 ns | 0.3053 ns | 0.2706 ns |  51.95 ns |  1.07 |    0.01 | 0.0051 |     - |     - |      32 B |
                           From_Int_Nullable_WithValue |        net472 |  50.40 ns | 0.4440 ns | 0.4153 ns |  50.22 ns |  1.04 |    0.01 | 0.0051 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.0 |  51.47 ns | 0.0454 ns | 0.0402 ns |  51.49 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.2 |  32.93 ns | 0.2903 ns | 0.2716 ns |  32.82 ns |  0.64 |    0.01 | 0.0051 |     - |     - |      32 B |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 3.0 |  28.91 ns | 0.0357 ns | 0.0298 ns |  28.92 ns |  0.56 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net461 |  54.17 ns | 0.1339 ns | 0.1187 ns |  54.16 ns |  1.05 |    0.00 | 0.0051 |     - |     - |      32 B |
                  From_Int_Nullable_WithValue_AsObject |        net472 |  54.22 ns | 0.0662 ns | 0.0553 ns |  54.23 ns |  1.05 |    0.00 | 0.0051 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_Int_Nullable_NoValue | .NET Core 2.0 |  13.23 ns | 0.0191 ns | 0.0160 ns |  13.23 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 2.2 |  13.18 ns | 0.0160 ns | 0.0149 ns |  13.18 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 3.0 |  12.52 ns | 0.0196 ns | 0.0174 ns |  12.52 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net461 |  13.33 ns | 0.0189 ns | 0.0177 ns |  13.33 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net472 |  13.50 ns | 0.0381 ns | 0.0357 ns |  13.51 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.0 |  14.66 ns | 0.0186 ns | 0.0165 ns |  14.67 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.2 |  12.34 ns | 0.0209 ns | 0.0186 ns |  12.34 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 3.0 |  12.89 ns | 0.0323 ns | 0.0287 ns |  12.89 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net461 |  13.64 ns | 0.1338 ns | 0.1251 ns |  13.70 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net472 |  13.47 ns | 0.0238 ns | 0.0185 ns |  13.47 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Long | .NET Core 2.0 |  48.07 ns | 0.0807 ns | 0.0755 ns |  48.07 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
                                             From_Long | .NET Core 2.2 |  29.77 ns | 0.1617 ns | 0.1513 ns |  29.74 ns |  0.62 |    0.00 | 0.0051 |     - |     - |      32 B |
                                             From_Long | .NET Core 3.0 |  25.36 ns | 0.2199 ns | 0.2057 ns |  25.32 ns |  0.53 |    0.00 |      - |     - |     - |         - |
                                             From_Long |        net461 |  51.05 ns | 0.2079 ns | 0.1944 ns |  51.09 ns |  1.06 |    0.00 | 0.0051 |     - |     - |      32 B |
                                             From_Long |        net472 |  49.50 ns | 0.0684 ns | 0.0607 ns |  49.53 ns |  1.03 |    0.00 | 0.0051 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Long_AsObject | .NET Core 2.0 |  55.41 ns | 0.0840 ns | 0.0786 ns |  55.41 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
                                    From_Long_AsObject | .NET Core 2.2 |  35.11 ns | 0.1374 ns | 0.1218 ns |  35.10 ns |  0.63 |    0.00 | 0.0051 |     - |     - |      32 B |
                                    From_Long_AsObject | .NET Core 3.0 |  29.23 ns | 0.5982 ns | 0.6143 ns |  28.73 ns |  0.53 |    0.01 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net461 |  55.50 ns | 0.1103 ns | 0.0978 ns |  55.51 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
                                    From_Long_AsObject |        net472 |  56.28 ns | 0.1011 ns | 0.0896 ns |  56.26 ns |  1.02 |    0.00 | 0.0051 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Long_Nullable_WithValue | .NET Core 2.0 |  49.78 ns | 0.0788 ns | 0.0699 ns |  49.77 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
                          From_Long_Nullable_WithValue | .NET Core 2.2 |  30.56 ns | 0.0737 ns | 0.0654 ns |  30.56 ns |  0.61 |    0.00 | 0.0051 |     - |     - |      32 B |
                          From_Long_Nullable_WithValue | .NET Core 3.0 |  25.20 ns | 0.0966 ns | 0.0904 ns |  25.18 ns |  0.51 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net461 |  53.40 ns | 0.2758 ns | 0.2580 ns |  53.43 ns |  1.07 |    0.00 | 0.0051 |     - |     - |      32 B |
                          From_Long_Nullable_WithValue |        net472 |  53.14 ns | 0.2069 ns | 0.1935 ns |  53.08 ns |  1.07 |    0.00 | 0.0051 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.0 |  55.09 ns | 0.0595 ns | 0.0497 ns |  55.09 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.2 |  34.06 ns | 0.0845 ns | 0.0749 ns |  34.06 ns |  0.62 |    0.00 | 0.0051 |     - |     - |      32 B |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 3.0 |  30.55 ns | 0.2509 ns | 0.2347 ns |  30.40 ns |  0.55 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net461 |  59.16 ns | 0.2806 ns | 0.2625 ns |  59.06 ns |  1.07 |    0.01 | 0.0051 |     - |     - |      32 B |
                 From_Long_Nullable_WithValue_AsObject |        net472 |  55.16 ns | 0.1092 ns | 0.1022 ns |  55.16 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Long_Nullable_NoValue | .NET Core 2.0 |  15.08 ns | 0.0432 ns | 0.0404 ns |  15.08 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 2.2 |  13.23 ns | 0.0373 ns | 0.0349 ns |  13.23 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 3.0 |  15.90 ns | 0.3399 ns | 0.7461 ns |  16.20 ns |  0.99 |    0.07 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net461 |  14.12 ns | 0.0376 ns | 0.0314 ns |  14.13 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net472 |  15.65 ns | 0.0379 ns | 0.0296 ns |  15.65 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.0 |  14.83 ns | 0.0308 ns | 0.0288 ns |  14.82 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.2 |  12.55 ns | 0.1163 ns | 0.1088 ns |  12.54 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 3.0 |  13.11 ns | 0.0891 ns | 0.0834 ns |  13.13 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net461 |  13.40 ns | 0.0310 ns | 0.0290 ns |  13.40 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net472 |  13.44 ns | 0.0196 ns | 0.0174 ns |  13.44 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_SByte | .NET Core 2.0 |  46.96 ns | 0.2240 ns | 0.2095 ns |  46.86 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
                                            From_SByte | .NET Core 2.2 |  28.59 ns | 0.0550 ns | 0.0488 ns |  28.58 ns |  0.61 |    0.00 | 0.0051 |     - |     - |      32 B |
                                            From_SByte | .NET Core 3.0 |  25.20 ns | 0.3895 ns | 0.3643 ns |  25.38 ns |  0.54 |    0.01 |      - |     - |     - |         - |
                                            From_SByte |        net461 |  50.91 ns | 0.0454 ns | 0.0424 ns |  50.91 ns |  1.08 |    0.00 | 0.0051 |     - |     - |      32 B |
                                            From_SByte |        net472 |  58.40 ns | 0.3849 ns | 0.3600 ns |  58.50 ns |  1.24 |    0.01 | 0.0051 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_SByte_AsObject | .NET Core 2.0 |  52.11 ns | 0.1105 ns | 0.1034 ns |  52.08 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
                                   From_SByte_AsObject | .NET Core 2.2 |  33.35 ns | 0.2819 ns | 0.2637 ns |  33.42 ns |  0.64 |    0.00 | 0.0051 |     - |     - |      32 B |
                                   From_SByte_AsObject | .NET Core 3.0 |  29.92 ns | 0.0794 ns | 0.0663 ns |  29.92 ns |  0.57 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net461 |  55.88 ns | 0.1158 ns | 0.1027 ns |  55.85 ns |  1.07 |    0.00 | 0.0051 |     - |     - |      32 B |
                                   From_SByte_AsObject |        net472 |  56.81 ns | 0.1982 ns | 0.1854 ns |  56.73 ns |  1.09 |    0.00 | 0.0051 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_SByte_Nullable_WithValue | .NET Core 2.0 |  48.38 ns | 0.2144 ns | 0.2006 ns |  48.29 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
                         From_SByte_Nullable_WithValue | .NET Core 2.2 |  29.48 ns | 0.0669 ns | 0.0593 ns |  29.48 ns |  0.61 |    0.00 | 0.0051 |     - |     - |      32 B |
                         From_SByte_Nullable_WithValue | .NET Core 3.0 |  26.05 ns | 0.0467 ns | 0.0414 ns |  26.04 ns |  0.54 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net461 |  49.10 ns | 0.0937 ns | 0.0783 ns |  49.09 ns |  1.01 |    0.00 | 0.0051 |     - |     - |      32 B |
                         From_SByte_Nullable_WithValue |        net472 |  57.43 ns | 0.1135 ns | 0.1006 ns |  57.43 ns |  1.19 |    0.01 | 0.0051 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.0 |  52.02 ns | 0.0834 ns | 0.0780 ns |  52.00 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.2 |  34.44 ns | 0.1812 ns | 0.1695 ns |  34.40 ns |  0.66 |    0.00 | 0.0051 |     - |     - |      32 B |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 3.0 |  31.26 ns | 0.2294 ns | 0.1915 ns |  31.30 ns |  0.60 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net461 |  62.79 ns | 0.0874 ns | 0.0730 ns |  62.80 ns |  1.21 |    0.00 | 0.0050 |     - |     - |      32 B |
                From_SByte_Nullable_WithValue_AsObject |        net472 |  55.74 ns | 0.1301 ns | 0.1086 ns |  55.73 ns |  1.07 |    0.00 | 0.0051 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_SByte_Nullable_NoValue | .NET Core 2.0 |  14.06 ns | 0.0263 ns | 0.0233 ns |  14.06 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 2.2 |  13.29 ns | 0.1417 ns | 0.1325 ns |  13.35 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 3.0 |  13.37 ns | 0.2375 ns | 0.2222 ns |  13.40 ns |  0.95 |    0.02 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net461 |  16.90 ns | 0.1274 ns | 0.1192 ns |  16.94 ns |  1.20 |    0.01 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net472 |  13.41 ns | 0.0228 ns | 0.0191 ns |  13.42 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.0 |  14.79 ns | 0.0374 ns | 0.0331 ns |  14.78 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.2 |  12.33 ns | 0.0119 ns | 0.0111 ns |  12.33 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 3.0 |  12.88 ns | 0.0132 ns | 0.0103 ns |  12.87 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net461 |  13.41 ns | 0.0260 ns | 0.0231 ns |  13.41 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net472 |  13.46 ns | 0.0267 ns | 0.0236 ns |  13.46 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_Float | .NET Core 2.0 | 180.71 ns | 0.2529 ns | 0.2112 ns | 180.68 ns |  1.00 |    0.00 | 0.0050 |     - |     - |      32 B |
                                            From_Float | .NET Core 2.2 | 117.29 ns | 0.1676 ns | 0.1568 ns | 117.27 ns |  0.65 |    0.00 | 0.0050 |     - |     - |      32 B |
                                            From_Float | .NET Core 3.0 | 127.01 ns | 0.9559 ns | 0.8941 ns | 127.41 ns |  0.70 |    0.01 | 0.0038 |     - |     - |      24 B |
                                            From_Float |        net461 | 302.48 ns | 0.6455 ns | 0.6038 ns | 302.60 ns |  1.67 |    0.00 | 0.0048 |     - |     - |      32 B |
                                            From_Float |        net472 | 306.09 ns | 0.5895 ns | 0.5514 ns | 306.17 ns |  1.69 |    0.00 | 0.0048 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_Float_AsObject | .NET Core 2.0 | 192.52 ns | 0.2456 ns | 0.2297 ns | 192.58 ns |  1.00 |    0.00 | 0.0050 |     - |     - |      32 B |
                                   From_Float_AsObject | .NET Core 2.2 | 122.19 ns | 0.9056 ns | 0.8471 ns | 121.73 ns |  0.63 |    0.00 | 0.0050 |     - |     - |      32 B |
                                   From_Float_AsObject | .NET Core 3.0 | 131.78 ns | 0.1300 ns | 0.1153 ns | 131.79 ns |  0.68 |    0.00 | 0.0038 |     - |     - |      24 B |
                                   From_Float_AsObject |        net461 | 310.24 ns | 0.7307 ns | 0.6835 ns | 309.97 ns |  1.61 |    0.00 | 0.0048 |     - |     - |      32 B |
                                   From_Float_AsObject |        net472 | 306.77 ns | 0.7600 ns | 0.7109 ns | 306.57 ns |  1.59 |    0.00 | 0.0048 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Float_Nullable_WithValue | .NET Core 2.0 | 184.44 ns | 1.7282 ns | 1.6166 ns | 185.25 ns |  1.00 |    0.00 | 0.0050 |     - |     - |      32 B |
                         From_Float_Nullable_WithValue | .NET Core 2.2 | 117.60 ns | 0.1132 ns | 0.1003 ns | 117.59 ns |  0.64 |    0.01 | 0.0050 |     - |     - |      32 B |
                         From_Float_Nullable_WithValue | .NET Core 3.0 | 128.30 ns | 0.3229 ns | 0.2696 ns | 128.22 ns |  0.70 |    0.01 | 0.0038 |     - |     - |      24 B |
                         From_Float_Nullable_WithValue |        net461 | 301.58 ns | 0.4256 ns | 0.3773 ns | 301.62 ns |  1.64 |    0.01 | 0.0048 |     - |     - |      32 B |
                         From_Float_Nullable_WithValue |        net472 | 302.37 ns | 0.3841 ns | 0.3405 ns | 302.23 ns |  1.64 |    0.01 | 0.0048 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.0 | 193.95 ns | 0.2820 ns | 0.2500 ns | 193.95 ns |  1.00 |    0.00 | 0.0050 |     - |     - |      32 B |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.2 | 124.21 ns | 0.3436 ns | 0.3046 ns | 124.22 ns |  0.64 |    0.00 | 0.0050 |     - |     - |      32 B |
                From_Float_Nullable_WithValue_AsObject | .NET Core 3.0 | 134.19 ns | 0.4074 ns | 0.3811 ns | 134.07 ns |  0.69 |    0.00 | 0.0038 |     - |     - |      24 B |
                From_Float_Nullable_WithValue_AsObject |        net461 | 305.92 ns | 0.4745 ns | 0.4206 ns | 305.87 ns |  1.58 |    0.00 | 0.0048 |     - |     - |      32 B |
                From_Float_Nullable_WithValue_AsObject |        net472 | 310.70 ns | 1.9298 ns | 1.8052 ns | 311.28 ns |  1.60 |    0.01 | 0.0048 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Float_Nullable_NoValue | .NET Core 2.0 |  14.04 ns | 0.0472 ns | 0.0394 ns |  14.03 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 2.2 |  12.94 ns | 0.0338 ns | 0.0316 ns |  12.94 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 3.0 |  13.15 ns | 0.0530 ns | 0.0470 ns |  13.14 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net461 |  15.98 ns | 0.0272 ns | 0.0254 ns |  15.97 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net472 |  13.70 ns | 0.0959 ns | 0.0897 ns |  13.70 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.0 |  14.23 ns | 0.0571 ns | 0.0506 ns |  14.24 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.2 |  12.72 ns | 0.0379 ns | 0.0354 ns |  12.70 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 3.0 |  13.88 ns | 0.2999 ns | 0.2805 ns |  13.95 ns |  0.98 |    0.02 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net461 |  13.50 ns | 0.0234 ns | 0.0219 ns |  13.50 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net472 |  13.46 ns | 0.0174 ns | 0.0163 ns |  13.46 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_String | .NET Core 2.0 |  12.25 ns | 0.0211 ns | 0.0198 ns |  12.25 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 2.2 |  11.66 ns | 0.0592 ns | 0.0554 ns |  11.68 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 3.0 |  12.26 ns | 0.1233 ns | 0.1153 ns |  12.32 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                                           From_String |        net461 |  12.04 ns | 0.0249 ns | 0.0208 ns |  12.04 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                           From_String |        net472 |  12.66 ns | 0.1015 ns | 0.0949 ns |  12.61 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_String_AsObject | .NET Core 2.0 |  16.27 ns | 0.0443 ns | 0.0415 ns |  16.26 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 2.2 |  13.10 ns | 0.0426 ns | 0.0398 ns |  13.11 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 3.0 |  14.01 ns | 0.1940 ns | 0.1814 ns |  13.88 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                                  From_String_AsObject |        net461 |  14.02 ns | 0.1140 ns | 0.1066 ns |  14.08 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                                  From_String_AsObject |        net472 |  14.08 ns | 0.0286 ns | 0.0254 ns |  14.08 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                      From_String_Null | .NET Core 2.0 |  12.58 ns | 0.1218 ns | 0.1140 ns |  12.63 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 2.2 |  11.39 ns | 0.0142 ns | 0.0133 ns |  11.39 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 3.0 |  13.03 ns | 0.2673 ns | 0.2500 ns |  13.22 ns |  1.04 |    0.03 |      - |     - |     - |         - |
                                      From_String_Null |        net461 |  12.02 ns | 0.0113 ns | 0.0106 ns |  12.02 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                                      From_String_Null |        net472 |  12.00 ns | 0.0116 ns | 0.0109 ns |  12.00 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_String_Null_AsObject | .NET Core 2.0 |  14.80 ns | 0.0318 ns | 0.0297 ns |  14.80 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 2.2 |  12.34 ns | 0.0266 ns | 0.0236 ns |  12.33 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 3.0 |  14.00 ns | 0.2996 ns | 0.3205 ns |  14.18 ns |  0.95 |    0.02 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net461 |  13.53 ns | 0.0152 ns | 0.0135 ns |  13.53 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net472 |  13.60 ns | 0.0414 ns | 0.0367 ns |  13.61 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_String_Empty | .NET Core 2.0 |  12.26 ns | 0.0114 ns | 0.0107 ns |  12.26 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 2.2 |  12.29 ns | 0.0195 ns | 0.0173 ns |  12.29 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 3.0 |  12.07 ns | 0.0484 ns | 0.0453 ns |  12.05 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty |        net461 |  12.30 ns | 0.0149 ns | 0.0139 ns |  12.29 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty |        net472 |  13.44 ns | 0.0379 ns | 0.0354 ns |  13.42 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_String_Empty_AsObject | .NET Core 2.0 |  15.86 ns | 0.1085 ns | 0.0906 ns |  15.89 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 2.2 |  13.09 ns | 0.0174 ns | 0.0163 ns |  13.09 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 3.0 |  13.26 ns | 0.0169 ns | 0.0158 ns |  13.25 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net461 |  13.95 ns | 0.0132 ns | 0.0117 ns |  13.96 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net472 |  13.91 ns | 0.0231 ns | 0.0216 ns |  13.92 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_UShort | .NET Core 2.0 |  44.62 ns | 0.0575 ns | 0.0538 ns |  44.63 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
                                           From_UShort | .NET Core 2.2 |  27.76 ns | 0.0447 ns | 0.0373 ns |  27.75 ns |  0.62 |    0.00 | 0.0051 |     - |     - |      32 B |
                                           From_UShort | .NET Core 3.0 |  25.15 ns | 0.2451 ns | 0.2293 ns |  25.23 ns |  0.56 |    0.01 |      - |     - |     - |         - |
                                           From_UShort |        net461 |  48.21 ns | 0.0736 ns | 0.0688 ns |  48.20 ns |  1.08 |    0.00 | 0.0051 |     - |     - |      32 B |
                                           From_UShort |        net472 |  49.36 ns | 0.2486 ns | 0.2325 ns |  49.40 ns |  1.11 |    0.01 | 0.0051 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_UShort_AsObject | .NET Core 2.0 |  49.69 ns | 0.0905 ns | 0.0846 ns |  49.68 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
                                  From_UShort_AsObject | .NET Core 2.2 |  33.19 ns | 0.3239 ns | 0.2872 ns |  33.27 ns |  0.67 |    0.01 | 0.0051 |     - |     - |      32 B |
                                  From_UShort_AsObject | .NET Core 3.0 |  30.88 ns | 0.0688 ns | 0.0574 ns |  30.86 ns |  0.62 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net461 |  60.47 ns | 0.4070 ns | 0.3807 ns |  60.63 ns |  1.22 |    0.01 | 0.0050 |     - |     - |      32 B |
                                  From_UShort_AsObject |        net472 |  54.01 ns | 0.0825 ns | 0.0644 ns |  54.01 ns |  1.09 |    0.00 | 0.0051 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_UShort_Nullable_WithValue | .NET Core 2.0 |  47.07 ns | 0.0507 ns | 0.0423 ns |  47.07 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
                        From_UShort_Nullable_WithValue | .NET Core 2.2 |  30.24 ns | 0.0442 ns | 0.0369 ns |  30.24 ns |  0.64 |    0.00 | 0.0051 |     - |     - |      32 B |
                        From_UShort_Nullable_WithValue | .NET Core 3.0 |  25.46 ns | 0.1137 ns | 0.1008 ns |  25.46 ns |  0.54 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net461 |  51.74 ns | 0.0491 ns | 0.0410 ns |  51.72 ns |  1.10 |    0.00 | 0.0051 |     - |     - |      32 B |
                        From_UShort_Nullable_WithValue |        net472 |  48.97 ns | 0.0914 ns | 0.0810 ns |  48.95 ns |  1.04 |    0.00 | 0.0051 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.0 |  50.20 ns | 0.0721 ns | 0.0674 ns |  50.20 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.2 |  34.19 ns | 0.0625 ns | 0.0488 ns |  34.20 ns |  0.68 |    0.00 | 0.0051 |     - |     - |      32 B |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 3.0 |  30.95 ns | 0.1914 ns | 0.1696 ns |  31.00 ns |  0.62 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net461 |  53.48 ns | 0.0589 ns | 0.0551 ns |  53.46 ns |  1.07 |    0.00 | 0.0051 |     - |     - |      32 B |
               From_UShort_Nullable_WithValue_AsObject |        net472 |  54.52 ns | 0.2398 ns | 0.2126 ns |  54.59 ns |  1.09 |    0.00 | 0.0051 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_UShort_Nullable_NoValue | .NET Core 2.0 |  12.98 ns | 0.0231 ns | 0.0193 ns |  12.98 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 2.2 |  15.57 ns | 0.0294 ns | 0.0275 ns |  15.57 ns |  1.20 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 3.0 |  16.41 ns | 0.3551 ns | 0.7720 ns |  16.56 ns |  1.22 |    0.12 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net461 |  14.95 ns | 0.1323 ns | 0.1173 ns |  15.00 ns |  1.15 |    0.01 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net472 |  14.91 ns | 0.0277 ns | 0.0259 ns |  14.92 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.0 |  13.75 ns | 0.0350 ns | 0.0293 ns |  13.74 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.2 |  13.59 ns | 0.0372 ns | 0.0330 ns |  13.58 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 3.0 |  13.20 ns | 0.1108 ns | 0.1036 ns |  13.13 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net461 |  13.40 ns | 0.0163 ns | 0.0153 ns |  13.41 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net472 |  13.45 ns | 0.0203 ns | 0.0180 ns |  13.45 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_UInt | .NET Core 2.0 |  44.67 ns | 0.2675 ns | 0.2502 ns |  44.74 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
                                             From_UInt | .NET Core 2.2 |  29.36 ns | 0.0484 ns | 0.0404 ns |  29.34 ns |  0.66 |    0.00 | 0.0051 |     - |     - |      32 B |
                                             From_UInt | .NET Core 3.0 |  24.70 ns | 0.1285 ns | 0.1202 ns |  24.69 ns |  0.55 |    0.00 |      - |     - |     - |         - |
                                             From_UInt |        net461 |  48.51 ns | 0.0487 ns | 0.0455 ns |  48.53 ns |  1.09 |    0.01 | 0.0051 |     - |     - |      32 B |
                                             From_UInt |        net472 |  49.09 ns | 0.3642 ns | 0.3041 ns |  49.20 ns |  1.10 |    0.01 | 0.0051 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_UInt_AsObject | .NET Core 2.0 |  51.84 ns | 0.0775 ns | 0.0687 ns |  51.84 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
                                    From_UInt_AsObject | .NET Core 2.2 |  33.18 ns | 0.0478 ns | 0.0424 ns |  33.19 ns |  0.64 |    0.00 | 0.0051 |     - |     - |      32 B |
                                    From_UInt_AsObject | .NET Core 3.0 |  30.39 ns | 0.1386 ns | 0.1297 ns |  30.42 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net461 |  55.32 ns | 0.3852 ns | 0.3604 ns |  55.46 ns |  1.07 |    0.01 | 0.0051 |     - |     - |      32 B |
                                    From_UInt_AsObject |        net472 |  54.21 ns | 0.1207 ns | 0.1070 ns |  54.21 ns |  1.05 |    0.00 | 0.0051 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_UInt_Nullable_WithValue | .NET Core 2.0 |  45.95 ns | 0.0593 ns | 0.0555 ns |  45.96 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
                          From_UInt_Nullable_WithValue | .NET Core 2.2 |  29.19 ns | 0.0828 ns | 0.0691 ns |  29.17 ns |  0.64 |    0.00 | 0.0051 |     - |     - |      32 B |
                          From_UInt_Nullable_WithValue | .NET Core 3.0 |  25.00 ns | 0.0365 ns | 0.0324 ns |  25.00 ns |  0.54 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net461 |  53.90 ns | 0.0590 ns | 0.0523 ns |  53.92 ns |  1.17 |    0.00 | 0.0051 |     - |     - |      32 B |
                          From_UInt_Nullable_WithValue |        net472 |  49.01 ns | 0.0768 ns | 0.0718 ns |  48.99 ns |  1.07 |    0.00 | 0.0051 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.0 |  50.36 ns | 0.3207 ns | 0.3000 ns |  50.22 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.2 |  35.14 ns | 0.2761 ns | 0.2583 ns |  35.26 ns |  0.70 |    0.01 | 0.0051 |     - |     - |      32 B |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 3.0 |  30.80 ns | 0.1550 ns | 0.1450 ns |  30.84 ns |  0.61 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net461 |  59.86 ns | 0.1597 ns | 0.1416 ns |  59.82 ns |  1.19 |    0.01 | 0.0050 |     - |     - |      32 B |
                 From_UInt_Nullable_WithValue_AsObject |        net472 |  55.34 ns | 0.4597 ns | 0.4300 ns |  55.57 ns |  1.10 |    0.01 | 0.0051 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_UInt_Nullable_NoValue | .NET Core 2.0 |  14.75 ns | 0.1752 ns | 0.1639 ns |  14.77 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 2.2 |  13.15 ns | 0.0356 ns | 0.0297 ns |  13.14 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 3.0 |  12.52 ns | 0.0217 ns | 0.0203 ns |  12.52 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net461 |  13.39 ns | 0.1253 ns | 0.1172 ns |  13.44 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net472 |  13.41 ns | 0.0299 ns | 0.0250 ns |  13.41 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.0 |  14.02 ns | 0.0429 ns | 0.0358 ns |  14.02 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.2 |  12.70 ns | 0.0238 ns | 0.0211 ns |  12.70 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 3.0 |  15.05 ns | 0.3259 ns | 0.5708 ns |  15.33 ns |  1.04 |    0.06 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net461 |  13.41 ns | 0.0153 ns | 0.0143 ns |  13.41 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net472 |  14.01 ns | 0.0239 ns | 0.0224 ns |  14.00 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_ULong | .NET Core 2.0 |  47.64 ns | 0.1949 ns | 0.1727 ns |  47.65 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
                                            From_ULong | .NET Core 2.2 |  29.84 ns | 0.2253 ns | 0.2107 ns |  29.94 ns |  0.63 |    0.00 | 0.0051 |     - |     - |      32 B |
                                            From_ULong | .NET Core 3.0 |  25.52 ns | 0.0709 ns | 0.0663 ns |  25.52 ns |  0.54 |    0.00 |      - |     - |     - |         - |
                                            From_ULong |        net461 |  50.20 ns | 0.0788 ns | 0.0698 ns |  50.21 ns |  1.05 |    0.00 | 0.0051 |     - |     - |      32 B |
                                            From_ULong |        net472 |  50.26 ns | 0.3250 ns | 0.3040 ns |  50.45 ns |  1.05 |    0.01 | 0.0051 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_ULong_AsObject | .NET Core 2.0 |  53.09 ns | 0.0849 ns | 0.0753 ns |  53.10 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
                                   From_ULong_AsObject | .NET Core 2.2 |  35.61 ns | 0.0757 ns | 0.0671 ns |  35.59 ns |  0.67 |    0.00 | 0.0051 |     - |     - |      32 B |
                                   From_ULong_AsObject | .NET Core 3.0 |  29.93 ns | 0.0466 ns | 0.0436 ns |  29.93 ns |  0.56 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net461 |  55.92 ns | 0.3926 ns | 0.3673 ns |  56.07 ns |  1.05 |    0.01 | 0.0051 |     - |     - |      32 B |
                                   From_ULong_AsObject |        net472 |  54.15 ns | 0.2439 ns | 0.2162 ns |  54.06 ns |  1.02 |    0.00 | 0.0051 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_ULong_Nullable_WithValue | .NET Core 2.0 |  50.08 ns | 0.0784 ns | 0.0695 ns |  50.10 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
                         From_ULong_Nullable_WithValue | .NET Core 2.2 |  30.09 ns | 0.0621 ns | 0.0518 ns |  30.07 ns |  0.60 |    0.00 | 0.0051 |     - |     - |      32 B |
                         From_ULong_Nullable_WithValue | .NET Core 3.0 |  29.03 ns | 0.2434 ns | 0.2277 ns |  29.14 ns |  0.58 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net461 |  52.43 ns | 0.0755 ns | 0.0669 ns |  52.42 ns |  1.05 |    0.00 | 0.0051 |     - |     - |      32 B |
                         From_ULong_Nullable_WithValue |        net472 |  51.01 ns | 0.1119 ns | 0.1046 ns |  50.99 ns |  1.02 |    0.00 | 0.0051 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.0 |  53.75 ns | 0.3612 ns | 0.3378 ns |  53.71 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.2 |  34.75 ns | 0.1929 ns | 0.1506 ns |  34.78 ns |  0.65 |    0.01 | 0.0051 |     - |     - |      32 B |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 3.0 |  30.70 ns | 0.0706 ns | 0.0660 ns |  30.71 ns |  0.57 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net461 |  53.77 ns | 0.1014 ns | 0.0949 ns |  53.75 ns |  1.00 |    0.01 | 0.0051 |     - |     - |      32 B |
                From_ULong_Nullable_WithValue_AsObject |        net472 |  55.57 ns | 0.4972 ns | 0.4651 ns |  55.25 ns |  1.03 |    0.01 | 0.0051 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_ULong_Nullable_NoValue | .NET Core 2.0 |  13.44 ns | 0.0363 ns | 0.0339 ns |  13.45 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 2.2 |  13.43 ns | 0.0222 ns | 0.0207 ns |  13.43 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 3.0 |  14.16 ns | 0.0235 ns | 0.0220 ns |  14.17 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net461 |  14.04 ns | 0.1425 ns | 0.1333 ns |  14.12 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net472 |  13.89 ns | 0.0270 ns | 0.0239 ns |  13.88 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.0 |  13.46 ns | 0.0429 ns | 0.0402 ns |  13.46 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.2 |  13.20 ns | 0.0178 ns | 0.0149 ns |  13.20 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 3.0 |  13.02 ns | 0.1207 ns | 0.1129 ns |  13.02 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net461 |  13.40 ns | 0.0125 ns | 0.0111 ns |  13.40 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net472 |  13.46 ns | 0.0154 ns | 0.0144 ns |  13.46 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                       From_NullObject | .NET Core 2.0 |  13.85 ns | 0.0724 ns | 0.0604 ns |  13.85 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 2.2 |  12.50 ns | 0.1181 ns | 0.1105 ns |  12.55 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 3.0 |  12.96 ns | 0.1162 ns | 0.1087 ns |  13.01 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                                       From_NullObject |        net461 |  13.51 ns | 0.0262 ns | 0.0232 ns |  13.51 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject |        net472 |  14.30 ns | 0.0516 ns | 0.0483 ns |  14.31 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_DBNull | .NET Core 2.0 |  13.37 ns | 0.0264 ns | 0.0234 ns |  13.37 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 2.2 |  12.96 ns | 0.0118 ns | 0.0111 ns |  12.96 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 3.0 |  12.48 ns | 0.2673 ns | 0.3079 ns |  12.24 ns |  0.94 |    0.02 |      - |     - |     - |         - |
                                           From_DBNull |        net461 |  12.31 ns | 0.0783 ns | 0.0733 ns |  12.35 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                                           From_DBNull |        net472 |  12.09 ns | 0.0159 ns | 0.0141 ns |  12.09 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_DBNull_AsObject | .NET Core 2.0 |  13.47 ns | 0.0281 ns | 0.0263 ns |  13.47 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 2.2 |  15.81 ns | 0.0193 ns | 0.0180 ns |  15.81 ns |  1.17 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 3.0 |  13.06 ns | 0.2772 ns | 0.2847 ns |  12.89 ns |  0.97 |    0.02 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net461 |  13.71 ns | 0.1195 ns | 0.1118 ns |  13.72 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net472 |  13.67 ns | 0.0299 ns | 0.0279 ns |  13.67 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                 From_ConvertibleClass | .NET Core 2.0 |  16.42 ns | 0.0446 ns | 0.0418 ns |  16.43 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 2.2 |  15.41 ns | 0.0175 ns | 0.0155 ns |  15.41 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 3.0 |  14.40 ns | 0.3149 ns | 0.3868 ns |  14.64 ns |  0.89 |    0.02 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net461 |  17.47 ns | 0.0353 ns | 0.0330 ns |  17.48 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net472 |  17.79 ns | 0.1606 ns | 0.1502 ns |  17.86 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_ConvertibleClass_AsObject | .NET Core 2.0 |  17.76 ns | 0.0388 ns | 0.0344 ns |  17.76 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 2.2 |  19.03 ns | 0.0753 ns | 0.0704 ns |  19.01 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 3.0 |  16.64 ns | 0.3531 ns | 0.3468 ns |  16.91 ns |  0.94 |    0.02 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net461 |  17.83 ns | 0.1706 ns | 0.1596 ns |  17.96 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net472 |  19.19 ns | 0.1215 ns | 0.1137 ns |  19.15 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_ConvertibleClass_NoValue | .NET Core 2.0 |  13.90 ns | 0.0180 ns | 0.0168 ns |  13.90 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 2.2 |  13.31 ns | 0.0155 ns | 0.0138 ns |  13.31 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 3.0 |  12.98 ns | 0.0363 ns | 0.0322 ns |  12.98 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net461 |  15.08 ns | 0.0193 ns | 0.0161 ns |  15.07 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net472 |  14.95 ns | 0.0507 ns | 0.0423 ns |  14.95 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.0 |  15.52 ns | 0.0321 ns | 0.0301 ns |  15.52 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.2 |  13.50 ns | 0.1097 ns | 0.1026 ns |  13.53 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 3.0 |  13.58 ns | 0.1789 ns | 0.1673 ns |  13.49 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net461 |  14.17 ns | 0.0270 ns | 0.0252 ns |  14.17 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net472 |  13.45 ns | 0.0150 ns | 0.0133 ns |  13.46 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                              From_NonConvertibleClass | .NET Core 2.0 |  20.73 ns | 0.1494 ns | 0.1397 ns |  20.67 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 2.2 |  19.71 ns | 0.0294 ns | 0.0260 ns |  19.70 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 3.0 |  18.09 ns | 0.0326 ns | 0.0305 ns |  18.08 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net461 |  22.47 ns | 0.1044 ns | 0.0925 ns |  22.49 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net472 |  23.95 ns | 0.0621 ns | 0.0580 ns |  23.97 ns |  1.16 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                     From_NonConvertibleClass_AsObject | .NET Core 2.0 |  26.56 ns | 0.0656 ns | 0.0581 ns |  26.56 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 2.2 |  24.43 ns | 0.0667 ns | 0.0557 ns |  24.44 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 3.0 |  22.74 ns | 0.0931 ns | 0.0871 ns |  22.71 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net461 |  26.22 ns | 0.2205 ns | 0.2063 ns |  26.34 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net472 |  27.11 ns | 0.0382 ns | 0.0339 ns |  27.12 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                      From_NonConvertibleClass_NoValue | .NET Core 2.0 |  14.37 ns | 0.0324 ns | 0.0303 ns |  14.37 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 2.2 |  12.97 ns | 0.0202 ns | 0.0189 ns |  12.97 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 3.0 |  13.19 ns | 0.0125 ns | 0.0111 ns |  13.19 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net461 |  13.15 ns | 0.0111 ns | 0.0092 ns |  13.15 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net472 |  16.45 ns | 0.0326 ns | 0.0305 ns |  16.45 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.0 |  14.84 ns | 0.0198 ns | 0.0176 ns |  14.84 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.2 |  13.21 ns | 0.0132 ns | 0.0117 ns |  13.21 ns |  0.89 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 3.0 |  13.58 ns | 0.2850 ns | 0.2799 ns |  13.43 ns |  0.92 |    0.02 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net461 |  13.45 ns | 0.0208 ns | 0.0184 ns |  13.46 ns |  0.91 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net472 |  13.94 ns | 0.0392 ns | 0.0366 ns |  13.95 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                From_ConvertibleStruct | .NET Core 2.0 |  20.48 ns | 0.0535 ns | 0.0501 ns |  20.47 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 2.2 |  16.93 ns | 0.0210 ns | 0.0186 ns |  16.92 ns |  0.83 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 3.0 |  17.67 ns | 0.0951 ns | 0.0889 ns |  17.66 ns |  0.86 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net461 |  21.60 ns | 0.0864 ns | 0.0808 ns |  21.62 ns |  1.05 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net472 |  21.13 ns | 0.0503 ns | 0.0446 ns |  21.14 ns |  1.03 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                       From_ConvertibleStruct_AsObject | .NET Core 2.0 |  20.77 ns | 0.1376 ns | 0.1287 ns |  20.78 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 2.2 |  16.83 ns | 0.1601 ns | 0.1497 ns |  16.93 ns |  0.81 |    0.01 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 3.0 |  16.42 ns | 0.1138 ns | 0.1064 ns |  16.46 ns |  0.79 |    0.01 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net461 |  18.01 ns | 0.0207 ns | 0.0183 ns |  18.01 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net472 |  18.00 ns | 0.0143 ns | 0.0133 ns |  18.00 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.0 |  22.31 ns | 0.0362 ns | 0.0302 ns |  22.31 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.2 |  18.20 ns | 0.0475 ns | 0.0421 ns |  18.19 ns |  0.82 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 3.0 |  18.73 ns | 0.1428 ns | 0.1336 ns |  18.66 ns |  0.84 |    0.01 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net461 |  21.98 ns | 0.0274 ns | 0.0243 ns |  21.99 ns |  0.98 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net472 |  20.93 ns | 0.0435 ns | 0.0364 ns |  20.94 ns |  0.94 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 |  20.23 ns | 0.0290 ns | 0.0271 ns |  20.23 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 |  16.86 ns | 0.0708 ns | 0.0662 ns |  16.86 ns |  0.83 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 |  16.68 ns | 0.1089 ns | 0.1019 ns |  16.70 ns |  0.82 |    0.01 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net461 |  18.27 ns | 0.1570 ns | 0.1468 ns |  18.35 ns |  0.90 |    0.01 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net472 |  17.99 ns | 0.0424 ns | 0.0376 ns |  17.97 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.0 |  15.69 ns | 0.0228 ns | 0.0202 ns |  15.69 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.2 |  13.56 ns | 0.0112 ns | 0.0099 ns |  13.56 ns |  0.86 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 3.0 |  13.17 ns | 0.3400 ns | 0.4048 ns |  13.03 ns |  0.84 |    0.03 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net461 |  14.69 ns | 0.0206 ns | 0.0192 ns |  14.69 ns |  0.94 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net472 |  14.78 ns | 0.0249 ns | 0.0221 ns |  14.78 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 |  13.60 ns | 0.0235 ns | 0.0220 ns |  13.60 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 |  12.36 ns | 0.0177 ns | 0.0148 ns |  12.36 ns |  0.91 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 |  14.04 ns | 0.3007 ns | 0.4015 ns |  13.98 ns |  1.05 |    0.03 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net461 |  13.42 ns | 0.0255 ns | 0.0239 ns |  13.42 ns |  0.99 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net472 |  14.60 ns | 0.0299 ns | 0.0279 ns |  14.60 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_NonConvertibleStruct | .NET Core 2.0 |  27.41 ns | 0.0366 ns | 0.0342 ns |  27.40 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                             From_NonConvertibleStruct | .NET Core 2.2 |  22.94 ns | 0.0277 ns | 0.0245 ns |  22.94 ns |  0.84 |    0.00 | 0.0038 |     - |     - |      24 B |
                             From_NonConvertibleStruct | .NET Core 3.0 |  20.78 ns | 0.2958 ns | 0.2767 ns |  20.63 ns |  0.76 |    0.01 | 0.0038 |     - |     - |      24 B |
                             From_NonConvertibleStruct |        net461 |  25.17 ns | 0.0493 ns | 0.0437 ns |  25.17 ns |  0.92 |    0.00 | 0.0038 |     - |     - |      24 B |
                             From_NonConvertibleStruct |        net472 |  25.95 ns | 0.0371 ns | 0.0347 ns |  25.94 ns |  0.95 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.0 |  27.37 ns | 0.0411 ns | 0.0365 ns |  27.37 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.2 |  23.98 ns | 0.1428 ns | 0.1335 ns |  24.02 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 3.0 |  23.29 ns | 1.0627 ns | 1.2651 ns |  22.68 ns |  0.86 |    0.05 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net461 |  26.35 ns | 0.0269 ns | 0.0238 ns |  26.34 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net472 |  26.21 ns | 0.0245 ns | 0.0230 ns |  26.22 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.0 |  28.30 ns | 0.0498 ns | 0.0466 ns |  28.30 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.2 |  26.68 ns | 0.0217 ns | 0.0192 ns |  26.67 ns |  0.94 |    0.00 | 0.0038 |     - |     - |      24 B |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 3.0 |  21.51 ns | 0.0787 ns | 0.0698 ns |  21.50 ns |  0.76 |    0.00 | 0.0038 |     - |     - |      24 B |
          From_NonConvertibleStruct_Nullable_WithValue |        net461 |  27.09 ns | 0.0438 ns | 0.0410 ns |  27.09 ns |  0.96 |    0.00 | 0.0038 |     - |     - |      24 B |
          From_NonConvertibleStruct_Nullable_WithValue |        net472 |  26.63 ns | 0.1156 ns | 0.1082 ns |  26.66 ns |  0.94 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 |  27.49 ns | 0.0499 ns | 0.0443 ns |  27.48 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 |  24.96 ns | 0.0331 ns | 0.0310 ns |  24.94 ns |  0.91 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 |  22.64 ns | 0.3072 ns | 0.2874 ns |  22.79 ns |  0.82 |    0.01 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net461 |  26.66 ns | 0.2462 ns | 0.2303 ns |  26.82 ns |  0.97 |    0.01 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net472 |  26.98 ns | 0.0373 ns | 0.0331 ns |  26.98 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.0 |  13.35 ns | 0.0287 ns | 0.0254 ns |  13.35 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.2 |  12.13 ns | 0.0380 ns | 0.0337 ns |  12.14 ns |  0.91 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 3.0 |  12.17 ns | 0.1132 ns | 0.1059 ns |  12.11 ns |  0.91 |    0.01 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net461 |  12.48 ns | 0.0144 ns | 0.0121 ns |  12.48 ns |  0.93 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net472 |  13.83 ns | 0.0184 ns | 0.0172 ns |  13.83 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 |  14.35 ns | 0.0240 ns | 0.0213 ns |  14.36 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 |  12.32 ns | 0.0214 ns | 0.0179 ns |  12.32 ns |  0.86 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 |  13.42 ns | 0.0179 ns | 0.0168 ns |  13.42 ns |  0.93 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net461 |  13.42 ns | 0.0159 ns | 0.0141 ns |  13.42 ns |  0.93 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net472 |  13.49 ns | 0.1468 ns | 0.1373 ns |  13.41 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Enum | .NET Core 2.0 |  38.24 ns | 0.0487 ns | 0.0456 ns |  38.25 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 2.2 |  36.72 ns | 0.0691 ns | 0.0613 ns |  36.72 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 3.0 |  34.17 ns | 0.0358 ns | 0.0334 ns |  34.17 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                             From_Enum |        net461 |  42.49 ns | 0.3415 ns | 0.3194 ns |  42.67 ns |  1.11 |    0.01 |      - |     - |     - |         - |
                                             From_Enum |        net472 |  41.75 ns | 0.0666 ns | 0.0590 ns |  41.76 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Enum_AsObject | .NET Core 2.0 |  68.05 ns | 0.1805 ns | 0.1689 ns |  68.01 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Enum_AsObject | .NET Core 2.2 |  64.09 ns | 0.4111 ns | 0.3644 ns |  64.21 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                                    From_Enum_AsObject | .NET Core 3.0 |  45.17 ns | 0.8816 ns | 0.8658 ns |  45.05 ns |  0.66 |    0.01 |      - |     - |     - |         - |
                                    From_Enum_AsObject |        net461 | 305.99 ns | 0.3840 ns | 0.3592 ns | 305.91 ns |  4.50 |    0.01 | 0.0076 |     - |     - |      48 B |
                                    From_Enum_AsObject |        net472 | 304.32 ns | 0.3965 ns | 0.3709 ns | 304.30 ns |  4.47 |    0.01 | 0.0076 |     - |     - |      48 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Enum_Nullable_WithValue | .NET Core 2.0 |  41.23 ns | 0.4420 ns | 0.4134 ns |  40.98 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 2.2 |  37.37 ns | 0.0516 ns | 0.0483 ns |  37.36 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 3.0 |  34.08 ns | 0.0536 ns | 0.0475 ns |  34.08 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net461 |  42.60 ns | 0.0941 ns | 0.0881 ns |  42.60 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net472 |  43.26 ns | 0.3840 ns | 0.3592 ns |  43.44 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.0 |  65.91 ns | 0.1175 ns | 0.1041 ns |  65.89 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.2 |  63.37 ns | 0.1582 ns | 0.1480 ns |  63.32 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 3.0 |  48.18 ns | 0.1938 ns | 0.1619 ns |  48.19 ns |  0.73 |    0.00 |      - |     - |     - |         - |
                 From_Enum_Nullable_WithValue_AsObject |        net461 | 308.26 ns | 0.3946 ns | 0.3498 ns | 308.22 ns |  4.68 |    0.01 | 0.0076 |     - |     - |      48 B |
                 From_Enum_Nullable_WithValue_AsObject |        net472 | 314.39 ns | 0.3989 ns | 0.3731 ns | 314.34 ns |  4.77 |    0.01 | 0.0076 |     - |     - |      48 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Enum_Nullable_NoValue | .NET Core 2.0 |  14.01 ns | 0.1478 ns | 0.1382 ns |  13.96 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 2.2 |  12.56 ns | 0.0397 ns | 0.0371 ns |  12.57 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 3.0 |  12.43 ns | 0.0301 ns | 0.0251 ns |  12.43 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net461 |  14.84 ns | 0.1215 ns | 0.1136 ns |  14.89 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net472 |  15.05 ns | 0.0257 ns | 0.0240 ns |  15.04 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.0 |  14.09 ns | 0.0218 ns | 0.0204 ns |  14.09 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.2 |  12.34 ns | 0.0338 ns | 0.0283 ns |  12.33 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 3.0 |  16.21 ns | 0.2335 ns | 0.2070 ns |  16.22 ns |  1.15 |    0.01 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net461 |  13.40 ns | 0.0215 ns | 0.0180 ns |  13.40 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net472 |  13.53 ns | 0.1232 ns | 0.1153 ns |  13.59 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                      From_ParentClass | .NET Core 2.0 |  20.45 ns | 0.0286 ns | 0.0268 ns |  20.44 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 2.2 |  21.14 ns | 0.0363 ns | 0.0339 ns |  21.13 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 3.0 |  17.77 ns | 0.1311 ns | 0.1226 ns |  17.72 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                                      From_ParentClass |        net461 |  21.03 ns | 0.0470 ns | 0.0440 ns |  21.02 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass |        net472 |  21.80 ns | 0.0260 ns | 0.0243 ns |  21.80 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_ParentClass_AsObject | .NET Core 2.0 |  27.92 ns | 0.0749 ns | 0.0664 ns |  27.90 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 2.2 |  24.66 ns | 0.1233 ns | 0.1153 ns |  24.68 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 3.0 |  22.91 ns | 0.1866 ns | 0.1654 ns |  23.02 ns |  0.82 |    0.01 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net461 |  27.20 ns | 0.0271 ns | 0.0212 ns |  27.20 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net472 |  27.03 ns | 0.0411 ns | 0.0385 ns |  27.03 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                              From_ParentClass_NoValue | .NET Core 2.0 |  15.66 ns | 0.0230 ns | 0.0204 ns |  15.67 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 2.2 |  12.14 ns | 0.0166 ns | 0.0155 ns |  12.14 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 3.0 |  13.25 ns | 0.0114 ns | 0.0089 ns |  13.25 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net461 |  13.15 ns | 0.0198 ns | 0.0176 ns |  13.15 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net472 |  14.61 ns | 0.0146 ns | 0.0137 ns |  14.61 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.0 |  15.65 ns | 0.0155 ns | 0.0145 ns |  15.66 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.2 |  12.35 ns | 0.0147 ns | 0.0137 ns |  12.35 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 3.0 |  13.48 ns | 0.1244 ns | 0.1163 ns |  13.48 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net461 |  13.45 ns | 0.0204 ns | 0.0170 ns |  13.46 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net472 |  13.37 ns | 0.0231 ns | 0.0217 ns |  13.38 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_ParentStruct | .NET Core 2.0 |  94.91 ns | 0.1301 ns | 0.1154 ns |  94.88 ns |  1.00 |    0.00 | 0.0851 |     - |     - |     536 B |
                                     From_ParentStruct | .NET Core 2.2 |  93.26 ns | 0.7302 ns | 0.6473 ns |  93.54 ns |  0.98 |    0.01 | 0.0851 |     - |     - |     536 B |
                                     From_ParentStruct | .NET Core 3.0 |  95.26 ns | 0.7507 ns | 0.6655 ns |  95.10 ns |  1.00 |    0.01 | 0.0854 |     - |     - |     536 B |
                                     From_ParentStruct |        net461 |  97.98 ns | 1.4741 ns | 1.3788 ns |  97.89 ns |  1.03 |    0.01 | 0.0851 |     - |     - |     536 B |
                                     From_ParentStruct |        net472 | 107.37 ns | 0.2546 ns | 0.2126 ns | 107.31 ns |  1.13 |    0.00 | 0.0851 |     - |     - |     536 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_ParentStruct_AsObject | .NET Core 2.0 |  26.54 ns | 0.2016 ns | 0.1886 ns |  26.46 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 2.2 |  24.35 ns | 0.0325 ns | 0.0288 ns |  24.35 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 3.0 |  23.61 ns | 0.1766 ns | 0.1652 ns |  23.69 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net461 |  27.12 ns | 0.1663 ns | 0.1555 ns |  27.16 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net472 |  28.81 ns | 0.1521 ns | 0.1348 ns |  28.77 ns |  1.09 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.0 | 120.95 ns | 0.4985 ns | 0.4663 ns | 120.97 ns |  1.00 |    0.00 | 0.0851 |     - |     - |     536 B |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.2 | 118.53 ns | 0.4358 ns | 0.4077 ns | 118.56 ns |  0.98 |    0.00 | 0.0851 |     - |     - |     536 B |
                  From_ParentStruct_Nullable_WithValue | .NET Core 3.0 | 128.35 ns | 0.7480 ns | 0.6997 ns | 128.30 ns |  1.06 |    0.01 | 0.0854 |     - |     - |     536 B |
                  From_ParentStruct_Nullable_WithValue |        net461 | 124.08 ns | 0.4749 ns | 0.3965 ns | 124.07 ns |  1.03 |    0.01 | 0.0851 |     - |     - |     536 B |
                  From_ParentStruct_Nullable_WithValue |        net472 | 119.74 ns | 0.3239 ns | 0.2705 ns | 119.64 ns |  0.99 |    0.00 | 0.0851 |     - |     - |     536 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.0 |  26.44 ns | 0.1885 ns | 0.1763 ns |  26.45 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.2 |  24.57 ns | 0.2315 ns | 0.2166 ns |  24.43 ns |  0.93 |    0.01 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 3.0 |  22.62 ns | 0.1765 ns | 0.1651 ns |  22.61 ns |  0.86 |    0.01 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net461 |  29.30 ns | 0.0479 ns | 0.0448 ns |  29.29 ns |  1.11 |    0.01 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net472 |  28.07 ns | 0.0421 ns | 0.0394 ns |  28.07 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.0 |  57.39 ns | 0.3018 ns | 0.2675 ns |  57.48 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.2 |  55.48 ns | 0.0663 ns | 0.0518 ns |  55.48 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 3.0 |  57.47 ns | 0.1212 ns | 0.1133 ns |  57.46 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net461 |  60.37 ns | 0.1113 ns | 0.0986 ns |  60.36 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net472 |  58.36 ns | 0.2650 ns | 0.2349 ns |  58.42 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.0 |  13.91 ns | 0.0170 ns | 0.0142 ns |  13.92 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.2 |  12.33 ns | 0.0113 ns | 0.0106 ns |  12.33 ns |  0.89 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 3.0 |  13.55 ns | 0.1950 ns | 0.1629 ns |  13.57 ns |  0.97 |    0.01 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net461 |  13.72 ns | 0.0382 ns | 0.0338 ns |  13.71 ns |  0.99 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net472 |  13.39 ns | 0.0222 ns | 0.0196 ns |  13.39 ns |  0.96 |    0.00 |      - |     - |     - |         - |
