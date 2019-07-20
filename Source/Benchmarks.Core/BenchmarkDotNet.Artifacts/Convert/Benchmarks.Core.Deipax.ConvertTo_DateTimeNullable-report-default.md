
BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.615 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-XBZJXS : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), 64bit RyuJIT
  Job-RPHYXP : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-WPBXUQ : .NET Core 3.0.0-preview6-27804-01 (CoreCLR 4.700.19.30373, CoreFX 4.700.19.30308), 64bit RyuJIT
  Job-EJFWSE : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0
  Job-ZVTGBZ : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0


                                                Method |     Toolchain |       Mean |     Error |    StdDev |     Median | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------------------------------------------ |-------------- |-----------:|----------:|----------:|-----------:|------:|--------:|-------:|------:|------:|----------:|
                                             From_Bool | .NET Core 2.0 |  14.826 ns | 0.0183 ns | 0.0162 ns |  14.826 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 2.2 |  11.841 ns | 0.0101 ns | 0.0084 ns |  11.838 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 3.0 |   8.389 ns | 0.1920 ns | 0.3154 ns |   8.541 ns |  0.55 |    0.03 |      - |     - |     - |         - |
                                             From_Bool |        net461 |  12.810 ns | 0.0191 ns | 0.0179 ns |  12.803 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                             From_Bool |        net472 |  14.153 ns | 0.0137 ns | 0.0128 ns |  14.153 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                    From_Bool_AsObject | .NET Core 2.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 2.2 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 3.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net461 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net472 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                          From_Bool_Nullable_WithValue | .NET Core 2.0 |  12.538 ns | 0.0207 ns | 0.0194 ns |  12.535 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 2.2 |  10.651 ns | 0.0161 ns | 0.0143 ns |  10.652 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 3.0 |   7.634 ns | 0.0102 ns | 0.0096 ns |   7.631 ns |  0.61 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net461 |  12.993 ns | 0.0653 ns | 0.0610 ns |  12.953 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net472 |  12.805 ns | 0.0123 ns | 0.0109 ns |  12.803 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.2 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 3.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net461 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net472 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                            From_Bool_Nullable_NoValue | .NET Core 2.0 |  12.537 ns | 0.0104 ns | 0.0092 ns |  12.538 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 2.2 |  10.993 ns | 0.0142 ns | 0.0125 ns |  10.995 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 3.0 |   7.935 ns | 0.3949 ns | 0.5789 ns |   7.613 ns |  0.66 |    0.05 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net461 |  12.949 ns | 0.0156 ns | 0.0146 ns |  12.950 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net472 |  15.294 ns | 0.0255 ns | 0.0226 ns |  15.286 ns |  1.22 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.0 |  14.914 ns | 0.0206 ns | 0.0193 ns |  14.910 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.2 |  15.475 ns | 0.0136 ns | 0.0128 ns |  15.472 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 3.0 |  14.458 ns | 0.0214 ns | 0.0200 ns |  14.459 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net461 |  25.338 ns | 0.0217 ns | 0.0203 ns |  25.340 ns |  1.70 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net472 |  23.363 ns | 0.0239 ns | 0.0200 ns |  23.361 ns |  1.57 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                             From_Byte | .NET Core 2.0 |  13.095 ns | 0.0175 ns | 0.0155 ns |  13.096 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 2.2 |  11.122 ns | 0.0156 ns | 0.0138 ns |  11.118 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 3.0 |   7.685 ns | 0.0138 ns | 0.0123 ns |   7.687 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                                             From_Byte |        net461 |  12.925 ns | 0.0103 ns | 0.0097 ns |  12.926 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                             From_Byte |        net472 |  12.817 ns | 0.0131 ns | 0.0123 ns |  12.818 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                    From_Byte_AsObject | .NET Core 2.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 2.2 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 3.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net461 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net472 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                          From_Byte_Nullable_WithValue | .NET Core 2.0 |  12.540 ns | 0.0117 ns | 0.0109 ns |  12.544 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 2.2 |  10.626 ns | 0.0167 ns | 0.0148 ns |  10.625 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 3.0 |   8.381 ns | 0.1867 ns | 0.1833 ns |   8.476 ns |  0.67 |    0.01 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net461 |  12.863 ns | 0.0124 ns | 0.0109 ns |  12.863 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net472 |  12.861 ns | 0.0137 ns | 0.0128 ns |  12.861 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.2 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 3.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net461 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net472 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                            From_Byte_Nullable_NoValue | .NET Core 2.0 |  12.539 ns | 0.0190 ns | 0.0178 ns |  12.536 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 2.2 |  10.709 ns | 0.0155 ns | 0.0145 ns |  10.706 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 3.0 |   8.994 ns | 0.2050 ns | 0.5365 ns |   9.142 ns |  0.65 |    0.07 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net461 |  12.949 ns | 0.0191 ns | 0.0169 ns |  12.946 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net472 |  12.761 ns | 0.0115 ns | 0.0102 ns |  12.761 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.0 |  14.641 ns | 0.0235 ns | 0.0196 ns |  14.636 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.2 |  13.106 ns | 0.0099 ns | 0.0087 ns |  13.106 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 3.0 |  13.014 ns | 0.0129 ns | 0.0121 ns |  13.012 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net461 |  26.339 ns | 0.0331 ns | 0.0309 ns |  26.337 ns |  1.80 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net472 |  23.794 ns | 0.0406 ns | 0.0360 ns |  23.790 ns |  1.63 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                             From_Char | .NET Core 2.0 |  13.839 ns | 0.0218 ns | 0.0193 ns |  13.843 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Char | .NET Core 2.2 |  10.688 ns | 0.0672 ns | 0.0629 ns |  10.726 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                                             From_Char | .NET Core 3.0 |   7.682 ns | 0.0144 ns | 0.0135 ns |   7.681 ns |  0.56 |    0.00 |      - |     - |     - |         - |
                                             From_Char |        net461 |  15.438 ns | 0.0364 ns | 0.0340 ns |  15.443 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                             From_Char |        net472 |  12.805 ns | 0.0121 ns | 0.0107 ns |  12.802 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                    From_Char_AsObject | .NET Core 2.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 2.2 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 3.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Char_AsObject |        net461 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Char_AsObject |        net472 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                          From_Char_Nullable_WithValue | .NET Core 2.0 |  12.634 ns | 0.0106 ns | 0.0099 ns |  12.634 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 2.2 |  12.364 ns | 0.0101 ns | 0.0089 ns |  12.363 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 3.0 |   9.394 ns | 0.2130 ns | 0.5343 ns |   9.533 ns |  0.69 |    0.07 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net461 |  12.880 ns | 0.0208 ns | 0.0184 ns |  12.872 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net472 |  13.242 ns | 0.0120 ns | 0.0113 ns |  13.242 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.2 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 3.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net461 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net472 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                            From_Char_Nullable_NoValue | .NET Core 2.0 |  12.586 ns | 0.0217 ns | 0.0192 ns |  12.582 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 2.2 |  10.518 ns | 0.0108 ns | 0.0090 ns |  10.519 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 3.0 |   8.604 ns | 0.1960 ns | 0.3681 ns |   8.767 ns |  0.65 |    0.04 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net461 |  12.923 ns | 0.0464 ns | 0.0434 ns |  12.933 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net472 |  13.951 ns | 0.0144 ns | 0.0120 ns |  13.950 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.0 |  15.428 ns | 0.0556 ns | 0.0520 ns |  15.417 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.2 |  14.014 ns | 0.0155 ns | 0.0145 ns |  14.010 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 3.0 |  15.486 ns | 0.0704 ns | 0.0624 ns |  15.499 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net461 |  26.362 ns | 0.0231 ns | 0.0205 ns |  26.363 ns |  1.71 |    0.01 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net472 |  25.347 ns | 0.0270 ns | 0.0239 ns |  25.347 ns |  1.64 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                         From_DateTime | .NET Core 2.0 |  14.337 ns | 0.0261 ns | 0.0245 ns |  14.332 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 2.2 |  11.791 ns | 0.0073 ns | 0.0068 ns |  11.794 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 3.0 |  11.219 ns | 0.2338 ns | 0.2297 ns |  11.355 ns |  0.78 |    0.02 |      - |     - |     - |         - |
                                         From_DateTime |        net461 |  14.329 ns | 0.0228 ns | 0.0213 ns |  14.336 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime |        net472 |  16.088 ns | 0.0262 ns | 0.0233 ns |  16.093 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                From_DateTime_AsObject | .NET Core 2.0 |  23.918 ns | 0.0231 ns | 0.0216 ns |  23.919 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 2.2 |  26.437 ns | 0.0299 ns | 0.0279 ns |  26.437 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 3.0 |  29.352 ns | 0.0648 ns | 0.0574 ns |  29.330 ns |  1.23 |    0.00 |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net461 |  39.571 ns | 0.2326 ns | 0.2176 ns |  39.565 ns |  1.65 |    0.01 |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net472 |  38.149 ns | 0.0331 ns | 0.0276 ns |  38.151 ns |  1.59 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                      From_DateTime_Nullable_WithValue | .NET Core 2.0 |  12.606 ns | 0.0142 ns | 0.0133 ns |  12.604 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 2.2 |  12.746 ns | 0.0210 ns | 0.0196 ns |  12.742 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 3.0 |   8.636 ns | 0.1923 ns | 0.2137 ns |   8.757 ns |  0.68 |    0.02 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net461 |  13.379 ns | 0.0211 ns | 0.0165 ns |  13.376 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net472 |  13.149 ns | 0.0212 ns | 0.0177 ns |  13.145 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.0 |  25.865 ns | 0.0282 ns | 0.0250 ns |  25.854 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.2 |  33.412 ns | 0.1535 ns | 0.1436 ns |  33.488 ns |  1.29 |    0.00 |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 3.0 |  30.271 ns | 0.0435 ns | 0.0386 ns |  30.276 ns |  1.17 |    0.00 |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net461 |  37.978 ns | 0.0573 ns | 0.0508 ns |  37.974 ns |  1.47 |    0.00 |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net472 |  39.025 ns | 0.0639 ns | 0.0598 ns |  39.036 ns |  1.51 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                        From_DateTime_Nullable_NoValue | .NET Core 2.0 |  12.634 ns | 0.0155 ns | 0.0138 ns |  12.629 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 2.2 |  11.255 ns | 0.0135 ns | 0.0113 ns |  11.253 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 3.0 |   8.404 ns | 0.0167 ns | 0.0157 ns |   8.400 ns |  0.67 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net461 |  13.200 ns | 0.0151 ns | 0.0141 ns |  13.198 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net472 |  13.313 ns | 0.0097 ns | 0.0091 ns |  13.314 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.0 |  15.565 ns | 0.0443 ns | 0.0414 ns |  15.577 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.2 |  12.963 ns | 0.0119 ns | 0.0112 ns |  12.959 ns |  0.83 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 3.0 |  13.208 ns | 0.0831 ns | 0.0694 ns |  13.197 ns |  0.85 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net461 |  25.333 ns | 0.0278 ns | 0.0260 ns |  25.331 ns |  1.63 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net472 |  23.756 ns | 0.1046 ns | 0.0979 ns |  23.745 ns |  1.53 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                          From_Decimal | .NET Core 2.0 |  12.728 ns | 0.0150 ns | 0.0133 ns |  12.725 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 2.2 |  11.465 ns | 0.0108 ns | 0.0101 ns |  11.466 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 3.0 |   8.386 ns | 0.0085 ns | 0.0071 ns |   8.383 ns |  0.66 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal |        net461 |  13.304 ns | 0.0832 ns | 0.0778 ns |  13.345 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                          From_Decimal |        net472 |  13.801 ns | 0.0321 ns | 0.0300 ns |  13.792 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                 From_Decimal_AsObject | .NET Core 2.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 2.2 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 3.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net461 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net472 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                       From_Decimal_Nullable_WithValue | .NET Core 2.0 |  12.798 ns | 0.0190 ns | 0.0178 ns |  12.798 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 2.2 |  12.145 ns | 0.0176 ns | 0.0156 ns |  12.144 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 3.0 |   8.971 ns | 0.0123 ns | 0.0115 ns |   8.968 ns |  0.70 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net461 |  13.327 ns | 0.0110 ns | 0.0092 ns |  13.328 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net472 |  13.021 ns | 0.0155 ns | 0.0145 ns |  13.020 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.2 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 3.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net461 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net472 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                         From_Decimal_Nullable_NoValue | .NET Core 2.0 |  12.793 ns | 0.0176 ns | 0.0156 ns |  12.790 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 2.2 |  12.346 ns | 0.0188 ns | 0.0176 ns |  12.337 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 3.0 |   8.647 ns | 0.0124 ns | 0.0110 ns |   8.647 ns |  0.68 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net461 |  13.590 ns | 0.0292 ns | 0.0274 ns |  13.581 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net472 |  12.999 ns | 0.0193 ns | 0.0181 ns |  12.998 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.0 |  15.922 ns | 0.0182 ns | 0.0170 ns |  15.916 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.2 |  12.950 ns | 0.0129 ns | 0.0115 ns |  12.949 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 3.0 |  13.058 ns | 0.0731 ns | 0.0684 ns |  13.026 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net461 |  25.185 ns | 0.0248 ns | 0.0219 ns |  25.183 ns |  1.58 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net472 |  25.337 ns | 0.0078 ns | 0.0061 ns |  25.339 ns |  1.59 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                           From_Double | .NET Core 2.0 |  13.140 ns | 0.0184 ns | 0.0163 ns |  13.138 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 2.2 |  10.697 ns | 0.0164 ns | 0.0137 ns |  10.693 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 3.0 |   7.730 ns | 0.2345 ns | 0.3720 ns |   7.527 ns |  0.61 |    0.03 |      - |     - |     - |         - |
                                           From_Double |        net461 |  13.682 ns | 0.0115 ns | 0.0108 ns |  13.682 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                           From_Double |        net472 |  13.122 ns | 0.0153 ns | 0.0136 ns |  13.122 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                  From_Double_AsObject | .NET Core 2.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 2.2 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 3.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                  From_Double_AsObject |        net461 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                  From_Double_AsObject |        net472 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                        From_Double_Nullable_WithValue | .NET Core 2.0 |  12.687 ns | 0.0141 ns | 0.0125 ns |  12.691 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 2.2 |  11.410 ns | 0.0112 ns | 0.0100 ns |  11.409 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 3.0 |   9.289 ns | 0.2047 ns | 0.2936 ns |   9.412 ns |  0.72 |    0.03 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net461 |  13.218 ns | 0.0165 ns | 0.0146 ns |  13.217 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net472 |  12.948 ns | 0.0088 ns | 0.0078 ns |  12.949 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.2 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 3.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net461 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net472 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                          From_Double_Nullable_NoValue | .NET Core 2.0 |  12.697 ns | 0.0145 ns | 0.0135 ns |  12.694 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 2.2 |  11.408 ns | 0.0141 ns | 0.0132 ns |  11.408 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 3.0 |   8.505 ns | 0.0149 ns | 0.0139 ns |   8.505 ns |  0.67 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net461 |  13.333 ns | 0.0810 ns | 0.0758 ns |  13.316 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net472 |  12.933 ns | 0.0171 ns | 0.0133 ns |  12.934 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.0 |  14.781 ns | 0.0313 ns | 0.0262 ns |  14.779 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.2 |  12.961 ns | 0.0152 ns | 0.0142 ns |  12.956 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 3.0 |  14.020 ns | 0.0387 ns | 0.0362 ns |  14.034 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net461 |  25.237 ns | 0.0179 ns | 0.0140 ns |  25.237 ns |  1.71 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net472 |  23.929 ns | 0.0756 ns | 0.0670 ns |  23.947 ns |  1.62 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                            From_Short | .NET Core 2.0 |  13.139 ns | 0.0105 ns | 0.0098 ns |  13.138 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 2.2 |  10.638 ns | 0.0131 ns | 0.0122 ns |  10.636 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 3.0 |   8.701 ns | 0.1984 ns | 0.3088 ns |   8.826 ns |  0.65 |    0.03 |      - |     - |     - |         - |
                                            From_Short |        net461 |  12.829 ns | 0.0158 ns | 0.0148 ns |  12.825 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                            From_Short |        net472 |  13.655 ns | 0.0284 ns | 0.0265 ns |  13.653 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                   From_Short_AsObject | .NET Core 2.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 2.2 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 3.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                   From_Short_AsObject |        net461 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                   From_Short_AsObject |        net472 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                         From_Short_Nullable_WithValue | .NET Core 2.0 |  12.571 ns | 0.0122 ns | 0.0114 ns |  12.572 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 2.2 |  10.543 ns | 0.0106 ns | 0.0094 ns |  10.543 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 3.0 |  10.230 ns | 0.2516 ns | 0.7300 ns |  10.433 ns |  0.73 |    0.12 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net461 |  12.852 ns | 0.0105 ns | 0.0098 ns |  12.850 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net472 |  14.483 ns | 0.0862 ns | 0.0806 ns |  14.533 ns |  1.15 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.2 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 3.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net461 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net472 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                           From_Short_Nullable_NoValue | .NET Core 2.0 |  12.676 ns | 0.0297 ns | 0.0264 ns |  12.675 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 2.2 |  10.526 ns | 0.0168 ns | 0.0149 ns |  10.532 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 3.0 |   7.625 ns | 0.0145 ns | 0.0121 ns |   7.628 ns |  0.60 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net461 |  12.845 ns | 0.0153 ns | 0.0143 ns |  12.845 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net472 |  13.538 ns | 0.0247 ns | 0.0219 ns |  13.539 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.0 |  15.044 ns | 0.0129 ns | 0.0114 ns |  15.045 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.2 |  12.960 ns | 0.0135 ns | 0.0126 ns |  12.956 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 3.0 |  15.432 ns | 0.0538 ns | 0.0449 ns |  15.448 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net461 |  26.563 ns | 0.1045 ns | 0.0978 ns |  26.618 ns |  1.77 |    0.01 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net472 |  23.538 ns | 0.0292 ns | 0.0273 ns |  23.543 ns |  1.56 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                              From_Int | .NET Core 2.0 |  12.608 ns | 0.0091 ns | 0.0085 ns |  12.607 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 2.2 |  10.500 ns | 0.0153 ns | 0.0128 ns |  10.501 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 3.0 |   7.271 ns | 0.0086 ns | 0.0081 ns |   7.272 ns |  0.58 |    0.00 |      - |     - |     - |         - |
                                              From_Int |        net461 |  12.880 ns | 0.0138 ns | 0.0129 ns |  12.882 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                              From_Int |        net472 |  13.322 ns | 0.0148 ns | 0.0132 ns |  13.318 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                     From_Int_AsObject | .NET Core 2.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 2.2 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 3.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                     From_Int_AsObject |        net461 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                     From_Int_AsObject |        net472 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                           From_Int_Nullable_WithValue | .NET Core 2.0 |  12.585 ns | 0.0149 ns | 0.0139 ns |  12.589 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 2.2 |  10.539 ns | 0.0243 ns | 0.0215 ns |  10.531 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 3.0 |   7.683 ns | 0.0497 ns | 0.0465 ns |   7.712 ns |  0.61 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net461 |  12.872 ns | 0.0181 ns | 0.0160 ns |  12.873 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net472 |  13.286 ns | 0.0120 ns | 0.0100 ns |  13.289 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.2 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 3.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net461 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net472 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                             From_Int_Nullable_NoValue | .NET Core 2.0 |  12.572 ns | 0.0119 ns | 0.0093 ns |  12.573 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 2.2 |  12.382 ns | 0.0173 ns | 0.0162 ns |  12.380 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 3.0 |   7.632 ns | 0.0123 ns | 0.0109 ns |   7.635 ns |  0.61 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net461 |  12.863 ns | 0.0319 ns | 0.0299 ns |  12.852 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net472 |  13.330 ns | 0.0108 ns | 0.0090 ns |  13.328 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.0 |  16.023 ns | 0.0215 ns | 0.0190 ns |  16.019 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.2 |  12.945 ns | 0.0090 ns | 0.0084 ns |  12.945 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 3.0 |  16.115 ns | 0.0219 ns | 0.0205 ns |  16.109 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net461 |  25.440 ns | 0.0172 ns | 0.0161 ns |  25.447 ns |  1.59 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net472 |  25.373 ns | 0.0201 ns | 0.0178 ns |  25.370 ns |  1.58 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                             From_Long | .NET Core 2.0 |  12.738 ns | 0.0379 ns | 0.0354 ns |  12.746 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Long | .NET Core 2.2 |  10.502 ns | 0.0113 ns | 0.0100 ns |  10.499 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                             From_Long | .NET Core 3.0 |   7.665 ns | 0.0158 ns | 0.0148 ns |   7.667 ns |  0.60 |    0.00 |      - |     - |     - |         - |
                                             From_Long |        net461 |  12.884 ns | 0.0113 ns | 0.0100 ns |  12.884 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                             From_Long |        net472 |  13.304 ns | 0.0082 ns | 0.0077 ns |  13.301 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                    From_Long_AsObject | .NET Core 2.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 2.2 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 3.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Long_AsObject |        net461 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Long_AsObject |        net472 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                          From_Long_Nullable_WithValue | .NET Core 2.0 |  12.707 ns | 0.0108 ns | 0.0096 ns |  12.707 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 2.2 |  11.409 ns | 0.0105 ns | 0.0099 ns |  11.408 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 3.0 |   8.521 ns | 0.0117 ns | 0.0104 ns |   8.523 ns |  0.67 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net461 |  13.920 ns | 0.0097 ns | 0.0091 ns |  13.918 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net472 |  15.258 ns | 0.0352 ns | 0.0329 ns |  15.251 ns |  1.20 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.2 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 3.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net461 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net472 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                            From_Long_Nullable_NoValue | .NET Core 2.0 |  12.685 ns | 0.0090 ns | 0.0080 ns |  12.688 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 2.2 |  11.415 ns | 0.0100 ns | 0.0094 ns |  11.414 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 3.0 |   9.420 ns | 0.0641 ns | 0.0535 ns |   9.393 ns |  0.74 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net461 |  13.236 ns | 0.0168 ns | 0.0140 ns |  13.234 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net472 |  14.266 ns | 0.0296 ns | 0.0277 ns |  14.266 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.0 |  17.147 ns | 0.0200 ns | 0.0177 ns |  17.142 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.2 |  14.925 ns | 0.0129 ns | 0.0121 ns |  14.925 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 3.0 |  13.294 ns | 0.2895 ns | 0.4757 ns |  13.024 ns |  0.80 |    0.03 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net461 |  26.435 ns | 0.0262 ns | 0.0245 ns |  26.438 ns |  1.54 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net472 |  26.921 ns | 0.1687 ns | 0.1578 ns |  27.014 ns |  1.57 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                            From_SByte | .NET Core 2.0 |  13.953 ns | 0.0211 ns | 0.0176 ns |  13.954 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 2.2 |  10.626 ns | 0.0148 ns | 0.0139 ns |  10.626 ns |  0.76 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 3.0 |   7.675 ns | 0.0050 ns | 0.0042 ns |   7.674 ns |  0.55 |    0.00 |      - |     - |     - |         - |
                                            From_SByte |        net461 |  12.826 ns | 0.0114 ns | 0.0107 ns |  12.828 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                            From_SByte |        net472 |  13.375 ns | 0.0382 ns | 0.0339 ns |  13.361 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                   From_SByte_AsObject | .NET Core 2.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 2.2 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 3.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net461 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net472 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                         From_SByte_Nullable_WithValue | .NET Core 2.0 |  12.534 ns | 0.0098 ns | 0.0087 ns |  12.532 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 2.2 |  12.110 ns | 0.0130 ns | 0.0109 ns |  12.111 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 3.0 |   7.939 ns | 0.5641 ns | 0.5793 ns |   7.622 ns |  0.64 |    0.05 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net461 |  15.242 ns | 0.0133 ns | 0.0125 ns |  15.238 ns |  1.22 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net472 |  12.860 ns | 0.0775 ns | 0.0725 ns |  12.898 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.2 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 3.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net461 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net472 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                           From_SByte_Nullable_NoValue | .NET Core 2.0 |  12.679 ns | 0.0473 ns | 0.0395 ns |  12.688 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 2.2 |  10.633 ns | 0.0130 ns | 0.0122 ns |  10.628 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 3.0 |   7.776 ns | 0.0132 ns | 0.0117 ns |   7.775 ns |  0.61 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net461 |  12.901 ns | 0.0094 ns | 0.0087 ns |  12.901 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net472 |  13.256 ns | 0.0180 ns | 0.0168 ns |  13.251 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.0 |  15.773 ns | 0.0742 ns | 0.0694 ns |  15.776 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.2 |  12.971 ns | 0.0131 ns | 0.0116 ns |  12.968 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 3.0 |  14.044 ns | 0.0155 ns | 0.0145 ns |  14.044 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net461 |  27.216 ns | 0.0543 ns | 0.0481 ns |  27.231 ns |  1.73 |    0.01 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net472 |  26.799 ns | 0.0466 ns | 0.0413 ns |  26.789 ns |  1.70 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                            From_Float | .NET Core 2.0 |  13.196 ns | 0.0126 ns | 0.0118 ns |  13.194 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 2.2 |  10.691 ns | 0.0102 ns | 0.0095 ns |  10.691 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 3.0 |   8.307 ns | 0.1899 ns | 0.2599 ns |   8.411 ns |  0.62 |    0.02 |      - |     - |     - |         - |
                                            From_Float |        net461 |  15.725 ns | 0.0158 ns | 0.0148 ns |  15.722 ns |  1.19 |    0.00 |      - |     - |     - |         - |
                                            From_Float |        net472 |  13.176 ns | 0.0105 ns | 0.0093 ns |  13.177 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                   From_Float_AsObject | .NET Core 2.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 2.2 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 3.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                   From_Float_AsObject |        net461 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                   From_Float_AsObject |        net472 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                         From_Float_Nullable_WithValue | .NET Core 2.0 |  12.646 ns | 0.0531 ns | 0.0497 ns |  12.671 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 2.2 |  12.044 ns | 0.0164 ns | 0.0154 ns |  12.042 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 3.0 |   7.785 ns | 0.1778 ns | 0.2116 ns |   7.689 ns |  0.62 |    0.02 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net461 |  12.849 ns | 0.0090 ns | 0.0080 ns |  12.848 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net472 |  13.419 ns | 0.0738 ns | 0.0654 ns |  13.445 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.2 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 3.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net461 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net472 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                           From_Float_Nullable_NoValue | .NET Core 2.0 |  12.576 ns | 0.0152 ns | 0.0135 ns |  12.576 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 2.2 |  10.583 ns | 0.0507 ns | 0.0474 ns |  10.603 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 3.0 |   7.789 ns | 0.0463 ns | 0.0433 ns |   7.769 ns |  0.62 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net461 |  12.840 ns | 0.0111 ns | 0.0093 ns |  12.838 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net472 |  13.330 ns | 0.0160 ns | 0.0149 ns |  13.333 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.0 |  15.554 ns | 0.0926 ns | 0.0866 ns |  15.573 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.2 |  12.945 ns | 0.0095 ns | 0.0089 ns |  12.946 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 3.0 |  14.314 ns | 0.0154 ns | 0.0144 ns |  14.316 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net461 |  25.332 ns | 0.0725 ns | 0.0678 ns |  25.350 ns |  1.63 |    0.01 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net472 |  23.939 ns | 0.2145 ns | 0.2007 ns |  24.061 ns |  1.54 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                           From_String | .NET Core 2.0 | 518.022 ns | 1.3054 ns | 1.2211 ns | 517.955 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 2.2 | 434.289 ns | 1.3314 ns | 1.2454 ns | 434.166 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 3.0 | 400.121 ns | 0.2889 ns | 0.2702 ns | 400.058 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                                           From_String |        net461 | 782.645 ns | 0.8892 ns | 0.7883 ns | 782.892 ns |  1.51 |    0.00 |      - |     - |     - |         - |
                                           From_String |        net472 | 782.948 ns | 0.7538 ns | 0.6682 ns | 783.026 ns |  1.51 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                  From_String_AsObject | .NET Core 2.0 | 506.446 ns | 0.5256 ns | 0.4660 ns | 506.344 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 2.2 | 443.630 ns | 0.3480 ns | 0.3256 ns | 443.559 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 3.0 | 401.144 ns | 1.0173 ns | 0.9516 ns | 400.803 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject |        net461 | 800.087 ns | 2.1750 ns | 1.9281 ns | 800.342 ns |  1.58 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject |        net472 | 792.708 ns | 3.1564 ns | 2.9525 ns | 792.624 ns |  1.56 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                      From_String_Null | .NET Core 2.0 |  14.269 ns | 0.0181 ns | 0.0170 ns |  14.271 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 2.2 |  12.314 ns | 0.0142 ns | 0.0133 ns |  12.317 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 3.0 |  11.989 ns | 0.0210 ns | 0.0197 ns |  11.988 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null |        net461 |  26.105 ns | 0.0280 ns | 0.0262 ns |  26.093 ns |  1.83 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null |        net472 |  21.815 ns | 0.1413 ns | 0.1321 ns |  21.910 ns |  1.53 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                             From_String_Null_AsObject | .NET Core 2.0 |  15.398 ns | 0.0174 ns | 0.0162 ns |  15.397 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 2.2 |  12.942 ns | 0.0108 ns | 0.0096 ns |  12.939 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 3.0 |  15.325 ns | 0.0346 ns | 0.0289 ns |  15.321 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net461 |  25.200 ns | 0.0234 ns | 0.0208 ns |  25.202 ns |  1.64 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net472 |  23.330 ns | 0.0259 ns | 0.0230 ns |  23.337 ns |  1.52 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                     From_String_Empty | .NET Core 2.0 |  14.454 ns | 0.0860 ns | 0.0804 ns |  14.509 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 2.2 |  12.156 ns | 0.0111 ns | 0.0098 ns |  12.153 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 3.0 |  12.383 ns | 0.3625 ns | 0.5314 ns |  12.075 ns |  0.88 |    0.04 |      - |     - |     - |         - |
                                     From_String_Empty |        net461 |  26.438 ns | 0.0210 ns | 0.0197 ns |  26.436 ns |  1.83 |    0.01 |      - |     - |     - |         - |
                                     From_String_Empty |        net472 |  22.873 ns | 0.0213 ns | 0.0199 ns |  22.868 ns |  1.58 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                            From_String_Empty_AsObject | .NET Core 2.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 2.2 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 3.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net461 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net472 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                           From_UShort | .NET Core 2.0 |  12.671 ns | 0.0115 ns | 0.0102 ns |  12.669 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 2.2 |  10.618 ns | 0.0146 ns | 0.0136 ns |  10.620 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 3.0 |   7.692 ns | 0.0149 ns | 0.0140 ns |   7.692 ns |  0.61 |    0.00 |      - |     - |     - |         - |
                                           From_UShort |        net461 |  12.967 ns | 0.0781 ns | 0.0731 ns |  13.001 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                                           From_UShort |        net472 |  12.784 ns | 0.0140 ns | 0.0124 ns |  12.786 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                  From_UShort_AsObject | .NET Core 2.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 2.2 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 3.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net461 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net472 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                        From_UShort_Nullable_WithValue | .NET Core 2.0 |  12.584 ns | 0.0124 ns | 0.0110 ns |  12.587 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 2.2 |  12.561 ns | 0.0086 ns | 0.0076 ns |  12.562 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 3.0 |   7.837 ns | 0.0588 ns | 0.0550 ns |   7.863 ns |  0.62 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net461 |  13.370 ns | 0.0185 ns | 0.0173 ns |  13.365 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net472 |  14.414 ns | 0.0158 ns | 0.0140 ns |  14.414 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.2 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 3.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net461 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net472 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                          From_UShort_Nullable_NoValue | .NET Core 2.0 |  13.359 ns | 0.1784 ns | 0.1669 ns |  13.388 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 2.2 |  10.526 ns | 0.0134 ns | 0.0112 ns |  10.524 ns |  0.79 |    0.01 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 3.0 |   7.588 ns | 0.1777 ns | 0.2115 ns |   7.733 ns |  0.56 |    0.02 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net461 |  12.856 ns | 0.0159 ns | 0.0141 ns |  12.851 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net472 |  13.292 ns | 0.0177 ns | 0.0148 ns |  13.291 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.0 |  14.657 ns | 0.0084 ns | 0.0070 ns |  14.656 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.2 |  12.964 ns | 0.0145 ns | 0.0129 ns |  12.963 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 3.0 |  14.929 ns | 0.2579 ns | 0.2412 ns |  15.017 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net461 |  26.496 ns | 0.0132 ns | 0.0123 ns |  26.495 ns |  1.81 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net472 |  27.080 ns | 0.0339 ns | 0.0317 ns |  27.088 ns |  1.85 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                             From_UInt | .NET Core 2.0 |  13.076 ns | 0.0164 ns | 0.0153 ns |  13.080 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 2.2 |  10.510 ns | 0.0111 ns | 0.0099 ns |  10.508 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 3.0 |   7.820 ns | 0.2603 ns | 0.3474 ns |   7.631 ns |  0.61 |    0.03 |      - |     - |     - |         - |
                                             From_UInt |        net461 |  12.885 ns | 0.0099 ns | 0.0092 ns |  12.886 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                             From_UInt |        net472 |  13.322 ns | 0.0144 ns | 0.0135 ns |  13.320 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                    From_UInt_AsObject | .NET Core 2.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 2.2 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 3.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net461 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net472 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                          From_UInt_Nullable_WithValue | .NET Core 2.0 |  14.171 ns | 0.0148 ns | 0.0131 ns |  14.170 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 2.2 |  10.518 ns | 0.0157 ns | 0.0131 ns |  10.517 ns |  0.74 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 3.0 |   7.899 ns | 0.1810 ns | 0.2155 ns |   8.056 ns |  0.55 |    0.02 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net461 |  12.972 ns | 0.0412 ns | 0.0385 ns |  12.978 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net472 |  15.369 ns | 0.0903 ns | 0.0754 ns |  15.367 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.2 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 3.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net461 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net472 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                            From_UInt_Nullable_NoValue | .NET Core 2.0 |  12.566 ns | 0.0150 ns | 0.0140 ns |  12.567 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 2.2 |  10.955 ns | 0.0815 ns | 0.0762 ns |  10.938 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 3.0 |   7.810 ns | 0.0405 ns | 0.0359 ns |   7.825 ns |  0.62 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net461 |  12.938 ns | 0.0547 ns | 0.0512 ns |  12.965 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net472 |  13.352 ns | 0.0284 ns | 0.0251 ns |  13.349 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.0 |  15.091 ns | 0.0514 ns | 0.0455 ns |  15.107 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.2 |  13.053 ns | 0.0378 ns | 0.0354 ns |  13.060 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 3.0 |  14.181 ns | 0.0867 ns | 0.0811 ns |  14.210 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net461 |  26.424 ns | 0.0218 ns | 0.0204 ns |  26.427 ns |  1.75 |    0.01 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net472 |  25.304 ns | 0.0109 ns | 0.0102 ns |  25.307 ns |  1.68 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                            From_ULong | .NET Core 2.0 |  13.073 ns | 0.0105 ns | 0.0093 ns |  13.073 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 2.2 |  10.494 ns | 0.0119 ns | 0.0106 ns |  10.495 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 3.0 |   7.674 ns | 0.0098 ns | 0.0087 ns |   7.675 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                                            From_ULong |        net461 |  12.888 ns | 0.0126 ns | 0.0117 ns |  12.883 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                            From_ULong |        net472 |  13.647 ns | 0.0150 ns | 0.0140 ns |  13.647 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                   From_ULong_AsObject | .NET Core 2.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 2.2 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 3.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net461 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net472 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                         From_ULong_Nullable_WithValue | .NET Core 2.0 |  12.702 ns | 0.0105 ns | 0.0093 ns |  12.703 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 2.2 |  11.417 ns | 0.0150 ns | 0.0140 ns |  11.412 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 3.0 |   8.580 ns | 0.1063 ns | 0.0994 ns |   8.512 ns |  0.67 |    0.01 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net461 |  13.191 ns | 0.0156 ns | 0.0146 ns |  13.189 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net472 |  12.926 ns | 0.0129 ns | 0.0121 ns |  12.921 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.2 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 3.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net461 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net472 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                           From_ULong_Nullable_NoValue | .NET Core 2.0 |  12.697 ns | 0.0167 ns | 0.0156 ns |  12.694 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 2.2 |  11.977 ns | 0.0112 ns | 0.0099 ns |  11.978 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 3.0 |  10.150 ns | 0.2270 ns | 0.4984 ns |  10.344 ns |  0.75 |    0.06 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net461 |  13.202 ns | 0.0151 ns | 0.0142 ns |  13.203 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net472 |  13.024 ns | 0.0206 ns | 0.0193 ns |  13.027 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.0 |  14.790 ns | 0.0145 ns | 0.0136 ns |  14.792 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.2 |  12.935 ns | 0.0153 ns | 0.0143 ns |  12.936 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 3.0 |  13.368 ns | 0.3433 ns | 0.6190 ns |  13.008 ns |  0.94 |    0.05 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net461 |  25.195 ns | 0.0270 ns | 0.0239 ns |  25.192 ns |  1.70 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net472 |  23.740 ns | 0.0177 ns | 0.0157 ns |  23.740 ns |  1.61 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                       From_NullObject | .NET Core 2.0 |  14.687 ns | 0.0174 ns | 0.0163 ns |  14.688 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 2.2 |  14.590 ns | 0.0768 ns | 0.0719 ns |  14.631 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 3.0 |  14.064 ns | 0.0411 ns | 0.0384 ns |  14.059 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject |        net461 |  26.722 ns | 0.0265 ns | 0.0248 ns |  26.719 ns |  1.82 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject |        net472 |  23.539 ns | 0.0282 ns | 0.0263 ns |  23.546 ns |  1.60 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                           From_DBNull | .NET Core 2.0 |  13.179 ns | 0.0094 ns | 0.0088 ns |  13.180 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 2.2 |  10.300 ns | 0.0102 ns | 0.0096 ns |  10.297 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 3.0 |  11.353 ns | 0.0757 ns | 0.0708 ns |  11.395 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                                           From_DBNull |        net461 |  12.581 ns | 0.0151 ns | 0.0134 ns |  12.581 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull |        net472 |  13.887 ns | 0.0158 ns | 0.0140 ns |  13.889 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                  From_DBNull_AsObject | .NET Core 2.0 |  15.172 ns | 0.0173 ns | 0.0161 ns |  15.171 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 2.2 |  12.953 ns | 0.0123 ns | 0.0115 ns |  12.954 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 3.0 |  14.325 ns | 0.0117 ns | 0.0104 ns |  14.323 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net461 |  26.459 ns | 0.0149 ns | 0.0125 ns |  26.460 ns |  1.74 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net472 |  23.587 ns | 0.0584 ns | 0.0488 ns |  23.570 ns |  1.55 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                 From_ConvertibleClass | .NET Core 2.0 |  19.873 ns | 0.0198 ns | 0.0176 ns |  19.873 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 2.2 |  17.481 ns | 0.0170 ns | 0.0151 ns |  17.479 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 3.0 |  16.337 ns | 0.1201 ns | 0.1123 ns |  16.292 ns |  0.82 |    0.01 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net461 |  29.400 ns | 0.0235 ns | 0.0208 ns |  29.400 ns |  1.48 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net472 |  29.662 ns | 0.2223 ns | 0.2079 ns |  29.546 ns |  1.49 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                        From_ConvertibleClass_AsObject | .NET Core 2.0 |  22.127 ns | 0.0973 ns | 0.0910 ns |  22.165 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 2.2 |  19.142 ns | 0.0230 ns | 0.0204 ns |  19.139 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 3.0 |  18.681 ns | 0.1582 ns | 0.1480 ns |  18.734 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net461 |  29.658 ns | 0.0636 ns | 0.0595 ns |  29.650 ns |  1.34 |    0.01 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net472 |  29.802 ns | 0.0433 ns | 0.0384 ns |  29.794 ns |  1.35 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                         From_ConvertibleClass_NoValue | .NET Core 2.0 |  14.913 ns | 0.0140 ns | 0.0131 ns |  14.912 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 2.2 |  13.630 ns | 0.0641 ns | 0.0600 ns |  13.666 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 3.0 |  13.092 ns | 0.2811 ns | 0.3452 ns |  12.842 ns |  0.89 |    0.02 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net461 |  25.826 ns | 0.0464 ns | 0.0434 ns |  25.832 ns |  1.73 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net472 |  25.123 ns | 0.0262 ns | 0.0232 ns |  25.128 ns |  1.68 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.0 |  14.648 ns | 0.0215 ns | 0.0191 ns |  14.652 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.2 |  12.973 ns | 0.0142 ns | 0.0133 ns |  12.974 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 3.0 |  14.435 ns | 0.0705 ns | 0.0659 ns |  14.462 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net461 |  26.443 ns | 0.0278 ns | 0.0260 ns |  26.438 ns |  1.81 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net472 |  23.382 ns | 0.0391 ns | 0.0365 ns |  23.369 ns |  1.60 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                              From_NonConvertibleClass | .NET Core 2.0 |  13.344 ns | 0.0111 ns | 0.0104 ns |  13.344 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 2.2 |  11.700 ns | 0.0533 ns | 0.0499 ns |  11.706 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 3.0 |  11.087 ns | 0.0183 ns | 0.0152 ns |  11.091 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net461 |  15.719 ns | 0.0233 ns | 0.0218 ns |  15.724 ns |  1.18 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net472 |  16.051 ns | 0.0233 ns | 0.0218 ns |  16.051 ns |  1.20 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                     From_NonConvertibleClass_AsObject | .NET Core 2.0 |  17.318 ns | 0.0235 ns | 0.0208 ns |  17.310 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 2.2 |  14.574 ns | 0.0140 ns | 0.0131 ns |  14.575 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 3.0 |  15.573 ns | 0.1441 ns | 0.1348 ns |  15.513 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net461 |  27.505 ns | 0.0266 ns | 0.0249 ns |  27.501 ns |  1.59 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net472 |  25.215 ns | 0.1536 ns | 0.1437 ns |  25.124 ns |  1.46 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                      From_NonConvertibleClass_NoValue | .NET Core 2.0 |  13.834 ns | 0.0693 ns | 0.0648 ns |  13.858 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 2.2 |  11.603 ns | 0.0081 ns | 0.0072 ns |  11.601 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 3.0 |  13.344 ns | 0.0105 ns | 0.0099 ns |  13.339 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net461 |  13.911 ns | 0.0131 ns | 0.0122 ns |  13.914 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net472 |  16.085 ns | 0.0214 ns | 0.0200 ns |  16.087 ns |  1.16 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.0 |  15.413 ns | 0.0232 ns | 0.0217 ns |  15.416 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.2 |  12.991 ns | 0.0225 ns | 0.0210 ns |  12.985 ns |  0.84 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 3.0 |  14.348 ns | 0.0134 ns | 0.0125 ns |  14.347 ns |  0.93 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net461 |  25.303 ns | 0.1604 ns | 0.1501 ns |  25.358 ns |  1.64 |    0.01 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net472 |  25.499 ns | 0.1786 ns | 0.1670 ns |  25.627 ns |  1.65 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                From_ConvertibleStruct | .NET Core 2.0 |  23.866 ns | 0.0447 ns | 0.0419 ns |  23.868 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 2.2 |  17.941 ns | 0.0303 ns | 0.0283 ns |  17.937 ns |  0.75 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 3.0 |  15.538 ns | 0.0944 ns | 0.0837 ns |  15.568 ns |  0.65 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net461 |  27.327 ns | 0.0320 ns | 0.0299 ns |  27.339 ns |  1.15 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net472 |  27.309 ns | 0.0514 ns | 0.0429 ns |  27.305 ns |  1.14 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                       From_ConvertibleStruct_AsObject | .NET Core 2.0 |  21.330 ns | 0.0172 ns | 0.0161 ns |  21.335 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 2.2 |  19.376 ns | 0.0179 ns | 0.0167 ns |  19.374 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 3.0 |  19.301 ns | 0.1220 ns | 0.1141 ns |  19.238 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net461 |  30.206 ns | 0.2174 ns | 0.2034 ns |  30.108 ns |  1.42 |    0.01 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net472 |  31.198 ns | 0.0532 ns | 0.0498 ns |  31.202 ns |  1.46 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.0 |  23.043 ns | 0.0330 ns | 0.0309 ns |  23.039 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.2 |  18.818 ns | 0.0470 ns | 0.0440 ns |  18.808 ns |  0.82 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 3.0 |  17.188 ns | 0.2805 ns | 0.2624 ns |  17.226 ns |  0.75 |    0.01 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net461 |  26.911 ns | 0.0273 ns | 0.0228 ns |  26.907 ns |  1.17 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net472 |  26.798 ns | 0.0278 ns | 0.0247 ns |  26.799 ns |  1.16 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 |  21.310 ns | 0.0191 ns | 0.0179 ns |  21.315 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 |  19.375 ns | 0.0166 ns | 0.0155 ns |  19.373 ns |  0.91 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 |  21.306 ns | 0.1053 ns | 0.0933 ns |  21.341 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net461 |  30.284 ns | 0.0459 ns | 0.0407 ns |  30.279 ns |  1.42 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net472 |  28.451 ns | 0.0473 ns | 0.0442 ns |  28.443 ns |  1.34 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.0 |  14.999 ns | 0.0201 ns | 0.0188 ns |  14.997 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.2 |  12.933 ns | 0.0352 ns | 0.0329 ns |  12.941 ns |  0.86 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 3.0 |  11.039 ns | 0.2460 ns | 0.6937 ns |  11.248 ns |  0.66 |    0.09 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net461 |  20.673 ns | 0.0579 ns | 0.0513 ns |  20.684 ns |  1.38 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net472 |  25.621 ns | 0.0397 ns | 0.0352 ns |  25.616 ns |  1.71 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 |  16.157 ns | 0.0201 ns | 0.0179 ns |  16.153 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 |  12.950 ns | 0.0140 ns | 0.0131 ns |  12.951 ns |  0.80 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 |  16.189 ns | 0.0620 ns | 0.0580 ns |  16.212 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net461 |  26.465 ns | 0.0241 ns | 0.0225 ns |  26.461 ns |  1.64 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net472 |  23.495 ns | 0.0258 ns | 0.0229 ns |  23.492 ns |  1.45 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                             From_NonConvertibleStruct | .NET Core 2.0 |  15.689 ns | 0.0613 ns | 0.0574 ns |  15.706 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 2.2 |  12.367 ns | 0.0184 ns | 0.0154 ns |  12.368 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 3.0 |   7.835 ns | 0.0167 ns | 0.0156 ns |   7.828 ns |  0.50 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net461 |  14.073 ns | 0.0109 ns | 0.0097 ns |  14.073 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net472 |  13.503 ns | 0.0111 ns | 0.0098 ns |  13.505 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.0 |  16.157 ns | 0.0257 ns | 0.0228 ns |  16.165 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.2 |  14.585 ns | 0.0141 ns | 0.0132 ns |  14.586 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 3.0 |  17.378 ns | 0.0179 ns | 0.0159 ns |  17.382 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net461 |  27.414 ns | 0.0240 ns | 0.0213 ns |  27.408 ns |  1.70 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net472 |  25.128 ns | 0.0264 ns | 0.0234 ns |  25.123 ns |  1.56 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.0 |  14.123 ns | 0.0152 ns | 0.0127 ns |  14.125 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.2 |  12.906 ns | 0.0110 ns | 0.0103 ns |  12.904 ns |  0.91 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 3.0 |   7.350 ns | 0.0123 ns | 0.0115 ns |   7.354 ns |  0.52 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net461 |  13.359 ns | 0.0220 ns | 0.0206 ns |  13.354 ns |  0.95 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net472 |  15.861 ns | 0.0125 ns | 0.0117 ns |  15.863 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 |  17.195 ns | 0.0197 ns | 0.0185 ns |  17.196 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 |  14.596 ns | 0.0152 ns | 0.0134 ns |  14.596 ns |  0.85 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 |  14.977 ns | 0.1604 ns | 0.1422 ns |  15.044 ns |  0.87 |    0.01 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net461 |  27.582 ns | 0.1454 ns | 0.1360 ns |  27.517 ns |  1.60 |    0.01 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net472 |  25.319 ns | 0.0401 ns | 0.0376 ns |  25.321 ns |  1.47 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.0 |  14.814 ns | 0.0649 ns | 0.0607 ns |  14.851 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.2 |  10.962 ns | 0.0110 ns | 0.0098 ns |  10.965 ns |  0.74 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 3.0 |   7.827 ns | 0.0102 ns | 0.0095 ns |   7.825 ns |  0.53 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net461 |  13.366 ns | 0.0129 ns | 0.0121 ns |  13.364 ns |  0.90 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net472 |  13.600 ns | 0.0438 ns | 0.0410 ns |  13.616 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 |  15.411 ns | 0.0261 ns | 0.0231 ns |  15.408 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 |  13.039 ns | 0.0380 ns | 0.0355 ns |  13.048 ns |  0.85 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 |  13.310 ns | 0.3990 ns | 0.4749 ns |  13.047 ns |  0.87 |    0.04 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net461 |  25.150 ns | 0.0138 ns | 0.0122 ns |  25.150 ns |  1.63 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net472 |  23.311 ns | 0.0336 ns | 0.0281 ns |  23.311 ns |  1.51 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                             From_Enum | .NET Core 2.0 |  14.260 ns | 0.0125 ns | 0.0117 ns |  14.257 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 2.2 |  11.026 ns | 0.0126 ns | 0.0118 ns |  11.025 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 3.0 |   7.790 ns | 0.0066 ns | 0.0058 ns |   7.791 ns |  0.55 |    0.00 |      - |     - |     - |         - |
                                             From_Enum |        net461 |  12.849 ns | 0.0163 ns | 0.0153 ns |  12.848 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                             From_Enum |        net472 |  13.351 ns | 0.0156 ns | 0.0146 ns |  13.350 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                    From_Enum_AsObject | .NET Core 2.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Enum_AsObject | .NET Core 2.2 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Enum_AsObject | .NET Core 3.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Enum_AsObject |        net461 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Enum_AsObject |        net472 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                          From_Enum_Nullable_WithValue | .NET Core 2.0 |  14.084 ns | 0.0097 ns | 0.0081 ns |  14.081 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 2.2 |  11.013 ns | 0.0090 ns | 0.0084 ns |  11.015 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 3.0 |   7.326 ns | 0.0132 ns | 0.0123 ns |   7.328 ns |  0.52 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net461 |  13.460 ns | 0.0704 ns | 0.0659 ns |  13.494 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net472 |  13.388 ns | 0.0124 ns | 0.0110 ns |  13.386 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.2 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 3.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                 From_Enum_Nullable_WithValue_AsObject |        net461 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                 From_Enum_Nullable_WithValue_AsObject |        net472 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                            From_Enum_Nullable_NoValue | .NET Core 2.0 |  14.029 ns | 0.0146 ns | 0.0136 ns |  14.030 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 2.2 |  10.978 ns | 0.0090 ns | 0.0084 ns |  10.975 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 3.0 |   7.332 ns | 0.0095 ns | 0.0089 ns |   7.332 ns |  0.52 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net461 |  12.846 ns | 0.0236 ns | 0.0209 ns |  12.838 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net472 |  13.843 ns | 0.0103 ns | 0.0096 ns |  13.845 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.0 |  15.553 ns | 0.0800 ns | 0.0709 ns |  15.567 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.2 |  13.382 ns | 0.0180 ns | 0.0168 ns |  13.382 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 3.0 |  13.339 ns | 0.0131 ns | 0.0122 ns |  13.338 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net461 |  26.382 ns | 0.0199 ns | 0.0166 ns |  26.379 ns |  1.70 |    0.01 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net472 |  23.803 ns | 0.0637 ns | 0.0596 ns |  23.818 ns |  1.53 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                      From_ParentClass | .NET Core 2.0 |  13.492 ns | 0.0187 ns | 0.0165 ns |  13.492 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 2.2 |  11.638 ns | 0.0277 ns | 0.0260 ns |  11.637 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 3.0 |  11.542 ns | 0.0842 ns | 0.0788 ns |  11.546 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                                      From_ParentClass |        net461 |  15.596 ns | 0.0225 ns | 0.0199 ns |  15.596 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass |        net472 |  15.834 ns | 0.0184 ns | 0.0172 ns |  15.832 ns |  1.17 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                             From_ParentClass_AsObject | .NET Core 2.0 |  17.588 ns | 0.0178 ns | 0.0158 ns |  17.594 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 2.2 |  14.991 ns | 0.0153 ns | 0.0143 ns |  14.991 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 3.0 |  15.301 ns | 0.3665 ns | 0.6608 ns |  14.930 ns |  0.91 |    0.04 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net461 |  28.294 ns | 0.1376 ns | 0.1220 ns |  28.340 ns |  1.61 |    0.01 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net472 |  26.949 ns | 0.0424 ns | 0.0397 ns |  26.949 ns |  1.53 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                              From_ParentClass_NoValue | .NET Core 2.0 |  13.487 ns | 0.0143 ns | 0.0120 ns |  13.484 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 2.2 |  11.693 ns | 0.0449 ns | 0.0420 ns |  11.715 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 3.0 |  11.816 ns | 0.0619 ns | 0.0579 ns |  11.833 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net461 |  14.478 ns | 0.0124 ns | 0.0110 ns |  14.480 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net472 |  16.074 ns | 0.0240 ns | 0.0224 ns |  16.073 ns |  1.19 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.0 |  14.864 ns | 0.0108 ns | 0.0091 ns |  14.862 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.2 |  13.243 ns | 0.0093 ns | 0.0078 ns |  13.244 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 3.0 |  13.169 ns | 0.2115 ns | 0.1979 ns |  13.040 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net461 |  25.071 ns | 0.0779 ns | 0.0728 ns |  25.056 ns |  1.69 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net472 |  28.111 ns | 0.0131 ns | 0.0117 ns |  28.112 ns |  1.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                     From_ParentStruct | .NET Core 2.0 |  44.625 ns | 0.0533 ns | 0.0445 ns |  44.613 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 2.2 |  37.871 ns | 0.0300 ns | 0.0266 ns |  37.875 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 3.0 |  35.432 ns | 0.0495 ns | 0.0463 ns |  35.428 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct |        net461 |  39.391 ns | 0.0593 ns | 0.0555 ns |  39.389 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct |        net472 |  40.460 ns | 0.0508 ns | 0.0476 ns |  40.467 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                            From_ParentStruct_AsObject | .NET Core 2.0 |  18.183 ns | 0.0217 ns | 0.0203 ns |  18.179 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 2.2 |  15.043 ns | 0.0183 ns | 0.0172 ns |  15.046 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 3.0 |  17.532 ns | 0.0842 ns | 0.0787 ns |  17.549 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net461 |  27.530 ns | 0.0561 ns | 0.0497 ns |  27.515 ns |  1.51 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net472 |  25.843 ns | 0.0351 ns | 0.0329 ns |  25.839 ns |  1.42 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.0 |  41.077 ns | 0.0556 ns | 0.0493 ns |  41.061 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.2 |  39.909 ns | 0.0335 ns | 0.0314 ns |  39.905 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 3.0 |  35.276 ns | 0.0306 ns | 0.0286 ns |  35.266 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue |        net461 |  39.695 ns | 0.0559 ns | 0.0523 ns |  39.690 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue |        net472 |  42.583 ns | 0.0745 ns | 0.0661 ns |  42.573 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.0 |  17.270 ns | 0.0247 ns | 0.0219 ns |  17.273 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.2 |  16.947 ns | 0.0168 ns | 0.0149 ns |  16.946 ns |  0.98 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 3.0 |  15.313 ns | 0.3311 ns | 0.6219 ns |  14.931 ns |  0.93 |    0.03 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net461 |  26.588 ns | 0.0295 ns | 0.0276 ns |  26.585 ns |  1.54 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net472 |  27.878 ns | 0.0307 ns | 0.0272 ns |  27.882 ns |  1.61 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.0 |  51.265 ns | 0.0892 ns | 0.0834 ns |  51.249 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.2 |  38.918 ns | 0.0480 ns | 0.0449 ns |  38.908 ns |  0.76 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 3.0 |  38.247 ns | 0.7870 ns | 1.1536 ns |  38.694 ns |  0.74 |    0.03 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net461 |  39.367 ns | 0.0425 ns | 0.0376 ns |  39.371 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net472 |  43.690 ns | 0.0489 ns | 0.0458 ns |  43.686 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.0 |  14.676 ns | 0.0221 ns | 0.0206 ns |  14.673 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.2 |  13.096 ns | 0.0402 ns | 0.0357 ns |  13.102 ns |  0.89 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 3.0 |  13.008 ns | 0.0179 ns | 0.0159 ns |  13.006 ns |  0.89 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net461 |  25.164 ns | 0.0206 ns | 0.0182 ns |  25.168 ns |  1.71 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net472 |  23.477 ns | 0.0959 ns | 0.0897 ns |  23.517 ns |  1.60 |    0.01 |      - |     - |     - |         - |

