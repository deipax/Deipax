
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
                                             From_Bool | .NET Core 2.0 |  24.621 ns | 0.1049 ns | 0.0981 ns |  24.557 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 2.2 |  21.533 ns | 0.0273 ns | 0.0228 ns |  21.530 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 3.0 |  14.748 ns | 0.0780 ns | 0.0730 ns |  14.785 ns |  0.60 |    0.00 |      - |     - |     - |         - |
                                             From_Bool |        net461 |  25.620 ns | 0.0147 ns | 0.0115 ns |  25.616 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                             From_Bool |        net472 |  23.454 ns | 0.0383 ns | 0.0358 ns |  23.449 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                    From_Bool_AsObject | .NET Core 2.0 |  31.365 ns | 0.0353 ns | 0.0313 ns |  31.363 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 2.2 |  27.679 ns | 0.0208 ns | 0.0195 ns |  27.675 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 3.0 |  27.983 ns | 0.0340 ns | 0.0284 ns |  27.994 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net461 |  37.841 ns | 0.0490 ns | 0.0383 ns |  37.853 ns |  1.21 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net472 |  35.833 ns | 0.0408 ns | 0.0340 ns |  35.828 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                          From_Bool_Nullable_WithValue | .NET Core 2.0 |  25.788 ns | 0.0296 ns | 0.0263 ns |  25.792 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 2.2 |  24.590 ns | 0.0568 ns | 0.0531 ns |  24.602 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 3.0 |  13.848 ns | 0.0861 ns | 0.0805 ns |  13.887 ns |  0.54 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net461 |  27.901 ns | 0.0834 ns | 0.0780 ns |  27.916 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net472 |  25.466 ns | 0.0238 ns | 0.0211 ns |  25.469 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.0 |  33.184 ns | 0.0530 ns | 0.0470 ns |  33.177 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.2 |  27.673 ns | 0.0269 ns | 0.0252 ns |  27.679 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 3.0 |  28.253 ns | 0.0363 ns | 0.0339 ns |  28.237 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net461 |  36.609 ns | 0.0813 ns | 0.0760 ns |  36.644 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net472 |  34.411 ns | 0.2058 ns | 0.1925 ns |  34.499 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                            From_Bool_Nullable_NoValue | .NET Core 2.0 |  11.607 ns | 0.0119 ns | 0.0111 ns |  11.605 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 2.2 |  10.061 ns | 0.0127 ns | 0.0106 ns |  10.058 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 3.0 |   6.847 ns | 0.0091 ns | 0.0085 ns |   6.847 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net461 |  13.125 ns | 0.0141 ns | 0.0125 ns |  13.124 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net472 |  10.525 ns | 0.0161 ns | 0.0150 ns |  10.526 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.0 |  12.938 ns | 0.0344 ns | 0.0322 ns |  12.946 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.2 |  10.763 ns | 0.0123 ns | 0.0115 ns |  10.762 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 3.0 |  11.679 ns | 0.0302 ns | 0.0268 ns |  11.673 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net461 |  13.383 ns | 0.0146 ns | 0.0137 ns |  13.380 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net472 |  12.925 ns | 0.0165 ns | 0.0154 ns |  12.923 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                             From_Byte | .NET Core 2.0 |  23.454 ns | 0.0209 ns | 0.0186 ns |  23.458 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 2.2 |  21.368 ns | 0.0234 ns | 0.0207 ns |  21.370 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 3.0 |  12.856 ns | 0.0129 ns | 0.0121 ns |  12.857 ns |  0.55 |    0.00 |      - |     - |     - |         - |
                                             From_Byte |        net461 |  27.408 ns | 0.0176 ns | 0.0165 ns |  27.404 ns |  1.17 |    0.00 |      - |     - |     - |         - |
                                             From_Byte |        net472 |  22.809 ns | 0.0210 ns | 0.0186 ns |  22.811 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                    From_Byte_AsObject | .NET Core 2.0 |  31.450 ns | 0.1572 ns | 0.1470 ns |  31.366 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 2.2 |  27.518 ns | 0.0240 ns | 0.0224 ns |  27.520 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 3.0 |  27.367 ns | 0.1222 ns | 0.1143 ns |  27.422 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net461 |  40.917 ns | 0.9024 ns | 2.6608 ns |  38.973 ns |  1.34 |    0.08 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net472 |  35.652 ns | 0.0528 ns | 0.0468 ns |  35.648 ns |  1.13 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                          From_Byte_Nullable_WithValue | .NET Core 2.0 |  25.595 ns | 0.0238 ns | 0.0211 ns |  25.593 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 2.2 |  23.777 ns | 0.0325 ns | 0.0288 ns |  23.774 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 3.0 |  13.677 ns | 0.0214 ns | 0.0190 ns |  13.676 ns |  0.53 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net461 |  32.943 ns | 0.0501 ns | 0.0469 ns |  32.941 ns |  1.29 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net472 |  26.024 ns | 0.0369 ns | 0.0345 ns |  26.006 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.0 |  32.241 ns | 0.0388 ns | 0.0363 ns |  32.246 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.2 |  27.394 ns | 0.0283 ns | 0.0265 ns |  27.392 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 3.0 |  27.070 ns | 0.0255 ns | 0.0238 ns |  27.071 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net461 |  37.802 ns | 0.0434 ns | 0.0406 ns |  37.785 ns |  1.17 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net472 |  35.769 ns | 0.0396 ns | 0.0370 ns |  35.766 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                            From_Byte_Nullable_NoValue | .NET Core 2.0 |  11.624 ns | 0.0133 ns | 0.0111 ns |  11.622 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 2.2 |  10.055 ns | 0.0108 ns | 0.0101 ns |  10.053 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 3.0 |   6.849 ns | 0.0269 ns | 0.0252 ns |   6.840 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net461 |  12.748 ns | 0.0812 ns | 0.0760 ns |  12.797 ns |  1.10 |    0.01 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net472 |  10.590 ns | 0.0488 ns | 0.0456 ns |  10.606 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.0 |  11.434 ns | 0.0146 ns | 0.0114 ns |  11.436 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.2 |  10.490 ns | 0.0125 ns | 0.0117 ns |  10.488 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 3.0 |  11.641 ns | 0.0442 ns | 0.0392 ns |  11.620 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net461 |  13.304 ns | 0.0165 ns | 0.0155 ns |  13.303 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net472 |  11.632 ns | 0.0250 ns | 0.0221 ns |  11.627 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                             From_Char | .NET Core 2.0 |  23.406 ns | 0.0250 ns | 0.0222 ns |  23.402 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Char | .NET Core 2.2 |  21.882 ns | 0.0255 ns | 0.0239 ns |  21.879 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                             From_Char | .NET Core 3.0 |  13.253 ns | 0.0683 ns | 0.0639 ns |  13.243 ns |  0.57 |    0.00 |      - |     - |     - |         - |
                                             From_Char |        net461 |  26.038 ns | 0.0233 ns | 0.0218 ns |  26.046 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                             From_Char |        net472 |  23.741 ns | 0.0410 ns | 0.0383 ns |  23.734 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                    From_Char_AsObject | .NET Core 2.0 |  32.428 ns | 0.0963 ns | 0.0901 ns |  32.444 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 2.2 |  29.077 ns | 0.0175 ns | 0.0155 ns |  29.080 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 3.0 |  27.769 ns | 0.0284 ns | 0.0266 ns |  27.759 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject |        net461 |  35.474 ns | 0.0510 ns | 0.0477 ns |  35.454 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject |        net472 |  35.873 ns | 0.0515 ns | 0.0482 ns |  35.880 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                          From_Char_Nullable_WithValue | .NET Core 2.0 |  26.210 ns | 0.0583 ns | 0.0487 ns |  26.188 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 2.2 |  23.671 ns | 0.0244 ns | 0.0216 ns |  23.669 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 3.0 |  14.203 ns | 0.3033 ns | 0.4152 ns |  13.906 ns |  0.55 |    0.01 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net461 |  28.271 ns | 0.0227 ns | 0.0201 ns |  28.270 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net472 |  24.997 ns | 0.0368 ns | 0.0326 ns |  25.006 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.0 |  31.699 ns | 0.0432 ns | 0.0404 ns |  31.691 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.2 |  28.303 ns | 0.0301 ns | 0.0282 ns |  28.311 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 3.0 |  27.629 ns | 0.0293 ns | 0.0244 ns |  27.621 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net461 |  35.351 ns | 0.0375 ns | 0.0293 ns |  35.353 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net472 |  34.586 ns | 0.0513 ns | 0.0480 ns |  34.593 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                            From_Char_Nullable_NoValue | .NET Core 2.0 |  11.666 ns | 0.0547 ns | 0.0511 ns |  11.642 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 2.2 |  10.083 ns | 0.0325 ns | 0.0304 ns |  10.073 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 3.0 |   6.692 ns | 0.1404 ns | 0.1314 ns |   6.606 ns |  0.57 |    0.01 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net461 |  12.497 ns | 0.0218 ns | 0.0194 ns |  12.496 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net472 |  10.515 ns | 0.0156 ns | 0.0138 ns |  10.516 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.0 |  11.692 ns | 0.0138 ns | 0.0115 ns |  11.693 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.2 |  10.607 ns | 0.0098 ns | 0.0092 ns |  10.607 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 3.0 |  11.662 ns | 0.0156 ns | 0.0146 ns |  11.660 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net461 |  11.562 ns | 0.0240 ns | 0.0224 ns |  11.564 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net472 |  12.074 ns | 0.0381 ns | 0.0356 ns |  12.079 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                         From_DateTime | .NET Core 2.0 |  26.453 ns | 0.0330 ns | 0.0308 ns |  26.451 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 2.2 |  24.857 ns | 0.0179 ns | 0.0140 ns |  24.856 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 3.0 |  12.633 ns | 0.1933 ns | 0.1809 ns |  12.778 ns |  0.48 |    0.01 |      - |     - |     - |         - |
                                         From_DateTime |        net461 |  30.742 ns | 0.0491 ns | 0.0459 ns |  30.736 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime |        net472 |  26.737 ns | 0.0280 ns | 0.0248 ns |  26.740 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                From_DateTime_AsObject | .NET Core 2.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 2.2 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 3.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net461 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net472 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                      From_DateTime_Nullable_WithValue | .NET Core 2.0 |  27.122 ns | 0.0192 ns | 0.0170 ns |  27.122 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 2.2 |  25.757 ns | 0.0323 ns | 0.0302 ns |  25.761 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 3.0 |  13.753 ns | 0.0315 ns | 0.0295 ns |  13.754 ns |  0.51 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net461 |  28.266 ns | 0.0497 ns | 0.0440 ns |  28.255 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net472 |  27.358 ns | 0.1063 ns | 0.0942 ns |  27.392 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.2 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 3.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net461 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net472 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                        From_DateTime_Nullable_NoValue | .NET Core 2.0 |  12.538 ns | 0.0400 ns | 0.0374 ns |  12.546 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 2.2 |  11.345 ns | 0.0097 ns | 0.0091 ns |  11.348 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 3.0 |   8.293 ns | 0.0113 ns | 0.0106 ns |   8.293 ns |  0.66 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net461 |  14.402 ns | 0.0346 ns | 0.0307 ns |  14.399 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net472 |  12.887 ns | 0.0071 ns | 0.0067 ns |  12.887 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.0 |  12.710 ns | 0.0216 ns | 0.0169 ns |  12.711 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.2 |  10.493 ns | 0.0141 ns | 0.0131 ns |  10.491 ns |  0.83 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 3.0 |  11.650 ns | 0.0147 ns | 0.0131 ns |  11.646 ns |  0.92 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net461 |  14.333 ns | 0.1301 ns | 0.1217 ns |  14.323 ns |  1.13 |    0.01 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net472 |  11.626 ns | 0.0161 ns | 0.0151 ns |  11.625 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                          From_Decimal | .NET Core 2.0 |  34.700 ns | 0.0420 ns | 0.0351 ns |  34.686 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 2.2 |  34.340 ns | 0.0398 ns | 0.0372 ns |  34.340 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 3.0 |  20.221 ns | 0.3037 ns | 0.2841 ns |  20.405 ns |  0.58 |    0.01 |      - |     - |     - |         - |
                                          From_Decimal |        net461 |  41.702 ns | 0.0445 ns | 0.0417 ns |  41.712 ns |  1.20 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal |        net472 |  34.801 ns | 0.0314 ns | 0.0278 ns |  34.798 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                 From_Decimal_AsObject | .NET Core 2.0 |  40.607 ns | 0.0363 ns | 0.0339 ns |  40.593 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 2.2 |  38.578 ns | 0.0477 ns | 0.0446 ns |  38.560 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 3.0 |  30.796 ns | 0.0394 ns | 0.0369 ns |  30.798 ns |  0.76 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net461 |  42.191 ns | 0.2598 ns | 0.2430 ns |  42.306 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net472 |  42.327 ns | 0.0512 ns | 0.0454 ns |  42.324 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                       From_Decimal_Nullable_WithValue | .NET Core 2.0 |  35.259 ns | 0.0596 ns | 0.0557 ns |  35.247 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 2.2 |  32.733 ns | 0.0474 ns | 0.0396 ns |  32.726 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 3.0 |  22.165 ns | 0.0155 ns | 0.0129 ns |  22.164 ns |  0.63 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net461 |  38.182 ns | 0.0469 ns | 0.0439 ns |  38.163 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net472 |  34.295 ns | 0.0544 ns | 0.0482 ns |  34.302 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.0 |  42.014 ns | 0.1489 ns | 0.1393 ns |  42.040 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.2 |  39.615 ns | 0.0628 ns | 0.0524 ns |  39.619 ns |  0.94 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 3.0 |  30.682 ns | 0.0409 ns | 0.0363 ns |  30.686 ns |  0.73 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net461 |  44.020 ns | 0.0479 ns | 0.0424 ns |  44.028 ns |  1.05 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net472 |  42.101 ns | 0.0567 ns | 0.0474 ns |  42.110 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                         From_Decimal_Nullable_NoValue | .NET Core 2.0 |  12.473 ns | 0.0063 ns | 0.0056 ns |  12.472 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 2.2 |  11.415 ns | 0.0393 ns | 0.0368 ns |  11.437 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 3.0 |   8.548 ns | 0.1972 ns | 0.3185 ns |   8.719 ns |  0.67 |    0.03 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net461 |  15.121 ns | 0.0616 ns | 0.0576 ns |  15.088 ns |  1.21 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net472 |  14.417 ns | 0.0133 ns | 0.0111 ns |  14.417 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.0 |  12.032 ns | 0.0125 ns | 0.0117 ns |  12.035 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.2 |  10.500 ns | 0.0183 ns | 0.0143 ns |  10.501 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 3.0 |  11.131 ns | 0.0592 ns | 0.0553 ns |  11.156 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net461 |  11.599 ns | 0.0193 ns | 0.0181 ns |  11.605 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net472 |  13.947 ns | 0.0167 ns | 0.0140 ns |  13.945 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                           From_Double | .NET Core 2.0 |  26.956 ns | 0.0431 ns | 0.0403 ns |  26.949 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 2.2 |  24.266 ns | 0.0175 ns | 0.0163 ns |  24.268 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 3.0 |  15.300 ns | 0.0254 ns | 0.0225 ns |  15.295 ns |  0.57 |    0.00 |      - |     - |     - |         - |
                                           From_Double |        net461 |  32.757 ns | 0.4282 ns | 0.4005 ns |  32.488 ns |  1.22 |    0.01 |      - |     - |     - |         - |
                                           From_Double |        net472 |  25.335 ns | 0.1221 ns | 0.1142 ns |  25.385 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                  From_Double_AsObject | .NET Core 2.0 |  32.575 ns | 0.0372 ns | 0.0348 ns |  32.566 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 2.2 |  28.668 ns | 0.0526 ns | 0.0440 ns |  28.675 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 3.0 |  28.790 ns | 0.0349 ns | 0.0309 ns |  28.789 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject |        net461 |  37.817 ns | 0.0751 ns | 0.0703 ns |  37.814 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject |        net472 |  37.025 ns | 0.0523 ns | 0.0464 ns |  37.024 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                        From_Double_Nullable_WithValue | .NET Core 2.0 |  31.413 ns | 0.0384 ns | 0.0359 ns |  31.417 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 2.2 |  27.948 ns | 0.0136 ns | 0.0120 ns |  27.949 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 3.0 |  17.170 ns | 0.3663 ns | 0.3598 ns |  16.906 ns |  0.55 |    0.01 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net461 |  40.421 ns | 0.0363 ns | 0.0340 ns |  40.419 ns |  1.29 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net472 |  29.943 ns | 0.0334 ns | 0.0296 ns |  29.952 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.0 |  33.382 ns | 0.0446 ns | 0.0395 ns |  33.381 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.2 |  28.669 ns | 0.0215 ns | 0.0190 ns |  28.674 ns |  0.86 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 3.0 |  28.657 ns | 0.0419 ns | 0.0350 ns |  28.659 ns |  0.86 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net461 |  38.548 ns | 0.0419 ns | 0.0392 ns |  38.554 ns |  1.15 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net472 |  36.190 ns | 0.0282 ns | 0.0263 ns |  36.190 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                          From_Double_Nullable_NoValue | .NET Core 2.0 |  12.441 ns | 0.0134 ns | 0.0126 ns |  12.443 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 2.2 |  11.287 ns | 0.0074 ns | 0.0065 ns |  11.287 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 3.0 |   7.990 ns | 0.0843 ns | 0.0789 ns |   8.010 ns |  0.64 |    0.01 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net461 |  14.000 ns | 0.0169 ns | 0.0132 ns |  14.001 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net472 |  12.714 ns | 0.0134 ns | 0.0119 ns |  12.715 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.0 |  12.402 ns | 0.0108 ns | 0.0101 ns |  12.401 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.2 |  10.499 ns | 0.0160 ns | 0.0149 ns |  10.499 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 3.0 |  12.345 ns | 0.2695 ns | 0.5382 ns |  12.556 ns |  0.96 |    0.06 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net461 |  12.073 ns | 0.0158 ns | 0.0148 ns |  12.071 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net472 |  11.614 ns | 0.0135 ns | 0.0120 ns |  11.611 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                            From_Short | .NET Core 2.0 |  23.382 ns | 0.0176 ns | 0.0165 ns |  23.381 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 2.2 |  21.877 ns | 0.0285 ns | 0.0238 ns |  21.872 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 3.0 |  12.773 ns | 0.0127 ns | 0.0113 ns |  12.772 ns |  0.55 |    0.00 |      - |     - |     - |         - |
                                            From_Short |        net461 |  26.896 ns | 0.0208 ns | 0.0184 ns |  26.896 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                                            From_Short |        net472 |  22.860 ns | 0.0243 ns | 0.0216 ns |  22.855 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                   From_Short_AsObject | .NET Core 2.0 |  32.267 ns | 0.0380 ns | 0.0355 ns |  32.274 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 2.2 |  27.490 ns | 0.0230 ns | 0.0215 ns |  27.491 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 3.0 |  27.310 ns | 0.0405 ns | 0.0338 ns |  27.315 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net461 |  37.540 ns | 0.0672 ns | 0.0596 ns |  37.541 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net472 |  36.012 ns | 0.1428 ns | 0.1266 ns |  36.031 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                         From_Short_Nullable_WithValue | .NET Core 2.0 |  26.541 ns | 0.0252 ns | 0.0235 ns |  26.547 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 2.2 |  23.628 ns | 0.0278 ns | 0.0247 ns |  23.629 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 3.0 |  13.706 ns | 0.0211 ns | 0.0197 ns |  13.708 ns |  0.52 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net461 |  30.881 ns | 0.0266 ns | 0.0249 ns |  30.879 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net472 |  25.980 ns | 0.0289 ns | 0.0270 ns |  25.976 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.0 |  33.027 ns | 0.0436 ns | 0.0364 ns |  33.015 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.2 |  27.467 ns | 0.0269 ns | 0.0225 ns |  27.467 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 3.0 |  27.192 ns | 0.0504 ns | 0.0447 ns |  27.181 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net461 |  36.715 ns | 0.0519 ns | 0.0485 ns |  36.721 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net472 |  36.649 ns | 0.0530 ns | 0.0496 ns |  36.638 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                           From_Short_Nullable_NoValue | .NET Core 2.0 |  11.608 ns | 0.0097 ns | 0.0086 ns |  11.609 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 2.2 |  10.058 ns | 0.0103 ns | 0.0096 ns |  10.058 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 3.0 |   6.955 ns | 0.5123 ns | 0.6099 ns |   6.620 ns |  0.61 |    0.06 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net461 |  12.538 ns | 0.0151 ns | 0.0134 ns |  12.538 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net472 |  10.934 ns | 0.0114 ns | 0.0107 ns |  10.931 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.0 |  11.440 ns | 0.0136 ns | 0.0128 ns |  11.440 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.2 |  10.495 ns | 0.0117 ns | 0.0104 ns |  10.491 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 3.0 |  11.654 ns | 0.0146 ns | 0.0122 ns |  11.655 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net461 |  13.753 ns | 0.0131 ns | 0.0123 ns |  13.755 ns |  1.20 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net472 |  11.620 ns | 0.0129 ns | 0.0121 ns |  11.615 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                              From_Int | .NET Core 2.0 |  23.016 ns | 0.0238 ns | 0.0211 ns |  23.014 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 2.2 |  20.756 ns | 0.0171 ns | 0.0160 ns |  20.754 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 3.0 |  12.783 ns | 0.0128 ns | 0.0114 ns |  12.788 ns |  0.56 |    0.00 |      - |     - |     - |         - |
                                              From_Int |        net461 |  26.232 ns | 0.0309 ns | 0.0289 ns |  26.235 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                              From_Int |        net472 |  23.839 ns | 0.1804 ns | 0.1687 ns |  23.954 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                     From_Int_AsObject | .NET Core 2.0 |  29.798 ns | 0.0347 ns | 0.0325 ns |  29.794 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 2.2 |  25.434 ns | 0.0231 ns | 0.0193 ns |  25.437 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 3.0 |  23.400 ns | 0.0224 ns | 0.0199 ns |  23.404 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net461 |  32.309 ns | 0.0688 ns | 0.0610 ns |  32.306 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net472 |  30.715 ns | 0.0642 ns | 0.0600 ns |  30.710 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                           From_Int_Nullable_WithValue | .NET Core 2.0 |  27.253 ns | 0.0304 ns | 0.0254 ns |  27.244 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 2.2 |  23.309 ns | 0.0585 ns | 0.0547 ns |  23.301 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 3.0 |  13.479 ns | 0.0133 ns | 0.0111 ns |  13.479 ns |  0.49 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net461 |  28.710 ns | 0.0275 ns | 0.0229 ns |  28.715 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net472 |  26.263 ns | 0.1361 ns | 0.1273 ns |  26.342 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.0 |  28.504 ns | 0.0173 ns | 0.0144 ns |  28.504 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.2 |  24.448 ns | 0.0192 ns | 0.0180 ns |  24.449 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 3.0 |  25.103 ns | 0.0387 ns | 0.0343 ns |  25.106 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net461 |  31.610 ns | 0.0273 ns | 0.0256 ns |  31.603 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net472 |  31.270 ns | 0.0465 ns | 0.0435 ns |  31.266 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                             From_Int_Nullable_NoValue | .NET Core 2.0 |  11.597 ns | 0.0110 ns | 0.0097 ns |  11.598 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 2.2 |  10.070 ns | 0.0125 ns | 0.0117 ns |  10.068 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 3.0 |   7.906 ns | 0.1828 ns | 0.4013 ns |   8.026 ns |  0.65 |    0.06 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net461 |  12.659 ns | 0.0161 ns | 0.0150 ns |  12.656 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net472 |  12.369 ns | 0.0180 ns | 0.0159 ns |  12.371 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.0 |  13.464 ns | 0.0181 ns | 0.0160 ns |  13.466 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.2 |  10.552 ns | 0.0092 ns | 0.0082 ns |  10.552 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 3.0 |  11.652 ns | 0.0145 ns | 0.0128 ns |  11.650 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net461 |  11.614 ns | 0.0222 ns | 0.0208 ns |  11.614 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net472 |  13.398 ns | 0.0152 ns | 0.0142 ns |  13.403 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                             From_Long | .NET Core 2.0 |  25.839 ns | 0.0192 ns | 0.0180 ns |  25.841 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Long | .NET Core 2.2 |  25.858 ns | 0.0190 ns | 0.0178 ns |  25.856 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Long | .NET Core 3.0 |  13.696 ns | 0.0196 ns | 0.0174 ns |  13.694 ns |  0.53 |    0.00 |      - |     - |     - |         - |
                                             From_Long |        net461 |  27.718 ns | 0.1109 ns | 0.1037 ns |  27.762 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                             From_Long |        net472 |  25.261 ns | 0.0239 ns | 0.0223 ns |  25.259 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                    From_Long_AsObject | .NET Core 2.0 |  33.663 ns | 0.0494 ns | 0.0413 ns |  33.648 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 2.2 |  28.549 ns | 0.0359 ns | 0.0336 ns |  28.554 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 3.0 |  27.989 ns | 0.0341 ns | 0.0285 ns |  27.983 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net461 |  36.917 ns | 0.0526 ns | 0.0467 ns |  36.919 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net472 |  36.983 ns | 0.1766 ns | 0.1565 ns |  37.045 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                          From_Long_Nullable_WithValue | .NET Core 2.0 |  29.127 ns | 0.0179 ns | 0.0167 ns |  29.124 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 2.2 |  28.195 ns | 0.0285 ns | 0.0267 ns |  28.197 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 3.0 |  17.168 ns | 0.1180 ns | 0.1104 ns |  17.130 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net461 |  31.713 ns | 0.0584 ns | 0.0518 ns |  31.706 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net472 |  30.766 ns | 0.0674 ns | 0.0598 ns |  30.767 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.0 |  32.129 ns | 0.0396 ns | 0.0351 ns |  32.130 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.2 |  28.512 ns | 0.0240 ns | 0.0213 ns |  28.512 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 3.0 |  28.002 ns | 0.0313 ns | 0.0293 ns |  28.006 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net461 |  38.154 ns | 0.0349 ns | 0.0327 ns |  38.149 ns |  1.19 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net472 |  37.058 ns | 0.0468 ns | 0.0391 ns |  37.050 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                            From_Long_Nullable_NoValue | .NET Core 2.0 |  12.389 ns | 0.0224 ns | 0.0199 ns |  12.384 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 2.2 |  11.977 ns | 0.0607 ns | 0.0568 ns |  11.961 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 3.0 |   8.096 ns | 0.0146 ns | 0.0129 ns |   8.095 ns |  0.65 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net461 |  15.599 ns | 0.0174 ns | 0.0145 ns |  15.591 ns |  1.26 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net472 |  12.800 ns | 0.0144 ns | 0.0127 ns |  12.800 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.0 |  11.536 ns | 0.0087 ns | 0.0081 ns |  11.536 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.2 |  11.604 ns | 0.0077 ns | 0.0069 ns |  11.603 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 3.0 |  11.652 ns | 0.0090 ns | 0.0070 ns |  11.653 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net461 |  14.151 ns | 0.0098 ns | 0.0087 ns |  14.151 ns |  1.23 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net472 |  11.648 ns | 0.0138 ns | 0.0129 ns |  11.649 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                            From_SByte | .NET Core 2.0 |  23.440 ns | 0.0461 ns | 0.0431 ns |  23.448 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 2.2 |  22.730 ns | 0.0744 ns | 0.0696 ns |  22.750 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 3.0 |  13.057 ns | 0.0100 ns | 0.0084 ns |  13.057 ns |  0.56 |    0.00 |      - |     - |     - |         - |
                                            From_SByte |        net461 |  27.912 ns | 0.0318 ns | 0.0297 ns |  27.907 ns |  1.19 |    0.00 |      - |     - |     - |         - |
                                            From_SByte |        net472 |  23.429 ns | 0.0257 ns | 0.0228 ns |  23.424 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                   From_SByte_AsObject | .NET Core 2.0 |  32.199 ns | 0.0289 ns | 0.0270 ns |  32.200 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 2.2 |  28.209 ns | 0.0244 ns | 0.0229 ns |  28.206 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 3.0 |  27.599 ns | 0.0429 ns | 0.0380 ns |  27.598 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net461 |  35.652 ns | 0.0479 ns | 0.0448 ns |  35.658 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net472 |  37.742 ns | 0.0458 ns | 0.0428 ns |  37.741 ns |  1.17 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                         From_SByte_Nullable_WithValue | .NET Core 2.0 |  25.541 ns | 0.0267 ns | 0.0250 ns |  25.533 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 2.2 |  23.618 ns | 0.0267 ns | 0.0236 ns |  23.609 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 3.0 |  13.921 ns | 0.0344 ns | 0.0305 ns |  13.918 ns |  0.55 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net461 |  28.933 ns | 0.0231 ns | 0.0193 ns |  28.931 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net472 |  24.989 ns | 0.0280 ns | 0.0262 ns |  24.985 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.0 |  32.252 ns | 0.0427 ns | 0.0379 ns |  32.249 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.2 |  27.355 ns | 0.0178 ns | 0.0158 ns |  27.358 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 3.0 |  27.618 ns | 0.0160 ns | 0.0142 ns |  27.616 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net461 |  35.681 ns | 0.0475 ns | 0.0444 ns |  35.679 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net472 |  35.733 ns | 0.0313 ns | 0.0293 ns |  35.727 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                           From_SByte_Nullable_NoValue | .NET Core 2.0 |  11.706 ns | 0.0375 ns | 0.0351 ns |  11.716 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 2.2 |  10.056 ns | 0.0083 ns | 0.0073 ns |  10.057 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 3.0 |   6.591 ns | 0.0108 ns | 0.0095 ns |   6.590 ns |  0.56 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net461 |  12.434 ns | 0.0154 ns | 0.0136 ns |  12.437 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net472 |  12.346 ns | 0.0180 ns | 0.0168 ns |  12.347 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.0 |  11.870 ns | 0.0128 ns | 0.0113 ns |  11.869 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.2 |  10.578 ns | 0.0553 ns | 0.0517 ns |  10.601 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 3.0 |  11.644 ns | 0.0126 ns | 0.0118 ns |  11.646 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net461 |  11.588 ns | 0.0295 ns | 0.0276 ns |  11.585 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net472 |  13.925 ns | 0.0163 ns | 0.0152 ns |  13.929 ns |  1.17 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                            From_Float | .NET Core 2.0 |  27.066 ns | 0.1122 ns | 0.1050 ns |  27.101 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 2.2 |  25.702 ns | 0.0204 ns | 0.0181 ns |  25.699 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 3.0 |  16.527 ns | 0.3202 ns | 0.2839 ns |  16.663 ns |  0.61 |    0.01 |      - |     - |     - |         - |
                                            From_Float |        net461 |  29.959 ns | 0.0432 ns | 0.0337 ns |  29.955 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                            From_Float |        net472 |  25.236 ns | 0.0196 ns | 0.0174 ns |  25.237 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                   From_Float_AsObject | .NET Core 2.0 |  35.182 ns | 0.0813 ns | 0.0760 ns |  35.196 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 2.2 |  29.363 ns | 0.0224 ns | 0.0209 ns |  29.366 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 3.0 |  31.127 ns | 0.1668 ns | 0.1560 ns |  31.196 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject |        net461 |  38.247 ns | 0.0636 ns | 0.0594 ns |  38.232 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject |        net472 |  37.932 ns | 0.0417 ns | 0.0370 ns |  37.931 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                         From_Float_Nullable_WithValue | .NET Core 2.0 |  28.359 ns | 0.0358 ns | 0.0335 ns |  28.362 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 2.2 |  27.703 ns | 0.0283 ns | 0.0265 ns |  27.689 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 3.0 |  15.562 ns | 0.0200 ns | 0.0177 ns |  15.558 ns |  0.55 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net461 |  29.407 ns | 0.0438 ns | 0.0389 ns |  29.402 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net472 |  27.761 ns | 0.0220 ns | 0.0195 ns |  27.758 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.0 |  34.186 ns | 0.1675 ns | 0.1566 ns |  34.250 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.2 |  28.822 ns | 0.0239 ns | 0.0212 ns |  28.823 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 3.0 |  28.738 ns | 0.0345 ns | 0.0323 ns |  28.743 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net461 |  38.593 ns | 0.0481 ns | 0.0450 ns |  38.597 ns |  1.13 |    0.01 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net472 |  36.226 ns | 0.0349 ns | 0.0309 ns |  36.230 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                           From_Float_Nullable_NoValue | .NET Core 2.0 |  11.626 ns | 0.0130 ns | 0.0122 ns |  11.621 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 2.2 |  10.179 ns | 0.0498 ns | 0.0465 ns |  10.207 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 3.0 |   8.443 ns | 0.2290 ns | 0.6645 ns |   8.677 ns |  0.62 |    0.08 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net461 |  12.815 ns | 0.0141 ns | 0.0132 ns |  12.810 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net472 |  10.763 ns | 0.0165 ns | 0.0155 ns |  10.761 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.0 |  11.481 ns | 0.0091 ns | 0.0085 ns |  11.480 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.2 |  10.830 ns | 0.0104 ns | 0.0087 ns |  10.831 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 3.0 |  11.999 ns | 0.1504 ns | 0.1407 ns |  12.028 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net461 |  11.630 ns | 0.0573 ns | 0.0536 ns |  11.607 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net472 |  11.614 ns | 0.0095 ns | 0.0089 ns |  11.612 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                           From_String | .NET Core 2.0 |  29.118 ns | 0.0390 ns | 0.0365 ns |  29.115 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 2.2 |  28.016 ns | 0.0468 ns | 0.0415 ns |  28.004 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 3.0 |  24.387 ns | 0.4888 ns | 0.4572 ns |  24.644 ns |  0.84 |    0.02 |      - |     - |     - |         - |
                                           From_String |        net461 |  41.491 ns | 0.0785 ns | 0.0734 ns |  41.479 ns |  1.42 |    0.00 |      - |     - |     - |         - |
                                           From_String |        net472 |  42.334 ns | 0.1787 ns | 0.1671 ns |  42.422 ns |  1.45 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                  From_String_AsObject | .NET Core 2.0 |  36.983 ns | 0.0314 ns | 0.0278 ns |  36.979 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 2.2 |  35.966 ns | 0.0491 ns | 0.0435 ns |  35.959 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 3.0 |  28.707 ns | 0.0408 ns | 0.0382 ns |  28.687 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject |        net461 |  47.526 ns | 0.0357 ns | 0.0334 ns |  47.531 ns |  1.29 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject |        net472 |  46.479 ns | 0.1586 ns | 0.1483 ns |  46.499 ns |  1.26 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                      From_String_Null | .NET Core 2.0 |  12.581 ns | 0.0828 ns | 0.0775 ns |  12.626 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 2.2 |  10.868 ns | 0.2260 ns | 0.2114 ns |  10.842 ns |  0.86 |    0.02 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 3.0 |  11.033 ns | 0.1851 ns | 0.1732 ns |  11.174 ns |  0.88 |    0.02 |      - |     - |     - |         - |
                                      From_String_Null |        net461 |  11.021 ns | 0.0418 ns | 0.0370 ns |  11.031 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                                      From_String_Null |        net472 |  11.172 ns | 0.0110 ns | 0.0092 ns |  11.174 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                             From_String_Null_AsObject | .NET Core 2.0 |  11.529 ns | 0.0157 ns | 0.0147 ns |  11.529 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 2.2 |  10.478 ns | 0.0090 ns | 0.0085 ns |  10.478 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 3.0 |  11.651 ns | 0.0097 ns | 0.0091 ns |  11.652 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net461 |  11.565 ns | 0.0138 ns | 0.0115 ns |  11.565 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net472 |  11.644 ns | 0.0180 ns | 0.0160 ns |  11.641 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                     From_String_Empty | .NET Core 2.0 |  11.515 ns | 0.0142 ns | 0.0133 ns |  11.513 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 2.2 |   9.731 ns | 0.0100 ns | 0.0094 ns |   9.730 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 3.0 |  11.791 ns | 0.2601 ns | 0.2783 ns |  11.678 ns |  1.03 |    0.02 |      - |     - |     - |         - |
                                     From_String_Empty |        net461 |  11.369 ns | 0.0587 ns | 0.0549 ns |  11.382 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty |        net472 |  11.475 ns | 0.0161 ns | 0.0135 ns |  11.479 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                            From_String_Empty_AsObject | .NET Core 2.0 |  20.313 ns | 0.0335 ns | 0.0314 ns |  20.317 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 2.2 |  17.263 ns | 0.0208 ns | 0.0195 ns |  17.263 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 3.0 |  20.716 ns | 0.4387 ns | 1.2657 ns |  21.117 ns |  0.91 |    0.11 |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net461 |  23.594 ns | 0.0271 ns | 0.0240 ns |  23.592 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net472 |  23.185 ns | 0.0809 ns | 0.0717 ns |  23.163 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                           From_UShort | .NET Core 2.0 |  23.114 ns | 0.0420 ns | 0.0393 ns |  23.111 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 2.2 |  21.349 ns | 0.0157 ns | 0.0147 ns |  21.344 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 3.0 |  12.886 ns | 0.0561 ns | 0.0525 ns |  12.869 ns |  0.56 |    0.00 |      - |     - |     - |         - |
                                           From_UShort |        net461 |  29.330 ns | 0.0582 ns | 0.0545 ns |  29.326 ns |  1.27 |    0.00 |      - |     - |     - |         - |
                                           From_UShort |        net472 |  22.686 ns | 0.0255 ns | 0.0239 ns |  22.685 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                  From_UShort_AsObject | .NET Core 2.0 |  31.269 ns | 0.0417 ns | 0.0391 ns |  31.256 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 2.2 |  28.322 ns | 0.0230 ns | 0.0192 ns |  28.319 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 3.0 |  27.240 ns | 0.0326 ns | 0.0305 ns |  27.239 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net461 |  37.210 ns | 0.1063 ns | 0.0942 ns |  37.194 ns |  1.19 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net472 |  34.272 ns | 0.0322 ns | 0.0269 ns |  34.276 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                        From_UShort_Nullable_WithValue | .NET Core 2.0 |  26.039 ns | 0.0369 ns | 0.0327 ns |  26.024 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 2.2 |  23.863 ns | 0.0239 ns | 0.0212 ns |  23.862 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 3.0 |  13.672 ns | 0.0234 ns | 0.0207 ns |  13.669 ns |  0.53 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net461 |  28.259 ns | 0.0329 ns | 0.0275 ns |  28.259 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net472 |  26.287 ns | 0.0411 ns | 0.0384 ns |  26.302 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.0 |  31.454 ns | 0.0394 ns | 0.0349 ns |  31.446 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.2 |  28.414 ns | 0.0300 ns | 0.0250 ns |  28.410 ns |  0.90 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 3.0 |  27.205 ns | 0.0415 ns | 0.0388 ns |  27.202 ns |  0.86 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net461 |  35.598 ns | 0.0474 ns | 0.0443 ns |  35.592 ns |  1.13 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net472 |  34.057 ns | 0.0479 ns | 0.0448 ns |  34.038 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                          From_UShort_Nullable_NoValue | .NET Core 2.0 |  11.619 ns | 0.0153 ns | 0.0127 ns |  11.618 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 2.2 |  10.124 ns | 0.0113 ns | 0.0105 ns |  10.125 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 3.0 |   7.256 ns | 0.4369 ns | 0.7419 ns |   6.841 ns |  0.69 |    0.07 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net461 |  12.475 ns | 0.0145 ns | 0.0129 ns |  12.472 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net472 |  10.552 ns | 0.0138 ns | 0.0122 ns |  10.552 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.0 |  11.465 ns | 0.0096 ns | 0.0090 ns |  11.462 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.2 |  10.487 ns | 0.0113 ns | 0.0095 ns |  10.484 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 3.0 |  11.711 ns | 0.0370 ns | 0.0346 ns |  11.702 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net461 |  13.842 ns | 0.1037 ns | 0.0970 ns |  13.861 ns |  1.21 |    0.01 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net472 |  13.455 ns | 0.0612 ns | 0.0573 ns |  13.486 ns |  1.17 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                             From_UInt | .NET Core 2.0 |  24.473 ns | 0.0451 ns | 0.0376 ns |  24.486 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 2.2 |  21.384 ns | 0.0299 ns | 0.0280 ns |  21.376 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 3.0 |  12.704 ns | 0.0125 ns | 0.0117 ns |  12.706 ns |  0.52 |    0.00 |      - |     - |     - |         - |
                                             From_UInt |        net461 |  27.311 ns | 0.0283 ns | 0.0237 ns |  27.317 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                             From_UInt |        net472 |  24.834 ns | 0.0172 ns | 0.0152 ns |  24.833 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                    From_UInt_AsObject | .NET Core 2.0 |  32.642 ns | 0.0298 ns | 0.0264 ns |  32.642 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 2.2 |  27.850 ns | 0.0162 ns | 0.0136 ns |  27.852 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 3.0 |  27.783 ns | 0.0343 ns | 0.0321 ns |  27.786 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net461 |  37.493 ns | 0.0942 ns | 0.0882 ns |  37.509 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net472 |  36.420 ns | 0.1207 ns | 0.1070 ns |  36.392 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                          From_UInt_Nullable_WithValue | .NET Core 2.0 |  25.826 ns | 0.0247 ns | 0.0219 ns |  25.822 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 2.2 |  24.215 ns | 0.0197 ns | 0.0184 ns |  24.216 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 3.0 |  13.552 ns | 0.0173 ns | 0.0162 ns |  13.550 ns |  0.52 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net461 |  34.282 ns | 0.2108 ns | 0.1972 ns |  34.359 ns |  1.33 |    0.01 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net472 |  26.635 ns | 0.0243 ns | 0.0227 ns |  26.632 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.0 |  33.362 ns | 0.0548 ns | 0.0486 ns |  33.367 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.2 |  27.698 ns | 0.0370 ns | 0.0328 ns |  27.699 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 3.0 |  27.907 ns | 0.0165 ns | 0.0146 ns |  27.906 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net461 |  36.608 ns | 0.0449 ns | 0.0398 ns |  36.602 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net472 |  34.556 ns | 0.0523 ns | 0.0408 ns |  34.554 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                            From_UInt_Nullable_NoValue | .NET Core 2.0 |  11.657 ns | 0.0117 ns | 0.0103 ns |  11.654 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 2.2 |  10.035 ns | 0.0147 ns | 0.0130 ns |  10.032 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 3.0 |   6.836 ns | 0.0095 ns | 0.0084 ns |   6.833 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net461 |  12.099 ns | 0.0135 ns | 0.0120 ns |  12.097 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net472 |  10.928 ns | 0.0131 ns | 0.0116 ns |  10.926 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.0 |  12.415 ns | 0.0084 ns | 0.0066 ns |  12.414 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.2 |  11.488 ns | 0.0782 ns | 0.0732 ns |  11.523 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 3.0 |  11.318 ns | 0.3402 ns | 0.4541 ns |  11.072 ns |  0.93 |    0.04 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net461 |  11.569 ns | 0.0116 ns | 0.0108 ns |  11.567 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net472 |  12.183 ns | 0.0170 ns | 0.0159 ns |  12.180 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                            From_ULong | .NET Core 2.0 |  27.501 ns | 0.0184 ns | 0.0163 ns |  27.503 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 2.2 |  25.016 ns | 0.0209 ns | 0.0196 ns |  25.019 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 3.0 |  13.488 ns | 0.0098 ns | 0.0087 ns |  13.489 ns |  0.49 |    0.00 |      - |     - |     - |         - |
                                            From_ULong |        net461 |  30.786 ns | 0.0407 ns | 0.0381 ns |  30.780 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                            From_ULong |        net472 |  25.822 ns | 0.0559 ns | 0.0523 ns |  25.837 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                   From_ULong_AsObject | .NET Core 2.0 |  33.714 ns | 0.0828 ns | 0.0775 ns |  33.728 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 2.2 |  29.871 ns | 0.0258 ns | 0.0215 ns |  29.875 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 3.0 |  28.111 ns | 0.0691 ns | 0.0540 ns |  28.126 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net461 |  37.479 ns | 0.1911 ns | 0.1596 ns |  37.549 ns |  1.11 |    0.01 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net472 |  35.408 ns | 0.0396 ns | 0.0371 ns |  35.399 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                         From_ULong_Nullable_WithValue | .NET Core 2.0 |  29.499 ns | 0.0254 ns | 0.0238 ns |  29.498 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 2.2 |  29.304 ns | 0.1779 ns | 0.1664 ns |  29.200 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 3.0 |  15.763 ns | 0.0221 ns | 0.0196 ns |  15.757 ns |  0.53 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net461 |  32.692 ns | 0.0610 ns | 0.0571 ns |  32.683 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net472 |  29.843 ns | 0.0405 ns | 0.0317 ns |  29.845 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.0 |  33.493 ns | 0.1730 ns | 0.1618 ns |  33.405 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.2 |  28.528 ns | 0.0393 ns | 0.0328 ns |  28.536 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 3.0 |  29.188 ns | 0.3562 ns | 0.3332 ns |  29.317 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net461 |  37.747 ns | 0.1400 ns | 0.1241 ns |  37.796 ns |  1.13 |    0.01 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net472 |  37.187 ns | 0.0431 ns | 0.0403 ns |  37.198 ns |  1.11 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                           From_ULong_Nullable_NoValue | .NET Core 2.0 |  12.439 ns | 0.0132 ns | 0.0123 ns |  12.443 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 2.2 |  11.317 ns | 0.0792 ns | 0.0741 ns |  11.275 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 3.0 |   7.848 ns | 0.0138 ns | 0.0108 ns |   7.848 ns |  0.63 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net461 |  13.911 ns | 0.0108 ns | 0.0095 ns |  13.913 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net472 |  12.779 ns | 0.0164 ns | 0.0145 ns |  12.777 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.0 |  12.417 ns | 0.0127 ns | 0.0113 ns |  12.418 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.2 |  10.395 ns | 0.0135 ns | 0.0126 ns |  10.390 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 3.0 |  12.118 ns | 0.0950 ns | 0.0889 ns |  12.180 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net461 |  13.541 ns | 0.0257 ns | 0.0241 ns |  13.539 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net472 |  11.611 ns | 0.0145 ns | 0.0136 ns |  11.609 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                       From_NullObject | .NET Core 2.0 |  11.533 ns | 0.0132 ns | 0.0124 ns |  11.535 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 2.2 |  10.478 ns | 0.0664 ns | 0.0621 ns |  10.440 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 3.0 |  11.656 ns | 0.0118 ns | 0.0110 ns |  11.656 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject |        net461 |  11.584 ns | 0.0153 ns | 0.0143 ns |  11.585 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject |        net472 |  13.657 ns | 0.0217 ns | 0.0192 ns |  13.655 ns |  1.18 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                           From_DBNull | .NET Core 2.0 |  11.649 ns | 0.0159 ns | 0.0141 ns |  11.650 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 2.2 |  10.413 ns | 0.0175 ns | 0.0136 ns |  10.411 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 3.0 |  12.227 ns | 0.6708 ns | 0.7985 ns |  11.783 ns |  1.07 |    0.08 |      - |     - |     - |         - |
                                           From_DBNull |        net461 |  13.700 ns | 0.0119 ns | 0.0112 ns |  13.704 ns |  1.18 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull |        net472 |  11.813 ns | 0.0217 ns | 0.0203 ns |  11.811 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                  From_DBNull_AsObject | .NET Core 2.0 |  11.580 ns | 0.0116 ns | 0.0108 ns |  11.583 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 2.2 |  10.670 ns | 0.0121 ns | 0.0113 ns |  10.674 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 3.0 |  11.046 ns | 0.0089 ns | 0.0079 ns |  11.046 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net461 |  11.643 ns | 0.0536 ns | 0.0501 ns |  11.622 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net472 |  12.760 ns | 0.0134 ns | 0.0105 ns |  12.760 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                 From_ConvertibleClass | .NET Core 2.0 |  30.894 ns | 0.0892 ns | 0.0834 ns |  30.869 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 2.2 |  24.769 ns | 0.1002 ns | 0.0937 ns |  24.724 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 3.0 |  23.327 ns | 0.0293 ns | 0.0245 ns |  23.326 ns |  0.76 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net461 |  38.896 ns | 0.0475 ns | 0.0421 ns |  38.894 ns |  1.26 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net472 |  37.570 ns | 0.0608 ns | 0.0569 ns |  37.557 ns |  1.22 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                        From_ConvertibleClass_AsObject | .NET Core 2.0 |  30.860 ns | 0.0349 ns | 0.0326 ns |  30.859 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 2.2 |  27.546 ns | 0.0677 ns | 0.0601 ns |  27.553 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 3.0 |  25.727 ns | 0.0446 ns | 0.0395 ns |  25.718 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net461 |  35.395 ns | 0.0746 ns | 0.0697 ns |  35.398 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net472 |  34.087 ns | 0.0395 ns | 0.0369 ns |  34.080 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                         From_ConvertibleClass_NoValue | .NET Core 2.0 |  12.224 ns | 0.0091 ns | 0.0085 ns |  12.223 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 2.2 |  10.365 ns | 0.0110 ns | 0.0103 ns |  10.365 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 3.0 |  11.301 ns | 0.1644 ns | 0.1538 ns |  11.377 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net461 |  11.566 ns | 0.0147 ns | 0.0137 ns |  11.562 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net472 |  13.420 ns | 0.0180 ns | 0.0140 ns |  13.417 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.0 |  11.471 ns | 0.0095 ns | 0.0089 ns |  11.471 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.2 |  11.484 ns | 0.0681 ns | 0.0637 ns |  11.518 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 3.0 |  11.653 ns | 0.0246 ns | 0.0205 ns |  11.648 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net461 |  13.317 ns | 0.0180 ns | 0.0168 ns |  13.312 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net472 |  13.425 ns | 0.0187 ns | 0.0175 ns |  13.426 ns |  1.17 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                              From_NonConvertibleClass | .NET Core 2.0 |  23.646 ns | 0.0726 ns | 0.0644 ns |  23.658 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 2.2 |  24.651 ns | 0.0201 ns | 0.0188 ns |  24.649 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 3.0 |  20.450 ns | 0.0183 ns | 0.0162 ns |  20.446 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net461 |  26.113 ns | 0.0304 ns | 0.0284 ns |  26.101 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net472 |  25.902 ns | 0.1025 ns | 0.0856 ns |  25.927 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                     From_NonConvertibleClass_AsObject | .NET Core 2.0 |  30.741 ns | 0.0580 ns | 0.0514 ns |  30.731 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 2.2 |  26.096 ns | 0.0248 ns | 0.0232 ns |  26.096 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 3.0 |  23.587 ns | 0.0361 ns | 0.0338 ns |  23.587 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net461 |  32.376 ns | 0.0397 ns | 0.0372 ns |  32.375 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net472 |  32.284 ns | 0.0397 ns | 0.0310 ns |  32.279 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                      From_NonConvertibleClass_NoValue | .NET Core 2.0 |  11.363 ns | 0.0109 ns | 0.0102 ns |  11.364 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 2.2 |  10.480 ns | 0.0341 ns | 0.0302 ns |  10.486 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 3.0 |  11.449 ns | 0.2248 ns | 0.2103 ns |  11.602 ns |  1.01 |    0.02 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net461 |  11.557 ns | 0.0158 ns | 0.0148 ns |  11.559 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net472 |  12.950 ns | 0.0595 ns | 0.0556 ns |  12.921 ns |  1.14 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.0 |  12.416 ns | 0.0149 ns | 0.0132 ns |  12.414 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.2 |  11.001 ns | 0.0128 ns | 0.0119 ns |  11.000 ns |  0.89 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 3.0 |  11.878 ns | 0.9146 ns | 1.3406 ns |  11.138 ns |  1.02 |    0.13 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net461 |  11.604 ns | 0.0473 ns | 0.0442 ns |  11.580 ns |  0.93 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net472 |  13.381 ns | 0.0086 ns | 0.0076 ns |  13.382 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                From_ConvertibleStruct | .NET Core 2.0 |  34.495 ns | 0.0679 ns | 0.0635 ns |  34.482 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 2.2 |  29.751 ns | 0.1073 ns | 0.0896 ns |  29.727 ns |  0.86 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 3.0 |  18.917 ns | 0.0497 ns | 0.0465 ns |  18.922 ns |  0.55 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net461 |  36.581 ns | 0.0838 ns | 0.0784 ns |  36.623 ns |  1.06 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net472 |  35.180 ns | 0.0428 ns | 0.0401 ns |  35.186 ns |  1.02 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                       From_ConvertibleStruct_AsObject | .NET Core 2.0 |  30.688 ns | 0.1351 ns | 0.1198 ns |  30.665 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 2.2 |  27.229 ns | 0.0254 ns | 0.0238 ns |  27.220 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 3.0 |  27.092 ns | 0.0539 ns | 0.0504 ns |  27.075 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net461 |  36.313 ns | 0.0576 ns | 0.0539 ns |  36.307 ns |  1.18 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net472 |  34.508 ns | 0.0746 ns | 0.0662 ns |  34.515 ns |  1.12 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.0 |  33.414 ns | 0.0660 ns | 0.0585 ns |  33.395 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.2 |  31.059 ns | 0.0338 ns | 0.0299 ns |  31.054 ns |  0.93 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 3.0 |  19.768 ns | 0.0499 ns | 0.0467 ns |  19.765 ns |  0.59 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net461 |  38.089 ns | 0.1212 ns | 0.1075 ns |  38.100 ns |  1.14 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net472 |  35.146 ns | 0.0881 ns | 0.0781 ns |  35.131 ns |  1.05 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 |  30.454 ns | 0.0357 ns | 0.0316 ns |  30.461 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 |  27.491 ns | 0.0374 ns | 0.0350 ns |  27.484 ns |  0.90 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 |  27.140 ns | 0.0524 ns | 0.0490 ns |  27.136 ns |  0.89 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net461 |  36.389 ns | 0.0469 ns | 0.0439 ns |  36.380 ns |  1.19 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net472 |  33.924 ns | 0.0555 ns | 0.0519 ns |  33.931 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.0 |  11.757 ns | 0.0289 ns | 0.0270 ns |  11.759 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.2 |  10.102 ns | 0.0104 ns | 0.0092 ns |  10.101 ns |  0.86 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 3.0 |   6.614 ns | 0.0089 ns | 0.0084 ns |   6.613 ns |  0.56 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net461 |  11.998 ns | 0.0079 ns | 0.0066 ns |  11.998 ns |  1.02 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net472 |  10.630 ns | 0.0163 ns | 0.0127 ns |  10.631 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 |  13.382 ns | 0.0241 ns | 0.0225 ns |  13.377 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 |  10.490 ns | 0.0690 ns | 0.0646 ns |  10.452 ns |  0.78 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 |  11.659 ns | 0.0111 ns | 0.0099 ns |  11.659 ns |  0.87 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net461 |  13.335 ns | 0.0236 ns | 0.0221 ns |  13.333 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net472 |  11.875 ns | 0.0206 ns | 0.0193 ns |  11.877 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                             From_NonConvertibleStruct | .NET Core 2.0 |  25.565 ns | 0.0295 ns | 0.0262 ns |  25.562 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 2.2 |  23.101 ns | 0.0274 ns | 0.0256 ns |  23.096 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 3.0 |  13.415 ns | 0.0172 ns | 0.0134 ns |  13.415 ns |  0.52 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net461 |  27.087 ns | 0.0242 ns | 0.0226 ns |  27.087 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net472 |  24.929 ns | 0.0200 ns | 0.0167 ns |  24.930 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.0 |  32.850 ns | 0.0172 ns | 0.0143 ns |  32.846 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.2 |  25.151 ns | 0.0220 ns | 0.0183 ns |  25.146 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 3.0 |  23.645 ns | 0.0293 ns | 0.0274 ns |  23.640 ns |  0.72 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net461 |  31.617 ns | 0.0388 ns | 0.0344 ns |  31.622 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net472 |  30.274 ns | 0.0440 ns | 0.0390 ns |  30.274 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.0 |  24.677 ns | 0.0198 ns | 0.0165 ns |  24.676 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.2 |  24.755 ns | 0.0233 ns | 0.0218 ns |  24.758 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 3.0 |  14.274 ns | 0.0099 ns | 0.0077 ns |  14.273 ns |  0.58 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net461 |  27.747 ns | 0.0253 ns | 0.0237 ns |  27.747 ns |  1.12 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net472 |  24.887 ns | 0.1497 ns | 0.1401 ns |  24.956 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 |  30.117 ns | 0.0326 ns | 0.0305 ns |  30.123 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 |  25.118 ns | 0.0221 ns | 0.0207 ns |  25.118 ns |  0.83 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 |  23.711 ns | 0.0365 ns | 0.0323 ns |  23.701 ns |  0.79 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net461 |  33.615 ns | 0.0980 ns | 0.0869 ns |  33.628 ns |  1.12 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net472 |  31.647 ns | 0.0447 ns | 0.0418 ns |  31.654 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.0 |  11.666 ns | 0.0144 ns | 0.0127 ns |  11.664 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.2 |  10.136 ns | 0.0712 ns | 0.0666 ns |  10.156 ns |  0.87 |    0.01 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 3.0 |   9.362 ns | 0.2158 ns | 0.6158 ns |   9.520 ns |  0.72 |    0.11 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net461 |  12.644 ns | 0.0168 ns | 0.0157 ns |  12.639 ns |  1.08 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net472 |  10.685 ns | 0.0535 ns | 0.0500 ns |  10.677 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 |  12.432 ns | 0.0560 ns | 0.0524 ns |  12.414 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 |  10.415 ns | 0.0184 ns | 0.0163 ns |  10.415 ns |  0.84 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 |  11.583 ns | 0.0620 ns | 0.0580 ns |  11.551 ns |  0.93 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net461 |  12.431 ns | 0.0171 ns | 0.0160 ns |  12.426 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net472 |  13.070 ns | 0.0110 ns | 0.0103 ns |  13.069 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                             From_Enum | .NET Core 2.0 |  11.630 ns | 0.0132 ns | 0.0123 ns |  11.631 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 2.2 |  10.045 ns | 0.0113 ns | 0.0106 ns |  10.041 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 3.0 |   6.637 ns | 0.0106 ns | 0.0094 ns |   6.637 ns |  0.57 |    0.00 |      - |     - |     - |         - |
                                             From_Enum |        net461 |  11.705 ns | 0.0152 ns | 0.0119 ns |  11.704 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                             From_Enum |        net472 |  12.019 ns | 0.0080 ns | 0.0075 ns |  12.018 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                    From_Enum_AsObject | .NET Core 2.0 |  12.193 ns | 0.0189 ns | 0.0158 ns |  12.191 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Enum_AsObject | .NET Core 2.2 |  11.246 ns | 0.0777 ns | 0.0727 ns |  11.283 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                                    From_Enum_AsObject | .NET Core 3.0 |  12.001 ns | 0.0121 ns | 0.0101 ns |  12.001 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                    From_Enum_AsObject |        net461 |  13.826 ns | 0.0173 ns | 0.0153 ns |  13.825 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                    From_Enum_AsObject |        net472 |  12.411 ns | 0.0379 ns | 0.0354 ns |  12.415 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                          From_Enum_Nullable_WithValue | .NET Core 2.0 |  12.447 ns | 0.0116 ns | 0.0109 ns |  12.445 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 2.2 |  10.187 ns | 0.0112 ns | 0.0104 ns |  10.189 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 3.0 |   6.654 ns | 0.0237 ns | 0.0198 ns |   6.657 ns |  0.53 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net461 |  10.947 ns | 0.1052 ns | 0.0933 ns |  10.931 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net472 |  10.490 ns | 0.0158 ns | 0.0140 ns |  10.492 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.0 |  12.148 ns | 0.0074 ns | 0.0066 ns |  12.148 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.2 |  11.028 ns | 0.0636 ns | 0.0595 ns |  10.997 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 3.0 |  12.018 ns | 0.0134 ns | 0.0125 ns |  12.015 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                 From_Enum_Nullable_WithValue_AsObject |        net461 |  12.085 ns | 0.0152 ns | 0.0142 ns |  12.086 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                 From_Enum_Nullable_WithValue_AsObject |        net472 |  14.206 ns | 0.0133 ns | 0.0125 ns |  14.208 ns |  1.17 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                            From_Enum_Nullable_NoValue | .NET Core 2.0 |  12.301 ns | 0.0203 ns | 0.0190 ns |  12.302 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 2.2 |   9.971 ns | 0.0115 ns | 0.0096 ns |   9.970 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 3.0 |   6.868 ns | 0.0108 ns | 0.0095 ns |   6.868 ns |  0.56 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net461 |  10.540 ns | 0.0241 ns | 0.0214 ns |  10.544 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net472 |  11.716 ns | 0.0155 ns | 0.0145 ns |  11.721 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.0 |  11.439 ns | 0.0144 ns | 0.0127 ns |  11.439 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.2 |  10.470 ns | 0.0095 ns | 0.0080 ns |  10.472 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 3.0 |  12.087 ns | 0.2579 ns | 0.2970 ns |  12.296 ns |  1.05 |    0.03 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net461 |  11.589 ns | 0.0138 ns | 0.0129 ns |  11.586 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net472 |  12.813 ns | 0.0104 ns | 0.0098 ns |  12.812 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                      From_ParentClass | .NET Core 2.0 |  22.769 ns | 0.0215 ns | 0.0179 ns |  22.773 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 2.2 |  20.932 ns | 0.0265 ns | 0.0248 ns |  20.931 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 3.0 |  20.232 ns | 0.0337 ns | 0.0316 ns |  20.226 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass |        net461 |  26.408 ns | 0.0621 ns | 0.0581 ns |  26.423 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass |        net472 |  28.193 ns | 0.0231 ns | 0.0216 ns |  28.200 ns |  1.24 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                             From_ParentClass_AsObject | .NET Core 2.0 |  30.063 ns | 0.0573 ns | 0.0536 ns |  30.052 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 2.2 |  25.585 ns | 0.0263 ns | 0.0246 ns |  25.587 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 3.0 |  24.175 ns | 0.0566 ns | 0.0502 ns |  24.185 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net461 |  33.776 ns | 0.1005 ns | 0.0940 ns |  33.748 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net472 |  32.510 ns | 0.0558 ns | 0.0495 ns |  32.505 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                              From_ParentClass_NoValue | .NET Core 2.0 |  12.303 ns | 0.0108 ns | 0.0101 ns |  12.304 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 2.2 |  10.404 ns | 0.0151 ns | 0.0126 ns |  10.405 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 3.0 |  11.822 ns | 0.0463 ns | 0.0434 ns |  11.808 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net461 |  11.563 ns | 0.0148 ns | 0.0138 ns |  11.563 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net472 |  13.888 ns | 0.0169 ns | 0.0150 ns |  13.887 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.0 |  12.504 ns | 0.0166 ns | 0.0147 ns |  12.502 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.2 |  11.506 ns | 0.0136 ns | 0.0120 ns |  11.508 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 3.0 |  11.754 ns | 0.0280 ns | 0.0248 ns |  11.759 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net461 |  13.299 ns | 0.0127 ns | 0.0119 ns |  13.299 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net472 |  12.770 ns | 0.0103 ns | 0.0092 ns |  12.771 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                     From_ParentStruct | .NET Core 2.0 |  94.932 ns | 0.0682 ns | 0.0570 ns |  94.919 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 2.2 |  90.520 ns | 0.0842 ns | 0.0788 ns |  90.528 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 3.0 |  86.545 ns | 0.3703 ns | 0.3463 ns |  86.670 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct |        net461 |  94.407 ns | 0.0702 ns | 0.0622 ns |  94.414 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct |        net472 | 101.493 ns | 0.0846 ns | 0.0750 ns | 101.485 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                            From_ParentStruct_AsObject | .NET Core 2.0 |  30.094 ns | 0.1604 ns | 0.1501 ns |  29.996 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 2.2 |  25.502 ns | 0.0271 ns | 0.0241 ns |  25.505 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 3.0 |  24.746 ns | 0.0369 ns | 0.0308 ns |  24.747 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net461 |  33.976 ns | 0.0851 ns | 0.0796 ns |  33.982 ns |  1.13 |    0.01 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net472 |  33.027 ns | 0.0343 ns | 0.0304 ns |  33.028 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.0 | 100.166 ns | 0.2311 ns | 0.2162 ns | 100.176 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.2 |  88.741 ns | 0.1317 ns | 0.1232 ns |  88.756 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 3.0 |  83.421 ns | 0.1189 ns | 0.0928 ns |  83.409 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue |        net461 |  94.692 ns | 0.1215 ns | 0.1077 ns |  94.721 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue |        net472 |  96.146 ns | 0.0808 ns | 0.0755 ns |  96.149 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.0 |  29.843 ns | 0.0676 ns | 0.0599 ns |  29.829 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.2 |  25.508 ns | 0.0239 ns | 0.0224 ns |  25.503 ns |  0.85 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 3.0 |  24.255 ns | 0.0215 ns | 0.0191 ns |  24.253 ns |  0.81 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net461 |  32.082 ns | 0.0480 ns | 0.0426 ns |  32.080 ns |  1.08 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net472 |  32.548 ns | 0.0445 ns | 0.0416 ns |  32.565 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.0 |  58.797 ns | 0.0594 ns | 0.0555 ns |  58.803 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.2 |  53.332 ns | 0.0539 ns | 0.0504 ns |  53.317 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 3.0 |  54.557 ns | 1.0675 ns | 1.0485 ns |  55.322 ns |  0.93 |    0.02 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net461 |  56.103 ns | 0.0399 ns | 0.0333 ns |  56.097 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net472 |  58.363 ns | 0.0809 ns | 0.0757 ns |  58.359 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.0 |  12.414 ns | 0.0143 ns | 0.0133 ns |  12.412 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.2 |  10.456 ns | 0.0102 ns | 0.0091 ns |  10.455 ns |  0.84 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 3.0 |  11.765 ns | 0.0705 ns | 0.0659 ns |  11.807 ns |  0.95 |    0.01 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net461 |  13.316 ns | 0.0127 ns | 0.0119 ns |  13.316 ns |  1.07 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net472 |  13.483 ns | 0.0134 ns | 0.0119 ns |  13.482 ns |  1.09 |    0.00 |      - |     - |     - |         - |

Benchmarks with issues:
  ConvertTo_Enum.From_DateTime_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_Enum.From_DateTime_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_Enum.From_DateTime_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_Enum.From_DateTime_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_Enum.From_DateTime_AsObject: Job-ZVTGBZ(Toolchain=net472)
  ConvertTo_Enum.From_DateTime_Nullable_WithValue_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_Enum.From_DateTime_Nullable_WithValue_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_Enum.From_DateTime_Nullable_WithValue_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_Enum.From_DateTime_Nullable_WithValue_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_Enum.From_DateTime_Nullable_WithValue_AsObject: Job-ZVTGBZ(Toolchain=net472)
