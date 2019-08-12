
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
                                             From_Bool | .NET Core 2.0 | 13.154 ns | 0.0383 ns | 0.0359 ns | 13.162 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 2.2 | 10.375 ns | 0.0156 ns | 0.0146 ns | 10.376 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 3.0 |  7.407 ns | 0.0147 ns | 0.0137 ns |  7.407 ns |  0.56 |    0.00 |      - |     - |     - |         - |
                                             From_Bool |        net461 | 10.439 ns | 0.0157 ns | 0.0147 ns | 10.433 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                                             From_Bool |        net472 | 10.458 ns | 0.0144 ns | 0.0128 ns | 10.458 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Bool_AsObject | .NET Core 2.0 | 17.319 ns | 0.0231 ns | 0.0205 ns | 17.317 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 2.2 | 16.972 ns | 0.0422 ns | 0.0395 ns | 16.965 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 3.0 | 17.537 ns | 0.1858 ns | 0.1738 ns | 17.552 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net461 | 17.864 ns | 0.0256 ns | 0.0239 ns | 17.866 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net472 | 18.107 ns | 0.0383 ns | 0.0339 ns | 18.109 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Bool_Nullable_WithValue | .NET Core 2.0 | 12.017 ns | 0.0684 ns | 0.0640 ns | 12.041 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 2.2 | 10.535 ns | 0.0206 ns | 0.0182 ns | 10.533 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 3.0 |  6.828 ns | 0.0106 ns | 0.0094 ns |  6.828 ns |  0.57 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net461 | 10.729 ns | 0.0326 ns | 0.0305 ns | 10.723 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net472 | 10.675 ns | 0.0121 ns | 0.0113 ns | 10.675 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.0 | 16.751 ns | 0.0266 ns | 0.0249 ns | 16.755 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.2 | 16.288 ns | 0.0545 ns | 0.0510 ns | 16.288 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 3.0 | 16.854 ns | 0.0973 ns | 0.0911 ns | 16.851 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net461 | 18.111 ns | 0.0214 ns | 0.0189 ns | 18.115 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net472 | 18.220 ns | 0.0332 ns | 0.0311 ns | 18.224 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Bool_Nullable_NoValue | .NET Core 2.0 | 12.301 ns | 0.0225 ns | 0.0200 ns | 12.295 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 2.2 | 10.289 ns | 0.0207 ns | 0.0194 ns | 10.286 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 3.0 |  6.684 ns | 0.0284 ns | 0.0251 ns |  6.688 ns |  0.54 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net461 | 10.481 ns | 0.0108 ns | 0.0101 ns | 10.482 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net472 | 10.374 ns | 0.0090 ns | 0.0080 ns | 10.376 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.128 ns | 0.0148 ns | 0.0139 ns | 13.127 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.544 ns | 0.0070 ns | 0.0059 ns | 13.546 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.243 ns | 0.0291 ns | 0.0272 ns | 11.238 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net461 | 13.172 ns | 0.0257 ns | 0.0240 ns | 13.169 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net472 | 19.066 ns | 0.0264 ns | 0.0247 ns | 19.074 ns |  1.45 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Byte | .NET Core 2.0 | 11.668 ns | 0.0170 ns | 0.0142 ns | 11.663 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 2.2 | 10.846 ns | 0.0119 ns | 0.0111 ns | 10.844 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 3.0 |  6.708 ns | 0.0906 ns | 0.0847 ns |  6.764 ns |  0.58 |    0.01 |      - |     - |     - |         - |
                                             From_Byte |        net461 | 10.409 ns | 0.0811 ns | 0.0719 ns | 10.417 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                                             From_Byte |        net472 | 10.360 ns | 0.0298 ns | 0.0249 ns | 10.361 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Byte_AsObject | .NET Core 2.0 | 17.498 ns | 0.0143 ns | 0.0134 ns | 17.496 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 2.2 | 15.750 ns | 0.0394 ns | 0.0368 ns | 15.747 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 3.0 | 15.305 ns | 0.0333 ns | 0.0295 ns | 15.312 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net461 | 18.389 ns | 0.0300 ns | 0.0266 ns | 18.385 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net472 | 18.456 ns | 0.0357 ns | 0.0334 ns | 18.462 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Byte_Nullable_WithValue | .NET Core 2.0 | 11.817 ns | 0.0228 ns | 0.0213 ns | 11.815 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 2.2 | 10.421 ns | 0.0122 ns | 0.0108 ns | 10.418 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 3.0 |  6.935 ns | 0.0095 ns | 0.0089 ns |  6.935 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net461 | 11.262 ns | 0.0425 ns | 0.0397 ns | 11.245 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net472 | 10.627 ns | 0.0262 ns | 0.0245 ns | 10.618 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.396 ns | 0.0253 ns | 0.0225 ns | 18.389 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.2 | 16.374 ns | 0.0705 ns | 0.0659 ns | 16.377 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 3.0 | 16.050 ns | 0.0243 ns | 0.0227 ns | 16.042 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net461 | 18.093 ns | 0.0326 ns | 0.0305 ns | 18.093 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net472 | 18.243 ns | 0.0371 ns | 0.0328 ns | 18.255 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Byte_Nullable_NoValue | .NET Core 2.0 | 11.589 ns | 0.0157 ns | 0.0147 ns | 11.592 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 2.2 | 10.320 ns | 0.0157 ns | 0.0147 ns | 10.317 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 3.0 |  6.896 ns | 0.0532 ns | 0.0498 ns |  6.870 ns |  0.60 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net461 | 10.395 ns | 0.0145 ns | 0.0121 ns | 10.395 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net472 | 10.243 ns | 0.0107 ns | 0.0100 ns | 10.244 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.574 ns | 0.0132 ns | 0.0123 ns | 14.574 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.646 ns | 0.0301 ns | 0.0281 ns | 13.643 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.287 ns | 0.2454 ns | 0.2295 ns | 14.372 ns |  0.98 |    0.02 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net461 | 13.052 ns | 0.0202 ns | 0.0189 ns | 13.052 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net472 | 15.453 ns | 0.0133 ns | 0.0118 ns | 15.451 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Char | .NET Core 2.0 | 11.663 ns | 0.0108 ns | 0.0096 ns | 11.660 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Char | .NET Core 2.2 | 10.791 ns | 0.0195 ns | 0.0172 ns | 10.794 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                             From_Char | .NET Core 3.0 |  8.120 ns | 0.1891 ns | 0.4268 ns |  8.245 ns |  0.66 |    0.07 |      - |     - |     - |         - |
                                             From_Char |        net461 | 10.268 ns | 0.0146 ns | 0.0137 ns | 10.270 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                             From_Char |        net472 | 10.407 ns | 0.0177 ns | 0.0166 ns | 10.401 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Char_AsObject | .NET Core 2.0 | 20.282 ns | 0.0148 ns | 0.0138 ns | 20.282 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 2.2 | 17.196 ns | 0.0414 ns | 0.0387 ns | 17.204 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 3.0 | 16.224 ns | 0.0907 ns | 0.0848 ns | 16.253 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject |        net461 | 19.573 ns | 0.0171 ns | 0.0151 ns | 19.576 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject |        net472 | 18.044 ns | 0.0300 ns | 0.0281 ns | 18.038 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Char_Nullable_WithValue | .NET Core 2.0 | 11.940 ns | 0.0096 ns | 0.0090 ns | 11.942 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 2.2 | 10.420 ns | 0.0096 ns | 0.0085 ns | 10.417 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 3.0 |  6.897 ns | 0.0207 ns | 0.0184 ns |  6.891 ns |  0.58 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net461 | 10.687 ns | 0.0128 ns | 0.0114 ns | 10.686 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net472 | 11.216 ns | 0.0169 ns | 0.0150 ns | 11.219 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.0 | 17.265 ns | 0.0232 ns | 0.0217 ns | 17.268 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.2 | 16.623 ns | 0.0141 ns | 0.0118 ns | 16.626 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 3.0 | 16.444 ns | 0.0241 ns | 0.0226 ns | 16.444 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net461 | 17.958 ns | 0.0156 ns | 0.0139 ns | 17.960 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net472 | 18.093 ns | 0.0644 ns | 0.0571 ns | 18.084 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Char_Nullable_NoValue | .NET Core 2.0 | 11.653 ns | 0.0141 ns | 0.0125 ns | 11.653 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 2.2 | 10.313 ns | 0.0133 ns | 0.0125 ns | 10.316 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 3.0 |  6.646 ns | 0.0817 ns | 0.0724 ns |  6.658 ns |  0.57 |    0.01 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net461 | 10.389 ns | 0.0198 ns | 0.0186 ns | 10.382 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net472 | 10.242 ns | 0.0111 ns | 0.0104 ns | 10.237 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.039 ns | 0.0213 ns | 0.0200 ns | 14.042 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.702 ns | 0.0102 ns | 0.0091 ns | 12.702 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.391 ns | 0.0643 ns | 0.0502 ns | 11.403 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net461 | 13.044 ns | 0.0163 ns | 0.0152 ns | 13.040 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net472 | 13.186 ns | 0.0202 ns | 0.0169 ns | 13.186 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                         From_DateTime | .NET Core 2.0 | 11.945 ns | 0.0186 ns | 0.0174 ns | 11.944 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 2.2 | 11.134 ns | 0.0130 ns | 0.0116 ns | 11.131 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 3.0 |  8.427 ns | 0.1069 ns | 0.1000 ns |  8.437 ns |  0.71 |    0.01 |      - |     - |     - |         - |
                                         From_DateTime |        net461 | 14.073 ns | 0.0160 ns | 0.0142 ns | 14.073 ns |  1.18 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime |        net472 | 12.961 ns | 0.0185 ns | 0.0173 ns | 12.963 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                From_DateTime_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                      From_DateTime_Nullable_WithValue | .NET Core 2.0 | 12.570 ns | 0.0184 ns | 0.0172 ns | 12.565 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 2.2 | 11.740 ns | 0.0143 ns | 0.0127 ns | 11.740 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 3.0 |  9.419 ns | 0.2136 ns | 0.5036 ns |  9.587 ns |  0.70 |    0.07 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net461 | 13.223 ns | 0.0088 ns | 0.0082 ns | 13.223 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net472 | 13.207 ns | 0.0177 ns | 0.0148 ns | 13.207 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_DateTime_Nullable_NoValue | .NET Core 2.0 | 12.567 ns | 0.0171 ns | 0.0160 ns | 12.569 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 2.2 | 12.029 ns | 0.0166 ns | 0.0156 ns | 12.030 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 3.0 |  8.305 ns | 0.1881 ns | 0.2928 ns |  8.441 ns |  0.65 |    0.03 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net461 | 13.925 ns | 0.0262 ns | 0.0219 ns | 13.922 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net472 | 13.201 ns | 0.0185 ns | 0.0173 ns | 13.199 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.149 ns | 0.0388 ns | 0.0363 ns | 14.153 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.467 ns | 0.0211 ns | 0.0187 ns | 13.461 ns |  0.95 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.735 ns | 0.0333 ns | 0.0311 ns | 13.734 ns |  0.97 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net461 | 14.923 ns | 0.0111 ns | 0.0092 ns | 14.926 ns |  1.06 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net472 | 13.253 ns | 0.0216 ns | 0.0202 ns | 13.255 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                          From_Decimal | .NET Core 2.0 | 25.414 ns | 0.0320 ns | 0.0284 ns | 25.412 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 2.2 | 23.464 ns | 0.0245 ns | 0.0218 ns | 23.464 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 3.0 | 14.708 ns | 0.0392 ns | 0.0367 ns | 14.722 ns |  0.58 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal |        net461 | 26.293 ns | 0.0277 ns | 0.0245 ns | 26.297 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal |        net472 | 26.227 ns | 0.0509 ns | 0.0476 ns | 26.215 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                 From_Decimal_AsObject | .NET Core 2.0 | 26.596 ns | 0.0377 ns | 0.0334 ns | 26.601 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 2.2 | 25.325 ns | 0.0286 ns | 0.0268 ns | 25.333 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 3.0 | 21.708 ns | 0.0893 ns | 0.0835 ns | 21.673 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net461 | 26.820 ns | 0.0133 ns | 0.0118 ns | 26.820 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net472 | 29.687 ns | 0.0291 ns | 0.0272 ns | 29.692 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                       From_Decimal_Nullable_WithValue | .NET Core 2.0 | 25.794 ns | 0.0151 ns | 0.0134 ns | 25.795 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 2.2 | 23.240 ns | 0.0693 ns | 0.0615 ns | 23.223 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 3.0 | 17.488 ns | 0.3237 ns | 0.3028 ns | 17.614 ns |  0.68 |    0.01 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net461 | 25.140 ns | 0.1310 ns | 0.1226 ns | 25.184 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net472 | 26.420 ns | 0.0429 ns | 0.0380 ns | 26.424 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.0 | 27.049 ns | 0.0239 ns | 0.0224 ns | 27.051 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.2 | 28.120 ns | 0.0297 ns | 0.0277 ns | 28.119 ns |  1.04 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 3.0 | 20.638 ns | 0.0452 ns | 0.0423 ns | 20.626 ns |  0.76 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net461 | 27.930 ns | 0.0322 ns | 0.0286 ns | 27.925 ns |  1.03 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net472 | 27.057 ns | 0.0359 ns | 0.0336 ns | 27.049 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Decimal_Nullable_NoValue | .NET Core 2.0 | 12.900 ns | 0.1630 ns | 0.1524 ns | 12.887 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 2.2 | 11.383 ns | 0.0100 ns | 0.0083 ns | 11.381 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 3.0 |  8.015 ns | 0.0889 ns | 0.0831 ns |  8.069 ns |  0.62 |    0.01 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net461 | 13.424 ns | 0.0125 ns | 0.0117 ns | 13.426 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net472 | 13.437 ns | 0.0109 ns | 0.0091 ns | 13.439 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.365 ns | 0.0136 ns | 0.0106 ns | 13.362 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.461 ns | 0.0148 ns | 0.0131 ns | 13.463 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.330 ns | 0.0358 ns | 0.0335 ns | 11.329 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net461 | 13.096 ns | 0.0990 ns | 0.0926 ns | 13.068 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net472 | 13.185 ns | 0.0204 ns | 0.0191 ns | 13.178 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_Double | .NET Core 2.0 | 13.829 ns | 0.0135 ns | 0.0119 ns | 13.831 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 2.2 | 12.329 ns | 0.0307 ns | 0.0287 ns | 12.332 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 3.0 |  9.680 ns | 0.0376 ns | 0.0352 ns |  9.674 ns |  0.70 |    0.00 |      - |     - |     - |         - |
                                           From_Double |        net461 | 13.953 ns | 0.0254 ns | 0.0238 ns | 13.960 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                           From_Double |        net472 | 13.956 ns | 0.0153 ns | 0.0128 ns | 13.957 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_Double_AsObject | .NET Core 2.0 | 19.264 ns | 0.0268 ns | 0.0237 ns | 19.271 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 2.2 | 18.769 ns | 0.0299 ns | 0.0280 ns | 18.768 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 3.0 | 18.812 ns | 0.1361 ns | 0.1273 ns | 18.812 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                                  From_Double_AsObject |        net461 | 20.219 ns | 0.0479 ns | 0.0448 ns | 20.204 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject |        net472 | 20.531 ns | 0.0737 ns | 0.0690 ns | 20.529 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_Double_Nullable_WithValue | .NET Core 2.0 | 15.541 ns | 0.0155 ns | 0.0145 ns | 15.543 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 2.2 | 14.626 ns | 0.0268 ns | 0.0237 ns | 14.614 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 3.0 | 12.235 ns | 0.0180 ns | 0.0151 ns | 12.235 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net461 | 16.100 ns | 0.0289 ns | 0.0270 ns | 16.096 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net472 | 15.888 ns | 0.0161 ns | 0.0143 ns | 15.884 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.864 ns | 0.0260 ns | 0.0243 ns | 20.855 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.2 | 18.197 ns | 0.0342 ns | 0.0303 ns | 18.192 ns |  0.87 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 3.0 | 20.371 ns | 0.4308 ns | 0.6447 ns | 20.814 ns |  0.95 |    0.03 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net461 | 21.413 ns | 0.0305 ns | 0.0270 ns | 21.414 ns |  1.03 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net472 | 20.290 ns | 0.0733 ns | 0.0685 ns | 20.309 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Double_Nullable_NoValue | .NET Core 2.0 | 12.511 ns | 0.0214 ns | 0.0179 ns | 12.519 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 2.2 | 11.280 ns | 0.0334 ns | 0.0312 ns | 11.269 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 3.0 |  7.953 ns | 0.0494 ns | 0.0462 ns |  7.972 ns |  0.64 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net461 | 12.651 ns | 0.0251 ns | 0.0235 ns | 12.653 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net472 | 12.753 ns | 0.0176 ns | 0.0164 ns | 12.752 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.114 ns | 0.0108 ns | 0.0096 ns | 13.113 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.633 ns | 0.0119 ns | 0.0112 ns | 12.633 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.479 ns | 0.2910 ns | 0.4444 ns | 13.630 ns |  1.01 |    0.04 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net461 | 15.034 ns | 0.0469 ns | 0.0439 ns | 15.040 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net472 | 14.983 ns | 0.0161 ns | 0.0126 ns | 14.982 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_Short | .NET Core 2.0 | 12.400 ns | 0.0114 ns | 0.0101 ns | 12.402 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 2.2 | 10.442 ns | 0.0214 ns | 0.0201 ns | 10.445 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 3.0 |  6.829 ns | 0.1758 ns | 0.2986 ns |  6.688 ns |  0.57 |    0.03 |      - |     - |     - |         - |
                                            From_Short |        net461 | 12.275 ns | 0.0218 ns | 0.0204 ns | 12.267 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                            From_Short |        net472 | 10.728 ns | 0.0216 ns | 0.0202 ns | 10.730 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_Short_AsObject | .NET Core 2.0 | 18.813 ns | 0.0289 ns | 0.0271 ns | 18.818 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 2.2 | 15.944 ns | 0.0185 ns | 0.0173 ns | 15.942 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 3.0 | 15.278 ns | 0.0286 ns | 0.0254 ns | 15.283 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net461 | 19.271 ns | 0.0281 ns | 0.0249 ns | 19.278 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net472 | 19.376 ns | 0.0407 ns | 0.0381 ns | 19.379 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Short_Nullable_WithValue | .NET Core 2.0 | 12.531 ns | 0.1551 ns | 0.1451 ns | 12.479 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 2.2 | 10.509 ns | 0.0186 ns | 0.0174 ns | 10.502 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 3.0 |  6.832 ns | 0.0130 ns | 0.0122 ns |  6.830 ns |  0.55 |    0.01 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net461 | 12.107 ns | 0.0850 ns | 0.0795 ns | 12.146 ns |  0.97 |    0.02 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net472 | 12.053 ns | 0.0674 ns | 0.0631 ns | 12.033 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.0 | 16.952 ns | 0.0175 ns | 0.0155 ns | 16.951 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.2 | 16.093 ns | 0.0472 ns | 0.0441 ns | 16.097 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.719 ns | 0.0794 ns | 0.0743 ns | 15.749 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net461 | 19.265 ns | 0.0165 ns | 0.0154 ns | 19.271 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net472 | 19.368 ns | 0.0378 ns | 0.0354 ns | 19.367 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Short_Nullable_NoValue | .NET Core 2.0 | 11.783 ns | 0.0160 ns | 0.0142 ns | 11.787 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 2.2 | 10.331 ns | 0.0251 ns | 0.0210 ns | 10.330 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 3.0 |  6.831 ns | 0.0101 ns | 0.0095 ns |  6.832 ns |  0.58 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net461 | 10.368 ns | 0.0129 ns | 0.0108 ns | 10.370 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net472 | 10.339 ns | 0.0169 ns | 0.0150 ns | 10.342 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.151 ns | 0.0133 ns | 0.0125 ns | 13.156 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.630 ns | 0.0098 ns | 0.0082 ns | 12.629 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.083 ns | 0.3547 ns | 0.3642 ns | 12.891 ns |  1.00 |    0.03 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net461 | 15.045 ns | 0.0313 ns | 0.0278 ns | 15.042 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net472 | 15.197 ns | 0.0315 ns | 0.0295 ns | 15.196 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                              From_Int | .NET Core 2.0 | 12.898 ns | 0.0260 ns | 0.0243 ns | 12.902 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 2.2 | 10.786 ns | 0.0086 ns | 0.0071 ns | 10.787 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 3.0 |  7.482 ns | 0.0141 ns | 0.0118 ns |  7.485 ns |  0.58 |    0.00 |      - |     - |     - |         - |
                                              From_Int |        net461 | 12.461 ns | 0.0099 ns | 0.0093 ns | 12.462 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                              From_Int |        net472 | 10.952 ns | 0.0107 ns | 0.0100 ns | 10.949 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_Int_AsObject | .NET Core 2.0 | 17.769 ns | 0.0325 ns | 0.0271 ns | 17.769 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 2.2 | 16.922 ns | 0.0429 ns | 0.0401 ns | 16.923 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 3.0 | 15.689 ns | 0.0245 ns | 0.0229 ns | 15.693 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net461 | 18.948 ns | 0.0250 ns | 0.0222 ns | 18.950 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net472 | 19.065 ns | 0.0308 ns | 0.0288 ns | 19.065 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Int_Nullable_WithValue | .NET Core 2.0 | 12.633 ns | 0.0167 ns | 0.0156 ns | 12.632 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 2.2 | 11.560 ns | 0.0164 ns | 0.0145 ns | 11.560 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 3.0 |  8.244 ns | 0.0112 ns | 0.0100 ns |  8.243 ns |  0.65 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net461 | 12.154 ns | 0.0150 ns | 0.0141 ns | 12.156 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net472 | 12.069 ns | 0.0719 ns | 0.0672 ns | 12.047 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.664 ns | 0.0412 ns | 0.0365 ns | 19.658 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.2 | 16.867 ns | 0.0474 ns | 0.0443 ns | 16.874 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.769 ns | 0.0734 ns | 0.0687 ns | 15.770 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net461 | 20.464 ns | 0.0243 ns | 0.0228 ns | 20.464 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net472 | 19.127 ns | 0.0207 ns | 0.0184 ns | 19.126 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_Int_Nullable_NoValue | .NET Core 2.0 | 11.686 ns | 0.0166 ns | 0.0130 ns | 11.687 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 2.2 | 10.297 ns | 0.0165 ns | 0.0154 ns | 10.291 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 3.0 |  6.857 ns | 0.0070 ns | 0.0055 ns |  6.856 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net461 | 10.375 ns | 0.0121 ns | 0.0101 ns | 10.374 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net472 | 12.141 ns | 0.0197 ns | 0.0185 ns | 12.142 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.402 ns | 0.0142 ns | 0.0126 ns | 13.406 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.674 ns | 0.0190 ns | 0.0168 ns | 12.668 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.933 ns | 0.0173 ns | 0.0162 ns | 12.937 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net461 | 13.445 ns | 0.0119 ns | 0.0099 ns | 13.444 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net472 | 13.336 ns | 0.0185 ns | 0.0154 ns | 13.339 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Long | .NET Core 2.0 | 12.031 ns | 0.0226 ns | 0.0212 ns | 12.037 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Long | .NET Core 2.2 | 10.562 ns | 0.0126 ns | 0.0112 ns | 10.563 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                             From_Long | .NET Core 3.0 |  7.803 ns | 0.0581 ns | 0.0543 ns |  7.832 ns |  0.65 |    0.01 |      - |     - |     - |         - |
                                             From_Long |        net461 | 10.783 ns | 0.0136 ns | 0.0127 ns | 10.781 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                             From_Long |        net472 | 10.938 ns | 0.0163 ns | 0.0144 ns | 10.939 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Long_AsObject | .NET Core 2.0 | 17.412 ns | 0.1097 ns | 0.1026 ns | 17.484 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 2.2 | 16.720 ns | 0.0194 ns | 0.0182 ns | 16.721 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 3.0 | 15.749 ns | 0.0266 ns | 0.0208 ns | 15.754 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net461 | 19.979 ns | 0.0366 ns | 0.0324 ns | 19.972 ns |  1.15 |    0.01 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net472 | 18.717 ns | 0.0277 ns | 0.0246 ns | 18.718 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Long_Nullable_WithValue | .NET Core 2.0 | 13.692 ns | 0.0178 ns | 0.0167 ns | 13.690 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 2.2 | 13.309 ns | 0.0313 ns | 0.0293 ns | 13.313 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 3.0 | 10.244 ns | 0.0162 ns | 0.0135 ns | 10.246 ns |  0.75 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net461 | 13.834 ns | 0.0119 ns | 0.0100 ns | 13.833 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net472 | 13.933 ns | 0.0207 ns | 0.0193 ns | 13.935 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.306 ns | 0.0409 ns | 0.0383 ns | 19.300 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.2 | 16.163 ns | 0.0212 ns | 0.0198 ns | 16.156 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 3.0 | 16.761 ns | 0.1164 ns | 0.1089 ns | 16.837 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net461 | 18.779 ns | 0.0355 ns | 0.0332 ns | 18.773 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net472 | 18.851 ns | 0.0442 ns | 0.0392 ns | 18.854 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Long_Nullable_NoValue | .NET Core 2.0 | 12.758 ns | 0.1042 ns | 0.0975 ns | 12.741 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 2.2 | 13.033 ns | 0.0148 ns | 0.0138 ns | 13.034 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 3.0 |  8.079 ns | 0.0246 ns | 0.0230 ns |  8.080 ns |  0.63 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net461 | 13.239 ns | 0.1142 ns | 0.1069 ns | 13.263 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net472 | 14.634 ns | 0.0194 ns | 0.0181 ns | 14.637 ns |  1.15 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.074 ns | 0.0124 ns | 0.0110 ns | 14.072 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.637 ns | 0.0222 ns | 0.0196 ns | 13.640 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.928 ns | 0.0156 ns | 0.0146 ns | 12.929 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net461 | 13.753 ns | 0.0202 ns | 0.0189 ns | 13.749 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net472 | 13.351 ns | 0.0205 ns | 0.0181 ns | 13.353 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_SByte | .NET Core 2.0 | 11.776 ns | 0.0144 ns | 0.0120 ns | 11.772 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 2.2 | 10.875 ns | 0.0121 ns | 0.0094 ns | 10.876 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 3.0 |  8.258 ns | 0.1911 ns | 0.4031 ns |  8.411 ns |  0.66 |    0.05 |      - |     - |     - |         - |
                                            From_SByte |        net461 | 10.636 ns | 0.0159 ns | 0.0132 ns | 10.635 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                            From_SByte |        net472 | 10.772 ns | 0.0192 ns | 0.0171 ns | 10.769 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_SByte_AsObject | .NET Core 2.0 | 18.470 ns | 0.0257 ns | 0.0241 ns | 18.473 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 2.2 | 15.929 ns | 0.0188 ns | 0.0175 ns | 15.932 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 3.0 | 15.229 ns | 0.0488 ns | 0.0433 ns | 15.231 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net461 | 18.882 ns | 0.0418 ns | 0.0391 ns | 18.869 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net472 | 19.000 ns | 0.0821 ns | 0.0768 ns | 19.034 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_SByte_Nullable_WithValue | .NET Core 2.0 | 11.914 ns | 0.0210 ns | 0.0175 ns | 11.917 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 2.2 | 10.520 ns | 0.0157 ns | 0.0131 ns | 10.523 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 3.0 |  6.846 ns | 0.0118 ns | 0.0099 ns |  6.849 ns |  0.57 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net461 | 13.534 ns | 0.0091 ns | 0.0080 ns | 13.532 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net472 | 11.886 ns | 0.0159 ns | 0.0133 ns | 11.891 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.0 | 16.805 ns | 0.0470 ns | 0.0392 ns | 16.791 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.701 ns | 0.0181 ns | 0.0169 ns | 15.697 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.302 ns | 0.0894 ns | 0.0836 ns | 15.279 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net461 | 18.544 ns | 0.0266 ns | 0.0249 ns | 18.543 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net472 | 18.817 ns | 0.0503 ns | 0.0470 ns | 18.834 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_SByte_Nullable_NoValue | .NET Core 2.0 | 11.855 ns | 0.0345 ns | 0.0323 ns | 11.862 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 2.2 | 10.330 ns | 0.0156 ns | 0.0138 ns | 10.333 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 3.0 |  6.873 ns | 0.0123 ns | 0.0096 ns |  6.873 ns |  0.58 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net461 | 11.883 ns | 0.0181 ns | 0.0160 ns | 11.877 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net472 | 10.240 ns | 0.0077 ns | 0.0069 ns | 10.241 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.413 ns | 0.0246 ns | 0.0218 ns | 14.417 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.627 ns | 0.0118 ns | 0.0105 ns | 12.625 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.909 ns | 0.1840 ns | 0.1721 ns | 11.976 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net461 | 14.990 ns | 0.0255 ns | 0.0238 ns | 14.994 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net472 | 13.164 ns | 0.0259 ns | 0.0229 ns | 13.168 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_Float | .NET Core 2.0 | 13.351 ns | 0.0233 ns | 0.0218 ns | 13.342 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 2.2 | 12.162 ns | 0.0099 ns | 0.0088 ns | 12.160 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 3.0 | 10.199 ns | 0.2157 ns | 0.2215 ns | 10.065 ns |  0.76 |    0.02 |      - |     - |     - |         - |
                                            From_Float |        net461 | 14.355 ns | 0.0180 ns | 0.0168 ns | 14.356 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                            From_Float |        net472 | 14.404 ns | 0.0951 ns | 0.0890 ns | 14.432 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_Float_AsObject | .NET Core 2.0 | 19.522 ns | 0.0481 ns | 0.0450 ns | 19.527 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 2.2 | 19.045 ns | 0.0340 ns | 0.0301 ns | 19.046 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 3.0 | 18.893 ns | 0.0704 ns | 0.0658 ns | 18.905 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject |        net461 | 21.602 ns | 0.0309 ns | 0.0274 ns | 21.609 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject |        net472 | 21.860 ns | 0.0342 ns | 0.0304 ns | 21.857 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Float_Nullable_WithValue | .NET Core 2.0 | 14.222 ns | 0.0294 ns | 0.0275 ns | 14.223 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 2.2 | 12.880 ns | 0.0182 ns | 0.0142 ns | 12.883 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 3.0 | 12.546 ns | 0.2747 ns | 0.6029 ns | 12.788 ns |  0.84 |    0.07 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net461 | 13.360 ns | 0.0267 ns | 0.0250 ns | 13.352 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net472 | 14.609 ns | 0.0148 ns | 0.0138 ns | 14.604 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.198 ns | 0.0313 ns | 0.0293 ns | 19.184 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.2 | 21.026 ns | 0.0300 ns | 0.0266 ns | 21.016 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.824 ns | 0.0312 ns | 0.0276 ns | 18.815 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net461 | 21.629 ns | 0.0274 ns | 0.0256 ns | 21.633 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net472 | 22.051 ns | 0.0977 ns | 0.0914 ns | 22.076 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Float_Nullable_NoValue | .NET Core 2.0 | 12.612 ns | 0.0058 ns | 0.0048 ns | 12.612 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 2.2 | 10.346 ns | 0.0142 ns | 0.0133 ns | 10.345 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 3.0 |  6.859 ns | 0.0110 ns | 0.0103 ns |  6.861 ns |  0.54 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net461 | 10.456 ns | 0.0717 ns | 0.0670 ns | 10.426 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net472 | 12.153 ns | 0.0135 ns | 0.0119 ns | 12.157 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.202 ns | 0.0190 ns | 0.0178 ns | 14.200 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.632 ns | 0.0110 ns | 0.0092 ns | 12.635 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.431 ns | 0.0714 ns | 0.0633 ns | 14.402 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net461 | 13.303 ns | 0.0259 ns | 0.0243 ns | 13.304 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net472 | 13.245 ns | 0.0686 ns | 0.0642 ns | 13.282 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_String | .NET Core 2.0 | 58.444 ns | 0.2971 ns | 0.2634 ns | 58.340 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 2.2 | 50.923 ns | 0.0644 ns | 0.0571 ns | 50.929 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 3.0 | 19.738 ns | 0.0312 ns | 0.0261 ns | 19.746 ns |  0.34 |    0.00 |      - |     - |     - |         - |
                                           From_String |        net461 | 59.233 ns | 0.1158 ns | 0.1083 ns | 59.243 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                           From_String |        net472 | 57.659 ns | 0.1068 ns | 0.0947 ns | 57.682 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_String_AsObject | .NET Core 2.0 | 63.670 ns | 0.0871 ns | 0.0815 ns | 63.667 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 2.2 | 60.128 ns | 0.1977 ns | 0.1849 ns | 60.102 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 3.0 | 25.604 ns | 0.0255 ns | 0.0239 ns | 25.609 ns |  0.40 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject |        net461 | 64.272 ns | 0.2043 ns | 0.1911 ns | 64.285 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject |        net472 | 63.832 ns | 0.1447 ns | 0.1283 ns | 63.846 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                      From_String_Null | .NET Core 2.0 | 12.331 ns | 0.0149 ns | 0.0140 ns | 12.334 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 2.2 | 12.107 ns | 0.0142 ns | 0.0111 ns | 12.108 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 3.0 | 11.581 ns | 0.0235 ns | 0.0220 ns | 11.583 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null |        net461 | 12.581 ns | 0.0129 ns | 0.0114 ns | 12.581 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null |        net472 | 13.012 ns | 0.0731 ns | 0.0684 ns | 13.059 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_String_Null_AsObject | .NET Core 2.0 | 13.927 ns | 0.0104 ns | 0.0098 ns | 13.930 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 2.2 | 12.659 ns | 0.0627 ns | 0.0586 ns | 12.636 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 3.0 | 11.437 ns | 0.1652 ns | 0.1545 ns | 11.483 ns |  0.82 |    0.01 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net461 | 13.128 ns | 0.0200 ns | 0.0187 ns | 13.130 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net472 | 13.256 ns | 0.0268 ns | 0.0251 ns | 13.247 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_String_Empty | .NET Core 2.0 | 12.543 ns | 0.0100 ns | 0.0089 ns | 12.542 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 2.2 | 12.080 ns | 0.0138 ns | 0.0122 ns | 12.082 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 3.0 | 11.576 ns | 0.0204 ns | 0.0181 ns | 11.578 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty |        net461 | 12.895 ns | 0.0367 ns | 0.0344 ns | 12.906 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty |        net472 | 11.372 ns | 0.0203 ns | 0.0190 ns | 11.370 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_String_Empty_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_UShort | .NET Core 2.0 | 13.307 ns | 0.0092 ns | 0.0086 ns | 13.306 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 2.2 | 10.751 ns | 0.0222 ns | 0.0197 ns | 10.748 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 3.0 |  6.886 ns | 0.1435 ns | 0.1343 ns |  6.810 ns |  0.52 |    0.01 |      - |     - |     - |         - |
                                           From_UShort |        net461 | 10.303 ns | 0.0095 ns | 0.0079 ns | 10.303 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                                           From_UShort |        net472 | 10.496 ns | 0.0131 ns | 0.0116 ns | 10.496 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_UShort_AsObject | .NET Core 2.0 | 13.733 ns | 0.0149 ns | 0.0139 ns | 13.734 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 2.2 | 13.141 ns | 0.0124 ns | 0.0110 ns | 13.143 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 3.0 | 14.640 ns | 0.2282 ns | 0.2134 ns | 14.509 ns |  1.07 |    0.02 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net461 | 14.255 ns | 0.0788 ns | 0.0737 ns | 14.287 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net472 | 14.074 ns | 0.0353 ns | 0.0330 ns | 14.068 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_UShort_Nullable_WithValue | .NET Core 2.0 | 11.858 ns | 0.0210 ns | 0.0186 ns | 11.856 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 2.2 | 10.533 ns | 0.0248 ns | 0.0232 ns | 10.528 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 3.0 |  6.738 ns | 0.1048 ns | 0.0980 ns |  6.793 ns |  0.57 |    0.01 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net461 | 12.104 ns | 0.0197 ns | 0.0184 ns | 12.103 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net472 | 10.721 ns | 0.0468 ns | 0.0437 ns | 10.743 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.0 | 13.709 ns | 0.0199 ns | 0.0186 ns | 13.704 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.2 | 14.287 ns | 0.0104 ns | 0.0092 ns | 14.285 ns |  1.04 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 3.0 | 14.657 ns | 0.3140 ns | 0.4700 ns | 14.310 ns |  1.10 |    0.03 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net461 | 14.016 ns | 0.0325 ns | 0.0304 ns | 14.013 ns |  1.02 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net472 | 14.121 ns | 0.0428 ns | 0.0401 ns | 14.112 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_UShort_Nullable_NoValue | .NET Core 2.0 | 11.630 ns | 0.0104 ns | 0.0097 ns | 11.632 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 2.2 | 10.767 ns | 0.0109 ns | 0.0102 ns | 10.764 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 3.0 |  6.871 ns | 0.0561 ns | 0.0525 ns |  6.886 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net461 | 11.664 ns | 0.0686 ns | 0.0642 ns | 11.679 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net472 | 12.156 ns | 0.0114 ns | 0.0101 ns | 12.153 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.151 ns | 0.0106 ns | 0.0094 ns | 13.148 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.651 ns | 0.0083 ns | 0.0065 ns | 12.651 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.856 ns | 0.4329 ns | 0.7350 ns | 11.467 ns |  0.95 |    0.06 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net461 | 13.532 ns | 0.0168 ns | 0.0157 ns | 13.529 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net472 | 13.315 ns | 0.0592 ns | 0.0553 ns | 13.329 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_UInt | .NET Core 2.0 | 12.377 ns | 0.0092 ns | 0.0081 ns | 12.376 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 2.2 | 10.879 ns | 0.0120 ns | 0.0101 ns | 10.878 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 3.0 |  6.856 ns | 0.0082 ns | 0.0072 ns |  6.855 ns |  0.55 |    0.00 |      - |     - |     - |         - |
                                             From_UInt |        net461 | 12.255 ns | 0.0076 ns | 0.0071 ns | 12.258 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                             From_UInt |        net472 | 10.898 ns | 0.0104 ns | 0.0087 ns | 10.901 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_UInt_AsObject | .NET Core 2.0 | 16.814 ns | 0.0218 ns | 0.0204 ns | 16.813 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 2.2 | 17.242 ns | 0.0221 ns | 0.0196 ns | 17.244 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 3.0 | 15.266 ns | 0.0303 ns | 0.0284 ns | 15.263 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net461 | 20.316 ns | 0.0369 ns | 0.0327 ns | 20.308 ns |  1.21 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net472 | 19.098 ns | 0.0250 ns | 0.0221 ns | 19.096 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_UInt_Nullable_WithValue | .NET Core 2.0 | 11.901 ns | 0.0121 ns | 0.0108 ns | 11.899 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 2.2 | 10.536 ns | 0.0090 ns | 0.0080 ns | 10.535 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 3.0 |  7.362 ns | 0.0481 ns | 0.0449 ns |  7.379 ns |  0.62 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net461 | 12.954 ns | 0.0116 ns | 0.0109 ns | 12.953 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net472 | 11.981 ns | 0.0451 ns | 0.0400 ns | 11.993 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.0 | 16.760 ns | 0.0288 ns | 0.0270 ns | 16.755 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.2 | 16.246 ns | 0.0333 ns | 0.0312 ns | 16.239 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 3.0 | 16.353 ns | 0.0413 ns | 0.0322 ns | 16.344 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net461 | 18.719 ns | 0.0258 ns | 0.0229 ns | 18.719 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net472 | 22.244 ns | 0.0264 ns | 0.0234 ns | 22.248 ns |  1.33 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_UInt_Nullable_NoValue | .NET Core 2.0 | 11.737 ns | 0.0180 ns | 0.0168 ns | 11.733 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 2.2 | 10.343 ns | 0.0082 ns | 0.0077 ns | 10.344 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 3.0 |  6.590 ns | 0.0094 ns | 0.0079 ns |  6.589 ns |  0.56 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net461 | 10.402 ns | 0.0139 ns | 0.0123 ns | 10.402 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net472 | 11.261 ns | 0.0106 ns | 0.0099 ns | 11.260 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.103 ns | 0.0083 ns | 0.0065 ns | 13.105 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.708 ns | 0.0127 ns | 0.0112 ns | 12.710 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.003 ns | 0.1183 ns | 0.1107 ns | 13.980 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net461 | 13.040 ns | 0.0180 ns | 0.0168 ns | 13.035 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net472 | 13.660 ns | 0.0137 ns | 0.0129 ns | 13.661 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_ULong | .NET Core 2.0 | 12.642 ns | 0.0160 ns | 0.0150 ns | 12.645 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 2.2 | 10.642 ns | 0.0118 ns | 0.0104 ns | 10.639 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 3.0 |  8.252 ns | 0.1878 ns | 0.2979 ns |  8.414 ns |  0.64 |    0.03 |      - |     - |     - |         - |
                                            From_ULong |        net461 | 10.645 ns | 0.0137 ns | 0.0128 ns | 10.645 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                            From_ULong |        net472 | 10.777 ns | 0.0106 ns | 0.0100 ns | 10.776 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_ULong_AsObject | .NET Core 2.0 | 17.846 ns | 0.0243 ns | 0.0227 ns | 17.849 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 2.2 | 16.413 ns | 0.0201 ns | 0.0188 ns | 16.413 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 3.0 | 15.838 ns | 0.0178 ns | 0.0149 ns | 15.844 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net461 | 18.910 ns | 0.0517 ns | 0.0483 ns | 18.901 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net472 | 18.931 ns | 0.0282 ns | 0.0250 ns | 18.929 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_ULong_Nullable_WithValue | .NET Core 2.0 | 13.572 ns | 0.0219 ns | 0.0194 ns | 13.568 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 2.2 | 12.463 ns | 0.0130 ns | 0.0122 ns | 12.462 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 3.0 | 10.283 ns | 0.0113 ns | 0.0106 ns | 10.283 ns |  0.76 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net461 | 13.823 ns | 0.0232 ns | 0.0205 ns | 13.825 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net472 | 13.897 ns | 0.0392 ns | 0.0367 ns | 13.911 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.0 | 17.490 ns | 0.0222 ns | 0.0197 ns | 17.487 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.003 ns | 0.0466 ns | 0.0436 ns | 17.014 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.164 ns | 0.3635 ns | 0.5096 ns | 17.490 ns |  0.96 |    0.03 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net461 | 18.882 ns | 0.0240 ns | 0.0225 ns | 18.880 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net472 | 18.872 ns | 0.0321 ns | 0.0300 ns | 18.868 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_ULong_Nullable_NoValue | .NET Core 2.0 | 14.110 ns | 0.0178 ns | 0.0166 ns | 14.110 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 2.2 | 11.206 ns | 0.0090 ns | 0.0084 ns | 11.208 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 3.0 |  7.854 ns | 0.0105 ns | 0.0098 ns |  7.853 ns |  0.56 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net461 | 12.730 ns | 0.0205 ns | 0.0192 ns | 12.724 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net472 | 12.694 ns | 0.0200 ns | 0.0178 ns | 12.696 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.138 ns | 0.0185 ns | 0.0154 ns | 13.135 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.659 ns | 0.0080 ns | 0.0067 ns | 12.660 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.407 ns | 0.1400 ns | 0.1310 ns | 11.415 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net461 | 13.058 ns | 0.0180 ns | 0.0168 ns | 13.059 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net472 | 13.230 ns | 0.0471 ns | 0.0440 ns | 13.253 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                       From_NullObject | .NET Core 2.0 | 14.869 ns | 0.0147 ns | 0.0131 ns | 14.866 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 2.2 | 13.498 ns | 0.0121 ns | 0.0101 ns | 13.499 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 3.0 | 13.977 ns | 0.1288 ns | 0.1205 ns | 14.036 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                                       From_NullObject |        net461 | 13.063 ns | 0.0156 ns | 0.0146 ns | 13.060 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject |        net472 | 13.324 ns | 0.0171 ns | 0.0160 ns | 13.327 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_DBNull | .NET Core 2.0 | 10.709 ns | 0.0113 ns | 0.0100 ns | 10.706 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 2.2 |  9.771 ns | 0.0071 ns | 0.0055 ns |  9.772 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 3.0 | 10.874 ns | 0.0138 ns | 0.0123 ns | 10.872 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull |        net461 | 11.060 ns | 0.0110 ns | 0.0092 ns | 11.060 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull |        net472 | 10.962 ns | 0.0148 ns | 0.0131 ns | 10.964 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_DBNull_AsObject | .NET Core 2.0 | 13.124 ns | 0.0108 ns | 0.0095 ns | 13.126 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 2.2 | 13.861 ns | 0.0225 ns | 0.0188 ns | 13.860 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 3.0 | 11.373 ns | 0.0656 ns | 0.0613 ns | 11.388 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net461 | 13.280 ns | 0.0168 ns | 0.0157 ns | 13.274 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net472 | 13.340 ns | 0.0347 ns | 0.0308 ns | 13.346 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                 From_ConvertibleClass | .NET Core 2.0 | 16.106 ns | 0.0223 ns | 0.0186 ns | 16.106 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 2.2 | 12.575 ns | 0.0128 ns | 0.0114 ns | 12.572 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 3.0 | 12.701 ns | 0.2763 ns | 0.4540 ns | 12.413 ns |  0.82 |    0.02 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net461 | 18.540 ns | 0.0368 ns | 0.0344 ns | 18.542 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net472 | 16.964 ns | 0.0331 ns | 0.0310 ns | 16.957 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_ConvertibleClass_AsObject | .NET Core 2.0 | 17.001 ns | 0.0483 ns | 0.0452 ns | 16.992 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 2.2 | 15.242 ns | 0.0724 ns | 0.0677 ns | 15.270 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 3.0 | 14.491 ns | 0.1671 ns | 0.1563 ns | 14.585 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net461 | 16.941 ns | 0.0256 ns | 0.0239 ns | 16.932 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net472 | 17.099 ns | 0.0272 ns | 0.0254 ns | 17.097 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_ConvertibleClass_NoValue | .NET Core 2.0 | 15.516 ns | 0.0223 ns | 0.0198 ns | 15.517 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 2.2 | 12.393 ns | 0.0126 ns | 0.0111 ns | 12.394 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 3.0 | 11.811 ns | 0.0911 ns | 0.0853 ns | 11.835 ns |  0.76 |    0.01 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net461 | 14.882 ns | 0.0288 ns | 0.0255 ns | 14.890 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net472 | 13.191 ns | 0.0249 ns | 0.0233 ns | 13.191 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.0 | 13.132 ns | 0.0125 ns | 0.0111 ns | 13.129 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.2 | 12.651 ns | 0.0108 ns | 0.0095 ns | 12.652 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 3.0 | 13.392 ns | 0.2827 ns | 0.3575 ns | 13.611 ns |  1.01 |    0.03 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net461 | 13.124 ns | 0.0280 ns | 0.0262 ns | 13.127 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net472 | 13.815 ns | 0.0339 ns | 0.0283 ns | 13.821 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                              From_NonConvertibleClass | .NET Core 2.0 | 12.716 ns | 0.0288 ns | 0.0256 ns | 12.712 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 2.2 | 10.416 ns | 0.0243 ns | 0.0203 ns | 10.417 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 3.0 | 10.842 ns | 0.2423 ns | 0.2694 ns | 10.745 ns |  0.86 |    0.02 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net461 | 12.361 ns | 0.0203 ns | 0.0190 ns | 12.365 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net472 | 12.627 ns | 0.0559 ns | 0.0523 ns | 12.602 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                     From_NonConvertibleClass_AsObject | .NET Core 2.0 | 15.047 ns | 0.0138 ns | 0.0122 ns | 15.048 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 2.2 | 14.147 ns | 0.0167 ns | 0.0148 ns | 14.142 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 3.0 | 14.973 ns | 0.0679 ns | 0.0602 ns | 14.943 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net461 | 16.545 ns | 0.0232 ns | 0.0217 ns | 16.536 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net472 | 14.979 ns | 0.0223 ns | 0.0209 ns | 14.976 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                      From_NonConvertibleClass_NoValue | .NET Core 2.0 | 12.717 ns | 0.0121 ns | 0.0107 ns | 12.719 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 2.2 | 10.347 ns | 0.0108 ns | 0.0096 ns | 10.346 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 3.0 | 11.721 ns | 0.0413 ns | 0.0366 ns | 11.707 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net461 | 13.944 ns | 0.0134 ns | 0.0119 ns | 13.942 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net472 | 12.562 ns | 0.0152 ns | 0.0135 ns | 12.557 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.0 | 13.126 ns | 0.0119 ns | 0.0105 ns | 13.126 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.2 | 13.622 ns | 0.0501 ns | 0.0444 ns | 13.633 ns |  1.04 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 3.0 | 12.837 ns | 0.2817 ns | 0.4468 ns | 13.062 ns |  0.95 |    0.04 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net461 | 13.402 ns | 0.0201 ns | 0.0157 ns | 13.401 ns |  1.02 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net472 | 13.791 ns | 0.0097 ns | 0.0081 ns | 13.792 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                From_ConvertibleStruct | .NET Core 2.0 | 18.890 ns | 0.0420 ns | 0.0393 ns | 18.886 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 2.2 | 16.132 ns | 0.0311 ns | 0.0291 ns | 16.136 ns |  0.85 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 3.0 | 11.097 ns | 0.0334 ns | 0.0297 ns | 11.099 ns |  0.59 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net461 | 16.540 ns | 0.0214 ns | 0.0190 ns | 16.542 ns |  0.88 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net472 | 16.606 ns | 0.0444 ns | 0.0415 ns | 16.598 ns |  0.88 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                       From_ConvertibleStruct_AsObject | .NET Core 2.0 | 15.896 ns | 0.0296 ns | 0.0263 ns | 15.901 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 2.2 | 16.144 ns | 0.0165 ns | 0.0146 ns | 16.147 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 3.0 | 15.137 ns | 0.0633 ns | 0.0592 ns | 15.109 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net461 | 17.567 ns | 0.0240 ns | 0.0224 ns | 17.566 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net472 | 17.814 ns | 0.0290 ns | 0.0271 ns | 17.807 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.0 | 18.871 ns | 0.0329 ns | 0.0308 ns | 18.875 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.2 | 16.031 ns | 0.0401 ns | 0.0375 ns | 16.031 ns |  0.85 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 3.0 | 12.074 ns | 0.0814 ns | 0.0762 ns | 12.089 ns |  0.64 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net461 | 18.507 ns | 0.0362 ns | 0.0302 ns | 18.506 ns |  0.98 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net472 | 17.009 ns | 0.0571 ns | 0.0534 ns | 16.988 ns |  0.90 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 17.653 ns | 0.0289 ns | 0.0256 ns | 17.657 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.242 ns | 0.0126 ns | 0.0099 ns | 15.240 ns |  0.86 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.222 ns | 0.0151 ns | 0.0133 ns | 15.224 ns |  0.86 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net461 | 19.174 ns | 0.0251 ns | 0.0235 ns | 19.169 ns |  1.09 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net472 | 17.796 ns | 0.0342 ns | 0.0320 ns | 17.783 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.0 | 15.810 ns | 0.0140 ns | 0.0131 ns | 15.809 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.2 | 11.986 ns | 0.0110 ns | 0.0103 ns | 11.985 ns |  0.76 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 3.0 |  7.857 ns | 0.1808 ns | 0.2414 ns |  7.974 ns |  0.49 |    0.02 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net461 | 10.502 ns | 0.0116 ns | 0.0103 ns | 10.499 ns |  0.66 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net472 | 10.502 ns | 0.0366 ns | 0.0325 ns | 10.493 ns |  0.66 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.033 ns | 0.0103 ns | 0.0091 ns | 14.031 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.793 ns | 0.0550 ns | 0.0514 ns | 12.813 ns |  0.91 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.377 ns | 0.0362 ns | 0.0338 ns | 11.385 ns |  0.81 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net461 | 13.083 ns | 0.0185 ns | 0.0173 ns | 13.076 ns |  0.93 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net472 | 13.182 ns | 0.0128 ns | 0.0114 ns | 13.183 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_NonConvertibleStruct | .NET Core 2.0 | 13.166 ns | 0.0132 ns | 0.0124 ns | 13.167 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 2.2 | 10.735 ns | 0.0189 ns | 0.0168 ns | 10.730 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 3.0 |  6.715 ns | 0.0087 ns | 0.0081 ns |  6.718 ns |  0.51 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net461 | 10.331 ns | 0.0123 ns | 0.0115 ns | 10.332 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net472 | 11.524 ns | 0.0090 ns | 0.0084 ns | 11.525 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.0 | 14.917 ns | 0.0155 ns | 0.0145 ns | 14.917 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.2 | 15.109 ns | 0.0188 ns | 0.0176 ns | 15.103 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 3.0 | 12.958 ns | 0.0175 ns | 0.0164 ns | 12.955 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net461 | 14.920 ns | 0.0295 ns | 0.0262 ns | 14.922 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net472 | 14.957 ns | 0.0137 ns | 0.0128 ns | 14.958 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.0 | 13.023 ns | 0.0141 ns | 0.0132 ns | 13.028 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.2 | 11.593 ns | 0.0379 ns | 0.0355 ns | 11.604 ns |  0.89 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 3.0 |  6.783 ns | 0.0515 ns | 0.0456 ns |  6.800 ns |  0.52 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net461 | 10.305 ns | 0.0109 ns | 0.0102 ns | 10.308 ns |  0.79 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net472 | 12.715 ns | 0.0085 ns | 0.0071 ns | 12.715 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 14.277 ns | 0.0078 ns | 0.0069 ns | 14.278 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 16.674 ns | 0.0250 ns | 0.0208 ns | 16.671 ns |  1.17 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 13.393 ns | 0.2901 ns | 0.3341 ns | 13.591 ns |  0.93 |    0.02 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net461 | 14.883 ns | 0.0322 ns | 0.0302 ns | 14.888 ns |  1.04 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net472 | 15.082 ns | 0.0217 ns | 0.0203 ns | 15.084 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.0 | 12.985 ns | 0.0095 ns | 0.0085 ns | 12.985 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.2 | 10.723 ns | 0.0089 ns | 0.0084 ns | 10.722 ns |  0.83 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 3.0 |  6.727 ns | 0.0109 ns | 0.0102 ns |  6.726 ns |  0.52 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net461 | 10.393 ns | 0.0253 ns | 0.0224 ns | 10.395 ns |  0.80 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net472 | 11.519 ns | 0.0165 ns | 0.0146 ns | 11.519 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.873 ns | 0.0160 ns | 0.0149 ns | 13.868 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.450 ns | 0.0815 ns | 0.0763 ns | 14.485 ns |  1.04 |    0.01 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.583 ns | 0.1902 ns | 0.1779 ns | 11.648 ns |  0.83 |    0.01 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net461 | 13.057 ns | 0.0165 ns | 0.0146 ns | 13.053 ns |  0.94 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net472 | 13.329 ns | 0.1048 ns | 0.0981 ns | 13.304 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Enum | .NET Core 2.0 | 13.520 ns | 0.0207 ns | 0.0193 ns | 13.525 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 2.2 | 10.714 ns | 0.0114 ns | 0.0089 ns | 10.716 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 3.0 |  7.655 ns | 0.0122 ns | 0.0114 ns |  7.659 ns |  0.57 |    0.00 |      - |     - |     - |         - |
                                             From_Enum |        net461 | 10.784 ns | 0.0181 ns | 0.0169 ns | 10.787 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                             From_Enum |        net472 | 10.976 ns | 0.0514 ns | 0.0481 ns | 10.967 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Enum_AsObject | .NET Core 2.0 | 45.279 ns | 0.1412 ns | 0.1252 ns | 45.243 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject | .NET Core 2.2 | 40.699 ns | 0.0440 ns | 0.0390 ns | 40.691 ns |  0.90 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject | .NET Core 3.0 | 36.912 ns | 0.6013 ns | 0.5624 ns | 37.048 ns |  0.82 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject |        net461 | 44.195 ns | 0.1142 ns | 0.1069 ns | 44.160 ns |  0.98 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject |        net472 | 45.714 ns | 1.1648 ns | 1.0896 ns | 45.120 ns |  1.01 |    0.02 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Enum_Nullable_WithValue | .NET Core 2.0 | 14.096 ns | 0.0134 ns | 0.0118 ns | 14.094 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 2.2 | 12.236 ns | 0.0536 ns | 0.0501 ns | 12.260 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 3.0 |  8.309 ns | 0.0724 ns | 0.0677 ns |  8.355 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net461 | 13.551 ns | 0.0259 ns | 0.0242 ns | 13.548 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net472 | 12.081 ns | 0.0132 ns | 0.0117 ns | 12.082 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.0 | 45.162 ns | 0.0717 ns | 0.0598 ns | 45.155 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.2 | 41.983 ns | 0.0794 ns | 0.0742 ns | 41.990 ns |  0.93 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 3.0 | 38.483 ns | 0.2906 ns | 0.2427 ns | 38.580 ns |  0.85 |    0.01 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject |        net461 | 43.905 ns | 0.0594 ns | 0.0556 ns | 43.926 ns |  0.97 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject |        net472 | 44.408 ns | 0.0706 ns | 0.0661 ns | 44.397 ns |  0.98 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Enum_Nullable_NoValue | .NET Core 2.0 | 13.103 ns | 0.0478 ns | 0.0447 ns | 13.084 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 2.2 | 10.770 ns | 0.0095 ns | 0.0080 ns | 10.770 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 3.0 |  6.794 ns | 0.0207 ns | 0.0184 ns |  6.790 ns |  0.52 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net461 | 10.497 ns | 0.0434 ns | 0.0406 ns | 10.512 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net472 | 10.385 ns | 0.0121 ns | 0.0113 ns | 10.389 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.125 ns | 0.0132 ns | 0.0117 ns | 13.125 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.705 ns | 0.0105 ns | 0.0093 ns | 12.705 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.916 ns | 0.0120 ns | 0.0113 ns | 11.915 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net461 | 14.929 ns | 0.0225 ns | 0.0199 ns | 14.924 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net472 | 13.320 ns | 0.0326 ns | 0.0272 ns | 13.329 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                      From_ParentClass | .NET Core 2.0 | 12.748 ns | 0.0208 ns | 0.0195 ns | 12.749 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 2.2 | 10.337 ns | 0.0071 ns | 0.0066 ns | 10.337 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 3.0 | 10.617 ns | 0.0084 ns | 0.0079 ns | 10.618 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass |        net461 | 12.393 ns | 0.0199 ns | 0.0176 ns | 12.394 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass |        net472 | 12.639 ns | 0.0168 ns | 0.0157 ns | 12.639 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_ParentClass_AsObject | .NET Core 2.0 | 14.675 ns | 0.0469 ns | 0.0439 ns | 14.660 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 2.2 | 15.275 ns | 0.0224 ns | 0.0209 ns | 15.277 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 3.0 | 15.461 ns | 0.0537 ns | 0.0476 ns | 15.467 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net461 | 15.251 ns | 0.0384 ns | 0.0359 ns | 15.246 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net472 | 15.329 ns | 0.0378 ns | 0.0315 ns | 15.329 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                              From_ParentClass_NoValue | .NET Core 2.0 | 12.729 ns | 0.0116 ns | 0.0096 ns | 12.725 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 2.2 | 10.351 ns | 0.0111 ns | 0.0098 ns | 10.350 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 3.0 | 10.919 ns | 0.0623 ns | 0.0582 ns | 10.910 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net461 | 12.336 ns | 0.0204 ns | 0.0180 ns | 12.342 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net472 | 12.371 ns | 0.0111 ns | 0.0092 ns | 12.371 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.0 | 14.062 ns | 0.0123 ns | 0.0115 ns | 14.062 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.2 | 12.700 ns | 0.0083 ns | 0.0069 ns | 12.698 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 3.0 | 13.871 ns | 0.3013 ns | 0.4416 ns | 14.063 ns |  0.97 |    0.04 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net461 | 13.061 ns | 0.0361 ns | 0.0301 ns | 13.055 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net472 | 13.184 ns | 0.0243 ns | 0.0227 ns | 13.182 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_ParentStruct | .NET Core 2.0 | 38.338 ns | 0.0479 ns | 0.0424 ns | 38.342 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 2.2 | 36.912 ns | 0.0412 ns | 0.0386 ns | 36.917 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 3.0 | 37.441 ns | 0.0332 ns | 0.0311 ns | 37.444 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct |        net461 | 38.060 ns | 0.0309 ns | 0.0274 ns | 38.058 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct |        net472 | 40.772 ns | 0.0741 ns | 0.0693 ns | 40.776 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_ParentStruct_AsObject | .NET Core 2.0 | 15.425 ns | 0.0156 ns | 0.0146 ns | 15.424 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 2.2 | 15.213 ns | 0.0243 ns | 0.0227 ns | 15.215 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 3.0 | 14.064 ns | 0.1177 ns | 0.1101 ns | 14.129 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net461 | 16.647 ns | 0.0339 ns | 0.0317 ns | 16.652 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net472 | 15.798 ns | 0.0199 ns | 0.0176 ns | 15.799 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.0 | 39.013 ns | 0.0593 ns | 0.0526 ns | 39.000 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.2 | 37.153 ns | 0.0624 ns | 0.0584 ns | 37.161 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 3.0 | 33.869 ns | 0.0623 ns | 0.0552 ns | 33.863 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue |        net461 | 46.091 ns | 0.1677 ns | 0.1568 ns | 46.148 ns |  1.18 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue |        net472 | 39.771 ns | 0.0466 ns | 0.0389 ns | 39.758 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 14.569 ns | 0.0907 ns | 0.0757 ns | 14.554 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 16.578 ns | 0.0161 ns | 0.0143 ns | 16.580 ns |  1.14 |    0.01 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 13.629 ns | 0.1146 ns | 0.1072 ns | 13.562 ns |  0.94 |    0.01 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net461 | 16.682 ns | 0.0410 ns | 0.0383 ns | 16.675 ns |  1.14 |    0.01 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net472 | 15.340 ns | 0.0252 ns | 0.0223 ns | 15.340 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.0 | 39.231 ns | 0.0549 ns | 0.0487 ns | 39.254 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.2 | 37.789 ns | 0.0687 ns | 0.0609 ns | 37.774 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 3.0 | 34.206 ns | 0.1062 ns | 0.0942 ns | 34.224 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net461 | 38.301 ns | 0.0405 ns | 0.0359 ns | 38.300 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net472 | 38.700 ns | 0.0877 ns | 0.0820 ns | 38.711 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.134 ns | 0.0207 ns | 0.0184 ns | 13.129 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.594 ns | 0.0093 ns | 0.0083 ns | 12.593 ns |  0.96 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.209 ns | 0.0200 ns | 0.0187 ns | 11.204 ns |  0.85 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net461 | 15.000 ns | 0.1022 ns | 0.0906 ns | 15.049 ns |  1.14 |    0.01 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net472 | 13.844 ns | 0.0400 ns | 0.0374 ns | 13.839 ns |  1.05 |    0.00 |      - |     - |     - |         - |

Benchmarks with issues:
  ConvertTo_UShort.From_DateTime_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_UShort.From_DateTime_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_UShort.From_DateTime_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_UShort.From_DateTime_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_UShort.From_DateTime_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_UShort.From_DateTime_Nullable_WithValue_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_UShort.From_DateTime_Nullable_WithValue_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_UShort.From_DateTime_Nullable_WithValue_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_UShort.From_DateTime_Nullable_WithValue_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_UShort.From_DateTime_Nullable_WithValue_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_UShort.From_String_Empty_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_UShort.From_String_Empty_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_UShort.From_String_Empty_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_UShort.From_String_Empty_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_UShort.From_String_Empty_AsObject: Job-PJAXXB(Toolchain=net472)
