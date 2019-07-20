
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
                                             From_Bool | .NET Core 2.0 | 11.757 ns | 0.0356 ns | 0.0333 ns | 11.748 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 2.2 | 11.073 ns | 0.0233 ns | 0.0218 ns | 11.070 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 3.0 |  6.938 ns | 0.0137 ns | 0.0121 ns |  6.938 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                                             From_Bool |        net461 | 12.883 ns | 0.0540 ns | 0.0505 ns | 12.865 ns |  1.10 |    0.01 |      - |     - |     - |         - |
                                             From_Bool |        net472 | 10.459 ns | 0.0160 ns | 0.0142 ns | 10.456 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Bool_AsObject | .NET Core 2.0 | 17.885 ns | 0.1285 ns | 0.1202 ns | 17.844 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 2.2 | 15.582 ns | 0.0968 ns | 0.0905 ns | 15.605 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 3.0 | 15.577 ns | 0.0390 ns | 0.0345 ns | 15.587 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net461 | 18.690 ns | 0.0396 ns | 0.0330 ns | 18.690 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net472 | 20.303 ns | 0.0428 ns | 0.0379 ns | 20.298 ns |  1.13 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Bool_Nullable_WithValue | .NET Core 2.0 | 12.090 ns | 0.1119 ns | 0.1046 ns | 12.146 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 2.2 | 10.990 ns | 0.0163 ns | 0.0152 ns | 10.988 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 3.0 |  8.327 ns | 0.1838 ns | 0.2117 ns |  8.280 ns |  0.69 |    0.02 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net461 | 13.332 ns | 0.1015 ns | 0.0950 ns | 13.369 ns |  1.10 |    0.01 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net472 | 10.914 ns | 0.0952 ns | 0.0890 ns | 10.866 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.126 ns | 0.0219 ns | 0.0205 ns | 18.123 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.353 ns | 0.0396 ns | 0.0351 ns | 15.363 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 3.0 | 16.138 ns | 0.3413 ns | 0.4437 ns | 16.472 ns |  0.88 |    0.02 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net461 | 18.905 ns | 0.0265 ns | 0.0235 ns | 18.904 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net472 | 20.888 ns | 0.0457 ns | 0.0382 ns | 20.885 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Bool_Nullable_NoValue | .NET Core 2.0 | 12.401 ns | 0.1177 ns | 0.1101 ns | 12.343 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 2.2 | 10.888 ns | 0.1083 ns | 0.1013 ns | 10.953 ns |  0.88 |    0.02 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 3.0 |  6.614 ns | 0.0246 ns | 0.0205 ns |  6.616 ns |  0.53 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net461 | 12.103 ns | 0.2693 ns | 0.2765 ns | 12.024 ns |  0.98 |    0.02 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net472 | 10.498 ns | 0.0289 ns | 0.0270 ns | 10.497 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.022 ns | 0.1093 ns | 0.1022 ns | 15.078 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.917 ns | 0.0147 ns | 0.0130 ns | 11.910 ns |  0.79 |    0.01 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.150 ns | 0.0874 ns | 0.0682 ns | 12.177 ns |  0.81 |    0.01 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net461 | 13.367 ns | 0.0495 ns | 0.0438 ns | 13.362 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net472 | 15.671 ns | 0.1048 ns | 0.0929 ns | 15.701 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Byte | .NET Core 2.0 | 11.545 ns | 0.0107 ns | 0.0095 ns | 11.546 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 2.2 | 10.431 ns | 0.0381 ns | 0.0357 ns | 10.441 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 3.0 |  6.961 ns | 0.4064 ns | 0.5956 ns |  6.635 ns |  0.63 |    0.06 |      - |     - |     - |         - |
                                             From_Byte |        net461 | 10.573 ns | 0.1108 ns | 0.1036 ns | 10.570 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                                             From_Byte |        net472 | 10.404 ns | 0.0250 ns | 0.0221 ns | 10.409 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Byte_AsObject | .NET Core 2.0 | 17.548 ns | 0.0330 ns | 0.0293 ns | 17.548 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 2.2 | 12.698 ns | 0.0722 ns | 0.0675 ns | 12.722 ns |  0.72 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 3.0 | 12.226 ns | 0.2615 ns | 0.2568 ns | 12.158 ns |  0.70 |    0.01 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net461 | 14.641 ns | 0.0657 ns | 0.0614 ns | 14.623 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net472 | 17.278 ns | 0.0194 ns | 0.0182 ns | 17.277 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Byte_Nullable_WithValue | .NET Core 2.0 | 11.912 ns | 0.1222 ns | 0.1143 ns | 11.880 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 2.2 | 10.412 ns | 0.0298 ns | 0.0279 ns | 10.402 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 3.0 |  7.491 ns | 0.0298 ns | 0.0279 ns |  7.484 ns |  0.63 |    0.01 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net461 | 10.703 ns | 0.0190 ns | 0.0169 ns | 10.702 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net472 | 12.437 ns | 0.0671 ns | 0.0627 ns | 12.446 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.0 | 14.695 ns | 0.0141 ns | 0.0132 ns | 14.697 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.2 | 12.653 ns | 0.0266 ns | 0.0249 ns | 12.652 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 3.0 | 13.449 ns | 0.0203 ns | 0.0170 ns | 13.452 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net461 | 16.320 ns | 0.0531 ns | 0.0497 ns | 16.302 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net472 | 16.581 ns | 0.0453 ns | 0.0378 ns | 16.587 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Byte_Nullable_NoValue | .NET Core 2.0 | 11.685 ns | 0.0169 ns | 0.0150 ns | 11.686 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 2.2 | 10.292 ns | 0.0104 ns | 0.0097 ns | 10.291 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 3.0 |  7.267 ns | 0.0250 ns | 0.0221 ns |  7.263 ns |  0.62 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net461 | 12.017 ns | 0.0217 ns | 0.0181 ns | 12.019 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net472 | 10.382 ns | 0.0620 ns | 0.0580 ns | 10.369 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.306 ns | 0.1203 ns | 0.1126 ns | 14.391 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.927 ns | 0.0176 ns | 0.0156 ns | 11.926 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.244 ns | 0.0972 ns | 0.0909 ns | 12.258 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net461 | 13.328 ns | 0.0238 ns | 0.0222 ns | 13.329 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net472 | 17.404 ns | 0.0271 ns | 0.0254 ns | 17.401 ns |  1.22 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Char | .NET Core 2.0 | 12.771 ns | 0.0356 ns | 0.0315 ns | 12.770 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Char | .NET Core 2.2 | 10.898 ns | 0.0317 ns | 0.0265 ns | 10.896 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                             From_Char | .NET Core 3.0 |  6.929 ns | 0.0169 ns | 0.0149 ns |  6.929 ns |  0.54 |    0.00 |      - |     - |     - |         - |
                                             From_Char |        net461 | 13.366 ns | 0.0417 ns | 0.0390 ns | 13.352 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                             From_Char |        net472 | 10.833 ns | 0.0459 ns | 0.0429 ns | 10.817 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Char_AsObject | .NET Core 2.0 | 19.263 ns | 0.0205 ns | 0.0181 ns | 19.257 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 2.2 | 16.274 ns | 0.0398 ns | 0.0353 ns | 16.284 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 3.0 | 17.707 ns | 0.0480 ns | 0.0375 ns | 17.716 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject |        net461 | 19.451 ns | 0.0421 ns | 0.0393 ns | 19.441 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject |        net472 | 21.469 ns | 0.0368 ns | 0.0344 ns | 21.472 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Char_Nullable_WithValue | .NET Core 2.0 | 12.080 ns | 0.0975 ns | 0.0912 ns | 12.125 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 2.2 | 11.005 ns | 0.0151 ns | 0.0142 ns | 11.003 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 3.0 |  7.097 ns | 0.0270 ns | 0.0252 ns |  7.098 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net461 | 13.489 ns | 0.0489 ns | 0.0457 ns | 13.480 ns |  1.12 |    0.01 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net472 | 13.403 ns | 0.0100 ns | 0.0094 ns | 13.401 ns |  1.11 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.035 ns | 0.0369 ns | 0.0327 ns | 19.035 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.2 | 16.299 ns | 0.0725 ns | 0.0643 ns | 16.287 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 3.0 | 16.074 ns | 0.0356 ns | 0.0297 ns | 16.068 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net461 | 19.318 ns | 0.0197 ns | 0.0175 ns | 19.320 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net472 | 21.782 ns | 0.1038 ns | 0.0971 ns | 21.793 ns |  1.14 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Char_Nullable_NoValue | .NET Core 2.0 | 11.746 ns | 0.0875 ns | 0.0819 ns | 11.707 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 2.2 | 10.877 ns | 0.0223 ns | 0.0209 ns | 10.880 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 3.0 |  6.666 ns | 0.0652 ns | 0.0610 ns |  6.641 ns |  0.57 |    0.01 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net461 | 12.488 ns | 0.0172 ns | 0.0153 ns | 12.493 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net472 | 10.460 ns | 0.0169 ns | 0.0158 ns | 10.455 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.165 ns | 0.1317 ns | 0.1232 ns | 15.257 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.925 ns | 0.0146 ns | 0.0129 ns | 11.922 ns |  0.79 |    0.01 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.236 ns | 0.2619 ns | 0.3016 ns | 12.034 ns |  0.81 |    0.02 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net461 | 13.315 ns | 0.0291 ns | 0.0273 ns | 13.299 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net472 | 17.976 ns | 0.0237 ns | 0.0222 ns | 17.975 ns |  1.19 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                         From_DateTime | .NET Core 2.0 | 12.579 ns | 0.0196 ns | 0.0153 ns | 12.584 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 2.2 | 11.763 ns | 0.0475 ns | 0.0444 ns | 11.749 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 3.0 |  7.970 ns | 0.0854 ns | 0.0799 ns |  7.996 ns |  0.63 |    0.01 |      - |     - |     - |         - |
                                         From_DateTime |        net461 | 12.751 ns | 0.0249 ns | 0.0233 ns | 12.748 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime |        net472 | 13.853 ns | 0.1465 ns | 0.1370 ns | 13.818 ns |  1.10 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                From_DateTime_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                      From_DateTime_Nullable_WithValue | .NET Core 2.0 | 13.088 ns | 0.0587 ns | 0.0549 ns | 13.099 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 2.2 | 11.805 ns | 0.0136 ns | 0.0127 ns | 11.811 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 3.0 |  8.083 ns | 0.0817 ns | 0.0764 ns |  8.128 ns |  0.62 |    0.01 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net461 | 13.411 ns | 0.0752 ns | 0.0703 ns | 13.399 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net472 | 13.298 ns | 0.0238 ns | 0.0198 ns | 13.293 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_DateTime_Nullable_NoValue | .NET Core 2.0 | 13.119 ns | 0.0231 ns | 0.0216 ns | 13.115 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 2.2 | 11.798 ns | 0.0404 ns | 0.0358 ns | 11.802 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 3.0 |  8.487 ns | 0.4522 ns | 0.7679 ns |  8.137 ns |  0.69 |    0.07 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net461 | 13.441 ns | 0.0204 ns | 0.0180 ns | 13.439 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net472 | 12.618 ns | 0.0209 ns | 0.0195 ns | 12.618 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.179 ns | 0.0152 ns | 0.0142 ns | 14.182 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.940 ns | 0.0167 ns | 0.0148 ns | 11.939 ns |  0.84 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.000 ns | 0.0289 ns | 0.0271 ns | 11.998 ns |  0.85 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net461 | 13.321 ns | 0.0412 ns | 0.0385 ns | 13.315 ns |  0.94 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net472 | 16.645 ns | 0.0335 ns | 0.0297 ns | 16.644 ns |  1.17 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                          From_Decimal | .NET Core 2.0 | 25.966 ns | 0.0964 ns | 0.0805 ns | 25.951 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 2.2 | 25.171 ns | 0.0566 ns | 0.0529 ns | 25.169 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 3.0 | 14.442 ns | 0.2696 ns | 0.2522 ns | 14.447 ns |  0.56 |    0.01 |      - |     - |     - |         - |
                                          From_Decimal |        net461 | 25.803 ns | 0.0654 ns | 0.0546 ns | 25.782 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal |        net472 | 25.013 ns | 0.0805 ns | 0.0753 ns | 25.021 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                 From_Decimal_AsObject | .NET Core 2.0 | 27.619 ns | 0.0315 ns | 0.0295 ns | 27.617 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 2.2 | 25.522 ns | 0.2255 ns | 0.2109 ns | 25.422 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 3.0 | 21.705 ns | 0.1901 ns | 0.1778 ns | 21.617 ns |  0.79 |    0.01 |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net461 | 28.260 ns | 0.0285 ns | 0.0253 ns | 28.258 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net472 | 28.617 ns | 0.0436 ns | 0.0386 ns | 28.622 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                       From_Decimal_Nullable_WithValue | .NET Core 2.0 | 26.997 ns | 0.0302 ns | 0.0267 ns | 26.996 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 2.2 | 24.815 ns | 0.0425 ns | 0.0398 ns | 24.817 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 3.0 | 16.489 ns | 0.1262 ns | 0.1180 ns | 16.531 ns |  0.61 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net461 | 29.122 ns | 0.1037 ns | 0.0970 ns | 29.103 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net472 | 25.457 ns | 0.1470 ns | 0.1375 ns | 25.396 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.0 | 28.126 ns | 0.0312 ns | 0.0292 ns | 28.126 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.2 | 25.369 ns | 0.0297 ns | 0.0232 ns | 25.376 ns |  0.90 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 3.0 | 21.402 ns | 0.1723 ns | 0.1611 ns | 21.301 ns |  0.76 |    0.01 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net461 | 27.686 ns | 0.0565 ns | 0.0501 ns | 27.684 ns |  0.98 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net472 | 29.214 ns | 0.0419 ns | 0.0327 ns | 29.205 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Decimal_Nullable_NoValue | .NET Core 2.0 | 12.600 ns | 0.0137 ns | 0.0129 ns | 12.602 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 2.2 | 11.887 ns | 0.0224 ns | 0.0209 ns | 11.890 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 3.0 |  8.269 ns | 0.0886 ns | 0.0829 ns |  8.320 ns |  0.66 |    0.01 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net461 | 14.945 ns | 0.0303 ns | 0.0283 ns | 14.944 ns |  1.19 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net472 | 13.489 ns | 0.0339 ns | 0.0283 ns | 13.492 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.187 ns | 0.0917 ns | 0.0858 ns | 14.138 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.843 ns | 0.0170 ns | 0.0159 ns | 12.846 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.245 ns | 0.0277 ns | 0.0246 ns | 11.250 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net461 | 13.276 ns | 0.0261 ns | 0.0203 ns | 13.278 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net472 | 16.673 ns | 0.0292 ns | 0.0259 ns | 16.679 ns |  1.17 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_Double | .NET Core 2.0 | 14.109 ns | 0.0655 ns | 0.0613 ns | 14.104 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 2.2 | 13.308 ns | 0.0590 ns | 0.0552 ns | 13.288 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                                           From_Double | .NET Core 3.0 | 10.760 ns | 0.2390 ns | 0.3927 ns | 10.899 ns |  0.74 |    0.03 |      - |     - |     - |         - |
                                           From_Double |        net461 | 15.451 ns | 0.0470 ns | 0.0440 ns | 15.456 ns |  1.10 |    0.01 |      - |     - |     - |         - |
                                           From_Double |        net472 | 14.045 ns | 0.0337 ns | 0.0299 ns | 14.045 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_Double_AsObject | .NET Core 2.0 | 20.370 ns | 0.0331 ns | 0.0309 ns | 20.363 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 2.2 | 17.523 ns | 0.0346 ns | 0.0307 ns | 17.518 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 3.0 | 17.814 ns | 0.0593 ns | 0.0526 ns | 17.834 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject |        net461 | 22.867 ns | 0.0269 ns | 0.0224 ns | 22.865 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject |        net472 | 22.062 ns | 0.0436 ns | 0.0387 ns | 22.061 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_Double_Nullable_WithValue | .NET Core 2.0 | 15.280 ns | 0.0211 ns | 0.0176 ns | 15.285 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 2.2 | 14.718 ns | 0.0203 ns | 0.0169 ns | 14.720 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 3.0 | 12.366 ns | 0.0146 ns | 0.0137 ns | 12.366 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net461 | 18.174 ns | 0.0279 ns | 0.0261 ns | 18.175 ns |  1.19 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net472 | 16.251 ns | 0.0377 ns | 0.0353 ns | 16.251 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.0 | 21.374 ns | 0.1473 ns | 0.1378 ns | 21.303 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.544 ns | 0.0933 ns | 0.0873 ns | 17.564 ns |  0.82 |    0.01 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.156 ns | 0.1263 ns | 0.1181 ns | 18.116 ns |  0.85 |    0.01 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net461 | 20.724 ns | 0.0949 ns | 0.0842 ns | 20.731 ns |  0.97 |    0.01 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net472 | 22.706 ns | 0.0440 ns | 0.0367 ns | 22.704 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Double_Nullable_NoValue | .NET Core 2.0 | 12.974 ns | 0.0230 ns | 0.0215 ns | 12.971 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 2.2 | 12.013 ns | 0.0227 ns | 0.0201 ns | 12.005 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 3.0 |  8.029 ns | 0.0227 ns | 0.0212 ns |  8.022 ns |  0.62 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net461 | 13.778 ns | 0.0879 ns | 0.0822 ns | 13.754 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net472 | 12.771 ns | 0.0309 ns | 0.0289 ns | 12.774 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.155 ns | 0.0358 ns | 0.0335 ns | 14.143 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.016 ns | 0.0241 ns | 0.0188 ns | 13.017 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.160 ns | 0.2899 ns | 0.3769 ns | 12.928 ns |  0.94 |    0.03 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net461 | 13.380 ns | 0.0146 ns | 0.0122 ns | 13.376 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net472 | 16.656 ns | 0.0255 ns | 0.0213 ns | 16.656 ns |  1.18 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_Short | .NET Core 2.0 | 13.233 ns | 0.0658 ns | 0.0616 ns | 13.239 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 2.2 | 11.247 ns | 0.0196 ns | 0.0184 ns | 11.247 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 3.0 |  7.797 ns | 0.0144 ns | 0.0120 ns |  7.800 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                                            From_Short |        net461 | 13.400 ns | 0.0207 ns | 0.0173 ns | 13.403 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                            From_Short |        net472 | 10.864 ns | 0.0217 ns | 0.0192 ns | 10.862 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_Short_AsObject | .NET Core 2.0 | 19.041 ns | 0.0465 ns | 0.0388 ns | 19.035 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 2.2 | 16.280 ns | 0.0166 ns | 0.0139 ns | 16.281 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 3.0 | 15.678 ns | 0.0378 ns | 0.0353 ns | 15.685 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net461 | 19.876 ns | 0.0952 ns | 0.0891 ns | 19.883 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net472 | 21.032 ns | 0.1258 ns | 0.1176 ns | 21.003 ns |  1.11 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Short_Nullable_WithValue | .NET Core 2.0 | 12.617 ns | 0.0352 ns | 0.0329 ns | 12.605 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 2.2 | 12.149 ns | 0.0199 ns | 0.0166 ns | 12.145 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 3.0 |  9.110 ns | 0.2066 ns | 0.3336 ns |  9.281 ns |  0.71 |    0.04 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net461 | 14.016 ns | 0.0327 ns | 0.0273 ns | 14.019 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net472 | 13.591 ns | 0.1169 ns | 0.1094 ns | 13.642 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.883 ns | 0.0242 ns | 0.0227 ns | 18.884 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.2 | 16.270 ns | 0.0405 ns | 0.0359 ns | 16.272 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 3.0 | 16.087 ns | 0.0472 ns | 0.0441 ns | 16.091 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net461 | 19.896 ns | 0.0268 ns | 0.0250 ns | 19.892 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net472 | 21.941 ns | 0.0587 ns | 0.0549 ns | 21.922 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Short_Nullable_NoValue | .NET Core 2.0 | 11.726 ns | 0.0108 ns | 0.0096 ns | 11.724 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 2.2 | 10.936 ns | 0.0529 ns | 0.0442 ns | 10.945 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 3.0 |  6.966 ns | 0.4157 ns | 0.6094 ns |  6.622 ns |  0.63 |    0.06 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net461 | 12.546 ns | 0.0287 ns | 0.0254 ns | 12.541 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net472 | 11.907 ns | 0.0180 ns | 0.0160 ns | 11.902 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.217 ns | 0.1165 ns | 0.1090 ns | 14.154 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.961 ns | 0.0161 ns | 0.0126 ns | 11.962 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.131 ns | 0.1116 ns | 0.1044 ns | 12.195 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net461 | 13.243 ns | 0.0169 ns | 0.0158 ns | 13.240 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net472 | 15.048 ns | 0.0222 ns | 0.0196 ns | 15.050 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                              From_Int | .NET Core 2.0 | 12.044 ns | 0.0173 ns | 0.0154 ns | 12.049 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 2.2 | 11.089 ns | 0.0168 ns | 0.0149 ns | 11.085 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 3.0 |  7.799 ns | 0.0307 ns | 0.0287 ns |  7.801 ns |  0.65 |    0.00 |      - |     - |     - |         - |
                                              From_Int |        net461 | 13.408 ns | 0.0139 ns | 0.0116 ns | 13.407 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                              From_Int |        net472 | 10.892 ns | 0.0295 ns | 0.0276 ns | 10.888 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_Int_AsObject | .NET Core 2.0 | 18.807 ns | 0.2171 ns | 0.2031 ns | 18.707 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 2.2 | 16.029 ns | 0.1232 ns | 0.1152 ns | 16.097 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 3.0 | 16.142 ns | 0.1118 ns | 0.1046 ns | 16.092 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net461 | 21.193 ns | 0.0315 ns | 0.0295 ns | 21.190 ns |  1.13 |    0.01 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net472 | 21.164 ns | 0.1944 ns | 0.1818 ns | 21.256 ns |  1.13 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Int_Nullable_WithValue | .NET Core 2.0 | 12.619 ns | 0.1101 ns | 0.1030 ns | 12.605 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 2.2 | 12.362 ns | 0.0354 ns | 0.0331 ns | 12.376 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 3.0 |  8.254 ns | 0.1625 ns | 0.1520 ns |  8.266 ns |  0.65 |    0.02 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net461 | 13.148 ns | 0.0190 ns | 0.0168 ns | 13.143 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net472 | 12.138 ns | 0.0330 ns | 0.0308 ns | 12.141 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.230 ns | 0.0390 ns | 0.0326 ns | 20.225 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.2 | 16.108 ns | 0.0302 ns | 0.0235 ns | 16.106 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 3.0 | 16.287 ns | 0.3308 ns | 0.3094 ns | 16.504 ns |  0.80 |    0.02 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net461 | 19.342 ns | 0.0318 ns | 0.0266 ns | 19.344 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net472 | 21.355 ns | 0.0487 ns | 0.0407 ns | 21.344 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_Int_Nullable_NoValue | .NET Core 2.0 | 14.100 ns | 0.1025 ns | 0.0958 ns | 14.148 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 2.2 | 11.677 ns | 0.0990 ns | 0.0926 ns | 11.713 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 3.0 |  8.088 ns | 0.0577 ns | 0.0512 ns |  8.069 ns |  0.57 |    0.01 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net461 | 11.824 ns | 0.0180 ns | 0.0168 ns | 11.823 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net472 | 10.443 ns | 0.0247 ns | 0.0231 ns | 10.449 ns |  0.74 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.896 ns | 0.0172 ns | 0.0152 ns | 14.899 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.955 ns | 0.0085 ns | 0.0071 ns | 11.957 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.811 ns | 0.1307 ns | 0.1222 ns | 13.888 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net461 | 13.468 ns | 0.0226 ns | 0.0189 ns | 13.462 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net472 | 16.617 ns | 0.0409 ns | 0.0342 ns | 16.625 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Long | .NET Core 2.0 | 12.021 ns | 0.0274 ns | 0.0243 ns | 12.028 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Long | .NET Core 2.2 | 11.140 ns | 0.1010 ns | 0.0944 ns | 11.086 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                                             From_Long | .NET Core 3.0 |  7.840 ns | 0.1127 ns | 0.0999 ns |  7.808 ns |  0.65 |    0.01 |      - |     - |     - |         - |
                                             From_Long |        net461 | 13.397 ns | 0.0830 ns | 0.0736 ns | 13.369 ns |  1.11 |    0.01 |      - |     - |     - |         - |
                                             From_Long |        net472 | 12.547 ns | 0.0179 ns | 0.0150 ns | 12.545 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Long_AsObject | .NET Core 2.0 | 18.990 ns | 0.0408 ns | 0.0362 ns | 18.987 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 2.2 | 15.901 ns | 0.0446 ns | 0.0395 ns | 15.895 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 3.0 | 16.867 ns | 0.1889 ns | 0.1767 ns | 16.823 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net461 | 19.377 ns | 0.0894 ns | 0.0837 ns | 19.342 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net472 | 21.693 ns | 0.0942 ns | 0.0835 ns | 21.684 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Long_Nullable_WithValue | .NET Core 2.0 | 13.673 ns | 0.0254 ns | 0.0238 ns | 13.672 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 2.2 | 13.245 ns | 0.0184 ns | 0.0153 ns | 13.247 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 3.0 | 11.821 ns | 0.2535 ns | 0.3385 ns | 11.701 ns |  0.86 |    0.03 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net461 | 15.497 ns | 0.0981 ns | 0.0870 ns | 15.526 ns |  1.13 |    0.01 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net472 | 14.567 ns | 0.0576 ns | 0.0539 ns | 14.563 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.899 ns | 0.0409 ns | 0.0363 ns | 18.904 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.2 | 16.024 ns | 0.1035 ns | 0.0968 ns | 16.075 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 3.0 | 16.469 ns | 0.1326 ns | 0.1175 ns | 16.461 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net461 | 19.563 ns | 0.0879 ns | 0.0779 ns | 19.532 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net472 | 21.921 ns | 0.0369 ns | 0.0327 ns | 21.916 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Long_Nullable_NoValue | .NET Core 2.0 | 12.652 ns | 0.0728 ns | 0.0645 ns | 12.673 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 2.2 | 12.007 ns | 0.0218 ns | 0.0194 ns | 12.009 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 3.0 |  8.283 ns | 0.1912 ns | 0.1877 ns |  8.286 ns |  0.65 |    0.02 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net461 | 14.071 ns | 0.0318 ns | 0.0249 ns | 14.068 ns |  1.11 |    0.01 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net472 | 12.786 ns | 0.0277 ns | 0.0259 ns | 12.794 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.152 ns | 0.0155 ns | 0.0145 ns | 14.148 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.951 ns | 0.0130 ns | 0.0115 ns | 11.952 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.656 ns | 0.4357 ns | 0.4843 ns | 11.463 ns |  0.83 |    0.04 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net461 | 13.354 ns | 0.0190 ns | 0.0168 ns | 13.351 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net472 | 14.994 ns | 0.0429 ns | 0.0401 ns | 14.980 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_SByte | .NET Core 2.0 | 11.748 ns | 0.0538 ns | 0.0504 ns | 11.736 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 2.2 | 10.955 ns | 0.0220 ns | 0.0172 ns | 10.954 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 3.0 |  7.007 ns | 0.1082 ns | 0.1012 ns |  6.965 ns |  0.60 |    0.01 |      - |     - |     - |         - |
                                            From_SByte |        net461 | 13.226 ns | 0.0284 ns | 0.0237 ns | 13.223 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                            From_SByte |        net472 | 10.869 ns | 0.1042 ns | 0.0975 ns | 10.898 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_SByte_AsObject | .NET Core 2.0 | 19.153 ns | 0.0944 ns | 0.0837 ns | 19.187 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 2.2 | 15.631 ns | 0.0379 ns | 0.0336 ns | 15.630 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 3.0 | 15.512 ns | 0.1920 ns | 0.1796 ns | 15.505 ns |  0.81 |    0.01 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net461 | 19.410 ns | 0.0557 ns | 0.0521 ns | 19.413 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net472 | 21.820 ns | 0.0649 ns | 0.0607 ns | 21.825 ns |  1.14 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_SByte_Nullable_WithValue | .NET Core 2.0 | 12.518 ns | 0.0196 ns | 0.0174 ns | 12.520 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 2.2 | 11.033 ns | 0.0170 ns | 0.0151 ns | 11.030 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 3.0 |  7.130 ns | 0.0479 ns | 0.0449 ns |  7.119 ns |  0.57 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net461 | 13.750 ns | 0.0212 ns | 0.0198 ns | 13.755 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net472 | 12.140 ns | 0.0146 ns | 0.0129 ns | 12.144 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.222 ns | 0.0784 ns | 0.0734 ns | 18.197 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.400 ns | 0.0221 ns | 0.0184 ns | 15.398 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.865 ns | 0.6548 ns | 0.8963 ns | 15.453 ns |  0.89 |    0.06 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net461 | 19.358 ns | 0.0452 ns | 0.0423 ns | 19.357 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net472 | 22.054 ns | 0.1521 ns | 0.1422 ns | 22.141 ns |  1.21 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_SByte_Nullable_NoValue | .NET Core 2.0 | 12.367 ns | 0.0583 ns | 0.0545 ns | 12.384 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 2.2 | 10.844 ns | 0.0162 ns | 0.0143 ns | 10.843 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 3.0 |  8.476 ns | 0.1939 ns | 0.4004 ns |  8.295 ns |  0.72 |    0.04 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net461 | 12.992 ns | 0.0193 ns | 0.0171 ns | 12.993 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net472 | 10.470 ns | 0.0321 ns | 0.0300 ns | 10.468 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.009 ns | 0.0228 ns | 0.0202 ns | 15.008 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.953 ns | 0.0144 ns | 0.0135 ns | 11.952 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.662 ns | 0.2746 ns | 0.2696 ns | 12.728 ns |  0.84 |    0.02 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net461 | 13.259 ns | 0.0159 ns | 0.0149 ns | 13.255 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net472 | 16.665 ns | 0.0341 ns | 0.0266 ns | 16.669 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_Float | .NET Core 2.0 | 14.204 ns | 0.0403 ns | 0.0357 ns | 14.200 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 2.2 | 13.207 ns | 0.0497 ns | 0.0465 ns | 13.196 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 3.0 |  9.599 ns | 0.1064 ns | 0.0943 ns |  9.566 ns |  0.68 |    0.01 |      - |     - |     - |         - |
                                            From_Float |        net461 | 15.891 ns | 0.0195 ns | 0.0173 ns | 15.891 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                            From_Float |        net472 | 14.345 ns | 0.0430 ns | 0.0335 ns | 14.352 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_Float_AsObject | .NET Core 2.0 | 21.528 ns | 0.1933 ns | 0.1808 ns | 21.562 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 2.2 | 17.525 ns | 0.0267 ns | 0.0223 ns | 17.525 ns |  0.81 |    0.01 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 3.0 | 18.283 ns | 0.0976 ns | 0.0913 ns | 18.269 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                                   From_Float_AsObject |        net461 | 22.470 ns | 0.0605 ns | 0.0536 ns | 22.469 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                   From_Float_AsObject |        net472 | 24.228 ns | 0.0474 ns | 0.0420 ns | 24.220 ns |  1.13 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Float_Nullable_WithValue | .NET Core 2.0 | 13.985 ns | 0.0369 ns | 0.0328 ns | 13.985 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 2.2 | 13.573 ns | 0.0391 ns | 0.0366 ns | 13.574 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 3.0 | 10.390 ns | 0.0805 ns | 0.0714 ns | 10.389 ns |  0.74 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net461 | 15.187 ns | 0.0246 ns | 0.0218 ns | 15.185 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net472 | 15.752 ns | 0.0401 ns | 0.0375 ns | 15.742 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.0 | 21.084 ns | 0.0338 ns | 0.0317 ns | 21.092 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.510 ns | 0.0444 ns | 0.0347 ns | 17.501 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.572 ns | 0.2007 ns | 0.1779 ns | 18.592 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net461 | 22.408 ns | 0.0368 ns | 0.0345 ns | 22.394 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net472 | 25.047 ns | 0.0562 ns | 0.0498 ns | 25.048 ns |  1.19 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Float_Nullable_NoValue | .NET Core 2.0 | 13.366 ns | 0.0678 ns | 0.0635 ns | 13.383 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 2.2 | 11.088 ns | 0.1195 ns | 0.1117 ns | 11.119 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 3.0 |  6.937 ns | 0.0246 ns | 0.0230 ns |  6.929 ns |  0.52 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net461 | 11.913 ns | 0.0459 ns | 0.0429 ns | 11.920 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net472 | 10.475 ns | 0.0152 ns | 0.0127 ns | 10.472 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.136 ns | 0.0179 ns | 0.0167 ns | 14.133 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.962 ns | 0.0158 ns | 0.0123 ns | 11.959 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 3.0 | 15.064 ns | 0.1686 ns | 0.1494 ns | 15.072 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net461 | 13.303 ns | 0.0242 ns | 0.0227 ns | 13.301 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net472 | 15.106 ns | 0.1628 ns | 0.1523 ns | 15.037 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_String | .NET Core 2.0 | 58.820 ns | 0.0546 ns | 0.0426 ns | 58.831 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 2.2 | 54.820 ns | 0.3288 ns | 0.3076 ns | 54.905 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                                           From_String | .NET Core 3.0 | 21.110 ns | 0.4383 ns | 0.4305 ns | 20.949 ns |  0.36 |    0.01 |      - |     - |     - |         - |
                                           From_String |        net461 | 59.226 ns | 0.2202 ns | 0.2059 ns | 59.211 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                           From_String |        net472 | 60.248 ns | 0.1979 ns | 0.1851 ns | 60.274 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_String_AsObject | .NET Core 2.0 | 63.576 ns | 0.1261 ns | 0.1053 ns | 63.566 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 2.2 | 61.032 ns | 0.1221 ns | 0.1082 ns | 61.062 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 3.0 | 23.668 ns | 0.1849 ns | 0.1544 ns | 23.621 ns |  0.37 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject |        net461 | 64.438 ns | 0.1553 ns | 0.1452 ns | 64.434 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject |        net472 | 68.190 ns | 0.4380 ns | 0.3883 ns | 68.300 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                      From_String_Null | .NET Core 2.0 | 12.392 ns | 0.0162 ns | 0.0151 ns | 12.387 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 2.2 | 12.995 ns | 0.0264 ns | 0.0247 ns | 12.987 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 3.0 | 11.486 ns | 0.2245 ns | 0.2100 ns | 11.339 ns |  0.93 |    0.02 |      - |     - |     - |         - |
                                      From_String_Null |        net461 | 12.834 ns | 0.0234 ns | 0.0219 ns | 12.833 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null |        net472 | 14.848 ns | 0.0205 ns | 0.0181 ns | 14.852 ns |  1.20 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_String_Null_AsObject | .NET Core 2.0 | 14.117 ns | 0.0174 ns | 0.0145 ns | 14.115 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 2.2 | 12.066 ns | 0.0923 ns | 0.0864 ns | 12.116 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 3.0 | 13.838 ns | 0.3074 ns | 0.2876 ns | 13.714 ns |  0.98 |    0.02 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net461 | 13.380 ns | 0.0563 ns | 0.0499 ns | 13.358 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net472 | 17.076 ns | 0.0217 ns | 0.0181 ns | 17.071 ns |  1.21 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_String_Empty | .NET Core 2.0 | 13.069 ns | 0.0715 ns | 0.0634 ns | 13.051 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 2.2 | 12.886 ns | 0.0207 ns | 0.0173 ns | 12.886 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 3.0 | 11.766 ns | 0.2553 ns | 0.2388 ns | 11.839 ns |  0.90 |    0.02 |      - |     - |     - |         - |
                                     From_String_Empty |        net461 | 12.812 ns | 0.0240 ns | 0.0225 ns | 12.810 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                                     From_String_Empty |        net472 | 14.499 ns | 0.0238 ns | 0.0223 ns | 14.500 ns |  1.11 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_String_Empty_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_UShort | .NET Core 2.0 | 12.827 ns | 0.0238 ns | 0.0186 ns | 12.828 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 2.2 | 11.017 ns | 0.0982 ns | 0.0871 ns | 11.056 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 3.0 |  7.300 ns | 0.1399 ns | 0.1240 ns |  7.240 ns |  0.57 |    0.01 |      - |     - |     - |         - |
                                           From_UShort |        net461 | 13.232 ns | 0.0209 ns | 0.0185 ns | 13.234 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                           From_UShort |        net472 | 11.053 ns | 0.0987 ns | 0.0924 ns | 11.110 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_UShort_AsObject | .NET Core 2.0 | 18.203 ns | 0.0401 ns | 0.0356 ns | 18.199 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 2.2 | 15.397 ns | 0.0490 ns | 0.0409 ns | 15.402 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 3.0 | 15.850 ns | 0.1879 ns | 0.1666 ns | 15.798 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net461 | 19.352 ns | 0.0384 ns | 0.0340 ns | 19.352 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net472 | 21.420 ns | 0.0880 ns | 0.0823 ns | 21.423 ns |  1.18 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_UShort_Nullable_WithValue | .NET Core 2.0 | 12.554 ns | 0.0201 ns | 0.0178 ns | 12.554 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 2.2 | 11.158 ns | 0.0524 ns | 0.0490 ns | 11.177 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 3.0 |  7.200 ns | 0.1709 ns | 0.1678 ns |  7.253 ns |  0.57 |    0.01 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net461 | 13.731 ns | 0.0389 ns | 0.0324 ns | 13.731 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net472 | 12.222 ns | 0.1158 ns | 0.1083 ns | 12.163 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.434 ns | 0.0364 ns | 0.0304 ns | 18.434 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.376 ns | 0.0233 ns | 0.0207 ns | 15.370 ns |  0.83 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.253 ns | 0.0645 ns | 0.0539 ns | 17.246 ns |  0.94 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net461 | 19.573 ns | 0.0432 ns | 0.0361 ns | 19.570 ns |  1.06 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net472 | 21.896 ns | 0.0598 ns | 0.0559 ns | 21.894 ns |  1.19 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_UShort_Nullable_NoValue | .NET Core 2.0 | 11.699 ns | 0.0201 ns | 0.0178 ns | 11.695 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 2.2 | 10.900 ns | 0.0875 ns | 0.0819 ns | 10.853 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 3.0 |  7.081 ns | 0.1011 ns | 0.0946 ns |  7.063 ns |  0.60 |    0.01 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net461 | 11.783 ns | 0.0224 ns | 0.0210 ns | 11.779 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net472 | 10.465 ns | 0.0115 ns | 0.0096 ns | 10.469 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.138 ns | 0.0297 ns | 0.0264 ns | 14.131 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.044 ns | 0.0993 ns | 0.0929 ns | 12.043 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 3.0 | 16.130 ns | 0.1605 ns | 0.1341 ns | 16.155 ns |  1.14 |    0.01 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net461 | 13.439 ns | 0.0740 ns | 0.0656 ns | 13.461 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net472 | 16.663 ns | 0.0268 ns | 0.0238 ns | 16.675 ns |  1.18 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_UInt | .NET Core 2.0 | 11.634 ns | 0.0375 ns | 0.0351 ns | 11.631 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 2.2 | 10.972 ns | 0.0958 ns | 0.0896 ns | 11.006 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 3.0 |  7.250 ns | 0.1669 ns | 0.1639 ns |  7.250 ns |  0.62 |    0.01 |      - |     - |     - |         - |
                                             From_UInt |        net461 | 12.803 ns | 0.0085 ns | 0.0075 ns | 12.805 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                             From_UInt |        net472 | 12.416 ns | 0.0283 ns | 0.0251 ns | 12.416 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_UInt_AsObject | .NET Core 2.0 | 18.177 ns | 0.0273 ns | 0.0242 ns | 18.174 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 2.2 | 15.555 ns | 0.0166 ns | 0.0156 ns | 15.550 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 3.0 | 15.345 ns | 0.1014 ns | 0.0899 ns | 15.341 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net461 | 19.571 ns | 0.0476 ns | 0.0422 ns | 19.559 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net472 | 21.907 ns | 0.0410 ns | 0.0363 ns | 21.889 ns |  1.21 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_UInt_Nullable_WithValue | .NET Core 2.0 | 11.925 ns | 0.0113 ns | 0.0100 ns | 11.926 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 2.2 | 11.017 ns | 0.0534 ns | 0.0500 ns | 10.993 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 3.0 |  7.175 ns | 0.0314 ns | 0.0262 ns |  7.176 ns |  0.60 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net461 | 14.090 ns | 0.0271 ns | 0.0253 ns | 14.083 ns |  1.18 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net472 | 13.403 ns | 0.0303 ns | 0.0253 ns | 13.393 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.481 ns | 0.0928 ns | 0.0868 ns | 18.486 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.489 ns | 0.1355 ns | 0.1267 ns | 15.549 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.419 ns | 0.2363 ns | 0.2095 ns | 15.363 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net461 | 19.961 ns | 0.0455 ns | 0.0380 ns | 19.962 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net472 | 21.950 ns | 0.0530 ns | 0.0470 ns | 21.951 ns |  1.19 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_UInt_Nullable_NoValue | .NET Core 2.0 | 12.189 ns | 0.0171 ns | 0.0143 ns | 12.186 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 2.2 | 10.790 ns | 0.0221 ns | 0.0206 ns | 10.796 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 3.0 |  6.760 ns | 0.0693 ns | 0.0648 ns |  6.722 ns |  0.55 |    0.01 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net461 | 11.799 ns | 0.0331 ns | 0.0294 ns | 11.793 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net472 | 10.449 ns | 0.0122 ns | 0.0108 ns | 10.446 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.826 ns | 0.0131 ns | 0.0116 ns | 14.827 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.964 ns | 0.0171 ns | 0.0151 ns | 12.967 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.445 ns | 0.1392 ns | 0.1302 ns | 12.452 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net461 | 13.715 ns | 0.0814 ns | 0.0721 ns | 13.730 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net472 | 14.968 ns | 0.0458 ns | 0.0406 ns | 14.966 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_ULong | .NET Core 2.0 | 12.372 ns | 0.1069 ns | 0.1000 ns | 12.381 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 2.2 | 11.587 ns | 0.1631 ns | 0.1525 ns | 11.659 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 3.0 |  7.403 ns | 0.0687 ns | 0.0609 ns |  7.372 ns |  0.60 |    0.01 |      - |     - |     - |         - |
                                            From_ULong |        net461 | 13.249 ns | 0.0185 ns | 0.0164 ns | 13.248 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                                            From_ULong |        net472 | 10.713 ns | 0.0306 ns | 0.0271 ns | 10.712 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_ULong_AsObject | .NET Core 2.0 | 18.811 ns | 0.2782 ns | 0.2603 ns | 18.720 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 2.2 | 16.122 ns | 0.0297 ns | 0.0278 ns | 16.128 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 3.0 | 17.212 ns | 0.0801 ns | 0.0710 ns | 17.184 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net461 | 19.366 ns | 0.0314 ns | 0.0262 ns | 19.370 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net472 | 20.653 ns | 0.0377 ns | 0.0334 ns | 20.654 ns |  1.10 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_ULong_Nullable_WithValue | .NET Core 2.0 | 13.697 ns | 0.0240 ns | 0.0225 ns | 13.700 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 2.2 | 13.331 ns | 0.0387 ns | 0.0362 ns | 13.321 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 3.0 | 10.580 ns | 0.0971 ns | 0.0861 ns | 10.562 ns |  0.77 |    0.01 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net461 | 14.551 ns | 0.0206 ns | 0.0183 ns | 14.550 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net472 | 13.846 ns | 0.0276 ns | 0.0231 ns | 13.844 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.278 ns | 0.0408 ns | 0.0382 ns | 19.278 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.2 | 16.308 ns | 0.1136 ns | 0.1007 ns | 16.347 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 3.0 | 16.683 ns | 0.4178 ns | 0.3704 ns | 16.512 ns |  0.87 |    0.02 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net461 | 19.439 ns | 0.0402 ns | 0.0356 ns | 19.450 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net472 | 21.658 ns | 0.0419 ns | 0.0327 ns | 21.666 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_ULong_Nullable_NoValue | .NET Core 2.0 | 12.675 ns | 0.1130 ns | 0.1057 ns | 12.612 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 2.2 | 11.916 ns | 0.0189 ns | 0.0168 ns | 11.919 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 3.0 |  8.183 ns | 0.0624 ns | 0.0584 ns |  8.162 ns |  0.65 |    0.01 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net461 | 13.487 ns | 0.0269 ns | 0.0251 ns | 13.484 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net472 | 14.500 ns | 0.0288 ns | 0.0270 ns | 14.499 ns |  1.14 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.515 ns | 0.0193 ns | 0.0181 ns | 14.509 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.915 ns | 0.0232 ns | 0.0194 ns | 11.915 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.281 ns | 0.1134 ns | 0.1061 ns | 12.249 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net461 | 13.266 ns | 0.0165 ns | 0.0155 ns | 13.266 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net472 | 14.968 ns | 0.0210 ns | 0.0186 ns | 14.974 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                       From_NullObject | .NET Core 2.0 | 14.171 ns | 0.0170 ns | 0.0142 ns | 14.168 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 2.2 | 12.055 ns | 0.1022 ns | 0.0956 ns | 12.113 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 3.0 | 12.167 ns | 0.0274 ns | 0.0214 ns | 12.170 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject |        net461 | 13.249 ns | 0.0191 ns | 0.0170 ns | 13.252 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject |        net472 | 16.647 ns | 0.0336 ns | 0.0281 ns | 16.654 ns |  1.17 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_DBNull | .NET Core 2.0 | 11.542 ns | 0.0300 ns | 0.0280 ns | 11.536 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 2.2 |  9.369 ns | 0.0574 ns | 0.0537 ns |  9.366 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 3.0 | 10.969 ns | 0.0628 ns | 0.0524 ns | 10.966 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                                           From_DBNull |        net461 | 11.096 ns | 0.0241 ns | 0.0214 ns | 11.093 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull |        net472 | 11.271 ns | 0.0249 ns | 0.0208 ns | 11.271 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_DBNull_AsObject | .NET Core 2.0 | 14.177 ns | 0.0191 ns | 0.0178 ns | 14.179 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 2.2 | 11.918 ns | 0.0192 ns | 0.0160 ns | 11.919 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 3.0 | 13.855 ns | 0.2726 ns | 0.2677 ns | 13.738 ns |  0.98 |    0.02 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net461 | 13.288 ns | 0.0348 ns | 0.0308 ns | 13.282 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net472 | 16.684 ns | 0.0189 ns | 0.0148 ns | 16.687 ns |  1.18 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                 From_ConvertibleClass | .NET Core 2.0 | 15.076 ns | 0.0267 ns | 0.0250 ns | 15.079 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 2.2 | 13.344 ns | 0.0326 ns | 0.0272 ns | 13.340 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 3.0 | 14.872 ns | 0.1618 ns | 0.1513 ns | 14.885 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net461 | 18.422 ns | 0.0712 ns | 0.0666 ns | 18.405 ns |  1.22 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net472 | 17.256 ns | 0.2296 ns | 0.2148 ns | 17.380 ns |  1.14 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_ConvertibleClass_AsObject | .NET Core 2.0 | 17.876 ns | 0.0386 ns | 0.0322 ns | 17.876 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 2.2 | 14.319 ns | 0.0091 ns | 0.0076 ns | 14.318 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 3.0 | 17.041 ns | 0.3252 ns | 0.3042 ns | 17.008 ns |  0.95 |    0.02 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net461 | 16.665 ns | 0.0234 ns | 0.0219 ns | 16.661 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net472 | 19.482 ns | 0.0742 ns | 0.0658 ns | 19.468 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_ConvertibleClass_NoValue | .NET Core 2.0 | 13.437 ns | 0.0117 ns | 0.0103 ns | 13.434 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 2.2 | 13.865 ns | 0.0174 ns | 0.0154 ns | 13.865 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 3.0 | 12.554 ns | 0.2724 ns | 0.2676 ns | 12.592 ns |  0.93 |    0.02 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net461 | 14.921 ns | 0.0238 ns | 0.0222 ns | 14.915 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net472 | 13.231 ns | 0.0128 ns | 0.0113 ns | 13.234 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.0 | 14.846 ns | 0.0131 ns | 0.0110 ns | 14.847 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.2 | 12.948 ns | 0.0264 ns | 0.0247 ns | 12.952 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 3.0 | 12.963 ns | 0.0999 ns | 0.0834 ns | 12.958 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net461 | 13.492 ns | 0.0570 ns | 0.0533 ns | 13.465 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net472 | 15.206 ns | 0.0767 ns | 0.0717 ns | 15.218 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                              From_NonConvertibleClass | .NET Core 2.0 | 12.041 ns | 0.0241 ns | 0.0201 ns | 12.040 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 2.2 | 11.579 ns | 0.0128 ns | 0.0120 ns | 11.578 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 3.0 | 11.349 ns | 0.0208 ns | 0.0174 ns | 11.355 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net461 | 14.084 ns | 0.1538 ns | 0.1438 ns | 14.156 ns |  1.17 |    0.01 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net472 | 12.652 ns | 0.0259 ns | 0.0203 ns | 12.657 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                     From_NonConvertibleClass_AsObject | .NET Core 2.0 | 15.489 ns | 0.0320 ns | 0.0300 ns | 15.489 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 2.2 | 13.335 ns | 0.0203 ns | 0.0169 ns | 13.333 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 3.0 | 13.021 ns | 0.0255 ns | 0.0226 ns | 13.025 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net461 | 15.246 ns | 0.1047 ns | 0.0928 ns | 15.284 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net472 | 18.142 ns | 0.0789 ns | 0.0700 ns | 18.120 ns |  1.17 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                      From_NonConvertibleClass_NoValue | .NET Core 2.0 | 12.666 ns | 0.1028 ns | 0.0962 ns | 12.617 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 2.2 | 11.182 ns | 0.0207 ns | 0.0194 ns | 11.187 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 3.0 | 10.740 ns | 0.0248 ns | 0.0220 ns | 10.736 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net461 | 12.568 ns | 0.0367 ns | 0.0325 ns | 12.553 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net472 | 12.871 ns | 0.0223 ns | 0.0198 ns | 12.869 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.0 | 14.663 ns | 0.1185 ns | 0.1108 ns | 14.711 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.2 | 11.918 ns | 0.0147 ns | 0.0130 ns | 11.913 ns |  0.81 |    0.01 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 3.0 | 12.017 ns | 0.0424 ns | 0.0331 ns | 12.009 ns |  0.82 |    0.01 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net461 | 13.282 ns | 0.0204 ns | 0.0181 ns | 13.276 ns |  0.91 |    0.01 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net472 | 16.722 ns | 0.0313 ns | 0.0293 ns | 16.716 ns |  1.14 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                From_ConvertibleStruct | .NET Core 2.0 | 19.503 ns | 0.0637 ns | 0.0596 ns | 19.509 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 2.2 | 16.300 ns | 0.0547 ns | 0.0427 ns | 16.306 ns |  0.84 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 3.0 | 12.040 ns | 0.2566 ns | 0.2635 ns | 11.877 ns |  0.62 |    0.01 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net461 | 19.570 ns | 0.1045 ns | 0.0978 ns | 19.593 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net472 | 17.354 ns | 0.1399 ns | 0.1309 ns | 17.283 ns |  0.89 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                       From_ConvertibleStruct_AsObject | .NET Core 2.0 | 16.982 ns | 0.0725 ns | 0.0605 ns | 16.977 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 2.2 | 15.102 ns | 0.0291 ns | 0.0272 ns | 15.103 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 3.0 | 15.689 ns | 0.1106 ns | 0.1034 ns | 15.656 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net461 | 17.358 ns | 0.0445 ns | 0.0416 ns | 17.365 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net472 | 20.699 ns | 0.0543 ns | 0.0508 ns | 20.696 ns |  1.22 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.0 | 19.507 ns | 0.2004 ns | 0.1875 ns | 19.557 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.2 | 15.899 ns | 0.0200 ns | 0.0167 ns | 15.895 ns |  0.81 |    0.01 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 3.0 | 12.717 ns | 0.0314 ns | 0.0278 ns | 12.717 ns |  0.65 |    0.01 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net461 | 20.071 ns | 0.0375 ns | 0.0350 ns | 20.065 ns |  1.03 |    0.01 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net472 | 17.945 ns | 0.0320 ns | 0.0284 ns | 17.940 ns |  0.92 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 16.991 ns | 0.0335 ns | 0.0297 ns | 16.995 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 14.860 ns | 0.0409 ns | 0.0341 ns | 14.859 ns |  0.87 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.382 ns | 0.1123 ns | 0.1050 ns | 15.358 ns |  0.90 |    0.01 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net461 | 17.593 ns | 0.1245 ns | 0.1103 ns | 17.622 ns |  1.04 |    0.01 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net472 | 19.600 ns | 0.0669 ns | 0.0559 ns | 19.576 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.0 | 13.189 ns | 0.0296 ns | 0.0247 ns | 13.192 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.2 | 11.777 ns | 0.0202 ns | 0.0179 ns | 11.777 ns |  0.89 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 3.0 |  7.950 ns | 0.0409 ns | 0.0382 ns |  7.946 ns |  0.60 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net461 | 12.681 ns | 0.0257 ns | 0.0228 ns | 12.675 ns |  0.96 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net472 | 10.604 ns | 0.0184 ns | 0.0172 ns | 10.608 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.138 ns | 0.0609 ns | 0.0540 ns | 14.122 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.899 ns | 0.0127 ns | 0.0113 ns | 11.898 ns |  0.84 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.179 ns | 0.1733 ns | 0.1621 ns | 12.286 ns |  0.86 |    0.01 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net461 | 13.284 ns | 0.0220 ns | 0.0206 ns | 13.290 ns |  0.94 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net472 | 15.972 ns | 0.0408 ns | 0.0362 ns | 15.959 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_NonConvertibleStruct | .NET Core 2.0 | 13.002 ns | 0.0208 ns | 0.0195 ns | 13.004 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 2.2 | 11.598 ns | 0.0374 ns | 0.0312 ns | 11.590 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 3.0 |  6.871 ns | 0.0067 ns | 0.0056 ns |  6.872 ns |  0.53 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net461 | 13.008 ns | 0.1074 ns | 0.1005 ns | 13.042 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net472 | 10.396 ns | 0.0136 ns | 0.0106 ns | 10.396 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.0 | 15.066 ns | 0.0244 ns | 0.0228 ns | 15.063 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.2 | 13.327 ns | 0.0308 ns | 0.0273 ns | 13.328 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 3.0 | 13.902 ns | 0.0988 ns | 0.0924 ns | 13.941 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net461 | 15.100 ns | 0.0435 ns | 0.0406 ns | 15.090 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net472 | 18.110 ns | 0.0431 ns | 0.0382 ns | 18.124 ns |  1.20 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.0 | 12.999 ns | 0.0297 ns | 0.0278 ns | 12.999 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.2 | 11.638 ns | 0.0191 ns | 0.0169 ns | 11.637 ns |  0.90 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 3.0 |  6.762 ns | 0.1603 ns | 0.1646 ns |  6.694 ns |  0.52 |    0.01 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net461 | 11.889 ns | 0.0234 ns | 0.0219 ns | 11.892 ns |  0.91 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net472 | 10.411 ns | 0.0609 ns | 0.0570 ns | 10.388 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 15.025 ns | 0.0326 ns | 0.0305 ns | 15.036 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 13.393 ns | 0.1016 ns | 0.0950 ns | 13.335 ns |  0.89 |    0.01 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 13.866 ns | 0.1031 ns | 0.0964 ns | 13.830 ns |  0.92 |    0.01 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net461 | 15.620 ns | 0.0292 ns | 0.0273 ns | 15.621 ns |  1.04 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net472 | 17.052 ns | 0.1392 ns | 0.1302 ns | 17.116 ns |  1.13 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.0 | 12.914 ns | 0.0179 ns | 0.0149 ns | 12.914 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.2 | 11.651 ns | 0.0247 ns | 0.0231 ns | 11.653 ns |  0.90 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 3.0 |  6.920 ns | 0.0305 ns | 0.0285 ns |  6.917 ns |  0.54 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net461 | 12.559 ns | 0.0319 ns | 0.0299 ns | 12.555 ns |  0.97 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net472 | 11.792 ns | 0.0263 ns | 0.0246 ns | 11.786 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.195 ns | 0.0558 ns | 0.0522 ns | 14.176 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.898 ns | 0.0096 ns | 0.0085 ns | 11.897 ns |  0.84 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.994 ns | 0.0177 ns | 0.0138 ns | 11.995 ns |  0.84 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net461 | 13.256 ns | 0.0098 ns | 0.0082 ns | 13.254 ns |  0.93 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net472 | 15.121 ns | 0.0197 ns | 0.0165 ns | 15.124 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Enum | .NET Core 2.0 | 14.179 ns | 0.0274 ns | 0.0229 ns | 14.191 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 2.2 | 12.971 ns | 0.0217 ns | 0.0203 ns | 12.972 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 3.0 |  7.554 ns | 0.0209 ns | 0.0174 ns |  7.549 ns |  0.53 |    0.00 |      - |     - |     - |         - |
                                             From_Enum |        net461 | 12.484 ns | 0.0226 ns | 0.0177 ns | 12.489 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                             From_Enum |        net472 | 11.028 ns | 0.0489 ns | 0.0457 ns | 11.055 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Enum_AsObject | .NET Core 2.0 | 46.856 ns | 0.0576 ns | 0.0539 ns | 46.868 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject | .NET Core 2.2 | 43.537 ns | 0.1123 ns | 0.0995 ns | 43.524 ns |  0.93 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject | .NET Core 3.0 | 35.027 ns | 0.3667 ns | 0.3430 ns | 35.036 ns |  0.75 |    0.01 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject |        net461 | 43.007 ns | 0.1690 ns | 0.1498 ns | 42.965 ns |  0.92 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject |        net472 | 47.871 ns | 0.1197 ns | 0.1119 ns | 47.831 ns |  1.02 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Enum_Nullable_WithValue | .NET Core 2.0 | 13.908 ns | 0.0187 ns | 0.0166 ns | 13.905 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 2.2 | 11.628 ns | 0.0276 ns | 0.0258 ns | 11.638 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 3.0 |  8.174 ns | 0.0090 ns | 0.0084 ns |  8.174 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net461 | 14.122 ns | 0.1347 ns | 0.1260 ns | 14.114 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net472 | 13.244 ns | 0.0229 ns | 0.0215 ns | 13.245 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.0 | 44.846 ns | 0.0368 ns | 0.0344 ns | 44.844 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.2 | 43.533 ns | 0.1733 ns | 0.1448 ns | 43.502 ns |  0.97 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 3.0 | 33.982 ns | 0.1953 ns | 0.1631 ns | 33.963 ns |  0.76 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject |        net461 | 42.984 ns | 0.1559 ns | 0.1382 ns | 42.979 ns |  0.96 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject |        net472 | 47.791 ns | 0.2488 ns | 0.2327 ns | 47.779 ns |  1.07 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Enum_Nullable_NoValue | .NET Core 2.0 | 13.047 ns | 0.0194 ns | 0.0172 ns | 13.046 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 2.2 | 10.298 ns | 0.0265 ns | 0.0235 ns | 10.292 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 3.0 |  6.993 ns | 0.0157 ns | 0.0147 ns |  6.992 ns |  0.54 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net461 | 12.573 ns | 0.0091 ns | 0.0080 ns | 12.572 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net472 | 11.983 ns | 0.0136 ns | 0.0114 ns | 11.981 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.533 ns | 0.1335 ns | 0.1249 ns | 14.457 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.926 ns | 0.0125 ns | 0.0117 ns | 11.929 ns |  0.82 |    0.01 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.408 ns | 0.2423 ns | 0.2488 ns | 11.240 ns |  0.79 |    0.01 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net461 | 13.456 ns | 0.0825 ns | 0.0731 ns | 13.483 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net472 | 16.881 ns | 0.0704 ns | 0.0659 ns | 16.911 ns |  1.16 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                      From_ParentClass | .NET Core 2.0 | 11.967 ns | 0.0169 ns | 0.0158 ns | 11.966 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 2.2 | 11.263 ns | 0.0876 ns | 0.0819 ns | 11.292 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 3.0 | 10.955 ns | 0.2297 ns | 0.2149 ns | 10.807 ns |  0.92 |    0.02 |      - |     - |     - |         - |
                                      From_ParentClass |        net461 | 13.893 ns | 0.0227 ns | 0.0212 ns | 13.900 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass |        net472 | 14.111 ns | 0.0359 ns | 0.0336 ns | 14.098 ns |  1.18 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_ParentClass_AsObject | .NET Core 2.0 | 16.490 ns | 0.0306 ns | 0.0255 ns | 16.492 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 2.2 | 13.678 ns | 0.0278 ns | 0.0260 ns | 13.674 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 3.0 | 13.955 ns | 0.0821 ns | 0.0728 ns | 13.945 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net461 | 15.325 ns | 0.0365 ns | 0.0323 ns | 15.312 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net472 | 17.336 ns | 0.1077 ns | 0.1008 ns | 17.289 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                              From_ParentClass_NoValue | .NET Core 2.0 | 14.165 ns | 0.1009 ns | 0.0944 ns | 14.200 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 2.2 | 11.775 ns | 0.0291 ns | 0.0243 ns | 11.767 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 3.0 | 10.809 ns | 0.0765 ns | 0.0716 ns | 10.809 ns |  0.76 |    0.01 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net461 | 12.535 ns | 0.0968 ns | 0.0905 ns | 12.572 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net472 | 12.751 ns | 0.0555 ns | 0.0519 ns | 12.765 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.0 | 14.109 ns | 0.0182 ns | 0.0161 ns | 14.113 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.2 | 12.049 ns | 0.0994 ns | 0.0930 ns | 12.091 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 3.0 | 12.613 ns | 0.2696 ns | 0.2884 ns | 12.720 ns |  0.89 |    0.02 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net461 | 13.318 ns | 0.0117 ns | 0.0110 ns | 13.321 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net472 | 16.105 ns | 0.0205 ns | 0.0192 ns | 16.109 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_ParentStruct | .NET Core 2.0 | 38.989 ns | 0.0689 ns | 0.0611 ns | 38.993 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 2.2 | 37.160 ns | 0.0299 ns | 0.0250 ns | 37.162 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 3.0 | 35.926 ns | 0.1102 ns | 0.0977 ns | 35.909 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct |        net461 | 39.487 ns | 0.0767 ns | 0.0641 ns | 39.478 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct |        net472 | 45.264 ns | 0.1252 ns | 0.1046 ns | 45.250 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_ParentStruct_AsObject | .NET Core 2.0 | 15.793 ns | 0.1369 ns | 0.1280 ns | 15.861 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 2.2 | 14.294 ns | 0.0492 ns | 0.0460 ns | 14.278 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 3.0 | 13.410 ns | 0.1496 ns | 0.1400 ns | 13.432 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net461 | 15.317 ns | 0.0419 ns | 0.0350 ns | 15.321 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net472 | 18.473 ns | 0.0533 ns | 0.0499 ns | 18.472 ns |  1.17 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.0 | 40.610 ns | 0.0510 ns | 0.0477 ns | 40.603 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.2 | 38.287 ns | 0.3742 ns | 0.3500 ns | 38.528 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 3.0 | 34.833 ns | 0.2982 ns | 0.2789 ns | 35.012 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue |        net461 | 39.639 ns | 0.0384 ns | 0.0359 ns | 39.643 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue |        net472 | 39.518 ns | 0.1374 ns | 0.1285 ns | 39.477 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 15.507 ns | 0.0361 ns | 0.0320 ns | 15.507 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 13.560 ns | 0.0154 ns | 0.0137 ns | 13.564 ns |  0.87 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 14.056 ns | 0.1176 ns | 0.1100 ns | 14.120 ns |  0.91 |    0.01 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net461 | 15.353 ns | 0.0464 ns | 0.0411 ns | 15.358 ns |  0.99 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net472 | 18.188 ns | 0.0164 ns | 0.0153 ns | 18.188 ns |  1.17 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.0 | 39.642 ns | 0.2382 ns | 0.2228 ns | 39.718 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.2 | 38.933 ns | 0.1524 ns | 0.1426 ns | 38.885 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 3.0 | 37.613 ns | 0.7667 ns | 1.3825 ns | 36.699 ns |  0.99 |    0.03 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net461 | 38.841 ns | 0.0745 ns | 0.0661 ns | 38.841 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net472 | 38.263 ns | 0.0409 ns | 0.0342 ns | 38.271 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.999 ns | 0.0194 ns | 0.0182 ns | 13.998 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.057 ns | 0.0886 ns | 0.0829 ns | 12.090 ns |  0.86 |    0.01 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.394 ns | 0.1350 ns | 0.1263 ns | 14.442 ns |  1.03 |    0.01 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net461 | 13.381 ns | 0.0278 ns | 0.0246 ns | 13.382 ns |  0.96 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net472 | 16.315 ns | 0.1013 ns | 0.0947 ns | 16.350 ns |  1.17 |    0.01 |      - |     - |     - |         - |

