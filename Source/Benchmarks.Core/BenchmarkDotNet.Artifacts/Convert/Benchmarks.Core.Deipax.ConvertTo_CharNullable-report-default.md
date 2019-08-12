
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
                                             From_Bool | .NET Core 2.0 | 11.822 ns | 0.0297 ns | 0.0248 ns | 11.821 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 2.2 | 10.377 ns | 0.0071 ns | 0.0059 ns | 10.377 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 3.0 |  9.725 ns | 0.2143 ns | 0.2105 ns |  9.853 ns |  0.82 |    0.02 |      - |     - |     - |         - |
                                             From_Bool |        net461 | 12.236 ns | 0.0143 ns | 0.0134 ns | 12.235 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                             From_Bool |        net472 | 13.082 ns | 0.0170 ns | 0.0151 ns | 13.085 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Bool_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Bool_Nullable_WithValue | .NET Core 2.0 | 11.815 ns | 0.0198 ns | 0.0185 ns | 11.814 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 2.2 | 10.919 ns | 0.0135 ns | 0.0120 ns | 10.916 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 3.0 |  9.427 ns | 0.0124 ns | 0.0104 ns |  9.427 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net461 | 12.236 ns | 0.0163 ns | 0.0152 ns | 12.238 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net472 | 13.839 ns | 0.0145 ns | 0.0121 ns | 13.838 ns |  1.17 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Bool_Nullable_NoValue | .NET Core 2.0 | 11.814 ns | 0.0182 ns | 0.0152 ns | 11.815 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 2.2 | 10.772 ns | 0.0108 ns | 0.0101 ns | 10.771 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 3.0 |  9.210 ns | 0.0146 ns | 0.0137 ns |  9.211 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net461 | 14.012 ns | 0.0129 ns | 0.0121 ns | 14.015 ns |  1.19 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net472 | 12.929 ns | 0.0141 ns | 0.0132 ns | 12.930 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.061 ns | 0.0245 ns | 0.0230 ns | 15.059 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.2 | 15.189 ns | 0.0119 ns | 0.0105 ns | 15.188 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.111 ns | 0.0168 ns | 0.0149 ns | 13.113 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net461 | 21.732 ns | 0.0335 ns | 0.0279 ns | 21.744 ns |  1.44 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net472 | 22.642 ns | 0.0375 ns | 0.0313 ns | 22.640 ns |  1.50 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Byte | .NET Core 2.0 | 11.829 ns | 0.0100 ns | 0.0094 ns | 11.830 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 2.2 | 10.387 ns | 0.0135 ns | 0.0127 ns | 10.390 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 3.0 |  9.645 ns | 0.0113 ns | 0.0100 ns |  9.649 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                             From_Byte |        net461 | 12.227 ns | 0.0095 ns | 0.0089 ns | 12.226 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                             From_Byte |        net472 | 12.244 ns | 0.0153 ns | 0.0136 ns | 12.247 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Byte_AsObject | .NET Core 2.0 | 19.568 ns | 0.0304 ns | 0.0284 ns | 19.572 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 2.2 | 17.523 ns | 0.0337 ns | 0.0281 ns | 17.530 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 3.0 | 17.346 ns | 0.0491 ns | 0.0384 ns | 17.342 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net461 | 28.952 ns | 0.0531 ns | 0.0471 ns | 28.944 ns |  1.48 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net472 | 27.277 ns | 0.0555 ns | 0.0520 ns | 27.275 ns |  1.39 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Byte_Nullable_WithValue | .NET Core 2.0 | 11.901 ns | 0.0233 ns | 0.0195 ns | 11.897 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 2.2 | 10.790 ns | 0.0087 ns | 0.0072 ns | 10.789 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 3.0 | 10.237 ns | 0.0305 ns | 0.0285 ns | 10.245 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net461 | 12.767 ns | 0.0731 ns | 0.0684 ns | 12.736 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net472 | 12.690 ns | 0.0207 ns | 0.0194 ns | 12.689 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.652 ns | 0.0254 ns | 0.0225 ns | 18.649 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.600 ns | 0.0527 ns | 0.0493 ns | 17.596 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.370 ns | 0.0652 ns | 0.0610 ns | 17.376 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net461 | 27.324 ns | 0.0788 ns | 0.0737 ns | 27.314 ns |  1.46 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net472 | 27.140 ns | 0.0276 ns | 0.0244 ns | 27.142 ns |  1.46 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Byte_Nullable_NoValue | .NET Core 2.0 | 11.840 ns | 0.0171 ns | 0.0160 ns | 11.839 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 2.2 | 10.468 ns | 0.0554 ns | 0.0518 ns | 10.447 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 3.0 |  9.474 ns | 0.0172 ns | 0.0153 ns |  9.469 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net461 | 12.729 ns | 0.0130 ns | 0.0121 ns | 12.731 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net472 | 12.718 ns | 0.0240 ns | 0.0225 ns | 12.710 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.505 ns | 0.0144 ns | 0.0112 ns | 14.506 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.500 ns | 0.0245 ns | 0.0217 ns | 13.502 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.294 ns | 0.0088 ns | 0.0073 ns | 13.295 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net461 | 24.292 ns | 0.1142 ns | 0.1068 ns | 24.264 ns |  1.67 |    0.01 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net472 | 25.832 ns | 0.0282 ns | 0.0264 ns | 25.833 ns |  1.78 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Char | .NET Core 2.0 | 11.784 ns | 0.0164 ns | 0.0146 ns | 11.782 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Char | .NET Core 2.2 | 10.443 ns | 0.0171 ns | 0.0160 ns | 10.445 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                             From_Char | .NET Core 3.0 | 10.043 ns | 0.0776 ns | 0.0726 ns | 10.023 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                                             From_Char |        net461 | 12.224 ns | 0.0233 ns | 0.0182 ns | 12.226 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                             From_Char |        net472 | 12.218 ns | 0.0142 ns | 0.0126 ns | 12.217 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Char_AsObject | .NET Core 2.0 | 23.206 ns | 0.0300 ns | 0.0281 ns | 23.206 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 2.2 | 25.527 ns | 0.0221 ns | 0.0185 ns | 25.531 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 3.0 | 27.241 ns | 0.2256 ns | 0.2110 ns | 27.316 ns |  1.17 |    0.01 |      - |     - |     - |         - |
                                    From_Char_AsObject |        net461 | 35.757 ns | 0.0601 ns | 0.0533 ns | 35.765 ns |  1.54 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject |        net472 | 35.826 ns | 0.0772 ns | 0.0684 ns | 35.811 ns |  1.54 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Char_Nullable_WithValue | .NET Core 2.0 | 11.705 ns | 0.0138 ns | 0.0129 ns | 11.706 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 2.2 | 10.416 ns | 0.0237 ns | 0.0222 ns | 10.412 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 3.0 |  6.959 ns | 0.0143 ns | 0.0134 ns |  6.958 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net461 | 11.730 ns | 0.0176 ns | 0.0165 ns | 11.737 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net472 | 12.596 ns | 0.0221 ns | 0.0196 ns | 12.591 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.0 | 22.608 ns | 0.0229 ns | 0.0191 ns | 22.621 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.2 | 26.726 ns | 0.0809 ns | 0.0675 ns | 26.723 ns |  1.18 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 3.0 | 28.787 ns | 0.0338 ns | 0.0282 ns | 28.796 ns |  1.27 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net461 | 37.223 ns | 0.1108 ns | 0.1037 ns | 37.231 ns |  1.65 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net472 | 35.816 ns | 0.0586 ns | 0.0548 ns | 35.825 ns |  1.58 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Char_Nullable_NoValue | .NET Core 2.0 | 11.472 ns | 0.0167 ns | 0.0140 ns | 11.474 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 2.2 | 10.300 ns | 0.0083 ns | 0.0078 ns | 10.298 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 3.0 |  6.969 ns | 0.0522 ns | 0.0489 ns |  6.989 ns |  0.61 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net461 | 12.496 ns | 0.0153 ns | 0.0143 ns | 12.494 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net472 | 11.748 ns | 0.0295 ns | 0.0261 ns | 11.745 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.797 ns | 0.0144 ns | 0.0134 ns | 14.795 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.386 ns | 0.0148 ns | 0.0123 ns | 13.384 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.121 ns | 0.0130 ns | 0.0122 ns | 13.118 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net461 | 22.618 ns | 0.0307 ns | 0.0272 ns | 22.617 ns |  1.53 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net472 | 22.598 ns | 0.0253 ns | 0.0236 ns | 22.601 ns |  1.53 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                         From_DateTime | .NET Core 2.0 | 12.325 ns | 0.0208 ns | 0.0195 ns | 12.330 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 2.2 | 11.170 ns | 0.0166 ns | 0.0155 ns | 11.171 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 3.0 |  9.890 ns | 0.0127 ns | 0.0112 ns |  9.892 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime |        net461 | 13.000 ns | 0.0148 ns | 0.0116 ns | 13.002 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime |        net472 | 14.600 ns | 0.0114 ns | 0.0101 ns | 14.602 ns |  1.18 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                From_DateTime_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                      From_DateTime_Nullable_WithValue | .NET Core 2.0 | 12.451 ns | 0.0172 ns | 0.0161 ns | 12.455 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 2.2 | 11.957 ns | 0.0198 ns | 0.0175 ns | 11.956 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 3.0 | 10.112 ns | 0.0155 ns | 0.0145 ns | 10.112 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net461 | 13.911 ns | 0.0153 ns | 0.0135 ns | 13.912 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net472 | 13.804 ns | 0.0231 ns | 0.0193 ns | 13.811 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_DateTime_Nullable_NoValue | .NET Core 2.0 | 12.380 ns | 0.0085 ns | 0.0076 ns | 12.380 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 2.2 | 11.903 ns | 0.0138 ns | 0.0122 ns | 11.900 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 3.0 | 10.098 ns | 0.0146 ns | 0.0130 ns | 10.099 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net461 | 13.337 ns | 0.0083 ns | 0.0074 ns | 13.337 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net472 | 14.250 ns | 0.0268 ns | 0.0251 ns | 14.249 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.510 ns | 0.0128 ns | 0.0120 ns | 14.514 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.157 ns | 0.0557 ns | 0.0521 ns | 14.172 ns |  0.98 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.722 ns | 0.2072 ns | 0.1938 ns | 13.611 ns |  0.95 |    0.01 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net461 | 22.638 ns | 0.0431 ns | 0.0382 ns | 22.641 ns |  1.56 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net472 | 22.866 ns | 0.0312 ns | 0.0292 ns | 22.861 ns |  1.58 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                          From_Decimal | .NET Core 2.0 | 12.298 ns | 0.0189 ns | 0.0176 ns | 12.296 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 2.2 | 11.245 ns | 0.0171 ns | 0.0152 ns | 11.246 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 3.0 |  9.895 ns | 0.0156 ns | 0.0146 ns |  9.894 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal |        net461 | 13.378 ns | 0.0111 ns | 0.0098 ns | 13.381 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal |        net472 | 13.775 ns | 0.0279 ns | 0.0233 ns | 13.775 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                 From_Decimal_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                       From_Decimal_Nullable_WithValue | .NET Core 2.0 | 12.487 ns | 0.0236 ns | 0.0221 ns | 12.486 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 2.2 | 12.016 ns | 0.0677 ns | 0.0633 ns | 12.039 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 3.0 | 10.151 ns | 0.0120 ns | 0.0107 ns | 10.151 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net461 | 13.175 ns | 0.0205 ns | 0.0192 ns | 13.168 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net472 | 13.904 ns | 0.0213 ns | 0.0178 ns | 13.902 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Decimal_Nullable_NoValue | .NET Core 2.0 | 12.573 ns | 0.0329 ns | 0.0257 ns | 12.579 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 2.2 | 11.939 ns | 0.0148 ns | 0.0139 ns | 11.936 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 3.0 | 10.315 ns | 0.1848 ns | 0.1728 ns | 10.185 ns |  0.82 |    0.01 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net461 | 13.182 ns | 0.0165 ns | 0.0154 ns | 13.183 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net472 | 14.446 ns | 0.0692 ns | 0.0613 ns | 14.465 ns |  1.15 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.505 ns | 0.0158 ns | 0.0140 ns | 14.506 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.488 ns | 0.0552 ns | 0.0516 ns | 13.507 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.109 ns | 0.0122 ns | 0.0114 ns | 13.111 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net461 | 23.925 ns | 0.0370 ns | 0.0328 ns | 23.926 ns |  1.65 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net472 | 22.582 ns | 0.0237 ns | 0.0210 ns | 22.582 ns |  1.56 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_Double | .NET Core 2.0 | 12.292 ns | 0.0581 ns | 0.0544 ns | 12.278 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 2.2 | 10.455 ns | 0.0113 ns | 0.0105 ns | 10.455 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 3.0 |  9.659 ns | 0.0238 ns | 0.0223 ns |  9.652 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                                           From_Double |        net461 | 13.687 ns | 0.0313 ns | 0.0245 ns | 13.695 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                           From_Double |        net472 | 13.367 ns | 0.0190 ns | 0.0177 ns | 13.367 ns |  1.09 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_Double_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                  From_Double_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                  From_Double_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_Double_Nullable_WithValue | .NET Core 2.0 | 12.273 ns | 0.0167 ns | 0.0148 ns | 12.268 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 2.2 | 12.218 ns | 0.0369 ns | 0.0308 ns | 12.229 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 3.0 | 10.248 ns | 0.0131 ns | 0.0122 ns | 10.248 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net461 | 14.847 ns | 0.0209 ns | 0.0195 ns | 14.851 ns |  1.21 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net472 | 13.870 ns | 0.0263 ns | 0.0233 ns | 13.867 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Double_Nullable_NoValue | .NET Core 2.0 | 12.266 ns | 0.0139 ns | 0.0130 ns | 12.268 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 2.2 | 12.103 ns | 0.0285 ns | 0.0266 ns | 12.093 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 3.0 | 10.103 ns | 0.0151 ns | 0.0118 ns | 10.102 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net461 | 13.269 ns | 0.0215 ns | 0.0201 ns | 13.269 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net472 | 13.838 ns | 0.0194 ns | 0.0181 ns | 13.836 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.685 ns | 0.0183 ns | 0.0172 ns | 14.678 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.419 ns | 0.0118 ns | 0.0110 ns | 13.418 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.229 ns | 0.1640 ns | 0.1534 ns | 13.129 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net461 | 22.551 ns | 0.0302 ns | 0.0283 ns | 22.546 ns |  1.54 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net472 | 22.625 ns | 0.0598 ns | 0.0560 ns | 22.599 ns |  1.54 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_Short | .NET Core 2.0 | 11.842 ns | 0.0226 ns | 0.0201 ns | 11.847 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 2.2 | 11.497 ns | 0.0126 ns | 0.0112 ns | 11.497 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 3.0 |  9.644 ns | 0.0094 ns | 0.0078 ns |  9.647 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                                            From_Short |        net461 | 12.921 ns | 0.0208 ns | 0.0195 ns | 12.915 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                            From_Short |        net472 | 12.988 ns | 0.0172 ns | 0.0153 ns | 12.986 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_Short_AsObject | .NET Core 2.0 | 19.111 ns | 0.0151 ns | 0.0134 ns | 19.115 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 2.2 | 18.537 ns | 0.0208 ns | 0.0185 ns | 18.531 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 3.0 | 18.751 ns | 0.3599 ns | 0.3367 ns | 19.007 ns |  0.98 |    0.02 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net461 | 29.302 ns | 0.0508 ns | 0.0476 ns | 29.294 ns |  1.53 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net472 | 27.369 ns | 0.0213 ns | 0.0177 ns | 27.369 ns |  1.43 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Short_Nullable_WithValue | .NET Core 2.0 | 12.577 ns | 0.0152 ns | 0.0142 ns | 12.575 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 2.2 | 10.676 ns | 0.0112 ns | 0.0099 ns | 10.673 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 3.0 |  9.905 ns | 0.0176 ns | 0.0156 ns |  9.899 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net461 | 14.185 ns | 0.0191 ns | 0.0179 ns | 14.187 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net472 | 13.443 ns | 0.0666 ns | 0.0623 ns | 13.423 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.348 ns | 0.0763 ns | 0.0676 ns | 19.365 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.2 | 18.151 ns | 0.0180 ns | 0.0169 ns | 18.153 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.919 ns | 0.3786 ns | 0.6326 ns | 17.572 ns |  0.96 |    0.04 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net461 | 27.616 ns | 0.0391 ns | 0.0366 ns | 27.622 ns |  1.43 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net472 | 27.268 ns | 0.0448 ns | 0.0374 ns | 27.268 ns |  1.41 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Short_Nullable_NoValue | .NET Core 2.0 | 12.140 ns | 0.0153 ns | 0.0128 ns | 12.139 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 2.2 | 10.398 ns | 0.0166 ns | 0.0147 ns | 10.394 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 3.0 |  9.648 ns | 0.0199 ns | 0.0166 ns |  9.648 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net461 | 12.722 ns | 0.0127 ns | 0.0112 ns | 12.725 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net472 | 12.801 ns | 0.0424 ns | 0.0397 ns | 12.799 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.522 ns | 0.0213 ns | 0.0189 ns | 14.523 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.414 ns | 0.0098 ns | 0.0092 ns | 13.412 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.570 ns | 0.0246 ns | 0.0230 ns | 13.571 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net461 | 22.571 ns | 0.0242 ns | 0.0215 ns | 22.570 ns |  1.55 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net472 | 22.822 ns | 0.0887 ns | 0.0829 ns | 22.832 ns |  1.57 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                              From_Int | .NET Core 2.0 | 12.832 ns | 0.0786 ns | 0.0735 ns | 12.873 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 2.2 | 12.517 ns | 0.0148 ns | 0.0138 ns | 12.519 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                                              From_Int | .NET Core 3.0 | 10.338 ns | 0.0105 ns | 0.0093 ns | 10.339 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                                              From_Int |        net461 | 13.290 ns | 0.0125 ns | 0.0117 ns | 13.289 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                              From_Int |        net472 | 12.952 ns | 0.0111 ns | 0.0093 ns | 12.952 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_Int_AsObject | .NET Core 2.0 | 19.496 ns | 0.0428 ns | 0.0358 ns | 19.482 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 2.2 | 18.267 ns | 0.0155 ns | 0.0137 ns | 18.268 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 3.0 | 18.759 ns | 0.0550 ns | 0.0514 ns | 18.744 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net461 | 27.841 ns | 0.1599 ns | 0.1496 ns | 27.760 ns |  1.43 |    0.01 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net472 | 28.160 ns | 0.0317 ns | 0.0296 ns | 28.162 ns |  1.44 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Int_Nullable_WithValue | .NET Core 2.0 | 13.094 ns | 0.0164 ns | 0.0153 ns | 13.097 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 2.2 | 11.954 ns | 0.0171 ns | 0.0142 ns | 11.953 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 3.0 | 10.153 ns | 0.0137 ns | 0.0115 ns | 10.148 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net461 | 13.412 ns | 0.0116 ns | 0.0103 ns | 13.410 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net472 | 13.455 ns | 0.0502 ns | 0.0470 ns | 13.428 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.619 ns | 0.0599 ns | 0.0561 ns | 19.632 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.2 | 18.385 ns | 0.0279 ns | 0.0247 ns | 18.386 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.729 ns | 0.0525 ns | 0.0491 ns | 18.730 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net461 | 29.540 ns | 0.0461 ns | 0.0431 ns | 29.558 ns |  1.51 |    0.01 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net472 | 27.849 ns | 0.0311 ns | 0.0260 ns | 27.846 ns |  1.42 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_Int_Nullable_NoValue | .NET Core 2.0 | 11.846 ns | 0.0119 ns | 0.0099 ns | 11.845 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 2.2 | 10.462 ns | 0.0119 ns | 0.0111 ns | 10.462 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 3.0 |  9.685 ns | 0.0138 ns | 0.0129 ns |  9.683 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net461 | 12.984 ns | 0.0181 ns | 0.0169 ns | 12.979 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net472 | 12.692 ns | 0.0203 ns | 0.0169 ns | 12.686 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.523 ns | 0.0097 ns | 0.0081 ns | 14.522 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.497 ns | 0.0132 ns | 0.0123 ns | 13.497 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.095 ns | 0.0139 ns | 0.0124 ns | 13.096 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net461 | 22.641 ns | 0.0346 ns | 0.0324 ns | 22.650 ns |  1.56 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net472 | 22.650 ns | 0.0617 ns | 0.0577 ns | 22.643 ns |  1.56 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Long | .NET Core 2.0 | 13.045 ns | 0.0855 ns | 0.0800 ns | 13.077 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Long | .NET Core 2.2 | 12.022 ns | 0.0444 ns | 0.0393 ns | 12.035 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                             From_Long | .NET Core 3.0 |  9.902 ns | 0.0179 ns | 0.0167 ns |  9.900 ns |  0.76 |    0.00 |      - |     - |     - |         - |
                                             From_Long |        net461 | 12.931 ns | 0.0416 ns | 0.0389 ns | 12.912 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                                             From_Long |        net472 | 12.960 ns | 0.0096 ns | 0.0085 ns | 12.959 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Long_AsObject | .NET Core 2.0 | 19.376 ns | 0.0248 ns | 0.0207 ns | 19.376 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 2.2 | 18.250 ns | 0.0276 ns | 0.0258 ns | 18.245 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 3.0 | 18.051 ns | 0.0341 ns | 0.0302 ns | 18.051 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net461 | 28.079 ns | 0.0278 ns | 0.0246 ns | 28.079 ns |  1.45 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net472 | 27.492 ns | 0.0268 ns | 0.0237 ns | 27.496 ns |  1.42 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Long_Nullable_WithValue | .NET Core 2.0 | 14.131 ns | 0.0279 ns | 0.0247 ns | 14.134 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 2.2 | 12.862 ns | 0.0118 ns | 0.0105 ns | 12.861 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 3.0 | 10.709 ns | 0.0319 ns | 0.0298 ns | 10.719 ns |  0.76 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net461 | 14.876 ns | 0.0159 ns | 0.0148 ns | 14.879 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net472 | 14.674 ns | 0.0925 ns | 0.0865 ns | 14.636 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.705 ns | 0.0519 ns | 0.0433 ns | 19.698 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.2 | 18.352 ns | 0.0526 ns | 0.0492 ns | 18.364 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.083 ns | 0.0338 ns | 0.0316 ns | 18.086 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net461 | 29.535 ns | 0.0524 ns | 0.0490 ns | 29.527 ns |  1.50 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net472 | 29.470 ns | 0.0372 ns | 0.0348 ns | 29.453 ns |  1.50 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Long_Nullable_NoValue | .NET Core 2.0 | 12.722 ns | 0.0160 ns | 0.0149 ns | 12.722 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 2.2 | 11.381 ns | 0.0209 ns | 0.0195 ns | 11.384 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 3.0 |  9.900 ns | 0.0095 ns | 0.0089 ns |  9.903 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net461 | 13.546 ns | 0.0471 ns | 0.0440 ns | 13.553 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net472 | 13.544 ns | 0.0216 ns | 0.0191 ns | 13.545 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.921 ns | 0.0748 ns | 0.0700 ns | 15.886 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.589 ns | 0.0120 ns | 0.0106 ns | 13.593 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 3.0 | 16.323 ns | 0.3532 ns | 0.6369 ns | 16.605 ns |  0.99 |    0.05 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net461 | 22.691 ns | 0.0489 ns | 0.0457 ns | 22.688 ns |  1.43 |    0.01 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net472 | 22.413 ns | 0.0356 ns | 0.0316 ns | 22.406 ns |  1.41 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_SByte | .NET Core 2.0 | 11.832 ns | 0.0149 ns | 0.0140 ns | 11.834 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 2.2 | 10.600 ns | 0.0203 ns | 0.0180 ns | 10.604 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 3.0 |  9.663 ns | 0.0190 ns | 0.0168 ns |  9.669 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                            From_SByte |        net461 | 14.478 ns | 0.0173 ns | 0.0162 ns | 14.477 ns |  1.22 |    0.00 |      - |     - |     - |         - |
                                            From_SByte |        net472 | 12.976 ns | 0.0118 ns | 0.0110 ns | 12.974 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_SByte_AsObject | .NET Core 2.0 | 19.816 ns | 0.0308 ns | 0.0273 ns | 19.812 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 2.2 | 18.116 ns | 0.0189 ns | 0.0168 ns | 18.118 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 3.0 | 17.430 ns | 0.0410 ns | 0.0342 ns | 17.426 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net461 | 27.477 ns | 0.0624 ns | 0.0554 ns | 27.489 ns |  1.39 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net472 | 30.052 ns | 0.0230 ns | 0.0204 ns | 30.056 ns |  1.52 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_SByte_Nullable_WithValue | .NET Core 2.0 | 12.492 ns | 0.0939 ns | 0.0878 ns | 12.446 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 2.2 | 10.671 ns | 0.0137 ns | 0.0128 ns | 10.670 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 3.0 | 10.247 ns | 0.0227 ns | 0.0212 ns | 10.245 ns |  0.82 |    0.01 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net461 | 17.089 ns | 0.0247 ns | 0.0219 ns | 17.085 ns |  1.37 |    0.01 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net472 | 13.318 ns | 0.0171 ns | 0.0160 ns | 13.320 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.252 ns | 0.0171 ns | 0.0160 ns | 19.252 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.2 | 18.196 ns | 0.0473 ns | 0.0443 ns | 18.201 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.540 ns | 0.0561 ns | 0.0525 ns | 17.546 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net461 | 26.580 ns | 0.0312 ns | 0.0277 ns | 26.578 ns |  1.38 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net472 | 28.345 ns | 0.1158 ns | 0.1083 ns | 28.378 ns |  1.47 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_SByte_Nullable_NoValue | .NET Core 2.0 | 12.507 ns | 0.0337 ns | 0.0299 ns | 12.498 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 2.2 | 10.444 ns | 0.0289 ns | 0.0256 ns | 10.438 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 3.0 |  9.687 ns | 0.0121 ns | 0.0094 ns |  9.688 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net461 | 12.895 ns | 0.0148 ns | 0.0139 ns | 12.898 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net472 | 12.840 ns | 0.0166 ns | 0.0147 ns | 12.845 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.637 ns | 0.0117 ns | 0.0110 ns | 14.635 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.412 ns | 0.0161 ns | 0.0134 ns | 13.412 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.901 ns | 0.1336 ns | 0.1250 ns | 13.837 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net461 | 24.391 ns | 0.0258 ns | 0.0241 ns | 24.390 ns |  1.67 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net472 | 25.158 ns | 0.0390 ns | 0.0365 ns | 25.160 ns |  1.72 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_Float | .NET Core 2.0 | 12.230 ns | 0.0158 ns | 0.0148 ns | 12.230 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 2.2 | 10.468 ns | 0.0196 ns | 0.0173 ns | 10.471 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 3.0 |  9.891 ns | 0.0217 ns | 0.0181 ns |  9.886 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                                            From_Float |        net461 | 12.669 ns | 0.0209 ns | 0.0195 ns | 12.666 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                            From_Float |        net472 | 13.476 ns | 0.0542 ns | 0.0507 ns | 13.504 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_Float_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                   From_Float_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                   From_Float_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Float_Nullable_WithValue | .NET Core 2.0 | 11.946 ns | 0.0656 ns | 0.0614 ns | 11.948 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 2.2 | 10.809 ns | 0.0199 ns | 0.0177 ns | 10.807 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 3.0 |  9.508 ns | 0.0133 ns | 0.0118 ns |  9.512 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net461 | 12.258 ns | 0.0235 ns | 0.0208 ns | 12.258 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net472 | 12.955 ns | 0.0116 ns | 0.0109 ns | 12.953 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Float_Nullable_NoValue | .NET Core 2.0 | 11.844 ns | 0.0204 ns | 0.0170 ns | 11.849 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 2.2 | 10.823 ns | 0.0158 ns | 0.0140 ns | 10.820 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 3.0 |  9.440 ns | 0.0185 ns | 0.0173 ns |  9.445 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net461 | 12.945 ns | 0.0160 ns | 0.0150 ns | 12.947 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net472 | 12.948 ns | 0.0095 ns | 0.0080 ns | 12.948 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.642 ns | 0.0475 ns | 0.0421 ns | 14.640 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.421 ns | 0.0235 ns | 0.0220 ns | 13.417 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.096 ns | 0.0107 ns | 0.0083 ns | 13.101 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net461 | 22.489 ns | 0.0318 ns | 0.0298 ns | 22.491 ns |  1.54 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net472 | 24.389 ns | 0.0876 ns | 0.0820 ns | 24.375 ns |  1.67 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_String | .NET Core 2.0 | 15.204 ns | 0.0274 ns | 0.0242 ns | 15.205 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 2.2 | 14.183 ns | 0.0167 ns | 0.0157 ns | 14.177 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 3.0 | 15.758 ns | 0.3405 ns | 0.6956 ns | 16.044 ns |  0.98 |    0.06 |      - |     - |     - |         - |
                                           From_String |        net461 | 16.424 ns | 0.0278 ns | 0.0260 ns | 16.428 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                           From_String |        net472 | 16.534 ns | 0.0376 ns | 0.0352 ns | 16.540 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_String_AsObject | .NET Core 2.0 | 19.132 ns | 0.0367 ns | 0.0307 ns | 19.139 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 2.2 | 19.587 ns | 0.0579 ns | 0.0542 ns | 19.585 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 3.0 | 18.049 ns | 0.0557 ns | 0.0521 ns | 18.054 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject |        net461 | 29.746 ns | 0.0388 ns | 0.0344 ns | 29.731 ns |  1.55 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject |        net472 | 27.481 ns | 0.0571 ns | 0.0506 ns | 27.485 ns |  1.44 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                      From_String_Null | .NET Core 2.0 | 13.955 ns | 0.0481 ns | 0.0402 ns | 13.962 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 2.2 | 13.064 ns | 0.0248 ns | 0.0232 ns | 13.069 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 3.0 | 12.669 ns | 0.0213 ns | 0.0166 ns | 12.669 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null |        net461 | 14.527 ns | 0.0248 ns | 0.0220 ns | 14.523 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null |        net472 | 14.513 ns | 0.0263 ns | 0.0233 ns | 14.507 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_String_Null_AsObject | .NET Core 2.0 | 15.843 ns | 0.0240 ns | 0.0224 ns | 15.844 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 2.2 | 13.432 ns | 0.0168 ns | 0.0157 ns | 13.432 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 3.0 | 13.255 ns | 0.0865 ns | 0.0809 ns | 13.284 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net461 | 23.865 ns | 0.0508 ns | 0.0451 ns | 23.885 ns |  1.51 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net472 | 22.648 ns | 0.0385 ns | 0.0360 ns | 22.650 ns |  1.43 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_String_Empty | .NET Core 2.0 | 14.174 ns | 0.0104 ns | 0.0098 ns | 14.173 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 2.2 | 12.911 ns | 0.0198 ns | 0.0165 ns | 12.911 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 3.0 | 13.982 ns | 0.0226 ns | 0.0212 ns | 13.980 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty |        net461 | 14.527 ns | 0.0218 ns | 0.0193 ns | 14.524 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty |        net472 | 14.548 ns | 0.0106 ns | 0.0094 ns | 14.549 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_String_Empty_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_UShort | .NET Core 2.0 | 11.817 ns | 0.0239 ns | 0.0200 ns | 11.822 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 2.2 | 10.439 ns | 0.0165 ns | 0.0146 ns | 10.438 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 3.0 |  9.847 ns | 0.1201 ns | 0.1123 ns |  9.858 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                                           From_UShort |        net461 | 12.211 ns | 0.0134 ns | 0.0125 ns | 12.208 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                           From_UShort |        net472 | 12.328 ns | 0.0654 ns | 0.0611 ns | 12.362 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_UShort_AsObject | .NET Core 2.0 | 18.652 ns | 0.0228 ns | 0.0213 ns | 18.655 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 2.2 | 17.526 ns | 0.0195 ns | 0.0182 ns | 17.524 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 3.0 | 17.304 ns | 0.0259 ns | 0.0230 ns | 17.316 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net461 | 29.495 ns | 0.0196 ns | 0.0174 ns | 29.495 ns |  1.58 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net472 | 27.096 ns | 0.0358 ns | 0.0335 ns | 27.099 ns |  1.45 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_UShort_Nullable_WithValue | .NET Core 2.0 | 11.863 ns | 0.0181 ns | 0.0151 ns | 11.864 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 2.2 | 11.060 ns | 0.0232 ns | 0.0217 ns | 11.064 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 3.0 | 10.107 ns | 0.0076 ns | 0.0059 ns | 10.106 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net461 | 12.714 ns | 0.0172 ns | 0.0152 ns | 12.714 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net472 | 12.722 ns | 0.0208 ns | 0.0184 ns | 12.716 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.832 ns | 0.0695 ns | 0.0616 ns | 18.822 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.649 ns | 0.0286 ns | 0.0253 ns | 17.640 ns |  0.94 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.454 ns | 0.0786 ns | 0.0735 ns | 17.481 ns |  0.93 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net461 | 27.062 ns | 0.0372 ns | 0.0330 ns | 27.059 ns |  1.44 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net472 | 26.942 ns | 0.0422 ns | 0.0353 ns | 26.940 ns |  1.43 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_UShort_Nullable_NoValue | .NET Core 2.0 | 11.844 ns | 0.0147 ns | 0.0138 ns | 11.839 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 2.2 | 10.503 ns | 0.0663 ns | 0.0620 ns | 10.463 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 3.0 |  9.682 ns | 0.0144 ns | 0.0135 ns |  9.683 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net461 | 12.706 ns | 0.0143 ns | 0.0134 ns | 12.707 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net472 | 12.723 ns | 0.0134 ns | 0.0125 ns | 12.726 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.351 ns | 0.0162 ns | 0.0152 ns | 15.353 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.189 ns | 0.0135 ns | 0.0126 ns | 14.189 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.203 ns | 0.0469 ns | 0.0392 ns | 13.215 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net461 | 24.332 ns | 0.0439 ns | 0.0367 ns | 24.330 ns |  1.58 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net472 | 22.758 ns | 0.0485 ns | 0.0430 ns | 22.764 ns |  1.48 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_UInt | .NET Core 2.0 | 11.956 ns | 0.0480 ns | 0.0449 ns | 11.940 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 2.2 | 10.793 ns | 0.0173 ns | 0.0162 ns | 10.795 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 3.0 |  9.731 ns | 0.0321 ns | 0.0300 ns |  9.740 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                                             From_UInt |        net461 | 12.921 ns | 0.0166 ns | 0.0147 ns | 12.920 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                             From_UInt |        net472 | 12.961 ns | 0.0119 ns | 0.0105 ns | 12.961 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_UInt_AsObject | .NET Core 2.0 | 19.576 ns | 0.0234 ns | 0.0195 ns | 19.577 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 2.2 | 19.575 ns | 0.0439 ns | 0.0389 ns | 19.567 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 3.0 | 17.977 ns | 0.0336 ns | 0.0280 ns | 17.973 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net461 | 27.218 ns | 0.0274 ns | 0.0243 ns | 27.228 ns |  1.39 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net472 | 29.515 ns | 0.0311 ns | 0.0276 ns | 29.517 ns |  1.51 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_UInt_Nullable_WithValue | .NET Core 2.0 | 12.055 ns | 0.0257 ns | 0.0241 ns | 12.058 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 2.2 | 10.813 ns | 0.0104 ns | 0.0087 ns | 10.814 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 3.0 | 10.251 ns | 0.0624 ns | 0.0584 ns | 10.273 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net461 | 13.520 ns | 0.0120 ns | 0.0107 ns | 13.518 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net472 | 13.705 ns | 0.0827 ns | 0.0773 ns | 13.755 ns |  1.14 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.116 ns | 0.0222 ns | 0.0185 ns | 19.121 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.996 ns | 0.0359 ns | 0.0300 ns | 18.001 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 3.0 | 19.204 ns | 0.0800 ns | 0.0748 ns | 19.201 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net461 | 27.265 ns | 0.0327 ns | 0.0306 ns | 27.267 ns |  1.43 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net472 | 27.652 ns | 0.0402 ns | 0.0376 ns | 27.646 ns |  1.45 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_UInt_Nullable_NoValue | .NET Core 2.0 | 13.105 ns | 0.0202 ns | 0.0189 ns | 13.097 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 2.2 | 10.358 ns | 0.0146 ns | 0.0130 ns | 10.357 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 3.0 |  9.466 ns | 0.0203 ns | 0.0190 ns |  9.458 ns |  0.72 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net461 | 13.430 ns | 0.0161 ns | 0.0150 ns | 13.433 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net472 | 13.018 ns | 0.0508 ns | 0.0475 ns | 12.999 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.527 ns | 0.0158 ns | 0.0140 ns | 14.523 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.2 | 15.099 ns | 0.0411 ns | 0.0385 ns | 15.095 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.346 ns | 0.0362 ns | 0.0302 ns | 13.330 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net461 | 22.559 ns | 0.0429 ns | 0.0359 ns | 22.566 ns |  1.55 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net472 | 22.562 ns | 0.0299 ns | 0.0280 ns | 22.561 ns |  1.55 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_ULong | .NET Core 2.0 | 12.760 ns | 0.0522 ns | 0.0488 ns | 12.739 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 2.2 | 11.438 ns | 0.0101 ns | 0.0079 ns | 11.437 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 3.0 |  9.997 ns | 0.0501 ns | 0.0444 ns | 10.013 ns |  0.78 |    0.01 |      - |     - |     - |         - |
                                            From_ULong |        net461 | 13.878 ns | 0.0140 ns | 0.0124 ns | 13.881 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                            From_ULong |        net472 | 12.941 ns | 0.0246 ns | 0.0218 ns | 12.939 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_ULong_AsObject | .NET Core 2.0 | 19.856 ns | 0.0210 ns | 0.0196 ns | 19.851 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 2.2 | 18.382 ns | 0.0167 ns | 0.0148 ns | 18.386 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 3.0 | 18.200 ns | 0.0818 ns | 0.0765 ns | 18.176 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net461 | 27.236 ns | 0.0324 ns | 0.0303 ns | 27.228 ns |  1.37 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net472 | 27.581 ns | 0.0561 ns | 0.0468 ns | 27.590 ns |  1.39 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_ULong_Nullable_WithValue | .NET Core 2.0 | 16.962 ns | 0.0222 ns | 0.0197 ns | 16.963 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 2.2 | 12.641 ns | 0.0155 ns | 0.0145 ns | 12.635 ns |  0.75 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 3.0 | 13.759 ns | 0.3725 ns | 1.0259 ns | 14.121 ns |  0.70 |    0.09 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net461 | 14.518 ns | 0.0164 ns | 0.0153 ns | 14.521 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net472 | 14.536 ns | 0.0314 ns | 0.0279 ns | 14.536 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.343 ns | 0.0179 ns | 0.0167 ns | 19.343 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.2 | 18.210 ns | 0.0235 ns | 0.0196 ns | 18.206 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 3.0 | 19.280 ns | 0.4051 ns | 0.6307 ns | 19.610 ns |  0.97 |    0.03 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net461 | 27.243 ns | 0.0284 ns | 0.0252 ns | 27.242 ns |  1.41 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net472 | 27.576 ns | 0.0526 ns | 0.0492 ns | 27.566 ns |  1.43 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_ULong_Nullable_NoValue | .NET Core 2.0 | 12.354 ns | 0.0151 ns | 0.0134 ns | 12.354 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 2.2 | 11.687 ns | 0.0156 ns | 0.0130 ns | 11.686 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 3.0 |  9.910 ns | 0.0125 ns | 0.0111 ns |  9.907 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net461 | 13.319 ns | 0.0201 ns | 0.0188 ns | 13.318 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net472 | 13.267 ns | 0.0168 ns | 0.0149 ns | 13.267 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.679 ns | 0.0324 ns | 0.0303 ns | 14.664 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.518 ns | 0.0310 ns | 0.0290 ns | 13.519 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.099 ns | 0.0199 ns | 0.0166 ns | 13.097 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net461 | 22.650 ns | 0.0387 ns | 0.0323 ns | 22.647 ns |  1.54 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net472 | 21.995 ns | 0.0289 ns | 0.0256 ns | 21.995 ns |  1.50 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                       From_NullObject | .NET Core 2.0 | 14.977 ns | 0.0199 ns | 0.0176 ns | 14.977 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 2.2 | 13.406 ns | 0.0155 ns | 0.0145 ns | 13.408 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 3.0 | 13.166 ns | 0.0632 ns | 0.0591 ns | 13.138 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject |        net461 | 22.566 ns | 0.0497 ns | 0.0415 ns | 22.565 ns |  1.51 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject |        net472 | 25.137 ns | 0.0315 ns | 0.0279 ns | 25.144 ns |  1.68 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_DBNull | .NET Core 2.0 | 12.481 ns | 0.0109 ns | 0.0102 ns | 12.481 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 2.2 | 11.300 ns | 0.0582 ns | 0.0544 ns | 11.277 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 3.0 | 13.049 ns | 0.1709 ns | 0.1598 ns | 13.065 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                                           From_DBNull |        net461 | 13.079 ns | 0.0570 ns | 0.0505 ns | 13.089 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull |        net472 | 12.887 ns | 0.0159 ns | 0.0133 ns | 12.890 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_DBNull_AsObject | .NET Core 2.0 | 15.006 ns | 0.0158 ns | 0.0140 ns | 15.006 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 2.2 | 14.321 ns | 0.0503 ns | 0.0470 ns | 14.318 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 3.0 | 13.701 ns | 0.1840 ns | 0.1721 ns | 13.603 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net461 | 24.420 ns | 0.0358 ns | 0.0335 ns | 24.417 ns |  1.63 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net472 | 24.571 ns | 0.0624 ns | 0.0554 ns | 24.574 ns |  1.64 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                 From_ConvertibleClass | .NET Core 2.0 | 18.550 ns | 0.0178 ns | 0.0148 ns | 18.549 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 2.2 | 14.593 ns | 0.0223 ns | 0.0209 ns | 14.598 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 3.0 | 15.186 ns | 0.0190 ns | 0.0178 ns | 15.193 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net461 | 25.890 ns | 0.0619 ns | 0.0548 ns | 25.873 ns |  1.40 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net472 | 25.767 ns | 0.0336 ns | 0.0314 ns | 25.763 ns |  1.39 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_ConvertibleClass_AsObject | .NET Core 2.0 | 18.195 ns | 0.0194 ns | 0.0172 ns | 18.192 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 2.2 | 18.208 ns | 0.0192 ns | 0.0171 ns | 18.208 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 3.0 | 17.677 ns | 0.3785 ns | 0.5053 ns | 17.305 ns |  0.99 |    0.03 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net461 | 26.307 ns | 0.1408 ns | 0.1248 ns | 26.330 ns |  1.45 |    0.01 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net472 | 29.488 ns | 0.0278 ns | 0.0247 ns | 29.482 ns |  1.62 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_ConvertibleClass_NoValue | .NET Core 2.0 | 14.781 ns | 0.0222 ns | 0.0197 ns | 14.779 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 2.2 | 13.495 ns | 0.0374 ns | 0.0332 ns | 13.501 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 3.0 | 12.923 ns | 0.0233 ns | 0.0195 ns | 12.927 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net461 | 22.696 ns | 0.0181 ns | 0.0151 ns | 22.698 ns |  1.54 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net472 | 25.101 ns | 0.0224 ns | 0.0198 ns | 25.104 ns |  1.70 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.0 | 15.554 ns | 0.0344 ns | 0.0305 ns | 15.543 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.2 | 13.403 ns | 0.0291 ns | 0.0258 ns | 13.398 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 3.0 | 13.103 ns | 0.0144 ns | 0.0113 ns | 13.107 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net461 | 22.645 ns | 0.0513 ns | 0.0428 ns | 22.657 ns |  1.46 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net472 | 22.599 ns | 0.0250 ns | 0.0222 ns | 22.604 ns |  1.45 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                              From_NonConvertibleClass | .NET Core 2.0 | 14.079 ns | 0.0135 ns | 0.0120 ns | 14.078 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 2.2 | 12.217 ns | 0.0102 ns | 0.0095 ns | 12.216 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 3.0 | 12.993 ns | 0.0516 ns | 0.0457 ns | 13.005 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net461 | 14.473 ns | 0.0132 ns | 0.0117 ns | 14.478 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net472 | 14.265 ns | 0.0133 ns | 0.0118 ns | 14.268 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                     From_NonConvertibleClass_AsObject | .NET Core 2.0 | 16.394 ns | 0.0216 ns | 0.0202 ns | 16.396 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 2.2 | 15.241 ns | 0.0184 ns | 0.0172 ns | 15.237 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 3.0 | 14.948 ns | 0.0222 ns | 0.0208 ns | 14.943 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net461 | 25.997 ns | 0.0582 ns | 0.0516 ns | 25.991 ns |  1.59 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net472 | 24.224 ns | 0.0378 ns | 0.0354 ns | 24.231 ns |  1.48 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                      From_NonConvertibleClass_NoValue | .NET Core 2.0 | 14.085 ns | 0.0243 ns | 0.0227 ns | 14.079 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 2.2 | 12.198 ns | 0.0099 ns | 0.0092 ns | 12.197 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 3.0 | 12.586 ns | 0.0555 ns | 0.0464 ns | 12.591 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net461 | 14.965 ns | 0.0111 ns | 0.0087 ns | 14.968 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net472 | 14.965 ns | 0.0172 ns | 0.0152 ns | 14.969 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.0 | 14.545 ns | 0.0175 ns | 0.0163 ns | 14.548 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.2 | 15.170 ns | 0.0126 ns | 0.0118 ns | 15.169 ns |  1.04 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 3.0 | 13.232 ns | 0.0762 ns | 0.0712 ns | 13.264 ns |  0.91 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net461 | 22.712 ns | 0.0388 ns | 0.0363 ns | 22.721 ns |  1.56 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net472 | 24.451 ns | 0.0205 ns | 0.0192 ns | 24.452 ns |  1.68 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                From_ConvertibleStruct | .NET Core 2.0 | 20.288 ns | 0.0264 ns | 0.0247 ns | 20.292 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 2.2 | 16.285 ns | 0.0450 ns | 0.0421 ns | 16.285 ns |  0.80 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 3.0 | 13.499 ns | 0.0594 ns | 0.0464 ns | 13.497 ns |  0.67 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net461 | 19.097 ns | 0.0463 ns | 0.0433 ns | 19.102 ns |  0.94 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net472 | 19.288 ns | 0.0896 ns | 0.0795 ns | 19.296 ns |  0.95 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                       From_ConvertibleStruct_AsObject | .NET Core 2.0 | 18.708 ns | 0.0277 ns | 0.0246 ns | 18.705 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 2.2 | 17.781 ns | 0.0248 ns | 0.0220 ns | 17.781 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 3.0 | 17.536 ns | 0.0793 ns | 0.0742 ns | 17.531 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net461 | 28.375 ns | 0.0351 ns | 0.0311 ns | 28.372 ns |  1.52 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net472 | 25.952 ns | 0.0285 ns | 0.0238 ns | 25.955 ns |  1.39 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.0 | 20.597 ns | 0.0970 ns | 0.0908 ns | 20.580 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.2 | 16.322 ns | 0.0466 ns | 0.0364 ns | 16.325 ns |  0.79 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 3.0 | 13.971 ns | 0.0858 ns | 0.0803 ns | 13.990 ns |  0.68 |    0.01 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net461 | 26.863 ns | 0.0368 ns | 0.0344 ns | 26.865 ns |  1.30 |    0.01 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net472 | 24.552 ns | 0.0300 ns | 0.0280 ns | 24.555 ns |  1.19 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.519 ns | 0.0202 ns | 0.0179 ns | 20.522 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.984 ns | 0.0167 ns | 0.0148 ns | 17.984 ns |  0.88 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.450 ns | 0.0543 ns | 0.0508 ns | 17.450 ns |  0.85 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net461 | 26.580 ns | 0.0609 ns | 0.0540 ns | 26.584 ns |  1.30 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net472 | 26.854 ns | 0.0725 ns | 0.0679 ns | 26.863 ns |  1.31 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.0 | 13.861 ns | 0.0108 ns | 0.0090 ns | 13.861 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.2 | 11.997 ns | 0.0089 ns | 0.0074 ns | 11.997 ns |  0.87 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 3.0 | 10.126 ns | 0.0125 ns | 0.0117 ns | 10.126 ns |  0.73 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net461 | 19.293 ns | 0.0387 ns | 0.0362 ns | 19.290 ns |  1.39 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net472 | 22.688 ns | 0.0759 ns | 0.0672 ns | 22.672 ns |  1.64 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.545 ns | 0.0133 ns | 0.0118 ns | 14.544 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.388 ns | 0.0163 ns | 0.0145 ns | 13.382 ns |  0.92 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.485 ns | 0.0511 ns | 0.0478 ns | 13.489 ns |  0.93 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net461 | 22.615 ns | 0.0268 ns | 0.0251 ns | 22.625 ns |  1.55 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net472 | 22.645 ns | 0.0410 ns | 0.0363 ns | 22.654 ns |  1.56 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_NonConvertibleStruct | .NET Core 2.0 | 13.305 ns | 0.0102 ns | 0.0096 ns | 13.304 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 2.2 | 10.324 ns | 0.0276 ns | 0.0258 ns | 10.317 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 3.0 |  9.461 ns | 0.0364 ns | 0.0284 ns |  9.451 ns |  0.71 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net461 | 12.252 ns | 0.0538 ns | 0.0503 ns | 12.225 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net472 | 13.357 ns | 0.0141 ns | 0.0132 ns | 13.358 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.0 | 16.377 ns | 0.0209 ns | 0.0185 ns | 16.380 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.2 | 15.246 ns | 0.0174 ns | 0.0163 ns | 15.242 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 3.0 | 15.433 ns | 0.0394 ns | 0.0349 ns | 15.441 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net461 | 26.525 ns | 0.1121 ns | 0.0994 ns | 26.558 ns |  1.62 |    0.01 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net472 | 24.183 ns | 0.0434 ns | 0.0363 ns | 24.183 ns |  1.48 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.0 | 13.163 ns | 0.0247 ns | 0.0231 ns | 13.159 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.2 | 11.393 ns | 0.0120 ns | 0.0107 ns | 11.399 ns |  0.87 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 3.0 | 10.056 ns | 0.2247 ns | 0.3363 ns | 10.230 ns |  0.75 |    0.03 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net461 | 12.236 ns | 0.0106 ns | 0.0089 ns | 12.234 ns |  0.93 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net472 | 12.928 ns | 0.0260 ns | 0.0231 ns | 12.928 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 16.543 ns | 0.0147 ns | 0.0138 ns | 16.545 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 16.383 ns | 0.0224 ns | 0.0209 ns | 16.377 ns |  0.99 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.081 ns | 0.0894 ns | 0.0836 ns | 15.115 ns |  0.91 |    0.01 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net461 | 24.646 ns | 0.0363 ns | 0.0303 ns | 24.656 ns |  1.49 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net472 | 24.307 ns | 0.0430 ns | 0.0402 ns | 24.295 ns |  1.47 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.0 | 13.163 ns | 0.0125 ns | 0.0117 ns | 13.161 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.2 | 10.310 ns | 0.0147 ns | 0.0123 ns | 10.311 ns |  0.78 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 3.0 |  9.443 ns | 0.0166 ns | 0.0156 ns |  9.443 ns |  0.72 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net461 | 12.339 ns | 0.0156 ns | 0.0138 ns | 12.342 ns |  0.94 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net472 | 12.927 ns | 0.0311 ns | 0.0276 ns | 12.915 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.636 ns | 0.0785 ns | 0.0734 ns | 14.673 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.143 ns | 0.0217 ns | 0.0181 ns | 14.141 ns |  0.97 |    0.01 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.139 ns | 0.0234 ns | 0.0219 ns | 13.136 ns |  0.90 |    0.01 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net461 | 22.600 ns | 0.0537 ns | 0.0503 ns | 22.605 ns |  1.54 |    0.01 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net472 | 24.384 ns | 0.0520 ns | 0.0461 ns | 24.372 ns |  1.67 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Enum | .NET Core 2.0 | 13.342 ns | 0.0199 ns | 0.0177 ns | 13.342 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 2.2 | 15.967 ns | 0.0150 ns | 0.0133 ns | 15.967 ns |  1.20 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 3.0 |  9.958 ns | 0.0389 ns | 0.0364 ns |  9.971 ns |  0.75 |    0.00 |      - |     - |     - |         - |
                                             From_Enum |        net461 | 12.891 ns | 0.0169 ns | 0.0142 ns | 12.887 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                             From_Enum |        net472 | 13.356 ns | 0.0261 ns | 0.0232 ns | 13.356 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Enum_AsObject | .NET Core 2.0 | 47.335 ns | 0.0754 ns | 0.0668 ns | 47.360 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject | .NET Core 2.2 | 44.444 ns | 0.0704 ns | 0.0659 ns | 44.456 ns |  0.94 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject | .NET Core 3.0 | 41.543 ns | 0.1371 ns | 0.1215 ns | 41.563 ns |  0.88 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject |        net461 | 53.564 ns | 0.0643 ns | 0.0570 ns | 53.556 ns |  1.13 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject |        net472 | 50.533 ns | 0.1107 ns | 0.0981 ns | 50.536 ns |  1.07 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Enum_Nullable_WithValue | .NET Core 2.0 | 15.353 ns | 0.0350 ns | 0.0328 ns | 15.359 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 2.2 | 13.983 ns | 0.0131 ns | 0.0123 ns | 13.985 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 3.0 | 10.594 ns | 0.0101 ns | 0.0095 ns | 10.596 ns |  0.69 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net461 | 13.418 ns | 0.0275 ns | 0.0244 ns | 13.419 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net472 | 13.436 ns | 0.0299 ns | 0.0280 ns | 13.446 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.0 | 46.743 ns | 0.0514 ns | 0.0481 ns | 46.756 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.2 | 44.021 ns | 0.0560 ns | 0.0497 ns | 44.037 ns |  0.94 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 3.0 | 41.539 ns | 0.8297 ns | 1.1076 ns | 41.785 ns |  0.88 |    0.02 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject |        net461 | 53.834 ns | 0.1432 ns | 0.1340 ns | 53.828 ns |  1.15 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject |        net472 | 57.752 ns | 0.1349 ns | 0.1195 ns | 57.717 ns |  1.24 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Enum_Nullable_NoValue | .NET Core 2.0 | 12.271 ns | 0.0184 ns | 0.0163 ns | 12.267 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 2.2 | 11.504 ns | 0.0160 ns | 0.0149 ns | 11.507 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 3.0 |  9.474 ns | 0.0122 ns | 0.0114 ns |  9.474 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net461 | 12.715 ns | 0.0175 ns | 0.0163 ns | 12.713 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net472 | 12.909 ns | 0.0320 ns | 0.0267 ns | 12.907 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.492 ns | 0.0144 ns | 0.0120 ns | 14.489 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.809 ns | 0.0258 ns | 0.0228 ns | 13.806 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.976 ns | 0.3545 ns | 0.3316 ns | 14.794 ns |  1.03 |    0.02 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net461 | 21.569 ns | 0.1536 ns | 0.1437 ns | 21.553 ns |  1.49 |    0.01 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net472 | 22.605 ns | 0.0342 ns | 0.0320 ns | 22.603 ns |  1.56 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                      From_ParentClass | .NET Core 2.0 | 14.495 ns | 0.0125 ns | 0.0117 ns | 14.495 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 2.2 | 12.256 ns | 0.0169 ns | 0.0158 ns | 12.257 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 3.0 | 13.040 ns | 0.0642 ns | 0.0601 ns | 13.062 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass |        net461 | 14.413 ns | 0.0238 ns | 0.0222 ns | 14.412 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass |        net472 | 14.340 ns | 0.0223 ns | 0.0208 ns | 14.342 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_ParentClass_AsObject | .NET Core 2.0 | 16.862 ns | 0.0665 ns | 0.0622 ns | 16.841 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 2.2 | 15.759 ns | 0.0241 ns | 0.0201 ns | 15.755 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 3.0 | 15.249 ns | 0.0514 ns | 0.0455 ns | 15.267 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net461 | 24.610 ns | 0.0431 ns | 0.0403 ns | 24.612 ns |  1.46 |    0.01 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net472 | 24.799 ns | 0.0905 ns | 0.0846 ns | 24.795 ns |  1.47 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                              From_ParentClass_NoValue | .NET Core 2.0 | 14.346 ns | 0.0172 ns | 0.0161 ns | 14.350 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 2.2 | 12.322 ns | 0.0109 ns | 0.0102 ns | 12.321 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 3.0 | 12.961 ns | 0.0218 ns | 0.0194 ns | 12.962 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net461 | 14.301 ns | 0.0482 ns | 0.0451 ns | 14.280 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net472 | 14.313 ns | 0.0132 ns | 0.0117 ns | 14.313 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.0 | 14.654 ns | 0.0146 ns | 0.0122 ns | 14.656 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.2 | 14.044 ns | 0.0203 ns | 0.0180 ns | 14.040 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 3.0 | 14.828 ns | 0.0963 ns | 0.0901 ns | 14.792 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net461 | 22.746 ns | 0.0307 ns | 0.0287 ns | 22.741 ns |  1.55 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net472 | 22.620 ns | 0.0358 ns | 0.0335 ns | 22.623 ns |  1.54 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_ParentStruct | .NET Core 2.0 | 47.160 ns | 0.0314 ns | 0.0294 ns | 47.171 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 2.2 | 39.132 ns | 0.0392 ns | 0.0327 ns | 39.137 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 3.0 | 38.245 ns | 0.0641 ns | 0.0568 ns | 38.248 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct |        net461 | 42.388 ns | 0.0537 ns | 0.0449 ns | 42.399 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct |        net472 | 43.623 ns | 0.0542 ns | 0.0507 ns | 43.626 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_ParentStruct_AsObject | .NET Core 2.0 | 16.811 ns | 0.0246 ns | 0.0192 ns | 16.811 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 2.2 | 15.910 ns | 0.0289 ns | 0.0270 ns | 15.918 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 3.0 | 15.399 ns | 0.0182 ns | 0.0161 ns | 15.398 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net461 | 24.393 ns | 0.0474 ns | 0.0420 ns | 24.398 ns |  1.45 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net472 | 26.344 ns | 0.0441 ns | 0.0413 ns | 26.347 ns |  1.57 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.0 | 42.718 ns | 0.0541 ns | 0.0506 ns | 42.717 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.2 | 39.173 ns | 0.0658 ns | 0.0550 ns | 39.179 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 3.0 | 38.324 ns | 0.6902 ns | 0.6456 ns | 38.015 ns |  0.90 |    0.02 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue |        net461 | 40.272 ns | 0.0472 ns | 0.0441 ns | 40.260 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue |        net472 | 48.201 ns | 0.0521 ns | 0.0487 ns | 48.203 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 16.855 ns | 0.0197 ns | 0.0175 ns | 16.856 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 16.298 ns | 0.0194 ns | 0.0172 ns | 16.294 ns |  0.97 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.765 ns | 0.2818 ns | 0.2498 ns | 15.883 ns |  0.94 |    0.01 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net461 | 26.145 ns | 0.0443 ns | 0.0415 ns | 26.146 ns |  1.55 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net472 | 24.564 ns | 0.0575 ns | 0.0538 ns | 24.568 ns |  1.46 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.0 | 42.075 ns | 0.0624 ns | 0.0553 ns | 42.073 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.2 | 38.780 ns | 0.0573 ns | 0.0478 ns | 38.768 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 3.0 | 37.919 ns | 0.0439 ns | 0.0411 ns | 37.926 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net461 | 40.813 ns | 0.0478 ns | 0.0424 ns | 40.818 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net472 | 44.661 ns | 0.1753 ns | 0.1640 ns | 44.633 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.639 ns | 0.0135 ns | 0.0126 ns | 14.640 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.388 ns | 0.0162 ns | 0.0144 ns | 13.388 ns |  0.91 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 15.040 ns | 0.1858 ns | 0.1738 ns | 14.927 ns |  1.03 |    0.01 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net461 | 22.656 ns | 0.0477 ns | 0.0446 ns | 22.658 ns |  1.55 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net472 | 22.572 ns | 0.0415 ns | 0.0347 ns | 22.572 ns |  1.54 |    0.00 |      - |     - |     - |         - |

