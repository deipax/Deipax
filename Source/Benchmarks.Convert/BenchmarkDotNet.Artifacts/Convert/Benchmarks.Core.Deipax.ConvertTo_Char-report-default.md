
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
                                             From_Bool | .NET Core 2.0 | 11.691 ns | 0.0696 ns | 0.0651 ns | 11.664 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 2.2 | 10.284 ns | 0.0117 ns | 0.0104 ns | 10.286 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 3.0 |  7.009 ns | 0.1661 ns | 0.2274 ns |  6.879 ns |  0.61 |    0.02 |      - |     - |     - |         - |
                                             From_Bool |        net461 | 11.698 ns | 0.0093 ns | 0.0078 ns | 11.697 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                                             From_Bool |        net472 | 11.685 ns | 0.0136 ns | 0.0127 ns | 11.686 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Bool_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Bool_Nullable_WithValue | .NET Core 2.0 | 11.620 ns | 0.0128 ns | 0.0113 ns | 11.619 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 2.2 | 10.903 ns | 0.0129 ns | 0.0120 ns | 10.903 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 3.0 |  6.929 ns | 0.0642 ns | 0.0601 ns |  6.961 ns |  0.60 |    0.01 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net461 | 10.435 ns | 0.0500 ns | 0.0468 ns | 10.425 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net472 | 11.858 ns | 0.0412 ns | 0.0386 ns | 11.848 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Bool_Nullable_NoValue | .NET Core 2.0 | 11.633 ns | 0.0138 ns | 0.0129 ns | 11.630 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 2.2 | 11.035 ns | 0.0144 ns | 0.0127 ns | 11.037 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 3.0 |  6.727 ns | 0.1387 ns | 0.1297 ns |  6.820 ns |  0.58 |    0.01 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net461 | 10.393 ns | 0.0415 ns | 0.0388 ns | 10.408 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net472 | 11.818 ns | 0.0184 ns | 0.0163 ns | 11.813 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.131 ns | 0.0192 ns | 0.0180 ns | 13.127 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.578 ns | 0.0268 ns | 0.0238 ns | 13.579 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.959 ns | 0.2597 ns | 0.3377 ns | 12.124 ns |  0.90 |    0.03 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net461 | 13.401 ns | 0.0214 ns | 0.0200 ns | 13.403 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net472 | 13.813 ns | 0.0147 ns | 0.0138 ns | 13.811 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Byte | .NET Core 2.0 | 11.667 ns | 0.0516 ns | 0.0483 ns | 11.639 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 2.2 | 10.252 ns | 0.0110 ns | 0.0092 ns | 10.252 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 3.0 |  7.287 ns | 0.0361 ns | 0.0338 ns |  7.300 ns |  0.62 |    0.00 |      - |     - |     - |         - |
                                             From_Byte |        net461 | 10.418 ns | 0.0101 ns | 0.0090 ns | 10.418 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                             From_Byte |        net472 | 10.375 ns | 0.0129 ns | 0.0121 ns | 10.373 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Byte_AsObject | .NET Core 2.0 | 16.517 ns | 0.0136 ns | 0.0121 ns | 16.518 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 2.2 | 16.272 ns | 0.0437 ns | 0.0409 ns | 16.290 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 3.0 | 15.161 ns | 0.0267 ns | 0.0249 ns | 15.154 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net461 | 18.481 ns | 0.0491 ns | 0.0460 ns | 18.483 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net472 | 18.524 ns | 0.0519 ns | 0.0486 ns | 18.535 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Byte_Nullable_WithValue | .NET Core 2.0 | 11.815 ns | 0.0160 ns | 0.0149 ns | 11.813 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 2.2 | 10.574 ns | 0.0378 ns | 0.0354 ns | 10.577 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 3.0 |  6.744 ns | 0.1175 ns | 0.1099 ns |  6.814 ns |  0.57 |    0.01 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net461 | 10.647 ns | 0.0147 ns | 0.0138 ns | 10.646 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net472 | 10.577 ns | 0.0188 ns | 0.0176 ns | 10.582 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.327 ns | 0.0248 ns | 0.0207 ns | 18.324 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.526 ns | 0.0951 ns | 0.0794 ns | 15.493 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 3.0 | 16.240 ns | 0.1054 ns | 0.0986 ns | 16.261 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net461 | 17.999 ns | 0.0197 ns | 0.0174 ns | 18.000 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net472 | 18.204 ns | 0.0292 ns | 0.0273 ns | 18.213 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Byte_Nullable_NoValue | .NET Core 2.0 | 11.604 ns | 0.0117 ns | 0.0104 ns | 11.603 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 2.2 | 10.347 ns | 0.0526 ns | 0.0492 ns | 10.325 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 3.0 |  7.649 ns | 0.0801 ns | 0.0710 ns |  7.668 ns |  0.66 |    0.01 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net461 | 10.539 ns | 0.1133 ns | 0.1060 ns | 10.536 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net472 | 10.337 ns | 0.0623 ns | 0.0583 ns | 10.363 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.129 ns | 0.0129 ns | 0.0115 ns | 13.131 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.481 ns | 0.0099 ns | 0.0093 ns | 13.482 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.982 ns | 0.1934 ns | 0.1809 ns | 14.086 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net461 | 15.078 ns | 0.0317 ns | 0.0281 ns | 15.080 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net472 | 13.206 ns | 0.0150 ns | 0.0133 ns | 13.204 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Char | .NET Core 2.0 | 11.646 ns | 0.0133 ns | 0.0124 ns | 11.643 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Char | .NET Core 2.2 | 10.746 ns | 0.0277 ns | 0.0246 ns | 10.745 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                             From_Char | .NET Core 3.0 |  6.632 ns | 0.0296 ns | 0.0277 ns |  6.645 ns |  0.57 |    0.00 |      - |     - |     - |         - |
                                             From_Char |        net461 | 10.425 ns | 0.0132 ns | 0.0110 ns | 10.425 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                             From_Char |        net472 | 10.343 ns | 0.0126 ns | 0.0118 ns | 10.343 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Char_AsObject | .NET Core 2.0 | 13.694 ns | 0.0142 ns | 0.0133 ns | 13.693 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 2.2 | 14.230 ns | 0.0103 ns | 0.0092 ns | 14.228 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 3.0 | 14.609 ns | 0.0294 ns | 0.0230 ns | 14.610 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject |        net461 | 14.028 ns | 0.0261 ns | 0.0244 ns | 14.029 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject |        net472 | 14.200 ns | 0.0442 ns | 0.0413 ns | 14.196 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Char_Nullable_WithValue | .NET Core 2.0 | 11.898 ns | 0.0967 ns | 0.0905 ns | 11.840 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 2.2 | 10.447 ns | 0.0147 ns | 0.0130 ns | 10.444 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 3.0 |  6.934 ns | 0.4490 ns | 0.5994 ns |  6.607 ns |  0.60 |    0.06 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net461 | 10.586 ns | 0.0167 ns | 0.0156 ns | 10.584 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net472 | 11.152 ns | 0.0136 ns | 0.0127 ns | 11.151 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.0 | 13.693 ns | 0.0107 ns | 0.0089 ns | 13.692 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.2 | 14.262 ns | 0.0111 ns | 0.0093 ns | 14.262 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 3.0 | 13.535 ns | 0.1318 ns | 0.1233 ns | 13.465 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net461 | 14.019 ns | 0.0244 ns | 0.0228 ns | 14.019 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net472 | 14.230 ns | 0.0331 ns | 0.0310 ns | 14.235 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Char_Nullable_NoValue | .NET Core 2.0 | 11.652 ns | 0.0184 ns | 0.0172 ns | 11.653 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 2.2 | 10.330 ns | 0.0119 ns | 0.0111 ns | 10.331 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 3.0 |  6.572 ns | 0.0079 ns | 0.0074 ns |  6.571 ns |  0.56 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net461 | 10.347 ns | 0.0107 ns | 0.0100 ns | 10.345 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net472 | 10.367 ns | 0.0074 ns | 0.0058 ns | 10.367 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.137 ns | 0.0170 ns | 0.0133 ns | 13.139 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.726 ns | 0.0347 ns | 0.0290 ns | 12.732 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.904 ns | 0.0191 ns | 0.0170 ns | 12.901 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net461 | 13.029 ns | 0.0131 ns | 0.0116 ns | 13.030 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net472 | 13.536 ns | 0.0130 ns | 0.0115 ns | 13.534 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                         From_DateTime | .NET Core 2.0 | 11.934 ns | 0.0070 ns | 0.0059 ns | 11.935 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 2.2 | 11.855 ns | 0.0121 ns | 0.0113 ns | 11.859 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 3.0 |  7.594 ns | 0.0189 ns | 0.0177 ns |  7.591 ns |  0.64 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime |        net461 | 11.793 ns | 0.0128 ns | 0.0113 ns | 11.793 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime |        net472 | 13.120 ns | 0.0446 ns | 0.0418 ns | 13.133 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                From_DateTime_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                      From_DateTime_Nullable_WithValue | .NET Core 2.0 | 12.621 ns | 0.0879 ns | 0.0822 ns | 12.573 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 2.2 | 11.859 ns | 0.0830 ns | 0.0777 ns | 11.912 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 3.0 |  8.023 ns | 0.0324 ns | 0.0303 ns |  8.036 ns |  0.64 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net461 | 15.037 ns | 0.0151 ns | 0.0141 ns | 15.041 ns |  1.19 |    0.01 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net472 | 13.246 ns | 0.0120 ns | 0.0112 ns | 13.248 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_DateTime_Nullable_NoValue | .NET Core 2.0 | 12.566 ns | 0.0186 ns | 0.0174 ns | 12.565 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 2.2 | 11.783 ns | 0.0159 ns | 0.0149 ns | 11.784 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 3.0 |  7.974 ns | 0.0086 ns | 0.0080 ns |  7.975 ns |  0.63 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net461 | 13.326 ns | 0.1454 ns | 0.1360 ns | 13.345 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net472 | 13.232 ns | 0.0317 ns | 0.0265 ns | 13.227 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.033 ns | 0.0106 ns | 0.0094 ns | 14.035 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.572 ns | 0.0483 ns | 0.0452 ns | 13.584 ns |  0.97 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.738 ns | 0.0456 ns | 0.0381 ns | 13.732 ns |  0.98 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net461 | 13.182 ns | 0.0194 ns | 0.0181 ns | 13.177 ns |  0.94 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net472 | 13.222 ns | 0.0114 ns | 0.0107 ns | 13.224 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                          From_Decimal | .NET Core 2.0 | 12.565 ns | 0.0117 ns | 0.0103 ns | 12.565 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 2.2 | 11.166 ns | 0.0124 ns | 0.0110 ns | 11.164 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 3.0 |  7.970 ns | 0.0152 ns | 0.0135 ns |  7.972 ns |  0.63 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal |        net461 | 12.587 ns | 0.0089 ns | 0.0079 ns | 12.587 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal |        net472 | 13.376 ns | 0.0620 ns | 0.0580 ns | 13.392 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                 From_Decimal_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                       From_Decimal_Nullable_WithValue | .NET Core 2.0 | 12.688 ns | 0.0892 ns | 0.0835 ns | 12.701 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 2.2 | 11.764 ns | 0.0154 ns | 0.0144 ns | 11.765 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 3.0 |  7.698 ns | 0.0423 ns | 0.0395 ns |  7.678 ns |  0.61 |    0.01 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net461 | 13.965 ns | 0.0179 ns | 0.0168 ns | 13.961 ns |  1.10 |    0.01 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net472 | 14.866 ns | 0.0171 ns | 0.0160 ns | 14.871 ns |  1.17 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Decimal_Nullable_NoValue | .NET Core 2.0 | 12.599 ns | 0.0148 ns | 0.0132 ns | 12.601 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 2.2 | 11.754 ns | 0.0162 ns | 0.0126 ns | 11.750 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 3.0 |  8.533 ns | 0.1943 ns | 0.3602 ns |  8.722 ns |  0.65 |    0.03 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net461 | 13.131 ns | 0.0160 ns | 0.0142 ns | 13.134 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net472 | 14.473 ns | 0.0332 ns | 0.0294 ns | 14.467 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.238 ns | 0.0370 ns | 0.0309 ns | 13.246 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.628 ns | 0.0077 ns | 0.0060 ns | 12.627 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.806 ns | 0.1416 ns | 0.1324 ns | 13.743 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net461 | 13.288 ns | 0.0162 ns | 0.0144 ns | 13.290 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net472 | 13.487 ns | 0.0179 ns | 0.0167 ns | 13.484 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_Double | .NET Core 2.0 | 11.775 ns | 0.0236 ns | 0.0221 ns | 11.778 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 2.2 | 10.286 ns | 0.0101 ns | 0.0085 ns | 10.288 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 3.0 |  6.970 ns | 0.0123 ns | 0.0115 ns |  6.967 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                                           From_Double |        net461 | 10.384 ns | 0.0121 ns | 0.0107 ns | 10.388 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                           From_Double |        net472 | 11.898 ns | 0.0623 ns | 0.0583 ns | 11.920 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_Double_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                  From_Double_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                  From_Double_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_Double_Nullable_WithValue | .NET Core 2.0 | 12.754 ns | 0.0504 ns | 0.0471 ns | 12.757 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 2.2 | 11.774 ns | 0.0091 ns | 0.0071 ns | 11.776 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 3.0 |  8.077 ns | 0.0445 ns | 0.0348 ns |  8.086 ns |  0.63 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net461 | 12.606 ns | 0.0231 ns | 0.0204 ns | 12.604 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net472 | 13.290 ns | 0.0184 ns | 0.0163 ns | 13.297 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Double_Nullable_NoValue | .NET Core 2.0 | 12.624 ns | 0.0177 ns | 0.0156 ns | 12.617 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 2.2 | 11.824 ns | 0.0592 ns | 0.0554 ns | 11.846 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 3.0 |  7.977 ns | 0.0237 ns | 0.0222 ns |  7.974 ns |  0.63 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net461 | 12.590 ns | 0.0177 ns | 0.0166 ns | 12.591 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net472 | 13.237 ns | 0.0337 ns | 0.0299 ns | 13.230 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.151 ns | 0.0167 ns | 0.0148 ns | 13.151 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.643 ns | 0.0152 ns | 0.0135 ns | 12.639 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.979 ns | 0.0452 ns | 0.0423 ns | 12.968 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net461 | 13.244 ns | 0.0222 ns | 0.0208 ns | 13.241 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net472 | 13.383 ns | 0.0698 ns | 0.0653 ns | 13.350 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_Short | .NET Core 2.0 | 11.897 ns | 0.0125 ns | 0.0117 ns | 11.894 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 2.2 | 10.441 ns | 0.0594 ns | 0.0555 ns | 10.409 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 3.0 |  6.740 ns | 0.0388 ns | 0.0324 ns |  6.735 ns |  0.57 |    0.00 |      - |     - |     - |         - |
                                            From_Short |        net461 | 12.251 ns | 0.0123 ns | 0.0115 ns | 12.252 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                            From_Short |        net472 | 10.779 ns | 0.0208 ns | 0.0174 ns | 10.783 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_Short_AsObject | .NET Core 2.0 | 18.788 ns | 0.0281 ns | 0.0263 ns | 18.781 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 2.2 | 15.919 ns | 0.0100 ns | 0.0089 ns | 15.921 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 3.0 | 15.334 ns | 0.0281 ns | 0.0263 ns | 15.334 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net461 | 20.257 ns | 0.0282 ns | 0.0250 ns | 20.262 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net472 | 18.931 ns | 0.0308 ns | 0.0273 ns | 18.933 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Short_Nullable_WithValue | .NET Core 2.0 | 11.934 ns | 0.0077 ns | 0.0068 ns | 11.934 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 2.2 | 10.578 ns | 0.0134 ns | 0.0125 ns | 10.578 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 3.0 |  7.703 ns | 0.0887 ns | 0.0830 ns |  7.650 ns |  0.65 |    0.01 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net461 | 13.037 ns | 0.0147 ns | 0.0130 ns | 13.034 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net472 | 11.937 ns | 0.0539 ns | 0.0504 ns | 11.914 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.0 | 16.945 ns | 0.0177 ns | 0.0165 ns | 16.946 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.2 | 16.011 ns | 0.0784 ns | 0.0733 ns | 16.012 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.608 ns | 0.3733 ns | 0.8652 ns | 17.944 ns |  0.97 |    0.07 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net461 | 18.835 ns | 0.0228 ns | 0.0214 ns | 18.830 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net472 | 18.931 ns | 0.0323 ns | 0.0302 ns | 18.933 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Short_Nullable_NoValue | .NET Core 2.0 | 11.781 ns | 0.0195 ns | 0.0183 ns | 11.782 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 2.2 | 10.350 ns | 0.0140 ns | 0.0131 ns | 10.347 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 3.0 |  7.171 ns | 0.0549 ns | 0.0514 ns |  7.199 ns |  0.61 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net461 | 10.386 ns | 0.0099 ns | 0.0088 ns | 10.384 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net472 | 10.267 ns | 0.0167 ns | 0.0139 ns | 10.270 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.052 ns | 0.0376 ns | 0.0351 ns | 14.041 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.637 ns | 0.0134 ns | 0.0119 ns | 12.637 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.838 ns | 0.2818 ns | 0.3245 ns | 12.951 ns |  0.91 |    0.02 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net461 | 14.922 ns | 0.0273 ns | 0.0256 ns | 14.919 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net472 | 13.254 ns | 0.0637 ns | 0.0596 ns | 13.230 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                              From_Int | .NET Core 2.0 | 12.089 ns | 0.0270 ns | 0.0252 ns | 12.078 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 2.2 | 10.649 ns | 0.0556 ns | 0.0520 ns | 10.624 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 3.0 |  7.815 ns | 0.0126 ns | 0.0118 ns |  7.816 ns |  0.65 |    0.00 |      - |     - |     - |         - |
                                              From_Int |        net461 | 12.895 ns | 0.0207 ns | 0.0184 ns | 12.893 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                              From_Int |        net472 | 11.042 ns | 0.0419 ns | 0.0372 ns | 11.034 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_Int_AsObject | .NET Core 2.0 | 17.516 ns | 0.0337 ns | 0.0298 ns | 17.520 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 2.2 | 16.167 ns | 0.0225 ns | 0.0210 ns | 16.173 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 3.0 | 17.021 ns | 0.0423 ns | 0.0330 ns | 17.027 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net461 | 18.808 ns | 0.0253 ns | 0.0237 ns | 18.808 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net472 | 18.961 ns | 0.0203 ns | 0.0190 ns | 18.959 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Int_Nullable_WithValue | .NET Core 2.0 | 13.096 ns | 0.0296 ns | 0.0262 ns | 13.093 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 2.2 | 11.615 ns | 0.0155 ns | 0.0137 ns | 11.619 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 3.0 |  8.107 ns | 0.0124 ns | 0.0116 ns |  8.110 ns |  0.62 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net461 | 12.206 ns | 0.0084 ns | 0.0074 ns | 12.203 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net472 | 11.963 ns | 0.0590 ns | 0.0552 ns | 11.978 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.0 | 17.544 ns | 0.0247 ns | 0.0219 ns | 17.540 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.010 ns | 0.0594 ns | 0.0555 ns | 17.022 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.125 ns | 0.3674 ns | 0.3437 ns | 16.845 ns |  0.97 |    0.02 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net461 | 20.260 ns | 0.0179 ns | 0.0159 ns | 20.260 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net472 | 19.002 ns | 0.0425 ns | 0.0377 ns | 18.988 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_Int_Nullable_NoValue | .NET Core 2.0 | 12.442 ns | 0.0698 ns | 0.0653 ns | 12.467 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 2.2 | 10.308 ns | 0.0125 ns | 0.0105 ns | 10.311 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 3.0 |  7.108 ns | 0.0213 ns | 0.0200 ns |  7.108 ns |  0.57 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net461 | 10.979 ns | 0.2398 ns | 0.2665 ns | 10.950 ns |  0.88 |    0.02 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net472 | 10.237 ns | 0.0150 ns | 0.0133 ns | 10.236 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.178 ns | 0.0089 ns | 0.0083 ns | 13.177 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.636 ns | 0.0152 ns | 0.0135 ns | 12.639 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.308 ns | 0.0180 ns | 0.0169 ns | 11.313 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net461 | 13.145 ns | 0.0245 ns | 0.0205 ns | 13.152 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net472 | 13.923 ns | 0.0495 ns | 0.0463 ns | 13.901 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Long | .NET Core 2.0 | 11.990 ns | 0.0110 ns | 0.0092 ns | 11.988 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Long | .NET Core 2.2 | 10.678 ns | 0.0620 ns | 0.0550 ns | 10.697 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                             From_Long | .NET Core 3.0 |  7.908 ns | 0.0156 ns | 0.0138 ns |  7.905 ns |  0.66 |    0.00 |      - |     - |     - |         - |
                                             From_Long |        net461 | 10.779 ns | 0.0132 ns | 0.0123 ns | 10.774 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                             From_Long |        net472 | 10.997 ns | 0.0216 ns | 0.0202 ns | 10.999 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Long_AsObject | .NET Core 2.0 | 17.410 ns | 0.0666 ns | 0.0623 ns | 17.439 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 2.2 | 16.159 ns | 0.0197 ns | 0.0184 ns | 16.156 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 3.0 | 16.751 ns | 0.0620 ns | 0.0580 ns | 16.772 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net461 | 18.687 ns | 0.0350 ns | 0.0310 ns | 18.691 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net472 | 18.780 ns | 0.0419 ns | 0.0392 ns | 18.782 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Long_Nullable_WithValue | .NET Core 2.0 | 13.509 ns | 0.0188 ns | 0.0157 ns | 13.509 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 2.2 | 12.575 ns | 0.0118 ns | 0.0092 ns | 12.574 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 3.0 | 10.806 ns | 0.0131 ns | 0.0116 ns | 10.803 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net461 | 14.500 ns | 0.0415 ns | 0.0368 ns | 14.495 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net472 | 13.918 ns | 0.0711 ns | 0.0665 ns | 13.913 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.0 | 17.479 ns | 0.0240 ns | 0.0213 ns | 17.482 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.2 | 16.311 ns | 0.0209 ns | 0.0195 ns | 16.311 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.748 ns | 0.0212 ns | 0.0199 ns | 15.748 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net461 | 18.766 ns | 0.0387 ns | 0.0362 ns | 18.768 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net472 | 18.927 ns | 0.0411 ns | 0.0384 ns | 18.930 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Long_Nullable_NoValue | .NET Core 2.0 | 12.641 ns | 0.0771 ns | 0.0721 ns | 12.674 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 2.2 | 11.342 ns | 0.0120 ns | 0.0112 ns | 11.340 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 3.0 |  7.926 ns | 0.0219 ns | 0.0205 ns |  7.931 ns |  0.63 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net461 | 12.695 ns | 0.0142 ns | 0.0126 ns | 12.694 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net472 | 12.773 ns | 0.0580 ns | 0.0542 ns | 12.754 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.149 ns | 0.0104 ns | 0.0086 ns | 13.150 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.632 ns | 0.0117 ns | 0.0110 ns | 12.633 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.350 ns | 0.1976 ns | 0.1848 ns | 11.234 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net461 | 15.159 ns | 0.0227 ns | 0.0190 ns | 15.154 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net472 | 13.276 ns | 0.0232 ns | 0.0217 ns | 13.280 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_SByte | .NET Core 2.0 | 11.775 ns | 0.0108 ns | 0.0101 ns | 11.775 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 2.2 | 10.506 ns | 0.0330 ns | 0.0309 ns | 10.513 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 3.0 |  7.163 ns | 0.0516 ns | 0.0483 ns |  7.191 ns |  0.61 |    0.00 |      - |     - |     - |         - |
                                            From_SByte |        net461 | 10.674 ns | 0.0147 ns | 0.0138 ns | 10.677 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                            From_SByte |        net472 | 10.841 ns | 0.0203 ns | 0.0190 ns | 10.835 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_SByte_AsObject | .NET Core 2.0 | 16.980 ns | 0.0493 ns | 0.0461 ns | 16.997 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 2.2 | 16.517 ns | 0.0229 ns | 0.0214 ns | 16.509 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 3.0 | 16.656 ns | 0.2840 ns | 0.2656 ns | 16.484 ns |  0.98 |    0.02 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net461 | 18.870 ns | 0.0333 ns | 0.0278 ns | 18.873 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net472 | 18.973 ns | 0.0480 ns | 0.0449 ns | 18.974 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_SByte_Nullable_WithValue | .NET Core 2.0 | 11.903 ns | 0.0145 ns | 0.0128 ns | 11.903 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 2.2 | 10.564 ns | 0.0135 ns | 0.0127 ns | 10.562 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 3.0 |  8.218 ns | 0.1861 ns | 0.2842 ns |  8.378 ns |  0.68 |    0.03 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net461 | 12.032 ns | 0.0160 ns | 0.0142 ns | 12.028 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net472 | 11.884 ns | 0.0129 ns | 0.0120 ns | 11.881 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.0 | 16.863 ns | 0.0249 ns | 0.0195 ns | 16.860 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.779 ns | 0.0971 ns | 0.0908 ns | 15.736 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 3.0 | 16.282 ns | 0.3113 ns | 0.2912 ns | 16.071 ns |  0.96 |    0.02 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net461 | 19.928 ns | 0.0270 ns | 0.0253 ns | 19.926 ns |  1.18 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net472 | 18.720 ns | 0.0417 ns | 0.0390 ns | 18.714 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_SByte_Nullable_NoValue | .NET Core 2.0 | 11.773 ns | 0.0174 ns | 0.0163 ns | 11.774 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 2.2 | 10.838 ns | 0.0110 ns | 0.0103 ns | 10.837 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 3.0 |  7.070 ns | 0.0110 ns | 0.0103 ns |  7.073 ns |  0.60 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net461 | 11.924 ns | 0.0745 ns | 0.0697 ns | 11.930 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net472 | 11.495 ns | 0.0201 ns | 0.0157 ns | 11.488 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.148 ns | 0.0078 ns | 0.0073 ns | 13.144 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.641 ns | 0.0091 ns | 0.0085 ns | 12.640 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.932 ns | 0.2635 ns | 0.3034 ns | 12.070 ns |  0.90 |    0.03 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net461 | 14.354 ns | 0.0182 ns | 0.0161 ns | 14.355 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net472 | 14.412 ns | 0.0443 ns | 0.0415 ns | 14.393 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_Float | .NET Core 2.0 | 12.317 ns | 0.0157 ns | 0.0139 ns | 12.321 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 2.2 | 10.375 ns | 0.0678 ns | 0.0634 ns | 10.404 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                                            From_Float | .NET Core 3.0 |  7.159 ns | 0.1675 ns | 0.1645 ns |  7.287 ns |  0.58 |    0.01 |      - |     - |     - |         - |
                                            From_Float |        net461 | 10.888 ns | 0.0698 ns | 0.0653 ns | 10.889 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                                            From_Float |        net472 | 12.047 ns | 0.0159 ns | 0.0149 ns | 12.044 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_Float_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                   From_Float_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                   From_Float_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Float_Nullable_WithValue | .NET Core 2.0 | 11.605 ns | 0.0121 ns | 0.0113 ns | 11.603 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 2.2 | 10.773 ns | 0.0113 ns | 0.0106 ns | 10.776 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 3.0 |  6.685 ns | 0.1170 ns | 0.1095 ns |  6.611 ns |  0.58 |    0.01 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net461 | 10.332 ns | 0.0180 ns | 0.0159 ns | 10.337 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net472 | 11.828 ns | 0.0200 ns | 0.0177 ns | 11.831 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Float_Nullable_NoValue | .NET Core 2.0 | 11.626 ns | 0.0240 ns | 0.0212 ns | 11.623 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 2.2 | 10.768 ns | 0.0113 ns | 0.0094 ns | 10.767 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 3.0 |  8.325 ns | 0.1926 ns | 0.4831 ns |  8.478 ns |  0.66 |    0.07 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net461 | 10.328 ns | 0.0168 ns | 0.0157 ns | 10.331 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net472 | 12.044 ns | 0.0568 ns | 0.0531 ns | 12.066 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.364 ns | 0.0130 ns | 0.0116 ns | 13.365 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.640 ns | 0.0132 ns | 0.0124 ns | 12.637 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.774 ns | 0.3185 ns | 0.6361 ns | 15.008 ns |  1.06 |    0.07 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net461 | 13.393 ns | 0.0205 ns | 0.0192 ns | 13.397 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net472 | 13.194 ns | 0.0136 ns | 0.0121 ns | 13.193 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_String | .NET Core 2.0 | 13.099 ns | 0.0118 ns | 0.0110 ns | 13.099 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 2.2 | 13.361 ns | 0.0227 ns | 0.0178 ns | 13.365 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 3.0 | 12.071 ns | 0.0194 ns | 0.0162 ns | 12.075 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                           From_String |        net461 | 13.930 ns | 0.0193 ns | 0.0181 ns | 13.932 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                           From_String |        net472 | 13.951 ns | 0.0163 ns | 0.0153 ns | 13.946 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_String_AsObject | .NET Core 2.0 | 17.309 ns | 0.0153 ns | 0.0136 ns | 17.307 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 2.2 | 17.847 ns | 0.0233 ns | 0.0206 ns | 17.846 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 3.0 | 14.865 ns | 0.0328 ns | 0.0306 ns | 14.861 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject |        net461 | 18.245 ns | 0.0408 ns | 0.0382 ns | 18.239 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject |        net472 | 20.834 ns | 0.0177 ns | 0.0157 ns | 20.838 ns |  1.20 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                      From_String_Null | .NET Core 2.0 | 12.109 ns | 0.0052 ns | 0.0046 ns | 12.109 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 2.2 | 11.804 ns | 0.0390 ns | 0.0365 ns | 11.821 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 3.0 | 14.900 ns | 0.3216 ns | 0.5194 ns | 14.535 ns |  1.28 |    0.02 |      - |     - |     - |         - |
                                      From_String_Null |        net461 | 12.638 ns | 0.0114 ns | 0.0107 ns | 12.637 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null |        net472 | 11.160 ns | 0.0166 ns | 0.0155 ns | 11.155 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_String_Null_AsObject | .NET Core 2.0 | 13.384 ns | 0.0102 ns | 0.0095 ns | 13.380 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 2.2 | 12.627 ns | 0.0147 ns | 0.0137 ns | 12.624 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 3.0 | 14.490 ns | 0.0436 ns | 0.0408 ns | 14.486 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net461 | 13.168 ns | 0.0191 ns | 0.0179 ns | 13.172 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net472 | 13.254 ns | 0.0289 ns | 0.0271 ns | 13.247 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_String_Empty | .NET Core 2.0 | 12.186 ns | 0.0155 ns | 0.0138 ns | 12.188 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 2.2 | 11.640 ns | 0.0126 ns | 0.0118 ns | 11.639 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 3.0 | 11.996 ns | 0.1473 ns | 0.1377 ns | 11.968 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                                     From_String_Empty |        net461 | 14.177 ns | 0.0195 ns | 0.0183 ns | 14.181 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty |        net472 | 12.719 ns | 0.0204 ns | 0.0191 ns | 12.717 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_String_Empty_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_UShort | .NET Core 2.0 | 11.773 ns | 0.0628 ns | 0.0587 ns | 11.786 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 2.2 | 10.833 ns | 0.0100 ns | 0.0094 ns | 10.835 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 3.0 |  7.311 ns | 0.0115 ns | 0.0107 ns |  7.310 ns |  0.62 |    0.00 |      - |     - |     - |         - |
                                           From_UShort |        net461 | 10.381 ns | 0.0362 ns | 0.0321 ns | 10.387 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                                           From_UShort |        net472 | 10.382 ns | 0.0247 ns | 0.0231 ns | 10.376 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_UShort_AsObject | .NET Core 2.0 | 16.574 ns | 0.0220 ns | 0.0183 ns | 16.579 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 2.2 | 15.468 ns | 0.0246 ns | 0.0230 ns | 15.465 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 3.0 | 15.146 ns | 0.0287 ns | 0.0240 ns | 15.143 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net461 | 18.023 ns | 0.0217 ns | 0.0193 ns | 18.022 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net472 | 18.323 ns | 0.0231 ns | 0.0216 ns | 18.319 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_UShort_Nullable_WithValue | .NET Core 2.0 | 11.841 ns | 0.0138 ns | 0.0129 ns | 11.843 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 2.2 | 10.786 ns | 0.0437 ns | 0.0408 ns | 10.772 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 3.0 |  6.814 ns | 0.0150 ns | 0.0125 ns |  6.814 ns |  0.58 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net461 | 10.606 ns | 0.0116 ns | 0.0103 ns | 10.606 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net472 | 10.588 ns | 0.0135 ns | 0.0126 ns | 10.592 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.0 | 17.022 ns | 0.0238 ns | 0.0223 ns | 17.027 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.450 ns | 0.0287 ns | 0.0254 ns | 15.464 ns |  0.91 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.537 ns | 0.0354 ns | 0.0314 ns | 15.542 ns |  0.91 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net461 | 18.388 ns | 0.0208 ns | 0.0195 ns | 18.383 ns |  1.08 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net472 | 18.392 ns | 0.0315 ns | 0.0279 ns | 18.384 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_UShort_Nullable_NoValue | .NET Core 2.0 | 11.653 ns | 0.0111 ns | 0.0099 ns | 11.652 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 2.2 | 10.320 ns | 0.0169 ns | 0.0158 ns | 10.322 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 3.0 |  7.385 ns | 0.0148 ns | 0.0131 ns |  7.380 ns |  0.63 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net461 | 10.363 ns | 0.0203 ns | 0.0190 ns | 10.361 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net472 | 10.337 ns | 0.0175 ns | 0.0164 ns | 10.334 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.161 ns | 0.0096 ns | 0.0090 ns | 13.163 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.691 ns | 0.0380 ns | 0.0356 ns | 12.674 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.376 ns | 0.1844 ns | 0.1725 ns | 11.338 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net461 | 13.094 ns | 0.0232 ns | 0.0205 ns | 13.092 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net472 | 13.830 ns | 0.0161 ns | 0.0142 ns | 13.835 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_UInt | .NET Core 2.0 | 13.340 ns | 0.0692 ns | 0.0578 ns | 13.358 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 2.2 | 10.404 ns | 0.0153 ns | 0.0143 ns | 10.405 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 3.0 |  7.385 ns | 0.0127 ns | 0.0112 ns |  7.383 ns |  0.55 |    0.00 |      - |     - |     - |         - |
                                             From_UInt |        net461 | 10.973 ns | 0.0155 ns | 0.0145 ns | 10.975 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                             From_UInt |        net472 | 10.793 ns | 0.0169 ns | 0.0150 ns | 10.794 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_UInt_AsObject | .NET Core 2.0 | 17.167 ns | 0.0210 ns | 0.0164 ns | 17.167 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 2.2 | 17.361 ns | 0.0229 ns | 0.0203 ns | 17.363 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 3.0 | 16.093 ns | 0.0350 ns | 0.0310 ns | 16.089 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net461 | 19.413 ns | 0.0417 ns | 0.0369 ns | 19.416 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net472 | 19.527 ns | 0.0700 ns | 0.0655 ns | 19.546 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_UInt_Nullable_WithValue | .NET Core 2.0 | 11.909 ns | 0.0120 ns | 0.0112 ns | 11.910 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 2.2 | 10.633 ns | 0.0597 ns | 0.0558 ns | 10.663 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 3.0 |  7.992 ns | 0.6174 ns | 0.7349 ns |  7.590 ns |  0.68 |    0.07 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net461 | 12.001 ns | 0.0158 ns | 0.0132 ns | 12.000 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net472 | 11.873 ns | 0.0113 ns | 0.0100 ns | 11.874 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.0 | 17.017 ns | 0.0310 ns | 0.0275 ns | 17.020 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.770 ns | 0.0162 ns | 0.0136 ns | 15.771 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.521 ns | 0.0163 ns | 0.0136 ns | 15.516 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net461 | 19.040 ns | 0.0211 ns | 0.0187 ns | 19.040 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net472 | 19.178 ns | 0.0265 ns | 0.0248 ns | 19.170 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_UInt_Nullable_NoValue | .NET Core 2.0 | 12.577 ns | 0.0075 ns | 0.0063 ns | 12.575 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 2.2 | 10.978 ns | 0.2277 ns | 0.2130 ns | 10.924 ns |  0.87 |    0.02 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 3.0 |  6.599 ns | 0.0143 ns | 0.0127 ns |  6.596 ns |  0.52 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net461 | 10.476 ns | 0.0116 ns | 0.0103 ns | 10.478 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net472 | 10.347 ns | 0.0179 ns | 0.0168 ns | 10.348 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.163 ns | 0.0137 ns | 0.0128 ns | 13.164 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.556 ns | 0.0664 ns | 0.0621 ns | 13.589 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.769 ns | 0.2437 ns | 0.2393 ns | 11.642 ns |  0.89 |    0.02 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net461 | 13.144 ns | 0.0105 ns | 0.0093 ns | 13.142 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net472 | 13.749 ns | 0.0152 ns | 0.0142 ns | 13.750 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_ULong | .NET Core 2.0 | 12.094 ns | 0.0610 ns | 0.0571 ns | 12.117 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 2.2 | 10.611 ns | 0.0114 ns | 0.0101 ns | 10.611 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 3.0 |  7.506 ns | 0.0130 ns | 0.0109 ns |  7.505 ns |  0.62 |    0.00 |      - |     - |     - |         - |
                                            From_ULong |        net461 | 10.673 ns | 0.0169 ns | 0.0150 ns | 10.678 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                            From_ULong |        net472 | 10.853 ns | 0.0124 ns | 0.0103 ns | 10.858 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_ULong_AsObject | .NET Core 2.0 | 17.778 ns | 0.0230 ns | 0.0192 ns | 17.785 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 2.2 | 16.390 ns | 0.0255 ns | 0.0239 ns | 16.394 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 3.0 | 16.205 ns | 0.0347 ns | 0.0324 ns | 16.214 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net461 | 20.187 ns | 0.0241 ns | 0.0214 ns | 20.180 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net472 | 18.972 ns | 0.0213 ns | 0.0188 ns | 18.969 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_ULong_Nullable_WithValue | .NET Core 2.0 | 14.460 ns | 0.0197 ns | 0.0184 ns | 14.458 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 2.2 | 12.732 ns | 0.0161 ns | 0.0150 ns | 12.732 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 3.0 | 10.378 ns | 0.0141 ns | 0.0132 ns | 10.378 ns |  0.72 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net461 | 13.982 ns | 0.0485 ns | 0.0405 ns | 13.992 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net472 | 13.826 ns | 0.0182 ns | 0.0170 ns | 13.827 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.914 ns | 0.0289 ns | 0.0270 ns | 18.922 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.2 | 16.396 ns | 0.0168 ns | 0.0140 ns | 16.392 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 3.0 | 16.631 ns | 0.0212 ns | 0.0199 ns | 16.628 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net461 | 20.194 ns | 0.0241 ns | 0.0214 ns | 20.202 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net472 | 18.881 ns | 0.0306 ns | 0.0271 ns | 18.877 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_ULong_Nullable_NoValue | .NET Core 2.0 | 12.512 ns | 0.0150 ns | 0.0125 ns | 12.510 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 2.2 | 11.360 ns | 0.0136 ns | 0.0128 ns | 11.359 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 3.0 |  8.423 ns | 0.0090 ns | 0.0080 ns |  8.422 ns |  0.67 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net461 | 12.687 ns | 0.0135 ns | 0.0126 ns | 12.686 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net472 | 12.810 ns | 0.0452 ns | 0.0423 ns | 12.817 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.138 ns | 0.0151 ns | 0.0118 ns | 13.136 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.2 | 15.423 ns | 0.0661 ns | 0.0619 ns | 15.452 ns |  1.17 |    0.01 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.565 ns | 0.0267 ns | 0.0249 ns | 11.566 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net461 | 13.037 ns | 0.0154 ns | 0.0137 ns | 13.035 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net472 | 13.188 ns | 0.0110 ns | 0.0102 ns | 13.192 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                       From_NullObject | .NET Core 2.0 | 14.028 ns | 0.0206 ns | 0.0193 ns | 14.028 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 2.2 | 13.472 ns | 0.0111 ns | 0.0104 ns | 13.473 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 3.0 | 13.022 ns | 0.0457 ns | 0.0405 ns | 13.033 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject |        net461 | 13.037 ns | 0.0237 ns | 0.0221 ns | 13.034 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject |        net472 | 13.188 ns | 0.0100 ns | 0.0094 ns | 13.187 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_DBNull | .NET Core 2.0 | 10.733 ns | 0.0155 ns | 0.0138 ns | 10.732 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 2.2 |  9.503 ns | 0.2162 ns | 0.2655 ns |  9.483 ns |  0.88 |    0.03 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 3.0 | 11.075 ns | 0.2288 ns | 0.2140 ns | 11.236 ns |  1.03 |    0.02 |      - |     - |     - |         - |
                                           From_DBNull |        net461 | 11.043 ns | 0.0193 ns | 0.0181 ns | 11.047 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull |        net472 | 11.050 ns | 0.0204 ns | 0.0191 ns | 11.049 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_DBNull_AsObject | .NET Core 2.0 | 13.185 ns | 0.0734 ns | 0.0686 ns | 13.151 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 2.2 | 13.616 ns | 0.0244 ns | 0.0216 ns | 13.609 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 3.0 | 11.743 ns | 0.4416 ns | 0.7003 ns | 11.354 ns |  0.93 |    0.06 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net461 | 13.038 ns | 0.0241 ns | 0.0213 ns | 13.038 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net472 | 13.197 ns | 0.0168 ns | 0.0157 ns | 13.196 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                 From_ConvertibleClass | .NET Core 2.0 | 16.469 ns | 0.0220 ns | 0.0195 ns | 16.469 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 2.2 | 12.555 ns | 0.0105 ns | 0.0087 ns | 12.555 ns |  0.76 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 3.0 | 13.184 ns | 0.0553 ns | 0.0462 ns | 13.192 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net461 | 18.586 ns | 0.0452 ns | 0.0423 ns | 18.607 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net472 | 16.980 ns | 0.0410 ns | 0.0383 ns | 16.984 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_ConvertibleClass_AsObject | .NET Core 2.0 | 15.783 ns | 0.0344 ns | 0.0305 ns | 15.772 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 2.2 | 15.224 ns | 0.0204 ns | 0.0181 ns | 15.223 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 3.0 | 15.164 ns | 0.0383 ns | 0.0339 ns | 15.151 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net461 | 18.425 ns | 0.0327 ns | 0.0306 ns | 18.433 ns |  1.17 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net472 | 17.118 ns | 0.0719 ns | 0.0672 ns | 17.095 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_ConvertibleClass_NoValue | .NET Core 2.0 | 14.125 ns | 0.0098 ns | 0.0092 ns | 14.124 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 2.2 | 11.730 ns | 0.0594 ns | 0.0556 ns | 11.765 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 3.0 | 11.741 ns | 0.0786 ns | 0.0736 ns | 11.706 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net461 | 13.148 ns | 0.0253 ns | 0.0237 ns | 13.155 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net472 | 15.713 ns | 0.0169 ns | 0.0158 ns | 15.709 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.0 | 13.130 ns | 0.0134 ns | 0.0125 ns | 13.130 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.2 | 13.472 ns | 0.0177 ns | 0.0165 ns | 13.478 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 3.0 | 11.237 ns | 0.0170 ns | 0.0159 ns | 11.236 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net461 | 13.100 ns | 0.0286 ns | 0.0268 ns | 13.092 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net472 | 13.254 ns | 0.0342 ns | 0.0320 ns | 13.262 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                              From_NonConvertibleClass | .NET Core 2.0 | 12.726 ns | 0.0122 ns | 0.0108 ns | 12.725 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 2.2 | 10.328 ns | 0.0122 ns | 0.0114 ns | 10.329 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 3.0 | 11.398 ns | 0.0217 ns | 0.0181 ns | 11.405 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net461 | 13.955 ns | 0.0099 ns | 0.0082 ns | 13.955 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net472 | 12.359 ns | 0.0256 ns | 0.0239 ns | 12.357 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                     From_NonConvertibleClass_AsObject | .NET Core 2.0 | 14.364 ns | 0.0435 ns | 0.0407 ns | 14.372 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 2.2 | 15.895 ns | 0.0525 ns | 0.0465 ns | 15.903 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 3.0 | 15.108 ns | 0.0880 ns | 0.0823 ns | 15.066 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net461 | 14.798 ns | 0.0228 ns | 0.0213 ns | 14.800 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net472 | 17.489 ns | 0.0348 ns | 0.0325 ns | 17.491 ns |  1.22 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                      From_NonConvertibleClass_NoValue | .NET Core 2.0 | 12.750 ns | 0.0214 ns | 0.0190 ns | 12.751 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 2.2 | 10.328 ns | 0.0135 ns | 0.0126 ns | 10.326 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 3.0 | 12.031 ns | 0.0104 ns | 0.0098 ns | 12.031 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net461 | 12.348 ns | 0.0216 ns | 0.0202 ns | 12.351 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net472 | 12.657 ns | 0.0569 ns | 0.0532 ns | 12.672 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.0 | 14.816 ns | 0.0506 ns | 0.0473 ns | 14.799 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.2 | 12.647 ns | 0.0107 ns | 0.0100 ns | 12.648 ns |  0.85 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 3.0 | 13.723 ns | 0.0245 ns | 0.0229 ns | 13.727 ns |  0.93 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net461 | 17.510 ns | 0.0256 ns | 0.0213 ns | 17.507 ns |  1.18 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net472 | 13.376 ns | 0.0211 ns | 0.0197 ns | 13.374 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                From_ConvertibleStruct | .NET Core 2.0 | 18.653 ns | 0.0538 ns | 0.0503 ns | 18.662 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 2.2 | 16.148 ns | 0.0716 ns | 0.0635 ns | 16.167 ns |  0.87 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 3.0 | 11.018 ns | 0.0515 ns | 0.0482 ns | 11.026 ns |  0.59 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net461 | 16.609 ns | 0.0282 ns | 0.0263 ns | 16.610 ns |  0.89 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net472 | 16.697 ns | 0.0252 ns | 0.0197 ns | 16.705 ns |  0.89 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                       From_ConvertibleStruct_AsObject | .NET Core 2.0 | 15.918 ns | 0.0128 ns | 0.0100 ns | 15.920 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 2.2 | 16.094 ns | 0.0167 ns | 0.0156 ns | 16.093 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 3.0 | 15.413 ns | 0.0261 ns | 0.0232 ns | 15.410 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net461 | 17.563 ns | 0.0479 ns | 0.0448 ns | 17.549 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net472 | 18.257 ns | 0.0895 ns | 0.0794 ns | 18.283 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.0 | 18.829 ns | 0.0588 ns | 0.0550 ns | 18.831 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.2 | 15.974 ns | 0.0417 ns | 0.0390 ns | 15.962 ns |  0.85 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 3.0 | 12.555 ns | 0.0244 ns | 0.0228 ns | 12.557 ns |  0.67 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net461 | 18.368 ns | 0.0391 ns | 0.0366 ns | 18.355 ns |  0.98 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net472 | 16.929 ns | 0.0413 ns | 0.0386 ns | 16.931 ns |  0.90 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 15.758 ns | 0.0232 ns | 0.0217 ns | 15.767 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.387 ns | 0.0885 ns | 0.0828 ns | 15.421 ns |  0.98 |    0.01 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.392 ns | 0.0356 ns | 0.0298 ns | 15.389 ns |  0.98 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net461 | 20.807 ns | 0.0299 ns | 0.0280 ns | 20.805 ns |  1.32 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net472 | 18.010 ns | 0.0380 ns | 0.0355 ns | 18.013 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.0 | 13.299 ns | 0.0118 ns | 0.0111 ns | 13.297 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.2 | 11.964 ns | 0.0090 ns | 0.0084 ns | 11.966 ns |  0.90 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 3.0 |  8.158 ns | 0.2353 ns | 0.3449 ns |  7.972 ns |  0.63 |    0.03 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net461 | 10.470 ns | 0.0361 ns | 0.0320 ns | 10.460 ns |  0.79 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net472 | 10.519 ns | 0.0534 ns | 0.0500 ns | 10.541 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.134 ns | 0.0135 ns | 0.0119 ns | 13.134 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.638 ns | 0.0166 ns | 0.0147 ns | 12.634 ns |  0.96 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.012 ns | 0.1092 ns | 0.1022 ns | 13.053 ns |  0.99 |    0.01 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net461 | 15.438 ns | 0.0242 ns | 0.0215 ns | 15.436 ns |  1.18 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net472 | 13.168 ns | 0.0195 ns | 0.0182 ns | 13.170 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_NonConvertibleStruct | .NET Core 2.0 | 13.032 ns | 0.0194 ns | 0.0181 ns | 13.025 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 2.2 | 10.783 ns | 0.0559 ns | 0.0523 ns | 10.799 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 3.0 |  6.938 ns | 0.0140 ns | 0.0131 ns |  6.942 ns |  0.53 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net461 | 10.317 ns | 0.0148 ns | 0.0139 ns | 10.318 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net472 | 11.515 ns | 0.0092 ns | 0.0082 ns | 11.515 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.0 | 14.343 ns | 0.0391 ns | 0.0366 ns | 14.351 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.2 | 15.216 ns | 0.0143 ns | 0.0126 ns | 15.212 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 3.0 | 12.959 ns | 0.0179 ns | 0.0168 ns | 12.956 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net461 | 16.415 ns | 0.0226 ns | 0.0200 ns | 16.417 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net472 | 15.163 ns | 0.0594 ns | 0.0555 ns | 15.182 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.0 | 13.027 ns | 0.0174 ns | 0.0163 ns | 13.031 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.2 | 10.704 ns | 0.0110 ns | 0.0103 ns | 10.706 ns |  0.82 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 3.0 |  7.225 ns | 0.1612 ns | 0.1725 ns |  7.310 ns |  0.55 |    0.01 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net461 | 10.309 ns | 0.0198 ns | 0.0175 ns | 10.310 ns |  0.79 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net472 | 11.482 ns | 0.0140 ns | 0.0117 ns | 11.482 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 15.703 ns | 0.0140 ns | 0.0124 ns | 15.698 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 14.145 ns | 0.0861 ns | 0.0805 ns | 14.179 ns |  0.90 |    0.01 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.219 ns | 0.0581 ns | 0.0543 ns | 15.230 ns |  0.97 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net461 | 14.885 ns | 0.0284 ns | 0.0265 ns | 14.879 ns |  0.95 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net472 | 15.123 ns | 0.0615 ns | 0.0575 ns | 15.137 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.0 | 13.058 ns | 0.0709 ns | 0.0663 ns | 13.087 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.2 | 10.708 ns | 0.0175 ns | 0.0163 ns | 10.704 ns |  0.82 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 3.0 |  6.729 ns | 0.0112 ns | 0.0104 ns |  6.728 ns |  0.52 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net461 | 10.300 ns | 0.0128 ns | 0.0113 ns | 10.301 ns |  0.79 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net472 | 11.494 ns | 0.0199 ns | 0.0176 ns | 11.497 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.010 ns | 0.0134 ns | 0.0125 ns | 14.011 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.462 ns | 0.0155 ns | 0.0145 ns | 13.458 ns |  0.96 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.055 ns | 0.0147 ns | 0.0138 ns | 12.057 ns |  0.86 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net461 | 13.050 ns | 0.0153 ns | 0.0136 ns | 13.046 ns |  0.93 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net472 | 13.193 ns | 0.0235 ns | 0.0220 ns | 13.198 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Enum | .NET Core 2.0 | 11.979 ns | 0.0105 ns | 0.0093 ns | 11.979 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 2.2 | 10.654 ns | 0.0673 ns | 0.0629 ns | 10.684 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 3.0 |  7.837 ns | 0.0164 ns | 0.0145 ns |  7.840 ns |  0.65 |    0.00 |      - |     - |     - |         - |
                                             From_Enum |        net461 | 10.784 ns | 0.0184 ns | 0.0153 ns | 10.787 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                             From_Enum |        net472 | 10.890 ns | 0.0559 ns | 0.0523 ns | 10.911 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Enum_AsObject | .NET Core 2.0 | 44.957 ns | 0.0507 ns | 0.0423 ns | 44.952 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject | .NET Core 2.2 | 41.374 ns | 0.0411 ns | 0.0343 ns | 41.378 ns |  0.92 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject | .NET Core 3.0 | 36.245 ns | 0.1766 ns | 0.1566 ns | 36.300 ns |  0.81 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject |        net461 | 45.091 ns | 0.0744 ns | 0.0659 ns | 45.081 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject |        net472 | 42.553 ns | 0.0713 ns | 0.0596 ns | 42.560 ns |  0.95 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Enum_Nullable_WithValue | .NET Core 2.0 | 13.117 ns | 0.0174 ns | 0.0154 ns | 13.121 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 2.2 | 12.143 ns | 0.0680 ns | 0.0637 ns | 12.107 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 3.0 |  7.879 ns | 0.0131 ns | 0.0110 ns |  7.881 ns |  0.60 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net461 | 12.026 ns | 0.0199 ns | 0.0186 ns | 12.024 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net472 | 12.024 ns | 0.0177 ns | 0.0157 ns | 12.019 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.0 | 43.506 ns | 0.0671 ns | 0.0561 ns | 43.496 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.2 | 42.911 ns | 0.0755 ns | 0.0707 ns | 42.907 ns |  0.99 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 3.0 | 36.546 ns | 0.1569 ns | 0.1467 ns | 36.558 ns |  0.84 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject |        net461 | 45.223 ns | 0.1259 ns | 0.1116 ns | 45.209 ns |  1.04 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject |        net472 | 44.794 ns | 0.1910 ns | 0.1693 ns | 44.836 ns |  1.03 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Enum_Nullable_NoValue | .NET Core 2.0 | 13.074 ns | 0.0153 ns | 0.0143 ns | 13.076 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 2.2 | 10.745 ns | 0.0115 ns | 0.0107 ns | 10.742 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 3.0 |  6.548 ns | 0.0140 ns | 0.0131 ns |  6.549 ns |  0.50 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net461 | 10.392 ns | 0.0063 ns | 0.0056 ns | 10.393 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net472 | 10.351 ns | 0.0145 ns | 0.0136 ns | 10.346 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.970 ns | 0.0191 ns | 0.0169 ns | 13.965 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.641 ns | 0.0170 ns | 0.0159 ns | 12.640 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.264 ns | 0.0879 ns | 0.0822 ns | 11.300 ns |  0.81 |    0.01 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net461 | 13.134 ns | 0.0156 ns | 0.0146 ns | 13.137 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net472 | 13.264 ns | 0.0215 ns | 0.0201 ns | 13.270 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                      From_ParentClass | .NET Core 2.0 | 12.736 ns | 0.0234 ns | 0.0183 ns | 12.735 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 2.2 | 10.411 ns | 0.0117 ns | 0.0104 ns | 10.413 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 3.0 | 10.937 ns | 0.1562 ns | 0.1461 ns | 11.013 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                                      From_ParentClass |        net461 | 12.418 ns | 0.0082 ns | 0.0077 ns | 12.419 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass |        net472 | 12.659 ns | 0.0198 ns | 0.0185 ns | 12.660 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_ParentClass_AsObject | .NET Core 2.0 | 14.522 ns | 0.0118 ns | 0.0110 ns | 14.522 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 2.2 | 14.373 ns | 0.0114 ns | 0.0107 ns | 14.370 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 3.0 | 13.079 ns | 0.0153 ns | 0.0135 ns | 13.079 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net461 | 15.238 ns | 0.0294 ns | 0.0275 ns | 15.235 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net472 | 15.281 ns | 0.0498 ns | 0.0442 ns | 15.266 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                              From_ParentClass_NoValue | .NET Core 2.0 | 12.796 ns | 0.0147 ns | 0.0138 ns | 12.795 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 2.2 | 10.323 ns | 0.0106 ns | 0.0099 ns | 10.323 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 3.0 | 10.851 ns | 0.0173 ns | 0.0161 ns | 10.845 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net461 | 12.350 ns | 0.0198 ns | 0.0185 ns | 12.352 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net472 | 12.344 ns | 0.0138 ns | 0.0129 ns | 12.345 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.0 | 13.235 ns | 0.0118 ns | 0.0099 ns | 13.233 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.2 | 12.760 ns | 0.0660 ns | 0.0617 ns | 12.784 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 3.0 | 11.293 ns | 0.0100 ns | 0.0094 ns | 11.292 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net461 | 13.067 ns | 0.0281 ns | 0.0249 ns | 13.060 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net472 | 13.252 ns | 0.0807 ns | 0.0755 ns | 13.201 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_ParentStruct | .NET Core 2.0 | 38.729 ns | 0.0418 ns | 0.0371 ns | 38.724 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 2.2 | 39.289 ns | 0.0443 ns | 0.0393 ns | 39.289 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 3.0 | 35.735 ns | 0.3468 ns | 0.3244 ns | 35.841 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                                     From_ParentStruct |        net461 | 41.146 ns | 0.0590 ns | 0.0552 ns | 41.147 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct |        net472 | 40.364 ns | 0.0567 ns | 0.0530 ns | 40.365 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_ParentStruct_AsObject | .NET Core 2.0 | 14.526 ns | 0.0133 ns | 0.0111 ns | 14.527 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 2.2 | 15.166 ns | 0.0252 ns | 0.0236 ns | 15.161 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 3.0 | 15.226 ns | 0.2375 ns | 0.2222 ns | 15.236 ns |  1.05 |    0.02 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net461 | 16.708 ns | 0.0284 ns | 0.0265 ns | 16.707 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net472 | 15.273 ns | 0.0245 ns | 0.0217 ns | 15.272 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.0 | 39.162 ns | 0.0778 ns | 0.0650 ns | 39.171 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.2 | 38.890 ns | 0.2401 ns | 0.2246 ns | 38.955 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 3.0 | 33.941 ns | 0.0571 ns | 0.0477 ns | 33.934 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue |        net461 | 38.562 ns | 0.0386 ns | 0.0322 ns | 38.558 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue |        net472 | 48.060 ns | 0.1070 ns | 0.0948 ns | 48.068 ns |  1.23 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 14.519 ns | 0.0139 ns | 0.0130 ns | 14.522 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 14.482 ns | 0.0685 ns | 0.0572 ns | 14.491 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 13.446 ns | 0.1386 ns | 0.1297 ns | 13.470 ns |  0.93 |    0.01 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net461 | 15.251 ns | 0.0286 ns | 0.0268 ns | 15.256 ns |  1.05 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net472 | 15.382 ns | 0.0360 ns | 0.0337 ns | 15.376 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.0 | 38.929 ns | 0.0448 ns | 0.0397 ns | 38.936 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.2 | 37.101 ns | 0.0286 ns | 0.0268 ns | 37.098 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 3.0 | 33.863 ns | 0.0544 ns | 0.0425 ns | 33.852 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net461 | 38.339 ns | 0.0444 ns | 0.0394 ns | 38.337 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net472 | 38.401 ns | 0.1114 ns | 0.1042 ns | 38.395 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.245 ns | 0.0315 ns | 0.0263 ns | 13.251 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.633 ns | 0.0188 ns | 0.0176 ns | 12.629 ns |  0.95 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.864 ns | 0.0176 ns | 0.0164 ns | 12.870 ns |  0.97 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net461 | 13.149 ns | 0.0263 ns | 0.0246 ns | 13.149 ns |  0.99 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net472 | 13.703 ns | 0.0136 ns | 0.0128 ns | 13.699 ns |  1.03 |    0.00 |      - |     - |     - |         - |

