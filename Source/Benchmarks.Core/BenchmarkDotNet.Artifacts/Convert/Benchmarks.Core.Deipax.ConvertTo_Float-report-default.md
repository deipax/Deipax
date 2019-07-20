
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
                                             From_Bool | .NET Core 2.0 | 13.139 ns | 0.0229 ns | 0.0214 ns | 13.138 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 2.2 | 11.622 ns | 0.0110 ns | 0.0092 ns | 11.624 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 3.0 |  6.795 ns | 0.0147 ns | 0.0130 ns |  6.794 ns |  0.52 |    0.00 |      - |     - |     - |         - |
                                             From_Bool |        net461 | 12.059 ns | 0.0118 ns | 0.0104 ns | 12.058 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                             From_Bool |        net472 | 11.903 ns | 0.0135 ns | 0.0105 ns | 11.899 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Bool_AsObject | .NET Core 2.0 | 19.270 ns | 0.0406 ns | 0.0380 ns | 19.271 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 2.2 | 16.203 ns | 0.0186 ns | 0.0174 ns | 16.199 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 3.0 | 16.516 ns | 0.1964 ns | 0.1837 ns | 16.384 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net461 | 18.760 ns | 0.0244 ns | 0.0229 ns | 18.758 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net472 | 20.504 ns | 0.0342 ns | 0.0267 ns | 20.503 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Bool_Nullable_WithValue | .NET Core 2.0 | 12.143 ns | 0.0753 ns | 0.0705 ns | 12.099 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 2.2 | 10.479 ns | 0.0131 ns | 0.0116 ns | 10.480 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 3.0 |  7.692 ns | 0.0293 ns | 0.0244 ns |  7.696 ns |  0.63 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net461 | 13.547 ns | 0.0372 ns | 0.0330 ns | 13.558 ns |  1.12 |    0.01 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net472 | 11.376 ns | 0.0415 ns | 0.0388 ns | 11.361 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.092 ns | 0.0394 ns | 0.0368 ns | 18.094 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.847 ns | 0.0688 ns | 0.0575 ns | 17.863 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.250 ns | 0.3665 ns | 0.7061 ns | 17.584 ns |  0.92 |    0.05 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net461 | 21.407 ns | 0.0339 ns | 0.0317 ns | 21.411 ns |  1.18 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net472 | 20.621 ns | 0.0337 ns | 0.0299 ns | 20.623 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Bool_Nullable_NoValue | .NET Core 2.0 | 12.581 ns | 0.0111 ns | 0.0099 ns | 12.584 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 2.2 | 10.038 ns | 0.0104 ns | 0.0097 ns | 10.038 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 3.0 |  7.158 ns | 0.0072 ns | 0.0064 ns |  7.156 ns |  0.57 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net461 | 11.768 ns | 0.0146 ns | 0.0129 ns | 11.766 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net472 | 10.444 ns | 0.0126 ns | 0.0118 ns | 10.444 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.250 ns | 0.0469 ns | 0.0439 ns | 14.253 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.661 ns | 0.0838 ns | 0.0784 ns | 13.619 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.614 ns | 0.2963 ns | 0.3043 ns | 13.744 ns |  0.95 |    0.02 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net461 | 13.618 ns | 0.0224 ns | 0.0210 ns | 13.612 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net472 | 15.277 ns | 0.0224 ns | 0.0210 ns | 15.276 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Byte | .NET Core 2.0 | 11.686 ns | 0.0160 ns | 0.0142 ns | 11.692 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 2.2 | 10.137 ns | 0.0160 ns | 0.0142 ns | 10.138 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 3.0 |  9.022 ns | 0.2076 ns | 0.3469 ns |  9.125 ns |  0.76 |    0.05 |      - |     - |     - |         - |
                                             From_Byte |        net461 | 12.775 ns | 0.0230 ns | 0.0204 ns | 12.774 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                             From_Byte |        net472 | 11.094 ns | 0.0171 ns | 0.0151 ns | 11.091 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Byte_AsObject | .NET Core 2.0 | 17.992 ns | 0.1343 ns | 0.1256 ns | 17.940 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 2.2 | 15.432 ns | 0.0261 ns | 0.0245 ns | 15.425 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 3.0 | 15.284 ns | 0.0649 ns | 0.0608 ns | 15.298 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net461 | 21.190 ns | 0.0959 ns | 0.0897 ns | 21.190 ns |  1.18 |    0.01 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net472 | 20.577 ns | 0.0280 ns | 0.0218 ns | 20.579 ns |  1.15 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Byte_Nullable_WithValue | .NET Core 2.0 | 11.911 ns | 0.0160 ns | 0.0133 ns | 11.913 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 2.2 | 10.330 ns | 0.0138 ns | 0.0129 ns | 10.325 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 3.0 |  7.729 ns | 0.0371 ns | 0.0347 ns |  7.742 ns |  0.65 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net461 | 12.375 ns | 0.0121 ns | 0.0113 ns | 12.377 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net472 | 10.783 ns | 0.0121 ns | 0.0113 ns | 10.778 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.037 ns | 0.0274 ns | 0.0257 ns | 19.032 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.272 ns | 0.0196 ns | 0.0164 ns | 17.271 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.688 ns | 0.0294 ns | 0.0261 ns | 15.688 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net461 | 18.903 ns | 0.0200 ns | 0.0177 ns | 18.901 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net472 | 21.213 ns | 0.0596 ns | 0.0528 ns | 21.213 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Byte_Nullable_NoValue | .NET Core 2.0 | 11.743 ns | 0.0203 ns | 0.0190 ns | 11.741 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 2.2 | 10.050 ns | 0.0121 ns | 0.0113 ns | 10.049 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 3.0 |  7.162 ns | 0.0120 ns | 0.0113 ns |  7.160 ns |  0.61 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net461 | 12.451 ns | 0.0127 ns | 0.0112 ns | 12.448 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net472 | 10.650 ns | 0.0121 ns | 0.0107 ns | 10.651 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.108 ns | 0.0115 ns | 0.0102 ns | 14.105 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.151 ns | 0.0428 ns | 0.0380 ns | 12.158 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.953 ns | 0.3734 ns | 0.6340 ns | 13.602 ns |  1.03 |    0.05 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net461 | 13.639 ns | 0.0390 ns | 0.0345 ns | 13.648 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net472 | 15.311 ns | 0.0472 ns | 0.0442 ns | 15.304 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Char | .NET Core 2.0 | 11.656 ns | 0.0139 ns | 0.0130 ns | 11.655 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Char | .NET Core 2.2 | 10.390 ns | 0.0712 ns | 0.0666 ns | 10.365 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                                             From_Char | .NET Core 3.0 |  6.443 ns | 0.0202 ns | 0.0189 ns |  6.446 ns |  0.55 |    0.00 |      - |     - |     - |         - |
                                             From_Char |        net461 | 12.485 ns | 0.0093 ns | 0.0083 ns | 12.483 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                             From_Char |        net472 | 10.374 ns | 0.0145 ns | 0.0135 ns | 10.376 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Char_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Char_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Char_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Char_Nullable_WithValue | .NET Core 2.0 | 12.819 ns | 0.0741 ns | 0.0693 ns | 12.818 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 2.2 | 10.095 ns | 0.0186 ns | 0.0174 ns | 10.096 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 3.0 |  6.384 ns | 0.0133 ns | 0.0125 ns |  6.385 ns |  0.50 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net461 | 11.864 ns | 0.0117 ns | 0.0104 ns | 11.866 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net472 | 10.331 ns | 0.0101 ns | 0.0085 ns | 10.331 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Char_Nullable_NoValue | .NET Core 2.0 | 11.651 ns | 0.0165 ns | 0.0146 ns | 11.648 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 2.2 | 10.091 ns | 0.0111 ns | 0.0104 ns | 10.092 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 3.0 |  8.015 ns | 0.1744 ns | 0.1632 ns |  8.100 ns |  0.69 |    0.01 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net461 | 11.730 ns | 0.0131 ns | 0.0109 ns | 11.731 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net472 | 10.337 ns | 0.0143 ns | 0.0119 ns | 10.338 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.097 ns | 0.0148 ns | 0.0138 ns | 14.097 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.772 ns | 0.0225 ns | 0.0210 ns | 12.772 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.451 ns | 0.0260 ns | 0.0243 ns | 12.462 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net461 | 15.887 ns | 0.0207 ns | 0.0184 ns | 15.886 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net472 | 15.297 ns | 0.0188 ns | 0.0166 ns | 15.300 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                         From_DateTime | .NET Core 2.0 | 12.024 ns | 0.0227 ns | 0.0212 ns | 12.018 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 2.2 | 10.944 ns | 0.0176 ns | 0.0156 ns | 10.943 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 3.0 |  8.569 ns | 0.1950 ns | 0.2535 ns |  8.406 ns |  0.72 |    0.02 |      - |     - |     - |         - |
                                         From_DateTime |        net461 | 13.774 ns | 0.0444 ns | 0.0415 ns | 13.782 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime |        net472 | 11.989 ns | 0.0202 ns | 0.0189 ns | 11.981 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                From_DateTime_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                      From_DateTime_Nullable_WithValue | .NET Core 2.0 | 12.730 ns | 0.0115 ns | 0.0102 ns | 12.729 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 2.2 | 11.652 ns | 0.0526 ns | 0.0466 ns | 11.671 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 3.0 |  9.380 ns | 0.2123 ns | 0.5046 ns |  9.562 ns |  0.68 |    0.06 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net461 | 14.275 ns | 0.0364 ns | 0.0341 ns | 14.274 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net472 | 12.776 ns | 0.0091 ns | 0.0076 ns | 12.776 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_DateTime_Nullable_NoValue | .NET Core 2.0 | 13.388 ns | 0.0130 ns | 0.0115 ns | 13.391 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 2.2 | 11.578 ns | 0.0771 ns | 0.0722 ns | 11.541 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 3.0 |  8.062 ns | 0.0826 ns | 0.0773 ns |  8.091 ns |  0.60 |    0.01 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net461 | 14.100 ns | 0.0149 ns | 0.0140 ns | 14.100 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net472 | 13.395 ns | 0.0117 ns | 0.0110 ns | 13.393 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.270 ns | 0.0073 ns | 0.0057 ns | 14.272 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.019 ns | 0.0116 ns | 0.0108 ns | 12.023 ns |  0.84 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.345 ns | 0.1846 ns | 0.1726 ns | 13.318 ns |  0.93 |    0.01 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net461 | 15.938 ns | 0.0260 ns | 0.0231 ns | 15.935 ns |  1.12 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net472 | 15.454 ns | 0.0524 ns | 0.0464 ns | 15.465 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                          From_Decimal | .NET Core 2.0 | 23.239 ns | 0.0359 ns | 0.0336 ns | 23.236 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 2.2 | 20.119 ns | 0.0281 ns | 0.0234 ns | 20.123 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 3.0 | 15.037 ns | 0.2774 ns | 0.2595 ns | 15.233 ns |  0.65 |    0.01 |      - |     - |     - |         - |
                                          From_Decimal |        net461 | 33.110 ns | 0.0217 ns | 0.0203 ns | 33.114 ns |  1.42 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal |        net472 | 24.002 ns | 0.0140 ns | 0.0124 ns | 24.002 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                 From_Decimal_AsObject | .NET Core 2.0 | 24.345 ns | 0.0180 ns | 0.0150 ns | 24.347 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 2.2 | 21.074 ns | 0.0413 ns | 0.0366 ns | 21.067 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 3.0 | 18.464 ns | 0.0428 ns | 0.0401 ns | 18.457 ns |  0.76 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net461 | 24.236 ns | 0.1140 ns | 0.1067 ns | 24.266 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net472 | 25.840 ns | 0.0268 ns | 0.0251 ns | 25.842 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                       From_Decimal_Nullable_WithValue | .NET Core 2.0 | 24.585 ns | 0.0285 ns | 0.0266 ns | 24.580 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 2.2 | 22.229 ns | 0.0147 ns | 0.0137 ns | 22.228 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 3.0 | 21.123 ns | 0.3980 ns | 0.3723 ns | 20.857 ns |  0.86 |    0.02 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net461 | 24.885 ns | 0.0142 ns | 0.0126 ns | 24.885 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net472 | 23.922 ns | 0.0338 ns | 0.0316 ns | 23.925 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.0 | 23.519 ns | 0.0272 ns | 0.0241 ns | 23.516 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.2 | 24.558 ns | 0.0639 ns | 0.0534 ns | 24.554 ns |  1.04 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 3.0 | 20.177 ns | 0.0732 ns | 0.0684 ns | 20.182 ns |  0.86 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net461 | 24.269 ns | 0.0385 ns | 0.0360 ns | 24.263 ns |  1.03 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net472 | 26.073 ns | 0.0383 ns | 0.0340 ns | 26.061 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Decimal_Nullable_NoValue | .NET Core 2.0 | 13.733 ns | 0.0542 ns | 0.0481 ns | 13.742 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 2.2 | 11.547 ns | 0.0631 ns | 0.0590 ns | 11.572 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 3.0 |  8.045 ns | 0.0091 ns | 0.0085 ns |  8.045 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net461 | 14.978 ns | 0.0217 ns | 0.0203 ns | 14.981 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net472 | 13.548 ns | 0.0188 ns | 0.0176 ns | 13.546 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.072 ns | 0.0245 ns | 0.0229 ns | 15.072 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.215 ns | 0.0155 ns | 0.0137 ns | 13.217 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.356 ns | 0.2707 ns | 0.2659 ns | 12.191 ns |  0.82 |    0.02 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net461 | 15.927 ns | 0.0287 ns | 0.0255 ns | 15.921 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net472 | 15.317 ns | 0.0139 ns | 0.0116 ns | 15.318 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_Double | .NET Core 2.0 | 13.429 ns | 0.0264 ns | 0.0247 ns | 13.423 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 2.2 | 10.105 ns | 0.0112 ns | 0.0105 ns | 10.103 ns |  0.75 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 3.0 |  6.801 ns | 0.0385 ns | 0.0341 ns |  6.788 ns |  0.51 |    0.00 |      - |     - |     - |         - |
                                           From_Double |        net461 | 11.834 ns | 0.0086 ns | 0.0076 ns | 11.833 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                           From_Double |        net472 | 11.832 ns | 0.0177 ns | 0.0157 ns | 11.835 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_Double_AsObject | .NET Core 2.0 | 18.894 ns | 0.0198 ns | 0.0176 ns | 18.891 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 2.2 | 15.432 ns | 0.0171 ns | 0.0160 ns | 15.428 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 3.0 | 17.585 ns | 0.0514 ns | 0.0481 ns | 17.587 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject |        net461 | 21.179 ns | 0.0631 ns | 0.0590 ns | 21.165 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject |        net472 | 20.583 ns | 0.0214 ns | 0.0178 ns | 20.590 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_Double_Nullable_WithValue | .NET Core 2.0 | 12.920 ns | 0.0242 ns | 0.0227 ns | 12.911 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 2.2 | 12.004 ns | 0.1448 ns | 0.1355 ns | 12.031 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 3.0 |  8.102 ns | 0.0109 ns | 0.0102 ns |  8.098 ns |  0.63 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net461 | 14.823 ns | 0.0793 ns | 0.0742 ns | 14.855 ns |  1.15 |    0.01 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net472 | 13.993 ns | 0.0183 ns | 0.0172 ns | 13.991 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.876 ns | 0.0362 ns | 0.0339 ns | 20.869 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.371 ns | 0.0280 ns | 0.0248 ns | 15.367 ns |  0.74 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.492 ns | 0.0965 ns | 0.0903 ns | 15.533 ns |  0.74 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net461 | 21.177 ns | 0.1307 ns | 0.1223 ns | 21.114 ns |  1.01 |    0.01 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net472 | 20.601 ns | 0.0190 ns | 0.0168 ns | 20.606 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Double_Nullable_NoValue | .NET Core 2.0 | 13.075 ns | 0.0286 ns | 0.0239 ns | 13.084 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 2.2 | 11.571 ns | 0.0152 ns | 0.0142 ns | 11.571 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 3.0 |  9.098 ns | 0.6088 ns | 0.8924 ns |  8.600 ns |  0.74 |    0.08 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net461 | 14.122 ns | 0.0207 ns | 0.0193 ns | 14.125 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net472 | 13.699 ns | 0.0250 ns | 0.0234 ns | 13.692 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.113 ns | 0.0218 ns | 0.0193 ns | 14.113 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.886 ns | 0.0223 ns | 0.0174 ns | 13.891 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.151 ns | 0.0367 ns | 0.0325 ns | 12.169 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net461 | 16.001 ns | 0.0446 ns | 0.0396 ns | 16.005 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net472 | 15.321 ns | 0.0180 ns | 0.0168 ns | 15.321 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_Short | .NET Core 2.0 | 11.682 ns | 0.0126 ns | 0.0117 ns | 11.684 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 2.2 | 10.437 ns | 0.0160 ns | 0.0150 ns | 10.439 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 3.0 |  7.897 ns | 0.0087 ns | 0.0077 ns |  7.895 ns |  0.68 |    0.00 |      - |     - |     - |         - |
                                            From_Short |        net461 | 12.673 ns | 0.0105 ns | 0.0098 ns | 12.674 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                            From_Short |        net472 | 10.348 ns | 0.0118 ns | 0.0110 ns | 10.350 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_Short_AsObject | .NET Core 2.0 | 19.252 ns | 0.0434 ns | 0.0406 ns | 19.257 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 2.2 | 14.978 ns | 0.0164 ns | 0.0145 ns | 14.976 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 3.0 | 15.505 ns | 0.0337 ns | 0.0316 ns | 15.498 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net461 | 19.441 ns | 0.0308 ns | 0.0288 ns | 19.446 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net472 | 21.095 ns | 0.0240 ns | 0.0201 ns | 21.098 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Short_Nullable_WithValue | .NET Core 2.0 | 11.909 ns | 0.0116 ns | 0.0090 ns | 11.908 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 2.2 | 10.237 ns | 0.0143 ns | 0.0126 ns | 10.241 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 3.0 |  7.406 ns | 0.0182 ns | 0.0161 ns |  7.403 ns |  0.62 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net461 | 13.101 ns | 0.0422 ns | 0.0395 ns | 13.116 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net472 | 11.391 ns | 0.1257 ns | 0.1176 ns | 11.370 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.261 ns | 0.0225 ns | 0.0211 ns | 18.261 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.445 ns | 0.0239 ns | 0.0212 ns | 15.440 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.445 ns | 0.1745 ns | 0.1633 ns | 15.478 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net461 | 19.456 ns | 0.0641 ns | 0.0599 ns | 19.445 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net472 | 21.511 ns | 0.0340 ns | 0.0318 ns | 21.495 ns |  1.18 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Short_Nullable_NoValue | .NET Core 2.0 | 11.735 ns | 0.0066 ns | 0.0059 ns | 11.736 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 2.2 | 10.069 ns | 0.0123 ns | 0.0115 ns | 10.070 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 3.0 |  7.168 ns | 0.0117 ns | 0.0109 ns |  7.168 ns |  0.61 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net461 | 12.453 ns | 0.0645 ns | 0.0603 ns | 12.476 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net472 | 10.419 ns | 0.0124 ns | 0.0116 ns | 10.416 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.119 ns | 0.0201 ns | 0.0179 ns | 14.112 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.022 ns | 0.0069 ns | 0.0064 ns | 12.022 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.873 ns | 0.2607 ns | 0.2677 ns | 12.015 ns |  0.84 |    0.02 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net461 | 13.507 ns | 0.0124 ns | 0.0110 ns | 13.504 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net472 | 15.471 ns | 0.0886 ns | 0.0829 ns | 15.504 ns |  1.10 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                              From_Int | .NET Core 2.0 | 11.828 ns | 0.0110 ns | 0.0097 ns | 11.828 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 2.2 | 10.132 ns | 0.0079 ns | 0.0066 ns | 10.131 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 3.0 |  6.557 ns | 0.0172 ns | 0.0152 ns |  6.558 ns |  0.55 |    0.00 |      - |     - |     - |         - |
                                              From_Int |        net461 | 11.979 ns | 0.0156 ns | 0.0146 ns | 11.978 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                              From_Int |        net472 | 10.361 ns | 0.0101 ns | 0.0089 ns | 10.362 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_Int_AsObject | .NET Core 2.0 | 19.187 ns | 0.0792 ns | 0.0702 ns | 19.168 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 2.2 | 15.813 ns | 0.0597 ns | 0.0530 ns | 15.824 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 3.0 | 15.346 ns | 0.0342 ns | 0.0303 ns | 15.341 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net461 | 19.096 ns | 0.0230 ns | 0.0204 ns | 19.096 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net472 | 21.010 ns | 0.0531 ns | 0.0470 ns | 21.015 ns |  1.10 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Int_Nullable_WithValue | .NET Core 2.0 | 11.902 ns | 0.0115 ns | 0.0096 ns | 11.901 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 2.2 | 10.230 ns | 0.0093 ns | 0.0087 ns | 10.230 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 3.0 |  7.942 ns | 0.0401 ns | 0.0376 ns |  7.959 ns |  0.67 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net461 | 12.127 ns | 0.0148 ns | 0.0138 ns | 12.128 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net472 | 10.661 ns | 0.0102 ns | 0.0091 ns | 10.664 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.212 ns | 0.0384 ns | 0.0340 ns | 19.207 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.010 ns | 0.0260 ns | 0.0217 ns | 15.010 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.794 ns | 0.0631 ns | 0.0590 ns | 15.812 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net461 | 18.913 ns | 0.0393 ns | 0.0349 ns | 18.913 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net472 | 21.123 ns | 0.0224 ns | 0.0198 ns | 21.117 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_Int_Nullable_NoValue | .NET Core 2.0 | 11.784 ns | 0.0143 ns | 0.0126 ns | 11.782 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 2.2 | 10.063 ns | 0.0087 ns | 0.0082 ns | 10.064 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 3.0 |  7.247 ns | 0.1001 ns | 0.0936 ns |  7.192 ns |  0.62 |    0.01 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net461 | 12.471 ns | 0.0544 ns | 0.0509 ns | 12.445 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net472 | 10.468 ns | 0.0160 ns | 0.0142 ns | 10.466 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.346 ns | 0.0584 ns | 0.0546 ns | 15.362 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.827 ns | 0.0091 ns | 0.0085 ns | 12.827 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.044 ns | 0.0121 ns | 0.0101 ns | 12.044 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net461 | 13.602 ns | 0.0113 ns | 0.0105 ns | 13.606 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net472 | 15.893 ns | 0.0236 ns | 0.0209 ns | 15.891 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Long | .NET Core 2.0 | 11.708 ns | 0.0157 ns | 0.0146 ns | 11.709 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Long | .NET Core 2.2 | 10.188 ns | 0.0256 ns | 0.0239 ns | 10.183 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                             From_Long | .NET Core 3.0 |  7.275 ns | 0.1723 ns | 0.2631 ns |  7.410 ns |  0.61 |    0.03 |      - |     - |     - |         - |
                                             From_Long |        net461 | 11.967 ns | 0.0085 ns | 0.0079 ns | 11.963 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                             From_Long |        net472 | 11.813 ns | 0.0411 ns | 0.0364 ns | 11.826 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Long_AsObject | .NET Core 2.0 | 17.888 ns | 0.0228 ns | 0.0213 ns | 17.880 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 2.2 | 15.195 ns | 0.0154 ns | 0.0136 ns | 15.190 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 3.0 | 15.425 ns | 0.0882 ns | 0.0825 ns | 15.477 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net461 | 18.947 ns | 0.0279 ns | 0.0261 ns | 18.944 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net472 | 20.648 ns | 0.0298 ns | 0.0278 ns | 20.645 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Long_Nullable_WithValue | .NET Core 2.0 | 13.013 ns | 0.0140 ns | 0.0131 ns | 13.013 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 2.2 | 12.273 ns | 0.0209 ns | 0.0196 ns | 12.271 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 3.0 |  8.129 ns | 0.0117 ns | 0.0104 ns |  8.129 ns |  0.62 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net461 | 14.450 ns | 0.0232 ns | 0.0217 ns | 14.439 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net472 | 14.555 ns | 0.0274 ns | 0.0243 ns | 14.556 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.111 ns | 0.0597 ns | 0.0558 ns | 19.106 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.483 ns | 0.0910 ns | 0.0760 ns | 17.511 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 3.0 | 16.065 ns | 0.2981 ns | 0.2788 ns | 16.148 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net461 | 19.182 ns | 0.0279 ns | 0.0261 ns | 19.175 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net472 | 21.407 ns | 0.0299 ns | 0.0279 ns | 21.401 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Long_Nullable_NoValue | .NET Core 2.0 | 12.875 ns | 0.0260 ns | 0.0217 ns | 12.871 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 2.2 | 11.609 ns | 0.0080 ns | 0.0075 ns | 11.612 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 3.0 |  8.092 ns | 0.1005 ns | 0.0940 ns |  8.141 ns |  0.63 |    0.01 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net461 | 14.315 ns | 0.0770 ns | 0.0720 ns | 14.331 ns |  1.11 |    0.01 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net472 | 13.543 ns | 0.0183 ns | 0.0162 ns | 13.547 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.085 ns | 0.0219 ns | 0.0205 ns | 15.085 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.032 ns | 0.0179 ns | 0.0158 ns | 12.028 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.252 ns | 0.2803 ns | 0.3644 ns | 13.025 ns |  0.89 |    0.03 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net461 | 13.575 ns | 0.0225 ns | 0.0199 ns | 13.576 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net472 | 15.417 ns | 0.0379 ns | 0.0336 ns | 15.425 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_SByte | .NET Core 2.0 | 11.683 ns | 0.0109 ns | 0.0097 ns | 11.681 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 2.2 | 10.163 ns | 0.0140 ns | 0.0124 ns | 10.162 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 3.0 |  6.605 ns | 0.0357 ns | 0.0334 ns |  6.611 ns |  0.57 |    0.00 |      - |     - |     - |         - |
                                            From_SByte |        net461 | 11.973 ns | 0.0184 ns | 0.0163 ns | 11.971 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                            From_SByte |        net472 | 10.364 ns | 0.0169 ns | 0.0158 ns | 10.365 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_SByte_AsObject | .NET Core 2.0 | 19.102 ns | 0.0299 ns | 0.0280 ns | 19.098 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 2.2 | 15.635 ns | 0.0174 ns | 0.0163 ns | 15.626 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 3.0 | 15.945 ns | 0.1637 ns | 0.1531 ns | 15.854 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net461 | 19.083 ns | 0.0617 ns | 0.0547 ns | 19.096 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net472 | 20.589 ns | 0.0221 ns | 0.0207 ns | 20.591 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_SByte_Nullable_WithValue | .NET Core 2.0 | 11.917 ns | 0.0202 ns | 0.0189 ns | 11.917 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 2.2 | 10.368 ns | 0.0314 ns | 0.0294 ns | 10.372 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 3.0 |  7.657 ns | 0.0172 ns | 0.0152 ns |  7.659 ns |  0.64 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net461 | 12.375 ns | 0.0151 ns | 0.0134 ns | 12.375 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net472 | 10.794 ns | 0.0158 ns | 0.0148 ns | 10.797 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.809 ns | 0.0231 ns | 0.0216 ns | 18.806 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.308 ns | 0.0224 ns | 0.0199 ns | 17.309 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.465 ns | 0.2008 ns | 0.1878 ns | 15.577 ns |  0.82 |    0.01 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net461 | 18.926 ns | 0.0265 ns | 0.0248 ns | 18.919 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net472 | 21.184 ns | 0.0614 ns | 0.0545 ns | 21.198 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_SByte_Nullable_NoValue | .NET Core 2.0 | 11.727 ns | 0.0186 ns | 0.0155 ns | 11.726 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 2.2 | 10.608 ns | 0.2313 ns | 0.2271 ns | 10.526 ns |  0.90 |    0.02 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 3.0 |  7.161 ns | 0.0166 ns | 0.0130 ns |  7.164 ns |  0.61 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net461 | 11.764 ns | 0.0210 ns | 0.0197 ns | 11.762 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net472 | 12.079 ns | 0.0417 ns | 0.0369 ns | 12.087 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.0 | 16.338 ns | 0.0126 ns | 0.0112 ns | 16.337 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.016 ns | 0.0083 ns | 0.0073 ns | 12.016 ns |  0.74 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.599 ns | 0.2607 ns | 0.2438 ns | 12.715 ns |  0.77 |    0.02 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net461 | 13.592 ns | 0.0180 ns | 0.0168 ns | 13.597 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net472 | 15.326 ns | 0.0336 ns | 0.0314 ns | 15.314 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_Float | .NET Core 2.0 | 11.651 ns | 0.0115 ns | 0.0107 ns | 11.651 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 2.2 | 10.046 ns | 0.0168 ns | 0.0149 ns | 10.041 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 3.0 |  6.934 ns | 0.0235 ns | 0.0209 ns |  6.939 ns |  0.60 |    0.00 |      - |     - |     - |         - |
                                            From_Float |        net461 | 10.444 ns | 0.0350 ns | 0.0327 ns | 10.449 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                            From_Float |        net472 | 10.414 ns | 0.0132 ns | 0.0117 ns | 10.416 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_Float_AsObject | .NET Core 2.0 | 14.542 ns | 0.0137 ns | 0.0121 ns | 14.543 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 2.2 | 12.934 ns | 0.0390 ns | 0.0365 ns | 12.945 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 3.0 | 12.127 ns | 0.2665 ns | 0.2851 ns | 11.943 ns |  0.84 |    0.02 |      - |     - |     - |         - |
                                   From_Float_AsObject |        net461 | 14.272 ns | 0.0255 ns | 0.0239 ns | 14.276 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject |        net472 | 16.014 ns | 0.0184 ns | 0.0163 ns | 16.012 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Float_Nullable_WithValue | .NET Core 2.0 | 11.873 ns | 0.0109 ns | 0.0097 ns | 11.872 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 2.2 | 10.249 ns | 0.0131 ns | 0.0122 ns | 10.255 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 3.0 |  6.912 ns | 0.0231 ns | 0.0216 ns |  6.907 ns |  0.58 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net461 | 10.648 ns | 0.0143 ns | 0.0127 ns | 10.645 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net472 | 12.110 ns | 0.0231 ns | 0.0205 ns | 12.108 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.0 | 14.667 ns | 0.0074 ns | 0.0065 ns | 14.669 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.2 | 12.657 ns | 0.0347 ns | 0.0307 ns | 12.664 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 3.0 | 12.575 ns | 0.0308 ns | 0.0288 ns | 12.562 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net461 | 14.247 ns | 0.0403 ns | 0.0377 ns | 14.236 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net472 | 16.030 ns | 0.0255 ns | 0.0239 ns | 16.031 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Float_Nullable_NoValue | .NET Core 2.0 | 11.746 ns | 0.0126 ns | 0.0112 ns | 11.746 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 2.2 | 10.064 ns | 0.0141 ns | 0.0110 ns | 10.060 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 3.0 |  6.720 ns | 0.0245 ns | 0.0229 ns |  6.723 ns |  0.57 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net461 | 10.426 ns | 0.0098 ns | 0.0087 ns | 10.426 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net472 | 10.467 ns | 0.0262 ns | 0.0245 ns | 10.464 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.658 ns | 0.0322 ns | 0.0286 ns | 14.656 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.023 ns | 0.0120 ns | 0.0100 ns | 12.022 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.256 ns | 0.0344 ns | 0.0321 ns | 12.261 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net461 | 13.643 ns | 0.0340 ns | 0.0302 ns | 13.649 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net472 | 16.011 ns | 0.0763 ns | 0.0676 ns | 16.034 ns |  1.09 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_String | .NET Core 2.0 | 70.908 ns | 0.1505 ns | 0.1334 ns | 70.902 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 2.2 | 70.457 ns | 0.1475 ns | 0.1379 ns | 70.467 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 3.0 | 57.698 ns | 0.4512 ns | 0.4220 ns | 57.602 ns |  0.81 |    0.01 |      - |     - |     - |         - |
                                           From_String |        net461 | 72.097 ns | 0.1035 ns | 0.0917 ns | 72.090 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                           From_String |        net472 | 74.458 ns | 0.1185 ns | 0.1050 ns | 74.445 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_String_AsObject | .NET Core 2.0 | 77.756 ns | 0.5395 ns | 0.5046 ns | 77.491 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 2.2 | 80.489 ns | 0.1255 ns | 0.1113 ns | 80.457 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 3.0 | 61.766 ns | 0.0830 ns | 0.0735 ns | 61.770 ns |  0.79 |    0.01 |      - |     - |     - |         - |
                                  From_String_AsObject |        net461 | 77.464 ns | 0.0768 ns | 0.0681 ns | 77.483 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                                  From_String_AsObject |        net472 | 80.158 ns | 0.1052 ns | 0.0933 ns | 80.145 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                      From_String_Null | .NET Core 2.0 | 13.190 ns | 0.0126 ns | 0.0118 ns | 13.187 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 2.2 | 11.546 ns | 0.0143 ns | 0.0127 ns | 11.544 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 3.0 | 12.040 ns | 0.2671 ns | 0.2623 ns | 11.851 ns |  0.91 |    0.02 |      - |     - |     - |         - |
                                      From_String_Null |        net461 | 12.725 ns | 0.0152 ns | 0.0142 ns | 12.725 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null |        net472 | 15.825 ns | 0.0168 ns | 0.0149 ns | 15.826 ns |  1.20 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_String_Null_AsObject | .NET Core 2.0 | 14.137 ns | 0.0189 ns | 0.0167 ns | 14.133 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 2.2 | 12.021 ns | 0.0195 ns | 0.0163 ns | 12.017 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 3.0 | 12.912 ns | 0.2786 ns | 0.4655 ns | 13.150 ns |  0.89 |    0.04 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net461 | 15.915 ns | 0.0194 ns | 0.0172 ns | 15.916 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net472 | 15.912 ns | 0.0254 ns | 0.0212 ns | 15.909 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_String_Empty | .NET Core 2.0 | 13.696 ns | 0.0178 ns | 0.0166 ns | 13.694 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 2.2 | 12.965 ns | 0.0383 ns | 0.0339 ns | 12.972 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 3.0 | 11.665 ns | 0.0198 ns | 0.0186 ns | 11.666 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty |        net461 | 12.934 ns | 0.0201 ns | 0.0188 ns | 12.932 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty |        net472 | 15.451 ns | 0.0858 ns | 0.0802 ns | 15.495 ns |  1.13 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_String_Empty_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_UShort | .NET Core 2.0 | 11.705 ns | 0.0109 ns | 0.0097 ns | 11.704 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 2.2 | 10.722 ns | 0.0162 ns | 0.0143 ns | 10.718 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 3.0 |  6.581 ns | 0.0207 ns | 0.0194 ns |  6.575 ns |  0.56 |    0.00 |      - |     - |     - |         - |
                                           From_UShort |        net461 | 12.661 ns | 0.0252 ns | 0.0236 ns | 12.658 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                           From_UShort |        net472 | 11.747 ns | 0.0136 ns | 0.0127 ns | 11.746 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_UShort_AsObject | .NET Core 2.0 | 18.059 ns | 0.0567 ns | 0.0530 ns | 18.050 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 2.2 | 15.678 ns | 0.0163 ns | 0.0153 ns | 15.674 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 3.0 | 15.169 ns | 0.0627 ns | 0.0587 ns | 15.151 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net461 | 18.874 ns | 0.0260 ns | 0.0203 ns | 18.873 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net472 | 21.175 ns | 0.0669 ns | 0.0626 ns | 21.192 ns |  1.17 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_UShort_Nullable_WithValue | .NET Core 2.0 | 11.936 ns | 0.0119 ns | 0.0093 ns | 11.937 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 2.2 | 12.957 ns | 0.0249 ns | 0.0221 ns | 12.949 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 3.0 |  7.555 ns | 0.0192 ns | 0.0180 ns |  7.553 ns |  0.63 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net461 | 12.399 ns | 0.0790 ns | 0.0739 ns | 12.417 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net472 | 10.798 ns | 0.0183 ns | 0.0162 ns | 10.798 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.641 ns | 0.0717 ns | 0.0670 ns | 19.654 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.249 ns | 0.0610 ns | 0.0570 ns | 17.258 ns |  0.88 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.463 ns | 0.0320 ns | 0.0284 ns | 15.456 ns |  0.79 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net461 | 21.318 ns | 0.0373 ns | 0.0349 ns | 21.324 ns |  1.09 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net472 | 21.641 ns | 0.0889 ns | 0.0832 ns | 21.670 ns |  1.10 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_UShort_Nullable_NoValue | .NET Core 2.0 | 11.735 ns | 0.0239 ns | 0.0224 ns | 11.730 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 2.2 | 10.051 ns | 0.0122 ns | 0.0108 ns | 10.054 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 3.0 |  7.325 ns | 0.1783 ns | 0.2829 ns |  7.175 ns |  0.64 |    0.03 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net461 | 11.736 ns | 0.0857 ns | 0.0801 ns | 11.681 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net472 | 10.409 ns | 0.0109 ns | 0.0085 ns | 10.408 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.185 ns | 0.0859 ns | 0.0804 ns | 14.126 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.964 ns | 0.0161 ns | 0.0143 ns | 12.965 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.713 ns | 0.4388 ns | 0.6432 ns | 12.356 ns |  0.92 |    0.06 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net461 | 15.967 ns | 0.0189 ns | 0.0158 ns | 15.965 ns |  1.13 |    0.01 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net472 | 15.978 ns | 0.0809 ns | 0.0757 ns | 16.009 ns |  1.13 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_UInt | .NET Core 2.0 | 11.670 ns | 0.0153 ns | 0.0143 ns | 11.670 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 2.2 | 10.697 ns | 0.0158 ns | 0.0148 ns | 10.695 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 3.0 |  7.984 ns | 0.0141 ns | 0.0132 ns |  7.987 ns |  0.68 |    0.00 |      - |     - |     - |         - |
                                             From_UInt |        net461 | 12.734 ns | 0.0233 ns | 0.0206 ns | 12.727 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                             From_UInt |        net472 | 10.364 ns | 0.0126 ns | 0.0112 ns | 10.362 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_UInt_AsObject | .NET Core 2.0 | 18.181 ns | 0.0300 ns | 0.0266 ns | 18.182 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 2.2 | 15.137 ns | 0.0269 ns | 0.0252 ns | 15.132 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 3.0 | 15.357 ns | 0.0295 ns | 0.0276 ns | 15.363 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net461 | 19.179 ns | 0.0261 ns | 0.0231 ns | 19.176 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net472 | 21.318 ns | 0.0242 ns | 0.0202 ns | 21.316 ns |  1.17 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_UInt_Nullable_WithValue | .NET Core 2.0 | 12.026 ns | 0.0271 ns | 0.0253 ns | 12.019 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 2.2 | 10.594 ns | 0.0154 ns | 0.0121 ns | 10.594 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 3.0 |  8.641 ns | 0.1952 ns | 0.2922 ns |  8.716 ns |  0.71 |    0.03 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net461 | 13.188 ns | 0.0266 ns | 0.0235 ns | 13.191 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net472 | 10.906 ns | 0.0212 ns | 0.0199 ns | 10.909 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.066 ns | 0.0267 ns | 0.0250 ns | 19.065 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.2 | 18.260 ns | 0.0238 ns | 0.0199 ns | 18.260 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.336 ns | 0.0307 ns | 0.0287 ns | 15.328 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net461 | 19.136 ns | 0.0346 ns | 0.0324 ns | 19.125 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net472 | 20.843 ns | 0.0333 ns | 0.0295 ns | 20.838 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_UInt_Nullable_NoValue | .NET Core 2.0 | 11.781 ns | 0.0700 ns | 0.0655 ns | 11.741 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 2.2 | 10.067 ns | 0.0135 ns | 0.0126 ns | 10.063 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 3.0 |  6.714 ns | 0.0384 ns | 0.0300 ns |  6.707 ns |  0.57 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net461 | 11.747 ns | 0.0084 ns | 0.0075 ns | 11.747 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net472 | 10.520 ns | 0.0622 ns | 0.0581 ns | 10.539 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.116 ns | 0.0149 ns | 0.0140 ns | 14.116 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.879 ns | 0.0201 ns | 0.0188 ns | 12.877 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.368 ns | 0.0230 ns | 0.0215 ns | 14.364 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net461 | 13.636 ns | 0.0746 ns | 0.0698 ns | 13.636 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net472 | 15.293 ns | 0.0149 ns | 0.0132 ns | 15.291 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_ULong | .NET Core 2.0 | 11.823 ns | 0.0784 ns | 0.0734 ns | 11.786 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 2.2 | 10.351 ns | 0.0153 ns | 0.0144 ns | 10.353 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 3.0 |  7.263 ns | 0.0186 ns | 0.0174 ns |  7.265 ns |  0.61 |    0.00 |      - |     - |     - |         - |
                                            From_ULong |        net461 | 12.942 ns | 0.0202 ns | 0.0179 ns | 12.938 ns |  1.09 |    0.01 |      - |     - |     - |         - |
                                            From_ULong |        net472 | 10.491 ns | 0.0166 ns | 0.0155 ns | 10.486 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_ULong_AsObject | .NET Core 2.0 | 19.619 ns | 0.0447 ns | 0.0418 ns | 19.622 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 2.2 | 15.196 ns | 0.0293 ns | 0.0274 ns | 15.188 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 3.0 | 15.411 ns | 0.0434 ns | 0.0406 ns | 15.413 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net461 | 19.623 ns | 0.0399 ns | 0.0354 ns | 19.614 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net472 | 21.278 ns | 0.0344 ns | 0.0305 ns | 21.275 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_ULong_Nullable_WithValue | .NET Core 2.0 | 13.118 ns | 0.0166 ns | 0.0147 ns | 13.124 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 2.2 | 11.834 ns | 0.0138 ns | 0.0122 ns | 11.836 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 3.0 |  8.208 ns | 0.0128 ns | 0.0113 ns |  8.209 ns |  0.63 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net461 | 15.023 ns | 0.0669 ns | 0.0593 ns | 15.041 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net472 | 13.293 ns | 0.0104 ns | 0.0087 ns | 13.292 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.208 ns | 0.0971 ns | 0.0908 ns | 19.170 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.2 | 18.716 ns | 0.0700 ns | 0.0655 ns | 18.699 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.689 ns | 0.0949 ns | 0.0888 ns | 15.688 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net461 | 19.587 ns | 0.0398 ns | 0.0353 ns | 19.581 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net472 | 21.440 ns | 0.0839 ns | 0.0744 ns | 21.465 ns |  1.12 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_ULong_Nullable_NoValue | .NET Core 2.0 | 12.815 ns | 0.0180 ns | 0.0160 ns | 12.818 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 2.2 | 11.614 ns | 0.0166 ns | 0.0147 ns | 11.615 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 3.0 |  8.340 ns | 0.1316 ns | 0.1231 ns |  8.436 ns |  0.65 |    0.01 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net461 | 13.619 ns | 0.0912 ns | 0.0853 ns | 13.636 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net472 | 12.895 ns | 0.0214 ns | 0.0179 ns | 12.896 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.713 ns | 0.0179 ns | 0.0158 ns | 15.712 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.331 ns | 0.0125 ns | 0.0098 ns | 12.330 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.069 ns | 0.1255 ns | 0.1174 ns | 13.113 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net461 | 13.579 ns | 0.0293 ns | 0.0260 ns | 13.576 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net472 | 15.303 ns | 0.0291 ns | 0.0243 ns | 15.308 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                       From_NullObject | .NET Core 2.0 | 14.023 ns | 0.0894 ns | 0.0836 ns | 13.971 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 2.2 | 12.014 ns | 0.0106 ns | 0.0089 ns | 12.017 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 3.0 | 13.009 ns | 0.0128 ns | 0.0107 ns | 13.011 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                                       From_NullObject |        net461 | 13.565 ns | 0.0280 ns | 0.0262 ns | 13.574 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                                       From_NullObject |        net472 | 15.864 ns | 0.0130 ns | 0.0122 ns | 15.865 ns |  1.13 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_DBNull | .NET Core 2.0 | 11.092 ns | 0.0109 ns | 0.0102 ns | 11.090 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 2.2 |  9.093 ns | 0.0128 ns | 0.0120 ns |  9.094 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 3.0 | 11.724 ns | 0.7111 ns | 0.8466 ns | 11.265 ns |  1.07 |    0.09 |      - |     - |     - |         - |
                                           From_DBNull |        net461 | 11.035 ns | 0.0166 ns | 0.0155 ns | 11.036 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull |        net472 | 11.226 ns | 0.0199 ns | 0.0186 ns | 11.224 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_DBNull_AsObject | .NET Core 2.0 | 15.193 ns | 0.0631 ns | 0.0559 ns | 15.207 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 2.2 | 13.071 ns | 0.0171 ns | 0.0152 ns | 13.072 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 3.0 | 12.288 ns | 0.3115 ns | 0.3199 ns | 12.171 ns |  0.81 |    0.02 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net461 | 13.522 ns | 0.0157 ns | 0.0139 ns | 13.522 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net472 | 15.909 ns | 0.0191 ns | 0.0169 ns | 15.911 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                 From_ConvertibleClass | .NET Core 2.0 | 15.245 ns | 0.0158 ns | 0.0148 ns | 15.244 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 2.2 | 13.557 ns | 0.0240 ns | 0.0213 ns | 13.557 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 3.0 | 13.921 ns | 0.3002 ns | 0.4493 ns | 13.811 ns |  0.93 |    0.02 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net461 | 16.835 ns | 0.0268 ns | 0.0251 ns | 16.836 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net472 | 18.194 ns | 0.0219 ns | 0.0194 ns | 18.196 ns |  1.19 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_ConvertibleClass_AsObject | .NET Core 2.0 | 17.494 ns | 0.0261 ns | 0.0244 ns | 17.505 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 2.2 | 15.473 ns | 0.0144 ns | 0.0135 ns | 15.469 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 3.0 | 15.272 ns | 0.0294 ns | 0.0261 ns | 15.277 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net461 | 19.383 ns | 0.0259 ns | 0.0230 ns | 19.379 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net472 | 19.189 ns | 0.0769 ns | 0.0719 ns | 19.209 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_ConvertibleClass_NoValue | .NET Core 2.0 | 13.430 ns | 0.0226 ns | 0.0201 ns | 13.430 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 2.2 | 13.548 ns | 0.0197 ns | 0.0174 ns | 13.547 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 3.0 | 12.751 ns | 0.0444 ns | 0.0394 ns | 12.758 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net461 | 13.267 ns | 0.0281 ns | 0.0262 ns | 13.263 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net472 | 14.943 ns | 0.0133 ns | 0.0118 ns | 14.945 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.0 | 16.424 ns | 0.0223 ns | 0.0198 ns | 16.422 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.2 | 12.768 ns | 0.0108 ns | 0.0096 ns | 12.769 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 3.0 | 13.111 ns | 0.2846 ns | 0.3701 ns | 12.881 ns |  0.81 |    0.03 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net461 | 13.610 ns | 0.0352 ns | 0.0329 ns | 13.615 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net472 | 15.302 ns | 0.0367 ns | 0.0343 ns | 15.300 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                              From_NonConvertibleClass | .NET Core 2.0 | 11.839 ns | 0.0218 ns | 0.0170 ns | 11.837 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 2.2 | 11.147 ns | 0.0091 ns | 0.0085 ns | 11.145 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 3.0 | 11.470 ns | 0.8788 ns | 1.2881 ns | 10.803 ns |  1.05 |    0.13 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net461 | 12.288 ns | 0.0119 ns | 0.0105 ns | 12.286 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net472 | 12.577 ns | 0.0601 ns | 0.0562 ns | 12.615 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                     From_NonConvertibleClass_AsObject | .NET Core 2.0 | 15.960 ns | 0.0160 ns | 0.0142 ns | 15.959 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 2.2 | 13.979 ns | 0.0131 ns | 0.0116 ns | 13.976 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 3.0 | 13.357 ns | 0.2888 ns | 0.3653 ns | 13.622 ns |  0.83 |    0.02 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net461 | 17.480 ns | 0.0250 ns | 0.0234 ns | 17.474 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net472 | 16.979 ns | 0.0207 ns | 0.0184 ns | 16.980 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                      From_NonConvertibleClass_NoValue | .NET Core 2.0 | 11.935 ns | 0.0331 ns | 0.0310 ns | 11.939 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 2.2 | 11.203 ns | 0.0833 ns | 0.0779 ns | 11.154 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 3.0 | 11.087 ns | 0.0343 ns | 0.0320 ns | 11.093 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net461 | 12.499 ns | 0.0164 ns | 0.0145 ns | 12.495 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net472 | 12.727 ns | 0.0194 ns | 0.0172 ns | 12.723 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.0 | 14.096 ns | 0.0094 ns | 0.0083 ns | 14.096 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.2 | 12.019 ns | 0.0092 ns | 0.0081 ns | 12.016 ns |  0.85 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 3.0 | 12.804 ns | 0.2678 ns | 0.2750 ns | 12.958 ns |  0.91 |    0.02 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net461 | 13.539 ns | 0.0251 ns | 0.0235 ns | 13.545 ns |  0.96 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net472 | 15.419 ns | 0.0233 ns | 0.0195 ns | 15.411 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                From_ConvertibleStruct | .NET Core 2.0 | 19.361 ns | 0.1285 ns | 0.1202 ns | 19.304 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 2.2 | 20.608 ns | 0.5358 ns | 1.5545 ns | 20.422 ns |  1.06 |    0.09 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 3.0 | 12.015 ns | 0.0535 ns | 0.0501 ns | 12.027 ns |  0.62 |    0.01 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net461 | 19.772 ns | 0.0626 ns | 0.0555 ns | 19.770 ns |  1.02 |    0.01 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net472 | 18.722 ns | 0.0653 ns | 0.0611 ns | 18.735 ns |  0.97 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                       From_ConvertibleStruct_AsObject | .NET Core 2.0 | 17.222 ns | 0.0269 ns | 0.0251 ns | 17.230 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 2.2 | 14.741 ns | 0.0137 ns | 0.0107 ns | 14.745 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 3.0 | 16.927 ns | 0.0285 ns | 0.0267 ns | 16.932 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net461 | 17.924 ns | 0.0329 ns | 0.0291 ns | 17.925 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net472 | 19.723 ns | 0.0167 ns | 0.0148 ns | 19.722 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.0 | 19.159 ns | 0.0298 ns | 0.0265 ns | 19.158 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.2 | 16.034 ns | 0.0499 ns | 0.0467 ns | 16.044 ns |  0.84 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 3.0 | 13.358 ns | 0.0394 ns | 0.0349 ns | 13.356 ns |  0.70 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net461 | 20.901 ns | 0.0381 ns | 0.0357 ns | 20.910 ns |  1.09 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net472 | 18.237 ns | 0.0744 ns | 0.0659 ns | 18.218 ns |  0.95 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.200 ns | 0.0785 ns | 0.0696 ns | 18.218 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 14.896 ns | 0.0491 ns | 0.0459 ns | 14.904 ns |  0.82 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.563 ns | 0.1461 ns | 0.1366 ns | 15.607 ns |  0.86 |    0.01 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net461 | 20.137 ns | 0.0429 ns | 0.0401 ns | 20.151 ns |  1.11 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net472 | 19.972 ns | 0.0237 ns | 0.0221 ns | 19.975 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.0 | 13.225 ns | 0.0178 ns | 0.0157 ns | 13.228 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.2 | 11.762 ns | 0.0195 ns | 0.0183 ns | 11.762 ns |  0.89 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 3.0 |  7.517 ns | 0.0168 ns | 0.0157 ns |  7.513 ns |  0.57 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net461 | 12.799 ns | 0.0165 ns | 0.0146 ns | 12.800 ns |  0.97 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net472 | 12.389 ns | 0.0130 ns | 0.0115 ns | 12.387 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.117 ns | 0.0777 ns | 0.0727 ns | 15.100 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.019 ns | 0.0118 ns | 0.0105 ns | 12.015 ns |  0.79 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.279 ns | 0.2125 ns | 0.1988 ns | 12.403 ns |  0.81 |    0.01 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net461 | 13.802 ns | 0.0124 ns | 0.0116 ns | 13.802 ns |  0.91 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net472 | 15.408 ns | 0.0442 ns | 0.0413 ns | 15.397 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_NonConvertibleStruct | .NET Core 2.0 | 13.120 ns | 0.0208 ns | 0.0185 ns | 13.114 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 2.2 | 10.094 ns | 0.0121 ns | 0.0114 ns | 10.094 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 3.0 |  6.852 ns | 0.0113 ns | 0.0106 ns |  6.849 ns |  0.52 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net461 | 12.480 ns | 0.0239 ns | 0.0223 ns | 12.479 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net472 | 10.548 ns | 0.0119 ns | 0.0111 ns | 10.547 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.0 | 15.782 ns | 0.0299 ns | 0.0265 ns | 15.773 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.2 | 13.376 ns | 0.0084 ns | 0.0078 ns | 13.380 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 3.0 | 14.274 ns | 0.0242 ns | 0.0226 ns | 14.271 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net461 | 15.164 ns | 0.0335 ns | 0.0313 ns | 15.153 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net472 | 16.855 ns | 0.0418 ns | 0.0370 ns | 16.847 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.0 | 13.267 ns | 0.0124 ns | 0.0110 ns | 13.269 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.2 | 10.090 ns | 0.0192 ns | 0.0161 ns | 10.087 ns |  0.76 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 3.0 |  6.874 ns | 0.0338 ns | 0.0316 ns |  6.878 ns |  0.52 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net461 | 12.474 ns | 0.0116 ns | 0.0108 ns | 12.475 ns |  0.94 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net472 | 10.670 ns | 0.0134 ns | 0.0125 ns | 10.669 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 16.091 ns | 0.0279 ns | 0.0261 ns | 16.088 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 14.193 ns | 0.0557 ns | 0.0493 ns | 14.205 ns |  0.88 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 14.938 ns | 0.3219 ns | 0.6279 ns | 15.235 ns |  0.89 |    0.05 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net461 | 17.338 ns | 0.0354 ns | 0.0276 ns | 17.340 ns |  1.08 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net472 | 17.331 ns | 0.0211 ns | 0.0187 ns | 17.330 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.0 | 12.978 ns | 0.0117 ns | 0.0092 ns | 12.977 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.2 | 10.081 ns | 0.0107 ns | 0.0100 ns | 10.084 ns |  0.78 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 3.0 |  6.912 ns | 0.0202 ns | 0.0179 ns |  6.909 ns |  0.53 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net461 | 12.486 ns | 0.0128 ns | 0.0113 ns | 12.485 ns |  0.96 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net472 | 11.701 ns | 0.0122 ns | 0.0109 ns | 11.702 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.113 ns | 0.0727 ns | 0.0680 ns | 15.084 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.023 ns | 0.0127 ns | 0.0113 ns | 12.022 ns |  0.80 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.857 ns | 0.2541 ns | 0.2926 ns | 12.014 ns |  0.78 |    0.02 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net461 | 13.513 ns | 0.0249 ns | 0.0220 ns | 13.504 ns |  0.89 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net472 | 15.358 ns | 0.0191 ns | 0.0178 ns | 15.356 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Enum | .NET Core 2.0 | 13.017 ns | 0.0153 ns | 0.0128 ns | 13.017 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 2.2 | 10.096 ns | 0.0081 ns | 0.0072 ns | 10.095 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 3.0 |  6.971 ns | 0.0264 ns | 0.0247 ns |  6.975 ns |  0.54 |    0.00 |      - |     - |     - |         - |
                                             From_Enum |        net461 | 11.825 ns | 0.0649 ns | 0.0607 ns | 11.859 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                             From_Enum |        net472 | 10.385 ns | 0.0138 ns | 0.0122 ns | 10.382 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Enum_AsObject | .NET Core 2.0 | 47.643 ns | 0.0296 ns | 0.0247 ns | 47.643 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject | .NET Core 2.2 | 40.682 ns | 0.0632 ns | 0.0560 ns | 40.697 ns |  0.85 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject | .NET Core 3.0 | 37.613 ns | 0.2239 ns | 0.2095 ns | 37.651 ns |  0.79 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject |        net461 | 42.493 ns | 0.0539 ns | 0.0504 ns | 42.471 ns |  0.89 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject |        net472 | 44.834 ns | 0.3032 ns | 0.2836 ns | 44.696 ns |  0.94 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Enum_Nullable_WithValue | .NET Core 2.0 | 13.391 ns | 0.0174 ns | 0.0163 ns | 13.392 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 2.2 | 11.743 ns | 0.0362 ns | 0.0338 ns | 11.752 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 3.0 |  7.545 ns | 0.7826 ns | 0.9316 ns |  7.032 ns |  0.58 |    0.08 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net461 | 13.131 ns | 0.0306 ns | 0.0271 ns | 13.138 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net472 | 12.281 ns | 0.0170 ns | 0.0142 ns | 12.276 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.0 | 45.059 ns | 0.0617 ns | 0.0547 ns | 45.063 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.2 | 44.345 ns | 0.0784 ns | 0.0695 ns | 44.345 ns |  0.98 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 3.0 | 34.017 ns | 0.0871 ns | 0.0815 ns | 34.020 ns |  0.75 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject |        net461 | 42.667 ns | 0.0580 ns | 0.0514 ns | 42.653 ns |  0.95 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject |        net472 | 44.968 ns | 0.0469 ns | 0.0439 ns | 44.967 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Enum_Nullable_NoValue | .NET Core 2.0 | 13.942 ns | 0.0161 ns | 0.0135 ns | 13.940 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 2.2 | 10.510 ns | 0.0151 ns | 0.0126 ns | 10.507 ns |  0.75 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 3.0 |  7.651 ns | 0.0117 ns | 0.0092 ns |  7.647 ns |  0.55 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net461 | 12.644 ns | 0.0115 ns | 0.0108 ns | 12.646 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net472 | 10.430 ns | 0.0082 ns | 0.0073 ns | 10.430 ns |  0.75 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.073 ns | 0.0239 ns | 0.0224 ns | 15.075 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.009 ns | 0.0095 ns | 0.0089 ns | 12.006 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.176 ns | 0.0636 ns | 0.0595 ns | 12.179 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net461 | 13.644 ns | 0.0200 ns | 0.0187 ns | 13.642 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net472 | 15.509 ns | 0.0248 ns | 0.0232 ns | 15.508 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                      From_ParentClass | .NET Core 2.0 | 12.137 ns | 0.0144 ns | 0.0128 ns | 12.137 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 2.2 | 11.923 ns | 0.0172 ns | 0.0153 ns | 11.919 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 3.0 | 13.715 ns | 0.2922 ns | 0.3001 ns | 13.854 ns |  1.13 |    0.03 |      - |     - |     - |         - |
                                      From_ParentClass |        net461 | 13.321 ns | 0.0394 ns | 0.0368 ns | 13.303 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass |        net472 | 12.614 ns | 0.0207 ns | 0.0183 ns | 12.616 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_ParentClass_AsObject | .NET Core 2.0 | 17.389 ns | 0.1367 ns | 0.1212 ns | 17.429 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 2.2 | 15.289 ns | 0.0185 ns | 0.0173 ns | 15.292 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 3.0 | 13.867 ns | 0.0264 ns | 0.0220 ns | 13.863 ns |  0.80 |    0.01 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net461 | 15.433 ns | 0.0243 ns | 0.0227 ns | 15.436 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net472 | 16.965 ns | 0.0225 ns | 0.0188 ns | 16.957 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                              From_ParentClass_NoValue | .NET Core 2.0 | 11.818 ns | 0.0150 ns | 0.0133 ns | 11.823 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 2.2 | 11.146 ns | 0.0068 ns | 0.0064 ns | 11.146 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 3.0 | 11.277 ns | 0.0086 ns | 0.0080 ns | 11.278 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net461 | 12.307 ns | 0.0192 ns | 0.0171 ns | 12.303 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net472 | 12.527 ns | 0.0160 ns | 0.0150 ns | 12.527 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.0 | 16.951 ns | 0.0861 ns | 0.0806 ns | 16.902 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.2 | 12.104 ns | 0.0615 ns | 0.0575 ns | 12.116 ns |  0.71 |    0.01 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 3.0 | 12.993 ns | 0.0112 ns | 0.0099 ns | 12.991 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net461 | 13.561 ns | 0.0200 ns | 0.0177 ns | 13.554 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net472 | 15.349 ns | 0.0251 ns | 0.0222 ns | 15.350 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_ParentStruct | .NET Core 2.0 | 38.843 ns | 0.0486 ns | 0.0455 ns | 38.844 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 2.2 | 36.280 ns | 0.0377 ns | 0.0353 ns | 36.277 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 3.0 | 36.836 ns | 0.7462 ns | 0.7985 ns | 36.376 ns |  0.94 |    0.02 |      - |     - |     - |         - |
                                     From_ParentStruct |        net461 | 39.496 ns | 0.0688 ns | 0.0643 ns | 39.511 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct |        net472 | 38.515 ns | 0.0281 ns | 0.0262 ns | 38.512 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_ParentStruct_AsObject | .NET Core 2.0 | 17.393 ns | 0.0709 ns | 0.0628 ns | 17.412 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 2.2 | 15.205 ns | 0.0175 ns | 0.0155 ns | 15.200 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 3.0 | 14.046 ns | 0.2750 ns | 0.2572 ns | 14.265 ns |  0.81 |    0.02 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net461 | 17.598 ns | 0.0204 ns | 0.0181 ns | 17.591 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net472 | 16.991 ns | 0.0282 ns | 0.0250 ns | 16.990 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.0 | 42.741 ns | 0.0507 ns | 0.0450 ns | 42.743 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.2 | 37.991 ns | 0.0544 ns | 0.0483 ns | 37.995 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 3.0 | 34.479 ns | 0.1608 ns | 0.1426 ns | 34.493 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue |        net461 | 41.969 ns | 0.3114 ns | 0.2913 ns | 42.066 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue |        net472 | 39.133 ns | 0.0752 ns | 0.0703 ns | 39.126 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 15.763 ns | 0.0152 ns | 0.0142 ns | 15.762 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 13.611 ns | 0.0103 ns | 0.0096 ns | 13.611 ns |  0.86 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 14.870 ns | 0.2771 ns | 0.2592 ns | 15.009 ns |  0.94 |    0.02 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net461 | 15.558 ns | 0.0221 ns | 0.0196 ns | 15.561 ns |  0.99 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net472 | 18.318 ns | 0.0471 ns | 0.0441 ns | 18.302 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.0 | 39.605 ns | 0.0340 ns | 0.0318 ns | 39.618 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.2 | 38.047 ns | 0.0464 ns | 0.0411 ns | 38.053 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 3.0 | 34.551 ns | 0.0988 ns | 0.0825 ns | 34.540 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net461 | 40.800 ns | 0.0624 ns | 0.0584 ns | 40.805 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net472 | 38.780 ns | 0.0521 ns | 0.0488 ns | 38.785 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.090 ns | 0.0108 ns | 0.0090 ns | 14.089 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.699 ns | 0.0125 ns | 0.0117 ns | 12.698 ns |  0.90 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.201 ns | 0.0357 ns | 0.0334 ns | 12.206 ns |  0.87 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net461 | 13.546 ns | 0.0208 ns | 0.0195 ns | 13.547 ns |  0.96 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net472 | 15.694 ns | 0.1316 ns | 0.1231 ns | 15.677 ns |  1.11 |    0.01 |      - |     - |     - |         - |

