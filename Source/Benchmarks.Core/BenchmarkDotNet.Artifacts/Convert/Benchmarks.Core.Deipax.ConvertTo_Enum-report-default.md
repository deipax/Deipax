
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
                                             From_Bool | .NET Core 2.0 |  24.305 ns | 0.1380 ns | 0.1291 ns |  24.354 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 2.2 |  22.145 ns | 0.1692 ns | 0.1582 ns |  22.065 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 3.0 |  14.531 ns | 0.0233 ns | 0.0206 ns |  14.539 ns |  0.60 |    0.00 |      - |     - |     - |         - |
                                             From_Bool |        net461 |  24.953 ns | 0.0445 ns | 0.0417 ns |  24.951 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                             From_Bool |        net472 |  23.310 ns | 0.0284 ns | 0.0265 ns |  23.311 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                    From_Bool_AsObject | .NET Core 2.0 |  33.570 ns | 0.0588 ns | 0.0521 ns |  33.571 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 2.2 |  29.097 ns | 0.1240 ns | 0.1160 ns |  29.070 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 3.0 |  27.230 ns | 0.0481 ns | 0.0450 ns |  27.234 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net461 |  41.644 ns | 0.0696 ns | 0.0651 ns |  41.643 ns |  1.24 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net472 |  44.882 ns | 0.1032 ns | 0.0915 ns |  44.858 ns |  1.34 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                          From_Bool_Nullable_WithValue | .NET Core 2.0 |  26.741 ns | 0.0103 ns | 0.0091 ns |  26.739 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 2.2 |  25.777 ns | 0.0323 ns | 0.0287 ns |  25.783 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 3.0 |  14.139 ns | 0.0294 ns | 0.0275 ns |  14.141 ns |  0.53 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net461 |  25.718 ns | 0.3136 ns | 0.2934 ns |  25.829 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net472 |  25.519 ns | 0.0368 ns | 0.0344 ns |  25.514 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.0 |  32.042 ns | 0.2555 ns | 0.2390 ns |  32.121 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.2 |  36.408 ns | 0.1202 ns | 0.0938 ns |  36.378 ns |  1.13 |    0.01 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 3.0 |  26.326 ns | 0.0548 ns | 0.0458 ns |  26.319 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net461 |  44.294 ns | 0.0614 ns | 0.0544 ns |  44.298 ns |  1.38 |    0.01 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net472 |  47.539 ns | 0.3247 ns | 0.3037 ns |  47.609 ns |  1.48 |    0.02 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                            From_Bool_Nullable_NoValue | .NET Core 2.0 |  11.840 ns | 0.0276 ns | 0.0244 ns |  11.840 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 2.2 |  10.448 ns | 0.0176 ns | 0.0164 ns |  10.450 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 3.0 |   6.737 ns | 0.0797 ns | 0.0745 ns |   6.775 ns |  0.57 |    0.01 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net461 |  10.566 ns | 0.0305 ns | 0.0285 ns |  10.559 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net472 |  11.890 ns | 0.0180 ns | 0.0150 ns |  11.886 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.0 |  11.491 ns | 0.0158 ns | 0.0148 ns |  11.490 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.2 |  10.981 ns | 0.2299 ns | 0.2151 ns |  10.909 ns |  0.96 |    0.02 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 3.0 |  11.448 ns | 0.0283 ns | 0.0265 ns |  11.448 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net461 |  11.857 ns | 0.0934 ns | 0.0874 ns |  11.853 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net472 |  14.831 ns | 0.0315 ns | 0.0295 ns |  14.828 ns |  1.29 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                             From_Byte | .NET Core 2.0 |  23.823 ns | 0.0640 ns | 0.0568 ns |  23.804 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 2.2 |  22.036 ns | 0.1261 ns | 0.1179 ns |  21.976 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 3.0 |  13.420 ns | 0.0433 ns | 0.0405 ns |  13.415 ns |  0.56 |    0.00 |      - |     - |     - |         - |
                                             From_Byte |        net461 |  23.549 ns | 0.0385 ns | 0.0360 ns |  23.551 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                             From_Byte |        net472 |  23.168 ns | 0.1843 ns | 0.1724 ns |  23.231 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                    From_Byte_AsObject | .NET Core 2.0 |  31.734 ns | 0.0980 ns | 0.0917 ns |  31.719 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 2.2 |  28.829 ns | 0.0287 ns | 0.0268 ns |  28.822 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 3.0 |  26.970 ns | 0.0440 ns | 0.0411 ns |  26.969 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net461 |  42.435 ns | 0.0646 ns | 0.0604 ns |  42.441 ns |  1.34 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net472 |  42.310 ns | 0.0447 ns | 0.0418 ns |  42.306 ns |  1.33 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                          From_Byte_Nullable_WithValue | .NET Core 2.0 |  26.589 ns | 0.0410 ns | 0.0364 ns |  26.598 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 2.2 |  24.712 ns | 0.0538 ns | 0.0504 ns |  24.714 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 3.0 |  14.391 ns | 0.0989 ns | 0.0925 ns |  14.396 ns |  0.54 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net461 |  25.574 ns | 0.0404 ns | 0.0316 ns |  25.575 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net472 |  25.318 ns | 0.0351 ns | 0.0311 ns |  25.321 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.0 |  31.470 ns | 0.1574 ns | 0.1229 ns |  31.505 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.2 |  35.564 ns | 0.1371 ns | 0.1145 ns |  35.552 ns |  1.13 |    0.01 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 3.0 |  26.110 ns | 0.0465 ns | 0.0413 ns |  26.108 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net461 |  45.430 ns | 0.1171 ns | 0.1038 ns |  45.457 ns |  1.44 |    0.01 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net472 |  45.559 ns | 0.0924 ns | 0.0721 ns |  45.523 ns |  1.45 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                            From_Byte_Nullable_NoValue | .NET Core 2.0 |  11.840 ns | 0.0634 ns | 0.0593 ns |  11.815 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 2.2 |  10.444 ns | 0.0080 ns | 0.0075 ns |  10.446 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 3.0 |   6.963 ns | 0.0586 ns | 0.0520 ns |   6.977 ns |  0.59 |    0.01 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net461 |  11.137 ns | 0.0294 ns | 0.0260 ns |  11.136 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net472 |  10.590 ns | 0.0114 ns | 0.0107 ns |  10.588 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.0 |  11.465 ns | 0.0265 ns | 0.0222 ns |  11.464 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.2 |  10.607 ns | 0.0828 ns | 0.0774 ns |  10.580 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 3.0 |  11.251 ns | 0.1759 ns | 0.1646 ns |  11.130 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net461 |  11.889 ns | 0.0848 ns | 0.0793 ns |  11.865 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net472 |  13.521 ns | 0.0309 ns | 0.0289 ns |  13.520 ns |  1.18 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                             From_Char | .NET Core 2.0 |  23.791 ns | 0.0335 ns | 0.0279 ns |  23.791 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Char | .NET Core 2.2 |  21.859 ns | 0.0173 ns | 0.0135 ns |  21.863 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                             From_Char | .NET Core 3.0 |  12.953 ns | 0.0200 ns | 0.0187 ns |  12.955 ns |  0.54 |    0.00 |      - |     - |     - |         - |
                                             From_Char |        net461 |  23.519 ns | 0.0485 ns | 0.0454 ns |  23.518 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                             From_Char |        net472 |  23.057 ns | 0.2188 ns | 0.2047 ns |  22.934 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                    From_Char_AsObject | .NET Core 2.0 |  32.080 ns | 0.0757 ns | 0.0591 ns |  32.080 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 2.2 |  29.714 ns | 0.0441 ns | 0.0368 ns |  29.709 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 3.0 |  27.085 ns | 0.1266 ns | 0.1122 ns |  27.116 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject |        net461 |  41.515 ns | 0.0871 ns | 0.0815 ns |  41.502 ns |  1.29 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject |        net472 |  42.628 ns | 0.0512 ns | 0.0454 ns |  42.621 ns |  1.33 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                          From_Char_Nullable_WithValue | .NET Core 2.0 |  26.172 ns | 0.0371 ns | 0.0329 ns |  26.181 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 2.2 |  24.711 ns | 0.1770 ns | 0.1656 ns |  24.628 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 3.0 |  14.030 ns | 0.0250 ns | 0.0234 ns |  14.033 ns |  0.54 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net461 |  25.472 ns | 0.1542 ns | 0.1442 ns |  25.441 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net472 |  25.282 ns | 0.3348 ns | 0.2968 ns |  25.171 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.0 |  31.783 ns | 0.0853 ns | 0.0712 ns |  31.789 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.2 |  29.699 ns | 0.0494 ns | 0.0463 ns |  29.698 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 3.0 |  26.715 ns | 0.0682 ns | 0.0638 ns |  26.708 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net461 |  41.862 ns | 0.1377 ns | 0.1221 ns |  41.859 ns |  1.32 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net472 |  45.656 ns | 0.2952 ns | 0.2617 ns |  45.632 ns |  1.44 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                            From_Char_Nullable_NoValue | .NET Core 2.0 |  11.832 ns | 0.0294 ns | 0.0261 ns |  11.827 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 2.2 |  10.416 ns | 0.0164 ns | 0.0145 ns |  10.416 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 3.0 |   6.978 ns | 0.0905 ns | 0.0846 ns |   6.964 ns |  0.59 |    0.01 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net461 |  10.586 ns | 0.0236 ns | 0.0221 ns |  10.583 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net472 |  10.582 ns | 0.0221 ns | 0.0207 ns |  10.583 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.0 |  11.489 ns | 0.0234 ns | 0.0219 ns |  11.486 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.2 |  10.604 ns | 0.0926 ns | 0.0866 ns |  10.559 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 3.0 |  11.360 ns | 0.1020 ns | 0.0904 ns |  11.392 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net461 |  11.657 ns | 0.0358 ns | 0.0318 ns |  11.656 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net472 |  13.021 ns | 0.1524 ns | 0.1426 ns |  12.940 ns |  1.13 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                         From_DateTime | .NET Core 2.0 |  26.797 ns | 0.0613 ns | 0.0573 ns |  26.801 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 2.2 |  26.192 ns | 0.0334 ns | 0.0260 ns |  26.189 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 3.0 |  12.945 ns | 0.2107 ns | 0.1971 ns |  13.057 ns |  0.48 |    0.01 |      - |     - |     - |         - |
                                         From_DateTime |        net461 |  27.101 ns | 0.2369 ns | 0.2216 ns |  27.111 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                         From_DateTime |        net472 |  29.951 ns | 0.0287 ns | 0.0268 ns |  29.950 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                From_DateTime_AsObject | .NET Core 2.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 2.2 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 3.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net461 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net472 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                      From_DateTime_Nullable_WithValue | .NET Core 2.0 |  27.091 ns | 0.0490 ns | 0.0434 ns |  27.074 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 2.2 |  26.532 ns | 0.0421 ns | 0.0373 ns |  26.539 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 3.0 |  13.960 ns | 0.0245 ns | 0.0205 ns |  13.952 ns |  0.52 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net461 |  27.545 ns | 0.0327 ns | 0.0306 ns |  27.555 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net472 |  26.486 ns | 0.0272 ns | 0.0255 ns |  26.485 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.2 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 3.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net461 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net472 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                        From_DateTime_Nullable_NoValue | .NET Core 2.0 |  12.825 ns | 0.0707 ns | 0.0662 ns |  12.833 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 2.2 |  11.585 ns | 0.0824 ns | 0.0771 ns |  11.611 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 3.0 |   8.644 ns | 0.0210 ns | 0.0196 ns |   8.648 ns |  0.67 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net461 |  13.153 ns | 0.1016 ns | 0.0901 ns |  13.163 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net472 |  12.979 ns | 0.0276 ns | 0.0258 ns |  12.987 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.0 |  11.497 ns | 0.0259 ns | 0.0242 ns |  11.508 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.2 |  10.541 ns | 0.0114 ns | 0.0101 ns |  10.538 ns |  0.92 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 3.0 |  11.232 ns | 0.2480 ns | 0.3311 ns |  11.006 ns |  0.99 |    0.03 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net461 |  11.653 ns | 0.0273 ns | 0.0242 ns |  11.651 ns |  1.01 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net472 |  11.804 ns | 0.0965 ns | 0.0902 ns |  11.775 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                          From_Decimal | .NET Core 2.0 |  36.569 ns | 0.0481 ns | 0.0450 ns |  36.577 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 2.2 |  33.234 ns | 0.0689 ns | 0.0611 ns |  33.236 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 3.0 |  19.633 ns | 0.0584 ns | 0.0517 ns |  19.635 ns |  0.54 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal |        net461 |  34.119 ns | 0.1045 ns | 0.0977 ns |  34.106 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal |        net472 |  34.330 ns | 0.0588 ns | 0.0550 ns |  34.341 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                 From_Decimal_AsObject | .NET Core 2.0 |  42.784 ns | 0.0653 ns | 0.0579 ns |  42.787 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 2.2 |  40.611 ns | 0.3474 ns | 0.3079 ns |  40.754 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 3.0 |  32.671 ns | 0.1901 ns | 0.1685 ns |  32.687 ns |  0.76 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net461 |  49.839 ns | 0.2715 ns | 0.2539 ns |  49.756 ns |  1.17 |    0.01 |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net472 |  48.628 ns | 0.1428 ns | 0.1266 ns |  48.639 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                       From_Decimal_Nullable_WithValue | .NET Core 2.0 |  35.276 ns | 0.0900 ns | 0.0798 ns |  35.289 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 2.2 |  33.598 ns | 0.0500 ns | 0.0468 ns |  33.595 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 3.0 |  22.267 ns | 0.1330 ns | 0.1244 ns |  22.329 ns |  0.63 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net461 |  35.682 ns | 0.1075 ns | 0.0953 ns |  35.673 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net472 |  35.362 ns | 0.0470 ns | 0.0392 ns |  35.360 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.0 |  43.639 ns | 0.0573 ns | 0.0536 ns |  43.640 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.2 |  40.053 ns | 0.0413 ns | 0.0366 ns |  40.059 ns |  0.92 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 3.0 |  29.852 ns | 0.1344 ns | 0.1257 ns |  29.781 ns |  0.68 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net461 |  48.811 ns | 0.0893 ns | 0.0835 ns |  48.814 ns |  1.12 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net472 |  51.277 ns | 0.1893 ns | 0.1678 ns |  51.257 ns |  1.18 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                         From_Decimal_Nullable_NoValue | .NET Core 2.0 |  12.686 ns | 0.0223 ns | 0.0208 ns |  12.694 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 2.2 |  11.552 ns | 0.1042 ns | 0.0974 ns |  11.567 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 3.0 |   8.871 ns | 0.0694 ns | 0.0649 ns |   8.893 ns |  0.70 |    0.01 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net461 |  16.898 ns | 0.0234 ns | 0.0195 ns |  16.901 ns |  1.33 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net472 |  13.781 ns | 0.0675 ns | 0.0631 ns |  13.751 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.0 |  11.327 ns | 0.0107 ns | 0.0100 ns |  11.327 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.2 |  10.522 ns | 0.0164 ns | 0.0145 ns |  10.522 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 3.0 |  11.897 ns | 0.0500 ns | 0.0468 ns |  11.894 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net461 |  14.679 ns | 0.2568 ns | 0.2402 ns |  14.647 ns |  1.30 |    0.02 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net472 |  14.663 ns | 0.0251 ns | 0.0196 ns |  14.665 ns |  1.29 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                           From_Double | .NET Core 2.0 |  26.895 ns | 0.1016 ns | 0.0950 ns |  26.872 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 2.2 |  25.044 ns | 0.0293 ns | 0.0260 ns |  25.033 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 3.0 |  15.688 ns | 0.0752 ns | 0.0667 ns |  15.663 ns |  0.58 |    0.00 |      - |     - |     - |         - |
                                           From_Double |        net461 |  25.578 ns | 0.0570 ns | 0.0476 ns |  25.581 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                           From_Double |        net472 |  25.809 ns | 0.0439 ns | 0.0411 ns |  25.805 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                  From_Double_AsObject | .NET Core 2.0 |  33.194 ns | 0.0430 ns | 0.0403 ns |  33.208 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 2.2 |  30.602 ns | 0.0330 ns | 0.0309 ns |  30.603 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 3.0 |  28.405 ns | 0.1965 ns | 0.1641 ns |  28.471 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                                  From_Double_AsObject |        net461 |  48.317 ns | 0.2299 ns | 0.1920 ns |  48.346 ns |  1.46 |    0.01 |      - |     - |     - |         - |
                                  From_Double_AsObject |        net472 |  47.400 ns | 0.0966 ns | 0.0857 ns |  47.382 ns |  1.43 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                        From_Double_Nullable_WithValue | .NET Core 2.0 |  30.224 ns | 0.0598 ns | 0.0559 ns |  30.232 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 2.2 |  28.622 ns | 0.0405 ns | 0.0359 ns |  28.629 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 3.0 |  16.819 ns | 0.3548 ns | 0.3485 ns |  16.615 ns |  0.56 |    0.01 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net461 |  30.098 ns | 0.0613 ns | 0.0544 ns |  30.117 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net472 |  29.814 ns | 0.0533 ns | 0.0445 ns |  29.819 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.0 |  32.613 ns | 0.0633 ns | 0.0561 ns |  32.607 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.2 |  37.612 ns | 0.0634 ns | 0.0594 ns |  37.600 ns |  1.15 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 3.0 |  27.808 ns | 0.0356 ns | 0.0278 ns |  27.802 ns |  0.85 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net461 |  43.016 ns | 0.1387 ns | 0.1230 ns |  42.958 ns |  1.32 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net472 |  47.056 ns | 0.0329 ns | 0.0275 ns |  47.065 ns |  1.44 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                          From_Double_Nullable_NoValue | .NET Core 2.0 |  12.821 ns | 0.0135 ns | 0.0126 ns |  12.822 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 2.2 |  11.393 ns | 0.0173 ns | 0.0154 ns |  11.392 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 3.0 |   8.458 ns | 0.0836 ns | 0.0782 ns |   8.505 ns |  0.66 |    0.01 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net461 |  12.940 ns | 0.0760 ns | 0.0711 ns |  12.918 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net472 |  12.881 ns | 0.0969 ns | 0.0906 ns |  12.843 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.0 |  13.448 ns | 0.0198 ns | 0.0175 ns |  13.449 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.2 |  10.543 ns | 0.0150 ns | 0.0140 ns |  10.543 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 3.0 |  12.016 ns | 0.1021 ns | 0.0955 ns |  11.964 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net461 |  11.655 ns | 0.0268 ns | 0.0237 ns |  11.663 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net472 |  12.503 ns | 0.0175 ns | 0.0146 ns |  12.504 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                            From_Short | .NET Core 2.0 |  23.498 ns | 0.0316 ns | 0.0280 ns |  23.505 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 2.2 |  22.108 ns | 0.1843 ns | 0.1724 ns |  22.222 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                                            From_Short | .NET Core 3.0 |  13.307 ns | 0.0863 ns | 0.0808 ns |  13.296 ns |  0.57 |    0.00 |      - |     - |     - |         - |
                                            From_Short |        net461 |  28.480 ns | 0.0789 ns | 0.0699 ns |  28.476 ns |  1.21 |    0.00 |      - |     - |     - |         - |
                                            From_Short |        net472 |  23.161 ns | 0.1305 ns | 0.1157 ns |  23.212 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                   From_Short_AsObject | .NET Core 2.0 |  34.723 ns | 0.1732 ns | 0.1620 ns |  34.767 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 2.2 |  28.828 ns | 0.0229 ns | 0.0203 ns |  28.828 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 3.0 |  26.889 ns | 0.1645 ns | 0.1539 ns |  26.941 ns |  0.77 |    0.01 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net461 |  43.436 ns | 0.2513 ns | 0.2227 ns |  43.514 ns |  1.25 |    0.01 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net472 |  45.636 ns | 0.0942 ns | 0.0835 ns |  45.635 ns |  1.31 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                         From_Short_Nullable_WithValue | .NET Core 2.0 |  26.241 ns | 0.0451 ns | 0.0377 ns |  26.253 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 2.2 |  24.588 ns | 0.0340 ns | 0.0302 ns |  24.593 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 3.0 |  14.180 ns | 0.0900 ns | 0.0798 ns |  14.207 ns |  0.54 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net461 |  26.260 ns | 0.0780 ns | 0.0729 ns |  26.247 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net472 |  25.259 ns | 0.1121 ns | 0.1049 ns |  25.234 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.0 |  31.903 ns | 0.0694 ns | 0.0649 ns |  31.895 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.2 |  29.241 ns | 0.1399 ns | 0.1309 ns |  29.277 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 3.0 |  26.387 ns | 0.0557 ns | 0.0435 ns |  26.383 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net461 |  44.378 ns | 0.0229 ns | 0.0215 ns |  44.380 ns |  1.39 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net472 |  43.108 ns | 0.0471 ns | 0.0417 ns |  43.106 ns |  1.35 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                           From_Short_Nullable_NoValue | .NET Core 2.0 |  12.036 ns | 0.0721 ns | 0.0674 ns |  12.052 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 2.2 |  12.639 ns | 0.1529 ns | 0.1430 ns |  12.635 ns |  1.05 |    0.02 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 3.0 |   6.786 ns | 0.0248 ns | 0.0232 ns |   6.790 ns |  0.56 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net461 |  10.556 ns | 0.0212 ns | 0.0188 ns |  10.556 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net472 |  11.603 ns | 0.0684 ns | 0.0640 ns |  11.583 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.0 |  11.950 ns | 0.0328 ns | 0.0291 ns |  11.951 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.2 |  10.538 ns | 0.0118 ns | 0.0111 ns |  10.543 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 3.0 |  11.126 ns | 0.0871 ns | 0.0814 ns |  11.113 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net461 |  13.530 ns | 0.0388 ns | 0.0363 ns |  13.532 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net472 |  14.528 ns | 0.0292 ns | 0.0274 ns |  14.531 ns |  1.22 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                              From_Int | .NET Core 2.0 |  21.984 ns | 0.1141 ns | 0.1067 ns |  21.936 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 2.2 |  22.367 ns | 0.1890 ns | 0.1768 ns |  22.453 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                                              From_Int | .NET Core 3.0 |  12.859 ns | 0.0729 ns | 0.0682 ns |  12.830 ns |  0.58 |    0.00 |      - |     - |     - |         - |
                                              From_Int |        net461 |  22.798 ns | 0.0632 ns | 0.0528 ns |  22.808 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                              From_Int |        net472 |  23.101 ns | 0.0942 ns | 0.0835 ns |  23.086 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                     From_Int_AsObject | .NET Core 2.0 |  36.145 ns | 0.0541 ns | 0.0452 ns |  36.158 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 2.2 |  36.717 ns | 0.0482 ns | 0.0403 ns |  36.716 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 3.0 |  36.534 ns | 0.1753 ns | 0.1640 ns |  36.576 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net461 |  51.627 ns | 0.0782 ns | 0.0732 ns |  51.628 ns |  1.43 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net472 |  50.898 ns | 0.0744 ns | 0.0696 ns |  50.900 ns |  1.41 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                           From_Int_Nullable_WithValue | .NET Core 2.0 |  25.242 ns | 0.0779 ns | 0.0728 ns |  25.222 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 2.2 |  23.151 ns | 0.0167 ns | 0.0157 ns |  23.147 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 3.0 |  14.232 ns | 0.0575 ns | 0.0538 ns |  14.227 ns |  0.56 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net461 |  25.952 ns | 0.0300 ns | 0.0266 ns |  25.956 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net472 |  25.303 ns | 0.0491 ns | 0.0410 ns |  25.309 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.0 |  36.240 ns | 0.0335 ns | 0.0314 ns |  36.231 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.2 |  38.004 ns | 0.1959 ns | 0.1737 ns |  38.033 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 3.0 |  36.192 ns | 0.3355 ns | 0.3138 ns |  36.025 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net461 |  52.973 ns | 0.0743 ns | 0.0695 ns |  52.972 ns |  1.46 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net472 |  54.136 ns | 0.1377 ns | 0.1220 ns |  54.095 ns |  1.49 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                             From_Int_Nullable_NoValue | .NET Core 2.0 |  11.862 ns | 0.0316 ns | 0.0264 ns |  11.865 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 2.2 |  10.431 ns | 0.0127 ns | 0.0106 ns |  10.432 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 3.0 |   7.018 ns | 0.0121 ns | 0.0113 ns |   7.018 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net461 |  10.744 ns | 0.0919 ns | 0.0860 ns |  10.716 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net472 |  11.787 ns | 0.0864 ns | 0.0808 ns |  11.760 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.0 |  11.526 ns | 0.0288 ns | 0.0255 ns |  11.529 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.2 |  11.439 ns | 0.0129 ns | 0.0115 ns |  11.435 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 3.0 |  11.751 ns | 0.2582 ns | 0.2973 ns |  11.935 ns |  1.01 |    0.03 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net461 |  11.646 ns | 0.0227 ns | 0.0213 ns |  11.650 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net472 |  11.675 ns | 0.0631 ns | 0.0590 ns |  11.644 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                             From_Long | .NET Core 2.0 |  29.828 ns | 0.0472 ns | 0.0442 ns |  29.825 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Long | .NET Core 2.2 |  25.961 ns | 0.1286 ns | 0.1203 ns |  26.012 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                             From_Long | .NET Core 3.0 |  13.379 ns | 0.0718 ns | 0.0637 ns |  13.356 ns |  0.45 |    0.00 |      - |     - |     - |         - |
                                             From_Long |        net461 |  26.830 ns | 0.0763 ns | 0.0637 ns |  26.819 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                             From_Long |        net472 |  25.656 ns | 0.0396 ns | 0.0370 ns |  25.655 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                    From_Long_AsObject | .NET Core 2.0 |  31.984 ns | 0.0577 ns | 0.0511 ns |  31.976 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 2.2 |  30.057 ns | 0.0578 ns | 0.0541 ns |  30.057 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 3.0 |  27.257 ns | 0.0570 ns | 0.0476 ns |  27.243 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net461 |  45.211 ns | 0.5077 ns | 0.4749 ns |  45.291 ns |  1.41 |    0.01 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net472 |  43.458 ns | 0.1459 ns | 0.1218 ns |  43.439 ns |  1.36 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                          From_Long_Nullable_WithValue | .NET Core 2.0 |  30.712 ns | 0.0578 ns | 0.0540 ns |  30.719 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 2.2 |  28.937 ns | 0.0577 ns | 0.0540 ns |  28.926 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 3.0 |  15.763 ns | 0.0273 ns | 0.0256 ns |  15.768 ns |  0.51 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net461 |  31.126 ns | 0.1168 ns | 0.0975 ns |  31.125 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net472 |  29.678 ns | 0.0249 ns | 0.0194 ns |  29.674 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.0 |  32.372 ns | 0.0819 ns | 0.0684 ns |  32.371 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.2 |  30.659 ns | 0.0340 ns | 0.0302 ns |  30.648 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 3.0 |  27.311 ns | 0.0288 ns | 0.0270 ns |  27.321 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net461 |  43.803 ns | 0.3151 ns | 0.2947 ns |  43.672 ns |  1.35 |    0.01 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net472 |  45.673 ns | 0.0507 ns | 0.0474 ns |  45.665 ns |  1.41 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                            From_Long_Nullable_NoValue | .NET Core 2.0 |  12.567 ns | 0.0308 ns | 0.0288 ns |  12.562 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 2.2 |  11.413 ns | 0.0261 ns | 0.0231 ns |  11.414 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 3.0 |   8.517 ns | 0.0874 ns | 0.0775 ns |   8.509 ns |  0.68 |    0.01 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net461 |  13.129 ns | 0.0619 ns | 0.0579 ns |  13.113 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net472 |  13.030 ns | 0.0942 ns | 0.0882 ns |  13.095 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.0 |  12.693 ns | 0.0155 ns | 0.0145 ns |  12.691 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.2 |  10.623 ns | 0.0910 ns | 0.0852 ns |  10.579 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 3.0 |  11.006 ns | 0.0314 ns | 0.0278 ns |  11.010 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net461 |  11.646 ns | 0.0227 ns | 0.0201 ns |  11.644 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net472 |  15.161 ns | 0.0346 ns | 0.0289 ns |  15.158 ns |  1.19 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                            From_SByte | .NET Core 2.0 |  23.488 ns | 0.0498 ns | 0.0441 ns |  23.494 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 2.2 |  22.066 ns | 0.1109 ns | 0.1037 ns |  22.019 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 3.0 |  13.394 ns | 0.0455 ns | 0.0426 ns |  13.374 ns |  0.57 |    0.00 |      - |     - |     - |         - |
                                            From_SByte |        net461 |  24.698 ns | 0.0525 ns | 0.0491 ns |  24.702 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                            From_SByte |        net472 |  23.374 ns | 0.0516 ns | 0.0431 ns |  23.365 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                   From_SByte_AsObject | .NET Core 2.0 |  31.600 ns | 0.0675 ns | 0.0631 ns |  31.611 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 2.2 |  29.728 ns | 0.0338 ns | 0.0300 ns |  29.719 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 3.0 |  25.816 ns | 0.0544 ns | 0.0483 ns |  25.820 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net461 |  44.637 ns | 0.3615 ns | 0.3382 ns |  44.605 ns |  1.41 |    0.01 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net472 |  42.776 ns | 0.1321 ns | 0.1171 ns |  42.753 ns |  1.35 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                         From_SByte_Nullable_WithValue | .NET Core 2.0 |  27.054 ns | 0.0333 ns | 0.0296 ns |  27.054 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 2.2 |  26.118 ns | 0.1779 ns | 0.1664 ns |  26.217 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 3.0 |  14.098 ns | 0.0341 ns | 0.0285 ns |  14.087 ns |  0.52 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net461 |  25.118 ns | 0.0518 ns | 0.0459 ns |  25.121 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net472 |  25.202 ns | 0.0754 ns | 0.0705 ns |  25.170 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.0 |  31.644 ns | 0.0862 ns | 0.0764 ns |  31.624 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.2 |  28.977 ns | 0.0378 ns | 0.0335 ns |  28.983 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 3.0 |  26.450 ns | 0.0570 ns | 0.0505 ns |  26.466 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net461 |  42.240 ns | 0.0693 ns | 0.0614 ns |  42.240 ns |  1.33 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net472 |  42.799 ns | 0.0911 ns | 0.0808 ns |  42.803 ns |  1.35 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                           From_SByte_Nullable_NoValue | .NET Core 2.0 |  12.165 ns | 0.0547 ns | 0.0512 ns |  12.139 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 2.2 |  10.448 ns | 0.0105 ns | 0.0088 ns |  10.450 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 3.0 |   7.172 ns | 0.0187 ns | 0.0156 ns |   7.174 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net461 |  10.736 ns | 0.0645 ns | 0.0572 ns |  10.752 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net472 |  10.654 ns | 0.0352 ns | 0.0312 ns |  10.646 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.0 |  11.712 ns | 0.0197 ns | 0.0164 ns |  11.714 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.2 |  11.007 ns | 0.0906 ns | 0.0847 ns |  11.049 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 3.0 |  11.047 ns | 0.0236 ns | 0.0221 ns |  11.038 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net461 |  11.678 ns | 0.0202 ns | 0.0179 ns |  11.678 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net472 |  15.262 ns | 0.0495 ns | 0.0413 ns |  15.261 ns |  1.30 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                            From_Float | .NET Core 2.0 |  26.899 ns | 0.0418 ns | 0.0370 ns |  26.890 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 2.2 |  24.909 ns | 0.0368 ns | 0.0344 ns |  24.903 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 3.0 |  15.870 ns | 0.0413 ns | 0.0386 ns |  15.880 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                                            From_Float |        net461 |  28.690 ns | 0.2377 ns | 0.2224 ns |  28.557 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                                            From_Float |        net472 |  26.254 ns | 0.1181 ns | 0.1105 ns |  26.204 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                   From_Float_AsObject | .NET Core 2.0 |  33.078 ns | 0.0555 ns | 0.0463 ns |  33.091 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 2.2 |  30.355 ns | 0.0721 ns | 0.0674 ns |  30.381 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 3.0 |  27.873 ns | 0.1232 ns | 0.1028 ns |  27.855 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject |        net461 |  47.620 ns | 0.0839 ns | 0.0701 ns |  47.610 ns |  1.44 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject |        net472 |  47.020 ns | 0.1187 ns | 0.1052 ns |  47.023 ns |  1.42 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                         From_Float_Nullable_WithValue | .NET Core 2.0 |  29.227 ns | 0.0342 ns | 0.0320 ns |  29.233 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 2.2 |  27.624 ns | 0.1830 ns | 0.1711 ns |  27.686 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 3.0 |  17.806 ns | 0.3805 ns | 0.8191 ns |  18.160 ns |  0.58 |    0.04 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net461 |  27.349 ns | 0.0857 ns | 0.0802 ns |  27.330 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net472 |  27.588 ns | 0.0295 ns | 0.0276 ns |  27.579 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.0 |  33.632 ns | 0.0543 ns | 0.0482 ns |  33.623 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.2 |  36.059 ns | 0.0863 ns | 0.0720 ns |  36.052 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 3.0 |  28.152 ns | 0.1460 ns | 0.1366 ns |  28.116 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net461 |  46.666 ns | 0.4454 ns | 0.4167 ns |  46.480 ns |  1.39 |    0.01 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net472 |  45.001 ns | 0.2180 ns | 0.2039 ns |  44.915 ns |  1.34 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                           From_Float_Nullable_NoValue | .NET Core 2.0 |  11.687 ns | 0.0339 ns | 0.0283 ns |  11.681 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 2.2 |  10.949 ns | 0.0150 ns | 0.0126 ns |  10.952 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 3.0 |   7.186 ns | 0.0488 ns | 0.0408 ns |   7.174 ns |  0.61 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net461 |  10.609 ns | 0.0158 ns | 0.0140 ns |  10.607 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net472 |  10.880 ns | 0.0197 ns | 0.0185 ns |  10.877 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.0 |  12.749 ns | 0.0075 ns | 0.0070 ns |  12.749 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.2 |  10.541 ns | 0.0239 ns | 0.0224 ns |  10.543 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 3.0 |  11.085 ns | 0.0254 ns | 0.0212 ns |  11.090 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net461 |  11.638 ns | 0.0337 ns | 0.0315 ns |  11.638 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net472 |  14.528 ns | 0.0399 ns | 0.0333 ns |  14.526 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                           From_String | .NET Core 2.0 |  32.899 ns | 0.1232 ns | 0.1092 ns |  32.884 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 2.2 |  29.720 ns | 0.2353 ns | 0.2201 ns |  29.678 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                                           From_String | .NET Core 3.0 |  25.570 ns | 0.5136 ns | 0.5914 ns |  25.166 ns |  0.78 |    0.02 |      - |     - |     - |         - |
                                           From_String |        net461 |  43.410 ns | 0.5140 ns | 0.4808 ns |  43.147 ns |  1.32 |    0.02 |      - |     - |     - |         - |
                                           From_String |        net472 |  39.747 ns | 0.0740 ns | 0.0656 ns |  39.746 ns |  1.21 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                  From_String_AsObject | .NET Core 2.0 |  37.453 ns | 0.0910 ns | 0.0760 ns |  37.441 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 2.2 |  36.207 ns | 0.0389 ns | 0.0364 ns |  36.209 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 3.0 |  31.120 ns | 0.0379 ns | 0.0336 ns |  31.118 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject |        net461 |  48.387 ns | 0.0637 ns | 0.0596 ns |  48.389 ns |  1.29 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject |        net472 |  49.401 ns | 0.1410 ns | 0.1319 ns |  49.432 ns |  1.32 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                      From_String_Null | .NET Core 2.0 |  10.946 ns | 0.0239 ns | 0.0212 ns |  10.954 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 2.2 |   9.989 ns | 0.0698 ns | 0.0653 ns |   9.975 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 3.0 |  10.902 ns | 0.0356 ns | 0.0333 ns |  10.908 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null |        net461 |  12.544 ns | 0.0327 ns | 0.0290 ns |  12.554 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null |        net472 |  11.206 ns | 0.0254 ns | 0.0237 ns |  11.206 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                             From_String_Null_AsObject | .NET Core 2.0 |  11.495 ns | 0.0169 ns | 0.0158 ns |  11.489 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 2.2 |  10.523 ns | 0.0187 ns | 0.0175 ns |  10.520 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 3.0 |  11.354 ns | 0.3695 ns | 0.4398 ns |  11.099 ns |  1.00 |    0.04 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net461 |  11.639 ns | 0.0232 ns | 0.0181 ns |  11.641 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net472 |  11.689 ns | 0.0659 ns | 0.0617 ns |  11.659 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                     From_String_Empty | .NET Core 2.0 |  11.084 ns | 0.0156 ns | 0.0139 ns |  11.087 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 2.2 |   9.928 ns | 0.0673 ns | 0.0630 ns |   9.950 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 3.0 |  10.857 ns | 0.0177 ns | 0.0166 ns |  10.857 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty |        net461 |  11.278 ns | 0.0197 ns | 0.0184 ns |  11.280 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty |        net472 |  12.806 ns | 0.0197 ns | 0.0184 ns |  12.811 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                            From_String_Empty_AsObject | .NET Core 2.0 |  19.446 ns | 0.0642 ns | 0.0569 ns |  19.447 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 2.2 |  16.871 ns | 0.0375 ns | 0.0293 ns |  16.870 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 3.0 |  16.329 ns | 0.0364 ns | 0.0341 ns |  16.320 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net461 |  22.878 ns | 0.0440 ns | 0.0390 ns |  22.872 ns |  1.18 |    0.00 |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net472 |  23.098 ns | 0.0817 ns | 0.0725 ns |  23.069 ns |  1.19 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                           From_UShort | .NET Core 2.0 |  23.457 ns | 0.0336 ns | 0.0280 ns |  23.457 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 2.2 |  23.262 ns | 0.0295 ns | 0.0276 ns |  23.267 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 3.0 |  13.019 ns | 0.0572 ns | 0.0535 ns |  13.001 ns |  0.56 |    0.00 |      - |     - |     - |         - |
                                           From_UShort |        net461 |  24.988 ns | 0.3380 ns | 0.3162 ns |  24.851 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                                           From_UShort |        net472 |  22.990 ns | 0.0388 ns | 0.0363 ns |  22.974 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                  From_UShort_AsObject | .NET Core 2.0 |  31.364 ns | 0.0723 ns | 0.0677 ns |  31.367 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 2.2 |  29.806 ns | 0.2125 ns | 0.1988 ns |  29.898 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 3.0 |  26.810 ns | 0.0417 ns | 0.0390 ns |  26.804 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net461 |  44.980 ns | 0.0532 ns | 0.0472 ns |  44.972 ns |  1.43 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net472 |  44.731 ns | 0.0948 ns | 0.0840 ns |  44.735 ns |  1.43 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                        From_UShort_Nullable_WithValue | .NET Core 2.0 |  26.571 ns | 0.0316 ns | 0.0296 ns |  26.578 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 2.2 |  25.202 ns | 0.0310 ns | 0.0290 ns |  25.203 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 3.0 |  14.041 ns | 0.0341 ns | 0.0319 ns |  14.041 ns |  0.53 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net461 |  25.302 ns | 0.0531 ns | 0.0497 ns |  25.297 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net472 |  25.123 ns | 0.0309 ns | 0.0258 ns |  25.121 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.0 |  35.854 ns | 0.0806 ns | 0.0715 ns |  35.845 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.2 |  29.155 ns | 0.0307 ns | 0.0273 ns |  29.152 ns |  0.81 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 3.0 |  26.592 ns | 0.0433 ns | 0.0405 ns |  26.581 ns |  0.74 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net461 |  45.453 ns | 0.5528 ns | 0.5171 ns |  45.151 ns |  1.27 |    0.01 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net472 |  45.769 ns | 0.0967 ns | 0.0904 ns |  45.769 ns |  1.28 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                          From_UShort_Nullable_NoValue | .NET Core 2.0 |  11.845 ns | 0.0225 ns | 0.0210 ns |  11.849 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 2.2 |  10.594 ns | 0.0640 ns | 0.0567 ns |  10.607 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 3.0 |   7.063 ns | 0.2376 ns | 0.3483 ns |   6.877 ns |  0.61 |    0.04 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net461 |  10.561 ns | 0.0192 ns | 0.0170 ns |  10.564 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net472 |  11.068 ns | 0.0158 ns | 0.0147 ns |  11.067 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.0 |  13.009 ns | 0.0448 ns | 0.0398 ns |  13.013 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.2 |  10.544 ns | 0.0136 ns | 0.0120 ns |  10.540 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 3.0 |  11.115 ns | 0.0181 ns | 0.0169 ns |  11.118 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net461 |  13.566 ns | 0.0312 ns | 0.0292 ns |  13.571 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net472 |  12.000 ns | 0.0520 ns | 0.0461 ns |  11.985 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                             From_UInt | .NET Core 2.0 |  23.532 ns | 0.0252 ns | 0.0223 ns |  23.535 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 2.2 |  21.917 ns | 0.0226 ns | 0.0211 ns |  21.926 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 3.0 |  12.631 ns | 0.0210 ns | 0.0186 ns |  12.635 ns |  0.54 |    0.00 |      - |     - |     - |         - |
                                             From_UInt |        net461 |  25.754 ns | 0.1960 ns | 0.1833 ns |  25.659 ns |  1.09 |    0.01 |      - |     - |     - |         - |
                                             From_UInt |        net472 |  27.024 ns | 0.0427 ns | 0.0399 ns |  27.012 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                    From_UInt_AsObject | .NET Core 2.0 |  33.983 ns | 0.0459 ns | 0.0429 ns |  33.976 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 2.2 |  34.934 ns | 0.0385 ns | 0.0361 ns |  34.926 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 3.0 |  26.160 ns | 0.0589 ns | 0.0522 ns |  26.164 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net461 |  45.582 ns | 0.0817 ns | 0.0725 ns |  45.583 ns |  1.34 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net472 |  46.306 ns | 0.2323 ns | 0.2173 ns |  46.187 ns |  1.36 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                          From_UInt_Nullable_WithValue | .NET Core 2.0 |  26.773 ns | 0.0458 ns | 0.0406 ns |  26.768 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 2.2 |  26.508 ns | 0.0355 ns | 0.0332 ns |  26.512 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 3.0 |  13.666 ns | 0.1037 ns | 0.0970 ns |  13.615 ns |  0.51 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net461 |  27.674 ns | 0.0312 ns | 0.0292 ns |  27.676 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net472 |  27.010 ns | 0.0339 ns | 0.0317 ns |  27.017 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.0 |  31.668 ns | 0.0663 ns | 0.0588 ns |  31.689 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.2 |  35.327 ns | 0.0993 ns | 0.0829 ns |  35.328 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 3.0 |  26.516 ns | 0.0227 ns | 0.0212 ns |  26.511 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net461 |  43.316 ns | 0.0834 ns | 0.0780 ns |  43.324 ns |  1.37 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net472 |  43.565 ns | 0.0779 ns | 0.0691 ns |  43.575 ns |  1.38 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                            From_UInt_Nullable_NoValue | .NET Core 2.0 |  11.836 ns | 0.0210 ns | 0.0197 ns |  11.844 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 2.2 |  10.606 ns | 0.0407 ns | 0.0381 ns |  10.613 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 3.0 |   6.894 ns | 0.0170 ns | 0.0159 ns |   6.897 ns |  0.58 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net461 |  10.589 ns | 0.0271 ns | 0.0227 ns |  10.583 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net472 |  11.575 ns | 0.1052 ns | 0.0984 ns |  11.578 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.0 |  11.486 ns | 0.0162 ns | 0.0144 ns |  11.485 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.2 |  10.540 ns | 0.0133 ns | 0.0125 ns |  10.540 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 3.0 |  11.549 ns | 0.2497 ns | 0.2452 ns |  11.723 ns |  1.00 |    0.02 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net461 |  12.606 ns | 0.0700 ns | 0.0621 ns |  12.621 ns |  1.10 |    0.01 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net472 |  11.961 ns | 0.0106 ns | 0.0088 ns |  11.962 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                            From_ULong | .NET Core 2.0 |  27.118 ns | 0.0331 ns | 0.0310 ns |  27.114 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 2.2 |  25.531 ns | 0.0341 ns | 0.0319 ns |  25.533 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 3.0 |  13.363 ns | 0.0342 ns | 0.0303 ns |  13.367 ns |  0.49 |    0.00 |      - |     - |     - |         - |
                                            From_ULong |        net461 |  31.259 ns | 0.0646 ns | 0.0604 ns |  31.265 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                                            From_ULong |        net472 |  25.939 ns | 0.1650 ns | 0.1544 ns |  25.856 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                   From_ULong_AsObject | .NET Core 2.0 |  33.227 ns | 0.0591 ns | 0.0553 ns |  33.238 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 2.2 |  29.764 ns | 0.1983 ns | 0.1854 ns |  29.829 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 3.0 |  26.688 ns | 0.0401 ns | 0.0313 ns |  26.677 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net461 |  44.904 ns | 0.0651 ns | 0.0508 ns |  44.907 ns |  1.35 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net472 |  43.023 ns | 0.0602 ns | 0.0563 ns |  43.012 ns |  1.29 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                         From_ULong_Nullable_WithValue | .NET Core 2.0 |  29.498 ns | 0.0527 ns | 0.0493 ns |  29.502 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 2.2 |  29.832 ns | 0.0280 ns | 0.0248 ns |  29.825 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 3.0 |  15.546 ns | 0.0342 ns | 0.0320 ns |  15.552 ns |  0.53 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net461 |  29.988 ns | 0.0768 ns | 0.0681 ns |  29.970 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net472 |  29.997 ns | 0.0369 ns | 0.0308 ns |  29.993 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.0 |  32.229 ns | 0.0723 ns | 0.0676 ns |  32.245 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.2 |  29.811 ns | 0.1324 ns | 0.1239 ns |  29.844 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 3.0 |  26.711 ns | 0.0472 ns | 0.0418 ns |  26.714 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net461 |  43.462 ns | 0.0453 ns | 0.0423 ns |  43.454 ns |  1.35 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net472 |  44.838 ns | 0.0778 ns | 0.0650 ns |  44.835 ns |  1.39 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                           From_ULong_Nullable_NoValue | .NET Core 2.0 |  12.527 ns | 0.0162 ns | 0.0152 ns |  12.527 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 2.2 |  11.692 ns | 0.0144 ns | 0.0120 ns |  11.691 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 3.0 |   8.438 ns | 0.0150 ns | 0.0125 ns |   8.432 ns |  0.67 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net461 |  13.713 ns | 0.1231 ns | 0.1152 ns |  13.726 ns |  1.09 |    0.01 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net472 |  12.928 ns | 0.0172 ns | 0.0152 ns |  12.928 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.0 |  12.433 ns | 0.0187 ns | 0.0156 ns |  12.431 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.2 |  10.545 ns | 0.0177 ns | 0.0165 ns |  10.545 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 3.0 |  11.227 ns | 0.1620 ns | 0.1515 ns |  11.290 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net461 |  12.779 ns | 0.0071 ns | 0.0059 ns |  12.779 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net472 |  11.658 ns | 0.0155 ns | 0.0138 ns |  11.662 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                       From_NullObject | .NET Core 2.0 |  12.353 ns | 0.0281 ns | 0.0263 ns |  12.355 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 2.2 |  10.664 ns | 0.0953 ns | 0.0891 ns |  10.706 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 3.0 |  11.112 ns | 0.0506 ns | 0.0449 ns |  11.106 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                                       From_NullObject |        net461 |  11.665 ns | 0.0259 ns | 0.0229 ns |  11.668 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject |        net472 |  14.558 ns | 0.0997 ns | 0.0933 ns |  14.502 ns |  1.18 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                           From_DBNull | .NET Core 2.0 |  13.057 ns | 0.0154 ns | 0.0137 ns |  13.053 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 2.2 |  10.461 ns | 0.0089 ns | 0.0079 ns |  10.462 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 3.0 |  11.259 ns | 0.0501 ns | 0.0469 ns |  11.292 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull |        net461 |  13.051 ns | 0.0186 ns | 0.0165 ns |  13.054 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull |        net472 |  13.728 ns | 0.0200 ns | 0.0167 ns |  13.726 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                  From_DBNull_AsObject | .NET Core 2.0 |  12.440 ns | 0.0173 ns | 0.0162 ns |  12.440 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 2.2 |  10.632 ns | 0.1059 ns | 0.0991 ns |  10.679 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 3.0 |  11.726 ns | 0.2599 ns | 0.3890 ns |  11.928 ns |  0.92 |    0.03 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net461 |  12.249 ns | 0.0924 ns | 0.0819 ns |  12.282 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net472 |  11.650 ns | 0.0195 ns | 0.0173 ns |  11.644 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                 From_ConvertibleClass | .NET Core 2.0 |  27.692 ns | 0.0352 ns | 0.0312 ns |  27.690 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 2.2 |  27.455 ns | 0.0463 ns | 0.0387 ns |  27.451 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 3.0 |  23.898 ns | 0.1695 ns | 0.1416 ns |  23.933 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net461 |  39.697 ns | 0.0652 ns | 0.0610 ns |  39.686 ns |  1.43 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net472 |  43.292 ns | 0.1491 ns | 0.1245 ns |  43.260 ns |  1.56 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                        From_ConvertibleClass_AsObject | .NET Core 2.0 |  30.252 ns | 0.0540 ns | 0.0451 ns |  30.255 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 2.2 |  28.227 ns | 0.0527 ns | 0.0440 ns |  28.238 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 3.0 |  26.191 ns | 0.0315 ns | 0.0279 ns |  26.191 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net461 |  44.719 ns | 0.0682 ns | 0.0570 ns |  44.719 ns |  1.48 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net472 |  43.668 ns | 0.0609 ns | 0.0509 ns |  43.674 ns |  1.44 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                         From_ConvertibleClass_NoValue | .NET Core 2.0 |  12.356 ns | 0.0214 ns | 0.0190 ns |  12.359 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 2.2 |  10.581 ns | 0.0976 ns | 0.0913 ns |  10.618 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 3.0 |  11.137 ns | 0.0816 ns | 0.0764 ns |  11.121 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net461 |  11.974 ns | 0.0605 ns | 0.0566 ns |  11.988 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net472 |  13.537 ns | 0.0243 ns | 0.0215 ns |  13.541 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.0 |  12.692 ns | 0.0658 ns | 0.0615 ns |  12.703 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.2 |  10.530 ns | 0.0099 ns | 0.0088 ns |  10.531 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 3.0 |  11.372 ns | 0.1535 ns | 0.1436 ns |  11.286 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net461 |  12.368 ns | 0.0218 ns | 0.0193 ns |  12.368 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net472 |  12.437 ns | 0.1368 ns | 0.1279 ns |  12.516 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                              From_NonConvertibleClass | .NET Core 2.0 |  22.914 ns | 0.0380 ns | 0.0355 ns |  22.909 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 2.2 |  20.876 ns | 0.0469 ns | 0.0415 ns |  20.880 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 3.0 |  20.236 ns | 0.0171 ns | 0.0143 ns |  20.232 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net461 |  26.242 ns | 0.0471 ns | 0.0394 ns |  26.245 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net472 |  27.901 ns | 0.0280 ns | 0.0234 ns |  27.898 ns |  1.22 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                     From_NonConvertibleClass_AsObject | .NET Core 2.0 |  27.206 ns | 0.0474 ns | 0.0443 ns |  27.199 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 2.2 |  25.525 ns | 0.1280 ns | 0.1135 ns |  25.558 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 3.0 |  22.595 ns | 0.0676 ns | 0.0599 ns |  22.563 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net461 |  39.248 ns | 0.2009 ns | 0.1879 ns |  39.289 ns |  1.44 |    0.01 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net472 |  37.909 ns | 0.4339 ns | 0.4059 ns |  37.635 ns |  1.39 |    0.02 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                      From_NonConvertibleClass_NoValue | .NET Core 2.0 |  11.377 ns | 0.0217 ns | 0.0181 ns |  11.377 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 2.2 |  10.444 ns | 0.0189 ns | 0.0167 ns |  10.440 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 3.0 |  11.390 ns | 0.1175 ns | 0.0917 ns |  11.422 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net461 |  11.666 ns | 0.0252 ns | 0.0224 ns |  11.667 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net472 |  13.998 ns | 0.1589 ns | 0.1408 ns |  14.055 ns |  1.23 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.0 |  11.494 ns | 0.0167 ns | 0.0148 ns |  11.496 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.2 |  10.544 ns | 0.0116 ns | 0.0109 ns |  10.547 ns |  0.92 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 3.0 |  11.215 ns | 0.1425 ns | 0.1333 ns |  11.294 ns |  0.98 |    0.01 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net461 |  13.539 ns | 0.0213 ns | 0.0189 ns |  13.543 ns |  1.18 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net472 |  11.607 ns | 0.0239 ns | 0.0224 ns |  11.605 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                From_ConvertibleStruct | .NET Core 2.0 |  37.191 ns | 0.0706 ns | 0.0589 ns |  37.193 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 2.2 |  37.995 ns | 0.2748 ns | 0.2570 ns |  38.140 ns |  1.02 |    0.01 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 3.0 |  19.094 ns | 0.0550 ns | 0.0429 ns |  19.104 ns |  0.51 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net461 |  34.890 ns | 0.0678 ns | 0.0601 ns |  34.877 ns |  0.94 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net472 |  35.773 ns | 0.1158 ns | 0.1027 ns |  35.753 ns |  0.96 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                       From_ConvertibleStruct_AsObject | .NET Core 2.0 |  30.891 ns | 0.0716 ns | 0.0669 ns |  30.892 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 2.2 |  28.844 ns | 0.0274 ns | 0.0229 ns |  28.846 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 3.0 |  26.957 ns | 0.0226 ns | 0.0200 ns |  26.958 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net461 |  41.429 ns | 0.0517 ns | 0.0458 ns |  41.429 ns |  1.34 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net472 |  41.353 ns | 0.0780 ns | 0.0692 ns |  41.362 ns |  1.34 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.0 |  35.286 ns | 0.0877 ns | 0.0777 ns |  35.296 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.2 |  30.943 ns | 0.0652 ns | 0.0610 ns |  30.931 ns |  0.88 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 3.0 |  19.492 ns | 0.0817 ns | 0.0638 ns |  19.516 ns |  0.55 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net461 |  35.335 ns | 0.1647 ns | 0.1540 ns |  35.293 ns |  1.00 |    0.01 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net472 |  39.796 ns | 0.1217 ns | 0.1078 ns |  39.815 ns |  1.13 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 |  34.972 ns | 0.1799 ns | 0.1502 ns |  34.929 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 |  28.859 ns | 0.2052 ns | 0.1920 ns |  28.968 ns |  0.83 |    0.01 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 |  26.562 ns | 0.0587 ns | 0.0549 ns |  26.549 ns |  0.76 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net461 |  44.325 ns | 0.3430 ns | 0.3209 ns |  44.181 ns |  1.27 |    0.01 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net472 |  41.131 ns | 0.0540 ns | 0.0505 ns |  41.134 ns |  1.18 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.0 |  11.729 ns | 0.0185 ns | 0.0164 ns |  11.732 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.2 |  10.454 ns | 0.0113 ns | 0.0105 ns |  10.452 ns |  0.89 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 3.0 |   6.960 ns | 0.0872 ns | 0.0816 ns |   6.984 ns |  0.59 |    0.01 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net461 |  10.558 ns | 0.0154 ns | 0.0136 ns |  10.562 ns |  0.90 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net472 |  10.679 ns | 0.0220 ns | 0.0195 ns |  10.679 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 |  11.489 ns | 0.0217 ns | 0.0203 ns |  11.497 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 |  10.529 ns | 0.0179 ns | 0.0158 ns |  10.524 ns |  0.92 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 |  11.118 ns | 0.0281 ns | 0.0263 ns |  11.127 ns |  0.97 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net461 |  13.805 ns | 0.0391 ns | 0.0366 ns |  13.807 ns |  1.20 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net472 |  14.443 ns | 0.0220 ns | 0.0172 ns |  14.444 ns |  1.26 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                             From_NonConvertibleStruct | .NET Core 2.0 |  30.147 ns | 0.0580 ns | 0.0514 ns |  30.151 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 2.2 |  25.002 ns | 0.0415 ns | 0.0368 ns |  24.990 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 3.0 |  13.457 ns | 0.0329 ns | 0.0292 ns |  13.457 ns |  0.45 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net461 |  24.978 ns | 0.0807 ns | 0.0715 ns |  24.960 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net472 |  25.135 ns | 0.0422 ns | 0.0394 ns |  25.147 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.0 |  27.600 ns | 0.0373 ns | 0.0331 ns |  27.607 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.2 |  25.139 ns | 0.0426 ns | 0.0332 ns |  25.140 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 3.0 |  22.572 ns | 0.0327 ns | 0.0290 ns |  22.574 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net461 |  37.310 ns | 0.0705 ns | 0.0589 ns |  37.312 ns |  1.35 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net472 |  39.143 ns | 0.0288 ns | 0.0240 ns |  39.147 ns |  1.42 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.0 |  26.392 ns | 0.0514 ns | 0.0430 ns |  26.399 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.2 |  23.010 ns | 0.0227 ns | 0.0201 ns |  23.014 ns |  0.87 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 3.0 |  14.436 ns | 0.0426 ns | 0.0355 ns |  14.436 ns |  0.55 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net461 |  25.249 ns | 0.0526 ns | 0.0466 ns |  25.245 ns |  0.96 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net472 |  24.924 ns | 0.0326 ns | 0.0289 ns |  24.927 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 |  31.822 ns | 0.0285 ns | 0.0253 ns |  31.821 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 |  25.260 ns | 0.0509 ns | 0.0477 ns |  25.253 ns |  0.79 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 |  22.540 ns | 0.0185 ns | 0.0164 ns |  22.541 ns |  0.71 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net461 |  39.826 ns | 0.0462 ns | 0.0410 ns |  39.828 ns |  1.25 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net472 |  37.657 ns | 0.0404 ns | 0.0358 ns |  37.653 ns |  1.18 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.0 |  11.735 ns | 0.0284 ns | 0.0266 ns |  11.741 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.2 |  10.449 ns | 0.0115 ns | 0.0102 ns |  10.449 ns |  0.89 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 3.0 |   6.667 ns | 0.0330 ns | 0.0276 ns |   6.664 ns |  0.57 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net461 |  10.569 ns | 0.0218 ns | 0.0182 ns |  10.568 ns |  0.90 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net472 |  10.718 ns | 0.0108 ns | 0.0101 ns |  10.719 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 |  12.322 ns | 0.0655 ns | 0.0613 ns |  12.298 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 |  10.511 ns | 0.0132 ns | 0.0123 ns |  10.510 ns |  0.85 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 |  11.178 ns | 0.1374 ns | 0.1285 ns |  11.104 ns |  0.91 |    0.01 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net461 |  11.662 ns | 0.0414 ns | 0.0387 ns |  11.662 ns |  0.95 |    0.01 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net472 |  11.602 ns | 0.0186 ns | 0.0174 ns |  11.604 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                             From_Enum | .NET Core 2.0 |  12.429 ns | 0.0591 ns | 0.0524 ns |  12.439 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 2.2 |  10.970 ns | 0.0835 ns | 0.0781 ns |  11.005 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 3.0 |   6.705 ns | 0.0137 ns | 0.0122 ns |   6.708 ns |  0.54 |    0.00 |      - |     - |     - |         - |
                                             From_Enum |        net461 |  10.489 ns | 0.0195 ns | 0.0153 ns |  10.487 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                             From_Enum |        net472 |  10.420 ns | 0.0134 ns | 0.0119 ns |  10.418 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                    From_Enum_AsObject | .NET Core 2.0 |  12.357 ns | 0.0366 ns | 0.0324 ns |  12.354 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Enum_AsObject | .NET Core 2.2 |  11.384 ns | 0.0193 ns | 0.0151 ns |  11.385 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                    From_Enum_AsObject | .NET Core 3.0 |  11.535 ns | 0.1073 ns | 0.0951 ns |  11.569 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                                    From_Enum_AsObject |        net461 |  12.533 ns | 0.0290 ns | 0.0272 ns |  12.529 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                    From_Enum_AsObject |        net472 |  14.842 ns | 0.0301 ns | 0.0251 ns |  14.844 ns |  1.20 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                          From_Enum_Nullable_WithValue | .NET Core 2.0 |  13.491 ns | 0.0131 ns | 0.0116 ns |  13.494 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 2.2 |  10.525 ns | 0.0171 ns | 0.0160 ns |  10.526 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 3.0 |   7.022 ns | 0.0157 ns | 0.0147 ns |   7.023 ns |  0.52 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net461 |  10.682 ns | 0.0298 ns | 0.0279 ns |  10.690 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net472 |  10.737 ns | 0.0241 ns | 0.0225 ns |  10.745 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.0 |  12.723 ns | 0.0087 ns | 0.0081 ns |  12.723 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.2 |  11.227 ns | 0.1061 ns | 0.0993 ns |  11.281 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 3.0 |  11.361 ns | 0.0133 ns | 0.0125 ns |  11.358 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                 From_Enum_Nullable_WithValue_AsObject |        net461 |  12.439 ns | 0.0662 ns | 0.0619 ns |  12.419 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                 From_Enum_Nullable_WithValue_AsObject |        net472 |  14.850 ns | 0.0214 ns | 0.0190 ns |  14.848 ns |  1.17 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                            From_Enum_Nullable_NoValue | .NET Core 2.0 |  12.401 ns | 0.0224 ns | 0.0210 ns |  12.400 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 2.2 |  11.036 ns | 0.0180 ns | 0.0150 ns |  11.038 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 3.0 |   6.915 ns | 0.0695 ns | 0.0650 ns |   6.953 ns |  0.56 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net461 |  11.685 ns | 0.0425 ns | 0.0397 ns |  11.706 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net472 |  11.533 ns | 0.0229 ns | 0.0203 ns |  11.540 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.0 |  11.489 ns | 0.0116 ns | 0.0097 ns |  11.490 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.2 |  10.540 ns | 0.0206 ns | 0.0193 ns |  10.536 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 3.0 |  11.093 ns | 0.0102 ns | 0.0085 ns |  11.093 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net461 |  11.654 ns | 0.0379 ns | 0.0355 ns |  11.653 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net472 |  14.206 ns | 0.0584 ns | 0.0487 ns |  14.201 ns |  1.24 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                      From_ParentClass | .NET Core 2.0 |  23.280 ns | 0.0843 ns | 0.0788 ns |  23.303 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 2.2 |  21.169 ns | 0.0370 ns | 0.0346 ns |  21.165 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 3.0 |  20.631 ns | 0.0377 ns | 0.0315 ns |  20.630 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass |        net461 |  26.336 ns | 0.0995 ns | 0.0930 ns |  26.303 ns |  1.13 |    0.01 |      - |     - |     - |         - |
                                      From_ParentClass |        net472 |  26.352 ns | 0.0310 ns | 0.0275 ns |  26.354 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                             From_ParentClass_AsObject | .NET Core 2.0 |  29.009 ns | 0.0393 ns | 0.0368 ns |  29.013 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 2.2 |  25.644 ns | 0.0312 ns | 0.0277 ns |  25.644 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 3.0 |  24.251 ns | 0.1539 ns | 0.1439 ns |  24.304 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net461 |  37.620 ns | 0.0662 ns | 0.0620 ns |  37.611 ns |  1.30 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net472 |  40.243 ns | 0.0888 ns | 0.0741 ns |  40.231 ns |  1.39 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                              From_ParentClass_NoValue | .NET Core 2.0 |  11.538 ns | 0.0202 ns | 0.0158 ns |  11.537 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 2.2 |  10.452 ns | 0.0191 ns | 0.0179 ns |  10.446 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 3.0 |  11.835 ns | 0.2573 ns | 0.3523 ns |  12.017 ns |  1.01 |    0.04 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net461 |  11.655 ns | 0.0314 ns | 0.0294 ns |  11.661 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net472 |  11.653 ns | 0.0143 ns | 0.0119 ns |  11.657 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.0 |  11.663 ns | 0.0983 ns | 0.0872 ns |  11.699 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.2 |  10.589 ns | 0.1063 ns | 0.0994 ns |  10.640 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 3.0 |  11.296 ns | 0.1504 ns | 0.1407 ns |  11.359 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net461 |  12.425 ns | 0.1285 ns | 0.1073 ns |  12.446 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net472 |  11.600 ns | 0.0217 ns | 0.0182 ns |  11.600 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                     From_ParentStruct | .NET Core 2.0 |  95.937 ns | 0.1432 ns | 0.1340 ns |  95.920 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 2.2 |  86.893 ns | 0.1227 ns | 0.0958 ns |  86.938 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 3.0 |  84.199 ns | 0.4856 ns | 0.4304 ns |  84.378 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct |        net461 |  96.574 ns | 0.0992 ns | 0.0879 ns |  96.555 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct |        net472 |  97.958 ns | 0.1847 ns | 0.1638 ns |  97.944 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                            From_ParentStruct_AsObject | .NET Core 2.0 |  29.074 ns | 0.0422 ns | 0.0353 ns |  29.082 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 2.2 |  25.597 ns | 0.0353 ns | 0.0313 ns |  25.608 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 3.0 |  22.806 ns | 0.0291 ns | 0.0258 ns |  22.803 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net461 |  40.681 ns | 0.1059 ns | 0.0991 ns |  40.678 ns |  1.40 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net472 |  40.116 ns | 0.0707 ns | 0.0662 ns |  40.113 ns |  1.38 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.0 | 103.893 ns | 0.3585 ns | 0.3178 ns | 103.962 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.2 |  90.738 ns | 0.7684 ns | 0.7188 ns |  91.120 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 3.0 |  88.644 ns | 0.6110 ns | 0.5716 ns |  88.837 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue |        net461 |  94.617 ns | 0.2950 ns | 0.2759 ns |  94.555 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue |        net472 |  95.013 ns | 0.1960 ns | 0.1737 ns |  94.994 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.0 |  28.008 ns | 0.0479 ns | 0.0424 ns |  28.000 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.2 |  25.638 ns | 0.0212 ns | 0.0188 ns |  25.639 ns |  0.92 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 3.0 |  22.782 ns | 0.0355 ns | 0.0332 ns |  22.789 ns |  0.81 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net461 |  39.620 ns | 0.0806 ns | 0.0754 ns |  39.638 ns |  1.41 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net472 |  37.713 ns | 0.0909 ns | 0.0851 ns |  37.704 ns |  1.35 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.0 |  55.286 ns | 0.0647 ns | 0.0606 ns |  55.293 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.2 |  53.118 ns | 0.0463 ns | 0.0433 ns |  53.125 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 3.0 |  51.421 ns | 0.0861 ns | 0.0763 ns |  51.414 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net461 |  55.391 ns | 0.0509 ns | 0.0451 ns |  55.387 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net472 |  54.850 ns | 0.0994 ns | 0.0881 ns |  54.858 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.0 |  12.227 ns | 0.0130 ns | 0.0115 ns |  12.229 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.2 |  10.499 ns | 0.0158 ns | 0.0140 ns |  10.499 ns |  0.86 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 3.0 |  11.079 ns | 0.0146 ns | 0.0136 ns |  11.083 ns |  0.91 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net461 |  13.840 ns | 0.0339 ns | 0.0301 ns |  13.827 ns |  1.13 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net472 |  15.340 ns | 0.0224 ns | 0.0198 ns |  15.345 ns |  1.25 |    0.00 |      - |     - |     - |         - |

Benchmarks with issues:
  ConvertTo_Enum.From_DateTime_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_Enum.From_DateTime_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_Enum.From_DateTime_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_Enum.From_DateTime_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_Enum.From_DateTime_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_Enum.From_DateTime_Nullable_WithValue_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_Enum.From_DateTime_Nullable_WithValue_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_Enum.From_DateTime_Nullable_WithValue_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_Enum.From_DateTime_Nullable_WithValue_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_Enum.From_DateTime_Nullable_WithValue_AsObject: Job-PJAXXB(Toolchain=net472)