Benchmarks with issues:
  ConvertTo_DateTimeNullable.From_Bool_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_DateTimeNullable.From_Bool_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_DateTimeNullable.From_Bool_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_DateTimeNullable.From_Bool_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_DateTimeNullable.From_Bool_AsObject: Job-ZVTGBZ(Toolchain=net472)
  ConvertTo_DateTimeNullable.From_Bool_Nullable_WithValue_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_DateTimeNullable.From_Bool_Nullable_WithValue_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_DateTimeNullable.From_Bool_Nullable_WithValue_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_DateTimeNullable.From_Bool_Nullable_WithValue_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_DateTimeNullable.From_Bool_Nullable_WithValue_AsObject: Job-ZVTGBZ(Toolchain=net472)
  ConvertTo_DateTimeNullable.From_Byte_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_DateTimeNullable.From_Byte_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_DateTimeNullable.From_Byte_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_DateTimeNullable.From_Byte_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_DateTimeNullable.From_Byte_AsObject: Job-ZVTGBZ(Toolchain=net472)
  ConvertTo_DateTimeNullable.From_Byte_Nullable_WithValue_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_DateTimeNullable.From_Byte_Nullable_WithValue_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_DateTimeNullable.From_Byte_Nullable_WithValue_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_DateTimeNullable.From_Byte_Nullable_WithValue_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_DateTimeNullable.From_Byte_Nullable_WithValue_AsObject: Job-ZVTGBZ(Toolchain=net472)
  ConvertTo_DateTimeNullable.From_Char_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_DateTimeNullable.From_Char_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_DateTimeNullable.From_Char_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_DateTimeNullable.From_Char_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_DateTimeNullable.From_Char_AsObject: Job-ZVTGBZ(Toolchain=net472)
  ConvertTo_DateTimeNullable.From_Char_Nullable_WithValue_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_DateTimeNullable.From_Char_Nullable_WithValue_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_DateTimeNullable.From_Char_Nullable_WithValue_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_DateTimeNullable.From_Char_Nullable_WithValue_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_DateTimeNullable.From_Char_Nullable_WithValue_AsObject: Job-ZVTGBZ(Toolchain=net472)
  ConvertTo_DateTimeNullable.From_Decimal_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_DateTimeNullable.From_Decimal_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_DateTimeNullable.From_Decimal_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_DateTimeNullable.From_Decimal_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_DateTimeNullable.From_Decimal_AsObject: Job-ZVTGBZ(Toolchain=net472)
  ConvertTo_DateTimeNullable.From_Decimal_Nullable_WithValue_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_DateTimeNullable.From_Decimal_Nullable_WithValue_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_DateTimeNullable.From_Decimal_Nullable_WithValue_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_DateTimeNullable.From_Decimal_Nullable_WithValue_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_DateTimeNullable.From_Decimal_Nullable_WithValue_AsObject: Job-ZVTGBZ(Toolchain=net472)
  ConvertTo_DateTimeNullable.From_Double_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_DateTimeNullable.From_Double_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_DateTimeNullable.From_Double_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_DateTimeNullable.From_Double_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_DateTimeNullable.From_Double_AsObject: Job-ZVTGBZ(Toolchain=net472)
  ConvertTo_DateTimeNullable.From_Double_Nullable_WithValue_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_DateTimeNullable.From_Double_Nullable_WithValue_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_DateTimeNullable.From_Double_Nullable_WithValue_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_DateTimeNullable.From_Double_Nullable_WithValue_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_DateTimeNullable.From_Double_Nullable_WithValue_AsObject: Job-ZVTGBZ(Toolchain=net472)
  ConvertTo_DateTimeNullable.From_Short_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_DateTimeNullable.From_Short_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_DateTimeNullable.From_Short_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_DateTimeNullable.From_Short_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_DateTimeNullable.From_Short_AsObject: Job-ZVTGBZ(Toolchain=net472)
  ConvertTo_DateTimeNullable.From_Short_Nullable_WithValue_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_DateTimeNullable.From_Short_Nullable_WithValue_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_DateTimeNullable.From_Short_Nullable_WithValue_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_DateTimeNullable.From_Short_Nullable_WithValue_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_DateTimeNullable.From_Short_Nullable_WithValue_AsObject: Job-ZVTGBZ(Toolchain=net472)
  ConvertTo_DateTimeNullable.From_Int_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_DateTimeNullable.From_Int_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_DateTimeNullable.From_Int_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_DateTimeNullable.From_Int_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_DateTimeNullable.From_Int_AsObject: Job-ZVTGBZ(Toolchain=net472)
  ConvertTo_DateTimeNullable.From_Int_Nullable_WithValue_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_DateTimeNullable.From_Int_Nullable_WithValue_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_DateTimeNullable.From_Int_Nullable_WithValue_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_DateTimeNullable.From_Int_Nullable_WithValue_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_DateTimeNullable.From_Int_Nullable_WithValue_AsObject: Job-ZVTGBZ(Toolchain=net472)
  ConvertTo_DateTimeNullable.From_Long_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_DateTimeNullable.From_Long_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_DateTimeNullable.From_Long_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_DateTimeNullable.From_Long_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_DateTimeNullable.From_Long_AsObject: Job-ZVTGBZ(Toolchain=net472)
  ConvertTo_DateTimeNullable.From_Long_Nullable_WithValue_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_DateTimeNullable.From_Long_Nullable_WithValue_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_DateTimeNullable.From_Long_Nullable_WithValue_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_DateTimeNullable.From_Long_Nullable_WithValue_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_DateTimeNullable.From_Long_Nullable_WithValue_AsObject: Job-ZVTGBZ(Toolchain=net472)
  ConvertTo_DateTimeNullable.From_SByte_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_DateTimeNullable.From_SByte_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_DateTimeNullable.From_SByte_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_DateTimeNullable.From_SByte_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_DateTimeNullable.From_SByte_AsObject: Job-ZVTGBZ(Toolchain=net472)
  ConvertTo_DateTimeNullable.From_SByte_Nullable_WithValue_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_DateTimeNullable.From_SByte_Nullable_WithValue_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_DateTimeNullable.From_SByte_Nullable_WithValue_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_DateTimeNullable.From_SByte_Nullable_WithValue_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_DateTimeNullable.From_SByte_Nullable_WithValue_AsObject: Job-ZVTGBZ(Toolchain=net472)
  ConvertTo_DateTimeNullable.From_Float_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_DateTimeNullable.From_Float_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_DateTimeNullable.From_Float_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_DateTimeNullable.From_Float_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_DateTimeNullable.From_Float_AsObject: Job-ZVTGBZ(Toolchain=net472)
  ConvertTo_DateTimeNullable.From_Float_Nullable_WithValue_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_DateTimeNullable.From_Float_Nullable_WithValue_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_DateTimeNullable.From_Float_Nullable_WithValue_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_DateTimeNullable.From_Float_Nullable_WithValue_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_DateTimeNullable.From_Float_Nullable_WithValue_AsObject: Job-ZVTGBZ(Toolchain=net472)
  ConvertTo_DateTimeNullable.From_String_Empty_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_DateTimeNullable.From_String_Empty_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_DateTimeNullable.From_String_Empty_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_DateTimeNullable.From_String_Empty_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_DateTimeNullable.From_String_Empty_AsObject: Job-ZVTGBZ(Toolchain=net472)
  ConvertTo_DateTimeNullable.From_UShort_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_DateTimeNullable.From_UShort_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_DateTimeNullable.From_UShort_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_DateTimeNullable.From_UShort_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_DateTimeNullable.From_UShort_AsObject: Job-ZVTGBZ(Toolchain=net472)
  ConvertTo_DateTimeNullable.From_UShort_Nullable_WithValue_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_DateTimeNullable.From_UShort_Nullable_WithValue_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_DateTimeNullable.From_UShort_Nullable_WithValue_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_DateTimeNullable.From_UShort_Nullable_WithValue_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_DateTimeNullable.From_UShort_Nullable_WithValue_AsObject: Job-ZVTGBZ(Toolchain=net472)
  ConvertTo_DateTimeNullable.From_UInt_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_DateTimeNullable.From_UInt_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_DateTimeNullable.From_UInt_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_DateTimeNullable.From_UInt_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_DateTimeNullable.From_UInt_AsObject: Job-ZVTGBZ(Toolchain=net472)
  ConvertTo_DateTimeNullable.From_UInt_Nullable_WithValue_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_DateTimeNullable.From_UInt_Nullable_WithValue_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_DateTimeNullable.From_UInt_Nullable_WithValue_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_DateTimeNullable.From_UInt_Nullable_WithValue_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_DateTimeNullable.From_UInt_Nullable_WithValue_AsObject: Job-ZVTGBZ(Toolchain=net472)
  ConvertTo_DateTimeNullable.From_ULong_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_DateTimeNullable.From_ULong_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_DateTimeNullable.From_ULong_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_DateTimeNullable.From_ULong_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_DateTimeNullable.From_ULong_AsObject: Job-ZVTGBZ(Toolchain=net472)
  ConvertTo_DateTimeNullable.From_ULong_Nullable_WithValue_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_DateTimeNullable.From_ULong_Nullable_WithValue_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_DateTimeNullable.From_ULong_Nullable_WithValue_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_DateTimeNullable.From_ULong_Nullable_WithValue_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_DateTimeNullable.From_ULong_Nullable_WithValue_AsObject: Job-ZVTGBZ(Toolchain=net472)
  ConvertTo_DateTimeNullable.From_Enum_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_DateTimeNullable.From_Enum_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_DateTimeNullable.From_Enum_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_DateTimeNullable.From_Enum_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_DateTimeNullable.From_Enum_AsObject: Job-ZVTGBZ(Toolchain=net472)
  ConvertTo_DateTimeNullable.From_Enum_Nullable_WithValue_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_DateTimeNullable.From_Enum_Nullable_WithValue_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_DateTimeNullable.From_Enum_Nullable_WithValue_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_DateTimeNullable.From_Enum_Nullable_WithValue_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_DateTimeNullable.From_Enum_Nullable_WithValue_AsObject: Job-ZVTGBZ(Toolchain=net472)