Benchmarks with issues:
  ConvertTo_Float.From_Char_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_Float.From_Char_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_Float.From_Char_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_Float.From_Char_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_Float.From_Char_AsObject: Job-ZVTGBZ(Toolchain=net472)
  ConvertTo_Float.From_Char_Nullable_WithValue_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_Float.From_Char_Nullable_WithValue_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_Float.From_Char_Nullable_WithValue_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_Float.From_Char_Nullable_WithValue_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_Float.From_Char_Nullable_WithValue_AsObject: Job-ZVTGBZ(Toolchain=net472)
  ConvertTo_Float.From_DateTime_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_Float.From_DateTime_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_Float.From_DateTime_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_Float.From_DateTime_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_Float.From_DateTime_AsObject: Job-ZVTGBZ(Toolchain=net472)
  ConvertTo_Float.From_DateTime_Nullable_WithValue_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_Float.From_DateTime_Nullable_WithValue_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_Float.From_DateTime_Nullable_WithValue_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_Float.From_DateTime_Nullable_WithValue_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_Float.From_DateTime_Nullable_WithValue_AsObject: Job-ZVTGBZ(Toolchain=net472)
  ConvertTo_Float.From_String_Empty_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_Float.From_String_Empty_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_Float.From_String_Empty_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_Float.From_String_Empty_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_Float.From_String_Empty_AsObject: Job-ZVTGBZ(Toolchain=net472)
