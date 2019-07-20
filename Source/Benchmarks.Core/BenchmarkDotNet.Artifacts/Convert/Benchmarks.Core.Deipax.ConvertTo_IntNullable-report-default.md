
BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.615 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-XBZJXS : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), 64bit RyuJIT
  Job-RPHYXP : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-WPBXUQ : .NET Core 3.0.0-preview6-27804-01 (CoreCLR 4.700.19.30373, CoreFX 4.700.19.30308), 64bit RyuJIT
  Job-EJFWSE : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0
  Job-ZVTGBZ : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0


                                                Method |     Toolchain |      Mean |     Error |    StdDev |    Median | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------------------------------------------ |-------------- |----------:|----------:|----------:|----------:|------:|--------:|-------:|------:|------:|----------:|
                                             From_Bool | .NET Core 2.0 | 13.164 ns | 0.0088 ns | 0.0083 ns | 13.163 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 2.2 | 10.456 ns | 0.0148 ns | 0.0138 ns | 10.454 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 3.0 |  9.626 ns | 0.0100 ns | 0.0094 ns |  9.625 ns |  0.73 |    0.00 |      - |     - |     - |         - |
                                             From_Bool |        net461 | 12.967 ns | 0.0166 ns | 0.0147 ns | 12.965 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                             From_Bool |        net472 | 12.226 ns | 0.0207 ns | 0.0194 ns | 12.225 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Bool_AsObject | .NET Core 2.0 | 19.259 ns | 0.0287 ns | 0.0254 ns | 19.265 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 2.2 | 18.082 ns | 0.0186 ns | 0.0174 ns | 18.080 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 3.0 | 17.650 ns | 0.0233 ns | 0.0206 ns | 17.652 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net461 | 30.624 ns | 0.0755 ns | 0.0707 ns | 30.636 ns |  1.59 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net472 | 29.867 ns | 0.0458 ns | 0.0428 ns | 29.867 ns |  1.55 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Bool_Nullable_WithValue | .NET Core 2.0 | 12.180 ns | 0.0359 ns | 0.0336 ns | 12.190 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 2.2 | 10.660 ns | 0.0136 ns | 0.0127 ns | 10.663 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 3.0 |  9.999 ns | 0.0628 ns | 0.0588 ns | 10.024 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net461 | 14.237 ns | 0.0535 ns | 0.0447 ns | 14.233 ns |  1.17 |    0.01 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net472 | 12.730 ns | 0.0137 ns | 0.0128 ns | 12.731 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.960 ns | 0.0213 ns | 0.0199 ns | 18.960 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.2 | 18.239 ns | 0.0295 ns | 0.0261 ns | 18.237 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 3.0 | 19.686 ns | 0.0205 ns | 0.0192 ns | 19.682 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net461 | 31.452 ns | 0.1540 ns | 0.1441 ns | 31.364 ns |  1.66 |    0.01 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net472 | 29.085 ns | 0.0407 ns | 0.0381 ns | 29.073 ns |  1.53 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Bool_Nullable_NoValue | .NET Core 2.0 | 11.855 ns | 0.0126 ns | 0.0098 ns | 11.854 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 2.2 | 10.345 ns | 0.0644 ns | 0.0603 ns | 10.369 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 3.0 |  9.670 ns | 0.0095 ns | 0.0074 ns |  9.672 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net461 | 14.105 ns | 0.0336 ns | 0.0298 ns | 14.102 ns |  1.19 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net472 | 12.767 ns | 0.0168 ns | 0.0157 ns | 12.770 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.486 ns | 0.0087 ns | 0.0077 ns | 15.486 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.923 ns | 0.0159 ns | 0.0148 ns | 12.918 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.516 ns | 0.1454 ns | 0.1360 ns | 13.583 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net461 | 23.080 ns | 0.0488 ns | 0.0457 ns | 23.093 ns |  1.49 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net472 | 25.968 ns | 0.0906 ns | 0.0848 ns | 25.969 ns |  1.68 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Byte | .NET Core 2.0 | 11.855 ns | 0.0146 ns | 0.0137 ns | 11.852 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 2.2 | 10.411 ns | 0.0156 ns | 0.0138 ns | 10.408 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 3.0 |  9.861 ns | 0.0227 ns | 0.0212 ns |  9.857 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                             From_Byte |        net461 | 13.069 ns | 0.0195 ns | 0.0172 ns | 13.068 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                             From_Byte |        net472 | 12.265 ns | 0.0142 ns | 0.0133 ns | 12.262 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Byte_AsObject | .NET Core 2.0 | 20.208 ns | 0.0938 ns | 0.0877 ns | 20.211 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 2.2 | 17.087 ns | 0.0182 ns | 0.0170 ns | 17.088 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 3.0 | 18.272 ns | 0.3840 ns | 0.3944 ns | 18.119 ns |  0.90 |    0.02 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net461 | 26.974 ns | 0.0194 ns | 0.0172 ns | 26.977 ns |  1.33 |    0.01 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net472 | 30.247 ns | 0.0442 ns | 0.0392 ns | 30.246 ns |  1.50 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Byte_Nullable_WithValue | .NET Core 2.0 | 11.863 ns | 0.0218 ns | 0.0204 ns | 11.856 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 2.2 | 10.659 ns | 0.0148 ns | 0.0138 ns | 10.662 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 3.0 | 10.556 ns | 0.1118 ns | 0.1046 ns | 10.572 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net461 | 13.535 ns | 0.0832 ns | 0.0778 ns | 13.492 ns |  1.14 |    0.01 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net472 | 12.761 ns | 0.0132 ns | 0.0117 ns | 12.758 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.695 ns | 0.1057 ns | 0.0937 ns | 19.697 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.716 ns | 0.0969 ns | 0.0906 ns | 17.670 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.880 ns | 0.0579 ns | 0.0542 ns | 17.858 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net461 | 30.651 ns | 0.0443 ns | 0.0415 ns | 30.637 ns |  1.56 |    0.01 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net472 | 30.260 ns | 0.0554 ns | 0.0463 ns | 30.240 ns |  1.54 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Byte_Nullable_NoValue | .NET Core 2.0 | 11.901 ns | 0.0260 ns | 0.0243 ns | 11.901 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 2.2 | 10.245 ns | 0.0092 ns | 0.0086 ns | 10.242 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 3.0 |  9.764 ns | 0.0451 ns | 0.0422 ns |  9.777 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net461 | 13.517 ns | 0.0627 ns | 0.0587 ns | 13.543 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net472 | 13.640 ns | 0.0192 ns | 0.0171 ns | 13.643 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.417 ns | 0.0162 ns | 0.0151 ns | 15.421 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.912 ns | 0.0290 ns | 0.0242 ns | 12.903 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 3.0 | 16.536 ns | 0.0945 ns | 0.0789 ns | 16.501 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net461 | 23.319 ns | 0.0300 ns | 0.0251 ns | 23.319 ns |  1.51 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net472 | 26.573 ns | 0.0760 ns | 0.0674 ns | 26.573 ns |  1.72 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Char | .NET Core 2.0 | 11.889 ns | 0.0603 ns | 0.0564 ns | 11.858 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Char | .NET Core 2.2 | 10.581 ns | 0.0084 ns | 0.0074 ns | 10.582 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                             From_Char | .NET Core 3.0 |  9.864 ns | 0.0192 ns | 0.0171 ns |  9.859 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                             From_Char |        net461 | 13.648 ns | 0.0194 ns | 0.0181 ns | 13.644 ns |  1.15 |    0.01 |      - |     - |     - |         - |
                                             From_Char |        net472 | 12.936 ns | 0.0160 ns | 0.0142 ns | 12.936 ns |  1.09 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Char_AsObject | .NET Core 2.0 | 21.025 ns | 0.0348 ns | 0.0326 ns | 21.024 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 2.2 | 17.520 ns | 0.0155 ns | 0.0138 ns | 17.519 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 3.0 | 17.444 ns | 0.0304 ns | 0.0254 ns | 17.439 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject |        net461 | 26.904 ns | 0.0598 ns | 0.0559 ns | 26.913 ns |  1.28 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject |        net472 | 29.602 ns | 0.0579 ns | 0.0513 ns | 29.599 ns |  1.41 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Char_Nullable_WithValue | .NET Core 2.0 | 12.527 ns | 0.0160 ns | 0.0142 ns | 12.528 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 2.2 | 10.766 ns | 0.0146 ns | 0.0136 ns | 10.766 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 3.0 | 10.231 ns | 0.0440 ns | 0.0390 ns | 10.242 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net461 | 14.170 ns | 0.0244 ns | 0.0204 ns | 14.174 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net472 | 12.775 ns | 0.0181 ns | 0.0169 ns | 12.774 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.745 ns | 0.0614 ns | 0.0544 ns | 19.754 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.933 ns | 0.0285 ns | 0.0253 ns | 17.923 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.667 ns | 0.0821 ns | 0.0768 ns | 17.634 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net461 | 27.216 ns | 0.0405 ns | 0.0359 ns | 27.221 ns |  1.38 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net472 | 28.830 ns | 0.0504 ns | 0.0471 ns | 28.838 ns |  1.46 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Char_Nullable_NoValue | .NET Core 2.0 | 12.259 ns | 0.0099 ns | 0.0087 ns | 12.259 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 2.2 | 10.248 ns | 0.0207 ns | 0.0173 ns | 10.246 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 3.0 |  9.679 ns | 0.0077 ns | 0.0068 ns |  9.679 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net461 | 14.103 ns | 0.0413 ns | 0.0387 ns | 14.090 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net472 | 12.775 ns | 0.0158 ns | 0.0148 ns | 12.778 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.790 ns | 0.0189 ns | 0.0168 ns | 14.793 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.936 ns | 0.0259 ns | 0.0230 ns | 12.929 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.637 ns | 0.0235 ns | 0.0220 ns | 14.628 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net461 | 23.161 ns | 0.1052 ns | 0.0984 ns | 23.124 ns |  1.57 |    0.01 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net472 | 25.734 ns | 0.0318 ns | 0.0282 ns | 25.728 ns |  1.74 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                         From_DateTime | .NET Core 2.0 | 12.245 ns | 0.0194 ns | 0.0182 ns | 12.243 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 2.2 | 11.255 ns | 0.0436 ns | 0.0364 ns | 11.263 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 3.0 |  9.884 ns | 0.0148 ns | 0.0123 ns |  9.880 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime |        net461 | 13.829 ns | 0.0171 ns | 0.0151 ns | 13.829 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime |        net472 | 13.019 ns | 0.0235 ns | 0.0208 ns | 13.015 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                From_DateTime_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                      From_DateTime_Nullable_WithValue | .NET Core 2.0 | 12.446 ns | 0.0839 ns | 0.0785 ns | 12.487 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 2.2 | 11.301 ns | 0.0296 ns | 0.0247 ns | 11.298 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 3.0 | 10.338 ns | 0.0148 ns | 0.0138 ns | 10.337 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net461 | 14.330 ns | 0.0747 ns | 0.0699 ns | 14.314 ns |  1.15 |    0.01 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net472 | 13.325 ns | 0.0101 ns | 0.0084 ns | 13.324 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_DateTime_Nullable_NoValue | .NET Core 2.0 | 13.183 ns | 0.0149 ns | 0.0139 ns | 13.186 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 2.2 | 11.295 ns | 0.0139 ns | 0.0123 ns | 11.293 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 3.0 | 11.109 ns | 0.2465 ns | 0.4318 ns | 11.307 ns |  0.82 |    0.04 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net461 | 14.326 ns | 0.0225 ns | 0.0210 ns | 14.326 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net472 | 14.678 ns | 0.0270 ns | 0.0240 ns | 14.683 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.809 ns | 0.0200 ns | 0.0187 ns | 14.804 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.950 ns | 0.0281 ns | 0.0263 ns | 12.943 ns |  0.87 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.185 ns | 0.0198 ns | 0.0185 ns | 13.186 ns |  0.89 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net461 | 26.795 ns | 0.0264 ns | 0.0234 ns | 26.797 ns |  1.81 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net472 | 26.530 ns | 0.0523 ns | 0.0490 ns | 26.524 ns |  1.79 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                          From_Decimal | .NET Core 2.0 | 23.376 ns | 0.0171 ns | 0.0134 ns | 23.381 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 2.2 | 21.422 ns | 0.0218 ns | 0.0194 ns | 21.424 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 3.0 | 13.597 ns | 0.0230 ns | 0.0180 ns | 13.597 ns |  0.58 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal |        net461 | 21.432 ns | 0.0315 ns | 0.0263 ns | 21.431 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal |        net472 | 20.067 ns | 0.0327 ns | 0.0306 ns | 20.069 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                 From_Decimal_AsObject | .NET Core 2.0 | 30.354 ns | 0.0398 ns | 0.0332 ns | 30.363 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 2.2 | 30.082 ns | 0.0989 ns | 0.0876 ns | 30.086 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 3.0 | 23.198 ns | 0.4886 ns | 0.9644 ns | 23.567 ns |  0.72 |    0.04 |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net461 | 32.155 ns | 0.0310 ns | 0.0275 ns | 32.160 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net472 | 35.552 ns | 0.1069 ns | 0.0892 ns | 35.562 ns |  1.17 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                       From_Decimal_Nullable_WithValue | .NET Core 2.0 | 25.069 ns | 0.0326 ns | 0.0305 ns | 25.069 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 2.2 | 23.334 ns | 0.0169 ns | 0.0158 ns | 23.333 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 3.0 | 19.102 ns | 0.0246 ns | 0.0218 ns | 19.108 ns |  0.76 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net461 | 21.243 ns | 0.0425 ns | 0.0332 ns | 21.236 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net472 | 20.555 ns | 0.0219 ns | 0.0182 ns | 20.552 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.0 | 30.309 ns | 0.0409 ns | 0.0363 ns | 30.312 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.2 | 28.518 ns | 0.0286 ns | 0.0267 ns | 28.516 ns |  0.94 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 3.0 | 21.987 ns | 0.2217 ns | 0.2074 ns | 21.889 ns |  0.72 |    0.01 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net461 | 33.125 ns | 0.1887 ns | 0.1765 ns | 33.031 ns |  1.09 |    0.01 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net472 | 35.534 ns | 0.0471 ns | 0.0440 ns | 35.525 ns |  1.17 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Decimal_Nullable_NoValue | .NET Core 2.0 | 12.630 ns | 0.0753 ns | 0.0704 ns | 12.645 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 2.2 | 12.432 ns | 0.0643 ns | 0.0570 ns | 12.452 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 3.0 |  9.943 ns | 0.0117 ns | 0.0098 ns |  9.942 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net461 | 15.405 ns | 0.0244 ns | 0.0217 ns | 15.400 ns |  1.22 |    0.01 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net472 | 13.647 ns | 0.0429 ns | 0.0401 ns | 13.653 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.918 ns | 0.0175 ns | 0.0164 ns | 14.914 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.938 ns | 0.0193 ns | 0.0161 ns | 12.934 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.967 ns | 0.0143 ns | 0.0134 ns | 14.965 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net461 | 23.036 ns | 0.0289 ns | 0.0256 ns | 23.034 ns |  1.54 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net472 | 25.731 ns | 0.0351 ns | 0.0328 ns | 25.722 ns |  1.72 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_Double | .NET Core 2.0 | 13.877 ns | 0.0203 ns | 0.0190 ns | 13.881 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 2.2 | 12.272 ns | 0.0232 ns | 0.0193 ns | 12.270 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 3.0 | 11.841 ns | 0.0555 ns | 0.0519 ns | 11.855 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                           From_Double |        net461 | 15.286 ns | 0.0913 ns | 0.0854 ns | 15.232 ns |  1.10 |    0.01 |      - |     - |     - |         - |
                                           From_Double |        net472 | 14.435 ns | 0.0239 ns | 0.0212 ns | 14.433 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_Double_AsObject | .NET Core 2.0 | 21.225 ns | 0.0223 ns | 0.0197 ns | 21.230 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 2.2 | 18.636 ns | 0.0201 ns | 0.0178 ns | 18.635 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 3.0 | 19.308 ns | 0.0787 ns | 0.0736 ns | 19.327 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject |        net461 | 27.953 ns | 0.0460 ns | 0.0408 ns | 27.960 ns |  1.32 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject |        net472 | 29.661 ns | 0.0363 ns | 0.0322 ns | 29.659 ns |  1.40 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_Double_Nullable_WithValue | .NET Core 2.0 | 14.450 ns | 0.0234 ns | 0.0219 ns | 14.450 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 2.2 | 12.869 ns | 0.0242 ns | 0.0226 ns | 12.877 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 3.0 | 12.283 ns | 0.0685 ns | 0.0641 ns | 12.312 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net461 | 17.404 ns | 0.0307 ns | 0.0256 ns | 17.407 ns |  1.20 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net472 | 16.015 ns | 0.0286 ns | 0.0253 ns | 16.010 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.820 ns | 0.0920 ns | 0.0861 ns | 20.843 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.2 | 18.608 ns | 0.1104 ns | 0.1033 ns | 18.661 ns |  0.89 |    0.01 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 3.0 | 19.348 ns | 0.0252 ns | 0.0235 ns | 19.344 ns |  0.93 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net461 | 31.656 ns | 0.1243 ns | 0.1163 ns | 31.679 ns |  1.52 |    0.01 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net472 | 30.969 ns | 0.0429 ns | 0.0381 ns | 30.985 ns |  1.49 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Double_Nullable_NoValue | .NET Core 2.0 | 12.324 ns | 0.0105 ns | 0.0098 ns | 12.319 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 2.2 | 11.441 ns | 0.0153 ns | 0.0143 ns | 11.440 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 3.0 |  9.926 ns | 0.0131 ns | 0.0123 ns |  9.925 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net461 | 15.011 ns | 0.0416 ns | 0.0389 ns | 15.003 ns |  1.22 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net472 | 13.450 ns | 0.0147 ns | 0.0138 ns | 13.451 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.426 ns | 0.0168 ns | 0.0149 ns | 15.423 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.250 ns | 0.0193 ns | 0.0171 ns | 14.254 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.123 ns | 0.0082 ns | 0.0073 ns | 13.124 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net461 | 23.051 ns | 0.0238 ns | 0.0222 ns | 23.051 ns |  1.49 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net472 | 25.633 ns | 0.0352 ns | 0.0312 ns | 25.637 ns |  1.66 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_Short | .NET Core 2.0 | 11.855 ns | 0.0227 ns | 0.0201 ns | 11.856 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 2.2 | 10.639 ns | 0.0104 ns | 0.0097 ns | 10.639 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 3.0 |  9.434 ns | 0.0345 ns | 0.0323 ns |  9.424 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                            From_Short |        net461 | 13.648 ns | 0.0269 ns | 0.0225 ns | 13.648 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                                            From_Short |        net472 | 12.327 ns | 0.0111 ns | 0.0104 ns | 12.327 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_Short_AsObject | .NET Core 2.0 | 19.086 ns | 0.0289 ns | 0.0270 ns | 19.077 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 2.2 | 17.168 ns | 0.0896 ns | 0.0839 ns | 17.132 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 3.0 | 18.789 ns | 0.0948 ns | 0.0886 ns | 18.838 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net461 | 30.422 ns | 0.0353 ns | 0.0313 ns | 30.432 ns |  1.59 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net472 | 30.101 ns | 0.0432 ns | 0.0383 ns | 30.097 ns |  1.58 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Short_Nullable_WithValue | .NET Core 2.0 | 11.858 ns | 0.0147 ns | 0.0130 ns | 11.859 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 2.2 | 10.694 ns | 0.0128 ns | 0.0120 ns | 10.695 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 3.0 | 10.130 ns | 0.0128 ns | 0.0120 ns | 10.129 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net461 | 13.475 ns | 0.0383 ns | 0.0359 ns | 13.478 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net472 | 12.738 ns | 0.0183 ns | 0.0171 ns | 12.732 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.791 ns | 0.0835 ns | 0.0781 ns | 19.826 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.102 ns | 0.0208 ns | 0.0194 ns | 17.101 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.509 ns | 0.0273 ns | 0.0255 ns | 17.517 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net461 | 27.380 ns | 0.0335 ns | 0.0279 ns | 27.377 ns |  1.38 |    0.01 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net472 | 29.018 ns | 0.0347 ns | 0.0325 ns | 29.020 ns |  1.47 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Short_Nullable_NoValue | .NET Core 2.0 | 11.862 ns | 0.0163 ns | 0.0153 ns | 11.864 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 2.2 | 10.356 ns | 0.0691 ns | 0.0646 ns | 10.336 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 3.0 |  9.449 ns | 0.0117 ns | 0.0098 ns |  9.448 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net461 | 14.223 ns | 0.0264 ns | 0.0220 ns | 14.216 ns |  1.20 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net472 | 12.717 ns | 0.0071 ns | 0.0059 ns | 12.718 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.815 ns | 0.0551 ns | 0.0488 ns | 14.797 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.939 ns | 0.0095 ns | 0.0084 ns | 12.941 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.558 ns | 0.0149 ns | 0.0132 ns | 13.553 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net461 | 22.816 ns | 0.0385 ns | 0.0360 ns | 22.823 ns |  1.54 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net472 | 25.496 ns | 0.0347 ns | 0.0325 ns | 25.493 ns |  1.72 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                              From_Int | .NET Core 2.0 | 12.645 ns | 0.0175 ns | 0.0164 ns | 12.647 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 2.2 | 10.408 ns | 0.0138 ns | 0.0115 ns | 10.409 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 3.0 |  9.494 ns | 0.0133 ns | 0.0118 ns |  9.495 ns |  0.75 |    0.00 |      - |     - |     - |         - |
                                              From_Int |        net461 | 12.906 ns | 0.0125 ns | 0.0104 ns | 12.907 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                              From_Int |        net472 | 12.245 ns | 0.0218 ns | 0.0182 ns | 12.247 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_Int_AsObject | .NET Core 2.0 | 24.735 ns | 0.0295 ns | 0.0261 ns | 24.742 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 2.2 | 25.235 ns | 0.0482 ns | 0.0451 ns | 25.223 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 3.0 | 27.547 ns | 0.0365 ns | 0.0341 ns | 27.538 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net461 | 38.988 ns | 0.1115 ns | 0.1043 ns | 38.952 ns |  1.58 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net472 | 40.627 ns | 0.1064 ns | 0.0943 ns | 40.652 ns |  1.64 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Int_Nullable_WithValue | .NET Core 2.0 | 11.378 ns | 0.0793 ns | 0.0742 ns | 11.412 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 2.2 | 10.146 ns | 0.0735 ns | 0.0687 ns | 10.108 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 3.0 |  6.954 ns | 0.0383 ns | 0.0320 ns |  6.942 ns |  0.61 |    0.01 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net461 | 12.491 ns | 0.0104 ns | 0.0097 ns | 12.494 ns |  1.10 |    0.01 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net472 | 11.784 ns | 0.0130 ns | 0.0121 ns | 11.781 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.0 | 23.801 ns | 0.0232 ns | 0.0205 ns | 23.799 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.2 | 26.115 ns | 0.0436 ns | 0.0408 ns | 26.110 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 3.0 | 29.438 ns | 0.0448 ns | 0.0419 ns | 29.436 ns |  1.24 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net461 | 35.509 ns | 0.0612 ns | 0.0542 ns | 35.503 ns |  1.49 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net472 | 37.416 ns | 0.1836 ns | 0.1717 ns | 37.501 ns |  1.57 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_Int_Nullable_NoValue | .NET Core 2.0 | 11.299 ns | 0.0277 ns | 0.0260 ns | 11.290 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 2.2 | 10.110 ns | 0.0344 ns | 0.0322 ns | 10.095 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 3.0 |  7.486 ns | 0.0126 ns | 0.0106 ns |  7.488 ns |  0.66 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net461 | 12.882 ns | 0.0635 ns | 0.0594 ns | 12.861 ns |  1.14 |    0.01 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net472 | 12.088 ns | 0.0134 ns | 0.0125 ns | 12.086 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.807 ns | 0.0110 ns | 0.0103 ns | 14.805 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.082 ns | 0.0151 ns | 0.0134 ns | 13.079 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.735 ns | 0.0258 ns | 0.0242 ns | 14.733 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net461 | 22.805 ns | 0.0413 ns | 0.0386 ns | 22.793 ns |  1.54 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net472 | 24.482 ns | 0.0270 ns | 0.0252 ns | 24.480 ns |  1.65 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Long | .NET Core 2.0 | 12.560 ns | 0.0129 ns | 0.0115 ns | 12.562 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Long | .NET Core 2.2 | 12.935 ns | 0.0163 ns | 0.0153 ns | 12.932 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                             From_Long | .NET Core 3.0 |  9.871 ns | 0.0197 ns | 0.0184 ns |  9.866 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                                             From_Long |        net461 | 16.084 ns | 0.0439 ns | 0.0411 ns | 16.068 ns |  1.28 |    0.00 |      - |     - |     - |         - |
                                             From_Long |        net472 | 12.969 ns | 0.0160 ns | 0.0149 ns | 12.968 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Long_AsObject | .NET Core 2.0 | 20.255 ns | 0.2033 ns | 0.1902 ns | 20.378 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 2.2 | 17.813 ns | 0.0229 ns | 0.0203 ns | 17.805 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 3.0 | 19.697 ns | 0.0347 ns | 0.0325 ns | 19.691 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net461 | 31.265 ns | 0.0388 ns | 0.0363 ns | 31.269 ns |  1.54 |    0.01 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net472 | 29.105 ns | 0.0273 ns | 0.0255 ns | 29.106 ns |  1.44 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Long_Nullable_WithValue | .NET Core 2.0 | 13.998 ns | 0.0454 ns | 0.0425 ns | 13.999 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 2.2 | 12.687 ns | 0.0164 ns | 0.0145 ns | 12.688 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 3.0 | 11.046 ns | 0.0193 ns | 0.0161 ns | 11.043 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net461 | 15.984 ns | 0.0685 ns | 0.0641 ns | 15.959 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net472 | 14.795 ns | 0.1192 ns | 0.1115 ns | 14.826 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.373 ns | 0.0651 ns | 0.0609 ns | 20.357 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.788 ns | 0.0222 ns | 0.0174 ns | 17.784 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 3.0 | 19.900 ns | 0.0850 ns | 0.0753 ns | 19.928 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net461 | 31.407 ns | 0.1153 ns | 0.1022 ns | 31.450 ns |  1.54 |    0.01 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net472 | 29.239 ns | 0.0369 ns | 0.0327 ns | 29.234 ns |  1.44 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Long_Nullable_NoValue | .NET Core 2.0 | 12.259 ns | 0.0271 ns | 0.0241 ns | 12.254 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 2.2 | 11.335 ns | 0.0116 ns | 0.0108 ns | 11.334 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 3.0 |  9.720 ns | 0.0617 ns | 0.0577 ns |  9.696 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net461 | 15.248 ns | 0.0269 ns | 0.0252 ns | 15.252 ns |  1.24 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net472 | 13.370 ns | 0.0138 ns | 0.0115 ns | 13.373 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.910 ns | 0.0164 ns | 0.0153 ns | 14.910 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.310 ns | 0.0150 ns | 0.0140 ns | 13.313 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 3.0 | 15.093 ns | 0.0248 ns | 0.0232 ns | 15.098 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net461 | 23.113 ns | 0.0448 ns | 0.0374 ns | 23.112 ns |  1.55 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net472 | 25.509 ns | 0.0326 ns | 0.0289 ns | 25.514 ns |  1.71 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_SByte | .NET Core 2.0 | 11.849 ns | 0.0192 ns | 0.0170 ns | 11.847 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 2.2 | 10.518 ns | 0.0168 ns | 0.0157 ns | 10.509 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 3.0 |  9.639 ns | 0.0088 ns | 0.0074 ns |  9.640 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                                            From_SByte |        net461 | 13.686 ns | 0.0233 ns | 0.0218 ns | 13.687 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                                            From_SByte |        net472 | 12.207 ns | 0.0069 ns | 0.0065 ns | 12.206 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_SByte_AsObject | .NET Core 2.0 | 19.422 ns | 0.0297 ns | 0.0263 ns | 19.422 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 2.2 | 17.100 ns | 0.0221 ns | 0.0185 ns | 17.101 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 3.0 | 18.666 ns | 0.0924 ns | 0.0819 ns | 18.691 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net461 | 27.557 ns | 0.0462 ns | 0.0432 ns | 27.561 ns |  1.42 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net472 | 29.241 ns | 0.0564 ns | 0.0500 ns | 29.231 ns |  1.51 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_SByte_Nullable_WithValue | .NET Core 2.0 | 11.859 ns | 0.0161 ns | 0.0134 ns | 11.863 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 2.2 | 10.752 ns | 0.0686 ns | 0.0642 ns | 10.785 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 3.0 | 10.256 ns | 0.0833 ns | 0.0739 ns | 10.238 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net461 | 14.213 ns | 0.0449 ns | 0.0420 ns | 14.196 ns |  1.20 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net472 | 12.745 ns | 0.0139 ns | 0.0123 ns | 12.746 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.895 ns | 0.0422 ns | 0.0353 ns | 20.887 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.513 ns | 0.0312 ns | 0.0292 ns | 17.510 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.917 ns | 0.0482 ns | 0.0451 ns | 18.922 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net461 | 30.743 ns | 0.0569 ns | 0.0532 ns | 30.735 ns |  1.47 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net472 | 28.673 ns | 0.0425 ns | 0.0398 ns | 28.662 ns |  1.37 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_SByte_Nullable_NoValue | .NET Core 2.0 | 11.865 ns | 0.0241 ns | 0.0226 ns | 11.859 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 2.2 | 10.293 ns | 0.0148 ns | 0.0123 ns | 10.289 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 3.0 |  9.477 ns | 0.0257 ns | 0.0241 ns |  9.468 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net461 | 13.541 ns | 0.0221 ns | 0.0184 ns | 13.536 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net472 | 13.440 ns | 0.0251 ns | 0.0235 ns | 13.430 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.0 | 16.173 ns | 0.0812 ns | 0.0759 ns | 16.209 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.036 ns | 0.0084 ns | 0.0078 ns | 13.036 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.126 ns | 0.0124 ns | 0.0110 ns | 13.125 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net461 | 26.584 ns | 0.0436 ns | 0.0407 ns | 26.592 ns |  1.64 |    0.01 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net472 | 25.664 ns | 0.0277 ns | 0.0259 ns | 25.670 ns |  1.59 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_Float | .NET Core 2.0 | 14.071 ns | 0.0592 ns | 0.0525 ns | 14.088 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 2.2 | 12.254 ns | 0.0149 ns | 0.0139 ns | 12.253 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 3.0 | 11.729 ns | 0.0121 ns | 0.0108 ns | 11.727 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                            From_Float |        net461 | 16.136 ns | 0.0279 ns | 0.0261 ns | 16.130 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                                            From_Float |        net472 | 15.242 ns | 0.0170 ns | 0.0159 ns | 15.246 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_Float_AsObject | .NET Core 2.0 | 20.943 ns | 0.0205 ns | 0.0171 ns | 20.951 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 2.2 | 18.836 ns | 0.1214 ns | 0.1135 ns | 18.901 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 3.0 | 20.718 ns | 0.0327 ns | 0.0290 ns | 20.718 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject |        net461 | 28.304 ns | 0.0261 ns | 0.0231 ns | 28.305 ns |  1.35 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject |        net472 | 30.029 ns | 0.0446 ns | 0.0417 ns | 30.030 ns |  1.43 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Float_Nullable_WithValue | .NET Core 2.0 | 13.923 ns | 0.0270 ns | 0.0252 ns | 13.914 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 2.2 | 15.531 ns | 0.0193 ns | 0.0161 ns | 15.533 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 3.0 | 12.320 ns | 0.4487 ns | 0.5990 ns | 11.991 ns |  0.90 |    0.05 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net461 | 15.340 ns | 0.0578 ns | 0.0513 ns | 15.328 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net472 | 15.368 ns | 0.0157 ns | 0.0139 ns | 15.366 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.907 ns | 0.0209 ns | 0.0196 ns | 20.905 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.2 | 19.654 ns | 0.0229 ns | 0.0179 ns | 19.651 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 3.0 | 20.162 ns | 0.2210 ns | 0.2067 ns | 20.280 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net461 | 28.287 ns | 0.0300 ns | 0.0281 ns | 28.293 ns |  1.35 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net472 | 30.864 ns | 0.0487 ns | 0.0407 ns | 30.860 ns |  1.48 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Float_Nullable_NoValue | .NET Core 2.0 | 12.343 ns | 0.0454 ns | 0.0425 ns | 12.330 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 2.2 | 10.639 ns | 0.0197 ns | 0.0184 ns | 10.637 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 3.0 |  9.917 ns | 0.0110 ns | 0.0103 ns |  9.915 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net461 | 14.810 ns | 0.1816 ns | 0.1698 ns | 14.843 ns |  1.20 |    0.02 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net472 | 13.080 ns | 0.0672 ns | 0.0629 ns | 13.104 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.588 ns | 0.0675 ns | 0.0598 ns | 15.602 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.936 ns | 0.0157 ns | 0.0139 ns | 12.933 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.360 ns | 0.0581 ns | 0.0543 ns | 13.335 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net461 | 22.742 ns | 0.0690 ns | 0.0576 ns | 22.757 ns |  1.46 |    0.01 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net472 | 24.605 ns | 0.0324 ns | 0.0303 ns | 24.589 ns |  1.58 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_String | .NET Core 2.0 | 57.935 ns | 0.1166 ns | 0.1091 ns | 57.909 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 2.2 | 57.497 ns | 0.0606 ns | 0.0567 ns | 57.490 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 3.0 | 22.719 ns | 0.3669 ns | 0.3432 ns | 22.945 ns |  0.39 |    0.01 |      - |     - |     - |         - |
                                           From_String |        net461 | 57.677 ns | 0.0801 ns | 0.0749 ns | 57.674 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_String |        net472 | 60.328 ns | 0.0742 ns | 0.0620 ns | 60.338 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_String_AsObject | .NET Core 2.0 | 63.262 ns | 0.1785 ns | 0.1582 ns | 63.267 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 2.2 | 59.178 ns | 0.0478 ns | 0.0424 ns | 59.175 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 3.0 | 29.598 ns | 0.0593 ns | 0.0555 ns | 29.597 ns |  0.47 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject |        net461 | 70.612 ns | 0.1621 ns | 0.1516 ns | 70.616 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject |        net472 | 73.079 ns | 0.1676 ns | 0.1486 ns | 73.074 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                      From_String_Null | .NET Core 2.0 | 14.062 ns | 0.0136 ns | 0.0120 ns | 14.062 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 2.2 | 17.848 ns | 0.0398 ns | 0.0353 ns | 17.850 ns |  1.27 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 3.0 | 13.724 ns | 0.0734 ns | 0.0686 ns | 13.716 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null |        net461 | 14.792 ns | 0.0240 ns | 0.0201 ns | 14.790 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null |        net472 | 15.576 ns | 0.1096 ns | 0.1025 ns | 15.635 ns |  1.11 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_String_Null_AsObject | .NET Core 2.0 | 17.316 ns | 0.0215 ns | 0.0179 ns | 17.317 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 2.2 | 13.034 ns | 0.0156 ns | 0.0139 ns | 13.032 ns |  0.75 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 3.0 | 13.572 ns | 0.0121 ns | 0.0107 ns | 13.572 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net461 | 25.228 ns | 0.0272 ns | 0.0242 ns | 25.225 ns |  1.46 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net472 | 24.493 ns | 0.0295 ns | 0.0262 ns | 24.494 ns |  1.41 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_String_Empty | .NET Core 2.0 | 15.024 ns | 0.0250 ns | 0.0222 ns | 15.020 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 2.2 | 17.961 ns | 0.0213 ns | 0.0189 ns | 17.960 ns |  1.20 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 3.0 | 13.879 ns | 0.0287 ns | 0.0254 ns | 13.880 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty |        net461 | 14.943 ns | 0.0326 ns | 0.0289 ns | 14.929 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty |        net472 | 16.557 ns | 0.0179 ns | 0.0150 ns | 16.558 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_String_Empty_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_UShort | .NET Core 2.0 | 11.832 ns | 0.0110 ns | 0.0092 ns | 11.833 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 2.2 | 10.444 ns | 0.0169 ns | 0.0158 ns | 10.441 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 3.0 |  9.866 ns | 0.0140 ns | 0.0124 ns |  9.869 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                           From_UShort |        net461 | 13.654 ns | 0.0213 ns | 0.0199 ns | 13.654 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                                           From_UShort |        net472 | 12.926 ns | 0.1532 ns | 0.1433 ns | 12.972 ns |  1.09 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_UShort_AsObject | .NET Core 2.0 | 19.485 ns | 0.1294 ns | 0.1210 ns | 19.514 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 2.2 | 17.097 ns | 0.0126 ns | 0.0118 ns | 17.095 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 3.0 | 19.130 ns | 0.0432 ns | 0.0383 ns | 19.123 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net461 | 27.492 ns | 0.0514 ns | 0.0481 ns | 27.505 ns |  1.41 |    0.01 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net472 | 29.462 ns | 0.2018 ns | 0.1888 ns | 29.542 ns |  1.51 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_UShort_Nullable_WithValue | .NET Core 2.0 | 11.871 ns | 0.0153 ns | 0.0135 ns | 11.869 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 2.2 | 10.751 ns | 0.0145 ns | 0.0135 ns | 10.751 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 3.0 | 10.056 ns | 0.0080 ns | 0.0075 ns | 10.054 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net461 | 13.604 ns | 0.0203 ns | 0.0180 ns | 13.601 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net472 | 13.147 ns | 0.0189 ns | 0.0168 ns | 13.142 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.139 ns | 0.0287 ns | 0.0254 ns | 19.132 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.055 ns | 0.0200 ns | 0.0177 ns | 17.057 ns |  0.89 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.487 ns | 0.1377 ns | 0.1221 ns | 17.441 ns |  0.91 |    0.01 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net461 | 26.770 ns | 0.0316 ns | 0.0280 ns | 26.772 ns |  1.40 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net472 | 30.751 ns | 0.0510 ns | 0.0478 ns | 30.741 ns |  1.61 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_UShort_Nullable_NoValue | .NET Core 2.0 | 11.860 ns | 0.0087 ns | 0.0081 ns | 11.858 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 2.2 | 10.272 ns | 0.0091 ns | 0.0080 ns | 10.272 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 3.0 |  9.689 ns | 0.0127 ns | 0.0112 ns |  9.688 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net461 | 14.135 ns | 0.0351 ns | 0.0328 ns | 14.133 ns |  1.19 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net472 | 12.726 ns | 0.0126 ns | 0.0118 ns | 12.722 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.786 ns | 0.0156 ns | 0.0138 ns | 14.786 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.005 ns | 0.0548 ns | 0.0513 ns | 13.026 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.897 ns | 0.2055 ns | 0.1822 ns | 13.970 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net461 | 22.891 ns | 0.0287 ns | 0.0269 ns | 22.880 ns |  1.55 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net472 | 24.512 ns | 0.0247 ns | 0.0193 ns | 24.511 ns |  1.66 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_UInt | .NET Core 2.0 | 11.872 ns | 0.0076 ns | 0.0064 ns | 11.872 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 2.2 | 10.468 ns | 0.0139 ns | 0.0123 ns | 10.468 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 3.0 |  9.491 ns | 0.0680 ns | 0.0636 ns |  9.498 ns |  0.80 |    0.01 |      - |     - |     - |         - |
                                             From_UInt |        net461 | 14.044 ns | 0.0613 ns | 0.0543 ns | 14.032 ns |  1.18 |    0.00 |      - |     - |     - |         - |
                                             From_UInt |        net472 | 12.964 ns | 0.0166 ns | 0.0155 ns | 12.965 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_UInt_AsObject | .NET Core 2.0 | 19.495 ns | 0.0256 ns | 0.0240 ns | 19.495 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 2.2 | 18.299 ns | 0.0259 ns | 0.0243 ns | 18.297 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 3.0 | 18.904 ns | 0.0238 ns | 0.0211 ns | 18.900 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net461 | 27.420 ns | 0.0309 ns | 0.0289 ns | 27.417 ns |  1.41 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net472 | 29.481 ns | 0.0531 ns | 0.0471 ns | 29.501 ns |  1.51 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_UInt_Nullable_WithValue | .NET Core 2.0 | 12.088 ns | 0.0193 ns | 0.0180 ns | 12.087 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 2.2 | 10.645 ns | 0.0085 ns | 0.0071 ns | 10.646 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 3.0 |  9.916 ns | 0.0138 ns | 0.0129 ns |  9.918 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net461 | 14.500 ns | 0.0259 ns | 0.0230 ns | 14.501 ns |  1.20 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net472 | 13.306 ns | 0.0182 ns | 0.0162 ns | 13.302 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.589 ns | 0.1062 ns | 0.0993 ns | 19.639 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.300 ns | 0.0190 ns | 0.0158 ns | 17.300 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 3.0 | 19.103 ns | 0.0427 ns | 0.0399 ns | 19.102 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net461 | 30.850 ns | 0.0499 ns | 0.0466 ns | 30.846 ns |  1.57 |    0.01 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net472 | 30.474 ns | 0.0329 ns | 0.0292 ns | 30.471 ns |  1.56 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_UInt_Nullable_NoValue | .NET Core 2.0 | 12.074 ns | 0.0221 ns | 0.0196 ns | 12.071 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 2.2 | 10.278 ns | 0.0126 ns | 0.0111 ns | 10.278 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 3.0 |  9.453 ns | 0.0101 ns | 0.0094 ns |  9.453 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net461 | 14.119 ns | 0.0377 ns | 0.0335 ns | 14.109 ns |  1.17 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net472 | 12.742 ns | 0.0205 ns | 0.0182 ns | 12.739 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.459 ns | 0.0122 ns | 0.0102 ns | 15.458 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.928 ns | 0.0142 ns | 0.0126 ns | 12.931 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.666 ns | 0.1159 ns | 0.1084 ns | 13.593 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net461 | 25.194 ns | 0.0344 ns | 0.0305 ns | 25.188 ns |  1.63 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net472 | 25.813 ns | 0.0251 ns | 0.0235 ns | 25.810 ns |  1.67 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_ULong | .NET Core 2.0 | 12.583 ns | 0.0113 ns | 0.0095 ns | 12.584 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 2.2 | 11.626 ns | 0.0557 ns | 0.0521 ns | 11.601 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 3.0 |  9.867 ns | 0.0125 ns | 0.0117 ns |  9.870 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                                            From_ULong |        net461 | 14.058 ns | 0.0185 ns | 0.0164 ns | 14.059 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                            From_ULong |        net472 | 13.006 ns | 0.0122 ns | 0.0108 ns | 13.006 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_ULong_AsObject | .NET Core 2.0 | 20.926 ns | 0.0337 ns | 0.0299 ns | 20.918 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 2.2 | 17.869 ns | 0.0286 ns | 0.0268 ns | 17.869 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 3.0 | 18.392 ns | 0.0249 ns | 0.0221 ns | 18.396 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net461 | 31.346 ns | 0.0478 ns | 0.0424 ns | 31.340 ns |  1.50 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net472 | 29.909 ns | 0.1391 ns | 0.1233 ns | 29.960 ns |  1.43 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_ULong_Nullable_WithValue | .NET Core 2.0 | 13.903 ns | 0.0208 ns | 0.0174 ns | 13.907 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 2.2 | 12.626 ns | 0.0243 ns | 0.0215 ns | 12.621 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 3.0 | 11.177 ns | 0.0574 ns | 0.0537 ns | 11.189 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net461 | 15.281 ns | 0.0246 ns | 0.0230 ns | 15.276 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net472 | 14.542 ns | 0.0204 ns | 0.0191 ns | 14.543 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.869 ns | 0.0293 ns | 0.0274 ns | 20.870 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.562 ns | 0.0197 ns | 0.0175 ns | 17.558 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.108 ns | 0.0183 ns | 0.0162 ns | 18.106 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net461 | 31.059 ns | 0.0500 ns | 0.0468 ns | 31.055 ns |  1.49 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net472 | 30.178 ns | 0.0338 ns | 0.0316 ns | 30.188 ns |  1.45 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_ULong_Nullable_NoValue | .NET Core 2.0 | 12.326 ns | 0.0338 ns | 0.0316 ns | 12.314 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 2.2 | 11.289 ns | 0.0159 ns | 0.0149 ns | 11.287 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 3.0 |  9.903 ns | 0.0157 ns | 0.0146 ns |  9.902 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net461 | 14.877 ns | 0.0223 ns | 0.0198 ns | 14.875 ns |  1.21 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net472 | 13.368 ns | 0.0194 ns | 0.0182 ns | 13.368 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.845 ns | 0.0403 ns | 0.0377 ns | 14.830 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.936 ns | 0.0289 ns | 0.0271 ns | 12.930 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 3.0 | 15.105 ns | 0.0140 ns | 0.0131 ns | 15.103 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net461 | 22.927 ns | 0.0286 ns | 0.0268 ns | 22.932 ns |  1.54 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net472 | 24.719 ns | 0.1226 ns | 0.1147 ns | 24.751 ns |  1.67 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                       From_NullObject | .NET Core 2.0 | 15.945 ns | 0.0244 ns | 0.0216 ns | 15.945 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 2.2 | 13.042 ns | 0.0648 ns | 0.0506 ns | 13.061 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 3.0 | 13.589 ns | 0.0250 ns | 0.0209 ns | 13.586 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject |        net461 | 26.769 ns | 0.0805 ns | 0.0672 ns | 26.780 ns |  1.68 |    0.01 |      - |     - |     - |         - |
                                       From_NullObject |        net472 | 24.449 ns | 0.0269 ns | 0.0252 ns | 24.443 ns |  1.53 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_DBNull | .NET Core 2.0 | 12.731 ns | 0.0255 ns | 0.0226 ns | 12.721 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 2.2 | 11.099 ns | 0.0151 ns | 0.0141 ns | 11.098 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 3.0 | 13.070 ns | 0.1633 ns | 0.1528 ns | 13.131 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                           From_DBNull |        net461 | 13.789 ns | 0.0515 ns | 0.0456 ns | 13.771 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull |        net472 | 13.929 ns | 0.1142 ns | 0.1069 ns | 13.963 ns |  1.09 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_DBNull_AsObject | .NET Core 2.0 | 14.788 ns | 0.0102 ns | 0.0095 ns | 14.788 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 2.2 | 12.929 ns | 0.0412 ns | 0.0366 ns | 12.916 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 3.0 | 13.952 ns | 0.4687 ns | 0.6870 ns | 13.576 ns |  0.97 |    0.06 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net461 | 22.906 ns | 0.0279 ns | 0.0261 ns | 22.902 ns |  1.55 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net472 | 26.534 ns | 0.0454 ns | 0.0425 ns | 26.534 ns |  1.79 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                 From_ConvertibleClass | .NET Core 2.0 | 17.296 ns | 0.0215 ns | 0.0168 ns | 17.297 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 2.2 | 14.798 ns | 0.0197 ns | 0.0185 ns | 14.794 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 3.0 | 14.879 ns | 0.0424 ns | 0.0397 ns | 14.882 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net461 | 26.095 ns | 0.0393 ns | 0.0349 ns | 26.096 ns |  1.51 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net472 | 25.802 ns | 0.0810 ns | 0.0758 ns | 25.805 ns |  1.49 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_ConvertibleClass_AsObject | .NET Core 2.0 | 18.989 ns | 0.0195 ns | 0.0182 ns | 18.991 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 2.2 | 16.827 ns | 0.0182 ns | 0.0161 ns | 16.830 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 3.0 | 18.860 ns | 0.0202 ns | 0.0189 ns | 18.860 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net461 | 26.198 ns | 0.0462 ns | 0.0410 ns | 26.193 ns |  1.38 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net472 | 29.462 ns | 0.2800 ns | 0.2619 ns | 29.644 ns |  1.55 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_ConvertibleClass_NoValue | .NET Core 2.0 | 14.901 ns | 0.0188 ns | 0.0167 ns | 14.904 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 2.2 | 14.912 ns | 0.0286 ns | 0.0267 ns | 14.916 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 3.0 | 13.423 ns | 0.2926 ns | 0.4725 ns | 13.125 ns |  0.93 |    0.03 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net461 | 24.529 ns | 0.0311 ns | 0.0259 ns | 24.531 ns |  1.65 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net472 | 24.476 ns | 0.0366 ns | 0.0342 ns | 24.486 ns |  1.64 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.0 | 15.461 ns | 0.0237 ns | 0.0222 ns | 15.453 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.2 | 12.914 ns | 0.0125 ns | 0.0111 ns | 12.914 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 3.0 | 13.332 ns | 0.0098 ns | 0.0082 ns | 13.332 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net461 | 22.969 ns | 0.0341 ns | 0.0319 ns | 22.967 ns |  1.49 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net472 | 24.850 ns | 0.0269 ns | 0.0251 ns | 24.846 ns |  1.61 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                              From_NonConvertibleClass | .NET Core 2.0 | 13.982 ns | 0.0522 ns | 0.0488 ns | 13.997 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 2.2 | 12.711 ns | 0.0112 ns | 0.0104 ns | 12.706 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 3.0 | 12.583 ns | 0.0162 ns | 0.0151 ns | 12.579 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net461 | 14.326 ns | 0.0185 ns | 0.0164 ns | 14.324 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net472 | 14.304 ns | 0.0132 ns | 0.0117 ns | 14.302 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                     From_NonConvertibleClass_AsObject | .NET Core 2.0 | 16.572 ns | 0.0140 ns | 0.0117 ns | 16.574 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 2.2 | 16.024 ns | 0.0174 ns | 0.0154 ns | 16.027 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 3.0 | 16.344 ns | 0.0216 ns | 0.0181 ns | 16.345 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net461 | 24.726 ns | 0.0289 ns | 0.0241 ns | 24.730 ns |  1.49 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net472 | 25.814 ns | 0.0426 ns | 0.0399 ns | 25.805 ns |  1.56 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                      From_NonConvertibleClass_NoValue | .NET Core 2.0 | 14.019 ns | 0.0099 ns | 0.0092 ns | 14.019 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 2.2 | 12.673 ns | 0.0135 ns | 0.0119 ns | 12.674 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 3.0 | 12.725 ns | 0.0105 ns | 0.0099 ns | 12.723 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net461 | 14.348 ns | 0.0105 ns | 0.0093 ns | 14.349 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net472 | 14.430 ns | 0.0854 ns | 0.0799 ns | 14.478 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.0 | 15.492 ns | 0.0140 ns | 0.0116 ns | 15.492 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.2 | 12.966 ns | 0.0826 ns | 0.0773 ns | 12.928 ns |  0.84 |    0.01 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 3.0 | 14.832 ns | 0.0832 ns | 0.0738 ns | 14.866 ns |  0.96 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net461 | 22.942 ns | 0.0219 ns | 0.0194 ns | 22.945 ns |  1.48 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net472 | 24.818 ns | 0.0184 ns | 0.0172 ns | 24.818 ns |  1.60 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                From_ConvertibleStruct | .NET Core 2.0 | 20.782 ns | 0.0322 ns | 0.0301 ns | 20.787 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 2.2 | 15.933 ns | 0.0292 ns | 0.0273 ns | 15.933 ns |  0.77 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 3.0 | 13.916 ns | 0.0257 ns | 0.0240 ns | 13.908 ns |  0.67 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net461 | 20.544 ns | 0.0724 ns | 0.0642 ns | 20.537 ns |  0.99 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net472 | 19.176 ns | 0.0266 ns | 0.0222 ns | 19.181 ns |  0.92 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                       From_ConvertibleStruct_AsObject | .NET Core 2.0 | 19.376 ns | 0.1391 ns | 0.1301 ns | 19.439 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 2.2 | 17.696 ns | 0.0166 ns | 0.0155 ns | 17.696 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 3.0 | 17.280 ns | 0.0316 ns | 0.0280 ns | 17.271 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net461 | 26.752 ns | 0.0362 ns | 0.0338 ns | 26.755 ns |  1.38 |    0.01 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net472 | 28.302 ns | 0.0464 ns | 0.0434 ns | 28.305 ns |  1.46 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.0 | 20.108 ns | 0.0291 ns | 0.0258 ns | 20.110 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.2 | 16.334 ns | 0.0580 ns | 0.0514 ns | 16.337 ns |  0.81 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 3.0 | 14.314 ns | 0.0392 ns | 0.0347 ns | 14.323 ns |  0.71 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net461 | 27.259 ns | 0.0817 ns | 0.0682 ns | 27.277 ns |  1.36 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net472 | 24.901 ns | 0.0368 ns | 0.0308 ns | 24.908 ns |  1.24 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.724 ns | 0.0242 ns | 0.0226 ns | 20.726 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.062 ns | 0.0298 ns | 0.0264 ns | 17.058 ns |  0.82 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.560 ns | 0.1246 ns | 0.1165 ns | 17.498 ns |  0.85 |    0.01 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net461 | 27.041 ns | 0.0365 ns | 0.0305 ns | 27.043 ns |  1.30 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net472 | 28.376 ns | 0.0509 ns | 0.0476 ns | 28.368 ns |  1.37 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.0 | 13.885 ns | 0.0184 ns | 0.0172 ns | 13.886 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.2 | 11.988 ns | 0.0125 ns | 0.0104 ns | 11.988 ns |  0.86 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 3.0 |  9.951 ns | 0.0143 ns | 0.0120 ns |  9.949 ns |  0.72 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net461 | 22.665 ns | 0.0355 ns | 0.0315 ns | 22.662 ns |  1.63 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net472 | 18.687 ns | 0.0240 ns | 0.0212 ns | 18.687 ns |  1.35 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.791 ns | 0.0142 ns | 0.0126 ns | 14.790 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.925 ns | 0.0106 ns | 0.0099 ns | 12.927 ns |  0.87 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.732 ns | 0.0294 ns | 0.0275 ns | 14.729 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net461 | 22.606 ns | 0.0396 ns | 0.0331 ns | 22.610 ns |  1.53 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net472 | 24.586 ns | 0.0284 ns | 0.0266 ns | 24.587 ns |  1.66 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_NonConvertibleStruct | .NET Core 2.0 | 13.469 ns | 0.0135 ns | 0.0120 ns | 13.468 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 2.2 | 11.499 ns | 0.0150 ns | 0.0133 ns | 11.500 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 3.0 |  9.525 ns | 0.0614 ns | 0.0574 ns |  9.497 ns |  0.71 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net461 | 13.008 ns | 0.0676 ns | 0.0632 ns | 12.983 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net472 | 12.243 ns | 0.0174 ns | 0.0145 ns | 12.244 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.0 | 18.187 ns | 0.0293 ns | 0.0274 ns | 18.181 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.2 | 14.827 ns | 0.0884 ns | 0.0827 ns | 14.775 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 3.0 | 14.969 ns | 0.0128 ns | 0.0120 ns | 14.971 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net461 | 24.428 ns | 0.0522 ns | 0.0463 ns | 24.410 ns |  1.34 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net472 | 26.286 ns | 0.0982 ns | 0.0870 ns | 26.305 ns |  1.45 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.0 | 13.727 ns | 0.0153 ns | 0.0143 ns | 13.727 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.2 | 11.290 ns | 0.0064 ns | 0.0057 ns | 11.291 ns |  0.82 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 3.0 |  9.484 ns | 0.0151 ns | 0.0134 ns |  9.483 ns |  0.69 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net461 | 14.799 ns | 0.0192 ns | 0.0170 ns | 14.800 ns |  1.08 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net472 | 13.553 ns | 0.0266 ns | 0.0249 ns | 13.549 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 16.690 ns | 0.0757 ns | 0.0708 ns | 16.706 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 14.757 ns | 0.0270 ns | 0.0225 ns | 14.750 ns |  0.88 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 16.349 ns | 0.0191 ns | 0.0169 ns | 16.346 ns |  0.98 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net461 | 24.530 ns | 0.0681 ns | 0.0637 ns | 24.520 ns |  1.47 |    0.01 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net472 | 25.856 ns | 0.0266 ns | 0.0208 ns | 25.856 ns |  1.55 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.0 | 13.480 ns | 0.0201 ns | 0.0188 ns | 13.477 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.2 | 11.441 ns | 0.0129 ns | 0.0115 ns | 11.437 ns |  0.85 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 3.0 |  9.471 ns | 0.0105 ns | 0.0093 ns |  9.473 ns |  0.70 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net461 | 13.666 ns | 0.0203 ns | 0.0190 ns | 13.668 ns |  1.01 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net472 | 12.249 ns | 0.0119 ns | 0.0105 ns | 12.249 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.794 ns | 0.0125 ns | 0.0117 ns | 14.794 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.385 ns | 0.0131 ns | 0.0116 ns | 13.383 ns |  0.90 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.335 ns | 0.0159 ns | 0.0149 ns | 13.333 ns |  0.90 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net461 | 26.482 ns | 0.0304 ns | 0.0270 ns | 26.477 ns |  1.79 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net472 | 25.569 ns | 0.0314 ns | 0.0294 ns | 25.565 ns |  1.73 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Enum | .NET Core 2.0 | 13.175 ns | 0.0114 ns | 0.0107 ns | 13.179 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 2.2 | 10.413 ns | 0.0153 ns | 0.0143 ns | 10.417 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 3.0 |  9.452 ns | 0.0126 ns | 0.0111 ns |  9.454 ns |  0.72 |    0.00 |      - |     - |     - |         - |
                                             From_Enum |        net461 | 13.673 ns | 0.0403 ns | 0.0377 ns | 13.674 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                             From_Enum |        net472 | 12.270 ns | 0.0086 ns | 0.0072 ns | 12.269 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Enum_AsObject | .NET Core 2.0 | 47.965 ns | 0.1050 ns | 0.0931 ns | 47.953 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject | .NET Core 2.2 | 43.812 ns | 0.1099 ns | 0.1028 ns | 43.816 ns |  0.91 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject | .NET Core 3.0 | 40.582 ns | 0.6152 ns | 0.5453 ns | 40.709 ns |  0.85 |    0.01 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject |        net461 | 49.960 ns | 0.1095 ns | 0.1024 ns | 49.966 ns |  1.04 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject |        net472 | 54.141 ns | 0.2646 ns | 0.2475 ns | 54.229 ns |  1.13 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Enum_Nullable_WithValue | .NET Core 2.0 | 13.279 ns | 0.0185 ns | 0.0164 ns | 13.277 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 2.2 | 10.610 ns | 0.0096 ns | 0.0090 ns | 10.612 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 3.0 |  9.989 ns | 0.0809 ns | 0.0757 ns | 10.006 ns |  0.75 |    0.01 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net461 | 14.790 ns | 0.1280 ns | 0.1197 ns | 14.719 ns |  1.11 |    0.01 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net472 | 12.754 ns | 0.0077 ns | 0.0064 ns | 12.753 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.0 | 46.171 ns | 0.0651 ns | 0.0609 ns | 46.159 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.2 | 44.522 ns | 0.0830 ns | 0.0777 ns | 44.507 ns |  0.96 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 3.0 | 41.757 ns | 0.0480 ns | 0.0426 ns | 41.768 ns |  0.90 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject |        net461 | 50.113 ns | 0.0426 ns | 0.0356 ns | 50.097 ns |  1.09 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject |        net472 | 53.388 ns | 0.0622 ns | 0.0552 ns | 53.374 ns |  1.16 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Enum_Nullable_NoValue | .NET Core 2.0 | 13.155 ns | 0.0106 ns | 0.0089 ns | 13.155 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 2.2 | 10.208 ns | 0.0172 ns | 0.0161 ns | 10.207 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 3.0 | 10.196 ns | 0.0475 ns | 0.0444 ns | 10.212 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net461 | 13.456 ns | 0.0161 ns | 0.0150 ns | 13.456 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net472 | 13.597 ns | 0.0114 ns | 0.0107 ns | 13.598 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.452 ns | 0.0122 ns | 0.0102 ns | 15.455 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.958 ns | 0.0753 ns | 0.0705 ns | 12.921 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.197 ns | 0.3059 ns | 0.4762 ns | 14.519 ns |  0.89 |    0.02 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net461 | 23.396 ns | 0.0332 ns | 0.0295 ns | 23.400 ns |  1.51 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net472 | 24.171 ns | 0.0383 ns | 0.0319 ns | 24.165 ns |  1.56 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                      From_ParentClass | .NET Core 2.0 | 13.899 ns | 0.0108 ns | 0.0090 ns | 13.902 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 2.2 | 12.690 ns | 0.0119 ns | 0.0105 ns | 12.692 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 3.0 | 12.632 ns | 0.0739 ns | 0.0692 ns | 12.646 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass |        net461 | 14.465 ns | 0.0126 ns | 0.0112 ns | 14.466 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass |        net472 | 14.454 ns | 0.0594 ns | 0.0555 ns | 14.469 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_ParentClass_AsObject | .NET Core 2.0 | 17.261 ns | 0.0266 ns | 0.0249 ns | 17.254 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 2.2 | 15.219 ns | 0.0249 ns | 0.0233 ns | 15.223 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 3.0 | 16.901 ns | 0.0343 ns | 0.0304 ns | 16.890 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net461 | 24.738 ns | 0.0368 ns | 0.0326 ns | 24.733 ns |  1.43 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net472 | 26.248 ns | 0.0735 ns | 0.0687 ns | 26.247 ns |  1.52 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                              From_ParentClass_NoValue | .NET Core 2.0 | 14.970 ns | 0.0115 ns | 0.0096 ns | 14.970 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 2.2 | 12.831 ns | 0.0399 ns | 0.0374 ns | 12.841 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 3.0 | 12.735 ns | 0.0984 ns | 0.0921 ns | 12.775 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net461 | 15.195 ns | 0.0133 ns | 0.0118 ns | 15.193 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net472 | 14.404 ns | 0.0600 ns | 0.0561 ns | 14.429 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.0 | 14.802 ns | 0.0127 ns | 0.0106 ns | 14.803 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.2 | 12.912 ns | 0.0199 ns | 0.0186 ns | 12.910 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 3.0 | 14.813 ns | 0.0467 ns | 0.0414 ns | 14.821 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net461 | 22.941 ns | 0.0339 ns | 0.0317 ns | 22.935 ns |  1.55 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net472 | 25.532 ns | 0.0291 ns | 0.0258 ns | 25.537 ns |  1.73 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_ParentStruct | .NET Core 2.0 | 43.357 ns | 0.0323 ns | 0.0302 ns | 43.358 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 2.2 | 38.776 ns | 0.1086 ns | 0.1016 ns | 38.736 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 3.0 | 42.845 ns | 0.0517 ns | 0.0432 ns | 42.855 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct |        net461 | 41.905 ns | 0.1154 ns | 0.1023 ns | 41.877 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct |        net472 | 48.005 ns | 0.0512 ns | 0.0453 ns | 47.997 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_ParentStruct_AsObject | .NET Core 2.0 | 17.105 ns | 0.0182 ns | 0.0161 ns | 17.103 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 2.2 | 15.252 ns | 0.0222 ns | 0.0208 ns | 15.257 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 3.0 | 15.401 ns | 0.0271 ns | 0.0226 ns | 15.399 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net461 | 24.659 ns | 0.0631 ns | 0.0590 ns | 24.650 ns |  1.44 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net472 | 26.102 ns | 0.0370 ns | 0.0347 ns | 26.094 ns |  1.53 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.0 | 43.729 ns | 0.0570 ns | 0.0506 ns | 43.740 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.2 | 38.764 ns | 0.0796 ns | 0.0745 ns | 38.770 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 3.0 | 38.810 ns | 0.0267 ns | 0.0223 ns | 38.809 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue |        net461 | 45.222 ns | 0.0449 ns | 0.0398 ns | 45.224 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue |        net472 | 43.049 ns | 0.0649 ns | 0.0575 ns | 43.059 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 17.824 ns | 0.0259 ns | 0.0242 ns | 17.827 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 16.332 ns | 0.0908 ns | 0.0849 ns | 16.276 ns |  0.92 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.394 ns | 0.0264 ns | 0.0247 ns | 15.393 ns |  0.86 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net461 | 24.561 ns | 0.0367 ns | 0.0343 ns | 24.562 ns |  1.38 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net472 | 26.118 ns | 0.0286 ns | 0.0253 ns | 26.119 ns |  1.47 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.0 | 42.746 ns | 0.0443 ns | 0.0393 ns | 42.740 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.2 | 40.635 ns | 0.0327 ns | 0.0306 ns | 40.625 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 3.0 | 40.312 ns | 0.1605 ns | 0.1502 ns | 40.397 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net461 | 41.826 ns | 0.0758 ns | 0.0672 ns | 41.839 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net472 | 40.746 ns | 0.0458 ns | 0.0428 ns | 40.750 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.945 ns | 0.0774 ns | 0.0687 ns | 14.964 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.114 ns | 0.0144 ns | 0.0121 ns | 14.113 ns |  0.94 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 15.049 ns | 0.0194 ns | 0.0181 ns | 15.045 ns |  1.01 |    0.01 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net461 | 23.221 ns | 0.0176 ns | 0.0147 ns | 23.222 ns |  1.55 |    0.01 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net472 | 24.753 ns | 0.0848 ns | 0.0793 ns | 24.779 ns |  1.66 |    0.01 |      - |     - |     - |         - |

Benchmarks with issues:
  ConvertTo_IntNullable.From_DateTime_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_IntNullable.From_DateTime_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_IntNullable.From_DateTime_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_IntNullable.From_DateTime_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_IntNullable.From_DateTime_AsObject: Job-ZVTGBZ(Toolchain=net472)
  ConvertTo_IntNullable.From_DateTime_Nullable_WithValue_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_IntNullable.From_DateTime_Nullable_WithValue_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_IntNullable.From_DateTime_Nullable_WithValue_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_IntNullable.From_DateTime_Nullable_WithValue_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_IntNullable.From_DateTime_Nullable_WithValue_AsObject: Job-ZVTGBZ(Toolchain=net472)
  ConvertTo_IntNullable.From_String_Empty_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_IntNullable.From_String_Empty_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_IntNullable.From_String_Empty_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_IntNullable.From_String_Empty_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_IntNullable.From_String_Empty_AsObject: Job-ZVTGBZ(Toolchain=net472)
