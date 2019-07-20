
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
                                             From_Bool | .NET Core 2.0 | 12.965 ns | 0.0265 ns | 0.0248 ns | 12.967 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 2.2 | 10.236 ns | 0.0072 ns | 0.0064 ns | 10.237 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 3.0 |  7.756 ns | 0.0522 ns | 0.0488 ns |  7.728 ns |  0.60 |    0.00 |      - |     - |     - |         - |
                                             From_Bool |        net461 | 12.832 ns | 0.0191 ns | 0.0169 ns | 12.829 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                             From_Bool |        net472 | 10.385 ns | 0.0541 ns | 0.0506 ns | 10.379 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Bool_AsObject | .NET Core 2.0 | 17.777 ns | 0.0340 ns | 0.0301 ns | 17.771 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 2.2 | 15.094 ns | 0.0312 ns | 0.0276 ns | 15.094 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 3.0 | 15.453 ns | 0.0739 ns | 0.0655 ns | 15.448 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net461 | 18.476 ns | 0.0300 ns | 0.0250 ns | 18.475 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net472 | 20.175 ns | 0.0304 ns | 0.0269 ns | 20.171 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Bool_Nullable_WithValue | .NET Core 2.0 | 12.389 ns | 0.0203 ns | 0.0180 ns | 12.384 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 2.2 | 10.429 ns | 0.0472 ns | 0.0394 ns | 10.441 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 3.0 |  7.519 ns | 0.4063 ns | 0.4836 ns |  7.265 ns |  0.62 |    0.04 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net461 | 13.664 ns | 0.0856 ns | 0.0801 ns | 13.688 ns |  1.10 |    0.01 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net472 | 12.427 ns | 0.0227 ns | 0.0212 ns | 12.429 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.081 ns | 0.0322 ns | 0.0301 ns | 19.079 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.103 ns | 0.0173 ns | 0.0162 ns | 15.101 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.536 ns | 0.2819 ns | 0.2637 ns | 15.399 ns |  0.81 |    0.01 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net461 | 18.826 ns | 0.0305 ns | 0.0285 ns | 18.830 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net472 | 21.099 ns | 0.1029 ns | 0.0962 ns | 21.058 ns |  1.11 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Bool_Nullable_NoValue | .NET Core 2.0 | 11.837 ns | 0.0153 ns | 0.0128 ns | 11.832 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 2.2 | 10.017 ns | 0.0142 ns | 0.0133 ns | 10.014 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 3.0 |  6.587 ns | 0.0144 ns | 0.0135 ns |  6.587 ns |  0.56 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net461 | 12.799 ns | 0.0638 ns | 0.0566 ns | 12.776 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net472 | 10.543 ns | 0.0388 ns | 0.0363 ns | 10.549 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.788 ns | 0.0095 ns | 0.0079 ns | 14.787 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.863 ns | 0.0085 ns | 0.0080 ns | 11.861 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.683 ns | 0.2902 ns | 0.4254 ns | 13.888 ns |  0.91 |    0.04 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net461 | 14.157 ns | 0.0174 ns | 0.0154 ns | 14.159 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net472 | 15.824 ns | 0.0228 ns | 0.0202 ns | 15.826 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Byte | .NET Core 2.0 | 11.475 ns | 0.0165 ns | 0.0146 ns | 11.473 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 2.2 | 10.057 ns | 0.0340 ns | 0.0318 ns | 10.047 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 3.0 |  7.100 ns | 0.2910 ns | 0.3464 ns |  6.914 ns |  0.63 |    0.03 |      - |     - |     - |         - |
                                             From_Byte |        net461 | 13.285 ns | 0.0282 ns | 0.0250 ns | 13.278 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                                             From_Byte |        net472 | 10.293 ns | 0.0149 ns | 0.0139 ns | 10.291 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Byte_AsObject | .NET Core 2.0 | 17.960 ns | 0.1331 ns | 0.1245 ns | 17.895 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 2.2 | 15.177 ns | 0.0218 ns | 0.0194 ns | 15.177 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 3.0 | 17.447 ns | 0.1020 ns | 0.0954 ns | 17.479 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net461 | 20.955 ns | 0.0269 ns | 0.0252 ns | 20.947 ns |  1.17 |    0.01 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net472 | 20.050 ns | 0.0215 ns | 0.0201 ns | 20.048 ns |  1.12 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Byte_Nullable_WithValue | .NET Core 2.0 | 11.749 ns | 0.0122 ns | 0.0114 ns | 11.748 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 2.2 | 11.610 ns | 0.0219 ns | 0.0205 ns | 11.605 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 3.0 |  7.645 ns | 0.1723 ns | 0.2415 ns |  7.712 ns |  0.65 |    0.03 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net461 | 13.399 ns | 0.0209 ns | 0.0195 ns | 13.408 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net472 | 10.548 ns | 0.0391 ns | 0.0346 ns | 10.542 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.100 ns | 0.0395 ns | 0.0350 ns | 19.086 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.250 ns | 0.0298 ns | 0.0265 ns | 15.245 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.546 ns | 0.1935 ns | 0.1810 ns | 15.523 ns |  0.81 |    0.01 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net461 | 18.947 ns | 0.0741 ns | 0.0656 ns | 18.965 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net472 | 20.044 ns | 0.0232 ns | 0.0217 ns | 20.044 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Byte_Nullable_NoValue | .NET Core 2.0 | 11.701 ns | 0.0203 ns | 0.0189 ns | 11.696 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 2.2 | 10.037 ns | 0.0617 ns | 0.0577 ns | 10.003 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 3.0 |  6.836 ns | 0.0349 ns | 0.0310 ns |  6.826 ns |  0.58 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net461 | 12.028 ns | 0.0206 ns | 0.0172 ns | 12.024 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net472 | 11.848 ns | 0.0180 ns | 0.0151 ns | 11.847 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.010 ns | 0.0789 ns | 0.0738 ns | 14.992 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.516 ns | 0.0182 ns | 0.0161 ns | 13.514 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.849 ns | 0.0223 ns | 0.0198 ns | 12.850 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net461 | 13.281 ns | 0.0734 ns | 0.0687 ns | 13.249 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net472 | 15.694 ns | 0.0261 ns | 0.0232 ns | 15.694 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Char | .NET Core 2.0 | 11.534 ns | 0.0803 ns | 0.0751 ns | 11.499 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Char | .NET Core 2.2 | 10.048 ns | 0.0110 ns | 0.0098 ns | 10.046 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                                             From_Char | .NET Core 3.0 |  7.700 ns | 0.0135 ns | 0.0127 ns |  7.696 ns |  0.67 |    0.00 |      - |     - |     - |         - |
                                             From_Char |        net461 | 12.602 ns | 0.0449 ns | 0.0420 ns | 12.587 ns |  1.09 |    0.01 |      - |     - |     - |         - |
                                             From_Char |        net472 | 10.359 ns | 0.0441 ns | 0.0412 ns | 10.376 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Char_AsObject | .NET Core 2.0 | 18.630 ns | 0.2801 ns | 0.2620 ns | 18.749 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 2.2 | 15.448 ns | 0.0194 ns | 0.0172 ns | 15.450 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 3.0 | 15.535 ns | 0.0866 ns | 0.0811 ns | 15.509 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                                    From_Char_AsObject |        net461 | 18.301 ns | 0.0361 ns | 0.0337 ns | 18.282 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                                    From_Char_AsObject |        net472 | 19.769 ns | 0.0265 ns | 0.0221 ns | 19.770 ns |  1.06 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Char_Nullable_WithValue | .NET Core 2.0 | 11.745 ns | 0.0195 ns | 0.0162 ns | 11.740 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 2.2 | 10.250 ns | 0.0116 ns | 0.0103 ns | 10.247 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 3.0 |  8.196 ns | 0.2142 ns | 0.2860 ns |  8.041 ns |  0.71 |    0.03 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net461 | 12.777 ns | 0.0486 ns | 0.0431 ns | 12.786 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net472 | 10.553 ns | 0.0228 ns | 0.0202 ns | 10.553 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.403 ns | 0.0701 ns | 0.0621 ns | 19.409 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.446 ns | 0.0185 ns | 0.0164 ns | 15.450 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.490 ns | 0.0387 ns | 0.0362 ns | 15.498 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net461 | 20.660 ns | 0.0387 ns | 0.0343 ns | 20.659 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net472 | 19.972 ns | 0.0186 ns | 0.0174 ns | 19.976 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Char_Nullable_NoValue | .NET Core 2.0 | 11.578 ns | 0.0130 ns | 0.0115 ns | 11.575 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 2.2 | 10.031 ns | 0.0195 ns | 0.0163 ns | 10.033 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 3.0 |  7.456 ns | 0.0142 ns | 0.0133 ns |  7.457 ns |  0.64 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net461 | 12.771 ns | 0.0188 ns | 0.0167 ns | 12.766 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net472 | 11.817 ns | 0.0198 ns | 0.0185 ns | 11.811 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.764 ns | 0.0265 ns | 0.0207 ns | 14.760 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.866 ns | 0.0133 ns | 0.0118 ns | 11.864 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.569 ns | 0.0933 ns | 0.0873 ns | 13.604 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net461 | 13.203 ns | 0.0239 ns | 0.0212 ns | 13.196 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net472 | 15.032 ns | 0.0165 ns | 0.0138 ns | 15.030 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                         From_DateTime | .NET Core 2.0 | 11.825 ns | 0.0136 ns | 0.0127 ns | 11.822 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 2.2 | 10.882 ns | 0.0125 ns | 0.0117 ns | 10.883 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 3.0 |  7.845 ns | 0.0168 ns | 0.0158 ns |  7.849 ns |  0.66 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime |        net461 | 13.559 ns | 0.0539 ns | 0.0504 ns | 13.573 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime |        net472 | 11.801 ns | 0.0227 ns | 0.0189 ns | 11.804 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                From_DateTime_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                      From_DateTime_Nullable_WithValue | .NET Core 2.0 | 12.501 ns | 0.0928 ns | 0.0868 ns | 12.458 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 2.2 | 11.049 ns | 0.0209 ns | 0.0195 ns | 11.041 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 3.0 |  8.024 ns | 0.0172 ns | 0.0161 ns |  8.022 ns |  0.64 |    0.01 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net461 | 13.923 ns | 0.0243 ns | 0.0203 ns | 13.924 ns |  1.11 |    0.01 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net472 | 12.584 ns | 0.0121 ns | 0.0108 ns | 12.585 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_DateTime_Nullable_NoValue | .NET Core 2.0 | 12.426 ns | 0.0276 ns | 0.0231 ns | 12.422 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 2.2 | 11.435 ns | 0.0069 ns | 0.0065 ns | 11.434 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 3.0 |  8.494 ns | 0.0769 ns | 0.0720 ns |  8.478 ns |  0.68 |    0.01 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net461 | 16.651 ns | 0.0168 ns | 0.0157 ns | 16.647 ns |  1.34 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net472 | 12.729 ns | 0.0536 ns | 0.0448 ns | 12.741 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.045 ns | 0.0154 ns | 0.0137 ns | 14.041 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.859 ns | 0.0077 ns | 0.0064 ns | 11.859 ns |  0.84 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.244 ns | 0.3076 ns | 0.6816 ns | 14.446 ns |  0.97 |    0.09 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net461 | 16.064 ns | 0.0301 ns | 0.0282 ns | 16.058 ns |  1.14 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net472 | 14.934 ns | 0.0212 ns | 0.0165 ns | 14.939 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                          From_Decimal | .NET Core 2.0 | 21.505 ns | 0.0246 ns | 0.0206 ns | 21.513 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 2.2 | 20.060 ns | 0.1365 ns | 0.1277 ns | 19.991 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 3.0 | 12.928 ns | 0.0369 ns | 0.0327 ns | 12.940 ns |  0.60 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal |        net461 | 19.789 ns | 0.0201 ns | 0.0178 ns | 19.792 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal |        net472 | 21.986 ns | 0.0448 ns | 0.0397 ns | 21.994 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                 From_Decimal_AsObject | .NET Core 2.0 | 26.193 ns | 0.0252 ns | 0.0236 ns | 26.187 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 2.2 | 25.130 ns | 0.0215 ns | 0.0201 ns | 25.134 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 3.0 | 19.823 ns | 0.4137 ns | 0.5081 ns | 20.181 ns |  0.75 |    0.02 |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net461 | 24.368 ns | 0.0343 ns | 0.0321 ns | 24.361 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net472 | 26.398 ns | 0.1057 ns | 0.0989 ns | 26.401 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                       From_Decimal_Nullable_WithValue | .NET Core 2.0 | 22.556 ns | 0.0713 ns | 0.0595 ns | 22.565 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 2.2 | 21.160 ns | 0.0384 ns | 0.0320 ns | 21.161 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 3.0 | 15.736 ns | 0.0286 ns | 0.0267 ns | 15.734 ns |  0.70 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net461 | 21.124 ns | 0.0506 ns | 0.0474 ns | 21.116 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net472 | 19.422 ns | 0.1116 ns | 0.1044 ns | 19.364 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.0 | 26.256 ns | 0.0462 ns | 0.0410 ns | 26.239 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.2 | 25.917 ns | 0.0202 ns | 0.0189 ns | 25.921 ns |  0.99 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 3.0 | 19.314 ns | 0.1111 ns | 0.0985 ns | 19.357 ns |  0.74 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net461 | 24.639 ns | 0.0210 ns | 0.0186 ns | 24.636 ns |  0.94 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net472 | 25.922 ns | 0.0186 ns | 0.0165 ns | 25.919 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Decimal_Nullable_NoValue | .NET Core 2.0 | 12.557 ns | 0.0162 ns | 0.0136 ns | 12.556 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 2.2 | 11.341 ns | 0.0153 ns | 0.0135 ns | 11.338 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 3.0 |  8.022 ns | 0.1156 ns | 0.1082 ns |  7.930 ns |  0.64 |    0.01 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net461 | 14.583 ns | 0.0831 ns | 0.0777 ns | 14.547 ns |  1.16 |    0.01 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net472 | 13.511 ns | 0.0096 ns | 0.0080 ns | 13.513 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.108 ns | 0.0151 ns | 0.0142 ns | 14.104 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.161 ns | 0.0094 ns | 0.0084 ns | 12.161 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.912 ns | 0.0191 ns | 0.0178 ns | 11.909 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net461 | 13.212 ns | 0.0298 ns | 0.0279 ns | 13.224 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net472 | 15.063 ns | 0.0184 ns | 0.0172 ns | 15.067 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_Double | .NET Core 2.0 | 12.414 ns | 0.0215 ns | 0.0201 ns | 12.411 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 2.2 | 10.821 ns | 0.0315 ns | 0.0279 ns | 10.825 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 3.0 |  8.512 ns | 0.0254 ns | 0.0238 ns |  8.512 ns |  0.69 |    0.00 |      - |     - |     - |         - |
                                           From_Double |        net461 | 12.970 ns | 0.0505 ns | 0.0472 ns | 12.955 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                           From_Double |        net472 | 12.951 ns | 0.0321 ns | 0.0301 ns | 12.945 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_Double_AsObject | .NET Core 2.0 | 19.428 ns | 0.0602 ns | 0.0534 ns | 19.420 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 2.2 | 15.784 ns | 0.0440 ns | 0.0412 ns | 15.784 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 3.0 | 16.624 ns | 0.0195 ns | 0.0183 ns | 16.620 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject |        net461 | 19.774 ns | 0.0182 ns | 0.0171 ns | 19.773 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject |        net472 | 20.830 ns | 0.1062 ns | 0.0994 ns | 20.785 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_Double_Nullable_WithValue | .NET Core 2.0 | 15.154 ns | 0.0401 ns | 0.0375 ns | 15.166 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 2.2 | 12.656 ns | 0.0218 ns | 0.0204 ns | 12.656 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 3.0 | 10.568 ns | 0.0127 ns | 0.0113 ns | 10.567 ns |  0.70 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net461 | 16.014 ns | 0.0505 ns | 0.0473 ns | 16.026 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net472 | 14.288 ns | 0.0188 ns | 0.0167 ns | 14.288 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.150 ns | 0.0518 ns | 0.0459 ns | 19.139 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.962 ns | 0.0558 ns | 0.0521 ns | 15.965 ns |  0.83 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 3.0 | 16.601 ns | 0.0564 ns | 0.0527 ns | 16.599 ns |  0.87 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net461 | 19.510 ns | 0.0276 ns | 0.0230 ns | 19.513 ns |  1.02 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net472 | 20.809 ns | 0.0261 ns | 0.0231 ns | 20.807 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Double_Nullable_NoValue | .NET Core 2.0 | 12.484 ns | 0.0230 ns | 0.0215 ns | 12.484 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 2.2 | 11.311 ns | 0.0849 ns | 0.0794 ns | 11.355 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 3.0 |  9.410 ns | 0.2146 ns | 0.3340 ns |  9.531 ns |  0.74 |    0.04 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net461 | 13.576 ns | 0.0258 ns | 0.0241 ns | 13.574 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net472 | 13.017 ns | 0.0218 ns | 0.0204 ns | 13.024 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.990 ns | 0.0206 ns | 0.0193 ns | 14.991 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.854 ns | 0.0099 ns | 0.0083 ns | 11.853 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.510 ns | 0.0749 ns | 0.0701 ns | 13.539 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net461 | 13.300 ns | 0.0155 ns | 0.0121 ns | 13.302 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net472 | 15.033 ns | 0.0210 ns | 0.0175 ns | 15.037 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_Short | .NET Core 2.0 | 11.605 ns | 0.0355 ns | 0.0296 ns | 11.606 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 2.2 | 10.068 ns | 0.0141 ns | 0.0132 ns | 10.067 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 3.0 |  6.840 ns | 0.0080 ns | 0.0067 ns |  6.839 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                                            From_Short |        net461 | 11.795 ns | 0.0200 ns | 0.0187 ns | 11.792 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                            From_Short |        net472 | 10.281 ns | 0.0248 ns | 0.0220 ns | 10.281 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_Short_AsObject | .NET Core 2.0 | 18.052 ns | 0.0243 ns | 0.0216 ns | 18.051 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 2.2 | 14.528 ns | 0.0195 ns | 0.0183 ns | 14.528 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 3.0 | 15.156 ns | 0.0866 ns | 0.0810 ns | 15.179 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net461 | 21.169 ns | 0.0235 ns | 0.0196 ns | 21.162 ns |  1.17 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net472 | 20.741 ns | 0.0683 ns | 0.0639 ns | 20.738 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Short_Nullable_WithValue | .NET Core 2.0 | 11.770 ns | 0.0135 ns | 0.0126 ns | 11.769 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 2.2 | 10.286 ns | 0.0525 ns | 0.0491 ns | 10.272 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 3.0 |  6.863 ns | 0.0247 ns | 0.0231 ns |  6.864 ns |  0.58 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net461 | 12.521 ns | 0.0181 ns | 0.0170 ns | 12.518 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net472 | 10.539 ns | 0.0160 ns | 0.0149 ns | 10.535 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.0 | 17.916 ns | 0.0590 ns | 0.0523 ns | 17.902 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.2 | 14.540 ns | 0.0193 ns | 0.0181 ns | 14.536 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.191 ns | 0.1726 ns | 0.1614 ns | 15.123 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net461 | 18.938 ns | 0.0233 ns | 0.0206 ns | 18.939 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net472 | 20.867 ns | 0.1266 ns | 0.1184 ns | 20.816 ns |  1.16 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Short_Nullable_NoValue | .NET Core 2.0 | 11.621 ns | 0.0268 ns | 0.0237 ns | 11.616 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 2.2 |  9.959 ns | 0.0305 ns | 0.0271 ns |  9.965 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 3.0 |  7.476 ns | 0.0203 ns | 0.0180 ns |  7.478 ns |  0.64 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net461 | 12.085 ns | 0.0169 ns | 0.0158 ns | 12.080 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net472 | 11.840 ns | 0.0115 ns | 0.0102 ns | 11.837 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.409 ns | 0.0144 ns | 0.0128 ns | 14.407 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.843 ns | 0.0122 ns | 0.0102 ns | 11.843 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.026 ns | 0.0380 ns | 0.0355 ns | 13.045 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net461 | 13.960 ns | 0.0194 ns | 0.0181 ns | 13.957 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net472 | 14.914 ns | 0.0359 ns | 0.0318 ns | 14.903 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                              From_Int | .NET Core 2.0 | 11.712 ns | 0.0114 ns | 0.0095 ns | 11.715 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 2.2 |  9.982 ns | 0.0103 ns | 0.0092 ns |  9.982 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 3.0 |  6.759 ns | 0.0307 ns | 0.0272 ns |  6.768 ns |  0.58 |    0.00 |      - |     - |     - |         - |
                                              From_Int |        net461 | 10.323 ns | 0.0116 ns | 0.0090 ns | 10.323 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                              From_Int |        net472 | 11.974 ns | 0.0345 ns | 0.0306 ns | 11.983 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_Int_AsObject | .NET Core 2.0 | 14.698 ns | 0.0996 ns | 0.0932 ns | 14.645 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 2.2 | 12.475 ns | 0.0187 ns | 0.0175 ns | 12.472 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 3.0 | 11.678 ns | 0.0325 ns | 0.0304 ns | 11.664 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net461 | 15.008 ns | 0.0133 ns | 0.0125 ns | 15.011 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net472 | 15.748 ns | 0.0571 ns | 0.0506 ns | 15.729 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Int_Nullable_WithValue | .NET Core 2.0 | 11.781 ns | 0.0145 ns | 0.0121 ns | 11.782 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 2.2 | 10.730 ns | 0.0142 ns | 0.0126 ns | 10.730 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 3.0 |  7.124 ns | 0.0224 ns | 0.0209 ns |  7.118 ns |  0.60 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net461 | 10.625 ns | 0.0181 ns | 0.0161 ns | 10.625 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net472 | 10.710 ns | 0.0317 ns | 0.0281 ns | 10.719 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.0 | 14.696 ns | 0.0228 ns | 0.0202 ns | 14.696 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.2 | 12.599 ns | 0.0689 ns | 0.0645 ns | 12.625 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 3.0 | 13.966 ns | 0.0421 ns | 0.0394 ns | 13.977 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net461 | 14.459 ns | 0.0291 ns | 0.0272 ns | 14.464 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net472 | 15.944 ns | 0.0223 ns | 0.0209 ns | 15.945 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_Int_Nullable_NoValue | .NET Core 2.0 | 12.521 ns | 0.0156 ns | 0.0130 ns | 12.522 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 2.2 |  9.969 ns | 0.0145 ns | 0.0136 ns |  9.971 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 3.0 |  6.869 ns | 0.0184 ns | 0.0163 ns |  6.866 ns |  0.55 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net461 | 11.850 ns | 0.0141 ns | 0.0132 ns | 11.848 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net472 | 11.757 ns | 0.0721 ns | 0.0675 ns | 11.796 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.934 ns | 0.0154 ns | 0.0144 ns | 14.933 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.879 ns | 0.0536 ns | 0.0501 ns | 11.855 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.251 ns | 0.1659 ns | 0.1552 ns | 12.166 ns |  0.82 |    0.01 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net461 | 13.264 ns | 0.0216 ns | 0.0192 ns | 13.264 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net472 | 15.206 ns | 0.0143 ns | 0.0119 ns | 15.205 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Long | .NET Core 2.0 | 11.871 ns | 0.0121 ns | 0.0107 ns | 11.868 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Long | .NET Core 2.2 | 10.726 ns | 0.0655 ns | 0.0613 ns | 10.722 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                                             From_Long | .NET Core 3.0 |  8.122 ns | 0.1816 ns | 0.2424 ns |  7.985 ns |  0.69 |    0.02 |      - |     - |     - |         - |
                                             From_Long |        net461 | 13.407 ns | 0.0200 ns | 0.0167 ns | 13.409 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                             From_Long |        net472 | 12.425 ns | 0.0125 ns | 0.0117 ns | 12.424 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Long_AsObject | .NET Core 2.0 | 18.560 ns | 0.0276 ns | 0.0258 ns | 18.560 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 2.2 | 16.354 ns | 0.0322 ns | 0.0301 ns | 16.355 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 3.0 | 18.035 ns | 0.1869 ns | 0.1748 ns | 18.097 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net461 | 21.507 ns | 0.0207 ns | 0.0194 ns | 21.502 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net472 | 20.720 ns | 0.0523 ns | 0.0490 ns | 20.729 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Long_Nullable_WithValue | .NET Core 2.0 | 13.591 ns | 0.0146 ns | 0.0137 ns | 13.590 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 2.2 | 12.565 ns | 0.0708 ns | 0.0662 ns | 12.600 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 3.0 | 11.797 ns | 0.1373 ns | 0.1285 ns | 11.881 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net461 | 14.677 ns | 0.0629 ns | 0.0588 ns | 14.651 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net472 | 13.961 ns | 0.0782 ns | 0.0732 ns | 13.932 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.922 ns | 0.1342 ns | 0.1255 ns | 18.978 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.947 ns | 0.0400 ns | 0.0374 ns | 15.946 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.928 ns | 0.0586 ns | 0.0548 ns | 15.922 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net461 | 19.429 ns | 0.0126 ns | 0.0118 ns | 19.428 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net472 | 20.779 ns | 0.0248 ns | 0.0220 ns | 20.775 ns |  1.10 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Long_Nullable_NoValue | .NET Core 2.0 | 12.459 ns | 0.0085 ns | 0.0075 ns | 12.458 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 2.2 | 11.176 ns | 0.0106 ns | 0.0099 ns | 11.177 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 3.0 |  8.953 ns | 0.0127 ns | 0.0119 ns |  8.951 ns |  0.72 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net461 | 14.147 ns | 0.0197 ns | 0.0174 ns | 14.144 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net472 | 14.604 ns | 0.0297 ns | 0.0277 ns | 14.610 ns |  1.17 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.104 ns | 0.0787 ns | 0.0736 ns | 15.131 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.930 ns | 0.0130 ns | 0.0122 ns | 12.928 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.866 ns | 0.0657 ns | 0.0615 ns | 12.839 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net461 | 13.697 ns | 0.0305 ns | 0.0286 ns | 13.687 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net472 | 16.261 ns | 0.0132 ns | 0.0123 ns | 16.260 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_SByte | .NET Core 2.0 | 11.498 ns | 0.0419 ns | 0.0372 ns | 11.482 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 2.2 | 10.038 ns | 0.0093 ns | 0.0087 ns | 10.039 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 3.0 |  6.653 ns | 0.0494 ns | 0.0463 ns |  6.641 ns |  0.58 |    0.00 |      - |     - |     - |         - |
                                            From_SByte |        net461 | 11.840 ns | 0.0391 ns | 0.0366 ns | 11.830 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                            From_SByte |        net472 | 10.620 ns | 0.0583 ns | 0.0545 ns | 10.598 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_SByte_AsObject | .NET Core 2.0 | 18.038 ns | 0.0822 ns | 0.0769 ns | 18.068 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 2.2 | 14.543 ns | 0.0351 ns | 0.0311 ns | 14.533 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 3.0 | 17.305 ns | 0.0255 ns | 0.0239 ns | 17.303 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net461 | 18.819 ns | 0.0301 ns | 0.0281 ns | 18.833 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net472 | 20.074 ns | 0.0337 ns | 0.0315 ns | 20.072 ns |  1.11 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_SByte_Nullable_WithValue | .NET Core 2.0 | 11.763 ns | 0.0144 ns | 0.0135 ns | 11.759 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 2.2 | 10.242 ns | 0.0180 ns | 0.0169 ns | 10.245 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 3.0 |  6.842 ns | 0.0137 ns | 0.0122 ns |  6.839 ns |  0.58 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net461 | 12.545 ns | 0.0202 ns | 0.0169 ns | 12.545 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net472 | 10.536 ns | 0.0188 ns | 0.0167 ns | 10.534 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.388 ns | 0.0399 ns | 0.0333 ns | 18.395 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.2 | 14.759 ns | 0.0193 ns | 0.0171 ns | 14.754 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.628 ns | 0.1021 ns | 0.0956 ns | 17.647 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net461 | 21.172 ns | 0.1264 ns | 0.1183 ns | 21.213 ns |  1.15 |    0.01 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net472 | 20.926 ns | 0.0651 ns | 0.0609 ns | 20.934 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_SByte_Nullable_NoValue | .NET Core 2.0 | 11.606 ns | 0.0162 ns | 0.0151 ns | 11.602 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 2.2 | 10.009 ns | 0.0141 ns | 0.0125 ns | 10.008 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 3.0 |  6.770 ns | 0.1955 ns | 0.3101 ns |  6.604 ns |  0.60 |    0.03 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net461 | 12.462 ns | 0.0220 ns | 0.0195 ns | 12.458 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net472 | 10.392 ns | 0.0119 ns | 0.0111 ns | 10.391 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.970 ns | 0.0118 ns | 0.0105 ns | 14.970 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.997 ns | 0.0175 ns | 0.0163 ns | 12.994 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.087 ns | 0.0489 ns | 0.0434 ns | 12.091 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net461 | 13.220 ns | 0.0228 ns | 0.0191 ns | 13.215 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net472 | 14.999 ns | 0.0686 ns | 0.0642 ns | 15.024 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_Float | .NET Core 2.0 | 12.359 ns | 0.0276 ns | 0.0258 ns | 12.362 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 2.2 | 10.881 ns | 0.0192 ns | 0.0160 ns | 10.874 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 3.0 |  9.216 ns | 0.0113 ns | 0.0094 ns |  9.216 ns |  0.75 |    0.00 |      - |     - |     - |         - |
                                            From_Float |        net461 | 13.628 ns | 0.0179 ns | 0.0168 ns | 13.627 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                            From_Float |        net472 | 11.999 ns | 0.0149 ns | 0.0125 ns | 11.998 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_Float_AsObject | .NET Core 2.0 | 19.492 ns | 0.0205 ns | 0.0182 ns | 19.494 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 2.2 | 15.740 ns | 0.0405 ns | 0.0379 ns | 15.738 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 3.0 | 18.927 ns | 0.4005 ns | 0.6691 ns | 19.129 ns |  0.96 |    0.05 |      - |     - |     - |         - |
                                   From_Float_AsObject |        net461 | 19.534 ns | 0.0298 ns | 0.0279 ns | 19.541 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject |        net472 | 21.151 ns | 0.0374 ns | 0.0331 ns | 21.144 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Float_Nullable_WithValue | .NET Core 2.0 | 13.932 ns | 0.0186 ns | 0.0165 ns | 13.931 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 2.2 | 11.826 ns | 0.0137 ns | 0.0122 ns | 11.823 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 3.0 | 10.196 ns | 0.0179 ns | 0.0159 ns | 10.194 ns |  0.73 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net461 | 14.677 ns | 0.0371 ns | 0.0329 ns | 14.670 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net472 | 13.019 ns | 0.0127 ns | 0.0113 ns | 13.016 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.332 ns | 0.0294 ns | 0.0275 ns | 19.325 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.806 ns | 0.1041 ns | 0.0974 ns | 17.834 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.749 ns | 0.0385 ns | 0.0342 ns | 17.757 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net461 | 21.861 ns | 0.0278 ns | 0.0260 ns | 21.859 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net472 | 21.158 ns | 0.0293 ns | 0.0244 ns | 21.158 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Float_Nullable_NoValue | .NET Core 2.0 | 11.685 ns | 0.0088 ns | 0.0078 ns | 11.686 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 2.2 | 10.065 ns | 0.0172 ns | 0.0161 ns | 10.067 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 3.0 |  6.668 ns | 0.0369 ns | 0.0327 ns |  6.679 ns |  0.57 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net461 | 12.034 ns | 0.0428 ns | 0.0379 ns | 12.017 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net472 | 10.441 ns | 0.0144 ns | 0.0127 ns | 10.441 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.0 | 16.338 ns | 0.0224 ns | 0.0198 ns | 16.337 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.755 ns | 0.0107 ns | 0.0090 ns | 12.754 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.839 ns | 0.0198 ns | 0.0176 ns | 12.834 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net461 | 15.796 ns | 0.0220 ns | 0.0184 ns | 15.797 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net472 | 15.304 ns | 0.0190 ns | 0.0178 ns | 15.307 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_String | .NET Core 2.0 | 57.040 ns | 0.1078 ns | 0.1008 ns | 57.028 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 2.2 | 51.849 ns | 0.1194 ns | 0.1117 ns | 51.855 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 3.0 | 20.414 ns | 0.1242 ns | 0.1162 ns | 20.437 ns |  0.36 |    0.00 |      - |     - |     - |         - |
                                           From_String |        net461 | 56.398 ns | 0.1654 ns | 0.1547 ns | 56.349 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                           From_String |        net472 | 59.552 ns | 0.2523 ns | 0.2360 ns | 59.521 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_String_AsObject | .NET Core 2.0 | 62.509 ns | 0.4206 ns | 0.3729 ns | 62.660 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 2.2 | 57.324 ns | 0.0605 ns | 0.0537 ns | 57.326 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 3.0 | 23.368 ns | 0.0632 ns | 0.0494 ns | 23.373 ns |  0.37 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject |        net461 | 63.769 ns | 0.0785 ns | 0.0734 ns | 63.757 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                                  From_String_AsObject |        net472 | 63.659 ns | 0.1344 ns | 0.1192 ns | 63.669 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                      From_String_Null | .NET Core 2.0 | 12.319 ns | 0.0101 ns | 0.0084 ns | 12.320 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 2.2 | 11.753 ns | 0.0129 ns | 0.0120 ns | 11.754 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 3.0 | 11.748 ns | 0.0192 ns | 0.0160 ns | 11.747 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null |        net461 | 12.711 ns | 0.0161 ns | 0.0143 ns | 12.709 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null |        net472 | 15.042 ns | 0.0182 ns | 0.0170 ns | 15.038 ns |  1.22 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_String_Null_AsObject | .NET Core 2.0 | 14.054 ns | 0.0131 ns | 0.0109 ns | 14.052 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 2.2 | 11.854 ns | 0.0152 ns | 0.0134 ns | 11.855 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 3.0 | 12.145 ns | 0.0930 ns | 0.0870 ns | 12.178 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net461 | 13.916 ns | 0.0301 ns | 0.0282 ns | 13.916 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net472 | 16.079 ns | 0.1349 ns | 0.1261 ns | 16.012 ns |  1.14 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_String_Empty | .NET Core 2.0 | 12.536 ns | 0.0150 ns | 0.0126 ns | 12.537 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 2.2 | 11.389 ns | 0.0110 ns | 0.0086 ns | 11.391 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 3.0 | 13.766 ns | 0.2989 ns | 0.7162 ns | 14.025 ns |  1.01 |    0.09 |      - |     - |     - |         - |
                                     From_String_Empty |        net461 | 12.741 ns | 0.0377 ns | 0.0352 ns | 12.732 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty |        net472 | 16.045 ns | 0.0813 ns | 0.0761 ns | 16.009 ns |  1.28 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_String_Empty_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_UShort | .NET Core 2.0 | 11.496 ns | 0.0124 ns | 0.0116 ns | 11.495 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 2.2 | 10.027 ns | 0.0105 ns | 0.0098 ns | 10.025 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 3.0 |  6.682 ns | 0.0315 ns | 0.0295 ns |  6.691 ns |  0.58 |    0.00 |      - |     - |     - |         - |
                                           From_UShort |        net461 | 11.895 ns | 0.0748 ns | 0.0699 ns | 11.865 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                           From_UShort |        net472 | 10.281 ns | 0.0156 ns | 0.0146 ns | 10.278 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_UShort_AsObject | .NET Core 2.0 | 17.883 ns | 0.0905 ns | 0.0846 ns | 17.849 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 2.2 | 14.754 ns | 0.0194 ns | 0.0181 ns | 14.752 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 3.0 | 17.220 ns | 0.0352 ns | 0.0329 ns | 17.214 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net461 | 20.973 ns | 0.0326 ns | 0.0305 ns | 20.980 ns |  1.17 |    0.01 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net472 | 20.083 ns | 0.0513 ns | 0.0454 ns | 20.068 ns |  1.12 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_UShort_Nullable_WithValue | .NET Core 2.0 | 11.771 ns | 0.0162 ns | 0.0152 ns | 11.765 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 2.2 | 10.258 ns | 0.0140 ns | 0.0131 ns | 10.260 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 3.0 |  6.849 ns | 0.0243 ns | 0.0203 ns |  6.849 ns |  0.58 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net461 | 12.555 ns | 0.0770 ns | 0.0720 ns | 12.526 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net472 | 10.523 ns | 0.0184 ns | 0.0172 ns | 10.522 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.558 ns | 0.0337 ns | 0.0315 ns | 18.552 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.2 | 14.755 ns | 0.0149 ns | 0.0139 ns | 14.753 ns |  0.80 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.686 ns | 0.9161 ns | 0.9408 ns | 15.203 ns |  0.85 |    0.05 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net461 | 19.003 ns | 0.0218 ns | 0.0194 ns | 19.001 ns |  1.02 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net472 | 20.496 ns | 0.0268 ns | 0.0237 ns | 20.489 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_UShort_Nullable_NoValue | .NET Core 2.0 | 11.909 ns | 0.0290 ns | 0.0271 ns | 11.902 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 2.2 | 10.082 ns | 0.0371 ns | 0.0329 ns | 10.086 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 3.0 |  6.720 ns | 0.0127 ns | 0.0112 ns |  6.722 ns |  0.56 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net461 | 12.777 ns | 0.0395 ns | 0.0350 ns | 12.766 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net472 | 11.863 ns | 0.0357 ns | 0.0316 ns | 11.850 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.964 ns | 0.0224 ns | 0.0210 ns | 14.961 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.520 ns | 0.0142 ns | 0.0119 ns | 13.516 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.492 ns | 0.0984 ns | 0.0921 ns | 11.428 ns |  0.77 |    0.01 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net461 | 13.303 ns | 0.0197 ns | 0.0174 ns | 13.299 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net472 | 15.734 ns | 0.0264 ns | 0.0206 ns | 15.734 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_UInt | .NET Core 2.0 | 11.532 ns | 0.0198 ns | 0.0175 ns | 11.533 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 2.2 | 10.286 ns | 0.0197 ns | 0.0184 ns | 10.280 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 3.0 |  6.966 ns | 0.0409 ns | 0.0382 ns |  6.978 ns |  0.60 |    0.00 |      - |     - |     - |         - |
                                             From_UInt |        net461 | 12.574 ns | 0.0280 ns | 0.0248 ns | 12.569 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                             From_UInt |        net472 | 10.655 ns | 0.0471 ns | 0.0418 ns | 10.637 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_UInt_AsObject | .NET Core 2.0 | 18.100 ns | 0.0362 ns | 0.0321 ns | 18.093 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 2.2 | 14.840 ns | 0.0184 ns | 0.0173 ns | 14.838 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 3.0 | 15.937 ns | 0.4222 ns | 0.5637 ns | 15.632 ns |  0.89 |    0.04 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net461 | 21.504 ns | 0.0260 ns | 0.0243 ns | 21.501 ns |  1.19 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net472 | 20.712 ns | 0.0729 ns | 0.0682 ns | 20.735 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_UInt_Nullable_WithValue | .NET Core 2.0 | 11.856 ns | 0.0175 ns | 0.0164 ns | 11.853 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 2.2 | 10.343 ns | 0.0154 ns | 0.0144 ns | 10.341 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 3.0 |  6.896 ns | 0.0143 ns | 0.0134 ns |  6.894 ns |  0.58 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net461 | 14.430 ns | 0.0196 ns | 0.0184 ns | 14.433 ns |  1.22 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net472 | 12.043 ns | 0.0156 ns | 0.0138 ns | 12.044 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.124 ns | 0.0421 ns | 0.0373 ns | 18.130 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.017 ns | 0.0218 ns | 0.0193 ns | 15.021 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.385 ns | 0.2347 ns | 0.2195 ns | 15.507 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net461 | 19.190 ns | 0.0206 ns | 0.0182 ns | 19.187 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net472 | 20.560 ns | 0.0337 ns | 0.0315 ns | 20.558 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_UInt_Nullable_NoValue | .NET Core 2.0 | 11.621 ns | 0.0195 ns | 0.0173 ns | 11.620 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 2.2 | 10.182 ns | 0.0495 ns | 0.0439 ns | 10.194 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 3.0 |  6.815 ns | 0.0122 ns | 0.0108 ns |  6.812 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net461 | 12.064 ns | 0.0683 ns | 0.0639 ns | 12.102 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net472 | 11.847 ns | 0.0122 ns | 0.0108 ns | 11.849 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.092 ns | 0.0203 ns | 0.0190 ns | 14.095 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.854 ns | 0.0093 ns | 0.0082 ns | 11.853 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.040 ns | 0.2835 ns | 0.4330 ns | 13.200 ns |  0.91 |    0.04 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net461 | 13.646 ns | 0.0175 ns | 0.0155 ns | 13.647 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net472 | 14.994 ns | 0.0285 ns | 0.0253 ns | 14.988 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_ULong | .NET Core 2.0 | 11.942 ns | 0.0137 ns | 0.0128 ns | 11.940 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 2.2 | 10.448 ns | 0.0104 ns | 0.0092 ns | 10.446 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 3.0 |  8.204 ns | 0.1037 ns | 0.0970 ns |  8.212 ns |  0.69 |    0.01 |      - |     - |     - |         - |
                                            From_ULong |        net461 | 13.427 ns | 0.0357 ns | 0.0334 ns | 13.432 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                            From_ULong |        net472 | 10.681 ns | 0.0152 ns | 0.0134 ns | 10.682 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_ULong_AsObject | .NET Core 2.0 | 19.352 ns | 0.1281 ns | 0.1198 ns | 19.318 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 2.2 | 15.245 ns | 0.0260 ns | 0.0243 ns | 15.236 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 3.0 | 18.299 ns | 0.0601 ns | 0.0533 ns | 18.313 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net461 | 21.912 ns | 0.0259 ns | 0.0243 ns | 21.914 ns |  1.13 |    0.01 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net472 | 21.640 ns | 0.0397 ns | 0.0352 ns | 21.642 ns |  1.12 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_ULong_Nullable_WithValue | .NET Core 2.0 | 14.336 ns | 0.0298 ns | 0.0279 ns | 14.336 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 2.2 | 12.475 ns | 0.0211 ns | 0.0187 ns | 12.476 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 3.0 | 10.328 ns | 0.0870 ns | 0.0814 ns | 10.361 ns |  0.72 |    0.01 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net461 | 14.705 ns | 0.0208 ns | 0.0184 ns | 14.706 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net472 | 14.061 ns | 0.0420 ns | 0.0372 ns | 14.060 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.989 ns | 0.0298 ns | 0.0279 ns | 18.982 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.736 ns | 0.0269 ns | 0.0225 ns | 15.730 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 3.0 | 16.181 ns | 0.0233 ns | 0.0195 ns | 16.183 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net461 | 20.279 ns | 0.0253 ns | 0.0237 ns | 20.284 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net472 | 21.616 ns | 0.0294 ns | 0.0261 ns | 21.613 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_ULong_Nullable_NoValue | .NET Core 2.0 | 12.481 ns | 0.0170 ns | 0.0159 ns | 12.476 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 2.2 | 11.170 ns | 0.0134 ns | 0.0125 ns | 11.165 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 3.0 |  7.979 ns | 0.0249 ns | 0.0233 ns |  7.977 ns |  0.64 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net461 | 13.535 ns | 0.0166 ns | 0.0155 ns | 13.535 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net472 | 12.861 ns | 0.0311 ns | 0.0276 ns | 12.850 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.997 ns | 0.0222 ns | 0.0197 ns | 14.998 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.074 ns | 0.0134 ns | 0.0125 ns | 12.069 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.908 ns | 0.0125 ns | 0.0117 ns | 11.911 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net461 | 13.228 ns | 0.0353 ns | 0.0330 ns | 13.221 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net472 | 14.875 ns | 0.0292 ns | 0.0259 ns | 14.870 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                       From_NullObject | .NET Core 2.0 | 14.045 ns | 0.0149 ns | 0.0124 ns | 14.045 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 2.2 | 11.844 ns | 0.0195 ns | 0.0162 ns | 11.840 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 3.0 | 14.223 ns | 0.0833 ns | 0.0779 ns | 14.210 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                       From_NullObject |        net461 | 15.830 ns | 0.0328 ns | 0.0307 ns | 15.823 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject |        net472 | 15.842 ns | 0.0247 ns | 0.0231 ns | 15.830 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_DBNull | .NET Core 2.0 | 11.428 ns | 0.0171 ns | 0.0160 ns | 11.426 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 2.2 |  9.794 ns | 0.0089 ns | 0.0069 ns |  9.795 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 3.0 | 12.534 ns | 0.2753 ns | 0.3675 ns | 12.510 ns |  1.09 |    0.03 |      - |     - |     - |         - |
                                           From_DBNull |        net461 | 11.011 ns | 0.0128 ns | 0.0120 ns | 11.011 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull |        net472 | 11.207 ns | 0.0236 ns | 0.0209 ns | 11.203 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_DBNull_AsObject | .NET Core 2.0 | 14.174 ns | 0.0137 ns | 0.0114 ns | 14.174 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 2.2 | 14.103 ns | 0.0128 ns | 0.0113 ns | 14.100 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 3.0 | 11.925 ns | 0.0176 ns | 0.0165 ns | 11.927 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net461 | 13.416 ns | 0.0524 ns | 0.0491 ns | 13.438 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net472 | 15.026 ns | 0.0128 ns | 0.0113 ns | 15.025 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                 From_ConvertibleClass | .NET Core 2.0 | 16.117 ns | 0.0154 ns | 0.0129 ns | 16.118 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 2.2 | 13.231 ns | 0.0120 ns | 0.0107 ns | 13.228 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 3.0 | 12.607 ns | 0.2788 ns | 0.3099 ns | 12.778 ns |  0.78 |    0.02 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net461 | 17.640 ns | 0.0206 ns | 0.0193 ns | 17.641 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net472 | 16.862 ns | 0.0405 ns | 0.0378 ns | 16.866 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_ConvertibleClass_AsObject | .NET Core 2.0 | 17.323 ns | 0.0375 ns | 0.0351 ns | 17.330 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 2.2 | 14.231 ns | 0.0446 ns | 0.0417 ns | 14.246 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 3.0 | 14.651 ns | 0.3198 ns | 0.3141 ns | 14.810 ns |  0.85 |    0.02 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net461 | 16.546 ns | 0.0326 ns | 0.0255 ns | 16.554 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net472 | 18.594 ns | 0.0263 ns | 0.0233 ns | 18.602 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_ConvertibleClass_NoValue | .NET Core 2.0 | 12.939 ns | 0.0230 ns | 0.0215 ns | 12.934 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 2.2 | 12.367 ns | 0.0109 ns | 0.0097 ns | 12.367 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 3.0 | 11.422 ns | 0.0565 ns | 0.0528 ns | 11.443 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net461 | 13.236 ns | 0.0217 ns | 0.0203 ns | 13.240 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net472 | 14.861 ns | 0.0358 ns | 0.0317 ns | 14.857 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.0 | 14.075 ns | 0.0152 ns | 0.0134 ns | 14.079 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.2 | 11.851 ns | 0.0055 ns | 0.0051 ns | 11.850 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 3.0 | 13.617 ns | 0.0217 ns | 0.0203 ns | 13.615 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net461 | 13.302 ns | 0.0066 ns | 0.0055 ns | 13.301 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net472 | 15.320 ns | 0.0560 ns | 0.0497 ns | 15.336 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                              From_NonConvertibleClass | .NET Core 2.0 | 11.969 ns | 0.0142 ns | 0.0118 ns | 11.967 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 2.2 | 11.145 ns | 0.0104 ns | 0.0087 ns | 11.143 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 3.0 | 11.708 ns | 0.0146 ns | 0.0136 ns | 11.707 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net461 | 12.389 ns | 0.0472 ns | 0.0442 ns | 12.405 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net472 | 12.525 ns | 0.0116 ns | 0.0097 ns | 12.526 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                     From_NonConvertibleClass_AsObject | .NET Core 2.0 | 14.966 ns | 0.0305 ns | 0.0270 ns | 14.968 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 2.2 | 13.863 ns | 0.0230 ns | 0.0192 ns | 13.857 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 3.0 | 13.531 ns | 0.0932 ns | 0.0872 ns | 13.476 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net461 | 17.201 ns | 0.0143 ns | 0.0134 ns | 17.198 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net472 | 16.608 ns | 0.0195 ns | 0.0183 ns | 16.606 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                      From_NonConvertibleClass_NoValue | .NET Core 2.0 | 11.776 ns | 0.0177 ns | 0.0165 ns | 11.777 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 2.2 | 11.113 ns | 0.0137 ns | 0.0122 ns | 11.111 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 3.0 | 11.290 ns | 0.0456 ns | 0.0426 ns | 11.263 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net461 | 12.504 ns | 0.0125 ns | 0.0111 ns | 12.507 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net472 | 12.722 ns | 0.0255 ns | 0.0238 ns | 12.716 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.0 | 13.884 ns | 0.0220 ns | 0.0205 ns | 13.879 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.2 | 11.854 ns | 0.0113 ns | 0.0094 ns | 11.856 ns |  0.85 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 3.0 | 13.104 ns | 0.2359 ns | 0.2206 ns | 13.255 ns |  0.94 |    0.02 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net461 | 13.229 ns | 0.0109 ns | 0.0102 ns | 13.228 ns |  0.95 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net472 | 14.892 ns | 0.0198 ns | 0.0176 ns | 14.891 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                From_ConvertibleStruct | .NET Core 2.0 | 19.413 ns | 0.0534 ns | 0.0500 ns | 19.416 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 2.2 | 16.095 ns | 0.0449 ns | 0.0398 ns | 16.080 ns |  0.83 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 3.0 | 11.678 ns | 0.1998 ns | 0.1771 ns | 11.752 ns |  0.60 |    0.01 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net461 | 19.178 ns | 0.0915 ns | 0.0811 ns | 19.147 ns |  0.99 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net472 | 17.143 ns | 0.0552 ns | 0.0516 ns | 17.135 ns |  0.88 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                       From_ConvertibleStruct_AsObject | .NET Core 2.0 | 17.072 ns | 0.1114 ns | 0.1042 ns | 17.084 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 2.2 | 14.383 ns | 0.0165 ns | 0.0138 ns | 14.384 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 3.0 | 15.115 ns | 0.0509 ns | 0.0476 ns | 15.107 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net461 | 17.473 ns | 0.0255 ns | 0.0238 ns | 17.471 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net472 | 19.343 ns | 0.0442 ns | 0.0413 ns | 19.336 ns |  1.13 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.0 | 19.242 ns | 0.0814 ns | 0.0761 ns | 19.221 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.2 | 16.148 ns | 0.0660 ns | 0.0585 ns | 16.146 ns |  0.84 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 3.0 | 15.321 ns | 0.2975 ns | 0.2782 ns | 15.484 ns |  0.80 |    0.02 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net461 | 19.282 ns | 0.0357 ns | 0.0316 ns | 19.283 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net472 | 18.034 ns | 0.0440 ns | 0.0412 ns | 18.029 ns |  0.94 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 17.741 ns | 0.0279 ns | 0.0248 ns | 17.737 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.120 ns | 0.0223 ns | 0.0198 ns | 15.123 ns |  0.85 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.209 ns | 0.0385 ns | 0.0360 ns | 15.205 ns |  0.86 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net461 | 17.447 ns | 0.0429 ns | 0.0380 ns | 17.438 ns |  0.98 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net472 | 19.328 ns | 0.0298 ns | 0.0278 ns | 19.327 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.0 | 13.411 ns | 0.0353 ns | 0.0294 ns | 13.421 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.2 | 11.587 ns | 0.0128 ns | 0.0106 ns | 11.583 ns |  0.86 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 3.0 |  7.055 ns | 0.0090 ns | 0.0080 ns |  7.055 ns |  0.53 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net461 | 12.648 ns | 0.0920 ns | 0.0861 ns | 12.590 ns |  0.94 |    0.01 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net472 | 10.488 ns | 0.0172 ns | 0.0144 ns | 10.488 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.716 ns | 0.0135 ns | 0.0112 ns | 14.719 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.855 ns | 0.0152 ns | 0.0127 ns | 11.854 ns |  0.81 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.920 ns | 0.0230 ns | 0.0204 ns | 11.919 ns |  0.81 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net461 | 13.250 ns | 0.0275 ns | 0.0257 ns | 13.246 ns |  0.90 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net472 | 15.851 ns | 0.0284 ns | 0.0265 ns | 15.855 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_NonConvertibleStruct | .NET Core 2.0 | 13.499 ns | 0.0136 ns | 0.0127 ns | 13.498 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 2.2 | 11.471 ns | 0.0150 ns | 0.0133 ns | 11.468 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 3.0 |  6.915 ns | 0.1591 ns | 0.1488 ns |  6.859 ns |  0.51 |    0.01 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net461 | 11.785 ns | 0.0081 ns | 0.0067 ns | 11.788 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net472 | 10.614 ns | 0.0145 ns | 0.0136 ns | 10.614 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.0 | 14.977 ns | 0.0252 ns | 0.0224 ns | 14.977 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.2 | 13.279 ns | 0.0222 ns | 0.0207 ns | 13.271 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 3.0 | 13.572 ns | 0.0257 ns | 0.0228 ns | 13.571 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net461 | 14.966 ns | 0.0403 ns | 0.0357 ns | 14.955 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net472 | 16.724 ns | 0.1300 ns | 0.1216 ns | 16.666 ns |  1.12 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.0 | 13.508 ns | 0.0150 ns | 0.0133 ns | 13.510 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.2 | 10.017 ns | 0.0069 ns | 0.0065 ns | 10.018 ns |  0.74 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 3.0 |  6.742 ns | 0.1238 ns | 0.1158 ns |  6.791 ns |  0.50 |    0.01 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net461 | 12.521 ns | 0.0152 ns | 0.0142 ns | 12.520 ns |  0.93 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net472 | 10.282 ns | 0.0089 ns | 0.0084 ns | 10.279 ns |  0.76 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 15.257 ns | 0.0246 ns | 0.0218 ns | 15.260 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 14.131 ns | 0.0206 ns | 0.0193 ns | 14.128 ns |  0.93 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 13.616 ns | 0.0731 ns | 0.0684 ns | 13.597 ns |  0.89 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net461 | 15.075 ns | 0.0511 ns | 0.0478 ns | 15.066 ns |  0.99 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net472 | 16.755 ns | 0.0962 ns | 0.0900 ns | 16.710 ns |  1.10 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.0 | 13.454 ns | 0.0189 ns | 0.0177 ns | 13.452 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.2 | 11.353 ns | 0.0115 ns | 0.0102 ns | 11.354 ns |  0.84 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 3.0 |  6.755 ns | 0.1003 ns | 0.0938 ns |  6.833 ns |  0.50 |    0.01 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net461 | 11.836 ns | 0.0297 ns | 0.0278 ns | 11.835 ns |  0.88 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net472 | 11.814 ns | 0.0466 ns | 0.0389 ns | 11.825 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.882 ns | 0.0202 ns | 0.0179 ns | 14.883 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.510 ns | 0.0165 ns | 0.0155 ns | 13.509 ns |  0.91 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.021 ns | 0.0671 ns | 0.0627 ns | 12.032 ns |  0.81 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net461 | 13.333 ns | 0.0172 ns | 0.0161 ns | 13.326 ns |  0.90 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net472 | 14.890 ns | 0.0223 ns | 0.0209 ns | 14.890 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Enum | .NET Core 2.0 | 12.925 ns | 0.0595 ns | 0.0527 ns | 12.916 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 2.2 | 10.590 ns | 0.0329 ns | 0.0307 ns | 10.573 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 3.0 |  7.176 ns | 0.0136 ns | 0.0120 ns |  7.173 ns |  0.56 |    0.00 |      - |     - |     - |         - |
                                             From_Enum |        net461 | 12.433 ns | 0.0137 ns | 0.0114 ns | 12.431 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                             From_Enum |        net472 | 10.326 ns | 0.0187 ns | 0.0175 ns | 10.321 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Enum_AsObject | .NET Core 2.0 | 44.290 ns | 0.0970 ns | 0.0908 ns | 44.272 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject | .NET Core 2.2 | 41.052 ns | 0.0632 ns | 0.0528 ns | 41.048 ns |  0.93 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject | .NET Core 3.0 | 34.568 ns | 0.1077 ns | 0.0955 ns | 34.602 ns |  0.78 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject |        net461 | 43.058 ns | 0.2285 ns | 0.1908 ns | 43.135 ns |  0.97 |    0.01 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject |        net472 | 44.413 ns | 0.0763 ns | 0.0713 ns | 44.413 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Enum_Nullable_WithValue | .NET Core 2.0 | 13.065 ns | 0.0119 ns | 0.0112 ns | 13.067 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 2.2 | 12.332 ns | 0.0352 ns | 0.0312 ns | 12.319 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 3.0 |  6.869 ns | 0.0306 ns | 0.0287 ns |  6.859 ns |  0.53 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net461 | 12.185 ns | 0.0258 ns | 0.0241 ns | 12.178 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net472 | 10.564 ns | 0.0246 ns | 0.0206 ns | 10.564 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.0 | 44.167 ns | 0.0840 ns | 0.0786 ns | 44.160 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.2 | 43.546 ns | 0.0915 ns | 0.0811 ns | 43.563 ns |  0.99 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 3.0 | 33.262 ns | 0.1728 ns | 0.1532 ns | 33.303 ns |  0.75 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject |        net461 | 43.113 ns | 0.0763 ns | 0.0676 ns | 43.105 ns |  0.98 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject |        net472 | 46.871 ns | 0.0514 ns | 0.0430 ns | 46.875 ns |  1.06 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Enum_Nullable_NoValue | .NET Core 2.0 | 12.982 ns | 0.0099 ns | 0.0082 ns | 12.980 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 2.2 | 12.100 ns | 0.0131 ns | 0.0109 ns | 12.101 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 3.0 |  6.759 ns | 0.0531 ns | 0.0497 ns |  6.780 ns |  0.52 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net461 | 11.829 ns | 0.0103 ns | 0.0096 ns | 11.829 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net472 | 10.939 ns | 0.0572 ns | 0.0535 ns | 10.948 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.239 ns | 0.0466 ns | 0.0436 ns | 14.247 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.850 ns | 0.0070 ns | 0.0066 ns | 11.849 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.943 ns | 0.0209 ns | 0.0195 ns | 11.941 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net461 | 13.345 ns | 0.0369 ns | 0.0345 ns | 13.355 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net472 | 14.912 ns | 0.0227 ns | 0.0201 ns | 14.911 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                      From_ParentClass | .NET Core 2.0 | 12.114 ns | 0.0114 ns | 0.0106 ns | 12.112 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 2.2 | 11.115 ns | 0.0074 ns | 0.0065 ns | 11.115 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 3.0 | 11.718 ns | 0.0101 ns | 0.0089 ns | 11.715 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass |        net461 | 12.471 ns | 0.0110 ns | 0.0097 ns | 12.469 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass |        net472 | 12.603 ns | 0.0507 ns | 0.0474 ns | 12.584 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_ParentClass_AsObject | .NET Core 2.0 | 16.235 ns | 0.0497 ns | 0.0415 ns | 16.228 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 2.2 | 14.799 ns | 0.0197 ns | 0.0175 ns | 14.797 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 3.0 | 13.821 ns | 0.0459 ns | 0.0407 ns | 13.815 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net461 | 15.285 ns | 0.0327 ns | 0.0306 ns | 15.281 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net472 | 17.460 ns | 0.0183 ns | 0.0162 ns | 17.460 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                              From_ParentClass_NoValue | .NET Core 2.0 | 11.909 ns | 0.0121 ns | 0.0113 ns | 11.907 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 2.2 | 11.115 ns | 0.0109 ns | 0.0102 ns | 11.112 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 3.0 | 11.288 ns | 0.0240 ns | 0.0200 ns | 11.289 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net461 | 12.346 ns | 0.0273 ns | 0.0256 ns | 12.343 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net472 | 12.512 ns | 0.0200 ns | 0.0177 ns | 12.511 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.0 | 14.059 ns | 0.0261 ns | 0.0218 ns | 14.053 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.2 | 12.436 ns | 0.0146 ns | 0.0130 ns | 12.437 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 3.0 | 11.936 ns | 0.0132 ns | 0.0117 ns | 11.936 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net461 | 13.178 ns | 0.0228 ns | 0.0213 ns | 13.180 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net472 | 14.909 ns | 0.0231 ns | 0.0180 ns | 14.908 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_ParentStruct | .NET Core 2.0 | 40.025 ns | 0.0848 ns | 0.0751 ns | 39.992 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 2.2 | 36.039 ns | 0.0497 ns | 0.0441 ns | 36.029 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 3.0 | 40.621 ns | 0.0486 ns | 0.0430 ns | 40.632 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct |        net461 | 39.388 ns | 0.0425 ns | 0.0377 ns | 39.378 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct |        net472 | 40.192 ns | 0.0599 ns | 0.0500 ns | 40.183 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_ParentStruct_AsObject | .NET Core 2.0 | 15.432 ns | 0.0247 ns | 0.0231 ns | 15.430 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 2.2 | 16.645 ns | 0.0463 ns | 0.0433 ns | 16.663 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 3.0 | 13.936 ns | 0.0264 ns | 0.0220 ns | 13.934 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net461 | 15.363 ns | 0.0351 ns | 0.0311 ns | 15.355 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net472 | 17.628 ns | 0.1215 ns | 0.1136 ns | 17.562 ns |  1.14 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.0 | 40.032 ns | 0.0544 ns | 0.0509 ns | 40.033 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.2 | 37.712 ns | 0.0384 ns | 0.0340 ns | 37.715 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 3.0 | 35.051 ns | 0.0932 ns | 0.0872 ns | 35.038 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue |        net461 | 41.120 ns | 0.0608 ns | 0.0539 ns | 41.122 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue |        net472 | 47.851 ns | 0.1399 ns | 0.1308 ns | 47.847 ns |  1.20 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 16.340 ns | 0.0661 ns | 0.0619 ns | 16.356 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 13.500 ns | 0.0107 ns | 0.0100 ns | 13.502 ns |  0.83 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 13.400 ns | 0.1329 ns | 0.1243 ns | 13.318 ns |  0.82 |    0.01 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net461 | 15.922 ns | 0.0153 ns | 0.0128 ns | 15.923 ns |  0.97 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net472 | 16.890 ns | 0.0343 ns | 0.0304 ns | 16.886 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.0 | 39.851 ns | 0.0800 ns | 0.0748 ns | 39.872 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.2 | 37.683 ns | 0.0627 ns | 0.0586 ns | 37.686 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 3.0 | 34.070 ns | 0.1562 ns | 0.1385 ns | 34.103 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net461 | 39.094 ns | 0.1324 ns | 0.1239 ns | 39.151 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net472 | 38.767 ns | 0.2283 ns | 0.2135 ns | 38.889 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.059 ns | 0.0162 ns | 0.0144 ns | 14.061 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.274 ns | 0.0145 ns | 0.0136 ns | 12.273 ns |  0.87 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.931 ns | 0.0165 ns | 0.0146 ns | 11.929 ns |  0.85 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net461 | 15.822 ns | 0.0236 ns | 0.0220 ns | 15.822 ns |  1.13 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net472 | 14.990 ns | 0.0243 ns | 0.0203 ns | 14.992 ns |  1.07 |    0.00 |      - |     - |     - |         - |

Benchmarks with issues:
  ConvertTo_Int.From_DateTime_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_Int.From_DateTime_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_Int.From_DateTime_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_Int.From_DateTime_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_Int.From_DateTime_AsObject: Job-ZVTGBZ(Toolchain=net472)
  ConvertTo_Int.From_DateTime_Nullable_WithValue_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_Int.From_DateTime_Nullable_WithValue_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_Int.From_DateTime_Nullable_WithValue_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_Int.From_DateTime_Nullable_WithValue_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_Int.From_DateTime_Nullable_WithValue_AsObject: Job-ZVTGBZ(Toolchain=net472)
  ConvertTo_Int.From_String_Empty_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_Int.From_String_Empty_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_Int.From_String_Empty_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_Int.From_String_Empty_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_Int.From_String_Empty_AsObject: Job-ZVTGBZ(Toolchain=net472)