Benchmarks with issues:
  ConvertTo_CharNullable.From_Bool_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_CharNullable.From_Bool_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_CharNullable.From_Bool_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_CharNullable.From_Bool_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_CharNullable.From_Bool_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_CharNullable.From_Bool_Nullable_WithValue_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_CharNullable.From_Bool_Nullable_WithValue_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_CharNullable.From_Bool_Nullable_WithValue_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_CharNullable.From_Bool_Nullable_WithValue_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_CharNullable.From_Bool_Nullable_WithValue_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_CharNullable.From_DateTime_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_CharNullable.From_DateTime_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_CharNullable.From_DateTime_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_CharNullable.From_DateTime_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_CharNullable.From_DateTime_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_CharNullable.From_DateTime_Nullable_WithValue_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_CharNullable.From_DateTime_Nullable_WithValue_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_CharNullable.From_DateTime_Nullable_WithValue_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_CharNullable.From_DateTime_Nullable_WithValue_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_CharNullable.From_DateTime_Nullable_WithValue_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_CharNullable.From_Decimal_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_CharNullable.From_Decimal_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_CharNullable.From_Decimal_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_CharNullable.From_Decimal_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_CharNullable.From_Decimal_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_CharNullable.From_Decimal_Nullable_WithValue_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_CharNullable.From_Decimal_Nullable_WithValue_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_CharNullable.From_Decimal_Nullable_WithValue_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_CharNullable.From_Decimal_Nullable_WithValue_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_CharNullable.From_Decimal_Nullable_WithValue_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_CharNullable.From_Double_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_CharNullable.From_Double_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_CharNullable.From_Double_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_CharNullable.From_Double_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_CharNullable.From_Double_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_CharNullable.From_Double_Nullable_WithValue_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_CharNullable.From_Double_Nullable_WithValue_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_CharNullable.From_Double_Nullable_WithValue_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_CharNullable.From_Double_Nullable_WithValue_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_CharNullable.From_Double_Nullable_WithValue_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_CharNullable.From_Float_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_CharNullable.From_Float_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_CharNullable.From_Float_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_CharNullable.From_Float_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_CharNullable.From_Float_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_CharNullable.From_Float_Nullable_WithValue_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_CharNullable.From_Float_Nullable_WithValue_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_CharNullable.From_Float_Nullable_WithValue_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_CharNullable.From_Float_Nullable_WithValue_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_CharNullable.From_Float_Nullable_WithValue_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_CharNullable.From_String_Empty_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_CharNullable.From_String_Empty_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_CharNullable.From_String_Empty_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_CharNullable.From_String_Empty_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_CharNullable.From_String_Empty_AsObject: Job-PJAXXB(Toolchain=net472)
