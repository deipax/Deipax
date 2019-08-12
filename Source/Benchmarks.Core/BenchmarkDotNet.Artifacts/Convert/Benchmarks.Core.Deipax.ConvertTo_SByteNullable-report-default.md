
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
                                             From_Bool | .NET Core 2.0 | 11.856 ns | 0.0121 ns | 0.0114 ns | 11.855 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 2.2 | 11.396 ns | 0.0678 ns | 0.0601 ns | 11.424 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 3.0 |  9.688 ns | 0.0495 ns | 0.0463 ns |  9.665 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                             From_Bool |        net461 | 12.309 ns | 0.0564 ns | 0.0500 ns | 12.321 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                             From_Bool |        net472 | 12.251 ns | 0.0340 ns | 0.0301 ns | 12.243 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Bool_AsObject | .NET Core 2.0 | 18.872 ns | 0.0388 ns | 0.0363 ns | 18.877 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 2.2 | 18.705 ns | 0.0204 ns | 0.0191 ns | 18.704 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 3.0 | 17.385 ns | 0.0266 ns | 0.0249 ns | 17.385 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net461 | 26.884 ns | 0.2182 ns | 0.2041 ns | 26.762 ns |  1.42 |    0.01 |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net472 | 29.373 ns | 0.0551 ns | 0.0516 ns | 29.383 ns |  1.56 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Bool_Nullable_WithValue | .NET Core 2.0 | 12.078 ns | 0.0205 ns | 0.0192 ns | 12.076 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 2.2 | 10.694 ns | 0.0122 ns | 0.0108 ns | 10.693 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 3.0 |  9.906 ns | 0.0194 ns | 0.0182 ns |  9.912 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net461 | 13.417 ns | 0.0271 ns | 0.0240 ns | 13.416 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net472 | 12.687 ns | 0.0165 ns | 0.0155 ns | 12.691 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.746 ns | 0.0309 ns | 0.0274 ns | 18.739 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.866 ns | 0.0897 ns | 0.0839 ns | 17.904 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.378 ns | 0.0271 ns | 0.0240 ns | 17.375 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net461 | 26.699 ns | 0.0731 ns | 0.0684 ns | 26.683 ns |  1.42 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net472 | 28.517 ns | 0.0290 ns | 0.0257 ns | 28.522 ns |  1.52 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Bool_Nullable_NoValue | .NET Core 2.0 | 11.963 ns | 0.0191 ns | 0.0169 ns | 11.963 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 2.2 | 10.974 ns | 0.0168 ns | 0.0141 ns | 10.974 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 3.0 | 10.125 ns | 0.0153 ns | 0.0136 ns | 10.122 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net461 | 13.426 ns | 0.0544 ns | 0.0509 ns | 13.404 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net472 | 12.778 ns | 0.0105 ns | 0.0098 ns | 12.781 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.548 ns | 0.0173 ns | 0.0145 ns | 14.548 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.398 ns | 0.0174 ns | 0.0154 ns | 13.394 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.125 ns | 0.0238 ns | 0.0223 ns | 13.126 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net461 | 22.599 ns | 0.0594 ns | 0.0527 ns | 22.607 ns |  1.55 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net472 | 22.662 ns | 0.0323 ns | 0.0270 ns | 22.670 ns |  1.56 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Byte | .NET Core 2.0 | 11.819 ns | 0.0070 ns | 0.0062 ns | 11.820 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 2.2 | 11.148 ns | 0.0563 ns | 0.0527 ns | 11.166 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 3.0 |  9.656 ns | 0.0201 ns | 0.0157 ns |  9.657 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                             From_Byte |        net461 | 12.902 ns | 0.0171 ns | 0.0160 ns | 12.901 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                             From_Byte |        net472 | 12.991 ns | 0.0095 ns | 0.0079 ns | 12.993 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Byte_AsObject | .NET Core 2.0 | 19.285 ns | 0.0165 ns | 0.0154 ns | 19.283 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 2.2 | 18.017 ns | 0.1040 ns | 0.0973 ns | 17.978 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 3.0 | 18.677 ns | 0.3209 ns | 0.3002 ns | 18.471 ns |  0.97 |    0.02 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net461 | 27.713 ns | 0.1112 ns | 0.1041 ns | 27.752 ns |  1.44 |    0.01 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net472 | 27.653 ns | 0.0510 ns | 0.0452 ns | 27.645 ns |  1.43 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Byte_Nullable_WithValue | .NET Core 2.0 | 12.054 ns | 0.0238 ns | 0.0223 ns | 12.050 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 2.2 | 11.412 ns | 0.0111 ns | 0.0104 ns | 11.413 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 3.0 | 10.343 ns | 0.0202 ns | 0.0189 ns | 10.341 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net461 | 13.296 ns | 0.0164 ns | 0.0137 ns | 13.297 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net472 | 13.273 ns | 0.0168 ns | 0.0149 ns | 13.271 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.827 ns | 0.0252 ns | 0.0210 ns | 19.826 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.2 | 18.135 ns | 0.0915 ns | 0.0856 ns | 18.154 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.280 ns | 0.0222 ns | 0.0197 ns | 17.276 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net461 | 29.195 ns | 0.0443 ns | 0.0414 ns | 29.198 ns |  1.47 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net472 | 27.538 ns | 0.0434 ns | 0.0406 ns | 27.538 ns |  1.39 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Byte_Nullable_NoValue | .NET Core 2.0 | 12.461 ns | 0.0182 ns | 0.0162 ns | 12.460 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 2.2 | 10.345 ns | 0.0104 ns | 0.0087 ns | 10.343 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 3.0 |  9.448 ns | 0.0098 ns | 0.0087 ns |  9.448 ns |  0.76 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net461 | 13.509 ns | 0.0811 ns | 0.0719 ns | 13.507 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net472 | 12.723 ns | 0.0358 ns | 0.0335 ns | 12.714 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.360 ns | 0.0355 ns | 0.0315 ns | 15.353 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.577 ns | 0.0141 ns | 0.0132 ns | 13.574 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.768 ns | 0.0301 ns | 0.0281 ns | 14.763 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net461 | 21.767 ns | 0.0488 ns | 0.0457 ns | 21.757 ns |  1.42 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net472 | 22.612 ns | 0.0352 ns | 0.0329 ns | 22.624 ns |  1.47 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Char | .NET Core 2.0 | 11.820 ns | 0.0140 ns | 0.0124 ns | 11.820 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Char | .NET Core 2.2 | 10.504 ns | 0.0138 ns | 0.0115 ns | 10.504 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                             From_Char | .NET Core 3.0 |  9.734 ns | 0.1107 ns | 0.0981 ns |  9.729 ns |  0.82 |    0.01 |      - |     - |     - |         - |
                                             From_Char |        net461 | 12.991 ns | 0.0955 ns | 0.0893 ns | 12.978 ns |  1.10 |    0.01 |      - |     - |     - |         - |
                                             From_Char |        net472 | 13.083 ns | 0.0420 ns | 0.0393 ns | 13.089 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Char_AsObject | .NET Core 2.0 | 19.985 ns | 0.0298 ns | 0.0279 ns | 19.990 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 2.2 | 18.652 ns | 0.0265 ns | 0.0235 ns | 18.640 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 3.0 | 17.544 ns | 0.0200 ns | 0.0177 ns | 17.541 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject |        net461 | 27.414 ns | 0.0388 ns | 0.0363 ns | 27.402 ns |  1.37 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject |        net472 | 29.179 ns | 0.0339 ns | 0.0317 ns | 29.187 ns |  1.46 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Char_Nullable_WithValue | .NET Core 2.0 | 13.091 ns | 0.1950 ns | 0.1824 ns | 13.165 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 2.2 | 11.311 ns | 0.0159 ns | 0.0149 ns | 11.314 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 3.0 | 10.760 ns | 0.8409 ns | 1.3338 ns | 10.017 ns |  0.89 |    0.11 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net461 | 16.904 ns | 0.0158 ns | 0.0148 ns | 16.901 ns |  1.29 |    0.02 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net472 | 13.953 ns | 0.2461 ns | 0.2302 ns | 13.993 ns |  1.07 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.356 ns | 0.0176 ns | 0.0156 ns | 19.355 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.2 | 18.858 ns | 0.1357 ns | 0.1269 ns | 18.892 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.533 ns | 0.0354 ns | 0.0314 ns | 17.530 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net461 | 27.127 ns | 0.0567 ns | 0.0502 ns | 27.129 ns |  1.40 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net472 | 27.571 ns | 0.0239 ns | 0.0212 ns | 27.578 ns |  1.42 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Char_Nullable_NoValue | .NET Core 2.0 | 12.042 ns | 0.0103 ns | 0.0097 ns | 12.041 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 2.2 | 10.732 ns | 0.0130 ns | 0.0102 ns | 10.729 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 3.0 |  9.916 ns | 0.0192 ns | 0.0180 ns |  9.925 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net461 | 12.715 ns | 0.0124 ns | 0.0110 ns | 12.718 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net472 | 12.791 ns | 0.0175 ns | 0.0164 ns | 12.794 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.577 ns | 0.0159 ns | 0.0141 ns | 14.577 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.870 ns | 0.0148 ns | 0.0131 ns | 13.867 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.687 ns | 0.0193 ns | 0.0171 ns | 13.687 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net461 | 24.217 ns | 0.0463 ns | 0.0433 ns | 24.213 ns |  1.66 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net472 | 22.515 ns | 0.0328 ns | 0.0307 ns | 22.514 ns |  1.54 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                         From_DateTime | .NET Core 2.0 | 12.857 ns | 0.0218 ns | 0.0182 ns | 12.855 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 2.2 | 11.709 ns | 0.0127 ns | 0.0113 ns | 11.712 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 3.0 |  9.875 ns | 0.0143 ns | 0.0127 ns |  9.875 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime |        net461 | 16.105 ns | 0.0566 ns | 0.0529 ns | 16.117 ns |  1.25 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime |        net472 | 13.662 ns | 0.0582 ns | 0.0545 ns | 13.676 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                From_DateTime_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                      From_DateTime_Nullable_WithValue | .NET Core 2.0 | 12.446 ns | 0.0177 ns | 0.0165 ns | 12.440 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 2.2 | 11.264 ns | 0.0145 ns | 0.0136 ns | 11.264 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 3.0 | 10.459 ns | 0.0454 ns | 0.0403 ns | 10.466 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net461 | 13.251 ns | 0.0171 ns | 0.0151 ns | 13.251 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net472 | 13.804 ns | 0.0197 ns | 0.0175 ns | 13.804 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_DateTime_Nullable_NoValue | .NET Core 2.0 | 13.315 ns | 0.0173 ns | 0.0153 ns | 13.313 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 2.2 | 11.258 ns | 0.0060 ns | 0.0050 ns | 11.257 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 3.0 | 10.133 ns | 0.0277 ns | 0.0231 ns | 10.128 ns |  0.76 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net461 | 13.216 ns | 0.0166 ns | 0.0155 ns | 13.214 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net472 | 13.793 ns | 0.0231 ns | 0.0216 ns | 13.794 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.676 ns | 0.0748 ns | 0.0699 ns | 14.705 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.385 ns | 0.0169 ns | 0.0158 ns | 13.380 ns |  0.91 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 3.0 | 15.186 ns | 0.0992 ns | 0.0928 ns | 15.218 ns |  1.03 |    0.01 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net461 | 22.941 ns | 0.0182 ns | 0.0161 ns | 22.937 ns |  1.56 |    0.01 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net472 | 25.532 ns | 0.0220 ns | 0.0195 ns | 25.531 ns |  1.74 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                          From_Decimal | .NET Core 2.0 | 25.012 ns | 0.0293 ns | 0.0260 ns | 25.011 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 2.2 | 23.391 ns | 0.1117 ns | 0.1045 ns | 23.351 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 3.0 | 14.367 ns | 0.0879 ns | 0.0822 ns | 14.407 ns |  0.57 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal |        net461 | 25.466 ns | 0.0229 ns | 0.0203 ns | 25.468 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal |        net472 | 25.386 ns | 0.0408 ns | 0.0381 ns | 25.384 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                 From_Decimal_AsObject | .NET Core 2.0 | 31.345 ns | 0.0315 ns | 0.0279 ns | 31.346 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 2.2 | 29.772 ns | 0.0351 ns | 0.0328 ns | 29.766 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 3.0 | 24.707 ns | 0.0459 ns | 0.0429 ns | 24.706 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net461 | 43.719 ns | 0.0544 ns | 0.0509 ns | 43.722 ns |  1.39 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net472 | 36.472 ns | 0.0810 ns | 0.0718 ns | 36.454 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                       From_Decimal_Nullable_WithValue | .NET Core 2.0 | 25.813 ns | 0.1066 ns | 0.0997 ns | 25.856 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 2.2 | 24.339 ns | 0.0153 ns | 0.0143 ns | 24.341 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 3.0 | 19.388 ns | 0.0957 ns | 0.0848 ns | 19.395 ns |  0.75 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net461 | 26.859 ns | 0.0294 ns | 0.0275 ns | 26.854 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net472 | 26.321 ns | 0.0218 ns | 0.0182 ns | 26.314 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.0 | 30.913 ns | 0.0522 ns | 0.0436 ns | 30.912 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.2 | 29.880 ns | 0.0332 ns | 0.0259 ns | 29.880 ns |  0.97 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 3.0 | 22.422 ns | 0.1299 ns | 0.1216 ns | 22.438 ns |  0.72 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net461 | 37.596 ns | 0.1007 ns | 0.0942 ns | 37.587 ns |  1.22 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net472 | 36.407 ns | 0.0411 ns | 0.0384 ns | 36.416 ns |  1.18 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Decimal_Nullable_NoValue | .NET Core 2.0 | 12.553 ns | 0.0174 ns | 0.0154 ns | 12.556 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 2.2 | 11.426 ns | 0.0211 ns | 0.0187 ns | 11.421 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 3.0 | 10.776 ns | 0.1227 ns | 0.1148 ns | 10.825 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net461 | 13.474 ns | 0.0187 ns | 0.0165 ns | 13.478 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net472 | 13.504 ns | 0.0250 ns | 0.0222 ns | 13.512 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.632 ns | 0.0793 ns | 0.0742 ns | 14.666 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.395 ns | 0.0287 ns | 0.0269 ns | 13.395 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 3.0 | 15.229 ns | 0.2039 ns | 0.1908 ns | 15.294 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net461 | 21.738 ns | 0.0366 ns | 0.0342 ns | 21.726 ns |  1.49 |    0.01 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net472 | 22.684 ns | 0.0255 ns | 0.0239 ns | 22.681 ns |  1.55 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_Double | .NET Core 2.0 | 15.076 ns | 0.0197 ns | 0.0174 ns | 15.079 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 2.2 | 13.060 ns | 0.0189 ns | 0.0176 ns | 13.059 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 3.0 | 12.644 ns | 0.0181 ns | 0.0170 ns | 12.643 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                           From_Double |        net461 | 15.505 ns | 0.0533 ns | 0.0499 ns | 15.510 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                           From_Double |        net472 | 15.357 ns | 0.0166 ns | 0.0155 ns | 15.357 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_Double_AsObject | .NET Core 2.0 | 21.768 ns | 0.0221 ns | 0.0196 ns | 21.766 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 2.2 | 20.373 ns | 0.1017 ns | 0.0902 ns | 20.366 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 3.0 | 20.603 ns | 0.1171 ns | 0.1095 ns | 20.553 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                                  From_Double_AsObject |        net461 | 28.881 ns | 0.0386 ns | 0.0342 ns | 28.879 ns |  1.33 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject |        net472 | 29.255 ns | 0.0291 ns | 0.0272 ns | 29.262 ns |  1.34 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_Double_Nullable_WithValue | .NET Core 2.0 | 18.385 ns | 0.1334 ns | 0.1247 ns | 18.454 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 2.2 | 14.408 ns | 0.0259 ns | 0.0242 ns | 14.408 ns |  0.78 |    0.01 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 3.0 | 12.891 ns | 0.0200 ns | 0.0188 ns | 12.890 ns |  0.70 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net461 | 17.122 ns | 0.0268 ns | 0.0238 ns | 17.124 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net472 | 17.213 ns | 0.0183 ns | 0.0162 ns | 17.216 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.0 | 21.525 ns | 0.0212 ns | 0.0177 ns | 21.529 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.2 | 20.215 ns | 0.0703 ns | 0.0623 ns | 20.218 ns |  0.94 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 3.0 | 20.519 ns | 0.0310 ns | 0.0290 ns | 20.523 ns |  0.95 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net461 | 29.130 ns | 0.0207 ns | 0.0184 ns | 29.132 ns |  1.35 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net472 | 28.988 ns | 0.0230 ns | 0.0215 ns | 28.986 ns |  1.35 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Double_Nullable_NoValue | .NET Core 2.0 | 12.350 ns | 0.0240 ns | 0.0213 ns | 12.346 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 2.2 | 11.423 ns | 0.0173 ns | 0.0162 ns | 11.424 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 3.0 |  9.921 ns | 0.0242 ns | 0.0226 ns |  9.919 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net461 | 13.451 ns | 0.0214 ns | 0.0190 ns | 13.453 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net472 | 13.504 ns | 0.0132 ns | 0.0110 ns | 13.504 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.880 ns | 0.0575 ns | 0.0510 ns | 14.897 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.383 ns | 0.0121 ns | 0.0113 ns | 13.386 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.313 ns | 0.0142 ns | 0.0126 ns | 13.311 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net461 | 22.358 ns | 0.0217 ns | 0.0203 ns | 22.355 ns |  1.50 |    0.01 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net472 | 22.571 ns | 0.0169 ns | 0.0150 ns | 22.573 ns |  1.52 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_Short | .NET Core 2.0 | 14.478 ns | 0.0144 ns | 0.0113 ns | 14.477 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 2.2 | 11.558 ns | 0.0173 ns | 0.0161 ns | 11.554 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 3.0 | 10.554 ns | 0.2338 ns | 0.3277 ns | 10.758 ns |  0.71 |    0.02 |      - |     - |     - |         - |
                                            From_Short |        net461 | 12.910 ns | 0.0153 ns | 0.0136 ns | 12.912 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                            From_Short |        net472 | 12.982 ns | 0.0173 ns | 0.0162 ns | 12.986 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_Short_AsObject | .NET Core 2.0 | 19.361 ns | 0.0165 ns | 0.0146 ns | 19.362 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 2.2 | 18.576 ns | 0.0529 ns | 0.0469 ns | 18.583 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 3.0 | 19.060 ns | 0.0213 ns | 0.0167 ns | 19.061 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net461 | 27.868 ns | 0.0323 ns | 0.0302 ns | 27.876 ns |  1.44 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net472 | 27.779 ns | 0.0260 ns | 0.0243 ns | 27.776 ns |  1.43 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Short_Nullable_WithValue | .NET Core 2.0 | 13.652 ns | 0.0918 ns | 0.0858 ns | 13.613 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 2.2 | 12.157 ns | 0.0128 ns | 0.0113 ns | 12.158 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 3.0 | 10.801 ns | 0.0144 ns | 0.0135 ns | 10.803 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net461 | 13.397 ns | 0.0162 ns | 0.0144 ns | 13.398 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net472 | 13.388 ns | 0.0117 ns | 0.0109 ns | 13.391 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.261 ns | 0.0156 ns | 0.0139 ns | 20.263 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.2 | 18.435 ns | 0.0201 ns | 0.0188 ns | 18.436 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.549 ns | 0.0849 ns | 0.0794 ns | 18.542 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net461 | 27.639 ns | 0.0656 ns | 0.0613 ns | 27.616 ns |  1.36 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net472 | 27.897 ns | 0.0777 ns | 0.0727 ns | 27.907 ns |  1.38 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Short_Nullable_NoValue | .NET Core 2.0 | 11.890 ns | 0.0191 ns | 0.0169 ns | 11.886 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 2.2 | 10.556 ns | 0.0237 ns | 0.0210 ns | 10.552 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 3.0 | 10.123 ns | 0.0200 ns | 0.0167 ns | 10.117 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net461 | 13.431 ns | 0.0173 ns | 0.0162 ns | 13.432 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net472 | 12.716 ns | 0.0135 ns | 0.0120 ns | 12.716 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.544 ns | 0.0141 ns | 0.0125 ns | 14.546 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.391 ns | 0.0140 ns | 0.0117 ns | 13.395 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.114 ns | 0.0162 ns | 0.0151 ns | 13.109 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net461 | 22.550 ns | 0.0223 ns | 0.0186 ns | 22.557 ns |  1.55 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net472 | 22.583 ns | 0.0215 ns | 0.0201 ns | 22.582 ns |  1.55 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                              From_Int | .NET Core 2.0 | 12.782 ns | 0.0225 ns | 0.0210 ns | 12.782 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 2.2 | 12.113 ns | 0.0156 ns | 0.0138 ns | 12.111 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 3.0 |  9.730 ns | 0.0788 ns | 0.0737 ns |  9.776 ns |  0.76 |    0.01 |      - |     - |     - |         - |
                                              From_Int |        net461 | 12.920 ns | 0.0225 ns | 0.0199 ns | 12.921 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                              From_Int |        net472 | 17.285 ns | 0.0134 ns | 0.0125 ns | 17.280 ns |  1.35 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_Int_AsObject | .NET Core 2.0 | 19.401 ns | 0.0182 ns | 0.0170 ns | 19.402 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 2.2 | 18.210 ns | 0.0217 ns | 0.0203 ns | 18.211 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 3.0 | 17.829 ns | 0.0362 ns | 0.0339 ns | 17.822 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net461 | 27.413 ns | 0.0541 ns | 0.0506 ns | 27.407 ns |  1.41 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net472 | 29.704 ns | 0.0374 ns | 0.0350 ns | 29.705 ns |  1.53 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Int_Nullable_WithValue | .NET Core 2.0 | 13.159 ns | 0.0112 ns | 0.0099 ns | 13.158 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 2.2 | 11.697 ns | 0.0097 ns | 0.0086 ns | 11.697 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 3.0 | 10.854 ns | 0.0663 ns | 0.0620 ns | 10.861 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net461 | 13.399 ns | 0.0087 ns | 0.0077 ns | 13.399 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net472 | 14.394 ns | 0.0125 ns | 0.0117 ns | 14.393 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.350 ns | 0.0240 ns | 0.0212 ns | 19.349 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.2 | 18.360 ns | 0.0411 ns | 0.0343 ns | 18.369 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.787 ns | 0.0274 ns | 0.0256 ns | 17.784 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net461 | 27.491 ns | 0.0332 ns | 0.0311 ns | 27.492 ns |  1.42 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net472 | 27.867 ns | 0.0392 ns | 0.0367 ns | 27.877 ns |  1.44 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_Int_Nullable_NoValue | .NET Core 2.0 | 12.313 ns | 0.0195 ns | 0.0152 ns | 12.315 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 2.2 | 10.416 ns | 0.0098 ns | 0.0091 ns | 10.416 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 3.0 |  9.452 ns | 0.0183 ns | 0.0172 ns |  9.445 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net461 | 12.731 ns | 0.0123 ns | 0.0115 ns | 12.732 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net472 | 12.736 ns | 0.0229 ns | 0.0203 ns | 12.729 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.513 ns | 0.0102 ns | 0.0095 ns | 14.514 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.608 ns | 0.0172 ns | 0.0161 ns | 13.606 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.230 ns | 0.0856 ns | 0.0759 ns | 13.263 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net461 | 22.634 ns | 0.0320 ns | 0.0299 ns | 22.622 ns |  1.56 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net472 | 22.642 ns | 0.0448 ns | 0.0419 ns | 22.630 ns |  1.56 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Long | .NET Core 2.0 | 14.298 ns | 0.0281 ns | 0.0249 ns | 14.296 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Long | .NET Core 2.2 | 11.595 ns | 0.0385 ns | 0.0341 ns | 11.603 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                                             From_Long | .NET Core 3.0 |  9.667 ns | 0.0130 ns | 0.0121 ns |  9.668 ns |  0.68 |    0.00 |      - |     - |     - |         - |
                                             From_Long |        net461 | 12.974 ns | 0.0289 ns | 0.0270 ns | 12.972 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                             From_Long |        net472 | 13.347 ns | 0.0078 ns | 0.0073 ns | 13.346 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Long_AsObject | .NET Core 2.0 | 19.337 ns | 0.0279 ns | 0.0247 ns | 19.343 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 2.2 | 18.205 ns | 0.0221 ns | 0.0206 ns | 18.211 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 3.0 | 18.096 ns | 0.0278 ns | 0.0217 ns | 18.099 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net461 | 29.932 ns | 0.0378 ns | 0.0354 ns | 29.931 ns |  1.55 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net472 | 27.440 ns | 0.0363 ns | 0.0340 ns | 27.446 ns |  1.42 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Long_Nullable_WithValue | .NET Core 2.0 | 14.127 ns | 0.0191 ns | 0.0178 ns | 14.129 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 2.2 | 12.659 ns | 0.0146 ns | 0.0137 ns | 12.656 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 3.0 | 11.088 ns | 0.0733 ns | 0.0686 ns | 11.057 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net461 | 14.546 ns | 0.0247 ns | 0.0231 ns | 14.551 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net472 | 15.444 ns | 0.0289 ns | 0.0270 ns | 15.437 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.326 ns | 0.0263 ns | 0.0233 ns | 19.334 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.2 | 18.352 ns | 0.0969 ns | 0.0907 ns | 18.385 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.062 ns | 0.0239 ns | 0.0212 ns | 18.066 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net461 | 29.516 ns | 0.0572 ns | 0.0507 ns | 29.509 ns |  1.53 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net472 | 29.227 ns | 0.0685 ns | 0.0641 ns | 29.206 ns |  1.51 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Long_Nullable_NoValue | .NET Core 2.0 | 12.354 ns | 0.0125 ns | 0.0117 ns | 12.352 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 2.2 | 12.060 ns | 0.0129 ns | 0.0115 ns | 12.060 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 3.0 | 10.348 ns | 0.0149 ns | 0.0139 ns | 10.350 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net461 | 13.972 ns | 0.0134 ns | 0.0126 ns | 13.974 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net472 | 13.415 ns | 0.0183 ns | 0.0171 ns | 13.415 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.542 ns | 0.0282 ns | 0.0250 ns | 14.536 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.642 ns | 0.0154 ns | 0.0136 ns | 13.639 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.787 ns | 0.0809 ns | 0.0757 ns | 13.779 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net461 | 22.832 ns | 0.0329 ns | 0.0307 ns | 22.827 ns |  1.57 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net472 | 22.662 ns | 0.0419 ns | 0.0392 ns | 22.656 ns |  1.56 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_SByte | .NET Core 2.0 | 11.853 ns | 0.0816 ns | 0.0763 ns | 11.801 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 2.2 | 11.221 ns | 0.1679 ns | 0.1570 ns | 11.271 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 3.0 |  9.461 ns | 0.0116 ns | 0.0109 ns |  9.461 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                            From_SByte |        net461 | 12.242 ns | 0.0234 ns | 0.0183 ns | 12.242 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                            From_SByte |        net472 | 12.235 ns | 0.0148 ns | 0.0131 ns | 12.230 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_SByte_AsObject | .NET Core 2.0 | 22.943 ns | 0.0302 ns | 0.0252 ns | 22.938 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 2.2 | 25.781 ns | 0.0309 ns | 0.0258 ns | 25.778 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 3.0 | 30.569 ns | 0.0397 ns | 0.0331 ns | 30.561 ns |  1.33 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net461 | 35.974 ns | 0.0410 ns | 0.0384 ns | 35.974 ns |  1.57 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net472 | 37.164 ns | 0.0801 ns | 0.0710 ns | 37.180 ns |  1.62 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_SByte_Nullable_WithValue | .NET Core 2.0 | 11.380 ns | 0.0285 ns | 0.0266 ns | 11.371 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 2.2 | 10.826 ns | 0.0253 ns | 0.0224 ns | 10.833 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 3.0 |  6.598 ns | 0.0758 ns | 0.0709 ns |  6.643 ns |  0.58 |    0.01 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net461 | 11.959 ns | 0.0137 ns | 0.0121 ns | 11.961 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net472 | 11.834 ns | 0.0890 ns | 0.0832 ns | 11.786 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.0 | 22.511 ns | 0.0304 ns | 0.0270 ns | 22.504 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.2 | 25.593 ns | 0.0222 ns | 0.0186 ns | 25.593 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 3.0 | 26.941 ns | 0.2159 ns | 0.2020 ns | 26.844 ns |  1.20 |    0.01 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net461 | 35.042 ns | 0.0789 ns | 0.0659 ns | 35.047 ns |  1.56 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net472 | 35.474 ns | 0.0543 ns | 0.0481 ns | 35.484 ns |  1.58 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_SByte_Nullable_NoValue | .NET Core 2.0 | 11.389 ns | 0.0134 ns | 0.0125 ns | 11.383 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 2.2 | 10.282 ns | 0.0172 ns | 0.0161 ns | 10.286 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 3.0 |  8.209 ns | 0.1895 ns | 0.2894 ns |  8.278 ns |  0.71 |    0.04 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net461 | 12.386 ns | 0.0175 ns | 0.0146 ns | 12.383 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net472 | 11.770 ns | 0.0125 ns | 0.0111 ns | 11.770 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.805 ns | 0.0245 ns | 0.0229 ns | 14.805 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.423 ns | 0.0412 ns | 0.0365 ns | 13.425 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.098 ns | 0.0138 ns | 0.0123 ns | 13.094 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net461 | 22.524 ns | 0.0478 ns | 0.0423 ns | 22.524 ns |  1.52 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net472 | 22.255 ns | 0.0356 ns | 0.0333 ns | 22.255 ns |  1.50 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_Float | .NET Core 2.0 | 15.139 ns | 0.0224 ns | 0.0199 ns | 15.139 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 2.2 | 13.592 ns | 0.0267 ns | 0.0236 ns | 13.589 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 3.0 | 12.774 ns | 0.1387 ns | 0.1297 ns | 12.858 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                                            From_Float |        net461 | 15.564 ns | 0.0189 ns | 0.0168 ns | 15.568 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                            From_Float |        net472 | 15.573 ns | 0.0310 ns | 0.0242 ns | 15.570 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_Float_AsObject | .NET Core 2.0 | 21.461 ns | 0.0296 ns | 0.0262 ns | 21.451 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 2.2 | 20.652 ns | 0.0345 ns | 0.0323 ns | 20.645 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 3.0 | 20.117 ns | 0.0808 ns | 0.0756 ns | 20.108 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject |        net461 | 29.400 ns | 0.0588 ns | 0.0550 ns | 29.394 ns |  1.37 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject |        net472 | 29.845 ns | 0.0583 ns | 0.0517 ns | 29.860 ns |  1.39 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Float_Nullable_WithValue | .NET Core 2.0 | 15.489 ns | 0.0262 ns | 0.0245 ns | 15.489 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 2.2 | 13.072 ns | 0.0256 ns | 0.0214 ns | 13.076 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 3.0 | 13.315 ns | 0.0123 ns | 0.0109 ns | 13.316 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net461 | 16.040 ns | 0.0223 ns | 0.0209 ns | 16.034 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net472 | 16.919 ns | 0.0881 ns | 0.0824 ns | 16.880 ns |  1.09 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.0 | 21.486 ns | 0.0260 ns | 0.0231 ns | 21.487 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.2 | 25.954 ns | 0.5544 ns | 1.6346 ns | 26.105 ns |  1.23 |    0.06 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 3.0 | 20.502 ns | 0.0263 ns | 0.0246 ns | 20.507 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net461 | 29.520 ns | 0.0485 ns | 0.0454 ns | 29.534 ns |  1.37 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net472 | 29.830 ns | 0.0651 ns | 0.0577 ns | 29.841 ns |  1.39 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Float_Nullable_NoValue | .NET Core 2.0 | 12.094 ns | 0.0100 ns | 0.0094 ns | 12.094 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 2.2 | 11.691 ns | 0.0147 ns | 0.0123 ns | 11.693 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 3.0 | 10.389 ns | 0.0777 ns | 0.0727 ns | 10.358 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net461 | 12.930 ns | 0.0150 ns | 0.0140 ns | 12.926 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net472 | 12.952 ns | 0.0210 ns | 0.0197 ns | 12.948 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.882 ns | 0.0170 ns | 0.0142 ns | 14.879 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.577 ns | 0.0201 ns | 0.0188 ns | 13.574 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.106 ns | 0.0104 ns | 0.0087 ns | 13.103 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net461 | 24.382 ns | 0.0381 ns | 0.0357 ns | 24.384 ns |  1.64 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net472 | 22.732 ns | 0.1403 ns | 0.1312 ns | 22.801 ns |  1.53 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_String | .NET Core 2.0 | 59.853 ns | 0.0723 ns | 0.0641 ns | 59.855 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 2.2 | 58.706 ns | 0.1290 ns | 0.1207 ns | 58.675 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 3.0 | 20.609 ns | 0.0366 ns | 0.0324 ns | 20.612 ns |  0.34 |    0.00 |      - |     - |     - |         - |
                                           From_String |        net461 | 59.476 ns | 0.1544 ns | 0.1444 ns | 59.495 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                           From_String |        net472 | 59.619 ns | 0.1879 ns | 0.1758 ns | 59.614 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_String_AsObject | .NET Core 2.0 | 65.687 ns | 0.1225 ns | 0.1146 ns | 65.698 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 2.2 | 62.628 ns | 0.0440 ns | 0.0390 ns | 62.617 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 3.0 | 24.566 ns | 0.2441 ns | 0.2283 ns | 24.721 ns |  0.37 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject |        net461 | 72.767 ns | 0.0643 ns | 0.0537 ns | 72.787 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject |        net472 | 73.171 ns | 0.1375 ns | 0.1286 ns | 73.216 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                      From_String_Null | .NET Core 2.0 | 14.055 ns | 0.0169 ns | 0.0150 ns | 14.056 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 2.2 | 18.058 ns | 0.0516 ns | 0.0482 ns | 18.058 ns |  1.29 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 3.0 | 13.839 ns | 0.0232 ns | 0.0206 ns | 13.832 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null |        net461 | 15.455 ns | 0.0136 ns | 0.0121 ns | 15.454 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null |        net472 | 15.564 ns | 0.0675 ns | 0.0631 ns | 15.581 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_String_Null_AsObject | .NET Core 2.0 | 14.530 ns | 0.0229 ns | 0.0192 ns | 14.530 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 2.2 | 13.433 ns | 0.0551 ns | 0.0516 ns | 13.406 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 3.0 | 13.108 ns | 0.0239 ns | 0.0224 ns | 13.111 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net461 | 22.485 ns | 0.0311 ns | 0.0291 ns | 22.491 ns |  1.55 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net472 | 25.849 ns | 0.0188 ns | 0.0157 ns | 25.843 ns |  1.78 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_String_Empty | .NET Core 2.0 | 14.037 ns | 0.0145 ns | 0.0121 ns | 14.038 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 2.2 | 18.556 ns | 0.0215 ns | 0.0201 ns | 18.555 ns |  1.32 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 3.0 | 13.934 ns | 0.0940 ns | 0.0879 ns | 13.976 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                                     From_String_Empty |        net461 | 15.571 ns | 0.0339 ns | 0.0283 ns | 15.573 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty |        net472 | 14.775 ns | 0.0132 ns | 0.0110 ns | 14.774 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_String_Empty_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_UShort | .NET Core 2.0 | 12.172 ns | 0.1617 ns | 0.1513 ns | 12.115 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 2.2 | 10.492 ns | 0.0130 ns | 0.0115 ns | 10.491 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 3.0 |  9.661 ns | 0.0112 ns | 0.0094 ns |  9.659 ns |  0.80 |    0.01 |      - |     - |     - |         - |
                                           From_UShort |        net461 | 13.028 ns | 0.0390 ns | 0.0365 ns | 13.042 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                                           From_UShort |        net472 | 12.954 ns | 0.0150 ns | 0.0126 ns | 12.955 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_UShort_AsObject | .NET Core 2.0 | 20.932 ns | 0.0257 ns | 0.0240 ns | 20.928 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 2.2 | 18.438 ns | 0.0238 ns | 0.0211 ns | 18.441 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 3.0 | 18.748 ns | 0.3932 ns | 0.6677 ns | 19.086 ns |  0.87 |    0.04 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net461 | 27.215 ns | 0.0332 ns | 0.0294 ns | 27.219 ns |  1.30 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net472 | 27.522 ns | 0.0422 ns | 0.0394 ns | 27.510 ns |  1.31 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_UShort_Nullable_WithValue | .NET Core 2.0 | 12.043 ns | 0.0245 ns | 0.0218 ns | 12.042 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 2.2 | 11.025 ns | 0.0197 ns | 0.0184 ns | 11.027 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 3.0 | 10.570 ns | 0.0076 ns | 0.0063 ns | 10.570 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net461 | 13.439 ns | 0.0285 ns | 0.0267 ns | 13.440 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net472 | 13.944 ns | 0.0583 ns | 0.0545 ns | 13.961 ns |  1.16 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.127 ns | 0.0230 ns | 0.0204 ns | 19.127 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.966 ns | 0.0268 ns | 0.0224 ns | 17.970 ns |  0.94 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.302 ns | 0.0324 ns | 0.0303 ns | 17.296 ns |  0.90 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net461 | 29.335 ns | 0.2146 ns | 0.2008 ns | 29.421 ns |  1.53 |    0.01 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net472 | 27.625 ns | 0.0399 ns | 0.0373 ns | 27.635 ns |  1.44 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_UShort_Nullable_NoValue | .NET Core 2.0 | 12.037 ns | 0.0121 ns | 0.0113 ns | 12.037 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 2.2 | 11.482 ns | 0.0483 ns | 0.0452 ns | 11.501 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 3.0 |  9.509 ns | 0.0724 ns | 0.0678 ns |  9.546 ns |  0.79 |    0.01 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net461 | 13.570 ns | 0.0156 ns | 0.0146 ns | 13.569 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net472 | 13.498 ns | 0.0491 ns | 0.0460 ns | 13.522 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.536 ns | 0.0136 ns | 0.0127 ns | 14.539 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.964 ns | 0.0298 ns | 0.0264 ns | 13.962 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.180 ns | 0.0822 ns | 0.0769 ns | 13.196 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net461 | 24.336 ns | 0.0473 ns | 0.0420 ns | 24.332 ns |  1.67 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net472 | 22.564 ns | 0.0330 ns | 0.0292 ns | 22.571 ns |  1.55 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_UInt | .NET Core 2.0 | 12.043 ns | 0.0166 ns | 0.0148 ns | 12.041 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 2.2 | 12.043 ns | 0.0095 ns | 0.0075 ns | 12.045 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 3.0 |  9.448 ns | 0.0155 ns | 0.0145 ns |  9.447 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                                             From_UInt |        net461 | 13.640 ns | 0.0232 ns | 0.0205 ns | 13.638 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                             From_UInt |        net472 | 14.654 ns | 0.0167 ns | 0.0156 ns | 14.662 ns |  1.22 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_UInt_AsObject | .NET Core 2.0 | 19.872 ns | 0.0207 ns | 0.0193 ns | 19.874 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 2.2 | 18.171 ns | 0.0835 ns | 0.0781 ns | 18.196 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 3.0 | 17.441 ns | 0.0952 ns | 0.0891 ns | 17.476 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net461 | 29.959 ns | 0.0187 ns | 0.0166 ns | 29.956 ns |  1.51 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net472 | 27.745 ns | 0.1724 ns | 0.1612 ns | 27.819 ns |  1.40 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_UInt_Nullable_WithValue | .NET Core 2.0 | 12.606 ns | 0.0227 ns | 0.0201 ns | 12.601 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 2.2 | 10.790 ns | 0.0254 ns | 0.0225 ns | 10.789 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 3.0 | 10.577 ns | 0.0115 ns | 0.0102 ns | 10.579 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net461 | 13.897 ns | 0.0122 ns | 0.0114 ns | 13.897 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net472 | 13.366 ns | 0.0111 ns | 0.0087 ns | 13.365 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.111 ns | 0.0184 ns | 0.0163 ns | 19.111 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.2 | 18.036 ns | 0.0300 ns | 0.0266 ns | 18.032 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.409 ns | 0.1422 ns | 0.1330 ns | 17.326 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net461 | 27.190 ns | 0.0229 ns | 0.0191 ns | 27.193 ns |  1.42 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net472 | 27.437 ns | 0.0230 ns | 0.0215 ns | 27.434 ns |  1.44 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_UInt_Nullable_NoValue | .NET Core 2.0 | 12.404 ns | 0.0098 ns | 0.0087 ns | 12.404 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 2.2 | 10.634 ns | 0.0116 ns | 0.0109 ns | 10.635 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 3.0 |  9.889 ns | 0.0135 ns | 0.0120 ns |  9.889 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net461 | 12.739 ns | 0.0244 ns | 0.0217 ns | 12.736 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net472 | 12.697 ns | 0.0159 ns | 0.0141 ns | 12.699 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.578 ns | 0.0905 ns | 0.0847 ns | 14.602 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.395 ns | 0.0202 ns | 0.0179 ns | 13.393 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.111 ns | 0.0131 ns | 0.0110 ns | 13.113 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net461 | 22.783 ns | 0.0609 ns | 0.0570 ns | 22.789 ns |  1.56 |    0.01 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net472 | 22.983 ns | 0.0261 ns | 0.0231 ns | 22.989 ns |  1.58 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_ULong | .NET Core 2.0 | 12.075 ns | 0.0140 ns | 0.0124 ns | 12.074 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 2.2 | 10.502 ns | 0.0109 ns | 0.0102 ns | 10.502 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 3.0 |  9.262 ns | 0.0515 ns | 0.0482 ns |  9.282 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                                            From_ULong |        net461 | 12.900 ns | 0.0182 ns | 0.0170 ns | 12.899 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                            From_ULong |        net472 | 12.934 ns | 0.0132 ns | 0.0117 ns | 12.931 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_ULong_AsObject | .NET Core 2.0 | 19.121 ns | 0.0124 ns | 0.0116 ns | 19.121 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 2.2 | 18.606 ns | 0.0744 ns | 0.0660 ns | 18.632 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 3.0 | 18.326 ns | 0.0923 ns | 0.0864 ns | 18.332 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net461 | 27.603 ns | 0.1418 ns | 0.1326 ns | 27.543 ns |  1.44 |    0.01 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net472 | 27.180 ns | 0.0652 ns | 0.0544 ns | 27.170 ns |  1.42 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_ULong_Nullable_WithValue | .NET Core 2.0 | 13.264 ns | 0.0494 ns | 0.0462 ns | 13.274 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 2.2 | 12.338 ns | 0.0143 ns | 0.0120 ns | 12.337 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 3.0 | 11.049 ns | 0.0214 ns | 0.0200 ns | 11.047 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net461 | 15.444 ns | 0.0382 ns | 0.0358 ns | 15.444 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net472 | 14.554 ns | 0.0138 ns | 0.0129 ns | 14.553 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.109 ns | 0.0197 ns | 0.0175 ns | 19.112 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.962 ns | 0.0258 ns | 0.0242 ns | 17.958 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.411 ns | 0.0332 ns | 0.0311 ns | 17.403 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net461 | 27.483 ns | 0.0904 ns | 0.0846 ns | 27.458 ns |  1.44 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net472 | 27.477 ns | 0.1179 ns | 0.1103 ns | 27.493 ns |  1.44 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_ULong_Nullable_NoValue | .NET Core 2.0 | 12.284 ns | 0.0133 ns | 0.0124 ns | 12.283 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 2.2 | 11.496 ns | 0.0830 ns | 0.0776 ns | 11.453 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 3.0 |  9.680 ns | 0.0117 ns | 0.0104 ns |  9.681 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net461 | 13.274 ns | 0.0288 ns | 0.0255 ns | 13.279 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net472 | 13.316 ns | 0.0155 ns | 0.0129 ns | 13.316 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.640 ns | 0.0740 ns | 0.0693 ns | 14.668 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.393 ns | 0.0113 ns | 0.0094 ns | 13.390 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.101 ns | 0.0114 ns | 0.0101 ns | 13.102 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net461 | 24.409 ns | 0.0504 ns | 0.0471 ns | 24.415 ns |  1.67 |    0.01 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net472 | 25.811 ns | 0.0259 ns | 0.0216 ns | 25.812 ns |  1.76 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                       From_NullObject | .NET Core 2.0 | 14.799 ns | 0.0195 ns | 0.0183 ns | 14.797 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 2.2 | 13.393 ns | 0.0170 ns | 0.0150 ns | 13.395 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 3.0 | 13.100 ns | 0.0145 ns | 0.0136 ns | 13.102 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject |        net461 | 22.605 ns | 0.0347 ns | 0.0290 ns | 22.603 ns |  1.53 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject |        net472 | 22.740 ns | 0.1174 ns | 0.1098 ns | 22.775 ns |  1.54 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_DBNull | .NET Core 2.0 | 12.454 ns | 0.0125 ns | 0.0117 ns | 12.456 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 2.2 | 11.176 ns | 0.0250 ns | 0.0234 ns | 11.165 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 3.0 | 12.797 ns | 0.1083 ns | 0.1013 ns | 12.781 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                           From_DBNull |        net461 | 12.905 ns | 0.0207 ns | 0.0183 ns | 12.906 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull |        net472 | 13.044 ns | 0.0098 ns | 0.0082 ns | 13.042 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_DBNull_AsObject | .NET Core 2.0 | 14.946 ns | 0.0917 ns | 0.0858 ns | 14.903 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 2.2 | 13.406 ns | 0.0262 ns | 0.0233 ns | 13.402 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 3.0 | 13.105 ns | 0.0148 ns | 0.0124 ns | 13.107 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net461 | 22.544 ns | 0.0268 ns | 0.0251 ns | 22.542 ns |  1.51 |    0.01 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net472 | 22.548 ns | 0.0292 ns | 0.0259 ns | 22.553 ns |  1.51 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                 From_ConvertibleClass | .NET Core 2.0 | 17.497 ns | 0.0243 ns | 0.0215 ns | 17.499 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 2.2 | 14.696 ns | 0.0133 ns | 0.0124 ns | 14.699 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 3.0 | 14.937 ns | 0.0209 ns | 0.0196 ns | 14.937 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net461 | 26.057 ns | 0.0998 ns | 0.0934 ns | 26.030 ns |  1.49 |    0.01 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net472 | 25.262 ns | 0.0390 ns | 0.0326 ns | 25.259 ns |  1.44 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_ConvertibleClass_AsObject | .NET Core 2.0 | 18.193 ns | 0.0296 ns | 0.0277 ns | 18.187 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 2.2 | 17.271 ns | 0.0335 ns | 0.0297 ns | 17.264 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 3.0 | 16.626 ns | 0.0309 ns | 0.0274 ns | 16.629 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net461 | 26.196 ns | 0.0475 ns | 0.0445 ns | 26.200 ns |  1.44 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net472 | 26.075 ns | 0.0503 ns | 0.0420 ns | 26.080 ns |  1.43 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_ConvertibleClass_NoValue | .NET Core 2.0 | 19.862 ns | 0.0285 ns | 0.0253 ns | 19.865 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 2.2 | 12.922 ns | 0.0620 ns | 0.0549 ns | 12.899 ns |  0.65 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 3.0 | 13.025 ns | 0.1639 ns | 0.1533 ns | 12.904 ns |  0.66 |    0.01 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net461 | 22.683 ns | 0.0386 ns | 0.0361 ns | 22.673 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net472 | 22.640 ns | 0.0399 ns | 0.0373 ns | 22.640 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.0 | 14.974 ns | 0.0118 ns | 0.0099 ns | 14.973 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.2 | 13.564 ns | 0.0669 ns | 0.0626 ns | 13.562 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 3.0 | 13.107 ns | 0.0186 ns | 0.0155 ns | 13.107 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net461 | 22.214 ns | 0.0545 ns | 0.0510 ns | 22.196 ns |  1.48 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net472 | 22.629 ns | 0.0385 ns | 0.0322 ns | 22.624 ns |  1.51 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                              From_NonConvertibleClass | .NET Core 2.0 | 14.063 ns | 0.0163 ns | 0.0152 ns | 14.064 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 2.2 | 12.249 ns | 0.0395 ns | 0.0350 ns | 12.238 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 3.0 | 12.918 ns | 0.0151 ns | 0.0141 ns | 12.919 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net461 | 14.269 ns | 0.0092 ns | 0.0072 ns | 14.269 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net472 | 14.963 ns | 0.0307 ns | 0.0272 ns | 14.958 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                     From_NonConvertibleClass_AsObject | .NET Core 2.0 | 16.368 ns | 0.0231 ns | 0.0204 ns | 16.368 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 2.2 | 15.244 ns | 0.0166 ns | 0.0147 ns | 15.249 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 3.0 | 15.139 ns | 0.2992 ns | 0.2799 ns | 14.958 ns |  0.92 |    0.02 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net461 | 24.320 ns | 0.0346 ns | 0.0307 ns | 24.315 ns |  1.49 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net472 | 24.220 ns | 0.0261 ns | 0.0204 ns | 24.220 ns |  1.48 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                      From_NonConvertibleClass_NoValue | .NET Core 2.0 | 14.055 ns | 0.0120 ns | 0.0112 ns | 14.055 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 2.2 | 12.206 ns | 0.0143 ns | 0.0134 ns | 12.210 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 3.0 | 12.458 ns | 0.0152 ns | 0.0142 ns | 12.463 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net461 | 15.013 ns | 0.0329 ns | 0.0275 ns | 15.010 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net472 | 14.430 ns | 0.0654 ns | 0.0612 ns | 14.447 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.0 | 14.516 ns | 0.0105 ns | 0.0093 ns | 14.517 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.2 | 13.406 ns | 0.0239 ns | 0.0224 ns | 13.398 ns |  0.92 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 3.0 | 13.329 ns | 0.0117 ns | 0.0104 ns | 13.334 ns |  0.92 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net461 | 22.650 ns | 0.0314 ns | 0.0294 ns | 22.650 ns |  1.56 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net472 | 22.567 ns | 0.0221 ns | 0.0195 ns | 22.573 ns |  1.55 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                From_ConvertibleStruct | .NET Core 2.0 | 20.216 ns | 0.0342 ns | 0.0285 ns | 20.205 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 2.2 | 16.527 ns | 0.0371 ns | 0.0310 ns | 16.536 ns |  0.82 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 3.0 | 14.109 ns | 0.3033 ns | 0.4252 ns | 14.381 ns |  0.68 |    0.02 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net461 | 19.083 ns | 0.0245 ns | 0.0229 ns | 19.076 ns |  0.94 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net472 | 18.201 ns | 0.0408 ns | 0.0382 ns | 18.202 ns |  0.90 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                       From_ConvertibleStruct_AsObject | .NET Core 2.0 | 18.649 ns | 0.0158 ns | 0.0140 ns | 18.648 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 2.2 | 17.566 ns | 0.0218 ns | 0.0204 ns | 17.560 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 3.0 | 17.391 ns | 0.2161 ns | 0.2021 ns | 17.517 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net461 | 27.033 ns | 0.2357 ns | 0.2205 ns | 27.146 ns |  1.45 |    0.01 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net472 | 26.983 ns | 0.0676 ns | 0.0600 ns | 26.980 ns |  1.45 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.0 | 20.110 ns | 0.0366 ns | 0.0343 ns | 20.106 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.2 | 16.431 ns | 0.0584 ns | 0.0517 ns | 16.425 ns |  0.82 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 3.0 | 14.732 ns | 0.3158 ns | 0.3510 ns | 14.963 ns |  0.74 |    0.02 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net461 | 24.199 ns | 0.0553 ns | 0.0517 ns | 24.199 ns |  1.20 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net472 | 24.273 ns | 0.0549 ns | 0.0513 ns | 24.259 ns |  1.21 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.664 ns | 0.0169 ns | 0.0158 ns | 18.662 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.715 ns | 0.0242 ns | 0.0214 ns | 17.716 ns |  0.95 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.482 ns | 0.0782 ns | 0.0693 ns | 18.492 ns |  0.99 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net461 | 26.547 ns | 0.0330 ns | 0.0292 ns | 26.541 ns |  1.42 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net472 | 26.775 ns | 0.0559 ns | 0.0523 ns | 26.777 ns |  1.43 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.0 | 13.826 ns | 0.0183 ns | 0.0171 ns | 13.822 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.2 | 11.997 ns | 0.0140 ns | 0.0131 ns | 11.994 ns |  0.87 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 3.0 |  9.903 ns | 0.0143 ns | 0.0126 ns |  9.902 ns |  0.72 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net461 | 18.375 ns | 0.0296 ns | 0.0262 ns | 18.378 ns |  1.33 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net472 | 18.765 ns | 0.0324 ns | 0.0303 ns | 18.761 ns |  1.36 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.045 ns | 0.0180 ns | 0.0168 ns | 15.046 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 20.665 ns | 0.0976 ns | 0.0913 ns | 20.710 ns |  1.37 |    0.01 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.114 ns | 0.0147 ns | 0.0123 ns | 13.115 ns |  0.87 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net461 | 22.550 ns | 0.0283 ns | 0.0265 ns | 22.560 ns |  1.50 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net472 | 24.338 ns | 0.0273 ns | 0.0255 ns | 24.338 ns |  1.62 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_NonConvertibleStruct | .NET Core 2.0 | 13.146 ns | 0.0169 ns | 0.0141 ns | 13.144 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 2.2 | 10.310 ns | 0.0119 ns | 0.0099 ns | 10.311 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 3.0 |  9.308 ns | 0.0075 ns | 0.0066 ns |  9.306 ns |  0.71 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net461 | 12.703 ns | 0.0146 ns | 0.0130 ns | 12.705 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net472 | 12.889 ns | 0.0153 ns | 0.0143 ns | 12.885 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.0 | 16.560 ns | 0.0203 ns | 0.0190 ns | 16.562 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.2 | 15.248 ns | 0.0184 ns | 0.0173 ns | 15.252 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 3.0 | 15.181 ns | 0.0190 ns | 0.0177 ns | 15.184 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net461 | 25.902 ns | 0.0257 ns | 0.0227 ns | 25.903 ns |  1.56 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net472 | 26.073 ns | 0.1537 ns | 0.1438 ns | 26.138 ns |  1.57 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.0 | 13.136 ns | 0.0100 ns | 0.0094 ns | 13.136 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.2 | 10.436 ns | 0.0378 ns | 0.0316 ns | 10.444 ns |  0.79 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 3.0 |  9.226 ns | 0.0152 ns | 0.0142 ns |  9.231 ns |  0.70 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net461 | 13.546 ns | 0.1707 ns | 0.1597 ns | 13.548 ns |  1.03 |    0.01 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net472 | 13.443 ns | 0.0356 ns | 0.0333 ns | 13.437 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 16.358 ns | 0.0216 ns | 0.0202 ns | 16.358 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.230 ns | 0.0291 ns | 0.0258 ns | 15.220 ns |  0.93 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 16.051 ns | 0.3458 ns | 0.3551 ns | 16.311 ns |  0.98 |    0.02 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net461 | 26.034 ns | 0.1661 ns | 0.1554 ns | 25.961 ns |  1.59 |    0.01 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net472 | 23.864 ns | 0.0278 ns | 0.0260 ns | 23.870 ns |  1.46 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.0 | 13.137 ns | 0.0217 ns | 0.0192 ns | 13.135 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.2 | 10.303 ns | 0.0105 ns | 0.0093 ns | 10.305 ns |  0.78 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 3.0 |  9.454 ns | 0.0096 ns | 0.0080 ns |  9.453 ns |  0.72 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net461 | 12.915 ns | 0.0133 ns | 0.0111 ns | 12.914 ns |  0.98 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net472 | 15.597 ns | 0.0111 ns | 0.0099 ns | 15.596 ns |  1.19 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.505 ns | 0.0101 ns | 0.0095 ns | 14.504 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.171 ns | 0.0233 ns | 0.0206 ns | 14.171 ns |  0.98 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.097 ns | 0.5275 ns | 0.8957 ns | 13.599 ns |  1.02 |    0.07 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net461 | 22.391 ns | 0.0299 ns | 0.0280 ns | 22.400 ns |  1.54 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net472 | 24.410 ns | 0.0333 ns | 0.0311 ns | 24.421 ns |  1.68 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Enum | .NET Core 2.0 | 13.283 ns | 0.0126 ns | 0.0118 ns | 13.282 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 2.2 | 11.560 ns | 0.0440 ns | 0.0411 ns | 11.539 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 3.0 |  9.973 ns | 0.2220 ns | 0.3039 ns |  9.767 ns |  0.76 |    0.02 |      - |     - |     - |         - |
                                             From_Enum |        net461 | 12.943 ns | 0.0628 ns | 0.0587 ns | 12.927 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                             From_Enum |        net472 | 12.914 ns | 0.0075 ns | 0.0070 ns | 12.917 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Enum_AsObject | .NET Core 2.0 | 47.689 ns | 0.1165 ns | 0.1090 ns | 47.667 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject | .NET Core 2.2 | 43.797 ns | 0.0395 ns | 0.0350 ns | 43.801 ns |  0.92 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject | .NET Core 3.0 | 38.597 ns | 0.1643 ns | 0.1456 ns | 38.642 ns |  0.81 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject |        net461 | 51.953 ns | 0.1616 ns | 0.1511 ns | 51.899 ns |  1.09 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject |        net472 | 52.196 ns | 0.1512 ns | 0.1414 ns | 52.211 ns |  1.09 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Enum_Nullable_WithValue | .NET Core 2.0 | 14.647 ns | 0.0192 ns | 0.0180 ns | 14.642 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 2.2 | 12.997 ns | 0.0166 ns | 0.0147 ns | 12.997 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 3.0 | 11.341 ns | 0.2509 ns | 0.4460 ns | 11.541 ns |  0.75 |    0.04 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net461 | 13.980 ns | 0.0151 ns | 0.0118 ns | 13.976 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net472 | 13.675 ns | 0.0144 ns | 0.0127 ns | 13.677 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.0 | 45.534 ns | 0.0958 ns | 0.0896 ns | 45.499 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.2 | 43.454 ns | 0.0717 ns | 0.0599 ns | 43.448 ns |  0.95 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 3.0 | 41.954 ns | 0.1544 ns | 0.1444 ns | 41.982 ns |  0.92 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject |        net461 | 51.488 ns | 0.1802 ns | 0.1686 ns | 51.448 ns |  1.13 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject |        net472 | 51.476 ns | 0.1122 ns | 0.0994 ns | 51.475 ns |  1.13 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Enum_Nullable_NoValue | .NET Core 2.0 | 14.224 ns | 0.0149 ns | 0.0140 ns | 14.226 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 2.2 | 11.505 ns | 0.0170 ns | 0.0159 ns | 11.509 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 3.0 |  9.698 ns | 0.0102 ns | 0.0090 ns |  9.700 ns |  0.68 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net461 | 13.418 ns | 0.0190 ns | 0.0168 ns | 13.416 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net472 | 12.728 ns | 0.0199 ns | 0.0166 ns | 12.730 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.517 ns | 0.0091 ns | 0.0076 ns | 14.518 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.952 ns | 0.0152 ns | 0.0142 ns | 14.950 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 3.0 | 15.367 ns | 0.6610 ns | 1.0484 ns | 14.774 ns |  1.12 |    0.08 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net461 | 22.345 ns | 0.0341 ns | 0.0302 ns | 22.353 ns |  1.54 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net472 | 25.098 ns | 0.0321 ns | 0.0300 ns | 25.105 ns |  1.73 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                      From_ParentClass | .NET Core 2.0 | 14.073 ns | 0.0301 ns | 0.0282 ns | 14.069 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 2.2 | 12.213 ns | 0.0212 ns | 0.0199 ns | 12.215 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 3.0 | 12.545 ns | 0.0243 ns | 0.0216 ns | 12.550 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass |        net461 | 14.305 ns | 0.0212 ns | 0.0165 ns | 14.303 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass |        net472 | 14.274 ns | 0.0135 ns | 0.0119 ns | 14.277 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_ParentClass_AsObject | .NET Core 2.0 | 16.831 ns | 0.0234 ns | 0.0219 ns | 16.830 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 2.2 | 15.778 ns | 0.0185 ns | 0.0173 ns | 15.777 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 3.0 | 15.968 ns | 0.0436 ns | 0.0408 ns | 15.953 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net461 | 27.384 ns | 0.0187 ns | 0.0166 ns | 27.385 ns |  1.63 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net472 | 24.744 ns | 0.0695 ns | 0.0650 ns | 24.737 ns |  1.47 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                              From_ParentClass_NoValue | .NET Core 2.0 | 14.044 ns | 0.0113 ns | 0.0106 ns | 14.044 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 2.2 | 12.204 ns | 0.0205 ns | 0.0182 ns | 12.200 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 3.0 | 12.484 ns | 0.0073 ns | 0.0064 ns | 12.484 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net461 | 15.315 ns | 0.0206 ns | 0.0172 ns | 15.314 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net472 | 14.293 ns | 0.0356 ns | 0.0315 ns | 14.283 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.0 | 14.875 ns | 0.0173 ns | 0.0135 ns | 14.877 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.2 | 13.396 ns | 0.0239 ns | 0.0224 ns | 13.398 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 3.0 | 13.360 ns | 0.0158 ns | 0.0132 ns | 13.362 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net461 | 24.342 ns | 0.0524 ns | 0.0490 ns | 24.337 ns |  1.64 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net472 | 22.563 ns | 0.0302 ns | 0.0268 ns | 22.561 ns |  1.52 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_ParentStruct | .NET Core 2.0 | 42.340 ns | 0.0483 ns | 0.0428 ns | 42.333 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 2.2 | 39.044 ns | 0.1693 ns | 0.1584 ns | 38.984 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 3.0 | 39.401 ns | 0.0676 ns | 0.0632 ns | 39.375 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct |        net461 | 40.810 ns | 0.0526 ns | 0.0466 ns | 40.800 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct |        net472 | 41.439 ns | 0.1006 ns | 0.0892 ns | 41.425 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_ParentStruct_AsObject | .NET Core 2.0 | 16.816 ns | 0.0173 ns | 0.0162 ns | 16.817 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 2.2 | 15.728 ns | 0.0260 ns | 0.0231 ns | 15.722 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 3.0 | 15.350 ns | 0.0873 ns | 0.0816 ns | 15.310 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net461 | 26.430 ns | 0.1446 ns | 0.1353 ns | 26.495 ns |  1.57 |    0.01 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net472 | 24.135 ns | 0.0700 ns | 0.0655 ns | 24.150 ns |  1.44 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.0 | 41.764 ns | 0.0642 ns | 0.0601 ns | 41.764 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.2 | 38.574 ns | 0.0450 ns | 0.0399 ns | 38.573 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 3.0 | 39.511 ns | 0.1455 ns | 0.1290 ns | 39.553 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue |        net461 | 41.061 ns | 0.0497 ns | 0.0465 ns | 41.057 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue |        net472 | 41.420 ns | 0.0568 ns | 0.0531 ns | 41.419 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 16.970 ns | 0.0577 ns | 0.0482 ns | 16.984 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.712 ns | 0.0244 ns | 0.0228 ns | 15.708 ns |  0.93 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 16.896 ns | 0.0921 ns | 0.0862 ns | 16.939 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net461 | 24.646 ns | 0.0430 ns | 0.0402 ns | 24.645 ns |  1.45 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net472 | 27.234 ns | 0.1147 ns | 0.1017 ns | 27.257 ns |  1.60 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.0 | 42.386 ns | 0.0303 ns | 0.0283 ns | 42.395 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.2 | 38.581 ns | 0.0546 ns | 0.0484 ns | 38.574 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 3.0 | 38.589 ns | 0.0287 ns | 0.0255 ns | 38.603 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net461 | 41.166 ns | 0.1640 ns | 0.1534 ns | 41.220 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net472 | 41.565 ns | 0.0880 ns | 0.0780 ns | 41.556 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.519 ns | 0.0194 ns | 0.0172 ns | 14.516 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.399 ns | 0.0248 ns | 0.0219 ns | 13.400 ns |  0.92 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 16.117 ns | 0.3231 ns | 0.3023 ns | 15.897 ns |  1.11 |    0.02 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net461 | 22.814 ns | 0.0723 ns | 0.0676 ns | 22.815 ns |  1.57 |    0.01 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net472 | 24.335 ns | 0.0376 ns | 0.0333 ns | 24.340 ns |  1.68 |    0.00 |      - |     - |     - |         - |

Benchmarks with issues:
  ConvertTo_SByteNullable.From_DateTime_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_SByteNullable.From_DateTime_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_SByteNullable.From_DateTime_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_SByteNullable.From_DateTime_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_SByteNullable.From_DateTime_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_SByteNullable.From_DateTime_Nullable_WithValue_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_SByteNullable.From_DateTime_Nullable_WithValue_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_SByteNullable.From_DateTime_Nullable_WithValue_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_SByteNullable.From_DateTime_Nullable_WithValue_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_SByteNullable.From_DateTime_Nullable_WithValue_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_SByteNullable.From_String_Empty_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_SByteNullable.From_String_Empty_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_SByteNullable.From_String_Empty_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_SByteNullable.From_String_Empty_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_SByteNullable.From_String_Empty_AsObject: Job-PJAXXB(Toolchain=net472)
