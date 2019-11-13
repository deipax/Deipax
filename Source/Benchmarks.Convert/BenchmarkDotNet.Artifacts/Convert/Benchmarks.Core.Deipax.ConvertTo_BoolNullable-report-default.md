
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
                                             From_Bool | .NET Core 2.0 | 11.919 ns | 0.0644 ns | 0.0603 ns | 11.950 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 2.2 | 10.376 ns | 0.0162 ns | 0.0144 ns | 10.382 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 3.0 |  9.758 ns | 0.0337 ns | 0.0263 ns |  9.760 ns |  0.82 |    0.01 |      - |     - |     - |         - |
                                             From_Bool |        net461 | 12.913 ns | 0.0367 ns | 0.0325 ns | 12.906 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                                             From_Bool |        net472 | 12.240 ns | 0.0165 ns | 0.0154 ns | 12.239 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Bool_AsObject | .NET Core 2.0 | 24.046 ns | 0.0175 ns | 0.0146 ns | 24.046 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 2.2 | 25.750 ns | 0.0241 ns | 0.0226 ns | 25.749 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 3.0 | 28.516 ns | 0.0615 ns | 0.0514 ns | 28.523 ns |  1.19 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net461 | 35.103 ns | 0.3211 ns | 0.3003 ns | 35.292 ns |  1.46 |    0.01 |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net472 | 35.771 ns | 0.0740 ns | 0.0692 ns | 35.785 ns |  1.49 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Bool_Nullable_WithValue | .NET Core 2.0 | 11.628 ns | 0.0083 ns | 0.0077 ns | 11.629 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 2.2 |  9.951 ns | 0.0147 ns | 0.0130 ns |  9.951 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 3.0 |  6.725 ns | 0.1586 ns | 0.1763 ns |  6.820 ns |  0.58 |    0.02 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net461 | 11.797 ns | 0.0129 ns | 0.0108 ns | 11.798 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net472 | 11.927 ns | 0.0454 ns | 0.0403 ns | 11.935 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.0 | 23.841 ns | 0.0781 ns | 0.0730 ns | 23.858 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.2 | 25.750 ns | 0.0267 ns | 0.0236 ns | 25.750 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 3.0 | 29.590 ns | 0.6103 ns | 0.8555 ns | 28.890 ns |  1.26 |    0.04 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net461 | 36.472 ns | 0.0778 ns | 0.0728 ns | 36.450 ns |  1.53 |    0.01 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net472 | 35.874 ns | 0.0923 ns | 0.0819 ns | 35.863 ns |  1.50 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Bool_Nullable_NoValue | .NET Core 2.0 | 11.595 ns | 0.0120 ns | 0.0106 ns | 11.598 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 2.2 | 10.634 ns | 0.0073 ns | 0.0068 ns | 10.633 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 3.0 |  7.460 ns | 0.1728 ns | 0.2307 ns |  7.566 ns |  0.64 |    0.02 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net461 | 11.921 ns | 0.0377 ns | 0.0353 ns | 11.928 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net472 | 11.729 ns | 0.0146 ns | 0.0136 ns | 11.728 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.759 ns | 0.0197 ns | 0.0165 ns | 14.759 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.437 ns | 0.0206 ns | 0.0183 ns | 13.435 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.302 ns | 0.0846 ns | 0.0791 ns | 13.270 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net461 | 25.102 ns | 0.0220 ns | 0.0205 ns | 25.102 ns |  1.70 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net472 | 22.919 ns | 0.1393 ns | 0.1303 ns | 22.986 ns |  1.55 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Byte | .NET Core 2.0 | 11.827 ns | 0.0168 ns | 0.0157 ns | 11.830 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 2.2 | 10.459 ns | 0.0148 ns | 0.0138 ns | 10.461 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 3.0 |  9.882 ns | 0.1176 ns | 0.1100 ns |  9.894 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                                             From_Byte |        net461 | 12.910 ns | 0.0165 ns | 0.0154 ns | 12.909 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                             From_Byte |        net472 | 12.202 ns | 0.0158 ns | 0.0140 ns | 12.205 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Byte_AsObject | .NET Core 2.0 | 20.212 ns | 0.0281 ns | 0.0234 ns | 20.201 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 2.2 | 18.068 ns | 0.0154 ns | 0.0144 ns | 18.073 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 3.0 | 17.603 ns | 0.1183 ns | 0.1107 ns | 17.614 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net461 | 26.891 ns | 0.1466 ns | 0.1372 ns | 26.952 ns |  1.33 |    0.01 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net472 | 28.694 ns | 0.0258 ns | 0.0241 ns | 28.695 ns |  1.42 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Byte_Nullable_WithValue | .NET Core 2.0 | 12.035 ns | 0.0172 ns | 0.0152 ns | 12.038 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 2.2 | 10.671 ns | 0.0090 ns | 0.0085 ns | 10.672 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 3.0 | 10.191 ns | 0.0569 ns | 0.0532 ns | 10.174 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net461 | 15.242 ns | 0.0144 ns | 0.0134 ns | 15.242 ns |  1.27 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net472 | 14.237 ns | 0.0600 ns | 0.0562 ns | 14.253 ns |  1.18 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.207 ns | 0.0285 ns | 0.0267 ns | 20.195 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.794 ns | 0.0204 ns | 0.0191 ns | 17.796 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.179 ns | 0.1738 ns | 0.1540 ns | 18.220 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net461 | 26.888 ns | 0.1372 ns | 0.1284 ns | 26.950 ns |  1.33 |    0.01 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net472 | 26.351 ns | 0.0432 ns | 0.0361 ns | 26.370 ns |  1.30 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Byte_Nullable_NoValue | .NET Core 2.0 | 11.922 ns | 0.0744 ns | 0.0621 ns | 11.937 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 2.2 | 10.280 ns | 0.0074 ns | 0.0069 ns | 10.279 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 3.0 |  9.761 ns | 0.0659 ns | 0.0617 ns |  9.769 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net461 | 12.719 ns | 0.0339 ns | 0.0317 ns | 12.703 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net472 | 13.103 ns | 0.0182 ns | 0.0170 ns | 13.102 ns |  1.10 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.481 ns | 0.0329 ns | 0.0308 ns | 15.477 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.435 ns | 0.0181 ns | 0.0161 ns | 13.435 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.752 ns | 0.3103 ns | 0.3694 ns | 14.892 ns |  0.96 |    0.02 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net461 | 22.114 ns | 0.0499 ns | 0.0467 ns | 22.114 ns |  1.43 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net472 | 23.982 ns | 0.1228 ns | 0.1149 ns | 23.948 ns |  1.55 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Char | .NET Core 2.0 | 11.875 ns | 0.0586 ns | 0.0549 ns | 11.886 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Char | .NET Core 2.2 | 10.904 ns | 0.0179 ns | 0.0168 ns | 10.905 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                             From_Char | .NET Core 3.0 |  9.504 ns | 0.0694 ns | 0.0616 ns |  9.490 ns |  0.80 |    0.01 |      - |     - |     - |         - |
                                             From_Char |        net461 | 12.365 ns | 0.0640 ns | 0.0598 ns | 12.389 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                             From_Char |        net472 | 12.913 ns | 0.0156 ns | 0.0146 ns | 12.908 ns |  1.09 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Char_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Char_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Char_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Char_Nullable_WithValue | .NET Core 2.0 | 13.156 ns | 0.0259 ns | 0.0216 ns | 13.159 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 2.2 | 10.072 ns | 0.0172 ns | 0.0153 ns | 10.073 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 3.0 |  9.730 ns | 0.0680 ns | 0.0603 ns |  9.702 ns |  0.74 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net461 | 12.677 ns | 0.0217 ns | 0.0181 ns | 12.676 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net472 | 13.893 ns | 0.0255 ns | 0.0226 ns | 13.895 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Char_Nullable_NoValue | .NET Core 2.0 | 12.360 ns | 0.1198 ns | 0.1121 ns | 12.370 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 2.2 | 10.074 ns | 0.0103 ns | 0.0096 ns | 10.075 ns |  0.82 |    0.01 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 3.0 |  9.758 ns | 0.0714 ns | 0.0668 ns |  9.778 ns |  0.79 |    0.01 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net461 | 13.246 ns | 0.0217 ns | 0.0192 ns | 13.252 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net472 | 13.072 ns | 0.0148 ns | 0.0131 ns | 13.071 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.943 ns | 0.0841 ns | 0.0787 ns | 14.978 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.801 ns | 0.0142 ns | 0.0132 ns | 13.803 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.315 ns | 0.1240 ns | 0.1160 ns | 13.340 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net461 | 22.127 ns | 0.0331 ns | 0.0310 ns | 22.133 ns |  1.48 |    0.01 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net472 | 25.191 ns | 0.0367 ns | 0.0344 ns | 25.188 ns |  1.69 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                         From_DateTime | .NET Core 2.0 | 12.043 ns | 0.0525 ns | 0.0439 ns | 12.030 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 2.2 | 11.194 ns | 0.0091 ns | 0.0071 ns | 11.195 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 3.0 |  9.943 ns | 0.0956 ns | 0.0894 ns |  9.913 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                                         From_DateTime |        net461 | 13.063 ns | 0.0330 ns | 0.0276 ns | 13.064 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime |        net472 | 13.471 ns | 0.0130 ns | 0.0115 ns | 13.466 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                From_DateTime_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                      From_DateTime_Nullable_WithValue | .NET Core 2.0 | 13.188 ns | 0.0532 ns | 0.0471 ns | 13.191 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 2.2 | 11.951 ns | 0.0096 ns | 0.0086 ns | 11.954 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 3.0 | 10.036 ns | 0.0676 ns | 0.0599 ns | 10.029 ns |  0.76 |    0.01 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net461 | 13.698 ns | 0.0179 ns | 0.0149 ns | 13.698 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net472 | 14.418 ns | 0.0343 ns | 0.0321 ns | 14.412 ns |  1.09 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_DateTime_Nullable_NoValue | .NET Core 2.0 | 13.027 ns | 0.0115 ns | 0.0107 ns | 13.028 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 2.2 | 11.217 ns | 0.0207 ns | 0.0193 ns | 11.222 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 3.0 | 10.030 ns | 0.0602 ns | 0.0534 ns | 10.038 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net461 | 13.145 ns | 0.0088 ns | 0.0073 ns | 13.142 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net472 | 14.176 ns | 0.0245 ns | 0.0229 ns | 14.174 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.592 ns | 0.0894 ns | 0.0792 ns | 15.608 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.492 ns | 0.0119 ns | 0.0111 ns | 13.490 ns |  0.87 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.097 ns | 0.3077 ns | 0.4511 ns | 13.914 ns |  0.92 |    0.03 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net461 | 23.789 ns | 0.0350 ns | 0.0327 ns | 23.791 ns |  1.53 |    0.01 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net472 | 22.352 ns | 0.0265 ns | 0.0248 ns | 22.346 ns |  1.43 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                          From_Decimal | .NET Core 2.0 | 23.110 ns | 0.0553 ns | 0.0490 ns | 23.105 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 2.2 | 19.060 ns | 0.0228 ns | 0.0214 ns | 19.059 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 3.0 | 12.937 ns | 0.0748 ns | 0.0699 ns | 12.908 ns |  0.56 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal |        net461 | 23.534 ns | 0.1029 ns | 0.0962 ns | 23.574 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal |        net472 | 23.414 ns | 0.0725 ns | 0.0643 ns | 23.386 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                 From_Decimal_AsObject | .NET Core 2.0 | 25.963 ns | 0.0310 ns | 0.0275 ns | 25.960 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 2.2 | 23.399 ns | 0.0201 ns | 0.0188 ns | 23.398 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 3.0 | 20.810 ns | 0.0809 ns | 0.0756 ns | 20.781 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net461 | 39.144 ns | 0.0439 ns | 0.0390 ns | 39.136 ns |  1.51 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net472 | 36.009 ns | 0.0285 ns | 0.0253 ns | 36.014 ns |  1.39 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                       From_Decimal_Nullable_WithValue | .NET Core 2.0 | 23.032 ns | 0.0303 ns | 0.0283 ns | 23.025 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 2.2 | 19.626 ns | 0.0202 ns | 0.0189 ns | 19.630 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 3.0 | 17.505 ns | 0.1630 ns | 0.1525 ns | 17.466 ns |  0.76 |    0.01 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net461 | 23.993 ns | 0.0335 ns | 0.0297 ns | 23.989 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net472 | 23.909 ns | 0.0437 ns | 0.0409 ns | 23.919 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.0 | 26.096 ns | 0.0263 ns | 0.0246 ns | 26.091 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.2 | 23.566 ns | 0.0503 ns | 0.0471 ns | 23.570 ns |  0.90 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 3.0 | 22.174 ns | 0.1175 ns | 0.1099 ns | 22.182 ns |  0.85 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net461 | 33.961 ns | 0.0394 ns | 0.0369 ns | 33.959 ns |  1.30 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net472 | 33.337 ns | 0.0870 ns | 0.0814 ns | 33.335 ns |  1.28 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Decimal_Nullable_NoValue | .NET Core 2.0 | 13.105 ns | 0.0363 ns | 0.0339 ns | 13.103 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 2.2 | 12.084 ns | 0.0190 ns | 0.0169 ns | 12.088 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 3.0 | 10.239 ns | 0.0701 ns | 0.0622 ns | 10.212 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net461 | 13.378 ns | 0.0132 ns | 0.0123 ns | 13.379 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net472 | 13.550 ns | 0.0181 ns | 0.0169 ns | 13.545 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.776 ns | 0.0147 ns | 0.0131 ns | 14.774 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.261 ns | 0.0182 ns | 0.0152 ns | 14.261 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.450 ns | 0.1654 ns | 0.1547 ns | 13.457 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net461 | 22.303 ns | 0.0311 ns | 0.0260 ns | 22.301 ns |  1.51 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net472 | 22.443 ns | 0.0261 ns | 0.0231 ns | 22.442 ns |  1.52 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_Double | .NET Core 2.0 | 12.469 ns | 0.0096 ns | 0.0085 ns | 12.468 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 2.2 | 10.862 ns | 0.0125 ns | 0.0117 ns | 10.866 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 3.0 | 10.277 ns | 0.0953 ns | 0.0844 ns | 10.272 ns |  0.82 |    0.01 |      - |     - |     - |         - |
                                           From_Double |        net461 | 14.067 ns | 0.0151 ns | 0.0134 ns | 14.069 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                           From_Double |        net472 | 13.418 ns | 0.0223 ns | 0.0208 ns | 13.415 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_Double_AsObject | .NET Core 2.0 | 19.918 ns | 0.0241 ns | 0.0213 ns | 19.918 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 2.2 | 19.060 ns | 0.0517 ns | 0.0484 ns | 19.067 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 3.0 | 18.559 ns | 0.3947 ns | 0.3876 ns | 18.534 ns |  0.93 |    0.02 |      - |     - |     - |         - |
                                  From_Double_AsObject |        net461 | 28.784 ns | 0.0628 ns | 0.0588 ns | 28.764 ns |  1.44 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject |        net472 | 29.332 ns | 0.0431 ns | 0.0403 ns | 29.336 ns |  1.47 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_Double_Nullable_WithValue | .NET Core 2.0 | 12.985 ns | 0.0109 ns | 0.0102 ns | 12.985 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 2.2 | 12.553 ns | 0.0128 ns | 0.0114 ns | 12.550 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 3.0 | 11.040 ns | 0.1067 ns | 0.0998 ns | 11.077 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net461 | 13.823 ns | 0.0182 ns | 0.0170 ns | 13.823 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net472 | 13.874 ns | 0.0133 ns | 0.0124 ns | 13.874 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.0 | 21.034 ns | 0.0250 ns | 0.0222 ns | 21.038 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.711 ns | 0.0204 ns | 0.0191 ns | 17.714 ns |  0.84 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.092 ns | 0.0797 ns | 0.0746 ns | 18.076 ns |  0.86 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net461 | 28.578 ns | 0.0353 ns | 0.0330 ns | 28.570 ns |  1.36 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net472 | 27.290 ns | 0.0344 ns | 0.0322 ns | 27.290 ns |  1.30 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Double_Nullable_NoValue | .NET Core 2.0 | 13.632 ns | 0.0146 ns | 0.0122 ns | 13.632 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 2.2 | 11.461 ns | 0.0349 ns | 0.0327 ns | 11.466 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 3.0 | 10.449 ns | 0.2290 ns | 0.2545 ns | 10.370 ns |  0.77 |    0.02 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net461 | 13.495 ns | 0.0770 ns | 0.0720 ns | 13.527 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net472 | 13.545 ns | 0.0176 ns | 0.0147 ns | 13.541 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.410 ns | 0.0225 ns | 0.0199 ns | 15.407 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.397 ns | 0.0094 ns | 0.0079 ns | 13.398 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.947 ns | 0.1229 ns | 0.1150 ns | 13.914 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net461 | 23.845 ns | 0.0336 ns | 0.0281 ns | 23.853 ns |  1.55 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net472 | 22.354 ns | 0.0704 ns | 0.0659 ns | 22.358 ns |  1.45 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_Short | .NET Core 2.0 | 12.473 ns | 0.0204 ns | 0.0190 ns | 12.477 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 2.2 | 10.372 ns | 0.0092 ns | 0.0086 ns | 10.375 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 3.0 |  9.779 ns | 0.0613 ns | 0.0573 ns |  9.794 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                                            From_Short |        net461 | 12.450 ns | 0.0202 ns | 0.0179 ns | 12.448 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Short |        net472 | 12.439 ns | 0.0220 ns | 0.0184 ns | 12.439 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_Short_AsObject | .NET Core 2.0 | 20.123 ns | 0.0256 ns | 0.0227 ns | 20.121 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 2.2 | 17.914 ns | 0.1005 ns | 0.0839 ns | 17.941 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 3.0 | 17.538 ns | 0.1183 ns | 0.1106 ns | 17.510 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net461 | 26.605 ns | 0.0264 ns | 0.0234 ns | 26.605 ns |  1.32 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net472 | 27.661 ns | 0.0420 ns | 0.0393 ns | 27.666 ns |  1.37 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Short_Nullable_WithValue | .NET Core 2.0 | 12.526 ns | 0.0136 ns | 0.0121 ns | 12.523 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 2.2 | 10.858 ns | 0.0330 ns | 0.0309 ns | 10.862 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 3.0 | 10.293 ns | 0.1097 ns | 0.1026 ns | 10.278 ns |  0.82 |    0.01 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net461 | 12.713 ns | 0.0121 ns | 0.0107 ns | 12.715 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net472 | 13.063 ns | 0.0077 ns | 0.0064 ns | 13.063 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.596 ns | 0.0931 ns | 0.0871 ns | 20.622 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.739 ns | 0.0166 ns | 0.0147 ns | 17.739 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.672 ns | 0.1460 ns | 0.1366 ns | 17.704 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net461 | 26.784 ns | 0.0333 ns | 0.0311 ns | 26.778 ns |  1.30 |    0.01 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net472 | 26.990 ns | 0.0310 ns | 0.0290 ns | 26.989 ns |  1.31 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Short_Nullable_NoValue | .NET Core 2.0 | 11.834 ns | 0.0208 ns | 0.0185 ns | 11.827 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 2.2 | 10.463 ns | 0.0116 ns | 0.0103 ns | 10.461 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 3.0 |  9.825 ns | 0.0965 ns | 0.0903 ns |  9.831 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net461 | 12.719 ns | 0.0093 ns | 0.0087 ns | 12.719 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net472 | 12.747 ns | 0.0167 ns | 0.0156 ns | 12.745 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.765 ns | 0.0138 ns | 0.0123 ns | 14.765 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.544 ns | 0.0102 ns | 0.0085 ns | 13.543 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.633 ns | 0.3081 ns | 0.3784 ns | 14.827 ns |  0.98 |    0.02 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net461 | 22.006 ns | 0.0219 ns | 0.0205 ns | 22.005 ns |  1.49 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net472 | 21.919 ns | 0.1126 ns | 0.1053 ns | 21.958 ns |  1.48 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                              From_Int | .NET Core 2.0 | 12.965 ns | 0.0482 ns | 0.0451 ns | 12.975 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 2.2 | 10.367 ns | 0.0086 ns | 0.0076 ns | 10.364 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 3.0 |  9.633 ns | 0.0974 ns | 0.0814 ns |  9.670 ns |  0.74 |    0.01 |      - |     - |     - |         - |
                                              From_Int |        net461 | 12.375 ns | 0.0110 ns | 0.0103 ns | 12.377 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                              From_Int |        net472 | 12.209 ns | 0.0171 ns | 0.0160 ns | 12.208 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_Int_AsObject | .NET Core 2.0 | 20.182 ns | 0.0178 ns | 0.0158 ns | 20.183 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 2.2 | 17.738 ns | 0.0243 ns | 0.0227 ns | 17.738 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 3.0 | 18.077 ns | 0.1415 ns | 0.1324 ns | 18.067 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net461 | 26.700 ns | 0.0542 ns | 0.0507 ns | 26.702 ns |  1.32 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net472 | 26.766 ns | 0.0317 ns | 0.0297 ns | 26.772 ns |  1.33 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Int_Nullable_WithValue | .NET Core 2.0 | 12.045 ns | 0.0144 ns | 0.0127 ns | 12.046 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 2.2 | 10.725 ns | 0.0163 ns | 0.0152 ns | 10.726 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 3.0 | 10.256 ns | 0.1206 ns | 0.1128 ns | 10.231 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net461 | 12.706 ns | 0.0148 ns | 0.0138 ns | 12.710 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net472 | 12.805 ns | 0.0093 ns | 0.0087 ns | 12.803 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.667 ns | 0.0484 ns | 0.0429 ns | 20.664 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.735 ns | 0.0320 ns | 0.0299 ns | 17.737 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.290 ns | 0.3568 ns | 0.3337 ns | 18.250 ns |  0.89 |    0.02 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net461 | 27.289 ns | 0.0602 ns | 0.0563 ns | 27.292 ns |  1.32 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net472 | 26.935 ns | 0.0298 ns | 0.0264 ns | 26.927 ns |  1.30 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_Int_Nullable_NoValue | .NET Core 2.0 | 12.323 ns | 0.0088 ns | 0.0082 ns | 12.323 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 2.2 | 10.264 ns | 0.0065 ns | 0.0058 ns | 10.265 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 3.0 |  9.559 ns | 0.0743 ns | 0.0695 ns |  9.585 ns |  0.78 |    0.01 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net461 | 12.747 ns | 0.0210 ns | 0.0196 ns | 12.745 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net472 | 12.734 ns | 0.0198 ns | 0.0185 ns | 12.730 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.415 ns | 0.0146 ns | 0.0129 ns | 15.417 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.520 ns | 0.0555 ns | 0.0492 ns | 13.539 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.937 ns | 0.2076 ns | 0.1840 ns | 13.926 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net461 | 22.048 ns | 0.0551 ns | 0.0515 ns | 22.048 ns |  1.43 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net472 | 22.636 ns | 0.0573 ns | 0.0508 ns | 22.630 ns |  1.47 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Long | .NET Core 2.0 | 11.849 ns | 0.0139 ns | 0.0123 ns | 11.848 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Long | .NET Core 2.2 | 10.637 ns | 0.0125 ns | 0.0111 ns | 10.635 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                             From_Long | .NET Core 3.0 |  9.843 ns | 0.0897 ns | 0.0839 ns |  9.879 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                                             From_Long |        net461 | 12.934 ns | 0.0097 ns | 0.0086 ns | 12.936 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                             From_Long |        net472 | 12.206 ns | 0.0172 ns | 0.0161 ns | 12.205 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Long_AsObject | .NET Core 2.0 | 19.929 ns | 0.0252 ns | 0.0224 ns | 19.935 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 2.2 | 17.859 ns | 0.0214 ns | 0.0200 ns | 17.859 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 3.0 | 19.335 ns | 0.2122 ns | 0.1985 ns | 19.289 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net461 | 26.642 ns | 0.0593 ns | 0.0526 ns | 26.618 ns |  1.34 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net472 | 29.119 ns | 0.0282 ns | 0.0250 ns | 29.119 ns |  1.46 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Long_Nullable_WithValue | .NET Core 2.0 | 12.727 ns | 0.0184 ns | 0.0172 ns | 12.727 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 2.2 | 12.286 ns | 0.0145 ns | 0.0136 ns | 12.285 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 3.0 | 10.566 ns | 0.1369 ns | 0.1280 ns | 10.587 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net461 | 15.159 ns | 0.0705 ns | 0.0625 ns | 15.187 ns |  1.19 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net472 | 15.042 ns | 0.0327 ns | 0.0306 ns | 15.044 ns |  1.18 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.777 ns | 0.0532 ns | 0.0472 ns | 20.789 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.2 | 18.066 ns | 0.0311 ns | 0.0260 ns | 18.053 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.435 ns | 0.1360 ns | 0.1062 ns | 18.477 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net461 | 26.556 ns | 0.0305 ns | 0.0270 ns | 26.561 ns |  1.28 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net472 | 27.243 ns | 0.0337 ns | 0.0299 ns | 27.236 ns |  1.31 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Long_Nullable_NoValue | .NET Core 2.0 | 12.569 ns | 0.0123 ns | 0.0115 ns | 12.571 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 2.2 | 11.411 ns | 0.0089 ns | 0.0074 ns | 11.412 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 3.0 | 10.008 ns | 0.0470 ns | 0.0440 ns | 10.001 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net461 | 13.307 ns | 0.0285 ns | 0.0267 ns | 13.311 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net472 | 15.023 ns | 0.0448 ns | 0.0419 ns | 15.029 ns |  1.20 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.405 ns | 0.0142 ns | 0.0132 ns | 15.405 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.390 ns | 0.0168 ns | 0.0140 ns | 13.393 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.402 ns | 0.1556 ns | 0.1455 ns | 13.354 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net461 | 22.060 ns | 0.0256 ns | 0.0227 ns | 22.059 ns |  1.43 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net472 | 24.148 ns | 0.0381 ns | 0.0356 ns | 24.145 ns |  1.57 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_SByte | .NET Core 2.0 | 11.910 ns | 0.0424 ns | 0.0396 ns | 11.920 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 2.2 | 10.379 ns | 0.0076 ns | 0.0067 ns | 10.378 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 3.0 |  9.903 ns | 0.1194 ns | 0.1117 ns |  9.917 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                                            From_SByte |        net461 | 12.476 ns | 0.0141 ns | 0.0118 ns | 12.476 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                            From_SByte |        net472 | 12.427 ns | 0.0175 ns | 0.0146 ns | 12.421 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_SByte_AsObject | .NET Core 2.0 | 19.909 ns | 0.0218 ns | 0.0204 ns | 19.910 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 2.2 | 17.884 ns | 0.0268 ns | 0.0250 ns | 17.883 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 3.0 | 17.400 ns | 0.0595 ns | 0.0464 ns | 17.398 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net461 | 28.565 ns | 0.0412 ns | 0.0386 ns | 28.555 ns |  1.43 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net472 | 27.191 ns | 0.0321 ns | 0.0300 ns | 27.183 ns |  1.37 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_SByte_Nullable_WithValue | .NET Core 2.0 | 12.031 ns | 0.0153 ns | 0.0136 ns | 12.032 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 2.2 | 10.639 ns | 0.0157 ns | 0.0147 ns | 10.638 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 3.0 | 10.077 ns | 0.0961 ns | 0.0899 ns | 10.041 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net461 | 12.744 ns | 0.0184 ns | 0.0172 ns | 12.746 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net472 | 12.720 ns | 0.0142 ns | 0.0133 ns | 12.722 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.627 ns | 0.0557 ns | 0.0521 ns | 20.638 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.2 | 19.382 ns | 0.0139 ns | 0.0123 ns | 19.379 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.732 ns | 0.1701 ns | 0.1591 ns | 18.712 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net461 | 26.738 ns | 0.0875 ns | 0.0775 ns | 26.766 ns |  1.30 |    0.01 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net472 | 28.894 ns | 0.0402 ns | 0.0356 ns | 28.897 ns |  1.40 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_SByte_Nullable_NoValue | .NET Core 2.0 | 11.813 ns | 0.0091 ns | 0.0085 ns | 11.810 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 2.2 | 10.839 ns | 0.0420 ns | 0.0372 ns | 10.847 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 3.0 |  9.941 ns | 0.0851 ns | 0.0796 ns |  9.918 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net461 | 12.742 ns | 0.0102 ns | 0.0095 ns | 12.742 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net472 | 12.731 ns | 0.0169 ns | 0.0158 ns | 12.731 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.0 | 16.343 ns | 0.0579 ns | 0.0542 ns | 16.328 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.399 ns | 0.0145 ns | 0.0129 ns | 13.402 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.433 ns | 0.1820 ns | 0.1703 ns | 14.427 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net461 | 23.899 ns | 0.0349 ns | 0.0292 ns | 23.901 ns |  1.46 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net472 | 22.338 ns | 0.0376 ns | 0.0352 ns | 22.338 ns |  1.37 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_Float | .NET Core 2.0 | 12.499 ns | 0.0523 ns | 0.0489 ns | 12.477 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 2.2 | 10.868 ns | 0.0225 ns | 0.0199 ns | 10.876 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 3.0 | 10.044 ns | 0.0575 ns | 0.0538 ns | 10.055 ns |  0.80 |    0.01 |      - |     - |     - |         - |
                                            From_Float |        net461 | 14.208 ns | 0.0291 ns | 0.0272 ns | 14.201 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                            From_Float |        net472 | 13.379 ns | 0.0301 ns | 0.0267 ns | 13.372 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_Float_AsObject | .NET Core 2.0 | 20.590 ns | 0.0219 ns | 0.0205 ns | 20.584 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 2.2 | 18.092 ns | 0.0797 ns | 0.0746 ns | 18.127 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 3.0 | 17.812 ns | 0.1356 ns | 0.1268 ns | 17.811 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                                   From_Float_AsObject |        net461 | 28.747 ns | 0.0440 ns | 0.0412 ns | 28.743 ns |  1.40 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject |        net472 | 27.113 ns | 0.0621 ns | 0.0581 ns | 27.126 ns |  1.32 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Float_Nullable_WithValue | .NET Core 2.0 | 12.549 ns | 0.0558 ns | 0.0522 ns | 12.523 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 2.2 | 11.758 ns | 0.0113 ns | 0.0105 ns | 11.760 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 3.0 | 10.350 ns | 0.1561 ns | 0.1460 ns | 10.349 ns |  0.82 |    0.01 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net461 | 13.421 ns | 0.0127 ns | 0.0119 ns | 13.423 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net472 | 13.633 ns | 0.1279 ns | 0.1197 ns | 13.622 ns |  1.09 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.952 ns | 0.0208 ns | 0.0194 ns | 19.954 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.934 ns | 0.0902 ns | 0.0844 ns | 17.965 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.141 ns | 0.1170 ns | 0.1094 ns | 18.117 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net461 | 27.357 ns | 0.0247 ns | 0.0219 ns | 27.350 ns |  1.37 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net472 | 26.957 ns | 0.0396 ns | 0.0309 ns | 26.964 ns |  1.35 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Float_Nullable_NoValue | .NET Core 2.0 | 12.038 ns | 0.0092 ns | 0.0082 ns | 12.036 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 2.2 | 10.449 ns | 0.0120 ns | 0.0101 ns | 10.446 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 3.0 | 10.065 ns | 0.1089 ns | 0.1018 ns | 10.051 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net461 | 13.538 ns | 0.0122 ns | 0.0108 ns | 13.540 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net472 | 13.095 ns | 0.0128 ns | 0.0113 ns | 13.093 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.321 ns | 0.0439 ns | 0.0390 ns | 15.331 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.974 ns | 0.0092 ns | 0.0076 ns | 13.972 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.464 ns | 0.1799 ns | 0.1682 ns | 13.442 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net461 | 22.198 ns | 0.0289 ns | 0.0271 ns | 22.198 ns |  1.45 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net472 | 22.524 ns | 0.1239 ns | 0.1159 ns | 22.573 ns |  1.47 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_String | .NET Core 2.0 | 28.203 ns | 0.0262 ns | 0.0232 ns | 28.200 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 2.2 | 32.766 ns | 0.1376 ns | 0.1287 ns | 32.675 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 3.0 | 26.359 ns | 0.1228 ns | 0.1089 ns | 26.356 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                           From_String |        net461 | 28.563 ns | 0.1289 ns | 0.1206 ns | 28.584 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                           From_String |        net472 | 28.357 ns | 0.0255 ns | 0.0213 ns | 28.351 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_String_AsObject | .NET Core 2.0 | 32.512 ns | 0.0390 ns | 0.0365 ns | 32.512 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 2.2 | 40.364 ns | 0.1208 ns | 0.1071 ns | 40.343 ns |  1.24 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 3.0 | 29.481 ns | 0.3221 ns | 0.2855 ns | 29.477 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                                  From_String_AsObject |        net461 | 37.861 ns | 0.0395 ns | 0.0330 ns | 37.855 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject |        net472 | 38.726 ns | 0.0540 ns | 0.0505 ns | 38.750 ns |  1.19 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                      From_String_Null | .NET Core 2.0 | 14.082 ns | 0.0172 ns | 0.0153 ns | 14.078 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 2.2 | 13.285 ns | 0.0124 ns | 0.0116 ns | 13.287 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 3.0 | 12.935 ns | 0.0660 ns | 0.0515 ns | 12.955 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null |        net461 | 14.557 ns | 0.0141 ns | 0.0132 ns | 14.556 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null |        net472 | 15.317 ns | 0.1342 ns | 0.1256 ns | 15.255 ns |  1.09 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_String_Null_AsObject | .NET Core 2.0 | 15.193 ns | 0.0153 ns | 0.0136 ns | 15.195 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 2.2 | 13.544 ns | 0.0758 ns | 0.0709 ns | 13.575 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 3.0 | 13.392 ns | 0.1503 ns | 0.1406 ns | 13.354 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net461 | 22.131 ns | 0.0227 ns | 0.0190 ns | 22.135 ns |  1.46 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net472 | 24.298 ns | 0.1502 ns | 0.1405 ns | 24.300 ns |  1.60 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_String_Empty | .NET Core 2.0 | 14.329 ns | 0.0119 ns | 0.0111 ns | 14.327 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 2.2 | 12.723 ns | 0.0502 ns | 0.0470 ns | 12.700 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 3.0 | 12.935 ns | 0.1199 ns | 0.1121 ns | 12.939 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                                     From_String_Empty |        net461 | 14.569 ns | 0.0237 ns | 0.0221 ns | 14.564 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty |        net472 | 15.096 ns | 0.0244 ns | 0.0228 ns | 15.092 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_String_Empty_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_UShort | .NET Core 2.0 | 11.841 ns | 0.0091 ns | 0.0085 ns | 11.843 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 2.2 | 10.461 ns | 0.0500 ns | 0.0468 ns | 10.466 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 3.0 |  9.804 ns | 0.0901 ns | 0.0843 ns |  9.797 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                                           From_UShort |        net461 | 14.632 ns | 0.0463 ns | 0.0433 ns | 14.643 ns |  1.24 |    0.00 |      - |     - |     - |         - |
                                           From_UShort |        net472 | 12.427 ns | 0.0273 ns | 0.0228 ns | 12.432 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_UShort_AsObject | .NET Core 2.0 | 20.479 ns | 0.0145 ns | 0.0113 ns | 20.480 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 2.2 | 18.032 ns | 0.0278 ns | 0.0246 ns | 18.034 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 3.0 | 18.645 ns | 0.2726 ns | 0.2550 ns | 18.629 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net461 | 26.734 ns | 0.0302 ns | 0.0282 ns | 26.732 ns |  1.31 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net472 | 28.816 ns | 0.0367 ns | 0.0307 ns | 28.819 ns |  1.41 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_UShort_Nullable_WithValue | .NET Core 2.0 | 12.057 ns | 0.0126 ns | 0.0111 ns | 12.058 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 2.2 | 11.283 ns | 0.0128 ns | 0.0114 ns | 11.286 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 3.0 | 10.445 ns | 0.1485 ns | 0.1390 ns | 10.415 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net461 | 12.836 ns | 0.0453 ns | 0.0423 ns | 12.852 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net472 | 12.727 ns | 0.0189 ns | 0.0177 ns | 12.722 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.806 ns | 0.0798 ns | 0.0746 ns | 20.826 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.2 | 18.270 ns | 0.0231 ns | 0.0205 ns | 18.270 ns |  0.88 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.521 ns | 0.2028 ns | 0.1897 ns | 17.526 ns |  0.84 |    0.01 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net461 | 28.726 ns | 0.0388 ns | 0.0324 ns | 28.719 ns |  1.38 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net472 | 28.822 ns | 0.0407 ns | 0.0380 ns | 28.816 ns |  1.39 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_UShort_Nullable_NoValue | .NET Core 2.0 | 11.911 ns | 0.0100 ns | 0.0083 ns | 11.908 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 2.2 | 10.283 ns | 0.0091 ns | 0.0085 ns | 10.280 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 3.0 |  9.882 ns | 0.0943 ns | 0.0882 ns |  9.893 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net461 | 12.961 ns | 0.0142 ns | 0.0126 ns | 12.959 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net472 | 12.755 ns | 0.0177 ns | 0.0157 ns | 12.755 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.508 ns | 0.0998 ns | 0.0934 ns | 15.448 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.425 ns | 0.0187 ns | 0.0175 ns | 13.423 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.608 ns | 0.5080 ns | 0.5217 ns | 13.357 ns |  0.88 |    0.04 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net461 | 22.055 ns | 0.0939 ns | 0.0878 ns | 22.023 ns |  1.42 |    0.01 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net472 | 24.079 ns | 0.0285 ns | 0.0252 ns | 24.083 ns |  1.55 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_UInt | .NET Core 2.0 | 11.957 ns | 0.0559 ns | 0.0523 ns | 11.962 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 2.2 | 10.388 ns | 0.0092 ns | 0.0077 ns | 10.388 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 3.0 |  9.855 ns | 0.1217 ns | 0.1138 ns |  9.849 ns |  0.82 |    0.01 |      - |     - |     - |         - |
                                             From_UInt |        net461 | 12.249 ns | 0.0358 ns | 0.0318 ns | 12.236 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                                             From_UInt |        net472 | 15.763 ns | 0.0189 ns | 0.0176 ns | 15.766 ns |  1.32 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_UInt_AsObject | .NET Core 2.0 | 20.507 ns | 0.0199 ns | 0.0166 ns | 20.509 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 2.2 | 17.756 ns | 0.0196 ns | 0.0173 ns | 17.756 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 3.0 | 17.851 ns | 0.1578 ns | 0.1476 ns | 17.875 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net461 | 26.828 ns | 0.0243 ns | 0.0227 ns | 26.826 ns |  1.31 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net472 | 28.948 ns | 0.0269 ns | 0.0252 ns | 28.950 ns |  1.41 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_UInt_Nullable_WithValue | .NET Core 2.0 | 12.092 ns | 0.0509 ns | 0.0425 ns | 12.073 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 2.2 | 10.665 ns | 0.0098 ns | 0.0087 ns | 10.665 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 3.0 | 10.219 ns | 0.0543 ns | 0.0508 ns | 10.228 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net461 | 13.487 ns | 0.0588 ns | 0.0550 ns | 13.465 ns |  1.12 |    0.01 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net472 | 12.699 ns | 0.0186 ns | 0.0174 ns | 12.701 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.965 ns | 0.0210 ns | 0.0196 ns | 19.959 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.2 | 18.243 ns | 0.0165 ns | 0.0147 ns | 18.245 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.664 ns | 0.2248 ns | 0.2102 ns | 17.614 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net461 | 26.705 ns | 0.0461 ns | 0.0408 ns | 26.700 ns |  1.34 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net472 | 26.911 ns | 0.0456 ns | 0.0426 ns | 26.906 ns |  1.35 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_UInt_Nullable_NoValue | .NET Core 2.0 | 11.839 ns | 0.0149 ns | 0.0125 ns | 11.839 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 2.2 | 10.285 ns | 0.0157 ns | 0.0147 ns | 10.283 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 3.0 | 11.279 ns | 0.0667 ns | 0.0624 ns | 11.261 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net461 | 12.727 ns | 0.0125 ns | 0.0111 ns | 12.729 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net472 | 12.748 ns | 0.0130 ns | 0.0121 ns | 12.754 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.787 ns | 0.0484 ns | 0.0452 ns | 14.770 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.429 ns | 0.0126 ns | 0.0111 ns | 13.429 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.299 ns | 0.0907 ns | 0.0757 ns | 14.288 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net461 | 21.815 ns | 0.0548 ns | 0.0512 ns | 21.819 ns |  1.48 |    0.01 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net472 | 24.179 ns | 0.0346 ns | 0.0307 ns | 24.175 ns |  1.63 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_ULong | .NET Core 2.0 | 12.679 ns | 0.0134 ns | 0.0125 ns | 12.679 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 2.2 | 10.381 ns | 0.0145 ns | 0.0129 ns | 10.379 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 3.0 |  9.796 ns | 0.0621 ns | 0.0581 ns |  9.792 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                                            From_ULong |        net461 | 13.312 ns | 0.0389 ns | 0.0364 ns | 13.316 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                            From_ULong |        net472 | 12.348 ns | 0.0549 ns | 0.0487 ns | 12.357 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_ULong_AsObject | .NET Core 2.0 | 20.228 ns | 0.0813 ns | 0.0761 ns | 20.199 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 2.2 | 18.359 ns | 0.1071 ns | 0.1002 ns | 18.415 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 3.0 | 18.349 ns | 0.2164 ns | 0.2024 ns | 18.288 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net461 | 26.463 ns | 0.0241 ns | 0.0226 ns | 26.461 ns |  1.31 |    0.01 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net472 | 26.919 ns | 0.0241 ns | 0.0213 ns | 26.913 ns |  1.33 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_ULong_Nullable_WithValue | .NET Core 2.0 | 13.377 ns | 0.0854 ns | 0.0799 ns | 13.339 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 2.2 | 11.509 ns | 0.0602 ns | 0.0563 ns | 11.475 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 3.0 | 10.497 ns | 0.0842 ns | 0.0788 ns | 10.492 ns |  0.78 |    0.01 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net461 | 13.653 ns | 0.0261 ns | 0.0244 ns | 13.653 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net472 | 13.885 ns | 0.0215 ns | 0.0201 ns | 13.888 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.424 ns | 0.0261 ns | 0.0204 ns | 20.430 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.783 ns | 0.0177 ns | 0.0166 ns | 17.781 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.631 ns | 0.1400 ns | 0.1169 ns | 17.644 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net461 | 28.862 ns | 0.0531 ns | 0.0497 ns | 28.850 ns |  1.41 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net472 | 27.398 ns | 0.0662 ns | 0.0620 ns | 27.414 ns |  1.34 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_ULong_Nullable_NoValue | .NET Core 2.0 | 12.608 ns | 0.0211 ns | 0.0197 ns | 12.607 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 2.2 | 11.911 ns | 0.0098 ns | 0.0091 ns | 11.911 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 3.0 |  9.847 ns | 0.0728 ns | 0.0645 ns |  9.830 ns |  0.78 |    0.01 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net461 | 14.009 ns | 0.0217 ns | 0.0203 ns | 14.004 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net472 | 13.308 ns | 0.0242 ns | 0.0214 ns | 13.307 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.800 ns | 0.0457 ns | 0.0405 ns | 14.795 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.053 ns | 0.0098 ns | 0.0082 ns | 14.052 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.300 ns | 0.0702 ns | 0.0622 ns | 13.307 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net461 | 22.016 ns | 0.0252 ns | 0.0236 ns | 22.019 ns |  1.49 |    0.01 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net472 | 21.818 ns | 0.0338 ns | 0.0264 ns | 21.816 ns |  1.47 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                       From_NullObject | .NET Core 2.0 | 15.397 ns | 0.0281 ns | 0.0263 ns | 15.387 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 2.2 | 15.489 ns | 0.0100 ns | 0.0088 ns | 15.491 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 3.0 | 14.779 ns | 0.1722 ns | 0.1611 ns | 14.784 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                                       From_NullObject |        net461 | 22.120 ns | 0.1397 ns | 0.1307 ns | 22.139 ns |  1.44 |    0.01 |      - |     - |     - |         - |
                                       From_NullObject |        net472 | 22.215 ns | 0.0252 ns | 0.0236 ns | 22.219 ns |  1.44 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_DBNull | .NET Core 2.0 | 12.486 ns | 0.0176 ns | 0.0156 ns | 12.489 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 2.2 | 11.668 ns | 0.0832 ns | 0.0778 ns | 11.658 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 3.0 | 12.782 ns | 0.1332 ns | 0.1246 ns | 12.752 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                                           From_DBNull |        net461 | 13.000 ns | 0.0145 ns | 0.0136 ns | 12.996 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull |        net472 | 12.934 ns | 0.0139 ns | 0.0130 ns | 12.932 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_DBNull_AsObject | .NET Core 2.0 | 14.901 ns | 0.0371 ns | 0.0347 ns | 14.883 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 2.2 | 13.427 ns | 0.0096 ns | 0.0090 ns | 13.426 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 3.0 | 14.458 ns | 0.3135 ns | 0.5324 ns | 14.663 ns |  0.95 |    0.05 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net461 | 22.016 ns | 0.0205 ns | 0.0192 ns | 22.017 ns |  1.48 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net472 | 22.420 ns | 0.0198 ns | 0.0176 ns | 22.421 ns |  1.51 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                 From_ConvertibleClass | .NET Core 2.0 | 18.738 ns | 0.1032 ns | 0.0965 ns | 18.705 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 2.2 | 14.740 ns | 0.0534 ns | 0.0500 ns | 14.749 ns |  0.79 |    0.01 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 3.0 | 15.281 ns | 0.1673 ns | 0.1565 ns | 15.292 ns |  0.82 |    0.01 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net461 | 26.629 ns | 0.1032 ns | 0.0914 ns | 26.650 ns |  1.42 |    0.01 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net472 | 25.124 ns | 0.0300 ns | 0.0281 ns | 25.126 ns |  1.34 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_ConvertibleClass_AsObject | .NET Core 2.0 | 18.714 ns | 0.0307 ns | 0.0256 ns | 18.713 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 2.2 | 17.314 ns | 0.0223 ns | 0.0198 ns | 17.310 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 3.0 | 17.221 ns | 0.2757 ns | 0.2579 ns | 17.237 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net461 | 27.287 ns | 0.0449 ns | 0.0398 ns | 27.284 ns |  1.46 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net472 | 28.674 ns | 0.0572 ns | 0.0535 ns | 28.656 ns |  1.53 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_ConvertibleClass_NoValue | .NET Core 2.0 | 15.453 ns | 0.0182 ns | 0.0162 ns | 15.451 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 2.2 | 12.922 ns | 0.0142 ns | 0.0133 ns | 12.921 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 3.0 | 13.312 ns | 0.1196 ns | 0.1119 ns | 13.318 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net461 | 23.875 ns | 0.0383 ns | 0.0358 ns | 23.871 ns |  1.55 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net472 | 23.158 ns | 0.0342 ns | 0.0320 ns | 23.148 ns |  1.50 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.0 | 14.747 ns | 0.0173 ns | 0.0145 ns | 14.746 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.2 | 13.551 ns | 0.0634 ns | 0.0593 ns | 13.573 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 3.0 | 13.833 ns | 0.1111 ns | 0.0985 ns | 13.810 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net461 | 22.632 ns | 0.0273 ns | 0.0256 ns | 22.631 ns |  1.53 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net472 | 22.393 ns | 0.0348 ns | 0.0326 ns | 22.396 ns |  1.52 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                              From_NonConvertibleClass | .NET Core 2.0 | 13.800 ns | 0.0143 ns | 0.0119 ns | 13.805 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 2.2 | 12.233 ns | 0.0096 ns | 0.0090 ns | 12.233 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 3.0 | 12.749 ns | 0.1101 ns | 0.1030 ns | 12.744 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net461 | 14.972 ns | 0.0178 ns | 0.0166 ns | 14.972 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net472 | 14.997 ns | 0.0190 ns | 0.0178 ns | 14.997 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                     From_NonConvertibleClass_AsObject | .NET Core 2.0 | 16.556 ns | 0.0162 ns | 0.0144 ns | 16.556 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 2.2 | 15.272 ns | 0.0209 ns | 0.0195 ns | 15.270 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 3.0 | 15.564 ns | 0.0913 ns | 0.0854 ns | 15.588 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net461 | 25.205 ns | 0.0512 ns | 0.0479 ns | 25.215 ns |  1.52 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net472 | 23.910 ns | 0.1122 ns | 0.1050 ns | 23.962 ns |  1.44 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                      From_NonConvertibleClass_NoValue | .NET Core 2.0 | 14.050 ns | 0.0133 ns | 0.0118 ns | 14.050 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 2.2 | 12.229 ns | 0.0146 ns | 0.0136 ns | 12.229 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 3.0 | 12.685 ns | 0.1485 ns | 0.1389 ns | 12.715 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net461 | 14.966 ns | 0.0146 ns | 0.0129 ns | 14.965 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net472 | 14.341 ns | 0.0679 ns | 0.0635 ns | 14.306 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.0 | 15.399 ns | 0.0183 ns | 0.0152 ns | 15.402 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.2 | 13.548 ns | 0.0815 ns | 0.0762 ns | 13.537 ns |  0.88 |    0.01 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 3.0 | 14.236 ns | 0.1836 ns | 0.1717 ns | 14.261 ns |  0.93 |    0.01 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net461 | 21.101 ns | 0.0393 ns | 0.0368 ns | 21.096 ns |  1.37 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net472 | 22.363 ns | 0.0405 ns | 0.0379 ns | 22.366 ns |  1.45 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                From_ConvertibleStruct | .NET Core 2.0 | 20.023 ns | 0.0745 ns | 0.0697 ns | 20.005 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 2.2 | 15.966 ns | 0.0395 ns | 0.0350 ns | 15.969 ns |  0.80 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 3.0 | 13.777 ns | 0.1376 ns | 0.1287 ns | 13.730 ns |  0.69 |    0.01 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net461 | 18.512 ns | 0.0769 ns | 0.0719 ns | 18.503 ns |  0.92 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net472 | 19.122 ns | 0.1485 ns | 0.1389 ns | 19.067 ns |  0.96 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                       From_ConvertibleStruct_AsObject | .NET Core 2.0 | 19.361 ns | 0.0324 ns | 0.0271 ns | 19.363 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 2.2 | 17.530 ns | 0.0295 ns | 0.0276 ns | 17.537 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 3.0 | 18.043 ns | 0.1863 ns | 0.1742 ns | 18.078 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net461 | 28.131 ns | 0.1723 ns | 0.1611 ns | 28.027 ns |  1.45 |    0.01 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net472 | 26.712 ns | 0.0317 ns | 0.0296 ns | 26.710 ns |  1.38 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.0 | 19.805 ns | 0.0627 ns | 0.0555 ns | 19.788 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.2 | 16.177 ns | 0.0331 ns | 0.0294 ns | 16.181 ns |  0.82 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 3.0 | 14.474 ns | 0.1161 ns | 0.1086 ns | 14.514 ns |  0.73 |    0.01 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net461 | 23.907 ns | 0.0493 ns | 0.0412 ns | 23.919 ns |  1.21 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net472 | 24.314 ns | 0.0274 ns | 0.0256 ns | 24.318 ns |  1.23 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.626 ns | 0.0467 ns | 0.0390 ns | 19.634 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.491 ns | 0.0255 ns | 0.0239 ns | 17.487 ns |  0.89 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.666 ns | 0.1602 ns | 0.1498 ns | 17.592 ns |  0.90 |    0.01 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net461 | 26.033 ns | 0.0479 ns | 0.0448 ns | 26.035 ns |  1.33 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net472 | 26.837 ns | 0.0748 ns | 0.0663 ns | 26.860 ns |  1.37 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.0 | 13.816 ns | 0.0150 ns | 0.0133 ns | 13.816 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.2 | 12.071 ns | 0.0527 ns | 0.0493 ns | 12.085 ns |  0.87 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 3.0 | 10.157 ns | 0.0152 ns | 0.0143 ns | 10.157 ns |  0.74 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net461 | 19.292 ns | 0.0684 ns | 0.0640 ns | 19.308 ns |  1.40 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net472 | 19.053 ns | 0.0287 ns | 0.0254 ns | 19.045 ns |  1.38 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.406 ns | 0.0261 ns | 0.0244 ns | 15.410 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.416 ns | 0.0123 ns | 0.0109 ns | 13.412 ns |  0.87 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.282 ns | 0.0361 ns | 0.0338 ns | 13.288 ns |  0.86 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net461 | 22.161 ns | 0.0354 ns | 0.0296 ns | 22.158 ns |  1.44 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net472 | 25.161 ns | 0.0201 ns | 0.0188 ns | 25.161 ns |  1.63 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_NonConvertibleStruct | .NET Core 2.0 | 13.249 ns | 0.0550 ns | 0.0488 ns | 13.262 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 2.2 | 10.778 ns | 0.0100 ns | 0.0089 ns | 10.777 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 3.0 |  9.201 ns | 0.0156 ns | 0.0138 ns |  9.201 ns |  0.69 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net461 | 12.241 ns | 0.0167 ns | 0.0148 ns | 12.240 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net472 | 13.041 ns | 0.0796 ns | 0.0745 ns | 13.068 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.0 | 17.291 ns | 0.0234 ns | 0.0219 ns | 17.296 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.2 | 16.015 ns | 0.0865 ns | 0.0809 ns | 16.047 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 3.0 | 15.867 ns | 0.3428 ns | 0.5728 ns | 15.489 ns |  0.95 |    0.03 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net461 | 25.199 ns | 0.1203 ns | 0.1126 ns | 25.235 ns |  1.46 |    0.01 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net472 | 23.749 ns | 0.0252 ns | 0.0236 ns | 23.748 ns |  1.37 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.0 | 14.875 ns | 0.0194 ns | 0.0172 ns | 14.877 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.2 | 10.055 ns | 0.0105 ns | 0.0093 ns | 10.055 ns |  0.68 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 3.0 |  9.267 ns | 0.0336 ns | 0.0281 ns |  9.273 ns |  0.62 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net461 | 12.257 ns | 0.0310 ns | 0.0290 ns | 12.251 ns |  0.82 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net472 | 12.919 ns | 0.0117 ns | 0.0091 ns | 12.919 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 17.440 ns | 0.0630 ns | 0.0558 ns | 17.447 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.262 ns | 0.0190 ns | 0.0178 ns | 15.259 ns |  0.88 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 14.989 ns | 0.0340 ns | 0.0318 ns | 14.985 ns |  0.86 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net461 | 23.521 ns | 0.0449 ns | 0.0420 ns | 23.520 ns |  1.35 |    0.01 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net472 | 23.922 ns | 0.0692 ns | 0.0647 ns | 23.927 ns |  1.37 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.0 | 11.806 ns | 0.0100 ns | 0.0088 ns | 11.808 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.2 | 10.069 ns | 0.0117 ns | 0.0104 ns | 10.067 ns |  0.85 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 3.0 |  9.210 ns | 0.0105 ns | 0.0088 ns |  9.211 ns |  0.78 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net461 | 12.341 ns | 0.0689 ns | 0.0644 ns | 12.367 ns |  1.05 |    0.01 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net472 | 13.032 ns | 0.0103 ns | 0.0086 ns | 13.034 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.846 ns | 0.0204 ns | 0.0191 ns | 14.845 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.412 ns | 0.0095 ns | 0.0079 ns | 13.410 ns |  0.90 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.293 ns | 0.0157 ns | 0.0139 ns | 13.293 ns |  0.90 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net461 | 22.143 ns | 0.0456 ns | 0.0427 ns | 22.133 ns |  1.49 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net472 | 22.444 ns | 0.0211 ns | 0.0187 ns | 22.448 ns |  1.51 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Enum | .NET Core 2.0 | 11.841 ns | 0.0161 ns | 0.0150 ns | 11.841 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 2.2 | 10.484 ns | 0.0141 ns | 0.0132 ns | 10.481 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 3.0 |  9.454 ns | 0.0152 ns | 0.0135 ns |  9.455 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                             From_Enum |        net461 | 12.226 ns | 0.0206 ns | 0.0193 ns | 12.224 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                             From_Enum |        net472 | 12.335 ns | 0.0161 ns | 0.0143 ns | 12.331 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Enum_AsObject | .NET Core 2.0 | 48.616 ns | 0.1538 ns | 0.1439 ns | 48.555 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject | .NET Core 2.2 | 42.569 ns | 0.1268 ns | 0.1124 ns | 42.553 ns |  0.88 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject | .NET Core 3.0 | 37.798 ns | 0.7659 ns | 1.0984 ns | 37.272 ns |  0.80 |    0.02 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject |        net461 | 55.174 ns | 1.3253 ns | 3.9075 ns | 51.861 ns |  1.19 |    0.07 | 0.0037 |     - |     - |      24 B |
                                    From_Enum_AsObject |        net472 | 50.772 ns | 0.0760 ns | 0.0635 ns | 50.795 ns |  1.04 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Enum_Nullable_WithValue | .NET Core 2.0 | 12.057 ns | 0.0221 ns | 0.0185 ns | 12.065 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 2.2 | 11.716 ns | 0.0155 ns | 0.0145 ns | 11.713 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 3.0 | 10.203 ns | 0.2258 ns | 0.2688 ns | 10.416 ns |  0.83 |    0.02 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net461 | 13.365 ns | 0.0128 ns | 0.0114 ns | 13.359 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net472 | 12.711 ns | 0.0122 ns | 0.0108 ns | 12.713 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.0 | 46.159 ns | 0.0615 ns | 0.0576 ns | 46.144 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.2 | 42.814 ns | 0.1547 ns | 0.1372 ns | 42.837 ns |  0.93 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 3.0 | 40.761 ns | 0.6000 ns | 0.5612 ns | 40.379 ns |  0.88 |    0.01 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject |        net461 | 49.655 ns | 0.1467 ns | 0.1373 ns | 49.624 ns |  1.08 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject |        net472 | 54.434 ns | 0.0749 ns | 0.0664 ns | 54.425 ns |  1.18 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Enum_Nullable_NoValue | .NET Core 2.0 | 13.255 ns | 0.0656 ns | 0.0613 ns | 13.280 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 2.2 | 11.271 ns | 0.0227 ns | 0.0212 ns | 11.261 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 3.0 |  9.885 ns | 0.0217 ns | 0.0192 ns |  9.879 ns |  0.75 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net461 | 13.197 ns | 0.0316 ns | 0.0296 ns | 13.207 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net472 | 12.742 ns | 0.0145 ns | 0.0121 ns | 12.741 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.0 | 20.063 ns | 0.0178 ns | 0.0158 ns | 20.066 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.806 ns | 0.0126 ns | 0.0118 ns | 13.804 ns |  0.69 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.686 ns | 0.0765 ns | 0.0716 ns | 13.693 ns |  0.68 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net461 | 23.868 ns | 0.0250 ns | 0.0234 ns | 23.872 ns |  1.19 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net472 | 22.546 ns | 0.0555 ns | 0.0492 ns | 22.550 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                      From_ParentClass | .NET Core 2.0 | 14.080 ns | 0.0148 ns | 0.0131 ns | 14.082 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 2.2 | 12.365 ns | 0.0076 ns | 0.0071 ns | 12.365 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 3.0 | 12.422 ns | 0.0177 ns | 0.0157 ns | 12.422 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass |        net461 | 14.978 ns | 0.0179 ns | 0.0167 ns | 14.979 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass |        net472 | 14.988 ns | 0.0255 ns | 0.0238 ns | 14.997 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_ParentClass_AsObject | .NET Core 2.0 | 17.174 ns | 0.0302 ns | 0.0235 ns | 17.179 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 2.2 | 15.802 ns | 0.0170 ns | 0.0159 ns | 15.801 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 3.0 | 16.038 ns | 0.0617 ns | 0.0577 ns | 16.063 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net461 | 27.559 ns | 0.1591 ns | 0.1488 ns | 27.633 ns |  1.60 |    0.01 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net472 | 24.203 ns | 0.0454 ns | 0.0403 ns | 24.195 ns |  1.41 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                              From_ParentClass_NoValue | .NET Core 2.0 | 14.061 ns | 0.0164 ns | 0.0153 ns | 14.064 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 2.2 | 12.214 ns | 0.0160 ns | 0.0141 ns | 12.217 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 3.0 | 12.412 ns | 0.0179 ns | 0.0159 ns | 12.410 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net461 | 14.962 ns | 0.0248 ns | 0.0232 ns | 14.962 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net472 | 14.281 ns | 0.0122 ns | 0.0114 ns | 14.280 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.0 | 14.803 ns | 0.0209 ns | 0.0174 ns | 14.795 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.2 | 13.524 ns | 0.0739 ns | 0.0691 ns | 13.564 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 3.0 | 13.132 ns | 0.0160 ns | 0.0142 ns | 13.136 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net461 | 21.241 ns | 0.0447 ns | 0.0418 ns | 21.250 ns |  1.43 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net472 | 22.559 ns | 0.0118 ns | 0.0098 ns | 22.557 ns |  1.52 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_ParentStruct | .NET Core 2.0 | 42.305 ns | 0.0142 ns | 0.0126 ns | 42.309 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 2.2 | 38.646 ns | 0.0693 ns | 0.0649 ns | 38.650 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 3.0 | 41.090 ns | 0.6152 ns | 0.5755 ns | 41.338 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                                     From_ParentStruct |        net461 | 46.079 ns | 0.0503 ns | 0.0470 ns | 46.071 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct |        net472 | 41.776 ns | 0.0858 ns | 0.0803 ns | 41.747 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_ParentStruct_AsObject | .NET Core 2.0 | 18.691 ns | 0.0215 ns | 0.0201 ns | 18.690 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 2.2 | 15.725 ns | 0.0196 ns | 0.0183 ns | 15.723 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 3.0 | 15.958 ns | 0.0298 ns | 0.0279 ns | 15.953 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net461 | 23.691 ns | 0.0464 ns | 0.0434 ns | 23.685 ns |  1.27 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net472 | 24.201 ns | 0.0633 ns | 0.0592 ns | 24.210 ns |  1.29 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.0 | 41.047 ns | 0.0641 ns | 0.0568 ns | 41.045 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.2 | 39.061 ns | 0.1645 ns | 0.1458 ns | 39.067 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 3.0 | 39.096 ns | 0.1127 ns | 0.0941 ns | 39.061 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue |        net461 | 42.057 ns | 0.0475 ns | 0.0421 ns | 42.052 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue |        net472 | 41.508 ns | 0.2057 ns | 0.1823 ns | 41.571 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 17.157 ns | 0.0272 ns | 0.0254 ns | 17.150 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.702 ns | 0.0218 ns | 0.0194 ns | 15.709 ns |  0.92 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 16.164 ns | 0.2034 ns | 0.1903 ns | 16.038 ns |  0.94 |    0.01 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net461 | 23.567 ns | 0.0335 ns | 0.0297 ns | 23.564 ns |  1.37 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net472 | 25.691 ns | 0.0524 ns | 0.0490 ns | 25.699 ns |  1.50 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.0 | 46.510 ns | 0.0294 ns | 0.0275 ns | 46.513 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.2 | 40.612 ns | 0.0519 ns | 0.0486 ns | 40.613 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 3.0 | 40.619 ns | 0.5932 ns | 0.5549 ns | 40.890 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net461 | 40.673 ns | 0.0841 ns | 0.0787 ns | 40.657 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net472 | 42.911 ns | 0.0559 ns | 0.0523 ns | 42.904 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.884 ns | 0.0112 ns | 0.0104 ns | 14.882 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.940 ns | 0.0204 ns | 0.0191 ns | 13.944 ns |  0.94 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.175 ns | 0.0155 ns | 0.0145 ns | 13.174 ns |  0.89 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net461 | 22.102 ns | 0.0259 ns | 0.0243 ns | 22.107 ns |  1.48 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net472 | 22.429 ns | 0.0416 ns | 0.0368 ns | 22.428 ns |  1.51 |    0.00 |      - |     - |     - |         - |

