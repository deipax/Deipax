
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
                                             From_Bool | .NET Core 2.0 | 11.895 ns | 0.0133 ns | 0.0111 ns | 11.893 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 2.2 | 11.679 ns | 0.0887 ns | 0.0830 ns | 11.725 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 3.0 |  9.703 ns | 0.0126 ns | 0.0118 ns |  9.703 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                             From_Bool |        net461 | 13.906 ns | 0.0927 ns | 0.0822 ns | 13.934 ns |  1.17 |    0.00 |      - |     - |     - |         - |
                                             From_Bool |        net472 | 13.001 ns | 0.0293 ns | 0.0229 ns | 13.001 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Bool_AsObject | .NET Core 2.0 | 19.210 ns | 0.0217 ns | 0.0203 ns | 19.215 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 2.2 | 17.436 ns | 0.0228 ns | 0.0213 ns | 17.428 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 3.0 | 17.999 ns | 0.0205 ns | 0.0192 ns | 17.992 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net461 | 27.349 ns | 0.0772 ns | 0.0722 ns | 27.339 ns |  1.42 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net472 | 29.546 ns | 0.0811 ns | 0.0758 ns | 29.547 ns |  1.54 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Bool_Nullable_WithValue | .NET Core 2.0 | 12.253 ns | 0.1104 ns | 0.1032 ns | 12.308 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 2.2 | 11.314 ns | 0.0202 ns | 0.0157 ns | 11.313 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 3.0 |  9.991 ns | 0.0150 ns | 0.0140 ns |  9.988 ns |  0.82 |    0.01 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net461 | 13.535 ns | 0.0142 ns | 0.0133 ns | 13.534 ns |  1.10 |    0.01 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net472 | 12.762 ns | 0.0149 ns | 0.0140 ns | 12.762 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.191 ns | 0.0773 ns | 0.0685 ns | 19.178 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.582 ns | 0.1204 ns | 0.1126 ns | 17.644 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 3.0 | 19.300 ns | 0.1041 ns | 0.0974 ns | 19.331 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net461 | 28.946 ns | 0.1511 ns | 0.1339 ns | 28.983 ns |  1.51 |    0.01 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net472 | 28.752 ns | 0.0461 ns | 0.0431 ns | 28.766 ns |  1.50 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Bool_Nullable_NoValue | .NET Core 2.0 | 12.240 ns | 0.0406 ns | 0.0317 ns | 12.239 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 2.2 | 10.875 ns | 0.0245 ns | 0.0229 ns | 10.875 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 3.0 |  9.744 ns | 0.0113 ns | 0.0106 ns |  9.744 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net461 | 14.162 ns | 0.0245 ns | 0.0230 ns | 14.157 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net472 | 12.768 ns | 0.0171 ns | 0.0152 ns | 12.769 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.876 ns | 0.0213 ns | 0.0199 ns | 14.877 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.347 ns | 0.0282 ns | 0.0250 ns | 13.340 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.806 ns | 0.0311 ns | 0.0291 ns | 14.800 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net461 | 22.253 ns | 0.0404 ns | 0.0378 ns | 22.247 ns |  1.50 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net472 | 25.493 ns | 0.0502 ns | 0.0445 ns | 25.513 ns |  1.71 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Byte | .NET Core 2.0 | 11.902 ns | 0.0202 ns | 0.0189 ns | 11.906 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 2.2 | 11.616 ns | 0.0954 ns | 0.0893 ns | 11.676 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 3.0 |  9.790 ns | 0.0548 ns | 0.0458 ns |  9.800 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                             From_Byte |        net461 | 14.012 ns | 0.0189 ns | 0.0177 ns | 14.007 ns |  1.18 |    0.00 |      - |     - |     - |         - |
                                             From_Byte |        net472 | 14.459 ns | 0.0283 ns | 0.0237 ns | 14.454 ns |  1.21 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Byte_AsObject | .NET Core 2.0 | 19.679 ns | 0.0430 ns | 0.0402 ns | 19.662 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 2.2 | 17.677 ns | 0.0285 ns | 0.0252 ns | 17.677 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 3.0 | 17.836 ns | 0.0305 ns | 0.0286 ns | 17.836 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net461 | 28.070 ns | 0.2406 ns | 0.2251 ns | 27.947 ns |  1.43 |    0.01 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net472 | 29.434 ns | 0.0607 ns | 0.0538 ns | 29.434 ns |  1.50 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Byte_Nullable_WithValue | .NET Core 2.0 | 12.299 ns | 0.0751 ns | 0.0703 ns | 12.321 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 2.2 | 11.231 ns | 0.0385 ns | 0.0360 ns | 11.218 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 3.0 | 10.337 ns | 0.1634 ns | 0.1528 ns | 10.250 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net461 | 15.017 ns | 0.0355 ns | 0.0315 ns | 15.025 ns |  1.22 |    0.01 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net472 | 13.351 ns | 0.0242 ns | 0.0227 ns | 13.355 ns |  1.09 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.751 ns | 0.0297 ns | 0.0278 ns | 19.760 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.864 ns | 0.0938 ns | 0.0877 ns | 17.900 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.385 ns | 0.3596 ns | 0.3363 ns | 18.629 ns |  0.93 |    0.02 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net461 | 30.133 ns | 0.0904 ns | 0.0845 ns | 30.096 ns |  1.53 |    0.01 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net472 | 31.385 ns | 0.2438 ns | 0.2281 ns | 31.528 ns |  1.59 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Byte_Nullable_NoValue | .NET Core 2.0 | 12.111 ns | 0.0192 ns | 0.0179 ns | 12.113 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 2.2 | 10.789 ns | 0.0130 ns | 0.0108 ns | 10.791 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 3.0 |  9.534 ns | 0.0174 ns | 0.0163 ns |  9.532 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net461 | 14.398 ns | 0.1052 ns | 0.0933 ns | 14.440 ns |  1.19 |    0.01 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net472 | 14.631 ns | 0.0285 ns | 0.0253 ns | 14.636 ns |  1.21 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.057 ns | 0.1375 ns | 0.1286 ns | 15.137 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.715 ns | 0.1130 ns | 0.1057 ns | 14.795 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 3.0 | 15.722 ns | 0.3316 ns | 0.5540 ns | 15.853 ns |  1.03 |    0.06 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net461 | 21.598 ns | 0.0361 ns | 0.0338 ns | 21.583 ns |  1.43 |    0.01 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net472 | 27.515 ns | 0.0454 ns | 0.0402 ns | 27.502 ns |  1.83 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Char | .NET Core 2.0 | 11.884 ns | 0.0087 ns | 0.0081 ns | 11.883 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Char | .NET Core 2.2 | 11.516 ns | 0.0176 ns | 0.0156 ns | 11.517 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                             From_Char | .NET Core 3.0 |  9.535 ns | 0.0875 ns | 0.0819 ns |  9.482 ns |  0.80 |    0.01 |      - |     - |     - |         - |
                                             From_Char |        net461 | 14.643 ns | 0.0258 ns | 0.0229 ns | 14.635 ns |  1.23 |    0.00 |      - |     - |     - |         - |
                                             From_Char |        net472 | 13.289 ns | 0.1255 ns | 0.1174 ns | 13.346 ns |  1.12 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Char_AsObject | .NET Core 2.0 | 20.082 ns | 0.1672 ns | 0.1564 ns | 20.169 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 2.2 | 18.232 ns | 0.1166 ns | 0.1091 ns | 18.179 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 3.0 | 18.149 ns | 0.0287 ns | 0.0268 ns | 18.148 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                                    From_Char_AsObject |        net461 | 27.763 ns | 0.1196 ns | 0.1060 ns | 27.787 ns |  1.38 |    0.01 |      - |     - |     - |         - |
                                    From_Char_AsObject |        net472 | 29.397 ns | 0.0747 ns | 0.0662 ns | 29.395 ns |  1.46 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Char_Nullable_WithValue | .NET Core 2.0 | 13.042 ns | 0.0149 ns | 0.0139 ns | 13.046 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 2.2 | 11.308 ns | 0.0762 ns | 0.0713 ns | 11.342 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 3.0 |  9.996 ns | 0.0124 ns | 0.0116 ns |  9.995 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net461 | 14.520 ns | 0.0210 ns | 0.0186 ns | 14.524 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net472 | 13.469 ns | 0.0215 ns | 0.0191 ns | 13.469 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.691 ns | 0.1552 ns | 0.1451 ns | 20.626 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.2 | 18.208 ns | 0.0464 ns | 0.0362 ns | 18.218 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.377 ns | 0.1277 ns | 0.1132 ns | 18.418 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net461 | 27.287 ns | 0.0305 ns | 0.0286 ns | 27.285 ns |  1.32 |    0.01 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net472 | 30.888 ns | 0.2464 ns | 0.2305 ns | 30.981 ns |  1.49 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Char_Nullable_NoValue | .NET Core 2.0 | 12.270 ns | 0.1178 ns | 0.1102 ns | 12.342 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 2.2 | 10.883 ns | 0.0847 ns | 0.0792 ns | 10.846 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 3.0 |  9.740 ns | 0.0160 ns | 0.0142 ns |  9.740 ns |  0.79 |    0.01 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net461 | 14.346 ns | 0.0902 ns | 0.0844 ns | 14.373 ns |  1.17 |    0.01 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net472 | 12.766 ns | 0.0167 ns | 0.0156 ns | 12.766 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.855 ns | 0.0219 ns | 0.0205 ns | 14.856 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.419 ns | 0.0309 ns | 0.0289 ns | 14.413 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.463 ns | 0.0175 ns | 0.0155 ns | 13.466 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net461 | 22.760 ns | 0.0372 ns | 0.0348 ns | 22.765 ns |  1.53 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net472 | 26.457 ns | 0.0615 ns | 0.0545 ns | 26.453 ns |  1.78 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                         From_DateTime | .NET Core 2.0 | 12.878 ns | 0.0180 ns | 0.0150 ns | 12.882 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 2.2 | 11.740 ns | 0.0214 ns | 0.0201 ns | 11.739 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 3.0 |  9.910 ns | 0.0547 ns | 0.0512 ns |  9.927 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime |        net461 | 13.924 ns | 0.0328 ns | 0.0274 ns | 13.937 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime |        net472 | 13.139 ns | 0.1447 ns | 0.1354 ns | 13.068 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                From_DateTime_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                      From_DateTime_Nullable_WithValue | .NET Core 2.0 | 14.146 ns | 0.0153 ns | 0.0136 ns | 14.147 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 2.2 | 11.988 ns | 0.0130 ns | 0.0115 ns | 11.989 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 3.0 | 11.189 ns | 0.1529 ns | 0.1431 ns | 11.288 ns |  0.79 |    0.01 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net461 | 14.639 ns | 0.0397 ns | 0.0352 ns | 14.639 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net472 | 13.997 ns | 0.0162 ns | 0.0136 ns | 13.995 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_DateTime_Nullable_NoValue | .NET Core 2.0 | 12.617 ns | 0.0158 ns | 0.0148 ns | 12.615 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 2.2 | 11.999 ns | 0.0325 ns | 0.0304 ns | 11.989 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 3.0 | 10.760 ns | 0.1188 ns | 0.1112 ns | 10.681 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net461 | 14.567 ns | 0.0493 ns | 0.0461 ns | 14.552 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net472 | 13.858 ns | 0.0235 ns | 0.0208 ns | 13.864 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.853 ns | 0.0158 ns | 0.0140 ns | 14.854 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.198 ns | 0.0208 ns | 0.0185 ns | 14.197 ns |  0.96 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.477 ns | 0.0191 ns | 0.0159 ns | 13.474 ns |  0.91 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net461 | 22.798 ns | 0.0839 ns | 0.0785 ns | 22.777 ns |  1.54 |    0.01 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net472 | 26.649 ns | 0.0372 ns | 0.0330 ns | 26.646 ns |  1.79 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                          From_Decimal | .NET Core 2.0 | 24.571 ns | 0.0177 ns | 0.0157 ns | 24.577 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 2.2 | 26.085 ns | 0.0348 ns | 0.0308 ns | 26.093 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 3.0 | 14.694 ns | 0.0174 ns | 0.0145 ns | 14.692 ns |  0.60 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal |        net461 | 27.532 ns | 0.0877 ns | 0.0820 ns | 27.521 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal |        net472 | 25.182 ns | 0.0494 ns | 0.0462 ns | 25.195 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                 From_Decimal_AsObject | .NET Core 2.0 | 31.448 ns | 0.2013 ns | 0.1883 ns | 31.511 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 2.2 | 29.712 ns | 0.2989 ns | 0.2796 ns | 29.877 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 3.0 | 23.254 ns | 0.2186 ns | 0.2045 ns | 23.252 ns |  0.74 |    0.01 |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net461 | 36.770 ns | 0.0372 ns | 0.0310 ns | 36.773 ns |  1.17 |    0.01 |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net472 | 38.049 ns | 0.0534 ns | 0.0499 ns | 38.056 ns |  1.21 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                       From_Decimal_Nullable_WithValue | .NET Core 2.0 | 25.898 ns | 0.0357 ns | 0.0334 ns | 25.906 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 2.2 | 25.152 ns | 0.0364 ns | 0.0340 ns | 25.144 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 3.0 | 20.010 ns | 0.0905 ns | 0.0846 ns | 20.030 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net461 | 28.172 ns | 0.0564 ns | 0.0500 ns | 28.168 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net472 | 26.737 ns | 0.0356 ns | 0.0316 ns | 26.737 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.0 | 31.385 ns | 0.0436 ns | 0.0364 ns | 31.389 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.2 | 29.348 ns | 0.0838 ns | 0.0699 ns | 29.330 ns |  0.94 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 3.0 | 22.935 ns | 0.0474 ns | 0.0443 ns | 22.939 ns |  0.73 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net461 | 37.082 ns | 0.1766 ns | 0.1565 ns | 37.037 ns |  1.18 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net472 | 43.270 ns | 0.0973 ns | 0.0910 ns | 43.242 ns |  1.38 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Decimal_Nullable_NoValue | .NET Core 2.0 | 12.627 ns | 0.0213 ns | 0.0189 ns | 12.632 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 2.2 | 12.195 ns | 0.1131 ns | 0.1058 ns | 12.264 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 3.0 | 10.041 ns | 0.0241 ns | 0.0202 ns | 10.036 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net461 | 17.228 ns | 0.1922 ns | 0.1797 ns | 17.341 ns |  1.37 |    0.01 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net472 | 13.497 ns | 0.0103 ns | 0.0091 ns | 13.496 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.887 ns | 0.0172 ns | 0.0160 ns | 14.885 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.980 ns | 0.0101 ns | 0.0084 ns | 12.982 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.656 ns | 0.1164 ns | 0.1032 ns | 13.703 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net461 | 22.764 ns | 0.0537 ns | 0.0503 ns | 22.767 ns |  1.53 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net472 | 26.764 ns | 0.3121 ns | 0.2919 ns | 26.914 ns |  1.80 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_Double | .NET Core 2.0 | 15.242 ns | 0.0332 ns | 0.0294 ns | 15.248 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 2.2 | 14.117 ns | 0.0989 ns | 0.0925 ns | 14.076 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                                           From_Double | .NET Core 3.0 | 13.869 ns | 0.3019 ns | 0.4875 ns | 14.063 ns |  0.89 |    0.05 |      - |     - |     - |         - |
                                           From_Double |        net461 | 16.205 ns | 0.0536 ns | 0.0475 ns | 16.191 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                           From_Double |        net472 | 15.389 ns | 0.0438 ns | 0.0410 ns | 15.373 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_Double_AsObject | .NET Core 2.0 | 21.844 ns | 0.0316 ns | 0.0280 ns | 21.843 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 2.2 | 20.288 ns | 0.1219 ns | 0.1140 ns | 20.324 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 3.0 | 20.455 ns | 0.0311 ns | 0.0291 ns | 20.457 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject |        net461 | 29.894 ns | 0.0295 ns | 0.0276 ns | 29.887 ns |  1.37 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject |        net472 | 31.639 ns | 0.0469 ns | 0.0415 ns | 31.626 ns |  1.45 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_Double_Nullable_WithValue | .NET Core 2.0 | 18.149 ns | 0.0595 ns | 0.0497 ns | 18.135 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 2.2 | 14.849 ns | 0.0233 ns | 0.0194 ns | 14.850 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 3.0 | 13.710 ns | 0.2970 ns | 0.5651 ns | 13.423 ns |  0.80 |    0.03 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net461 | 18.319 ns | 0.0309 ns | 0.0274 ns | 18.326 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net472 | 17.230 ns | 0.1026 ns | 0.0960 ns | 17.262 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.0 | 21.813 ns | 0.0572 ns | 0.0535 ns | 21.809 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.2 | 19.689 ns | 0.0480 ns | 0.0426 ns | 19.683 ns |  0.90 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 3.0 | 20.430 ns | 0.0182 ns | 0.0170 ns | 20.431 ns |  0.94 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net461 | 29.338 ns | 0.0361 ns | 0.0301 ns | 29.336 ns |  1.34 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net472 | 34.044 ns | 0.0693 ns | 0.0648 ns | 34.051 ns |  1.56 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Double_Nullable_NoValue | .NET Core 2.0 | 12.642 ns | 0.0253 ns | 0.0224 ns | 12.648 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 2.2 | 12.085 ns | 0.1046 ns | 0.0978 ns | 12.160 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 3.0 |  9.997 ns | 0.0206 ns | 0.0183 ns |  9.996 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net461 | 14.501 ns | 0.1496 ns | 0.1400 ns | 14.568 ns |  1.15 |    0.01 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net472 | 15.121 ns | 0.1275 ns | 0.1193 ns | 15.175 ns |  1.20 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.940 ns | 0.0152 ns | 0.0127 ns | 14.943 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.971 ns | 0.0287 ns | 0.0268 ns | 12.973 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.644 ns | 0.0943 ns | 0.0882 ns | 13.675 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net461 | 22.413 ns | 0.0496 ns | 0.0464 ns | 22.417 ns |  1.50 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net472 | 26.306 ns | 0.0671 ns | 0.0627 ns | 26.301 ns |  1.76 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_Short | .NET Core 2.0 | 12.629 ns | 0.0296 ns | 0.0276 ns | 12.634 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 2.2 | 13.251 ns | 0.0376 ns | 0.0351 ns | 13.249 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 3.0 | 10.170 ns | 0.0158 ns | 0.0140 ns | 10.166 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                                            From_Short |        net461 | 14.551 ns | 0.0380 ns | 0.0337 ns | 14.553 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                                            From_Short |        net472 | 13.477 ns | 0.0195 ns | 0.0172 ns | 13.479 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_Short_AsObject | .NET Core 2.0 | 21.506 ns | 0.0426 ns | 0.0356 ns | 21.506 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 2.2 | 18.172 ns | 0.1749 ns | 0.1636 ns | 18.197 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 3.0 | 18.185 ns | 0.0353 ns | 0.0295 ns | 18.184 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net461 | 27.723 ns | 0.2240 ns | 0.2095 ns | 27.877 ns |  1.29 |    0.01 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net472 | 30.094 ns | 0.1483 ns | 0.1387 ns | 30.141 ns |  1.40 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Short_Nullable_WithValue | .NET Core 2.0 | 12.983 ns | 0.0118 ns | 0.0099 ns | 12.986 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 2.2 | 15.196 ns | 0.0094 ns | 0.0079 ns | 15.195 ns |  1.17 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 3.0 | 10.463 ns | 0.0493 ns | 0.0461 ns | 10.434 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net461 | 14.514 ns | 0.0215 ns | 0.0201 ns | 14.511 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net472 | 13.923 ns | 0.0266 ns | 0.0249 ns | 13.921 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.024 ns | 0.0354 ns | 0.0276 ns | 20.020 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.937 ns | 0.0339 ns | 0.0300 ns | 17.941 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.602 ns | 0.0630 ns | 0.0590 ns | 18.601 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net461 | 28.004 ns | 0.0639 ns | 0.0566 ns | 27.995 ns |  1.40 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net472 | 31.535 ns | 0.0772 ns | 0.0602 ns | 31.553 ns |  1.57 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Short_Nullable_NoValue | .NET Core 2.0 | 11.908 ns | 0.0434 ns | 0.0363 ns | 11.897 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 2.2 | 11.312 ns | 0.0185 ns | 0.0164 ns | 11.313 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 3.0 |  9.524 ns | 0.0151 ns | 0.0118 ns |  9.523 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net461 | 13.721 ns | 0.0975 ns | 0.0912 ns | 13.748 ns |  1.15 |    0.01 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net472 | 13.002 ns | 0.0830 ns | 0.0777 ns | 13.031 ns |  1.09 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.964 ns | 0.0213 ns | 0.0189 ns | 14.967 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.000 ns | 0.0130 ns | 0.0102 ns | 12.999 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.786 ns | 0.3007 ns | 0.5106 ns | 13.475 ns |  0.96 |    0.03 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net461 | 22.717 ns | 0.0376 ns | 0.0351 ns | 22.710 ns |  1.52 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net472 | 26.409 ns | 0.0627 ns | 0.0587 ns | 26.402 ns |  1.77 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                              From_Int | .NET Core 2.0 | 12.626 ns | 0.0281 ns | 0.0234 ns | 12.625 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 2.2 | 12.553 ns | 0.0301 ns | 0.0281 ns | 12.553 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 3.0 |  9.957 ns | 0.0215 ns | 0.0201 ns |  9.955 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                                              From_Int |        net461 | 15.160 ns | 0.0653 ns | 0.0611 ns | 15.147 ns |  1.20 |    0.00 |      - |     - |     - |         - |
                                              From_Int |        net472 | 14.033 ns | 0.0330 ns | 0.0293 ns | 14.023 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_Int_AsObject | .NET Core 2.0 | 20.037 ns | 0.0581 ns | 0.0454 ns | 20.029 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 2.2 | 17.844 ns | 0.0222 ns | 0.0208 ns | 17.848 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 3.0 | 18.454 ns | 0.0346 ns | 0.0289 ns | 18.456 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net461 | 28.059 ns | 0.1740 ns | 0.1542 ns | 28.098 ns |  1.40 |    0.01 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net472 | 29.753 ns | 0.0709 ns | 0.0663 ns | 29.755 ns |  1.49 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Int_Nullable_WithValue | .NET Core 2.0 | 13.040 ns | 0.0145 ns | 0.0121 ns | 13.040 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 2.2 | 13.746 ns | 0.0904 ns | 0.0846 ns | 13.744 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 3.0 | 10.219 ns | 0.0174 ns | 0.0145 ns | 10.213 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net461 | 14.780 ns | 0.0201 ns | 0.0168 ns | 14.783 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net472 | 13.777 ns | 0.0221 ns | 0.0196 ns | 13.781 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.947 ns | 0.0346 ns | 0.0323 ns | 19.944 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.858 ns | 0.0267 ns | 0.0249 ns | 17.867 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.303 ns | 0.0237 ns | 0.0198 ns | 18.301 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net461 | 27.630 ns | 0.0468 ns | 0.0415 ns | 27.622 ns |  1.39 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net472 | 29.884 ns | 0.1867 ns | 0.1746 ns | 29.812 ns |  1.50 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_Int_Nullable_NoValue | .NET Core 2.0 | 12.013 ns | 0.1294 ns | 0.1211 ns | 12.085 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 2.2 | 10.854 ns | 0.0224 ns | 0.0175 ns | 10.854 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 3.0 |  9.740 ns | 0.0128 ns | 0.0114 ns |  9.738 ns |  0.81 |    0.01 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net461 | 14.409 ns | 0.0795 ns | 0.0664 ns | 14.420 ns |  1.20 |    0.01 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net472 | 13.238 ns | 0.0304 ns | 0.0285 ns | 13.232 ns |  1.10 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.861 ns | 0.0106 ns | 0.0099 ns | 14.861 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.979 ns | 0.0116 ns | 0.0103 ns | 12.980 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.459 ns | 0.0238 ns | 0.0222 ns | 13.454 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net461 | 24.698 ns | 0.0667 ns | 0.0624 ns | 24.713 ns |  1.66 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net472 | 26.659 ns | 0.0305 ns | 0.0285 ns | 26.655 ns |  1.79 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Long | .NET Core 2.0 | 12.686 ns | 0.0123 ns | 0.0103 ns | 12.688 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Long | .NET Core 2.2 | 12.638 ns | 0.1127 ns | 0.1054 ns | 12.570 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                                             From_Long | .NET Core 3.0 |  9.947 ns | 0.0237 ns | 0.0198 ns |  9.950 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                                             From_Long |        net461 | 14.002 ns | 0.0165 ns | 0.0154 ns | 14.002 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                             From_Long |        net472 | 13.115 ns | 0.0541 ns | 0.0506 ns | 13.094 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Long_AsObject | .NET Core 2.0 | 20.510 ns | 0.1830 ns | 0.1712 ns | 20.599 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 2.2 | 17.989 ns | 0.0451 ns | 0.0422 ns | 17.988 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 3.0 | 19.647 ns | 0.1488 ns | 0.1392 ns | 19.572 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net461 | 28.052 ns | 0.2609 ns | 0.2441 ns | 27.901 ns |  1.37 |    0.02 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net472 | 30.660 ns | 0.0627 ns | 0.0586 ns | 30.669 ns |  1.49 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Long_Nullable_WithValue | .NET Core 2.0 | 14.151 ns | 0.0196 ns | 0.0164 ns | 14.153 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 2.2 | 13.153 ns | 0.0238 ns | 0.0199 ns | 13.151 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 3.0 | 10.663 ns | 0.0078 ns | 0.0065 ns | 10.663 ns |  0.75 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net461 | 15.319 ns | 0.0235 ns | 0.0220 ns | 15.320 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net472 | 14.660 ns | 0.0203 ns | 0.0190 ns | 14.661 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.227 ns | 0.0530 ns | 0.0496 ns | 20.237 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.948 ns | 0.1503 ns | 0.1406 ns | 17.859 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.070 ns | 0.0317 ns | 0.0281 ns | 18.067 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net461 | 27.926 ns | 0.0523 ns | 0.0464 ns | 27.936 ns |  1.38 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net472 | 31.210 ns | 0.0420 ns | 0.0328 ns | 31.210 ns |  1.54 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Long_Nullable_NoValue | .NET Core 2.0 | 12.935 ns | 0.1329 ns | 0.1243 ns | 12.990 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 2.2 | 12.088 ns | 0.0321 ns | 0.0301 ns | 12.089 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 3.0 |  9.973 ns | 0.0161 ns | 0.0135 ns |  9.972 ns |  0.77 |    0.01 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net461 | 14.253 ns | 0.0300 ns | 0.0250 ns | 14.253 ns |  1.10 |    0.01 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net472 | 14.305 ns | 0.0437 ns | 0.0409 ns | 14.300 ns |  1.11 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.848 ns | 0.0195 ns | 0.0182 ns | 14.839 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.665 ns | 0.0247 ns | 0.0231 ns | 13.660 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.476 ns | 0.0442 ns | 0.0414 ns | 13.461 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net461 | 22.696 ns | 0.0318 ns | 0.0282 ns | 22.692 ns |  1.53 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net472 | 24.470 ns | 0.0271 ns | 0.0253 ns | 24.466 ns |  1.65 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_SByte | .NET Core 2.0 | 11.891 ns | 0.0198 ns | 0.0165 ns | 11.887 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 2.2 | 15.564 ns | 0.1545 ns | 0.1445 ns | 15.484 ns |  1.31 |    0.01 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 3.0 |  9.529 ns | 0.0137 ns | 0.0122 ns |  9.531 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                            From_SByte |        net461 | 12.951 ns | 0.0186 ns | 0.0145 ns | 12.955 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                            From_SByte |        net472 | 12.429 ns | 0.1377 ns | 0.1288 ns | 12.502 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_SByte_AsObject | .NET Core 2.0 | 24.770 ns | 0.0363 ns | 0.0322 ns | 24.769 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 2.2 | 25.462 ns | 0.0472 ns | 0.0442 ns | 25.468 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 3.0 | 27.607 ns | 0.1411 ns | 0.1320 ns | 27.530 ns |  1.11 |    0.01 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net461 | 35.361 ns | 0.0502 ns | 0.0445 ns | 35.347 ns |  1.43 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net472 | 39.377 ns | 0.0548 ns | 0.0512 ns | 39.374 ns |  1.59 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_SByte_Nullable_WithValue | .NET Core 2.0 | 11.389 ns | 0.0246 ns | 0.0231 ns | 11.385 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 2.2 | 10.251 ns | 0.0203 ns | 0.0180 ns | 10.253 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 3.0 |  6.991 ns | 0.0845 ns | 0.0790 ns |  7.034 ns |  0.61 |    0.01 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net461 | 12.570 ns | 0.0114 ns | 0.0107 ns | 12.570 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net472 | 11.848 ns | 0.0103 ns | 0.0096 ns | 11.851 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.0 | 24.394 ns | 0.0458 ns | 0.0428 ns | 24.377 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.2 | 25.574 ns | 0.1005 ns | 0.0839 ns | 25.559 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 3.0 | 28.350 ns | 0.0530 ns | 0.0414 ns | 28.355 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net461 | 35.241 ns | 0.3492 ns | 0.3267 ns | 35.059 ns |  1.44 |    0.01 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net472 | 39.260 ns | 0.3836 ns | 0.3588 ns | 39.106 ns |  1.61 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_SByte_Nullable_NoValue | .NET Core 2.0 | 11.387 ns | 0.0178 ns | 0.0149 ns | 11.384 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 2.2 | 10.282 ns | 0.0195 ns | 0.0183 ns | 10.288 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 3.0 |  6.758 ns | 0.5373 ns | 0.6396 ns |  6.406 ns |  0.61 |    0.06 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net461 | 11.856 ns | 0.0290 ns | 0.0271 ns | 11.849 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net472 | 11.846 ns | 0.0205 ns | 0.0192 ns | 11.844 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.123 ns | 0.1033 ns | 0.0966 ns | 15.185 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.049 ns | 0.0227 ns | 0.0202 ns | 13.047 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.504 ns | 0.1382 ns | 0.1292 ns | 13.429 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net461 | 22.799 ns | 0.0329 ns | 0.0308 ns | 22.798 ns |  1.51 |    0.01 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net472 | 24.516 ns | 0.0181 ns | 0.0161 ns | 24.519 ns |  1.62 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_Float | .NET Core 2.0 | 15.210 ns | 0.0192 ns | 0.0150 ns | 15.215 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 2.2 | 14.150 ns | 0.1328 ns | 0.1242 ns | 14.207 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                                            From_Float | .NET Core 3.0 | 12.512 ns | 0.0196 ns | 0.0164 ns | 12.515 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                            From_Float |        net461 | 16.633 ns | 0.1742 ns | 0.1630 ns | 16.550 ns |  1.09 |    0.01 |      - |     - |     - |         - |
                                            From_Float |        net472 | 16.333 ns | 0.0307 ns | 0.0287 ns | 16.339 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_Float_AsObject | .NET Core 2.0 | 22.465 ns | 0.0454 ns | 0.0402 ns | 22.476 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 2.2 | 19.697 ns | 0.0264 ns | 0.0247 ns | 19.699 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 3.0 | 21.315 ns | 0.0772 ns | 0.0645 ns | 21.284 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject |        net461 | 29.566 ns | 0.0720 ns | 0.0673 ns | 29.571 ns |  1.32 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject |        net472 | 33.961 ns | 0.1240 ns | 0.1160 ns | 33.994 ns |  1.51 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Float_Nullable_WithValue | .NET Core 2.0 | 15.905 ns | 0.1035 ns | 0.0968 ns | 15.957 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 2.2 | 13.613 ns | 0.0280 ns | 0.0248 ns | 13.612 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 3.0 | 12.983 ns | 0.0087 ns | 0.0068 ns | 12.982 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net461 | 16.101 ns | 0.0247 ns | 0.0231 ns | 16.102 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net472 | 15.431 ns | 0.0156 ns | 0.0146 ns | 15.431 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.0 | 22.172 ns | 0.0360 ns | 0.0337 ns | 22.176 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.2 | 19.677 ns | 0.0316 ns | 0.0296 ns | 19.680 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 3.0 | 22.175 ns | 0.0275 ns | 0.0257 ns | 22.183 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net461 | 30.072 ns | 0.0530 ns | 0.0470 ns | 30.071 ns |  1.36 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net472 | 32.000 ns | 0.2469 ns | 0.2310 ns | 31.909 ns |  1.44 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Float_Nullable_NoValue | .NET Core 2.0 | 12.193 ns | 0.0641 ns | 0.0600 ns | 12.173 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 2.2 | 11.553 ns | 0.0360 ns | 0.0301 ns | 11.551 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 3.0 |  9.987 ns | 0.0142 ns | 0.0119 ns |  9.992 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net461 | 14.345 ns | 0.0281 ns | 0.0249 ns | 14.339 ns |  1.18 |    0.01 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net472 | 13.180 ns | 0.1036 ns | 0.0969 ns | 13.228 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.040 ns | 0.1051 ns | 0.0983 ns | 15.107 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.684 ns | 0.1213 ns | 0.1135 ns | 13.609 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.480 ns | 0.0212 ns | 0.0177 ns | 13.479 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net461 | 21.509 ns | 0.0300 ns | 0.0280 ns | 21.506 ns |  1.43 |    0.01 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net472 | 26.323 ns | 0.0334 ns | 0.0296 ns | 26.324 ns |  1.75 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_String | .NET Core 2.0 | 59.444 ns | 0.0813 ns | 0.0761 ns | 59.427 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 2.2 | 58.988 ns | 0.0783 ns | 0.0732 ns | 59.000 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 3.0 | 20.777 ns | 0.1747 ns | 0.1634 ns | 20.690 ns |  0.35 |    0.00 |      - |     - |     - |         - |
                                           From_String |        net461 | 60.977 ns | 0.5131 ns | 0.4800 ns | 60.758 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                           From_String |        net472 | 62.028 ns | 0.2283 ns | 0.2024 ns | 61.984 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_String_AsObject | .NET Core 2.0 | 66.098 ns | 0.1473 ns | 0.1230 ns | 66.114 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 2.2 | 62.509 ns | 0.1268 ns | 0.1186 ns | 62.520 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 3.0 | 26.402 ns | 0.0609 ns | 0.0509 ns | 26.391 ns |  0.40 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject |        net461 | 73.648 ns | 0.1632 ns | 0.1274 ns | 73.625 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject |        net472 | 76.810 ns | 0.0894 ns | 0.0792 ns | 76.807 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                      From_String_Null | .NET Core 2.0 | 14.349 ns | 0.0871 ns | 0.0815 ns | 14.387 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 2.2 | 19.224 ns | 0.1547 ns | 0.1447 ns | 19.286 ns |  1.34 |    0.01 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 3.0 | 16.286 ns | 0.3512 ns | 0.8940 ns | 16.586 ns |  1.05 |    0.11 |      - |     - |     - |         - |
                                      From_String_Null |        net461 | 15.517 ns | 0.0190 ns | 0.0178 ns | 15.520 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                                      From_String_Null |        net472 | 16.217 ns | 0.0421 ns | 0.0352 ns | 16.217 ns |  1.13 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_String_Null_AsObject | .NET Core 2.0 | 15.341 ns | 0.0191 ns | 0.0169 ns | 15.346 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 2.2 | 12.974 ns | 0.0214 ns | 0.0201 ns | 12.967 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 3.0 | 14.784 ns | 0.0179 ns | 0.0167 ns | 14.785 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net461 | 22.749 ns | 0.0359 ns | 0.0280 ns | 22.753 ns |  1.48 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net472 | 26.343 ns | 0.0861 ns | 0.0719 ns | 26.337 ns |  1.72 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_String_Empty | .NET Core 2.0 | 14.238 ns | 0.0779 ns | 0.0729 ns | 14.205 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 2.2 | 18.660 ns | 0.0554 ns | 0.0491 ns | 18.653 ns |  1.31 |    0.01 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 3.0 | 13.793 ns | 0.0583 ns | 0.0517 ns | 13.778 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                                     From_String_Empty |        net461 | 14.858 ns | 0.0311 ns | 0.0291 ns | 14.865 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                     From_String_Empty |        net472 | 15.550 ns | 0.0047 ns | 0.0036 ns | 15.550 ns |  1.09 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_String_Empty_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_UShort | .NET Core 2.0 | 11.925 ns | 0.0198 ns | 0.0175 ns | 11.930 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 2.2 | 11.470 ns | 0.0148 ns | 0.0138 ns | 11.466 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 3.0 |  9.701 ns | 0.0113 ns | 0.0100 ns |  9.700 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                                           From_UShort |        net461 | 14.619 ns | 0.0189 ns | 0.0148 ns | 14.622 ns |  1.23 |    0.00 |      - |     - |     - |         - |
                                           From_UShort |        net472 | 13.066 ns | 0.0254 ns | 0.0225 ns | 13.069 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_UShort_AsObject | .NET Core 2.0 | 19.734 ns | 0.0906 ns | 0.0803 ns | 19.711 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 2.2 | 17.888 ns | 0.0935 ns | 0.0874 ns | 17.931 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 3.0 | 17.924 ns | 0.1502 ns | 0.1405 ns | 17.865 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net461 | 27.379 ns | 0.0274 ns | 0.0257 ns | 27.379 ns |  1.39 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net472 | 29.646 ns | 0.0616 ns | 0.0576 ns | 29.630 ns |  1.50 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_UShort_Nullable_WithValue | .NET Core 2.0 | 12.261 ns | 0.0873 ns | 0.0817 ns | 12.305 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 2.2 | 11.131 ns | 0.0131 ns | 0.0102 ns | 11.134 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 3.0 |  9.998 ns | 0.0211 ns | 0.0198 ns |  9.996 ns |  0.82 |    0.01 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net461 | 15.231 ns | 0.1516 ns | 0.1418 ns | 15.329 ns |  1.24 |    0.01 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net472 | 13.469 ns | 0.0244 ns | 0.0204 ns | 13.471 ns |  1.10 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.756 ns | 0.0343 ns | 0.0321 ns | 19.761 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.608 ns | 0.0327 ns | 0.0290 ns | 17.610 ns |  0.89 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 3.0 | 19.206 ns | 0.4095 ns | 0.7792 ns | 19.626 ns |  0.93 |    0.04 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net461 | 29.178 ns | 0.0549 ns | 0.0486 ns | 29.174 ns |  1.48 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net472 | 29.474 ns | 0.0389 ns | 0.0364 ns | 29.474 ns |  1.49 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_UShort_Nullable_NoValue | .NET Core 2.0 | 12.181 ns | 0.0479 ns | 0.0448 ns | 12.174 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 2.2 | 10.887 ns | 0.0907 ns | 0.0848 ns | 10.924 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 3.0 |  9.753 ns | 0.0163 ns | 0.0144 ns |  9.751 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net461 | 14.136 ns | 0.0326 ns | 0.0305 ns | 14.129 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net472 | 12.784 ns | 0.0175 ns | 0.0164 ns | 12.787 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.021 ns | 0.1055 ns | 0.0987 ns | 14.956 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.986 ns | 0.0275 ns | 0.0244 ns | 12.983 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.435 ns | 0.0175 ns | 0.0146 ns | 13.442 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net461 | 22.815 ns | 0.2149 ns | 0.2010 ns | 22.697 ns |  1.52 |    0.02 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net472 | 26.843 ns | 0.2474 ns | 0.2315 ns | 26.948 ns |  1.79 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_UInt | .NET Core 2.0 | 12.165 ns | 0.0362 ns | 0.0321 ns | 12.159 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 2.2 | 11.470 ns | 0.0350 ns | 0.0311 ns | 11.461 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 3.0 |  9.718 ns | 0.0080 ns | 0.0075 ns |  9.716 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                             From_UInt |        net461 | 14.667 ns | 0.0542 ns | 0.0480 ns | 14.663 ns |  1.21 |    0.01 |      - |     - |     - |         - |
                                             From_UInt |        net472 | 13.524 ns | 0.0196 ns | 0.0184 ns | 13.527 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_UInt_AsObject | .NET Core 2.0 | 19.908 ns | 0.1197 ns | 0.1119 ns | 19.887 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 2.2 | 17.845 ns | 0.1767 ns | 0.1653 ns | 17.936 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 3.0 | 17.841 ns | 0.0221 ns | 0.0173 ns | 17.839 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net461 | 27.582 ns | 0.0501 ns | 0.0444 ns | 27.576 ns |  1.38 |    0.01 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net472 | 30.661 ns | 0.0517 ns | 0.0432 ns | 30.658 ns |  1.54 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_UInt_Nullable_WithValue | .NET Core 2.0 | 12.247 ns | 0.1125 ns | 0.1052 ns | 12.308 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 2.2 | 11.158 ns | 0.0196 ns | 0.0174 ns | 11.154 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 3.0 | 10.026 ns | 0.0675 ns | 0.0632 ns | 10.000 ns |  0.82 |    0.01 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net461 | 16.754 ns | 0.0189 ns | 0.0147 ns | 16.753 ns |  1.37 |    0.01 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net472 | 15.118 ns | 0.1704 ns | 0.1594 ns | 15.024 ns |  1.23 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.852 ns | 0.0376 ns | 0.0352 ns | 19.871 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.907 ns | 0.0300 ns | 0.0280 ns | 17.906 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.867 ns | 0.0371 ns | 0.0290 ns | 17.865 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net461 | 27.320 ns | 0.0932 ns | 0.0872 ns | 27.342 ns |  1.38 |    0.01 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net472 | 31.439 ns | 0.0371 ns | 0.0329 ns | 31.440 ns |  1.58 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_UInt_Nullable_NoValue | .NET Core 2.0 | 12.201 ns | 0.0716 ns | 0.0670 ns | 12.164 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 2.2 | 10.761 ns | 0.0218 ns | 0.0170 ns | 10.758 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 3.0 |  9.894 ns | 0.0233 ns | 0.0207 ns |  9.899 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net461 | 13.552 ns | 0.0212 ns | 0.0198 ns | 13.554 ns |  1.11 |    0.01 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net472 | 12.785 ns | 0.0248 ns | 0.0232 ns | 12.784 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.903 ns | 0.0262 ns | 0.0232 ns | 14.905 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.171 ns | 0.0909 ns | 0.0850 ns | 13.209 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.478 ns | 0.0174 ns | 0.0154 ns | 13.479 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net461 | 22.808 ns | 0.1706 ns | 0.1595 ns | 22.723 ns |  1.53 |    0.01 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net472 | 25.835 ns | 0.1219 ns | 0.1140 ns | 25.868 ns |  1.73 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_ULong | .NET Core 2.0 | 12.257 ns | 0.0160 ns | 0.0150 ns | 12.258 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 2.2 | 11.509 ns | 0.0405 ns | 0.0378 ns | 11.490 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 3.0 |  9.515 ns | 0.0903 ns | 0.0845 ns |  9.473 ns |  0.78 |    0.01 |      - |     - |     - |         - |
                                            From_ULong |        net461 | 14.069 ns | 0.0337 ns | 0.0316 ns | 14.078 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                                            From_ULong |        net472 | 13.059 ns | 0.0238 ns | 0.0223 ns | 13.056 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_ULong_AsObject | .NET Core 2.0 | 20.003 ns | 0.0450 ns | 0.0399 ns | 20.006 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 2.2 | 17.798 ns | 0.0338 ns | 0.0264 ns | 17.789 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 3.0 | 18.051 ns | 0.0592 ns | 0.0525 ns | 18.060 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net461 | 30.096 ns | 0.0348 ns | 0.0308 ns | 30.092 ns |  1.50 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net472 | 29.358 ns | 0.0301 ns | 0.0252 ns | 29.350 ns |  1.47 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_ULong_Nullable_WithValue | .NET Core 2.0 | 12.900 ns | 0.0866 ns | 0.0810 ns | 12.865 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 2.2 | 12.319 ns | 0.0747 ns | 0.0662 ns | 12.344 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 3.0 | 10.686 ns | 0.0270 ns | 0.0253 ns | 10.681 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net461 | 15.356 ns | 0.1358 ns | 0.1270 ns | 15.277 ns |  1.19 |    0.01 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net472 | 14.921 ns | 0.0413 ns | 0.0386 ns | 14.912 ns |  1.16 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.688 ns | 0.0309 ns | 0.0289 ns | 19.690 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.617 ns | 0.0183 ns | 0.0143 ns | 17.617 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.239 ns | 0.0500 ns | 0.0444 ns | 18.233 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net461 | 29.436 ns | 0.0554 ns | 0.0518 ns | 29.435 ns |  1.50 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net472 | 30.962 ns | 0.0394 ns | 0.0349 ns | 30.967 ns |  1.57 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_ULong_Nullable_NoValue | .NET Core 2.0 | 12.608 ns | 0.0230 ns | 0.0192 ns | 12.604 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 2.2 | 11.882 ns | 0.1051 ns | 0.0983 ns | 11.869 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 3.0 |  9.926 ns | 0.0586 ns | 0.0490 ns |  9.942 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net461 | 14.891 ns | 0.0194 ns | 0.0151 ns | 14.892 ns |  1.18 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net472 | 14.007 ns | 0.0308 ns | 0.0273 ns | 14.010 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.769 ns | 0.0307 ns | 0.0287 ns | 15.768 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.184 ns | 0.0662 ns | 0.0587 ns | 13.207 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.452 ns | 0.0166 ns | 0.0156 ns | 13.456 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net461 | 25.644 ns | 0.1409 ns | 0.1318 ns | 25.663 ns |  1.63 |    0.01 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net472 | 27.024 ns | 0.1298 ns | 0.1214 ns | 27.054 ns |  1.71 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                       From_NullObject | .NET Core 2.0 | 14.908 ns | 0.0262 ns | 0.0232 ns | 14.911 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 2.2 | 12.993 ns | 0.0155 ns | 0.0137 ns | 12.991 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 3.0 | 13.250 ns | 0.0211 ns | 0.0197 ns | 13.248 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject |        net461 | 23.916 ns | 0.0575 ns | 0.0510 ns | 23.931 ns |  1.60 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject |        net472 | 26.328 ns | 0.0282 ns | 0.0264 ns | 26.326 ns |  1.77 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_DBNull | .NET Core 2.0 | 12.861 ns | 0.0181 ns | 0.0141 ns | 12.858 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 2.2 | 11.230 ns | 0.1092 ns | 0.1021 ns | 11.173 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 3.0 | 13.028 ns | 0.0185 ns | 0.0144 ns | 13.025 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull |        net461 | 12.966 ns | 0.0429 ns | 0.0401 ns | 12.955 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull |        net472 | 12.996 ns | 0.0200 ns | 0.0187 ns | 12.991 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_DBNull_AsObject | .NET Core 2.0 | 14.936 ns | 0.0384 ns | 0.0359 ns | 14.923 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 2.2 | 13.190 ns | 0.0560 ns | 0.0524 ns | 13.182 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 3.0 | 13.626 ns | 0.0806 ns | 0.0754 ns | 13.655 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net461 | 22.931 ns | 0.1793 ns | 0.1677 ns | 23.005 ns |  1.54 |    0.01 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net472 | 24.938 ns | 0.1153 ns | 0.1079 ns | 24.953 ns |  1.67 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                 From_ConvertibleClass | .NET Core 2.0 | 17.470 ns | 0.0258 ns | 0.0215 ns | 17.472 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 2.2 | 15.594 ns | 0.0293 ns | 0.0244 ns | 15.596 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 3.0 | 15.046 ns | 0.0221 ns | 0.0184 ns | 15.046 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net461 | 26.012 ns | 0.0682 ns | 0.0638 ns | 26.013 ns |  1.49 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net472 | 26.162 ns | 0.2384 ns | 0.1861 ns | 26.239 ns |  1.50 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_ConvertibleClass_AsObject | .NET Core 2.0 | 18.641 ns | 0.0300 ns | 0.0250 ns | 18.643 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 2.2 | 17.058 ns | 0.1631 ns | 0.1526 ns | 16.971 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 3.0 | 17.216 ns | 0.3268 ns | 0.3057 ns | 17.057 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net461 | 26.177 ns | 0.0718 ns | 0.0671 ns | 26.167 ns |  1.40 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net472 | 28.017 ns | 0.0495 ns | 0.0439 ns | 28.029 ns |  1.50 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_ConvertibleClass_NoValue | .NET Core 2.0 | 16.265 ns | 0.0344 ns | 0.0322 ns | 16.262 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 2.2 | 13.691 ns | 0.0679 ns | 0.0635 ns | 13.693 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 3.0 | 13.475 ns | 0.1069 ns | 0.1000 ns | 13.544 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net461 | 22.990 ns | 0.1364 ns | 0.1276 ns | 23.048 ns |  1.41 |    0.01 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net472 | 22.908 ns | 0.0485 ns | 0.0430 ns | 22.897 ns |  1.41 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.0 | 14.910 ns | 0.0294 ns | 0.0246 ns | 14.908 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.2 | 13.178 ns | 0.0202 ns | 0.0179 ns | 13.172 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 3.0 | 13.472 ns | 0.0146 ns | 0.0129 ns | 13.475 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net461 | 22.754 ns | 0.0426 ns | 0.0377 ns | 22.753 ns |  1.53 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net472 | 25.001 ns | 0.0374 ns | 0.0350 ns | 24.995 ns |  1.68 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                              From_NonConvertibleClass | .NET Core 2.0 | 14.053 ns | 0.0942 ns | 0.0882 ns | 14.007 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 2.2 | 12.782 ns | 0.0232 ns | 0.0181 ns | 12.785 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 3.0 | 12.728 ns | 0.0202 ns | 0.0169 ns | 12.732 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net461 | 15.414 ns | 0.0456 ns | 0.0426 ns | 15.408 ns |  1.10 |    0.01 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net472 | 14.362 ns | 0.0210 ns | 0.0186 ns | 14.360 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                     From_NonConvertibleClass_AsObject | .NET Core 2.0 | 16.733 ns | 0.0362 ns | 0.0338 ns | 16.728 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 2.2 | 14.902 ns | 0.0134 ns | 0.0126 ns | 14.902 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 3.0 | 15.417 ns | 0.1197 ns | 0.0999 ns | 15.361 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net461 | 25.078 ns | 0.1851 ns | 0.1732 ns | 25.182 ns |  1.50 |    0.01 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net472 | 27.995 ns | 0.0702 ns | 0.0657 ns | 27.984 ns |  1.67 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                      From_NonConvertibleClass_NoValue | .NET Core 2.0 | 13.954 ns | 0.0069 ns | 0.0061 ns | 13.953 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 2.2 | 12.776 ns | 0.0197 ns | 0.0184 ns | 12.773 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 3.0 | 12.679 ns | 0.0489 ns | 0.0457 ns | 12.667 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net461 | 14.368 ns | 0.0269 ns | 0.0238 ns | 14.370 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net472 | 14.587 ns | 0.1340 ns | 0.1254 ns | 14.661 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.0 | 15.588 ns | 0.0285 ns | 0.0238 ns | 15.585 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.2 | 13.053 ns | 0.0959 ns | 0.0897 ns | 13.002 ns |  0.84 |    0.01 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 3.0 | 13.623 ns | 0.1705 ns | 0.1594 ns | 13.530 ns |  0.87 |    0.01 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net461 | 22.740 ns | 0.0368 ns | 0.0326 ns | 22.746 ns |  1.46 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net472 | 24.541 ns | 0.0384 ns | 0.0359 ns | 24.534 ns |  1.57 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                From_ConvertibleStruct | .NET Core 2.0 | 20.754 ns | 0.0570 ns | 0.0534 ns | 20.750 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 2.2 | 16.275 ns | 0.1079 ns | 0.0957 ns | 16.237 ns |  0.78 |    0.01 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 3.0 | 14.636 ns | 0.2553 ns | 0.2388 ns | 14.500 ns |  0.71 |    0.01 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net461 | 20.699 ns | 0.1671 ns | 0.1563 ns | 20.688 ns |  1.00 |    0.01 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net472 | 18.737 ns | 0.0229 ns | 0.0203 ns | 18.735 ns |  0.90 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                       From_ConvertibleStruct_AsObject | .NET Core 2.0 | 19.421 ns | 0.0335 ns | 0.0297 ns | 19.426 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 2.2 | 17.158 ns | 0.0212 ns | 0.0198 ns | 17.164 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 3.0 | 17.648 ns | 0.0674 ns | 0.0630 ns | 17.662 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net461 | 27.044 ns | 0.0698 ns | 0.0653 ns | 27.062 ns |  1.39 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net472 | 30.298 ns | 0.2745 ns | 0.2568 ns | 30.419 ns |  1.56 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.0 | 20.578 ns | 0.0332 ns | 0.0311 ns | 20.577 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.2 | 17.578 ns | 0.0832 ns | 0.0778 ns | 17.569 ns |  0.85 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 3.0 | 15.723 ns | 0.9858 ns | 1.5635 ns | 14.883 ns |  0.82 |    0.09 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net461 | 26.339 ns | 0.0733 ns | 0.0650 ns | 26.325 ns |  1.28 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net472 | 27.022 ns | 0.0676 ns | 0.0599 ns | 27.031 ns |  1.31 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.943 ns | 0.0372 ns | 0.0348 ns | 19.931 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.395 ns | 0.0627 ns | 0.0587 ns | 17.409 ns |  0.87 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.916 ns | 0.0948 ns | 0.0887 ns | 18.889 ns |  0.95 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net461 | 27.723 ns | 0.1880 ns | 0.1759 ns | 27.771 ns |  1.39 |    0.01 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net472 | 30.483 ns | 0.0431 ns | 0.0382 ns | 30.487 ns |  1.53 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.0 | 14.016 ns | 0.0178 ns | 0.0157 ns | 14.018 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.2 | 12.058 ns | 0.0179 ns | 0.0149 ns | 12.061 ns |  0.86 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 3.0 | 10.183 ns | 0.0143 ns | 0.0120 ns | 10.183 ns |  0.73 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net461 | 19.807 ns | 0.2042 ns | 0.1910 ns | 19.853 ns |  1.41 |    0.01 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net472 | 19.496 ns | 0.1862 ns | 0.1742 ns | 19.595 ns |  1.39 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.865 ns | 0.0381 ns | 0.0356 ns | 15.862 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.009 ns | 0.0229 ns | 0.0203 ns | 13.004 ns |  0.82 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.030 ns | 0.0197 ns | 0.0184 ns | 14.026 ns |  0.88 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net461 | 22.678 ns | 0.0291 ns | 0.0258 ns | 22.684 ns |  1.43 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net472 | 25.417 ns | 0.0269 ns | 0.0238 ns | 25.412 ns |  1.60 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_NonConvertibleStruct | .NET Core 2.0 | 13.258 ns | 0.0121 ns | 0.0108 ns | 13.256 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 2.2 | 11.427 ns | 0.0472 ns | 0.0441 ns | 11.410 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 3.0 |  9.731 ns | 0.0157 ns | 0.0147 ns |  9.731 ns |  0.73 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net461 | 13.131 ns | 0.1304 ns | 0.1220 ns | 13.218 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net472 | 12.316 ns | 0.0358 ns | 0.0335 ns | 12.302 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.0 | 16.796 ns | 0.1043 ns | 0.0975 ns | 16.748 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.2 | 14.860 ns | 0.0196 ns | 0.0183 ns | 14.852 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 3.0 | 15.475 ns | 0.1683 ns | 0.1575 ns | 15.488 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net461 | 24.522 ns | 0.0459 ns | 0.0407 ns | 24.528 ns |  1.46 |    0.01 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net472 | 26.593 ns | 0.0388 ns | 0.0324 ns | 26.597 ns |  1.58 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.0 | 13.576 ns | 0.0205 ns | 0.0182 ns | 13.579 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.2 | 11.524 ns | 0.0676 ns | 0.0564 ns | 11.497 ns |  0.85 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 3.0 |  9.494 ns | 0.0409 ns | 0.0362 ns |  9.480 ns |  0.70 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net461 | 13.682 ns | 0.0317 ns | 0.0281 ns | 13.679 ns |  1.01 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net472 | 12.402 ns | 0.1292 ns | 0.1209 ns | 12.348 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 16.704 ns | 0.0144 ns | 0.0127 ns | 16.705 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 14.984 ns | 0.1238 ns | 0.1158 ns | 15.018 ns |  0.90 |    0.01 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 16.637 ns | 0.0293 ns | 0.0260 ns | 16.635 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net461 | 25.103 ns | 0.1634 ns | 0.1365 ns | 25.141 ns |  1.50 |    0.01 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net472 | 27.894 ns | 0.0286 ns | 0.0268 ns | 27.893 ns |  1.67 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.0 | 13.315 ns | 0.0799 ns | 0.0747 ns | 13.276 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.2 | 11.484 ns | 0.0166 ns | 0.0138 ns | 11.484 ns |  0.86 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 3.0 |  9.775 ns | 0.2084 ns | 0.1949 ns |  9.885 ns |  0.73 |    0.01 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net461 | 13.678 ns | 0.0193 ns | 0.0181 ns | 13.682 ns |  1.03 |    0.01 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net472 | 12.273 ns | 0.0353 ns | 0.0276 ns | 12.278 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.934 ns | 0.0270 ns | 0.0252 ns | 14.933 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.084 ns | 0.0498 ns | 0.0466 ns | 13.065 ns |  0.88 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.398 ns | 0.2984 ns | 0.4466 ns | 14.585 ns |  0.95 |    0.04 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net461 | 22.834 ns | 0.1904 ns | 0.1781 ns | 22.709 ns |  1.53 |    0.01 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net472 | 26.841 ns | 0.1405 ns | 0.1245 ns | 26.858 ns |  1.80 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Enum | .NET Core 2.0 | 14.938 ns | 0.0146 ns | 0.0122 ns | 14.939 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 2.2 | 12.002 ns | 0.0125 ns | 0.0104 ns | 12.006 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 3.0 |  9.769 ns | 0.0244 ns | 0.0191 ns |  9.766 ns |  0.65 |    0.00 |      - |     - |     - |         - |
                                             From_Enum |        net461 | 14.011 ns | 0.0323 ns | 0.0286 ns | 14.016 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                             From_Enum |        net472 | 13.047 ns | 0.0202 ns | 0.0189 ns | 13.043 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Enum_AsObject | .NET Core 2.0 | 46.802 ns | 0.0777 ns | 0.0607 ns | 46.803 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject | .NET Core 2.2 | 51.428 ns | 0.1669 ns | 0.1561 ns | 51.377 ns |  1.10 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject | .NET Core 3.0 | 41.566 ns | 0.8490 ns | 1.1621 ns | 41.022 ns |  0.91 |    0.01 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject |        net461 | 55.103 ns | 0.1612 ns | 0.1508 ns | 55.067 ns |  1.18 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject |        net472 | 57.897 ns | 0.0871 ns | 0.0727 ns | 57.875 ns |  1.24 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Enum_Nullable_WithValue | .NET Core 2.0 | 14.391 ns | 0.0283 ns | 0.0236 ns | 14.395 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 2.2 | 12.777 ns | 0.0373 ns | 0.0331 ns | 12.768 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 3.0 | 10.207 ns | 0.0322 ns | 0.0301 ns | 10.203 ns |  0.71 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net461 | 15.494 ns | 0.1404 ns | 0.1313 ns | 15.536 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net472 | 14.720 ns | 0.1091 ns | 0.1021 ns | 14.757 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.0 | 46.909 ns | 0.0869 ns | 0.0771 ns | 46.925 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.2 | 47.938 ns | 0.0806 ns | 0.0715 ns | 47.938 ns |  1.02 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 3.0 | 43.046 ns | 0.0757 ns | 0.0708 ns | 43.033 ns |  0.92 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject |        net461 | 51.606 ns | 0.1324 ns | 0.1238 ns | 51.647 ns |  1.10 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject |        net472 | 55.037 ns | 0.0905 ns | 0.0846 ns | 55.031 ns |  1.17 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Enum_Nullable_NoValue | .NET Core 2.0 | 13.304 ns | 0.0435 ns | 0.0406 ns | 13.289 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 2.2 | 11.675 ns | 0.0099 ns | 0.0083 ns | 11.676 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 3.0 |  9.493 ns | 0.0154 ns | 0.0129 ns |  9.489 ns |  0.71 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net461 | 14.186 ns | 0.0832 ns | 0.0778 ns | 14.141 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net472 | 13.514 ns | 0.0191 ns | 0.0170 ns | 13.517 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.915 ns | 0.0255 ns | 0.0239 ns | 14.921 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.472 ns | 0.0196 ns | 0.0164 ns | 13.466 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.226 ns | 0.0102 ns | 0.0090 ns | 13.224 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net461 | 22.660 ns | 0.0304 ns | 0.0285 ns | 22.661 ns |  1.52 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net472 | 25.898 ns | 0.0367 ns | 0.0343 ns | 25.888 ns |  1.74 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                      From_ParentClass | .NET Core 2.0 | 13.965 ns | 0.0363 ns | 0.0303 ns | 13.963 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 2.2 | 12.748 ns | 0.0117 ns | 0.0104 ns | 12.749 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 3.0 | 12.729 ns | 0.0286 ns | 0.0254 ns | 12.725 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass |        net461 | 14.356 ns | 0.0150 ns | 0.0125 ns | 14.354 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass |        net472 | 14.366 ns | 0.0123 ns | 0.0115 ns | 14.369 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_ParentClass_AsObject | .NET Core 2.0 | 17.425 ns | 0.1229 ns | 0.1149 ns | 17.364 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 2.2 | 15.330 ns | 0.0234 ns | 0.0219 ns | 15.325 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 3.0 | 15.320 ns | 0.0269 ns | 0.0210 ns | 15.316 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net461 | 27.602 ns | 0.0722 ns | 0.0603 ns | 27.588 ns |  1.58 |    0.01 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net472 | 27.232 ns | 0.1879 ns | 0.1757 ns | 27.305 ns |  1.56 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                              From_ParentClass_NoValue | .NET Core 2.0 | 13.940 ns | 0.0182 ns | 0.0152 ns | 13.939 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 2.2 | 12.746 ns | 0.0100 ns | 0.0089 ns | 12.743 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 3.0 | 12.505 ns | 0.0132 ns | 0.0103 ns | 12.507 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net461 | 14.377 ns | 0.0228 ns | 0.0213 ns | 14.376 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net472 | 14.367 ns | 0.0158 ns | 0.0140 ns | 14.364 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.0 | 15.011 ns | 0.0243 ns | 0.0215 ns | 15.013 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.2 | 12.974 ns | 0.0073 ns | 0.0068 ns | 12.971 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 3.0 | 13.443 ns | 0.0160 ns | 0.0150 ns | 13.442 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net461 | 22.637 ns | 0.0263 ns | 0.0246 ns | 22.633 ns |  1.51 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net472 | 24.441 ns | 0.0277 ns | 0.0232 ns | 24.431 ns |  1.63 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_ParentStruct | .NET Core 2.0 | 46.268 ns | 0.2804 ns | 0.2623 ns | 46.384 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 2.2 | 41.116 ns | 0.0552 ns | 0.0490 ns | 41.122 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 3.0 | 41.064 ns | 0.5968 ns | 0.4983 ns | 41.250 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                                     From_ParentStruct |        net461 | 57.834 ns | 0.4767 ns | 0.4459 ns | 57.614 ns |  1.25 |    0.01 |      - |     - |     - |         - |
                                     From_ParentStruct |        net472 | 49.546 ns | 0.3530 ns | 0.2948 ns | 49.677 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_ParentStruct_AsObject | .NET Core 2.0 | 18.112 ns | 0.0288 ns | 0.0269 ns | 18.110 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 2.2 | 15.306 ns | 0.0155 ns | 0.0129 ns | 15.305 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 3.0 | 15.519 ns | 0.0306 ns | 0.0271 ns | 15.518 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net461 | 24.231 ns | 0.0369 ns | 0.0346 ns | 24.220 ns |  1.34 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net472 | 27.406 ns | 0.0489 ns | 0.0457 ns | 27.386 ns |  1.51 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.0 | 42.819 ns | 0.0572 ns | 0.0535 ns | 42.822 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.2 | 40.905 ns | 0.0540 ns | 0.0505 ns | 40.915 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 3.0 | 39.710 ns | 0.2132 ns | 0.1890 ns | 39.744 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue |        net461 | 41.421 ns | 0.0797 ns | 0.0745 ns | 41.399 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue |        net472 | 44.132 ns | 0.3799 ns | 0.3554 ns | 43.924 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 17.453 ns | 0.1263 ns | 0.1182 ns | 17.520 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.307 ns | 0.0214 ns | 0.0200 ns | 15.300 ns |  0.88 |    0.01 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.558 ns | 0.0404 ns | 0.0378 ns | 15.565 ns |  0.89 |    0.01 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net461 | 24.685 ns | 0.0611 ns | 0.0542 ns | 24.678 ns |  1.41 |    0.01 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net472 | 28.290 ns | 0.1568 ns | 0.1467 ns | 28.328 ns |  1.62 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.0 | 44.042 ns | 0.0655 ns | 0.0581 ns | 44.040 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.2 | 40.440 ns | 0.0854 ns | 0.0757 ns | 40.430 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 3.0 | 37.899 ns | 0.0534 ns | 0.0473 ns | 37.896 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net461 | 42.827 ns | 0.0740 ns | 0.0692 ns | 42.816 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net472 | 42.341 ns | 0.0430 ns | 0.0402 ns | 42.338 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.934 ns | 0.0350 ns | 0.0310 ns | 14.925 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.995 ns | 0.0171 ns | 0.0143 ns | 13.000 ns |  0.87 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.482 ns | 0.0451 ns | 0.0422 ns | 13.473 ns |  0.90 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net461 | 22.665 ns | 0.0329 ns | 0.0308 ns | 22.662 ns |  1.52 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net472 | 24.465 ns | 0.0332 ns | 0.0294 ns | 24.465 ns |  1.64 |    0.00 |      - |     - |     - |         - |

