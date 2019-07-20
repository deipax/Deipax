
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
                                             From_Bool | .NET Core 2.0 | 21.009 ns | 0.0355 ns | 0.0277 ns | 21.003 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 2.2 | 19.142 ns | 0.0242 ns | 0.0226 ns | 19.142 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 3.0 | 16.168 ns | 0.0172 ns | 0.0144 ns | 16.174 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                                             From_Bool |        net461 | 21.037 ns | 0.0185 ns | 0.0173 ns | 21.040 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Bool |        net472 | 19.618 ns | 0.0200 ns | 0.0167 ns | 19.619 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Bool_AsObject | .NET Core 2.0 | 27.193 ns | 0.0265 ns | 0.0248 ns | 27.198 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 2.2 | 25.124 ns | 0.0314 ns | 0.0262 ns | 25.128 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 3.0 | 24.308 ns | 0.0309 ns | 0.0258 ns | 24.303 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net461 | 28.393 ns | 0.0358 ns | 0.0317 ns | 28.389 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net472 | 28.707 ns | 0.0536 ns | 0.0501 ns | 28.704 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Bool_Nullable_WithValue | .NET Core 2.0 | 20.984 ns | 0.0302 ns | 0.0282 ns | 20.982 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 2.2 | 18.055 ns | 0.0250 ns | 0.0209 ns | 18.055 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 3.0 | 17.020 ns | 0.1488 ns | 0.1392 ns | 17.032 ns |  0.81 |    0.01 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net461 | 20.960 ns | 0.0684 ns | 0.0640 ns | 20.978 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net472 | 20.343 ns | 0.0282 ns | 0.0235 ns | 20.344 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.0 | 27.409 ns | 0.0359 ns | 0.0318 ns | 27.410 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.2 | 25.118 ns | 0.0238 ns | 0.0223 ns | 25.110 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 3.0 | 24.507 ns | 0.0359 ns | 0.0318 ns | 24.500 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net461 | 27.010 ns | 0.0496 ns | 0.0440 ns | 27.002 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net472 | 27.916 ns | 0.0272 ns | 0.0254 ns | 27.924 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Bool_Nullable_NoValue | .NET Core 2.0 | 13.968 ns | 0.0166 ns | 0.0156 ns | 13.969 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 2.2 | 11.240 ns | 0.0203 ns | 0.0190 ns | 11.242 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 3.0 |  8.136 ns | 1.1585 ns | 1.1896 ns |  7.499 ns |  0.59 |    0.09 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net461 | 14.263 ns | 0.0185 ns | 0.0155 ns | 14.266 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net472 | 12.975 ns | 0.0117 ns | 0.0104 ns | 12.976 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.604 ns | 0.0209 ns | 0.0195 ns | 15.603 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.891 ns | 0.0156 ns | 0.0146 ns | 12.891 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.399 ns | 0.2906 ns | 0.3676 ns | 13.655 ns |  0.85 |    0.03 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net461 | 14.638 ns | 0.0145 ns | 0.0121 ns | 14.638 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net472 | 17.232 ns | 0.0152 ns | 0.0143 ns | 17.232 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Byte | .NET Core 2.0 | 21.019 ns | 0.0185 ns | 0.0164 ns | 21.016 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 2.2 | 17.790 ns | 0.0277 ns | 0.0259 ns | 17.786 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 3.0 | 16.078 ns | 0.0950 ns | 0.0889 ns | 16.107 ns |  0.76 |    0.00 |      - |     - |     - |         - |
                                             From_Byte |        net461 | 20.804 ns | 0.0230 ns | 0.0204 ns | 20.804 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                             From_Byte |        net472 | 19.393 ns | 0.0283 ns | 0.0236 ns | 19.395 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Byte_AsObject | .NET Core 2.0 | 26.975 ns | 0.0267 ns | 0.0250 ns | 26.982 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 2.2 | 25.153 ns | 0.0275 ns | 0.0229 ns | 25.146 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 3.0 | 24.060 ns | 0.0272 ns | 0.0213 ns | 24.060 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net461 | 26.974 ns | 0.0282 ns | 0.0250 ns | 26.969 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net472 | 27.928 ns | 0.0271 ns | 0.0253 ns | 27.925 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Byte_Nullable_WithValue | .NET Core 2.0 | 21.174 ns | 0.0444 ns | 0.0416 ns | 21.179 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 2.2 | 17.931 ns | 0.0188 ns | 0.0176 ns | 17.933 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 3.0 | 17.265 ns | 0.1421 ns | 0.1329 ns | 17.181 ns |  0.82 |    0.01 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net461 | 20.568 ns | 0.0304 ns | 0.0284 ns | 20.573 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net472 | 20.284 ns | 0.0276 ns | 0.0258 ns | 20.282 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.0 | 26.985 ns | 0.0356 ns | 0.0333 ns | 26.982 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.2 | 25.144 ns | 0.0274 ns | 0.0243 ns | 25.144 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 3.0 | 25.953 ns | 0.1333 ns | 0.1247 ns | 26.025 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net461 | 28.618 ns | 0.0700 ns | 0.0655 ns | 28.639 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net472 | 28.509 ns | 0.0266 ns | 0.0249 ns | 28.507 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Byte_Nullable_NoValue | .NET Core 2.0 | 14.077 ns | 0.0789 ns | 0.0738 ns | 14.117 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 2.2 | 11.829 ns | 0.0115 ns | 0.0102 ns | 11.829 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 3.0 |  7.973 ns | 0.3018 ns | 0.3593 ns |  7.769 ns |  0.57 |    0.03 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net461 | 13.672 ns | 0.0271 ns | 0.0240 ns | 13.666 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net472 | 13.070 ns | 0.0452 ns | 0.0423 ns | 13.076 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.119 ns | 0.0245 ns | 0.0229 ns | 15.114 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.894 ns | 0.0118 ns | 0.0099 ns | 12.895 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.938 ns | 0.0309 ns | 0.0289 ns | 12.927 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net461 | 15.095 ns | 0.0196 ns | 0.0183 ns | 15.088 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net472 | 16.317 ns | 0.0266 ns | 0.0236 ns | 16.312 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Char | .NET Core 2.0 | 12.765 ns | 0.0130 ns | 0.0122 ns | 12.763 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Char | .NET Core 2.2 | 10.995 ns | 0.0114 ns | 0.0107 ns | 10.998 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                             From_Char | .NET Core 3.0 |  7.167 ns | 0.0148 ns | 0.0139 ns |  7.169 ns |  0.56 |    0.00 |      - |     - |     - |         - |
                                             From_Char |        net461 | 14.695 ns | 0.0140 ns | 0.0131 ns | 14.697 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                                             From_Char |        net472 | 15.150 ns | 0.0279 ns | 0.0261 ns | 15.149 ns |  1.19 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Char_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Char_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Char_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Char_Nullable_WithValue | .NET Core 2.0 | 12.388 ns | 0.0176 ns | 0.0147 ns | 12.391 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 2.2 | 10.544 ns | 0.0213 ns | 0.0199 ns | 10.549 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 3.0 |  7.929 ns | 0.0132 ns | 0.0124 ns |  7.935 ns |  0.64 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net461 | 14.756 ns | 0.0186 ns | 0.0174 ns | 14.754 ns |  1.19 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net472 | 12.746 ns | 0.0186 ns | 0.0164 ns | 12.744 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Char_Nullable_NoValue | .NET Core 2.0 | 12.357 ns | 0.0239 ns | 0.0212 ns | 12.353 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 2.2 | 10.617 ns | 0.0575 ns | 0.0510 ns | 10.639 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 3.0 |  7.071 ns | 0.0414 ns | 0.0387 ns |  7.086 ns |  0.57 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net461 | 14.183 ns | 0.0206 ns | 0.0193 ns | 14.182 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net472 | 13.493 ns | 0.0179 ns | 0.0159 ns | 13.488 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.0 | 16.519 ns | 0.0196 ns | 0.0183 ns | 16.517 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.599 ns | 0.0163 ns | 0.0153 ns | 13.599 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.170 ns | 0.0177 ns | 0.0166 ns | 14.166 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net461 | 14.512 ns | 0.0255 ns | 0.0238 ns | 14.506 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net472 | 17.280 ns | 0.0280 ns | 0.0261 ns | 17.283 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                         From_DateTime | .NET Core 2.0 | 13.238 ns | 0.0138 ns | 0.0122 ns | 13.236 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 2.2 | 11.324 ns | 0.0097 ns | 0.0086 ns | 11.323 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 3.0 |  8.012 ns | 0.0131 ns | 0.0116 ns |  8.011 ns |  0.61 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime |        net461 | 14.741 ns | 0.0087 ns | 0.0082 ns | 14.742 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime |        net472 | 12.778 ns | 0.0163 ns | 0.0144 ns | 12.783 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                From_DateTime_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                      From_DateTime_Nullable_WithValue | .NET Core 2.0 | 12.785 ns | 0.0169 ns | 0.0150 ns | 12.784 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 2.2 | 11.526 ns | 0.0136 ns | 0.0121 ns | 11.527 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 3.0 |  8.916 ns | 0.1757 ns | 0.1643 ns |  8.808 ns |  0.70 |    0.01 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net461 | 15.927 ns | 0.0234 ns | 0.0219 ns | 15.925 ns |  1.25 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net472 | 13.094 ns | 0.0398 ns | 0.0372 ns | 13.098 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_DateTime_Nullable_NoValue | .NET Core 2.0 | 13.596 ns | 0.0104 ns | 0.0098 ns | 13.593 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 2.2 | 11.543 ns | 0.0408 ns | 0.0382 ns | 11.534 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 3.0 |  8.348 ns | 0.0164 ns | 0.0154 ns |  8.351 ns |  0.61 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net461 | 14.440 ns | 0.0132 ns | 0.0117 ns | 14.437 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net472 | 12.959 ns | 0.0185 ns | 0.0164 ns | 12.960 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.0 | 16.015 ns | 0.0420 ns | 0.0393 ns | 16.006 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.009 ns | 0.0122 ns | 0.0114 ns | 13.010 ns |  0.81 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.283 ns | 0.0117 ns | 0.0109 ns | 13.285 ns |  0.83 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net461 | 14.675 ns | 0.0167 ns | 0.0157 ns | 14.672 ns |  0.92 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net472 | 19.184 ns | 0.0200 ns | 0.0177 ns | 19.188 ns |  1.20 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                          From_Decimal | .NET Core 2.0 | 14.538 ns | 0.0579 ns | 0.0542 ns | 14.551 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 2.2 | 12.977 ns | 0.0114 ns | 0.0107 ns | 12.975 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 3.0 | 11.822 ns | 0.0143 ns | 0.0126 ns | 11.821 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal |        net461 | 15.304 ns | 0.0375 ns | 0.0351 ns | 15.312 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal |        net472 | 15.311 ns | 0.0177 ns | 0.0165 ns | 15.309 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                 From_Decimal_AsObject | .NET Core 2.0 | 27.421 ns | 0.0327 ns | 0.0290 ns | 27.423 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 2.2 | 26.418 ns | 0.0228 ns | 0.0202 ns | 26.420 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 3.0 | 33.225 ns | 0.0521 ns | 0.0487 ns | 33.217 ns |  1.21 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net461 | 35.585 ns | 0.1280 ns | 0.1197 ns | 35.610 ns |  1.30 |    0.01 |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net472 | 35.839 ns | 0.0973 ns | 0.0910 ns | 35.876 ns |  1.31 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                       From_Decimal_Nullable_WithValue | .NET Core 2.0 | 12.700 ns | 0.0116 ns | 0.0109 ns | 12.697 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 2.2 | 11.578 ns | 0.0105 ns | 0.0093 ns | 11.576 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 3.0 |  9.180 ns | 0.2100 ns | 0.3269 ns |  9.329 ns |  0.71 |    0.03 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net461 | 14.199 ns | 0.0228 ns | 0.0202 ns | 14.193 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net472 | 14.097 ns | 0.0179 ns | 0.0159 ns | 14.094 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.0 | 26.584 ns | 0.0309 ns | 0.0289 ns | 26.581 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.2 | 26.409 ns | 0.0338 ns | 0.0282 ns | 26.412 ns |  0.99 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 3.0 | 34.023 ns | 0.0481 ns | 0.0427 ns | 34.013 ns |  1.28 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net461 | 33.552 ns | 0.0447 ns | 0.0419 ns | 33.550 ns |  1.26 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net472 | 36.267 ns | 0.1005 ns | 0.0839 ns | 36.291 ns |  1.36 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Decimal_Nullable_NoValue | .NET Core 2.0 | 12.735 ns | 0.0533 ns | 0.0473 ns | 12.720 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 2.2 | 11.650 ns | 0.0561 ns | 0.0525 ns | 11.678 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 3.0 |  8.677 ns | 0.2703 ns | 0.3218 ns |  8.500 ns |  0.69 |    0.03 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net461 | 14.249 ns | 0.0220 ns | 0.0206 ns | 14.245 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net472 | 14.094 ns | 0.0215 ns | 0.0191 ns | 14.096 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.999 ns | 0.0337 ns | 0.0281 ns | 15.989 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.897 ns | 0.0094 ns | 0.0078 ns | 12.898 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.910 ns | 0.0241 ns | 0.0225 ns | 12.904 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net461 | 17.205 ns | 0.0243 ns | 0.0203 ns | 17.206 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net472 | 16.998 ns | 0.0326 ns | 0.0305 ns | 16.987 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_Double | .NET Core 2.0 | 69.490 ns | 0.0568 ns | 0.0532 ns | 69.483 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 2.2 | 64.804 ns | 0.0682 ns | 0.0604 ns | 64.802 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 3.0 | 22.568 ns | 0.1260 ns | 0.1178 ns | 22.646 ns |  0.32 |    0.00 |      - |     - |     - |         - |
                                           From_Double |        net461 | 69.360 ns | 0.2744 ns | 0.2567 ns | 69.367 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_Double |        net472 | 69.956 ns | 0.1162 ns | 0.0907 ns | 69.970 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_Double_AsObject | .NET Core 2.0 | 77.005 ns | 0.0862 ns | 0.0764 ns | 77.010 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 2.2 | 74.808 ns | 0.0738 ns | 0.0690 ns | 74.806 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 3.0 | 32.997 ns | 0.0390 ns | 0.0326 ns | 32.996 ns |  0.43 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject |        net461 | 76.958 ns | 0.1118 ns | 0.0934 ns | 76.988 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject |        net472 | 77.834 ns | 0.0868 ns | 0.0725 ns | 77.848 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_Double_Nullable_WithValue | .NET Core 2.0 | 69.816 ns | 0.0791 ns | 0.0701 ns | 69.801 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 2.2 | 65.393 ns | 0.0614 ns | 0.0544 ns | 65.388 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 3.0 | 22.526 ns | 0.1410 ns | 0.1319 ns | 22.545 ns |  0.32 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net461 | 69.399 ns | 0.4226 ns | 0.3953 ns | 69.168 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net472 | 68.755 ns | 0.0645 ns | 0.0539 ns | 68.756 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.0 | 77.708 ns | 0.2445 ns | 0.2287 ns | 77.751 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.2 | 75.289 ns | 0.3529 ns | 0.3301 ns | 75.425 ns |  0.97 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 3.0 | 33.482 ns | 0.1091 ns | 0.0967 ns | 33.513 ns |  0.43 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net461 | 77.804 ns | 0.0827 ns | 0.0774 ns | 77.810 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net472 | 78.683 ns | 0.2043 ns | 0.1811 ns | 78.720 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Double_Nullable_NoValue | .NET Core 2.0 | 14.044 ns | 0.0132 ns | 0.0123 ns | 14.045 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 2.2 | 11.523 ns | 0.0110 ns | 0.0102 ns | 11.523 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 3.0 |  9.005 ns | 0.2013 ns | 0.2397 ns |  9.097 ns |  0.64 |    0.02 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net461 | 14.557 ns | 0.0180 ns | 0.0168 ns | 14.558 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net472 | 14.137 ns | 0.0191 ns | 0.0178 ns | 14.134 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.0 | 16.003 ns | 0.0153 ns | 0.0135 ns | 16.005 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.928 ns | 0.0356 ns | 0.0316 ns | 12.913 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.957 ns | 0.0075 ns | 0.0062 ns | 12.958 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net461 | 15.269 ns | 0.0190 ns | 0.0159 ns | 15.270 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net472 | 17.213 ns | 0.0248 ns | 0.0219 ns | 17.213 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_Short | .NET Core 2.0 | 19.658 ns | 0.0237 ns | 0.0222 ns | 19.653 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 2.2 | 17.685 ns | 0.0831 ns | 0.0778 ns | 17.715 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 3.0 | 16.646 ns | 0.0314 ns | 0.0245 ns | 16.641 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                            From_Short |        net461 | 20.881 ns | 0.0253 ns | 0.0236 ns | 20.878 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                            From_Short |        net472 | 19.417 ns | 0.0331 ns | 0.0310 ns | 19.425 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_Short_AsObject | .NET Core 2.0 | 26.963 ns | 0.0295 ns | 0.0262 ns | 26.962 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 2.2 | 24.681 ns | 0.0311 ns | 0.0291 ns | 24.679 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 3.0 | 24.144 ns | 0.1332 ns | 0.1246 ns | 24.062 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net461 | 28.360 ns | 0.0164 ns | 0.0137 ns | 28.354 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net472 | 27.670 ns | 0.0280 ns | 0.0249 ns | 27.667 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Short_Nullable_WithValue | .NET Core 2.0 | 21.160 ns | 0.0186 ns | 0.0174 ns | 21.161 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 2.2 | 18.054 ns | 0.0220 ns | 0.0206 ns | 18.056 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 3.0 | 16.781 ns | 0.0329 ns | 0.0307 ns | 16.783 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net461 | 21.609 ns | 0.0356 ns | 0.0333 ns | 21.598 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net472 | 20.547 ns | 0.0263 ns | 0.0246 ns | 20.541 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.0 | 27.682 ns | 0.0352 ns | 0.0294 ns | 27.675 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.2 | 24.672 ns | 0.0261 ns | 0.0232 ns | 24.667 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 3.0 | 24.298 ns | 0.0344 ns | 0.0322 ns | 24.302 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net461 | 26.990 ns | 0.0344 ns | 0.0287 ns | 26.991 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net472 | 27.679 ns | 0.0196 ns | 0.0183 ns | 27.681 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Short_Nullable_NoValue | .NET Core 2.0 | 13.597 ns | 0.0158 ns | 0.0140 ns | 13.592 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 2.2 | 11.997 ns | 0.0169 ns | 0.0150 ns | 11.995 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 3.0 |  7.658 ns | 0.0244 ns | 0.0228 ns |  7.653 ns |  0.56 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net461 | 14.308 ns | 0.1167 ns | 0.1092 ns | 14.252 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net472 | 14.252 ns | 0.0474 ns | 0.0444 ns | 14.263 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.100 ns | 0.0186 ns | 0.0165 ns | 15.096 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.267 ns | 0.0073 ns | 0.0068 ns | 13.265 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.191 ns | 0.0205 ns | 0.0192 ns | 14.191 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net461 | 14.636 ns | 0.0139 ns | 0.0130 ns | 14.636 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net472 | 17.813 ns | 0.0268 ns | 0.0251 ns | 17.811 ns |  1.18 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                              From_Int | .NET Core 2.0 | 20.756 ns | 0.0153 ns | 0.0143 ns | 20.759 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 2.2 | 17.720 ns | 0.0184 ns | 0.0163 ns | 17.716 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 3.0 | 16.257 ns | 0.1311 ns | 0.1226 ns | 16.179 ns |  0.78 |    0.01 |      - |     - |     - |         - |
                                              From_Int |        net461 | 20.999 ns | 0.0224 ns | 0.0187 ns | 21.005 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                              From_Int |        net472 | 19.402 ns | 0.0186 ns | 0.0165 ns | 19.405 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_Int_AsObject | .NET Core 2.0 | 27.506 ns | 0.0292 ns | 0.0273 ns | 27.504 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 2.2 | 24.901 ns | 0.0762 ns | 0.0675 ns | 24.910 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 3.0 | 26.067 ns | 0.1138 ns | 0.1064 ns | 26.103 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net461 | 28.700 ns | 0.0304 ns | 0.0284 ns | 28.705 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net472 | 27.896 ns | 0.0255 ns | 0.0226 ns | 27.898 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Int_Nullable_WithValue | .NET Core 2.0 | 21.000 ns | 0.0094 ns | 0.0088 ns | 21.003 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 2.2 | 17.791 ns | 0.0219 ns | 0.0205 ns | 17.787 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 3.0 | 16.409 ns | 0.0200 ns | 0.0187 ns | 16.406 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net461 | 21.956 ns | 0.0196 ns | 0.0174 ns | 21.954 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net472 | 20.269 ns | 0.0210 ns | 0.0186 ns | 20.267 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.0 | 27.461 ns | 0.0393 ns | 0.0307 ns | 27.461 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.2 | 24.702 ns | 0.0186 ns | 0.0174 ns | 24.701 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 3.0 | 24.455 ns | 0.1232 ns | 0.1152 ns | 24.502 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net461 | 27.033 ns | 0.1757 ns | 0.1644 ns | 26.966 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net472 | 27.674 ns | 0.0282 ns | 0.0250 ns | 27.673 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_Int_Nullable_NoValue | .NET Core 2.0 | 13.824 ns | 0.0351 ns | 0.0328 ns | 13.810 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 2.2 | 10.981 ns | 0.0092 ns | 0.0082 ns | 10.981 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 3.0 |  7.460 ns | 0.0276 ns | 0.0258 ns |  7.458 ns |  0.54 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net461 | 14.237 ns | 0.0192 ns | 0.0179 ns | 14.234 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net472 | 14.557 ns | 0.0561 ns | 0.0525 ns | 14.532 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.0 | 16.111 ns | 0.0178 ns | 0.0166 ns | 16.111 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.780 ns | 0.0098 ns | 0.0087 ns | 13.779 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.380 ns | 0.2645 ns | 0.2598 ns | 12.513 ns |  0.77 |    0.02 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net461 | 14.854 ns | 0.0169 ns | 0.0158 ns | 14.851 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net472 | 17.252 ns | 0.0181 ns | 0.0160 ns | 17.251 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Long | .NET Core 2.0 | 19.644 ns | 0.0169 ns | 0.0158 ns | 19.642 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Long | .NET Core 2.2 | 17.897 ns | 0.0791 ns | 0.0740 ns | 17.925 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                             From_Long | .NET Core 3.0 | 16.309 ns | 0.1268 ns | 0.1186 ns | 16.369 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                                             From_Long |        net461 | 20.543 ns | 0.0488 ns | 0.0457 ns | 20.548 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                             From_Long |        net472 | 20.398 ns | 0.1208 ns | 0.1130 ns | 20.335 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Long_AsObject | .NET Core 2.0 | 27.461 ns | 0.0388 ns | 0.0363 ns | 27.465 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 2.2 | 25.122 ns | 0.0223 ns | 0.0208 ns | 25.129 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 3.0 | 24.082 ns | 0.0341 ns | 0.0285 ns | 24.086 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net461 | 27.174 ns | 0.0195 ns | 0.0183 ns | 27.169 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net472 | 27.892 ns | 0.0330 ns | 0.0309 ns | 27.889 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Long_Nullable_WithValue | .NET Core 2.0 | 21.685 ns | 0.0197 ns | 0.0184 ns | 21.684 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 2.2 | 18.516 ns | 0.0187 ns | 0.0175 ns | 18.512 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 3.0 | 17.725 ns | 0.0775 ns | 0.0725 ns | 17.777 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net461 | 22.169 ns | 0.0318 ns | 0.0297 ns | 22.182 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net472 | 21.041 ns | 0.0190 ns | 0.0178 ns | 21.037 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.0 | 27.665 ns | 0.0279 ns | 0.0247 ns | 27.666 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.2 | 25.091 ns | 0.0819 ns | 0.0766 ns | 25.118 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 3.0 | 24.287 ns | 0.0214 ns | 0.0190 ns | 24.284 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net461 | 27.203 ns | 0.0260 ns | 0.0243 ns | 27.203 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net472 | 27.905 ns | 0.0224 ns | 0.0210 ns | 27.905 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Long_Nullable_NoValue | .NET Core 2.0 | 15.232 ns | 0.0129 ns | 0.0108 ns | 15.233 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 2.2 | 11.558 ns | 0.0180 ns | 0.0140 ns | 11.554 ns |  0.76 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 3.0 |  8.493 ns | 0.0119 ns | 0.0106 ns |  8.492 ns |  0.56 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net461 | 14.586 ns | 0.0216 ns | 0.0191 ns | 14.588 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net472 | 13.353 ns | 0.0929 ns | 0.0869 ns | 13.325 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.0 | 17.097 ns | 0.0231 ns | 0.0216 ns | 17.095 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.915 ns | 0.0143 ns | 0.0133 ns | 12.921 ns |  0.76 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.962 ns | 0.0213 ns | 0.0199 ns | 14.960 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net461 | 15.046 ns | 0.0188 ns | 0.0176 ns | 15.045 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net472 | 16.913 ns | 0.0189 ns | 0.0168 ns | 16.912 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_SByte | .NET Core 2.0 | 21.051 ns | 0.0346 ns | 0.0323 ns | 21.050 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 2.2 | 17.779 ns | 0.0406 ns | 0.0380 ns | 17.770 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 3.0 | 16.771 ns | 0.0592 ns | 0.0554 ns | 16.798 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                            From_SByte |        net461 | 20.099 ns | 0.0174 ns | 0.0155 ns | 20.100 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                            From_SByte |        net472 | 19.631 ns | 0.0266 ns | 0.0208 ns | 19.628 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_SByte_AsObject | .NET Core 2.0 | 27.197 ns | 0.1373 ns | 0.1217 ns | 27.253 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 2.2 | 25.384 ns | 0.0379 ns | 0.0355 ns | 25.383 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 3.0 | 24.421 ns | 0.1255 ns | 0.1174 ns | 24.483 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net461 | 27.216 ns | 0.0778 ns | 0.0727 ns | 27.242 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net472 | 27.659 ns | 0.0374 ns | 0.0331 ns | 27.658 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_SByte_Nullable_WithValue | .NET Core 2.0 | 20.984 ns | 0.0160 ns | 0.0142 ns | 20.986 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 2.2 | 17.917 ns | 0.0899 ns | 0.0841 ns | 17.950 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 3.0 | 17.211 ns | 0.1157 ns | 0.1083 ns | 17.148 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net461 | 31.372 ns | 0.0379 ns | 0.0354 ns | 31.368 ns |  1.50 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net472 | 20.882 ns | 0.0262 ns | 0.0219 ns | 20.877 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.0 | 27.706 ns | 0.0189 ns | 0.0177 ns | 27.705 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.2 | 24.901 ns | 0.0234 ns | 0.0207 ns | 24.899 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 3.0 | 24.354 ns | 0.0315 ns | 0.0295 ns | 24.353 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net461 | 27.194 ns | 0.0241 ns | 0.0201 ns | 27.199 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net472 | 28.170 ns | 0.0175 ns | 0.0156 ns | 28.175 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_SByte_Nullable_NoValue | .NET Core 2.0 | 13.944 ns | 0.0123 ns | 0.0115 ns | 13.945 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 2.2 | 11.518 ns | 0.1451 ns | 0.1358 ns | 11.472 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 3.0 |  7.281 ns | 0.0083 ns | 0.0074 ns |  7.281 ns |  0.52 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net461 | 14.998 ns | 0.0234 ns | 0.0208 ns | 14.998 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net472 | 13.604 ns | 0.0296 ns | 0.0231 ns | 13.604 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.102 ns | 0.0184 ns | 0.0172 ns | 15.098 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.900 ns | 0.0079 ns | 0.0074 ns | 12.899 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.982 ns | 0.0540 ns | 0.0451 ns | 12.968 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net461 | 17.596 ns | 0.0221 ns | 0.0207 ns | 17.589 ns |  1.17 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net472 | 16.798 ns | 0.0210 ns | 0.0196 ns | 16.800 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_Float | .NET Core 2.0 | 40.733 ns | 0.2186 ns | 0.2045 ns | 40.840 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 2.2 | 35.156 ns | 0.0366 ns | 0.0343 ns | 35.149 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 3.0 | 20.867 ns | 0.1265 ns | 0.1184 ns | 20.802 ns |  0.51 |    0.00 |      - |     - |     - |         - |
                                            From_Float |        net461 | 38.727 ns | 0.2383 ns | 0.2229 ns | 38.614 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                                            From_Float |        net472 | 37.981 ns | 0.0390 ns | 0.0326 ns | 37.975 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_Float_AsObject | .NET Core 2.0 | 46.441 ns | 0.1189 ns | 0.1112 ns | 46.467 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 2.2 | 44.476 ns | 0.0713 ns | 0.0595 ns | 44.490 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 3.0 | 30.045 ns | 0.0566 ns | 0.0529 ns | 30.025 ns |  0.65 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject |        net461 | 45.654 ns | 0.0681 ns | 0.0637 ns | 45.668 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject |        net472 | 47.147 ns | 0.1169 ns | 0.1094 ns | 47.140 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Float_Nullable_WithValue | .NET Core 2.0 | 39.926 ns | 0.2131 ns | 0.1994 ns | 40.030 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 2.2 | 34.576 ns | 0.0222 ns | 0.0173 ns | 34.571 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 3.0 | 21.026 ns | 0.1588 ns | 0.1485 ns | 21.000 ns |  0.53 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net461 | 39.255 ns | 0.0777 ns | 0.0727 ns | 39.266 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net472 | 38.564 ns | 0.0482 ns | 0.0427 ns | 38.555 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.0 | 46.283 ns | 0.0808 ns | 0.0716 ns | 46.300 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.2 | 44.524 ns | 0.0935 ns | 0.0874 ns | 44.533 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 3.0 | 32.297 ns | 0.1060 ns | 0.0939 ns | 32.343 ns |  0.70 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net461 | 46.114 ns | 0.1328 ns | 0.1242 ns | 46.153 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net472 | 46.552 ns | 0.1125 ns | 0.1052 ns | 46.583 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Float_Nullable_NoValue | .NET Core 2.0 | 13.760 ns | 0.0158 ns | 0.0140 ns | 13.759 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 2.2 | 10.762 ns | 0.0105 ns | 0.0098 ns | 10.763 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 3.0 |  9.547 ns | 0.2151 ns | 0.4721 ns |  9.704 ns |  0.66 |    0.06 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net461 | 13.645 ns | 0.0198 ns | 0.0185 ns | 13.646 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net472 | 13.599 ns | 0.0168 ns | 0.0157 ns | 13.597 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.465 ns | 0.0159 ns | 0.0149 ns | 15.462 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.597 ns | 0.0227 ns | 0.0212 ns | 13.593 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.328 ns | 0.2927 ns | 0.3595 ns | 13.366 ns |  0.85 |    0.02 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net461 | 14.661 ns | 0.0763 ns | 0.0714 ns | 14.622 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net472 | 16.310 ns | 0.0407 ns | 0.0380 ns | 16.296 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_String | .NET Core 2.0 | 86.328 ns | 0.3995 ns | 0.3737 ns | 86.147 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 2.2 | 76.025 ns | 0.0904 ns | 0.0846 ns | 76.030 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 3.0 | 58.830 ns | 0.1076 ns | 0.1007 ns | 58.821 ns |  0.68 |    0.00 |      - |     - |     - |         - |
                                           From_String |        net461 | 86.391 ns | 0.1076 ns | 0.1007 ns | 86.415 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_String |        net472 | 87.144 ns | 0.0895 ns | 0.0747 ns | 87.124 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_String_AsObject | .NET Core 2.0 | 93.807 ns | 0.1329 ns | 0.1243 ns | 93.770 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 2.2 | 84.896 ns | 0.0755 ns | 0.0706 ns | 84.887 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 3.0 | 64.799 ns | 0.0590 ns | 0.0523 ns | 64.805 ns |  0.69 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject |        net461 | 94.513 ns | 0.5738 ns | 0.5367 ns | 94.149 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                  From_String_AsObject |        net472 | 94.455 ns | 0.0817 ns | 0.0724 ns | 94.454 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                      From_String_Null | .NET Core 2.0 | 14.291 ns | 0.0126 ns | 0.0118 ns | 14.288 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 2.2 | 11.893 ns | 0.0153 ns | 0.0136 ns | 11.896 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 3.0 | 12.221 ns | 0.2757 ns | 0.2831 ns | 12.070 ns |  0.86 |    0.02 |      - |     - |     - |         - |
                                      From_String_Null |        net461 | 15.144 ns | 0.0171 ns | 0.0151 ns | 15.142 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null |        net472 | 17.310 ns | 0.0248 ns | 0.0232 ns | 17.314 ns |  1.21 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_String_Null_AsObject | .NET Core 2.0 | 16.145 ns | 0.0726 ns | 0.0644 ns | 16.168 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 2.2 | 13.981 ns | 0.0146 ns | 0.0114 ns | 13.980 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 3.0 | 13.383 ns | 0.0868 ns | 0.0812 ns | 13.422 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net461 | 15.354 ns | 0.0203 ns | 0.0180 ns | 15.353 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net472 | 16.510 ns | 0.0218 ns | 0.0204 ns | 16.507 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_String_Empty | .NET Core 2.0 | 13.454 ns | 0.0149 ns | 0.0132 ns | 13.457 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 2.2 | 12.710 ns | 0.0124 ns | 0.0116 ns | 12.709 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 3.0 | 12.059 ns | 0.0506 ns | 0.0473 ns | 12.039 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty |        net461 | 14.341 ns | 0.0171 ns | 0.0160 ns | 14.341 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty |        net472 | 17.233 ns | 0.0267 ns | 0.0208 ns | 17.228 ns |  1.28 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_String_Empty_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_UShort | .NET Core 2.0 | 20.931 ns | 0.0707 ns | 0.0661 ns | 20.947 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 2.2 | 17.540 ns | 0.0227 ns | 0.0201 ns | 17.541 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 3.0 | 16.424 ns | 0.0225 ns | 0.0210 ns | 16.420 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                                           From_UShort |        net461 | 20.272 ns | 0.1378 ns | 0.1289 ns | 20.179 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                                           From_UShort |        net472 | 19.394 ns | 0.0123 ns | 0.0103 ns | 19.393 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_UShort_AsObject | .NET Core 2.0 | 27.450 ns | 0.0265 ns | 0.0248 ns | 27.451 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 2.2 | 25.393 ns | 0.0277 ns | 0.0259 ns | 25.395 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 3.0 | 24.144 ns | 0.1101 ns | 0.1030 ns | 24.090 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net461 | 26.966 ns | 0.0178 ns | 0.0166 ns | 26.969 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net472 | 28.596 ns | 0.0269 ns | 0.0251 ns | 28.591 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_UShort_Nullable_WithValue | .NET Core 2.0 | 21.028 ns | 0.0163 ns | 0.0153 ns | 21.032 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 2.2 | 18.188 ns | 0.0281 ns | 0.0263 ns | 18.188 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 3.0 | 17.267 ns | 0.1605 ns | 0.1502 ns | 17.334 ns |  0.82 |    0.01 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net461 | 20.564 ns | 0.0265 ns | 0.0235 ns | 20.557 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net472 | 20.086 ns | 0.0181 ns | 0.0169 ns | 20.091 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.0 | 27.433 ns | 0.0206 ns | 0.0193 ns | 27.432 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.2 | 24.672 ns | 0.0226 ns | 0.0201 ns | 24.670 ns |  0.90 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 3.0 | 24.058 ns | 0.0392 ns | 0.0366 ns | 24.052 ns |  0.88 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net461 | 28.345 ns | 0.0262 ns | 0.0245 ns | 28.350 ns |  1.03 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net472 | 28.683 ns | 0.0404 ns | 0.0358 ns | 28.683 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_UShort_Nullable_NoValue | .NET Core 2.0 | 13.786 ns | 0.0064 ns | 0.0053 ns | 13.785 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 2.2 | 11.361 ns | 0.0123 ns | 0.0109 ns | 11.362 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 3.0 |  7.403 ns | 0.0221 ns | 0.0206 ns |  7.404 ns |  0.54 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net461 | 14.738 ns | 0.0209 ns | 0.0196 ns | 14.744 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net472 | 12.906 ns | 0.0625 ns | 0.0584 ns | 12.933 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.0 | 16.307 ns | 0.0205 ns | 0.0192 ns | 16.305 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.271 ns | 0.0156 ns | 0.0146 ns | 13.272 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.533 ns | 0.1014 ns | 0.0948 ns | 13.554 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net461 | 15.718 ns | 0.0415 ns | 0.0388 ns | 15.726 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net472 | 17.445 ns | 0.0254 ns | 0.0212 ns | 17.450 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_UInt | .NET Core 2.0 | 19.180 ns | 0.0188 ns | 0.0167 ns | 19.177 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 2.2 | 17.601 ns | 0.0385 ns | 0.0360 ns | 17.604 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 3.0 | 16.398 ns | 0.0310 ns | 0.0290 ns | 16.396 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                             From_UInt |        net461 | 20.790 ns | 0.0240 ns | 0.0224 ns | 20.793 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                             From_UInt |        net472 | 19.770 ns | 0.0830 ns | 0.0777 ns | 19.799 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_UInt_AsObject | .NET Core 2.0 | 26.998 ns | 0.0211 ns | 0.0187 ns | 26.994 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 2.2 | 24.869 ns | 0.0738 ns | 0.0654 ns | 24.882 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 3.0 | 25.618 ns | 0.0156 ns | 0.0146 ns | 25.617 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net461 | 27.089 ns | 0.1481 ns | 0.1385 ns | 27.025 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net472 | 27.926 ns | 0.0436 ns | 0.0408 ns | 27.916 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_UInt_Nullable_WithValue | .NET Core 2.0 | 20.971 ns | 0.0203 ns | 0.0190 ns | 20.964 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 2.2 | 17.567 ns | 0.0224 ns | 0.0210 ns | 17.566 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 3.0 | 17.216 ns | 0.0908 ns | 0.0849 ns | 17.268 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net461 | 21.222 ns | 0.0150 ns | 0.0133 ns | 21.222 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net472 | 21.323 ns | 0.1060 ns | 0.0991 ns | 21.270 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.0 | 27.424 ns | 0.0169 ns | 0.0141 ns | 27.425 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.2 | 24.656 ns | 0.0318 ns | 0.0282 ns | 24.656 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 3.0 | 24.238 ns | 0.0864 ns | 0.0766 ns | 24.258 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net461 | 27.058 ns | 0.1314 ns | 0.1229 ns | 27.007 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net472 | 27.681 ns | 0.0270 ns | 0.0253 ns | 27.682 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_UInt_Nullable_NoValue | .NET Core 2.0 | 13.606 ns | 0.0111 ns | 0.0098 ns | 13.603 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 2.2 | 11.378 ns | 0.0443 ns | 0.0415 ns | 11.365 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 3.0 |  8.081 ns | 0.1960 ns | 0.2333 ns |  7.972 ns |  0.60 |    0.02 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net461 | 13.598 ns | 0.0124 ns | 0.0110 ns | 13.601 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net472 | 13.569 ns | 0.0199 ns | 0.0177 ns | 13.572 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.982 ns | 0.0163 ns | 0.0144 ns | 15.980 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.567 ns | 0.0211 ns | 0.0187 ns | 14.563 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.463 ns | 0.1417 ns | 0.1326 ns | 13.546 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net461 | 16.645 ns | 0.0222 ns | 0.0197 ns | 16.643 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net472 | 17.246 ns | 0.0109 ns | 0.0102 ns | 17.246 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_ULong | .NET Core 2.0 | 20.764 ns | 0.0440 ns | 0.0411 ns | 20.746 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 2.2 | 17.707 ns | 0.0197 ns | 0.0175 ns | 17.707 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 3.0 | 16.332 ns | 0.1097 ns | 0.1026 ns | 16.384 ns |  0.79 |    0.01 |      - |     - |     - |         - |
                                            From_ULong |        net461 | 20.310 ns | 0.0342 ns | 0.0320 ns | 20.314 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                            From_ULong |        net472 | 20.328 ns | 0.0416 ns | 0.0369 ns | 20.325 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_ULong_AsObject | .NET Core 2.0 | 27.749 ns | 0.0330 ns | 0.0292 ns | 27.747 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 2.2 | 24.680 ns | 0.0343 ns | 0.0321 ns | 24.671 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 3.0 | 25.977 ns | 0.1268 ns | 0.1186 ns | 26.040 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net461 | 26.971 ns | 0.0483 ns | 0.0452 ns | 26.961 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net472 | 28.434 ns | 0.0231 ns | 0.0193 ns | 28.434 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_ULong_Nullable_WithValue | .NET Core 2.0 | 21.224 ns | 0.0147 ns | 0.0130 ns | 21.225 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 2.2 | 18.248 ns | 0.0254 ns | 0.0225 ns | 18.242 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 3.0 | 17.263 ns | 0.1200 ns | 0.1122 ns | 17.336 ns |  0.81 |    0.01 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net461 | 21.453 ns | 0.0322 ns | 0.0269 ns | 21.449 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net472 | 20.851 ns | 0.0212 ns | 0.0188 ns | 20.854 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.0 | 27.949 ns | 0.0282 ns | 0.0263 ns | 27.939 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.2 | 24.701 ns | 0.0280 ns | 0.0262 ns | 24.701 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 3.0 | 24.331 ns | 0.0280 ns | 0.0248 ns | 24.329 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net461 | 28.352 ns | 0.0204 ns | 0.0191 ns | 28.352 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net472 | 28.433 ns | 0.0308 ns | 0.0273 ns | 28.441 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_ULong_Nullable_NoValue | .NET Core 2.0 | 14.027 ns | 0.0118 ns | 0.0111 ns | 14.027 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 2.2 | 11.407 ns | 0.0132 ns | 0.0111 ns | 11.408 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 3.0 |  9.886 ns | 0.2225 ns | 0.4391 ns | 10.046 ns |  0.68 |    0.05 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net461 | 14.573 ns | 0.0215 ns | 0.0201 ns | 14.566 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net472 | 14.392 ns | 0.0250 ns | 0.0222 ns | 14.387 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.0 | 16.054 ns | 0.0953 ns | 0.0891 ns | 16.012 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.889 ns | 0.0092 ns | 0.0077 ns | 12.887 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 3.0 | 15.672 ns | 0.0197 ns | 0.0184 ns | 15.673 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net461 | 14.901 ns | 0.0832 ns | 0.0779 ns | 14.862 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net472 | 17.285 ns | 0.0210 ns | 0.0186 ns | 17.287 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                       From_NullObject | .NET Core 2.0 | 15.094 ns | 0.0130 ns | 0.0115 ns | 15.094 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 2.2 | 13.939 ns | 0.0154 ns | 0.0128 ns | 13.939 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 3.0 | 14.279 ns | 0.0622 ns | 0.0582 ns | 14.300 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject |        net461 | 14.902 ns | 0.0242 ns | 0.0227 ns | 14.898 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject |        net472 | 17.259 ns | 0.0162 ns | 0.0143 ns | 17.255 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_DBNull | .NET Core 2.0 | 12.582 ns | 0.0128 ns | 0.0114 ns | 12.579 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 2.2 | 11.239 ns | 0.0161 ns | 0.0143 ns | 11.239 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 3.0 | 11.026 ns | 0.0247 ns | 0.0231 ns | 11.028 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull |        net461 | 12.447 ns | 0.0132 ns | 0.0123 ns | 12.446 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull |        net472 | 12.714 ns | 0.0534 ns | 0.0499 ns | 12.699 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_DBNull_AsObject | .NET Core 2.0 | 16.177 ns | 0.0328 ns | 0.0307 ns | 16.176 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 2.2 | 13.207 ns | 0.0122 ns | 0.0114 ns | 13.208 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 3.0 | 14.497 ns | 0.0215 ns | 0.0201 ns | 14.494 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net461 | 14.706 ns | 0.0534 ns | 0.0473 ns | 14.717 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net472 | 17.880 ns | 0.0149 ns | 0.0132 ns | 17.880 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                 From_ConvertibleClass | .NET Core 2.0 | 20.936 ns | 0.0256 ns | 0.0239 ns | 20.943 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 2.2 | 17.747 ns | 0.0244 ns | 0.0204 ns | 17.740 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 3.0 | 18.255 ns | 0.3829 ns | 0.6292 ns | 18.668 ns |  0.85 |    0.03 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net461 | 20.987 ns | 0.0226 ns | 0.0211 ns | 20.988 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net472 | 21.140 ns | 0.0144 ns | 0.0134 ns | 21.139 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_ConvertibleClass_AsObject | .NET Core 2.0 | 22.184 ns | 0.0147 ns | 0.0137 ns | 22.186 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 2.2 | 19.823 ns | 0.0189 ns | 0.0167 ns | 19.824 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 3.0 | 20.573 ns | 0.0261 ns | 0.0218 ns | 20.566 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net461 | 23.405 ns | 0.0762 ns | 0.0712 ns | 23.434 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net472 | 23.075 ns | 0.0213 ns | 0.0189 ns | 23.072 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_ConvertibleClass_NoValue | .NET Core 2.0 | 14.249 ns | 0.0104 ns | 0.0093 ns | 14.248 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 2.2 | 13.479 ns | 0.0171 ns | 0.0152 ns | 13.478 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 3.0 | 11.775 ns | 0.0786 ns | 0.0735 ns | 11.732 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net461 | 14.731 ns | 0.0209 ns | 0.0196 ns | 14.733 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net472 | 16.636 ns | 0.0225 ns | 0.0210 ns | 16.637 ns |  1.17 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.0 | 16.080 ns | 0.0955 ns | 0.0893 ns | 16.119 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.2 | 13.028 ns | 0.0573 ns | 0.0479 ns | 13.040 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 3.0 | 12.164 ns | 0.2987 ns | 0.3556 ns | 11.977 ns |  0.76 |    0.03 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net461 | 15.093 ns | 0.0178 ns | 0.0149 ns | 15.096 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net472 | 17.541 ns | 0.0192 ns | 0.0160 ns | 17.542 ns |  1.09 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                              From_NonConvertibleClass | .NET Core 2.0 | 13.200 ns | 0.0130 ns | 0.0122 ns | 13.200 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 2.2 | 11.734 ns | 0.0172 ns | 0.0153 ns | 11.730 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 3.0 | 11.729 ns | 0.0154 ns | 0.0145 ns | 11.728 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net461 | 14.068 ns | 0.0175 ns | 0.0164 ns | 14.063 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net472 | 15.255 ns | 0.0292 ns | 0.0273 ns | 15.250 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                     From_NonConvertibleClass_AsObject | .NET Core 2.0 | 21.112 ns | 0.1013 ns | 0.0948 ns | 21.087 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 2.2 | 14.275 ns | 0.0173 ns | 0.0154 ns | 14.271 ns |  0.68 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 3.0 | 16.578 ns | 0.3536 ns | 0.8403 ns | 16.903 ns |  0.73 |    0.06 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net461 | 18.977 ns | 0.0358 ns | 0.0335 ns | 18.980 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net472 | 19.029 ns | 0.0469 ns | 0.0416 ns | 19.035 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                      From_NonConvertibleClass_NoValue | .NET Core 2.0 | 13.587 ns | 0.0451 ns | 0.0422 ns | 13.588 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 2.2 | 11.727 ns | 0.0099 ns | 0.0088 ns | 11.724 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 3.0 | 11.814 ns | 0.0524 ns | 0.0490 ns | 11.830 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net461 | 14.156 ns | 0.0161 ns | 0.0151 ns | 14.152 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net472 | 15.829 ns | 0.0219 ns | 0.0194 ns | 15.828 ns |  1.17 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.0 | 15.977 ns | 0.0180 ns | 0.0168 ns | 15.973 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.2 | 14.579 ns | 0.0135 ns | 0.0120 ns | 14.580 ns |  0.91 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 3.0 | 13.528 ns | 0.2892 ns | 0.3094 ns | 13.685 ns |  0.84 |    0.02 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net461 | 15.167 ns | 0.0130 ns | 0.0122 ns | 15.168 ns |  0.95 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net472 | 16.653 ns | 0.0233 ns | 0.0218 ns | 16.650 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                From_ConvertibleStruct | .NET Core 2.0 | 24.847 ns | 0.0691 ns | 0.0646 ns | 24.857 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 2.2 | 18.833 ns | 0.0472 ns | 0.0419 ns | 18.842 ns |  0.76 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 3.0 | 16.433 ns | 0.0394 ns | 0.0369 ns | 16.431 ns |  0.66 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net461 | 22.377 ns | 0.0447 ns | 0.0373 ns | 22.364 ns |  0.90 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net472 | 22.021 ns | 0.0345 ns | 0.0306 ns | 22.022 ns |  0.89 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                       From_ConvertibleStruct_AsObject | .NET Core 2.0 | 23.045 ns | 0.0228 ns | 0.0213 ns | 23.043 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 2.2 | 20.338 ns | 0.0385 ns | 0.0360 ns | 20.346 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 3.0 | 19.949 ns | 0.1945 ns | 0.1819 ns | 20.072 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net461 | 22.396 ns | 0.0275 ns | 0.0257 ns | 22.400 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net472 | 24.331 ns | 0.0606 ns | 0.0537 ns | 24.338 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.0 | 23.556 ns | 0.1376 ns | 0.1287 ns | 23.496 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.2 | 19.309 ns | 0.0243 ns | 0.0227 ns | 19.311 ns |  0.82 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 3.0 | 16.673 ns | 0.1075 ns | 0.1006 ns | 16.692 ns |  0.71 |    0.01 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net461 | 22.951 ns | 0.0366 ns | 0.0342 ns | 22.947 ns |  0.97 |    0.01 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net472 | 24.110 ns | 0.0284 ns | 0.0266 ns | 24.110 ns |  1.02 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 23.083 ns | 0.0161 ns | 0.0143 ns | 23.085 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 20.300 ns | 0.0271 ns | 0.0226 ns | 20.306 ns |  0.88 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 21.517 ns | 0.0207 ns | 0.0194 ns | 21.516 ns |  0.93 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net461 | 22.810 ns | 0.1312 ns | 0.1227 ns | 22.876 ns |  0.99 |    0.01 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net472 | 23.177 ns | 0.0187 ns | 0.0166 ns | 23.177 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.0 | 14.039 ns | 0.0094 ns | 0.0078 ns | 14.039 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.2 | 12.032 ns | 0.0151 ns | 0.0141 ns | 12.030 ns |  0.86 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 3.0 |  9.861 ns | 0.1143 ns | 0.1069 ns |  9.786 ns |  0.70 |    0.01 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net461 | 14.121 ns | 0.0198 ns | 0.0176 ns | 14.123 ns |  1.01 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net472 | 13.209 ns | 0.0111 ns | 0.0104 ns | 13.209 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.241 ns | 0.0427 ns | 0.0400 ns | 15.248 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.893 ns | 0.0097 ns | 0.0086 ns | 12.893 ns |  0.85 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.877 ns | 0.0127 ns | 0.0113 ns | 14.876 ns |  0.98 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net461 | 15.238 ns | 0.0201 ns | 0.0168 ns | 15.243 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net472 | 18.784 ns | 0.0170 ns | 0.0159 ns | 18.785 ns |  1.23 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_NonConvertibleStruct | .NET Core 2.0 | 13.920 ns | 0.0088 ns | 0.0078 ns | 13.918 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 2.2 | 11.748 ns | 0.0141 ns | 0.0132 ns | 11.747 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 3.0 |  7.377 ns | 0.0199 ns | 0.0186 ns |  7.383 ns |  0.53 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net461 | 13.825 ns | 0.0164 ns | 0.0153 ns | 13.829 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net472 | 13.750 ns | 0.0274 ns | 0.0243 ns | 13.753 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.0 | 17.265 ns | 0.0121 ns | 0.0107 ns | 17.265 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.2 | 14.296 ns | 0.0177 ns | 0.0166 ns | 14.292 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 3.0 | 14.493 ns | 0.0275 ns | 0.0258 ns | 14.491 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net461 | 16.760 ns | 0.0247 ns | 0.0231 ns | 16.760 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net472 | 18.522 ns | 0.0218 ns | 0.0204 ns | 18.520 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.0 | 15.620 ns | 0.0132 ns | 0.0124 ns | 15.616 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.2 | 12.809 ns | 0.0109 ns | 0.0097 ns | 12.809 ns |  0.82 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 3.0 |  7.321 ns | 0.0184 ns | 0.0172 ns |  7.322 ns |  0.47 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net461 | 13.931 ns | 0.0679 ns | 0.0635 ns | 13.958 ns |  0.89 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net472 | 12.920 ns | 0.0148 ns | 0.0132 ns | 12.919 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 17.446 ns | 0.0230 ns | 0.0192 ns | 17.443 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 14.318 ns | 0.0192 ns | 0.0180 ns | 14.314 ns |  0.82 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 14.953 ns | 0.1739 ns | 0.1627 ns | 15.057 ns |  0.86 |    0.01 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net461 | 16.731 ns | 0.0235 ns | 0.0208 ns | 16.731 ns |  0.96 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net472 | 18.571 ns | 0.0425 ns | 0.0398 ns | 18.579 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.0 | 15.576 ns | 0.0161 ns | 0.0151 ns | 15.573 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.2 | 11.766 ns | 0.0126 ns | 0.0112 ns | 11.767 ns |  0.76 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 3.0 |  8.121 ns | 0.1882 ns | 0.3246 ns |  8.264 ns |  0.51 |    0.03 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net461 | 13.850 ns | 0.0101 ns | 0.0095 ns | 13.848 ns |  0.89 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net472 | 12.910 ns | 0.0139 ns | 0.0130 ns | 12.912 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.079 ns | 0.0106 ns | 0.0094 ns | 15.078 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.889 ns | 0.0134 ns | 0.0125 ns | 12.883 ns |  0.85 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.959 ns | 0.0155 ns | 0.0138 ns | 12.960 ns |  0.86 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net461 | 17.432 ns | 0.0535 ns | 0.0500 ns | 17.448 ns |  1.16 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net472 | 17.423 ns | 0.0185 ns | 0.0164 ns | 17.425 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Enum | .NET Core 2.0 | 20.740 ns | 0.0202 ns | 0.0179 ns | 20.739 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 2.2 | 17.541 ns | 0.0265 ns | 0.0221 ns | 17.535 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 3.0 | 16.108 ns | 0.0825 ns | 0.0772 ns | 16.136 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                                             From_Enum |        net461 | 20.340 ns | 0.0194 ns | 0.0172 ns | 20.344 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                             From_Enum |        net472 | 19.424 ns | 0.0168 ns | 0.0140 ns | 19.428 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Enum_AsObject | .NET Core 2.0 | 55.295 ns | 0.0654 ns | 0.0612 ns | 55.300 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject | .NET Core 2.2 | 47.755 ns | 0.1284 ns | 0.1201 ns | 47.785 ns |  0.86 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject | .NET Core 3.0 | 43.193 ns | 0.8778 ns | 0.8211 ns | 43.589 ns |  0.78 |    0.01 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject |        net461 | 49.383 ns | 0.1521 ns | 0.1422 ns | 49.363 ns |  0.89 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject |        net472 | 55.351 ns | 0.0904 ns | 0.0846 ns | 55.332 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Enum_Nullable_WithValue | .NET Core 2.0 | 20.979 ns | 0.0243 ns | 0.0227 ns | 20.981 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 2.2 | 19.428 ns | 0.0228 ns | 0.0213 ns | 19.428 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 3.0 | 16.625 ns | 0.1161 ns | 0.1086 ns | 16.664 ns |  0.79 |    0.01 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net461 | 29.262 ns | 0.0262 ns | 0.0245 ns | 29.256 ns |  1.39 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net472 | 20.112 ns | 0.0139 ns | 0.0130 ns | 20.118 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.0 | 50.452 ns | 0.0756 ns | 0.0707 ns | 50.430 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.2 | 51.586 ns | 0.1331 ns | 0.1180 ns | 51.557 ns |  1.02 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 3.0 | 43.523 ns | 0.2286 ns | 0.1784 ns | 43.593 ns |  0.86 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject |        net461 | 51.691 ns | 0.2566 ns | 0.2400 ns | 51.601 ns |  1.02 |    0.01 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject |        net472 | 53.106 ns | 0.2774 ns | 0.2595 ns | 53.189 ns |  1.05 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Enum_Nullable_NoValue | .NET Core 2.0 | 13.827 ns | 0.0126 ns | 0.0112 ns | 13.824 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 2.2 | 10.737 ns | 0.0107 ns | 0.0100 ns | 10.739 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 3.0 |  8.851 ns | 0.0148 ns | 0.0139 ns |  8.848 ns |  0.64 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net461 | 14.188 ns | 0.0163 ns | 0.0153 ns | 14.191 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net472 | 14.555 ns | 0.0207 ns | 0.0193 ns | 14.550 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.156 ns | 0.0789 ns | 0.0738 ns | 15.124 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.694 ns | 0.0215 ns | 0.0191 ns | 13.689 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.239 ns | 0.0799 ns | 0.0748 ns | 14.278 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net461 | 14.645 ns | 0.0195 ns | 0.0183 ns | 14.648 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net472 | 16.368 ns | 0.0243 ns | 0.0227 ns | 16.366 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                      From_ParentClass | .NET Core 2.0 | 13.296 ns | 0.0150 ns | 0.0133 ns | 13.293 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 2.2 | 11.819 ns | 0.0347 ns | 0.0307 ns | 11.824 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 3.0 | 11.709 ns | 0.0128 ns | 0.0100 ns | 11.709 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass |        net461 | 13.811 ns | 0.0098 ns | 0.0087 ns | 13.809 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass |        net472 | 14.067 ns | 0.0144 ns | 0.0128 ns | 14.066 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_ParentClass_AsObject | .NET Core 2.0 | 18.226 ns | 0.0866 ns | 0.0810 ns | 18.177 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 2.2 | 18.068 ns | 0.0402 ns | 0.0376 ns | 18.075 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 3.0 | 16.389 ns | 0.0683 ns | 0.0639 ns | 16.408 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net461 | 17.462 ns | 0.0339 ns | 0.0317 ns | 17.457 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net472 | 19.374 ns | 0.0809 ns | 0.0756 ns | 19.393 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                              From_ParentClass_NoValue | .NET Core 2.0 | 13.298 ns | 0.0191 ns | 0.0178 ns | 13.297 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 2.2 | 11.765 ns | 0.0491 ns | 0.0460 ns | 11.739 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 3.0 | 12.963 ns | 0.2746 ns | 0.3053 ns | 13.108 ns |  0.97 |    0.02 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net461 | 14.040 ns | 0.0081 ns | 0.0076 ns | 14.041 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net472 | 16.514 ns | 0.0802 ns | 0.0750 ns | 16.534 ns |  1.24 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.0 | 15.976 ns | 0.0195 ns | 0.0173 ns | 15.979 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.2 | 13.669 ns | 0.0165 ns | 0.0154 ns | 13.672 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 3.0 | 13.282 ns | 0.0171 ns | 0.0142 ns | 13.279 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net461 | 17.369 ns | 0.0214 ns | 0.0190 ns | 17.369 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net472 | 16.330 ns | 0.0219 ns | 0.0205 ns | 16.323 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_ParentStruct | .NET Core 2.0 | 39.556 ns | 0.0311 ns | 0.0291 ns | 39.561 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 2.2 | 38.667 ns | 0.0299 ns | 0.0280 ns | 38.670 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 3.0 | 37.954 ns | 0.1585 ns | 0.1483 ns | 38.030 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct |        net461 | 44.595 ns | 0.0260 ns | 0.0230 ns | 44.600 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct |        net472 | 39.621 ns | 0.0563 ns | 0.0526 ns | 39.622 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_ParentStruct_AsObject | .NET Core 2.0 | 17.955 ns | 0.0147 ns | 0.0138 ns | 17.956 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 2.2 | 14.656 ns | 0.0204 ns | 0.0180 ns | 14.656 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 3.0 | 15.136 ns | 0.2954 ns | 0.2763 ns | 15.291 ns |  0.84 |    0.02 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net461 | 19.439 ns | 0.0234 ns | 0.0208 ns | 19.441 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net472 | 18.936 ns | 0.0170 ns | 0.0159 ns | 18.934 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.0 | 41.646 ns | 0.0499 ns | 0.0442 ns | 41.657 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.2 | 38.674 ns | 0.0725 ns | 0.0643 ns | 38.682 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 3.0 | 38.305 ns | 0.7838 ns | 0.7332 ns | 38.603 ns |  0.92 |    0.02 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue |        net461 | 45.075 ns | 0.0426 ns | 0.0399 ns | 45.074 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue |        net472 | 38.957 ns | 0.0492 ns | 0.0461 ns | 38.951 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 17.969 ns | 0.0127 ns | 0.0119 ns | 17.970 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.003 ns | 0.0172 ns | 0.0161 ns | 15.005 ns |  0.83 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 16.015 ns | 0.0277 ns | 0.0231 ns | 16.013 ns |  0.89 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net461 | 16.934 ns | 0.0325 ns | 0.0304 ns | 16.934 ns |  0.94 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net472 | 18.618 ns | 0.0235 ns | 0.0208 ns | 18.615 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.0 | 40.448 ns | 0.1122 ns | 0.1050 ns | 40.453 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.2 | 43.042 ns | 0.0454 ns | 0.0379 ns | 43.022 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 3.0 | 36.000 ns | 0.0962 ns | 0.0853 ns | 36.028 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net461 | 43.860 ns | 0.0667 ns | 0.0624 ns | 43.858 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net472 | 40.917 ns | 0.1006 ns | 0.0941 ns | 40.940 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 16.005 ns | 0.0186 ns | 0.0165 ns | 16.005 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.927 ns | 0.0097 ns | 0.0086 ns | 12.928 ns |  0.81 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.956 ns | 0.0113 ns | 0.0101 ns | 12.958 ns |  0.81 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net461 | 14.740 ns | 0.0924 ns | 0.0864 ns | 14.767 ns |  0.92 |    0.01 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net472 | 16.347 ns | 0.0216 ns | 0.0202 ns | 16.340 ns |  1.02 |    0.00 |      - |     - |     - |         - |

