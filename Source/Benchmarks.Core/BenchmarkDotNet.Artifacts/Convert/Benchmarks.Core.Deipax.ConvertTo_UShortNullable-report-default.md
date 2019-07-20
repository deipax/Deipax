
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
                                             From_Bool | .NET Core 2.0 | 12.917 ns | 0.0117 ns | 0.0110 ns | 12.916 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 2.2 | 10.411 ns | 0.0190 ns | 0.0159 ns | 10.415 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 3.0 |  9.639 ns | 0.0111 ns | 0.0098 ns |  9.640 ns |  0.75 |    0.00 |      - |     - |     - |         - |
                                             From_Bool |        net461 | 14.282 ns | 0.0393 ns | 0.0348 ns | 14.290 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                             From_Bool |        net472 | 12.249 ns | 0.0246 ns | 0.0218 ns | 12.245 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Bool_AsObject | .NET Core 2.0 | 19.179 ns | 0.0394 ns | 0.0368 ns | 19.195 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 2.2 | 17.284 ns | 0.0151 ns | 0.0126 ns | 17.284 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 3.0 | 19.492 ns | 0.0906 ns | 0.0847 ns | 19.505 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net461 | 27.194 ns | 0.0425 ns | 0.0397 ns | 27.189 ns |  1.42 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net472 | 28.667 ns | 0.0574 ns | 0.0537 ns | 28.673 ns |  1.49 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Bool_Nullable_WithValue | .NET Core 2.0 | 12.048 ns | 0.0142 ns | 0.0126 ns | 12.049 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 2.2 | 10.674 ns | 0.0111 ns | 0.0087 ns | 10.673 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 3.0 |  9.875 ns | 0.0131 ns | 0.0122 ns |  9.871 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net461 | 13.442 ns | 0.0206 ns | 0.0182 ns | 13.436 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net472 | 13.414 ns | 0.0149 ns | 0.0140 ns | 13.415 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.332 ns | 0.0238 ns | 0.0211 ns | 19.335 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.2 | 18.216 ns | 0.0170 ns | 0.0159 ns | 18.215 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 3.0 | 20.346 ns | 0.1696 ns | 0.1587 ns | 20.369 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net461 | 26.962 ns | 0.0500 ns | 0.0468 ns | 26.951 ns |  1.39 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net472 | 28.963 ns | 0.1648 ns | 0.1542 ns | 29.017 ns |  1.50 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Bool_Nullable_NoValue | .NET Core 2.0 | 11.861 ns | 0.0157 ns | 0.0147 ns | 11.855 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 2.2 | 10.297 ns | 0.0114 ns | 0.0107 ns | 10.297 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 3.0 |  9.639 ns | 0.0104 ns | 0.0092 ns |  9.638 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net461 | 14.056 ns | 0.0156 ns | 0.0130 ns | 14.056 ns |  1.19 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net472 | 13.499 ns | 0.0208 ns | 0.0184 ns | 13.498 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.727 ns | 0.0466 ns | 0.0413 ns | 15.739 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.010 ns | 0.0591 ns | 0.0552 ns | 13.033 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.400 ns | 0.0358 ns | 0.0317 ns | 13.393 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net461 | 22.635 ns | 0.0328 ns | 0.0307 ns | 22.641 ns |  1.44 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net472 | 26.299 ns | 0.0590 ns | 0.0552 ns | 26.275 ns |  1.67 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Byte | .NET Core 2.0 | 12.343 ns | 0.0177 ns | 0.0157 ns | 12.343 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 2.2 | 10.736 ns | 0.0103 ns | 0.0086 ns | 10.739 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 3.0 |  9.445 ns | 0.0288 ns | 0.0270 ns |  9.435 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                                             From_Byte |        net461 | 14.499 ns | 0.0647 ns | 0.0605 ns | 14.531 ns |  1.18 |    0.01 |      - |     - |     - |         - |
                                             From_Byte |        net472 | 12.245 ns | 0.0272 ns | 0.0241 ns | 12.238 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Byte_AsObject | .NET Core 2.0 | 19.749 ns | 0.0424 ns | 0.0396 ns | 19.747 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 2.2 | 17.072 ns | 0.0274 ns | 0.0229 ns | 17.076 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 3.0 | 19.740 ns | 0.0310 ns | 0.0290 ns | 19.743 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net461 | 26.760 ns | 0.0290 ns | 0.0242 ns | 26.766 ns |  1.35 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net472 | 30.180 ns | 0.0459 ns | 0.0429 ns | 30.174 ns |  1.53 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Byte_Nullable_WithValue | .NET Core 2.0 | 11.817 ns | 0.0130 ns | 0.0116 ns | 11.817 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 2.2 | 10.684 ns | 0.0212 ns | 0.0199 ns | 10.680 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 3.0 | 10.102 ns | 0.0158 ns | 0.0148 ns | 10.103 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net461 | 14.231 ns | 0.0385 ns | 0.0360 ns | 14.246 ns |  1.20 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net472 | 15.509 ns | 0.0166 ns | 0.0147 ns | 15.506 ns |  1.31 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.527 ns | 0.0263 ns | 0.0233 ns | 20.530 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.080 ns | 0.0173 ns | 0.0145 ns | 17.083 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.070 ns | 0.0591 ns | 0.0524 ns | 18.077 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net461 | 27.228 ns | 0.0453 ns | 0.0424 ns | 27.221 ns |  1.33 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net472 | 29.112 ns | 0.0699 ns | 0.0654 ns | 29.090 ns |  1.42 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Byte_Nullable_NoValue | .NET Core 2.0 | 11.843 ns | 0.0102 ns | 0.0090 ns | 11.845 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 2.2 | 10.370 ns | 0.0576 ns | 0.0539 ns | 10.403 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 3.0 |  9.648 ns | 0.0116 ns | 0.0103 ns |  9.649 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net461 | 14.095 ns | 0.0272 ns | 0.0241 ns | 14.095 ns |  1.19 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net472 | 12.723 ns | 0.0294 ns | 0.0260 ns | 12.711 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.793 ns | 0.0204 ns | 0.0191 ns | 14.788 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.2 | 15.526 ns | 0.3786 ns | 1.1104 ns | 15.388 ns |  1.05 |    0.08 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.361 ns | 0.0159 ns | 0.0141 ns | 13.359 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net461 | 22.605 ns | 0.0207 ns | 0.0184 ns | 22.605 ns |  1.53 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net472 | 24.287 ns | 0.0430 ns | 0.0381 ns | 24.290 ns |  1.64 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Char | .NET Core 2.0 | 12.333 ns | 0.0847 ns | 0.0792 ns | 12.359 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Char | .NET Core 2.2 | 10.372 ns | 0.0151 ns | 0.0134 ns | 10.371 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                                             From_Char | .NET Core 3.0 |  9.720 ns | 0.0609 ns | 0.0570 ns |  9.736 ns |  0.79 |    0.01 |      - |     - |     - |         - |
                                             From_Char |        net461 | 13.758 ns | 0.0266 ns | 0.0236 ns | 13.749 ns |  1.12 |    0.01 |      - |     - |     - |         - |
                                             From_Char |        net472 | 12.275 ns | 0.0126 ns | 0.0117 ns | 12.273 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Char_AsObject | .NET Core 2.0 | 19.486 ns | 0.0327 ns | 0.0306 ns | 19.488 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 2.2 | 17.527 ns | 0.0209 ns | 0.0185 ns | 17.528 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 3.0 | 18.385 ns | 0.0684 ns | 0.0640 ns | 18.363 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject |        net461 | 29.264 ns | 0.0462 ns | 0.0360 ns | 29.262 ns |  1.50 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject |        net472 | 29.021 ns | 0.2269 ns | 0.2122 ns | 29.109 ns |  1.49 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Char_Nullable_WithValue | .NET Core 2.0 | 11.869 ns | 0.0160 ns | 0.0149 ns | 11.869 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 2.2 | 10.643 ns | 0.0093 ns | 0.0087 ns | 10.640 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 3.0 |  9.944 ns | 0.0145 ns | 0.0129 ns |  9.942 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net461 | 13.417 ns | 0.0083 ns | 0.0074 ns | 13.419 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net472 | 13.418 ns | 0.0334 ns | 0.0313 ns | 13.423 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.241 ns | 0.0946 ns | 0.0885 ns | 20.272 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.2 | 18.169 ns | 0.0758 ns | 0.0672 ns | 18.192 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 3.0 | 19.679 ns | 0.0424 ns | 0.0354 ns | 19.696 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net461 | 26.789 ns | 0.0446 ns | 0.0417 ns | 26.799 ns |  1.32 |    0.01 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net472 | 29.700 ns | 0.0480 ns | 0.0426 ns | 29.702 ns |  1.47 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Char_Nullable_NoValue | .NET Core 2.0 | 12.287 ns | 0.0116 ns | 0.0097 ns | 12.288 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 2.2 | 10.365 ns | 0.0138 ns | 0.0130 ns | 10.368 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 3.0 |  9.489 ns | 0.0104 ns | 0.0097 ns |  9.490 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net461 | 14.227 ns | 0.0487 ns | 0.0455 ns | 14.240 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net472 | 12.711 ns | 0.0173 ns | 0.0153 ns | 12.710 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.775 ns | 0.0089 ns | 0.0079 ns | 14.774 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.905 ns | 0.0106 ns | 0.0099 ns | 12.906 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.174 ns | 0.0146 ns | 0.0136 ns | 13.167 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net461 | 22.637 ns | 0.0316 ns | 0.0280 ns | 22.640 ns |  1.53 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net472 | 24.274 ns | 0.0290 ns | 0.0257 ns | 24.276 ns |  1.64 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                         From_DateTime | .NET Core 2.0 | 12.726 ns | 0.0122 ns | 0.0102 ns | 12.727 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 2.2 | 11.165 ns | 0.0225 ns | 0.0211 ns | 11.160 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 3.0 |  9.942 ns | 0.0208 ns | 0.0195 ns |  9.938 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime |        net461 | 16.368 ns | 0.0728 ns | 0.0645 ns | 16.342 ns |  1.29 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime |        net472 | 13.682 ns | 0.0224 ns | 0.0198 ns | 13.679 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                From_DateTime_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                      From_DateTime_Nullable_WithValue | .NET Core 2.0 | 12.321 ns | 0.0083 ns | 0.0074 ns | 12.323 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 2.2 | 11.642 ns | 0.0256 ns | 0.0239 ns | 11.639 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 3.0 | 10.145 ns | 0.0257 ns | 0.0240 ns | 10.143 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net461 | 13.888 ns | 0.0196 ns | 0.0174 ns | 13.889 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net472 | 13.306 ns | 0.0537 ns | 0.0502 ns | 13.299 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_DateTime_Nullable_NoValue | .NET Core 2.0 | 12.322 ns | 0.0161 ns | 0.0151 ns | 12.319 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 2.2 | 11.249 ns | 0.0148 ns | 0.0123 ns | 11.254 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 3.0 | 10.175 ns | 0.0262 ns | 0.0245 ns | 10.183 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net461 | 13.830 ns | 0.0156 ns | 0.0130 ns | 13.827 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net472 | 13.236 ns | 0.0253 ns | 0.0237 ns | 13.235 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.770 ns | 0.0138 ns | 0.0129 ns | 14.772 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.929 ns | 0.0178 ns | 0.0158 ns | 12.926 ns |  0.88 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.962 ns | 0.0236 ns | 0.0197 ns | 14.960 ns |  1.01 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net461 | 26.299 ns | 0.1005 ns | 0.0940 ns | 26.276 ns |  1.78 |    0.01 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net472 | 24.116 ns | 0.0540 ns | 0.0505 ns | 24.105 ns |  1.63 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                          From_Decimal | .NET Core 2.0 | 26.143 ns | 0.0319 ns | 0.0283 ns | 26.147 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 2.2 | 25.375 ns | 0.0601 ns | 0.0562 ns | 25.369 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 3.0 | 14.326 ns | 0.0235 ns | 0.0219 ns | 14.323 ns |  0.55 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal |        net461 | 29.341 ns | 0.0688 ns | 0.0610 ns | 29.319 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal |        net472 | 27.310 ns | 0.1232 ns | 0.1152 ns | 27.267 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                 From_Decimal_AsObject | .NET Core 2.0 | 31.356 ns | 0.2331 ns | 0.2181 ns | 31.242 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 2.2 | 29.331 ns | 0.0429 ns | 0.0401 ns | 29.328 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 3.0 | 23.065 ns | 0.0681 ns | 0.0604 ns | 23.089 ns |  0.74 |    0.01 |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net461 | 38.503 ns | 0.0849 ns | 0.0752 ns | 38.474 ns |  1.23 |    0.01 |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net472 | 37.799 ns | 0.0528 ns | 0.0468 ns | 37.793 ns |  1.21 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                       From_Decimal_Nullable_WithValue | .NET Core 2.0 | 26.150 ns | 0.0338 ns | 0.0299 ns | 26.150 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 2.2 | 24.578 ns | 0.1002 ns | 0.0937 ns | 24.626 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 3.0 | 19.571 ns | 0.0314 ns | 0.0294 ns | 19.566 ns |  0.75 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net461 | 27.148 ns | 0.0380 ns | 0.0356 ns | 27.152 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net472 | 26.331 ns | 0.0387 ns | 0.0362 ns | 26.322 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.0 | 30.821 ns | 0.0649 ns | 0.0607 ns | 30.817 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.2 | 29.683 ns | 0.0428 ns | 0.0379 ns | 29.690 ns |  0.96 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 3.0 | 23.316 ns | 0.2461 ns | 0.2302 ns | 23.456 ns |  0.76 |    0.01 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net461 | 38.275 ns | 0.0632 ns | 0.0528 ns | 38.254 ns |  1.24 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net472 | 37.755 ns | 0.0362 ns | 0.0302 ns | 37.766 ns |  1.23 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Decimal_Nullable_NoValue | .NET Core 2.0 | 12.521 ns | 0.0157 ns | 0.0139 ns | 12.522 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 2.2 | 11.479 ns | 0.0107 ns | 0.0095 ns | 11.478 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 3.0 |  9.928 ns | 0.0129 ns | 0.0108 ns |  9.924 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net461 | 15.263 ns | 0.0692 ns | 0.0647 ns | 15.255 ns |  1.22 |    0.01 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net472 | 13.451 ns | 0.0251 ns | 0.0209 ns | 13.445 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.792 ns | 0.0147 ns | 0.0138 ns | 14.792 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.901 ns | 0.0097 ns | 0.0081 ns | 12.902 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.970 ns | 0.2940 ns | 0.3268 ns | 13.702 ns |  0.94 |    0.02 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net461 | 22.581 ns | 0.0304 ns | 0.0269 ns | 22.584 ns |  1.53 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net472 | 26.195 ns | 0.0461 ns | 0.0431 ns | 26.194 ns |  1.77 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_Double | .NET Core 2.0 | 15.438 ns | 0.0157 ns | 0.0139 ns | 15.441 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 2.2 | 13.126 ns | 0.0188 ns | 0.0176 ns | 13.129 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 3.0 | 12.438 ns | 0.0181 ns | 0.0161 ns | 12.436 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                                           From_Double |        net461 | 16.142 ns | 0.0292 ns | 0.0259 ns | 16.137 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                           From_Double |        net472 | 15.324 ns | 0.0165 ns | 0.0146 ns | 15.321 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_Double_AsObject | .NET Core 2.0 | 22.346 ns | 0.0478 ns | 0.0447 ns | 22.334 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 2.2 | 19.718 ns | 0.0784 ns | 0.0734 ns | 19.736 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 3.0 | 21.431 ns | 0.0226 ns | 0.0176 ns | 21.426 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject |        net461 | 33.217 ns | 0.0413 ns | 0.0366 ns | 33.209 ns |  1.49 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject |        net472 | 32.688 ns | 0.0307 ns | 0.0256 ns | 32.687 ns |  1.46 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_Double_Nullable_WithValue | .NET Core 2.0 | 17.048 ns | 0.0780 ns | 0.0691 ns | 17.070 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 2.2 | 14.308 ns | 0.0217 ns | 0.0203 ns | 14.306 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 3.0 | 13.214 ns | 0.1589 ns | 0.1486 ns | 13.143 ns |  0.78 |    0.01 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net461 | 18.350 ns | 0.0096 ns | 0.0075 ns | 18.350 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net472 | 17.661 ns | 0.0179 ns | 0.0159 ns | 17.659 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.0 | 21.907 ns | 0.1265 ns | 0.1184 ns | 21.952 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.2 | 19.627 ns | 0.0321 ns | 0.0285 ns | 19.628 ns |  0.90 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 3.0 | 21.218 ns | 0.3648 ns | 0.3413 ns | 21.388 ns |  0.97 |    0.01 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net461 | 29.860 ns | 0.0705 ns | 0.0625 ns | 29.861 ns |  1.36 |    0.01 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net472 | 32.521 ns | 0.0429 ns | 0.0401 ns | 32.516 ns |  1.48 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Double_Nullable_NoValue | .NET Core 2.0 | 12.313 ns | 0.0128 ns | 0.0107 ns | 12.312 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 2.2 | 11.409 ns | 0.0081 ns | 0.0072 ns | 11.411 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 3.0 |  9.894 ns | 0.0091 ns | 0.0081 ns |  9.896 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net461 | 14.880 ns | 0.0572 ns | 0.0507 ns | 14.898 ns |  1.21 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net472 | 15.893 ns | 0.0183 ns | 0.0153 ns | 15.891 ns |  1.29 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.818 ns | 0.0253 ns | 0.0236 ns | 14.818 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.913 ns | 0.0167 ns | 0.0148 ns | 12.908 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.713 ns | 0.0147 ns | 0.0130 ns | 14.712 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net461 | 22.126 ns | 0.0636 ns | 0.0564 ns | 22.134 ns |  1.49 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net472 | 25.566 ns | 0.0295 ns | 0.0276 ns | 25.565 ns |  1.73 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_Short | .NET Core 2.0 | 12.334 ns | 0.0117 ns | 0.0104 ns | 12.331 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 2.2 | 10.444 ns | 0.0532 ns | 0.0498 ns | 10.466 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 3.0 |  9.684 ns | 0.0552 ns | 0.0517 ns |  9.655 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                                            From_Short |        net461 | 13.765 ns | 0.0948 ns | 0.0887 ns | 13.740 ns |  1.12 |    0.01 |      - |     - |     - |         - |
                                            From_Short |        net472 | 13.082 ns | 0.0407 ns | 0.0361 ns | 13.064 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_Short_AsObject | .NET Core 2.0 | 20.235 ns | 0.1356 ns | 0.1268 ns | 20.307 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 2.2 | 17.536 ns | 0.0225 ns | 0.0200 ns | 17.531 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 3.0 | 18.204 ns | 0.1594 ns | 0.1491 ns | 18.287 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net461 | 27.346 ns | 0.0276 ns | 0.0231 ns | 27.351 ns |  1.35 |    0.01 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net472 | 30.543 ns | 0.0623 ns | 0.0552 ns | 30.548 ns |  1.51 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Short_Nullable_WithValue | .NET Core 2.0 | 12.471 ns | 0.0127 ns | 0.0106 ns | 12.473 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 2.2 | 10.660 ns | 0.0100 ns | 0.0089 ns | 10.659 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 3.0 |  9.965 ns | 0.0105 ns | 0.0093 ns |  9.966 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net461 | 14.998 ns | 0.0356 ns | 0.0333 ns | 14.987 ns |  1.20 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net472 | 13.561 ns | 0.0154 ns | 0.0136 ns | 13.558 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.216 ns | 0.0367 ns | 0.0326 ns | 20.218 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.519 ns | 0.0155 ns | 0.0130 ns | 17.513 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 3.0 | 19.623 ns | 0.0518 ns | 0.0485 ns | 19.619 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net461 | 27.514 ns | 0.0593 ns | 0.0495 ns | 27.516 ns |  1.36 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net472 | 29.482 ns | 0.0470 ns | 0.0440 ns | 29.482 ns |  1.46 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Short_Nullable_NoValue | .NET Core 2.0 | 12.078 ns | 0.0116 ns | 0.0103 ns | 12.077 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 2.2 | 10.387 ns | 0.0122 ns | 0.0108 ns | 10.386 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 3.0 |  9.724 ns | 0.0131 ns | 0.0116 ns |  9.722 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net461 | 13.507 ns | 0.0385 ns | 0.0360 ns | 13.501 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net472 | 12.726 ns | 0.0149 ns | 0.0133 ns | 12.723 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.814 ns | 0.0397 ns | 0.0372 ns | 14.801 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.928 ns | 0.0093 ns | 0.0077 ns | 12.928 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.728 ns | 0.0263 ns | 0.0233 ns | 14.722 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net461 | 21.839 ns | 0.0362 ns | 0.0339 ns | 21.832 ns |  1.47 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net472 | 24.376 ns | 0.0386 ns | 0.0361 ns | 24.360 ns |  1.65 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                              From_Int | .NET Core 2.0 | 13.211 ns | 0.0128 ns | 0.0107 ns | 13.212 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 2.2 | 11.480 ns | 0.0098 ns | 0.0087 ns | 11.479 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 3.0 |  9.746 ns | 0.0193 ns | 0.0180 ns |  9.745 ns |  0.74 |    0.00 |      - |     - |     - |         - |
                                              From_Int |        net461 | 14.555 ns | 0.0229 ns | 0.0215 ns | 14.554 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                              From_Int |        net472 | 13.059 ns | 0.0681 ns | 0.0637 ns | 13.029 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_Int_AsObject | .NET Core 2.0 | 19.882 ns | 0.0351 ns | 0.0311 ns | 19.878 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 2.2 | 17.757 ns | 0.0291 ns | 0.0258 ns | 17.754 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 3.0 | 18.601 ns | 0.0281 ns | 0.0249 ns | 18.589 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net461 | 27.082 ns | 0.0233 ns | 0.0194 ns | 27.083 ns |  1.36 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net472 | 29.601 ns | 0.0319 ns | 0.0266 ns | 29.590 ns |  1.49 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Int_Nullable_WithValue | .NET Core 2.0 | 13.013 ns | 0.0703 ns | 0.0657 ns | 13.045 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 2.2 | 12.446 ns | 0.0097 ns | 0.0086 ns | 12.444 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 3.0 | 10.202 ns | 0.0173 ns | 0.0162 ns | 10.203 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net461 | 14.543 ns | 0.0639 ns | 0.0598 ns | 14.560 ns |  1.12 |    0.01 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net472 | 13.414 ns | 0.0141 ns | 0.0132 ns | 13.416 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.0 | 21.004 ns | 0.0139 ns | 0.0130 ns | 21.004 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.815 ns | 0.0584 ns | 0.0547 ns | 17.808 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.714 ns | 0.0485 ns | 0.0430 ns | 18.707 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net461 | 27.415 ns | 0.0460 ns | 0.0408 ns | 27.412 ns |  1.31 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net472 | 29.905 ns | 0.1016 ns | 0.0950 ns | 29.916 ns |  1.42 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_Int_Nullable_NoValue | .NET Core 2.0 | 12.233 ns | 0.0138 ns | 0.0129 ns | 12.231 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 2.2 | 10.306 ns | 0.0088 ns | 0.0078 ns | 10.304 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 3.0 |  9.663 ns | 0.0171 ns | 0.0143 ns |  9.665 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net461 | 14.079 ns | 0.0150 ns | 0.0125 ns | 14.078 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net472 | 12.912 ns | 0.0157 ns | 0.0131 ns | 12.911 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.0 | 16.328 ns | 0.0190 ns | 0.0168 ns | 16.328 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.929 ns | 0.0105 ns | 0.0098 ns | 12.931 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.636 ns | 0.0353 ns | 0.0330 ns | 13.638 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net461 | 22.614 ns | 0.0413 ns | 0.0386 ns | 22.605 ns |  1.39 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net472 | 24.701 ns | 0.0956 ns | 0.0847 ns | 24.727 ns |  1.51 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Long | .NET Core 2.0 | 16.816 ns | 0.0179 ns | 0.0167 ns | 16.813 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Long | .NET Core 2.2 | 11.439 ns | 0.0084 ns | 0.0075 ns | 11.441 ns |  0.68 |    0.00 |      - |     - |     - |         - |
                                             From_Long | .NET Core 3.0 |  9.883 ns | 0.0076 ns | 0.0064 ns |  9.882 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                                             From_Long |        net461 | 13.950 ns | 0.0296 ns | 0.0231 ns | 13.956 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                             From_Long |        net472 | 13.014 ns | 0.0146 ns | 0.0130 ns | 13.012 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Long_AsObject | .NET Core 2.0 | 20.039 ns | 0.1015 ns | 0.0949 ns | 20.085 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 2.2 | 18.037 ns | 0.0226 ns | 0.0201 ns | 18.034 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 3.0 | 19.219 ns | 0.0203 ns | 0.0190 ns | 19.223 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net461 | 27.453 ns | 0.0383 ns | 0.0340 ns | 27.453 ns |  1.37 |    0.01 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net472 | 29.734 ns | 0.1710 ns | 0.1600 ns | 29.653 ns |  1.48 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Long_Nullable_WithValue | .NET Core 2.0 | 14.790 ns | 0.0165 ns | 0.0137 ns | 14.796 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 2.2 | 13.496 ns | 0.0193 ns | 0.0171 ns | 13.492 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 3.0 | 10.589 ns | 0.0116 ns | 0.0102 ns | 10.589 ns |  0.72 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net461 | 16.065 ns | 0.0317 ns | 0.0297 ns | 16.067 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net472 | 15.762 ns | 0.0187 ns | 0.0174 ns | 15.756 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.194 ns | 0.0180 ns | 0.0168 ns | 20.194 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.2 | 18.512 ns | 0.2211 ns | 0.2068 ns | 18.405 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 3.0 | 19.774 ns | 0.0800 ns | 0.0748 ns | 19.790 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net461 | 27.689 ns | 0.0414 ns | 0.0345 ns | 27.684 ns |  1.37 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net472 | 29.750 ns | 0.0514 ns | 0.0456 ns | 29.733 ns |  1.47 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Long_Nullable_NoValue | .NET Core 2.0 | 12.254 ns | 0.0108 ns | 0.0096 ns | 12.256 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 2.2 | 11.258 ns | 0.0149 ns | 0.0132 ns | 11.255 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 3.0 |  9.651 ns | 0.0072 ns | 0.0064 ns |  9.652 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net461 | 14.149 ns | 0.0225 ns | 0.0188 ns | 14.150 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net472 | 13.390 ns | 0.0278 ns | 0.0260 ns | 13.386 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.428 ns | 0.0180 ns | 0.0160 ns | 15.422 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.954 ns | 0.0161 ns | 0.0143 ns | 12.950 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.723 ns | 0.0157 ns | 0.0123 ns | 14.726 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net461 | 22.702 ns | 0.0329 ns | 0.0308 ns | 22.687 ns |  1.47 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net472 | 24.408 ns | 0.0903 ns | 0.0845 ns | 24.375 ns |  1.58 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_SByte | .NET Core 2.0 | 12.445 ns | 0.0549 ns | 0.0514 ns | 12.457 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 2.2 | 11.087 ns | 0.0563 ns | 0.0526 ns | 11.107 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 3.0 |  9.536 ns | 0.0137 ns | 0.0128 ns |  9.536 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                                            From_SByte |        net461 | 14.627 ns | 0.0235 ns | 0.0220 ns | 14.629 ns |  1.18 |    0.00 |      - |     - |     - |         - |
                                            From_SByte |        net472 | 13.024 ns | 0.0220 ns | 0.0206 ns | 13.020 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_SByte_AsObject | .NET Core 2.0 | 19.458 ns | 0.0211 ns | 0.0187 ns | 19.457 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 2.2 | 18.034 ns | 0.0137 ns | 0.0121 ns | 18.029 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 3.0 | 18.332 ns | 0.4618 ns | 0.7841 ns | 17.909 ns |  0.98 |    0.05 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net461 | 27.517 ns | 0.0306 ns | 0.0286 ns | 27.511 ns |  1.41 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net472 | 30.658 ns | 0.0285 ns | 0.0238 ns | 30.668 ns |  1.58 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_SByte_Nullable_WithValue | .NET Core 2.0 | 12.052 ns | 0.0215 ns | 0.0190 ns | 12.050 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 2.2 | 10.771 ns | 0.0318 ns | 0.0266 ns | 10.775 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 3.0 |  9.872 ns | 0.0117 ns | 0.0104 ns |  9.870 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net461 | 15.274 ns | 0.0782 ns | 0.0732 ns | 15.317 ns |  1.27 |    0.01 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net472 | 16.405 ns | 0.0226 ns | 0.0200 ns | 16.400 ns |  1.36 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.0 | 22.218 ns | 0.0705 ns | 0.0659 ns | 22.230 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.560 ns | 0.0210 ns | 0.0196 ns | 17.555 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 3.0 | 19.909 ns | 0.4254 ns | 0.8196 ns | 20.245 ns |  0.86 |    0.05 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net461 | 27.232 ns | 0.0579 ns | 0.0542 ns | 27.222 ns |  1.23 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net472 | 30.665 ns | 0.0332 ns | 0.0277 ns | 30.667 ns |  1.38 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_SByte_Nullable_NoValue | .NET Core 2.0 | 12.392 ns | 0.0347 ns | 0.0325 ns | 12.377 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 2.2 | 10.273 ns | 0.0061 ns | 0.0051 ns | 10.274 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 3.0 |  9.423 ns | 0.0120 ns | 0.0112 ns |  9.425 ns |  0.76 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net461 | 13.445 ns | 0.0167 ns | 0.0148 ns | 13.441 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net472 | 13.434 ns | 0.0626 ns | 0.0586 ns | 13.403 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.800 ns | 0.0133 ns | 0.0118 ns | 14.800 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.043 ns | 0.0091 ns | 0.0071 ns | 13.045 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.318 ns | 0.0203 ns | 0.0180 ns | 13.311 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net461 | 26.142 ns | 0.0286 ns | 0.0253 ns | 26.144 ns |  1.77 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net472 | 24.390 ns | 0.0333 ns | 0.0311 ns | 24.389 ns |  1.65 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_Float | .NET Core 2.0 | 15.539 ns | 0.0228 ns | 0.0190 ns | 15.536 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 2.2 | 13.109 ns | 0.0264 ns | 0.0234 ns | 13.101 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 3.0 | 12.427 ns | 0.0136 ns | 0.0127 ns | 12.427 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                            From_Float |        net461 | 16.449 ns | 0.0221 ns | 0.0206 ns | 16.447 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                            From_Float |        net472 | 15.647 ns | 0.0293 ns | 0.0274 ns | 15.640 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_Float_AsObject | .NET Core 2.0 | 21.836 ns | 0.0224 ns | 0.0187 ns | 21.834 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 2.2 | 19.664 ns | 0.0324 ns | 0.0303 ns | 19.654 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 3.0 | 20.213 ns | 0.0388 ns | 0.0363 ns | 20.199 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject |        net461 | 30.400 ns | 0.0652 ns | 0.0578 ns | 30.382 ns |  1.39 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject |        net472 | 32.691 ns | 0.1511 ns | 0.1413 ns | 32.735 ns |  1.50 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Float_Nullable_WithValue | .NET Core 2.0 | 14.894 ns | 0.0157 ns | 0.0147 ns | 14.896 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 2.2 | 13.109 ns | 0.0246 ns | 0.0230 ns | 13.106 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 3.0 | 12.745 ns | 0.0738 ns | 0.0691 ns | 12.782 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net461 | 16.735 ns | 0.0241 ns | 0.0214 ns | 16.737 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net472 | 16.939 ns | 0.0662 ns | 0.0620 ns | 16.920 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.0 | 22.506 ns | 0.0273 ns | 0.0256 ns | 22.506 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.2 | 19.910 ns | 0.0165 ns | 0.0154 ns | 19.908 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 3.0 | 20.517 ns | 0.0495 ns | 0.0463 ns | 20.521 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net461 | 33.934 ns | 0.1112 ns | 0.1040 ns | 33.964 ns |  1.51 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net472 | 33.203 ns | 0.0494 ns | 0.0462 ns | 33.200 ns |  1.48 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Float_Nullable_NoValue | .NET Core 2.0 | 12.143 ns | 0.0695 ns | 0.0650 ns | 12.176 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 2.2 | 10.537 ns | 0.0639 ns | 0.0598 ns | 10.508 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 3.0 |  9.648 ns | 0.0105 ns | 0.0093 ns |  9.647 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net461 | 13.657 ns | 0.0190 ns | 0.0169 ns | 13.657 ns |  1.13 |    0.01 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net472 | 12.989 ns | 0.0573 ns | 0.0536 ns | 13.011 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.437 ns | 0.0181 ns | 0.0169 ns | 15.438 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.951 ns | 0.0258 ns | 0.0229 ns | 12.950 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.568 ns | 0.0217 ns | 0.0193 ns | 13.563 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net461 | 26.208 ns | 0.0287 ns | 0.0269 ns | 26.212 ns |  1.70 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net472 | 24.373 ns | 0.0268 ns | 0.0237 ns | 24.374 ns |  1.58 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_String | .NET Core 2.0 | 60.214 ns | 0.0619 ns | 0.0517 ns | 60.208 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 2.2 | 56.103 ns | 0.0492 ns | 0.0436 ns | 56.096 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 3.0 | 21.135 ns | 0.4480 ns | 0.9352 ns | 20.608 ns |  0.38 |    0.00 |      - |     - |     - |         - |
                                           From_String |        net461 | 59.389 ns | 0.0739 ns | 0.0655 ns | 59.381 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                           From_String |        net472 | 61.656 ns | 0.2504 ns | 0.2220 ns | 61.594 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_String_AsObject | .NET Core 2.0 | 64.805 ns | 0.0841 ns | 0.0787 ns | 64.811 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 2.2 | 59.907 ns | 0.0931 ns | 0.0870 ns | 59.915 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 3.0 | 27.201 ns | 0.0697 ns | 0.0652 ns | 27.191 ns |  0.42 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject |        net461 | 72.218 ns | 0.1272 ns | 0.1190 ns | 72.220 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject |        net472 | 75.077 ns | 0.0880 ns | 0.0823 ns | 75.045 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                      From_String_Null | .NET Core 2.0 | 14.061 ns | 0.0092 ns | 0.0077 ns | 14.064 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 2.2 | 18.088 ns | 0.1018 ns | 0.0953 ns | 18.113 ns |  1.29 |    0.01 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 3.0 | 14.754 ns | 0.7491 ns | 1.1882 ns | 14.099 ns |  1.12 |    0.10 |      - |     - |     - |         - |
                                      From_String_Null |        net461 | 14.759 ns | 0.0217 ns | 0.0182 ns | 14.753 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null |        net472 | 16.846 ns | 0.0179 ns | 0.0159 ns | 16.850 ns |  1.20 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_String_Null_AsObject | .NET Core 2.0 | 14.810 ns | 0.0136 ns | 0.0121 ns | 14.807 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 2.2 | 12.914 ns | 0.0109 ns | 0.0102 ns | 12.915 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 3.0 | 13.852 ns | 0.3040 ns | 0.3501 ns | 13.627 ns |  0.94 |    0.02 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net461 | 22.611 ns | 0.0292 ns | 0.0273 ns | 22.608 ns |  1.53 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net472 | 24.583 ns | 0.0557 ns | 0.0493 ns | 24.588 ns |  1.66 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_String_Empty | .NET Core 2.0 | 14.067 ns | 0.0191 ns | 0.0159 ns | 14.063 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 2.2 | 17.617 ns | 0.0312 ns | 0.0292 ns | 17.613 ns |  1.25 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 3.0 | 13.878 ns | 0.0284 ns | 0.0265 ns | 13.884 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty |        net461 | 15.447 ns | 0.0226 ns | 0.0201 ns | 15.445 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty |        net472 | 16.250 ns | 0.0175 ns | 0.0164 ns | 16.254 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_String_Empty_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_UShort | .NET Core 2.0 | 11.938 ns | 0.0578 ns | 0.0541 ns | 11.960 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 2.2 | 10.392 ns | 0.0083 ns | 0.0073 ns | 10.393 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 3.0 |  9.756 ns | 0.0539 ns | 0.0504 ns |  9.734 ns |  0.82 |    0.01 |      - |     - |     - |         - |
                                           From_UShort |        net461 | 13.068 ns | 0.0099 ns | 0.0093 ns | 13.065 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                           From_UShort |        net472 | 12.272 ns | 0.0239 ns | 0.0223 ns | 12.272 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_UShort_AsObject | .NET Core 2.0 | 24.369 ns | 0.0248 ns | 0.0232 ns | 24.369 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 2.2 | 25.085 ns | 0.0344 ns | 0.0322 ns | 25.083 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 3.0 | 28.900 ns | 0.1897 ns | 0.1774 ns | 28.853 ns |  1.19 |    0.01 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net461 | 35.837 ns | 0.1332 ns | 0.1246 ns | 35.881 ns |  1.47 |    0.01 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net472 | 38.259 ns | 0.1016 ns | 0.0950 ns | 38.257 ns |  1.57 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_UShort_Nullable_WithValue | .NET Core 2.0 | 11.285 ns | 0.0099 ns | 0.0088 ns | 11.284 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 2.2 | 10.960 ns | 0.0120 ns | 0.0106 ns | 10.957 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 3.0 |  7.120 ns | 0.0691 ns | 0.0647 ns |  7.150 ns |  0.63 |    0.01 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net461 | 11.767 ns | 0.0139 ns | 0.0123 ns | 11.772 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net472 | 11.870 ns | 0.0695 ns | 0.0650 ns | 11.893 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.0 | 23.538 ns | 0.0265 ns | 0.0207 ns | 23.544 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.2 | 26.052 ns | 0.0332 ns | 0.0277 ns | 26.049 ns |  1.11 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 3.0 | 27.443 ns | 0.0422 ns | 0.0395 ns | 27.442 ns |  1.17 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net461 | 39.152 ns | 0.0508 ns | 0.0475 ns | 39.138 ns |  1.66 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net472 | 38.460 ns | 0.0715 ns | 0.0634 ns | 38.446 ns |  1.63 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_UShort_Nullable_NoValue | .NET Core 2.0 | 11.281 ns | 0.0179 ns | 0.0168 ns | 11.280 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 2.2 | 10.154 ns | 0.0337 ns | 0.0316 ns | 10.156 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 3.0 |  7.180 ns | 0.1646 ns | 0.1540 ns |  7.307 ns |  0.64 |    0.01 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net461 | 12.786 ns | 0.0205 ns | 0.0192 ns | 12.784 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net472 | 11.773 ns | 0.0136 ns | 0.0113 ns | 11.771 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.0 | 16.551 ns | 0.0790 ns | 0.0739 ns | 16.583 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.397 ns | 0.0099 ns | 0.0088 ns | 13.393 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 3.0 | 15.085 ns | 0.0608 ns | 0.0569 ns | 15.095 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net461 | 26.254 ns | 0.0428 ns | 0.0400 ns | 26.260 ns |  1.59 |    0.01 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net472 | 25.316 ns | 0.0397 ns | 0.0352 ns | 25.319 ns |  1.53 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_UInt | .NET Core 2.0 | 13.266 ns | 0.0140 ns | 0.0117 ns | 13.266 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 2.2 | 10.401 ns | 0.0102 ns | 0.0090 ns | 10.403 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 3.0 |  9.676 ns | 0.2611 ns | 0.3486 ns |  9.485 ns |  0.74 |    0.03 |      - |     - |     - |         - |
                                             From_UInt |        net461 | 13.991 ns | 0.0221 ns | 0.0184 ns | 13.990 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                             From_UInt |        net472 | 13.051 ns | 0.0119 ns | 0.0093 ns | 13.053 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_UInt_AsObject | .NET Core 2.0 | 20.049 ns | 0.0196 ns | 0.0183 ns | 20.050 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 2.2 | 17.981 ns | 0.0116 ns | 0.0108 ns | 17.980 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 3.0 | 19.961 ns | 0.0427 ns | 0.0379 ns | 19.975 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net461 | 27.381 ns | 0.0534 ns | 0.0473 ns | 27.378 ns |  1.37 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net472 | 30.263 ns | 0.0379 ns | 0.0317 ns | 30.264 ns |  1.51 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_UInt_Nullable_WithValue | .NET Core 2.0 | 12.046 ns | 0.0153 ns | 0.0144 ns | 12.047 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 2.2 | 11.099 ns | 0.0120 ns | 0.0107 ns | 11.096 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 3.0 | 10.094 ns | 0.0089 ns | 0.0079 ns | 10.092 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net461 | 16.996 ns | 0.0185 ns | 0.0164 ns | 16.997 ns |  1.41 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net472 | 13.553 ns | 0.0264 ns | 0.0247 ns | 13.546 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.465 ns | 0.0227 ns | 0.0190 ns | 19.469 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.2 | 18.601 ns | 0.0569 ns | 0.0475 ns | 18.617 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.268 ns | 0.1686 ns | 0.1577 ns | 18.335 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net461 | 31.190 ns | 0.1288 ns | 0.1204 ns | 31.235 ns |  1.60 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net472 | 30.247 ns | 0.0414 ns | 0.0387 ns | 30.239 ns |  1.55 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_UInt_Nullable_NoValue | .NET Core 2.0 | 13.603 ns | 0.0819 ns | 0.0766 ns | 13.636 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 2.2 | 10.293 ns | 0.0072 ns | 0.0064 ns | 10.294 ns |  0.76 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 3.0 |  9.656 ns | 0.0108 ns | 0.0095 ns |  9.656 ns |  0.71 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net461 | 14.098 ns | 0.0225 ns | 0.0210 ns | 14.099 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net472 | 13.533 ns | 0.0875 ns | 0.0819 ns | 13.574 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.789 ns | 0.0193 ns | 0.0171 ns | 14.784 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.415 ns | 0.0159 ns | 0.0141 ns | 13.412 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.092 ns | 0.0133 ns | 0.0118 ns | 13.090 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net461 | 27.311 ns | 0.0357 ns | 0.0334 ns | 27.321 ns |  1.85 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net472 | 24.302 ns | 0.0519 ns | 0.0486 ns | 24.326 ns |  1.64 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_ULong | .NET Core 2.0 | 14.147 ns | 0.0231 ns | 0.0216 ns | 14.139 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 2.2 | 11.526 ns | 0.0436 ns | 0.0407 ns | 11.541 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 3.0 |  9.931 ns | 0.0455 ns | 0.0380 ns |  9.948 ns |  0.70 |    0.00 |      - |     - |     - |         - |
                                            From_ULong |        net461 | 13.973 ns | 0.0197 ns | 0.0175 ns | 13.973 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                            From_ULong |        net472 | 13.042 ns | 0.0333 ns | 0.0312 ns | 13.028 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_ULong_AsObject | .NET Core 2.0 | 19.936 ns | 0.0198 ns | 0.0175 ns | 19.933 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 2.2 | 18.207 ns | 0.0173 ns | 0.0153 ns | 18.205 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 3.0 | 18.902 ns | 0.0291 ns | 0.0272 ns | 18.898 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net461 | 27.248 ns | 0.0427 ns | 0.0399 ns | 27.230 ns |  1.37 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net472 | 30.540 ns | 0.0760 ns | 0.0673 ns | 30.548 ns |  1.53 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_ULong_Nullable_WithValue | .NET Core 2.0 | 13.775 ns | 0.0163 ns | 0.0145 ns | 13.780 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 2.2 | 12.832 ns | 0.0702 ns | 0.0657 ns | 12.862 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 3.0 | 10.787 ns | 0.0114 ns | 0.0107 ns | 10.785 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net461 | 16.006 ns | 0.0917 ns | 0.0858 ns | 16.055 ns |  1.16 |    0.01 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net472 | 14.559 ns | 0.0217 ns | 0.0181 ns | 14.556 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.0 | 21.578 ns | 0.1815 ns | 0.1698 ns | 21.695 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.2 | 18.193 ns | 0.0255 ns | 0.0239 ns | 18.200 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 3.0 | 19.699 ns | 0.0307 ns | 0.0287 ns | 19.701 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net461 | 27.283 ns | 0.0362 ns | 0.0338 ns | 27.293 ns |  1.26 |    0.01 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net472 | 29.671 ns | 0.1924 ns | 0.1503 ns | 29.704 ns |  1.38 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_ULong_Nullable_NoValue | .NET Core 2.0 | 12.356 ns | 0.0131 ns | 0.0116 ns | 12.357 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 2.2 | 11.265 ns | 0.0173 ns | 0.0144 ns | 11.266 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 3.0 |  9.860 ns | 0.0091 ns | 0.0085 ns |  9.861 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net461 | 15.360 ns | 0.0244 ns | 0.0216 ns | 15.353 ns |  1.24 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net472 | 14.101 ns | 0.0197 ns | 0.0184 ns | 14.098 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.768 ns | 0.0093 ns | 0.0083 ns | 14.769 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.051 ns | 0.0167 ns | 0.0156 ns | 13.049 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 3.0 | 15.047 ns | 0.0686 ns | 0.0642 ns | 15.062 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net461 | 22.604 ns | 0.0385 ns | 0.0360 ns | 22.611 ns |  1.53 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net472 | 25.316 ns | 0.0286 ns | 0.0253 ns | 25.312 ns |  1.71 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                       From_NullObject | .NET Core 2.0 | 17.144 ns | 0.0134 ns | 0.0119 ns | 17.146 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 2.2 | 12.936 ns | 0.0134 ns | 0.0118 ns | 12.937 ns |  0.75 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 3.0 | 13.323 ns | 0.0152 ns | 0.0142 ns | 13.320 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject |        net461 | 22.581 ns | 0.0354 ns | 0.0314 ns | 22.570 ns |  1.32 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject |        net472 | 24.397 ns | 0.0307 ns | 0.0288 ns | 24.405 ns |  1.42 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_DBNull | .NET Core 2.0 | 12.715 ns | 0.0078 ns | 0.0069 ns | 12.713 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 2.2 | 11.487 ns | 0.0172 ns | 0.0152 ns | 11.486 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 3.0 | 12.777 ns | 0.0831 ns | 0.0778 ns | 12.740 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                                           From_DBNull |        net461 | 13.000 ns | 0.0758 ns | 0.0709 ns | 13.042 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                                           From_DBNull |        net472 | 12.916 ns | 0.0117 ns | 0.0098 ns | 12.915 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_DBNull_AsObject | .NET Core 2.0 | 14.782 ns | 0.0189 ns | 0.0167 ns | 14.781 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 2.2 | 13.672 ns | 0.0146 ns | 0.0136 ns | 13.668 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 3.0 | 13.314 ns | 0.0127 ns | 0.0112 ns | 13.315 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net461 | 22.623 ns | 0.0406 ns | 0.0360 ns | 22.629 ns |  1.53 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net472 | 24.613 ns | 0.0808 ns | 0.0755 ns | 24.643 ns |  1.67 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                 From_ConvertibleClass | .NET Core 2.0 | 17.274 ns | 0.0187 ns | 0.0166 ns | 17.273 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 2.2 | 14.769 ns | 0.0124 ns | 0.0110 ns | 14.768 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 3.0 | 15.908 ns | 0.1848 ns | 0.1729 ns | 15.988 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net461 | 25.997 ns | 0.0619 ns | 0.0579 ns | 25.984 ns |  1.50 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net472 | 27.092 ns | 0.0315 ns | 0.0263 ns | 27.100 ns |  1.57 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_ConvertibleClass_AsObject | .NET Core 2.0 | 18.435 ns | 0.0210 ns | 0.0164 ns | 18.435 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 2.2 | 16.837 ns | 0.0363 ns | 0.0340 ns | 16.834 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 3.0 | 17.345 ns | 0.0318 ns | 0.0282 ns | 17.335 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net461 | 30.204 ns | 0.0242 ns | 0.0215 ns | 30.210 ns |  1.64 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net472 | 27.904 ns | 0.0441 ns | 0.0391 ns | 27.898 ns |  1.51 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_ConvertibleClass_NoValue | .NET Core 2.0 | 14.537 ns | 0.0244 ns | 0.0228 ns | 14.533 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 2.2 | 13.610 ns | 0.0173 ns | 0.0153 ns | 13.610 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 3.0 | 13.113 ns | 0.0135 ns | 0.0126 ns | 13.112 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net461 | 25.349 ns | 0.1076 ns | 0.1007 ns | 25.372 ns |  1.74 |    0.01 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net472 | 24.413 ns | 0.0319 ns | 0.0283 ns | 24.416 ns |  1.68 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.0 | 15.082 ns | 0.0116 ns | 0.0109 ns | 15.081 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.2 | 14.177 ns | 0.0327 ns | 0.0306 ns | 14.167 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 3.0 | 14.731 ns | 0.0168 ns | 0.0149 ns | 14.733 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net461 | 22.674 ns | 0.0357 ns | 0.0334 ns | 22.666 ns |  1.50 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net472 | 25.273 ns | 0.0242 ns | 0.0189 ns | 25.277 ns |  1.68 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                              From_NonConvertibleClass | .NET Core 2.0 | 13.840 ns | 0.0273 ns | 0.0242 ns | 13.838 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 2.2 | 12.682 ns | 0.0154 ns | 0.0137 ns | 12.685 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 3.0 | 12.415 ns | 0.0162 ns | 0.0151 ns | 12.411 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net461 | 14.288 ns | 0.0135 ns | 0.0127 ns | 14.284 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net472 | 15.024 ns | 0.0119 ns | 0.0099 ns | 15.023 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                     From_NonConvertibleClass_AsObject | .NET Core 2.0 | 18.296 ns | 0.0328 ns | 0.0274 ns | 18.295 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 2.2 | 14.747 ns | 0.0171 ns | 0.0151 ns | 14.745 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 3.0 | 15.519 ns | 0.3335 ns | 0.5753 ns | 15.160 ns |  0.89 |    0.03 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net461 | 24.454 ns | 0.0520 ns | 0.0487 ns | 24.458 ns |  1.34 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net472 | 25.900 ns | 0.0314 ns | 0.0278 ns | 25.905 ns |  1.42 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                      From_NonConvertibleClass_NoValue | .NET Core 2.0 | 13.818 ns | 0.0135 ns | 0.0127 ns | 13.817 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 2.2 | 12.681 ns | 0.0163 ns | 0.0144 ns | 12.683 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 3.0 | 12.713 ns | 0.1712 ns | 0.1430 ns | 12.625 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net461 | 19.540 ns | 0.4699 ns | 1.3855 ns | 19.696 ns |  1.41 |    0.10 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net472 | 15.338 ns | 0.0314 ns | 0.0294 ns | 15.335 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.0 | 14.876 ns | 0.0369 ns | 0.0308 ns | 14.866 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.2 | 14.560 ns | 0.0166 ns | 0.0147 ns | 14.557 ns |  0.98 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 3.0 | 14.707 ns | 0.0123 ns | 0.0096 ns | 14.708 ns |  0.99 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net461 | 22.559 ns | 0.0488 ns | 0.0456 ns | 22.554 ns |  1.52 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net472 | 24.364 ns | 0.0346 ns | 0.0307 ns | 24.371 ns |  1.64 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                From_ConvertibleStruct | .NET Core 2.0 | 20.256 ns | 0.0514 ns | 0.0481 ns | 20.245 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 2.2 | 16.522 ns | 0.0355 ns | 0.0315 ns | 16.534 ns |  0.82 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 3.0 | 14.083 ns | 0.1695 ns | 0.1586 ns | 14.029 ns |  0.70 |    0.01 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net461 | 20.448 ns | 0.0536 ns | 0.0501 ns | 20.446 ns |  1.01 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net472 | 18.714 ns | 0.0259 ns | 0.0202 ns | 18.711 ns |  0.92 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                       From_ConvertibleStruct_AsObject | .NET Core 2.0 | 18.905 ns | 0.0225 ns | 0.0188 ns | 18.909 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 2.2 | 17.896 ns | 0.0236 ns | 0.0209 ns | 17.897 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 3.0 | 19.086 ns | 0.0421 ns | 0.0394 ns | 19.095 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net461 | 30.476 ns | 0.0476 ns | 0.0422 ns | 30.472 ns |  1.61 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net472 | 29.529 ns | 0.0450 ns | 0.0421 ns | 29.531 ns |  1.56 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.0 | 20.327 ns | 0.0820 ns | 0.0767 ns | 20.343 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.2 | 16.438 ns | 0.0261 ns | 0.0244 ns | 16.438 ns |  0.81 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 3.0 | 14.185 ns | 0.0464 ns | 0.0434 ns | 14.184 ns |  0.70 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net461 | 26.563 ns | 0.0319 ns | 0.0298 ns | 26.559 ns |  1.31 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net472 | 24.783 ns | 0.0859 ns | 0.0803 ns | 24.755 ns |  1.22 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.265 ns | 0.0329 ns | 0.0275 ns | 19.258 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.065 ns | 0.0227 ns | 0.0189 ns | 17.067 ns |  0.89 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.035 ns | 0.0193 ns | 0.0181 ns | 17.036 ns |  0.88 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net461 | 26.099 ns | 0.0332 ns | 0.0294 ns | 26.110 ns |  1.35 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net472 | 29.636 ns | 0.0643 ns | 0.0601 ns | 29.639 ns |  1.54 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.0 | 14.313 ns | 0.0123 ns | 0.0109 ns | 14.310 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.2 | 12.015 ns | 0.0429 ns | 0.0401 ns | 11.999 ns |  0.84 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 3.0 | 10.172 ns | 0.0188 ns | 0.0176 ns | 10.176 ns |  0.71 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net461 | 22.668 ns | 0.0264 ns | 0.0247 ns | 22.661 ns |  1.58 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net472 | 19.192 ns | 0.0220 ns | 0.0206 ns | 19.189 ns |  1.34 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.776 ns | 0.0103 ns | 0.0081 ns | 14.776 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.906 ns | 0.0169 ns | 0.0141 ns | 12.902 ns |  0.87 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.103 ns | 0.0133 ns | 0.0111 ns | 13.096 ns |  0.89 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net461 | 22.571 ns | 0.0294 ns | 0.0230 ns | 22.575 ns |  1.53 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net472 | 25.636 ns | 0.0386 ns | 0.0342 ns | 25.634 ns |  1.73 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_NonConvertibleStruct | .NET Core 2.0 | 13.247 ns | 0.0689 ns | 0.0645 ns | 13.275 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 2.2 | 10.053 ns | 0.0141 ns | 0.0132 ns | 10.051 ns |  0.76 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 3.0 |  9.535 ns | 0.0324 ns | 0.0303 ns |  9.546 ns |  0.72 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net461 | 13.023 ns | 0.0489 ns | 0.0457 ns | 13.040 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net472 | 13.078 ns | 0.0149 ns | 0.0139 ns | 13.077 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.0 | 17.281 ns | 0.0341 ns | 0.0319 ns | 17.282 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.2 | 15.761 ns | 0.0514 ns | 0.0481 ns | 15.751 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 3.0 | 15.271 ns | 0.1322 ns | 0.1172 ns | 15.224 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net461 | 27.971 ns | 0.0388 ns | 0.0363 ns | 27.971 ns |  1.62 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net472 | 25.863 ns | 0.0439 ns | 0.0411 ns | 25.866 ns |  1.50 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.0 | 13.160 ns | 0.0429 ns | 0.0401 ns | 13.144 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.2 | 10.164 ns | 0.0088 ns | 0.0078 ns | 10.163 ns |  0.77 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 3.0 |  9.708 ns | 0.0144 ns | 0.0127 ns |  9.708 ns |  0.74 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net461 | 12.930 ns | 0.0102 ns | 0.0080 ns | 12.933 ns |  0.98 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net472 | 12.287 ns | 0.0485 ns | 0.0454 ns | 12.313 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 17.318 ns | 0.0235 ns | 0.0220 ns | 17.319 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.764 ns | 0.0175 ns | 0.0164 ns | 15.755 ns |  0.91 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.159 ns | 0.0204 ns | 0.0191 ns | 15.160 ns |  0.88 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net461 | 24.452 ns | 0.0641 ns | 0.0600 ns | 24.431 ns |  1.41 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net472 | 25.805 ns | 0.0262 ns | 0.0245 ns | 25.803 ns |  1.49 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.0 | 13.594 ns | 0.0165 ns | 0.0147 ns | 13.593 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.2 | 11.427 ns | 0.0359 ns | 0.0336 ns | 11.436 ns |  0.84 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 3.0 |  9.482 ns | 0.0233 ns | 0.0207 ns |  9.479 ns |  0.70 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net461 | 12.969 ns | 0.0086 ns | 0.0067 ns | 12.970 ns |  0.95 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net472 | 12.240 ns | 0.0270 ns | 0.0225 ns | 12.238 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.913 ns | 0.0749 ns | 0.0701 ns | 14.939 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.124 ns | 0.0158 ns | 0.0148 ns | 13.117 ns |  0.88 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.795 ns | 0.1608 ns | 0.1504 ns | 14.858 ns |  0.99 |    0.01 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net461 | 22.568 ns | 0.0385 ns | 0.0342 ns | 22.572 ns |  1.51 |    0.01 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net472 | 25.432 ns | 0.0236 ns | 0.0221 ns | 25.438 ns |  1.71 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Enum | .NET Core 2.0 | 14.187 ns | 0.0170 ns | 0.0159 ns | 14.186 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 2.2 | 11.593 ns | 0.0099 ns | 0.0088 ns | 11.596 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 3.0 |  9.662 ns | 0.0279 ns | 0.0261 ns |  9.657 ns |  0.68 |    0.00 |      - |     - |     - |         - |
                                             From_Enum |        net461 | 14.616 ns | 0.1017 ns | 0.0951 ns | 14.576 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                             From_Enum |        net472 | 13.021 ns | 0.0150 ns | 0.0141 ns | 13.018 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Enum_AsObject | .NET Core 2.0 | 48.096 ns | 0.0512 ns | 0.0427 ns | 48.082 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject | .NET Core 2.2 | 45.258 ns | 0.0910 ns | 0.0807 ns | 45.231 ns |  0.94 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject | .NET Core 3.0 | 43.381 ns | 0.2690 ns | 0.2516 ns | 43.275 ns |  0.90 |    0.01 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject |        net461 | 54.511 ns | 0.0918 ns | 0.0813 ns | 54.511 ns |  1.13 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject |        net472 | 53.207 ns | 0.1815 ns | 0.1609 ns | 53.249 ns |  1.11 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Enum_Nullable_WithValue | .NET Core 2.0 | 14.768 ns | 0.0496 ns | 0.0464 ns | 14.781 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 2.2 | 12.843 ns | 0.0160 ns | 0.0150 ns | 12.840 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 3.0 | 10.103 ns | 0.0157 ns | 0.0140 ns | 10.100 ns |  0.68 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net461 | 15.181 ns | 0.0202 ns | 0.0189 ns | 15.181 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net472 | 14.477 ns | 0.0216 ns | 0.0202 ns | 14.476 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.0 | 45.977 ns | 0.0977 ns | 0.0914 ns | 45.942 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.2 | 44.359 ns | 0.0850 ns | 0.0795 ns | 44.361 ns |  0.96 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 3.0 | 39.144 ns | 0.7770 ns | 0.7980 ns | 38.696 ns |  0.85 |    0.02 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject |        net461 | 51.509 ns | 0.0602 ns | 0.0534 ns | 51.511 ns |  1.12 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject |        net472 | 54.022 ns | 0.0999 ns | 0.0935 ns | 54.005 ns |  1.17 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Enum_Nullable_NoValue | .NET Core 2.0 | 13.134 ns | 0.0140 ns | 0.0117 ns | 13.135 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 2.2 | 10.743 ns | 0.0510 ns | 0.0477 ns | 10.723 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 3.0 |  9.512 ns | 0.0473 ns | 0.0419 ns |  9.527 ns |  0.72 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net461 | 13.421 ns | 0.0145 ns | 0.0129 ns | 13.422 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net472 | 12.826 ns | 0.0784 ns | 0.0734 ns | 12.848 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.792 ns | 0.0242 ns | 0.0214 ns | 14.790 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.938 ns | 0.0147 ns | 0.0131 ns | 12.935 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.837 ns | 0.3011 ns | 0.3346 ns | 13.576 ns |  0.93 |    0.02 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net461 | 26.263 ns | 0.0437 ns | 0.0409 ns | 26.255 ns |  1.78 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net472 | 25.266 ns | 0.0207 ns | 0.0184 ns | 25.262 ns |  1.71 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                      From_ParentClass | .NET Core 2.0 | 13.847 ns | 0.0279 ns | 0.0261 ns | 13.843 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 2.2 | 12.669 ns | 0.0186 ns | 0.0165 ns | 12.667 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 3.0 | 16.361 ns | 0.3525 ns | 0.9942 ns | 16.562 ns |  1.08 |    0.14 |      - |     - |     - |         - |
                                      From_ParentClass |        net461 | 14.294 ns | 0.0124 ns | 0.0110 ns | 14.295 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass |        net472 | 14.302 ns | 0.0120 ns | 0.0107 ns | 14.304 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_ParentClass_AsObject | .NET Core 2.0 | 17.272 ns | 0.0495 ns | 0.0439 ns | 17.283 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 2.2 | 15.360 ns | 0.0850 ns | 0.0795 ns | 15.368 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 3.0 | 15.722 ns | 0.3399 ns | 0.5392 ns | 15.397 ns |  0.94 |    0.03 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net461 | 24.830 ns | 0.0471 ns | 0.0441 ns | 24.828 ns |  1.44 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net472 | 27.364 ns | 0.0350 ns | 0.0327 ns | 27.365 ns |  1.58 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                              From_ParentClass_NoValue | .NET Core 2.0 | 13.830 ns | 0.0147 ns | 0.0130 ns | 13.830 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 2.2 | 12.666 ns | 0.0134 ns | 0.0125 ns | 12.663 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 3.0 | 12.854 ns | 0.0356 ns | 0.0297 ns | 12.847 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net461 | 14.312 ns | 0.0254 ns | 0.0237 ns | 14.316 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net472 | 14.302 ns | 0.0143 ns | 0.0127 ns | 14.301 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.0 | 14.767 ns | 0.0194 ns | 0.0172 ns | 14.766 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.2 | 12.914 ns | 0.0222 ns | 0.0186 ns | 12.911 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 3.0 | 13.563 ns | 0.0263 ns | 0.0220 ns | 13.563 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net461 | 22.575 ns | 0.0206 ns | 0.0172 ns | 22.581 ns |  1.53 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net472 | 24.493 ns | 0.0938 ns | 0.0877 ns | 24.521 ns |  1.66 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_ParentStruct | .NET Core 2.0 | 42.180 ns | 0.0400 ns | 0.0355 ns | 42.195 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 2.2 | 42.924 ns | 0.0620 ns | 0.0580 ns | 42.916 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 3.0 | 39.681 ns | 0.0428 ns | 0.0379 ns | 39.674 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct |        net461 | 42.043 ns | 0.0477 ns | 0.0446 ns | 42.043 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct |        net472 | 40.696 ns | 0.0619 ns | 0.0579 ns | 40.683 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_ParentStruct_AsObject | .NET Core 2.0 | 17.757 ns | 0.0153 ns | 0.0127 ns | 17.758 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 2.2 | 16.703 ns | 0.0235 ns | 0.0220 ns | 16.704 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 3.0 | 16.716 ns | 0.0216 ns | 0.0202 ns | 16.714 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net461 | 24.356 ns | 0.0177 ns | 0.0165 ns | 24.356 ns |  1.37 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net472 | 28.132 ns | 0.0347 ns | 0.0307 ns | 28.121 ns |  1.58 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.0 | 42.116 ns | 0.1592 ns | 0.1489 ns | 42.170 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.2 | 41.616 ns | 0.1864 ns | 0.1744 ns | 41.658 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 3.0 | 40.187 ns | 0.4475 ns | 0.4186 ns | 40.415 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue |        net461 | 47.240 ns | 0.1596 ns | 0.1493 ns | 47.203 ns |  1.12 |    0.01 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue |        net472 | 40.176 ns | 0.0964 ns | 0.0902 ns | 40.142 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 17.150 ns | 0.0101 ns | 0.0090 ns | 17.150 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.232 ns | 0.0173 ns | 0.0162 ns | 15.228 ns |  0.89 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.583 ns | 0.0198 ns | 0.0176 ns | 18.588 ns |  1.08 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net461 | 24.254 ns | 0.1182 ns | 0.1105 ns | 24.199 ns |  1.41 |    0.01 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net472 | 27.204 ns | 0.0543 ns | 0.0482 ns | 27.198 ns |  1.59 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.0 | 42.397 ns | 0.0474 ns | 0.0444 ns | 42.406 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.2 | 39.970 ns | 0.0378 ns | 0.0335 ns | 39.969 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 3.0 | 39.417 ns | 0.6623 ns | 0.6195 ns | 39.674 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net461 | 41.364 ns | 0.1036 ns | 0.0969 ns | 41.353 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net472 | 42.081 ns | 0.1548 ns | 0.1448 ns | 42.129 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.906 ns | 0.0908 ns | 0.0849 ns | 14.905 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.950 ns | 0.0327 ns | 0.0306 ns | 12.943 ns |  0.87 |    0.01 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.304 ns | 0.0184 ns | 0.0163 ns | 13.304 ns |  0.89 |    0.01 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net461 | 26.412 ns | 0.0372 ns | 0.0311 ns | 26.408 ns |  1.77 |    0.01 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net472 | 26.522 ns | 0.0292 ns | 0.0273 ns | 26.527 ns |  1.78 |    0.01 |      - |     - |     - |         - |

Benchmarks with issues:
  ConvertTo_UShortNullable.From_DateTime_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_UShortNullable.From_DateTime_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_UShortNullable.From_DateTime_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_UShortNullable.From_DateTime_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_UShortNullable.From_DateTime_AsObject: Job-ZVTGBZ(Toolchain=net472)
  ConvertTo_UShortNullable.From_DateTime_Nullable_WithValue_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_UShortNullable.From_DateTime_Nullable_WithValue_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_UShortNullable.From_DateTime_Nullable_WithValue_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_UShortNullable.From_DateTime_Nullable_WithValue_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_UShortNullable.From_DateTime_Nullable_WithValue_AsObject: Job-ZVTGBZ(Toolchain=net472)
  ConvertTo_UShortNullable.From_String_Empty_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_UShortNullable.From_String_Empty_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_UShortNullable.From_String_Empty_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_UShortNullable.From_String_Empty_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_UShortNullable.From_String_Empty_AsObject: Job-ZVTGBZ(Toolchain=net472)