Benchmarks with issues:
  ConvertTo_SByteNullable.From_DateTime_AsObject: Job-LRKCAO(Toolchain=.NET Core 2.0)
  ConvertTo_SByteNullable.From_DateTime_AsObject: Job-VAJWLV(Toolchain=.NET Core 2.2)
  ConvertTo_SByteNullable.From_DateTime_AsObject: Job-TJIRAH(Toolchain=.NET Core 3.0)
  ConvertTo_SByteNullable.From_DateTime_AsObject: Job-HBFVIR(Toolchain=net461)
  ConvertTo_SByteNullable.From_DateTime_AsObject: Job-YRWWQX(Toolchain=net472)
  ConvertTo_SByteNullable.From_DateTime_Nullable_WithValue_AsObject: Job-LRKCAO(Toolchain=.NET Core 2.0)
  ConvertTo_SByteNullable.From_DateTime_Nullable_WithValue_AsObject: Job-VAJWLV(Toolchain=.NET Core 2.2)
  ConvertTo_SByteNullable.From_DateTime_Nullable_WithValue_AsObject: Job-TJIRAH(Toolchain=.NET Core 3.0)
  ConvertTo_SByteNullable.From_DateTime_Nullable_WithValue_AsObject: Job-HBFVIR(Toolchain=net461)
  ConvertTo_SByteNullable.From_DateTime_Nullable_WithValue_AsObject: Job-YRWWQX(Toolchain=net472)
  ConvertTo_SByteNullable.From_String_Empty_AsObject: Job-LRKCAO(Toolchain=.NET Core 2.0)
  ConvertTo_SByteNullable.From_String_Empty_AsObject: Job-VAJWLV(Toolchain=.NET Core 2.2)
  ConvertTo_SByteNullable.From_String_Empty_AsObject: Job-TJIRAH(Toolchain=.NET Core 3.0)
  ConvertTo_SByteNullable.From_String_Empty_AsObject: Job-HBFVIR(Toolchain=net461)
  ConvertTo_SByteNullable.From_String_Empty_AsObject: Job-YRWWQX(Toolchain=net472)