Benchmarks with issues:
  ConvertTo_DecimalNullable.From_Char_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_DecimalNullable.From_Char_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_DecimalNullable.From_Char_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_DecimalNullable.From_Char_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_DecimalNullable.From_Char_AsObject: Job-ZVTGBZ(Toolchain=net472)
  ConvertTo_DecimalNullable.From_Char_Nullable_WithValue_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_DecimalNullable.From_Char_Nullable_WithValue_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_DecimalNullable.From_Char_Nullable_WithValue_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_DecimalNullable.From_Char_Nullable_WithValue_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_DecimalNullable.From_Char_Nullable_WithValue_AsObject: Job-ZVTGBZ(Toolchain=net472)
  ConvertTo_DecimalNullable.From_DateTime_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_DecimalNullable.From_DateTime_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_DecimalNullable.From_DateTime_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_DecimalNullable.From_DateTime_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_DecimalNullable.From_DateTime_AsObject: Job-ZVTGBZ(Toolchain=net472)
  ConvertTo_DecimalNullable.From_DateTime_Nullable_WithValue_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_DecimalNullable.From_DateTime_Nullable_WithValue_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_DecimalNullable.From_DateTime_Nullable_WithValue_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_DecimalNullable.From_DateTime_Nullable_WithValue_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_DecimalNullable.From_DateTime_Nullable_WithValue_AsObject: Job-ZVTGBZ(Toolchain=net472)
  ConvertTo_DecimalNullable.From_String_Empty_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_DecimalNullable.From_String_Empty_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_DecimalNullable.From_String_Empty_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_DecimalNullable.From_String_Empty_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_DecimalNullable.From_String_Empty_AsObject: Job-ZVTGBZ(Toolchain=net472)
