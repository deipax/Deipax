
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
                                             From_Bool | .NET Core 2.0 | 13.321 ns | 0.0172 ns | 0.0153 ns | 13.318 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 2.2 | 12.207 ns | 0.0372 ns | 0.0348 ns | 12.193 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 3.0 |  7.571 ns | 0.0352 ns | 0.0294 ns |  7.561 ns |  0.57 |    0.00 |      - |     - |     - |         - |
                                             From_Bool |        net461 | 10.562 ns | 0.0254 ns | 0.0225 ns | 10.555 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                                             From_Bool |        net472 | 11.864 ns | 0.0254 ns | 0.0238 ns | 11.867 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Bool_AsObject | .NET Core 2.0 | 18.398 ns | 0.0364 ns | 0.0340 ns | 18.389 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 2.2 | 17.086 ns | 0.0673 ns | 0.0596 ns | 17.086 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 3.0 | 16.561 ns | 0.2567 ns | 0.2401 ns | 16.657 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net461 | 19.907 ns | 0.0297 ns | 0.0278 ns | 19.906 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net472 | 18.331 ns | 0.1330 ns | 0.1244 ns | 18.258 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Bool_Nullable_WithValue | .NET Core 2.0 | 15.698 ns | 0.0314 ns | 0.0293 ns | 15.694 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 2.2 | 10.819 ns | 0.0278 ns | 0.0260 ns | 10.823 ns |  0.69 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 3.0 |  7.473 ns | 0.1329 ns | 0.1243 ns |  7.409 ns |  0.48 |    0.01 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net461 | 12.771 ns | 0.0178 ns | 0.0167 ns | 12.770 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net472 | 12.784 ns | 0.0302 ns | 0.0267 ns | 12.777 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.587 ns | 0.0237 ns | 0.0222 ns | 18.587 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.2 | 16.801 ns | 0.0357 ns | 0.0298 ns | 16.805 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 3.0 | 16.453 ns | 0.0320 ns | 0.0299 ns | 16.455 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net461 | 18.713 ns | 0.1815 ns | 0.1698 ns | 18.778 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net472 | 18.210 ns | 0.0488 ns | 0.0433 ns | 18.205 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Bool_Nullable_NoValue | .NET Core 2.0 | 11.803 ns | 0.0251 ns | 0.0235 ns | 11.806 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 2.2 | 10.667 ns | 0.0704 ns | 0.0659 ns | 10.689 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 3.0 |  7.223 ns | 0.0117 ns | 0.0110 ns |  7.224 ns |  0.61 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net461 | 10.486 ns | 0.0180 ns | 0.0168 ns | 10.486 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net472 | 12.422 ns | 0.1424 ns | 0.1332 ns | 12.453 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.181 ns | 0.0249 ns | 0.0221 ns | 15.182 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.616 ns | 0.0132 ns | 0.0123 ns | 13.612 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.849 ns | 0.3994 ns | 0.4755 ns | 11.591 ns |  0.79 |    0.04 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net461 | 15.132 ns | 0.0282 ns | 0.0264 ns | 15.128 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net472 | 13.656 ns | 0.0220 ns | 0.0206 ns | 13.657 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Byte | .NET Core 2.0 | 12.021 ns | 0.0184 ns | 0.0144 ns | 12.021 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 2.2 | 10.426 ns | 0.0482 ns | 0.0402 ns | 10.407 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 3.0 |  6.743 ns | 0.0171 ns | 0.0152 ns |  6.743 ns |  0.56 |    0.00 |      - |     - |     - |         - |
                                             From_Byte |        net461 | 11.405 ns | 0.1484 ns | 0.1388 ns | 11.447 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                                             From_Byte |        net472 | 11.829 ns | 0.0219 ns | 0.0205 ns | 11.825 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Byte_AsObject | .NET Core 2.0 | 18.606 ns | 0.0313 ns | 0.0278 ns | 18.597 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 2.2 | 16.595 ns | 0.1730 ns | 0.1444 ns | 16.606 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 3.0 | 15.444 ns | 0.0487 ns | 0.0407 ns | 15.450 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net461 | 18.327 ns | 0.0404 ns | 0.0358 ns | 18.326 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net472 | 18.729 ns | 0.0597 ns | 0.0498 ns | 18.744 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Byte_Nullable_WithValue | .NET Core 2.0 | 13.483 ns | 0.0239 ns | 0.0212 ns | 13.482 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 2.2 | 10.696 ns | 0.0224 ns | 0.0209 ns | 10.693 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 3.0 |  7.155 ns | 0.0089 ns | 0.0079 ns |  7.153 ns |  0.53 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net461 | 12.432 ns | 0.0264 ns | 0.0220 ns | 12.437 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net472 | 12.424 ns | 0.0220 ns | 0.0206 ns | 12.428 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.573 ns | 0.1209 ns | 0.1131 ns | 19.537 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.2 | 16.620 ns | 0.0645 ns | 0.0538 ns | 16.605 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 3.0 | 16.627 ns | 0.2177 ns | 0.2037 ns | 16.637 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net461 | 18.587 ns | 0.0215 ns | 0.0190 ns | 18.584 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net472 | 18.249 ns | 0.0560 ns | 0.0524 ns | 18.231 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Byte_Nullable_NoValue | .NET Core 2.0 | 11.789 ns | 0.0192 ns | 0.0180 ns | 11.788 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 2.2 | 10.568 ns | 0.0131 ns | 0.0110 ns | 10.567 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 3.0 |  6.953 ns | 0.1628 ns | 0.2335 ns |  6.816 ns |  0.60 |    0.02 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net461 | 10.648 ns | 0.1287 ns | 0.1141 ns | 10.585 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net472 | 12.452 ns | 0.0674 ns | 0.0598 ns | 12.464 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.450 ns | 0.0286 ns | 0.0239 ns | 14.453 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.909 ns | 0.0130 ns | 0.0122 ns | 12.910 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.892 ns | 0.0372 ns | 0.0330 ns | 14.886 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net461 | 15.442 ns | 0.0350 ns | 0.0328 ns | 15.449 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net472 | 13.605 ns | 0.0170 ns | 0.0133 ns | 13.608 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Char | .NET Core 2.0 | 11.847 ns | 0.0198 ns | 0.0185 ns | 11.846 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Char | .NET Core 2.2 | 10.431 ns | 0.0187 ns | 0.0166 ns | 10.429 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                             From_Char | .NET Core 3.0 |  8.212 ns | 0.1720 ns | 0.1525 ns |  8.210 ns |  0.69 |    0.01 |      - |     - |     - |         - |
                                             From_Char |        net461 | 10.358 ns | 0.0185 ns | 0.0154 ns | 10.357 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                             From_Char |        net472 | 12.327 ns | 0.2175 ns | 0.2035 ns | 12.336 ns |  1.04 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Char_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Char_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Char_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Char_Nullable_WithValue | .NET Core 2.0 | 12.846 ns | 0.0181 ns | 0.0170 ns | 12.847 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 2.2 | 10.420 ns | 0.0107 ns | 0.0089 ns | 10.419 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 3.0 |  7.890 ns | 0.1811 ns | 0.2710 ns |  8.031 ns |  0.60 |    0.02 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net461 | 10.661 ns | 0.0167 ns | 0.0156 ns | 10.659 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net472 | 11.631 ns | 0.0201 ns | 0.0188 ns | 11.629 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Char_Nullable_NoValue | .NET Core 2.0 | 12.405 ns | 0.0497 ns | 0.0415 ns | 12.407 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 2.2 | 10.427 ns | 0.0098 ns | 0.0087 ns | 10.428 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 3.0 |  7.580 ns | 0.1350 ns | 0.1263 ns |  7.570 ns |  0.61 |    0.01 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net461 | 10.349 ns | 0.0128 ns | 0.0113 ns | 10.349 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net472 | 11.672 ns | 0.0284 ns | 0.0265 ns | 11.663 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.188 ns | 0.0149 ns | 0.0140 ns | 14.190 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.889 ns | 0.0184 ns | 0.0172 ns | 12.885 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.195 ns | 0.2689 ns | 0.2878 ns | 12.317 ns |  0.86 |    0.02 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net461 | 15.226 ns | 0.0545 ns | 0.0483 ns | 15.238 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net472 | 13.624 ns | 0.0182 ns | 0.0161 ns | 13.624 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                         From_DateTime | .NET Core 2.0 | 12.313 ns | 0.0191 ns | 0.0169 ns | 12.313 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 2.2 | 11.184 ns | 0.0194 ns | 0.0172 ns | 11.186 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 3.0 |  8.146 ns | 0.0852 ns | 0.0797 ns |  8.101 ns |  0.66 |    0.01 |      - |     - |     - |         - |
                                         From_DateTime |        net461 | 13.671 ns | 0.0815 ns | 0.0723 ns | 13.694 ns |  1.11 |    0.01 |      - |     - |     - |         - |
                                         From_DateTime |        net472 | 13.887 ns | 0.1510 ns | 0.1412 ns | 13.820 ns |  1.13 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                From_DateTime_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                      From_DateTime_Nullable_WithValue | .NET Core 2.0 | 12.787 ns | 0.0354 ns | 0.0331 ns | 12.786 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 2.2 | 11.673 ns | 0.0216 ns | 0.0168 ns | 11.677 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 3.0 |  8.132 ns | 0.0189 ns | 0.0177 ns |  8.130 ns |  0.64 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net461 | 12.854 ns | 0.0295 ns | 0.0276 ns | 12.852 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net472 | 13.528 ns | 0.0634 ns | 0.0529 ns | 13.527 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_DateTime_Nullable_NoValue | .NET Core 2.0 | 13.216 ns | 0.0520 ns | 0.0461 ns | 13.193 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 2.2 | 11.842 ns | 0.0263 ns | 0.0246 ns | 11.843 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 3.0 |  7.949 ns | 0.0275 ns | 0.0244 ns |  7.942 ns |  0.60 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net461 | 12.910 ns | 0.1242 ns | 0.1162 ns | 12.873 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net472 | 14.124 ns | 0.0117 ns | 0.0104 ns | 14.124 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.223 ns | 0.0192 ns | 0.0179 ns | 14.221 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.833 ns | 0.0121 ns | 0.0107 ns | 12.830 ns |  0.90 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.241 ns | 0.0179 ns | 0.0149 ns | 13.241 ns |  0.93 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net461 | 13.409 ns | 0.0236 ns | 0.0221 ns | 13.405 ns |  0.94 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net472 | 13.611 ns | 0.0211 ns | 0.0187 ns | 13.614 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                          From_Decimal | .NET Core 2.0 | 19.656 ns | 0.0436 ns | 0.0408 ns | 19.661 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 2.2 | 16.733 ns | 0.0518 ns | 0.0485 ns | 16.737 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 3.0 | 11.150 ns | 0.0511 ns | 0.0478 ns | 11.129 ns |  0.57 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal |        net461 | 19.185 ns | 0.1117 ns | 0.0933 ns | 19.166 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                                          From_Decimal |        net472 | 23.004 ns | 0.0307 ns | 0.0287 ns | 23.006 ns |  1.17 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                 From_Decimal_AsObject | .NET Core 2.0 | 22.915 ns | 0.1142 ns | 0.1068 ns | 22.865 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 2.2 | 20.195 ns | 0.0475 ns | 0.0445 ns | 20.203 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 3.0 | 20.488 ns | 0.3943 ns | 0.3688 ns | 20.779 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net461 | 22.044 ns | 0.0481 ns | 0.0450 ns | 22.027 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net472 | 23.781 ns | 0.0384 ns | 0.0359 ns | 23.781 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                       From_Decimal_Nullable_WithValue | .NET Core 2.0 | 23.479 ns | 0.0324 ns | 0.0303 ns | 23.475 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 2.2 | 20.072 ns | 0.0501 ns | 0.0469 ns | 20.097 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 3.0 | 20.178 ns | 0.0243 ns | 0.0215 ns | 20.181 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net461 | 22.937 ns | 0.0651 ns | 0.0544 ns | 22.952 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net472 | 22.262 ns | 0.2746 ns | 0.2569 ns | 22.145 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.0 | 22.191 ns | 0.0337 ns | 0.0299 ns | 22.187 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.2 | 21.704 ns | 0.0670 ns | 0.0594 ns | 21.716 ns |  0.98 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 3.0 | 20.227 ns | 0.1052 ns | 0.0933 ns | 20.233 ns |  0.91 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net461 | 23.725 ns | 0.0388 ns | 0.0324 ns | 23.725 ns |  1.07 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net472 | 21.953 ns | 0.0266 ns | 0.0222 ns | 21.953 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Decimal_Nullable_NoValue | .NET Core 2.0 | 12.724 ns | 0.0199 ns | 0.0177 ns | 12.725 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 2.2 | 11.466 ns | 0.0523 ns | 0.0464 ns | 11.447 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 3.0 |  8.043 ns | 0.0200 ns | 0.0157 ns |  8.043 ns |  0.63 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net461 | 16.239 ns | 0.0401 ns | 0.0375 ns | 16.235 ns |  1.28 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net472 | 15.553 ns | 0.1307 ns | 0.1222 ns | 15.482 ns |  1.22 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.205 ns | 0.0195 ns | 0.0163 ns | 14.205 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.792 ns | 0.0894 ns | 0.0836 ns | 13.753 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 3.0 | 15.318 ns | 0.3314 ns | 0.6143 ns | 15.625 ns |  1.03 |    0.05 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net461 | 15.091 ns | 0.0514 ns | 0.0456 ns | 15.090 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net472 | 15.921 ns | 0.0115 ns | 0.0102 ns | 15.922 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_Double | .NET Core 2.0 | 11.864 ns | 0.0261 ns | 0.0218 ns | 11.857 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 2.2 | 10.995 ns | 0.0139 ns | 0.0116 ns | 10.994 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 3.0 |  7.260 ns | 0.0674 ns | 0.0630 ns |  7.241 ns |  0.61 |    0.01 |      - |     - |     - |         - |
                                           From_Double |        net461 | 11.751 ns | 0.0228 ns | 0.0191 ns | 11.750 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                           From_Double |        net472 | 10.473 ns | 0.0143 ns | 0.0127 ns | 10.473 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_Double_AsObject | .NET Core 2.0 | 15.024 ns | 0.0582 ns | 0.0486 ns | 15.025 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 2.2 | 15.525 ns | 0.0173 ns | 0.0161 ns | 15.525 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 3.0 | 12.065 ns | 0.0235 ns | 0.0208 ns | 12.059 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject |        net461 | 15.392 ns | 0.0320 ns | 0.0299 ns | 15.398 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject |        net472 | 14.339 ns | 0.0679 ns | 0.0567 ns | 14.329 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_Double_Nullable_WithValue | .NET Core 2.0 | 12.968 ns | 0.0388 ns | 0.0344 ns | 12.974 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 2.2 | 11.911 ns | 0.1017 ns | 0.0951 ns | 11.895 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 3.0 |  8.790 ns | 0.0262 ns | 0.0245 ns |  8.788 ns |  0.68 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net461 | 13.261 ns | 0.0173 ns | 0.0162 ns | 13.263 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net472 | 13.367 ns | 0.0187 ns | 0.0175 ns | 13.364 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.0 | 16.167 ns | 0.0390 ns | 0.0365 ns | 16.164 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.2 | 13.425 ns | 0.0734 ns | 0.0687 ns | 13.388 ns |  0.83 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 3.0 | 13.532 ns | 0.1136 ns | 0.1063 ns | 13.459 ns |  0.84 |    0.01 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net461 | 15.865 ns | 0.0806 ns | 0.0673 ns | 15.852 ns |  0.98 |    0.01 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net472 | 14.352 ns | 0.1191 ns | 0.1114 ns | 14.290 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Double_Nullable_NoValue | .NET Core 2.0 | 13.154 ns | 0.0260 ns | 0.0243 ns | 13.158 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 2.2 | 11.804 ns | 0.0131 ns | 0.0116 ns | 11.806 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 3.0 |  8.679 ns | 0.0156 ns | 0.0146 ns |  8.676 ns |  0.66 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net461 | 13.573 ns | 0.0372 ns | 0.0330 ns | 13.568 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net472 | 13.696 ns | 0.0332 ns | 0.0311 ns | 13.688 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.418 ns | 0.1142 ns | 0.1068 ns | 14.443 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.865 ns | 0.0248 ns | 0.0194 ns | 12.873 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.379 ns | 0.1226 ns | 0.1147 ns | 12.454 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net461 | 15.314 ns | 0.0548 ns | 0.0486 ns | 15.295 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net472 | 13.618 ns | 0.0233 ns | 0.0218 ns | 13.617 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_Short | .NET Core 2.0 | 11.838 ns | 0.0154 ns | 0.0144 ns | 11.834 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 2.2 | 10.439 ns | 0.0503 ns | 0.0470 ns | 10.421 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 3.0 |  7.592 ns | 0.1081 ns | 0.1011 ns |  7.540 ns |  0.64 |    0.01 |      - |     - |     - |         - |
                                            From_Short |        net461 | 10.356 ns | 0.0142 ns | 0.0133 ns | 10.360 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                            From_Short |        net472 | 12.530 ns | 0.1349 ns | 0.1262 ns | 12.518 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_Short_AsObject | .NET Core 2.0 | 19.572 ns | 0.0602 ns | 0.0534 ns | 19.558 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 2.2 | 16.269 ns | 0.0245 ns | 0.0217 ns | 16.270 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 3.0 | 15.479 ns | 0.0252 ns | 0.0236 ns | 15.483 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net461 | 20.058 ns | 0.0308 ns | 0.0288 ns | 20.067 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net472 | 18.833 ns | 0.0439 ns | 0.0410 ns | 18.824 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Short_Nullable_WithValue | .NET Core 2.0 | 12.223 ns | 0.0746 ns | 0.0623 ns | 12.224 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 2.2 | 10.689 ns | 0.0859 ns | 0.0804 ns | 10.649 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 3.0 |  7.013 ns | 0.0128 ns | 0.0107 ns |  7.013 ns |  0.57 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net461 | 10.778 ns | 0.1272 ns | 0.1190 ns | 10.707 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net472 | 12.563 ns | 0.1110 ns | 0.1039 ns | 12.559 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.299 ns | 0.0568 ns | 0.0532 ns | 19.301 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.2 | 16.267 ns | 0.0221 ns | 0.0196 ns | 16.267 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 3.0 | 16.108 ns | 0.1470 ns | 0.1375 ns | 16.075 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net461 | 20.055 ns | 0.0257 ns | 0.0241 ns | 20.056 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net472 | 18.842 ns | 0.0409 ns | 0.0383 ns | 18.830 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Short_Nullable_NoValue | .NET Core 2.0 | 12.427 ns | 0.0322 ns | 0.0286 ns | 12.428 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 2.2 | 10.532 ns | 0.0458 ns | 0.0406 ns | 10.518 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 3.0 |  6.904 ns | 0.1349 ns | 0.1262 ns |  6.972 ns |  0.56 |    0.01 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net461 | 10.465 ns | 0.0167 ns | 0.0130 ns | 10.468 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net472 | 11.924 ns | 0.0173 ns | 0.0162 ns | 11.924 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.405 ns | 0.1013 ns | 0.0948 ns | 15.432 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.768 ns | 0.0909 ns | 0.0850 ns | 13.736 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.742 ns | 0.0250 ns | 0.0221 ns | 11.744 ns |  0.76 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net461 | 13.630 ns | 0.0858 ns | 0.0803 ns | 13.605 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net472 | 13.605 ns | 0.0162 ns | 0.0152 ns | 13.604 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                              From_Int | .NET Core 2.0 | 11.825 ns | 0.0244 ns | 0.0216 ns | 11.826 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 2.2 | 10.392 ns | 0.0093 ns | 0.0083 ns | 10.390 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 3.0 |  7.712 ns | 0.1747 ns | 0.2012 ns |  7.614 ns |  0.66 |    0.02 |      - |     - |     - |         - |
                                              From_Int |        net461 | 10.370 ns | 0.0125 ns | 0.0111 ns | 10.370 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                              From_Int |        net472 | 11.921 ns | 0.0859 ns | 0.0804 ns | 11.886 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_Int_AsObject | .NET Core 2.0 | 18.834 ns | 0.0340 ns | 0.0301 ns | 18.830 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 2.2 | 16.063 ns | 0.0256 ns | 0.0227 ns | 16.063 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 3.0 | 15.888 ns | 0.0269 ns | 0.0225 ns | 15.884 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net461 | 18.825 ns | 0.0523 ns | 0.0489 ns | 18.810 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net472 | 18.710 ns | 0.1023 ns | 0.0799 ns | 18.732 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Int_Nullable_WithValue | .NET Core 2.0 | 12.058 ns | 0.0127 ns | 0.0112 ns | 12.056 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 2.2 | 10.663 ns | 0.0650 ns | 0.0608 ns | 10.627 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 3.0 |  7.216 ns | 0.0216 ns | 0.0181 ns |  7.215 ns |  0.60 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net461 | 11.723 ns | 0.0852 ns | 0.0797 ns | 11.721 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net472 | 12.296 ns | 0.0203 ns | 0.0190 ns | 12.293 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.627 ns | 0.0501 ns | 0.0444 ns | 19.622 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.2 | 16.831 ns | 0.0565 ns | 0.0528 ns | 16.847 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.909 ns | 0.0347 ns | 0.0325 ns | 15.904 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net461 | 18.232 ns | 0.0441 ns | 0.0391 ns | 18.230 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net472 | 18.594 ns | 0.0404 ns | 0.0358 ns | 18.589 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_Int_Nullable_NoValue | .NET Core 2.0 | 11.871 ns | 0.1259 ns | 0.1178 ns | 11.810 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 2.2 | 10.629 ns | 0.1068 ns | 0.0999 ns | 10.684 ns |  0.90 |    0.02 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 3.0 |  6.846 ns | 0.0221 ns | 0.0207 ns |  6.849 ns |  0.58 |    0.01 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net461 | 10.670 ns | 0.0819 ns | 0.0766 ns | 10.665 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net472 | 12.505 ns | 0.0531 ns | 0.0443 ns | 12.516 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.186 ns | 0.0123 ns | 0.0109 ns | 14.191 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.695 ns | 0.0237 ns | 0.0210 ns | 13.684 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.028 ns | 0.2863 ns | 0.2941 ns | 11.876 ns |  0.85 |    0.02 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net461 | 13.505 ns | 0.0276 ns | 0.0258 ns | 13.506 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net472 | 13.727 ns | 0.0293 ns | 0.0274 ns | 13.720 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Long | .NET Core 2.0 | 11.812 ns | 0.0245 ns | 0.0217 ns | 11.807 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Long | .NET Core 2.2 | 10.412 ns | 0.0188 ns | 0.0176 ns | 10.413 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                             From_Long | .NET Core 3.0 |  6.583 ns | 0.0195 ns | 0.0183 ns |  6.586 ns |  0.56 |    0.00 |      - |     - |     - |         - |
                                             From_Long |        net461 | 11.830 ns | 0.0287 ns | 0.0239 ns | 11.827 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Long |        net472 | 11.920 ns | 0.1091 ns | 0.1021 ns | 11.864 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Long_AsObject | .NET Core 2.0 | 18.881 ns | 0.0334 ns | 0.0313 ns | 18.887 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 2.2 | 18.567 ns | 0.0286 ns | 0.0268 ns | 18.560 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 3.0 | 15.654 ns | 0.0208 ns | 0.0184 ns | 15.657 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net461 | 20.411 ns | 0.0902 ns | 0.0753 ns | 20.431 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net472 | 18.539 ns | 0.0409 ns | 0.0383 ns | 18.526 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Long_Nullable_WithValue | .NET Core 2.0 | 13.190 ns | 0.0326 ns | 0.0305 ns | 13.188 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 2.2 | 11.821 ns | 0.0165 ns | 0.0138 ns | 11.824 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 3.0 |  8.545 ns | 0.0447 ns | 0.0396 ns |  8.557 ns |  0.65 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net461 | 13.222 ns | 0.0208 ns | 0.0184 ns | 13.221 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net472 | 13.931 ns | 0.0185 ns | 0.0164 ns | 13.929 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.107 ns | 0.0597 ns | 0.0558 ns | 19.079 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.2 | 16.760 ns | 0.0537 ns | 0.0502 ns | 16.752 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 3.0 | 16.563 ns | 0.0383 ns | 0.0358 ns | 16.554 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net461 | 18.958 ns | 0.0603 ns | 0.0564 ns | 18.974 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net472 | 18.954 ns | 0.2524 ns | 0.2361 ns | 19.005 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Long_Nullable_NoValue | .NET Core 2.0 | 14.541 ns | 0.0718 ns | 0.0672 ns | 14.544 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 2.2 | 11.737 ns | 0.0105 ns | 0.0093 ns | 11.735 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 3.0 |  8.294 ns | 0.0173 ns | 0.0153 ns |  8.290 ns |  0.57 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net461 | 14.355 ns | 0.0322 ns | 0.0285 ns | 14.358 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net472 | 13.752 ns | 0.0146 ns | 0.0129 ns | 13.753 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.279 ns | 0.0229 ns | 0.0203 ns | 14.279 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.730 ns | 0.0262 ns | 0.0232 ns | 13.725 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.188 ns | 0.2891 ns | 0.5906 ns | 13.436 ns |  0.88 |    0.06 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net461 | 13.531 ns | 0.0266 ns | 0.0236 ns | 13.533 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net472 | 14.189 ns | 0.0169 ns | 0.0150 ns | 14.189 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_SByte | .NET Core 2.0 | 11.904 ns | 0.0211 ns | 0.0198 ns | 11.899 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 2.2 | 10.409 ns | 0.0233 ns | 0.0195 ns | 10.406 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 3.0 |  8.133 ns | 0.1877 ns | 0.2631 ns |  8.236 ns |  0.68 |    0.03 |      - |     - |     - |         - |
                                            From_SByte |        net461 | 12.048 ns | 0.0605 ns | 0.0566 ns | 12.019 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                            From_SByte |        net472 | 11.841 ns | 0.0188 ns | 0.0176 ns | 11.840 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_SByte_AsObject | .NET Core 2.0 | 18.693 ns | 0.0186 ns | 0.0165 ns | 18.696 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 2.2 | 16.853 ns | 0.0602 ns | 0.0563 ns | 16.867 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 3.0 | 15.550 ns | 0.0408 ns | 0.0382 ns | 15.544 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net461 | 18.659 ns | 0.1291 ns | 0.1207 ns | 18.591 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net472 | 18.750 ns | 0.0802 ns | 0.0670 ns | 18.763 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_SByte_Nullable_WithValue | .NET Core 2.0 | 12.085 ns | 0.0118 ns | 0.0110 ns | 12.081 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 2.2 | 10.666 ns | 0.0403 ns | 0.0358 ns | 10.660 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 3.0 |  7.258 ns | 0.0279 ns | 0.0247 ns |  7.259 ns |  0.60 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net461 | 10.688 ns | 0.0327 ns | 0.0290 ns | 10.688 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net472 | 12.423 ns | 0.0225 ns | 0.0211 ns | 12.420 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.749 ns | 0.0521 ns | 0.0435 ns | 20.735 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.2 | 16.554 ns | 0.0480 ns | 0.0449 ns | 16.570 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.372 ns | 0.3717 ns | 0.5331 ns | 17.669 ns |  0.82 |    0.03 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net461 | 18.641 ns | 0.0649 ns | 0.0575 ns | 18.615 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net472 | 18.303 ns | 0.0530 ns | 0.0495 ns | 18.305 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_SByte_Nullable_NoValue | .NET Core 2.0 | 11.852 ns | 0.0139 ns | 0.0130 ns | 11.854 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 2.2 | 10.532 ns | 0.0225 ns | 0.0199 ns | 10.529 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 3.0 |  6.737 ns | 0.0322 ns | 0.0285 ns |  6.737 ns |  0.57 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net461 | 10.473 ns | 0.0172 ns | 0.0161 ns | 10.477 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net472 | 12.475 ns | 0.1108 ns | 0.1037 ns | 12.447 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.279 ns | 0.0126 ns | 0.0112 ns | 14.277 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.128 ns | 0.0619 ns | 0.0579 ns | 14.141 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.118 ns | 0.0795 ns | 0.0744 ns | 13.102 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net461 | 13.533 ns | 0.0221 ns | 0.0207 ns | 13.529 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net472 | 13.836 ns | 0.0419 ns | 0.0392 ns | 13.829 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_Float | .NET Core 2.0 | 11.904 ns | 0.0143 ns | 0.0127 ns | 11.906 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 2.2 | 10.363 ns | 0.0095 ns | 0.0080 ns | 10.362 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 3.0 |  7.482 ns | 0.0227 ns | 0.0213 ns |  7.477 ns |  0.63 |    0.00 |      - |     - |     - |         - |
                                            From_Float |        net461 | 11.946 ns | 0.0342 ns | 0.0285 ns | 11.946 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Float |        net472 | 11.935 ns | 0.0125 ns | 0.0117 ns | 11.939 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_Float_AsObject | .NET Core 2.0 | 18.937 ns | 0.0185 ns | 0.0164 ns | 18.931 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 2.2 | 16.304 ns | 0.0640 ns | 0.0598 ns | 16.291 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 3.0 | 15.915 ns | 0.0265 ns | 0.0248 ns | 15.913 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject |        net461 | 18.264 ns | 0.0277 ns | 0.0245 ns | 18.266 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject |        net472 | 18.505 ns | 0.0450 ns | 0.0399 ns | 18.503 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Float_Nullable_WithValue | .NET Core 2.0 | 13.549 ns | 0.0897 ns | 0.0839 ns | 13.587 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 2.2 | 11.316 ns | 0.1179 ns | 0.1103 ns | 11.288 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 3.0 |  7.469 ns | 0.0519 ns | 0.0460 ns |  7.456 ns |  0.55 |    0.01 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net461 | 10.689 ns | 0.1357 ns | 0.1270 ns | 10.608 ns |  0.79 |    0.01 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net472 | 12.352 ns | 0.0910 ns | 0.0851 ns | 12.317 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.790 ns | 0.1552 ns | 0.1451 ns | 18.719 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.2 | 16.274 ns | 0.0290 ns | 0.0242 ns | 16.283 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.916 ns | 0.0319 ns | 0.0299 ns | 15.914 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net461 | 19.864 ns | 0.0378 ns | 0.0353 ns | 19.864 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net472 | 18.704 ns | 0.0186 ns | 0.0174 ns | 18.702 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Float_Nullable_NoValue | .NET Core 2.0 | 11.847 ns | 0.0160 ns | 0.0134 ns | 11.848 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 2.2 | 10.531 ns | 0.0359 ns | 0.0336 ns | 10.533 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 3.0 |  6.843 ns | 0.1557 ns | 0.1456 ns |  6.761 ns |  0.58 |    0.01 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net461 | 10.590 ns | 0.1120 ns | 0.1048 ns | 10.538 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net472 | 12.263 ns | 0.0355 ns | 0.0315 ns | 12.254 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.379 ns | 0.0558 ns | 0.0494 ns | 14.393 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.840 ns | 0.0146 ns | 0.0114 ns | 12.840 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.773 ns | 0.7828 ns | 0.9318 ns | 13.223 ns |  0.98 |    0.07 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net461 | 15.170 ns | 0.0335 ns | 0.0313 ns | 15.175 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net472 | 13.581 ns | 0.0262 ns | 0.0232 ns | 13.585 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_String | .NET Core 2.0 | 72.399 ns | 0.1339 ns | 0.1187 ns | 72.391 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 2.2 | 73.779 ns | 0.0913 ns | 0.0854 ns | 73.777 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 3.0 | 57.034 ns | 0.0965 ns | 0.0903 ns | 57.016 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                                           From_String |        net461 | 79.855 ns | 0.0949 ns | 0.0842 ns | 79.878 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                           From_String |        net472 | 73.838 ns | 0.1492 ns | 0.1396 ns | 73.886 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_String_AsObject | .NET Core 2.0 | 76.638 ns | 0.1860 ns | 0.1740 ns | 76.619 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 2.2 | 82.118 ns | 0.4966 ns | 0.4402 ns | 81.973 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 3.0 | 62.826 ns | 0.2008 ns | 0.1878 ns | 62.842 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject |        net461 | 80.503 ns | 0.1563 ns | 0.1386 ns | 80.491 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject |        net472 | 80.239 ns | 0.5157 ns | 0.4571 ns | 80.321 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                      From_String_Null | .NET Core 2.0 | 12.477 ns | 0.0168 ns | 0.0157 ns | 12.476 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 2.2 | 12.284 ns | 0.0145 ns | 0.0136 ns | 12.284 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 3.0 | 12.865 ns | 0.1796 ns | 0.1680 ns | 12.855 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                      From_String_Null |        net461 | 12.889 ns | 0.0190 ns | 0.0178 ns | 12.884 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null |        net472 | 12.949 ns | 0.0188 ns | 0.0157 ns | 12.953 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_String_Null_AsObject | .NET Core 2.0 | 15.609 ns | 0.0193 ns | 0.0181 ns | 15.609 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 2.2 | 12.945 ns | 0.1001 ns | 0.0936 ns | 13.005 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 3.0 | 15.131 ns | 0.9725 ns | 1.8504 ns | 14.080 ns |  1.10 |    0.12 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net461 | 13.678 ns | 0.0336 ns | 0.0314 ns | 13.680 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net472 | 13.653 ns | 0.0296 ns | 0.0262 ns | 13.656 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_String_Empty | .NET Core 2.0 | 12.778 ns | 0.0330 ns | 0.0293 ns | 12.771 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 2.2 | 13.314 ns | 0.0224 ns | 0.0187 ns | 13.308 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 3.0 | 11.826 ns | 0.1158 ns | 0.1083 ns | 11.786 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                                     From_String_Empty |        net461 | 13.799 ns | 0.1059 ns | 0.0991 ns | 13.747 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                                     From_String_Empty |        net472 | 13.184 ns | 0.0252 ns | 0.0236 ns | 13.183 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_String_Empty_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_UShort | .NET Core 2.0 | 13.403 ns | 0.0136 ns | 0.0127 ns | 13.400 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 2.2 | 10.417 ns | 0.0166 ns | 0.0155 ns | 10.415 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 3.0 |  7.597 ns | 0.1200 ns | 0.1123 ns |  7.540 ns |  0.57 |    0.01 |      - |     - |     - |         - |
                                           From_UShort |        net461 | 11.029 ns | 0.0152 ns | 0.0142 ns | 11.029 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                           From_UShort |        net472 | 11.828 ns | 0.0289 ns | 0.0241 ns | 11.825 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_UShort_AsObject | .NET Core 2.0 | 18.637 ns | 0.0440 ns | 0.0390 ns | 18.629 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 2.2 | 17.846 ns | 0.0231 ns | 0.0193 ns | 17.845 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 3.0 | 15.565 ns | 0.0282 ns | 0.0264 ns | 15.555 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net461 | 18.942 ns | 0.0537 ns | 0.0419 ns | 18.925 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net472 | 18.237 ns | 0.0377 ns | 0.0353 ns | 18.238 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_UShort_Nullable_WithValue | .NET Core 2.0 | 12.026 ns | 0.0175 ns | 0.0155 ns | 12.026 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 2.2 | 10.939 ns | 0.0818 ns | 0.0765 ns | 10.937 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 3.0 |  8.449 ns | 0.1939 ns | 0.2234 ns |  8.553 ns |  0.70 |    0.02 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net461 | 10.670 ns | 0.0149 ns | 0.0132 ns | 10.674 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net472 | 12.420 ns | 0.0195 ns | 0.0152 ns | 12.416 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.597 ns | 0.0413 ns | 0.0366 ns | 19.595 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.480 ns | 0.0516 ns | 0.0431 ns | 17.474 ns |  0.89 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.200 ns | 0.0370 ns | 0.0328 ns | 18.194 ns |  0.93 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net461 | 18.795 ns | 0.0266 ns | 0.0236 ns | 18.794 ns |  0.96 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net472 | 18.478 ns | 0.0527 ns | 0.0493 ns | 18.475 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_UShort_Nullable_NoValue | .NET Core 2.0 | 12.451 ns | 0.0565 ns | 0.0528 ns | 12.438 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 2.2 | 10.511 ns | 0.0093 ns | 0.0082 ns | 10.510 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 3.0 |  6.855 ns | 0.0181 ns | 0.0170 ns |  6.855 ns |  0.55 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net461 | 13.093 ns | 0.0810 ns | 0.0757 ns | 13.061 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net472 | 11.932 ns | 0.0461 ns | 0.0431 ns | 11.914 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.219 ns | 0.0205 ns | 0.0191 ns | 14.216 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.090 ns | 0.0895 ns | 0.0838 ns | 13.054 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.202 ns | 0.1497 ns | 0.1401 ns | 14.163 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net461 | 15.112 ns | 0.0359 ns | 0.0318 ns | 15.114 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net472 | 13.634 ns | 0.0151 ns | 0.0126 ns | 13.632 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_UInt | .NET Core 2.0 | 11.887 ns | 0.0277 ns | 0.0259 ns | 11.884 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 2.2 | 10.427 ns | 0.0144 ns | 0.0128 ns | 10.429 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 3.0 |  6.537 ns | 0.0166 ns | 0.0147 ns |  6.541 ns |  0.55 |    0.00 |      - |     - |     - |         - |
                                             From_UInt |        net461 | 10.385 ns | 0.0140 ns | 0.0131 ns | 10.386 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                             From_UInt |        net472 | 11.864 ns | 0.0259 ns | 0.0217 ns | 11.868 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_UInt_AsObject | .NET Core 2.0 | 19.130 ns | 0.1086 ns | 0.0963 ns | 19.095 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 2.2 | 17.873 ns | 0.0187 ns | 0.0166 ns | 17.870 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 3.0 | 15.802 ns | 0.0268 ns | 0.0237 ns | 15.808 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net461 | 18.422 ns | 0.1147 ns | 0.1017 ns | 18.402 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net472 | 18.784 ns | 0.0447 ns | 0.0418 ns | 18.790 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_UInt_Nullable_WithValue | .NET Core 2.0 | 12.919 ns | 0.0365 ns | 0.0341 ns | 12.909 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 2.2 | 10.706 ns | 0.0771 ns | 0.0721 ns | 10.674 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 3.0 |  7.839 ns | 0.1829 ns | 0.2623 ns |  7.965 ns |  0.60 |    0.03 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net461 | 12.403 ns | 0.0191 ns | 0.0169 ns | 12.405 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net472 | 12.424 ns | 0.0243 ns | 0.0227 ns | 12.428 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.594 ns | 0.0278 ns | 0.0232 ns | 18.585 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.2 | 16.024 ns | 0.0327 ns | 0.0305 ns | 16.011 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.270 ns | 0.0442 ns | 0.0392 ns | 17.278 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net461 | 20.323 ns | 0.0362 ns | 0.0302 ns | 20.329 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net472 | 18.627 ns | 0.0746 ns | 0.0698 ns | 18.608 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_UInt_Nullable_NoValue | .NET Core 2.0 | 11.799 ns | 0.0192 ns | 0.0160 ns | 11.790 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 2.2 | 10.530 ns | 0.0167 ns | 0.0157 ns | 10.523 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 3.0 |  6.840 ns | 0.0264 ns | 0.0221 ns |  6.832 ns |  0.58 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net461 | 10.473 ns | 0.0152 ns | 0.0135 ns | 10.471 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net472 | 12.264 ns | 0.0254 ns | 0.0212 ns | 12.266 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.192 ns | 0.0223 ns | 0.0174 ns | 15.191 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.039 ns | 0.0848 ns | 0.0793 ns | 13.066 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.709 ns | 0.0237 ns | 0.0198 ns | 11.715 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net461 | 15.833 ns | 0.0584 ns | 0.0546 ns | 15.828 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net472 | 13.829 ns | 0.0392 ns | 0.0367 ns | 13.818 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_ULong | .NET Core 2.0 | 11.893 ns | 0.0546 ns | 0.0510 ns | 11.879 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 2.2 | 10.571 ns | 0.0107 ns | 0.0095 ns | 10.575 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 3.0 |  6.797 ns | 0.0219 ns | 0.0205 ns |  6.793 ns |  0.57 |    0.00 |      - |     - |     - |         - |
                                            From_ULong |        net461 | 12.263 ns | 0.0689 ns | 0.0611 ns | 12.271 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                            From_ULong |        net472 | 11.917 ns | 0.0293 ns | 0.0274 ns | 11.925 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_ULong_AsObject | .NET Core 2.0 | 20.078 ns | 0.0309 ns | 0.0274 ns | 20.069 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 2.2 | 17.303 ns | 0.0692 ns | 0.0613 ns | 17.309 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 3.0 | 16.754 ns | 0.1056 ns | 0.0988 ns | 16.708 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net461 | 18.757 ns | 0.0362 ns | 0.0339 ns | 18.759 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net472 | 18.817 ns | 0.0477 ns | 0.0398 ns | 18.824 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_ULong_Nullable_WithValue | .NET Core 2.0 | 14.330 ns | 0.0223 ns | 0.0198 ns | 14.329 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 2.2 | 12.061 ns | 0.0774 ns | 0.0686 ns | 12.075 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 3.0 |  9.094 ns | 0.2089 ns | 0.2145 ns |  9.199 ns |  0.63 |    0.02 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net461 | 13.477 ns | 0.0334 ns | 0.0313 ns | 13.479 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net472 | 14.657 ns | 0.0518 ns | 0.0485 ns | 14.656 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.214 ns | 0.1218 ns | 0.1139 ns | 19.160 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.299 ns | 0.0598 ns | 0.0530 ns | 17.303 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 3.0 | 16.703 ns | 0.0422 ns | 0.0352 ns | 16.695 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net461 | 20.370 ns | 0.0404 ns | 0.0338 ns | 20.370 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net472 | 18.843 ns | 0.0428 ns | 0.0358 ns | 18.849 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_ULong_Nullable_NoValue | .NET Core 2.0 | 12.972 ns | 0.0181 ns | 0.0161 ns | 12.972 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 2.2 | 11.737 ns | 0.0156 ns | 0.0138 ns | 11.737 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 3.0 |  8.612 ns | 0.1862 ns | 0.1828 ns |  8.657 ns |  0.66 |    0.02 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net461 | 13.040 ns | 0.0162 ns | 0.0144 ns | 13.039 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net472 | 13.645 ns | 0.0435 ns | 0.0386 ns | 13.641 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.241 ns | 0.0430 ns | 0.0402 ns | 14.234 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.691 ns | 0.0211 ns | 0.0187 ns | 13.686 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.702 ns | 0.0184 ns | 0.0163 ns | 11.706 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net461 | 15.682 ns | 0.0289 ns | 0.0241 ns | 15.672 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net472 | 14.193 ns | 0.0189 ns | 0.0177 ns | 14.193 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                       From_NullObject | .NET Core 2.0 | 15.175 ns | 0.0200 ns | 0.0177 ns | 15.175 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 2.2 | 13.721 ns | 0.0211 ns | 0.0187 ns | 13.719 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 3.0 | 11.753 ns | 0.0632 ns | 0.0591 ns | 11.718 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject |        net461 | 15.197 ns | 0.0376 ns | 0.0333 ns | 15.193 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject |        net472 | 13.614 ns | 0.0245 ns | 0.0217 ns | 13.610 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_DBNull | .NET Core 2.0 | 10.749 ns | 0.0384 ns | 0.0341 ns | 10.740 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 2.2 |  9.117 ns | 0.0129 ns | 0.0100 ns |  9.115 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 3.0 | 13.611 ns | 0.2955 ns | 0.4771 ns | 13.338 ns |  1.31 |    0.03 |      - |     - |     - |         - |
                                           From_DBNull |        net461 | 13.691 ns | 0.2176 ns | 0.2035 ns | 13.731 ns |  1.28 |    0.02 |      - |     - |     - |         - |
                                           From_DBNull |        net472 | 11.006 ns | 0.0192 ns | 0.0171 ns | 11.001 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_DBNull_AsObject | .NET Core 2.0 | 15.217 ns | 0.0339 ns | 0.0301 ns | 15.217 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 2.2 | 13.723 ns | 0.0430 ns | 0.0381 ns | 13.709 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 3.0 | 11.861 ns | 0.2016 ns | 0.1886 ns | 11.725 ns |  0.78 |    0.01 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net461 | 13.717 ns | 0.1049 ns | 0.0981 ns | 13.699 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net472 | 13.639 ns | 0.0209 ns | 0.0186 ns | 13.631 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                 From_ConvertibleClass | .NET Core 2.0 | 15.357 ns | 0.0268 ns | 0.0237 ns | 15.358 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 2.2 | 13.022 ns | 0.0329 ns | 0.0291 ns | 13.015 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 3.0 | 13.784 ns | 0.2939 ns | 0.3498 ns | 13.568 ns |  0.91 |    0.02 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net461 | 17.318 ns | 0.0433 ns | 0.0384 ns | 17.315 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net472 | 18.829 ns | 0.1083 ns | 0.1013 ns | 18.785 ns |  1.23 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_ConvertibleClass_AsObject | .NET Core 2.0 | 18.172 ns | 0.0270 ns | 0.0253 ns | 18.173 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 2.2 | 15.409 ns | 0.0361 ns | 0.0337 ns | 15.404 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 3.0 | 15.520 ns | 0.0299 ns | 0.0279 ns | 15.522 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net461 | 17.102 ns | 0.0378 ns | 0.0335 ns | 17.097 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net472 | 17.599 ns | 0.0709 ns | 0.0663 ns | 17.610 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_ConvertibleClass_NoValue | .NET Core 2.0 | 13.129 ns | 0.0149 ns | 0.0139 ns | 13.132 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 2.2 | 11.934 ns | 0.0221 ns | 0.0206 ns | 11.932 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 3.0 | 11.311 ns | 0.1985 ns | 0.1856 ns | 11.280 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net461 | 15.122 ns | 0.0230 ns | 0.0215 ns | 15.129 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net472 | 15.019 ns | 0.0234 ns | 0.0219 ns | 15.023 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.0 | 14.182 ns | 0.0174 ns | 0.0163 ns | 14.182 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.2 | 13.697 ns | 0.0168 ns | 0.0157 ns | 13.698 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 3.0 | 11.695 ns | 0.0154 ns | 0.0136 ns | 11.693 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net461 | 15.073 ns | 0.0242 ns | 0.0214 ns | 15.068 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net472 | 13.690 ns | 0.0329 ns | 0.0307 ns | 13.695 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                              From_NonConvertibleClass | .NET Core 2.0 | 12.113 ns | 0.0175 ns | 0.0164 ns | 12.118 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 2.2 | 10.562 ns | 0.0218 ns | 0.0204 ns | 10.557 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 3.0 | 12.101 ns | 0.2667 ns | 0.4229 ns | 12.309 ns |  0.98 |    0.04 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net461 | 12.432 ns | 0.0308 ns | 0.0288 ns | 12.423 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net472 | 12.635 ns | 0.0105 ns | 0.0098 ns | 12.636 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                     From_NonConvertibleClass_AsObject | .NET Core 2.0 | 15.345 ns | 0.0268 ns | 0.0250 ns | 15.348 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 2.2 | 14.536 ns | 0.0688 ns | 0.0643 ns | 14.501 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 3.0 | 14.361 ns | 0.2969 ns | 0.2777 ns | 14.493 ns |  0.94 |    0.02 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net461 | 15.097 ns | 0.0298 ns | 0.0278 ns | 15.087 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net472 | 15.399 ns | 0.0540 ns | 0.0478 ns | 15.401 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                      From_NonConvertibleClass_NoValue | .NET Core 2.0 | 12.096 ns | 0.0071 ns | 0.0063 ns | 12.097 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 2.2 | 10.553 ns | 0.0120 ns | 0.0100 ns | 10.550 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 3.0 | 11.579 ns | 0.0339 ns | 0.0317 ns | 11.571 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net461 | 14.050 ns | 0.0183 ns | 0.0171 ns | 14.050 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net472 | 12.841 ns | 0.0216 ns | 0.0202 ns | 12.835 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.0 | 15.537 ns | 0.0275 ns | 0.0244 ns | 15.535 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.2 | 14.671 ns | 0.1303 ns | 0.1219 ns | 14.762 ns |  0.94 |    0.01 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 3.0 | 12.224 ns | 0.2715 ns | 0.3334 ns | 12.065 ns |  0.79 |    0.02 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net461 | 13.446 ns | 0.0260 ns | 0.0243 ns | 13.453 ns |  0.87 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net472 | 14.560 ns | 0.0311 ns | 0.0291 ns | 14.559 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                From_ConvertibleStruct | .NET Core 2.0 | 19.675 ns | 0.0678 ns | 0.0634 ns | 19.665 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 2.2 | 16.318 ns | 0.0356 ns | 0.0316 ns | 16.311 ns |  0.83 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 3.0 | 12.598 ns | 0.0546 ns | 0.0484 ns | 12.600 ns |  0.64 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net461 | 17.357 ns | 0.0492 ns | 0.0460 ns | 17.358 ns |  0.88 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net472 | 16.960 ns | 0.0463 ns | 0.0410 ns | 16.947 ns |  0.86 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                       From_ConvertibleStruct_AsObject | .NET Core 2.0 | 18.094 ns | 0.0426 ns | 0.0356 ns | 18.100 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 2.2 | 16.038 ns | 0.0224 ns | 0.0199 ns | 16.036 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 3.0 | 17.951 ns | 0.1530 ns | 0.1432 ns | 17.889 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net461 | 19.205 ns | 0.0381 ns | 0.0356 ns | 19.200 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net472 | 18.307 ns | 0.0194 ns | 0.0172 ns | 18.305 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.0 | 19.389 ns | 0.0518 ns | 0.0459 ns | 19.398 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.2 | 16.865 ns | 0.1260 ns | 0.1179 ns | 16.881 ns |  0.87 |    0.01 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 3.0 | 13.721 ns | 0.0525 ns | 0.0491 ns | 13.717 ns |  0.71 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net461 | 17.873 ns | 0.0383 ns | 0.0358 ns | 17.882 ns |  0.92 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net472 | 17.909 ns | 0.0497 ns | 0.0415 ns | 17.905 ns |  0.92 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 17.943 ns | 0.0266 ns | 0.0249 ns | 17.939 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 16.430 ns | 0.0373 ns | 0.0331 ns | 16.427 ns |  0.92 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.530 ns | 0.0220 ns | 0.0206 ns | 15.529 ns |  0.87 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net461 | 17.722 ns | 0.1526 ns | 0.1427 ns | 17.674 ns |  0.99 |    0.01 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net472 | 18.091 ns | 0.0549 ns | 0.0486 ns | 18.076 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.0 | 14.240 ns | 0.0224 ns | 0.0175 ns | 14.241 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.2 | 12.249 ns | 0.0640 ns | 0.0568 ns | 12.264 ns |  0.86 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 3.0 |  7.962 ns | 0.0858 ns | 0.0803 ns |  7.976 ns |  0.56 |    0.01 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net461 | 10.814 ns | 0.0306 ns | 0.0256 ns | 10.800 ns |  0.76 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net472 | 10.581 ns | 0.0250 ns | 0.0222 ns | 10.583 ns |  0.74 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.217 ns | 0.0180 ns | 0.0160 ns | 14.215 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.880 ns | 0.0734 ns | 0.0687 ns | 12.855 ns |  0.91 |    0.01 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.221 ns | 0.1237 ns | 0.1158 ns | 13.312 ns |  0.93 |    0.01 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net461 | 13.549 ns | 0.0280 ns | 0.0261 ns | 13.548 ns |  0.95 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net472 | 13.620 ns | 0.0237 ns | 0.0222 ns | 13.623 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_NonConvertibleStruct | .NET Core 2.0 | 13.283 ns | 0.0323 ns | 0.0302 ns | 13.288 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 2.2 | 12.208 ns | 0.0181 ns | 0.0142 ns | 12.206 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 3.0 |  7.287 ns | 0.4969 ns | 0.5915 ns |  6.966 ns |  0.56 |    0.05 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net461 | 10.419 ns | 0.0284 ns | 0.0265 ns | 10.411 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net472 | 11.636 ns | 0.0790 ns | 0.0739 ns | 11.593 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.0 | 15.233 ns | 0.0324 ns | 0.0303 ns | 15.228 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.2 | 14.411 ns | 0.1124 ns | 0.1051 ns | 14.451 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 3.0 | 13.340 ns | 0.0775 ns | 0.0647 ns | 13.318 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net461 | 16.888 ns | 0.0630 ns | 0.0589 ns | 16.916 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net472 | 15.667 ns | 0.0284 ns | 0.0237 ns | 15.668 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.0 | 13.270 ns | 0.0147 ns | 0.0122 ns | 13.264 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.2 | 12.086 ns | 0.0282 ns | 0.0250 ns | 12.079 ns |  0.91 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 3.0 |  6.887 ns | 0.0094 ns | 0.0088 ns |  6.887 ns |  0.52 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net461 | 10.544 ns | 0.0188 ns | 0.0176 ns | 10.549 ns |  0.79 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net472 | 11.687 ns | 0.0799 ns | 0.0747 ns | 11.675 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 15.907 ns | 0.0506 ns | 0.0423 ns | 15.919 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 16.467 ns | 0.0272 ns | 0.0255 ns | 16.465 ns |  1.04 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 13.986 ns | 0.0374 ns | 0.0349 ns | 13.994 ns |  0.88 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net461 | 17.219 ns | 0.1716 ns | 0.1605 ns | 17.125 ns |  1.08 |    0.01 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net472 | 15.328 ns | 0.0302 ns | 0.0282 ns | 15.335 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.0 | 13.174 ns | 0.0316 ns | 0.0264 ns | 13.174 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.2 | 12.083 ns | 0.0175 ns | 0.0146 ns | 12.084 ns |  0.92 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 3.0 |  7.144 ns | 0.1673 ns | 0.2055 ns |  7.034 ns |  0.55 |    0.02 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net461 | 10.410 ns | 0.0199 ns | 0.0186 ns | 10.408 ns |  0.79 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net472 | 11.589 ns | 0.0274 ns | 0.0243 ns | 11.593 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.893 ns | 0.0648 ns | 0.0606 ns | 15.911 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.847 ns | 0.0098 ns | 0.0082 ns | 12.847 ns |  0.81 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.191 ns | 0.0268 ns | 0.0250 ns | 13.187 ns |  0.83 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net461 | 15.107 ns | 0.0319 ns | 0.0267 ns | 15.109 ns |  0.95 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net472 | 13.882 ns | 0.0143 ns | 0.0133 ns | 13.882 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Enum | .NET Core 2.0 | 13.163 ns | 0.0224 ns | 0.0199 ns | 13.160 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 2.2 | 11.970 ns | 0.0824 ns | 0.0771 ns | 12.000 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 3.0 |  6.778 ns | 0.0451 ns | 0.0422 ns |  6.763 ns |  0.51 |    0.00 |      - |     - |     - |         - |
                                             From_Enum |        net461 | 10.666 ns | 0.0878 ns | 0.0821 ns | 10.652 ns |  0.81 |    0.01 |      - |     - |     - |         - |
                                             From_Enum |        net472 | 10.417 ns | 0.0263 ns | 0.0233 ns | 10.421 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Enum_AsObject | .NET Core 2.0 | 50.352 ns | 0.1050 ns | 0.0877 ns | 50.369 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject | .NET Core 2.2 | 46.133 ns | 0.0879 ns | 0.0822 ns | 46.139 ns |  0.92 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject | .NET Core 3.0 | 40.368 ns | 0.0757 ns | 0.0632 ns | 40.379 ns |  0.80 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject |        net461 | 42.318 ns | 0.1195 ns | 0.1060 ns | 42.321 ns |  0.84 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject |        net472 | 44.259 ns | 0.2611 ns | 0.2315 ns | 44.127 ns |  0.88 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Enum_Nullable_WithValue | .NET Core 2.0 | 13.739 ns | 0.0133 ns | 0.0118 ns | 13.736 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 2.2 | 12.229 ns | 0.0242 ns | 0.0227 ns | 12.224 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 3.0 |  7.201 ns | 0.0156 ns | 0.0146 ns |  7.206 ns |  0.52 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net461 | 12.258 ns | 0.1270 ns | 0.1188 ns | 12.296 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net472 | 10.755 ns | 0.0444 ns | 0.0415 ns | 10.769 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.0 | 44.979 ns | 0.1096 ns | 0.1025 ns | 44.966 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.2 | 40.443 ns | 0.2232 ns | 0.1979 ns | 40.380 ns |  0.90 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 3.0 | 34.125 ns | 0.4265 ns | 0.3990 ns | 34.012 ns |  0.76 |    0.01 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject |        net461 | 42.393 ns | 0.0814 ns | 0.0762 ns | 42.404 ns |  0.94 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject |        net472 | 43.294 ns | 0.0878 ns | 0.0686 ns | 43.298 ns |  0.96 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Enum_Nullable_NoValue | .NET Core 2.0 | 13.502 ns | 0.0139 ns | 0.0130 ns | 13.497 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 2.2 | 13.506 ns | 0.0145 ns | 0.0128 ns | 13.503 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 3.0 |  7.269 ns | 0.0185 ns | 0.0173 ns |  7.271 ns |  0.54 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net461 | 11.026 ns | 0.0119 ns | 0.0106 ns | 11.028 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net472 | 10.508 ns | 0.0101 ns | 0.0094 ns | 10.511 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.779 ns | 0.0310 ns | 0.0275 ns | 15.769 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.883 ns | 0.0524 ns | 0.0490 ns | 12.872 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.123 ns | 0.0180 ns | 0.0141 ns | 13.123 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net461 | 13.516 ns | 0.0253 ns | 0.0224 ns | 13.512 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net472 | 13.662 ns | 0.0229 ns | 0.0203 ns | 13.663 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                      From_ParentClass | .NET Core 2.0 | 12.004 ns | 0.1065 ns | 0.0997 ns | 11.956 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 2.2 | 10.554 ns | 0.0212 ns | 0.0188 ns | 10.549 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 3.0 | 12.273 ns | 0.2721 ns | 0.4546 ns | 12.426 ns |  1.00 |    0.05 |      - |     - |     - |         - |
                                      From_ParentClass |        net461 | 14.028 ns | 0.0206 ns | 0.0193 ns | 14.025 ns |  1.17 |    0.01 |      - |     - |     - |         - |
                                      From_ParentClass |        net472 | 12.697 ns | 0.0235 ns | 0.0220 ns | 12.695 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_ParentClass_AsObject | .NET Core 2.0 | 17.569 ns | 0.0140 ns | 0.0131 ns | 17.572 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 2.2 | 15.581 ns | 0.1397 ns | 0.1306 ns | 15.536 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 3.0 | 16.220 ns | 0.0935 ns | 0.0781 ns | 16.243 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net461 | 15.846 ns | 0.0316 ns | 0.0264 ns | 15.844 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net472 | 15.597 ns | 0.0286 ns | 0.0267 ns | 15.597 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                              From_ParentClass_NoValue | .NET Core 2.0 | 12.818 ns | 0.0308 ns | 0.0273 ns | 12.814 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 2.2 | 10.562 ns | 0.0488 ns | 0.0456 ns | 10.540 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 3.0 | 11.767 ns | 0.1603 ns | 0.1499 ns | 11.692 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net461 | 12.623 ns | 0.0329 ns | 0.0307 ns | 12.611 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net472 | 12.449 ns | 0.0231 ns | 0.0193 ns | 12.442 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.0 | 15.203 ns | 0.0534 ns | 0.0473 ns | 15.189 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.2 | 13.143 ns | 0.0186 ns | 0.0145 ns | 13.141 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 3.0 | 11.707 ns | 0.0250 ns | 0.0234 ns | 11.700 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net461 | 13.475 ns | 0.0337 ns | 0.0316 ns | 13.472 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net472 | 14.308 ns | 0.0277 ns | 0.0246 ns | 14.305 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_ParentStruct | .NET Core 2.0 | 40.051 ns | 0.1087 ns | 0.0963 ns | 40.056 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 2.2 | 38.936 ns | 0.0318 ns | 0.0266 ns | 38.933 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 3.0 | 37.064 ns | 0.2296 ns | 0.2147 ns | 37.057 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                                     From_ParentStruct |        net461 | 39.136 ns | 0.0779 ns | 0.0608 ns | 39.144 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct |        net472 | 39.357 ns | 0.1530 ns | 0.1431 ns | 39.328 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_ParentStruct_AsObject | .NET Core 2.0 | 15.685 ns | 0.0273 ns | 0.0242 ns | 15.680 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 2.2 | 14.471 ns | 0.0229 ns | 0.0215 ns | 14.470 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 3.0 | 14.778 ns | 0.0174 ns | 0.0154 ns | 14.782 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net461 | 15.427 ns | 0.0376 ns | 0.0351 ns | 15.427 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net472 | 15.511 ns | 0.0383 ns | 0.0320 ns | 15.506 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.0 | 39.887 ns | 0.1626 ns | 0.1521 ns | 39.930 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.2 | 39.335 ns | 0.0835 ns | 0.0781 ns | 39.309 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 3.0 | 38.370 ns | 0.7798 ns | 1.3452 ns | 39.006 ns |  0.94 |    0.04 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue |        net461 | 39.209 ns | 0.0875 ns | 0.0731 ns | 39.208 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue |        net472 | 39.987 ns | 0.0634 ns | 0.0593 ns | 39.997 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 15.684 ns | 0.0544 ns | 0.0509 ns | 15.685 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 14.683 ns | 0.0149 ns | 0.0132 ns | 14.680 ns |  0.94 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 13.443 ns | 0.0153 ns | 0.0128 ns | 13.445 ns |  0.86 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net461 | 17.129 ns | 0.1119 ns | 0.0935 ns | 17.144 ns |  1.09 |    0.01 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net472 | 15.790 ns | 0.0880 ns | 0.0735 ns | 15.775 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.0 | 39.883 ns | 0.0951 ns | 0.0843 ns | 39.910 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.2 | 40.861 ns | 0.0409 ns | 0.0362 ns | 40.875 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 3.0 | 35.099 ns | 0.0560 ns | 0.0524 ns | 35.109 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net461 | 39.106 ns | 0.0960 ns | 0.0851 ns | 39.081 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net472 | 47.025 ns | 0.0845 ns | 0.0791 ns | 47.043 ns |  1.18 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.428 ns | 0.0125 ns | 0.0117 ns | 14.431 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.721 ns | 0.0231 ns | 0.0216 ns | 13.722 ns |  0.95 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.274 ns | 0.0202 ns | 0.0158 ns | 12.274 ns |  0.85 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net461 | 13.523 ns | 0.0305 ns | 0.0238 ns | 13.527 ns |  0.94 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net472 | 13.644 ns | 0.0337 ns | 0.0299 ns | 13.632 ns |  0.95 |    0.00 |      - |     - |     - |         - |

Benchmarks with issues:
  ConvertTo_Double.From_Char_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_Double.From_Char_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_Double.From_Char_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_Double.From_Char_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_Double.From_Char_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_Double.From_Char_Nullable_WithValue_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_Double.From_Char_Nullable_WithValue_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_Double.From_Char_Nullable_WithValue_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_Double.From_Char_Nullable_WithValue_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_Double.From_Char_Nullable_WithValue_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_Double.From_DateTime_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_Double.From_DateTime_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_Double.From_DateTime_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_Double.From_DateTime_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_Double.From_DateTime_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_Double.From_DateTime_Nullable_WithValue_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_Double.From_DateTime_Nullable_WithValue_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_Double.From_DateTime_Nullable_WithValue_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_Double.From_DateTime_Nullable_WithValue_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_Double.From_DateTime_Nullable_WithValue_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_Double.From_String_Empty_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_Double.From_String_Empty_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_Double.From_String_Empty_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_Double.From_String_Empty_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_Double.From_String_Empty_AsObject: Job-PJAXXB(Toolchain=net472)