Benchmarks with issues:
  ConvertTo_Char.From_Bool_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_Char.From_Bool_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_Char.From_Bool_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_Char.From_Bool_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_Char.From_Bool_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_Char.From_Bool_Nullable_WithValue_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_Char.From_Bool_Nullable_WithValue_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_Char.From_Bool_Nullable_WithValue_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_Char.From_Bool_Nullable_WithValue_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_Char.From_Bool_Nullable_WithValue_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_Char.From_DateTime_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_Char.From_DateTime_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_Char.From_DateTime_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_Char.From_DateTime_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_Char.From_DateTime_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_Char.From_DateTime_Nullable_WithValue_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_Char.From_DateTime_Nullable_WithValue_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_Char.From_DateTime_Nullable_WithValue_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_Char.From_DateTime_Nullable_WithValue_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_Char.From_DateTime_Nullable_WithValue_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_Char.From_Decimal_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_Char.From_Decimal_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_Char.From_Decimal_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_Char.From_Decimal_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_Char.From_Decimal_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_Char.From_Decimal_Nullable_WithValue_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_Char.From_Decimal_Nullable_WithValue_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_Char.From_Decimal_Nullable_WithValue_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_Char.From_Decimal_Nullable_WithValue_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_Char.From_Decimal_Nullable_WithValue_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_Char.From_Double_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_Char.From_Double_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_Char.From_Double_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_Char.From_Double_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_Char.From_Double_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_Char.From_Double_Nullable_WithValue_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_Char.From_Double_Nullable_WithValue_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_Char.From_Double_Nullable_WithValue_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_Char.From_Double_Nullable_WithValue_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_Char.From_Double_Nullable_WithValue_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_Char.From_Float_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_Char.From_Float_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_Char.From_Float_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_Char.From_Float_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_Char.From_Float_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_Char.From_Float_Nullable_WithValue_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_Char.From_Float_Nullable_WithValue_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_Char.From_Float_Nullable_WithValue_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_Char.From_Float_Nullable_WithValue_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_Char.From_Float_Nullable_WithValue_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_Char.From_String_Empty_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_Char.From_String_Empty_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_Char.From_String_Empty_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_Char.From_String_Empty_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_Char.From_String_Empty_AsObject: Job-PJAXXB(Toolchain=net472)
