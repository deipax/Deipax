
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
                                             From_Bool | .NET Core 2.0 |  28.351 ns | 0.0290 ns | 0.0271 ns |  28.349 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 2.2 |  25.610 ns | 0.0376 ns | 0.0333 ns |  25.616 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 3.0 |  19.162 ns | 0.0415 ns | 0.0368 ns |  19.158 ns |  0.68 |    0.00 |      - |     - |     - |         - |
                                             From_Bool |        net461 |  27.314 ns | 0.0567 ns | 0.0502 ns |  27.303 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                             From_Bool |        net472 |  27.351 ns | 0.0371 ns | 0.0347 ns |  27.350 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                    From_Bool_AsObject | .NET Core 2.0 |  35.051 ns | 0.0602 ns | 0.0563 ns |  35.047 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 2.2 |  34.010 ns | 0.1435 ns | 0.1272 ns |  34.039 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 3.0 |  30.635 ns | 0.0709 ns | 0.0628 ns |  30.655 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net461 |  43.787 ns | 0.1757 ns | 0.1467 ns |  43.743 ns |  1.25 |    0.01 |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net472 |  43.852 ns | 0.0416 ns | 0.0348 ns |  43.851 ns |  1.25 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                          From_Bool_Nullable_WithValue | .NET Core 2.0 |  26.204 ns | 0.0231 ns | 0.0216 ns |  26.207 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 2.2 |  26.601 ns | 0.0521 ns | 0.0462 ns |  26.602 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 3.0 |  18.299 ns | 0.1587 ns | 0.1484 ns |  18.283 ns |  0.70 |    0.01 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net461 |  28.327 ns | 0.0555 ns | 0.0492 ns |  28.338 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net472 |  28.330 ns | 0.3088 ns | 0.2888 ns |  28.188 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.0 |  35.040 ns | 0.0585 ns | 0.0489 ns |  35.045 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.2 |  33.567 ns | 0.0599 ns | 0.0531 ns |  33.564 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 3.0 |  30.842 ns | 0.0400 ns | 0.0374 ns |  30.846 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net461 |  45.022 ns | 0.1004 ns | 0.0940 ns |  45.027 ns |  1.28 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net472 |  45.263 ns | 0.0585 ns | 0.0548 ns |  45.257 ns |  1.29 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                            From_Bool_Nullable_NoValue | .NET Core 2.0 |  12.125 ns | 0.0259 ns | 0.0230 ns |  12.122 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 2.2 |  12.564 ns | 0.0235 ns | 0.0208 ns |  12.567 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 3.0 |   9.588 ns | 0.0239 ns | 0.0212 ns |   9.586 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net461 |  13.010 ns | 0.0162 ns | 0.0136 ns |  13.009 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net472 |  13.010 ns | 0.0348 ns | 0.0326 ns |  13.006 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.0 |  13.072 ns | 0.0241 ns | 0.0214 ns |  13.073 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.2 |  11.684 ns | 0.0214 ns | 0.0200 ns |  11.688 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 3.0 |  13.465 ns | 0.0580 ns | 0.0542 ns |  13.468 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net461 |  13.879 ns | 0.0243 ns | 0.0227 ns |  13.887 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net472 |  14.743 ns | 0.1715 ns | 0.1604 ns |  14.659 ns |  1.13 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                             From_Byte | .NET Core 2.0 |  26.029 ns | 0.0307 ns | 0.0287 ns |  26.029 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 2.2 |  25.154 ns | 0.0232 ns | 0.0217 ns |  25.154 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 3.0 |  17.655 ns | 0.0341 ns | 0.0303 ns |  17.647 ns |  0.68 |    0.00 |      - |     - |     - |         - |
                                             From_Byte |        net461 |  27.197 ns | 0.0514 ns | 0.0455 ns |  27.189 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                             From_Byte |        net472 |  27.117 ns | 0.0516 ns | 0.0483 ns |  27.141 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                    From_Byte_AsObject | .NET Core 2.0 |  35.293 ns | 0.0864 ns | 0.0721 ns |  35.306 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 2.2 |  33.784 ns | 0.3592 ns | 0.3360 ns |  33.906 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 3.0 |  30.916 ns | 0.0487 ns | 0.0455 ns |  30.914 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net461 |  44.311 ns | 0.1189 ns | 0.1112 ns |  44.308 ns |  1.26 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net472 |  44.682 ns | 0.0708 ns | 0.0591 ns |  44.700 ns |  1.27 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                          From_Byte_Nullable_WithValue | .NET Core 2.0 |  25.905 ns | 0.0273 ns | 0.0242 ns |  25.906 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 2.2 |  27.024 ns | 0.0805 ns | 0.0714 ns |  27.015 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 3.0 |  18.507 ns | 0.0705 ns | 0.0550 ns |  18.522 ns |  0.71 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net461 |  27.704 ns | 0.0360 ns | 0.0301 ns |  27.699 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net472 |  27.849 ns | 0.2945 ns | 0.2755 ns |  27.671 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.0 |  35.082 ns | 0.1373 ns | 0.1147 ns |  35.053 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.2 |  33.788 ns | 0.0502 ns | 0.0445 ns |  33.785 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 3.0 |  30.647 ns | 0.0458 ns | 0.0406 ns |  30.656 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net461 |  44.042 ns | 0.0731 ns | 0.0684 ns |  44.032 ns |  1.26 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net472 |  45.462 ns | 0.0324 ns | 0.0270 ns |  45.463 ns |  1.30 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                            From_Byte_Nullable_NoValue | .NET Core 2.0 |  12.127 ns | 0.0166 ns | 0.0155 ns |  12.128 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 2.2 |  11.837 ns | 0.0232 ns | 0.0193 ns |  11.831 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 3.0 |   9.807 ns | 0.0231 ns | 0.0205 ns |   9.804 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net461 |  13.009 ns | 0.0146 ns | 0.0137 ns |  13.009 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net472 |  13.081 ns | 0.0230 ns | 0.0204 ns |  13.087 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.0 |  13.311 ns | 0.0199 ns | 0.0176 ns |  13.312 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.2 |  12.155 ns | 0.0336 ns | 0.0315 ns |  12.154 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 3.0 |  13.237 ns | 0.0811 ns | 0.0758 ns |  13.264 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net461 |  13.888 ns | 0.0327 ns | 0.0273 ns |  13.895 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net472 |  14.579 ns | 0.0205 ns | 0.0182 ns |  14.581 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                             From_Char | .NET Core 2.0 |  26.450 ns | 0.0343 ns | 0.0304 ns |  26.461 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Char | .NET Core 2.2 |  27.333 ns | 0.0399 ns | 0.0354 ns |  27.338 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                             From_Char | .NET Core 3.0 |  17.347 ns | 0.0268 ns | 0.0238 ns |  17.351 ns |  0.66 |    0.00 |      - |     - |     - |         - |
                                             From_Char |        net461 |  27.390 ns | 0.0545 ns | 0.0509 ns |  27.384 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                             From_Char |        net472 |  27.176 ns | 0.0245 ns | 0.0217 ns |  27.177 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                    From_Char_AsObject | .NET Core 2.0 |  35.333 ns | 0.0562 ns | 0.0526 ns |  35.343 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 2.2 |  34.196 ns | 0.1993 ns | 0.1865 ns |  34.266 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 3.0 |  30.769 ns | 0.0667 ns | 0.0624 ns |  30.778 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject |        net461 |  43.797 ns | 0.0681 ns | 0.0569 ns |  43.796 ns |  1.24 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject |        net472 |  44.924 ns | 0.0828 ns | 0.0734 ns |  44.926 ns |  1.27 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                          From_Char_Nullable_WithValue | .NET Core 2.0 |  25.743 ns | 0.1730 ns | 0.1618 ns |  25.667 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 2.2 |  27.792 ns | 0.0709 ns | 0.0629 ns |  27.780 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 3.0 |  20.142 ns | 0.1418 ns | 0.1327 ns |  20.101 ns |  0.78 |    0.01 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net461 |  29.715 ns | 0.0725 ns | 0.0678 ns |  29.729 ns |  1.15 |    0.01 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net472 |  28.375 ns | 0.0552 ns | 0.0517 ns |  28.368 ns |  1.10 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.0 |  35.303 ns | 0.0581 ns | 0.0515 ns |  35.312 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.2 |  33.732 ns | 0.0806 ns | 0.0715 ns |  33.726 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 3.0 |  30.857 ns | 0.0809 ns | 0.0757 ns |  30.824 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net461 |  44.164 ns | 0.0640 ns | 0.0599 ns |  44.179 ns |  1.25 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net472 |  44.004 ns | 0.0550 ns | 0.0488 ns |  44.012 ns |  1.25 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                            From_Char_Nullable_NoValue | .NET Core 2.0 |  12.224 ns | 0.1329 ns | 0.1244 ns |  12.132 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 2.2 |  10.767 ns | 0.0628 ns | 0.0588 ns |  10.771 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 3.0 |   9.894 ns | 0.0501 ns | 0.0418 ns |   9.904 ns |  0.81 |    0.01 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net461 |  14.396 ns | 0.0704 ns | 0.0659 ns |  14.401 ns |  1.18 |    0.01 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net472 |  13.021 ns | 0.0120 ns | 0.0112 ns |  13.021 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.0 |  13.030 ns | 0.0212 ns | 0.0188 ns |  13.026 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.2 |  11.686 ns | 0.0149 ns | 0.0132 ns |  11.687 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 3.0 |  13.093 ns | 0.0302 ns | 0.0282 ns |  13.105 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net461 |  13.837 ns | 0.0328 ns | 0.0290 ns |  13.839 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net472 |  14.569 ns | 0.0299 ns | 0.0250 ns |  14.570 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                         From_DateTime | .NET Core 2.0 |  27.279 ns | 0.0409 ns | 0.0383 ns |  27.282 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 2.2 |  25.546 ns | 0.0315 ns | 0.0294 ns |  25.550 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 3.0 |  13.204 ns | 0.2799 ns | 0.3540 ns |  13.053 ns |  0.49 |    0.01 |      - |     - |     - |         - |
                                         From_DateTime |        net461 |  26.981 ns | 0.1703 ns | 0.1510 ns |  26.958 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                                         From_DateTime |        net472 |  29.466 ns | 0.1020 ns | 0.0852 ns |  29.466 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                From_DateTime_AsObject | .NET Core 2.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 2.2 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 3.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net461 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net472 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                      From_DateTime_Nullable_WithValue | .NET Core 2.0 |  27.206 ns | 0.0780 ns | 0.0652 ns |  27.193 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 2.2 |  28.477 ns | 0.0583 ns | 0.0516 ns |  28.465 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 3.0 |  14.245 ns | 0.0295 ns | 0.0276 ns |  14.251 ns |  0.52 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net461 |  31.226 ns | 0.2241 ns | 0.2096 ns |  31.138 ns |  1.15 |    0.01 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net472 |  29.450 ns | 0.0838 ns | 0.0743 ns |  29.437 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.2 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 3.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net461 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net472 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                        From_DateTime_Nullable_NoValue | .NET Core 2.0 |  12.609 ns | 0.1158 ns | 0.1084 ns |  12.548 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 2.2 |  16.565 ns | 0.0693 ns | 0.0649 ns |  16.578 ns |  1.31 |    0.01 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 3.0 |  10.765 ns | 0.0190 ns | 0.0169 ns |  10.765 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net461 |  19.922 ns | 0.0553 ns | 0.0517 ns |  19.926 ns |  1.58 |    0.01 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net472 |  19.453 ns | 0.0295 ns | 0.0276 ns |  19.449 ns |  1.54 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.0 |  13.889 ns | 0.0291 ns | 0.0273 ns |  13.887 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.2 |  11.681 ns | 0.0315 ns | 0.0295 ns |  11.679 ns |  0.84 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 3.0 |  13.882 ns | 1.1886 ns | 1.4149 ns |  13.101 ns |  1.02 |    0.11 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net461 |  14.607 ns | 0.0891 ns | 0.0790 ns |  14.579 ns |  1.05 |    0.01 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net472 |  14.680 ns | 0.0240 ns | 0.0224 ns |  14.684 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                          From_Decimal | .NET Core 2.0 |  37.575 ns | 0.0711 ns | 0.0665 ns |  37.576 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 2.2 |  36.505 ns | 0.0547 ns | 0.0512 ns |  36.522 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 3.0 |  23.352 ns | 0.4888 ns | 0.8939 ns |  22.828 ns |  0.65 |    0.02 |      - |     - |     - |         - |
                                          From_Decimal |        net461 |  35.856 ns | 0.1664 ns | 0.1557 ns |  35.899 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal |        net472 |  34.917 ns | 0.0554 ns | 0.0518 ns |  34.933 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                 From_Decimal_AsObject | .NET Core 2.0 |  47.177 ns | 0.4160 ns | 0.3891 ns |  47.414 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 2.2 |  44.908 ns | 0.1165 ns | 0.1090 ns |  44.909 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 3.0 |  34.867 ns | 0.0772 ns | 0.0684 ns |  34.874 ns |  0.74 |    0.01 |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net461 |  50.573 ns | 0.1049 ns | 0.0981 ns |  50.577 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net472 |  51.489 ns | 0.0674 ns | 0.0563 ns |  51.499 ns |  1.09 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                       From_Decimal_Nullable_WithValue | .NET Core 2.0 |  43.189 ns | 0.0471 ns | 0.0440 ns |  43.195 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 2.2 |  41.299 ns | 0.2021 ns | 0.1891 ns |  41.224 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 3.0 |  26.935 ns | 0.1288 ns | 0.1142 ns |  26.975 ns |  0.62 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net461 |  39.025 ns | 0.0857 ns | 0.0759 ns |  39.018 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net472 |  40.656 ns | 0.0540 ns | 0.0505 ns |  40.669 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.0 |  46.667 ns | 0.0947 ns | 0.0886 ns |  46.690 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.2 |  44.687 ns | 0.0808 ns | 0.0717 ns |  44.694 ns |  0.96 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 3.0 |  35.201 ns | 0.1869 ns | 0.1749 ns |  35.290 ns |  0.75 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net461 |  51.123 ns | 0.1743 ns | 0.1630 ns |  51.156 ns |  1.10 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net472 |  53.014 ns | 0.0874 ns | 0.0775 ns |  53.011 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                         From_Decimal_Nullable_NoValue | .NET Core 2.0 |  18.059 ns | 0.1815 ns | 0.1698 ns |  17.951 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 2.2 |  16.262 ns | 0.0337 ns | 0.0298 ns |  16.257 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 3.0 |  10.547 ns | 0.0154 ns | 0.0144 ns |  10.545 ns |  0.58 |    0.01 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net461 |  20.250 ns | 0.0684 ns | 0.0640 ns |  20.240 ns |  1.12 |    0.01 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net472 |  20.127 ns | 0.0203 ns | 0.0190 ns |  20.131 ns |  1.11 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.0 |  15.120 ns | 0.0525 ns | 0.0491 ns |  15.102 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.2 |  11.694 ns | 0.0598 ns | 0.0560 ns |  11.674 ns |  0.77 |    0.01 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 3.0 |  13.372 ns | 0.5112 ns | 0.5249 ns |  13.100 ns |  0.89 |    0.04 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net461 |  13.844 ns | 0.0247 ns | 0.0219 ns |  13.843 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net472 |  13.842 ns | 0.0321 ns | 0.0301 ns |  13.849 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                           From_Double | .NET Core 2.0 |  28.314 ns | 0.0466 ns | 0.0413 ns |  28.321 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 2.2 |  26.876 ns | 0.0370 ns | 0.0346 ns |  26.875 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 3.0 |  20.183 ns | 0.1321 ns | 0.1236 ns |  20.125 ns |  0.71 |    0.00 |      - |     - |     - |         - |
                                           From_Double |        net461 |  30.567 ns | 0.0789 ns | 0.0738 ns |  30.573 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                           From_Double |        net472 |  29.548 ns | 0.0537 ns | 0.0476 ns |  29.536 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                  From_Double_AsObject | .NET Core 2.0 |  38.064 ns | 0.2583 ns | 0.2416 ns |  38.140 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 2.2 |  34.877 ns | 0.0668 ns | 0.0592 ns |  34.876 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 3.0 |  32.586 ns | 0.0531 ns | 0.0471 ns |  32.583 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject |        net461 |  45.626 ns | 0.0846 ns | 0.0750 ns |  45.636 ns |  1.20 |    0.01 |      - |     - |     - |         - |
                                  From_Double_AsObject |        net472 |  46.670 ns | 0.0618 ns | 0.0548 ns |  46.673 ns |  1.22 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                        From_Double_Nullable_WithValue | .NET Core 2.0 |  30.622 ns | 0.0523 ns | 0.0463 ns |  30.630 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 2.2 |  29.905 ns | 0.0785 ns | 0.0734 ns |  29.885 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 3.0 |  22.216 ns | 0.4679 ns | 0.7687 ns |  22.679 ns |  0.70 |    0.02 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net461 |  30.463 ns | 0.0601 ns | 0.0533 ns |  30.488 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net472 |  32.291 ns | 0.0332 ns | 0.0294 ns |  32.286 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.0 |  36.697 ns | 0.0400 ns | 0.0374 ns |  36.684 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.2 |  34.783 ns | 0.0780 ns | 0.0730 ns |  34.767 ns |  0.95 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 3.0 |  32.870 ns | 0.2376 ns | 0.2222 ns |  32.950 ns |  0.90 |    0.01 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net461 |  46.259 ns | 0.2620 ns | 0.2322 ns |  46.335 ns |  1.26 |    0.01 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net472 |  47.347 ns | 0.0776 ns | 0.0726 ns |  47.363 ns |  1.29 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                          From_Double_Nullable_NoValue | .NET Core 2.0 |  12.460 ns | 0.1202 ns | 0.1124 ns |  12.412 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 2.2 |  13.011 ns | 0.0403 ns | 0.0337 ns |  13.014 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 3.0 |  10.262 ns | 0.0119 ns | 0.0111 ns |  10.261 ns |  0.82 |    0.01 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net461 |  14.663 ns | 0.0337 ns | 0.0315 ns |  14.669 ns |  1.18 |    0.01 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net472 |  13.681 ns | 0.0362 ns | 0.0338 ns |  13.687 ns |  1.10 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.0 |  13.069 ns | 0.0424 ns | 0.0354 ns |  13.059 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.2 |  11.685 ns | 0.0388 ns | 0.0324 ns |  11.681 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 3.0 |  13.056 ns | 0.0320 ns | 0.0267 ns |  13.061 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net461 |  13.850 ns | 0.0320 ns | 0.0267 ns |  13.847 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net472 |  14.060 ns | 0.0986 ns | 0.0874 ns |  14.080 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                            From_Short | .NET Core 2.0 |  26.018 ns | 0.0355 ns | 0.0332 ns |  26.012 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 2.2 |  25.103 ns | 0.0569 ns | 0.0504 ns |  25.109 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 3.0 |  17.527 ns | 0.0348 ns | 0.0309 ns |  17.531 ns |  0.67 |    0.00 |      - |     - |     - |         - |
                                            From_Short |        net461 |  30.063 ns | 0.0371 ns | 0.0329 ns |  30.057 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                                            From_Short |        net472 |  27.477 ns | 0.1251 ns | 0.1170 ns |  27.410 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                   From_Short_AsObject | .NET Core 2.0 |  35.943 ns | 0.1891 ns | 0.1769 ns |  35.981 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 2.2 |  34.034 ns | 0.2221 ns | 0.2077 ns |  33.961 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 3.0 |  32.024 ns | 0.5491 ns | 0.5136 ns |  32.219 ns |  0.89 |    0.02 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net461 |  44.281 ns | 0.0749 ns | 0.0664 ns |  44.263 ns |  1.23 |    0.01 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net472 |  45.346 ns | 0.0895 ns | 0.0837 ns |  45.326 ns |  1.26 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                         From_Short_Nullable_WithValue | .NET Core 2.0 |  25.574 ns | 0.0438 ns | 0.0388 ns |  25.564 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 2.2 |  26.992 ns | 0.0914 ns | 0.0855 ns |  26.980 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 3.0 |  18.333 ns | 0.0431 ns | 0.0360 ns |  18.346 ns |  0.72 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net461 |  27.817 ns | 0.0453 ns | 0.0423 ns |  27.811 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net472 |  30.381 ns | 0.0674 ns | 0.0630 ns |  30.374 ns |  1.19 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.0 |  37.420 ns | 0.0816 ns | 0.0682 ns |  37.420 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.2 |  33.235 ns | 0.0518 ns | 0.0433 ns |  33.242 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 3.0 |  30.557 ns | 0.0480 ns | 0.0425 ns |  30.569 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net461 |  44.515 ns | 0.0766 ns | 0.0640 ns |  44.525 ns |  1.19 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net472 |  45.155 ns | 0.2207 ns | 0.2064 ns |  45.152 ns |  1.21 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                           From_Short_Nullable_NoValue | .NET Core 2.0 |  12.292 ns | 0.1141 ns | 0.1067 ns |  12.355 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 2.2 |  10.665 ns | 0.0872 ns | 0.0816 ns |  10.639 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 3.0 |   9.810 ns | 0.0233 ns | 0.0195 ns |   9.811 ns |  0.80 |    0.01 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net461 |  13.213 ns | 0.0281 ns | 0.0263 ns |  13.215 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net472 |  13.083 ns | 0.0170 ns | 0.0159 ns |  13.077 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.0 |  13.531 ns | 0.0562 ns | 0.0525 ns |  13.531 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.2 |  11.722 ns | 0.0114 ns | 0.0101 ns |  11.722 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 3.0 |  13.193 ns | 0.0169 ns | 0.0150 ns |  13.190 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net461 |  13.870 ns | 0.0320 ns | 0.0284 ns |  13.878 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net472 |  14.143 ns | 0.0849 ns | 0.0752 ns |  14.163 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                              From_Int | .NET Core 2.0 |  24.683 ns | 0.0231 ns | 0.0205 ns |  24.681 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 2.2 |  23.635 ns | 0.0425 ns | 0.0377 ns |  23.631 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 3.0 |  17.124 ns | 0.0402 ns | 0.0357 ns |  17.121 ns |  0.69 |    0.00 |      - |     - |     - |         - |
                                              From_Int |        net461 |  29.289 ns | 0.1016 ns | 0.0950 ns |  29.289 ns |  1.19 |    0.00 |      - |     - |     - |         - |
                                              From_Int |        net472 |  27.424 ns | 0.0733 ns | 0.0650 ns |  27.408 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                     From_Int_AsObject | .NET Core 2.0 |  39.175 ns | 0.3661 ns | 0.2858 ns |  39.298 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 2.2 |  41.578 ns | 0.3599 ns | 0.3366 ns |  41.422 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 3.0 |  39.711 ns | 0.0749 ns | 0.0701 ns |  39.693 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net461 |  54.138 ns | 0.2443 ns | 0.2166 ns |  54.197 ns |  1.38 |    0.01 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net472 |  52.881 ns | 0.0998 ns | 0.0885 ns |  52.877 ns |  1.35 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                           From_Int_Nullable_WithValue | .NET Core 2.0 |  24.193 ns | 0.0342 ns | 0.0286 ns |  24.195 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 2.2 |  24.958 ns | 0.0233 ns | 0.0195 ns |  24.957 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 3.0 |  18.027 ns | 0.0970 ns | 0.0758 ns |  18.060 ns |  0.75 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net461 |  27.794 ns | 0.0424 ns | 0.0354 ns |  27.783 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net472 |  28.540 ns | 0.2043 ns | 0.1911 ns |  28.613 ns |  1.18 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.0 |  40.058 ns | 0.0447 ns | 0.0418 ns |  40.062 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.2 |  41.288 ns | 0.0354 ns | 0.0331 ns |  41.293 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 3.0 |  39.578 ns | 0.0239 ns | 0.0200 ns |  39.568 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net461 |  56.588 ns | 0.1178 ns | 0.1045 ns |  56.603 ns |  1.41 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net472 |  53.153 ns | 0.2102 ns | 0.1966 ns |  53.049 ns |  1.33 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                             From_Int_Nullable_NoValue | .NET Core 2.0 |  12.214 ns | 0.1169 ns | 0.1094 ns |  12.143 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 2.2 |  10.581 ns | 0.0129 ns | 0.0101 ns |  10.582 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 3.0 |   9.807 ns | 0.0227 ns | 0.0212 ns |   9.811 ns |  0.80 |    0.01 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net461 |  13.001 ns | 0.0376 ns | 0.0333 ns |  13.004 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net472 |  13.077 ns | 0.0152 ns | 0.0135 ns |  13.080 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.0 |  13.043 ns | 0.0200 ns | 0.0156 ns |  13.043 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.2 |  12.067 ns | 0.0190 ns | 0.0178 ns |  12.069 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 3.0 |  13.062 ns | 0.0458 ns | 0.0406 ns |  13.048 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net461 |  13.865 ns | 0.0380 ns | 0.0297 ns |  13.867 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net472 |  15.290 ns | 0.1204 ns | 0.1126 ns |  15.341 ns |  1.17 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                             From_Long | .NET Core 2.0 |  29.504 ns | 0.0478 ns | 0.0447 ns |  29.493 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Long | .NET Core 2.2 |  27.519 ns | 0.0374 ns | 0.0350 ns |  27.531 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                             From_Long | .NET Core 3.0 |  18.212 ns | 0.0159 ns | 0.0124 ns |  18.213 ns |  0.62 |    0.00 |      - |     - |     - |         - |
                                             From_Long |        net461 |  28.548 ns | 0.2109 ns | 0.1973 ns |  28.616 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                                             From_Long |        net472 |  28.015 ns | 0.1154 ns | 0.1079 ns |  27.964 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                    From_Long_AsObject | .NET Core 2.0 |  36.348 ns | 0.4557 ns | 0.4262 ns |  36.479 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 2.2 |  34.055 ns | 0.0849 ns | 0.0709 ns |  34.056 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 3.0 |  31.795 ns | 0.1833 ns | 0.1714 ns |  31.849 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net461 |  44.833 ns | 0.0705 ns | 0.0625 ns |  44.831 ns |  1.23 |    0.02 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net472 |  46.444 ns | 0.0569 ns | 0.0533 ns |  46.443 ns |  1.28 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                          From_Long_Nullable_WithValue | .NET Core 2.0 |  30.996 ns | 0.0830 ns | 0.0736 ns |  30.975 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 2.2 |  33.082 ns | 0.0527 ns | 0.0493 ns |  33.079 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 3.0 |  19.320 ns | 0.0298 ns | 0.0249 ns |  19.316 ns |  0.62 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net461 |  30.722 ns | 0.0385 ns | 0.0342 ns |  30.720 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net472 |  31.713 ns | 0.2082 ns | 0.1947 ns |  31.789 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.0 |  37.868 ns | 0.0693 ns | 0.0648 ns |  37.860 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.2 |  35.300 ns | 0.0676 ns | 0.0599 ns |  35.288 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 3.0 |  31.422 ns | 0.0831 ns | 0.0777 ns |  31.419 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net461 |  44.861 ns | 0.0965 ns | 0.0903 ns |  44.864 ns |  1.18 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net472 |  46.509 ns | 0.0595 ns | 0.0497 ns |  46.499 ns |  1.23 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                            From_Long_Nullable_NoValue | .NET Core 2.0 |  13.490 ns | 0.1173 ns | 0.1097 ns |  13.429 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 2.2 |  11.483 ns | 0.0196 ns | 0.0153 ns |  11.488 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 3.0 |  10.378 ns | 0.0680 ns | 0.0636 ns |  10.413 ns |  0.77 |    0.01 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net461 |  13.744 ns | 0.0378 ns | 0.0335 ns |  13.741 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net472 |  13.710 ns | 0.0202 ns | 0.0169 ns |  13.713 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.0 |  14.083 ns | 0.0839 ns | 0.0785 ns |  14.101 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.2 |  11.683 ns | 0.0174 ns | 0.0154 ns |  11.686 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 3.0 |  13.052 ns | 0.0278 ns | 0.0246 ns |  13.045 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net461 |  14.118 ns | 0.0164 ns | 0.0154 ns |  14.112 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net472 |  14.784 ns | 0.1023 ns | 0.0957 ns |  14.829 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                            From_SByte | .NET Core 2.0 |  27.424 ns | 0.0533 ns | 0.0499 ns |  27.414 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 2.2 |  25.500 ns | 0.0281 ns | 0.0263 ns |  25.497 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 3.0 |  17.726 ns | 0.0373 ns | 0.0311 ns |  17.730 ns |  0.65 |    0.00 |      - |     - |     - |         - |
                                            From_SByte |        net461 |  27.235 ns | 0.0388 ns | 0.0344 ns |  27.243 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                            From_SByte |        net472 |  27.362 ns | 0.1224 ns | 0.1145 ns |  27.309 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                   From_SByte_AsObject | .NET Core 2.0 |  40.942 ns | 0.3172 ns | 0.2967 ns |  41.084 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 2.2 |  33.862 ns | 0.0546 ns | 0.0426 ns |  33.861 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 3.0 |  30.876 ns | 0.2623 ns | 0.2453 ns |  30.940 ns |  0.75 |    0.01 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net461 |  44.975 ns | 0.1129 ns | 0.0882 ns |  45.000 ns |  1.10 |    0.01 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net472 |  44.747 ns | 0.0756 ns | 0.0707 ns |  44.728 ns |  1.09 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                         From_SByte_Nullable_WithValue | .NET Core 2.0 |  25.657 ns | 0.0169 ns | 0.0150 ns |  25.655 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 2.2 |  27.811 ns | 0.0485 ns | 0.0454 ns |  27.822 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 3.0 |  18.349 ns | 0.0467 ns | 0.0414 ns |  18.341 ns |  0.72 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net461 |  27.752 ns | 0.0455 ns | 0.0403 ns |  27.761 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net472 |  28.070 ns | 0.1232 ns | 0.1153 ns |  28.100 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.0 |  35.301 ns | 0.0462 ns | 0.0410 ns |  35.292 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.2 |  33.398 ns | 0.0421 ns | 0.0394 ns |  33.414 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 3.0 |  30.530 ns | 0.0328 ns | 0.0307 ns |  30.529 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net461 |  45.610 ns | 0.0984 ns | 0.0920 ns |  45.605 ns |  1.29 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net472 |  45.761 ns | 0.0695 ns | 0.0616 ns |  45.760 ns |  1.30 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                           From_SByte_Nullable_NoValue | .NET Core 2.0 |  12.312 ns | 0.1061 ns | 0.0993 ns |  12.353 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 2.2 |  11.867 ns | 0.1498 ns | 0.1401 ns |  11.908 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 3.0 |   9.882 ns | 0.0677 ns | 0.0600 ns |   9.911 ns |  0.80 |    0.01 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net461 |  13.034 ns | 0.0314 ns | 0.0293 ns |  13.024 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net472 |  13.973 ns | 0.0211 ns | 0.0187 ns |  13.974 ns |  1.14 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.0 |  13.298 ns | 0.0277 ns | 0.0231 ns |  13.289 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.2 |  11.831 ns | 0.0195 ns | 0.0173 ns |  11.829 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 3.0 |  14.918 ns | 1.4459 ns | 2.6073 ns |  13.506 ns |  1.36 |    0.20 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net461 |  13.855 ns | 0.0441 ns | 0.0368 ns |  13.851 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net472 |  16.723 ns | 0.0705 ns | 0.0589 ns |  16.727 ns |  1.26 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                            From_Float | .NET Core 2.0 |  28.251 ns | 0.0348 ns | 0.0308 ns |  28.248 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 2.2 |  27.698 ns | 0.1651 ns | 0.1544 ns |  27.674 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                                            From_Float | .NET Core 3.0 |  19.931 ns | 0.0392 ns | 0.0347 ns |  19.939 ns |  0.71 |    0.00 |      - |     - |     - |         - |
                                            From_Float |        net461 |  29.764 ns | 0.0873 ns | 0.0774 ns |  29.765 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                            From_Float |        net472 |  29.725 ns | 0.0658 ns | 0.0514 ns |  29.711 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                   From_Float_AsObject | .NET Core 2.0 |  38.327 ns | 0.0427 ns | 0.0399 ns |  38.316 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 2.2 |  34.997 ns | 0.0838 ns | 0.0784 ns |  35.017 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 3.0 |  33.112 ns | 0.2436 ns | 0.2279 ns |  33.205 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                                   From_Float_AsObject |        net461 |  46.418 ns | 0.2997 ns | 0.2804 ns |  46.279 ns |  1.21 |    0.01 |      - |     - |     - |         - |
                                   From_Float_AsObject |        net472 |  47.594 ns | 0.0886 ns | 0.0829 ns |  47.591 ns |  1.24 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                         From_Float_Nullable_WithValue | .NET Core 2.0 |  28.450 ns | 0.0486 ns | 0.0455 ns |  28.444 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 2.2 |  28.281 ns | 0.2720 ns | 0.2544 ns |  28.101 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 3.0 |  20.396 ns | 0.0387 ns | 0.0302 ns |  20.399 ns |  0.72 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net461 |  33.311 ns | 0.0378 ns | 0.0335 ns |  33.312 ns |  1.17 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net472 |  34.358 ns | 0.2703 ns | 0.2529 ns |  34.276 ns |  1.21 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.0 |  36.711 ns | 0.0710 ns | 0.0664 ns |  36.711 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.2 |  37.473 ns | 0.0577 ns | 0.0482 ns |  37.482 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 3.0 |  32.808 ns | 0.0303 ns | 0.0269 ns |  32.807 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net461 |  46.390 ns | 0.0766 ns | 0.0717 ns |  46.385 ns |  1.26 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net472 |  47.149 ns | 0.1821 ns | 0.1703 ns |  47.099 ns |  1.28 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                           From_Float_Nullable_NoValue | .NET Core 2.0 |  12.121 ns | 0.0143 ns | 0.0133 ns |  12.123 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 2.2 |  10.731 ns | 0.0191 ns | 0.0178 ns |  10.733 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 3.0 |   9.874 ns | 0.0911 ns | 0.0852 ns |   9.834 ns |  0.81 |    0.01 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net461 |  12.820 ns | 0.0634 ns | 0.0593 ns |  12.795 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net472 |  12.791 ns | 0.0174 ns | 0.0162 ns |  12.790 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.0 |  13.034 ns | 0.0206 ns | 0.0192 ns |  13.033 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.2 |  11.736 ns | 0.0182 ns | 0.0152 ns |  11.733 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 3.0 |  13.219 ns | 0.1562 ns | 0.1461 ns |  13.300 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net461 |  13.885 ns | 0.0315 ns | 0.0295 ns |  13.888 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net472 |  14.689 ns | 0.1344 ns | 0.1258 ns |  14.680 ns |  1.13 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                           From_String | .NET Core 2.0 |  34.829 ns | 0.0585 ns | 0.0518 ns |  34.833 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 2.2 |  33.563 ns | 0.0386 ns | 0.0323 ns |  33.561 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 3.0 |  32.388 ns | 0.5514 ns | 0.4888 ns |  32.517 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                                           From_String |        net461 |  45.967 ns | 0.1028 ns | 0.0962 ns |  45.959 ns |  1.32 |    0.00 |      - |     - |     - |         - |
                                           From_String |        net472 |  44.512 ns | 0.1861 ns | 0.1650 ns |  44.467 ns |  1.28 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                  From_String_AsObject | .NET Core 2.0 |  44.583 ns | 0.0719 ns | 0.0638 ns |  44.596 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 2.2 |  40.049 ns | 0.0498 ns | 0.0465 ns |  40.046 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 3.0 |  35.187 ns | 0.2443 ns | 0.2286 ns |  35.262 ns |  0.79 |    0.01 |      - |     - |     - |         - |
                                  From_String_AsObject |        net461 |  52.599 ns | 0.2483 ns | 0.2201 ns |  52.572 ns |  1.18 |    0.01 |      - |     - |     - |         - |
                                  From_String_AsObject |        net472 |  50.046 ns | 0.0639 ns | 0.0567 ns |  50.045 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                      From_String_Null | .NET Core 2.0 |  12.844 ns | 0.0163 ns | 0.0152 ns |  12.841 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 2.2 |  12.781 ns | 0.0191 ns | 0.0170 ns |  12.784 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 3.0 |  12.599 ns | 0.0206 ns | 0.0172 ns |  12.596 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null |        net461 |  13.256 ns | 0.0343 ns | 0.0286 ns |  13.264 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null |        net472 |  13.273 ns | 0.0336 ns | 0.0298 ns |  13.270 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                             From_String_Null_AsObject | .NET Core 2.0 |  14.505 ns | 0.0199 ns | 0.0186 ns |  14.507 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 2.2 |  11.977 ns | 0.0090 ns | 0.0079 ns |  11.977 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 3.0 |  12.995 ns | 0.0179 ns | 0.0150 ns |  12.995 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net461 |  13.844 ns | 0.0401 ns | 0.0335 ns |  13.852 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net472 |  14.573 ns | 0.0326 ns | 0.0289 ns |  14.566 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                     From_String_Empty | .NET Core 2.0 |  12.820 ns | 0.0140 ns | 0.0124 ns |  12.823 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 2.2 |  11.193 ns | 0.0113 ns | 0.0100 ns |  11.196 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 3.0 |  12.746 ns | 0.0607 ns | 0.0568 ns |  12.749 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty |        net461 |  13.484 ns | 0.0177 ns | 0.0165 ns |  13.486 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty |        net472 |  13.945 ns | 0.0258 ns | 0.0242 ns |  13.937 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                            From_String_Empty_AsObject | .NET Core 2.0 |  20.933 ns | 0.0315 ns | 0.0295 ns |  20.943 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 2.2 |  18.566 ns | 0.0479 ns | 0.0425 ns |  18.559 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 3.0 |  18.176 ns | 0.0611 ns | 0.0477 ns |  18.191 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net461 |  24.146 ns | 0.0310 ns | 0.0290 ns |  24.146 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net472 |  24.742 ns | 0.0531 ns | 0.0471 ns |  24.743 ns |  1.18 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                           From_UShort | .NET Core 2.0 |  26.539 ns | 0.0251 ns | 0.0223 ns |  26.543 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 2.2 |  25.288 ns | 0.0440 ns | 0.0367 ns |  25.285 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 3.0 |  17.261 ns | 0.0265 ns | 0.0235 ns |  17.266 ns |  0.65 |    0.00 |      - |     - |     - |         - |
                                           From_UShort |        net461 |  29.899 ns | 0.0330 ns | 0.0293 ns |  29.896 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                           From_UShort |        net472 |  27.623 ns | 0.0906 ns | 0.0847 ns |  27.594 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                  From_UShort_AsObject | .NET Core 2.0 |  35.066 ns | 0.1598 ns | 0.1417 ns |  35.057 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 2.2 |  33.403 ns | 0.0524 ns | 0.0464 ns |  33.390 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 3.0 |  30.955 ns | 0.3467 ns | 0.3243 ns |  31.054 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net461 |  46.834 ns | 0.1078 ns | 0.1008 ns |  46.858 ns |  1.34 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net472 |  45.669 ns | 0.0803 ns | 0.0751 ns |  45.669 ns |  1.30 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                        From_UShort_Nullable_WithValue | .NET Core 2.0 |  25.633 ns | 0.0357 ns | 0.0334 ns |  25.627 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 2.2 |  27.497 ns | 0.0444 ns | 0.0371 ns |  27.490 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 3.0 |  18.239 ns | 0.0353 ns | 0.0295 ns |  18.242 ns |  0.71 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net461 |  28.210 ns | 0.0306 ns | 0.0286 ns |  28.201 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net472 |  27.806 ns | 0.2195 ns | 0.2053 ns |  27.686 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.0 |  36.458 ns | 0.3385 ns | 0.3166 ns |  36.698 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.2 |  33.358 ns | 0.0456 ns | 0.0427 ns |  33.357 ns |  0.92 |    0.01 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 3.0 |  30.506 ns | 0.0468 ns | 0.0438 ns |  30.507 ns |  0.84 |    0.01 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net461 |  43.965 ns | 0.0613 ns | 0.0544 ns |  43.969 ns |  1.21 |    0.01 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net472 |  43.934 ns | 0.0467 ns | 0.0414 ns |  43.943 ns |  1.21 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                          From_UShort_Nullable_NoValue | .NET Core 2.0 |  13.613 ns | 0.0793 ns | 0.0742 ns |  13.602 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 2.2 |  12.012 ns | 0.0132 ns | 0.0124 ns |  12.015 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 3.0 |   9.666 ns | 0.0876 ns | 0.0819 ns |   9.696 ns |  0.71 |    0.01 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net461 |  13.122 ns | 0.1237 ns | 0.1157 ns |  13.128 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net472 |  13.012 ns | 0.0133 ns | 0.0124 ns |  13.013 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.0 |  13.317 ns | 0.0437 ns | 0.0365 ns |  13.306 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.2 |  11.742 ns | 0.0214 ns | 0.0189 ns |  11.743 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 3.0 |  13.267 ns | 0.0701 ns | 0.0655 ns |  13.239 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net461 |  14.032 ns | 0.0914 ns | 0.0855 ns |  14.059 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net472 |  14.948 ns | 0.0985 ns | 0.0922 ns |  14.914 ns |  1.12 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                             From_UInt | .NET Core 2.0 |  26.319 ns | 0.0311 ns | 0.0276 ns |  26.313 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 2.2 |  25.260 ns | 0.0431 ns | 0.0382 ns |  25.271 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 3.0 |  17.324 ns | 0.0393 ns | 0.0367 ns |  17.331 ns |  0.66 |    0.00 |      - |     - |     - |         - |
                                             From_UInt |        net461 |  29.248 ns | 0.0614 ns | 0.0574 ns |  29.251 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                             From_UInt |        net472 |  28.429 ns | 0.1226 ns | 0.0958 ns |  28.452 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                    From_UInt_AsObject | .NET Core 2.0 |  36.223 ns | 0.0785 ns | 0.0695 ns |  36.216 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 2.2 |  34.552 ns | 0.0573 ns | 0.0508 ns |  34.547 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 3.0 |  31.373 ns | 0.0477 ns | 0.0446 ns |  31.373 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net461 |  48.902 ns | 0.0811 ns | 0.0719 ns |  48.923 ns |  1.35 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net472 |  50.492 ns | 0.2406 ns | 0.2009 ns |  50.427 ns |  1.39 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                          From_UInt_Nullable_WithValue | .NET Core 2.0 |  26.067 ns | 0.1535 ns | 0.1436 ns |  26.123 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 2.2 |  28.069 ns | 0.0334 ns | 0.0296 ns |  28.070 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 3.0 |  17.644 ns | 0.0221 ns | 0.0185 ns |  17.641 ns |  0.68 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net461 |  28.591 ns | 0.0428 ns | 0.0379 ns |  28.593 ns |  1.10 |    0.01 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net472 |  28.579 ns | 0.0469 ns | 0.0439 ns |  28.575 ns |  1.10 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.0 |  36.203 ns | 0.0724 ns | 0.0642 ns |  36.201 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.2 |  33.691 ns | 0.0447 ns | 0.0418 ns |  33.690 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 3.0 |  30.792 ns | 0.0545 ns | 0.0510 ns |  30.800 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net461 |  44.768 ns | 0.0616 ns | 0.0576 ns |  44.756 ns |  1.24 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net472 |  47.706 ns | 0.3669 ns | 0.3432 ns |  47.620 ns |  1.32 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                            From_UInt_Nullable_NoValue | .NET Core 2.0 |  13.295 ns | 0.0166 ns | 0.0156 ns |  13.299 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 2.2 |  10.668 ns | 0.0234 ns | 0.0207 ns |  10.667 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 3.0 |   9.870 ns | 0.1104 ns | 0.1032 ns |   9.929 ns |  0.74 |    0.01 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net461 |  13.006 ns | 0.0182 ns | 0.0162 ns |  13.007 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net472 |  13.076 ns | 0.0178 ns | 0.0158 ns |  13.077 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.0 |  13.898 ns | 0.0167 ns | 0.0139 ns |  13.900 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.2 |  11.753 ns | 0.0285 ns | 0.0252 ns |  11.750 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 3.0 |  12.998 ns | 0.0295 ns | 0.0246 ns |  12.992 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net461 |  14.728 ns | 0.0375 ns | 0.0350 ns |  14.725 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net472 |  13.957 ns | 0.0419 ns | 0.0391 ns |  13.960 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                            From_ULong | .NET Core 2.0 |  29.253 ns | 0.0384 ns | 0.0321 ns |  29.243 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 2.2 |  27.963 ns | 0.0219 ns | 0.0205 ns |  27.963 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 3.0 |  18.212 ns | 0.0929 ns | 0.0776 ns |  18.236 ns |  0.62 |    0.00 |      - |     - |     - |         - |
                                            From_ULong |        net461 |  28.134 ns | 0.0317 ns | 0.0264 ns |  28.136 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                            From_ULong |        net472 |  28.009 ns | 0.1387 ns | 0.1297 ns |  27.963 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                   From_ULong_AsObject | .NET Core 2.0 |  38.695 ns | 0.0617 ns | 0.0577 ns |  38.703 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 2.2 |  34.061 ns | 0.0362 ns | 0.0321 ns |  34.053 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 3.0 |  31.710 ns | 0.2753 ns | 0.2575 ns |  31.837 ns |  0.82 |    0.01 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net461 |  46.403 ns | 0.0498 ns | 0.0441 ns |  46.387 ns |  1.20 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net472 |  47.180 ns | 0.1902 ns | 0.1686 ns |  47.225 ns |  1.22 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                         From_ULong_Nullable_WithValue | .NET Core 2.0 |  29.956 ns | 0.0795 ns | 0.0744 ns |  29.955 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 2.2 |  31.030 ns | 0.0705 ns | 0.0660 ns |  31.027 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 3.0 |  19.434 ns | 0.0883 ns | 0.0783 ns |  19.405 ns |  0.65 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net461 |  31.192 ns | 0.1022 ns | 0.0853 ns |  31.213 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net472 |  30.961 ns | 0.0547 ns | 0.0485 ns |  30.975 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.0 |  35.993 ns | 0.0472 ns | 0.0441 ns |  35.996 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.2 |  35.492 ns | 0.0603 ns | 0.0564 ns |  35.503 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 3.0 |  31.298 ns | 0.0476 ns | 0.0422 ns |  31.291 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net461 |  44.650 ns | 0.0574 ns | 0.0509 ns |  44.649 ns |  1.24 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net472 |  49.179 ns | 0.1299 ns | 0.1085 ns |  49.168 ns |  1.37 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                           From_ULong_Nullable_NoValue | .NET Core 2.0 |  13.474 ns | 0.0143 ns | 0.0134 ns |  13.476 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 2.2 |  11.544 ns | 0.0164 ns | 0.0146 ns |  11.546 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 3.0 |  10.354 ns | 0.0975 ns | 0.0912 ns |  10.408 ns |  0.77 |    0.01 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net461 |  13.634 ns | 0.0176 ns | 0.0165 ns |  13.633 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net472 |  13.959 ns | 0.0615 ns | 0.0514 ns |  13.975 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.0 |  13.611 ns | 0.0235 ns | 0.0220 ns |  13.605 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.2 |  11.728 ns | 0.0163 ns | 0.0144 ns |  11.726 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 3.0 |  13.007 ns | 0.0507 ns | 0.0449 ns |  12.995 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net461 |  14.094 ns | 0.0800 ns | 0.0710 ns |  14.116 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net472 |  14.636 ns | 0.0278 ns | 0.0260 ns |  14.636 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                       From_NullObject | .NET Core 2.0 |  13.302 ns | 0.0231 ns | 0.0205 ns |  13.299 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 2.2 |  11.741 ns | 0.0122 ns | 0.0114 ns |  11.739 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 3.0 |  13.000 ns | 0.0249 ns | 0.0221 ns |  12.998 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject |        net461 |  13.939 ns | 0.0177 ns | 0.0138 ns |  13.938 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject |        net472 |  14.623 ns | 0.0355 ns | 0.0296 ns |  14.620 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                           From_DBNull | .NET Core 2.0 |  13.082 ns | 0.0193 ns | 0.0171 ns |  13.082 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 2.2 |  12.029 ns | 0.0141 ns | 0.0125 ns |  12.029 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 3.0 |  13.287 ns | 0.0206 ns | 0.0193 ns |  13.285 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull |        net461 |  14.841 ns | 0.1557 ns | 0.1216 ns |  14.898 ns |  1.13 |    0.01 |      - |     - |     - |         - |
                                           From_DBNull |        net472 |  15.965 ns | 0.0783 ns | 0.0654 ns |  15.974 ns |  1.22 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                  From_DBNull_AsObject | .NET Core 2.0 |  13.893 ns | 0.0201 ns | 0.0188 ns |  13.890 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 2.2 |  12.238 ns | 0.0228 ns | 0.0203 ns |  12.237 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 3.0 |  13.061 ns | 0.1272 ns | 0.1190 ns |  12.987 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net461 |  13.881 ns | 0.0298 ns | 0.0264 ns |  13.877 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net472 |  13.971 ns | 0.0476 ns | 0.0445 ns |  13.970 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                 From_ConvertibleClass | .NET Core 2.0 |  30.910 ns | 0.0424 ns | 0.0376 ns |  30.911 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 2.2 |  29.141 ns | 0.0554 ns | 0.0491 ns |  29.138 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 3.0 |  28.053 ns | 0.0961 ns | 0.0852 ns |  28.019 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net461 |  44.046 ns | 0.1459 ns | 0.1218 ns |  44.018 ns |  1.43 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net472 |  41.735 ns | 0.0608 ns | 0.0508 ns |  41.737 ns |  1.35 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                        From_ConvertibleClass_AsObject | .NET Core 2.0 |  34.601 ns | 0.0554 ns | 0.0518 ns |  34.603 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 2.2 |  33.271 ns | 0.0530 ns | 0.0442 ns |  33.253 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 3.0 |  30.140 ns | 0.0348 ns | 0.0290 ns |  30.148 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net461 |  43.415 ns | 0.0542 ns | 0.0481 ns |  43.400 ns |  1.25 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net472 |  44.698 ns | 0.0663 ns | 0.0587 ns |  44.683 ns |  1.29 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                         From_ConvertibleClass_NoValue | .NET Core 2.0 |  13.462 ns | 0.1059 ns | 0.0991 ns |  13.421 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 2.2 |  11.773 ns | 0.0174 ns | 0.0154 ns |  11.774 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 3.0 |  13.176 ns | 0.1253 ns | 0.1172 ns |  13.239 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net461 |  13.877 ns | 0.0367 ns | 0.0325 ns |  13.876 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net472 |  14.892 ns | 0.0263 ns | 0.0205 ns |  14.891 ns |  1.11 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.0 |  13.349 ns | 0.0248 ns | 0.0220 ns |  13.354 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.2 |  11.732 ns | 0.0176 ns | 0.0165 ns |  11.731 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 3.0 |  13.349 ns | 0.0533 ns | 0.0498 ns |  13.353 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net461 |  16.062 ns | 0.0346 ns | 0.0270 ns |  16.060 ns |  1.20 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net472 |  15.197 ns | 0.0236 ns | 0.0209 ns |  15.200 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                              From_NonConvertibleClass | .NET Core 2.0 |  22.895 ns | 0.0349 ns | 0.0309 ns |  22.902 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 2.2 |  21.188 ns | 0.0186 ns | 0.0174 ns |  21.190 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 3.0 |  20.831 ns | 0.0217 ns | 0.0203 ns |  20.826 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net461 |  26.193 ns | 0.0636 ns | 0.0563 ns |  26.205 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net472 |  27.529 ns | 0.0468 ns | 0.0391 ns |  27.531 ns |  1.20 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                     From_NonConvertibleClass_AsObject | .NET Core 2.0 |  28.157 ns | 0.0469 ns | 0.0416 ns |  28.157 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 2.2 |  27.522 ns | 0.0495 ns | 0.0439 ns |  27.521 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 3.0 |  24.060 ns | 0.1508 ns | 0.1411 ns |  24.109 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net461 |  41.948 ns | 0.0600 ns | 0.0532 ns |  41.950 ns |  1.49 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net472 |  40.669 ns | 0.2757 ns | 0.2579 ns |  40.514 ns |  1.44 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                      From_NonConvertibleClass_NoValue | .NET Core 2.0 |  13.053 ns | 0.0149 ns | 0.0124 ns |  13.054 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 2.2 |  12.415 ns | 0.0105 ns | 0.0088 ns |  12.415 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 3.0 |  12.995 ns | 0.0279 ns | 0.0247 ns |  12.994 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net461 |  16.038 ns | 0.1473 ns | 0.1378 ns |  15.972 ns |  1.23 |    0.01 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net472 |  14.795 ns | 0.0269 ns | 0.0252 ns |  14.793 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.0 |  13.056 ns | 0.0183 ns | 0.0171 ns |  13.055 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.2 |  11.914 ns | 0.0118 ns | 0.0105 ns |  11.916 ns |  0.91 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 3.0 |  13.426 ns | 0.0785 ns | 0.0734 ns |  13.440 ns |  1.03 |    0.01 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net461 |  15.191 ns | 0.0219 ns | 0.0194 ns |  15.200 ns |  1.16 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net472 |  13.929 ns | 0.0345 ns | 0.0323 ns |  13.929 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                From_ConvertibleStruct | .NET Core 2.0 |  33.092 ns | 0.0708 ns | 0.0591 ns |  33.090 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 2.2 |  33.303 ns | 0.0841 ns | 0.0786 ns |  33.288 ns |  1.01 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 3.0 |  23.465 ns | 0.1433 ns | 0.1340 ns |  23.491 ns |  0.71 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net461 |  36.579 ns | 0.2897 ns | 0.2710 ns |  36.436 ns |  1.10 |    0.01 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net472 |  37.358 ns | 0.2922 ns | 0.2733 ns |  37.505 ns |  1.13 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                       From_ConvertibleStruct_AsObject | .NET Core 2.0 |  36.780 ns | 0.3148 ns | 0.2944 ns |  36.930 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 2.2 |  33.545 ns | 0.0425 ns | 0.0377 ns |  33.541 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 3.0 |  30.423 ns | 0.0661 ns | 0.0586 ns |  30.417 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net461 |  45.651 ns | 0.0514 ns | 0.0456 ns |  45.640 ns |  1.24 |    0.01 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net472 |  45.631 ns | 0.0660 ns | 0.0585 ns |  45.626 ns |  1.24 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.0 |  34.807 ns | 0.2085 ns | 0.1848 ns |  34.740 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.2 |  32.475 ns | 0.0945 ns | 0.0838 ns |  32.466 ns |  0.93 |    0.01 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 3.0 |  23.721 ns | 0.0415 ns | 0.0347 ns |  23.726 ns |  0.68 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net461 |  38.819 ns | 0.2953 ns | 0.2762 ns |  38.700 ns |  1.11 |    0.01 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net472 |  38.195 ns | 0.1711 ns | 0.1600 ns |  38.172 ns |  1.10 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 |  35.224 ns | 0.0374 ns | 0.0332 ns |  35.218 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 |  39.884 ns | 0.0524 ns | 0.0490 ns |  39.889 ns |  1.13 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 |  30.858 ns | 0.3263 ns | 0.3053 ns |  30.955 ns |  0.88 |    0.01 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net461 |  43.635 ns | 0.0682 ns | 0.0605 ns |  43.623 ns |  1.24 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net472 |  47.762 ns | 0.0543 ns | 0.0481 ns |  47.766 ns |  1.36 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.0 |  12.188 ns | 0.0342 ns | 0.0267 ns |  12.188 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.2 |  12.590 ns | 0.0294 ns | 0.0260 ns |  12.589 ns |  1.03 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 3.0 |  10.044 ns | 0.0746 ns | 0.0698 ns |   9.997 ns |  0.82 |    0.01 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net461 |  13.800 ns | 0.0286 ns | 0.0239 ns |  13.802 ns |  1.13 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net472 |  13.050 ns | 0.0284 ns | 0.0252 ns |  13.051 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 |  13.256 ns | 0.1413 ns | 0.1321 ns |  13.314 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 |  11.731 ns | 0.0172 ns | 0.0161 ns |  11.732 ns |  0.89 |    0.01 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 |  13.356 ns | 0.1169 ns | 0.1093 ns |  13.320 ns |  1.01 |    0.02 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net461 |  13.875 ns | 0.0218 ns | 0.0204 ns |  13.874 ns |  1.05 |    0.01 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net472 |  14.699 ns | 0.0404 ns | 0.0338 ns |  14.701 ns |  1.11 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                             From_NonConvertibleStruct | .NET Core 2.0 |  24.394 ns | 0.0390 ns | 0.0345 ns |  24.381 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 2.2 |  25.429 ns | 0.0263 ns | 0.0233 ns |  25.431 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 3.0 |  14.093 ns | 0.1162 ns | 0.1087 ns |  14.157 ns |  0.58 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net461 |  26.559 ns | 0.0469 ns | 0.0439 ns |  26.555 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net472 |  27.170 ns | 0.0309 ns | 0.0289 ns |  27.165 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.0 |  34.620 ns | 0.0731 ns | 0.0648 ns |  34.615 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.2 |  27.494 ns | 0.0447 ns | 0.0418 ns |  27.480 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 3.0 |  23.691 ns | 0.0365 ns | 0.0341 ns |  23.697 ns |  0.68 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net461 |  39.252 ns | 0.0448 ns | 0.0419 ns |  39.248 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net472 |  40.506 ns | 0.0609 ns | 0.0569 ns |  40.494 ns |  1.17 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.0 |  25.851 ns | 0.0481 ns | 0.0450 ns |  25.863 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.2 |  25.674 ns | 0.0141 ns | 0.0118 ns |  25.671 ns |  0.99 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 3.0 |  14.640 ns | 0.0178 ns | 0.0158 ns |  14.640 ns |  0.57 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net461 |  26.681 ns | 0.0241 ns | 0.0225 ns |  26.680 ns |  1.03 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net472 |  26.693 ns | 0.0680 ns | 0.0636 ns |  26.666 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 |  28.269 ns | 0.0712 ns | 0.0595 ns |  28.254 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 |  27.437 ns | 0.0399 ns | 0.0353 ns |  27.444 ns |  0.97 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 |  24.087 ns | 0.0287 ns | 0.0254 ns |  24.084 ns |  0.85 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net461 |  38.754 ns | 0.1255 ns | 0.1174 ns |  38.762 ns |  1.37 |    0.01 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net472 |  41.481 ns | 0.0536 ns | 0.0501 ns |  41.484 ns |  1.47 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.0 |  12.384 ns | 0.0206 ns | 0.0182 ns |  12.386 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.2 |  12.608 ns | 0.0309 ns | 0.0289 ns |  12.605 ns |  1.02 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 3.0 |   9.990 ns | 0.0154 ns | 0.0144 ns |   9.990 ns |  0.81 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net461 |  13.252 ns | 0.0381 ns | 0.0356 ns |  13.263 ns |  1.07 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net472 |  13.057 ns | 0.0338 ns | 0.0316 ns |  13.055 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 |  13.888 ns | 0.0322 ns | 0.0285 ns |  13.893 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 |  11.730 ns | 0.0171 ns | 0.0152 ns |  11.732 ns |  0.84 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 |  13.271 ns | 0.0790 ns | 0.0617 ns |  13.275 ns |  0.96 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net461 |  14.538 ns | 0.0232 ns | 0.0206 ns |  14.543 ns |  1.05 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net472 |  13.860 ns | 0.0259 ns | 0.0217 ns |  13.861 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                             From_Enum | .NET Core 2.0 |  11.900 ns | 0.0265 ns | 0.0221 ns |  11.897 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 2.2 |  10.560 ns | 0.0140 ns | 0.0117 ns |  10.559 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 3.0 |   9.887 ns | 0.0756 ns | 0.0670 ns |   9.913 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                                             From_Enum |        net461 |  12.330 ns | 0.0115 ns | 0.0108 ns |  12.331 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                             From_Enum |        net472 |  12.319 ns | 0.0206 ns | 0.0182 ns |  12.317 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                    From_Enum_AsObject | .NET Core 2.0 |  22.516 ns | 0.1258 ns | 0.1051 ns |  22.540 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Enum_AsObject | .NET Core 2.2 |  24.335 ns | 0.0339 ns | 0.0301 ns |  24.334 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                                    From_Enum_AsObject | .NET Core 3.0 |  27.312 ns | 0.0738 ns | 0.0655 ns |  27.299 ns |  1.21 |    0.01 |      - |     - |     - |         - |
                                    From_Enum_AsObject |        net461 |  28.839 ns | 0.0565 ns | 0.0441 ns |  28.837 ns |  1.28 |    0.01 |      - |     - |     - |         - |
                                    From_Enum_AsObject |        net472 |  29.837 ns | 0.0565 ns | 0.0472 ns |  29.855 ns |  1.33 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                          From_Enum_Nullable_WithValue | .NET Core 2.0 |  11.446 ns | 0.0197 ns | 0.0185 ns |  11.444 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 2.2 |  10.411 ns | 0.0122 ns | 0.0108 ns |  10.414 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 3.0 |   6.660 ns | 0.0180 ns | 0.0150 ns |   6.659 ns |  0.58 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net461 |  12.903 ns | 0.0191 ns | 0.0178 ns |  12.901 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net472 |  11.811 ns | 0.0208 ns | 0.0184 ns |  11.812 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.0 |  22.232 ns | 0.0268 ns | 0.0224 ns |  22.240 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.2 |  24.340 ns | 0.0231 ns | 0.0216 ns |  24.338 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 3.0 |  28.273 ns | 0.5607 ns | 0.5758 ns |  28.677 ns |  1.27 |    0.03 |      - |     - |     - |         - |
                 From_Enum_Nullable_WithValue_AsObject |        net461 |  28.960 ns | 0.1119 ns | 0.0992 ns |  28.976 ns |  1.30 |    0.00 |      - |     - |     - |         - |
                 From_Enum_Nullable_WithValue_AsObject |        net472 |  29.624 ns | 0.0403 ns | 0.0358 ns |  29.629 ns |  1.33 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                            From_Enum_Nullable_NoValue | .NET Core 2.0 |  11.437 ns | 0.0294 ns | 0.0260 ns |  11.434 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 2.2 |  10.409 ns | 0.0165 ns | 0.0146 ns |  10.407 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 3.0 |   8.181 ns | 0.1885 ns | 0.3097 ns |   8.288 ns |  0.70 |    0.04 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net461 |  11.783 ns | 0.0284 ns | 0.0252 ns |  11.785 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net472 |  11.809 ns | 0.0252 ns | 0.0236 ns |  11.807 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.0 |  13.058 ns | 0.0189 ns | 0.0167 ns |  13.057 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.2 |  12.054 ns | 0.0547 ns | 0.0512 ns |  12.053 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 3.0 |  13.766 ns | 0.2973 ns | 0.3053 ns |  13.875 ns |  1.05 |    0.02 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net461 |  13.845 ns | 0.0172 ns | 0.0144 ns |  13.851 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net472 |  13.849 ns | 0.0305 ns | 0.0271 ns |  13.851 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                      From_ParentClass | .NET Core 2.0 |  22.857 ns | 0.0396 ns | 0.0351 ns |  22.858 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 2.2 |  21.214 ns | 0.0354 ns | 0.0295 ns |  21.223 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 3.0 |  21.702 ns | 0.0469 ns | 0.0438 ns |  21.695 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass |        net461 |  26.827 ns | 0.0430 ns | 0.0359 ns |  26.809 ns |  1.17 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass |        net472 |  28.994 ns | 0.0444 ns | 0.0415 ns |  29.006 ns |  1.27 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                             From_ParentClass_AsObject | .NET Core 2.0 |  29.329 ns | 0.2018 ns | 0.1789 ns |  29.390 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 2.2 |  27.659 ns | 0.0332 ns | 0.0294 ns |  27.652 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 3.0 |  24.033 ns | 0.1351 ns | 0.1264 ns |  23.969 ns |  0.82 |    0.01 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net461 |  40.793 ns | 0.0813 ns | 0.0760 ns |  40.796 ns |  1.39 |    0.01 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net472 |  43.608 ns | 0.0716 ns | 0.0670 ns |  43.600 ns |  1.49 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                              From_ParentClass_NoValue | .NET Core 2.0 |  13.060 ns | 0.0222 ns | 0.0197 ns |  13.063 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 2.2 |  11.803 ns | 0.0409 ns | 0.0383 ns |  11.790 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 3.0 |  13.060 ns | 0.0418 ns | 0.0370 ns |  13.075 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net461 |  13.882 ns | 0.0317 ns | 0.0247 ns |  13.876 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net472 |  13.825 ns | 0.0310 ns | 0.0290 ns |  13.827 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.0 |  13.895 ns | 0.0455 ns | 0.0403 ns |  13.899 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.2 |  11.739 ns | 0.0207 ns | 0.0194 ns |  11.739 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 3.0 |  13.420 ns | 0.0730 ns | 0.0683 ns |  13.393 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net461 |  13.860 ns | 0.0230 ns | 0.0215 ns |  13.857 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net472 |  14.188 ns | 0.0768 ns | 0.0719 ns |  14.202 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                     From_ParentStruct | .NET Core 2.0 |  93.063 ns | 0.1439 ns | 0.1276 ns |  93.069 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 2.2 |  90.287 ns | 0.1701 ns | 0.1508 ns |  90.295 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 3.0 |  86.888 ns | 0.4421 ns | 0.3919 ns |  86.695 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct |        net461 |  94.805 ns | 0.1492 ns | 0.1396 ns |  94.783 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct |        net472 | 104.768 ns | 0.1692 ns | 0.1500 ns | 104.735 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                            From_ParentStruct_AsObject | .NET Core 2.0 |  29.000 ns | 0.0179 ns | 0.0159 ns |  29.003 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 2.2 |  27.391 ns | 0.0335 ns | 0.0313 ns |  27.389 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 3.0 |  24.000 ns | 0.0554 ns | 0.0491 ns |  24.001 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net461 |  41.842 ns | 0.2378 ns | 0.2224 ns |  41.790 ns |  1.44 |    0.01 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net472 |  42.312 ns | 0.0525 ns | 0.0491 ns |  42.312 ns |  1.46 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.0 |  88.142 ns | 0.2945 ns | 0.2755 ns |  88.076 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.2 |  88.342 ns | 0.1187 ns | 0.1110 ns |  88.336 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 3.0 |  80.088 ns | 0.4025 ns | 0.3765 ns |  80.151 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue |        net461 |  95.504 ns | 0.1594 ns | 0.1413 ns |  95.488 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue |        net472 |  95.844 ns | 0.1309 ns | 0.1224 ns |  95.900 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.0 |  29.648 ns | 0.1016 ns | 0.0900 ns |  29.628 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.2 |  28.720 ns | 0.0450 ns | 0.0421 ns |  28.719 ns |  0.97 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 3.0 |  23.951 ns | 0.0431 ns | 0.0360 ns |  23.945 ns |  0.81 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net461 |  39.837 ns | 0.0749 ns | 0.0701 ns |  39.850 ns |  1.34 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net472 |  43.238 ns | 0.0613 ns | 0.0544 ns |  43.259 ns |  1.46 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.0 |  65.363 ns | 0.3061 ns | 0.2713 ns |  65.426 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.2 |  54.944 ns | 0.3714 ns | 0.3474 ns |  55.163 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 3.0 |  52.521 ns | 0.1304 ns | 0.1018 ns |  52.529 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net461 |  59.029 ns | 0.1935 ns | 0.1616 ns |  59.022 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net472 |  55.398 ns | 0.1251 ns | 0.1170 ns |  55.431 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.0 |  13.428 ns | 0.0276 ns | 0.0230 ns |  13.438 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.2 |  12.166 ns | 0.0198 ns | 0.0166 ns |  12.168 ns |  0.91 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 3.0 |  13.182 ns | 0.1237 ns | 0.1157 ns |  13.243 ns |  0.98 |    0.01 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net461 |  13.897 ns | 0.0254 ns | 0.0238 ns |  13.894 ns |  1.03 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net472 |  13.849 ns | 0.0382 ns | 0.0319 ns |  13.858 ns |  1.03 |    0.00 |      - |     - |     - |         - |

Benchmarks with issues:
  ConvertTo_EnumNullable.From_DateTime_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_EnumNullable.From_DateTime_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_EnumNullable.From_DateTime_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_EnumNullable.From_DateTime_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_EnumNullable.From_DateTime_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_EnumNullable.From_DateTime_Nullable_WithValue_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_EnumNullable.From_DateTime_Nullable_WithValue_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_EnumNullable.From_DateTime_Nullable_WithValue_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_EnumNullable.From_DateTime_Nullable_WithValue_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_EnumNullable.From_DateTime_Nullable_WithValue_AsObject: Job-PJAXXB(Toolchain=net472)