Benchmarks with issues:
  ConvertTo_Byte.From_DateTime_AsObject: Job-LRKCAO(Toolchain=.NET Core 2.0)
  ConvertTo_Byte.From_DateTime_AsObject: Job-VAJWLV(Toolchain=.NET Core 2.2)
  ConvertTo_Byte.From_DateTime_AsObject: Job-TJIRAH(Toolchain=.NET Core 3.0)
  ConvertTo_Byte.From_DateTime_AsObject: Job-HBFVIR(Toolchain=net461)
  ConvertTo_Byte.From_DateTime_AsObject: Job-YRWWQX(Toolchain=net472)
  ConvertTo_Byte.From_DateTime_Nullable_WithValue_AsObject: Job-LRKCAO(Toolchain=.NET Core 2.0)
  ConvertTo_Byte.From_DateTime_Nullable_WithValue_AsObject: Job-VAJWLV(Toolchain=.NET Core 2.2)
  ConvertTo_Byte.From_DateTime_Nullable_WithValue_AsObject: Job-TJIRAH(Toolchain=.NET Core 3.0)
  ConvertTo_Byte.From_DateTime_Nullable_WithValue_AsObject: Job-HBFVIR(Toolchain=net461)
  ConvertTo_Byte.From_DateTime_Nullable_WithValue_AsObject: Job-YRWWQX(Toolchain=net472)
  ConvertTo_Byte.From_String_Empty_AsObject: Job-LRKCAO(Toolchain=.NET Core 2.0)
  ConvertTo_Byte.From_String_Empty_AsObject: Job-VAJWLV(Toolchain=.NET Core 2.2)
  ConvertTo_Byte.From_String_Empty_AsObject: Job-TJIRAH(Toolchain=.NET Core 3.0)
  ConvertTo_Byte.From_String_Empty_AsObject: Job-HBFVIR(Toolchain=net461)
  ConvertTo_Byte.From_String_Empty_AsObject: Job-YRWWQX(Toolchain=net472)
