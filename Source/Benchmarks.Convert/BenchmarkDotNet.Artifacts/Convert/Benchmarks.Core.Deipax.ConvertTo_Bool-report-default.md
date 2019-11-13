
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
                                             From_Bool | .NET Core 2.0 | 11.763 ns | 0.1407 ns | 0.1175 ns | 11.734 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 2.2 | 10.694 ns | 0.0402 ns | 0.0356 ns | 10.702 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 3.0 |  7.155 ns | 0.0292 ns | 0.0274 ns |  7.161 ns |  0.61 |    0.01 |      - |     - |     - |         - |
                                             From_Bool |        net461 | 10.568 ns | 0.0727 ns | 0.0680 ns | 10.595 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                                             From_Bool |        net472 | 10.353 ns | 0.0139 ns | 0.0130 ns | 10.354 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Bool_AsObject | .NET Core 2.0 | 14.699 ns | 0.1483 ns | 0.1387 ns | 14.618 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 2.2 | 14.249 ns | 0.0170 ns | 0.0132 ns | 14.250 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 3.0 | 11.885 ns | 0.0217 ns | 0.0170 ns | 11.885 ns |  0.81 |    0.01 |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net461 | 15.426 ns | 0.0241 ns | 0.0214 ns | 15.416 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net472 | 14.076 ns | 0.0249 ns | 0.0221 ns | 14.073 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Bool_Nullable_WithValue | .NET Core 2.0 | 12.381 ns | 0.0113 ns | 0.0088 ns | 12.382 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 2.2 | 10.243 ns | 0.0131 ns | 0.0123 ns | 10.241 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 3.0 |  7.010 ns | 0.0102 ns | 0.0091 ns |  7.012 ns |  0.57 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net461 | 10.686 ns | 0.0161 ns | 0.0143 ns | 10.690 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net472 | 10.673 ns | 0.0577 ns | 0.0540 ns | 10.645 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.0 | 14.646 ns | 0.0583 ns | 0.0517 ns | 14.634 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.2 | 13.320 ns | 0.0968 ns | 0.0905 ns | 13.364 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 3.0 | 14.284 ns | 0.0527 ns | 0.0493 ns | 14.305 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net461 | 15.486 ns | 0.0219 ns | 0.0205 ns | 15.488 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net472 | 14.061 ns | 0.0242 ns | 0.0226 ns | 14.056 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Bool_Nullable_NoValue | .NET Core 2.0 | 11.771 ns | 0.0925 ns | 0.0865 ns | 11.804 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 2.2 | 11.516 ns | 0.0121 ns | 0.0107 ns | 11.520 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 3.0 |  8.103 ns | 0.1868 ns | 0.4652 ns |  8.285 ns |  0.63 |    0.05 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net461 | 10.453 ns | 0.0162 ns | 0.0135 ns | 10.451 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net472 | 10.377 ns | 0.0087 ns | 0.0082 ns | 10.378 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.897 ns | 0.0056 ns | 0.0049 ns | 14.897 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.637 ns | 0.0108 ns | 0.0096 ns | 12.637 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.950 ns | 0.0229 ns | 0.0191 ns | 11.958 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net461 | 13.077 ns | 0.0208 ns | 0.0174 ns | 13.075 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net472 | 13.327 ns | 0.0490 ns | 0.0434 ns | 13.314 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Byte | .NET Core 2.0 | 11.808 ns | 0.0866 ns | 0.0768 ns | 11.837 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 2.2 | 11.790 ns | 0.1095 ns | 0.1024 ns | 11.803 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 3.0 |  6.710 ns | 0.0121 ns | 0.0113 ns |  6.708 ns |  0.57 |    0.00 |      - |     - |     - |         - |
                                             From_Byte |        net461 | 10.457 ns | 0.0170 ns | 0.0159 ns | 10.455 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                                             From_Byte |        net472 | 10.350 ns | 0.0304 ns | 0.0270 ns | 10.344 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Byte_AsObject | .NET Core 2.0 | 21.721 ns | 0.0304 ns | 0.0254 ns | 21.719 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 2.2 | 17.837 ns | 0.0177 ns | 0.0166 ns | 17.841 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 3.0 | 16.114 ns | 0.0717 ns | 0.0670 ns | 16.122 ns |  0.74 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net461 | 17.706 ns | 0.0906 ns | 0.0848 ns | 17.682 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net472 | 18.514 ns | 0.0468 ns | 0.0438 ns | 18.522 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Byte_Nullable_WithValue | .NET Core 2.0 | 11.861 ns | 0.0242 ns | 0.0227 ns | 11.854 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 2.2 | 10.221 ns | 0.0163 ns | 0.0144 ns | 10.217 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 3.0 |  7.653 ns | 0.0143 ns | 0.0134 ns |  7.654 ns |  0.65 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net461 | 10.664 ns | 0.0131 ns | 0.0110 ns | 10.667 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net472 | 10.661 ns | 0.0262 ns | 0.0233 ns | 10.659 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.763 ns | 0.0664 ns | 0.0622 ns | 18.755 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.2 | 18.143 ns | 0.0918 ns | 0.0859 ns | 18.173 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.965 ns | 0.0215 ns | 0.0201 ns | 15.965 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net461 | 19.586 ns | 0.0914 ns | 0.0763 ns | 19.587 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net472 | 18.196 ns | 0.0319 ns | 0.0283 ns | 18.203 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Byte_Nullable_NoValue | .NET Core 2.0 | 11.600 ns | 0.0247 ns | 0.0231 ns | 11.598 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 2.2 | 10.020 ns | 0.0123 ns | 0.0096 ns | 10.017 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 3.0 |  7.483 ns | 0.0436 ns | 0.0408 ns |  7.460 ns |  0.65 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net461 | 11.720 ns | 0.0119 ns | 0.0106 ns | 11.721 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net472 | 10.410 ns | 0.0175 ns | 0.0163 ns | 10.411 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.273 ns | 0.0866 ns | 0.0810 ns | 14.295 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.627 ns | 0.0148 ns | 0.0132 ns | 12.628 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.295 ns | 0.0159 ns | 0.0141 ns | 11.294 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net461 | 14.820 ns | 0.0204 ns | 0.0170 ns | 14.828 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net472 | 13.331 ns | 0.0126 ns | 0.0118 ns | 13.329 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Char | .NET Core 2.0 | 11.650 ns | 0.0336 ns | 0.0298 ns | 11.643 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Char | .NET Core 2.2 | 10.055 ns | 0.0398 ns | 0.0372 ns | 10.059 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                             From_Char | .NET Core 3.0 |  6.897 ns | 0.0092 ns | 0.0077 ns |  6.897 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                                             From_Char |        net461 | 11.810 ns | 0.0137 ns | 0.0121 ns | 11.810 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                             From_Char |        net472 | 11.643 ns | 0.0195 ns | 0.0163 ns | 11.639 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Char_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Char_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Char_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Char_Nullable_WithValue | .NET Core 2.0 | 12.460 ns | 0.1513 ns | 0.1415 ns | 12.365 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 2.2 |  9.988 ns | 0.0102 ns | 0.0095 ns |  9.987 ns |  0.80 |    0.01 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 3.0 |  6.963 ns | 0.3766 ns | 0.5519 ns |  6.661 ns |  0.58 |    0.06 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net461 | 11.817 ns | 0.0121 ns | 0.0101 ns | 11.819 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net472 | 11.504 ns | 0.0160 ns | 0.0149 ns | 11.505 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Char_Nullable_NoValue | .NET Core 2.0 | 12.110 ns | 0.0284 ns | 0.0266 ns | 12.104 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 2.2 |  9.983 ns | 0.0098 ns | 0.0091 ns |  9.981 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 3.0 |  6.445 ns | 0.0488 ns | 0.0457 ns |  6.470 ns |  0.53 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net461 | 10.456 ns | 0.0175 ns | 0.0146 ns | 10.455 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net472 | 11.482 ns | 0.0099 ns | 0.0087 ns | 11.483 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.042 ns | 0.0233 ns | 0.0207 ns | 14.040 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.626 ns | 0.0144 ns | 0.0128 ns | 12.625 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.939 ns | 0.0775 ns | 0.0725 ns | 12.908 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net461 | 13.115 ns | 0.0205 ns | 0.0182 ns | 13.115 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net472 | 13.175 ns | 0.0299 ns | 0.0265 ns | 13.170 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                         From_DateTime | .NET Core 2.0 | 11.965 ns | 0.0106 ns | 0.0088 ns | 11.968 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 2.2 | 11.060 ns | 0.0653 ns | 0.0611 ns | 11.023 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 3.0 |  8.216 ns | 0.1392 ns | 0.1302 ns |  8.233 ns |  0.69 |    0.01 |      - |     - |     - |         - |
                                         From_DateTime |        net461 | 11.700 ns | 0.0210 ns | 0.0164 ns | 11.699 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime |        net472 | 12.751 ns | 0.0155 ns | 0.0137 ns | 12.748 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                From_DateTime_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                      From_DateTime_Nullable_WithValue | .NET Core 2.0 | 14.979 ns | 0.0341 ns | 0.0284 ns | 14.981 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 2.2 | 11.125 ns | 0.0130 ns | 0.0116 ns | 11.126 ns |  0.74 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 3.0 |  8.025 ns | 0.0158 ns | 0.0147 ns |  8.023 ns |  0.54 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net461 | 13.188 ns | 0.0188 ns | 0.0176 ns | 13.195 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net472 | 13.894 ns | 0.1913 ns | 0.1790 ns | 13.910 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_DateTime_Nullable_NoValue | .NET Core 2.0 | 14.591 ns | 0.0216 ns | 0.0191 ns | 14.591 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 2.2 | 11.398 ns | 0.0160 ns | 0.0142 ns | 11.396 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 3.0 |  8.058 ns | 0.0398 ns | 0.0372 ns |  8.076 ns |  0.55 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net461 | 13.099 ns | 0.0154 ns | 0.0129 ns | 13.099 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net472 | 13.302 ns | 0.0109 ns | 0.0096 ns | 13.306 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.891 ns | 0.0238 ns | 0.0222 ns | 14.884 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.526 ns | 0.0176 ns | 0.0147 ns | 13.528 ns |  0.91 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.764 ns | 0.0134 ns | 0.0104 ns | 13.762 ns |  0.92 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net461 | 13.000 ns | 0.0199 ns | 0.0176 ns | 12.999 ns |  0.87 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net472 | 13.213 ns | 0.0180 ns | 0.0168 ns | 13.218 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                          From_Decimal | .NET Core 2.0 | 22.977 ns | 0.0187 ns | 0.0165 ns | 22.981 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 2.2 | 19.431 ns | 0.0242 ns | 0.0227 ns | 19.430 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 3.0 | 13.295 ns | 0.0133 ns | 0.0118 ns | 13.293 ns |  0.58 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal |        net461 | 22.686 ns | 0.0657 ns | 0.0582 ns | 22.681 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal |        net472 | 22.439 ns | 0.0177 ns | 0.0138 ns | 22.446 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                 From_Decimal_AsObject | .NET Core 2.0 | 24.354 ns | 0.0734 ns | 0.0613 ns | 24.359 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 2.2 | 22.431 ns | 0.0527 ns | 0.0493 ns | 22.449 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 3.0 | 19.354 ns | 0.0279 ns | 0.0261 ns | 19.345 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net461 | 27.842 ns | 0.0280 ns | 0.0248 ns | 27.836 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net472 | 25.317 ns | 0.0316 ns | 0.0295 ns | 25.315 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                       From_Decimal_Nullable_WithValue | .NET Core 2.0 | 23.623 ns | 0.0249 ns | 0.0208 ns | 23.621 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 2.2 | 20.835 ns | 0.0218 ns | 0.0204 ns | 20.832 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 3.0 | 13.870 ns | 0.0778 ns | 0.0728 ns | 13.905 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net461 | 23.935 ns | 0.0918 ns | 0.0814 ns | 23.963 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net472 | 23.250 ns | 0.0216 ns | 0.0202 ns | 23.251 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.0 | 22.642 ns | 0.0461 ns | 0.0409 ns | 22.633 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.2 | 21.477 ns | 0.0497 ns | 0.0465 ns | 21.476 ns |  0.95 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 3.0 | 19.605 ns | 0.0205 ns | 0.0182 ns | 19.606 ns |  0.87 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net461 | 26.218 ns | 0.0442 ns | 0.0414 ns | 26.197 ns |  1.16 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net472 | 23.899 ns | 0.0410 ns | 0.0384 ns | 23.907 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Decimal_Nullable_NoValue | .NET Core 2.0 | 13.463 ns | 0.0183 ns | 0.0153 ns | 13.458 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 2.2 | 11.360 ns | 0.0841 ns | 0.0746 ns | 11.348 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 3.0 | 10.381 ns | 0.2319 ns | 0.6465 ns | 10.580 ns |  0.68 |    0.09 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net461 | 14.154 ns | 0.0193 ns | 0.0181 ns | 14.152 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net472 | 14.886 ns | 0.0396 ns | 0.0371 ns | 14.887 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.380 ns | 0.0203 ns | 0.0180 ns | 13.377 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.623 ns | 0.0229 ns | 0.0203 ns | 12.623 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.199 ns | 0.2846 ns | 0.2662 ns | 14.342 ns |  1.06 |    0.02 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net461 | 14.841 ns | 0.0292 ns | 0.0244 ns | 14.839 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net472 | 13.894 ns | 0.0105 ns | 0.0088 ns | 13.891 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_Double | .NET Core 2.0 | 11.746 ns | 0.0160 ns | 0.0150 ns | 11.745 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 2.2 | 10.456 ns | 0.0400 ns | 0.0355 ns | 10.465 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 3.0 |  7.809 ns | 0.1794 ns | 0.3188 ns |  7.973 ns |  0.64 |    0.03 |      - |     - |     - |         - |
                                           From_Double |        net461 | 10.580 ns | 0.0155 ns | 0.0145 ns | 10.581 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                           From_Double |        net472 | 10.421 ns | 0.0156 ns | 0.0146 ns | 10.419 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_Double_AsObject | .NET Core 2.0 | 17.048 ns | 0.2805 ns | 0.2486 ns | 17.031 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 2.2 | 15.648 ns | 0.0223 ns | 0.0197 ns | 15.646 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 3.0 | 15.449 ns | 0.0835 ns | 0.0781 ns | 15.417 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                                  From_Double_AsObject |        net461 | 17.524 ns | 0.0314 ns | 0.0278 ns | 17.522 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                  From_Double_AsObject |        net472 | 18.553 ns | 0.0813 ns | 0.0761 ns | 18.587 ns |  1.09 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_Double_Nullable_WithValue | .NET Core 2.0 | 13.497 ns | 0.2094 ns | 0.1748 ns | 13.423 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 2.2 | 11.335 ns | 0.0183 ns | 0.0171 ns | 11.334 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 3.0 |  8.737 ns | 0.0140 ns | 0.0124 ns |  8.739 ns |  0.65 |    0.01 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net461 | 13.133 ns | 0.0274 ns | 0.0257 ns | 13.132 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net472 | 15.808 ns | 0.0387 ns | 0.0343 ns | 15.796 ns |  1.17 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.0 | 16.878 ns | 0.0555 ns | 0.0464 ns | 16.874 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.2 | 16.054 ns | 0.0719 ns | 0.0637 ns | 16.047 ns |  0.95 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.310 ns | 0.0454 ns | 0.0402 ns | 15.319 ns |  0.91 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net461 | 17.910 ns | 0.0386 ns | 0.0361 ns | 17.902 ns |  1.06 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net472 | 18.305 ns | 0.0379 ns | 0.0316 ns | 18.297 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Double_Nullable_NoValue | .NET Core 2.0 | 12.759 ns | 0.1460 ns | 0.1294 ns | 12.687 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 2.2 | 11.246 ns | 0.0224 ns | 0.0209 ns | 11.248 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 3.0 |  9.181 ns | 0.1580 ns | 0.1478 ns |  9.263 ns |  0.72 |    0.02 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net461 | 12.667 ns | 0.0107 ns | 0.0100 ns | 12.667 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net472 | 12.837 ns | 0.0313 ns | 0.0245 ns | 12.841 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.624 ns | 0.2242 ns | 0.2097 ns | 13.718 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.641 ns | 0.0182 ns | 0.0171 ns | 12.645 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.935 ns | 0.0100 ns | 0.0089 ns | 12.936 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net461 | 14.828 ns | 0.0241 ns | 0.0213 ns | 14.827 ns |  1.09 |    0.02 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net472 | 13.236 ns | 0.0286 ns | 0.0253 ns | 13.232 ns |  0.97 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_Short | .NET Core 2.0 | 11.776 ns | 0.0703 ns | 0.0658 ns | 11.769 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 2.2 | 11.049 ns | 0.0437 ns | 0.0342 ns | 11.060 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                                            From_Short | .NET Core 3.0 |  6.448 ns | 0.0174 ns | 0.0154 ns |  6.445 ns |  0.55 |    0.00 |      - |     - |     - |         - |
                                            From_Short |        net461 | 10.581 ns | 0.0414 ns | 0.0387 ns | 10.564 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                                            From_Short |        net472 | 10.261 ns | 0.0141 ns | 0.0125 ns | 10.260 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_Short_AsObject | .NET Core 2.0 | 16.979 ns | 0.1125 ns | 0.1053 ns | 17.004 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 2.2 | 15.906 ns | 0.0365 ns | 0.0305 ns | 15.905 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 3.0 | 15.542 ns | 0.0510 ns | 0.0477 ns | 15.554 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net461 | 19.232 ns | 0.0193 ns | 0.0180 ns | 19.230 ns |  1.13 |    0.01 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net472 | 18.505 ns | 0.0315 ns | 0.0295 ns | 18.506 ns |  1.09 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Short_Nullable_WithValue | .NET Core 2.0 | 12.499 ns | 0.0390 ns | 0.0365 ns | 12.502 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 2.2 | 10.236 ns | 0.0230 ns | 0.0204 ns | 10.237 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 3.0 |  7.378 ns | 0.0609 ns | 0.0539 ns |  7.390 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net461 | 12.330 ns | 0.0112 ns | 0.0104 ns | 12.332 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net472 | 10.779 ns | 0.0855 ns | 0.0800 ns | 10.822 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.0 | 17.216 ns | 0.2031 ns | 0.1800 ns | 17.262 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.2 | 16.272 ns | 0.0653 ns | 0.0510 ns | 16.285 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.169 ns | 0.0247 ns | 0.0219 ns | 15.173 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net461 | 17.708 ns | 0.0256 ns | 0.0239 ns | 17.701 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net472 | 18.488 ns | 0.0362 ns | 0.0338 ns | 18.496 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Short_Nullable_NoValue | .NET Core 2.0 | 12.118 ns | 0.0424 ns | 0.0376 ns | 12.113 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 2.2 | 10.012 ns | 0.0157 ns | 0.0139 ns | 10.011 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 3.0 |  7.111 ns | 0.0268 ns | 0.0251 ns |  7.105 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net461 | 10.470 ns | 0.0126 ns | 0.0105 ns | 10.472 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net472 | 10.402 ns | 0.0283 ns | 0.0237 ns | 10.398 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.310 ns | 0.0204 ns | 0.0191 ns | 13.309 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.498 ns | 0.0209 ns | 0.0195 ns | 13.501 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.659 ns | 0.1873 ns | 0.1752 ns | 11.656 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net461 | 13.148 ns | 0.0397 ns | 0.0372 ns | 13.144 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net472 | 14.270 ns | 0.0231 ns | 0.0180 ns | 14.269 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                              From_Int | .NET Core 2.0 | 11.793 ns | 0.0202 ns | 0.0179 ns | 11.791 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 2.2 | 10.060 ns | 0.0093 ns | 0.0082 ns | 10.057 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 3.0 |  6.718 ns | 0.0130 ns | 0.0121 ns |  6.717 ns |  0.57 |    0.00 |      - |     - |     - |         - |
                                              From_Int |        net461 | 10.428 ns | 0.0110 ns | 0.0092 ns | 10.424 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                              From_Int |        net472 | 10.275 ns | 0.0130 ns | 0.0122 ns | 10.278 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_Int_AsObject | .NET Core 2.0 | 17.048 ns | 0.0469 ns | 0.0392 ns | 17.041 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 2.2 | 15.876 ns | 0.0275 ns | 0.0244 ns | 15.872 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 3.0 | 14.983 ns | 0.0215 ns | 0.0201 ns | 14.978 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net461 | 19.515 ns | 0.0322 ns | 0.0302 ns | 19.511 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net472 | 18.395 ns | 0.0352 ns | 0.0312 ns | 18.400 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Int_Nullable_WithValue | .NET Core 2.0 | 13.499 ns | 0.0311 ns | 0.0276 ns | 13.499 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 2.2 | 10.251 ns | 0.0321 ns | 0.0284 ns | 10.241 ns |  0.76 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 3.0 |  7.388 ns | 0.0108 ns | 0.0096 ns |  7.387 ns |  0.55 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net461 | 12.355 ns | 0.0499 ns | 0.0467 ns | 12.351 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net472 | 10.636 ns | 0.0107 ns | 0.0100 ns | 10.636 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.0 | 17.482 ns | 0.1956 ns | 0.1830 ns | 17.523 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.665 ns | 0.0174 ns | 0.0154 ns | 15.659 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.191 ns | 0.0277 ns | 0.0259 ns | 15.185 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net461 | 17.555 ns | 0.0241 ns | 0.0214 ns | 17.553 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net472 | 18.493 ns | 0.0302 ns | 0.0282 ns | 18.498 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_Int_Nullable_NoValue | .NET Core 2.0 | 11.714 ns | 0.0158 ns | 0.0140 ns | 11.715 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 2.2 |  9.984 ns | 0.0129 ns | 0.0115 ns |  9.983 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 3.0 |  7.279 ns | 0.1686 ns | 0.2071 ns |  7.448 ns |  0.61 |    0.02 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net461 | 10.467 ns | 0.0107 ns | 0.0100 ns | 10.466 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net472 | 11.584 ns | 0.0128 ns | 0.0114 ns | 11.582 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.379 ns | 0.1837 ns | 0.1718 ns | 13.301 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.491 ns | 0.0238 ns | 0.0211 ns | 13.494 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.861 ns | 0.2633 ns | 0.2704 ns | 11.926 ns |  0.89 |    0.03 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net461 | 13.130 ns | 0.0486 ns | 0.0455 ns | 13.140 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net472 | 13.282 ns | 0.0319 ns | 0.0266 ns | 13.288 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Long | .NET Core 2.0 | 11.840 ns | 0.0815 ns | 0.0723 ns | 11.820 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Long | .NET Core 2.2 | 10.717 ns | 0.0378 ns | 0.0354 ns | 10.711 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                                             From_Long | .NET Core 3.0 |  6.856 ns | 0.0090 ns | 0.0075 ns |  6.858 ns |  0.58 |    0.00 |      - |     - |     - |         - |
                                             From_Long |        net461 | 10.455 ns | 0.0175 ns | 0.0155 ns | 10.454 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                                             From_Long |        net472 | 10.280 ns | 0.0130 ns | 0.0122 ns | 10.275 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Long_AsObject | .NET Core 2.0 | 16.865 ns | 0.0844 ns | 0.0748 ns | 16.853 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 2.2 | 16.143 ns | 0.0379 ns | 0.0336 ns | 16.140 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 3.0 | 15.081 ns | 0.0305 ns | 0.0286 ns | 15.071 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net461 | 19.501 ns | 0.0266 ns | 0.0236 ns | 19.502 ns |  1.16 |    0.01 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net472 | 18.174 ns | 0.0273 ns | 0.0242 ns | 18.174 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Long_Nullable_WithValue | .NET Core 2.0 | 13.498 ns | 0.2271 ns | 0.2124 ns | 13.622 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 2.2 | 11.380 ns | 0.0163 ns | 0.0144 ns | 11.374 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 3.0 |  8.291 ns | 0.0109 ns | 0.0102 ns |  8.289 ns |  0.61 |    0.01 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net461 | 13.071 ns | 0.0794 ns | 0.0743 ns | 13.116 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net472 | 12.956 ns | 0.0159 ns | 0.0133 ns | 12.955 ns |  0.96 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.0 | 17.054 ns | 0.0589 ns | 0.0551 ns | 17.033 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.2 | 16.308 ns | 0.0207 ns | 0.0194 ns | 16.311 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.090 ns | 0.3265 ns | 0.3055 ns | 14.887 ns |  0.88 |    0.02 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net461 | 17.911 ns | 0.0271 ns | 0.0226 ns | 17.913 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net472 | 18.365 ns | 0.0210 ns | 0.0197 ns | 18.371 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Long_Nullable_NoValue | .NET Core 2.0 | 12.836 ns | 0.2352 ns | 0.2200 ns | 12.717 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 2.2 | 11.286 ns | 0.0157 ns | 0.0131 ns | 11.283 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 3.0 |  8.115 ns | 0.0100 ns | 0.0084 ns |  8.114 ns |  0.64 |    0.01 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net461 | 12.652 ns | 0.0206 ns | 0.0192 ns | 12.644 ns |  0.99 |    0.02 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net472 | 12.713 ns | 0.0148 ns | 0.0131 ns | 12.713 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.616 ns | 0.1905 ns | 0.1782 ns | 15.517 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.638 ns | 0.0098 ns | 0.0087 ns | 12.637 ns |  0.81 |    0.01 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.868 ns | 0.0130 ns | 0.0122 ns | 12.867 ns |  0.82 |    0.01 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net461 | 13.055 ns | 0.0136 ns | 0.0113 ns | 13.053 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net472 | 13.445 ns | 0.0752 ns | 0.0704 ns | 13.414 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_SByte | .NET Core 2.0 | 11.920 ns | 0.0910 ns | 0.0807 ns | 11.889 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 2.2 | 10.661 ns | 0.0441 ns | 0.0413 ns | 10.662 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 3.0 |  8.224 ns | 0.1874 ns | 0.3742 ns |  8.348 ns |  0.66 |    0.05 |      - |     - |     - |         - |
                                            From_SByte |        net461 | 10.443 ns | 0.0110 ns | 0.0103 ns | 10.441 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                                            From_SByte |        net472 | 10.277 ns | 0.0291 ns | 0.0272 ns | 10.275 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_SByte_AsObject | .NET Core 2.0 | 18.602 ns | 0.2769 ns | 0.2590 ns | 18.685 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 2.2 | 17.559 ns | 0.0441 ns | 0.0413 ns | 17.560 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 3.0 | 15.642 ns | 0.0417 ns | 0.0390 ns | 15.646 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net461 | 17.527 ns | 0.0390 ns | 0.0365 ns | 17.523 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net472 | 18.478 ns | 0.0335 ns | 0.0297 ns | 18.478 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_SByte_Nullable_WithValue | .NET Core 2.0 | 11.838 ns | 0.0144 ns | 0.0127 ns | 11.842 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 2.2 | 10.212 ns | 0.0109 ns | 0.0091 ns | 10.213 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 3.0 |  7.138 ns | 0.0116 ns | 0.0108 ns |  7.136 ns |  0.60 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net461 | 12.326 ns | 0.0118 ns | 0.0104 ns | 12.325 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net472 | 10.711 ns | 0.0214 ns | 0.0190 ns | 10.715 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.0 | 16.590 ns | 0.0229 ns | 0.0214 ns | 16.584 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.2 | 16.313 ns | 0.0209 ns | 0.0196 ns | 16.312 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.948 ns | 0.2082 ns | 0.1948 ns | 15.824 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net461 | 17.929 ns | 0.0315 ns | 0.0279 ns | 17.930 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net472 | 18.177 ns | 0.0269 ns | 0.0225 ns | 18.182 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_SByte_Nullable_NoValue | .NET Core 2.0 | 11.611 ns | 0.0546 ns | 0.0484 ns | 11.593 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 2.2 | 10.094 ns | 0.0516 ns | 0.0483 ns | 10.117 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 3.0 |  8.102 ns | 0.0089 ns | 0.0074 ns |  8.104 ns |  0.70 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net461 | 10.449 ns | 0.0195 ns | 0.0163 ns | 10.450 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net472 | 10.388 ns | 0.0159 ns | 0.0141 ns | 10.390 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.295 ns | 0.0932 ns | 0.0826 ns | 13.329 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.618 ns | 0.0110 ns | 0.0092 ns | 12.618 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.201 ns | 0.0192 ns | 0.0180 ns | 11.201 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net461 | 13.054 ns | 0.0106 ns | 0.0099 ns | 13.053 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net472 | 14.184 ns | 0.0140 ns | 0.0117 ns | 14.183 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_Float | .NET Core 2.0 | 11.729 ns | 0.0107 ns | 0.0089 ns | 11.729 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 2.2 | 10.341 ns | 0.0149 ns | 0.0140 ns | 10.344 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 3.0 |  7.332 ns | 0.5962 ns | 0.8739 ns |  6.849 ns |  0.68 |    0.09 |      - |     - |     - |         - |
                                            From_Float |        net461 | 11.135 ns | 0.0114 ns | 0.0095 ns | 11.137 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                            From_Float |        net472 | 10.555 ns | 0.0160 ns | 0.0142 ns | 10.556 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_Float_AsObject | .NET Core 2.0 | 16.809 ns | 0.0279 ns | 0.0261 ns | 16.814 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 2.2 | 16.400 ns | 0.0839 ns | 0.0785 ns | 16.392 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 3.0 | 15.205 ns | 0.0461 ns | 0.0385 ns | 15.210 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject |        net461 | 19.238 ns | 0.0404 ns | 0.0378 ns | 19.227 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject |        net472 | 18.496 ns | 0.0313 ns | 0.0293 ns | 18.496 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Float_Nullable_WithValue | .NET Core 2.0 | 12.106 ns | 0.1038 ns | 0.0971 ns | 12.163 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 2.2 | 10.441 ns | 0.0974 ns | 0.0911 ns | 10.457 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 3.0 |  8.456 ns | 0.0092 ns | 0.0082 ns |  8.458 ns |  0.70 |    0.01 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net461 | 10.928 ns | 0.0124 ns | 0.0116 ns | 10.925 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net472 | 10.724 ns | 0.0109 ns | 0.0097 ns | 10.726 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.262 ns | 0.0372 ns | 0.0311 ns | 18.251 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.070 ns | 0.1544 ns | 0.1444 ns | 16.974 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 3.0 | 16.043 ns | 0.0547 ns | 0.0512 ns | 16.025 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net461 | 17.570 ns | 0.0169 ns | 0.0158 ns | 17.571 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net472 | 18.778 ns | 0.0250 ns | 0.0234 ns | 18.776 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Float_Nullable_NoValue | .NET Core 2.0 | 11.630 ns | 0.0205 ns | 0.0181 ns | 11.632 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 2.2 | 10.099 ns | 0.0483 ns | 0.0452 ns | 10.131 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 3.0 |  7.838 ns | 0.0153 ns | 0.0120 ns |  7.842 ns |  0.67 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net461 | 10.507 ns | 0.0152 ns | 0.0142 ns | 10.502 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net472 | 11.358 ns | 0.2407 ns | 0.2364 ns | 11.449 ns |  0.97 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.193 ns | 0.0401 ns | 0.0375 ns | 13.180 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.164 ns | 0.0194 ns | 0.0172 ns | 13.165 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.094 ns | 0.1112 ns | 0.0986 ns | 12.082 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net461 | 13.115 ns | 0.0238 ns | 0.0223 ns | 13.121 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net472 | 13.312 ns | 0.0186 ns | 0.0165 ns | 13.312 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_String | .NET Core 2.0 | 24.663 ns | 0.0611 ns | 0.0542 ns | 24.642 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 2.2 | 31.532 ns | 0.1217 ns | 0.1139 ns | 31.492 ns |  1.28 |    0.01 |      - |     - |     - |         - |
                                           From_String | .NET Core 3.0 | 22.371 ns | 0.0235 ns | 0.0209 ns | 22.373 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                           From_String |        net461 | 25.661 ns | 0.0318 ns | 0.0281 ns | 25.654 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                           From_String |        net472 | 24.600 ns | 0.0297 ns | 0.0278 ns | 24.594 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_String_AsObject | .NET Core 2.0 | 28.115 ns | 0.0317 ns | 0.0297 ns | 28.110 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 2.2 | 40.128 ns | 0.0433 ns | 0.0384 ns | 40.135 ns |  1.43 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 3.0 | 25.010 ns | 0.1265 ns | 0.1183 ns | 24.936 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject |        net461 | 28.648 ns | 0.0288 ns | 0.0256 ns | 28.644 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject |        net472 | 29.574 ns | 0.1041 ns | 0.0923 ns | 29.552 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                      From_String_Null | .NET Core 2.0 | 12.022 ns | 0.0352 ns | 0.0330 ns | 12.027 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 2.2 | 11.481 ns | 0.0123 ns | 0.0115 ns | 11.483 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 3.0 | 12.223 ns | 0.2704 ns | 0.3516 ns | 12.378 ns |  1.01 |    0.03 |      - |     - |     - |         - |
                                      From_String_Null |        net461 | 14.255 ns | 0.0484 ns | 0.0429 ns | 14.271 ns |  1.19 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null |        net472 | 11.039 ns | 0.0108 ns | 0.0096 ns | 11.038 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_String_Null_AsObject | .NET Core 2.0 | 14.032 ns | 0.0094 ns | 0.0088 ns | 14.033 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 2.2 | 12.658 ns | 0.0240 ns | 0.0200 ns | 12.658 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 3.0 | 11.716 ns | 0.1182 ns | 0.1106 ns | 11.631 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net461 | 14.780 ns | 0.0146 ns | 0.0136 ns | 14.779 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net472 | 13.312 ns | 0.0360 ns | 0.0337 ns | 13.324 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_String_Empty | .NET Core 2.0 | 12.168 ns | 0.0388 ns | 0.0363 ns | 12.159 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 2.2 | 12.740 ns | 0.0171 ns | 0.0160 ns | 12.739 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 3.0 | 12.489 ns | 0.0167 ns | 0.0156 ns | 12.488 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty |        net461 | 12.483 ns | 0.0215 ns | 0.0201 ns | 12.483 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty |        net472 | 11.517 ns | 0.0120 ns | 0.0113 ns | 11.520 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_String_Empty_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_UShort | .NET Core 2.0 | 11.669 ns | 0.0135 ns | 0.0120 ns | 11.666 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 2.2 | 10.737 ns | 0.0772 ns | 0.0684 ns | 10.753 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 3.0 |  6.875 ns | 0.0237 ns | 0.0221 ns |  6.871 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                                           From_UShort |        net461 | 10.416 ns | 0.0169 ns | 0.0158 ns | 10.416 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                           From_UShort |        net472 | 10.260 ns | 0.0165 ns | 0.0147 ns | 10.258 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_UShort_AsObject | .NET Core 2.0 | 16.665 ns | 0.0755 ns | 0.0706 ns | 16.689 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 2.2 | 15.923 ns | 0.0705 ns | 0.0659 ns | 15.898 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 3.0 | 16.506 ns | 0.3482 ns | 0.3576 ns | 16.325 ns |  0.99 |    0.02 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net461 | 19.460 ns | 0.0302 ns | 0.0283 ns | 19.457 ns |  1.17 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net472 | 18.179 ns | 0.0275 ns | 0.0257 ns | 18.183 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_UShort_Nullable_WithValue | .NET Core 2.0 | 11.864 ns | 0.0183 ns | 0.0162 ns | 11.871 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 2.2 | 11.025 ns | 0.0697 ns | 0.0652 ns | 11.005 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 3.0 |  7.438 ns | 0.2023 ns | 0.2701 ns |  7.305 ns |  0.64 |    0.03 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net461 | 12.442 ns | 0.0101 ns | 0.0095 ns | 12.442 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net472 | 10.636 ns | 0.0117 ns | 0.0104 ns | 10.635 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.0 | 16.793 ns | 0.0151 ns | 0.0141 ns | 16.793 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.2 | 16.295 ns | 0.0258 ns | 0.0215 ns | 16.299 ns |  0.97 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 3.0 | 14.983 ns | 0.0159 ns | 0.0141 ns | 14.980 ns |  0.89 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net461 | 19.438 ns | 0.0169 ns | 0.0158 ns | 19.439 ns |  1.16 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net472 | 18.411 ns | 0.0363 ns | 0.0321 ns | 18.410 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_UShort_Nullable_NoValue | .NET Core 2.0 | 13.993 ns | 0.0480 ns | 0.0449 ns | 13.975 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 2.2 | 11.170 ns | 0.0146 ns | 0.0122 ns | 11.173 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 3.0 |  9.245 ns | 0.0150 ns | 0.0140 ns |  9.242 ns |  0.66 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net461 | 10.413 ns | 0.0200 ns | 0.0178 ns | 10.412 ns |  0.74 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net472 | 10.509 ns | 0.0142 ns | 0.0133 ns | 10.506 ns |  0.75 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.151 ns | 0.0208 ns | 0.0195 ns | 13.147 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.650 ns | 0.0445 ns | 0.0416 ns | 13.665 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.569 ns | 0.2758 ns | 0.4903 ns | 12.791 ns |  0.93 |    0.05 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net461 | 14.935 ns | 0.0438 ns | 0.0409 ns | 14.938 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net472 | 13.869 ns | 0.0242 ns | 0.0227 ns | 13.870 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_UInt | .NET Core 2.0 | 11.658 ns | 0.0291 ns | 0.0258 ns | 11.650 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 2.2 | 10.001 ns | 0.0667 ns | 0.0624 ns | 10.021 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 3.0 |  6.998 ns | 0.1645 ns | 0.1539 ns |  6.901 ns |  0.60 |    0.01 |      - |     - |     - |         - |
                                             From_UInt |        net461 | 11.778 ns | 0.0246 ns | 0.0218 ns | 11.779 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                             From_UInt |        net472 | 11.230 ns | 0.0112 ns | 0.0094 ns | 11.232 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_UInt_AsObject | .NET Core 2.0 | 16.769 ns | 0.1165 ns | 0.1090 ns | 16.822 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 2.2 | 16.081 ns | 0.0204 ns | 0.0181 ns | 16.078 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 3.0 | 15.938 ns | 0.2015 ns | 0.1885 ns | 15.812 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net461 | 17.673 ns | 0.0243 ns | 0.0227 ns | 17.667 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net472 | 18.509 ns | 0.0292 ns | 0.0259 ns | 18.511 ns |  1.10 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_UInt_Nullable_WithValue | .NET Core 2.0 | 11.845 ns | 0.0076 ns | 0.0068 ns | 11.846 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 2.2 | 10.208 ns | 0.0107 ns | 0.0095 ns | 10.208 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 3.0 |  7.160 ns | 0.0299 ns | 0.0250 ns |  7.164 ns |  0.60 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net461 | 11.362 ns | 0.0192 ns | 0.0180 ns | 11.362 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net472 | 10.618 ns | 0.0170 ns | 0.0151 ns | 10.616 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.0 | 17.072 ns | 0.0228 ns | 0.0213 ns | 17.074 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.2 | 16.341 ns | 0.0227 ns | 0.0201 ns | 16.340 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.051 ns | 0.0166 ns | 0.0147 ns | 15.052 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net461 | 17.876 ns | 0.0285 ns | 0.0266 ns | 17.878 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net472 | 18.673 ns | 0.0224 ns | 0.0199 ns | 18.670 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_UInt_Nullable_NoValue | .NET Core 2.0 | 11.658 ns | 0.0632 ns | 0.0591 ns | 11.685 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 2.2 | 10.021 ns | 0.0102 ns | 0.0090 ns | 10.020 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 3.0 |  7.684 ns | 0.0124 ns | 0.0104 ns |  7.685 ns |  0.66 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net461 | 10.549 ns | 0.0155 ns | 0.0145 ns | 10.548 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net472 | 10.360 ns | 0.0116 ns | 0.0109 ns | 10.358 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.124 ns | 0.0111 ns | 0.0098 ns | 13.124 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.625 ns | 0.0146 ns | 0.0136 ns | 12.626 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.918 ns | 0.0212 ns | 0.0198 ns | 12.922 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net461 | 16.753 ns | 0.0118 ns | 0.0092 ns | 16.755 ns |  1.28 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net472 | 13.202 ns | 0.0271 ns | 0.0240 ns | 13.199 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_ULong | .NET Core 2.0 | 11.659 ns | 0.0251 ns | 0.0209 ns | 11.661 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 2.2 | 10.010 ns | 0.0278 ns | 0.0260 ns | 10.010 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 3.0 |  7.226 ns | 0.0507 ns | 0.0474 ns |  7.192 ns |  0.62 |    0.00 |      - |     - |     - |         - |
                                            From_ULong |        net461 | 10.491 ns | 0.0091 ns | 0.0080 ns | 10.489 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                            From_ULong |        net472 | 10.269 ns | 0.0235 ns | 0.0220 ns | 10.264 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_ULong_AsObject | .NET Core 2.0 | 16.780 ns | 0.0259 ns | 0.0229 ns | 16.775 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 2.2 | 16.312 ns | 0.0261 ns | 0.0244 ns | 16.311 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 3.0 | 15.606 ns | 0.0195 ns | 0.0183 ns | 15.605 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net461 | 17.706 ns | 0.0241 ns | 0.0214 ns | 17.706 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net472 | 18.700 ns | 0.0301 ns | 0.0267 ns | 18.701 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_ULong_Nullable_WithValue | .NET Core 2.0 | 12.615 ns | 0.0146 ns | 0.0137 ns | 12.613 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 2.2 | 11.377 ns | 0.0182 ns | 0.0170 ns | 11.378 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 3.0 |  8.293 ns | 0.0118 ns | 0.0098 ns |  8.291 ns |  0.66 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net461 | 13.028 ns | 0.0126 ns | 0.0112 ns | 13.028 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net472 | 15.347 ns | 0.0191 ns | 0.0178 ns | 15.349 ns |  1.22 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.0 | 16.688 ns | 0.0538 ns | 0.0477 ns | 16.681 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.863 ns | 0.0309 ns | 0.0289 ns | 15.856 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.281 ns | 0.1390 ns | 0.1300 ns | 15.265 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net461 | 19.291 ns | 0.0352 ns | 0.0329 ns | 19.281 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net472 | 18.728 ns | 0.0368 ns | 0.0344 ns | 18.720 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_ULong_Nullable_NoValue | .NET Core 2.0 | 12.514 ns | 0.0208 ns | 0.0194 ns | 12.509 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 2.2 | 11.271 ns | 0.0154 ns | 0.0144 ns | 11.271 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 3.0 |  8.939 ns | 0.0132 ns | 0.0123 ns |  8.937 ns |  0.71 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net461 | 12.580 ns | 0.0164 ns | 0.0145 ns | 12.580 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net472 | 12.718 ns | 0.0104 ns | 0.0087 ns | 12.718 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.127 ns | 0.0132 ns | 0.0124 ns | 13.129 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.628 ns | 0.0122 ns | 0.0114 ns | 12.629 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.891 ns | 0.0141 ns | 0.0118 ns | 12.888 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net461 | 13.155 ns | 0.0152 ns | 0.0143 ns | 13.155 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net472 | 14.340 ns | 0.0107 ns | 0.0095 ns | 14.339 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                       From_NullObject | .NET Core 2.0 | 13.928 ns | 0.0150 ns | 0.0125 ns | 13.930 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 2.2 | 13.880 ns | 0.0660 ns | 0.0617 ns | 13.853 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 3.0 | 14.110 ns | 0.3045 ns | 0.4650 ns | 13.766 ns |  1.05 |    0.02 |      - |     - |     - |         - |
                                       From_NullObject |        net461 | 14.927 ns | 0.0110 ns | 0.0097 ns | 14.927 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject |        net472 | 15.817 ns | 0.0173 ns | 0.0135 ns | 15.816 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_DBNull | .NET Core 2.0 | 12.268 ns | 0.0125 ns | 0.0111 ns | 12.266 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 2.2 |  9.019 ns | 0.0105 ns | 0.0099 ns |  9.017 ns |  0.74 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 3.0 | 11.441 ns | 0.0651 ns | 0.0609 ns | 11.446 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull |        net461 | 11.123 ns | 0.0129 ns | 0.0121 ns | 11.124 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull |        net472 | 10.960 ns | 0.0169 ns | 0.0158 ns | 10.959 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_DBNull_AsObject | .NET Core 2.0 | 13.119 ns | 0.0134 ns | 0.0125 ns | 13.120 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 2.2 | 12.636 ns | 0.0164 ns | 0.0154 ns | 12.636 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 3.0 | 11.803 ns | 0.1517 ns | 0.1419 ns | 11.747 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net461 | 13.044 ns | 0.0271 ns | 0.0254 ns | 13.037 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net472 | 15.766 ns | 0.0359 ns | 0.0318 ns | 15.762 ns |  1.20 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                 From_ConvertibleClass | .NET Core 2.0 | 16.476 ns | 0.0597 ns | 0.0529 ns | 16.478 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 2.2 | 13.545 ns | 0.0887 ns | 0.0830 ns | 13.486 ns |  0.82 |    0.01 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 3.0 | 14.829 ns | 0.0325 ns | 0.0304 ns | 14.826 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net461 | 17.752 ns | 0.0305 ns | 0.0271 ns | 17.751 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net472 | 17.023 ns | 0.0291 ns | 0.0243 ns | 17.020 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_ConvertibleClass_AsObject | .NET Core 2.0 | 15.347 ns | 0.0196 ns | 0.0163 ns | 15.343 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 2.2 | 14.970 ns | 0.0215 ns | 0.0191 ns | 14.971 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 3.0 | 14.605 ns | 0.0503 ns | 0.0470 ns | 14.602 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net461 | 16.395 ns | 0.1380 ns | 0.1224 ns | 16.352 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net472 | 17.148 ns | 0.0277 ns | 0.0259 ns | 17.154 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_ConvertibleClass_NoValue | .NET Core 2.0 | 13.774 ns | 0.0073 ns | 0.0061 ns | 13.774 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 2.2 | 11.743 ns | 0.0169 ns | 0.0158 ns | 11.743 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 3.0 | 11.709 ns | 0.0489 ns | 0.0457 ns | 11.688 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net461 | 13.695 ns | 0.0247 ns | 0.0231 ns | 13.697 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net472 | 13.776 ns | 0.0256 ns | 0.0214 ns | 13.783 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.0 | 13.181 ns | 0.0221 ns | 0.0196 ns | 13.174 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.2 | 14.148 ns | 0.0109 ns | 0.0102 ns | 14.145 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 3.0 | 13.420 ns | 0.2933 ns | 0.3378 ns | 13.623 ns |  1.01 |    0.03 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net461 | 14.925 ns | 0.0269 ns | 0.0251 ns | 14.923 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net472 | 13.307 ns | 0.0471 ns | 0.0440 ns | 13.298 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                              From_NonConvertibleClass | .NET Core 2.0 | 12.778 ns | 0.0629 ns | 0.0557 ns | 12.764 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 2.2 | 10.445 ns | 0.0089 ns | 0.0075 ns | 10.446 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 3.0 | 11.176 ns | 0.2474 ns | 0.3303 ns | 11.360 ns |  0.86 |    0.03 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net461 | 16.228 ns | 0.0154 ns | 0.0144 ns | 16.226 ns |  1.27 |    0.01 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net472 | 12.444 ns | 0.0200 ns | 0.0187 ns | 12.446 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                     From_NonConvertibleClass_AsObject | .NET Core 2.0 | 14.499 ns | 0.1822 ns | 0.1522 ns | 14.519 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 2.2 | 14.068 ns | 0.0129 ns | 0.0114 ns | 14.066 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 3.0 | 15.628 ns | 0.2497 ns | 0.2336 ns | 15.743 ns |  1.08 |    0.02 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net461 | 14.906 ns | 0.0155 ns | 0.0145 ns | 14.906 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net472 | 15.271 ns | 0.0280 ns | 0.0234 ns | 15.269 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                      From_NonConvertibleClass_NoValue | .NET Core 2.0 | 12.892 ns | 0.1289 ns | 0.1205 ns | 12.914 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 2.2 | 10.342 ns | 0.0130 ns | 0.0122 ns | 10.346 ns |  0.80 |    0.01 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 3.0 | 10.790 ns | 0.0123 ns | 0.0115 ns | 10.788 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net461 | 14.119 ns | 0.0715 ns | 0.0668 ns | 14.142 ns |  1.10 |    0.01 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net472 | 12.836 ns | 0.0375 ns | 0.0313 ns | 12.836 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.0 | 13.596 ns | 0.2731 ns | 0.2554 ns | 13.542 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.2 | 13.589 ns | 0.0227 ns | 0.0213 ns | 13.595 ns |  1.00 |    0.02 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 3.0 | 13.791 ns | 0.0187 ns | 0.0175 ns | 13.786 ns |  1.01 |    0.02 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net461 | 13.033 ns | 0.0205 ns | 0.0192 ns | 13.034 ns |  0.96 |    0.02 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net472 | 13.181 ns | 0.0140 ns | 0.0131 ns | 13.181 ns |  0.97 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                From_ConvertibleStruct | .NET Core 2.0 | 18.640 ns | 0.0749 ns | 0.0700 ns | 18.633 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 2.2 | 15.606 ns | 0.0319 ns | 0.0267 ns | 15.604 ns |  0.84 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 3.0 | 11.130 ns | 0.0379 ns | 0.0354 ns | 11.135 ns |  0.60 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net461 | 16.955 ns | 0.0367 ns | 0.0326 ns | 16.962 ns |  0.91 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net472 | 16.714 ns | 0.0851 ns | 0.0796 ns | 16.685 ns |  0.90 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                       From_ConvertibleStruct_AsObject | .NET Core 2.0 | 15.899 ns | 0.0196 ns | 0.0184 ns | 15.899 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 2.2 | 15.196 ns | 0.0168 ns | 0.0157 ns | 15.195 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 3.0 | 15.543 ns | 0.0494 ns | 0.0462 ns | 15.532 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net461 | 16.942 ns | 0.0418 ns | 0.0391 ns | 16.952 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net472 | 17.806 ns | 0.0343 ns | 0.0321 ns | 17.803 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.0 | 18.863 ns | 0.1473 ns | 0.1378 ns | 18.782 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.2 | 15.973 ns | 0.0299 ns | 0.0280 ns | 15.967 ns |  0.85 |    0.01 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 3.0 | 12.541 ns | 0.0716 ns | 0.0670 ns | 12.530 ns |  0.66 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net461 | 17.214 ns | 0.0293 ns | 0.0260 ns | 17.215 ns |  0.91 |    0.01 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net472 | 16.934 ns | 0.0223 ns | 0.0209 ns | 16.930 ns |  0.90 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 16.146 ns | 0.0158 ns | 0.0132 ns | 16.145 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.885 ns | 0.0225 ns | 0.0211 ns | 15.882 ns |  0.98 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 16.530 ns | 0.3495 ns | 0.3885 ns | 16.197 ns |  1.01 |    0.02 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net461 | 18.521 ns | 0.0265 ns | 0.0221 ns | 18.528 ns |  1.15 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net472 | 17.970 ns | 0.0642 ns | 0.0601 ns | 17.945 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.0 | 13.185 ns | 0.0150 ns | 0.0140 ns | 13.183 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.2 | 11.565 ns | 0.0153 ns | 0.0135 ns | 11.560 ns |  0.88 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 3.0 |  6.919 ns | 0.0250 ns | 0.0209 ns |  6.913 ns |  0.52 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net461 | 10.568 ns | 0.0541 ns | 0.0506 ns | 10.590 ns |  0.80 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net472 | 10.460 ns | 0.0195 ns | 0.0183 ns | 10.461 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.565 ns | 0.0459 ns | 0.0429 ns | 13.575 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.521 ns | 0.0137 ns | 0.0128 ns | 13.522 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.032 ns | 0.0148 ns | 0.0131 ns | 12.032 ns |  0.89 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net461 | 13.014 ns | 0.0200 ns | 0.0187 ns | 13.012 ns |  0.96 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net472 | 13.169 ns | 0.0174 ns | 0.0162 ns | 13.175 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_NonConvertibleStruct | .NET Core 2.0 | 12.169 ns | 0.0162 ns | 0.0143 ns | 12.168 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 2.2 | 10.639 ns | 0.0133 ns | 0.0124 ns | 10.638 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 3.0 |  6.732 ns | 0.0067 ns | 0.0060 ns |  6.733 ns |  0.55 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net461 | 10.442 ns | 0.0116 ns | 0.0097 ns | 10.442 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net472 | 11.804 ns | 0.0109 ns | 0.0091 ns | 11.804 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.0 | 14.296 ns | 0.0153 ns | 0.0136 ns | 14.295 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.2 | 14.883 ns | 0.0348 ns | 0.0309 ns | 14.870 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 3.0 | 15.699 ns | 0.0154 ns | 0.0136 ns | 15.696 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net461 | 14.654 ns | 0.0267 ns | 0.0249 ns | 14.647 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net472 | 14.896 ns | 0.0226 ns | 0.0200 ns | 14.891 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.0 | 13.060 ns | 0.0100 ns | 0.0094 ns | 13.058 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.2 | 10.615 ns | 0.0202 ns | 0.0179 ns | 10.610 ns |  0.81 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 3.0 |  6.504 ns | 0.1242 ns | 0.1162 ns |  6.431 ns |  0.50 |    0.01 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net461 | 10.429 ns | 0.0085 ns | 0.0076 ns | 10.431 ns |  0.80 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net472 | 11.683 ns | 0.0581 ns | 0.0543 ns | 11.707 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 14.573 ns | 0.0100 ns | 0.0088 ns | 14.571 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 14.855 ns | 0.0124 ns | 0.0116 ns | 14.851 ns |  1.02 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 12.970 ns | 0.0825 ns | 0.0772 ns | 12.919 ns |  0.89 |    0.01 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net461 | 14.671 ns | 0.0328 ns | 0.0307 ns | 14.679 ns |  1.01 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net472 | 15.079 ns | 0.0428 ns | 0.0400 ns | 15.069 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.0 | 13.109 ns | 0.0145 ns | 0.0135 ns | 13.110 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.2 | 10.969 ns | 0.0168 ns | 0.0157 ns | 10.968 ns |  0.84 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 3.0 |  8.814 ns | 0.0142 ns | 0.0133 ns |  8.817 ns |  0.67 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net461 | 10.437 ns | 0.0186 ns | 0.0145 ns | 10.440 ns |  0.80 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net472 | 11.504 ns | 0.0149 ns | 0.0139 ns | 11.505 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.168 ns | 0.0107 ns | 0.0095 ns | 13.167 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.653 ns | 0.0157 ns | 0.0123 ns | 12.652 ns |  0.96 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.814 ns | 0.1256 ns | 0.1175 ns | 11.871 ns |  0.90 |    0.01 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net461 | 13.003 ns | 0.0221 ns | 0.0207 ns | 13.001 ns |  0.99 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net472 | 13.346 ns | 0.0626 ns | 0.0585 ns | 13.368 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Enum | .NET Core 2.0 | 11.634 ns | 0.0146 ns | 0.0137 ns | 11.632 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 2.2 |  9.986 ns | 0.0175 ns | 0.0155 ns |  9.983 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 3.0 |  6.782 ns | 0.0107 ns | 0.0100 ns |  6.783 ns |  0.58 |    0.00 |      - |     - |     - |         - |
                                             From_Enum |        net461 | 12.909 ns | 0.0213 ns | 0.0199 ns | 12.910 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                             From_Enum |        net472 | 10.714 ns | 0.0137 ns | 0.0121 ns | 10.713 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Enum_AsObject | .NET Core 2.0 | 44.113 ns | 0.0397 ns | 0.0331 ns | 44.108 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject | .NET Core 2.2 | 39.414 ns | 0.1529 ns | 0.1430 ns | 39.421 ns |  0.89 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject | .NET Core 3.0 | 33.163 ns | 0.2269 ns | 0.2123 ns | 33.169 ns |  0.75 |    0.01 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject |        net461 | 42.334 ns | 0.0463 ns | 0.0386 ns | 42.344 ns |  0.96 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject |        net472 | 41.457 ns | 0.1683 ns | 0.1574 ns | 41.405 ns |  0.94 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Enum_Nullable_WithValue | .NET Core 2.0 | 11.889 ns | 0.0170 ns | 0.0159 ns | 11.888 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 2.2 | 12.083 ns | 0.0165 ns | 0.0138 ns | 12.075 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 3.0 |  7.271 ns | 0.0109 ns | 0.0102 ns |  7.270 ns |  0.61 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net461 | 10.663 ns | 0.0151 ns | 0.0141 ns | 10.669 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net472 | 10.666 ns | 0.0345 ns | 0.0323 ns | 10.670 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.0 | 44.241 ns | 0.0562 ns | 0.0498 ns | 44.228 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.2 | 40.490 ns | 0.1137 ns | 0.1008 ns | 40.493 ns |  0.92 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 3.0 | 33.415 ns | 0.2235 ns | 0.2090 ns | 33.468 ns |  0.76 |    0.01 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject |        net461 | 41.097 ns | 0.1338 ns | 0.1186 ns | 41.103 ns |  0.93 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject |        net472 | 41.385 ns | 0.0873 ns | 0.0817 ns | 41.361 ns |  0.94 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Enum_Nullable_NoValue | .NET Core 2.0 | 13.237 ns | 0.0146 ns | 0.0136 ns | 13.238 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 2.2 | 10.800 ns | 0.0121 ns | 0.0107 ns | 10.797 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 3.0 |  7.315 ns | 0.4287 ns | 0.4402 ns |  7.084 ns |  0.55 |    0.03 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net461 | 10.400 ns | 0.0193 ns | 0.0161 ns | 10.398 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net472 | 12.181 ns | 0.0181 ns | 0.0170 ns | 12.189 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.439 ns | 0.0109 ns | 0.0096 ns | 13.441 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.647 ns | 0.0132 ns | 0.0117 ns | 12.648 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.516 ns | 0.3459 ns | 0.9813 ns | 14.813 ns |  0.95 |    0.13 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net461 | 12.989 ns | 0.0205 ns | 0.0191 ns | 12.989 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net472 | 13.727 ns | 0.0213 ns | 0.0200 ns | 13.723 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                      From_ParentClass | .NET Core 2.0 | 13.524 ns | 0.0098 ns | 0.0087 ns | 13.523 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 2.2 | 10.341 ns | 0.0106 ns | 0.0094 ns | 10.340 ns |  0.76 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 3.0 | 10.693 ns | 0.0198 ns | 0.0185 ns | 10.695 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass |        net461 | 12.172 ns | 0.0129 ns | 0.0121 ns | 12.172 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass |        net472 | 12.557 ns | 0.0168 ns | 0.0157 ns | 12.558 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_ParentClass_AsObject | .NET Core 2.0 | 14.675 ns | 0.0202 ns | 0.0189 ns | 14.676 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 2.2 | 14.430 ns | 0.0200 ns | 0.0187 ns | 14.423 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 3.0 | 13.864 ns | 0.0422 ns | 0.0374 ns | 13.854 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net461 | 14.971 ns | 0.0429 ns | 0.0401 ns | 14.956 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net472 | 15.359 ns | 0.0260 ns | 0.0231 ns | 15.356 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                              From_ParentClass_NoValue | .NET Core 2.0 | 13.280 ns | 0.0490 ns | 0.0459 ns | 13.293 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 2.2 | 10.405 ns | 0.0243 ns | 0.0228 ns | 10.400 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 3.0 | 10.766 ns | 0.0113 ns | 0.0100 ns | 10.767 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net461 | 12.185 ns | 0.0217 ns | 0.0203 ns | 12.186 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net472 | 12.456 ns | 0.0384 ns | 0.0359 ns | 12.469 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.0 | 13.165 ns | 0.0140 ns | 0.0131 ns | 13.165 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.2 | 12.651 ns | 0.0084 ns | 0.0074 ns | 12.650 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 3.0 | 11.432 ns | 0.0392 ns | 0.0347 ns | 11.438 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net461 | 13.017 ns | 0.0204 ns | 0.0181 ns | 13.022 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net472 | 13.141 ns | 0.0144 ns | 0.0135 ns | 13.138 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_ParentStruct | .NET Core 2.0 | 37.884 ns | 0.0665 ns | 0.0622 ns | 37.899 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 2.2 | 37.016 ns | 0.0747 ns | 0.0662 ns | 37.032 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 3.0 | 38.442 ns | 0.4131 ns | 0.3662 ns | 38.531 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                     From_ParentStruct |        net461 | 40.327 ns | 0.0267 ns | 0.0250 ns | 40.326 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct |        net472 | 38.451 ns | 0.0656 ns | 0.0613 ns | 38.441 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_ParentStruct_AsObject | .NET Core 2.0 | 14.548 ns | 0.0252 ns | 0.0211 ns | 14.546 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 2.2 | 14.378 ns | 0.0239 ns | 0.0223 ns | 14.371 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 3.0 | 13.460 ns | 0.2827 ns | 0.2777 ns | 13.622 ns |  0.92 |    0.02 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net461 | 15.078 ns | 0.0171 ns | 0.0152 ns | 15.077 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net472 | 15.197 ns | 0.0757 ns | 0.0708 ns | 15.200 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.0 | 39.558 ns | 0.0919 ns | 0.0767 ns | 39.553 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.2 | 36.901 ns | 0.0394 ns | 0.0329 ns | 36.903 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 3.0 | 34.214 ns | 0.0322 ns | 0.0285 ns | 34.214 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue |        net461 | 38.814 ns | 0.1245 ns | 0.1164 ns | 38.848 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue |        net472 | 40.564 ns | 0.0434 ns | 0.0406 ns | 40.573 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 14.738 ns | 0.0264 ns | 0.0247 ns | 14.735 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 14.441 ns | 0.0138 ns | 0.0115 ns | 14.439 ns |  0.98 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 13.087 ns | 0.0184 ns | 0.0172 ns | 13.083 ns |  0.89 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net461 | 14.899 ns | 0.0496 ns | 0.0464 ns | 14.890 ns |  1.01 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net472 | 15.263 ns | 0.0112 ns | 0.0094 ns | 15.263 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.0 | 38.148 ns | 0.0502 ns | 0.0445 ns | 38.146 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.2 | 40.118 ns | 0.0589 ns | 0.0551 ns | 40.106 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 3.0 | 37.613 ns | 0.7648 ns | 1.2350 ns | 38.000 ns |  0.97 |    0.05 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net461 | 38.788 ns | 0.0308 ns | 0.0288 ns | 38.792 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net472 | 39.196 ns | 0.0736 ns | 0.0653 ns | 39.176 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.140 ns | 0.0170 ns | 0.0159 ns | 13.138 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.266 ns | 0.0098 ns | 0.0087 ns | 13.265 ns |  1.01 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.754 ns | 0.1311 ns | 0.1226 ns | 11.804 ns |  0.89 |    0.01 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net461 | 13.293 ns | 0.0117 ns | 0.0104 ns | 13.293 ns |  1.01 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net472 | 13.164 ns | 0.0123 ns | 0.0109 ns | 13.162 ns |  1.00 |    0.00 |      - |     - |     - |         - |

Benchmarks with issues:
  ConvertTo_Bool.From_Char_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_Bool.From_Char_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_Bool.From_Char_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_Bool.From_Char_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_Bool.From_Char_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_Bool.From_Char_Nullable_WithValue_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_Bool.From_Char_Nullable_WithValue_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_Bool.From_Char_Nullable_WithValue_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_Bool.From_Char_Nullable_WithValue_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_Bool.From_Char_Nullable_WithValue_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_Bool.From_DateTime_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_Bool.From_DateTime_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_Bool.From_DateTime_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_Bool.From_DateTime_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_Bool.From_DateTime_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_Bool.From_DateTime_Nullable_WithValue_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_Bool.From_DateTime_Nullable_WithValue_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_Bool.From_DateTime_Nullable_WithValue_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_Bool.From_DateTime_Nullable_WithValue_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_Bool.From_DateTime_Nullable_WithValue_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_Bool.From_String_Empty_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_Bool.From_String_Empty_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_Bool.From_String_Empty_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_Bool.From_String_Empty_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_Bool.From_String_Empty_AsObject: Job-PJAXXB(Toolchain=net472)
