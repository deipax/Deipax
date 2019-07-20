
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
                                             From_Bool | .NET Core 2.0 | 14.892 ns | 0.0358 ns | 0.0335 ns | 14.889 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 2.2 | 11.151 ns | 0.0150 ns | 0.0140 ns | 11.150 ns |  0.75 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 3.0 |  7.784 ns | 0.0398 ns | 0.0373 ns |  7.767 ns |  0.52 |    0.00 |      - |     - |     - |         - |
                                             From_Bool |        net461 | 13.806 ns | 0.0161 ns | 0.0142 ns | 13.806 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                             From_Bool |        net472 | 12.888 ns | 0.0236 ns | 0.0210 ns | 12.887 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Bool_AsObject | .NET Core 2.0 | 20.193 ns | 0.0197 ns | 0.0184 ns | 20.197 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 2.2 | 17.478 ns | 0.0414 ns | 0.0367 ns | 17.485 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 3.0 | 17.985 ns | 0.0359 ns | 0.0318 ns | 17.988 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net461 | 21.076 ns | 0.0196 ns | 0.0183 ns | 21.078 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net472 | 22.078 ns | 0.0366 ns | 0.0286 ns | 22.078 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Bool_Nullable_WithValue | .NET Core 2.0 | 13.482 ns | 0.0137 ns | 0.0121 ns | 13.484 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 2.2 | 10.982 ns | 0.0138 ns | 0.0122 ns | 10.980 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 3.0 |  8.300 ns | 0.0417 ns | 0.0390 ns |  8.318 ns |  0.62 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net461 | 14.848 ns | 0.0234 ns | 0.0207 ns | 14.842 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net472 | 13.712 ns | 0.0239 ns | 0.0199 ns | 13.706 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.004 ns | 0.0257 ns | 0.0228 ns | 20.003 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.2 | 18.244 ns | 0.0659 ns | 0.0616 ns | 18.265 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.502 ns | 0.0334 ns | 0.0313 ns | 18.499 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net461 | 21.603 ns | 0.0295 ns | 0.0261 ns | 21.606 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net472 | 22.326 ns | 0.0347 ns | 0.0325 ns | 22.324 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Bool_Nullable_NoValue | .NET Core 2.0 | 13.142 ns | 0.0157 ns | 0.0139 ns | 13.143 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 2.2 | 12.074 ns | 0.0145 ns | 0.0128 ns | 12.073 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 3.0 |  7.625 ns | 0.0441 ns | 0.0413 ns |  7.650 ns |  0.58 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net461 | 14.282 ns | 0.0329 ns | 0.0307 ns | 14.285 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net472 | 13.076 ns | 0.0338 ns | 0.0300 ns | 13.078 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.715 ns | 0.0558 ns | 0.0495 ns | 15.723 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.706 ns | 0.0633 ns | 0.0592 ns | 12.672 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.852 ns | 0.0111 ns | 0.0104 ns | 12.852 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net461 | 14.596 ns | 0.0275 ns | 0.0257 ns | 14.592 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net472 | 17.349 ns | 0.0469 ns | 0.0438 ns | 17.347 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Byte | .NET Core 2.0 | 12.607 ns | 0.0203 ns | 0.0189 ns | 12.606 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 2.2 | 10.664 ns | 0.0202 ns | 0.0189 ns | 10.666 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 3.0 |  7.068 ns | 0.0087 ns | 0.0073 ns |  7.069 ns |  0.56 |    0.00 |      - |     - |     - |         - |
                                             From_Byte |        net461 | 13.741 ns | 0.0314 ns | 0.0294 ns | 13.737 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                             From_Byte |        net472 | 14.069 ns | 0.2408 ns | 0.2252 ns | 14.070 ns |  1.12 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Byte_AsObject | .NET Core 2.0 | 20.894 ns | 0.0511 ns | 0.0478 ns | 20.891 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 2.2 | 17.415 ns | 0.0261 ns | 0.0232 ns | 17.410 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 3.0 | 18.988 ns | 0.1369 ns | 0.1281 ns | 19.050 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net461 | 21.450 ns | 0.0470 ns | 0.0439 ns | 21.440 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net472 | 22.347 ns | 0.0243 ns | 0.0203 ns | 22.342 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Byte_Nullable_WithValue | .NET Core 2.0 | 13.267 ns | 0.0170 ns | 0.0133 ns | 13.265 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 2.2 | 12.060 ns | 0.0230 ns | 0.0204 ns | 12.055 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 3.0 |  7.357 ns | 0.0117 ns | 0.0104 ns |  7.353 ns |  0.55 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net461 | 14.594 ns | 0.0164 ns | 0.0145 ns | 14.599 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net472 | 14.383 ns | 0.0379 ns | 0.0336 ns | 14.397 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.344 ns | 0.0331 ns | 0.0309 ns | 20.332 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.048 ns | 0.0253 ns | 0.0224 ns | 17.035 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.411 ns | 0.0438 ns | 0.0389 ns | 17.409 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net461 | 23.714 ns | 0.1103 ns | 0.1031 ns | 23.747 ns |  1.17 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net472 | 23.614 ns | 0.0986 ns | 0.0922 ns | 23.648 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Byte_Nullable_NoValue | .NET Core 2.0 | 12.731 ns | 0.0333 ns | 0.0295 ns | 12.737 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 2.2 | 10.731 ns | 0.0181 ns | 0.0170 ns | 10.727 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 3.0 |  7.470 ns | 0.1756 ns | 0.1642 ns |  7.593 ns |  0.59 |    0.01 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net461 | 14.225 ns | 0.0956 ns | 0.0894 ns | 14.179 ns |  1.12 |    0.01 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net472 | 12.981 ns | 0.0181 ns | 0.0160 ns | 12.984 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.0 | 16.400 ns | 0.0291 ns | 0.0272 ns | 16.396 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.664 ns | 0.0165 ns | 0.0154 ns | 12.663 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.765 ns | 0.0861 ns | 0.0806 ns | 14.739 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net461 | 14.586 ns | 0.0286 ns | 0.0268 ns | 14.583 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net472 | 16.181 ns | 0.0586 ns | 0.0549 ns | 16.153 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Char | .NET Core 2.0 | 12.621 ns | 0.0245 ns | 0.0229 ns | 12.616 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Char | .NET Core 2.2 | 10.650 ns | 0.0135 ns | 0.0120 ns | 10.649 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                             From_Char | .NET Core 3.0 |  7.619 ns | 0.0089 ns | 0.0074 ns |  7.621 ns |  0.60 |    0.00 |      - |     - |     - |         - |
                                             From_Char |        net461 | 14.277 ns | 0.0206 ns | 0.0193 ns | 14.273 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                             From_Char |        net472 | 12.779 ns | 0.0230 ns | 0.0215 ns | 12.775 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Char_AsObject | .NET Core 2.0 | 21.169 ns | 0.0358 ns | 0.0335 ns | 21.161 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 2.2 | 17.335 ns | 0.0214 ns | 0.0190 ns | 17.330 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 3.0 | 17.917 ns | 0.0211 ns | 0.0187 ns | 17.916 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject |        net461 | 20.947 ns | 0.0209 ns | 0.0185 ns | 20.946 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject |        net472 | 22.734 ns | 0.0737 ns | 0.0689 ns | 22.763 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Char_Nullable_WithValue | .NET Core 2.0 | 13.665 ns | 0.0188 ns | 0.0176 ns | 13.667 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 2.2 | 10.606 ns | 0.0189 ns | 0.0167 ns | 10.604 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 3.0 |  7.893 ns | 0.0210 ns | 0.0197 ns |  7.899 ns |  0.58 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net461 | 13.977 ns | 0.0156 ns | 0.0146 ns | 13.973 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net472 | 13.351 ns | 0.0097 ns | 0.0091 ns | 13.352 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.802 ns | 0.0393 ns | 0.0348 ns | 20.801 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.388 ns | 0.0990 ns | 0.0926 ns | 17.333 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.448 ns | 0.0269 ns | 0.0252 ns | 17.455 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net461 | 20.899 ns | 0.0328 ns | 0.0307 ns | 20.896 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net472 | 21.884 ns | 0.0288 ns | 0.0256 ns | 21.888 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Char_Nullable_NoValue | .NET Core 2.0 | 12.700 ns | 0.0091 ns | 0.0085 ns | 12.701 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 2.2 | 10.504 ns | 0.0098 ns | 0.0092 ns | 10.503 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 3.0 |  7.587 ns | 0.0565 ns | 0.0529 ns |  7.557 ns |  0.60 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net461 | 13.557 ns | 0.0259 ns | 0.0216 ns | 13.556 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net472 | 13.071 ns | 0.0436 ns | 0.0387 ns | 13.079 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.0 | 16.071 ns | 0.0157 ns | 0.0131 ns | 16.071 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.226 ns | 0.0137 ns | 0.0128 ns | 13.231 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.988 ns | 0.1249 ns | 0.1168 ns | 13.066 ns |  0.81 |    0.01 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net461 | 17.208 ns | 0.0815 ns | 0.0762 ns | 17.239 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net472 | 17.162 ns | 0.0321 ns | 0.0268 ns | 17.159 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                         From_DateTime | .NET Core 2.0 | 12.711 ns | 0.0270 ns | 0.0225 ns | 12.706 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 2.2 | 11.235 ns | 0.0124 ns | 0.0116 ns | 11.232 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 3.0 |  8.149 ns | 0.0812 ns | 0.0759 ns |  8.159 ns |  0.64 |    0.01 |      - |     - |     - |         - |
                                         From_DateTime |        net461 | 13.504 ns | 0.0217 ns | 0.0203 ns | 13.502 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime |        net472 | 12.650 ns | 0.0232 ns | 0.0194 ns | 12.649 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                From_DateTime_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                      From_DateTime_Nullable_WithValue | .NET Core 2.0 | 12.526 ns | 0.0145 ns | 0.0129 ns | 12.524 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 2.2 | 11.466 ns | 0.0081 ns | 0.0068 ns | 11.466 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 3.0 | 10.612 ns | 0.2395 ns | 0.6351 ns | 10.772 ns |  0.78 |    0.10 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net461 | 14.469 ns | 0.0194 ns | 0.0162 ns | 14.468 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net472 | 12.970 ns | 0.0147 ns | 0.0130 ns | 12.968 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_DateTime_Nullable_NoValue | .NET Core 2.0 | 12.542 ns | 0.0709 ns | 0.0629 ns | 12.559 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 2.2 | 13.319 ns | 0.0198 ns | 0.0155 ns | 13.318 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 3.0 |  8.182 ns | 0.0719 ns | 0.0672 ns |  8.144 ns |  0.65 |    0.01 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net461 | 14.495 ns | 0.0378 ns | 0.0354 ns | 14.503 ns |  1.16 |    0.01 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net472 | 12.959 ns | 0.0136 ns | 0.0114 ns | 12.960 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.957 ns | 0.0444 ns | 0.0415 ns | 15.951 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.654 ns | 0.0139 ns | 0.0130 ns | 12.654 ns |  0.79 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.232 ns | 0.0734 ns | 0.0686 ns | 14.264 ns |  0.89 |    0.01 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net461 | 18.043 ns | 0.0247 ns | 0.0219 ns | 18.039 ns |  1.13 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net472 | 16.147 ns | 0.0330 ns | 0.0275 ns | 16.141 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                          From_Decimal | .NET Core 2.0 | 23.025 ns | 0.0166 ns | 0.0155 ns | 23.030 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 2.2 | 20.208 ns | 0.0525 ns | 0.0465 ns | 20.210 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 3.0 | 12.933 ns | 0.1519 ns | 0.1421 ns | 13.018 ns |  0.56 |    0.01 |      - |     - |     - |         - |
                                          From_Decimal |        net461 | 22.698 ns | 0.0323 ns | 0.0303 ns | 22.690 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal |        net472 | 22.735 ns | 0.0360 ns | 0.0319 ns | 22.727 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                 From_Decimal_AsObject | .NET Core 2.0 | 31.759 ns | 0.0427 ns | 0.0399 ns | 31.778 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 2.2 | 26.802 ns | 0.0271 ns | 0.0240 ns | 26.800 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 3.0 | 23.914 ns | 0.0454 ns | 0.0424 ns | 23.919 ns |  0.75 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net461 | 30.750 ns | 0.0440 ns | 0.0344 ns | 30.750 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net472 | 30.844 ns | 0.0224 ns | 0.0187 ns | 30.841 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                       From_Decimal_Nullable_WithValue | .NET Core 2.0 | 22.801 ns | 0.0208 ns | 0.0174 ns | 22.801 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 2.2 | 21.507 ns | 0.0452 ns | 0.0378 ns | 21.503 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 3.0 | 15.476 ns | 0.0185 ns | 0.0164 ns | 15.474 ns |  0.68 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net461 | 24.394 ns | 0.0113 ns | 0.0106 ns | 24.396 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net472 | 23.266 ns | 0.0192 ns | 0.0150 ns | 23.268 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.0 | 31.621 ns | 0.0527 ns | 0.0493 ns | 31.622 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.2 | 27.520 ns | 0.0314 ns | 0.0263 ns | 27.528 ns |  0.87 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 3.0 | 21.721 ns | 0.1566 ns | 0.1465 ns | 21.649 ns |  0.69 |    0.01 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net461 | 29.663 ns | 0.1025 ns | 0.0856 ns | 29.686 ns |  0.94 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net472 | 31.074 ns | 0.0451 ns | 0.0422 ns | 31.079 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Decimal_Nullable_NoValue | .NET Core 2.0 | 12.804 ns | 0.0145 ns | 0.0129 ns | 12.802 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 2.2 | 11.713 ns | 0.0134 ns | 0.0126 ns | 11.710 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 3.0 |  8.961 ns | 0.0100 ns | 0.0089 ns |  8.961 ns |  0.70 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net461 | 15.095 ns | 0.0277 ns | 0.0259 ns | 15.096 ns |  1.18 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net472 | 14.193 ns | 0.0263 ns | 0.0246 ns | 14.194 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.0 | 16.591 ns | 0.0216 ns | 0.0192 ns | 16.591 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.533 ns | 0.0741 ns | 0.0694 ns | 13.483 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.887 ns | 0.0160 ns | 0.0133 ns | 13.890 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net461 | 15.727 ns | 0.0114 ns | 0.0107 ns | 15.729 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net472 | 17.136 ns | 0.0204 ns | 0.0181 ns | 17.145 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_Double | .NET Core 2.0 | 15.661 ns | 0.0512 ns | 0.0479 ns | 15.666 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 2.2 | 12.057 ns | 0.0148 ns | 0.0131 ns | 12.058 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 3.0 | 10.120 ns | 0.1719 ns | 0.1608 ns | 10.219 ns |  0.65 |    0.01 |      - |     - |     - |         - |
                                           From_Double |        net461 | 17.557 ns | 0.0177 ns | 0.0157 ns | 17.553 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                           From_Double |        net472 | 17.773 ns | 0.0253 ns | 0.0198 ns | 17.768 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_Double_AsObject | .NET Core 2.0 | 23.545 ns | 0.0302 ns | 0.0236 ns | 23.551 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 2.2 | 18.925 ns | 0.0283 ns | 0.0236 ns | 18.921 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 3.0 | 19.258 ns | 0.3776 ns | 0.3532 ns | 19.505 ns |  0.82 |    0.01 |      - |     - |     - |         - |
                                  From_Double_AsObject |        net461 | 23.848 ns | 0.0325 ns | 0.0304 ns | 23.858 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject |        net472 | 25.660 ns | 0.0858 ns | 0.0761 ns | 25.642 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_Double_Nullable_WithValue | .NET Core 2.0 | 15.686 ns | 0.0237 ns | 0.0222 ns | 15.693 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 2.2 | 12.998 ns | 0.0165 ns | 0.0154 ns | 12.993 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 3.0 | 10.388 ns | 0.0702 ns | 0.0657 ns | 10.411 ns |  0.66 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net461 | 20.419 ns | 0.0202 ns | 0.0179 ns | 20.412 ns |  1.30 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net472 | 16.307 ns | 0.0158 ns | 0.0148 ns | 16.309 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.0 | 24.268 ns | 0.0873 ns | 0.0774 ns | 24.288 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.2 | 19.152 ns | 0.0235 ns | 0.0209 ns | 19.149 ns |  0.79 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.940 ns | 0.0309 ns | 0.0289 ns | 18.939 ns |  0.78 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net461 | 23.825 ns | 0.0255 ns | 0.0226 ns | 23.831 ns |  0.98 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net472 | 24.872 ns | 0.0216 ns | 0.0192 ns | 24.868 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Double_Nullable_NoValue | .NET Core 2.0 | 12.670 ns | 0.0194 ns | 0.0172 ns | 12.668 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 2.2 | 11.572 ns | 0.0164 ns | 0.0154 ns | 11.573 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 3.0 |  8.390 ns | 0.0164 ns | 0.0153 ns |  8.392 ns |  0.66 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net461 | 14.161 ns | 0.0127 ns | 0.0119 ns | 14.158 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net472 | 13.133 ns | 0.0224 ns | 0.0187 ns | 13.136 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.203 ns | 0.0197 ns | 0.0184 ns | 15.205 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.232 ns | 0.0146 ns | 0.0136 ns | 14.231 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.836 ns | 0.0117 ns | 0.0110 ns | 11.834 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net461 | 17.109 ns | 0.0289 ns | 0.0270 ns | 17.106 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net472 | 16.164 ns | 0.0337 ns | 0.0282 ns | 16.164 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_Short | .NET Core 2.0 | 13.517 ns | 0.0209 ns | 0.0185 ns | 13.519 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 2.2 | 12.154 ns | 0.0141 ns | 0.0132 ns | 12.157 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 3.0 |  7.306 ns | 0.0081 ns | 0.0075 ns |  7.305 ns |  0.54 |    0.00 |      - |     - |     - |         - |
                                            From_Short |        net461 | 13.672 ns | 0.0178 ns | 0.0158 ns | 13.674 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                            From_Short |        net472 | 13.465 ns | 0.0261 ns | 0.0218 ns | 13.459 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_Short_AsObject | .NET Core 2.0 | 20.495 ns | 0.0967 ns | 0.0857 ns | 20.492 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 2.2 | 17.033 ns | 0.0210 ns | 0.0186 ns | 17.026 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 3.0 | 17.942 ns | 0.1316 ns | 0.1231 ns | 17.999 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net461 | 21.366 ns | 0.0337 ns | 0.0299 ns | 21.361 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net472 | 22.562 ns | 0.0699 ns | 0.0620 ns | 22.578 ns |  1.10 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Short_Nullable_WithValue | .NET Core 2.0 | 13.145 ns | 0.0086 ns | 0.0081 ns | 13.144 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 2.2 | 10.679 ns | 0.0138 ns | 0.0130 ns | 10.676 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 3.0 |  7.929 ns | 0.0160 ns | 0.0142 ns |  7.928 ns |  0.60 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net461 | 14.576 ns | 0.0252 ns | 0.0197 ns | 14.572 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net472 | 13.399 ns | 0.0219 ns | 0.0194 ns | 13.401 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.833 ns | 0.0238 ns | 0.0222 ns | 20.831 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.2 | 16.841 ns | 0.0322 ns | 0.0301 ns | 16.834 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.830 ns | 0.0840 ns | 0.0786 ns | 18.833 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net461 | 21.486 ns | 0.0252 ns | 0.0224 ns | 21.487 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net472 | 22.373 ns | 0.0317 ns | 0.0281 ns | 22.374 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Short_Nullable_NoValue | .NET Core 2.0 | 12.656 ns | 0.0176 ns | 0.0156 ns | 12.659 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 2.2 | 10.551 ns | 0.0171 ns | 0.0151 ns | 10.549 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 3.0 |  7.604 ns | 0.0159 ns | 0.0149 ns |  7.600 ns |  0.60 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net461 | 14.054 ns | 0.0141 ns | 0.0125 ns | 14.053 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net472 | 14.131 ns | 0.0255 ns | 0.0226 ns | 14.130 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.0 | 16.236 ns | 0.0215 ns | 0.0191 ns | 16.239 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.644 ns | 0.0159 ns | 0.0141 ns | 12.649 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.778 ns | 0.0152 ns | 0.0135 ns | 12.778 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net461 | 14.626 ns | 0.0520 ns | 0.0486 ns | 14.651 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net472 | 16.138 ns | 0.0240 ns | 0.0187 ns | 16.138 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                              From_Int | .NET Core 2.0 | 12.557 ns | 0.0731 ns | 0.0683 ns | 12.514 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 2.2 | 11.999 ns | 0.0736 ns | 0.0688 ns | 12.029 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                                              From_Int | .NET Core 3.0 |  8.209 ns | 0.1848 ns | 0.2877 ns |  8.353 ns |  0.64 |    0.03 |      - |     - |     - |         - |
                                              From_Int |        net461 | 14.071 ns | 0.0137 ns | 0.0122 ns | 14.073 ns |  1.12 |    0.01 |      - |     - |     - |         - |
                                              From_Int |        net472 | 12.842 ns | 0.0156 ns | 0.0146 ns | 12.838 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_Int_AsObject | .NET Core 2.0 | 20.095 ns | 0.0293 ns | 0.0245 ns | 20.094 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 2.2 | 17.057 ns | 0.0304 ns | 0.0270 ns | 17.056 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 3.0 | 17.246 ns | 0.0211 ns | 0.0198 ns | 17.242 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net461 | 21.719 ns | 0.0785 ns | 0.0734 ns | 21.754 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net472 | 22.607 ns | 0.0262 ns | 0.0245 ns | 22.603 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Int_Nullable_WithValue | .NET Core 2.0 | 14.360 ns | 0.0135 ns | 0.0119 ns | 14.358 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 2.2 | 10.588 ns | 0.0150 ns | 0.0117 ns | 10.589 ns |  0.74 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 3.0 |  7.924 ns | 0.0600 ns | 0.0561 ns |  7.960 ns |  0.55 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net461 | 14.695 ns | 0.0923 ns | 0.0863 ns | 14.709 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net472 | 13.468 ns | 0.0241 ns | 0.0226 ns | 13.473 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.140 ns | 0.0294 ns | 0.0275 ns | 20.132 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.010 ns | 0.0184 ns | 0.0172 ns | 17.008 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.518 ns | 0.1478 ns | 0.1382 ns | 17.562 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net461 | 21.380 ns | 0.0146 ns | 0.0129 ns | 21.377 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net472 | 29.293 ns | 0.0295 ns | 0.0247 ns | 29.296 ns |  1.45 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_Int_Nullable_NoValue | .NET Core 2.0 | 13.582 ns | 0.0126 ns | 0.0112 ns | 13.585 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 2.2 | 10.495 ns | 0.0108 ns | 0.0090 ns | 10.492 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 3.0 |  7.863 ns | 0.0190 ns | 0.0178 ns |  7.861 ns |  0.58 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net461 | 15.124 ns | 0.0244 ns | 0.0216 ns | 15.117 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net472 | 12.930 ns | 0.0172 ns | 0.0144 ns | 12.929 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.377 ns | 0.0486 ns | 0.0406 ns | 15.382 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.698 ns | 0.0684 ns | 0.0640 ns | 12.665 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.920 ns | 0.2430 ns | 0.2273 ns | 13.768 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net461 | 14.543 ns | 0.0162 ns | 0.0144 ns | 14.541 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net472 | 16.139 ns | 0.0235 ns | 0.0220 ns | 16.141 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Long | .NET Core 2.0 | 14.502 ns | 0.0234 ns | 0.0219 ns | 14.499 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Long | .NET Core 2.2 | 10.377 ns | 0.0093 ns | 0.0087 ns | 10.376 ns |  0.72 |    0.00 |      - |     - |     - |         - |
                                             From_Long | .NET Core 3.0 |  6.798 ns | 0.0089 ns | 0.0079 ns |  6.797 ns |  0.47 |    0.00 |      - |     - |     - |         - |
                                             From_Long |        net461 | 13.645 ns | 0.0160 ns | 0.0134 ns | 13.647 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                             From_Long |        net472 | 12.722 ns | 0.0134 ns | 0.0112 ns | 12.717 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Long_AsObject | .NET Core 2.0 | 25.069 ns | 0.0375 ns | 0.0332 ns | 25.068 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 2.2 | 25.880 ns | 0.0536 ns | 0.0502 ns | 25.871 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 3.0 | 28.768 ns | 0.0342 ns | 0.0303 ns | 28.751 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net461 | 33.218 ns | 0.0419 ns | 0.0392 ns | 33.215 ns |  1.33 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net472 | 35.183 ns | 0.1338 ns | 0.1186 ns | 35.225 ns |  1.40 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Long_Nullable_WithValue | .NET Core 2.0 | 12.546 ns | 0.0194 ns | 0.0162 ns | 12.542 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 2.2 | 12.086 ns | 0.0111 ns | 0.0099 ns | 12.085 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 3.0 |  8.602 ns | 0.0570 ns | 0.0533 ns |  8.620 ns |  0.69 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net461 | 14.710 ns | 0.0148 ns | 0.0131 ns | 14.712 ns |  1.17 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net472 | 13.168 ns | 0.0185 ns | 0.0164 ns | 13.166 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.0 | 25.013 ns | 0.0196 ns | 0.0174 ns | 25.015 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.2 | 26.741 ns | 0.0269 ns | 0.0238 ns | 26.733 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 3.0 | 29.796 ns | 0.0473 ns | 0.0419 ns | 29.788 ns |  1.19 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net461 | 34.984 ns | 0.0561 ns | 0.0525 ns | 34.973 ns |  1.40 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net472 | 34.675 ns | 0.0938 ns | 0.0832 ns | 34.664 ns |  1.39 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Long_Nullable_NoValue | .NET Core 2.0 | 13.836 ns | 0.1763 ns | 0.1649 ns | 13.839 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 2.2 | 11.818 ns | 0.0100 ns | 0.0089 ns | 11.820 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 3.0 |  8.472 ns | 0.0159 ns | 0.0141 ns |  8.471 ns |  0.61 |    0.01 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net461 | 13.341 ns | 0.0122 ns | 0.0114 ns | 13.338 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net472 | 13.096 ns | 0.0109 ns | 0.0097 ns | 13.095 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.0 | 16.192 ns | 0.0238 ns | 0.0211 ns | 16.188 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.359 ns | 0.0212 ns | 0.0177 ns | 14.356 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.776 ns | 0.0204 ns | 0.0191 ns | 12.772 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net461 | 14.784 ns | 0.0239 ns | 0.0212 ns | 14.781 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net472 | 17.174 ns | 0.0185 ns | 0.0164 ns | 17.172 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_SByte | .NET Core 2.0 | 12.561 ns | 0.0140 ns | 0.0124 ns | 12.559 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 2.2 | 12.052 ns | 0.0895 ns | 0.0837 ns | 12.089 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 3.0 |  7.877 ns | 0.0174 ns | 0.0163 ns |  7.874 ns |  0.63 |    0.00 |      - |     - |     - |         - |
                                            From_SByte |        net461 | 13.737 ns | 0.0643 ns | 0.0602 ns | 13.760 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                            From_SByte |        net472 | 13.464 ns | 0.0063 ns | 0.0059 ns | 13.465 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_SByte_AsObject | .NET Core 2.0 | 20.490 ns | 0.0236 ns | 0.0221 ns | 20.488 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 2.2 | 16.809 ns | 0.0180 ns | 0.0168 ns | 16.808 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 3.0 | 18.627 ns | 0.1113 ns | 0.1041 ns | 18.641 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net461 | 21.410 ns | 0.0184 ns | 0.0164 ns | 21.410 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net472 | 22.402 ns | 0.0769 ns | 0.0720 ns | 22.381 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_SByte_Nullable_WithValue | .NET Core 2.0 | 12.904 ns | 0.0144 ns | 0.0120 ns | 12.907 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 2.2 | 10.774 ns | 0.0105 ns | 0.0093 ns | 10.774 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 3.0 |  8.397 ns | 0.1952 ns | 0.2398 ns |  8.505 ns |  0.64 |    0.02 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net461 | 15.607 ns | 0.0240 ns | 0.0213 ns | 15.605 ns |  1.21 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net472 | 13.632 ns | 0.0635 ns | 0.0594 ns | 13.651 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.0 | 21.622 ns | 0.0214 ns | 0.0190 ns | 21.621 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.2 | 19.124 ns | 0.0528 ns | 0.0494 ns | 19.133 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.439 ns | 0.0569 ns | 0.0532 ns | 17.438 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net461 | 21.451 ns | 0.0988 ns | 0.0876 ns | 21.486 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net472 | 22.354 ns | 0.0292 ns | 0.0259 ns | 22.351 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_SByte_Nullable_NoValue | .NET Core 2.0 | 12.692 ns | 0.0134 ns | 0.0125 ns | 12.694 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 2.2 | 10.618 ns | 0.0107 ns | 0.0100 ns | 10.618 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 3.0 |  7.292 ns | 0.0143 ns | 0.0127 ns |  7.289 ns |  0.57 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net461 | 14.154 ns | 0.0152 ns | 0.0142 ns | 14.151 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net472 | 14.566 ns | 0.0191 ns | 0.0179 ns | 14.565 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.0 | 16.247 ns | 0.0273 ns | 0.0242 ns | 16.245 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.265 ns | 0.0896 ns | 0.0838 ns | 14.224 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.783 ns | 0.0166 ns | 0.0148 ns | 12.779 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net461 | 14.481 ns | 0.0121 ns | 0.0101 ns | 14.482 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net472 | 17.142 ns | 0.0231 ns | 0.0216 ns | 17.147 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_Float | .NET Core 2.0 | 15.533 ns | 0.0255 ns | 0.0239 ns | 15.528 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 2.2 | 12.620 ns | 0.0157 ns | 0.0140 ns | 12.619 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 3.0 |  9.760 ns | 0.1608 ns | 0.1425 ns |  9.693 ns |  0.63 |    0.01 |      - |     - |     - |         - |
                                            From_Float |        net461 | 17.669 ns | 0.0248 ns | 0.0232 ns | 17.667 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                            From_Float |        net472 | 17.072 ns | 0.0163 ns | 0.0152 ns | 17.070 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_Float_AsObject | .NET Core 2.0 | 23.547 ns | 0.0232 ns | 0.0193 ns | 23.547 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 2.2 | 20.768 ns | 0.1057 ns | 0.0937 ns | 20.789 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 3.0 | 19.575 ns | 0.0255 ns | 0.0226 ns | 19.569 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject |        net461 | 23.932 ns | 0.0906 ns | 0.0847 ns | 23.911 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject |        net472 | 26.144 ns | 0.1407 ns | 0.1316 ns | 26.201 ns |  1.11 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Float_Nullable_WithValue | .NET Core 2.0 | 15.569 ns | 0.0419 ns | 0.0392 ns | 15.560 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 2.2 | 12.065 ns | 0.0108 ns | 0.0101 ns | 12.066 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 3.0 |  9.930 ns | 0.0608 ns | 0.0569 ns |  9.953 ns |  0.64 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net461 | 18.269 ns | 0.1061 ns | 0.0993 ns | 18.315 ns |  1.17 |    0.01 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net472 | 17.696 ns | 0.0205 ns | 0.0171 ns | 17.692 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.0 | 24.371 ns | 0.0555 ns | 0.0492 ns | 24.375 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.2 | 19.042 ns | 0.0276 ns | 0.0245 ns | 19.044 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 3.0 | 19.008 ns | 0.0378 ns | 0.0354 ns | 19.020 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net461 | 23.871 ns | 0.0425 ns | 0.0377 ns | 23.866 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net472 | 25.353 ns | 0.1222 ns | 0.1143 ns | 25.400 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Float_Nullable_NoValue | .NET Core 2.0 | 12.784 ns | 0.0243 ns | 0.0227 ns | 12.777 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 2.2 | 11.290 ns | 0.0160 ns | 0.0142 ns | 11.297 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 3.0 |  8.224 ns | 0.0161 ns | 0.0150 ns |  8.221 ns |  0.64 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net461 | 14.105 ns | 0.0188 ns | 0.0176 ns | 14.104 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net472 | 13.012 ns | 0.0155 ns | 0.0145 ns | 13.013 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.199 ns | 0.0180 ns | 0.0150 ns | 15.204 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.359 ns | 0.0169 ns | 0.0149 ns | 14.357 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.240 ns | 0.0330 ns | 0.0309 ns | 14.247 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net461 | 15.344 ns | 0.0388 ns | 0.0363 ns | 15.325 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net472 | 16.176 ns | 0.0197 ns | 0.0184 ns | 16.180 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_String | .NET Core 2.0 | 63.308 ns | 0.0896 ns | 0.0838 ns | 63.325 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 2.2 | 50.294 ns | 0.0261 ns | 0.0218 ns | 50.297 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 3.0 | 22.445 ns | 0.4073 ns | 0.3810 ns | 22.187 ns |  0.35 |    0.01 |      - |     - |     - |         - |
                                           From_String |        net461 | 61.574 ns | 0.1386 ns | 0.1228 ns | 61.565 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                           From_String |        net472 | 63.389 ns | 0.0651 ns | 0.0609 ns | 63.370 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_String_AsObject | .NET Core 2.0 | 68.084 ns | 0.0958 ns | 0.0896 ns | 68.088 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 2.2 | 58.906 ns | 0.0535 ns | 0.0474 ns | 58.905 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 3.0 | 29.472 ns | 0.2049 ns | 0.1917 ns | 29.412 ns |  0.43 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject |        net461 | 66.062 ns | 0.0716 ns | 0.0669 ns | 66.059 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject |        net472 | 68.620 ns | 0.2516 ns | 0.2354 ns | 68.490 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                      From_String_Null | .NET Core 2.0 | 13.589 ns | 0.0143 ns | 0.0133 ns | 13.583 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 2.2 | 12.044 ns | 0.0688 ns | 0.0644 ns | 12.006 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 3.0 | 13.372 ns | 0.0123 ns | 0.0109 ns | 13.370 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null |        net461 | 14.414 ns | 0.0331 ns | 0.0294 ns | 14.408 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null |        net472 | 16.719 ns | 0.0807 ns | 0.0754 ns | 16.737 ns |  1.23 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_String_Null_AsObject | .NET Core 2.0 | 16.055 ns | 0.0245 ns | 0.0204 ns | 16.057 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 2.2 | 13.016 ns | 0.0084 ns | 0.0074 ns | 13.016 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 3.0 | 12.977 ns | 0.2037 ns | 0.1905 ns | 12.820 ns |  0.81 |    0.01 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net461 | 17.249 ns | 0.0925 ns | 0.0865 ns | 17.196 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net472 | 18.559 ns | 0.0234 ns | 0.0219 ns | 18.558 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_String_Empty | .NET Core 2.0 | 14.642 ns | 0.0229 ns | 0.0203 ns | 14.640 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 2.2 | 12.338 ns | 0.0121 ns | 0.0095 ns | 12.337 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 3.0 | 12.665 ns | 0.0947 ns | 0.0886 ns | 12.611 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                                     From_String_Empty |        net461 | 14.160 ns | 0.0219 ns | 0.0182 ns | 14.161 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty |        net472 | 17.690 ns | 0.0171 ns | 0.0160 ns | 17.686 ns |  1.21 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_String_Empty_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_UShort | .NET Core 2.0 | 12.567 ns | 0.0265 ns | 0.0235 ns | 12.563 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 2.2 | 11.029 ns | 0.0106 ns | 0.0094 ns | 11.028 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 3.0 |  7.093 ns | 0.0456 ns | 0.0426 ns |  7.084 ns |  0.56 |    0.00 |      - |     - |     - |         - |
                                           From_UShort |        net461 | 14.202 ns | 0.0163 ns | 0.0144 ns | 14.202 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                           From_UShort |        net472 | 13.460 ns | 0.0127 ns | 0.0106 ns | 13.461 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_UShort_AsObject | .NET Core 2.0 | 20.293 ns | 0.0311 ns | 0.0276 ns | 20.296 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 2.2 | 18.056 ns | 0.0726 ns | 0.0679 ns | 18.076 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 3.0 | 18.672 ns | 0.0749 ns | 0.0664 ns | 18.661 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net461 | 21.296 ns | 0.0302 ns | 0.0268 ns | 21.293 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net472 | 22.376 ns | 0.0203 ns | 0.0190 ns | 22.380 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_UShort_Nullable_WithValue | .NET Core 2.0 | 13.727 ns | 0.0084 ns | 0.0079 ns | 13.726 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 2.2 | 10.673 ns | 0.0495 ns | 0.0463 ns | 10.688 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 3.0 |  7.551 ns | 0.0193 ns | 0.0181 ns |  7.554 ns |  0.55 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net461 | 14.667 ns | 0.0418 ns | 0.0371 ns | 14.670 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net472 | 13.340 ns | 0.0120 ns | 0.0112 ns | 13.339 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.634 ns | 0.0221 ns | 0.0196 ns | 20.636 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.260 ns | 0.0171 ns | 0.0151 ns | 17.264 ns |  0.84 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.638 ns | 0.0366 ns | 0.0342 ns | 18.625 ns |  0.90 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net461 | 21.520 ns | 0.0245 ns | 0.0217 ns | 21.517 ns |  1.04 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net472 | 22.592 ns | 0.0239 ns | 0.0212 ns | 22.588 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_UShort_Nullable_NoValue | .NET Core 2.0 | 12.789 ns | 0.0735 ns | 0.0614 ns | 12.814 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 2.2 | 10.505 ns | 0.0094 ns | 0.0088 ns | 10.502 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 3.0 |  8.168 ns | 0.0613 ns | 0.0573 ns |  8.174 ns |  0.64 |    0.01 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net461 | 14.565 ns | 0.0335 ns | 0.0313 ns | 14.557 ns |  1.14 |    0.01 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net472 | 13.025 ns | 0.0743 ns | 0.0695 ns | 13.050 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.212 ns | 0.0139 ns | 0.0130 ns | 15.210 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.456 ns | 0.0133 ns | 0.0124 ns | 13.451 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.823 ns | 0.0080 ns | 0.0071 ns | 12.823 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net461 | 15.549 ns | 0.0903 ns | 0.0845 ns | 15.595 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net472 | 17.147 ns | 0.0211 ns | 0.0198 ns | 17.148 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_UInt | .NET Core 2.0 | 12.549 ns | 0.0208 ns | 0.0195 ns | 12.547 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 2.2 | 10.877 ns | 0.0129 ns | 0.0120 ns | 10.878 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 3.0 |  7.736 ns | 0.0793 ns | 0.0742 ns |  7.735 ns |  0.62 |    0.01 |      - |     - |     - |         - |
                                             From_UInt |        net461 | 14.061 ns | 0.0245 ns | 0.0217 ns | 14.063 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                             From_UInt |        net472 | 15.218 ns | 0.0332 ns | 0.0294 ns | 15.205 ns |  1.21 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_UInt_AsObject | .NET Core 2.0 | 20.278 ns | 0.0216 ns | 0.0180 ns | 20.282 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 2.2 | 18.535 ns | 0.0446 ns | 0.0417 ns | 18.540 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 3.0 | 19.072 ns | 0.1496 ns | 0.1400 ns | 19.121 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net461 | 23.725 ns | 0.1197 ns | 0.1120 ns | 23.741 ns |  1.17 |    0.01 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net472 | 23.157 ns | 0.0544 ns | 0.0509 ns | 23.173 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_UInt_Nullable_WithValue | .NET Core 2.0 | 12.900 ns | 0.0359 ns | 0.0318 ns | 12.885 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 2.2 | 10.596 ns | 0.0149 ns | 0.0132 ns | 10.595 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 3.0 |  9.246 ns | 0.2069 ns | 0.3457 ns |  9.325 ns |  0.71 |    0.04 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net461 | 13.988 ns | 0.0128 ns | 0.0120 ns | 13.989 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net472 | 13.365 ns | 0.0167 ns | 0.0156 ns | 13.363 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.399 ns | 0.0166 ns | 0.0155 ns | 20.402 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.775 ns | 0.0280 ns | 0.0262 ns | 17.773 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.894 ns | 0.0307 ns | 0.0287 ns | 17.891 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net461 | 21.336 ns | 0.0316 ns | 0.0246 ns | 21.341 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net472 | 22.399 ns | 0.0312 ns | 0.0292 ns | 22.397 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_UInt_Nullable_NoValue | .NET Core 2.0 | 13.500 ns | 0.0161 ns | 0.0150 ns | 13.498 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 2.2 | 10.484 ns | 0.0105 ns | 0.0093 ns | 10.482 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 3.0 |  8.081 ns | 0.1119 ns | 0.1046 ns |  8.136 ns |  0.60 |    0.01 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net461 | 14.105 ns | 0.0155 ns | 0.0137 ns | 14.105 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net472 | 12.947 ns | 0.0152 ns | 0.0135 ns | 12.947 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.0 | 16.072 ns | 0.0201 ns | 0.0188 ns | 16.070 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.955 ns | 0.0141 ns | 0.0118 ns | 14.959 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.956 ns | 0.0538 ns | 0.0503 ns | 13.969 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net461 | 14.555 ns | 0.0118 ns | 0.0104 ns | 14.556 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net472 | 17.224 ns | 0.0314 ns | 0.0294 ns | 17.222 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_ULong | .NET Core 2.0 | 15.825 ns | 0.0129 ns | 0.0108 ns | 15.829 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 2.2 | 10.612 ns | 0.0111 ns | 0.0104 ns | 10.612 ns |  0.67 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 3.0 |  8.155 ns | 0.0716 ns | 0.0670 ns |  8.191 ns |  0.52 |    0.00 |      - |     - |     - |         - |
                                            From_ULong |        net461 | 14.677 ns | 0.0318 ns | 0.0282 ns | 14.672 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                            From_ULong |        net472 | 13.873 ns | 0.0104 ns | 0.0093 ns | 13.876 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_ULong_AsObject | .NET Core 2.0 | 20.466 ns | 0.0246 ns | 0.0230 ns | 20.470 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 2.2 | 17.120 ns | 0.0232 ns | 0.0206 ns | 17.119 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 3.0 | 17.751 ns | 0.0458 ns | 0.0429 ns | 17.751 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net461 | 24.614 ns | 0.0494 ns | 0.0462 ns | 24.628 ns |  1.20 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net472 | 23.048 ns | 0.0346 ns | 0.0289 ns | 23.041 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_ULong_Nullable_WithValue | .NET Core 2.0 | 12.885 ns | 0.0114 ns | 0.0106 ns | 12.885 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 2.2 | 11.871 ns | 0.0212 ns | 0.0188 ns | 11.872 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 3.0 |  8.451 ns | 0.0102 ns | 0.0090 ns |  8.450 ns |  0.66 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net461 | 16.365 ns | 0.0249 ns | 0.0220 ns | 16.362 ns |  1.27 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net472 | 14.587 ns | 0.1151 ns | 0.1077 ns | 14.567 ns |  1.13 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.643 ns | 0.0226 ns | 0.0189 ns | 20.640 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.222 ns | 0.0695 ns | 0.0616 ns | 17.245 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.573 ns | 0.0346 ns | 0.0323 ns | 17.568 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net461 | 22.120 ns | 0.0305 ns | 0.0271 ns | 22.127 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net472 | 23.047 ns | 0.0281 ns | 0.0249 ns | 23.052 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_ULong_Nullable_NoValue | .NET Core 2.0 | 13.376 ns | 0.1618 ns | 0.1514 ns | 13.373 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 2.2 | 11.623 ns | 0.0382 ns | 0.0357 ns | 11.601 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 3.0 |  8.506 ns | 0.0102 ns | 0.0085 ns |  8.509 ns |  0.64 |    0.01 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net461 | 14.722 ns | 0.0159 ns | 0.0149 ns | 14.725 ns |  1.10 |    0.01 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net472 | 13.321 ns | 0.0860 ns | 0.0805 ns | 13.361 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.525 ns | 0.0208 ns | 0.0195 ns | 15.525 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.894 ns | 0.0123 ns | 0.0103 ns | 12.893 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.902 ns | 0.0818 ns | 0.0765 ns | 12.949 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net461 | 16.102 ns | 0.0349 ns | 0.0291 ns | 16.090 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net472 | 16.117 ns | 0.0271 ns | 0.0254 ns | 16.114 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                       From_NullObject | .NET Core 2.0 | 15.885 ns | 0.0939 ns | 0.0878 ns | 15.834 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 2.2 | 13.444 ns | 0.0124 ns | 0.0097 ns | 13.442 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 3.0 | 12.770 ns | 0.0214 ns | 0.0190 ns | 12.769 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject |        net461 | 14.526 ns | 0.0117 ns | 0.0098 ns | 14.526 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                                       From_NullObject |        net472 | 16.954 ns | 0.0264 ns | 0.0234 ns | 16.951 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_DBNull | .NET Core 2.0 | 11.636 ns | 0.0134 ns | 0.0125 ns | 11.637 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 2.2 |  9.692 ns | 0.0602 ns | 0.0563 ns |  9.722 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 3.0 | 11.711 ns | 0.0387 ns | 0.0362 ns | 11.716 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull |        net461 | 14.277 ns | 0.0157 ns | 0.0139 ns | 14.278 ns |  1.23 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull |        net472 | 12.658 ns | 0.0148 ns | 0.0138 ns | 12.655 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_DBNull_AsObject | .NET Core 2.0 | 16.052 ns | 0.0307 ns | 0.0287 ns | 16.054 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 2.2 | 12.668 ns | 0.0127 ns | 0.0112 ns | 12.667 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 3.0 | 13.763 ns | 0.2987 ns | 0.4651 ns | 14.063 ns |  0.83 |    0.03 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net461 | 15.515 ns | 0.0212 ns | 0.0198 ns | 15.511 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net472 | 16.200 ns | 0.0479 ns | 0.0400 ns | 16.194 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                 From_ConvertibleClass | .NET Core 2.0 | 16.978 ns | 0.0230 ns | 0.0204 ns | 16.975 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 2.2 | 15.349 ns | 0.0252 ns | 0.0224 ns | 15.352 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 3.0 | 13.521 ns | 0.0187 ns | 0.0156 ns | 13.521 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net461 | 18.928 ns | 0.0193 ns | 0.0180 ns | 18.925 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net472 | 19.416 ns | 0.0370 ns | 0.0328 ns | 19.421 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_ConvertibleClass_AsObject | .NET Core 2.0 | 19.240 ns | 0.0293 ns | 0.0229 ns | 19.241 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 2.2 | 16.491 ns | 0.0140 ns | 0.0124 ns | 16.491 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 3.0 | 16.030 ns | 0.0421 ns | 0.0393 ns | 16.030 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net461 | 19.683 ns | 0.0500 ns | 0.0468 ns | 19.683 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net472 | 20.548 ns | 0.0223 ns | 0.0198 ns | 20.544 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_ConvertibleClass_NoValue | .NET Core 2.0 | 14.933 ns | 0.0269 ns | 0.0225 ns | 14.928 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 2.2 | 14.105 ns | 0.0263 ns | 0.0219 ns | 14.097 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 3.0 | 14.552 ns | 0.3110 ns | 0.5528 ns | 14.697 ns |  0.95 |    0.06 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net461 | 14.777 ns | 0.0203 ns | 0.0190 ns | 14.783 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net472 | 16.103 ns | 0.0159 ns | 0.0149 ns | 16.103 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.0 | 15.218 ns | 0.0228 ns | 0.0202 ns | 15.215 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.2 | 12.799 ns | 0.0419 ns | 0.0392 ns | 12.807 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 3.0 | 13.952 ns | 0.0145 ns | 0.0128 ns | 13.952 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net461 | 14.600 ns | 0.0230 ns | 0.0215 ns | 14.601 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net472 | 16.434 ns | 0.0232 ns | 0.0206 ns | 16.425 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                              From_NonConvertibleClass | .NET Core 2.0 | 13.186 ns | 0.0123 ns | 0.0115 ns | 13.184 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 2.2 | 11.622 ns | 0.0321 ns | 0.0300 ns | 11.608 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 3.0 | 12.231 ns | 0.2720 ns | 0.3341 ns | 12.402 ns |  0.92 |    0.03 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net461 | 14.185 ns | 0.0146 ns | 0.0129 ns | 14.184 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net472 | 14.043 ns | 0.0075 ns | 0.0066 ns | 14.045 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                     From_NonConvertibleClass_AsObject | .NET Core 2.0 | 18.037 ns | 0.0317 ns | 0.0281 ns | 18.031 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 2.2 | 14.846 ns | 0.0277 ns | 0.0259 ns | 14.837 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 3.0 | 14.903 ns | 0.0261 ns | 0.0231 ns | 14.903 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net461 | 19.136 ns | 0.0189 ns | 0.0167 ns | 19.139 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net472 | 18.424 ns | 0.0305 ns | 0.0270 ns | 18.426 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                      From_NonConvertibleClass_NoValue | .NET Core 2.0 | 13.304 ns | 0.0527 ns | 0.0493 ns | 13.324 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 2.2 | 11.697 ns | 0.0040 ns | 0.0031 ns | 11.697 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 3.0 | 11.681 ns | 0.0604 ns | 0.0565 ns | 11.698 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net461 | 14.490 ns | 0.0334 ns | 0.0296 ns | 14.494 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net472 | 14.247 ns | 0.0132 ns | 0.0117 ns | 14.245 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.0 | 15.370 ns | 0.0178 ns | 0.0158 ns | 15.371 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.2 | 12.669 ns | 0.0144 ns | 0.0128 ns | 12.669 ns |  0.82 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 3.0 | 13.847 ns | 0.0425 ns | 0.0397 ns | 13.851 ns |  0.90 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net461 | 14.564 ns | 0.0127 ns | 0.0113 ns | 14.563 ns |  0.95 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net472 | 17.298 ns | 0.0913 ns | 0.0763 ns | 17.334 ns |  1.13 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                From_ConvertibleStruct | .NET Core 2.0 | 20.628 ns | 0.0347 ns | 0.0324 ns | 20.632 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 2.2 | 16.235 ns | 0.0336 ns | 0.0298 ns | 16.239 ns |  0.79 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 3.0 | 14.088 ns | 0.3012 ns | 0.3094 ns | 13.876 ns |  0.68 |    0.01 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net461 | 21.878 ns | 0.0375 ns | 0.0333 ns | 21.867 ns |  1.06 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net472 | 21.583 ns | 0.0574 ns | 0.0509 ns | 21.583 ns |  1.05 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                       From_ConvertibleStruct_AsObject | .NET Core 2.0 | 19.686 ns | 0.0306 ns | 0.0286 ns | 19.681 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 2.2 | 16.156 ns | 0.0168 ns | 0.0149 ns | 16.152 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 3.0 | 16.527 ns | 0.0201 ns | 0.0188 ns | 16.529 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net461 | 22.433 ns | 0.0177 ns | 0.0156 ns | 22.432 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net472 | 22.163 ns | 0.0285 ns | 0.0267 ns | 22.166 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.0 | 25.224 ns | 0.0308 ns | 0.0257 ns | 25.220 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.2 | 16.824 ns | 0.0534 ns | 0.0499 ns | 16.827 ns |  0.67 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 3.0 | 13.170 ns | 0.2809 ns | 0.2627 ns | 13.346 ns |  0.52 |    0.01 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net461 | 21.895 ns | 0.0263 ns | 0.0246 ns | 21.889 ns |  0.87 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net472 | 19.880 ns | 0.0316 ns | 0.0280 ns | 19.873 ns |  0.79 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.999 ns | 0.0763 ns | 0.0713 ns | 20.021 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 16.170 ns | 0.0264 ns | 0.0234 ns | 16.169 ns |  0.81 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 16.846 ns | 0.0780 ns | 0.0729 ns | 16.858 ns |  0.84 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net461 | 20.413 ns | 0.0698 ns | 0.0653 ns | 20.422 ns |  1.02 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net472 | 22.021 ns | 0.0272 ns | 0.0255 ns | 22.011 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.0 | 15.972 ns | 0.0175 ns | 0.0164 ns | 15.969 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.2 | 12.109 ns | 0.0143 ns | 0.0119 ns | 12.113 ns |  0.76 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 3.0 |  8.237 ns | 0.1901 ns | 0.2602 ns |  8.367 ns |  0.51 |    0.02 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net461 | 15.046 ns | 0.0151 ns | 0.0141 ns | 15.041 ns |  0.94 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net472 | 13.098 ns | 0.0149 ns | 0.0132 ns | 13.101 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.973 ns | 0.0243 ns | 0.0203 ns | 15.968 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.465 ns | 0.0127 ns | 0.0106 ns | 13.461 ns |  0.84 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.125 ns | 0.0168 ns | 0.0157 ns | 13.126 ns |  0.82 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net461 | 14.562 ns | 0.0312 ns | 0.0292 ns | 14.559 ns |  0.91 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net472 | 17.162 ns | 0.0134 ns | 0.0125 ns | 17.165 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_NonConvertibleStruct | .NET Core 2.0 | 13.935 ns | 0.0146 ns | 0.0129 ns | 13.934 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 2.2 | 10.605 ns | 0.0102 ns | 0.0090 ns | 10.602 ns |  0.76 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 3.0 |  7.580 ns | 0.0126 ns | 0.0118 ns |  7.582 ns |  0.54 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net461 | 14.382 ns | 0.0846 ns | 0.0706 ns | 14.411 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net472 | 12.928 ns | 0.0670 ns | 0.0627 ns | 12.953 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.0 | 17.011 ns | 0.0209 ns | 0.0196 ns | 17.009 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.2 | 14.190 ns | 0.0493 ns | 0.0437 ns | 14.203 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 3.0 | 15.285 ns | 0.3212 ns | 0.3570 ns | 15.560 ns |  0.89 |    0.02 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net461 | 17.180 ns | 0.0229 ns | 0.0203 ns | 17.181 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net472 | 19.406 ns | 0.0155 ns | 0.0121 ns | 19.407 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.0 | 14.078 ns | 0.1049 ns | 0.0982 ns | 14.124 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.2 | 11.980 ns | 0.0382 ns | 0.0357 ns | 11.966 ns |  0.85 |    0.01 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 3.0 |  7.637 ns | 0.0101 ns | 0.0094 ns |  7.638 ns |  0.54 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net461 | 15.342 ns | 0.0112 ns | 0.0099 ns | 15.343 ns |  1.09 |    0.01 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net472 | 12.828 ns | 0.0190 ns | 0.0168 ns | 12.826 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.447 ns | 0.0229 ns | 0.0203 ns | 20.448 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 14.077 ns | 0.0141 ns | 0.0132 ns | 14.078 ns |  0.69 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 14.191 ns | 0.0260 ns | 0.0244 ns | 14.186 ns |  0.69 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net461 | 19.263 ns | 0.0143 ns | 0.0127 ns | 19.265 ns |  0.94 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net472 | 18.489 ns | 0.0195 ns | 0.0173 ns | 18.486 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.0 | 14.069 ns | 0.1332 ns | 0.1246 ns | 14.004 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.2 | 11.946 ns | 0.0106 ns | 0.0094 ns | 11.945 ns |  0.85 |    0.01 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 3.0 |  7.634 ns | 0.0168 ns | 0.0149 ns |  7.635 ns |  0.54 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net461 | 14.380 ns | 0.0195 ns | 0.0183 ns | 14.377 ns |  1.02 |    0.01 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net472 | 12.851 ns | 0.0090 ns | 0.0075 ns | 12.850 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.213 ns | 0.0292 ns | 0.0259 ns | 15.214 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.442 ns | 0.0186 ns | 0.0155 ns | 13.444 ns |  0.88 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.231 ns | 0.0644 ns | 0.0602 ns | 13.267 ns |  0.87 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net461 | 17.691 ns | 0.1258 ns | 0.1177 ns | 17.763 ns |  1.16 |    0.01 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net472 | 16.195 ns | 0.0199 ns | 0.0187 ns | 16.190 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Enum | .NET Core 2.0 | 13.919 ns | 0.0136 ns | 0.0127 ns | 13.917 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 2.2 | 11.116 ns | 0.0277 ns | 0.0259 ns | 11.119 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 3.0 |  7.024 ns | 0.0123 ns | 0.0115 ns |  7.020 ns |  0.50 |    0.00 |      - |     - |     - |         - |
                                             From_Enum |        net461 | 14.011 ns | 0.0174 ns | 0.0163 ns | 14.011 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                             From_Enum |        net472 | 15.012 ns | 0.0356 ns | 0.0333 ns | 15.000 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Enum_AsObject | .NET Core 2.0 | 49.028 ns | 0.3505 ns | 0.3278 ns | 49.095 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject | .NET Core 2.2 | 43.753 ns | 0.0983 ns | 0.0768 ns | 43.756 ns |  0.89 |    0.01 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject | .NET Core 3.0 | 42.681 ns | 0.0366 ns | 0.0305 ns | 42.685 ns |  0.87 |    0.01 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject |        net461 | 50.547 ns | 0.2283 ns | 0.2135 ns | 50.630 ns |  1.03 |    0.01 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject |        net472 | 53.879 ns | 0.3270 ns | 0.2899 ns | 53.977 ns |  1.10 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Enum_Nullable_WithValue | .NET Core 2.0 | 14.401 ns | 0.0170 ns | 0.0159 ns | 14.397 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 2.2 | 10.689 ns | 0.0486 ns | 0.0455 ns | 10.676 ns |  0.74 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 3.0 |  8.385 ns | 0.0547 ns | 0.0512 ns |  8.390 ns |  0.58 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net461 | 14.061 ns | 0.0133 ns | 0.0117 ns | 14.065 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net472 | 14.559 ns | 0.0210 ns | 0.0197 ns | 14.556 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.0 | 45.918 ns | 0.1164 ns | 0.1032 ns | 45.911 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.2 | 43.837 ns | 0.0686 ns | 0.0608 ns | 43.858 ns |  0.95 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 3.0 | 39.783 ns | 0.4350 ns | 0.4069 ns | 39.566 ns |  0.87 |    0.01 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject |        net461 | 50.162 ns | 0.0710 ns | 0.0664 ns | 50.165 ns |  1.09 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject |        net472 | 51.980 ns | 0.1652 ns | 0.1545 ns | 52.022 ns |  1.13 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Enum_Nullable_NoValue | .NET Core 2.0 | 14.094 ns | 0.0245 ns | 0.0230 ns | 14.096 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 2.2 | 11.837 ns | 0.0488 ns | 0.0457 ns | 11.819 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 3.0 |  7.316 ns | 0.0098 ns | 0.0087 ns |  7.316 ns |  0.52 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net461 | 14.145 ns | 0.0201 ns | 0.0178 ns | 14.145 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net472 | 12.960 ns | 0.0074 ns | 0.0066 ns | 12.959 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.274 ns | 0.0202 ns | 0.0189 ns | 15.273 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.547 ns | 0.0307 ns | 0.0287 ns | 13.552 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 3.0 | 16.067 ns | 0.0527 ns | 0.0467 ns | 16.080 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net461 | 14.603 ns | 0.0314 ns | 0.0278 ns | 14.597 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net472 | 16.116 ns | 0.0219 ns | 0.0205 ns | 16.113 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                      From_ParentClass | .NET Core 2.0 | 13.288 ns | 0.0741 ns | 0.0693 ns | 13.246 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 2.2 | 11.602 ns | 0.0093 ns | 0.0082 ns | 11.600 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 3.0 | 11.630 ns | 0.0498 ns | 0.0466 ns | 11.604 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                                      From_ParentClass |        net461 | 14.294 ns | 0.0366 ns | 0.0342 ns | 14.299 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                                      From_ParentClass |        net472 | 14.244 ns | 0.0164 ns | 0.0145 ns | 14.246 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_ParentClass_AsObject | .NET Core 2.0 | 17.469 ns | 0.0277 ns | 0.0259 ns | 17.465 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 2.2 | 14.529 ns | 0.0198 ns | 0.0176 ns | 14.526 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 3.0 | 14.587 ns | 0.0545 ns | 0.0483 ns | 14.587 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net461 | 19.692 ns | 0.1783 ns | 0.1668 ns | 19.580 ns |  1.13 |    0.01 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net472 | 18.652 ns | 0.0236 ns | 0.0209 ns | 18.654 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                              From_ParentClass_NoValue | .NET Core 2.0 | 13.731 ns | 0.0255 ns | 0.0226 ns | 13.723 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 2.2 | 12.454 ns | 0.0126 ns | 0.0111 ns | 12.453 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 3.0 | 13.119 ns | 0.4994 ns | 0.5945 ns | 12.800 ns |  0.97 |    0.05 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net461 | 14.201 ns | 0.0237 ns | 0.0221 ns | 14.193 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net472 | 15.599 ns | 0.0188 ns | 0.0167 ns | 15.595 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.0 | 15.343 ns | 0.0128 ns | 0.0113 ns | 15.345 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.2 | 12.686 ns | 0.0144 ns | 0.0127 ns | 12.685 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 3.0 | 13.146 ns | 0.0164 ns | 0.0153 ns | 13.139 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net461 | 14.529 ns | 0.0167 ns | 0.0139 ns | 14.528 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net472 | 17.139 ns | 0.0189 ns | 0.0177 ns | 17.142 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_ParentStruct | .NET Core 2.0 | 40.089 ns | 0.0500 ns | 0.0467 ns | 40.098 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 2.2 | 38.115 ns | 0.1024 ns | 0.0958 ns | 38.132 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 3.0 | 36.276 ns | 0.0528 ns | 0.0441 ns | 36.284 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct |        net461 | 45.198 ns | 0.1261 ns | 0.1180 ns | 45.148 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct |        net472 | 41.385 ns | 0.0383 ns | 0.0340 ns | 41.388 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_ParentStruct_AsObject | .NET Core 2.0 | 18.072 ns | 0.0222 ns | 0.0208 ns | 18.076 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 2.2 | 14.499 ns | 0.0258 ns | 0.0215 ns | 14.498 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 3.0 | 13.858 ns | 0.0401 ns | 0.0376 ns | 13.859 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net461 | 17.545 ns | 0.0828 ns | 0.0774 ns | 17.586 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net472 | 18.998 ns | 0.0196 ns | 0.0184 ns | 18.992 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.0 | 44.761 ns | 0.1741 ns | 0.1628 ns | 44.803 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.2 | 38.474 ns | 0.0397 ns | 0.0371 ns | 38.480 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 3.0 | 36.928 ns | 0.6988 ns | 0.6537 ns | 36.589 ns |  0.82 |    0.01 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue |        net461 | 39.221 ns | 0.0709 ns | 0.0592 ns | 39.231 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue |        net472 | 39.419 ns | 0.0925 ns | 0.0820 ns | 39.409 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.553 ns | 0.0179 ns | 0.0159 ns | 18.551 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 14.497 ns | 0.0209 ns | 0.0185 ns | 14.495 ns |  0.78 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 14.486 ns | 0.0310 ns | 0.0290 ns | 14.487 ns |  0.78 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net461 | 17.262 ns | 0.0202 ns | 0.0189 ns | 17.260 ns |  0.93 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net472 | 19.793 ns | 0.0669 ns | 0.0626 ns | 19.807 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.0 | 40.211 ns | 0.2276 ns | 0.2129 ns | 40.111 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.2 | 38.060 ns | 0.0716 ns | 0.0670 ns | 38.016 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 3.0 | 35.738 ns | 0.0941 ns | 0.0880 ns | 35.721 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net461 | 42.692 ns | 0.0386 ns | 0.0361 ns | 42.684 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net472 | 38.631 ns | 0.0381 ns | 0.0356 ns | 38.630 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 16.067 ns | 0.0484 ns | 0.0453 ns | 16.046 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.668 ns | 0.0133 ns | 0.0117 ns | 12.670 ns |  0.79 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.396 ns | 0.0377 ns | 0.0334 ns | 14.398 ns |  0.90 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net461 | 14.608 ns | 0.0197 ns | 0.0174 ns | 14.606 ns |  0.91 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net472 | 16.885 ns | 0.0205 ns | 0.0182 ns | 16.886 ns |  1.05 |    0.00 |      - |     - |     - |         - |

Benchmarks with issues:
  ConvertTo_LongNullable.From_DateTime_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_LongNullable.From_DateTime_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_LongNullable.From_DateTime_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_LongNullable.From_DateTime_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_LongNullable.From_DateTime_AsObject: Job-ZVTGBZ(Toolchain=net472)
  ConvertTo_LongNullable.From_DateTime_Nullable_WithValue_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_LongNullable.From_DateTime_Nullable_WithValue_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_LongNullable.From_DateTime_Nullable_WithValue_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_LongNullable.From_DateTime_Nullable_WithValue_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_LongNullable.From_DateTime_Nullable_WithValue_AsObject: Job-ZVTGBZ(Toolchain=net472)
  ConvertTo_LongNullable.From_String_Empty_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_LongNullable.From_String_Empty_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_LongNullable.From_String_Empty_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_LongNullable.From_String_Empty_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_LongNullable.From_String_Empty_AsObject: Job-ZVTGBZ(Toolchain=net472)
