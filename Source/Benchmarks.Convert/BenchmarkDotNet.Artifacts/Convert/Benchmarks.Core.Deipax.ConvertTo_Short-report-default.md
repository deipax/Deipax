
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
                                             From_Bool | .NET Core 2.0 | 11.686 ns | 0.0162 ns | 0.0135 ns | 11.683 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 2.2 | 10.391 ns | 0.0140 ns | 0.0131 ns | 10.393 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 3.0 |  8.819 ns | 0.2024 ns | 0.4134 ns |  8.980 ns |  0.71 |    0.05 |      - |     - |     - |         - |
                                             From_Bool |        net461 | 10.514 ns | 0.0154 ns | 0.0144 ns | 10.511 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                             From_Bool |        net472 | 12.827 ns | 0.0124 ns | 0.0116 ns | 12.824 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Bool_AsObject | .NET Core 2.0 | 18.738 ns | 0.0246 ns | 0.0230 ns | 18.734 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 2.2 | 16.386 ns | 0.0393 ns | 0.0368 ns | 16.399 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 3.0 | 16.592 ns | 0.0564 ns | 0.0528 ns | 16.586 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net461 | 17.935 ns | 0.0288 ns | 0.0269 ns | 17.932 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net472 | 18.000 ns | 0.0392 ns | 0.0347 ns | 17.995 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Bool_Nullable_WithValue | .NET Core 2.0 | 11.952 ns | 0.0086 ns | 0.0067 ns | 11.953 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 2.2 | 10.564 ns | 0.0105 ns | 0.0093 ns | 10.562 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 3.0 |  7.484 ns | 0.1478 ns | 0.1383 ns |  7.563 ns |  0.62 |    0.01 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net461 | 12.214 ns | 0.0509 ns | 0.0476 ns | 12.188 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net472 | 11.337 ns | 0.1391 ns | 0.1301 ns | 11.325 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.881 ns | 0.0155 ns | 0.0145 ns | 18.874 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.850 ns | 0.0334 ns | 0.0296 ns | 15.857 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 3.0 | 16.316 ns | 0.0683 ns | 0.0639 ns | 16.324 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net461 | 18.115 ns | 0.0591 ns | 0.0494 ns | 18.101 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net472 | 18.247 ns | 0.0324 ns | 0.0287 ns | 18.255 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Bool_Nullable_NoValue | .NET Core 2.0 | 11.637 ns | 0.0055 ns | 0.0052 ns | 11.637 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 2.2 | 10.739 ns | 0.0099 ns | 0.0093 ns | 10.739 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 3.0 |  6.694 ns | 0.0551 ns | 0.0515 ns |  6.677 ns |  0.58 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net461 | 10.253 ns | 0.0178 ns | 0.0158 ns | 10.252 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net472 | 10.375 ns | 0.0119 ns | 0.0111 ns | 10.377 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.959 ns | 0.0324 ns | 0.0304 ns | 14.958 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.653 ns | 0.0099 ns | 0.0088 ns | 12.653 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.794 ns | 0.1855 ns | 0.1735 ns | 12.738 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net461 | 13.947 ns | 0.0528 ns | 0.0494 ns | 13.966 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net472 | 13.241 ns | 0.0356 ns | 0.0316 ns | 13.243 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Byte | .NET Core 2.0 | 11.656 ns | 0.0143 ns | 0.0127 ns | 11.659 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 2.2 | 10.328 ns | 0.0086 ns | 0.0067 ns | 10.326 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 3.0 |  6.883 ns | 0.0352 ns | 0.0329 ns |  6.871 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                                             From_Byte |        net461 | 10.337 ns | 0.0183 ns | 0.0153 ns | 10.334 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                             From_Byte |        net472 | 12.909 ns | 0.0095 ns | 0.0089 ns | 12.906 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Byte_AsObject | .NET Core 2.0 | 18.802 ns | 0.0235 ns | 0.0219 ns | 18.798 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 2.2 | 16.313 ns | 0.0439 ns | 0.0410 ns | 16.329 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 3.0 | 16.479 ns | 0.0584 ns | 0.0518 ns | 16.476 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net461 | 18.424 ns | 0.0469 ns | 0.0439 ns | 18.416 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net472 | 18.458 ns | 0.0221 ns | 0.0207 ns | 18.458 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Byte_Nullable_WithValue | .NET Core 2.0 | 11.857 ns | 0.0143 ns | 0.0134 ns | 11.857 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 2.2 | 10.452 ns | 0.0148 ns | 0.0138 ns | 10.452 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 3.0 |  6.860 ns | 0.0301 ns | 0.0282 ns |  6.851 ns |  0.58 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net461 | 10.700 ns | 0.0889 ns | 0.0831 ns | 10.742 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net472 | 10.660 ns | 0.0384 ns | 0.0321 ns | 10.654 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.388 ns | 0.0331 ns | 0.0310 ns | 18.380 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.492 ns | 0.0172 ns | 0.0153 ns | 15.493 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 3.0 | 16.483 ns | 0.0660 ns | 0.0617 ns | 16.459 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net461 | 18.006 ns | 0.0376 ns | 0.0351 ns | 18.011 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net472 | 19.926 ns | 0.0183 ns | 0.0171 ns | 19.924 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Byte_Nullable_NoValue | .NET Core 2.0 | 11.639 ns | 0.0101 ns | 0.0079 ns | 11.637 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 2.2 | 10.735 ns | 0.0159 ns | 0.0141 ns | 10.728 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 3.0 |  6.690 ns | 0.0342 ns | 0.0320 ns |  6.680 ns |  0.57 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net461 | 10.385 ns | 0.0121 ns | 0.0113 ns | 10.384 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net472 | 10.379 ns | 0.0145 ns | 0.0121 ns | 10.378 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.960 ns | 0.0191 ns | 0.0179 ns | 13.956 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.792 ns | 0.0118 ns | 0.0110 ns | 14.794 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.919 ns | 0.0640 ns | 0.0599 ns | 12.895 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net461 | 15.051 ns | 0.0834 ns | 0.0780 ns | 15.073 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net472 | 14.153 ns | 0.0104 ns | 0.0087 ns | 14.155 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Char | .NET Core 2.0 | 11.770 ns | 0.0150 ns | 0.0125 ns | 11.765 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Char | .NET Core 2.2 | 10.384 ns | 0.0116 ns | 0.0103 ns | 10.384 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                             From_Char | .NET Core 3.0 |  7.209 ns | 0.0576 ns | 0.0538 ns |  7.206 ns |  0.61 |    0.00 |      - |     - |     - |         - |
                                             From_Char |        net461 | 10.837 ns | 0.0190 ns | 0.0168 ns | 10.835 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                             From_Char |        net472 | 10.827 ns | 0.0143 ns | 0.0134 ns | 10.831 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Char_AsObject | .NET Core 2.0 | 19.541 ns | 0.0209 ns | 0.0185 ns | 19.535 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 2.2 | 16.902 ns | 0.0258 ns | 0.0229 ns | 16.896 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 3.0 | 16.303 ns | 0.0465 ns | 0.0435 ns | 16.285 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject |        net461 | 18.617 ns | 0.0281 ns | 0.0263 ns | 18.626 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject |        net472 | 18.691 ns | 0.0345 ns | 0.0323 ns | 18.692 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Char_Nullable_WithValue | .NET Core 2.0 | 12.568 ns | 0.0140 ns | 0.0125 ns | 12.566 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 2.2 | 10.578 ns | 0.0115 ns | 0.0108 ns | 10.576 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 3.0 |  7.116 ns | 0.1637 ns | 0.1885 ns |  7.229 ns |  0.56 |    0.02 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net461 | 11.875 ns | 0.0257 ns | 0.0241 ns | 11.875 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net472 | 11.987 ns | 0.0127 ns | 0.0119 ns | 11.985 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.0 | 22.139 ns | 0.0123 ns | 0.0115 ns | 22.140 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.378 ns | 0.0279 ns | 0.0247 ns | 17.382 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 3.0 | 16.670 ns | 0.0513 ns | 0.0428 ns | 16.674 ns |  0.75 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net461 | 18.586 ns | 0.0276 ns | 0.0258 ns | 18.588 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net472 | 18.677 ns | 0.0324 ns | 0.0303 ns | 18.674 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Char_Nullable_NoValue | .NET Core 2.0 | 12.295 ns | 0.0175 ns | 0.0164 ns | 12.295 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 2.2 | 10.816 ns | 0.0079 ns | 0.0070 ns | 10.817 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 3.0 |  6.671 ns | 0.0262 ns | 0.0245 ns |  6.658 ns |  0.54 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net461 | 10.284 ns | 0.0513 ns | 0.0480 ns | 10.267 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net472 | 10.371 ns | 0.0099 ns | 0.0092 ns | 10.368 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.082 ns | 0.0094 ns | 0.0088 ns | 14.082 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.652 ns | 0.0141 ns | 0.0125 ns | 12.653 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.475 ns | 0.1453 ns | 0.1359 ns | 11.535 ns |  0.81 |    0.01 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net461 | 13.190 ns | 0.0143 ns | 0.0119 ns | 13.190 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net472 | 13.841 ns | 0.0115 ns | 0.0096 ns | 13.838 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                         From_DateTime | .NET Core 2.0 | 12.525 ns | 0.0114 ns | 0.0101 ns | 12.525 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 2.2 | 11.525 ns | 0.0126 ns | 0.0118 ns | 11.524 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 3.0 |  7.910 ns | 0.0332 ns | 0.0311 ns |  7.903 ns |  0.63 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime |        net461 | 12.756 ns | 0.0136 ns | 0.0114 ns | 12.758 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime |        net472 | 12.820 ns | 0.0379 ns | 0.0355 ns | 12.801 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                From_DateTime_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                      From_DateTime_Nullable_WithValue | .NET Core 2.0 | 12.989 ns | 0.0316 ns | 0.0280 ns | 12.988 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 2.2 | 11.800 ns | 0.0101 ns | 0.0089 ns | 11.799 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 3.0 |  8.154 ns | 0.0669 ns | 0.0626 ns |  8.139 ns |  0.63 |    0.01 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net461 | 12.555 ns | 0.0174 ns | 0.0154 ns | 12.558 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net472 | 13.168 ns | 0.0131 ns | 0.0122 ns | 13.165 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_DateTime_Nullable_NoValue | .NET Core 2.0 | 12.948 ns | 0.0108 ns | 0.0101 ns | 12.951 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 2.2 | 11.782 ns | 0.0113 ns | 0.0100 ns | 11.781 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 3.0 |  8.127 ns | 0.0475 ns | 0.0444 ns |  8.106 ns |  0.63 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net461 | 13.447 ns | 0.0413 ns | 0.0386 ns | 13.454 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net472 | 13.176 ns | 0.0166 ns | 0.0147 ns | 13.180 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.067 ns | 0.0129 ns | 0.0115 ns | 14.068 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.488 ns | 0.0116 ns | 0.0103 ns | 13.487 ns |  0.96 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.202 ns | 0.2675 ns | 0.3920 ns | 12.366 ns |  0.85 |    0.04 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net461 | 13.931 ns | 0.0154 ns | 0.0121 ns | 13.930 ns |  0.99 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net472 | 13.193 ns | 0.0155 ns | 0.0145 ns | 13.197 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                          From_Decimal | .NET Core 2.0 | 26.550 ns | 0.0199 ns | 0.0176 ns | 26.552 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 2.2 | 23.829 ns | 0.0260 ns | 0.0217 ns | 23.832 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 3.0 | 14.606 ns | 0.1278 ns | 0.1195 ns | 14.564 ns |  0.55 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal |        net461 | 25.894 ns | 0.0316 ns | 0.0264 ns | 25.902 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal |        net472 | 24.055 ns | 0.0286 ns | 0.0267 ns | 24.058 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                 From_Decimal_AsObject | .NET Core 2.0 | 26.975 ns | 0.0152 ns | 0.0127 ns | 26.973 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 2.2 | 26.105 ns | 0.0481 ns | 0.0450 ns | 26.094 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 3.0 | 22.801 ns | 0.1130 ns | 0.1057 ns | 22.830 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net461 | 27.942 ns | 0.1621 ns | 0.1516 ns | 27.996 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net472 | 27.159 ns | 0.0450 ns | 0.0375 ns | 27.154 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                       From_Decimal_Nullable_WithValue | .NET Core 2.0 | 25.091 ns | 0.0278 ns | 0.0247 ns | 25.090 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 2.2 | 24.448 ns | 0.0256 ns | 0.0214 ns | 24.446 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 3.0 | 16.512 ns | 0.1024 ns | 0.0958 ns | 16.503 ns |  0.66 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net461 | 25.234 ns | 0.0765 ns | 0.0716 ns | 25.245 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net472 | 24.501 ns | 0.0173 ns | 0.0154 ns | 24.503 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.0 | 26.715 ns | 0.0305 ns | 0.0270 ns | 26.711 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.2 | 26.276 ns | 0.0199 ns | 0.0176 ns | 26.278 ns |  0.98 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 3.0 | 22.063 ns | 0.0973 ns | 0.0910 ns | 22.033 ns |  0.83 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net461 | 27.135 ns | 0.0323 ns | 0.0302 ns | 27.127 ns |  1.02 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net472 | 31.236 ns | 0.0250 ns | 0.0233 ns | 31.234 ns |  1.17 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Decimal_Nullable_NoValue | .NET Core 2.0 | 12.609 ns | 0.0107 ns | 0.0100 ns | 12.613 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 2.2 | 11.952 ns | 0.0122 ns | 0.0108 ns | 11.952 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 3.0 |  8.320 ns | 0.1675 ns | 0.1566 ns |  8.220 ns |  0.66 |    0.01 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net461 | 14.020 ns | 0.1296 ns | 0.1082 ns | 13.952 ns |  1.11 |    0.01 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net472 | 13.425 ns | 0.0102 ns | 0.0086 ns | 13.425 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.063 ns | 0.0083 ns | 0.0078 ns | 14.064 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.499 ns | 0.0150 ns | 0.0133 ns | 13.503 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.016 ns | 0.1782 ns | 0.1667 ns | 14.074 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net461 | 13.026 ns | 0.0397 ns | 0.0352 ns | 13.026 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net472 | 13.229 ns | 0.0166 ns | 0.0155 ns | 13.227 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_Double | .NET Core 2.0 | 13.883 ns | 0.0268 ns | 0.0251 ns | 13.883 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 2.2 | 12.598 ns | 0.0121 ns | 0.0113 ns | 12.601 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 3.0 | 10.745 ns | 0.1660 ns | 0.1552 ns | 10.783 ns |  0.77 |    0.01 |      - |     - |     - |         - |
                                           From_Double |        net461 | 13.956 ns | 0.0112 ns | 0.0100 ns | 13.957 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                           From_Double |        net472 | 14.215 ns | 0.0403 ns | 0.0377 ns | 14.223 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_Double_AsObject | .NET Core 2.0 | 20.948 ns | 0.0301 ns | 0.0282 ns | 20.949 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 2.2 | 17.875 ns | 0.0223 ns | 0.0209 ns | 17.872 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 3.0 | 18.229 ns | 0.0525 ns | 0.0491 ns | 18.223 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject |        net461 | 21.654 ns | 0.0302 ns | 0.0282 ns | 21.659 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject |        net472 | 20.369 ns | 0.0397 ns | 0.0352 ns | 20.373 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_Double_Nullable_WithValue | .NET Core 2.0 | 15.801 ns | 0.0300 ns | 0.0281 ns | 15.792 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 2.2 | 14.200 ns | 0.0201 ns | 0.0188 ns | 14.201 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 3.0 | 12.824 ns | 0.0641 ns | 0.0599 ns | 12.814 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net461 | 15.860 ns | 0.0302 ns | 0.0282 ns | 15.854 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net472 | 15.829 ns | 0.0275 ns | 0.0229 ns | 15.832 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.991 ns | 0.0346 ns | 0.0323 ns | 20.995 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.521 ns | 0.0237 ns | 0.0222 ns | 17.517 ns |  0.83 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.129 ns | 0.0731 ns | 0.0648 ns | 18.107 ns |  0.86 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net461 | 20.012 ns | 0.0245 ns | 0.0229 ns | 20.013 ns |  0.95 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net472 | 20.305 ns | 0.0679 ns | 0.0635 ns | 20.316 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Double_Nullable_NoValue | .NET Core 2.0 | 12.498 ns | 0.0122 ns | 0.0108 ns | 12.495 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 2.2 | 11.401 ns | 0.0152 ns | 0.0127 ns | 11.398 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 3.0 |  7.924 ns | 0.0262 ns | 0.0245 ns |  7.921 ns |  0.63 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net461 | 13.381 ns | 0.0220 ns | 0.0195 ns | 13.374 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net472 | 12.663 ns | 0.0176 ns | 0.0156 ns | 12.663 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.954 ns | 0.0264 ns | 0.0234 ns | 14.954 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.663 ns | 0.0071 ns | 0.0059 ns | 12.662 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.091 ns | 0.2799 ns | 0.2618 ns | 12.949 ns |  0.88 |    0.02 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net461 | 13.231 ns | 0.0143 ns | 0.0134 ns | 13.233 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net472 | 13.250 ns | 0.0730 ns | 0.0683 ns | 13.215 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_Short | .NET Core 2.0 | 12.932 ns | 0.0172 ns | 0.0152 ns | 12.936 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 2.2 | 10.760 ns | 0.0096 ns | 0.0090 ns | 10.760 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 3.0 |  6.868 ns | 0.0264 ns | 0.0246 ns |  6.868 ns |  0.53 |    0.00 |      - |     - |     - |         - |
                                            From_Short |        net461 | 11.525 ns | 0.0122 ns | 0.0108 ns | 11.525 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                            From_Short |        net472 | 10.332 ns | 0.0112 ns | 0.0105 ns | 10.334 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_Short_AsObject | .NET Core 2.0 | 14.637 ns | 0.0103 ns | 0.0096 ns | 14.634 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 2.2 | 13.206 ns | 0.0155 ns | 0.0145 ns | 13.210 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 3.0 | 12.121 ns | 0.3958 ns | 0.6721 ns | 11.759 ns |  0.87 |    0.05 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net461 | 14.132 ns | 0.0366 ns | 0.0342 ns | 14.138 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net472 | 14.266 ns | 0.0286 ns | 0.0268 ns | 14.264 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Short_Nullable_WithValue | .NET Core 2.0 | 12.099 ns | 0.1450 ns | 0.1285 ns | 12.039 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 2.2 | 10.467 ns | 0.0167 ns | 0.0156 ns | 10.468 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 3.0 |  7.028 ns | 0.0329 ns | 0.0308 ns |  7.028 ns |  0.58 |    0.01 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net461 | 10.597 ns | 0.0114 ns | 0.0096 ns | 10.596 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net472 | 11.373 ns | 0.0436 ns | 0.0408 ns | 11.357 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.0 | 17.538 ns | 0.0314 ns | 0.0293 ns | 17.527 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.2 | 14.089 ns | 0.0115 ns | 0.0102 ns | 14.090 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 3.0 | 13.929 ns | 0.0892 ns | 0.0835 ns | 13.952 ns |  0.79 |    0.01 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net461 | 14.135 ns | 0.0379 ns | 0.0354 ns | 14.139 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net472 | 14.607 ns | 0.0427 ns | 0.0399 ns | 14.598 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Short_Nullable_NoValue | .NET Core 2.0 | 11.670 ns | 0.0127 ns | 0.0112 ns | 11.670 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 2.2 | 10.341 ns | 0.0060 ns | 0.0056 ns | 10.342 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 3.0 |  7.836 ns | 0.1798 ns | 0.3633 ns |  7.985 ns |  0.64 |    0.04 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net461 | 10.701 ns | 0.0124 ns | 0.0104 ns | 10.702 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net472 | 10.359 ns | 0.0157 ns | 0.0147 ns | 10.361 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.064 ns | 0.0082 ns | 0.0069 ns | 14.064 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.663 ns | 0.0152 ns | 0.0142 ns | 12.663 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.362 ns | 0.0360 ns | 0.0337 ns | 11.351 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net461 | 13.044 ns | 0.0125 ns | 0.0117 ns | 13.046 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net472 | 14.315 ns | 0.0520 ns | 0.0487 ns | 14.290 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                              From_Int | .NET Core 2.0 | 12.084 ns | 0.0141 ns | 0.0131 ns | 12.087 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 2.2 | 10.677 ns | 0.0102 ns | 0.0090 ns | 10.677 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 3.0 |  7.838 ns | 0.0535 ns | 0.0500 ns |  7.828 ns |  0.65 |    0.00 |      - |     - |     - |         - |
                                              From_Int |        net461 | 10.975 ns | 0.0129 ns | 0.0121 ns | 10.977 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                              From_Int |        net472 | 10.724 ns | 0.0399 ns | 0.0373 ns | 10.703 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_Int_AsObject | .NET Core 2.0 | 19.485 ns | 0.0187 ns | 0.0156 ns | 19.482 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 2.2 | 16.189 ns | 0.0384 ns | 0.0320 ns | 16.187 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 3.0 | 17.724 ns | 0.3718 ns | 0.5678 ns | 18.117 ns |  0.88 |    0.02 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net461 | 20.125 ns | 0.0199 ns | 0.0177 ns | 20.131 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net472 | 18.832 ns | 0.0235 ns | 0.0220 ns | 18.830 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Int_Nullable_WithValue | .NET Core 2.0 | 12.624 ns | 0.0108 ns | 0.0101 ns | 12.622 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 2.2 | 11.510 ns | 0.0108 ns | 0.0101 ns | 11.514 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 3.0 |  8.239 ns | 0.0201 ns | 0.0178 ns |  8.236 ns |  0.65 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net461 | 12.021 ns | 0.0434 ns | 0.0406 ns | 12.012 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net472 | 12.092 ns | 0.0544 ns | 0.0508 ns | 12.061 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.887 ns | 0.0247 ns | 0.0231 ns | 19.880 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.2 | 16.917 ns | 0.0500 ns | 0.0468 ns | 16.916 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.784 ns | 0.0670 ns | 0.0627 ns | 15.772 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net461 | 21.521 ns | 0.0268 ns | 0.0250 ns | 21.522 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net472 | 18.914 ns | 0.0285 ns | 0.0253 ns | 18.919 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_Int_Nullable_NoValue | .NET Core 2.0 | 11.693 ns | 0.0315 ns | 0.0294 ns | 11.696 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 2.2 | 10.703 ns | 0.0171 ns | 0.0160 ns | 10.702 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 3.0 |  6.760 ns | 0.1178 ns | 0.1102 ns |  6.708 ns |  0.58 |    0.01 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net461 | 10.251 ns | 0.0105 ns | 0.0098 ns | 10.253 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net472 | 10.373 ns | 0.0107 ns | 0.0100 ns | 10.372 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.034 ns | 0.0151 ns | 0.0141 ns | 14.031 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.478 ns | 0.0104 ns | 0.0087 ns | 13.480 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.273 ns | 0.0433 ns | 0.0405 ns | 11.269 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net461 | 14.901 ns | 0.0212 ns | 0.0177 ns | 14.902 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net472 | 13.301 ns | 0.0393 ns | 0.0368 ns | 13.298 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Long | .NET Core 2.0 | 12.110 ns | 0.0143 ns | 0.0134 ns | 12.111 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Long | .NET Core 2.2 | 10.739 ns | 0.0162 ns | 0.0152 ns | 10.745 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                             From_Long | .NET Core 3.0 |  7.821 ns | 0.0813 ns | 0.0721 ns |  7.802 ns |  0.65 |    0.01 |      - |     - |     - |         - |
                                             From_Long |        net461 | 11.018 ns | 0.0280 ns | 0.0261 ns | 11.003 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                             From_Long |        net472 | 11.472 ns | 0.1126 ns | 0.1053 ns | 11.500 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Long_AsObject | .NET Core 2.0 | 18.990 ns | 0.0274 ns | 0.0243 ns | 18.991 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 2.2 | 17.298 ns | 0.0702 ns | 0.0657 ns | 17.305 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 3.0 | 16.635 ns | 0.0817 ns | 0.0764 ns | 16.613 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net461 | 20.137 ns | 0.0246 ns | 0.0230 ns | 20.128 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net472 | 18.830 ns | 0.0241 ns | 0.0226 ns | 18.826 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Long_Nullable_WithValue | .NET Core 2.0 | 14.113 ns | 0.0182 ns | 0.0170 ns | 14.118 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 2.2 | 12.712 ns | 0.0147 ns | 0.0130 ns | 12.711 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 3.0 | 10.341 ns | 0.0702 ns | 0.0657 ns | 10.332 ns |  0.73 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net461 | 13.749 ns | 0.0234 ns | 0.0219 ns | 13.757 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net472 | 13.869 ns | 0.0638 ns | 0.0597 ns | 13.899 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.363 ns | 0.0293 ns | 0.0274 ns | 19.359 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.2 | 16.678 ns | 0.0231 ns | 0.0216 ns | 16.671 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.280 ns | 0.3916 ns | 0.6096 ns | 18.519 ns |  0.93 |    0.04 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net461 | 20.594 ns | 0.1066 ns | 0.0998 ns | 20.619 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net472 | 19.157 ns | 0.1153 ns | 0.1079 ns | 19.105 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Long_Nullable_NoValue | .NET Core 2.0 | 12.978 ns | 0.0056 ns | 0.0047 ns | 12.978 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 2.2 | 11.320 ns | 0.0111 ns | 0.0099 ns | 11.320 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 3.0 |  7.826 ns | 0.0065 ns | 0.0054 ns |  7.828 ns |  0.60 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net461 | 12.662 ns | 0.0141 ns | 0.0125 ns | 12.662 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net472 | 13.539 ns | 0.0101 ns | 0.0089 ns | 13.538 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.322 ns | 0.0085 ns | 0.0075 ns | 15.325 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.790 ns | 0.0722 ns | 0.0675 ns | 12.782 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.294 ns | 0.0606 ns | 0.0567 ns | 11.301 ns |  0.74 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net461 | 13.114 ns | 0.0197 ns | 0.0175 ns | 13.117 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net472 | 13.351 ns | 0.0459 ns | 0.0429 ns | 13.369 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_SByte | .NET Core 2.0 | 11.773 ns | 0.0204 ns | 0.0181 ns | 11.769 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 2.2 | 10.402 ns | 0.1099 ns | 0.0918 ns | 10.385 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 3.0 |  7.198 ns | 0.1682 ns | 0.3240 ns |  7.320 ns |  0.59 |    0.04 |      - |     - |     - |         - |
                                            From_SByte |        net461 | 10.378 ns | 0.0614 ns | 0.0574 ns | 10.346 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                                            From_SByte |        net472 | 12.869 ns | 0.0214 ns | 0.0190 ns | 12.867 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_SByte_AsObject | .NET Core 2.0 | 21.426 ns | 0.0257 ns | 0.0227 ns | 21.423 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 2.2 | 16.258 ns | 0.0334 ns | 0.0312 ns | 16.254 ns |  0.76 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 3.0 | 15.481 ns | 0.0569 ns | 0.0532 ns | 15.489 ns |  0.72 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net461 | 18.374 ns | 0.0473 ns | 0.0443 ns | 18.375 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net472 | 18.477 ns | 0.0317 ns | 0.0296 ns | 18.477 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_SByte_Nullable_WithValue | .NET Core 2.0 | 11.811 ns | 0.0084 ns | 0.0079 ns | 11.813 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 2.2 | 10.496 ns | 0.0351 ns | 0.0293 ns | 10.498 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 3.0 |  6.640 ns | 0.0157 ns | 0.0146 ns |  6.637 ns |  0.56 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net461 | 11.727 ns | 0.0226 ns | 0.0212 ns | 11.724 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net472 | 11.333 ns | 0.0615 ns | 0.0575 ns | 11.297 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.456 ns | 0.0420 ns | 0.0393 ns | 18.463 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.057 ns | 0.0296 ns | 0.0277 ns | 17.067 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.145 ns | 0.0499 ns | 0.0442 ns | 17.143 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net461 | 19.470 ns | 0.0287 ns | 0.0255 ns | 19.474 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net472 | 18.191 ns | 0.0339 ns | 0.0317 ns | 18.189 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_SByte_Nullable_NoValue | .NET Core 2.0 | 11.608 ns | 0.0170 ns | 0.0151 ns | 11.608 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 2.2 | 10.306 ns | 0.0170 ns | 0.0142 ns | 10.306 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 3.0 |  6.662 ns | 0.0252 ns | 0.0223 ns |  6.657 ns |  0.57 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net461 | 10.248 ns | 0.0124 ns | 0.0116 ns | 10.250 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net472 | 10.951 ns | 0.2422 ns | 0.2592 ns | 10.880 ns |  0.94 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.902 ns | 0.0157 ns | 0.0147 ns | 14.907 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.772 ns | 0.0115 ns | 0.0096 ns | 12.770 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.033 ns | 0.2467 ns | 0.2308 ns | 12.867 ns |  0.87 |    0.02 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net461 | 14.946 ns | 0.0111 ns | 0.0098 ns | 14.945 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net472 | 13.280 ns | 0.0573 ns | 0.0478 ns | 13.303 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_Float | .NET Core 2.0 | 13.463 ns | 0.0122 ns | 0.0114 ns | 13.465 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 2.2 | 12.067 ns | 0.0299 ns | 0.0265 ns | 12.073 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 3.0 | 10.655 ns | 0.1482 ns | 0.1386 ns | 10.754 ns |  0.79 |    0.01 |      - |     - |     - |         - |
                                            From_Float |        net461 | 14.260 ns | 0.0310 ns | 0.0275 ns | 14.252 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                            From_Float |        net472 | 14.224 ns | 0.0189 ns | 0.0168 ns | 14.227 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_Float_AsObject | .NET Core 2.0 | 21.770 ns | 0.0641 ns | 0.0599 ns | 21.759 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 2.2 | 18.791 ns | 0.0433 ns | 0.0405 ns | 18.778 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 3.0 | 18.661 ns | 0.0903 ns | 0.0845 ns | 18.675 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject |        net461 | 20.496 ns | 0.0452 ns | 0.0423 ns | 20.486 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject |        net472 | 20.578 ns | 0.0214 ns | 0.0190 ns | 20.574 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Float_Nullable_WithValue | .NET Core 2.0 | 14.213 ns | 0.0319 ns | 0.0299 ns | 14.206 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 2.2 | 13.198 ns | 0.0258 ns | 0.0215 ns | 13.191 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 3.0 | 10.190 ns | 0.0134 ns | 0.0119 ns | 10.192 ns |  0.72 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net461 | 14.296 ns | 0.0170 ns | 0.0151 ns | 14.296 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net472 | 13.259 ns | 0.0768 ns | 0.0718 ns | 13.231 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.0 | 21.058 ns | 0.0360 ns | 0.0319 ns | 21.062 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.2 | 18.225 ns | 0.0365 ns | 0.0342 ns | 18.217 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 3.0 | 19.642 ns | 0.3351 ns | 0.3134 ns | 19.471 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net461 | 20.516 ns | 0.0269 ns | 0.0252 ns | 20.512 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net472 | 20.660 ns | 0.0297 ns | 0.0264 ns | 20.664 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Float_Nullable_NoValue | .NET Core 2.0 | 11.672 ns | 0.0121 ns | 0.0107 ns | 11.670 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 2.2 | 10.331 ns | 0.0102 ns | 0.0090 ns | 10.329 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 3.0 |  6.881 ns | 0.0300 ns | 0.0281 ns |  6.898 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net461 | 10.411 ns | 0.0420 ns | 0.0393 ns | 10.415 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net472 | 10.776 ns | 0.0142 ns | 0.0126 ns | 10.777 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.538 ns | 0.0396 ns | 0.0370 ns | 14.549 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.617 ns | 0.0091 ns | 0.0081 ns | 13.615 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.842 ns | 0.0145 ns | 0.0121 ns | 12.841 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net461 | 13.855 ns | 0.0190 ns | 0.0168 ns | 13.860 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net472 | 13.451 ns | 0.0130 ns | 0.0102 ns | 13.453 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_String | .NET Core 2.0 | 57.971 ns | 0.0569 ns | 0.0504 ns | 57.976 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 2.2 | 52.154 ns | 0.0636 ns | 0.0595 ns | 52.155 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 3.0 | 19.694 ns | 0.0397 ns | 0.0372 ns | 19.680 ns |  0.34 |    0.00 |      - |     - |     - |         - |
                                           From_String |        net461 | 57.696 ns | 0.1148 ns | 0.1074 ns | 57.724 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_String |        net472 | 57.704 ns | 0.1800 ns | 0.1684 ns | 57.765 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_String_AsObject | .NET Core 2.0 | 64.495 ns | 0.2805 ns | 0.2487 ns | 64.425 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 2.2 | 61.608 ns | 0.1597 ns | 0.1494 ns | 61.606 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 3.0 | 24.045 ns | 0.1003 ns | 0.0938 ns | 24.073 ns |  0.37 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject |        net461 | 62.847 ns | 0.2516 ns | 0.2353 ns | 62.783 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject |        net472 | 62.820 ns | 0.1350 ns | 0.1263 ns | 62.837 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                      From_String_Null | .NET Core 2.0 | 12.470 ns | 0.0244 ns | 0.0229 ns | 12.472 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 2.2 | 12.108 ns | 0.0059 ns | 0.0052 ns | 12.107 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 3.0 | 13.707 ns | 0.2037 ns | 0.1905 ns | 13.822 ns |  1.10 |    0.02 |      - |     - |     - |         - |
                                      From_String_Null |        net461 | 12.582 ns | 0.0270 ns | 0.0252 ns | 12.577 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null |        net472 | 12.910 ns | 0.0693 ns | 0.0648 ns | 12.898 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_String_Null_AsObject | .NET Core 2.0 | 14.021 ns | 0.0176 ns | 0.0165 ns | 14.019 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 2.2 | 12.623 ns | 0.0203 ns | 0.0190 ns | 12.626 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 3.0 | 13.089 ns | 0.1747 ns | 0.1634 ns | 13.181 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net461 | 13.808 ns | 0.0124 ns | 0.0110 ns | 13.809 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net472 | 13.540 ns | 0.0264 ns | 0.0247 ns | 13.534 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_String_Empty | .NET Core 2.0 | 12.666 ns | 0.0158 ns | 0.0147 ns | 12.662 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 2.2 | 12.988 ns | 0.0137 ns | 0.0128 ns | 12.987 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 3.0 | 11.603 ns | 0.0218 ns | 0.0182 ns | 11.598 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty |        net461 | 14.558 ns | 0.0591 ns | 0.0553 ns | 14.520 ns |  1.15 |    0.01 |      - |     - |     - |         - |
                                     From_String_Empty |        net472 | 12.894 ns | 0.0411 ns | 0.0385 ns | 12.902 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_String_Empty_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_UShort | .NET Core 2.0 | 11.758 ns | 0.0127 ns | 0.0112 ns | 11.756 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 2.2 | 10.356 ns | 0.0170 ns | 0.0151 ns | 10.352 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 3.0 |  6.928 ns | 0.0338 ns | 0.0316 ns |  6.941 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                                           From_UShort |        net461 | 13.119 ns | 0.0179 ns | 0.0168 ns | 13.113 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                           From_UShort |        net472 | 10.809 ns | 0.0139 ns | 0.0130 ns | 10.808 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_UShort_AsObject | .NET Core 2.0 | 18.557 ns | 0.0178 ns | 0.0158 ns | 18.562 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 2.2 | 15.727 ns | 0.0206 ns | 0.0182 ns | 15.724 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 3.0 | 15.203 ns | 0.0423 ns | 0.0375 ns | 15.205 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net461 | 19.281 ns | 0.0530 ns | 0.0496 ns | 19.262 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net472 | 19.100 ns | 0.0479 ns | 0.0448 ns | 19.101 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_UShort_Nullable_WithValue | .NET Core 2.0 | 12.785 ns | 0.0338 ns | 0.0317 ns | 12.789 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 2.2 | 11.021 ns | 0.0129 ns | 0.0121 ns | 11.019 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 3.0 |  6.817 ns | 0.0120 ns | 0.0106 ns |  6.816 ns |  0.53 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net461 | 12.019 ns | 0.0214 ns | 0.0190 ns | 12.019 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net472 | 12.072 ns | 0.0208 ns | 0.0162 ns | 12.072 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.777 ns | 0.0280 ns | 0.0262 ns | 18.778 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.851 ns | 0.0188 ns | 0.0167 ns | 15.848 ns |  0.84 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 3.0 | 16.657 ns | 0.3531 ns | 0.3302 ns | 16.454 ns |  0.89 |    0.02 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net461 | 20.590 ns | 0.0295 ns | 0.0262 ns | 20.591 ns |  1.10 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net472 | 19.314 ns | 0.0218 ns | 0.0194 ns | 19.309 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_UShort_Nullable_NoValue | .NET Core 2.0 | 12.267 ns | 0.0092 ns | 0.0086 ns | 12.267 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 2.2 | 10.316 ns | 0.0126 ns | 0.0117 ns | 10.314 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 3.0 |  6.908 ns | 0.0100 ns | 0.0094 ns |  6.911 ns |  0.56 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net461 | 10.355 ns | 0.0380 ns | 0.0355 ns | 10.353 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net472 | 10.377 ns | 0.0110 ns | 0.0098 ns | 10.378 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.178 ns | 0.0397 ns | 0.0372 ns | 14.185 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.631 ns | 0.0134 ns | 0.0118 ns | 12.631 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.762 ns | 0.0932 ns | 0.0871 ns | 13.729 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net461 | 15.145 ns | 0.0218 ns | 0.0204 ns | 15.143 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net472 | 13.582 ns | 0.0503 ns | 0.0393 ns | 13.595 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_UInt | .NET Core 2.0 | 12.186 ns | 0.0196 ns | 0.0183 ns | 12.187 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 2.2 | 11.206 ns | 0.0357 ns | 0.0298 ns | 11.211 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 3.0 |  8.127 ns | 0.0111 ns | 0.0098 ns |  8.126 ns |  0.67 |    0.00 |      - |     - |     - |         - |
                                             From_UInt |        net461 | 10.906 ns | 0.0099 ns | 0.0093 ns | 10.906 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                             From_UInt |        net472 | 10.634 ns | 0.0216 ns | 0.0181 ns | 10.635 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_UInt_AsObject | .NET Core 2.0 | 19.011 ns | 0.0354 ns | 0.0332 ns | 19.006 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 2.2 | 16.992 ns | 0.0583 ns | 0.0545 ns | 17.003 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 3.0 | 15.706 ns | 0.0323 ns | 0.0302 ns | 15.699 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net461 | 18.924 ns | 0.0297 ns | 0.0263 ns | 18.921 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net472 | 18.954 ns | 0.0269 ns | 0.0225 ns | 18.956 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_UInt_Nullable_WithValue | .NET Core 2.0 | 12.630 ns | 0.0086 ns | 0.0072 ns | 12.630 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 2.2 | 11.581 ns | 0.0097 ns | 0.0086 ns | 11.583 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 3.0 |  8.058 ns | 0.0101 ns | 0.0089 ns |  8.059 ns |  0.64 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net461 | 11.871 ns | 0.0224 ns | 0.0209 ns | 11.868 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net472 | 12.015 ns | 0.0124 ns | 0.0110 ns | 12.019 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.010 ns | 0.0381 ns | 0.0357 ns | 19.019 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.2 | 16.328 ns | 0.0153 ns | 0.0143 ns | 16.327 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.285 ns | 0.1167 ns | 0.1092 ns | 17.252 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net461 | 18.545 ns | 0.0362 ns | 0.0321 ns | 18.545 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net472 | 18.713 ns | 0.0341 ns | 0.0319 ns | 18.713 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_UInt_Nullable_NoValue | .NET Core 2.0 | 11.726 ns | 0.0614 ns | 0.0574 ns | 11.740 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 2.2 | 10.300 ns | 0.0162 ns | 0.0151 ns | 10.299 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 3.0 |  6.629 ns | 0.0062 ns | 0.0058 ns |  6.629 ns |  0.57 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net461 | 10.351 ns | 0.0167 ns | 0.0157 ns | 10.351 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net472 | 10.493 ns | 0.0488 ns | 0.0457 ns | 10.505 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.891 ns | 0.0140 ns | 0.0117 ns | 13.892 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.461 ns | 0.0060 ns | 0.0054 ns | 13.461 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.771 ns | 0.0525 ns | 0.0439 ns | 13.759 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net461 | 13.011 ns | 0.0127 ns | 0.0112 ns | 13.009 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net472 | 13.188 ns | 0.0179 ns | 0.0168 ns | 13.185 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_ULong | .NET Core 2.0 | 12.641 ns | 0.0088 ns | 0.0078 ns | 12.642 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 2.2 | 10.718 ns | 0.0128 ns | 0.0113 ns | 10.716 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 3.0 |  7.380 ns | 0.0286 ns | 0.0268 ns |  7.386 ns |  0.58 |    0.00 |      - |     - |     - |         - |
                                            From_ULong |        net461 | 13.698 ns | 0.2248 ns | 0.2102 ns | 13.630 ns |  1.08 |    0.02 |      - |     - |     - |         - |
                                            From_ULong |        net472 | 10.905 ns | 0.1044 ns | 0.0977 ns | 10.915 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_ULong_AsObject | .NET Core 2.0 | 19.992 ns | 0.0171 ns | 0.0143 ns | 19.987 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 2.2 | 16.693 ns | 0.0982 ns | 0.0919 ns | 16.676 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 3.0 | 15.868 ns | 0.1058 ns | 0.0938 ns | 15.828 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net461 | 19.097 ns | 0.0256 ns | 0.0239 ns | 19.094 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net472 | 19.157 ns | 0.0390 ns | 0.0346 ns | 19.154 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_ULong_Nullable_WithValue | .NET Core 2.0 | 13.664 ns | 0.0153 ns | 0.0127 ns | 13.663 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 2.2 | 13.126 ns | 0.0350 ns | 0.0292 ns | 13.117 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 3.0 | 10.258 ns | 0.0809 ns | 0.0757 ns | 10.259 ns |  0.75 |    0.01 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net461 | 13.769 ns | 0.0204 ns | 0.0191 ns | 13.774 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net472 | 13.739 ns | 0.0217 ns | 0.0203 ns | 13.741 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.771 ns | 0.0316 ns | 0.0280 ns | 19.772 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.2 | 16.384 ns | 0.0361 ns | 0.0337 ns | 16.391 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.943 ns | 0.0437 ns | 0.0408 ns | 15.946 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net461 | 20.465 ns | 0.0304 ns | 0.0284 ns | 20.456 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net472 | 19.150 ns | 0.0353 ns | 0.0330 ns | 19.151 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_ULong_Nullable_NoValue | .NET Core 2.0 | 12.984 ns | 0.0127 ns | 0.0119 ns | 12.986 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 2.2 | 11.360 ns | 0.0196 ns | 0.0164 ns | 11.358 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 3.0 |  7.828 ns | 0.0091 ns | 0.0076 ns |  7.831 ns |  0.60 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net461 | 12.779 ns | 0.0188 ns | 0.0176 ns | 12.774 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net472 | 12.874 ns | 0.0443 ns | 0.0414 ns | 12.862 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.065 ns | 0.0145 ns | 0.0129 ns | 14.066 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.571 ns | 0.0137 ns | 0.0114 ns | 14.571 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.782 ns | 0.2534 ns | 0.3205 ns | 11.971 ns |  0.83 |    0.03 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net461 | 13.056 ns | 0.0157 ns | 0.0147 ns | 13.052 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net472 | 14.312 ns | 0.0142 ns | 0.0126 ns | 14.312 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                       From_NullObject | .NET Core 2.0 | 14.030 ns | 0.0221 ns | 0.0185 ns | 14.028 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 2.2 | 13.528 ns | 0.1273 ns | 0.1063 ns | 13.490 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 3.0 | 11.488 ns | 0.1915 ns | 0.1791 ns | 11.503 ns |  0.82 |    0.01 |      - |     - |     - |         - |
                                       From_NullObject |        net461 | 13.044 ns | 0.0128 ns | 0.0120 ns | 13.042 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject |        net472 | 13.743 ns | 0.0376 ns | 0.0352 ns | 13.729 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_DBNull | .NET Core 2.0 | 10.703 ns | 0.0119 ns | 0.0111 ns | 10.702 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 2.2 |  9.081 ns | 0.0177 ns | 0.0148 ns |  9.083 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 3.0 | 11.868 ns | 0.0527 ns | 0.0467 ns | 11.883 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull |        net461 | 11.073 ns | 0.0186 ns | 0.0174 ns | 11.075 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull |        net472 | 10.982 ns | 0.0212 ns | 0.0188 ns | 10.981 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_DBNull_AsObject | .NET Core 2.0 | 13.963 ns | 0.0112 ns | 0.0105 ns | 13.962 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 2.2 | 12.702 ns | 0.0345 ns | 0.0306 ns | 12.709 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 3.0 | 12.999 ns | 0.0867 ns | 0.0811 ns | 12.976 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net461 | 15.436 ns | 0.0156 ns | 0.0146 ns | 15.438 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net472 | 13.205 ns | 0.0175 ns | 0.0164 ns | 13.205 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                 From_ConvertibleClass | .NET Core 2.0 | 15.342 ns | 0.0182 ns | 0.0161 ns | 15.338 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 2.2 | 12.577 ns | 0.0080 ns | 0.0067 ns | 12.579 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 3.0 | 12.594 ns | 0.3032 ns | 0.4048 ns | 12.381 ns |  0.83 |    0.03 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net461 | 18.670 ns | 0.0346 ns | 0.0307 ns | 18.672 ns |  1.22 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net472 | 17.021 ns | 0.0455 ns | 0.0426 ns | 17.025 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_ConvertibleClass_AsObject | .NET Core 2.0 | 16.768 ns | 0.0285 ns | 0.0253 ns | 16.766 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 2.2 | 17.714 ns | 0.0102 ns | 0.0090 ns | 17.713 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 3.0 | 14.221 ns | 0.0211 ns | 0.0197 ns | 14.223 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net461 | 16.926 ns | 0.0427 ns | 0.0399 ns | 16.926 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net472 | 17.129 ns | 0.0230 ns | 0.0204 ns | 17.129 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_ConvertibleClass_NoValue | .NET Core 2.0 | 13.771 ns | 0.0138 ns | 0.0116 ns | 13.773 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 2.2 | 11.840 ns | 0.0447 ns | 0.0418 ns | 11.851 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 3.0 | 11.682 ns | 0.2591 ns | 0.3798 ns | 11.886 ns |  0.83 |    0.03 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net461 | 14.893 ns | 0.0251 ns | 0.0234 ns | 14.893 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net472 | 13.182 ns | 0.0296 ns | 0.0277 ns | 13.180 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.0 | 15.027 ns | 0.0363 ns | 0.0340 ns | 15.031 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.2 | 13.484 ns | 0.0095 ns | 0.0084 ns | 13.483 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 3.0 | 12.925 ns | 0.0519 ns | 0.0485 ns | 12.892 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net461 | 14.933 ns | 0.0141 ns | 0.0125 ns | 14.932 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net472 | 13.311 ns | 0.0226 ns | 0.0211 ns | 13.306 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                              From_NonConvertibleClass | .NET Core 2.0 | 11.909 ns | 0.0159 ns | 0.0141 ns | 11.911 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 2.2 | 10.384 ns | 0.0215 ns | 0.0201 ns | 10.383 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 3.0 | 10.705 ns | 0.0086 ns | 0.0077 ns | 10.703 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net461 | 13.993 ns | 0.0169 ns | 0.0158 ns | 13.994 ns |  1.17 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net472 | 12.481 ns | 0.0122 ns | 0.0108 ns | 12.479 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                     From_NonConvertibleClass_AsObject | .NET Core 2.0 | 15.080 ns | 0.0188 ns | 0.0175 ns | 15.081 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 2.2 | 14.060 ns | 0.0344 ns | 0.0322 ns | 14.046 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 3.0 | 14.942 ns | 0.3198 ns | 0.3683 ns | 14.939 ns |  0.98 |    0.02 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net461 | 14.847 ns | 0.0146 ns | 0.0137 ns | 14.841 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net472 | 14.955 ns | 0.0222 ns | 0.0208 ns | 14.955 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                      From_NonConvertibleClass_NoValue | .NET Core 2.0 | 12.002 ns | 0.0124 ns | 0.0110 ns | 12.003 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 2.2 | 10.345 ns | 0.0081 ns | 0.0067 ns | 10.346 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 3.0 | 11.183 ns | 0.0130 ns | 0.0101 ns | 11.183 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net461 | 12.361 ns | 0.0158 ns | 0.0147 ns | 12.360 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net472 | 12.549 ns | 0.0212 ns | 0.0198 ns | 12.546 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.0 | 15.431 ns | 0.0292 ns | 0.0244 ns | 15.430 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.2 | 12.786 ns | 0.0588 ns | 0.0550 ns | 12.799 ns |  0.83 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 3.0 | 11.331 ns | 0.0229 ns | 0.0203 ns | 11.330 ns |  0.73 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net461 | 13.037 ns | 0.0130 ns | 0.0116 ns | 13.039 ns |  0.84 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net472 | 14.470 ns | 0.0590 ns | 0.0552 ns | 14.481 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                From_ConvertibleStruct | .NET Core 2.0 | 18.662 ns | 0.0495 ns | 0.0463 ns | 18.653 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 2.2 | 16.487 ns | 0.0378 ns | 0.0315 ns | 16.491 ns |  0.88 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 3.0 | 11.293 ns | 0.0505 ns | 0.0472 ns | 11.276 ns |  0.61 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net461 | 16.522 ns | 0.0368 ns | 0.0344 ns | 16.519 ns |  0.89 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net472 | 16.678 ns | 0.0370 ns | 0.0328 ns | 16.678 ns |  0.89 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                       From_ConvertibleStruct_AsObject | .NET Core 2.0 | 17.903 ns | 0.0327 ns | 0.0290 ns | 17.898 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 2.2 | 17.842 ns | 0.0170 ns | 0.0159 ns | 17.845 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 3.0 | 15.366 ns | 0.0339 ns | 0.0300 ns | 15.367 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net461 | 17.574 ns | 0.0261 ns | 0.0245 ns | 17.566 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net472 | 18.174 ns | 0.0276 ns | 0.0245 ns | 18.177 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.0 | 19.661 ns | 0.0278 ns | 0.0260 ns | 19.663 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.2 | 16.100 ns | 0.0218 ns | 0.0204 ns | 16.098 ns |  0.82 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 3.0 | 12.600 ns | 0.2714 ns | 0.3230 ns | 12.399 ns |  0.65 |    0.02 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net461 | 17.593 ns | 0.0248 ns | 0.0207 ns | 17.590 ns |  0.89 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net472 | 17.020 ns | 0.0382 ns | 0.0319 ns | 17.024 ns |  0.87 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 17.514 ns | 0.0557 ns | 0.0521 ns | 17.516 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.656 ns | 0.0191 ns | 0.0159 ns | 17.657 ns |  1.01 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 16.400 ns | 0.0210 ns | 0.0196 ns | 16.408 ns |  0.94 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net461 | 17.575 ns | 0.0211 ns | 0.0187 ns | 17.576 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net472 | 18.027 ns | 0.0362 ns | 0.0321 ns | 18.030 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.0 | 13.185 ns | 0.0109 ns | 0.0102 ns | 13.180 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.2 | 12.061 ns | 0.0766 ns | 0.0679 ns | 12.031 ns |  0.91 |    0.01 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 3.0 |  6.971 ns | 0.0494 ns | 0.0462 ns |  6.984 ns |  0.53 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net461 | 11.338 ns | 0.0235 ns | 0.0220 ns | 11.336 ns |  0.86 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net472 | 10.601 ns | 0.0185 ns | 0.0173 ns | 10.598 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.055 ns | 0.0082 ns | 0.0068 ns | 14.057 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.877 ns | 0.1649 ns | 0.1461 ns | 12.808 ns |  0.92 |    0.01 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.545 ns | 0.0267 ns | 0.0250 ns | 11.544 ns |  0.82 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net461 | 13.247 ns | 0.0131 ns | 0.0122 ns | 13.248 ns |  0.94 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net472 | 13.184 ns | 0.0224 ns | 0.0187 ns | 13.188 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_NonConvertibleStruct | .NET Core 2.0 | 13.044 ns | 0.0106 ns | 0.0094 ns | 13.045 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 2.2 | 10.790 ns | 0.0565 ns | 0.0441 ns | 10.797 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 3.0 |  6.403 ns | 0.0143 ns | 0.0126 ns |  6.407 ns |  0.49 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net461 | 10.324 ns | 0.0120 ns | 0.0106 ns | 10.325 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net472 | 11.634 ns | 0.0363 ns | 0.0339 ns | 11.619 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.0 | 15.038 ns | 0.0268 ns | 0.0251 ns | 15.045 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.2 | 14.890 ns | 0.0236 ns | 0.0209 ns | 14.880 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 3.0 | 14.516 ns | 0.1306 ns | 0.1222 ns | 14.470 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net461 | 14.778 ns | 0.0261 ns | 0.0244 ns | 14.777 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net472 | 15.718 ns | 0.0200 ns | 0.0167 ns | 15.718 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.0 | 13.074 ns | 0.0170 ns | 0.0159 ns | 13.072 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.2 | 10.738 ns | 0.0203 ns | 0.0189 ns | 10.735 ns |  0.82 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 3.0 |  6.577 ns | 0.0118 ns | 0.0104 ns |  6.578 ns |  0.50 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net461 | 10.315 ns | 0.0137 ns | 0.0128 ns | 10.312 ns |  0.79 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net472 | 11.626 ns | 0.0105 ns | 0.0093 ns | 11.627 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 14.975 ns | 0.0218 ns | 0.0204 ns | 14.969 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 14.058 ns | 0.0273 ns | 0.0255 ns | 14.053 ns |  0.94 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 13.042 ns | 0.0504 ns | 0.0446 ns | 13.050 ns |  0.87 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net461 | 14.912 ns | 0.0366 ns | 0.0342 ns | 14.915 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net472 | 15.022 ns | 0.0247 ns | 0.0231 ns | 15.018 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.0 | 13.023 ns | 0.0239 ns | 0.0223 ns | 13.023 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.2 | 10.819 ns | 0.0179 ns | 0.0158 ns | 10.819 ns |  0.83 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 3.0 |  7.938 ns | 0.1832 ns | 0.4098 ns |  8.059 ns |  0.58 |    0.05 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net461 | 10.786 ns | 0.0171 ns | 0.0160 ns | 10.791 ns |  0.83 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net472 | 11.499 ns | 0.0096 ns | 0.0085 ns | 11.498 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.082 ns | 0.0122 ns | 0.0114 ns | 14.085 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.494 ns | 0.0156 ns | 0.0146 ns | 13.493 ns |  0.96 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.288 ns | 0.0520 ns | 0.0487 ns | 11.273 ns |  0.80 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net461 | 13.061 ns | 0.0084 ns | 0.0074 ns | 13.060 ns |  0.93 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net472 | 13.777 ns | 0.0409 ns | 0.0383 ns | 13.784 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Enum | .NET Core 2.0 | 12.864 ns | 0.0125 ns | 0.0117 ns | 12.864 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 2.2 | 10.788 ns | 0.1419 ns | 0.1185 ns | 10.767 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 3.0 |  7.556 ns | 0.0142 ns | 0.0118 ns |  7.554 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                                             From_Enum |        net461 | 10.795 ns | 0.0318 ns | 0.0282 ns | 10.804 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                             From_Enum |        net472 | 10.791 ns | 0.0138 ns | 0.0129 ns | 10.793 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Enum_AsObject | .NET Core 2.0 | 46.698 ns | 0.1540 ns | 0.1441 ns | 46.678 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject | .NET Core 2.2 | 42.911 ns | 0.3853 ns | 0.3604 ns | 42.878 ns |  0.92 |    0.01 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject | .NET Core 3.0 | 40.357 ns | 0.2083 ns | 0.1949 ns | 40.479 ns |  0.86 |    0.01 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject |        net461 | 47.245 ns | 0.0796 ns | 0.0705 ns | 47.245 ns |  1.01 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject |        net472 | 43.527 ns | 0.0908 ns | 0.0709 ns | 43.533 ns |  0.93 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Enum_Nullable_WithValue | .NET Core 2.0 | 12.750 ns | 0.0149 ns | 0.0140 ns | 12.750 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 2.2 | 12.193 ns | 0.0811 ns | 0.0677 ns | 12.208 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 3.0 |  9.945 ns | 0.2234 ns | 0.5562 ns | 10.121 ns |  0.73 |    0.08 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net461 | 12.016 ns | 0.0091 ns | 0.0081 ns | 12.015 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net472 | 12.165 ns | 0.0083 ns | 0.0078 ns | 12.165 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.0 | 45.293 ns | 0.0607 ns | 0.0538 ns | 45.286 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.2 | 45.487 ns | 0.2421 ns | 0.2265 ns | 45.440 ns |  1.00 |    0.01 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 3.0 | 42.793 ns | 0.7519 ns | 0.7034 ns | 42.973 ns |  0.94 |    0.02 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject |        net461 | 42.872 ns | 0.2418 ns | 0.2262 ns | 42.857 ns |  0.95 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject |        net472 | 45.394 ns | 0.0636 ns | 0.0563 ns | 45.407 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Enum_Nullable_NoValue | .NET Core 2.0 | 13.097 ns | 0.0135 ns | 0.0126 ns | 13.100 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 2.2 | 10.819 ns | 0.0408 ns | 0.0362 ns | 10.808 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 3.0 |  6.546 ns | 0.0097 ns | 0.0081 ns |  6.545 ns |  0.50 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net461 | 10.372 ns | 0.0140 ns | 0.0124 ns | 10.373 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net472 | 10.343 ns | 0.0110 ns | 0.0103 ns | 10.341 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.352 ns | 0.0241 ns | 0.0225 ns | 14.356 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.752 ns | 0.0977 ns | 0.0866 ns | 12.719 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.886 ns | 0.0304 ns | 0.0284 ns | 12.884 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net461 | 13.104 ns | 0.0231 ns | 0.0216 ns | 13.106 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net472 | 13.330 ns | 0.0352 ns | 0.0312 ns | 13.335 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                      From_ParentClass | .NET Core 2.0 | 11.912 ns | 0.0124 ns | 0.0116 ns | 11.910 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 2.2 | 11.265 ns | 0.0107 ns | 0.0095 ns | 11.266 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 3.0 | 11.060 ns | 0.2360 ns | 0.2207 ns | 11.185 ns |  0.93 |    0.02 |      - |     - |     - |         - |
                                      From_ParentClass |        net461 | 14.112 ns | 0.1268 ns | 0.1124 ns | 14.060 ns |  1.18 |    0.01 |      - |     - |     - |         - |
                                      From_ParentClass |        net472 | 12.592 ns | 0.0253 ns | 0.0237 ns | 12.586 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_ParentClass_AsObject | .NET Core 2.0 | 15.447 ns | 0.0231 ns | 0.0216 ns | 15.441 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 2.2 | 15.268 ns | 0.0175 ns | 0.0155 ns | 15.268 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 3.0 | 13.622 ns | 0.2196 ns | 0.2054 ns | 13.505 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net461 | 15.399 ns | 0.0233 ns | 0.0207 ns | 15.392 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net472 | 15.596 ns | 0.0253 ns | 0.0237 ns | 15.595 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                              From_ParentClass_NoValue | .NET Core 2.0 | 12.150 ns | 0.0311 ns | 0.0291 ns | 12.154 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 2.2 | 10.348 ns | 0.0097 ns | 0.0086 ns | 10.348 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 3.0 | 10.829 ns | 0.0945 ns | 0.0884 ns | 10.766 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net461 | 13.985 ns | 0.0123 ns | 0.0109 ns | 13.984 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net472 | 12.436 ns | 0.0327 ns | 0.0306 ns | 12.443 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.0 | 13.929 ns | 0.0175 ns | 0.0155 ns | 13.925 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.2 | 13.036 ns | 0.2419 ns | 0.2689 ns | 12.941 ns |  0.94 |    0.02 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 3.0 | 13.872 ns | 0.2213 ns | 0.2070 ns | 13.736 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net461 | 13.039 ns | 0.0117 ns | 0.0109 ns | 13.037 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net472 | 13.174 ns | 0.0183 ns | 0.0172 ns | 13.169 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_ParentStruct | .NET Core 2.0 | 37.759 ns | 0.0447 ns | 0.0373 ns | 37.749 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 2.2 | 37.158 ns | 0.1749 ns | 0.1551 ns | 37.143 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 3.0 | 36.375 ns | 0.6107 ns | 0.5712 ns | 36.025 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                                     From_ParentStruct |        net461 | 38.162 ns | 0.0338 ns | 0.0300 ns | 38.156 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct |        net472 | 40.553 ns | 0.0835 ns | 0.0740 ns | 40.558 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_ParentStruct_AsObject | .NET Core 2.0 | 15.522 ns | 0.0198 ns | 0.0165 ns | 15.522 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 2.2 | 16.128 ns | 0.0275 ns | 0.0229 ns | 16.122 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 3.0 | 13.212 ns | 0.0150 ns | 0.0140 ns | 13.215 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net461 | 15.478 ns | 0.0682 ns | 0.0638 ns | 15.495 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net472 | 15.290 ns | 0.0310 ns | 0.0275 ns | 15.289 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.0 | 39.523 ns | 0.0509 ns | 0.0451 ns | 39.517 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.2 | 37.483 ns | 0.0781 ns | 0.0652 ns | 37.463 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 3.0 | 33.840 ns | 0.0536 ns | 0.0476 ns | 33.832 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue |        net461 | 38.815 ns | 0.1467 ns | 0.1372 ns | 38.829 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue |        net472 | 46.151 ns | 0.1092 ns | 0.1022 ns | 46.168 ns |  1.17 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 15.420 ns | 0.0169 ns | 0.0150 ns | 15.419 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.275 ns | 0.0678 ns | 0.0634 ns | 15.244 ns |  0.99 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.849 ns | 0.2618 ns | 0.2449 ns | 15.647 ns |  1.03 |    0.02 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net461 | 15.205 ns | 0.0281 ns | 0.0263 ns | 15.208 ns |  0.99 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net472 | 15.262 ns | 0.0330 ns | 0.0276 ns | 15.261 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.0 | 42.794 ns | 0.1125 ns | 0.1052 ns | 42.827 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.2 | 37.559 ns | 0.1693 ns | 0.1583 ns | 37.542 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 3.0 | 34.211 ns | 0.6878 ns | 0.7921 ns | 33.793 ns |  0.80 |    0.02 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net461 | 38.825 ns | 0.1429 ns | 0.1337 ns | 38.837 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net472 | 53.234 ns | 0.1194 ns | 0.1117 ns | 53.220 ns |  1.24 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.930 ns | 0.0208 ns | 0.0194 ns | 13.930 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.649 ns | 0.0276 ns | 0.0230 ns | 13.648 ns |  0.98 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.289 ns | 0.0125 ns | 0.0105 ns | 11.292 ns |  0.81 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net461 | 13.358 ns | 0.0280 ns | 0.0262 ns | 13.352 ns |  0.96 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net472 | 13.245 ns | 0.0377 ns | 0.0353 ns | 13.250 ns |  0.95 |    0.00 |      - |     - |     - |         - |

Benchmarks with issues:
  ConvertTo_Short.From_DateTime_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_Short.From_DateTime_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_Short.From_DateTime_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_Short.From_DateTime_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_Short.From_DateTime_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_Short.From_DateTime_Nullable_WithValue_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_Short.From_DateTime_Nullable_WithValue_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_Short.From_DateTime_Nullable_WithValue_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_Short.From_DateTime_Nullable_WithValue_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_Short.From_DateTime_Nullable_WithValue_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_Short.From_String_Empty_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_Short.From_String_Empty_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_Short.From_String_Empty_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_Short.From_String_Empty_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_Short.From_String_Empty_AsObject: Job-PJAXXB(Toolchain=net472)