Benchmarks with issues:
  ConvertTo_BoolNullable.From_Char_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_BoolNullable.From_Char_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_BoolNullable.From_Char_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_BoolNullable.From_Char_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_BoolNullable.From_Char_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_BoolNullable.From_Char_Nullable_WithValue_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_BoolNullable.From_Char_Nullable_WithValue_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_BoolNullable.From_Char_Nullable_WithValue_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_BoolNullable.From_Char_Nullable_WithValue_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_BoolNullable.From_Char_Nullable_WithValue_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_BoolNullable.From_DateTime_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_BoolNullable.From_DateTime_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_BoolNullable.From_DateTime_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_BoolNullable.From_DateTime_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_BoolNullable.From_DateTime_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_BoolNullable.From_DateTime_Nullable_WithValue_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_BoolNullable.From_DateTime_Nullable_WithValue_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_BoolNullable.From_DateTime_Nullable_WithValue_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_BoolNullable.From_DateTime_Nullable_WithValue_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_BoolNullable.From_DateTime_Nullable_WithValue_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_BoolNullable.From_String_Empty_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_BoolNullable.From_String_Empty_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_BoolNullable.From_String_Empty_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_BoolNullable.From_String_Empty_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_BoolNullable.From_String_Empty_AsObject: Job-PJAXXB(Toolchain=net472)
